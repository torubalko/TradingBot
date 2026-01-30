using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Markup;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Parsing;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Indicators;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

namespace ActiproSoftware.Text.Implementation;

[ContentProperty("Text")]
public class EditorDocument : CodeDocument, IEditorDocument, ICodeDocument, IParseTarget, ITextDocument
{
	private xL DIV;

	private int dIr;

	private CM FIs;

	private OutliningMode GIk;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private WhitespaceTrimModes BIS;

	internal static EditorDocument FGm;

	public IIndicatorManager IndicatorManager => DIV;

	public int LineNumberOrigin
	{
		get
		{
			return dIr;
		}
		set
		{
			if (dIr != value)
			{
				dIr = value;
				NotifyPropertyChanged(Q7Z.tqM(198312));
			}
		}
	}

	public IOutliningManager OutliningManager => FIs;

	public OutliningMode OutliningMode
	{
		get
		{
			return GIk;
		}
		set
		{
			if (GIk != value)
			{
				GIk = value;
				FIs.vvD(null);
				NotifyPropertyChanged(Q7Z.tqM(198348));
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public string Text
	{
		get
		{
			return base.CurrentSnapshot.GetText(LineTerminator.CarriageReturnNewline);
		}
		set
		{
			SetText(value);
		}
	}

	public WhitespaceTrimModes WhitespaceTrimModes
	{
		[CompilerGenerated]
		get
		{
			return BIS;
		}
		[CompilerGenerated]
		set
		{
			BIS = value;
		}
	}

	public EditorDocument()
	{
		grA.DaB7cz();
		dIr = 1;
		GIk = OutliningMode.Default;
		base._002Ector();
		DIV = new xL(this);
		FIs = new CM(this);
	}

	protected override string GetTextReplacementInsertText(ITextChangeOperation operation)
	{
		if (operation == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(198290));
		}
		string text = null;
		if ((WhitespaceTrimModes & WhitespaceTrimModes.TrailingOnTextReplacement) == WhitespaceTrimModes.TrailingOnTextReplacement)
		{
			text = operation.InsertedText;
			StringHelper.TrimTrailingWhitespace(ref text);
		}
		return text;
	}

	internal static bool GGp()
	{
		return FGm == null;
	}

	internal static EditorDocument mG4()
	{
		return FGm;
	}
}
