using System;
using System.Text;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Agreement.JPake;

public abstract class JPakeUtilities
{
	public static readonly BigInteger Zero = BigInteger.Zero;

	public static readonly BigInteger One = BigInteger.One;

	public static BigInteger GenerateX1(BigInteger q, SecureRandom random)
	{
		BigInteger zero = Zero;
		BigInteger max = q.Subtract(One);
		return BigIntegers.CreateRandomInRange(zero, max, random);
	}

	public static BigInteger GenerateX2(BigInteger q, SecureRandom random)
	{
		BigInteger one = One;
		BigInteger max = q.Subtract(One);
		return BigIntegers.CreateRandomInRange(one, max, random);
	}

	public static BigInteger CalculateS(char[] password)
	{
		return new BigInteger(Encoding.UTF8.GetBytes(password));
	}

	public static BigInteger CalculateGx(BigInteger p, BigInteger g, BigInteger x)
	{
		return g.ModPow(x, p);
	}

	public static BigInteger CalculateGA(BigInteger p, BigInteger gx1, BigInteger gx3, BigInteger gx4)
	{
		return gx1.Multiply(gx3).Multiply(gx4).Mod(p);
	}

	public static BigInteger CalculateX2s(BigInteger q, BigInteger x2, BigInteger s)
	{
		return x2.Multiply(s).Mod(q);
	}

	public static BigInteger CalculateA(BigInteger p, BigInteger q, BigInteger gA, BigInteger x2s)
	{
		return gA.ModPow(x2s, p);
	}

	public static BigInteger[] CalculateZeroKnowledgeProof(BigInteger p, BigInteger q, BigInteger g, BigInteger gx, BigInteger x, string participantId, IDigest digest, SecureRandom random)
	{
		BigInteger zero = Zero;
		BigInteger vMax = q.Subtract(One);
		BigInteger v = BigIntegers.CreateRandomInRange(zero, vMax, random);
		BigInteger gv = g.ModPow(v, p);
		BigInteger h = CalculateHashForZeroKnowledgeProof(g, gv, gx, participantId, digest);
		return new BigInteger[2]
		{
			gv,
			v.Subtract(x.Multiply(h)).Mod(q)
		};
	}

	private static BigInteger CalculateHashForZeroKnowledgeProof(BigInteger g, BigInteger gr, BigInteger gx, string participantId, IDigest digest)
	{
		digest.Reset();
		UpdateDigestIncludingSize(digest, g);
		UpdateDigestIncludingSize(digest, gr);
		UpdateDigestIncludingSize(digest, gx);
		UpdateDigestIncludingSize(digest, participantId);
		return new BigInteger(DigestUtilities.DoFinal(digest));
	}

	public static void ValidateGx4(BigInteger gx4)
	{
		if (gx4.Equals(One))
		{
			throw new CryptoException("g^x validation failed.  g^x should not be 1.");
		}
	}

	public static void ValidateGa(BigInteger ga)
	{
		if (ga.Equals(One))
		{
			throw new CryptoException("ga is equal to 1.  It should not be.  The chances of this happening are on the order of 2^160 for a 160-bit q.  Try again.");
		}
	}

	public static void ValidateZeroKnowledgeProof(BigInteger p, BigInteger q, BigInteger g, BigInteger gx, BigInteger[] zeroKnowledgeProof, string participantId, IDigest digest)
	{
		BigInteger gv = zeroKnowledgeProof[0];
		BigInteger r = zeroKnowledgeProof[1];
		BigInteger h = CalculateHashForZeroKnowledgeProof(g, gv, gx, participantId, digest);
		if (gx.CompareTo(Zero) != 1 || gx.CompareTo(p) != -1 || gx.ModPow(q, p).CompareTo(One) != 0 || g.ModPow(r, p).Multiply(gx.ModPow(h, p)).Mod(p)
			.CompareTo(gv) != 0)
		{
			throw new CryptoException("Zero-knowledge proof validation failed");
		}
	}

	public static BigInteger CalculateKeyingMaterial(BigInteger p, BigInteger q, BigInteger gx4, BigInteger x2, BigInteger s, BigInteger B)
	{
		return gx4.ModPow(x2.Multiply(s).Negate().Mod(q), p).Multiply(B).ModPow(x2, p);
	}

