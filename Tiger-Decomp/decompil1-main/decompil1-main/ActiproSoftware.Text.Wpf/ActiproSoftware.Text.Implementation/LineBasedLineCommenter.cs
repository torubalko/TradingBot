using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

public class LineBasedLineCommenter : ILineCommenter
{
	private bool ncL;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string ocq;

	private static LineBasedLineCommenter kUG;

	public bool CanCommentEmptyLines
	{
		get
		{
			return ncL;
		}
		set
		{
			ncL = value;
		}
	}

	public string StartDelimiter
	{
		[CompilerGenerated]
		get
		{
			return ocq;
		}
		[CompilerGenerated]
		set
		{
			ocq = value;
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
		if (string.IsNullOrEmpty(StartDelimiter))
		{
			return;
		}
		ITextChange textChange = snapshot.CreateTextChange(TextChangeTypes.CommentLines, options);
		int num = 0;
		int num2 = -1;
		string startDelimiter = StartDelimiter;
		int length = startDelimiter.Length;
		TextRange[] array = new TextRange[positionRanges.Count];
		for (int i = 0; i < positionRanges.Count; i++)
		{
			TextRange textRange = snapshot.PositionRangeToTextRange(positionRanges[i]);
			TextPositionRange normalizedTextPositionRange = positionRanges[i].NormalizedTextPositionRange;
			int num3 = normalizedTextPositionRange.Lines;
			if (num3 > 1 && normalizedTextPositionRange.EndPosition.Character == 0)
			{
				num3--;
			}
			TextPosition firstPosition = positionRanges[i].FirstPosition;
			int num4 = num;
			for (int j = 0; j < num3; j++)
			{
				int num5 = firstPosition.Line + j;
				if (num5 <= num2)
				{
					continue;
				}
				ITextSnapshotLine textSnapshotLine = snapshot.Lines[num5];
				if (ncL || textSnapshotLine.FirstNonWhitespaceCharacterOffset < textSnapshotLine.EndOffset)
				{
					textChange.InsertText(textSnapshotLine.StartOffset + num, startDelimiter);
					if (j == 0 && textRange.FirstOffset >= textSnapshotLine.FirstNonWhitespaceCharacterOffset + length)
					{
						num4 += length;
					}
					num += length;
					num2 = num5;
				}
			}
			if (textRange.IsNormalized)
			{
				array[i] = new TextRange(textRange.StartOffset + num4, textRange.EndOffset + num);
			}
			else
			{
				array[i] = new TextRange(textRange.StartOffset + num, textRange.EndOffset + num4);
			}
		}
		textChange.Apply(array, positionRanges.PrimaryIndex, null);
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
		if (string.IsNullOrEmpty(StartDelimiter))
		{
			return;
		}
		ITextChange textChange = snapshot.CreateTextChange(TextChangeTypes.UncommentLines, options);
		int num = 0;
		int num2 = -1;
		string startDelimiter = StartDelimiter;
		int length = startDelimiter.Length;
		List<TextRange> list = new List<TextRange>(positionRanges.Count);
		int primaryIndex = positionRanges.PrimaryIndex;
		ITextSnapshotReader textSnapshotReader = null;
		for (int i = 0; i < positionRanges.Count; i++)
		{
			TextRange textRange = snapshot.PositionRangeToTextRange(positionRanges[i]);
			TextPositionRange normalizedTextPositionRange = positionRanges[i].NormalizedTextPositionRange;
			int num3 = normalizedTextPositionRange.Lines;
			if (num3 > 1 && normalizedTextPositionRange.EndPosition.Character == 0)
			{
				num3--;
			}
			TextPosition firstPosition = positionRanges[i].FirstPosition;
			int num4 = num;
			for (int j = 0; j < num3; j++)
			{
				int num5 = firstPosition.Line + j;
				if (num5 <= num2)
				{
					continue;
				}
				ITextSnapshotLine textSnapshotLine = snapshot.Lines[num5];
				int firstNonWhitespaceCharacterOffset = textSnapshotLine.FirstNonWhitespaceCharacterOffset;
				if (firstNonWhitespaceCharacterOffset >= textSnapshotLine.EndOffset)
				{
					continue;
				}
				if (textSnapshotReader == null)
				{
					textSnapshotReader = textChange.Snapshot.GetReader(firstNonWhitespaceCharacterOffset);
				}
				else
				{
					textSnapshotReader.Offset = firstNonWhitespaceCharacterOffset;
				}
				string text = textSnapshotReader.PeekText(length);
				if (text == startDelimiter)
				{
					textChange.DeleteText(firstNonWhitespaceCharacterOffset + num, length);
					if (j == 0 && textRange.FirstOffset >= firstNonWhitespaceCharacterOffset + length)
					{
						num4 -= length;
					}
					num -= length;
					num2 = num5;
				}
			}
			TextRange item = (textRange.IsNormalized ? new TextRange(Math.Max(0, textRange.StartOffset + num4), Math.Max(0, textRange.EndOffset + num)) : new TextRange(Math.Max(0, textRange.StartOffset + num), Math.Max(0, textRange.EndOffset + num4)));
			list.Add(item);
		}
		if (textChange.Operations.Count > 0)
		{
			textChange.Apply(list, primaryIndex, null);
		}
	}

	public LineBasedLineCommenter()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		ncL = false;
		base._002Ector();
	}

	internal static bool PUh()
	{
		return kUG == null;
	}

	internal static LineBasedLineCommenter DUQ()
	{
		return kUG;
	}
}
