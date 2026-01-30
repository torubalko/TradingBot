using System;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

public class InMemoryCryptoProviderCache : CryptoProviderCache, IDisposable
{
	internal CryptoProviderCacheOptions _cryptoProviderCacheOptions;

	private bool _disposed;

	private readonly EventBasedLRUCache<string, SignatureProvider> _signingSignatureProviders;

	private readonly EventBasedLRUCache<string, SignatureProvider> _verifyingSignatureProviders;

	internal CryptoProviderFactory CryptoProviderFactory { get; set; }

	internal long TaskCount => _signingSignatureProviders.TaskCount + _verifyingSignatureProviders.TaskCount;

	internal long EventQueueTaskIdleTimeoutInSeconds
	{
		get
		{
			return _signingSignatureProviders.EventQueueTaskIdleTimeoutInSeconds;
		}
		set
		{
			_signingSignatureProviders.EventQueueTaskIdleTimeoutInSeconds = value;
			_verifyingSignatureProviders.EventQueueTaskIdleTimeoutInSeconds = value;
		}
	}

	public InMemoryCryptoProviderCache()
		: this(new CryptoProviderCacheOptions())
	{
	}

	public InMemoryCryptoProviderCache(CryptoProviderCacheOptions cryptoProviderCacheOptions)
	{
		if (cryptoProviderCacheOptions == null)
		{
			throw LogHelper.LogArgumentNullException("cryptoProviderCacheOptions");
		}
		_cryptoProviderCacheOptions = cryptoProviderCacheOptions;
		_signingSignatureProviders = new EventBasedLRUCache<string, SignatureProvider>(cryptoProviderCacheOptions.SizeLimit, TaskCreationOptions.None, StringComparer.Ordinal)
		{
			OnItemRemoved = delegate(SignatureProvider signatureProvider)
			{
				signatureProvider.CryptoProviderCache = null;
			}
		};
		_verifyingSignatureProviders = new EventBasedLRUCache<string, SignatureProvider>(cryptoProviderCacheOptions.SizeLimit, TaskCreationOptions.None, StringComparer.Ordinal)
		{
			OnItemRemoved = delegate(SignatureProvider signatureProvider)
			{
				signatureProvider.CryptoProviderCache = null;
			}
		};
	}

	internal InMemoryCryptoProviderCache(CryptoProviderCacheOptions cryptoProviderCacheOptions, TaskCreationOptions options, int tryTakeTimeout = 500)
	{
		if (cryptoProviderCacheOptions == null)
		{
			throw LogHelper.LogArgumentNullException("cryptoProviderCacheOptions");
		}
		if (tryTakeTimeout <= 0)
		{
			throw LogHelper.LogArgumentException<ArgumentException>("tryTakeTimeout", "tryTakeTimeout must be greater than zero");
		}
		_cryptoProviderCacheOptions = cryptoProviderCacheOptions;
		_signingSignatureProviders = new EventBasedLRUCache<string, SignatureProvider>(cryptoProviderCacheOptions.SizeLimit, options, StringComparer.Ordinal)
		{
			OnItemRemoved = delegate(SignatureProvider signatureProvider)
			{
				signatureProvider.CryptoProviderCache = null;
			}
		};
		_verifyingSignatureProviders = new EventBasedLRUCache<string, SignatureProvider>(cryptoProviderCacheOptions.SizeLimit, options, StringComparer.Ordinal)
		{
			OnItemRemoved = delegate(SignatureProvider signatureProvider)
			{
				signatureProvider.CryptoProviderCache = null;
			}
		};
	}

	protected override string GetCacheKey(SignatureProvider signatureProvider)
	{
		if (signatureProvider == null)
		{
			throw LogHelper.LogArgumentNullException("signatureProvider");
		}
		return GetCacheKeyPrivate(signatureProvider.Key, signatureProvider.Algorithm, signatureProvider.GetType().ToString());
	}

