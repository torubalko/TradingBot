using System;
using System.Text;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

internal static class InternalValidators
{
	internal static void ValidateLifetimeAndIssuerAfterSignatureNotValidatedJwt(SecurityToken securityToken, DateTime? notBefore, DateTime? expires, string kid, TokenValidationParameters validationParameters, BaseConfiguration configuration, StringBuilder exceptionStrings)
	{
		bool flag = false;
		bool flag2 = false;
		try
		{
			Validators.ValidateLifetime(notBefore, expires, securityToken, validationParameters);
			flag2 = true;
		}
		catch (Exception)
		{
		}
		try
		{
			Validators.ValidateIssuer(securityToken.Issuer, securityToken, validationParameters, configuration);
			flag = true;
		}
		catch (Exception)
		{
		}
		if (flag2 && flag)
		{
			throw LogHelper.LogExceptionMessage(new SecurityTokenSignatureKeyNotFoundException(LogHelper.FormatInvariant("IDX10501: Signature validation failed. Unable to match key: \nkid: '{0}'.\nExceptions caught:\n '{1}'. \ntoken: '{2}'.", kid, exceptionStrings, securityToken)));
		}
		ValidationFailure validationFailure = ValidationFailure.None;
		if (!flag2)
		{
			validationFailure |= ValidationFailure.InvalidLifetime;
		}
		if (!flag)
		{
			validationFailure |= ValidationFailure.InvalidIssuer;
		}
		throw LogHelper.LogExceptionMessage(new SecurityTokenUnableToValidateException(validationFailure, LogHelper.FormatInvariant("IDX10516: Signature validation failed. Unable to match key: \nkid: '{0}'.\nExceptions caught:\n '{1}'. \ntoken: '{2}'. Valid Lifetime: '{3}'. Valid Issuer: '{4}'", kid, exceptionStrings, securityToken, LogHelper.MarkAsNonPII(flag2), flag)));
	}

	internal static void ValidateLifetimeAndIssuerAfterSignatureNotValidatedSaml(SecurityToken securityToken, DateTime? notBefore, DateTime? expires, string keyInfo, TokenValidationParameters validationParameters, StringBuilder exceptionStrings)
	{
		bool flag = false;
		bool flag2 = false;
		try
		{
			Validators.ValidateLifetime(notBefore, expires, securityToken, validationParameters);
			flag2 = true;
		}
		catch (Exception)
		{
		}
		try
		{
			Validators.ValidateIssuer(securityToken.Issuer, securityToken, validationParameters);
			flag = true;
		}
		catch (Exception)
		{
		}
		if (flag2 && flag)
		{
			throw LogHelper.LogExceptionMessage(new SecurityTokenSignatureKeyNotFoundException(LogHelper.FormatInvariant("IDX10513: Signature validation failed. Unable to match key: \nKeyInfo: '{0}'.\nExceptions caught:\n '{1}'. \ntoken: '{2}'.", keyInfo, exceptionStrings, securityToken)));
		}
		ValidationFailure validationFailure = ValidationFailure.None;
		if (!flag2)
		{
			validationFailure |= ValidationFailure.InvalidLifetime;
		}
		if (!flag)
		{
			validationFailure |= ValidationFailure.InvalidIssuer;
		}
		throw LogHelper.LogExceptionMessage(new SecurityTokenUnableToValidateException(validationFailure, LogHelper.FormatInvariant("IDX10515: Signature validation failed. Unable to match key: \nKeyInfo: '{0}'.\nExceptions caught:\n '{1}'. \ntoken: '{2}'. Valid Lifetime: '{3}'. Valid Issuer: '{4}'", keyInfo, exceptionStrings, securityToken, LogHelper.MarkAsNonPII(flag2), flag)));
	}
}
