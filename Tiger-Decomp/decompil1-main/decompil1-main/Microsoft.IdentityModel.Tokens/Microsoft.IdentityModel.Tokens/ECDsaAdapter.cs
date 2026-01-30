using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

internal class ECDsaAdapter
{
	private enum KeyBlobMagicNumber : uint
	{
		BCRYPT_ECDSA_PUBLIC_P256_MAGIC = 827540293u,
		BCRYPT_ECDSA_PUBLIC_P384_MAGIC = 861094725u,
		BCRYPT_ECDSA_PUBLIC_P521_MAGIC = 894649157u,
		BCRYPT_ECDSA_PRIVATE_P256_MAGIC = 844317509u,
		BCRYPT_ECDSA_PRIVATE_P384_MAGIC = 877871941u,
		BCRYPT_ECDSA_PRIVATE_P521_MAGIC = 911426373u
	}

	internal readonly CreateECDsaDelegate CreateECDsaFunction = ECDsaNotSupported;

	internal static ECDsaAdapter Instance = new ECDsaAdapter();

	internal ECDsaAdapter()
	{
		CreateECDsaFunction = CreateECDsaUsingECParams;
	}

	internal ECDsa CreateECDsa(JsonWebKey jsonWebKey, bool usePrivateKey)
	{
		return CreateECDsaFunction(jsonWebKey, usePrivateKey);
	}

	internal static ECDsa ECDsaNotSupported(JsonWebKey jsonWebKey, bool usePrivateKey)
	{
		throw LogHelper.LogExceptionMessage(new PlatformNotSupportedException("IDX10690: ECDsa creation is not supported by the current platform. For more details, see https://aka.ms/IdentityModel/create-ecdsa"));
	}

	private static uint GetKeyByteCount(string curveId)
	{
		if (string.IsNullOrEmpty(curveId))
		{
			throw LogHelper.LogArgumentNullException("curveId");
		}
		switch (curveId)
		{
		case "P-256":
			return 32u;
		case "P-384":
			return 48u;
		case "P-512":
		case "P-521":
			return 66u;
		default:
			throw LogHelper.LogExceptionMessage(new ArgumentException(LogHelper.FormatInvariant("IDX10645: Elliptical Curve not supported for curveId: '{0}'", LogHelper.MarkAsNonPII(curveId))));
		}
	}

	private static uint GetMagicValue(string curveId, bool willCreateSignatures)
	{
		if (string.IsNullOrEmpty(curveId))
		{
			throw LogHelper.LogArgumentNullException("curveId");
		}
		switch (curveId)
		{
		case "P-256":
			if (willCreateSignatures)
			{
				return 844317509u;
			}
			return 827540293u;
		case "P-384":
			if (willCreateSignatures)
			{
				return 877871941u;
			}
			return 861094725u;
		case "P-512":
		case "P-521":
			if (willCreateSignatures)
			{
				return 911426373u;
			}
			return 894649157u;
		default:
			throw LogHelper.LogExceptionMessage(new ArgumentException(LogHelper.FormatInvariant("IDX10645: Elliptical Curve not supported for curveId: '{0}'", LogHelper.MarkAsNonPII(curveId))));
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static bool SupportsCNGKey()
	{
		try
		{
			_ = CngKeyBlobFormat.EccPrivateBlob;
			return true;
		}
		catch
		{
			return false;
		}
	}

	private ECDsa CreateECDsaUsingECParams(JsonWebKey jsonWebKey, bool usePrivateKey)
	{
		if (jsonWebKey == null)
		{
			throw LogHelper.LogArgumentNullException("jsonWebKey");
		}
		if (jsonWebKey.Crv == null)
		{
			throw LogHelper.LogArgumentNullException("Crv");
		}
		if (jsonWebKey.X == null)
		{
			throw LogHelper.LogArgumentNullException("X");
		}
		if (jsonWebKey.Y == null)
		{
			throw LogHelper.LogArgumentNullException("Y");
		}
		try
		{
			ECParameters parameters = new ECParameters
			{
				Curve = GetNamedECCurve(jsonWebKey.Crv),
				Q = 
				{
					X = Base64UrlEncoder.DecodeBytes(jsonWebKey.X),
					Y = Base64UrlEncoder.DecodeBytes(jsonWebKey.Y)
				}
			};
			if (usePrivateKey)
			{
				if (jsonWebKey.D == null)
				{
					throw LogHelper.LogArgumentNullException("D");
				}
				parameters.D = Base64UrlEncoder.DecodeBytes(jsonWebKey.D);
			}
			return ECDsa.Create(parameters);
		}
		catch (Exception inner)
		{
			throw LogHelper.LogExceptionMessage(new CryptographicException("IDX10689: Unable to create an ECDsa object. See inner exception for more details.", inner));
		}
	}

	private static ECCurve GetNamedECCurve(string curveId)
	{
		if (string.IsNullOrEmpty(curveId))
		{
			throw LogHelper.LogArgumentNullException("curveId");
		}
		switch (curveId)
		{
		case "P-256":
			return ECCurve.NamedCurves.nistP256;
		case "P-384":
			return ECCurve.NamedCurves.nistP384;
		case "P-512":
		case "P-521":
			return ECCurve.NamedCurves.nistP521;
		default:
			throw LogHelper.LogExceptionMessage(new ArgumentException(LogHelper.FormatInvariant("IDX10645: Elliptical Curve not supported for curveId: '{0}'", LogHelper.MarkAsNonPII(curveId))));
		}
	}

	internal static string GetCrvParameterValue(ECCurve curve)
	{
		if (curve.Oid == null)
		{
			throw LogHelper.LogArgumentNullException("Oid");
		}
		if (string.Equals(curve.Oid.Value, ECCurve.NamedCurves.nistP256.Oid.Value, StringComparison.Ordinal) || string.Equals(curve.Oid.FriendlyName, ECCurve.NamedCurves.nistP256.Oid.FriendlyName, StringComparison.Ordinal))
		{
			return "P-256";
		}
		if (string.Equals(curve.Oid.Value, ECCurve.NamedCurves.nistP384.Oid.Value, StringComparison.Ordinal) || string.Equals(curve.Oid.FriendlyName, ECCurve.NamedCurves.nistP384.Oid.FriendlyName, StringComparison.Ordinal))
		{
			return "P-384";
		}
		if (string.Equals(curve.Oid.Value, ECCurve.NamedCurves.nistP521.Oid.Value, StringComparison.Ordinal) || string.Equals(curve.Oid.FriendlyName, ECCurve.NamedCurves.nistP521.Oid.FriendlyName, StringComparison.Ordinal))
		{
			return "P-521";
		}
		throw LogHelper.LogExceptionMessage(new ArgumentException(LogHelper.FormatInvariant("IDX10645: Elliptical Curve not supported for curveId: '{0}'", (curve.Oid.Value ?? curve.Oid.FriendlyName) ?? "null")));
	}

	internal static bool SupportsECParameters()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void LoadECParametersType()
	{
	}
}
