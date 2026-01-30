using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using ECOEgqlSad8NUJZ2Dr9n;
using GPyoH8nl49gHjhie6KCl;
using jS3Y2j9pTQRy0FnOknFG;
using kaGY6vnlotCyCWw7ZhD5;
using TuAMtrl1Nd3XoZQQUXf0;

namespace byuRZVn0UIdr8OYukypu;

internal sealed class oZbb3Yn0tnF1Sv7H1A8H : UserControl, IComponentConnector
{
	private bool zlqn0rPEbKm;

	private jjKtVJ9pUSOpdg38tqnP iPhn0K2HSeF;

	internal ScrollBar ChartScrollBar;

	private bool Kxln0mAqB7D;

	internal static oZbb3Yn0tnF1Sv7H1A8H DLflQ9b7sxEY5r8LBoAC;

	public oZbb3Yn0tnF1Sv7H1A8H()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				InitializeComponent();
				ChartScrollBar.Minimum = 0.0;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				ChartScrollBar.LargeChange = 0.0;
				ve9LR1b7jwr3YxfmjAHU(ChartScrollBar, 0.0);
				return;
			default:
				ChartScrollBar.Maximum = 0.0;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	[SpecialName]
	public jjKtVJ9pUSOpdg38tqnP sebn0Zg8358()
	{
		return iPhn0K2HSeF;
	}

	[SpecialName]
	public void FfNn0VQGBeM(jjKtVJ9pUSOpdg38tqnP P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				iPhn0K2HSeF = P_0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (P_0 != null)
				{
					iPhn0K2HSeF.RNR9zrxcC92(XVmn0TgYWNJ);
					k1eVYhb7EXghq73aCh4k(iPhn0K2HSeF, new Gv6oHWnllm288kdP8Rlo(XVmn0TgYWNJ));
				}
				return;
			}
		}
	}

	private void XVmn0TgYWNJ(object P_0, QiMs6anlYOxVtN4vT3de P_1)
	{
		if (zlqn0rPEbKm)
		{
			zlqn0rPEbKm = false;
			return;
		}
		zlqn0rPEbKm = true;
		try
		{
			int num = Math.Max(P_1.kMonlBnE7Vh - P_1.hdenlvdSeyY, 0) + 1;
			ChartScrollBar.Minimum = P_1.fnbnlap64c3 + num - 1;
			HWmNwfb7Q5SZ4Z78FPAw(ChartScrollBar, P_1.eggnli55XWa);
			int num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 != 0)
			{
				num2 = 1;
			}
			double num4 = default(double);
			double num3 = default(double);
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 2:
					num4 = num3 * 0.02;
					if (!(num4 < 0.0))
					{
						if (!(num4 < num3))
						{
							ChartScrollBar.ViewportSize = double.MaxValue;
							return;
						}
						int num5 = 5;
						num2 = num5;
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
						{
							num2 = 0;
						}
					}
					break;
				case 5:
					jI3059b7Rah7GG52rcuO(ChartScrollBar, num3 * num4 / (num3 - num4));
					return;
				case 1:
					ChartScrollBar.LargeChange = num;
					num2 = 3;
					break;
				default:
					ChartScrollBar.ViewportSize = 0.0;
					num2 = 4;
					break;
				case 3:
					ChartScrollBar.SmallChange = yA2UkOb7dr7mGWmwsHU2(ChartScrollBar);
					ve9LR1b7jwr3YxfmjAHU(ChartScrollBar, P_1.kMonlBnE7Vh);
					num3 = yOfGeNb7gLj89Pm6PGg6(ChartScrollBar) - ChartScrollBar.Minimum;
					num2 = 2;
					break;
				}
			}
		}
		finally
		{
			zlqn0rPEbKm = false;
		}
	}

	private void iYNn0yCkKcq(object P_0, RoutedPropertyChangedEventArgs<double> P_1)
	{
		if (!zlqn0rPEbKm && sebn0Zg8358() != null)
		{
			zlqn0rPEbKm = true;
			sebn0Zg8358().Chart.VNfniL6M4jn = 0.0;
			sebn0Zg8358().Chart.NaCnaIJ6EHh((int)(ChartScrollBar.Maximum - (double)(int)Math.Ceiling(ChartScrollBar.Value)));
			sebn0Zg8358().KLn9ppXIgKi();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!Kxln0mAqB7D)
		{
			Kxln0mAqB7D = true;
			Uri resourceLocator = new Uri((string)T1bm3Ob76bbxu128cwFh(0x1AB79299 ^ 0x1AB3129D), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf != 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 0:
				break;
			case 1:
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (P_0 != 1)
				{
					Kxln0mAqB7D = true;
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				ChartScrollBar = (ScrollBar)P_1;
				ChartScrollBar.ValueChanged += iYNn0yCkKcq;
				return;
			}
		}
	}

	static oZbb3Yn0tnF1Sv7H1A8H()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void ve9LR1b7jwr3YxfmjAHU(object P_0, double P_1)
	{
		((RangeBase)P_0).Value = P_1;
	}

	internal static bool AQ6MTyb7XqW6vTmKuFfa()
	{
		return DLflQ9b7sxEY5r8LBoAC == null;
	}

	internal static oZbb3Yn0tnF1Sv7H1A8H J6OckFb7crRTN3xPV0J2()
	{
		return DLflQ9b7sxEY5r8LBoAC;
	}

	internal static void k1eVYhb7EXghq73aCh4k(object P_0, object P_1)
	{
		((jjKtVJ9pUSOpdg38tqnP)P_0).b0T9zCywKoF((Gv6oHWnllm288kdP8Rlo)P_1);
	}

	internal static void HWmNwfb7Q5SZ4Z78FPAw(object P_0, double P_1)
	{
		((RangeBase)P_0).Maximum = P_1;
	}

	internal static double yA2UkOb7dr7mGWmwsHU2(object P_0)
	{
		return ((RangeBase)P_0).LargeChange;
	}

	internal static double yOfGeNb7gLj89Pm6PGg6(object P_0)
	{
		return ((RangeBase)P_0).Maximum;
	}

	internal static void jI3059b7Rah7GG52rcuO(object P_0, double P_1)
	{
		((ScrollBar)P_0).ViewportSize = P_1;
	}

	internal static object T1bm3Ob76bbxu128cwFh(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}
}