	public static void ValidateParticipantIdsDiffer(string participantId1, string participantId2)
	{
		if (participantId1.Equals(participantId2))
		{
			throw new CryptoException("Both participants are using the same participantId (" + participantId1 + "). This is not allowed. Each participant must use a unique participantId.");
		}
	}

	public static void ValidateParticipantIdsEqual(string expectedParticipantId, string actualParticipantId)
	{
		if (!expectedParticipantId.Equals(actualParticipantId))
		{
			throw new CryptoException("Received payload from incorrect partner (" + actualParticipantId + "). Expected to receive payload from " + expectedParticipantId + ".");
		}
	}

	public static void ValidateNotNull(object obj, string description)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(description);
		}
	}

	public static BigInteger CalculateMacTag(string participantId, string partnerParticipantId, BigInteger gx1, BigInteger gx2, BigInteger gx3, BigInteger gx4, BigInteger keyingMaterial, IDigest digest)
	{
		byte[] macKey = CalculateMacKey(keyingMaterial, digest);
		HMac hMac = new HMac(digest);
		hMac.Init(new KeyParameter(macKey));
		Arrays.Fill(macKey, 0);
		UpdateMac(hMac, "KC_1_U");
		UpdateMac(hMac, participantId);
		UpdateMac(hMac, partnerParticipantId);
		UpdateMac(hMac, gx1);
		UpdateMac(hMac, gx2);
		UpdateMac(hMac, gx3);
		UpdateMac(hMac, gx4);
		return new BigInteger(MacUtilities.DoFinal(hMac));
	}

	private static byte[] CalculateMacKey(BigInteger keyingMaterial, IDigest digest)
	{
		digest.Reset();
		UpdateDigest(digest, keyingMaterial);
		UpdateDigest(digest, "JPAKE_KC");
		return DigestUtilities.DoFinal(digest);
	}

	public static void ValidateMacTag(string participantId, string partnerParticipantId, BigInteger gx1, BigInteger gx2, BigInteger gx3, BigInteger gx4, BigInteger keyingMaterial, IDigest digest, BigInteger partnerMacTag)
	{
		if (!CalculateMacTag(partnerParticipantId, participantId, gx3, gx4, gx1, gx2, keyingMaterial, digest).Equals(partnerMacTag))
		{
			throw new CryptoException("Partner MacTag validation failed. Therefore, the password, MAC, or digest algorithm of each participant does not match.");
		}
	}

	private static void UpdateDigest(IDigest digest, BigInteger bigInteger)
	{
		UpdateDigest(digest, BigIntegers.AsUnsignedByteArray(bigInteger));
	}

	private static void UpdateDigest(IDigest digest, string str)
	{
		UpdateDigest(digest, Encoding.UTF8.GetBytes(str));
	}

	private static void UpdateDigest(IDigest digest, byte[] bytes)
	{
		digest.BlockUpdate(bytes, 0, bytes.Length);
		Arrays.Fill(bytes, 0);
	}

	private static void UpdateDigestIncludingSize(IDigest digest, BigInteger bigInteger)
	{
		UpdateDigestIncludingSize(digest, BigIntegers.AsUnsignedByteArray(bigInteger));
	}

	private static void UpdateDigestIncludingSize(IDigest digest, string str)
	{
		UpdateDigestIncludingSize(digest, Encoding.UTF8.GetBytes(str));
	}

	private static void UpdateDigestIncludingSize(IDigest digest, byte[] bytes)
	{
		digest.BlockUpdate(IntToByteArray(bytes.Length), 0, 4);
		digest.BlockUpdate(bytes, 0, bytes.Length);
		Arrays.Fill(bytes, 0);
	}

	private static void UpdateMac(IMac mac, BigInteger bigInteger)
	{
		UpdateMac(mac, BigIntegers.AsUnsignedByteArray(bigInteger));
	}

	private static void UpdateMac(IMac mac, string str)
	{
		UpdateMac(mac, Encoding.UTF8.GetBytes(str));
	}

	private static void UpdateMac(IMac mac, byte[] bytes)
	{
		mac.BlockUpdate(bytes, 0, bytes.Length);
		Arrays.Fill(bytes, 0);
	}

	private static byte[] IntToByteArray(int value)
	{
		return Pack.UInt32_To_BE((uint)value);
	}
}
