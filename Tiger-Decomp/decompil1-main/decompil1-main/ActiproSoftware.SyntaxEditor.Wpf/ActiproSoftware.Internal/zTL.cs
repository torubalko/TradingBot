using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows;
using System.Windows.Input;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Internal;

internal class zTL
{
	private enum U7o
	{

	}

	private bool QYJ;

	private SyntaxEditor kYt;

	internal static zTL LA2;

	public zTL(SyntaxEditor P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8238));
		}
		kYt = P_0;
		VYi();
	}

	private static Point VY0(EditorView P_0, DragEventArgs P_1)
	{
		return P_0.TransformToTextArea(P_1.GetPosition(P_0.VisualElement));
	}

	private static bool cYB(EditorView P_0, IDataStore P_1)
	{
		string text = P_0.SyntaxEditor.Document.UniqueId.ToString();
		string text2 = P_1.GetData(Q7Z.tqM(192988)) as string;
		return text2 != text;
	}

	private Tuple<U7o, TextPositionRange> AYV(EditorView P_0, IDataStore P_1, TextPosition P_2)
	{
		if (cYB(P_0, P_1))
		{
			return Tuple.Create((U7o)2, TextPositionRange.Empty);
		}
		string text = P_1.GetData(Q7Z.tqM(193036)) as string;
		if (!string.IsNullOrEmpty(text))
		{
			string[] array = text.Split(';');
			if (array.Length == 4 && int.TryParse(array[0], out var result) && int.TryParse(array[1], out var result2) && int.TryParse(array[2], out var result3) && int.TryParse(array[3], out var result4))
			{
				TextPositionRange normalizedTextPositionRange = new TextPositionRange(result, result2, result3, result4).NormalizedTextPositionRange;
				if (!normalizedTextPositionRange.Contains(P_2))
				{
					return Tuple.Create((U7o)1, normalizedTextPositionRange);
				}
			}
		}
		return Tuple.Create((U7o)0, TextPositionRange.Empty);
	}

	private void wYr(EditorView P_0, DragEventArgs P_1)
	{
		QYJ = !P_0.SyntaxEditor.Document.IsReadOnly;
		cTH cTH2 = new cTH(P_1.Data);
		string text = cTH2.GetText();
		PasteDragDropEventArgs e = new PasteDragDropEventArgs(PasteDragDropAction.DragEnter, P_1, text);
		P_0.SyntaxEditor.Uxj(e);
		QYJ &= e.Text != null;
		NY9(P_0, P_1, _0020: false);
	}

	private void rYs(EditorView P_0, DragEventArgs P_1)
	{
		P_1.Handled = true;
		P_0.SyntaxEditor.LGl().cRw(_0020: true);
		QYJ = false;
	}

	private void IYk(EditorView P_0, DragEventArgs P_1)
	{
		NY9(P_0, P_1, _0020: true);
	}

	private void hYS(EditorView P_0, DragEventArgs P_1)
	{
		P_0.SyntaxEditor.LGl().cRw(_0020: true);
		if (QYJ)
		{
			QYJ = false;
			IDataObject data = P_1.Data;
			if (data != null && OYq(P_1) != DragDropEffects.None)
			{
				Point location = VY0(P_0, P_1);
				TextPosition textPosition = P_0.LocationToPosition(location, LocationToPositionAlgorithm.BestFit);
				P_0.SyntaxEditor.gGw().K4g(P_0, _0020: false);
				cTH cTH2 = new cTH(data);
				bool flag = cTH2.TextKind == DataStoreTextKind.Block;
				EditorViewTextChangeOptions editorViewTextChangeOptions = new EditorViewTextChangeOptions(P_0)
				{
					CheckReadOnly = true,
					IsBlock = flag,
					SelectInsertedText = P_0.SyntaxEditor.IsDragDropTextReselectEnabled
				};
				Tuple<U7o, TextPositionRange> tuple = AYV(P_0, cTH2, textPosition);
				switch (tuple.Item1)
				{
				case (U7o)2:
				{
					string text2 = cTH2.GetText();
					PasteDragDropEventArgs e2 = new PasteDragDropEventArgs(PasteDragDropAction.DragDrop, P_1, text2);
					P_0.SyntaxEditor.Uxj(e2);
					DragDropEffects dragDropEffects = OYq(P_1);
					if (!string.IsNullOrEmpty(e2.Text))
					{
						P_0.Selection.StartPosition = textPosition;
						P_0.ReplaceSelectedText(TextChangeTypes.DragAndDrop, e2.Text, editorViewTextChangeOptions);
						NY2(P_1, dragDropEffects);
						return;
					}
					break;
				}
				case (U7o)1:
				{
					string text = cTH2.GetText();
					PasteDragDropEventArgs e = new PasteDragDropEventArgs(PasteDragDropAction.DragDrop, P_1, text);
					P_0.SyntaxEditor.Uxj(e);
					DragDropEffects dragDropEffects = OYq(P_1);
					NY2(P_1, DragDropEffects.Copy);
					TextPositionRange item = tuple.Item2;
					if (flag)
					{
						if (P_0.Selection.Mode != SelectionModes.Block || P_0.Selection.PositionRange != item)
						{
							P_0.Selection.SelectRange(item, SelectionModes.Block);
						}
						string selectedText = P_0.SelectedText;
						if (dragDropEffects == DragDropEffects.Move)
						{
							P_0.DeleteSelectedText(TextChangeTypes.DragAndDrop);
							editorViewTextChangeOptions.CanMergeIntoPreviousChange = true;
						}
						P_0.Selection.StartPosition = textPosition;
						P_0.ReplaceSelectedText(TextChangeTypes.DragAndDrop, selectedText, editorViewTextChangeOptions);
						return;
					}
					ITextChange textChange = P_0.CurrentSnapshot.Document.CreateTextChange(TextChangeTypes.DragAndDrop, editorViewTextChangeOptions);
					TextRange textRange = P_0.CurrentSnapshot.PositionRangeToTextRange(item);
					string substring = P_0.CurrentSnapshot.GetSubstring(textRange, LineTerminator.Newline);
					int num = P_0.PositionToOffset(textPosition);
					if (dragDropEffects == DragDropEffects.Move)
					{
						if (num >= textRange.EndOffset)
						{
							num -= textRange.AbsoluteLength;
						}
						else if (num >= textRange.StartOffset)
						{
							num -= num - textRange.StartOffset;
						}
					}
					if (dragDropEffects == DragDropEffects.Move)
					{
						textChange.DeleteText(textRange);
					}
					textChange.InsertText(num, substring);
					textChange.Apply();
					if (editorViewTextChangeOptions.SelectInsertedText)
					{
						P_0.Selection.SelectRange(num, substring.Length);
					}
					return;
				}
				}
			}
		}
		NY2(P_1, DragDropEffects.None);
	}

	private void NY9(EditorView P_0, DragEventArgs P_1, bool P_2)
	{
		DragDropEffects dragDropEffects = DragDropEffects.None;
		if (QYJ)
		{
			IDataObject data = P_1.Data;
			if (data != null)
			{
				dragDropEffects = OYq(P_1);
				if (dragDropEffects != DragDropEffects.None)
				{
					Point location = VY0(P_0, P_1);
					TextPosition textPosition = P_0.LocationToPosition(location, LocationToPositionAlgorithm.BestFit);
					nR nR2 = P_0.DAb();
					if (nR2 != null && nR2.ActualHeight > 40.0)
					{
						ITextViewLineCollection visibleViewLines = P_0.VisibleViewLines;
						if (visibleViewLines != null && visibleViewLines.Count > 0)
						{
							if (location.Y <= 20.0 && visibleViewLines[0].StartOffset > 0)
							{
								P_0.lfz().ScrollUp();
							}
							else if (location.Y > nR2.ActualHeight - 20.0 && visibleViewLines[visibleViewLines.Count - 1].EndOffsetIncludingLineTerminator < P_0.CurrentSnapshot.Length)
							{
								P_0.lfz().ScrollDown();
							}
						}
					}
					P_0.lfz().C46(textPosition, _0020: false);
					P_0.SyntaxEditor.gGw().K4g(P_0, _0020: false);
					cTH cTH2 = new cTH(data);
					Tuple<U7o, TextPositionRange> tuple = AYV(P_0, cTH2, textPosition);
					if (tuple.Item1 != 0)
					{
						P_0.SyntaxEditor.LGl().uRT(textPosition);
						if (P_2)
						{
							string text = cTH2.GetText();
							PasteDragDropEventArgs e = new PasteDragDropEventArgs(PasteDragDropAction.DragOver, P_1, text);
							P_0.SyntaxEditor.Uxj(e);
							dragDropEffects = OYq(P_1);
						}
						NY2(P_1, dragDropEffects);
						return;
					}
				}
			}
		}
		P_0.SyntaxEditor.LGl().cRw(_0020: false);
		NY2(P_1, DragDropEffects.None);
	}

	public void RYy(EditorView P_0, InputPointerEventArgs P_1)
	{
		if (P_0.Selection.Ranges.Count == 1 && !P_0.Selection.IsZeroLength && fTO.bRt())
		{
			P_0.SyntaxEditor.IntelliPrompt.CloseAllSessions();
			cTH cTH2 = new cTH();
			cTH2.SetText(P_0.SelectedText, (P_0.Selection.Mode == SelectionModes.Block) ? DataStoreTextKind.Block : DataStoreTextKind.Default);
			cTH2.mY3(P_0.SyntaxEditor, P_0.CurrentSnapshot, P_0.Selection.GetTextRanges());
			cTH2.rYR(P_0);
			CutCopyDragEventArgs e = new CutCopyDragEventArgs(CutCopyDragAction.Drag, cTH2);
			P_0.SyntaxEditor.mxe(e);
			SY7(P_0, P_1, cTH2);
			int num = 0;
			if (gAI() != null)
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

	private static DragDropEffects OYq(DragEventArgs P_0)
	{
		DragDropEffects allowedEffects = P_0.AllowedEffects;
		DragDropEffects effects = P_0.Effects;
		DragDropEffects result = default(DragDropEffects);
		if ((vAE.A0o() & ModifierKeys.Control) != ModifierKeys.Control && effects != DragDropEffects.Copy && (allowedEffects & DragDropEffects.Move) == DragDropEffects.Move)
		{
			result = DragDropEffects.Move;
			goto IL_0043;
		}
		bool flag = (allowedEffects & DragDropEffects.Copy) == DragDropEffects.Copy || allowedEffects == DragDropEffects.None;
		int num = 1;
		if (gAI() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0043:
		return result;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
				if (flag)
				{
					result = DragDropEffects.Copy;
					break;
				}
				goto IL_0060;
			}
			break;
			IL_0060:
			result = DragDropEffects.None;
			num = 0;
			if (rAV())
			{
				continue;
			}
			goto IL_0005;
		}
		goto IL_0043;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private static void NY2(DragEventArgs P_0, DragDropEffects P_1)
	{
		P_0.Effects = P_1;
		P_0.Handled = true;
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", MessageId = "e")]
	public void SY7(EditorView P_0, InputPointerEventArgs P_1, IDataStore P_2)
	{
		DragDropEffects dragDropEffects = DragDropEffects.None;
		try
		{
			DragDropEffects allowedEffects = (DragDropEffects)(1 | ((!P_0.Selection.IsReadOnly) ? 2 : 0));
			dragDropEffects = DragDrop.DoDragDrop(P_0, P_2.ToDataObject(), allowedEffects);
		}
		catch (SecurityException)
		{
		}
		switch (dragDropEffects)
		{
		case DragDropEffects.Move:
			P_0.DeleteSelectedText(TextChangeTypes.DragAndDrop);
			break;
		case DragDropEffects.None:
			P_0.lfz().ScrollToCaret();
			break;
		}
	}

	private void VYi()
	{
		kYt.DragEnter += delegate(object P_0, DragEventArgs P_1)
		{
			ATk aTk = new ATk(kYt, P_1.GetPosition(kYt), _0020: true);
			if (aTk.View is EditorView editorView)
			{
				wYr(editorView, P_1);
			}
		};
		kYt.DragLeave += delegate(object P_0, DragEventArgs P_1)
		{
			ATk aTk = new ATk(kYt, P_1.GetPosition(kYt), _0020: true);
			if (aTk.View is EditorView editorView)
			{
				rYs(editorView, P_1);
			}
		};
		kYt.DragOver += delegate(object P_0, DragEventArgs P_1)
		{
			ATk aTk = new ATk(kYt, P_1.GetPosition(kYt), _0020: true);
			if (aTk.View is EditorView editorView)
			{
				IYk(editorView, P_1);
			}
		};
		kYt.Drop += delegate(object P_0, DragEventArgs P_1)
		{
			ATk aTk = new ATk(kYt, P_1.GetPosition(kYt), _0020: true);
			if (aTk.View is EditorView editorView)
			{
				hYS(editorView, P_1);
			}
		};
	}

	[CompilerGenerated]
	private void pYp(object P_0, DragEventArgs P_1)
	{
		ATk aTk = new ATk(kYt, P_1.GetPosition(kYt), _0020: true);
		if (aTk.View is EditorView editorView)
		{
			wYr(editorView, P_1);
		}
	}

	[CompilerGenerated]
	private void UYM(object P_0, DragEventArgs P_1)
	{
		ATk aTk = new ATk(kYt, P_1.GetPosition(kYt), _0020: true);
		if (aTk.View is EditorView editorView)
		{
			rYs(editorView, P_1);
		}
	}

	[CompilerGenerated]
	private void xYO(object P_0, DragEventArgs P_1)
	{
		ATk aTk = new ATk(kYt, P_1.GetPosition(kYt), _0020: true);
		if (aTk.View is EditorView editorView)
		{
			IYk(editorView, P_1);
		}
	}

	[CompilerGenerated]
	private void sYU(object P_0, DragEventArgs P_1)
	{
		ATk aTk = new ATk(kYt, P_1.GetPosition(kYt), _0020: true);
		if (aTk.View is EditorView editorView)
		{
			hYS(editorView, P_1);
		}
	}

	internal static bool rAV()
	{
		return LA2 == null;
	}

	internal static zTL gAI()
	{
		return LA2;
	}
}
