using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings;

public class ISO7816d4Padding : IBlockCipherPadding
{
	public string PaddingName => "ISO7816-4";

	public void Init(SecureRandom random)
	{
	}

	public int AddPadding(byte[] input, int inOff)
	{
		int added = input.Length - inOff;
		input[inOff] = 128;
		for (inOff++; inOff < input.Length; inOff++)
		{
			input[inOff] = 0;
		}
		return added;
	}

	public int PadCount(byte[] input)
	{
		int count = input.Length - 1;
		while (count > 0 && input[count] == 0)
		{
			count--;
		}
		if (input[count] != 128)
		{
			throw new InvalidCipherTextException("pad block corrupted");
		}
		return input.Length - count;
	}
}