	protected override string GetCacheKey(SecurityKey securityKey, string algorithm, string typeofProvider)
	{
		if (securityKey == null)
		{
			throw LogHelper.LogArgumentNullException("securityKey");
		}
		if (string.IsNullOrEmpty(algorithm))
		{
			throw LogHelper.LogArgumentNullException("algorithm");
		}
		if (string.IsNullOrEmpty(typeofProvider))
		{
			throw LogHelper.LogArgumentNullException("typeofProvider");
		}
		return GetCacheKeyPrivate(securityKey, algorithm, typeofProvider);
	}

	private static string GetCacheKeyPrivate(SecurityKey securityKey, string algorithm, string typeofProvider)
	{
		return string.Format(CultureInfo.InvariantCulture, "{0}-{1}-{2}-{3}", securityKey.GetType(), securityKey.InternalId, algorithm, typeofProvider);
	}

	public override bool TryAdd(SignatureProvider signatureProvider)
	{
		if (signatureProvider == null)
		{
			throw LogHelper.LogArgumentNullException("signatureProvider");
		}
		string cacheKey = GetCacheKey(signatureProvider);
		EventBasedLRUCache<string, SignatureProvider> eventBasedLRUCache = ((!signatureProvider.WillCreateSignatures) ? _verifyingSignatureProviders : _signingSignatureProviders);
		if (!eventBasedLRUCache.Contains(cacheKey))
		{
			eventBasedLRUCache.SetValue(cacheKey, signatureProvider);
			signatureProvider.CryptoProviderCache = this;
			return true;
		}
		return false;
	}

	public override bool TryGetSignatureProvider(SecurityKey securityKey, string algorithm, string typeofProvider, bool willCreateSignatures, out SignatureProvider signatureProvider)
	{
		if (securityKey == null)
		{
			throw LogHelper.LogArgumentNullException("securityKey");
		}
		if (string.IsNullOrEmpty(algorithm))
		{
			throw LogHelper.LogArgumentNullException("algorithm");
		}
		if (string.IsNullOrEmpty(typeofProvider))
		{
			throw LogHelper.LogArgumentNullException("typeofProvider");
		}
		string cacheKeyPrivate = GetCacheKeyPrivate(securityKey, algorithm, typeofProvider);
		if (willCreateSignatures)
		{
			return _signingSignatureProviders.TryGetValue(cacheKeyPrivate, out signatureProvider);
		}
		return _verifyingSignatureProviders.TryGetValue(cacheKeyPrivate, out signatureProvider);
	}

	public override bool TryRemove(SignatureProvider signatureProvider)
	{
		if (signatureProvider == null)
		{
			throw LogHelper.LogArgumentNullException("signatureProvider");
		}
		if (signatureProvider.CryptoProviderCache != this)
		{
			return false;
		}
		string cacheKey = GetCacheKey(signatureProvider);
		EventBasedLRUCache<string, SignatureProvider> eventBasedLRUCache = ((!signatureProvider.WillCreateSignatures) ? _verifyingSignatureProviders : _signingSignatureProviders);
		try
		{
			SignatureProvider value;
			return eventBasedLRUCache.TryRemove(cacheKey, out value);
		}
		catch (Exception ex)
		{
			LogHelper.LogWarning(LogHelper.FormatInvariant("IDX10699: Unable to remove SignatureProvider with cache key: {0} from the InMemoryCryptoProviderCache. Exception: '{1}'.", cacheKey, ex));
			return false;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_disposed)
		{
			_disposed = true;
		}
	}

	internal long LinkedListCountSigning()
	{
		return _signingSignatureProviders.LinkedListCount;
	}

	internal long LinkedListCountVerifying()
	{
		return _verifyingSignatureProviders.LinkedListCount;
	}

	internal long MapCountSigning()
	{
		return _signingSignatureProviders.MapCount;
	}

	internal long MapCountVerifying()
	{
		return _verifyingSignatureProviders.MapCount;
	}

	internal long EventQueueCountSigning()
	{
		return _signingSignatureProviders.EventQueueCount;
	}

	internal long EventQueueCountVerifying()
	{
		return _verifyingSignatureProviders.EventQueueCount;
	}
}
