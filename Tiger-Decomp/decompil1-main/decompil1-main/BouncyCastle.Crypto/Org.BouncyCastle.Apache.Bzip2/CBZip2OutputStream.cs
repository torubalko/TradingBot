using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Apache.Bzip2;

public class CBZip2OutputStream : Stream
{
	internal class StackElem
	{
		internal int ll;

		internal int hh;

		internal int dd;
	}

	protected const int SETMASK = 2097152;

	protected const int CLEARMASK = -2097153;

	protected const int GREATER_ICOST = 15;

	protected const int LESSER_ICOST = 0;

	protected const int SMALL_THRESH = 20;

	protected const int DEPTH_THRESH = 10;

	private bool finished;

	private int count;

	private int origPtr;

	private readonly int blockSize100k;

	private int allowableBlockSize;

	private bool blockRandomised;

	private int bsBuff;

	private int bsLive;

	private readonly CRC mCrc = new CRC();

	private bool[] inUse = new bool[256];

	private int nInUse;

	private char[] seqToUnseq = new char[256];

	private char[] unseqToSeq = new char[256];

	private char[] selector = new char[18002];

	private char[] selectorMtf = new char[18002];

	private byte[] blockBytes;

	private ushort[] quadrantShorts;

	private int[] zptr;

	private int[] szptr;

	private int[] ftab;

	private int nMTF;

	private int[] mtfFreq = new int[258];

	private int workFactor;

	private int workDone;

	private int workLimit;

	private bool firstAttempt;

	private int currentByte = -1;

	private int runLength;

	private bool closed;

	private int blockCRC;

	private int combinedCRC;

	private Stream bsStream;

	private static readonly int[] incs = new int[14]
	{
		1, 4, 13, 40, 121, 364, 1093, 3280, 9841, 29524,
		88573, 265720, 797161, 2391484
	};

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => true;

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

