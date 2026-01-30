using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ActiproSoftware.Text.Exporters;
using ActiproSoftware.Text.Searching;
using ActiproSoftware.Text.Searching.Implementation;
using ActiproSoftware.Text.StringTrees;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class TextSnapshot : ITextSnapshot, ITextRangeProvider
{
	private ITextSnapshotLineCollection jhZ;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IStringTreeNode nh0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string Ehv;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string lhY;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextVersion Eho;

	internal static TextSnapshot d2P;

	internal IStringTreeNode TextData
	{
		[CompilerGenerated]
		get
		{
			return nh0;
		}
		[CompilerGenerated]
		private set
		{
			nh0 = value;
		}
	}

	public ITextDocument Document => Version.Document;

	public string FooterText
	{
		[CompilerGenerated]
		get
		{
			return Ehv;
		}
		[CompilerGenerated]
		private set
		{
			Ehv = value;
		}
	}

	public bool HasContent => TextData.Length > 0;

	public string HeaderText
	{
		[CompilerGenerated]
		get
		{
			return lhY;
		}
		[CompilerGenerated]
		private set
		{
			lhY = value;
		}
	}

	public int Length => TextData.Length;

	public ITextSnapshotLineCollection Lines => jhZ;

	public TextSnapshotRange SnapshotRange => new TextSnapshotRange(this, 0, TextData.Length);

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public string Text => GetText(LineTerminator.CarriageReturnNewline);

	public TextRange TextRange
	{
		get
		{
			return new TextRange(0, TextData.Length);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	[IndexerName("Characters")]
	public char this[int index]
	{
		get
		{
			if (index >= TextData.Length)
			{
				return '\0';
			}
			return TextData[index];
		}
	}

	public ITextVersion Version
	{
		[CompilerGenerated]
		get
		{
			return Eho;
		}
		[CompilerGenerated]
		private set
		{
			Eho = value;
		}
	}

	internal TextSnapshot(ITextVersion version, IStringTreeNode textData, string headerText, string footerText)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		Version = version;
		TextData = textData;
		HeaderText = headerText;
		FooterText = footerText;
		jhZ = new TextSnapshotLineCollection(this);
	}

	public ITextChange CreateTextChange(ITextChangeType type)
	{
		return CreateTextChange(type, null);
	}

	public ITextChange CreateTextChange(ITextChangeType type, ITextChangeOptions options)
	{
		return new TextChange(this, type, options);
	}

	public string Export(ITextExporter exporter)
	{
		if (exporter == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9190));
		}
		return exporter.Export(this, new TextRange[1] { TextRange });
	}

	public void ExportToFile(ITextExporter exporter, string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9162));
		}
		string value = Export(exporter);
		using StreamWriter streamWriter = File.CreateText(path);
		streamWriter.Write(value);
		streamWriter.Flush();
	}

	public ISearchResultSet FindAll(ISearchOptions options)
	{
		return FindAll(options, TextRange);
	}

	public ISearchResultSet FindAll(ISearchOptions options, TextRange searchTextRange)
	{
		return TextSearcher.FindAll(this, options, searchTextRange);
	}

	public ISearchResultSet FindNext(ISearchOptions options, int startOffset, bool canWrap)
	{
		return FindNext(options, startOffset, canWrap, TextRange);
	}

	public ISearchResultSet FindNext(ISearchOptions options, int startOffset, bool canWrap, TextRange searchTextRange)
	{
		return TextSearcher.FindNext(this, options, startOffset, canWrap, searchTextRange);
	}

	public ISearchResultSet FindNext(ISearchOptions options, int startOffset, bool canWrap, TextRange searchTextRange, CancellationToken cancellationToken)
	{
		return TextSearcher.FindNext(this, options, startOffset, canWrap, searchTextRange, cancellationToken);
	}

	public ITextBufferReader GetMergedBufferReader()
	{
		if (string.IsNullOrEmpty(HeaderText) && string.IsNullOrEmpty(FooterText))
		{
			return GetReader(0).BufferReader;
		}
		return new WrappedTextBufferReader(GetReader(0).BufferReader, HeaderText, FooterText);
	}

	public ITextSnapshotReader GetReader(int offset)
	{
		offset = Math.Max(0, Math.Min(Length, offset));
		return new TextSnapshotReader(this, new StringTreeWalker(TextData, OffsetToPosition(offset), offset));
	}

	public ITextSnapshotReader GetReader(TextPosition position)
	{
		int initialOffset = Math.Max(0, Math.Min(Length, PositionToOffset(position)));
		return new TextSnapshotReader(this, new StringTreeWalker(TextData, position, initialOffset));
	}

	public string GetSubstring(int offset, int length)
	{
		return GetSubstring(TextRange.FromSpan(offset, length), LineTerminator.CarriageReturnNewline);
	}

	public string GetSubstring(TextRange textRange)
	{
		return GetSubstring(textRange, LineTerminator.CarriageReturnNewline);
	}

	public string GetSubstring(int offset, int length, LineTerminator lineTerminator)
	{
		return GetSubstring(TextRange.FromSpan(offset, length), lineTerminator);
	}

	public string GetSubstring(TextRange textRange, LineTerminator lineTerminator)
	{
		string lineTerminatorText = StringHelper.GetLineTerminatorText(lineTerminator);
		if (lineTerminator != LineTerminator.Newline)
		{
			int num = 0;
			if (l22() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				if (TextData.Length <= 1000000)
				{
					return TextData.ToString(textRange.FirstOffset, textRange.LastOffset).Replace(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5366), lineTerminatorText);
				}
				StringBuilder stringBuilder = new StringBuilder(TextData.ToString(textRange.FirstOffset, textRange.LastOffset));
				stringBuilder.Replace(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5366), lineTerminatorText);
				return stringBuilder.ToString();
			}
			}
		}
		return TextData.ToString(textRange.FirstOffset, textRange.LastOffset);
	}

	public string GetText(LineTerminator lineTerminator)
	{
		string lineTerminatorText = StringHelper.GetLineTerminatorText(lineTerminator);
		if (lineTerminator == LineTerminator.Newline)
		{
			return TextData.ToString();
		}
		if (TextData.Length > 1000000)
		{
			StringBuilder stringBuilder = new StringBuilder(TextData.ToString());
			stringBuilder.Replace(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5366), lineTerminatorText);
			return stringBuilder.ToString();
		}
		return TextData.ToString().Replace(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5366), lineTerminatorText);
	}

	public ITextStatistics GetTextStatistics()
	{
		ITextStatistics textStatistics = null;
		if (Document is ICodeDocument { Language: not null } codeDocument)
		{
			ITextStatisticsFactory service = codeDocument.Language.GetService<ITextStatisticsFactory>();
			if (service != null)
			{
				textStatistics = service.CreateStatistics(Text);
			}
		}
		if (textStatistics == null)
		{
			textStatistics = new TextStatistics(Text);
		}
		return textStatistics;
	}

	public string GetWordText(int offset)
	{
		return GetSubstring(GetWordTextRange(offset), LineTerminator.CarriageReturnNewline);
	}

	public TextRange GetWordTextRange(int offset)
	{
		IWordBreakFinder wordBreakFinder = null;
		if (Document is ICodeDocument { Language: not null } codeDocument)
		{
			wordBreakFinder = codeDocument.Language.GetService<IWordBreakFinder>();
		}
		if (wordBreakFinder == null)
		{
			wordBreakFinder = new DefaultWordBreakFinder();
		}
		int num = wordBreakFinder.FindCurrentWordEnd(new TextSnapshotOffset(this, offset));
		int startOffset = wordBreakFinder.FindCurrentWordStart(new TextSnapshotOffset(this, num));
		return new TextRange(startOffset, num);
	}

	public TextPosition OffsetToPosition(int offset)
	{
		if (offset == -1)
		{
			return TextPosition.Empty;
		}
		int lineIndex = TextData.GetLineIndex(offset);
		return new TextPosition(lineIndex, offset - TextData.GetLineTextRange(lineIndex).StartOffset);
	}

	public TextRange PositionRangeToTextRange(TextPositionRange positionRange)
	{
		if (!positionRange.IsZeroLength)
		{
			return new TextRange(PositionToOffset(positionRange.StartPosition), PositionToOffset(positionRange.EndPosition));
		}
		return new TextRange(PositionToOffset(positionRange.StartPosition));
	}

	public int PositionToOffset(TextPosition position)
	{
		if (position.IsEmpty)
		{
			return -1;
		}
		int lineIndex = Math.Min(position.Line, jhZ.Count - 1);
		TextRange lineTextRange = TextData.GetLineTextRange(lineIndex);
		return lineTextRange.StartOffset + Math.Min(position.Character, lineTextRange.Length);
	}

	public TextPositionRange TextRangeToPositionRange(TextRange textRange)
	{
		return new TextPositionRange(OffsetToPosition(textRange.StartOffset), OffsetToPosition(textRange.EndOffset));
	}

	[SpecialName]
	char ITextSnapshot.get_Item(int index)
	{
		return this[index];
	}

	internal static bool U2U()
	{
		return d2P == null;
	}

	internal static TextSnapshot l22()
	{
		return d2P;
	}
}
