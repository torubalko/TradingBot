using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators;

public class Pkcs12ParametersGenerator : PbeParametersGenerator
{
	public const int KeyMaterial = 1;

	public const int IVMaterial = 2;

	public const int MacMaterial = 3;

	private readonly IDigest digest;

	private readonly int u;

	private readonly int v;

	public Pkcs12ParametersGenerator(IDigest digest)
	{
		this.digest = digest;
		u = digest.GetDigestSize();
		v = digest.GetByteLength();
	}

	private void Adjust(byte[] a, int aOff, byte[] b)
	{
		int x = (b[b.Length - 1] & 0xFF) + (a[aOff + b.Length - 1] & 0xFF) + 1;
		a[aOff + b.Length - 1] = (byte)x;
		x >>>= 8;
		for (int i = b.Length - 2; i >= 0; i--)
		{
			x += (b[i] & 0xFF) + (a[aOff + i] & 0xFF);
			a[aOff + i] = (byte)x;
			x >>>= 8;
		}
	}

	private byte[] GenerateDerivedKey(int idByte, int n)
	{
		byte[] D = new byte[v];
		byte[] dKey = new byte[n];
		for (int i = 0; i != D.Length; i++)
		{
			D[i] = (byte)idByte;
		}
		byte[] S;
		if (mSalt != null && mSalt.Length != 0)
		{
			S = new byte[v * ((mSalt.Length + v - 1) / v)];
			for (int j = 0; j != S.Length; j++)
			{
				S[j] = mSalt[j % mSalt.Length];
			}
		}
		else
		{
			S = new byte[0];
		}
		byte[] P;
		if (mPassword != null && mPassword.Length != 0)
		{
			P = new byte[v * ((mPassword.Length + v - 1) / v)];
			for (int k = 0; k != P.Length; k++)
			{
				P[k] = mPassword[k % mPassword.Length];
			}
		}
		else
		{
			P = new byte[0];
		}
		byte[] I = new byte[S.Length + P.Length];
		Array.Copy(S, 0, I, 0, S.Length);
		Array.Copy(P, 0, I, S.Length, P.Length);
		byte[] B = new byte[v];
		int c = (n + u - 1) / u;
		byte[] A = new byte[u];
		for (int l = 1; l <= c; l++)
		{
			digest.BlockUpdate(D, 0, D.Length);
			digest.BlockUpdate(I, 0, I.Length);
			digest.DoFinal(A, 0);
			for (int m = 1; m != mIterationCount; m++)
			{
				digest.BlockUpdate(A, 0, A.Length);
				digest.DoFinal(A, 0);
			}
			for (int num = 0; num != B.Length; num++)
			{
				B[num] = A[num % A.Length];
			}
			for (int num2 = 0; num2 != I.Length / v; num2++)
			{
				Adjust(I, num2 * v, B);
			}
			if (l == c)
			{
				Array.Copy(A, 0, dKey, (l - 1) * u, dKey.Length - (l - 1) * u);
			}
			else
			{
				Array.Copy(A, 0, dKey, (l - 1) * u, A.Length);
			}
		}
		return dKey;
	}

	public override ICipherParameters GenerateDerivedParameters(int keySize)
	{
		keySize /= 8;
		return new KeyParameter(GenerateDerivedKey(1, keySize), 0, keySize);
	}

	public override ICipherParameters GenerateDerivedParameters(string algorithm, int keySize)
	{
		keySize /= 8;
		byte[] dKey = GenerateDerivedKey(1, keySize);
		return ParameterUtilities.CreateKeyParameter(algorithm, dKey, 0, keySize);
	}

	public override ICipherParameters GenerateDerivedParameters(int keySize, int ivSize)
	{
		keySize /= 8;
		ivSize /= 8;
		byte[] key = GenerateDerivedKey(1, keySize);
		return new ParametersWithIV(iv: GenerateDerivedKey(2, ivSize), parameters: new KeyParameter(key, 0, keySize), ivOff: 0, ivLen: ivSize);
	}

	public override ICipherParameters GenerateDerivedParameters(string algorithm, int keySize, int ivSize)
	{
		keySize /= 8;
		ivSize /= 8;
		byte[] dKey = GenerateDerivedKey(1, keySize);
		KeyParameter parameters = ParameterUtilities.CreateKeyParameter(algorithm, dKey, 0, keySize);
		byte[] iv = GenerateDerivedKey(2, ivSize);
		return new ParametersWithIV(parameters, iv, 0, ivSize);
	}

	public override ICipherParameters GenerateDerivedMacParameters(int keySize)
	{
		keySize /= 8;
		return new KeyParameter(GenerateDerivedKey(3, keySize), 0, keySize);
	}
}