	private static void Panic()
	{
		throw new InvalidOperationException();
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

	protected static void HbMakeCodeLengths(byte[] len, int[] freq, int alphaSize, int maxLen)
	{
		int[] heap = new int[260];
		int[] weight = new int[516];
		int[] parent = new int[516];
		for (int i = 0; i < alphaSize; i++)
		{
			weight[i + 1] = ((freq[i] == 0) ? 1 : freq[i]) << 8;
		}
		while (true)
		{
			int nNodes = alphaSize;
			int nHeap = 0;
			heap[0] = 0;
			weight[0] = 0;
			parent[0] = -2;
			for (int j = 1; j <= alphaSize; j++)
			{
				parent[j] = -1;
				heap[++nHeap] = j;
				int zz = nHeap;
				int tmp = heap[zz];
				while (weight[tmp] < weight[heap[zz >> 1]])
				{
					heap[zz] = heap[zz >> 1];
					zz >>= 1;
				}
				heap[zz] = tmp;
			}
			if (nHeap >= 260)
			{
				Panic();
			}
			while (nHeap > 1)
			{
				int n1 = heap[1];
				heap[1] = heap[nHeap--];
				int zz2 = 1;
				int tmp2 = heap[zz2];
				while (true)
				{
					int yy = zz2 << 1;
					if (yy > nHeap)
					{
						break;
					}
					if (yy < nHeap && weight[heap[yy + 1]] < weight[heap[yy]])
					{
						yy++;
					}
					if (weight[tmp2] < weight[heap[yy]])
					{
						break;
					}
					heap[zz2] = heap[yy];
					zz2 = yy;
				}
				heap[zz2] = tmp2;
				int n2 = heap[1];
				heap[1] = heap[nHeap--];
				int zz3 = 1;
				int tmp3 = heap[zz3];
				while (true)
				{
					int yy2 = zz3 << 1;
					if (yy2 > nHeap)
					{
						break;
					}
					if (yy2 < nHeap && weight[heap[yy2 + 1]] < weight[heap[yy2]])
					{
						yy2++;
					}
					if (weight[tmp3] < weight[heap[yy2]])
					{
						break;
					}
					heap[zz3] = heap[yy2];
					zz3 = yy2;
				}
				heap[zz3] = tmp3;
				nNodes++;
				parent[n1] = (parent[n2] = nNodes);
				weight[nNodes] = (int)((weight[n1] & 0xFFFFFF00u) + (weight[n2] & 0xFFFFFF00u)) | (1 + (((weight[n1] & 0xFF) > (weight[n2] & 0xFF)) ? (weight[n1] & 0xFF) : (weight[n2] & 0xFF)));
				parent[nNodes] = -1;
				heap[++nHeap] = nNodes;
				int zz4 = nHeap;
				int tmp4 = heap[zz4];
				while (weight[tmp4] < weight[heap[zz4 >> 1]])
				{
					heap[zz4] = heap[zz4 >> 1];
					zz4 >>= 1;
				}
				heap[zz4] = tmp4;
			}
			if (nNodes >= 516)
			{
				Panic();
			}
			bool tooLong = false;
			for (int k = 1; k <= alphaSize; k++)
			{
				int j2 = 0;
				int k2 = k;
				while (parent[k2] >= 0)
				{
					k2 = parent[k2];
					j2++;
				}
				len[k - 1] = (byte)j2;
				if (j2 > maxLen)
				{
					tooLong = true;
				}
			}
			if (tooLong)
			{
				for (int l = 1; l < alphaSize; l++)
				{
					int j3 = weight[l] >> 8;
					j3 = 1 + j3 / 2;
					weight[l] = j3 << 8;
				}
				continue;
			}
			break;
		}
	}

	public CBZip2OutputStream(Stream outStream)
		: this(outStream, 9)
	{
	}

	public CBZip2OutputStream(Stream outStream, int blockSize)
	{
		blockBytes = null;
		quadrantShorts = null;
		zptr = null;
		ftab = null;
		outStream.WriteByte(66);
		outStream.WriteByte(90);
		BsSetStream(outStream);
		workFactor = 50;
		if (blockSize > 9)
		{
			blockSize = 9;
		}
		if (blockSize < 1)
		{
			blockSize = 1;
		}
		blockSize100k = blockSize;
		AllocateCompressStructures();
		Initialize();
		InitBlock();
	}

	public override void WriteByte(byte b)
	{
		if (currentByte == b)
		{
			runLength++;
			if (runLength > 254)
			{
				WriteRun();
				currentByte = -1;
				runLength = 0;
			}
		}
		else if (currentByte == -1)
		{
			currentByte = b;
			runLength++;
		}
		else
		{
			WriteRun();
			runLength = 1;
			currentByte = b;
		}
	}

	private void WriteRun()
	{
		if (count > allowableBlockSize)
		{
			EndBlock();
			InitBlock();
		}
		inUse[currentByte] = true;
		for (int i = 0; i < runLength; i++)
		{
			mCrc.UpdateCRC(currentByte);
		}
		switch (runLength)
		{
		case 1:
			blockBytes[++count] = (byte)currentByte;
			break;
		case 2:
			blockBytes[++count] = (byte)currentByte;
			blockBytes[++count] = (byte)currentByte;
			break;
		case 3:
			blockBytes[++count] = (byte)currentByte;
			blockBytes[++count] = (byte)currentByte;
			blockBytes[++count] = (byte)currentByte;
			break;
		default:
			inUse[runLength - 4] = true;
			blockBytes[++count] = (byte)currentByte;
			blockBytes[++count] = (byte)currentByte;
			blockBytes[++count] = (byte)currentByte;
			blockBytes[++count] = (byte)currentByte;
			blockBytes[++count] = (byte)(runLength - 4);
			break;
		}
	}

	public override void Close()
	{
		if (!closed)
		{
			Finish();
			closed = true;
			Platform.Dispose(bsStream);
			base.Close();
		}
	}

	public void Finish()
	{
		if (!finished)
		{
			if (runLength > 0)
			{
				WriteRun();
			}
			currentByte = -1;
			if (count > 0)
			{
				EndBlock();
			}
			EndCompression();
			finished = true;
			Flush();
		}
	}

	public override void Flush()
	{
		bsStream.Flush();
	}

	private void Initialize()
	{
		BsPutUChar(104);
		BsPutUChar(48 + blockSize100k);
		combinedCRC = 0;
	}

	private void InitBlock()
	{
		mCrc.InitialiseCRC();
		count = 0;
		for (int i = 0; i < 256; i++)
		{
			inUse[i] = false;
		}
		allowableBlockSize = 100000 * blockSize100k - 20;
	}

	private void EndBlock()
	{
		blockCRC = mCrc.GetFinalCRC();
		combinedCRC = Integers.RotateLeft(combinedCRC, 1) ^ blockCRC;
		DoReversibleTransformation();
		BsPutUChar(49);
		BsPutUChar(65);
		BsPutUChar(89);
		BsPutUChar(38);
		BsPutUChar(83);
		BsPutUChar(89);
		BsPutint(blockCRC);
		BsW(1, blockRandomised ? 1 : 0);
		MoveToFrontCodeAndSend();
	}

	private void EndCompression()
	{
		BsPutUChar(23);
		BsPutUChar(114);
		BsPutUChar(69);
		BsPutUChar(56);
		BsPutUChar(80);
		BsPutUChar(144);
		BsPutint(combinedCRC);
		BsFinishedWithStream();
	}

	private void HbAssignCodes(int[] code, byte[] length, int minLen, int maxLen, int alphaSize)
	{
		int vec = 0;
		for (int n = minLen; n <= maxLen; n++)
		{
			for (int i = 0; i < alphaSize; i++)
			{
				if (length[i] == n)
				{
					code[i] = vec;
					vec++;
				}
			}
			vec <<= 1;
		}
	}

	private void BsSetStream(Stream f)
	{
		bsStream = f;
		bsLive = 0;
		bsBuff = 0;
	}

	private void BsFinishedWithStream()
	{
		while (bsLive > 0)
		{
			bsStream.WriteByte((byte)(bsBuff >> 24));
			bsBuff <<= 8;
			bsLive -= 8;
		}
	}

	private void BsW(int n, int v)
	{
		while (bsLive >= 8)
		{
			bsStream.WriteByte((byte)(bsBuff >> 24));
			bsBuff <<= 8;
			bsLive -= 8;
		}
		bsBuff |= v << 32 - bsLive - n;
		bsLive += n;
	}

	private void BsPutUChar(int c)
	{
		BsW(8, c);
	}

	private void BsPutint(int u)
	{
		BsW(16, (u >> 16) & 0xFFFF);
		BsW(16, u & 0xFFFF);
	}

	private void BsPutIntVS(int numBits, int c)
	{
		BsW(numBits, c);
	}

	private void SendMTFValues()
	{
		byte[][] len = CBZip2InputStream.InitByteArray(6, 258);
		int nSelectors = 0;
		int alphaSize = nInUse + 2;
		for (int t = 0; t < 6; t++)
		{
			byte[] len_t = len[t];
			for (int v = 0; v < alphaSize; v++)
			{
				len_t[v] = 15;
			}
		}
		if (nMTF <= 0)
		{
			Panic();
		}
		int nGroups = ((nMTF < 200) ? 2 : ((nMTF < 600) ? 3 : ((nMTF < 1200) ? 4 : ((nMTF >= 2400) ? 6 : 5))));
		int nPart = nGroups;
		int remF = nMTF;
		int gs = 0;
		while (nPart > 0)
		{
			int tFreq = remF / nPart;
			int ge = gs - 1;
			int aFreq;
			for (aFreq = 0; aFreq < tFreq; aFreq += mtfFreq[++ge])
			{
				if (ge >= alphaSize - 1)
				{
					break;
				}
			}
			if (ge > gs && nPart != nGroups && nPart != 1 && (nGroups - nPart) % 2 == 1)
			{
				aFreq -= mtfFreq[ge--];
			}
			byte[] len_np = len[nPart - 1];
			for (int v = 0; v < alphaSize; v++)
			{
				if (v >= gs && v <= ge)
				{
					len_np[v] = 0;
				}
				else
				{
					len_np[v] = 15;
				}
			}
			nPart--;
			gs = ge + 1;
			remF -= aFreq;
		}
		int[][] rfreq = CBZip2InputStream.InitIntArray(6, 258);
		int[] fave = new int[6];
		short[] cost = new short[6];
		byte[] len_0 = len[0];
		byte[] len_1 = len[1];
		byte[] len_2 = len[2];
		byte[] len_3 = len[3];
		byte[] len_4 = len[4];
		byte[] len_5 = len[5];
		for (int iter = 0; iter < 4; iter++)
		{
			for (int t = 0; t < nGroups; t++)
			{
				fave[t] = 0;
				int[] rfreq_t = rfreq[t];
				for (int v = 0; v < alphaSize; v++)
				{
					rfreq_t[v] = 0;
				}
			}
			nSelectors = 0;
			gs = 0;
			while (gs < nMTF)
			{
				int ge = System.Math.Min(gs + 50 - 1, nMTF - 1);
				if (nGroups == 6)
				{
					short cost2 = 0;
					short cost3 = 0;
					short cost4 = 0;
					short cost5 = 0;
					short cost6 = 0;
					short cost7 = 0;
					for (int i = gs; i <= ge; i++)
					{
						int icv = szptr[i];
						cost2 += len_0[icv];
						cost3 += len_1[icv];
						cost4 += len_2[icv];
						cost5 += len_3[icv];
						cost6 += len_4[icv];
						cost7 += len_5[icv];
					}
					cost[0] = cost2;
					cost[1] = cost3;
					cost[2] = cost4;
					cost[3] = cost5;
					cost[4] = cost6;
					cost[5] = cost7;
				}
				else
				{
					for (int t = 0; t < nGroups; t++)
					{
						cost[t] = 0;
					}
					for (int i = gs; i <= ge; i++)
					{
						int icv2 = szptr[i];
						for (int t = 0; t < nGroups; t++)
						{
							ref short reference = ref cost[t];
							reference += len[t][icv2];
						}
					}
				}
				int bc = 999999999;
				int bt = -1;
				for (int t = 0; t < nGroups; t++)
				{
					if (cost[t] < bc)
					{
						bc = cost[t];
						bt = t;
					}
				}
				fave[bt]++;
				selector[nSelectors] = (char)bt;
				nSelectors++;
				int[] rfreq_bt = rfreq[bt];
				for (int i = gs; i <= ge; i++)
				{
					rfreq_bt[szptr[i]]++;
				}
				gs = ge + 1;
			}
			for (int t = 0; t < nGroups; t++)
			{
				HbMakeCodeLengths(len[t], rfreq[t], alphaSize, 20);
			}
		}
		rfreq = null;
		fave = null;
		cost = null;
		if (nGroups >= 8)
		{
			Panic();
		}
		if (nSelectors >= 32768 || nSelectors > 18002)
		{
			Panic();
		}
		char[] pos = new char[6];
		for (int i = 0; i < nGroups; i++)
		{
			pos[i] = (char)i;
		}
		for (int i = 0; i < nSelectors; i++)
		{
			char ll_i = selector[i];
			int j = 0;
			char tmp = pos[j];
			while (ll_i != tmp)
			{
				j++;
				char tmp2 = tmp;
				tmp = pos[j];
				pos[j] = tmp2;
			}
			pos[0] = tmp;
			selectorMtf[i] = (char)j;
		}
		int[][] code = CBZip2InputStream.InitIntArray(6, 258);
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
			if (maxLen > 20)
			{
				Panic();
			}
			if (minLen < 1)
			{
				Panic();
			}
			HbAssignCodes(code[t], len[t], minLen, maxLen, alphaSize);
		}
		bool[] inUse16 = new bool[16];
		for (int i = 0; i < 16; i++)
		{
			inUse16[i] = false;
			int i16 = i * 16;
			for (int j = 0; j < 16; j++)
			{
				if (inUse[i16 + j])
				{
					inUse16[i] = true;
					break;
				}
			}
		}
		for (int i = 0; i < 16; i++)
		{
			BsW(1, inUse16[i] ? 1 : 0);
		}
		for (int i = 0; i < 16; i++)
		{
			if (inUse16[i])
			{
				int i17 = i * 16;
				for (int j = 0; j < 16; j++)
				{
					BsW(1, inUse[i17 + j] ? 1 : 0);
				}
			}
		}
		BsW(3, nGroups);
		BsW(15, nSelectors);
		for (int i = 0; i < nSelectors; i++)
		{
			int count;
			for (count = selectorMtf[i]; count >= 24; count -= 24)
			{
				BsW(24, 16777215);
			}
			BsW(count + 1, (1 << count + 1) - 2);
		}
		for (int t = 0; t < nGroups; t++)
		{
			byte[] len_t3 = len[t];
			int curr = len_t3[0];
			BsW(5, curr);
			for (int i = 0; i < alphaSize; i++)
			{
				int lti2;
				for (lti2 = len_t3[i]; curr < lti2; curr++)
				{
					BsW(2, 2);
				}
				while (curr > lti2)
				{
					BsW(2, 3);
					curr--;
				}
				BsW(1, 0);
			}
		}
		int selCtr = 0;
		gs = 0;
		while (gs < nMTF)
		{
			int ge = System.Math.Min(gs + 50 - 1, nMTF - 1);
			int selector_selCtr = selector[selCtr];
			byte[] len_selCtr = len[selector_selCtr];
			int[] code_selCtr = code[selector_selCtr];
			for (int i = gs; i <= ge; i++)
			{
				int sfmap_i = szptr[i];
				BsW(len_selCtr[sfmap_i], code_selCtr[sfmap_i]);
			}
			gs = ge + 1;
			selCtr++;
		}
		if (selCtr != nSelectors)
		{
			Panic();
		}
	}

