using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;

namespace MimeKit.Cryptography;

public class ArcVerifier : DkimVerifierBase
{
	public ArcVerifier(IDkimPublicKeyLocator publicKeyLocator)
		: base(publicKeyLocator)
	{
	}

	private static void ValidateArcMessageSignatureParameters(IDictionary<string, string> parameters, out DkimSignatureAlgorithm algorithm, out DkimCanonicalizationAlgorithm headerAlgorithm, out DkimCanonicalizationAlgorithm bodyAlgorithm, out string d, out string s, out string q, out string[] headers, out string bh, out string b, out int maxLength)
	{
		DkimVerifierBase.ValidateCommonSignatureParameters("ARC-Message-Signature", parameters, out algorithm, out headerAlgorithm, out bodyAlgorithm, out d, out s, out q, out headers, out bh, out b, out maxLength);
	}

	private static void ValidateArcSealParameters(IDictionary<string, string> parameters, out DkimSignatureAlgorithm algorithm, out string d, out string s, out string q, out string b)
	{
		DkimVerifierBase.ValidateCommonParameters("ARC-Seal", parameters, out algorithm, out d, out s, out q, out b);
		if (parameters.TryGetValue("h", out var _))
		{
			throw new FormatException("Malformed ARC-Seal header: the 'h' parameter tag is not allowed.");
		}
	}

	private async Task<bool> VerifyArcMessageSignatureAsync(FormatOptions options, MimeMessage message, Header arcSignature, Dictionary<string, string> parameters, bool doAsync, CancellationToken cancellationToken)
	{
		ValidateArcMessageSignatureParameters(parameters, out var signatureAlgorithm, out var headerAlgorithm, out var bodyAlgorithm, out var d, out var s, out var q, out var headers, out var bh, out var b, out var maxLength);
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
		return VerifySignature(options, message, arcSignature, signatureAlgorithm, asymmetricKeyParameter, headers, headerAlgorithm, b);
	}

