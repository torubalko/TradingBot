using System;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

public class CryptoProviderCacheOptions
{
	private int _sizeLimit = DefaultSizeLimit;

	public static readonly int DefaultSizeLimit = 1000;

	public int SizeLimit
	{
		get
		{
			return _sizeLimit;
		}
		set
		{
			if (value <= 10)
			{
				throw LogHelper.LogExceptionMessage(new ArgumentOutOfRangeException("SizeLimit", LogHelper.FormatInvariant("IDX10901: CryptoProviderCacheOptions.SizeLimit must be greater than 10. Value: '{0}'", LogHelper.MarkAsNonPII(value))));
			}
			_sizeLimit = value;
		}
	}
}
