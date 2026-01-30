using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Untabify")]
public class UntabifySelectedLinesAction : EditActionBase
{
	private static UntabifySelectedLinesAction qZC;

	public UntabifySelectedLinesAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandUntabifySelectedLinesText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view != null)
		{
			return !view.SyntaxEditor.Document.IsReadOnly;
		}
		throw new ArgumentNullException(Q7Z.tqM(952));
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		ITextSnapshot currentSnapshot = view.CurrentSnapshot;
		int num = -1;
		List<TextRange> list = new List<TextRange>();
		foreach (TextPositionRange range in view.Selection.Ranges)
		{
			int line = range.FirstPosition.Line;
			int line2 = range.LastPosition.Line;
			if (line2 > num)
			{
				line = Math.Max(num + 1, line);
				num = line2;
				TextRange item = new TextRange(currentSnapshot.Lines[line].StartOffset, currentSnapshot.Lines[line2].EndOffset);
				list.Add(item);
			}
		}
		ITextChange textChange = ConvertTabsToSpacesAction.unP(view.CurrentSnapshot, list, new EditorViewTextChangeOptions(view)
		{
			CheckReadOnly = true
		}, view.SyntaxEditor.Document.TabSize, _0020: true);
		textChange.Apply(list, view.Selection.Ranges.PrimaryIndex, TextRangeTrackingModes.ExpandBothEdges);
	}

	internal static bool xZr()
	{
		return qZC == null;
	}

	internal static UntabifySelectedLinesAction hZX()
	{
		return qZC;
	}
}
