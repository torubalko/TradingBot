using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Undo;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Internal;

internal class vAl : ITextViewLine, ITextRangeProvider
{
	private TextPosition zLG;

	private ITextView CLX;

	private TextViewLineVisibility KLK;

	internal static vAl yWI;

	public double Baseline => 0.0;

	public double BottomMargin => 0.0;

	public Rect Bounds => Rect.Empty;

	public TextViewLineChange Change => TextViewLineChange.None;

	public int CharacterCount => 0;

	public int EndOffset => CLX.CurrentSnapshot.Length;

	public int EndOffsetIncludingLineTerminator => CLX.CurrentSnapshot.Length;

	public TextPosition EndPosition => zLG;

	public TextPosition EndPositionIncludingLineTerminator => zLG;

	public int FirstNonWhitespaceCharacterIndex => 0;

	public int FirstNonWhitespaceOffset => CLX.CurrentSnapshot.Length;

	public bool HasHardLineBreak => true;

	public int IndentAmount => 0;

	public bool IsFirstLine => false;

	public bool IsLastLine => false;

	public bool IsPureWhitespace => true;

	public bool IsVirtualLine => true;

	public bool IsWrapped => false;

	public TextPosition MaxPosition => new TextPosition(zLG.Line, int.MaxValue);

	public ITextViewLine NextLine => View.GetViewLine(this, 1, forceVirtualSpace: true);

	public TextPositionRange PositionRange => new TextPositionRange(zLG);

	public ITextViewLine PreviousLine => View.GetViewLine(this, -1, forceVirtualSpace: true);

	public SavePointChangeType SavePointChangeType => SavePointChangeType.None;

	public Size Size => Size.Empty;

	public TextSnapshotRange SnapshotRange => new TextSnapshotRange(CLX.CurrentSnapshot, TextRange);

	public TextSnapshotRange SnapshotRangeIncludingLineTerminator => new TextSnapshotRange(CLX.CurrentSnapshot, TextRangeIncludingLineTerminator);

	public int StartOffset => CLX.CurrentSnapshot.Length;

	public TextPosition StartPosition => zLG;

	public int TabStopLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string Text
	{
		get
		{
			return string.Empty;
		}
		set
		{
		}
	}

	public Rect TextBounds => Rect.Empty;

	public TextRange TextRange
	{
		get
		{
			return new TextRange(CLX.CurrentSnapshot.Length);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public TextRange TextRangeIncludingLineTerminator => new TextRange(CLX.CurrentSnapshot.Length);

	public Size TextSize => Size.Empty;

	public double TopMargin => 0.0;

	public double TranslationY => 0.0;

	public ITextView View => CLX;

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	public TextViewLineVisibility Visibility
	{
		get
		{
			return KLK;
		}
		internal set
		{
			KLK = kLK;
		}
	}

	public IEnumerable<TextSnapshotRange> VisibleSnapshotRanges
	{
		get
		{
			yield return SnapshotRange;
		}
	}

	public TextPosition VisibleStartPosition => StartPosition;

	public int WordWrapIndex => 0;

	public vAl(ITextView P_0, TextPosition P_1)
	{
		grA.DaB7cz();
		zLG = TextPosition.Empty;
		KLK = TextViewLineVisibility.Hidden;
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		CLX = P_0;
		zLG = P_1;
	}

	public int CharacterIndexToOffset(int P_0)
	{
		return CLX.CurrentSnapshot.Length;
	}

	public TextPosition CharacterIndexToPosition(int P_0)
	{
		return new TextPosition(zLG.Line, Math.Max(0, P_0));
	}

	public TextBounds GetCharacterBounds(int P_0)
	{
		return ActiproSoftware.Windows.Controls.SyntaxEditor.TextBounds.Empty;
	}

	public TextBounds GetCharacterBounds(TextPosition P_0)
	{
		return ActiproSoftware.Windows.Controls.SyntaxEditor.TextBounds.Empty;
	}

	public int GetCharacterColumn(int P_0)
	{
		return 0;
	}

	public int GetCharacterColumn(TextPosition P_0)
	{
		return 0;
	}

	public IEnumerable<TagSnapshotRange<oAv>> GetIntraLineSpacerTags<oAv>() where oAv : IIntraLineSpacerTag
	{
		yield break;
	}

	public TextBounds GetIntraTextSpacerBounds(object P_0)
	{
		return ActiproSoftware.Windows.Controls.SyntaxEditor.TextBounds.Empty;
	}

	public TagSnapshotRange<IIntraTextSpacerTag> GetIntraTextSpacerTag(int P_0)
	{
		return null;
	}

	public IEnumerable<TagSnapshotRange<yA4>> GetIntraTextSpacerTags<yA4>() where yA4 : IIntraTextSpacerTag
	{
		yield break;
	}

	public IEnumerable<TextBounds> GetTextBounds(TextRange P_0)
	{
		yield break;
	}

	public IEnumerable<TextBounds> GetTextBounds(TextPositionRange P_0)
	{
		yield break;
	}

	public bool IsVirtualCharacter(int P_0, bool P_1)
	{
		return true;
	}

	public int LocationToCharacterIndex(double P_0, LocationToPositionAlgorithm P_1)
	{
		return 0;
	}

	public int LocationToOffset(double P_0, LocationToPositionAlgorithm P_1)
	{
		return CLX.CurrentSnapshot.Length;
	}

	public TextPosition LocationToPosition(double P_0, LocationToPositionAlgorithm P_1)
	{
		return LocationToPosition(P_0, P_1, _0020: true);
	}

	public TextPosition LocationToPosition(double P_0, LocationToPositionAlgorithm P_1, bool P_2)
	{
		return zLG;
	}

	public int OffsetToCharacterIndex(int P_0)
	{
		return 0;
	}

	public int PositionToCharacterIndex(TextPosition P_0)
	{
		return Math.Max(0, P_0.Character);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, Q7Z.tqM(194362), new object[1] { TextRangeIncludingLineTerminator });
	}

	internal static bool aWc()
	{
		return yWI == null;
	}

	internal static vAl NWd()
	{
		return yWI;
	}
}
