using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

public class StringTextBufferReader : ITextBufferReader
{
	private struct RZ
	{
		internal int xsW;

		internal int Ls5;

		internal int as6;

		internal static object nMc;

		internal RZ(int P_0, int P_1, int P_2)
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			Ls5 = P_0;
			xsW = P_1;
			as6 = P_2;
		}

		internal static bool iMf()
		{
			return nMc == null;
		}

		internal static object KMM()
		{
			return nMc;
		}
	}

	private int ucP;

	private int Jcp;

	private int hcb;

	private int ScC;

	private TextPosition zcU;

	private int Aca;

	private Stack<RZ> rcj;

	private RZ EcF;

	private string xcx;

	private static StringTextBufferReader LUO;

	public bool HasStackEntries => rcj.Count > 0;

	public bool IsAtEnd => Jcp >= ucP;

	public bool IsAtStart => Jcp <= -hcb;

	public bool IsWhitespaceOnlyAfterOnLine
	{
		get
		{
			int num = Jcp;
			while (true)
			{
				if (num < ucP)
				{
					char c = xcx[num + hcb];
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
			return true;
		}
	}

	public bool IsWhitespaceOnlyBeforeOnLine
	{
		get
		{
			for (int num = Jcp - 1; num >= -hcb; num--)
			{
				char c = xcx[num + hcb];
				if (!char.IsWhiteSpace(c))
				{
					return false;
				}
				if (c == '\n')
				{
					return true;
				}
			}
			return true;
		}
	}

	public int Length => ucP;

	public int Offset
	{
		get
		{
			return Jcp;
		}
		set
		{
			while (Jcp < value)
			{
				Read();
			}
			while (Jcp > value)
			{
				ReadReverse();
			}
		}
	}

	public int OffsetDelta => hcb;

	public TextPosition Position => new TextPosition(Aca, ScC);

	public TextPosition PositionDelta => zcU;

	public StringTextBufferReader(string text)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(text, TextPosition.Zero, 0);
	}

	public StringTextBufferReader(string text, TextPosition position, int offset)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(text, position, TextPosition.Zero, offset, 0);
	}

	private StringTextBufferReader(string text, TextPosition position, TextPosition positionDelta, int offset, int offsetDelta)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		rcj = new Stack<RZ>();
		base._002Ector();
		xcx = text;
		Aca = position.Line;
		ScC = position.Character;
		zcU = positionDelta;
		Jcp = offset - offsetDelta;
		ucP = text.Length - offsetDelta;
		hcb = offsetDelta;
	}

	public TextReader AsTextReader()
	{
		return new StringReader(xcx);
	}

	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#")]
	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "1#")]
	public string GetSubstring(int startOffset, int substringLength)
	{
		return xcx.Substring(startOffset + hcb, substringLength);
	}

	public char Peek()
	{
		if (Jcp < ucP)
		{
			return xcx[Jcp + hcb];
		}
		return '\0';
	}

	public char Peek(int count)
	{
		if (Jcp + count - 1 >= ucP)
		{
			return '\0';
		}
		return xcx[Jcp + hcb + count - 1];
	}

	public char PeekReverse()
	{
		if (Jcp > -hcb)
		{
			return xcx[Jcp + hcb - 1];
		}
		return '\0';
	}

	public bool Pop()
	{
		if (rcj.Count > 0)
		{
			int num = 0;
			if (WUv() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				EcF = rcj.Pop();
				Aca = EcF.Ls5;
				ScC = EcF.xsW;
				Jcp = EcF.as6;
				return true;
			}
		}
		return false;
	}

	public bool PopAll()
	{
		if (rcj.Count == 0)
		{
			return false;
		}
		while (rcj.Count > 1)
		{
			rcj.Pop();
		}
		return Pop();
	}

	public void Push()
	{
		rcj.Push(new RZ(Aca, ScC, Jcp));
	}

	public char Read()
	{
		if (Jcp >= ucP)
		{
			return '\0';
		}
		char c = xcx[Jcp++ + hcb];
		if (c == '\n')
		{
			Aca++;
			ScC = 0;
		}
		else
		{
			ScC++;
		}
		return c;
	}

	public char ReadReverse()
	{
		if (Jcp > -hcb)
		{
			int num = 1;
			if (WUv() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			char c = default(char);
			switch (num)
			{
			case 1:
				c = xcx[--Jcp + hcb];
				if (c == '\n')
				{
					Aca--;
					ScC = 0;
					int num3 = Jcp - 1;
					while (num3 >= 0 && xcx[num3] != '\n')
					{
						ScC++;
						num3--;
					}
					break;
				}
				goto default;
			default:
				ScC--;
				break;
			}
			return c;
		}
		return '\0';
	}

	public bool ReadReverseThrough(char ch)
	{
		while (!IsAtStart)
		{
			if (ReadReverse() == ch)
			{
				return true;
			}
		}
		return false;
	}

	public bool ReadReverseThrough(char ch, int minOffset)
	{
		minOffset = Math.Max(-hcb, minOffset);
		int num2 = default(int);
		while (true)
		{
			bool flag = Jcp > minOffset;
			int num = 0;
			if (!DUD())
			{
				num = num2;
			}
			switch (num)
			{
			}
			if (!flag)
			{
				return false;
			}
			if (ReadReverse() == ch)
			{
				return true;
			}
		}
	}

	public bool ReadThrough(char ch)
	{
		bool result;
		int num2 = default(int);
		while (true)
		{
			if (!IsAtEnd)
			{
				if (Read() == ch)
				{
					result = true;
					int num = 0;
					if (!DUD())
					{
						num = num2;
					}
					switch (num)
					{
					}
					break;
				}
				continue;
			}
			result = false;
			break;
		}
		return result;
	}

	public bool ReadThrough(char ch, int maxOffset)
	{
		maxOffset = Math.Min(maxOffset, ucP);
		do
		{
			if (Jcp >= maxOffset)
			{
				return false;
			}
		}
		while (Read() != ch);
		return true;
	}

	public override string ToString()
	{
		return xcx;
	}

	internal static bool DUD()
	{
		return LUO == null;
	}

	internal static StringTextBufferReader WUv()
	{
		return LUO;
	}
}
