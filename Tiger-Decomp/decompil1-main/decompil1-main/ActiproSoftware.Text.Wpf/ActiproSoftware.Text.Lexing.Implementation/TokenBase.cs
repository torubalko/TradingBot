using System.Globalization;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Lexing.Implementation;

public abstract class TokenBase : IToken
{
	private TextPosition lmK;

	private int Hmk;

	private int GmE;

	private TextPosition zmr;

	internal static TokenBase LU2;

	public int EndOffset => GmE + Hmk;

	public TextPosition EndPosition => lmK;

	public abstract int Id { get; }

	public virtual string Key => null;

	public int Length
	{
		get
		{
			return Hmk;
		}
		set
		{
			Hmk = value;
		}
	}

	public virtual int LexicalStateId => 0;

	public TextPositionRange PositionRange => new TextPositionRange(zmr, lmK);

	public int StartOffset
	{
		get
		{
			return GmE;
		}
		set
		{
			GmE = value;
		}
	}

	public TextPosition StartPosition => zmr;

	public TextRange TextRange => new TextRange(GmE, GmE + Hmk);

	protected TokenBase(int startOffset, int length, TextPosition startPosition, TextPosition endPosition)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		GmE = startOffset;
		Hmk = length;
		zmr = startPosition;
		lmK = endPosition;
	}

	public bool Contains(int offset)
	{
		return offset >= GmE && offset < EndOffset;
	}

	public bool Contains(TextPosition position)
	{
		return position >= zmr && position < lmK;
	}

	public override bool Equals(object obj)
	{
		int num = 1;
		IToken token = default(IToken);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					if (token != null)
					{
						return Id == token.Id && GmE == token.StartOffset && Hmk == token.Length && zmr == token.StartPosition && lmK == token.EndPosition;
					}
					return false;
				case 1:
					break;
				}
				token = obj as IToken;
				num2 = 0;
			}
			while (zUq());
		}
	}

	public override int GetHashCode()
	{
		return GmE ^ Id;
	}

	public override string ToString()
	{
		return ToString(GetType().Name);
	}

	public string ToString(string tokenDescription)
	{
		return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8578), tokenDescription, Key, GmE, EndOffset);
	}

	internal static bool zUq()
	{
		return LU2 == null;
	}

	internal static TokenBase BUc()
	{
		return LU2;
	}
}
