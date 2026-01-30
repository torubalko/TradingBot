using System;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class TextSnapshotLine : ITextSnapshotLine, ITextRangeProvider
{
	private int bhD;

	private ITextSnapshot Vh1;

	private TextRange Fh4;

	internal static TextSnapshotLine p2q;

	public int EndOffset => Fh4.EndOffset;

	public int EndOffsetIncludingLineTerminator => Fh4.EndOffset + ((Fh4.EndOffset < Vh1.Length) ? 1 : 0);

	public int FirstNonWhitespaceCharacterOffset
	{
		get
		{
			ITextBufferReader bufferReader = Vh1.GetReader(Fh4.StartOffset).BufferReader;
			char c3;
			do
			{
				if (bufferReader.Offset < Fh4.EndOffset)
				{
					char c = bufferReader.Read();
					char c2 = c;
					c3 = c2;
					continue;
				}
				return Fh4.EndOffset;
			}
			while (c3 == '\t' || c3 == ' ');
			return bufferReader.Offset - 1;
		}
	}

	public int Index => bhD;

	public int IndentAmount
	{
		get
		{
			return GetIndentAmountBefore(Fh4.EndOffset);
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6008));
			}
			int firstNonWhitespaceCharacterOffset = FirstNonWhitespaceCharacterOffset;
			TextRange textRange = new TextRange(Fh4.StartOffset, firstNonWhitespaceCharacterOffset);
			string text = ((firstNonWhitespaceCharacterOffset > Fh4.StartOffset) ? Vh1.GetSubstring(textRange) : string.Empty);
			if (value == 0)
			{
				if (text.Length > 0)
				{
					Vh1.Document.DeleteText(TextChangeTypes.AutoIndent, textRange, new TextChangeOptions
					{
						RetainSelection = true
					});
				}
				return;
			}
			int tabSize = Vh1.Document.TabSize;
			int num = value / Math.Max(1, tabSize);
			string text2 = (Vh1.Document.AutoConvertTabsToSpaces ? new string(' ', value) : (new string('\t', num) + new string(' ', value - num * tabSize)));
			if (text != text2)
			{
				ITextChange textChange = Vh1.CreateTextChange(TextChangeTypes.AutoIndent, new TextChangeOptions
				{
					RetainSelection = true
				});
				textChange.ReplaceText(textRange, text2);
				textChange.Apply();
			}
		}
	}

	public bool IsLastLine => EndOffset == Vh1.Length;

	public int Length => Fh4.Length;

	public ITextSnapshot Snapshot => Vh1;

	public TextSnapshotRange SnapshotRange => new TextSnapshotRange(Vh1, Fh4);

	public int StartOffset => Fh4.StartOffset;

	public string Text => Vh1.GetSubstring(Fh4, LineTerminator.Newline);

	public TextRange TextRange
	{
		get
		{
			return Fh4;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public TextRange TextRangeIncludingLineTerminator => new TextRange(StartOffset, EndOffsetIncludingLineTerminator);

	internal TextSnapshotLine(ITextSnapshot snapshot, int index, TextRange textRange)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		Vh1 = snapshot;
		bhD = index;
		Fh4 = textRange;
	}

	public bool Contains(int offset)
	{
		return Fh4.Contains(offset);
	}

	public int GetIndentAmountBefore(int offset)
	{
		offset = Math.Min(offset, Fh4.EndOffset);
		int tabSize = Vh1.Document.TabSize;
		ITextBufferReader bufferReader = Vh1.GetReader(Fh4.StartOffset).BufferReader;
		int num = 0;
		while (bufferReader.Offset < offset)
		{
			switch (bufferReader.Read())
			{
			case ' ':
				num++;
				break;
			case '\t':
			{
				int num2 = tabSize - num % tabSize;
				num += num2;
				break;
			}
			default:
				return num;
			}
		}
		return num;
	}

	public bool IsLineEnd(int offset)
	{
		return Fh4.EndOffset == offset;
	}

	public bool IsLineStart(int offset)
	{
		return Fh4.StartOffset == offset;
	}

	internal static bool t2c()
	{
		return p2q == null;
	}

	internal static TextSnapshotLine r2f()
	{
		return p2q;
	}
}
