using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings;

public class Pkcs7Padding : IBlockCipherPadding
{
	public string PaddingName => "PKCS7";

	public void Init(SecureRandom random)
	{
	}

	public int AddPadding(byte[] input, int inOff)
	{
		byte code = (byte)(input.Length - inOff);
		while (inOff < input.Length)
		{
			input[inOff] = code;
			inOff++;
		}
		return code;
	}

	public int PadCount(byte[] input)
	{
		byte countAsByte = input[input.Length - 1];
		int count = countAsByte;
		if (count < 1 || count > input.Length)
		{
			throw new InvalidCipherTextException("pad block corrupted");
		}
		for (int i = 2; i <= count; i++)
		{
			if (input[input.Length - i] != countAsByte)
			{
				throw new InvalidCipherTextException("pad block corrupted");
			}
		}
		return count;
	}
}
