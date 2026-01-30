using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;

namespace ActiproSoftware.Internal;

internal abstract class XAK : IAdornment
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<IAdornment> tn5;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextSnapshotRange? nn0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object fnB;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextRangeTrackingModes? MnV;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextViewLine pnr;

	internal static XAK WOX;

	public virtual DrawAdornmentCallback DrawCallback => null;

	public abstract Point Location { get; set; }

	public Action<IAdornment> RemovedCallback
	{
		[CompilerGenerated]
		get
		{
			return tn5;
		}
		[CompilerGenerated]
		private set
		{
			tn5 = action;
		}
	}

	public abstract Size Size { get; }

	public TextSnapshotRange? SnapshotRange
	{
		[CompilerGenerated]
		get
		{
			return nn0;
		}
		[CompilerGenerated]
		private set
		{
			nn0 = textSnapshotRange;
		}
	}

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return fnB;
		}
		[CompilerGenerated]
		private set
		{
			fnB = obj;
		}
	}

	public TextRangeTrackingModes? TrackingModes
	{
		[CompilerGenerated]
		get
		{
			return MnV;
		}
		[CompilerGenerated]
		private set
		{
			MnV = mnV;
		}
	}

	public ITextViewLine ViewLine
	{
		[CompilerGenerated]
		get
		{
			return pnr;
		}
		[CompilerGenerated]
		private set
		{
			pnr = textViewLine;
		}
	}

	public virtual UIElement VisualElement => null;

	protected XAK(object P_0, ITextViewLine P_1, TextSnapshotRange? P_2, TextRangeTrackingModes? P_3, Action<IAdornment> P_4)
	{
		grA.DaB7cz();
		base._002Ector();
		Tag = P_0;
		ViewLine = P_1;
		SnapshotRange = P_2;
		TrackingModes = P_3;
		RemovedCallback = P_4;
	}

	internal void znb(ITextSnapshot P_0)
	{
		if (SnapshotRange.HasValue)
		{
			SnapshotRange = SnapshotRange.Value.TranslateTo(P_0, TrackingModes ?? TextRangeTrackingModes.ExpandBothEdges);
		}
	}

	public abstract void Translate(double P_0, double P_1);

	internal static bool WOE()
	{
		return WOX == null;
	}

	internal static XAK rOw()
	{
		return WOX;
	}
}
