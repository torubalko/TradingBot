using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Apache.Bzip2;

public class CBZip2InputStream : Stream
{
	private int last;

	private int origPtr;

	private int blockSize100k;

	private bool blockRandomised;

	private int bsBuff;

	private int bsLive;

	private CRC mCrc = new CRC();

	private bool[] inUse = new bool[256];

	private int nInUse;

	private char[] seqToUnseq = new char[256];

	private char[] unseqToSeq = new char[256];

	private char[] selector = new char[18002];

	private char[] selectorMtf = new char[18002];

	private int[] tt;

	private char[] ll8;

	private int[] unzftab = new int[256];

	private int[][] limit = InitIntArray(6, 258);

	private int[][] basev = InitIntArray(6, 258);

	private int[][] perm = InitIntArray(6, 258);

	private int[] minLens = new int[6];

	private Stream bsStream;

	private bool streamEnd;

	private int currentChar = -1;

	private const int START_BLOCK_STATE = 1;

	private const int RAND_PART_A_STATE = 2;

	private const int RAND_PART_B_STATE = 3;

	private const int RAND_PART_C_STATE = 4;

	private const int NO_RAND_PART_A_STATE = 5;

	private const int NO_RAND_PART_B_STATE = 6;

	private const int NO_RAND_PART_C_STATE = 7;

	private int currentState = 1;

	private int storedBlockCRC;

	private int storedCombinedCRC;

	private int computedBlockCRC;

	private int computedCombinedCRC;

	private int i2;

	private int count;

	private int chPrev;

	private int ch2;

	private int i;

	private int tPos;

	private int rNToGo;

	private int rTPos;

	private int j2;

	private char z;

	public override bool CanRead => true;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

	public override long Length => 0L;

	public override long Position
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	private static void Cadvise()
	{
	}

	private static void CompressedStreamEOF()
	{
		Cadvise();
	}

	private void MakeMaps()
	{
		nInUse = 0;
		for (int i = 0; i < 256; i++)
		{
			if (inUse[i])
			{
				seqToUnseq[nInUse] = (char)i;
				unseqToSeq[i] = (char)nInUse;
				nInUse++;
			}
		}
	}

	public CBZip2InputStream(Stream zStream)
	{
		ll8 = null;
		tt = null;
		BsSetStream(zStream);
		Initialize();
		InitBlock();
		SetupBlock();
	}

	internal static int[][] InitIntArray(int n1, int n2)
	{
		int[][] a = new int[n1][];
		for (int k = 0; k < n1; k++)
		{
			a[k] = new int[n2];
		}
		return a;
	}

	internal static byte[][] InitByteArray(int n1, int n2)
	{
		byte[][] a = new byte[n1][];
		for (int k = 0; k < n1; k++)
		{
			a[k] = new byte[n2];
		}
		return a;
	}

	public override int ReadByte()
	{
		if (streamEnd)
		{
			return -1;
		}
		int retChar = currentChar;
		switch (currentState)
		{
		case 3:
			SetupRandPartB();
			break;
		case 4:
			SetupRandPartC();
			break;
		case 6:
			SetupNoRandPartB();
			break;
		case 7:
			SetupNoRandPartC();
			break;
		}
		return retChar;
	}

	private void Initialize()
	{
		char num = BsGetUChar();
		char magic4 = BsGetUChar();
		if (num != 'B' && magic4 != 'Z')
		{
			throw new IOException("Not a BZIP2 marked stream");
		}
		char num2 = BsGetUChar();
		magic4 = BsGetUChar();
		if (num2 != 'h' || magic4 < '1' || magic4 > '9')
		{
			BsFinishedWithStream();
			streamEnd = true;
		}
		else
		{
			SetDecompressStructureSizes(magic4 - 48);
			computedCombinedCRC = 0;
		}
	}

	private void InitBlock()
	{
		char magic1 = BsGetUChar();
		char magic2 = BsGetUChar();
		char magic3 = BsGetUChar();
		char magic4 = BsGetUChar();
		char magic5 = BsGetUChar();
		char magic6 = BsGetUChar();
		if (magic1 == '\u0017' && magic2 == 'r' && magic3 == 'E' && magic4 == '8' && magic5 == 'P' && magic6 == '\u0090')
		{
			Complete();
			return;
		}
		if (magic1 != '1' || magic2 != 'A' || magic3 != 'Y' || magic4 != '&' || magic5 != 'S' || magic6 != 'Y')
		{
			BadBlockHeader();
			streamEnd = true;
			return;
		}
		storedBlockCRC = BsGetInt32();
		blockRandomised = BsR(1) == 1;
		GetAndMoveToFrontDecode();
		mCrc.InitialiseCRC();
		currentState = 1;
	}