	private void MoveToFrontCodeAndSend()
	{
		BsPutIntVS(24, origPtr);
		GenerateMTFValues();
		SendMTFValues();
	}

	private void SimpleSort(int lo, int hi, int d)
	{
		int bigN = hi - lo + 1;
		if (bigN < 2)
		{
			return;
		}
		int hp;
		for (hp = 0; incs[hp] < bigN; hp++)
		{
		}
		for (hp--; hp >= 0; hp--)
		{
			int h = incs[hp];
			int i = lo + h;
			while (i <= hi)
			{
				int v = zptr[i];
				int j = i;
				while (FullGtU(zptr[j - h] + d, v + d))
				{
					zptr[j] = zptr[j - h];
					j -= h;
					if (j <= lo + h - 1)
					{
						break;
					}
				}
				zptr[j] = v;
				if (++i > hi)
				{
					break;
				}
				v = zptr[i];
				j = i;
				while (FullGtU(zptr[j - h] + d, v + d))
				{
					zptr[j] = zptr[j - h];
					j -= h;
					if (j <= lo + h - 1)
					{
						break;
					}
				}
				zptr[j] = v;
				if (++i > hi)
				{
					break;
				}
				v = zptr[i];
				j = i;
				while (FullGtU(zptr[j - h] + d, v + d))
				{
					zptr[j] = zptr[j - h];
					j -= h;
					if (j <= lo + h - 1)
					{
						break;
					}
				}
				zptr[j] = v;
				i++;
				if (workDone > workLimit && firstAttempt)
				{
					return;
				}
			}
		}
	}

