using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

public abstract class PrinterViewMarginBase : Control, IPrinterViewMargin, ITextViewMargin, IOrderable, IKeyedObject
{
	private IPrinterView aeq;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string Ee2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IEnumerable<Ordering> me7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PrinterViewMarginPlacement kei;

	private static PrinterViewMarginBase P0x;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return Ee2;
		}
		[CompilerGenerated]
		private set
		{
			Ee2 = value;
		}
	}

	public IEnumerable<Ordering> Orderings
	{
		[CompilerGenerated]
		get
		{
			return me7;
		}
		[CompilerGenerated]
		private set
		{
			me7 = value;
		}
	}

	public PrinterViewMarginPlacement Placement
	{
		[CompilerGenerated]
		get
		{
			return kei;
		}
		[CompilerGenerated]
		private set
		{
			kei = value;
		}
	}

	public IPrinterView View => aeq;

	public FrameworkElement VisualElement => this;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	protected PrinterViewMarginBase(IPrinterView view, string key, PrinterViewMarginPlacement placement, IEnumerable<Ordering> orderings)
	{
		grA.DaB7cz();
		base._002Ector();
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		aeq = view;
		Key = key;
		Placement = placement;
		Orderings = orderings;
		UpdateVisibility();
	}

	public virtual void Draw(TextViewDrawContext context)
	{
	}

	public virtual void UpdateVisibility()
	{
	}

	internal static bool D0a()
	{
		return P0x == null;
	}

	internal static PrinterViewMarginBase b0L()
	{
		return P0x;
	}
}
