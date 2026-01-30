using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings;

public class TbcPadding : IBlockCipherPadding
{
	public string PaddingName => "TBC";

	public virtual void Init(SecureRandom random)
	{
	}

	public virtual int AddPadding(byte[] input, int inOff)
	{
		int count = input.Length - inOff;
		byte code = ((inOff <= 0) ? ((byte)(((input[input.Length - 1] & 1) == 0) ? 255u : 0u)) : ((byte)(((input[inOff - 1] & 1) == 0) ? 255u : 0u)));
		while (inOff < input.Length)
		{
			input[inOff] = code;
			inOff++;
		}
		return count;
	}

	public virtual int PadCount(byte[] input)
	{
		byte code = input[input.Length - 1];
		int index = input.Length - 1;
		while (index > 0 && input[index - 1] == code)
		{
			index--;
		}
		return input.Length - index;
	}
}