	private void Vswap(int p1, int p2, int n)
	{
		while (--n >= 0)
		{
			int t1 = zptr[p1];
			int t2 = zptr[p2];
			zptr[p1++] = t2;
			zptr[p2++] = t1;
		}
	}

	private int Med3(int a, int b, int c)
	{
		if (a <= b)
		{
			if (c >= a)
			{
				if (c <= b)
				{
					return c;
				}
				return b;
			}
			return a;
		}
		if (c >= b)
		{
			if (c <= a)
			{
				return c;
			}
			return a;
		}
		return b;
	}

	private static void PushStackElem(IList stack, int stackCount, int ll, int hh, int dd)
	{
		StackElem stackElem;
		if (stackCount < stack.Count)
		{
			stackElem = (StackElem)stack[stackCount];
		}
		else
		{
			stackElem = new StackElem();
			stack.Add(stackElem);
		}
		stackElem.ll = ll;
		stackElem.hh = hh;
		stackElem.dd = dd;
	}

	private void QSort3(int loSt, int hiSt, int dSt)
	{
		IList stack = Platform.CreateArrayList();
		int stackCount = 0;
		int lo = loSt;
		int hi = hiSt;
		int d = dSt;
		while (true)
		{
			if (hi - lo < 20 || d > 10)
			{
				SimpleSort(lo, hi, d);
				if (stackCount < 1 || (workDone > workLimit && firstAttempt))
				{
					break;
				}
				StackElem obj = (StackElem)stack[--stackCount];
				lo = obj.ll;
				hi = obj.hh;
				d = obj.dd;
				continue;
			}
			int d2 = d + 1;
			int med = Med3(blockBytes[zptr[lo] + d2], blockBytes[zptr[hi] + d2], blockBytes[zptr[lo + hi >> 1] + d2]);
			int ltLo;
			int unLo = (ltLo = lo);
			int gtHi;
			int unHi = (gtHi = hi);
			int n;
			while (true)
			{
				if (unLo <= unHi)
				{
					int zUnLo = zptr[unLo];
					n = blockBytes[zUnLo + d2] - med;
					if (n <= 0)
					{
						if (n == 0)
						{
							zptr[unLo] = zptr[ltLo];
							zptr[ltLo++] = zUnLo;
						}
						unLo++;
						continue;
					}
				}
				while (unLo <= unHi)
				{
					int zUnHi = zptr[unHi];
					n = blockBytes[zUnHi + d2] - med;
					if (n < 0)
					{
						break;
					}
					if (n == 0)
					{
						zptr[unHi] = zptr[gtHi];
						zptr[gtHi--] = zUnHi;
					}
					unHi--;
				}
				if (unLo > unHi)
				{
					break;
				}
				int temp = zptr[unLo];
				zptr[unLo++] = zptr[unHi];
				zptr[unHi--] = temp;
			}
			if (gtHi < ltLo)
			{
				d = d2;
				continue;
			}
			n = System.Math.Min(ltLo - lo, unLo - ltLo);
			Vswap(lo, unLo - n, n);
			int m = System.Math.Min(hi - gtHi, gtHi - unHi);
			Vswap(unLo, hi - m + 1, m);
			n = lo + (unLo - ltLo);
			m = hi - (gtHi - unHi);
			PushStackElem(stack, stackCount++, lo, n - 1, d);
			PushStackElem(stack, stackCount++, n, m, d2);
			lo = m + 1;
		}
	}

