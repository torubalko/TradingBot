using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings;

public class ZeroBytePadding : IBlockCipherPadding
{
	public string PaddingName => "ZeroBytePadding";

	public void Init(SecureRandom random)
	{
	}

	public int AddPadding(byte[] input, int inOff)
	{
		int added = input.Length - inOff;
		while (inOff < input.Length)
		{
			input[inOff] = 0;
			inOff++;
		}
		return added;
	}

	public int PadCount(byte[] input)
	{
		int count = input.Length;
		while (count > 0 && input[count - 1] == 0)
		{
			count--;
		}
		return input.Length - count;
	}
}
