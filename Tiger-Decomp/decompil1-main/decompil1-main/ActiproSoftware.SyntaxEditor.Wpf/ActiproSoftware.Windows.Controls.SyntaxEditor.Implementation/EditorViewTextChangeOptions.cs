using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

public class EditorViewTextChangeOptions : TextChangeOptions, IEditorViewTextChangeOptions, ITextChangeOptions
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Func<ITextViewLine, Range, Range> Iop;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool VoM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool ToO;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool coU;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool qoJ;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool Lot;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Func<TextPosition, TextPositionRange> noZ;

	internal static EditorViewTextChangeOptions mlm;

	public Func<ITextViewLine, Range, Range> BlockEditRangeAdjustFunc
	{
		[CompilerGenerated]
		get
		{
			return Iop;
		}
		[CompilerGenerated]
		set
		{
			Iop = value;
		}
	}

	public bool CanApplyToBlockEdit
	{
		[CompilerGenerated]
		get
		{
			return VoM;
		}
		[CompilerGenerated]
		set
		{
			VoM = value;
		}
	}

	public bool CanApplyToMultipleSelections
	{
		[CompilerGenerated]
		get
		{
			return ToO;
		}
		[CompilerGenerated]
		set
		{
			ToO = value;
		}
	}

	public bool IsBlock
	{
		[CompilerGenerated]
		get
		{
			return coU;
		}
		[CompilerGenerated]
		set
		{
			coU = value;
		}
	}

	public bool SelectInsertedText
	{
		[CompilerGenerated]
		get
		{
			return qoJ;
		}
		[CompilerGenerated]
		set
		{
			qoJ = value;
		}
	}

	public bool VirtualCharacterFill
	{
		[CompilerGenerated]
		get
		{
			return Lot;
		}
		[CompilerGenerated]
		set
		{
			Lot = value;
		}
	}

	public Func<TextPosition, TextPositionRange> ZeroLengthEditRangeAdjustFunc
	{
		[CompilerGenerated]
		get
		{
			return noZ;
		}
		[CompilerGenerated]
		set
		{
			noZ = value;
		}
	}

	public EditorViewTextChangeOptions()
	{
		grA.DaB7cz();
		base._002Ector();
		VirtualCharacterFill = true;
	}

	public EditorViewTextChangeOptions(object source)
	{
		grA.DaB7cz();
		this._002Ector();
		base.Source = source;
	}

	internal static bool elp()
	{
		return mlm == null;
	}

	internal static EditorViewTextChangeOptions Ql4()
	{
		return mlm;
	}
}