	private void MainSort()
	{
		int[] runningOrder = new int[256];
		int[] copy = new int[256];
		bool[] bigDone = new bool[256];
		for (int i = 0; i < 20; i++)
		{
			blockBytes[count + i + 1] = blockBytes[i % count + 1];
		}
		for (int i = 0; i <= count + 20; i++)
		{
			quadrantShorts[i] = 0;
		}
		blockBytes[0] = blockBytes[count];
		if (count <= 4000)
		{
			for (int i = 0; i < count; i++)
			{
				zptr[i] = i;
			}
			firstAttempt = false;
			workDone = (workLimit = 0);
			SimpleSort(0, count - 1, 0);
			return;
		}
		for (int i = 0; i <= 255; i++)
		{
			bigDone[i] = false;
		}
		for (int i = 0; i <= 65536; i++)
		{
			ftab[i] = 0;
		}
		int c1 = blockBytes[0];
		for (int i = 1; i <= count; i++)
		{
			int c2 = blockBytes[i];
			ftab[(c1 << 8) + c2]++;
			c1 = c2;
		}
		for (int i = 0; i < 65536; i++)
		{
			ftab[i + 1] += ftab[i];
		}
		c1 = blockBytes[1];
		int j;
		for (int i = 0; i < count - 1; i++)
		{
			int c2 = blockBytes[i + 2];
			j = (c1 << 8) + c2;
			c1 = c2;
			ftab[j]--;
			zptr[ftab[j]] = i;
		}
		j = (blockBytes[count] << 8) + blockBytes[1];
		ftab[j]--;
		zptr[ftab[j]] = count - 1;
		for (int i = 0; i <= 255; i++)
		{
			runningOrder[i] = i;
		}
		int h = 1;
		do
		{
			h = 3 * h + 1;
		}
		while (h <= 256);
		do
		{
			h /= 3;
			for (int i = h; i <= 255; i++)
			{
				int vv = runningOrder[i];
				j = i;
				while (ftab[runningOrder[j - h] + 1 << 8] - ftab[runningOrder[j - h] << 8] > ftab[vv + 1 << 8] - ftab[vv << 8])
				{
					runningOrder[j] = runningOrder[j - h];
					j -= h;
					if (j < h)
					{
						break;
					}
				}
				runningOrder[j] = vv;
			}
		}
		while (h != 1);
		for (int i = 0; i <= 255; i++)
		{
			int ss = runningOrder[i];
			for (j = 0; j <= 255; j++)
			{
				int sb = (ss << 8) + j;
				if ((ftab[sb] & 0x200000) == 2097152)
				{
					continue;
				}
				int lo = ftab[sb] & -2097153;
				int hi = (ftab[sb + 1] & -2097153) - 1;
				if (hi > lo)
				{
					QSort3(lo, hi, 2);
					if (workDone > workLimit && firstAttempt)
					{
						return;
					}
				}
				ftab[sb] |= 2097152;
			}
			bigDone[ss] = true;
			if (i < 255)
			{
				int bbStart = ftab[ss << 8] & -2097153;
				int bbSize = (ftab[ss + 1 << 8] & -2097153) - bbStart;
				int shifts;
				for (shifts = 0; bbSize >> shifts > 65534; shifts++)
				{
				}
				for (j = 0; j < bbSize; j++)
				{
					int a2update = zptr[bbStart + j] + 1;
					ushort qVal = (ushort)(j >> shifts);
					quadrantShorts[a2update] = qVal;
					if (a2update <= 20)
					{
						quadrantShorts[a2update + count] = qVal;
					}
				}
				if (bbSize - 1 >> shifts > 65535)
				{
					Panic();
				}
			}
			for (j = 0; j <= 255; j++)
			{
				copy[j] = ftab[(j << 8) + ss] & -2097153;
			}
			for (j = ftab[ss << 8] & -2097153; j < (ftab[ss + 1 << 8] & -2097153); j++)
			{
				int zptr_j = zptr[j];
				c1 = blockBytes[zptr_j];
				if (!bigDone[c1])
				{
					zptr[copy[c1]] = ((zptr_j == 0) ? count : zptr_j) - 1;
					copy[c1]++;
				}
			}
			for (j = 0; j <= 255; j++)
			{
				ftab[(j << 8) + ss] |= 2097152;
			}
		}
	}

