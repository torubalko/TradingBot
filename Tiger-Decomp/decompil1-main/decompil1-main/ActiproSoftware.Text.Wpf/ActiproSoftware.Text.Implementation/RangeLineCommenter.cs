using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Lexing;
using ActiproSoftware.Text.RegularExpressions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

public class RangeLineCommenter : ILineCommenter
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int? Mc7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string EcM;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string ncw;

	internal static RangeLineCommenter NUw;

	public int? CommentTokenId
	{
		[CompilerGenerated]
		get
		{
			return Mc7;
		}
		[CompilerGenerated]
		set
		{
			Mc7 = value;
		}
	}

	public string EndDelimiter
	{
		[CompilerGenerated]
		get
		{
			return EcM;
		}
		[CompilerGenerated]
		set
		{
			EcM = value;
		}
	}

	public string StartDelimiter
	{
		[CompilerGenerated]
		get
		{
			return ncw;
		}
		[CompilerGenerated]
		set
		{
			ncw = value;
		}
	}

	public virtual void Comment(ITextSnapshot snapshot, ITextPositionRangeCollection positionRanges, ITextChangeOptions options)
	{
		if (snapshot == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1676));
		}
		if (options == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6554));
		}
		if (!string.IsNullOrEmpty(StartDelimiter) && !string.IsNullOrEmpty(EndDelimiter))
		{
			ITextChange textChange = snapshot.CreateTextChange(TextChangeTypes.CommentLines, options);
			int num = 0;
			string startDelimiter = StartDelimiter;
			int length = startDelimiter.Length;
			string endDelimiter = EndDelimiter;
			int length2 = endDelimiter.Length;
			TextRange[] array = new TextRange[positionRanges.Count];
			for (int i = 0; i < positionRanges.Count; i++)
			{
				TextRange textRange = snapshot.PositionRangeToTextRange(positionRanges[i]);
				textChange.InsertText(textRange.FirstOffset + num, startDelimiter);
				array[i] = new TextRange(textRange.StartOffset + num, textRange.EndOffset + num + length + length2);
				num += length;
				textChange.InsertText(textRange.LastOffset + num, endDelimiter);
				num += length2;
			}
			textChange.Apply(array, positionRanges.PrimaryIndex, null);
		}
	}

	protected virtual TextRange? FindCommentTextRange(TextSnapshotRange snapshotRange)
	{
		if (snapshotRange.IsDeleted)
		{
			return null;
		}
		ITextSnapshotReader reader = snapshotRange.Snapshot.GetReader(snapshotRange.StartOffset);
		while (!reader.IsAtSnapshotEnd && reader.IsCharacterWhitespace)
		{
			reader.ReadCharacter();
		}
		int num = reader.Offset;
		string text = reader.PeekText(StartDelimiter.Length);
		if (text != StartDelimiter)
		{
			reader.Offset = snapshotRange.StartOffset;
			if (reader.PeekTextReverse(StartDelimiter.Length) == StartDelimiter)
			{
				num = reader.Offset - StartDelimiter.Length;
			}
			else
			{
				while (!reader.IsAtSnapshotStart && CharClass.Whitespace.Contains(reader.PeekCharacterReverse()))
				{
					reader.ReadCharacterReverse();
				}
				if (!(reader.PeekTextReverse(StartDelimiter.Length) == StartDelimiter))
				{
					if (CommentTokenId.HasValue)
					{
						reader.Offset = snapshotRange.StartOffset;
						IToken token = reader.Token;
						if (token != null && token.StartOffset <= snapshotRange.StartOffset && token.EndOffset >= snapshotRange.EndOffset && CommentTokenId == token.Id)
						{
							return token.TextRange;
						}
						return null;
					}
					return null;
				}
				num = reader.Offset - StartDelimiter.Length;
			}
		}
		int num2 = num + StartDelimiter.Length;
		reader.Offset = snapshotRange.EndOffset;
		while (!reader.IsAtSnapshotStart && char.IsWhiteSpace(reader.PeekCharacterReverse()))
		{
			reader.ReadCharacterReverse();
		}
		text = reader.ReadTextReverse(EndDelimiter.Length);
		if (text != EndDelimiter || reader.Offset < num2)
		{
			reader.Offset = snapshotRange.EndOffset;
			if (reader.PeekText(EndDelimiter.Length) != EndDelimiter)
			{
				while (!reader.IsAtSnapshotEnd && reader.IsCharacterWhitespace)
				{
					reader.ReadCharacter();
				}
				if (reader.PeekText(EndDelimiter.Length) != EndDelimiter)
				{
					return new TextRange(num, Math.Max(num + StartDelimiter.Length, snapshotRange.EndOffset));
				}
			}
		}
		return new TextRange(num, reader.Offset + EndDelimiter.Length);
	}

	public virtual void Uncomment(ITextSnapshot snapshot, ITextPositionRangeCollection positionRanges, ITextChangeOptions options)
	{
		if (snapshot == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1676));
		}
		if (options == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6554));
		}
		if (string.IsNullOrEmpty(StartDelimiter) || string.IsNullOrEmpty(EndDelimiter))
		{
			return;
		}
		ITextChange textChange = snapshot.CreateTextChange(TextChangeTypes.UncommentLines, options);
		int num = 0;
		int num2 = 0;
		string startDelimiter = StartDelimiter;
		int length = startDelimiter.Length;
		string endDelimiter = EndDelimiter;
		int length2 = endDelimiter.Length;
		List<TextRange> list = new List<TextRange>(positionRanges.Count);
		int num3 = positionRanges.PrimaryIndex;
		ITextSnapshotReader textSnapshotReader = null;
		for (int i = 0; i < positionRanges.Count; i++)
		{
			TextRange textRange = snapshot.PositionRangeToTextRange(positionRanges[i]);
			TextSnapshotRange snapshotRange = new TextSnapshotRange(snapshot, textRange);
			TextRange? textRange2 = FindCommentTextRange(snapshotRange);
			if (!textRange2.HasValue)
			{
				continue;
			}
			if (textSnapshotReader == null)
			{
				textSnapshotReader = textChange.Snapshot.GetReader(textRange2.Value.StartOffset);
			}
			else
			{
				textSnapshotReader.Offset = textRange2.Value.StartOffset;
			}
			if (num2 <= textSnapshotReader.Offset && textSnapshotReader.PeekText(length) == startDelimiter)
			{
				int num4 = textSnapshotReader.Offset + num;
				textChange.DeleteText(num4, length);
				num -= length;
				num2 = textSnapshotReader.Offset + length;
				TextRange item = (textRange.IsNormalized ? new TextRange(num4, textRange2.Value.EndOffset + num) : new TextRange(textRange2.Value.EndOffset + num, num4));
				list.Add(item);
				if (num4 + length + length2 <= textRange2.Value.EndOffset)
				{
					textSnapshotReader.Offset = textRange2.Value.EndOffset;
					if (textSnapshotReader.PeekTextReverse(length2) == endDelimiter)
					{
						num4 = textSnapshotReader.Offset + num - length2;
						item = new TextRange(Math.Min(num4, item.StartOffset), Math.Min(num4, item.EndOffset));
						list[list.Count - 1] = item;
						textChange.DeleteText(num4, length2);
						num -= length2;
						num2 = textSnapshotReader.Offset;
					}
				}
			}
			else
			{
				num3 = Math.Max(0, num3 - 1);
			}
		}
		if (textChange.Operations.Count > 0)
		{
			textChange.Apply(list, num3, null);
		}
	}

	public RangeLineCommenter()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool QUa()
	{
		return NUw == null;
	}

	internal static RangeLineCommenter qU7()
	{
		return NUw;
	}
}
