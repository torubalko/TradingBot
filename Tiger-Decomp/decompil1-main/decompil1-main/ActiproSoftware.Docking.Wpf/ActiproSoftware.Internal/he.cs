using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Docking.Primitives;
using ActiproSoftware.Windows.Extensions;

namespace ActiproSoftware.Internal;

internal abstract class he : N7
{
	private double H77;

	private double r7R;

	private Va i7S;

	private bool G7L;

	private bool Q73;

	private bO f76;

	private SplitContainerSplitter E79;

	private static he UYu;

	protected bool UseHostedPopups => G7L;

	protected he(Va P_0, bool P_1, bool P_2)
	{
		IVH.CecNqz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(23398));
		}
		i7S = P_0;
		Q73 = P_1;
		G7L = P_2;
	}

	private void r78(Point P_0, bool P_1)
	{
		double num = Math.Round(i7S.GetLocationExtent(P_0) - r7R);
		if (P_1 || num != H77)
		{
			G7E(num, P_1);
		}
		H77 = num;
	}

	private void c7D()
	{
		if (E79 != null)
		{
			if (E79.Orientation == Orientation.Horizontal)
			{
				E79.RenderTransform = new TranslateTransform
				{
					X = i7S.TranslationOffset
				};
			}
			else
			{
				E79.RenderTransform = new TranslateTransform
				{
					Y = i7S.TranslationOffset
				};
			}
		}
	}

	private void G7E(double P_0, bool P_1)
	{
		if (P_0 > 0.0)
		{
			P_0 = Math.Min(P_0, Jmk());
			int num = 0;
			if (eYV() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else if (P_0 < 0.0)
		{
			P_0 = 0.0 - Math.Min(Math.Abs(P_0), mms());
		}
		if (Q73 || P_1)
		{
			i7S.TranslationOffset = 0.0;
			rm4(P_0);
		}
		else
		{
			i7S.TranslationOffset = P_0;
			c7D();
		}
	}

	private void x7r()
	{
		Canvas canvas = new Canvas();
		f76 = new bO(Jm0(), canvas, bO.SO8(Jm0()), _0020: false, _0020: true, _0020: true, _0020: false);
		Rect bounds = i7S.GetBounds();
		int num = 0;
		if (!aYy())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		E79 = new SplitContainerSplitter();
		E79.IsHighlighted = true;
		E79.Orientation = i7S.Orientation;
		E79.Width = bounds.Width;
		E79.Height = bounds.Height;
		if (E79.Orientation != Orientation.Horizontal)
		{
			Canvas.SetTop(E79, bounds.Top);
		}
		else
		{
			Canvas.SetLeft(E79, bounds.Left);
		}
		canvas.Children.Add(E79);
		f76.MOM();
	}

	private void h7x()
	{
		if (f76 != null)
		{
			f76.Close();
			f76 = null;
		}
		if (E79 != null)
		{
			E79 = null;
		}
	}

	public void MmH(Point P_0)
	{
		r78(P_0, _0020: false);
	}

	protected abstract void rm4(double P_0);

	[SpecialName]
	protected abstract double mms();

	[SpecialName]
	protected abstract double Jmk();

	[SpecialName]
	protected Va n7l()
	{
		return i7S;
	}

	public void Dmz(Point P_0)
	{
		r7R = i7S.GetLocationExtent(P_0);
		i7S.IsHighlighted = !Q73 && G7L;
		if (!Q73 && !G7L)
		{
			x7r();
		}
	}

	public void GoW(Point P_0)
	{
		if (!Q73 && !G7L)
		{
			h7x();
		}
		i7S.IsHighlighted = false;
		r78(P_0, _0020: true);
		i7S.TranslationOffset = 0.0;
	}

	[SpecialName]
	public abstract FrameworkElement Jm0();

	internal static bool aYy()
	{
		return UYu == null;
	}

	internal static he eYV()
	{
		return UYu;
	}
}
