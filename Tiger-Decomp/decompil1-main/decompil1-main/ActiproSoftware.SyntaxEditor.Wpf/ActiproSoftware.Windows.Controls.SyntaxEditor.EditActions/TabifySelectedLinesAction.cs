using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tabify")]
public class TabifySelectedLinesAction : EditActionBase
{
	internal static TabifySelectedLinesAction jZ3;

	public TabifySelectedLinesAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandTabifySelectedLinesText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		return !view.SyntaxEditor.Document.IsReadOnly;
	}

	public override void Execute(IEditorView view)
	{
		int num = 1;
		bool flag = default(bool);
		int num5 = default(int);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
				{
					if (flag)
					{
						throw new ArgumentNullException(Q7Z.tqM(952));
					}
					ITextSnapshot currentSnapshot = view.CurrentSnapshot;
					int num3 = -1;
					List<TextRange> list = new List<TextRange>();
					foreach (TextPositionRange range in view.Selection.Ranges)
					{
						int line = range.FirstPosition.Line;
						int line2 = range.LastPosition.Line;
						if (line2 > num3)
						{
							line = Math.Max(num3 + 1, line);
							int num4 = 0;
							if (!KZv())
							{
								num4 = num5;
							}
							switch (num4)
							{
							}
							num3 = line2;
							TextRange item = new TextRange(currentSnapshot.Lines[line].StartOffset, currentSnapshot.Lines[line2].EndOffset);
							list.Add(item);
						}
					}
					ITextChange textChange = ConvertSpacesToTabsAction.TLz(view.CurrentSnapshot, list, new EditorViewTextChangeOptions(view)
					{
						CheckReadOnly = true
					}, view.SyntaxEditor.Document.TabSize, _0020: true);
					textChange.Apply(list, view.Selection.Ranges.PrimaryIndex, TextRangeTrackingModes.ExpandBothEdges);
					return;
				}
				case 1:
					break;
				}
				flag = view == null;
				num2 = 0;
			}
			while (KZv());
		}
	}

	internal static bool KZv()
	{
		return jZ3 == null;
	}

	internal static TabifySelectedLinesAction JZf()
	{
		return jZ3;
	}
}