	private void RandomiseBlock()
	{
		for (int i = 0; i < 256; i++)
		{
			inUse[i] = false;
		}
		int rNToGo = 0;
		int rTPos = 0;
		for (int j = 0; j < count; j++)
		{
			if (rNToGo == 0)
			{
				rNToGo = BZip2Constants.rNums[rTPos];
				if (++rTPos == 512)
				{
					rTPos = 0;
				}
			}
			rNToGo--;
			blockBytes[j + 1] ^= ((rNToGo == 1) ? ((byte)1) : ((byte)0));
			inUse[blockBytes[j + 1]] = true;
		}
	}

	private void DoReversibleTransformation()
	{
		workLimit = workFactor * (count - 1);
		workDone = 0;
		blockRandomised = false;
		firstAttempt = true;
		MainSort();
		if (workDone > workLimit && firstAttempt)
		{
			RandomiseBlock();
			workLimit = (workDone = 0);
			blockRandomised = true;
			firstAttempt = false;
			MainSort();
		}
		origPtr = -1;
		for (int i = 0; i < count; i++)
		{
			if (zptr[i] == 0)
			{
				origPtr = i;
				break;
			}
		}
		if (origPtr == -1)
		{
			Panic();
		}
	}

	private bool FullGtU(int i1, int i2)
	{
		int c1 = blockBytes[++i1];
		int c2 = blockBytes[++i2];
		if (c1 != c2)
		{
			return c1 > c2;
		}
		c1 = blockBytes[++i1];
		c2 = blockBytes[++i2];
		if (c1 != c2)
		{
			return c1 > c2;
		}
		c1 = blockBytes[++i1];
		c2 = blockBytes[++i2];
		if (c1 != c2)
		{
			return c1 > c2;
		}
		c1 = blockBytes[++i1];
		c2 = blockBytes[++i2];
		if (c1 != c2)
		{
			return c1 > c2;
		}
		c1 = blockBytes[++i1];
		c2 = blockBytes[++i2];
		if (c1 != c2)
		{
			return c1 > c2;
		}
		c1 = blockBytes[++i1];
		c2 = blockBytes[++i2];
		if (c1 != c2)
		{
			return c1 > c2;
		}
		int k = count;
		do
		{
			c1 = blockBytes[++i1];
			c2 = blockBytes[++i2];
			if (c1 != c2)
			{
				return c1 > c2;
			}
			int s1 = quadrantShorts[i1];
			int s2 = quadrantShorts[i2];
			if (s1 != s2)
			{
				return s1 > s2;
			}
			c1 = blockBytes[++i1];
			c2 = blockBytes[++i2];
			if (c1 != c2)
			{
				return c1 > c2;
			}
			s1 = quadrantShorts[i1];
			s2 = quadrantShorts[i2];
			if (s1 != s2)
			{
				return s1 > s2;
			}
			c1 = blockBytes[++i1];
			c2 = blockBytes[++i2];
			if (c1 != c2)
			{
				return c1 > c2;
			}
			s1 = quadrantShorts[i1];
			s2 = quadrantShorts[i2];
			if (s1 != s2)
			{
				return s1 > s2;
			}
			c1 = blockBytes[++i1];
			c2 = blockBytes[++i2];
			if (c1 != c2)
			{
				return c1 > c2;
			}
			s1 = quadrantShorts[i1];
			s2 = quadrantShorts[i2];
			if (s1 != s2)
			{
				return s1 > s2;
			}
			if (i1 >= count)
			{
				i1 -= count;
			}
			if (i2 >= count)
			{
				i2 -= count;
			}
			k -= 4;
			workDone++;
		}
		while (k >= 0);
		return false;
	}

