using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Markup;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

[ContentProperty("Transitions")]
[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi")]
public class MultiTransitionSelector : TransitionSelector
{
	private ObservableCollection<Transition> dQE;

	private static MultiTransitionSelector sHO;

	public ObservableCollection<Transition> Transitions => dQE;

	public override Transition SelectTransition(TransitionPresenter presenter, object fromContent, object toContent)
	{
		Transition transition = null;
		if (dQE.Count > 0)
		{
			int index = (int)Math.Round(new Random().NextDouble() * (double)(dQE.Count - 1));
			transition = dQE[index];
			if (transition != null && presenter != null && presenter.DefaultMode == TransitionMode.Out)
			{
				transition = transition.GetOppositeTransition();
			}
		}
		return transition;
	}

	public MultiTransitionSelector()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		dQE = new ObservableCollection<Transition>();
		base._002Ector();
	}

	internal static bool yHq()
	{
		return sHO == null;
	}

	internal static MultiTransitionSelector dHG()
	{
		return sHO;
	}
}
