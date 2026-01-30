using System;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Generators;

public class KdfCounterBytesGenerator : IMacDerivationFunction, IDerivationFunction
{
	private static readonly BigInteger IntegerMax = BigInteger.ValueOf(2147483647L);

	private static readonly BigInteger Two = BigInteger.Two;

	private readonly IMac prf;

	private readonly int h;

	private byte[] fixedInputDataCtrPrefix;

	private byte[] fixedInputData_afterCtr;

	private int maxSizeExcl;

	private byte[] ios;

	private int generatedBytes;

	private byte[] k;

	public IDigest Digest
	{
		get
		{
			if (!(prf is HMac))
			{
				return null;
			}
			return ((HMac)prf).GetUnderlyingDigest();
		}
	}

	public KdfCounterBytesGenerator(IMac prf)
	{
		this.prf = prf;
		h = prf.GetMacSize();
		k = new byte[h];
	}

	public void Init(IDerivationParameters param)
	{
		if (!(param is KdfCounterParameters kdfParams))
		{
			throw new ArgumentException("Wrong type of arguments given");
		}
		prf.Init(new KeyParameter(kdfParams.Ki));
		fixedInputDataCtrPrefix = kdfParams.FixedInputDataCounterPrefix;
		fixedInputData_afterCtr = kdfParams.FixedInputDataCounterSuffix;
		int r = kdfParams.R;
		ios = new byte[r / 8];
		BigInteger maxSize = Two.Pow(r).Multiply(BigInteger.ValueOf(h));
		maxSizeExcl = ((maxSize.CompareTo(IntegerMax) == 1) ? int.MaxValue : maxSize.IntValue);
		generatedBytes = 0;
	}

	public IMac GetMac()
	{
		return prf;
	}

	public int GenerateBytes(byte[] output, int outOff, int length)
	{
		int generatedBytesAfter = generatedBytes + length;
		if (generatedBytesAfter < 0 || generatedBytesAfter >= maxSizeExcl)
		{
			throw new DataLengthException("Current KDFCTR may only be used for " + maxSizeExcl + " bytes");
		}
		if (generatedBytes % h == 0)
		{
			generateNext();
		}
		int toGenerate = length;
		int posInK = generatedBytes % h;
		int toCopy = System.Math.Min(h - generatedBytes % h, toGenerate);
		Array.Copy(k, posInK, output, outOff, toCopy);
		generatedBytes += toCopy;
		toGenerate -= toCopy;
		outOff += toCopy;
		while (toGenerate > 0)
		{
			generateNext();
			toCopy = System.Math.Min(h, toGenerate);
			Array.Copy(k, 0, output, outOff, toCopy);
			generatedBytes += toCopy;
			toGenerate -= toCopy;
			outOff += toCopy;
		}
		return length;
	}

	private void generateNext()
	{
		int i = generatedBytes / h + 1;
		switch (ios.Length)
		{
		case 4:
			ios[0] = (byte)(i >> 24);
			goto case 3;
		case 3:
			ios[ios.Length - 3] = (byte)(i >> 16);
			goto case 2;
		case 2:
			ios[ios.Length - 2] = (byte)(i >> 8);
			goto case 1;
		case 1:
			ios[ios.Length - 1] = (byte)i;
			prf.BlockUpdate(fixedInputDataCtrPrefix, 0, fixedInputDataCtrPrefix.Length);
			prf.BlockUpdate(ios, 0, ios.Length);
			prf.BlockUpdate(fixedInputData_afterCtr, 0, fixedInputData_afterCtr.Length);
			prf.DoFinal(k, 0);
			break;
		default:
			throw new InvalidOperationException("Unsupported size of counter i");
		}
	}
}
