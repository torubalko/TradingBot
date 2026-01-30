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
using kaGY6vnlotCyCWw7ZhD5;
using lu2mPMmsdlOvPFIB25c;
using TuAMtrl1Nd3XoZQQUXf0;

namespace pSN0Obm4uT0my4JTdtJ;

internal class xfJdusmlMIKXdP5g3BA : UserControl, IComponentConnector
{
	private bool qDwm5FIZnT;

	private double HBcmSnSUPU;

	private XweZ7cme4bUexhPLo8B mI4mxdCUPZ;

	internal ScrollBar ChartScrollBar;

	private bool nRGmLmfmQ1;

	private static xfJdusmlMIKXdP5g3BA RiYRkn4NzE6eCetJBbuQ;

	public xfJdusmlMIKXdP5g3BA()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		InitializeComponent();
		IcrSlJ4kHhApsRJVdHIp(ChartScrollBar, 0.0);
		ChartScrollBar.Maximum = 0.0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				ChartScrollBar.Value = 0.0;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
				{
					num = 0;
				}
				break;
			case 1:
				ChartScrollBar.LargeChange = 0.0;
				num = 2;
				break;
			case 0:
				return;
			}
		}
	}

	[SpecialName]
	public XweZ7cme4bUexhPLo8B mKAmNvhkFs()
	{
		return mI4mxdCUPZ;
	}

	[SpecialName]
	public void QuVmkNk31D(XweZ7cme4bUexhPLo8B P_0)
	{
		mI4mxdCUPZ = P_0;
		if (P_0 == null)
		{
			return;
		}
		YQBkFr4kfjB4fElRULSA(mI4mxdCUPZ, new Gv6oHWnllm288kdP8Rlo(D5PmDynGNj));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				mI4mxdCUPZ.eBZmARjN5d(D5PmDynGNj);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void D5PmDynGNj(object P_0, QiMs6anlYOxVtN4vT3de P_1)
	{
		if (qDwm5FIZnT)
		{
			qDwm5FIZnT = false;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				break;
			}
		}
		qDwm5FIZnT = true;
		try
		{
			int num2 = Math.Max(P_1.kMonlBnE7Vh - P_1.hdenlvdSeyY, 0) + 1;
			int num3 = 4;
			double num5 = default(double);
			double num4 = default(double);
			while (true)
			{
				switch (num3)
				{
				default:
					if (num5 < 0.0)
					{
						num3 = 3;
						break;
					}
					if (num5 < num4)
					{
						ChartScrollBar.ViewportSize = num4 * num5 / (num4 - num5);
						num3 = 6;
						break;
					}
					goto case 2;
				case 2:
					ChartScrollBar.ViewportSize = double.MaxValue;
					num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
					{
						num3 = 1;
					}
					break;
				case 3:
				{
					ChartScrollBar.ViewportSize = 0.0;
					int num6 = 5;
					num3 = num6;
					break;
				}
				case 4:
					IcrSlJ4kHhApsRJVdHIp(ChartScrollBar, P_1.fnbnlap64c3 + num2 - 1);
					ChartScrollBar.Maximum = P_1.eggnli55XWa;
					ChartScrollBar.LargeChange = num2;
					ChartScrollBar.SmallChange = Extv1J4k9upGSHOZCweG(ChartScrollBar);
					ChartScrollBar.Value = P_1.hdenlvdSeyY;
					HBcmSnSUPU = P_1.kMonlBnE7Vh;
					num4 = ChartScrollBar.Maximum - ChartScrollBar.Minimum;
					num5 = num4 * 0.02;
					num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
					{
						num3 = 0;
					}
					break;
				case 5:
					return;
				case 6:
					return;
				case 1:
					return;
				}
			}
		}
		finally
		{
			qDwm5FIZnT = false;
		}
	}

	private void wGambQbfE5(object P_0, RoutedPropertyChangedEventArgs<double> P_1)
	{
		if (!qDwm5FIZnT && mKAmNvhkFs() != null)
		{
			qDwm5FIZnT = true;
			mKAmNvhkFs().Scroll((int)((double)(int)Math.Ceiling(ChartScrollBar.Value) - ChartScrollBar.Minimum));
			mKAmNvhkFs().DN2mtm0veC();
			HBcmSnSUPU = ChartScrollBar.Value;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!nRGmLmfmQ1)
		{
			nRGmLmfmQ1 = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-527080372 ^ -527090908), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
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
					nRGmLmfmQ1 = true;
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				ChartScrollBar = (ScrollBar)P_1;
				ChartScrollBar.ValueChanged += wGambQbfE5;
				return;
			}
		}
	}

	static xfJdusmlMIKXdP5g3BA()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void IcrSlJ4kHhApsRJVdHIp(object P_0, double P_1)
	{
		((RangeBase)P_0).Minimum = P_1;
	}

	internal static bool IRumXd4k0S6nmTM4ibmp()
	{
		return RiYRkn4NzE6eCetJBbuQ == null;
	}

	internal static xfJdusmlMIKXdP5g3BA qwivYG4k2wgwcXFUTF0B()
	{
		return RiYRkn4NzE6eCetJBbuQ;
	}

	internal static void YQBkFr4kfjB4fElRULSA(object P_0, object P_1)
	{
		((XweZ7cme4bUexhPLo8B)P_0).Vp0mPFCGYm((Gv6oHWnllm288kdP8Rlo)P_1);
	}

	internal static double Extv1J4k9upGSHOZCweG(object P_0)
	{
		return ((RangeBase)P_0).LargeChange;
	}
}