	private void EndBlock()
	{
		computedBlockCRC = mCrc.GetFinalCRC();
		if (storedBlockCRC != computedBlockCRC)
		{
			CrcError();
		}
		computedCombinedCRC = Integers.RotateLeft(computedCombinedCRC, 1) ^ computedBlockCRC;
	}

	private void Complete()
	{
		storedCombinedCRC = BsGetInt32();
		if (storedCombinedCRC != computedCombinedCRC)
		{
			CrcError();
		}
		BsFinishedWithStream();
		streamEnd = true;
	}

	private static void BlockOverrun()
	{
		Cadvise();
	}

	private static void BadBlockHeader()
	{
		Cadvise();
	}

	private static void CrcError()
	{
		Cadvise();
	}

	private void BsFinishedWithStream()
	{
		try
		{
			if (bsStream != null)
			{
				Platform.Dispose(bsStream);
				bsStream = null;
			}
		}
		catch
		{
		}
	}

	private void BsSetStream(Stream f)
	{
		bsStream = f;
		bsLive = 0;
		bsBuff = 0;
	}

	private int BsR(int n)
	{
		while (bsLive < n)
		{
			char thech = '\0';
			try
			{
				thech = (char)bsStream.ReadByte();
			}
			catch (IOException)
			{
				CompressedStreamEOF();
			}
			if (thech == '\uffff')
			{
				CompressedStreamEOF();
			}
			int zzi = thech;
			bsBuff = (bsBuff << 8) | (zzi & 0xFF);
			bsLive += 8;
		}
		int result = (bsBuff >> bsLive - n) & ((1 << n) - 1);
		bsLive -= n;
		return result;
	}

	private char BsGetUChar()
	{
		return (char)BsR(8);
	}

	private int BsGetint()
	{
		return (BsR(16) << 16) | BsR(16);
	}

	private int BsGetIntVS(int numBits)
	{
		return BsR(numBits);
	}

	private int BsGetInt32()
	{
		return BsGetint();
	}

	private void HbCreateDecodeTables(int[] limit, int[] basev, int[] perm, byte[] length, int minLen, int maxLen, int alphaSize)
	{
		int pp = 0;
		for (int i = minLen; i <= maxLen; i++)
		{
			for (int j = 0; j < alphaSize; j++)
			{
				if (length[j] == i)
				{
					perm[pp] = j;
					pp++;
				}
			}
		}
		for (int i = 0; i < 23; i++)
		{
			basev[i] = 0;
		}
		for (int i = 0; i < alphaSize; i++)
		{
			basev[length[i] + 1]++;
		}
		for (int i = 1; i < 23; i++)
		{
			basev[i] += basev[i - 1];
		}
		for (int i = 0; i < 23; i++)
		{
			limit[i] = 0;
		}
		int vec = 0;
		for (int i = minLen; i <= maxLen; i++)
		{
			vec += basev[i + 1] - basev[i];
			limit[i] = vec - 1;
			vec <<= 1;
		}
		for (int i = minLen + 1; i <= maxLen; i++)
		{
			basev[i] = (limit[i - 1] + 1 << 1) - basev[i];
		}
	}

	private void RecvDecodingTables()
	{
		byte[][] len = InitByteArray(6, 258);
		bool[] inUse16 = new bool[16];
		for (int i = 0; i < 16; i++)
		{
			inUse16[i] = BsR(1) == 1;
		}
		for (int i = 0; i < 16; i++)
		{
			int i16 = i * 16;
			if (inUse16[i])
			{
				for (int j = 0; j < 16; j++)
				{
					inUse[i16 + j] = BsR(1) == 1;
				}
			}
			else
			{
				for (int j = 0; j < 16; j++)
				{
					inUse[i16 + j] = false;
				}
			}
		}
		MakeMaps();
		int alphaSize = nInUse + 2;
		int nGroups = BsR(3);
		int nSelectors = BsR(15);
		for (int i = 0; i < nSelectors; i++)
		{
			int j = 0;
			while (BsR(1) == 1)
			{
				j++;
			}
			selectorMtf[i] = (char)j;
		}
		char[] pos = new char[6];
		for (char v = '\0'; v < nGroups; v = (char)(v + 1))
		{
			pos[(uint)v] = v;
		}
		for (int i = 0; i < nSelectors; i++)
		{
			char v = selectorMtf[i];
			char tmp = pos[(uint)v];
			while (v > '\0')
			{
				pos[(uint)v] = pos[v - 1];
				v = (char)(v - 1);
			}
			pos[0] = tmp;
			selector[i] = tmp;
		}
		for (int t = 0; t < nGroups; t++)
		{
			byte[] len_t = len[t];
			int curr = BsR(5);
			for (int i = 0; i < alphaSize; i++)
			{
				while (BsR(1) == 1)
				{
					curr = ((BsR(1) != 0) ? (curr - 1) : (curr + 1));
				}
				len_t[i] = (byte)curr;
			}
		}
		for (int t = 0; t < nGroups; t++)
		{
			int minLen = 32;
			int maxLen = 0;
			byte[] len_t2 = len[t];
			for (int i = 0; i < alphaSize; i++)
			{
				int lti = len_t2[i];
				if (lti > maxLen)
				{
					maxLen = lti;
				}
				if (lti < minLen)
				{
					minLen = lti;
				}
			}
			HbCreateDecodeTables(limit[t], basev[t], perm[t], len_t2, minLen, maxLen, alphaSize);
			minLens[t] = minLen;
		}
	}

