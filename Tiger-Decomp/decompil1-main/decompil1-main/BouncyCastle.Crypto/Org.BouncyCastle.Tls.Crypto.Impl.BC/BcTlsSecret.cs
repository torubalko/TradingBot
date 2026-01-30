using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsSecret : AbstractTlsSecret
{
	private static readonly byte[] Ssl3Const = GenerateSsl3Constants();

	protected readonly BcTlsCrypto m_crypto;

	protected override AbstractTlsCrypto Crypto => m_crypto;

	public static BcTlsSecret Convert(BcTlsCrypto crypto, TlsSecret secret)
	{
		if (secret is BcTlsSecret)
		{
			return (BcTlsSecret)secret;
		}
		if (secret is AbstractTlsSecret)
		{
			AbstractTlsSecret abstractTlsSecret = (AbstractTlsSecret)secret;
			return crypto.AdoptLocalSecret(AbstractTlsSecret.CopyData(abstractTlsSecret));
		}
		throw new ArgumentException("unrecognized TlsSecret - cannot copy data: " + Platform.GetTypeName(secret));
	}

	private static byte[] GenerateSsl3Constants()
	{
		int n = 15;
		byte[] result = new byte[n * (n + 1) / 2];
		int pos = 0;
		for (int i = 0; i < n; i++)
		{
			byte b = (byte)(65 + i);
			for (int j = 0; j <= i; j++)
			{
				result[pos++] = b;
			}
		}
		return result;
	}

	public BcTlsSecret(BcTlsCrypto crypto, byte[] data)
		: base(data)
	{
		m_crypto = crypto;
	}

	public override TlsSecret DeriveUsingPrf(int prfAlgorithm, string label, byte[] seed, int length)
	{
		lock (this)
		{
			CheckAlive();
			return prfAlgorithm switch
			{
				4 => TlsCryptoUtilities.HkdfExpandLabel(this, 4, label, seed, length), 
				5 => TlsCryptoUtilities.HkdfExpandLabel(this, 5, label, seed, length), 
				7 => TlsCryptoUtilities.HkdfExpandLabel(this, 7, label, seed, length), 
				_ => m_crypto.AdoptLocalSecret(Prf(prfAlgorithm, label, seed, length)), 
			};
		}
	}

	public override TlsSecret HkdfExpand(int cryptoHashAlgorithm, byte[] info, int length)
	{
		lock (this)
		{
			if (length < 1)
			{
				return m_crypto.AdoptLocalSecret(TlsUtilities.EmptyBytes);
			}
			int hashLen = TlsCryptoUtilities.GetHashOutputSize(cryptoHashAlgorithm);
			if (length > 255 * hashLen)
			{
				throw new ArgumentException("must be <= 255 * (output size of 'hashAlgorithm')", "length");
			}
			CheckAlive();
			byte[] prk = m_data;
			HMac hmac = new HMac(m_crypto.CreateDigest(cryptoHashAlgorithm));
			hmac.Init(new KeyParameter(prk));
			byte[] okm = new byte[length];
			byte[] t = new byte[hashLen];
			byte counter = 0;
			int pos = 0;
			int remaining;
			while (true)
			{
				hmac.BlockUpdate(info, 0, info.Length);
				hmac.Update(++counter);
				hmac.DoFinal(t, 0);
				remaining = length - pos;
				if (remaining <= hashLen)
				{
					break;
				}
				Array.Copy(t, 0, okm, pos, hashLen);
				pos += hashLen;
				hmac.BlockUpdate(t, 0, t.Length);
			}
			Array.Copy(t, 0, okm, pos, remaining);
			return m_crypto.AdoptLocalSecret(okm);
		}
	}

	public override TlsSecret HkdfExtract(int cryptoHashAlgorithm, TlsSecret ikm)
	{
		lock (this)
		{
			CheckAlive();
			byte[] salt = m_data;
			m_data = null;
			HMac hmac = new HMac(m_crypto.CreateDigest(cryptoHashAlgorithm));
			hmac.Init(new KeyParameter(salt));
			Convert(m_crypto, ikm).UpdateMac(hmac);
			byte[] prk = new byte[hmac.GetMacSize()];
			hmac.DoFinal(prk, 0);
			return m_crypto.AdoptLocalSecret(prk);
		}
	}

	protected virtual void HmacHash(IDigest digest, byte[] secret, int secretOff, int secretLen, byte[] seed, byte[] output)
	{
		HMac mac = new HMac(digest);
		mac.Init(new KeyParameter(secret, secretOff, secretLen));
		byte[] a = seed;
		int macSize = mac.GetMacSize();
		byte[] b1 = new byte[macSize];
		byte[] b2 = new byte[macSize];
		for (int pos = 0; pos < output.Length; pos += macSize)
		{
			mac.BlockUpdate(a, 0, a.Length);
			mac.DoFinal(b1, 0);
			a = b1;
			mac.BlockUpdate(a, 0, a.Length);
			mac.BlockUpdate(seed, 0, seed.Length);
			mac.DoFinal(b2, 0);
			Array.Copy(b2, 0, output, pos, System.Math.Min(macSize, output.Length - pos));
		}
	}

	protected virtual byte[] Prf(int prfAlgorithm, string label, byte[] seed, int length)
	{
		if (prfAlgorithm == 0)
		{
			return Prf_Ssl(seed, length);
		}
		byte[] labelSeed = Arrays.Concatenate(Strings.ToByteArray(label), seed);
		if (1 == prfAlgorithm)
		{
			return Prf_1_0(labelSeed, length);
		}
		return Prf_1_2(prfAlgorithm, labelSeed, length);
	}

	protected virtual byte[] Prf_Ssl(byte[] seed, int length)
	{
		IDigest md5 = m_crypto.CreateDigest(1);
		IDigest sha1 = m_crypto.CreateDigest(2);
		int md5Size = md5.GetDigestSize();
		int sha1Size = sha1.GetDigestSize();
		byte[] tmp = new byte[System.Math.Max(md5Size, sha1Size)];
		byte[] result = new byte[length];
		int constLen = 1;
		int constPos = 0;
		int resultPos = 0;
		while (resultPos < length)
		{
			sha1.BlockUpdate(Ssl3Const, constPos, constLen);
			constPos += constLen++;
			sha1.BlockUpdate(m_data, 0, m_data.Length);
			sha1.BlockUpdate(seed, 0, seed.Length);
			sha1.DoFinal(tmp, 0);
			md5.BlockUpdate(m_data, 0, m_data.Length);
			md5.BlockUpdate(tmp, 0, sha1Size);
			int remaining = length - resultPos;
			if (remaining < md5Size)
			{
				md5.DoFinal(tmp, 0);
				Array.Copy(tmp, 0, result, resultPos, remaining);
				resultPos += remaining;
			}
			else
			{
				md5.DoFinal(result, resultPos);
				resultPos += md5Size;
			}
		}
		return result;
	}

	protected virtual byte[] Prf_1_0(byte[] labelSeed, int length)
	{
		int s_half = (m_data.Length + 1) / 2;
		IDigest md5 = m_crypto.CreateDigest(1);
		byte[] b1 = new byte[length];
		HmacHash(md5, m_data, 0, s_half, labelSeed, b1);
		IDigest sha1 = m_crypto.CreateDigest(2);
		byte[] b2 = new byte[length];
		HmacHash(sha1, m_data, m_data.Length - s_half, s_half, labelSeed, b2);
		for (int i = 0; i < length; i++)
		{
			b1[i] ^= b2[i];
		}
		return b1;
	}

	protected virtual byte[] Prf_1_2(int prfAlgorithm, byte[] labelSeed, int length)
	{
		IDigest digest = m_crypto.CreateDigest(TlsCryptoUtilities.GetHashForPrf(prfAlgorithm));
		byte[] result = new byte[length];
		HmacHash(digest, m_data, 0, m_data.Length, labelSeed, result);
		return result;
	}

	protected virtual void UpdateMac(IMac mac)
	{
		lock (this)
		{
			CheckAlive();
			mac.BlockUpdate(m_data, 0, m_data.Length);
		}
	}
}
