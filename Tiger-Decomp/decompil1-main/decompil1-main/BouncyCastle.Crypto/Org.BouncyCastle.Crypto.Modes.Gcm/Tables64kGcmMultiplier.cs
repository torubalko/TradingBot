using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes.Gcm;

public class Tables64kGcmMultiplier : IGcmMultiplier
{
	private byte[] H;

	private ulong[][] T;

	public void Init(byte[] H)
	{
		if (T == null)
		{
			T = new ulong[16][];
		}
		else if (Arrays.AreEqual(this.H, H))
		{
			return;
		}
		this.H = Arrays.Clone(H);
		for (int i = 0; i < 16; i++)
		{
			ulong[] t = (T[i] = new ulong[512]);
			if (i == 0)
			{
				GcmUtilities.AsUlongs(this.H, t, 2);
				GcmUtilities.MultiplyP7(t, 2, t, 2);
			}
			else
			{
				GcmUtilities.MultiplyP8(T[i - 1], 2, t, 2);
			}
			for (int n = 2; n < 256; n += 2)
			{
				GcmUtilities.DivideP(t, n, t, n << 1);
				GcmUtilities.Xor(t, n << 1, t, 2, t, n + 1 << 1);
			}
		}
	}

	public void MultiplyH(byte[] x)
	{
		ulong[] t = T[15];
		int tPos = x[15] << 1;
		ulong z0 = t[tPos];
		ulong z1 = t[tPos + 1];
		for (int i = 14; i >= 0; i--)
		{
			t = T[i];
			tPos = x[i] << 1;
			z0 ^= t[tPos];
			z1 ^= t[tPos + 1];
		}
		Pack.UInt64_To_BE(z0, x, 0);
		Pack.UInt64_To_BE(z1, x, 8);
	}
}
