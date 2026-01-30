using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using MimeKit.IO;
using MimeKit.Utils;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Signers;

namespace MimeKit.Cryptography;

public abstract class DkimVerifierBase
{
	private int enabledSignatureAlgorithms;

	protected IDkimPublicKeyLocator PublicKeyLocator { get; private set; }

	public int MinimumRsaKeyLength { get; set; }

	protected DkimVerifierBase(IDkimPublicKeyLocator publicKeyLocator)
	{
		if (publicKeyLocator == null)
		{
			throw new ArgumentNullException("publicKeyLocator");
		}
		PublicKeyLocator = publicKeyLocator;
		Enable(DkimSignatureAlgorithm.Ed25519Sha256);
		Enable(DkimSignatureAlgorithm.RsaSha256);
		MinimumRsaKeyLength = 1024;
	}

	public void Enable(DkimSignatureAlgorithm algorithm)
	{
		enabledSignatureAlgorithms |= 1 << (int)algorithm;
	}

	public void Disable(DkimSignatureAlgorithm algorithm)
	{
		enabledSignatureAlgorithms &= ~(1 << (int)algorithm);
	}

	public bool IsEnabled(DkimSignatureAlgorithm algorithm)
	{
		return (enabledSignatureAlgorithms & (1 << (int)algorithm)) != 0;
	}

	private static bool IsWhiteSpace(char c)
	{
		if (c != ' ')
		{
			return c == '\t';
		}
		return true;
	}

	private static bool IsAlpha(char c)
	{
		if (c < 'A' || c > 'Z')
		{
			if (c >= 'a')
			{
				return c <= 'z';
			}
			return false;
		}
		return true;
	}

