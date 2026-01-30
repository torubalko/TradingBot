using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

public class DelegateTransitionSelector : TransitionSelector
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private SelectTransitionCallback lQU;

	internal static DelegateTransitionSelector d7W;

	public SelectTransitionCallback Callback
	{
		[CompilerGenerated]
		get
		{
			return lQU;
		}
		[CompilerGenerated]
		set
		{
			lQU = value;
		}
	}

	public DelegateTransitionSelector()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(null);
	}

	public DelegateTransitionSelector(SelectTransitionCallback callback)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		Callback = callback;
	}

	public override Transition SelectTransition(TransitionPresenter presenter, object fromContent, object toContent)
	{
		if (Callback != null)
		{
			return Callback(presenter, fromContent, toContent);
		}
		return null;
	}

	internal static bool j7z()
	{
		return d7W == null;
	}

	internal static DelegateTransitionSelector yHK()
	{
		return d7W;
	}
}
