using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments.Implementation;

public abstract class AdornmentManagerBase<TView> : IAdornmentManager where TView : ITextView
{
	[Flags]
	private enum I7O
	{

	}

	private class S7a
	{
		private I7O Xyv;

		internal static object kfa;

		internal bool ryl(I7O P_0)
		{
			return (Xyv & P_0) == P_0;
		}

		internal void iyA(I7O P_0, bool P_1)
		{
			if (P_1)
			{
				Xyv |= P_0;
			}
			else
			{
				Xyv &= ~P_0;
			}
		}

		public S7a()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool rfL()
		{
			return kfa == null;
		}

		internal static object tfg()
		{
			return kfa;
		}
	}

	private IAdornmentLayer lnJ;

	private S7a knt;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TView XnZ;

	internal static object ROe;

	ITextView IAdornmentManager.View => View;

	public IAdornmentLayer AdornmentLayer => lnJ;

	public bool IsActive
	{
		get
		{
			return knt.ryl((I7O)2);
		}
		set
		{
			if (knt.ryl((I7O)2) != value)
			{
				knt.iyA((I7O)2, value);
				OnIsActiveChanged();
			}
		}
	}

	public TView View
	{
		[CompilerGenerated]
		get
		{
			return XnZ;
		}
		[CompilerGenerated]
		private set
		{
			XnZ = value;
		}
	}

	protected AdornmentManagerBase(TView view, AdornmentLayerDefinition layerDefinition)
	{
		grA.DaB7cz();
		this._002Ector(view, layerDefinition, isForLanguage: true);
	}

	protected AdornmentManagerBase(TView view, AdornmentLayerDefinition layerDefinition, bool isForLanguage)
	{
		grA.DaB7cz();
		knt = new S7a();
		base._002Ector();
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (layerDefinition == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8018));
		}
		View = view;
		knt.iyA((I7O)4, isForLanguage);
		knt.iyA((I7O)1, _0020: true);
		lnJ = view.GetAdornmentLayer(layerDefinition);
		RoutedEventHandler value = AnM;
		view.Closed += value;
		if (knt.ryl((I7O)4))
		{
			view.SyntaxEditor.DocumentChanged += wni;
			view.SyntaxEditor.DocumentLanguageChanged += nnp;
		}
	}

	private void wni(object P_0, EditorDocumentChangedEventArgs P_1)
	{
		Close();
	}

	private void nnp(object P_0, EditorDocumentLanguageChangedEventArgs P_1)
	{
		Close();
	}

	private void AnM(object P_0, EventArgs P_1)
	{
		Close();
	}

	private void bnO(PropertyDictionary P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		foreach (object key in P_0.Keys)
		{
			if (P_0.TryGetValue<object>(key, out var value) && value == this)
			{
				P_0.Remove(key);
			}
		}
	}

	public void Close()
	{
		if (knt.ryl((I7O)1))
		{
			knt.iyA((I7O)1, _0020: false);
			TView view = View;
			view.Closed -= AnM;
			if (knt.ryl((I7O)4))
			{
				View.SyntaxEditor.DocumentChanged -= wni;
				View.SyntaxEditor.DocumentLanguageChanged -= nnp;
			}
			IsActive = false;
			bnO(View.Properties);
			OnClosed();
		}
	}

	protected virtual void OnClosed()
	{
	}

	protected virtual void OnIsActiveChanged()
	{
	}

	internal static bool OOz()
	{
		return ROe == null;
	}

	internal static object n1m()
	{
		return ROe;
	}
}
