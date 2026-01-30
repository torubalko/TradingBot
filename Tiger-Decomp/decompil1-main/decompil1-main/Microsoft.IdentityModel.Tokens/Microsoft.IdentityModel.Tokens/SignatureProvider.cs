using System;
using System.Threading;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

public abstract class SignatureProvider : IDisposable
{
	private int _referenceCount;

	public string Algorithm { get; private set; }

	public string Context { get; set; }

	public CryptoProviderCache CryptoProviderCache { get; set; }

	public SecurityKey Key { get; private set; }

	internal virtual int ObjectPoolSize => 0;

	internal int RefCount => _referenceCount;

	public bool WillCreateSignatures { get; protected set; }

	protected SignatureProvider(SecurityKey key, string algorithm)
	{
		Key = key ?? throw LogHelper.LogArgumentNullException("key");
		if (string.IsNullOrEmpty(algorithm))
		{
			throw LogHelper.LogArgumentNullException("algorithm");
		}
		Algorithm = algorithm;
		_referenceCount = 1;
	}

	internal int AddRef()
	{
		return Interlocked.Increment(ref _referenceCount);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected abstract void Dispose(bool disposing);

	internal int Release()
	{
		if (_referenceCount > 0)
		{
			Interlocked.Decrement(ref _referenceCount);
		}
		return _referenceCount;
	}

	public abstract byte[] Sign(byte[] input);

	public abstract bool Verify(byte[] input, byte[] signature);
}
