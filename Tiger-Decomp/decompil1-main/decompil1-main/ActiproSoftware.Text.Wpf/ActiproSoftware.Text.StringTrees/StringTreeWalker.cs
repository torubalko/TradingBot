using System;
using System.Collections.Generic;
using System.IO;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.StringTrees;

internal class StringTreeWalker : ITextBufferReader
{
	private struct fF
	{
		private IStringTreeNode pq6;

		private int RqZ;

		private int tq0;

		private int Tqv;

		private string AqY;

		private Stack<lg> Tqo;

		private int FqD;

		private int mq1;

		internal static object yfP;

		internal fF(StringTreeWalker P_0)
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			pq6 = P_0.wAb;
			RqZ = P_0.fAC;
			tq0 = P_0.tAU;
			Tqv = P_0.sAa;
			AqY = P_0.GAj;
			Tqo = new Stack<lg>(P_0.vAF.ToArray());
			FqD = P_0.fAx;
			mq1 = P_0.nAg;
		}

		internal void mq5(StringTreeWalker P_0)
		{
			P_0.wAb = pq6;
			P_0.fAC = RqZ;
			P_0.tAU = tq0;
			P_0.sAa = Tqv;
			P_0.GAj = AqY;
			P_0.vAF = new Stack<lg>(Tqo.ToArray());
			P_0.fAx = FqD;
			P_0.nAg = mq1;
		}

		internal static bool rfU()
		{
			return yfP == null;
		}

