using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Provider;
using System.Windows.Automation.Text;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Searching;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

public class TextRangeProvider : System.Windows.Automation.Provider.ITextRangeProvider
{
	private IEditorView fnm;

	private TextSnapshotRange tnC;

	private static TextRangeProvider yOM;

	public TextRangeProvider(IEditorView view, TextRange textRange)
	{
		grA.DaB7cz();
		base._002Ector();
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		fnm = view;
		tnC = new TextSnapshotRange(view.CurrentSnapshot, textRange);
	}

	public virtual void AddToSelection()
	{
		throw new InvalidOperationException();
	}

	public virtual System.Windows.Automation.Provider.ITextRangeProvider Clone()
	{
		return new TextRangeProvider(fnm, tnC);
	}

	public virtual bool Compare(System.Windows.Automation.Provider.ITextRangeProvider range)
	{
		if (range == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197246));
		}
		if (!(range is TextRangeProvider textRangeProvider))
		{
			throw new ArgumentException(Q7Z.tqM(197260), Q7Z.tqM(197246));
		}
		if (tnC.Snapshot == null || textRangeProvider.tnC.Snapshot == null || tnC.Snapshot.Document != textRangeProvider.tnC.Snapshot.Document)
		{
			return false;
		}
		TextSnapshotRange textSnapshotRange = tnC;
		TextSnapshotRange textSnapshotRange2 = textRangeProvider.tnC;
		if (textSnapshotRange.Snapshot.Version.Number < textSnapshotRange2.Snapshot.Version.Number)
		{
			textSnapshotRange = textSnapshotRange.TranslateTo(textSnapshotRange2.Snapshot, TextRangeTrackingModes.Default);
		}
		else
		{
			textSnapshotRange2 = textSnapshotRange2.TranslateTo(textSnapshotRange.Snapshot, TextRangeTrackingModes.Default);
		}
		return textSnapshotRange.Equals(textSnapshotRange2);
	}

	public virtual int CompareEndpoints(TextPatternRangeEndpoint endpoint, System.Windows.Automation.Provider.ITextRangeProvider targetRange, TextPatternRangeEndpoint targetEndpoint)
	{
		if (targetRange == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197390));
		}
		if (!(targetRange is TextRangeProvider textRangeProvider))
		{
			throw new ArgumentException(Q7Z.tqM(197260), Q7Z.tqM(197390));
		}
		if (tnC.Snapshot == null || textRangeProvider.tnC.Snapshot == null || tnC.Snapshot.Document != textRangeProvider.tnC.Snapshot.Document)
		{
			throw new ArgumentException(Q7Z.tqM(197416), Q7Z.tqM(197390));
		}
		TextSnapshotRange textSnapshotRange = tnC;
		TextSnapshotRange textSnapshotRange2 = textRangeProvider.tnC;
		if (textSnapshotRange.Snapshot.Version.Number < textSnapshotRange2.Snapshot.Version.Number)
		{
			textSnapshotRange = textSnapshotRange.TranslateTo(textSnapshotRange2.Snapshot, TextRangeTrackingModes.Default);
		}
		else
		{
			textSnapshotRange2 = textSnapshotRange2.TranslateTo(textSnapshotRange.Snapshot, TextRangeTrackingModes.Default);
		}
		int num = ((endpoint == TextPatternRangeEndpoint.Start) ? textSnapshotRange.StartOffset : textSnapshotRange.EndOffset);
		int value = ((targetEndpoint == TextPatternRangeEndpoint.Start) ? textSnapshotRange2.StartOffset : textSnapshotRange2.EndOffset);
		return num.CompareTo(value);
	}

	public virtual void ExpandToEnclosingUnit(TextUnit unit)
	{
	}

	public virtual System.Windows.Automation.Provider.ITextRangeProvider FindAttribute(int attribute, object value, bool backward)
	{
		throw new NotImplementedException();
	}

	public virtual System.Windows.Automation.Provider.ITextRangeProvider FindText(string text, bool backward, bool ignoreCase)
	{
		if (text == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192708));
		}
		EditorSearchOptions editorSearchOptions = new EditorSearchOptions();
		editorSearchOptions.FindText = text;
		editorSearchOptions.MatchCase = !ignoreCase;
		editorSearchOptions.SearchUp = backward;
		ISearchResultSet searchResultSet = tnC.Snapshot.FindNext(editorSearchOptions, tnC.StartOffset, canWrap: true, tnC);
		if (searchResultSet.Results.Count > 0)
		{
			return new TextRangeProvider(fnm, new TextSnapshotRange(tnC.Snapshot, searchResultSet.Results[0].TextRange));
		}
		return null;
	}

	public virtual object GetAttributeValue(int attribute)
	{
		return AutomationElement.NotSupported;
	}

	public virtual double[] GetBoundingRectangles()
	{
		TextRange normalizedTextRange = tnC.TranslateTo(fnm.CurrentSnapshot, TextRangeTrackingModes.Default).TextRange.NormalizedTextRange;
		List<double> list = new List<double>();
		foreach (ITextViewLine visibleViewLine in fnm.VisibleViewLines)
		{
			TextRange textRange = TextRange.Intersect(normalizedTextRange, visibleViewLine.TextRangeIncludingLineTerminator);
			if (textRange.IsDeleted)
			{
				continue;
			}
			IEnumerable<TextBounds> textBounds = visibleViewLine.GetTextBounds(textRange);
			foreach (TextBounds item in textBounds)
			{
				Rect rect = fnm.TransformFromTextArea(item.Rect);
				Point point = fnm.SyntaxEditor.PointToScreen(rect.TopLeft);
				rect.X = point.X;
				rect.Y = point.Y;
				list.Add(rect.Left);
				list.Add(rect.Top);
				list.Add(rect.Width);
				list.Add(rect.Height);
			}
		}
		return list.ToArray();
	}

	public virtual IRawElementProviderSimple[] GetChildren()
	{
		return new IRawElementProviderSimple[0];
	}

	public virtual IRawElementProviderSimple GetEnclosingElement()
	{
		return null;
	}

	public virtual string GetText(int maxLength)
	{
		if (maxLength < -1)
		{
			throw new ArgumentOutOfRangeException(Q7Z.tqM(197536));
		}
		maxLength = ((maxLength >= 0) ? Math.Min(maxLength, tnC.AbsoluteLength) : tnC.AbsoluteLength);
		return tnC.Snapshot.GetSubstring(tnC.StartOffset, maxLength, LineTerminator.Newline);
	}

	public virtual int Move(TextUnit unit, int count)
	{
		return 0;
	}

	public virtual void MoveEndpointByRange(TextPatternRangeEndpoint endpoint, System.Windows.Automation.Provider.ITextRangeProvider targetRange, TextPatternRangeEndpoint targetEndpoint)
	{
	}

	public virtual int MoveEndpointByUnit(TextPatternRangeEndpoint endpoint, TextUnit unit, int count)
	{
		return 0;
	}

	public virtual void RemoveFromSelection()
	{
		throw new InvalidOperationException();
	}

	public virtual void ScrollIntoView(bool alignToTop)
	{
		TextSnapshotRange textSnapshotRange = tnC.TranslateTo(fnm.CurrentSnapshot, TextRangeTrackingModes.Default);
		if (!alignToTop)
		{
			fnm.Scroller.ScrollIntoView(textSnapshotRange.PositionRange.LastPosition, scrollToVerticalMiddle: true);
		}
		else
		{
			fnm.Scroller.ScrollIntoView(textSnapshotRange.PositionRange.FirstPosition, scrollToVerticalMiddle: true);
		}
	}

	public virtual void Select()
	{
		TextSnapshotRange textSnapshotRange = tnC.TranslateTo(fnm.CurrentSnapshot, TextRangeTrackingModes.Default);
		fnm.Selection.SelectRange(textSnapshotRange.TextRange);
	}

	internal static bool iO3()
	{
		return yOM == null;
	}

	internal static TextRangeProvider qOv()
	{
		return yOM;
	}
}
