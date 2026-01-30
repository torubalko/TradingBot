using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Lexing;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

public class DelimiterIndentProvider : IIndentProvider, IEditorDocumentTextChangeEventSink
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool zYb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool UYT;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int? pYL;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int xYn;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int? DY8;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int? aYI;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int? tY5;

	internal static DelimiterIndentProvider kAv;

	public bool CanAutoIndentCurlyBraces
	{
		[CompilerGenerated]
		get
		{
			return zYb;
		}
		[CompilerGenerated]
		set
		{
			zYb = value;
		}
	}

	public bool CanAutoIndentSquareBraces
	{
		[CompilerGenerated]
		get
		{
			return UYT;
		}
		[CompilerGenerated]
		set
		{
			UYT = value;
		}
	}

	public int? CloseCurlyBraceTokenId
	{
		[CompilerGenerated]
		get
		{
			return pYL;
		}
		[CompilerGenerated]
		set
		{
			pYL = value;
		}
	}

	public int CloseDelimiterIndentLevel
	{
		[CompilerGenerated]
		get
		{
			return xYn;
		}
		[CompilerGenerated]
		set
		{
			xYn = value;
		}
	}

	public int? CloseSquareBraceTokenId
	{
		[CompilerGenerated]
		get
		{
			return DY8;
		}
		[CompilerGenerated]
		set
		{
			DY8 = value;
		}
	}

	public virtual IndentMode Mode => IndentMode.Block;

	public int? OpenCurlyBraceTokenId
	{
		[CompilerGenerated]
		get
		{
			return aYI;
		}
		[CompilerGenerated]
		set
		{
			aYI = value;
		}
	}

	public int? OpenSquareBraceTokenId
	{
		[CompilerGenerated]
		get
		{
			return tY5;
		}
		[CompilerGenerated]
		set
		{
			tY5 = value;
		}
	}

	public DelimiterIndentProvider()
	{
		grA.DaB7cz();
		base._002Ector();
		CanAutoIndentCurlyBraces = true;
		CanAutoIndentSquareBraces = false;
	}

	void IEditorDocumentTextChangeEventSink.NotifyDocumentTextChanged(SyntaxEditor editor, EditorSnapshotChangedEventArgs e)
	{
		OnDocumentTextChanged(editor, e);
	}

	void IEditorDocumentTextChangeEventSink.NotifyDocumentTextChanging(SyntaxEditor editor, EditorSnapshotChangingEventArgs e)
	{
		OnDocumentTextChanging(editor, e);
	}

	private bool fYw(ITextChange P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(193272));
		}
		if (P_0.Type == TextChangeTypes.Enter && P_0.Operations != null && P_0.Operations.Count == 1)
		{
			int tabSize = P_0.Snapshot.Document.TabSize;
			string indentText = StringHelper.GetIndentText(P_0.Snapshot.Document.AutoConvertTabsToSpaces, tabSize, Math.Max(0, CloseDelimiterIndentLevel) * tabSize);
			string indentText2 = StringHelper.GetIndentText(P_0.Snapshot.Document.AutoConvertTabsToSpaces, tabSize, tabSize);
			ITextChangeOperation textChangeOperation = P_0.Operations[0];
			ITextChange textChange = P_0.Snapshot.CreateTextChange(TextChangeTypes.AutoIndent);
			textChange.InsertText(textChangeOperation.StartOffset, textChangeOperation.InsertedText + indentText);
			textChange.InsertText(textChangeOperation.StartOffset, textChangeOperation.InsertedText + indentText2);
			textChange.Apply();
			return true;
		}
		return false;
	}

	private bool KY6(ITextChange P_0)
	{
		if (P_0 != null && P_0.Type == TextChangeTypes.Enter && P_0.Operations != null && P_0.Operations.Count == 1 && P_0.Snapshot != null)
		{
			ITextChangeOperation textChangeOperation = P_0.Operations[0];
			if (textChangeOperation != null && textChangeOperation.StartOffset > 0 && textChangeOperation.StartOffset < P_0.Snapshot.Length && !string.IsNullOrEmpty(textChangeOperation.InsertedText) && textChangeOperation.InsertedText[0] == '\n' && textChangeOperation.InsertedText.Trim().Length == 0)
			{
				if (CanAutoIndentCurlyBraces && xYH(P_0, textChangeOperation, '{', '}'))
				{
					return true;
				}
				if (CanAutoIndentSquareBraces && xYH(P_0, textChangeOperation, '[', ']'))
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool xYH(ITextChange P_0, ITextChangeOperation P_1, char P_2, char P_3)
	{
		if (P_0.Snapshot[P_1.StartOffset - 1] == P_2 && P_0.Snapshot[P_1.StartOffset] == P_3)
		{
			ITextSnapshotReader reader = P_0.Snapshot.GetReader(P_1.StartOffset);
			if (reader != null)
			{
				reader.Options.InitialTokenLoadBufferLength = 10;
				if (reader.IsAtTokenStart)
				{
					IToken token = reader.PeekToken();
					if (token != null && token.Length == 1 && IsValidEndDelimiter(token, P_3))
					{
						token = reader.PeekTokenReverse();
						if (token != null && token.Length == 1 && IsValidStartDelimiter(token, P_2))
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public virtual int GetIndentAmount(TextSnapshotOffset snapshotOffset, int defaultAmount)
	{
		return defaultAmount;
	}

	protected virtual bool IsValidEndDelimiter(IToken token, char endDelimiter)
	{
		return endDelimiter switch
		{
			'}' => !CloseCurlyBraceTokenId.HasValue || (token != null && token.Id == CloseCurlyBraceTokenId), 
			']' => !CloseSquareBraceTokenId.HasValue || (token != null && token.Id == CloseSquareBraceTokenId), 
			_ => false, 
		};
	}

	protected virtual bool IsValidStartDelimiter(IToken token, char startDelimiter)
	{
		return startDelimiter switch
		{
			'{' => !OpenCurlyBraceTokenId.HasValue || (token != null && token.Id == OpenCurlyBraceTokenId), 
			'[' => !OpenSquareBraceTokenId.HasValue || (token != null && token.Id == OpenSquareBraceTokenId), 
			_ => false, 
		};
	}

	protected virtual void OnDocumentTextChanged(SyntaxEditor editor, EditorSnapshotChangedEventArgs e)
	{
	}

	protected virtual void OnDocumentTextChanging(SyntaxEditor editor, EditorSnapshotChangingEventArgs e)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (e != null && e.TextChange != null && e.TextChange.Source == editor.ActiveView && KY6(e.TextChange))
					{
						e.Cancel = fYw(e.TextChange);
					}
					return;
				case 1:
					if (editor != null)
					{
						num2 = 0;
						if (aAf())
						{
							break;
						}
						goto end_IL_0012;
					}
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
		}
	}

	internal static bool aAf()
	{
		return kAv == null;
	}

	internal static DelimiterIndentProvider KAi()
	{
		return kAv;
	}
}