	private async Task<bool> VerifyArcSealAsync(FormatOptions options, ArcHeaderSet[] sets, int i, bool doAsync, CancellationToken cancellationToken)
	{
		ValidateArcSealParameters(sets[i].ArcSealParameters, out var algorithm, out var d, out var s, out var q, out var b);
		if (!IsEnabled(algorithm))
		{
			return false;
		}
		AsymmetricKeyParameter asymmetricKeyParameter = ((!doAsync) ? base.PublicKeyLocator.LocatePublicKey(q, d, s, cancellationToken) : (await base.PublicKeyLocator.LocatePublicKeyAsync(q, d, s, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
		if (asymmetricKeyParameter is RsaKeyParameters rsaKeyParameters && rsaKeyParameters.Modulus.BitLength < base.MinimumRsaKeyLength)
		{
			return false;
		}
		options = options.Clone();
		options.NewLineFormat = NewLineFormat.Dos;
		using DkimSignatureStream dkimSignatureStream = new DkimSignatureStream(CreateVerifyContext(algorithm, asymmetricKeyParameter));
		using (FilteredStream filteredStream = new FilteredStream(dkimSignatureStream))
		{
			filteredStream.Add(options.CreateNewLineFilter());
			for (int j = 0; j < i; j++)
			{
				DkimVerifierBase.WriteHeaderRelaxed(options, filteredStream, sets[j].ArcAuthenticationResult, isDkimSignature: false);
				DkimVerifierBase.WriteHeaderRelaxed(options, filteredStream, sets[j].ArcMessageSignature, isDkimSignature: false);
				DkimVerifierBase.WriteHeaderRelaxed(options, filteredStream, sets[j].ArcSeal, isDkimSignature: false);
			}
			DkimVerifierBase.WriteHeaderRelaxed(options, filteredStream, sets[i].ArcAuthenticationResult, isDkimSignature: false);
			DkimVerifierBase.WriteHeaderRelaxed(options, filteredStream, sets[i].ArcMessageSignature, isDkimSignature: false);
			Header signedSignatureHeader = DkimVerifierBase.GetSignedSignatureHeader(sets[i].ArcSeal);
			DkimVerifierBase.WriteHeaderRelaxed(options, filteredStream, signedSignatureHeader, isDkimSignature: true);
			filteredStream.Flush();
		}
		return dkimSignatureStream.VerifySignature(b);
	}

	internal static ArcSignatureValidationResult GetArcHeaderSets(MimeMessage message, bool throwOnError, out ArcHeaderSet[] sets, out int count, out ArcValidationErrors errors)
	{
		errors = ArcValidationErrors.None;
		sets = new ArcHeaderSet[50];
		count = 0;
		for (int i = 0; i < message.Headers.Count; i++)
		{
			Dictionary<string, string> dictionary = null;
			Header header = message.Headers[i];
			int result = 0;
			switch (header.Id)
			{
			case HeaderId.ArcAuthenticationResults:
			{
				if (!AuthenticationResults.TryParse(header.RawValue, out var authres))
				{
					if (throwOnError)
					{
						throw new FormatException("Invalid ARC-Authentication-Results header.");
					}
					errors |= ArcValidationErrors.InvalidArcAuthenticationResults;
					break;
				}
				if (!authres.Instance.HasValue)
				{
					if (throwOnError)
					{
						throw new FormatException("Missing instance tag in ARC-Authentication-Results header.");
					}
					errors |= ArcValidationErrors.InvalidArcAuthenticationResults;
					break;
				}
				result = authres.Instance.Value;
				if (result < 1 || result > 50)
				{
					if (throwOnError)
					{
						throw new FormatException(string.Format(CultureInfo.InvariantCulture, "Invalid instance tag in ARC-Authentication-Results header: i={0}", result));
					}
					errors |= ArcValidationErrors.InvalidArcAuthenticationResults;
					result = 0;
				}
				break;
			}
			case HeaderId.ArcMessageSignature:
			case HeaderId.ArcSeal:
			{
				try
				{
					dictionary = DkimVerifierBase.ParseParameterTags(header.Id, header.Value);
				}
				catch
				{
					if (throwOnError)
					{
						throw;
					}
					if (header.Id == HeaderId.ArcMessageSignature)
					{
						errors |= ArcValidationErrors.InvalidArcMessageSignature;
					}
					else
					{
						errors |= ArcValidationErrors.InvalidArcSeal;
					}
					break;
				}
				if (!dictionary.TryGetValue("i", out var value))
				{
					if (throwOnError)
					{
						throw new FormatException(string.Format(CultureInfo.InvariantCulture, "Missing instance tag in {0} header.", header.Id.ToHeaderName()));
					}
					if (header.Id == HeaderId.ArcMessageSignature)
					{
						errors |= ArcValidationErrors.InvalidArcMessageSignature;
					}
					else
					{
						errors |= ArcValidationErrors.InvalidArcSeal;
					}
				}
				else if (!int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out result) || result < 1 || result > 50)
				{
					if (throwOnError)
					{
						throw new FormatException(string.Format(CultureInfo.InvariantCulture, "Invalid instance tag in {0} header: i={1}", header.Id.ToHeaderName(), value));
					}
					if (header.Id == HeaderId.ArcMessageSignature)
					{
						errors |= ArcValidationErrors.InvalidArcMessageSignature;
					}
					else
					{
						errors |= ArcValidationErrors.InvalidArcSeal;
					}
					result = 0;
				}
				break;
			}
			}
			if (result == 0)
			{
				continue;
			}
			ArcHeaderSet arcHeaderSet = sets[result - 1];
			if (arcHeaderSet == null)
			{
				arcHeaderSet = (sets[result - 1] = new ArcHeaderSet());
			}
			if (!arcHeaderSet.Add(header, dictionary))
			{
				if (throwOnError)
				{
					throw new FormatException(string.Format(CultureInfo.InvariantCulture, "Duplicate {0} header for i={1}", header.Id.ToHeaderName(), result));
				}
				switch (header.Id)
				{
				case HeaderId.ArcAuthenticationResults:
					errors |= ArcValidationErrors.DuplicateArcAuthenticationResults;
					break;
				case HeaderId.ArcMessageSignature:
					errors |= ArcValidationErrors.DuplicateArcMessageSignature;
					break;
				case HeaderId.ArcSeal:
					errors |= ArcValidationErrors.DuplicateArcSeal;
					break;
				}
			}
			if (result > count)
			{
				count = result;
			}
		}
		if (count == 0)
		{
			return ArcSignatureValidationResult.None;
		}
		for (int j = 0; j < count; j++)
		{
			ArcHeaderSet arcHeaderSet = sets[j];
			if (arcHeaderSet == null)
			{
				if (throwOnError)
				{
					throw new FormatException(string.Format(CultureInfo.InvariantCulture, "Missing ARC headers for i={0}", j + 1));
				}
				if ((errors & ArcValidationErrors.InvalidArcAuthenticationResults) == 0)
				{
					errors |= ArcValidationErrors.MissingArcAuthenticationResults;
				}
				if ((errors & ArcValidationErrors.InvalidArcMessageSignature) == 0)
				{
					errors |= ArcValidationErrors.MissingArcMessageSignature;
				}
				if ((errors & ArcValidationErrors.InvalidArcSeal) == 0)
				{
					errors |= ArcValidationErrors.MissingArcSeal;
				}
				continue;
			}
			if (arcHeaderSet.ArcAuthenticationResult == null)
			{
				if (throwOnError)
				{
					throw new FormatException(string.Format(CultureInfo.InvariantCulture, "Missing ARC-Authentication-Results header for i={0}", j + 1));
				}
				if ((errors & ArcValidationErrors.InvalidArcAuthenticationResults) == 0)
				{
					errors |= ArcValidationErrors.MissingArcAuthenticationResults;
				}
			}
			if (arcHeaderSet.ArcMessageSignature == null)
			{
				if (throwOnError)
				{
					throw new FormatException(string.Format(CultureInfo.InvariantCulture, "Missing ARC-Message-Signature header for i={0}", j + 1));
				}
				if ((errors & ArcValidationErrors.InvalidArcMessageSignature) == 0)
				{
					errors |= ArcValidationErrors.MissingArcMessageSignature;
				}
			}
			string value2;
			if (arcHeaderSet.ArcSeal == null)
			{
				if (throwOnError)
				{
					throw new FormatException(string.Format(CultureInfo.InvariantCulture, "Missing ARC-Seal header for i={0}", j + 1));
				}
				if ((errors & ArcValidationErrors.InvalidArcSeal) == 0)
				{
					errors |= ArcValidationErrors.MissingArcSeal;
				}
			}
			else if (!arcHeaderSet.ArcSealParameters.TryGetValue("cv", out value2))
			{
				if (throwOnError)
				{
					throw new FormatException(string.Format(CultureInfo.InvariantCulture, "Missing chain validation tag in ARC-Seal header for i={0}.", j + 1));
				}
				errors |= ArcValidationErrors.MissingArcSealChainValidationValue;
			}
			else if (!value2.Equals((j == 0) ? "none" : "pass", StringComparison.Ordinal))
			{
				errors |= ArcValidationErrors.InvalidArcSealChainValidationValue;
			}
		}
		if (errors != ArcValidationErrors.None)
		{
			return ArcSignatureValidationResult.Fail;
		}
		return ArcSignatureValidationResult.Pass;
	}

	private async Task<ArcValidationResult> VerifyAsync(FormatOptions options, MimeMessage message, bool doAsync, CancellationToken cancellationToken)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		ArcValidationResult result = new ArcValidationResult();
		ArcHeaderSet[] sets;
		int count;
		ArcValidationErrors errors;
		switch (GetArcHeaderSets(message, throwOnError: false, out sets, out count, out errors))
		{
		case ArcSignatureValidationResult.None:
			return result;
		case ArcSignatureValidationResult.Fail:
			result.Chain = ArcSignatureValidationResult.Fail;
			result.ChainErrors = errors;
			if ((errors & ~(ArcValidationErrors.InvalidArcSealChainValidationValue | ArcValidationErrors.MissingArcSealChainValidationValue)) != ArcValidationErrors.None)
			{
				return result;
			}
			break;
		default:
			result.Chain = ArcSignatureValidationResult.Pass;
			break;
		}
		int newest = count - 1;
		result.Seals = new ArcHeaderValidationResult[count];
		try
		{
			Dictionary<string, string> arcMessageSignatureParameters = sets[newest].ArcMessageSignatureParameters;
			Header arcMessageSignature = sets[newest].ArcMessageSignature;
			result.MessageSignature = new ArcHeaderValidationResult(arcMessageSignature);
			if (await VerifyArcMessageSignatureAsync(options, message, arcMessageSignature, arcMessageSignatureParameters, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false))
			{
				result.MessageSignature.Signature = ArcSignatureValidationResult.Pass;
			}
			else
			{
				result.MessageSignature.Signature = ArcSignatureValidationResult.Fail;
				result.ChainErrors |= ArcValidationErrors.MessageSignatureValidationFailed;
				result.Chain = ArcSignatureValidationResult.Fail;
			}
		}
		catch
		{
			result.MessageSignature.Signature = ArcSignatureValidationResult.Fail;
			result.ChainErrors |= ArcValidationErrors.MessageSignatureValidationFailed;
			result.Chain = ArcSignatureValidationResult.Fail;
		}
		for (int i = newest; i >= 0; i--)
		{
			result.Seals[i] = new ArcHeaderValidationResult(sets[i].ArcSeal);
			try
			{
				if (await VerifyArcSealAsync(options, sets, i, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false))
				{
					result.Seals[i].Signature = ArcSignatureValidationResult.Pass;
				}
				else
				{
					result.Seals[i].Signature = ArcSignatureValidationResult.Fail;
					result.ChainErrors |= ArcValidationErrors.SealValidationFailed;
					result.Chain = ArcSignatureValidationResult.Fail;
				}
			}
			catch
			{
				result.Seals[i].Signature = ArcSignatureValidationResult.Fail;
				result.ChainErrors |= ArcValidationErrors.SealValidationFailed;
				result.Chain = ArcSignatureValidationResult.Fail;
			}
		}
		return result;
	}

	public ArcValidationResult Verify(FormatOptions options, MimeMessage message, CancellationToken cancellationToken = default(CancellationToken))
	{
		return VerifyAsync(options, message, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public Task<ArcValidationResult> VerifyAsync(FormatOptions options, MimeMessage message, CancellationToken cancellationToken = default(CancellationToken))
	{
		return VerifyAsync(options, message, doAsync: true, cancellationToken);
	}

	public ArcValidationResult Verify(MimeMessage message, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Verify(FormatOptions.Default, message, cancellationToken);
	}

	public Task<ArcValidationResult> VerifyAsync(MimeMessage message, CancellationToken cancellationToken = default(CancellationToken))
	{
		return VerifyAsync(FormatOptions.Default, message, cancellationToken);
	}
}