	private void GetAndMoveToFrontDecode()
	{
		char[] yy = new char[256];
		int limitLast = 100000 * blockSize100k;
		origPtr = BsGetIntVS(24);
		RecvDecodingTables();
		int EOB = nInUse + 1;
		int groupNo = -1;
		int groupPos = 0;
		for (int i = 0; i <= 255; i++)
		{
			unzftab[i] = 0;
		}
		for (int i = 0; i <= 255; i++)
		{
			yy[i] = (char)i;
		}
		last = -1;
		if (groupPos == 0)
		{
			groupNo++;
			groupPos = 50;
		}
		groupPos--;
		int zt = selector[groupNo];
		int zn = minLens[zt];
		int zvec = BsR(zn);
		while (zvec > limit[zt][zn])
		{
			zn++;
			while (bsLive < 1)
			{
				char thech = '\0';
				try
				{
					thech = (char)bsStream.ReadByte();
				}
				catch (IOException)
				{
					CompressedStreamEOF();
				}
				if (thech == '\uffff')
				{
					CompressedStreamEOF();
				}
				int zzi = thech;
				bsBuff = (bsBuff << 8) | (zzi & 0xFF);
				bsLive += 8;
			}
			int zj = (bsBuff >> bsLive - 1) & 1;
			bsLive--;
			zvec = (zvec << 1) | zj;
		}
		int nextSym = perm[zt][zvec - basev[zt][zn]];
		while (nextSym != EOB)
		{
			if (nextSym == 0 || nextSym == 1)
			{
				int s = -1;
				int N = 1;
				do
				{
					switch (nextSym)
					{
					case 0:
						s += N;
						break;
					case 1:
						s += 2 * N;
						break;
					}
					N *= 2;
					if (groupPos == 0)
					{
						groupNo++;
						groupPos = 50;
					}
					groupPos--;
					int zt2 = selector[groupNo];
					int zn2 = minLens[zt2];
					int zvec2 = BsR(zn2);
					while (zvec2 > limit[zt2][zn2])
					{
						zn2++;
						while (bsLive < 1)
						{
							char thech2 = '\0';
							try
							{
								thech2 = (char)bsStream.ReadByte();
							}
							catch (IOException)
							{
								CompressedStreamEOF();
							}
							if (thech2 == '\uffff')
							{
								CompressedStreamEOF();
							}
							int zzi2 = thech2;
							bsBuff = (bsBuff << 8) | (zzi2 & 0xFF);
							bsLive += 8;
						}
						int zj2 = (bsBuff >> bsLive - 1) & 1;
						bsLive--;
						zvec2 = (zvec2 << 1) | zj2;
					}
					nextSym = perm[zt2][zvec2 - basev[zt2][zn2]];
				}
				while (nextSym == 0 || nextSym == 1);
				s++;
				char ch = seqToUnseq[(uint)yy[0]];
				unzftab[(uint)ch] += s;
				while (s > 0)
				{
					last++;
					ll8[last] = ch;
					s--;
				}
				if (last >= limitLast)
				{
					BlockOverrun();
				}
				continue;
			}
			if (++last >= limitLast)
			{
				BlockOverrun();
			}
			char tmp = yy[nextSym - 1];
			unzftab[(uint)seqToUnseq[(uint)tmp]]++;
			ll8[last] = seqToUnseq[(uint)tmp];
			if (nextSym <= 16)
			{
				for (int j = nextSym - 1; j > 0; j--)
				{
					yy[j] = yy[j - 1];
				}
			}
			else
			{
				Array.Copy(yy, 0, yy, 1, nextSym - 1);
			}
			yy[0] = tmp;
			if (groupPos == 0)
			{
				groupNo++;
				groupPos = 50;
			}
			groupPos--;
			int zt3 = selector[groupNo];
			int zn3 = minLens[zt3];
			int zvec3 = BsR(zn3);
			while (zvec3 > limit[zt3][zn3])
			{
				zn3++;
				while (bsLive < 1)
				{
					char thech3 = '\0';
					try
					{
						thech3 = (char)bsStream.ReadByte();
					}
					catch (IOException)
					{
						CompressedStreamEOF();
					}
					int zzi3 = thech3;
					bsBuff = (bsBuff << 8) | (zzi3 & 0xFF);
					bsLive += 8;
				}
				int zj3 = (bsBuff >> bsLive - 1) & 1;
				bsLive--;
				zvec3 = (zvec3 << 1) | zj3;
			}
			nextSym = perm[zt3][zvec3 - basev[zt3][zn3]];
		}
	}

