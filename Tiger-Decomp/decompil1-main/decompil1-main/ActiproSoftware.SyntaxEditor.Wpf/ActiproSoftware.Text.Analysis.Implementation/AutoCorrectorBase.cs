using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Text.Analysis.Implementation;

public abstract class AutoCorrectorBase : IAutoCorrector, IEditorDocumentTextChangeEventSink, IEditorViewSelectionChangeEventSink
{
	private static AutoCorrectorBase PGV;

	void IEditorDocumentTextChangeEventSink.NotifyDocumentTextChanged(SyntaxEditor editor, EditorSnapshotChangedEventArgs e)
	{
		if (editor == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(13940));
		}
		if (editor.IsAutoCorrectEnabled)
		{
			OnDocumentTextChanged(editor, e);
		}
	}

	void IEditorDocumentTextChangeEventSink.NotifyDocumentTextChanging(SyntaxEditor editor, EditorSnapshotChangingEventArgs e)
	{
		if (editor == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(13940));
		}
		if (editor.IsAutoCorrectEnabled)
		{
			OnDocumentTextChanging(editor, e);
		}
	}

	void IEditorViewSelectionChangeEventSink.NotifySelectionChanged(IEditorView view, EditorViewSelectionEventArgs e)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.SyntaxEditor == null || view.SyntaxEditor.IsAutoCorrectEnabled)
		{
			OnViewSelectionChanged(view, e);
		}
	}

	private void S5o(ICodeDocument P_0, int P_1)
	{
		g5j(P_0, _0020: false);
		if (P_1 >= 0 && P_1 < P_0.CurrentSnapshot.Lines.Count)
		{
			AutoCorrect(P_0.CurrentSnapshot.Lines[P_1].SnapshotRange);
		}
	}

	private static void g5j(ICodeDocument P_0, bool P_1)
	{
		if (P_0 == null)
		{
			return;
		}
		if (P_1)
		{
			P_0.Properties[Q7Z.tqM(201974)] = true;
		}
		else if (P_0.Properties.ContainsKey(Q7Z.tqM(201974)))
		{
			P_0.Properties.Remove(Q7Z.tqM(201974));
			int num = 0;
			if (!vGI())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	private static bool N5w(ICodeDocument P_0)
	{
		bool value = false;
		P_0?.Properties.TryGetValue<bool>(Q7Z.tqM(201974), out value);
		return value;
	}

	public abstract void AutoCorrect(TextSnapshotRange snapshotRange);

	protected virtual void OnDocumentTextChanged(SyntaxEditor editor, EditorSnapshotChangedEventArgs e)
	{
		if (editor == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(13940));
		}
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		if (e.TextChange == null || e.TextChange.Type == TextChangeTypes.AutoCorrect || e.TextChange.IsRedo || e.TextChange.IsUndo || e.TextChange.Source != editor.ActiveView)
		{
			return;
		}
		if (e.TextChange.Operations != null && e.TextChange.Operations.Count > 0 && e.TextChange.Operations[e.TextChange.Operations.Count - 1].IsProgrammaticTextReplacement)
		{
			g5j(editor.Document, _0020: false);
			return;
		}
		TextSnapshotRange textSnapshotRange = ((e.TextChange.Operations.Count == 1) ? new TextSnapshotRange(e.NewSnapshot, e.TextChange.Operations[0].StartOffset, e.TextChange.Operations[0].InsertionEndOffset) : e.ChangedSnapshotRange);
		if (!textSnapshotRange.IsDeleted)
		{
			TextSnapshotRange snapshotRange = editor.ActiveView.CurrentSnapshotLine.SnapshotRange;
			if (textSnapshotRange.Snapshot.Document == snapshotRange.Snapshot.Document)
			{
				textSnapshotRange = new TextSnapshotRange(textSnapshotRange.Snapshot, textSnapshotRange.StartLine.StartOffset, textSnapshotRange.EndLine.EndOffset).TranslateTo(snapshotRange.Snapshot, TextRangeTrackingModes.Default);
				if (textSnapshotRange.StartPosition.Line < snapshotRange.StartPosition.Line || textSnapshotRange.EndPosition.Line > snapshotRange.EndPosition.Line)
				{
					AutoCorrect(textSnapshotRange);
					if (textSnapshotRange.Contains(snapshotRange))
					{
						g5j(editor.Document, _0020: false);
						return;
					}
				}
			}
		}
		g5j(editor.Document, _0020: true);
	}

	protected virtual void OnDocumentTextChanging(SyntaxEditor editor, EditorSnapshotChangingEventArgs e)
	{
	}

	protected virtual void OnViewSelectionChanged(IEditorView view, EditorViewSelectionEventArgs e)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		bool flag = !view.IsActive || e.CaretPosition.Line == e.PreviousCaretPosition.Line;
		int num = 0;
		if (!vGI())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (!flag)
		{
			IEditorDocument document = view.SyntaxEditor.Document;
			if (N5w(document))
			{
				S5o(document, e.PreviousCaretPosition.Line);
			}
		}
	}

	protected AutoCorrectorBase()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool vGI()
	{
		return PGV == null;
	}

	internal static AutoCorrectorBase rGc()
	{
		return PGV;
	}
}
