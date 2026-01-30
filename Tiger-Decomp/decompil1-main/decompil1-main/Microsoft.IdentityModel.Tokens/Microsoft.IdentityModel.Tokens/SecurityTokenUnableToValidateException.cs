using System;
using System.Runtime.Serialization;

namespace Microsoft.IdentityModel.Tokens;

[Serializable]
public class SecurityTokenUnableToValidateException : SecurityTokenInvalidSignatureException
{
	[NonSerialized]
	private const string _Prefix = "Microsoft.IdentityModel.SecurityTokenUnableToValidateException.";

	[NonSerialized]
	private const string _ValidationFailureKey = "Microsoft.IdentityModel.SecurityTokenUnableToValidateException.ValidationFailure";

	public ValidationFailure ValidationFailure { get; set; }

	public SecurityTokenUnableToValidateException()
	{
	}

	public SecurityTokenUnableToValidateException(ValidationFailure validationFailure, string message)
		: base(message)
	{
		ValidationFailure = validationFailure;
	}

	public SecurityTokenUnableToValidateException(string message)
		: base(message)
	{
	}

	public SecurityTokenUnableToValidateException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected SecurityTokenUnableToValidateException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		SerializationInfoEnumerator enumerator = info.GetEnumerator();
		while (enumerator.MoveNext())
		{
			if (enumerator.Name == "Microsoft.IdentityModel.SecurityTokenUnableToValidateException.ValidationFailure")
			{
				ValidationFailure = (ValidationFailure)info.GetValue("Microsoft.IdentityModel.SecurityTokenUnableToValidateException.ValidationFailure", typeof(ValidationFailure));
			}
		}
	}

	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("Microsoft.IdentityModel.SecurityTokenUnableToValidateException.ValidationFailure", ValidationFailure);
	}
}
