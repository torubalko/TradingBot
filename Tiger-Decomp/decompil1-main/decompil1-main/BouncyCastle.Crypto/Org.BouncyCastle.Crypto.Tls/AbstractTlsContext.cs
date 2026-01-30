using System;
using System.Threading;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls;

internal abstract class AbstractTlsContext : TlsContext
{
	private static long counter = Times.NanoTime();

	private readonly IRandomGenerator mNonceRandom;

	private readonly SecureRandom mSecureRandom;

	private readonly SecurityParameters mSecurityParameters;

	private ProtocolVersion mClientVersion;

	private ProtocolVersion mServerVersion;

	private TlsSession mSession;

	private object mUserObject;

	public virtual IRandomGenerator NonceRandomGenerator => mNonceRandom;

	public virtual SecureRandom SecureRandom => mSecureRandom;

	public virtual SecurityParameters SecurityParameters => mSecurityParameters;

	public abstract bool IsServer { get; }

	public virtual ProtocolVersion ClientVersion => mClientVersion;

	public virtual ProtocolVersion ServerVersion => mServerVersion;

	public virtual TlsSession ResumableSession => mSession;

	public virtual object UserObject
	{
		get
		{
			return mUserObject;
		}
		set
		{
			mUserObject = value;
		}
	}

	private static long NextCounterValue()
	{
		return Interlocked.Increment(ref counter);
	}

	private static IRandomGenerator CreateNonceRandom(SecureRandom secureRandom, int connectionEnd)
	{
		byte[] additionalSeedMaterial = new byte[16];
		Pack.UInt64_To_BE((ulong)NextCounterValue(), additionalSeedMaterial, 0);
		Pack.UInt64_To_BE((ulong)Times.NanoTime(), additionalSeedMaterial, 8);
		additionalSeedMaterial[0] &= 127;
		additionalSeedMaterial[0] |= (byte)(connectionEnd << 7);
		IDigest digest = TlsUtilities.CreateHash(4);
		byte[] seed = new byte[digest.GetDigestSize()];
		secureRandom.NextBytes(seed);
		DigestRandomGenerator digestRandomGenerator = new DigestRandomGenerator(digest);
		((IRandomGenerator)digestRandomGenerator).AddSeedMaterial(additionalSeedMaterial);
		((IRandomGenerator)digestRandomGenerator).AddSeedMaterial(seed);
		return digestRandomGenerator;
	}

	internal AbstractTlsContext(SecureRandom secureRandom, SecurityParameters securityParameters)
	{
		mSecureRandom = secureRandom;
		mSecurityParameters = securityParameters;
		mNonceRandom = CreateNonceRandom(secureRandom, securityParameters.Entity);
	}

	internal virtual void SetClientVersion(ProtocolVersion clientVersion)
	{
		mClientVersion = clientVersion;
	}

	internal virtual void SetServerVersion(ProtocolVersion serverVersion)
	{
		mServerVersion = serverVersion;
	}

	internal virtual void SetResumableSession(TlsSession session)
	{
		mSession = session;
	}

	public virtual byte[] ExportKeyingMaterial(string asciiLabel, byte[] context_value, int length)
	{
		if (context_value != null && !TlsUtilities.IsValidUint16(context_value.Length))
		{
			throw new ArgumentException("must have length less than 2^16 (or be null)", "context_value");
		}
		SecurityParameters sp = SecurityParameters;
		if (!sp.IsExtendedMasterSecret)
		{
			throw new InvalidOperationException("cannot export keying material without extended_master_secret");
		}
		byte[] cr = sp.ClientRandom;
		byte[] sr = sp.ServerRandom;
		int seedLength = cr.Length + sr.Length;
		if (context_value != null)
		{
			seedLength += 2 + context_value.Length;
		}
		byte[] seed = new byte[seedLength];
		int seedPos = 0;
		Array.Copy(cr, 0, seed, seedPos, cr.Length);
		seedPos += cr.Length;
		Array.Copy(sr, 0, seed, seedPos, sr.Length);
		seedPos += sr.Length;
		if (context_value != null)
		{
			TlsUtilities.WriteUint16(context_value.Length, seed, seedPos);
			seedPos += 2;
			Array.Copy(context_value, 0, seed, seedPos, context_value.Length);
			seedPos += context_value.Length;
		}
		if (seedPos != seedLength)
		{
			throw new InvalidOperationException("error in calculation of seed for export");
		}
		return TlsUtilities.PRF(this, sp.MasterSecret, asciiLabel, seed, length);
	}
}
