using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Lexing;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Text.Analysis.Implementation;

public class DelimiterAutoCompleter : IDelimiterAutoCompleter, IEditorDocumentTextChangeEventSink, IEditorViewSelectionChangeEventSink, IEditorViewTextInputEventSink
{
	private class v7g
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private char Rqm;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ITextVersionRange cqC;

		private static v7g lil;

		[SpecialName]
		[CompilerGenerated]
		public char dqg()
		{
			return Rqm;
		}

		[SpecialName]
		[CompilerGenerated]
		public void NqQ(char P_0)
		{
			Rqm = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public ITextVersionRange Mql()
		{
			return cqC;
		}

		[SpecialName]
		[CompilerGenerated]
		public void fqA(ITextVersionRange P_0)
		{
			cqC = P_0;
		}

		public v7g()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool EiW()
		{
			return lil == null;
		}

		internal static v7g DiS()
		{
			return lil;
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool k5B;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool m5V;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool I5r;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool y5s;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool W5k;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool w5S;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int? e59;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int? g5y;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int? V5q;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int? H52;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int? N57;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int? q5i;

	private static DelimiterAutoCompleter jGd;

	public bool CanCompleteAngleBraces
	{
		[CompilerGenerated]
		get
		{
			return k5B;
		}
		[CompilerGenerated]
		set
		{
			k5B = value;
		}
	}

	public bool CanCompleteCurlyBraces
	{
		[CompilerGenerated]
		get
		{
			return m5V;
		}
		[CompilerGenerated]
		set
		{
			m5V = value;
		}
	}

	public bool CanCompleteDoubleQuotes
	{
		[CompilerGenerated]
		get
		{
			return I5r;
		}
		[CompilerGenerated]
		set
		{
			I5r = value;
		}
	}

	public bool CanCompleteParentheses
	{
		[CompilerGenerated]
		get
		{
			return y5s;
		}
		[CompilerGenerated]
		set
		{
			y5s = value;
		}
	}

	public bool CanCompleteSingleQuotes
	{
		[CompilerGenerated]
		get
		{
			return W5k;
		}
		[CompilerGenerated]
		set
		{
			W5k = value;
		}
	}

	public bool CanCompleteSquareBraces
	{
		[CompilerGenerated]
		get
		{
			return w5S;
		}
		[CompilerGenerated]
		set
		{
			w5S = value;
		}
	}

	public int? OpenAngleBraceTokenId
	{
		[CompilerGenerated]
		get
		{
			return e59;
		}
		[CompilerGenerated]
		set
		{
			e59 = value;
		}
	}

	public int? OpenCurlyBraceTokenId
	{
		[CompilerGenerated]
		get
		{
			return g5y;
		}
		[CompilerGenerated]
		set
		{
			g5y = value;
		}
	}

	public int? OpenDoubleQuoteTokenId
	{
		[CompilerGenerated]
		get
		{
			return V5q;
		}
		[CompilerGenerated]
		set
		{
			V5q = value;
		}
	}

	public int? OpenParenthesisTokenId
	{
		[CompilerGenerated]
		get
		{
			return H52;
		}
		[CompilerGenerated]
		set
		{
			H52 = value;
		}
	}

	public int? OpenSingleQuoteTokenId
	{
		[CompilerGenerated]
		get
		{
			return N57;
		}
		[CompilerGenerated]
		set
		{
			N57 = value;
		}
	}

	public int? OpenSquareBraceTokenId
	{
		[CompilerGenerated]
		get
		{
			return q5i;
		}
		[CompilerGenerated]
		set
		{
			q5i = value;
		}
	}

	public DelimiterAutoCompleter()
	{
		grA.DaB7cz();
		base._002Ector();
		CanCompleteCurlyBraces = true;
		CanCompleteDoubleQuotes = true;
		CanCompleteParentheses = true;
		CanCompleteSquareBraces = true;
	}

	void IEditorDocumentTextChangeEventSink.NotifyDocumentTextChanged(SyntaxEditor editor, EditorSnapshotChangedEventArgs e)
	{
		if (editor == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(13940));
		}
		if (editor.IsDelimiterAutoCompleteEnabled)
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
		if (editor.IsDelimiterAutoCompleteEnabled)
		{
			OnDocumentTextChanging(editor, e);
		}
	}

	void IEditorViewTextInputEventSink.NotifyTextInput(IEditorView view, TextCompositionEventArgs e)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.SyntaxEditor == null || view.SyntaxEditor.IsDelimiterAutoCompleteEnabled)
		{
			OnViewTextInput(view, e);
		}
	}

	void IEditorViewSelectionChangeEventSink.NotifySelectionChanged(IEditorView view, EditorViewSelectionEventArgs e)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.SyntaxEditor == null || view.SyntaxEditor.IsDelimiterAutoCompleteEnabled)
		{
			OnViewSelectionChanged(view, e);
		}
	}

	private static void N56(ICodeDocument P_0, v7g P_1)
	{
		if (P_0 == null || P_1 == null)
		{
			return;
		}
		TextSnapshotRange textSnapshotRange = P_1.Mql().Translate(P_0.CurrentSnapshot);
		if (textSnapshotRange.Length >= 2)
		{
			K5H(P_0, textSnapshotRange);
			Stack<v7g> stack = V5T(P_0);
			if (stack == null)
			{
				stack = new Stack<v7g>();
				P_0.Properties[Q7Z.tqM(202016)] = stack;
			}
			stack.Push(P_1);
		}
	}

	private static void K5H(ICodeDocument P_0, TextSnapshotRange P_1)
	{
		if (P_0 == null)
		{
			return;
		}
		Stack<v7g> stack = V5T(P_0);
		if (stack == null)
		{
			return;
		}
		if (!P_1.IsDeleted && P_1.Snapshot.Document == P_0)
		{
			while (stack.Count > 0)
			{
				TextSnapshotRange textSnapshotRange = stack.Peek().Mql().Translate(P_1.Snapshot);
				if (!textSnapshotRange.IsDeleted && textSnapshotRange.Length >= 2 && P_1.StartOffset > textSnapshotRange.StartOffset && P_1.EndOffset < textSnapshotRange.EndOffset)
				{
					return;
				}
				stack.Pop();
			}
		}
		P_0.Properties.Remove(Q7Z.tqM(202016));
	}

	private static int? S5b(ICodeDocument P_0)
	{
		int? value = null;
		P_0?.Properties.TryGetValue<int?>(Q7Z.tqM(202068), out value);
		return value;
	}

	private static Stack<v7g> V5T(ICodeDocument P_0)
	{
		Stack<v7g> value = null;
		P_0?.Properties.TryGetValue<Stack<v7g>>(Q7Z.tqM(202016), out value);
		return value;
	}

	private static char F5L(char P_0, bool P_1)
	{
		return P_0 switch
		{
			'<' => '>', 
			'>' => (!P_1) ? '<' : '\0', 
			'{' => '}', 
			'}' => (!P_1) ? '{' : '\0', 
			'"' => '"', 
			'(' => ')', 
			')' => (!P_1) ? '(' : '\0', 
			'\'' => '\'', 
			'[' => ']', 
			']' => (!P_1) ? '[' : '\0', 
			_ => '\0', 
		};
	}

	private static TextSnapshotRange o5n(IEditorView P_0, ITextChange P_1, bool P_2)
	{
		if ((P_1.Type == TextChangeTypes.Backspace || P_1.Type == TextChangeTypes.Delete) && P_0.Selection.IsZeroLength && P_1.Operations.Count == 1 && P_1.Operations[0].StartOffset == P_0.Selection.EndOffset - (P_2 ? 1 : 0) && P_1.Operations[0].DeletionLength == 1 && P_1.Operations[0].InsertionLength == 0)
		{
			Stack<v7g> stack = V5T(P_1.Snapshot.Document as ICodeDocument);
			if (stack != null && stack.Count > 0)
			{
				v7g v7g = stack.Peek();
				TextSnapshotRange textSnapshotRange = v7g.Mql().Translate(P_1.Snapshot);
				if (!textSnapshotRange.IsDeleted && textSnapshotRange.Length == 2 && textSnapshotRange.StartOffset == P_1.Operations[0].StartOffset && textSnapshotRange.Snapshot[textSnapshotRange.StartOffset] == v7g.dqg() && textSnapshotRange.Snapshot[textSnapshotRange.EndOffset - 1] == F5L(v7g.dqg(), _0020: true))
				{
					return new TextSnapshotRange(textSnapshotRange.Snapshot, textSnapshotRange.EndOffset - 1, textSnapshotRange.EndOffset);
				}
			}
		}
		return TextSnapshotRange.Deleted;
	}

	private bool A58(TextSnapshotOffset P_0, char P_1)
	{
		char c = F5L(P_1, _0020: true);
		if (IsValidForEndDelimiterAutoComplete(P_0, c))
		{
			P_0.Snapshot.Document.InsertText(TextChangeTypes.AutoComplete, P_0, char.ToString(c), new TextChangeOptions
			{
				RetainSelection = true
			});
			v7g v7g = new v7g();
			v7g.NqQ(P_1);
			v7g.fqA(new TextSnapshotRange(P_0.Snapshot.Document.CurrentSnapshot, P_0.Offset - 1, P_0.Offset + 1).ToVersionRange(TextRangeTrackingModes.DeleteWhenZeroLength));
			v7g v7g2 = v7g;
			N56(P_0.Snapshot.Document as ICodeDocument, v7g2);
			return true;
		}
		return false;
	}

	private static bool L5I(IEditorView P_0, char P_1)
	{
		if (P_0.Selection.IsZeroLength)
		{
			TextSnapshotOffset endSnapshotOffset = P_0.Selection.EndSnapshotOffset;
			if (endSnapshotOffset.Snapshot[endSnapshotOffset.Offset] == P_1)
			{
				Stack<v7g> stack = V5T(endSnapshotOffset.Snapshot.Document as ICodeDocument);
				if (stack != null && stack.Count > 0)
				{
					v7g v7g = stack.Peek();
					if (F5L(v7g.dqg(), _0020: true) == P_1 && v7g.Mql().Translate(endSnapshotOffset.Snapshot).EndOffset == endSnapshotOffset.Offset + 1)
					{
						P_0.Selection.StartOffset = endSnapshotOffset.Offset + 1;
						return true;
					}
				}
			}
		}
		return false;
	}

	private static bool H55(IEditorView P_0, ITextChange P_1, ITextSnapshot P_2)
	{
		TextSnapshotRange textSnapshotRange = o5n(P_0, P_1, _0020: false);
		if (!textSnapshotRange.IsDeleted)
		{
			P_2.Document.DeleteText(TextChangeTypes.AutoComplete, textSnapshotRange.TranslateTo(P_2, TextRangeTrackingModes.Default), new TextChangeOptions
			{
				RetainSelection = true
			});
			return true;
		}
		return false;
	}

	private static void f50(ICodeDocument P_0, int? P_1)
	{
		if (P_0 != null)
		{
			if (P_1.HasValue)
			{
				P_0.Properties[Q7Z.tqM(202068)] = P_1;
			}
			else if (P_0.Properties.ContainsKey(Q7Z.tqM(202068)))
			{
				P_0.Properties.Remove(Q7Z.tqM(202068));
			}
		}
	}

	protected virtual bool IsValidForEndDelimiterAutoComplete(TextSnapshotOffset snapshotOffset, char endDelimiter)
	{
		char c = F5L(endDelimiter, _0020: false);
		if (c != 0)
		{
			ITextSnapshotReader reader = snapshotOffset.Snapshot.GetReader(snapshotOffset);
			if (reader != null)
			{
				reader.Options.InitialTokenLoadBufferLength = 10;
				int num = snapshotOffset.Line.EndOffset;
				if (snapshotOffset.Snapshot.Document is ICodeDocument codeDocument)
				{
					Stack<v7g> stack = V5T(codeDocument);
					if (stack != null && stack.Count > 0)
					{
						v7g v7g = stack.Peek();
						if (v7g != null)
						{
							num = Math.Min(num, Math.Max(0, v7g.Mql().Translate(snapshotOffset.Snapshot).EndOffset - 1));
						}
					}
				}
				if (reader.Offset < num)
				{
					reader.BufferReader.Push();
					while (reader.Offset < num)
					{
						char c2 = reader.ReadCharacter();
						if (!char.IsWhiteSpace(c2))
						{
							return false;
						}
					}
					reader.BufferReader.Pop();
				}
				return IsValidStartDelimiter(reader, c);
			}
		}
		return false;
	}

	protected virtual bool IsValidStartDelimiter(ITextSnapshotReader reader, char startDelimiter)
	{
		if (reader != null && reader.IsAtTokenStart)
		{
			IToken token = reader.PeekTokenReverse();
			if (token != null && token.Length == 1)
			{
				return IsValidStartDelimiter(token, startDelimiter);
			}
		}
		return false;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected virtual bool IsValidStartDelimiter(IToken token, char startDelimiter)
	{
		return startDelimiter switch
		{
			'<' => !OpenAngleBraceTokenId.HasValue || (token != null && token.Id == OpenAngleBraceTokenId), 
			'{' => !OpenCurlyBraceTokenId.HasValue || (token != null && token.Id == OpenCurlyBraceTokenId), 
			'"' => !OpenDoubleQuoteTokenId.HasValue || (token != null && token.Id == OpenDoubleQuoteTokenId), 
			'(' => !OpenParenthesisTokenId.HasValue || (token != null && token.Id == OpenParenthesisTokenId), 
			'\'' => !OpenSingleQuoteTokenId.HasValue || (token != null && token.Id == OpenSingleQuoteTokenId), 
			'[' => !OpenSquareBraceTokenId.HasValue || (token != null && token.Id == OpenSquareBraceTokenId), 
			_ => false, 
		};
	}

	protected virtual void OnDocumentTextChanging(SyntaxEditor editor, EditorSnapshotChangingEventArgs e)
	{
		if (editor == null || e == null || e.TextChange == null)
		{
			return;
		}
		int num = 0;
		if (!PGT())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (e.TextChange.Source == editor.ActiveView && !o5n(editor.ActiveView, e.TextChange, _0020: true).IsDeleted)
		{
			f50(editor.Document, e.TextChange.Operations[0].StartOffset);
		}
	}

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
		if (e.TextChange == null || e.TextChange.Operations == null || e.TextChange.Operations.Count <= 0 || e.TextChange.Source != editor.ActiveView)
		{
			return;
		}
		string typedText = e.TypedText;
		string text = typedText;
		if (!(text == Q7Z.tqM(202138)))
		{
			if (!(text == Q7Z.tqM(202144)))
			{
				if (!(text == Q7Z.tqM(191774)))
				{
					if (!(text == Q7Z.tqM(14044)))
					{
						if (!(text == Q7Z.tqM(191768)))
						{
							if (text == Q7Z.tqM(11634))
							{
								if (CanCompleteSquareBraces)
								{
									A58(new TextSnapshotOffset(e.NewSnapshot, e.TextChange.Operations[0].InsertionEndOffset).TranslateTo(e.NewSnapshot.Document.CurrentSnapshot, TextOffsetTrackingMode.Positive), e.TypedText[0]);
								}
							}
							else if ((e.TextChange.Type == TextChangeTypes.Backspace || e.TextChange.Type == TextChangeTypes.Delete) && H55(editor.ActiveView, e.TextChange, e.NewSnapshot))
							{
							}
						}
						else if (CanCompleteSingleQuotes)
						{
							A58(new TextSnapshotOffset(e.NewSnapshot, e.TextChange.Operations[0].InsertionEndOffset).TranslateTo(e.NewSnapshot.Document.CurrentSnapshot, TextOffsetTrackingMode.Positive), e.TypedText[0]);
						}
					}
					else if (CanCompleteParentheses)
					{
						A58(new TextSnapshotOffset(e.NewSnapshot, e.TextChange.Operations[0].InsertionEndOffset).TranslateTo(e.NewSnapshot.Document.CurrentSnapshot, TextOffsetTrackingMode.Positive), e.TypedText[0]);
					}
				}
				else if (CanCompleteDoubleQuotes)
				{
					A58(new TextSnapshotOffset(e.NewSnapshot, e.TextChange.Operations[0].InsertionEndOffset).TranslateTo(e.NewSnapshot.Document.CurrentSnapshot, TextOffsetTrackingMode.Positive), e.TypedText[0]);
				}
			}
			else if (CanCompleteCurlyBraces)
			{
				A58(new TextSnapshotOffset(e.NewSnapshot, e.TextChange.Operations[0].InsertionEndOffset).TranslateTo(e.NewSnapshot.Document.CurrentSnapshot, TextOffsetTrackingMode.Positive), e.TypedText[0]);
			}
		}
		else if (CanCompleteAngleBraces)
		{
			A58(new TextSnapshotOffset(e.NewSnapshot, e.TextChange.Operations[0].InsertionEndOffset).TranslateTo(e.NewSnapshot.Document.CurrentSnapshot, TextOffsetTrackingMode.Positive), e.TypedText[0]);
		}
	}

	protected virtual void OnViewSelectionChanged(IEditorView view, EditorViewSelectionEventArgs e)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view.Selection.IsZeroLength)
		{
			int num = 0;
			if (fGt() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (S5b(view.SyntaxEditor.Document) == view.Selection.EndOffset)
			{
				goto IL_00b0;
			}
		}
		K5H(view.SyntaxEditor.Document, view.Selection.SnapshotRange);
		goto IL_00b0;
		IL_00b0:
		f50(view.SyntaxEditor.Document, null);
	}

	protected virtual void OnViewTextInput(IEditorView view, TextCompositionEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		string text = e.Text;
		string text2 = text;
		if (!(text2 == Q7Z.tqM(8554)))
		{
			if (!(text2 == Q7Z.tqM(201864)))
			{
				if (!(text2 == Q7Z.tqM(191774)))
				{
					if (!(text2 == Q7Z.tqM(14000)))
					{
						if (!(text2 == Q7Z.tqM(191768)))
						{
							if (text2 == Q7Z.tqM(11640) && CanCompleteSquareBraces)
							{
								e.Handled |= L5I(view, e.Text[0]);
							}
						}
						else if (CanCompleteSingleQuotes)
						{
							e.Handled |= L5I(view, e.Text[0]);
						}
					}
					else if (CanCompleteParentheses)
					{
						e.Handled |= L5I(view, e.Text[0]);
					}
				}
				else if (CanCompleteDoubleQuotes)
				{
					e.Handled |= L5I(view, e.Text[0]);
				}
			}
			else if (CanCompleteCurlyBraces)
			{
				e.Handled |= L5I(view, e.Text[0]);
			}
		}
		else if (CanCompleteAngleBraces)
		{
			e.Handled |= L5I(view, e.Text[0]);
		}
	}

	internal static bool PGT()
	{
		return jGd == null;
	}

	internal static DelimiterAutoCompleter fGt()
	{
		return jGd;
	}
}
