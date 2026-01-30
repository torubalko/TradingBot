using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace ActiproSoftware.Internal;

internal static class zn
{
	private static zn QAz;

	public static void PxP(Control P_0, double P_1, bool P_2, bool P_3, bool P_4, double P_5, double P_6)
	{
		double num = (P_4 ? 1.0 : P_5);
		double num2 = (P_4 ? P_5 : 1.0);
		double num3 = (P_4 ? 1.0 : P_6);
		double num4 = (P_4 ? P_6 : 1.0);
		Yxf(P_0, P_1, P_2, P_3, num, num2, num3, num4);
	}

	public static void Yxf(Control P_0, double P_1, bool P_2, bool P_3, double P_4, double P_5, double P_6, double P_7)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(vVK.ssH(21080));
		}
		if (!P_2 && !P_3)
		{
			return;
		}
		Storyboard storyboard = new Storyboard();
		Storyboard.SetTarget(storyboard, P_0);
		if (P_2)
		{
			DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames = new DoubleAnimationUsingKeyFrames
			{
				KeyFrames = { (DoubleKeyFrame)new EasingDoubleKeyFrame
				{
					EasingFunction = new QuadraticEase(),
					KeyTime = TimeSpan.FromSeconds(P_1),
					Value = P_5
				} }
			};
			if (P_1 > 0.0)
			{
				doubleAnimationUsingKeyFrames.KeyFrames.Add(new EasingDoubleKeyFrame
				{
					KeyTime = TimeSpan.FromSeconds(0.0),
					Value = P_4
				});
			}
			string path = vVK.ssH(3302);
			Storyboard.SetTargetProperty(doubleAnimationUsingKeyFrames, new PropertyPath(path));
			storyboard.Children.Add(doubleAnimationUsingKeyFrames);
		}
		if (P_3)
		{
			DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames2 = new DoubleAnimationUsingKeyFrames
			{
				KeyFrames = { (DoubleKeyFrame)new EasingDoubleKeyFrame
				{
					EasingFunction = new BackEase
					{
						EasingMode = EasingMode.EaseOut
					},
					KeyTime = TimeSpan.FromSeconds(P_1),
					Value = P_7
				} }
			};
			if (P_1 > 0.0)
			{
				doubleAnimationUsingKeyFrames2.KeyFrames.Add(new EasingDoubleKeyFrame
				{
					KeyTime = TimeSpan.FromSeconds(0.0),
					Value = P_6
				});
			}
			string path2 = vVK.ssH(22964);
			Storyboard.SetTargetProperty(doubleAnimationUsingKeyFrames2, new PropertyPath(path2));
			storyboard.Children.Add(doubleAnimationUsingKeyFrames2);
			int num = 0;
			if (nY1() != null)
			{
				num = 0;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					doubleAnimationUsingKeyFrames2 = new DoubleAnimationUsingKeyFrames
					{
						KeyFrames = { (DoubleKeyFrame)new EasingDoubleKeyFrame
						{
							EasingFunction = new BackEase
							{
								EasingMode = EasingMode.EaseOut
							},
							KeyTime = TimeSpan.FromSeconds(P_1),
							Value = P_7
						} }
					};
					num = 1;
					if (!QY0())
					{
						num = num2;
					}
					continue;
				case 1:
					break;
				}
				break;
			}
			if (P_1 > 0.0)
			{
				doubleAnimationUsingKeyFrames2.KeyFrames.Add(new EasingDoubleKeyFrame
				{
					KeyTime = TimeSpan.FromSeconds(0.0),
					Value = P_6
				});
			}
			path2 = vVK.ssH(23084);
			Storyboard.SetTargetProperty(doubleAnimationUsingKeyFrames2, new PropertyPath(path2));
			storyboard.Children.Add(doubleAnimationUsingKeyFrames2);
		}
		storyboard.Begin(P_0, HandoffBehavior.SnapshotAndReplace);
	}

	internal static bool QY0()
	{
		return QAz == null;
	}

	internal static zn nY1()
	{
		return QAz;
	}
}
