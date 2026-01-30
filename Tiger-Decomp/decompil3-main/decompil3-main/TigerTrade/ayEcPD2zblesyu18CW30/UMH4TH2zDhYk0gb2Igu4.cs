using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace ayEcPD2zblesyu18CW30;

internal sealed class UMH4TH2zDhYk0gb2Igu4 : StackPanel
{
	public static readonly DependencyProperty zMA2z1VRVuA;

	private static UMH4TH2zDhYk0gb2Igu4 IQCJyfDBROxEoKiu6hMS;

	public bool ReverseOrder
	{
		get
		{
			return (bool)GetValue(zMA2z1VRVuA);
		}
		set
		{
			SetValue(zMA2z1VRVuA, flag);
		}
	}

	protected override Size ArrangeOverride(Size P_0)
	{
		double num = 0.0;
		double num2 = 0.0;
		int num3 = 2;
		IEnumerator<UIElement> enumerator = default(IEnumerator<UIElement>);
		while (true)
		{
			IEnumerable<UIElement> obj;
			switch (num3)
			{
			case 1:
				try
				{
					while (enumerator.MoveNext())
					{
						UIElement current = enumerator.Current;
						Size size;
						int num4;
						if (base.Orientation != Orientation.Horizontal)
						{
							size = new Size(IkSVr8DBW3hiwP1d7bqe(P_0.Width, current.DesiredSize.Width), current.DesiredSize.Height);
							num4 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
							{
								num4 = 0;
							}
						}
						else
						{
							size = new Size(aMbEe5DBqOxxALOLdyMx(current).Width, Math.Max(P_0.Height, current.DesiredSize.Height));
							num4 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
							{
								num4 = 1;
							}
						}
						while (true)
						{
							switch (num4)
							{
							default:
								current.Arrange(new Rect(new Point(num, num2), size));
								num4 = 3;
								continue;
							case 2:
								break;
							case 3:
								num2 += size.Height;
								num4 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
								{
									num4 = 2;
								}
								continue;
							case 1:
								MN6xdWDBIeuL1honk5oT(current, new Rect(new Point(num, num2), size));
								num += size.Width;
								break;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						baO4VKDBtIHhYrMd1chf(enumerator);
					}
				}
				goto default;
			case 2:
				obj = (ReverseOrder ? ((IEnumerable)DcbkvdDBORfdAHZl3wrY(this)).Cast<UIElement>().Reverse() : base.InternalChildren.Cast<UIElement>());
				break;
			default:
				if (y40xBfDBUGDuYHNm7FGH(this) != Orientation.Horizontal)
				{
					return new Size(P_0.Width, num2);
				}
				return new Size(num, P_0.Height);
			}
			enumerator = obj.GetEnumerator();
			num3 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
			{
				num3 = 1;
			}
		}
	}

	public UMH4TH2zDhYk0gb2Igu4()
	{
		aM0xLPDBTJ9deSUy7Ytx();
		base._002Ector();
	}

	static UMH4TH2zDhYk0gb2Igu4()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				zMA2z1VRVuA = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1736566656 ^ -1736514500), O5PafZDByxT2MYq5FxPW(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555186)), new PropertyMetadata(false));
				return;
			}
		}
	}

	internal static bool yg8nRiDB6XRYwGqAe71b()
	{
		return IQCJyfDBROxEoKiu6hMS == null;
	}

	internal static UMH4TH2zDhYk0gb2Igu4 O9NuxpDBM0PY3SXXc8er()
	{
		return IQCJyfDBROxEoKiu6hMS;
	}

	internal static object DcbkvdDBORfdAHZl3wrY(object P_0)
	{
		return ((Panel)P_0).InternalChildren;
	}

	internal static Size aMbEe5DBqOxxALOLdyMx(object P_0)
	{
		return ((UIElement)P_0).DesiredSize;
	}

	internal static void MN6xdWDBIeuL1honk5oT(object P_0, Rect P_1)
	{
		((UIElement)P_0).Arrange(P_1);
	}

	internal static double IkSVr8DBW3hiwP1d7bqe(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void baO4VKDBtIHhYrMd1chf(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Orientation y40xBfDBUGDuYHNm7FGH(object P_0)
	{
		return ((StackPanel)P_0).Orientation;
	}

	internal static void aM0xLPDBTJ9deSUy7Ytx()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static Type O5PafZDByxT2MYq5FxPW(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
