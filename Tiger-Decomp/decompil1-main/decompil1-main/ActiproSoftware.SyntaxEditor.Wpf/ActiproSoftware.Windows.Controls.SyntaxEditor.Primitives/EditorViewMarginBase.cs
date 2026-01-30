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

public abstract class EditorViewMarginBase : Control, IEditorViewMargin, ITextViewMargin, IOrderable, IKeyedObject
{
	private IEditorView qgB;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string pgV;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IEnumerable<Ordering> mgr;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EditorViewMarginPlacement Ngs;

	private static EditorViewMarginBase tBk;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return pgV;
		}
		[CompilerGenerated]
		private set
		{
			pgV = value;
		}
	}

	public IEnumerable<Ordering> Orderings
	{
		[CompilerGenerated]
		get
		{
			return mgr;
		}
		[CompilerGenerated]
		private set
		{
			mgr = value;
		}
	}

	public EditorViewMarginPlacement Placement
	{
		[CompilerGenerated]
		get
		{
			return Ngs;
		}
		[CompilerGenerated]
		private set
		{
			Ngs = value;
		}
	}

	public IEditorView View => qgB;

	public FrameworkElement VisualElement => this;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	protected EditorViewMarginBase(IEditorView view, string key, EditorViewMarginPlacement placement, IEnumerable<Ordering> orderings)
	{
		grA.DaB7cz();
		base._002Ector();
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		qgB = view;
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

	[SpecialName]
	Visibility IEditorViewMargin.get_Visibility()
	{
		return base.Visibility;
	}

	internal static bool MBZ()
	{
		return tBk == null;
	}

	internal static EditorViewMarginBase WBF()
	{
		return tBk;
	}
}
