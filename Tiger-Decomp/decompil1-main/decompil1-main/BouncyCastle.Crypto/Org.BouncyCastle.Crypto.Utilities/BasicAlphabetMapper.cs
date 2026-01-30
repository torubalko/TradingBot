using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Utilities;

public class BasicAlphabetMapper : IAlphabetMapper
{
	private readonly IDictionary indexMap = Platform.CreateHashtable();

	private readonly IDictionary charMap = Platform.CreateHashtable();

	public int Radix => indexMap.Count;

	public BasicAlphabetMapper(string alphabet)
		: this(alphabet.ToCharArray())
	{
	}

	public BasicAlphabetMapper(char[] alphabet)
	{
		for (int i = 0; i != alphabet.Length; i++)
		{
			if (indexMap.Contains(alphabet[i]))
			{
				throw new ArgumentException("duplicate key detected in alphabet: " + alphabet[i]);
			}
			indexMap.Add(alphabet[i], i);
			charMap.Add(i, alphabet[i]);
		}
	}

	public byte[] ConvertToIndexes(char[] input)
	{
		byte[] outBuf;
		if (indexMap.Count <= 256)
		{
			outBuf = new byte[input.Length];
			for (int i = 0; i != input.Length; i++)
			{
				outBuf[i] = (byte)(int)indexMap[input[i]];
			}
		}
		else
		{
			outBuf = new byte[input.Length * 2];
			for (int j = 0; j != input.Length; j++)
			{
				int idx = (int)indexMap[input[j]];
				outBuf[j * 2] = (byte)((idx >> 8) & 0xFF);
				outBuf[j * 2 + 1] = (byte)(idx & 0xFF);
			}
		}
		return outBuf;
	}

	public char[] ConvertToChars(byte[] input)
	{
		char[] outBuf;
		if (charMap.Count <= 256)
		{
			outBuf = new char[input.Length];
			for (int i = 0; i != input.Length; i++)
			{
				outBuf[i] = (char)charMap[input[i] & 0xFF];
			}
		}
		else
		{
			if ((input.Length & 1) != 0)
			{
				throw new ArgumentException("two byte radix and input string odd.Length");
			}
			outBuf = new char[input.Length / 2];
			for (int j = 0; j != input.Length; j += 2)
			{
				outBuf[j / 2] = (char)charMap[((input[j] << 8) & 0xFF00) | (input[j + 1] & 0xFF)];
			}
		}
		return outBuf;
	}
}