	private void SetupBlock()
	{
		int[] cftab = new int[257];
		cftab[0] = 0;
		for (i = 1; i <= 256; i++)
		{
			cftab[i] = unzftab[i - 1];
		}
		for (i = 1; i <= 256; i++)
		{
			cftab[i] += cftab[i - 1];
		}
		for (i = 0; i <= last; i++)
		{
			char ch = ll8[i];
			tt[cftab[(uint)ch]] = i;
			cftab[(uint)ch]++;
		}
		cftab = null;
		tPos = tt[origPtr];
		count = 0;
		i2 = 0;
		ch2 = 256;
		if (blockRandomised)
		{
			rNToGo = 0;
			rTPos = 0;
			SetupRandPartA();
		}
		else
		{
			SetupNoRandPartA();
		}
	}

	private void SetupRandPartA()
	{
		if (i2 <= last)
		{
			chPrev = ch2;
			ch2 = ll8[tPos];
			tPos = tt[tPos];
			if (rNToGo == 0)
			{
				rNToGo = BZip2Constants.rNums[rTPos];
				rTPos++;
				if (rTPos == 512)
				{
					rTPos = 0;
				}
			}
			rNToGo--;
			ch2 ^= ((rNToGo == 1) ? 1 : 0);
			i2++;
			currentChar = ch2;
			currentState = 3;
			mCrc.UpdateCRC(ch2);
		}
		else
		{
			EndBlock();
			InitBlock();
			SetupBlock();
		}
	}

	private void SetupNoRandPartA()
	{
		if (i2 <= last)
		{
			chPrev = ch2;
			ch2 = ll8[tPos];
			tPos = tt[tPos];
			i2++;
			currentChar = ch2;
			currentState = 6;
			mCrc.UpdateCRC(ch2);
		}
		else
		{
			EndBlock();
			InitBlock();
			SetupBlock();
		}
	}

	private void SetupRandPartB()
	{
		if (ch2 != chPrev)
		{
			currentState = 2;
			count = 1;
			SetupRandPartA();
			return;
		}
		count++;
		if (count >= 4)
		{
			z = ll8[tPos];
			tPos = tt[tPos];
			if (rNToGo == 0)
			{
				rNToGo = BZip2Constants.rNums[rTPos];
				rTPos++;
				if (rTPos == 512)
				{
					rTPos = 0;
				}
			}
			rNToGo--;
			z ^= ((rNToGo == 1) ? '\u0001' : '\0');
			j2 = 0;
			currentState = 4;
			SetupRandPartC();
		}
		else
		{
			currentState = 2;
			SetupRandPartA();
		}
	}

	private void SetupRandPartC()
	{
		if (j2 < z)
		{
			currentChar = ch2;
			mCrc.UpdateCRC(ch2);
			j2++;
		}
		else
		{
			currentState = 2;
			i2++;
			count = 0;
			SetupRandPartA();
		}
	}

	private void SetupNoRandPartB()
	{
		if (ch2 != chPrev)
		{
			currentState = 5;
			count = 1;
			SetupNoRandPartA();
			return;
		}
		count++;
		if (count >= 4)
		{
			z = ll8[tPos];
			tPos = tt[tPos];
			currentState = 7;
			j2 = 0;
			SetupNoRandPartC();
		}
		else
		{
			currentState = 5;
			SetupNoRandPartA();
		}
	}

	private void SetupNoRandPartC()
	{
		if (j2 < z)
		{
			currentChar = ch2;
			mCrc.UpdateCRC(ch2);
			j2++;
		}
		else
		{
			currentState = 5;
			i2++;
			count = 0;
			SetupNoRandPartA();
		}
	}

	private void SetDecompressStructureSizes(int newSize100k)
	{
		if (0 <= newSize100k && newSize100k <= 9 && 0 <= blockSize100k)
		{
			_ = blockSize100k;
			_ = 9;
		}
		blockSize100k = newSize100k;
		if (newSize100k != 0)
		{
			int n = 100000 * newSize100k;
			ll8 = new char[n];
			tt = new int[n];
		}
	}

	public override void Flush()
	{
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int c = -1;
		int k;
		for (k = 0; k < count; k++)
		{
			c = ReadByte();
			if (c == -1)
			{
				break;
			}
			buffer[k + offset] = (byte)c;
		}
		return k;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return 0L;
	}

	public override void SetLength(long value)
	{
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
	}
}
