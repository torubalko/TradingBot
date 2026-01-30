using System;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;

namespace ActiproSoftware.Internal;

internal class xAa : XAK
{
	private UIElement O8b;

	private static xAa s1R;

	public override Point Location
	{
		get
		{
			return new Point(Canvas.GetLeft(VisualElement), Canvas.GetTop(VisualElement));
		}
		set
		{
			if (VisualElement != null)
			{
				if (!double.IsNaN(point.X) && !double.IsInfinity(point.X))
				{
					Canvas.SetLeft(VisualElement, point.X);
				}
				if (!double.IsNaN(point.Y) && !double.IsInfinity(point.Y))
				{
					Canvas.SetTop(VisualElement, point.Y);
				}
			}
		}
	}

	public override Size Size => (VisualElement != null) ? VisualElement.DesiredSize : default(Size);

	public override UIElement VisualElement => O8b;

	public xAa(UIElement P_0, object P_1, ITextViewLine P_2, TextSnapshotRange? P_3, TextRangeTrackingModes? P_4, Action<IAdornment> P_5)
	{
		grA.DaB7cz();
		base._002Ector(P_1, P_2, P_3, P_4, P_5);
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197748));
		}
		O8b = P_0;
	}

	public override void Translate(double P_0, double P_1)
	{
		if (P_0 != 0.0)
		{
			double num = Canvas.GetLeft(VisualElement);
			if (double.IsNaN(num))
			{
				num = 0.0;
			}
			Canvas.SetLeft(VisualElement, num + P_0);
		}
		bool flag = P_1 != 0.0;
		int num2 = 0;
		if (!f1O())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		}
		if (flag)
		{
			double num4 = Canvas.GetTop(VisualElement);
			if (double.IsNaN(num4))
			{
				num4 = 0.0;
			}
			Canvas.SetTop(VisualElement, num4 + P_1);
		}
	}

	internal static bool f1O()
	{
		return s1R == null;
	}

	internal static xAa F11()
	{
		return s1R;
	}
}
