using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;
using MimeKit.Utils;
using Org.BouncyCastle.Crypto;

namespace MimeKit.Cryptography;

public abstract class ArcSigner : DkimSignerBase
{
	private static readonly string[] ArcShouldNotInclude = new string[7] { "return-path", "received", "comments", "keywords", "bcc", "resent-bcc", "arc-seal" };

	protected ArcSigner(string domain, string selector, DkimSignatureAlgorithm algorithm = DkimSignatureAlgorithm.RsaSha256)
		: base(domain, selector, algorithm)
	{
	}

	protected ArcSigner(AsymmetricKeyParameter key, string domain, string selector, DkimSignatureAlgorithm algorithm = DkimSignatureAlgorithm.RsaSha256)
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

	protected ArcSigner(string fileName, string domain, string selector, DkimSignatureAlgorithm algorithm = DkimSignatureAlgorithm.RsaSha256)
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

	protected ArcSigner(Stream stream, string domain, string selector, DkimSignatureAlgorithm algorithm = DkimSignatureAlgorithm.RsaSha256)
		: this(domain, selector, algorithm)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		base.PrivateKey = DkimSignerBase.LoadPrivateKey(stream);
	}

	protected abstract AuthenticationResults GenerateArcAuthenticationResults(FormatOptions options, MimeMessage message, CancellationToken cancellationToken);

	protected abstract Task<AuthenticationResults> GenerateArcAuthenticationResultsAsync(FormatOptions options, MimeMessage message, CancellationToken cancellationToken);

	protected virtual long GetTimestamp()
	{
		return (long)(DateTime.UtcNow - DateUtils.UnixEpoch).TotalSeconds;
	}

	private StringBuilder CreateArcHeaderBuilder(int instance)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("i={0}", instance.ToString(CultureInfo.InvariantCulture));
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
		return stringBuilder;
	}

	private Header GenerateArcMessageSignature(FormatOptions options, MimeMessage message, int instance, long t, IList<string> headers)
	{
		StringBuilder stringBuilder = CreateArcHeaderBuilder(instance);
		stringBuilder.AppendFormat("; d={0}; s={1}", base.Domain, base.Selector);
		stringBuilder.AppendFormat("; c={0}/{1}", base.HeaderCanonicalizationAlgorithm.ToString().ToLowerInvariant(), base.BodyCanonicalizationAlgorithm.ToString().ToLowerInvariant());
		stringBuilder.AppendFormat("; t={0}", t);
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
			header = new Header(HeaderId.ArcMessageSignature, stringBuilder.ToString());
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
		return header;
	}

	private Header GenerateArcSeal(FormatOptions options, int instance, string cv, long t, ArcHeaderSet[] sets, int count, Header aar, Header ams)
	{
		StringBuilder stringBuilder = CreateArcHeaderBuilder(instance);
		stringBuilder.AppendFormat("; cv={0}", cv);
		stringBuilder.AppendFormat("; d={0}; s={1}", base.Domain, base.Selector);
		stringBuilder.AppendFormat("; t={0}", t);
		using DkimSignatureStream dkimSignatureStream = new DkimSignatureStream(CreateSigningContext());
		Header header;
		using (FilteredStream filteredStream = new FilteredStream(dkimSignatureStream))
		{
			filteredStream.Add(options.CreateNewLineFilter());
			for (int i = 0; i < count; i++)
			{
				DkimVerifierBase.WriteHeaderRelaxed(options, filteredStream, sets[i].ArcAuthenticationResult, isDkimSignature: false);
				DkimVerifierBase.WriteHeaderRelaxed(options, filteredStream, sets[i].ArcMessageSignature, isDkimSignature: false);
				DkimVerifierBase.WriteHeaderRelaxed(options, filteredStream, sets[i].ArcSeal, isDkimSignature: false);
			}
			DkimVerifierBase.WriteHeaderRelaxed(options, filteredStream, aar, isDkimSignature: false);
			DkimVerifierBase.WriteHeaderRelaxed(options, filteredStream, ams, isDkimSignature: false);
			stringBuilder.Append("; b=");
			header = new Header(HeaderId.ArcSeal, stringBuilder.ToString());
			DkimVerifierBase.WriteHeaderRelaxed(options, filteredStream, header, isDkimSignature: true);
			filteredStream.Flush();
		}
		byte[] inArray = dkimSignatureStream.GenerateSignature();
		header.Value += Convert.ToBase64String(inArray);
		return header;
	}

	private async Task ArcSignAsync(FormatOptions options, MimeMessage message, IList<string> headers, bool doAsync, CancellationToken cancellationToken)
	{
		ArcVerifier.GetArcHeaderSets(message, throwOnError: true, out var sets, out var count, out var errors);
		int instance = count + 1;
		if (count > 0 && (errors & ArcValidationErrors.InvalidArcSealChainValidationValue) != ArcValidationErrors.None)
		{
			return;
		}
		options = options.Clone();
		options.NewLineFormat = NewLineFormat.Dos;
		options.EnsureNewLine = true;
		AuthenticationResults authenticationResults = ((!doAsync) ? GenerateArcAuthenticationResults(options, message, cancellationToken) : (await GenerateArcAuthenticationResultsAsync(options, message, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
		if (authenticationResults == null)
		{
			return;
		}
		authenticationResults.Instance = instance;
		Header header = new Header(HeaderId.ArcAuthenticationResults, authenticationResults.ToString());
		string cv = "none";
		if (count > 0)
		{
			cv = "pass";
			foreach (AuthenticationMethodResult result in authenticationResults.Results)
			{
				if (result.Method.Equals("arc", StringComparison.OrdinalIgnoreCase))
				{
					cv = result.Result;
					break;
				}
			}
		}
		long timestamp = GetTimestamp();
		Header header2 = GenerateArcMessageSignature(options, message, instance, timestamp, headers);
		Header header3 = GenerateArcSeal(options, instance, cv, timestamp, sets, count, header, header2);
		message.Headers.Insert(0, header);
		message.Headers.Insert(0, header2);
		message.Headers.Insert(0, header3);
	}

	private Task SignAsync(FormatOptions options, MimeMessage message, IList<string> headers, bool doAsync, CancellationToken cancellationToken)
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
			if (ArcShouldNotInclude.Contains(array[i]))
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
		return ArcSignAsync(options, message, array, doAsync, cancellationToken);
	}

	private Task SignAsync(FormatOptions options, MimeMessage message, IList<HeaderId> headers, bool doAsync, CancellationToken cancellationToken)
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
			if (ArcShouldNotInclude.Contains(array[i]))
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
		return ArcSignAsync(options, message, array, doAsync, cancellationToken);
	}

	public void Sign(FormatOptions options, MimeMessage message, IList<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		SignAsync(options, message, headers, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public Task SignAsync(FormatOptions options, MimeMessage message, IList<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SignAsync(options, message, headers, doAsync: true, cancellationToken);
	}

	public void Sign(MimeMessage message, IList<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		Sign(FormatOptions.Default, message, headers, cancellationToken);
	}

	public Task SignAsync(MimeMessage message, IList<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SignAsync(FormatOptions.Default, message, headers, cancellationToken);
	}

	public void Sign(FormatOptions options, MimeMessage message, IList<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		SignAsync(options, message, headers, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public Task SignAsync(FormatOptions options, MimeMessage message, IList<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SignAsync(options, message, headers, doAsync: true, cancellationToken);
	}

	public void Sign(MimeMessage message, IList<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		Sign(FormatOptions.Default, message, headers, cancellationToken);
	}

	public Task SignAsync(MimeMessage message, IList<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SignAsync(FormatOptions.Default, message, headers, cancellationToken);
	}
}