	private void AllocateCompressStructures()
	{
		int n = 100000 * blockSize100k;
		blockBytes = new byte[n + 1 + 20];
		quadrantShorts = new ushort[n + 1 + 20];
		zptr = new int[n];
		ftab = new int[65537];
		szptr = zptr;
	}

	private void GenerateMTFValues()
	{
		char[] yy = new char[256];
		MakeMaps();
		int EOB = nInUse + 1;
		for (int i = 0; i <= EOB; i++)
		{
			mtfFreq[i] = 0;
		}
		int wr = 0;
		int zPend = 0;
		for (int i = 0; i < nInUse; i++)
		{
			yy[i] = (char)i;
		}
		for (int i = 0; i < count; i++)
		{
			char ll_i = unseqToSeq[blockBytes[zptr[i]]];
			int j = 0;
			char tmp = yy[j];
			while (ll_i != tmp)
			{
				j++;
				char tmp2 = tmp;
				tmp = yy[j];
				yy[j] = tmp2;
			}
			yy[0] = tmp;
			if (j == 0)
			{
				zPend++;
				continue;
			}
			if (zPend > 0)
			{
				zPend--;
				while (true)
				{
					switch (zPend % 2)
					{
					case 0:
						szptr[wr++] = 0;
						mtfFreq[0]++;
						break;
					case 1:
						szptr[wr++] = 1;
						mtfFreq[1]++;
						break;
					}
					if (zPend < 2)
					{
						break;
					}
					zPend = (zPend - 2) / 2;
				}
				zPend = 0;
			}
			szptr[wr++] = j + 1;
			mtfFreq[j + 1]++;
		}
		if (zPend > 0)
		{
			zPend--;
			while (true)
			{
				switch (zPend % 2)
				{
				case 0:
					szptr[wr++] = 0;
					mtfFreq[0]++;
					break;
				case 1:
					szptr[wr++] = 1;
					mtfFreq[1]++;
					break;
				}
				if (zPend < 2)
				{
					break;
				}
				zPend = (zPend - 2) / 2;
			}
		}
		szptr[wr++] = EOB;
		mtfFreq[EOB]++;
		nMTF = wr;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return 0;
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
		for (int k = 0; k < count; k++)
		{
			WriteByte(buffer[k + offset]);
		}
	}
}
