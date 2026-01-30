using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MimeKit.IO;
using MimeKit.Utils;
using Org.BouncyCastle.Crypto;

namespace MimeKit.Cryptography;

public class DkimSigner : DkimSignerBase
{
	private static readonly string[] DkimShouldNotInclude = new string[7] { "return-path", "received", "comments", "keywords", "bcc", "resent-bcc", "dkim-signature" };

	public string AgentOrUserIdentifier { get; set; }

	public string QueryMethod { get; set; }

	protected DkimSigner(string domain, string selector, DkimSignatureAlgorithm algorithm = DkimSignatureAlgorithm.RsaSha256)
		: base(domain, selector, algorithm)
	{
	}

	public DkimSigner(AsymmetricKeyParameter key, string domain, string selector, DkimSignatureAlgorithm algorithm = DkimSignatureAlgorithm.RsaSha256)
		: this(domain, selector, algorithm)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!key.IsPrivate)
		{
			throw new ArgumentException("The key must be a private key.", "key");
		}
		base.PrivateKey = key;
	}

	public DkimSigner(string fileName, string domain, string selector, DkimSignatureAlgorithm algorithm = DkimSignatureAlgorithm.RsaSha256)
		: this(domain, selector, algorithm)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException("The file name cannot be empty.", "fileName");
		}
		using FileStream stream = File.OpenRead(fileName);
		base.PrivateKey = DkimSignerBase.LoadPrivateKey(stream);
	}

	public DkimSigner(Stream stream, string domain, string selector, DkimSignatureAlgorithm algorithm = DkimSignatureAlgorithm.RsaSha256)
		: this(domain, selector, algorithm)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		base.PrivateKey = DkimSignerBase.LoadPrivateKey(stream);
	}

	protected virtual long GetTimestamp()
	{
		return (long)(DateTime.UtcNow - DateUtils.UnixEpoch).TotalSeconds;
	}

	private void DkimSign(FormatOptions options, MimeMessage message, IList<string> headers)
	{
		StringBuilder stringBuilder = new StringBuilder("v=1");
		long timestamp = GetTimestamp();
		options = options.Clone();
		options.NewLineFormat = NewLineFormat.Dos;
		options.EnsureNewLine = true;
		switch (base.SignatureAlgorithm)
		{
		case DkimSignatureAlgorithm.Ed25519Sha256:
			stringBuilder.Append("; a=ed25519-sha256");
			break;
		case DkimSignatureAlgorithm.RsaSha256:
			stringBuilder.Append("; a=rsa-sha256");
			break;
		default:
			stringBuilder.Append("; a=rsa-sha1");
			break;
		}
		stringBuilder.AppendFormat("; d={0}; s={1}", base.Domain, base.Selector);
		stringBuilder.AppendFormat("; c={0}/{1}", base.HeaderCanonicalizationAlgorithm.ToString().ToLowerInvariant(), base.BodyCanonicalizationAlgorithm.ToString().ToLowerInvariant());
		if (!string.IsNullOrEmpty(QueryMethod))
		{
			stringBuilder.AppendFormat("; q={0}", QueryMethod);
		}
		if (!string.IsNullOrEmpty(AgentOrUserIdentifier))
		{
			stringBuilder.AppendFormat("; i={0}", AgentOrUserIdentifier);
		}
		stringBuilder.AppendFormat("; t={0}", timestamp);
		using DkimSignatureStream dkimSignatureStream = new DkimSignatureStream(CreateSigningContext());
		Header header;
		using (FilteredStream filteredStream = new FilteredStream(dkimSignatureStream))
		{
			filteredStream.Add(options.CreateNewLineFilter());
			DkimVerifierBase.WriteHeaders(options, message, headers, base.HeaderCanonicalizationAlgorithm, filteredStream);
			stringBuilder.AppendFormat("; h={0}", string.Join(":", headers.ToArray()));
			byte[] inArray = message.HashBody(options, base.SignatureAlgorithm, base.BodyCanonicalizationAlgorithm, -1);
			stringBuilder.AppendFormat("; bh={0}", Convert.ToBase64String(inArray));
			stringBuilder.Append("; b=");
			header = new Header(HeaderId.DkimSignature, stringBuilder.ToString());
			message.Headers.Insert(0, header);
			DkimCanonicalizationAlgorithm headerCanonicalizationAlgorithm = base.HeaderCanonicalizationAlgorithm;
			if (headerCanonicalizationAlgorithm == DkimCanonicalizationAlgorithm.Relaxed)
			{
				DkimVerifierBase.WriteHeaderRelaxed(options, filteredStream, header, isDkimSignature: true);
			}
			else
			{
				DkimVerifierBase.WriteHeaderSimple(options, filteredStream, header, isDkimSignature: true);
			}
			filteredStream.Flush();
		}
		byte[] inArray2 = dkimSignatureStream.GenerateSignature();
		header.Value += Convert.ToBase64String(inArray2);
	}

	public void Sign(FormatOptions options, MimeMessage message, IList<string> headers)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (headers == null)
		{
			throw new ArgumentNullException("headers");
		}
		string[] array = new string[headers.Count];
		bool flag = false;
		for (int i = 0; i < headers.Count; i++)
		{
			if (headers[i] == null)
			{
				throw new ArgumentException("The list of headers cannot contain null.", "headers");
			}
			if (headers[i].Length == 0)
			{
				throw new ArgumentException("The list of headers cannot contain empty string.", "headers");
			}
			array[i] = headers[i].ToLowerInvariant();
			if (DkimShouldNotInclude.Contains(array[i]))
			{
				throw new ArgumentException($"The list of headers to sign SHOULD NOT include the '{headers[i]}' header.", "headers");
			}
			if (array[i] == "from")
			{
				flag = true;
			}
		}
		if (!flag)
		{
			throw new ArgumentException("The list of headers to sign MUST include the 'From' header.", "headers");
		}
		DkimSign(options, message, array);
	}

	public void Sign(MimeMessage message, IList<string> headers)
	{
		Sign(FormatOptions.Default, message, headers);
	}

	public void Sign(FormatOptions options, MimeMessage message, IList<HeaderId> headers)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (headers == null)
		{
			throw new ArgumentNullException("headers");
		}
		string[] array = new string[headers.Count];
		bool flag = false;
		for (int i = 0; i < headers.Count; i++)
		{
			if (headers[i] == HeaderId.Unknown)
			{
				throw new ArgumentException("The list of headers to sign cannot include the 'Unknown' header.", "headers");
			}
			array[i] = headers[i].ToHeaderName().ToLowerInvariant();
			if (DkimShouldNotInclude.Contains(array[i]))
			{
				throw new ArgumentException($"The list of headers to sign SHOULD NOT include the '{headers[i].ToHeaderName()}' header.", "headers");
			}
			if (headers[i] == HeaderId.From)
			{
				flag = true;
			}
		}
		if (!flag)
		{
			throw new ArgumentException("The list of headers to sign MUST include the 'From' header.", "headers");
		}
		DkimSign(options, message, array);
	}

	public void Sign(MimeMessage message, IList<HeaderId> headers)
	{
		Sign(FormatOptions.Default, message, headers);
	}
}
