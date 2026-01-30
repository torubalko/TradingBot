using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class DesEdeEngine : DesEngine
{
	private int[] workingKey1;

	private int[] workingKey2;

	private int[] workingKey3;

	private bool forEncryption;

	public override string AlgorithmName => "DESede";

	public override void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (!(parameters is KeyParameter))
		{
			throw new ArgumentException("invalid parameter passed to DESede init - " + Platform.GetTypeName(parameters));
		}
		byte[] keyMaster = ((KeyParameter)parameters).GetKey();
		if (keyMaster.Length != 24 && keyMaster.Length != 16)
		{
			throw new ArgumentException("key size must be 16 or 24 bytes.");
		}
		this.forEncryption = forEncryption;
		byte[] key1 = new byte[8];
		Array.Copy(keyMaster, 0, key1, 0, key1.Length);
		workingKey1 = DesEngine.GenerateWorkingKey(forEncryption, key1);
		byte[] key2 = new byte[8];
		Array.Copy(keyMaster, 8, key2, 0, key2.Length);
		workingKey2 = DesEngine.GenerateWorkingKey(!forEncryption, key2);
		if (keyMaster.Length == 24)
		{
			byte[] key3 = new byte[8];
			Array.Copy(keyMaster, 16, key3, 0, key3.Length);
			workingKey3 = DesEngine.GenerateWorkingKey(forEncryption, key3);
		}
		else
		{
			workingKey3 = workingKey1;
		}
	}

	public override int GetBlockSize()
	{
		return 8;
	}

	public override int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		if (workingKey1 == null)
		{
			throw new InvalidOperationException("DESede engine not initialised");
		}
		Check.DataLength(input, inOff, 8, "input buffer too short");
		Check.OutputLength(output, outOff, 8, "output buffer too short");
		byte[] temp = new byte[8];
		if (forEncryption)
		{
			DesEngine.DesFunc(workingKey1, input, inOff, temp, 0);
			DesEngine.DesFunc(workingKey2, temp, 0, temp, 0);
			DesEngine.DesFunc(workingKey3, temp, 0, output, outOff);
		}
		else
		{
			DesEngine.DesFunc(workingKey3, input, inOff, temp, 0);
			DesEngine.DesFunc(workingKey2, temp, 0, temp, 0);
			DesEngine.DesFunc(workingKey1, temp, 0, output, outOff);
		}
		return 8;
	}

	public override void Reset()
	{
	}
}
