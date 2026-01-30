using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings;

public class X923Padding : IBlockCipherPadding
{
	private SecureRandom random;

	public string PaddingName => "X9.23";

	public void Init(SecureRandom random)
	{
		this.random = random;
	}

	public int AddPadding(byte[] input, int inOff)
	{
		byte code = (byte)(input.Length - inOff);
		while (inOff < input.Length - 1)
		{
			if (random == null)
			{
				input[inOff] = 0;
			}
			else
			{
				input[inOff] = (byte)random.NextInt();
			}
			inOff++;
		}
		input[inOff] = code;
		return code;
	}

	public int PadCount(byte[] input)
	{
		int num = input[input.Length - 1] & 0xFF;
		if (num > input.Length)
		{
			throw new InvalidCipherTextException("pad block corrupted");
		}
		return num;
	}
}
