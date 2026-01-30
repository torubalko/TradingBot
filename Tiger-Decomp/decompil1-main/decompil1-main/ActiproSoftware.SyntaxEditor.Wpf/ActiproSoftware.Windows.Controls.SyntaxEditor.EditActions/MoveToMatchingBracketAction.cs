using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Analysis;
using ActiproSoftware.Text.Analysis.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class MoveToMatchingBracketAction : EditActionBase
{
	internal static MoveToMatchingBracketAction hFv;

	public MoveToMatchingBracketAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandMoveToMatchingBracketText));
	}

	public override bool CanExecute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEditorDocument document = view.SyntaxEditor.Document;
		return document != null && document.Language != null && document.Language.GetStructureMatcher() != null;
	}

	public override void Execute(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		IEditorDocument document = view.SyntaxEditor.Document;
		if (document == null || document.Language == null)
		{
			return;
		}
		IStructureMatcher structureMatcher = document.Language.GetStructureMatcher();
		if (structureMatcher == null)
		{
			return;
		}
		TextSnapshotOffset endSnapshotOffset = view.Selection.EndSnapshotOffset;
		IStructureMatchResultSet structureMatchResultSet = structureMatcher.Match(endSnapshotOffset, new StructureMatchOptions
		{
			IsNavigationRequest = true
		});
		if (structureMatchResultSet == null || structureMatchResultSet.Results == null || structureMatchResultSet.Results.Count <= 1)
		{
			return;
		}
		int num = -1;
		for (int i = 0; i < structureMatchResultSet.Results.Count; i++)
		{
			IStructureMatchResult structureMatchResult = structureMatchResultSet.Results[i];
			if (structureMatchResult != null && structureMatchResult.IsSource)
			{
				num = i;
				break;
			}
		}
		for (int j = num + 1; j < structureMatchResultSet.Results.Count; j++)
		{
			IStructureMatchResult structureMatchResult2 = structureMatchResultSet.Results[j];
			if (structureMatchResult2 != null && structureMatchResult2.NavigationSnapshotOffset.HasValue)
			{
				view.Selection.StartOffset = structureMatchResult2.NavigationSnapshotOffset.Value;
				return;
			}
		}
		for (int k = 0; k < num; k++)
		{
			IStructureMatchResult structureMatchResult3 = structureMatchResultSet.Results[k];
			if (structureMatchResult3 != null && structureMatchResult3.NavigationSnapshotOffset.HasValue)
			{
				view.Selection.StartOffset = structureMatchResult3.NavigationSnapshotOffset.Value;
				break;
			}
		}
	}

	internal static bool XFf()
	{
		return hFv == null;
	}

	internal static MoveToMatchingBracketAction KFi()
	{
		return hFv;
	}
}
