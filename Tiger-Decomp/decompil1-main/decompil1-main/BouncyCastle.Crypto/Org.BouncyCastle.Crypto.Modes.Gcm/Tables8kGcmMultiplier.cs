using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes.Gcm;

public class Tables8kGcmMultiplier : IGcmMultiplier
{
	private byte[] H;

	private ulong[][] T;

	public void Init(byte[] H)
	{
		if (T == null)
		{
			T = new ulong[32][];
		}
		else if (Arrays.AreEqual(this.H, H))
		{
			return;
		}
		this.H = Arrays.Clone(H);
		for (int i = 0; i < 32; i++)
		{
			ulong[] t = (T[i] = new ulong[32]);
			if (i == 0)
			{
				GcmUtilities.AsUlongs(this.H, t, 2);
				GcmUtilities.MultiplyP3(t, 2, t, 2);
			}
			else
			{
				GcmUtilities.MultiplyP4(T[i - 1], 2, t, 2);
			}
			for (int n = 2; n < 16; n += 2)
			{
				GcmUtilities.DivideP(t, n, t, n << 1);
				GcmUtilities.Xor(t, n << 1, t, 2, t, n + 1 << 1);
			}
		}
	}

	public void MultiplyH(byte[] x)
	{
		ulong z0 = 0uL;
		ulong z1 = 0uL;
		for (int i = 15; i >= 0; i--)
		{
			ulong[] tu = T[i + i + 1];
			ulong[] tv = T[i + i];
			int uPos = (x[i] & 0xF) << 1;
			int vPos = (x[i] & 0xF0) >> 3;
			z0 ^= tu[uPos] ^ tv[vPos];
			z1 ^= tu[uPos + 1] ^ tv[vPos + 1];
		}
		Pack.UInt64_To_BE(z0, x, 0);
		Pack.UInt64_To_BE(z1, x, 8);
	}
}
