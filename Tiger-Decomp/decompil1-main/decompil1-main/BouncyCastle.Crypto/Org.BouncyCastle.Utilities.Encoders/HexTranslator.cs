namespace Org.BouncyCastle.Utilities.Encoders;

public class HexTranslator : ITranslator
{
	private static readonly byte[] hexTable = new byte[16]
	{
		48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
		97, 98, 99, 100, 101, 102
	};

	public int GetEncodedBlockSize()
	{
		return 2;
	}

	public int Encode(byte[] input, int inOff, int length, byte[] outBytes, int outOff)
	{
		int i = 0;
		int j = 0;
		while (i < length)
		{
			outBytes[outOff + j] = hexTable[(input[inOff] >> 4) & 0xF];
			outBytes[outOff + j + 1] = hexTable[input[inOff] & 0xF];
			inOff++;
			i++;
			j += 2;
		}
		return length * 2;
	}

	public int GetDecodedBlockSize()
	{
		return 1;
	}

	public int Decode(byte[] input, int inOff, int length, byte[] outBytes, int outOff)
	{
		int halfLength = length / 2;
		for (int i = 0; i < halfLength; i++)
		{
			byte left = input[inOff + i * 2];
			byte right = input[inOff + i * 2 + 1];
			if (left < 97)
			{
				outBytes[outOff] = (byte)(left - 48 << 4);
			}
			else
			{
				outBytes[outOff] = (byte)(left - 97 + 10 << 4);
			}
			if (right < 97)
			{
				outBytes[outOff] += (byte)(right - 48);
			}
			else
			{
				outBytes[outOff] += (byte)(right - 97 + 10);
			}
			outOff++;
		}
		return halfLength;
	}
}