		internal static object Df2()
		{
			return yfP;
		}
	}

	private class nx : TextReader
	{
		private StringTreeWalker Eq4;

		private static nx hfq;

		internal nx(StringTreeWalker P_0)
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
			if (P_0 == null)
			{
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(18090));
			}
			Eq4 = P_0;
		}

		public override void Close()
		{
			Dispose(_0020: true);
		}

		protected override void Dispose(bool P_0)
		{
			Eq4 = null;
			base.Dispose(P_0);
		}

		public override int Peek()
		{
			if (Eq4 == null)
			{
				throw new InvalidOperationException(SR.GetString(SRName.ExReaderClosed));
			}
			if (Eq4.IsAtEnd)
			{
				return -1;
			}
			return Eq4.Peek();
		}

		public override int Read()
		{
			if (Eq4 != null)
			{
				if (Eq4.IsAtEnd)
				{
					return -1;
				}
				return Eq4.Read();
			}
			throw new InvalidOperationException(SR.GetString(SRName.ExReaderClosed));
		}

		public override int Read(char[] P_0, int P_1, int P_2)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(18106));
			}
			if (P_1 < 0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5502));
			}
			if (P_2 < 0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6022));
			}
			if (P_0.Length - P_1 < P_2)
			{
				throw new ArgumentException(SR.GetString(SRName.ExInvalidOffsetLength));
			}
			bool flag = Eq4 == null;
			int num = 0;
			if (dff() == null)
			{
				num = 1;
			}
			int result = default(int);
			int num3 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					return result;
				case 1:
				{
					if (flag)
					{
						throw new InvalidOperationException(SR.GetString(SRName.ExReaderClosed));
					}
					int num2 = Eq4.Length - Eq4.Offset;
					if (num2 > 0)
					{
						if (num2 > P_2)
						{
							num2 = P_2;
						}
						Eq4.wAO.CopyTo(Eq4.Offset, P_0, P_1, num2);
						Eq4.Offset += num2;
					}
					result = num2;
					num = 0;
					if (dff() != null)
					{
						num = num3;
					}
					break;
				}
				}
			}
		}

		public override string ReadLine()
		{
			if (Eq4 == null)
			{
				throw new InvalidOperationException(SR.GetString(SRName.ExReaderClosed));
			}
			int offset = Eq4.Offset;
			if (Eq4.ReadThrough('\n'))
			{
				return Eq4.GetSubstring(offset, Eq4.Offset - offset - 1);
			}
			return Eq4.GetSubstring(offset, Eq4.Offset - offset);
		}

		public override string ReadToEnd()
		{
			if (Eq4 == null)
			{
				throw new InvalidOperationException(SR.GetString(SRName.ExReaderClosed));
			}
			string substring = Eq4.GetSubstring(Eq4.Offset, Eq4.Length - Eq4.Offset);
			Eq4.Offset = Eq4.Length;
			return substring;
		}

		internal static bool jfc()
		{
			return hfq == null;
		}

		internal static nx dff()
		{
			return hfq;
		}
	}

	private struct lg
	{
		internal IStringTreeNode dqK;

		internal bool rqk;
	}

	private IStringTreeNode wAb;

	private int fAC;

	private int tAU;

	private int sAa;

	private string GAj;

	private Stack<lg> vAF;

	private int fAx;

	private int nAg;

	private IStringTreeNode wAO;

	private Stack<fF> LAl;

	private int eAi;

	internal static StringTreeWalker oAX;

	public bool HasStackEntries => LAl.Count > 0;

	public bool IsAtEnd => sAa + tAU >= eAi;

	public bool IsAtStart => sAa + tAU <= 0;

	public bool IsWhitespaceOnlyAfterOnLine
	{
		get
		{
			Push();
			bool flag = default(bool);
			int num2 = default(int);
			for (char c = Read(); c != 0; c = Read())
			{
				int num = 0;
				if (AA3())
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						flag = !char.IsWhiteSpace(c);
						num = 0;
						if (!AA3())
						{
							num = num2;
						}
						continue;
					}
					if (!flag)
					{
						if (c == '\n')
						{
							Pop();
							return true;
						}
						break;
					}
					Pop();
					return false;
				}
			}
			Pop();
			return true;
		}
	}

	public bool IsWhitespaceOnlyBeforeOnLine
	{
		get
		{
			Push();
			for (char c = ReadReverse(); c != 0; c = ReadReverse())
			{
				if (!char.IsWhiteSpace(c))
				{
					Pop();
					return false;
				}
				if (c == '\n')
				{
					Pop();
					return true;
				}
			}
			Pop();
			return true;
		}
	}

	public int Length => eAi;

	public int Offset
	{
		get
		{
			return sAa + tAU;
		}
		set
		{
			if (value < 0 || value > eAi)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6008));
			}
			if (value - Offset != 0)
			{
				GA7(value - Offset);
			}
		}
	}

	public int OffsetDelta => 0;

	public TextPosition Position
	{
		get
		{
			if (nAg == -1)
			{
				gAp();
			}
			return new TextPosition(nAg, fAx);
		}
	}

	public TextPosition PositionDelta => TextPosition.Zero;

	internal StringTreeWalker(IStringTreeNode rootNode)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(rootNode, TextPosition.Zero, 0);
	}

	internal StringTreeWalker(IStringTreeNode rootNode, TextPosition initialPosition, int initialOffset)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		vAF = new Stack<lg>();
		LAl = new Stack<fF>();
		base._002Ector();
		wAO = rootNode;
		eAi = rootNode.Length;
		wAb = rootNode;
		if (!wAb.IsLeaf)
		{
			WAH();
		}
		fAC = wAb.Length;
		GAj = wAb.ToString();
		Offset = initialOffset;
		nAg = initialPosition.Line;
		fAx = initialPosition.Character;
	}

	private char GA7(int P_0)
	{
		if (P_0 >= 0)
		{
			while (P_0 > 0)
			{
				if (P_0 > fAC)
				{
					P_0 -= fAC;
					WAH();
					continue;
				}
				goto IL_0102;
			}
			goto IL_01ef;
		}
		goto IL_0267;
		IL_00db:
		P_0 -= tAU;
		BAP();
		goto IL_0050;
		IL_0005:
		int num2 = default(int);
		int num = num2;
		goto IL_0009;
		IL_0050:
		bool flag = default(bool);
		if (P_0 > 0)
		{
			flag = P_0 <= tAU;
			num = 2;
			if (!AA3())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_01ef;
		IL_0102:
		tAU += P_0;
		char result = ((GAj == null) ? wAb[tAU - 1] : GAj[tAU - 1]);
		if (P_0 != fAC)
		{
			fAC -= P_0;
		}
		else
		{
			WAH();
		}
		nAg = -1;
		num = 3;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 3:
				return result;
			case 2:
				break;
			case 1:
				goto end_IL_0009;
			default:
				nAg = -1;
				return result;
			}
			if (flag)
			{
				tAU -= P_0;
				result = ((GAj != null) ? GAj[tAU] : wAb[tAU]);
				fAC += P_0;
				num = 0;
				if (AA3())
				{
					continue;
				}
				goto IL_0005;
			}
			goto IL_00db;
			continue;
			end_IL_0009:
			break;
		}
		goto IL_0267;
		IL_0267:
		P_0 = Math.Abs(P_0);
		goto IL_0050;
		IL_01ef:
		throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5994));
	}

	private char BAM()
	{
		if (tAU == 0 || !wAb.IsLeaf)
		{
			BAP();
		}
		fAC++;
		char c = ((GAj == null) ? wAb[--tAU] : GAj[--tAU]);
		if (c == '\n')
		{
			nAg = -1;
		}
		else
		{
			fAx--;
		}
		return c;
	}

	private char mAw()
	{
		bool flag;
		if (GAj != null)
		{
			flag = fAC == 1;
			int num = 0;
			if (!AA3())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				break;
			case 2:
				goto IL_0125;
			default:
				goto IL_0142;
			}
			goto IL_0111;
		}
		char c = default(char);
		if (fAC == 1)
		{
			c = wAb[tAU];
			WAH();
		}
		else
		{
			fAC--;
			c = wAb[tAU++];
		}
		goto IL_0167;
		IL_0142:
		if (!flag)
		{
			goto IL_0111;
		}
		c = GAj[tAU];
		WAH();
		goto IL_0167;
		IL_00a3:
		return c;
		IL_0125:
		fAx++;
		goto IL_00a3;
		IL_0111:
		fAC--;
		c = GAj[tAU++];
		goto IL_0167;
		IL_0167:
		if (c == '\n')
		{
			if (nAg != -1)
			{
				nAg++;
				fAx = 0;
			}
			goto IL_00a3;
		}
		goto IL_0125;
	}

	private void WAH()
	{
		if (wAb.IsLeaf)
		{
			sAa += wAb.Length;
		}
		while (wAb.Left != null)
		{
			vAF.Push(new lg
			{
				dqK = wAb,
				rqk = true
			});
			wAb = wAb.Left;
			if (wAb.IsLeaf)
			{
				tAU = 0;
				fAC = wAb.Length;
				GAj = ((fAC < 5000) ? wAb.ToString() : null);
				return;
			}
		}
		while (vAF.Count > 0)
		{
			lg item = vAF.Pop();
			wAb = item.dqK;
			if (item.rqk)
			{
				item.rqk = false;
				vAF.Push(item);
				wAb = wAb.Right;
				if (wAb == null)
				{
					throw new InvalidOperationException(SR.GetString(SRName.ExInvalidWalkerTreeStateMovingToNextLeaf));
				}
				if (!wAb.IsLeaf)
				{
					WAH();
				}
				tAU = 0;
				fAC = wAb.Length;
				GAj = ((fAC < 5000) ? wAb.ToString() : null);
				return;
			}
		}
		tAU = 0;
		fAC = 0;
		GAj = ((wAb.IsLeaf && wAb.Length < 5000) ? wAb.ToString() : null);
	}

	private void BAP()
	{
		while (vAF.Count > 0)
		{
			lg item = vAF.Pop();
			wAb = item.dqK;
			if (!item.rqk)
			{
				item.rqk = true;
				vAF.Push(item);
				wAb = wAb.Left;
				if (wAb == null)
				{
					throw new InvalidOperationException(SR.GetString(SRName.ExInvalidWalkerTreeStateMovingToPreviousLeaf));
				}
				break;
			}
		}
		while (wAb.Right != null)
		{
			vAF.Push(new lg
			{
				dqK = wAb,
				rqk = false
			});
			wAb = wAb.Right;
			if (wAb.IsLeaf)
			{
				break;
			}
		}
		if (wAb.IsLeaf)
		{
			sAa -= wAb.Length;
			tAU = wAb.Length;
			fAC = 0;
			GAj = ((fAC < 5000) ? wAb.ToString() : null);
			return;
		}
		throw new InvalidOperationException(SR.GetString(SRName.ExInvalidWalkerTreeStateMovingToPreviousLeaf));
	}

	private void gAp()
	{
		int offset = Offset;
		nAg = wAO.GetLineIndex(offset);
		fAx = offset - wAO.GetLineTextRange(nAg).StartOffset;
	}

	public TextReader AsTextReader()
	{
		StringTreeWalker stringTreeWalker = new StringTreeWalker(wAO);
		return new nx(stringTreeWalker);
	}

	public string GetSubstring(int offset, int length)
	{
		return wAO.ToString(offset, offset + length);
	}

	public char Peek()
	{
		if (fAC <= 0)
		{
			return '\0';
		}
		if (GAj != null)
		{
			return GAj[tAU];
		}
		return wAb[tAU];
	}

	public char Peek(int count)
	{
		if (count > 0)
		{
			if (fAC > 0)
			{
				if (count > fAC)
				{
					char result = '\0';
					Push();
					int num2 = default(int);
					while (count-- > 0)
					{
						while (true)
						{
							result = Read();
							int num = 0;
							if (!AA3())
							{
								num = num2;
							}
							switch (num)
							{
							case 1:
								continue;
							}
							break;
						}
					}
					Pop();
					return result;
				}
				if (GAj == null)
				{
					return wAb[tAU + count - 1];
				}
				return GAj[tAU + count - 1];
			}
			return '\0';
		}
		throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6022));
	}

	public char PeekReverse()
	{
		if (tAU > 0)
		{
			bool flag = GAj != null;
			int num = 0;
			if (MAC() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				if (flag)
				{
					return GAj[tAU - 1];
				}
				return wAb[tAU - 1];
			}
		}
		if (sAa + tAU > 0)
		{
			Push();
			char result = BAM();
			Pop();
			return result;
		}
		return '\0';
	}

	public bool Pop()
	{
		if (LAl.Count > 0)
		{
			LAl.Pop().mq5(this);
			return true;
		}
		return false;
	}

	public bool PopAll()
	{
		if (LAl.Count != 0)
		{
			while (LAl.Count > 1)
			{
				LAl.Pop();
			}
			return Pop();
		}
		return false;
	}

	public void Push()
	{
		LAl.Push(new fF(this));
	}

	public char Read()
	{
		if (fAC <= 0)
		{
			return '\0';
		}
		return mAw();
	}

	public char ReadReverse()
	{
		if (sAa + tAU <= 0)
		{
			return '\0';
		}
		return BAM();
	}

	public bool ReadReverseThrough(char ch)
	{
		do
		{
			if (IsAtStart)
			{
				return false;
			}
		}
		while (ReadReverse() != ch);
		int num = 0;
		if (MAC() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => true, 
		};
	}

	public bool ReadReverseThrough(char ch, int minOffset)
	{
		minOffset = Math.Max(0, minOffset);
		while (sAa + tAU > minOffset)
		{
			if (ReadReverse() == ch)
			{
				return true;
			}
		}
		return false;
	}

	public bool ReadThrough(char ch)
	{
		while (!IsAtEnd)
		{
			if (Read() == ch)
			{
				return true;
			}
		}
		return false;
	}

	public bool ReadThrough(char ch, int maxOffset)
	{
		maxOffset = Math.Min(maxOffset, eAi);
		while (sAa + tAU < maxOffset)
		{
			if (Read() == ch)
			{
				return true;
			}
		}
		return false;
	}

	internal static bool AA3()
	{
		return oAX == null;
	}

	internal static StringTreeWalker MAC()
	{
		return oAX;
	}
}