	internal static Dictionary<string, string> ParseParameterTags(HeaderId header, string signature)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		StringBuilder stringBuilder = new StringBuilder();
		int i = 0;
		while (i < signature.Length)
		{
			for (; i < signature.Length && IsWhiteSpace(signature[i]); i++)
			{
			}
			if (i >= signature.Length)
			{
				break;
			}
			if (signature[i] == ';' || !IsAlpha(signature[i]))
			{
				throw new FormatException($"Malformed {header.ToHeaderName()} value.");
			}
			int num = i++;
			for (; i < signature.Length && signature[i] != '='; i++)
			{
			}
			if (i >= signature.Length)
			{
				continue;
			}
			string text = signature.Substring(num, i - num).TrimEnd();
			stringBuilder.Length = 0;
			for (i++; i < signature.Length && signature[i] != ';'; i++)
			{
				if (!IsWhiteSpace(signature[i]))
				{
					stringBuilder.Append(signature[i]);
				}
			}
			if (dictionary.ContainsKey(text))
			{
				throw new FormatException($"Malformed {header.ToHeaderName()} value: duplicate parameter '{text}'.");
			}
			dictionary.Add(text, stringBuilder.ToString());
			i++;
		}
		return dictionary;
	}

	internal static void ValidateCommonParameters(string header, IDictionary<string, string> parameters, out DkimSignatureAlgorithm algorithm, out string d, out string s, out string q, out string b)
	{
		if (!parameters.TryGetValue("a", out var value))
		{
			throw new FormatException($"Malformed {header} header: no signature algorithm parameter detected.");
		}
		switch (value.ToLowerInvariant())
		{
		case "ed25519-sha256":
			algorithm = DkimSignatureAlgorithm.Ed25519Sha256;
			break;
		case "rsa-sha256":
			algorithm = DkimSignatureAlgorithm.RsaSha256;
			break;
		case "rsa-sha1":
			algorithm = DkimSignatureAlgorithm.RsaSha1;
			break;
		default:
			throw new FormatException($"Unrecognized {header} algorithm parameter: a={value}");
		}
		if (!parameters.TryGetValue("d", out d))
		{
			throw new FormatException($"Malformed {header} header: no domain parameter detected.");
		}
		if (d.Length == 0)
		{
			throw new FormatException($"Malformed {header} header: empty domain parameter detected.");
		}
		if (!parameters.TryGetValue("s", out s))
		{
			throw new FormatException($"Malformed {header} header: no selector parameter detected.");
		}
		if (s.Length == 0)
		{
			throw new FormatException($"Malformed {header} header: empty selector parameter detected.");
		}
		if (!parameters.TryGetValue("q", out q))
		{
			q = "dns/txt";
		}
		if (!parameters.TryGetValue("b", out b))
		{
			throw new FormatException($"Malformed {header} header: no signature parameter detected.");
		}
		if (b.Length == 0)
		{
			throw new FormatException($"Malformed {header} header: empty signature parameter detected.");
		}
		if (parameters.TryGetValue("t", out var value2) && (!int.TryParse(value2, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result) || result < 0))
		{
			throw new FormatException($"Malformed {header} header: invalid timestamp parameter: t={value2}.");
		}
	}

	internal static void ValidateCommonSignatureParameters(string header, IDictionary<string, string> parameters, out DkimSignatureAlgorithm algorithm, out DkimCanonicalizationAlgorithm headerAlgorithm, out DkimCanonicalizationAlgorithm bodyAlgorithm, out string d, out string s, out string q, out string[] headers, out string bh, out string b, out int maxLength)
	{
		ValidateCommonParameters(header, parameters, out algorithm, out d, out s, out q, out b);
		if (parameters.TryGetValue("l", out var value))
		{
			if (!int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out maxLength) || maxLength < 0)
			{
				throw new FormatException($"Malformed {header} header: invalid length parameter: l={value}");
			}
		}
		else
		{
			maxLength = -1;
		}
		if (parameters.TryGetValue("c", out var value2))
		{
			string[] array = value2.ToLowerInvariant().Split('/');
			if (array.Length == 0 || array.Length > 2)
			{
				throw new FormatException($"Malformed {header} header: invalid canonicalization parameter: c={value2}");
			}
			string text = array[0];
			if (!(text == "relaxed"))
			{
				if (!(text == "simple"))
				{
					throw new FormatException($"Malformed {header} header: invalid canonicalization parameter: c={value2}");
				}
				headerAlgorithm = DkimCanonicalizationAlgorithm.Simple;
			}
			else
			{
				headerAlgorithm = DkimCanonicalizationAlgorithm.Relaxed;
			}
			if (array.Length == 2)
			{
				string text2 = array[1];
				if (!(text2 == "relaxed"))
				{
					if (!(text2 == "simple"))
					{
						throw new FormatException($"Malformed {header} header: invalid canonicalization parameter: c={value2}");
					}
					bodyAlgorithm = DkimCanonicalizationAlgorithm.Simple;
				}
				else
				{
					bodyAlgorithm = DkimCanonicalizationAlgorithm.Relaxed;
				}
			}
			else
			{
				bodyAlgorithm = DkimCanonicalizationAlgorithm.Simple;
			}
		}
		else
		{
			headerAlgorithm = DkimCanonicalizationAlgorithm.Simple;
			bodyAlgorithm = DkimCanonicalizationAlgorithm.Simple;
		}
		if (!parameters.TryGetValue("h", out var value3))
		{
			throw new FormatException($"Malformed {header} header: no signed header parameter detected.");
		}
		headers = value3.Split(':');
		if (!parameters.TryGetValue("bh", out bh))
		{
			throw new FormatException($"Malformed {header} header: no body hash parameter detected.");
		}
	}

	internal static void WriteHeaderRelaxed(FormatOptions options, Stream stream, Header header, bool isDkimSignature)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(header.Field.ToLowerInvariant());
		byte[] rawValue = header.GetRawValue(options);
		int i = 0;
		stream.Write(bytes, 0, bytes.Length);
		stream.WriteByte(58);
		for (; i < rawValue.Length && rawValue[i].IsWhitespace(); i++)
		{
		}
		while (i < rawValue.Length)
		{
			int num = i;
			for (; i < rawValue.Length && rawValue[i].IsWhitespace(); i++)
			{
			}
			if (i >= rawValue.Length)
			{
				break;
			}
			if (i > num)
			{
				stream.WriteByte(32);
			}
			num = i;
			for (; i < rawValue.Length && !rawValue[i].IsWhitespace(); i++)
			{
			}
			if (i > num)
			{
				stream.Write(rawValue, num, i - num);
			}
		}
		if (!isDkimSignature)
		{
			stream.Write(options.NewLineBytes, 0, options.NewLineBytes.Length);
		}
	}

	internal static void WriteHeaderSimple(FormatOptions options, Stream stream, Header header, bool isDkimSignature)
	{
		byte[] rawValue = header.GetRawValue(options);
		int num = rawValue.Length;
		if (isDkimSignature && num > 0 && rawValue[num - 1] == 10)
		{
			num--;
			if (num > 0 && rawValue[num - 1] == 13)
			{
				num--;
			}
		}
		stream.Write(header.RawField, 0, header.RawField.Length);
		stream.Write(Header.Colon, 0, Header.Colon.Length);
		stream.Write(rawValue, 0, num);
	}

	internal virtual ISigner CreateVerifyContext(DkimSignatureAlgorithm algorithm, AsymmetricKeyParameter key)
	{
		ISigner signer = algorithm switch
		{
			DkimSignatureAlgorithm.RsaSha1 => new RsaDigestSigner(new Sha1Digest()), 
			DkimSignatureAlgorithm.RsaSha256 => new RsaDigestSigner(new Sha256Digest()), 
			DkimSignatureAlgorithm.Ed25519Sha256 => new Ed25519DigestSigner(new Sha256Digest()), 
			_ => throw new NotSupportedException($"{algorithm} is not supported."), 
		};
		signer.Init(key.IsPrivate, key);
		return signer;
	}

	internal static void WriteHeaders(FormatOptions options, MimeMessage message, IList<string> fields, DkimCanonicalizationAlgorithm headerCanonicalizationAlgorithm, Stream stream)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>(StringComparer.Ordinal);
		for (int i = 0; i < fields.Count; i++)
		{
			HeaderList headerList = (fields[i].StartsWith("Content-", StringComparison.OrdinalIgnoreCase) ? message.Body.Headers : message.Headers);
			string text = fields[i].ToLowerInvariant();
			int num = 0;
			if (!dictionary.TryGetValue(text, out var value))
			{
				value = 0;
			}
			int num2 = headerList.LastIndexOf(text);
			while (num < value && --num2 >= 0)
			{
				if (headerList[num2].Field.Equals(text, StringComparison.OrdinalIgnoreCase))
				{
					num++;
				}
			}
			if (num2 >= 0)
			{
				Header header = headerList[num2];
				if (headerCanonicalizationAlgorithm == DkimCanonicalizationAlgorithm.Relaxed)
				{
					WriteHeaderRelaxed(options, stream, header, isDkimSignature: false);
				}
				else
				{
					WriteHeaderSimple(options, stream, header, isDkimSignature: false);
				}
				value = (dictionary[text] = value + 1);
			}
		}
	}

	internal static Header GetSignedSignatureHeader(Header header)
	{
		byte[] array = (byte[])header.RawValue.Clone();
		int newSize = 0;
		int i = 0;
		while (true)
		{
			if (i < array.Length && array[i].IsWhitespace())
			{
				i++;
				continue;
			}
			if (i + 2 < array.Length)
			{
				char c = (char)array[i++];
				for (; i < array.Length && array[i].IsWhitespace(); i++)
				{
				}
				if (i < array.Length && array[i] == 61 && c == 'b')
				{
					newSize = ++i;
					for (; i < array.Length && array[i] != 59; i++)
					{
					}
					if (i == array.Length && array[i - 1] == 10)
					{
						i--;
						if (array[i - 1] == 13)
						{
							i--;
						}
					}
					break;
				}
			}
			for (; i < array.Length && array[i] != 59; i++)
			{
			}
			if (i < array.Length)
			{
				i++;
			}
			if (i >= array.Length)
			{
				break;
			}
		}
		if (i == array.Length)
		{
			throw new FormatException($"Malformed {header.Id.ToHeaderName()} header: missing signature parameter.");
		}
		while (i < array.Length)
		{
			array[newSize++] = array[i++];
		}
		Array.Resize(ref array, newSize);
		return new Header(header.Options, header.RawField, array, invalid: false);
	}

	protected bool VerifyBodyHash(FormatOptions options, MimeMessage message, DkimSignatureAlgorithm signatureAlgorithm, DkimCanonicalizationAlgorithm canonicalizationAlgorithm, int maxLength, string bodyHash)
	{
		string text = Convert.ToBase64String(message.HashBody(options, signatureAlgorithm, canonicalizationAlgorithm, maxLength));
		return text == bodyHash;
	}

	protected bool VerifySignature(FormatOptions options, MimeMessage message, Header dkimSignature, DkimSignatureAlgorithm signatureAlgorithm, AsymmetricKeyParameter key, string[] headers, DkimCanonicalizationAlgorithm canonicalizationAlgorithm, string signature)
	{
		using DkimSignatureStream dkimSignatureStream = new DkimSignatureStream(CreateVerifyContext(signatureAlgorithm, key));
		using (FilteredStream filteredStream = new FilteredStream(dkimSignatureStream))
		{
			filteredStream.Add(options.CreateNewLineFilter());
			WriteHeaders(options, message, headers, canonicalizationAlgorithm, filteredStream);
			Header signedSignatureHeader = GetSignedSignatureHeader(dkimSignature);
			if (canonicalizationAlgorithm == DkimCanonicalizationAlgorithm.Relaxed)
			{
				WriteHeaderRelaxed(options, filteredStream, signedSignatureHeader, isDkimSignature: true);
			}
			else
			{
				WriteHeaderSimple(options, filteredStream, signedSignatureHeader, isDkimSignature: true);
			}
			filteredStream.Flush();
		}
		return dkimSignatureStream.VerifySignature(signature);
	}
}
