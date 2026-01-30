using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Analysis;
using ActiproSoftware.Text.Analysis.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.EditActions;

public class SelectToMatchingBracketAction : EditActionBase
{
	private static SelectToMatchingBracketAction aRO;

	public SelectToMatchingBracketAction()
	{
		grA.DaB7cz();
		base._002Ector(SR.GetString(SRName.UICommandSelectToMatchingBracketText));
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
		IStructureMatchResult structureMatchResult = null;
		for (int i = 0; i < structureMatchResultSet.Results.Count; i++)
		{
			IStructureMatchResult structureMatchResult2 = structureMatchResultSet.Results[i];
			if (structureMatchResult2 != null && structureMatchResult2.IsSource)
			{
				num = i;
				structureMatchResult = structureMatchResult2;
				break;
			}
		}
		IStructureMatchResult structureMatchResult3 = null;
		for (int j = num + 1; j < structureMatchResultSet.Results.Count; j++)
		{
			IStructureMatchResult structureMatchResult4 = structureMatchResultSet.Results[j];
			if (structureMatchResult4 != null && structureMatchResult4.NavigationSnapshotOffset.HasValue)
			{
				structureMatchResult3 = structureMatchResult4;
				break;
			}
		}
		if (structureMatchResult3 == null)
		{
			for (int k = 0; k < num; k++)
			{
				IStructureMatchResult structureMatchResult5 = structureMatchResultSet.Results[k];
				if (structureMatchResult5 != null && structureMatchResult5.NavigationSnapshotOffset.HasValue)
				{
					structureMatchResult3 = structureMatchResult5;
					break;
				}
			}
		}
		if (structureMatchResult3 != null)
		{
			if (structureMatchResult != null && structureMatchResult.NavigationSnapshotOffset.HasValue)
			{
				view.Selection.SelectRange(new TextRange(structureMatchResult.NavigationSnapshotOffset.Value, structureMatchResult3.NavigationSnapshotOffset.Value));
			}
			else
			{
				view.Selection.EndOffset = structureMatchResult3.NavigationSnapshotOffset.Value;
			}
		}
	}

	internal static bool iR1()
	{
		return aRO == null;
	}

	internal static SelectToMatchingBracketAction cR5()
	{
		return aRO;
	}
}
