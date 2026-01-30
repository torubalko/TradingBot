using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class ju : Panel
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public Action HVR;

		private static _003C_003Ec__DisplayClass3_0 eHL;

		public _003C_003Ec__DisplayClass3_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void QV3(object sender, EventArgs e)
		{
			HVR();
		}

		internal static bool GHg()
		{
			return eHL == null;
		}

		internal static _003C_003Ec__DisplayClass3_0 THA()
		{
			return eHL;
		}
	}

	private double Oe8;

	internal static ju mBw;

	internal void geL(EditorView P_0)
	{
		Oe8 = 1.0;
		if (P_0 == null)
		{
			return;
		}
		bool flag = P_0.Margins.Any((IEditorViewMargin m) => m.Placement == EditorViewMarginPlacement.ScrollableRight && m.Visibility == Visibility.Visible);
		int num = 0;
		if (!FBu())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			Oe8 = 0.0;
		}
		if (P_0.BfU() && !P_0.lfz().IsVerticalScrollBarVisible)
		{
			Oe8 = 0.0 - P_0.QDP();
		}
	}

	public static void yen(UIElement P_0, bool P_1, Action P_2)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals2.HVR = P_2;
		P_0.Visibility = Visibility.Visible;
		TranslateTransform translateTransform = P_0.RenderTransform as TranslateTransform;
		if (translateTransform == null)
		{
			translateTransform = new TranslateTransform
			{
				Y = (P_1 ? (-50.0) : 0.0)
			};
			P_0.RenderTransform = translateTransform;
		}
		Storyboard storyboard = new Storyboard();
		int num = 1;
		if (jB8() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		do
		{
			DoubleAnimation obj;
			double value;
			switch (num)
			{
			case 1:
				obj = new DoubleAnimation
				{
					Duration = TimeSpan.FromMilliseconds(100.0),
					EasingFunction = new QuadraticEase
					{
						EasingMode = (P_1 ? EasingMode.EaseOut : EasingMode.EaseIn)
					}
				};
				value = (P_1 ? 0.0 : (-50.0));
				break;
			default:
			{
				DoubleAnimation doubleAnimation = new DoubleAnimation
				{
					Duration = TimeSpan.FromMilliseconds(100.0),
					EasingFunction = new QuadraticEase
					{
						EasingMode = (P_1 ? EasingMode.EaseOut : EasingMode.EaseIn)
					},
					From = ((!P_1) ? 1 : 0),
					To = (P_1 ? 1 : 0)
				};
				Storyboard.SetTarget(doubleAnimation, P_0);
				Storyboard.SetTargetProperty(doubleAnimation, new PropertyPath(Q7Z.tqM(9432)));
				storyboard.Children.Add(doubleAnimation);
				if (!P_1)
				{
					storyboard.Completed += delegate
					{
						CS_0024_003C_003E8__locals2.HVR();
					};
				}
				storyboard.Begin();
				return;
			}
			}
			obj.To = value;
			DoubleAnimation doubleAnimation2 = obj;
			Storyboard.SetTarget(doubleAnimation2, P_0);
			PropertyPath path = new PropertyPath(Q7Z.tqM(9328));
			Storyboard.SetTargetProperty(doubleAnimation2, path);
			storyboard.Children.Add(doubleAnimation2);
			num = 0;
		}
		while (jB8() == null);
		goto IL_0005;
	}

	protected override Size ArrangeOverride(Size P_0)
	{
		Rect rect = new Rect(default(Point), P_0);
		foreach (UIElement child in base.Children)
		{
			Size desiredSize = child.DesiredSize;
			child.Arrange(new Rect(rect.Right - desiredSize.Width + Oe8, -1.0, desiredSize.Width, desiredSize.Height));
		}
		return P_0;
	}

	protected override Size MeasureOverride(Size P_0)
	{
		foreach (UIElement child in base.Children)
		{
			child.Measure(P_0);
		}
		return default(Size);
	}

	public ju()
	{
		grA.DaB7cz();
		Oe8 = 1.0;
		base._002Ector();
	}

	internal static bool FBu()
	{
		return mBw == null;
	}

	internal static ju jB8()
	{
		return mBw;
	}
}
