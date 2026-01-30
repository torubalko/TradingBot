using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;

namespace MimeKit.Cryptography;

public class DkimVerifier : DkimVerifierBase
{
	public DkimVerifier(IDkimPublicKeyLocator publicKeyLocator)
		: base(publicKeyLocator)
	{
	}

	private static void ValidateDkimSignatureParameters(IDictionary<string, string> parameters, out DkimSignatureAlgorithm algorithm, out DkimCanonicalizationAlgorithm headerAlgorithm, out DkimCanonicalizationAlgorithm bodyAlgorithm, out string d, out string s, out string q, out string[] headers, out string bh, out string b, out int maxLength)
	{
		bool flag = false;
		if (!parameters.TryGetValue("v", out var value))
		{
			throw new FormatException("Malformed DKIM-Signature header: no version parameter detected.");
		}
		if (value != "1")
		{
			throw new FormatException($"Unrecognized DKIM-Signature version: v={value}");
		}
		DkimVerifierBase.ValidateCommonSignatureParameters("DKIM-Signature", parameters, out algorithm, out headerAlgorithm, out bodyAlgorithm, out d, out s, out q, out headers, out bh, out b, out maxLength);
		for (int i = 0; i < headers.Length; i++)
		{
			if (headers[i].Equals("from", StringComparison.OrdinalIgnoreCase))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			throw new FormatException("Malformed DKIM-Signature header: From header not signed.");
		}
		if (parameters.TryGetValue("i", out var value2))
		{
			int num;
			if ((num = value2.LastIndexOf('@')) == -1)
			{
				throw new FormatException("Malformed DKIM-Signature header: no @ in the AUID value.");
			}
			string text = value2.Substring(num + 1);
			if (!text.Equals(d, StringComparison.OrdinalIgnoreCase) && !text.EndsWith("." + d, StringComparison.OrdinalIgnoreCase))
			{
				throw new FormatException("Invalid DKIM-Signature header: the domain in the AUID does not match the domain parameter.");
			}
		}
	}

	private async Task<bool> VerifyAsync(FormatOptions options, MimeMessage message, Header dkimSignature, bool doAsync, CancellationToken cancellationToken)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (dkimSignature == null)
		{
			throw new ArgumentNullException("dkimSignature");
		}
		if (dkimSignature.Id != HeaderId.DkimSignature)
		{
			throw new ArgumentException("The signature parameter MUST be a DKIM-Signature header.", "dkimSignature");
		}
		Dictionary<string, string> parameters = DkimVerifierBase.ParseParameterTags(dkimSignature.Id, dkimSignature.Value);
		ValidateDkimSignatureParameters(parameters, out var signatureAlgorithm, out var headerAlgorithm, out var bodyAlgorithm, out var d, out var s, out var q, out var headers, out var bh, out var b, out var maxLength);
		if (!IsEnabled(signatureAlgorithm))
		{
			return false;
		}
		options = options.Clone();
		options.NewLineFormat = NewLineFormat.Dos;
		if (!VerifyBodyHash(options, message, signatureAlgorithm, bodyAlgorithm, maxLength, bh))
		{
			return false;
		}
		AsymmetricKeyParameter asymmetricKeyParameter = ((!doAsync) ? base.PublicKeyLocator.LocatePublicKey(q, d, s, cancellationToken) : (await base.PublicKeyLocator.LocatePublicKeyAsync(q, d, s, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
		if (asymmetricKeyParameter is RsaKeyParameters rsaKeyParameters && rsaKeyParameters.Modulus.BitLength < base.MinimumRsaKeyLength)
		{
			return false;
		}
		return VerifySignature(options, message, dkimSignature, signatureAlgorithm, asymmetricKeyParameter, headers, headerAlgorithm, b);
	}

	public bool Verify(FormatOptions options, MimeMessage message, Header dkimSignature, CancellationToken cancellationToken = default(CancellationToken))
	{
		return VerifyAsync(options, message, dkimSignature, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public Task<bool> VerifyAsync(FormatOptions options, MimeMessage message, Header dkimSignature, CancellationToken cancellationToken = default(CancellationToken))
	{
		return VerifyAsync(options, message, dkimSignature, doAsync: true, cancellationToken);
	}

	public bool Verify(MimeMessage message, Header dkimSignature, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Verify(FormatOptions.Default, message, dkimSignature, cancellationToken);
	}

	public Task<bool> VerifyAsync(MimeMessage message, Header dkimSignature, CancellationToken cancellationToken = default(CancellationToken))
	{
		return VerifyAsync(FormatOptions.Default, message, dkimSignature, cancellationToken);
	}
}
