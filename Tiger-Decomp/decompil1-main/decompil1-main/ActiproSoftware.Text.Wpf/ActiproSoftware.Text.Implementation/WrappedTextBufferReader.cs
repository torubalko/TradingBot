using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class WrappedTextBufferReader : ITextBufferReader
{
	private struct x4
	{
		internal int sI9;

		internal int vIA;

		internal int wIu;

		private static object zMg;

		internal x4(int P_0, int P_1, int P_2)
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			vIA = P_0;
			sI9 = P_1;
			wIu = P_2;
		}

		internal static bool jMp()
		{
			return zMg == null;
		}

		internal static object qMm()
		{
			return zMg;
		}
	}

	private string Pd0;

	private int ndv;

	private string xdY;

	private int zdo;

	private int EdD;

	private int Ed1;

	private int cd4;

	private TextPosition fdK;

	private int rdk;

	private Stack<x4> tdE;

	private x4 Qdr;

	private ITextBufferReader Rd3;

	internal static WrappedTextBufferReader I2T;

	public bool HasStackEntries => tdE.Count > 0;

	public bool IsAtEnd => EdD >= zdo;

	public bool IsAtStart => EdD <= -Ed1;

	public bool IsWhitespaceOnlyAfterOnLine
	{
		get
		{
			int num = EdD;
			while (true)
			{
				if (num >= zdo)
				{
					return true;
				}
				char c = bdZ(num);
				if (!char.IsWhiteSpace(c))
				{
					return false;
				}
				if (c != '\n')
				{
					num++;
					continue;
				}
				break;
			}
			return true;
		}
	}

	public bool IsWhitespaceOnlyBeforeOnLine
	{
		get
		{
			int num = EdD - 1;
			int num3 = default(int);
			while (true)
			{
				bool flag = num >= -Ed1;
				int num2 = 0;
				if (e2X() != null)
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
				if (flag)
				{
					char c = bdZ(num);
					if (char.IsWhiteSpace(c))
					{
						if (c == '\n')
						{
							return true;
						}
						num--;
						continue;
					}
					return false;
				}
				return true;
			}
		}
	}

	public int Length => zdo;

	public int Offset
	{
		get
		{
			return EdD;
		}
		set
		{
			while (EdD < value)
			{
				Read();
			}
			while (EdD > value)
			{
				ReadReverse();
			}
		}
	}

	public int OffsetDelta => Ed1;

	public TextPosition Position => new TextPosition(rdk, cd4);

	public TextPosition PositionDelta => fdK;

	public WrappedTextBufferReader(ITextBufferReader wrappedReader, string headerText, string footerText)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		tdE = new Stack<x4>();
		base._002Ector();
		if (wrappedReader == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(10086));
		}
		if (wrappedReader.OffsetDelta != 0)
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(10116), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(10086));
		}
		if (headerText == null)
		{
			headerText = string.Empty;
		}
		if (footerText == null)
		{
			footerText = string.Empty;
		}
		int[] lineFeedIndices = StringHelper.GetLineFeedIndices(headerText);
		Pd0 = footerText;
		ndv = lineFeedIndices.Length;
		xdY = headerText;
		zdo = wrappedReader.Length + footerText.Length;
		EdD = -headerText.Length;
		Ed1 = headerText.Length;
		rdk = -ndv;
		fdK = new TextPosition(ndv, (lineFeedIndices.Length != 0) ? (headerText.Length - (lineFeedIndices[lineFeedIndices.Length - 1] + 1)) : 0);
		Rd3 = wrappedReader;
	}

	private char bdZ(int P_0)
	{
		if (P_0 >= 0)
		{
			bool flag = P_0 < Rd3.Length;
			int num = 0;
			if (e2X() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				if (flag)
				{
					return Rd3.GetSubstring(P_0, 1)[0];
				}
				return Pd0[P_0 - Rd3.Length];
			}
		}
		return xdY[Ed1 + P_0];
	}

	public TextReader AsTextReader()
	{
		return new StringReader(ToString());
	}

	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "1#")]
	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#")]
	public string GetSubstring(int startOffset, int substringLength)
	{
		if (startOffset < 0)
		{
			if (startOffset + substringLength <= 0)
			{
				return xdY.Substring(Ed1 + startOffset, substringLength);
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(xdY.Substring(Ed1 + startOffset));
			substringLength += startOffset;
			if (substringLength <= Rd3.Length)
			{
				stringBuilder.Append(Rd3.GetSubstring(0, substringLength));
			}
			else
			{
				stringBuilder.Append(Rd3.GetSubstring(0, Rd3.Length));
				substringLength -= Rd3.Length;
				stringBuilder.Append(Pd0.Substring(0, substringLength));
			}
			return stringBuilder.ToString();
		}
		if (startOffset < Rd3.Length)
		{
			if (startOffset + substringLength <= Rd3.Length)
			{
				return Rd3.GetSubstring(startOffset, substringLength);
			}
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append(Rd3.GetSubstring(startOffset, Rd3.Length - startOffset));
			substringLength -= Rd3.Length - startOffset;
			stringBuilder2.Append(Pd0.Substring(0, substringLength));
			return stringBuilder2.ToString();
		}
		startOffset -= Rd3.Length;
		return Pd0.Substring(startOffset, substringLength);
	}

	public char Peek()
	{
		if (EdD < zdo)
		{
			return bdZ(EdD);
		}
		return '\0';
	}

	public char Peek(int count)
	{
		if (EdD + count - 1 < zdo)
		{
			return bdZ(EdD + count - 1);
		}
		return '\0';
	}

	public char PeekReverse()
	{
		if (EdD > -Ed1)
		{
			return bdZ(EdD - 1);
		}
		return '\0';
	}

	public bool Pop()
	{
		if (tdE.Count > 0)
		{
			Rd3.Pop();
			Qdr = tdE.Pop();
			rdk = Qdr.vIA;
			cd4 = Qdr.sI9;
			EdD = Qdr.wIu;
			return true;
		}
		return false;
	}

	public bool PopAll()
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					break;
				default:
					if (!flag)
					{
						Rd3.PopAll();
						while (tdE.Count > 1)
						{
							tdE.Pop();
						}
						return Pop();
					}
					return false;
				}
				flag = tdE.Count == 0;
				num2 = 0;
			}
			while (e2X() == null);
		}
	}

	public void Push()
	{
		Rd3.Push();
		tdE.Push(new x4(rdk, cd4, EdD));
	}

	public char Read()
	{
		if (EdD < zdo)
		{
			char c;
			if (EdD >= 0 && EdD < Rd3.Length)
			{
				Rd3.Offset = EdD;
				EdD++;
				c = Rd3.Read();
			}
			else
			{
				c = bdZ(EdD++);
			}
			if (c == '\n')
			{
				rdk++;
				cd4 = 0;
			}
			else
			{
				cd4++;
			}
			return c;
		}
		return '\0';
	}

	public char ReadReverse()
	{
		if (EdD > -Ed1)
		{
			char c;
			if (EdD > 0 && EdD <= Rd3.Length)
			{
				Rd3.Offset = EdD;
				EdD--;
				c = Rd3.ReadReverse();
			}
			else
			{
				c = bdZ(--EdD);
			}
			if (c == '\n')
			{
				rdk--;
				cd4 = 0;
				int num = EdD - 1;
				while (num >= 0 && bdZ(num) != '\n')
				{
					cd4++;
					num--;
				}
			}
			else
			{
				cd4--;
			}
			return c;
		}
		return '\0';
	}

	public bool ReadReverseThrough(char ch)
	{
		bool result;
		int num2 = default(int);
		while (true)
		{
			if (IsAtStart)
			{
				result = false;
				break;
			}
			if (ReadReverse() == ch)
			{
				result = true;
				int num = 0;
				if (!N2k())
				{
					num = num2;
				}
				switch (num)
				{
				}
				break;
			}
		}
		return result;
	}

	public bool ReadReverseThrough(char ch, int minOffset)
	{
		minOffset = Math.Max(-Ed1, minOffset);
		while (EdD > minOffset)
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
		maxOffset = Math.Min(maxOffset, zdo);
		while (EdD < maxOffset)
		{
			if (Read() == ch)
			{
				return true;
			}
		}
		return false;
	}

	public override string ToString()
	{
		return xdY + Rd3.GetSubstring(0, Rd3.Length) + Pd0;
	}

	internal static bool N2k()
	{
		return I2T == null;
	}

	internal static WrappedTextBufferReader e2X()
	{
		return I2T;
	}
}
