using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

public class TokenValidationResult
{
	private bool _isValid;

	private bool _hasIsValidOrExceptionBeenRead;

	private Exception _exception;

	private Lazy<IDictionary<string, object>> _claims => new Lazy<IDictionary<string, object>>(() => TokenUtilities.CreateDictionaryFromClaims(ClaimsIdentity?.Claims));

	public IDictionary<string, object> Claims
	{
		get
		{
			if (!_hasIsValidOrExceptionBeenRead)
			{
				LogHelper.LogWarning("IDX10109: Warning: Claims is being accessed without first reading the properties TokenValidationResult.IsValid or TokenValidationResult.Exception. This could be a potential security issue.");
			}
			return _claims.Value;
		}
	}

	public ClaimsIdentity ClaimsIdentity { get; set; }

	public Exception Exception
	{
		get
		{
			_hasIsValidOrExceptionBeenRead = true;
			return _exception;
		}
		set
		{
			_exception = value;
		}
	}

	public string Issuer { get; set; }

	public bool IsValid
	{
		get
		{
			_hasIsValidOrExceptionBeenRead = true;
			return _isValid;
		}
		set
		{
			_isValid = value;
		}
	}

	public IDictionary<string, object> PropertyBag { get; } = new Dictionary<string, object>(StringComparer.Ordinal);

	public SecurityToken SecurityToken { get; set; }

	public CallContext TokenContext { get; set; }

	public string TokenType { get; set; }
}
