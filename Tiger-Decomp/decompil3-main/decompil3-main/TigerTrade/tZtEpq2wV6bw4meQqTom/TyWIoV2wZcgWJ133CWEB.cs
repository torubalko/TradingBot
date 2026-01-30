using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using ECOEgqlSad8NUJZ2Dr9n;
using OWUMXkHkWgCUprHQ3jb9;
using TigerTrade.Properties;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace tZtEpq2wV6bw4meQqTom;

internal sealed class TyWIoV2wZcgWJ133CWEB : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	private string jwA2ww4Lvnw;

	internal Button ButtonYes;

	internal Button ButtonNo;

	private bool z6Y2w7P5c9o;

	private static TyWIoV2wZcgWJ133CWEB ogsBeVDfJCAG5SALcHNl;

	public string Message
	{
		get
		{
			return jwA2ww4Lvnw;
		}
		set
		{
			if (!(text == jwA2ww4Lvnw))
			{
				jwA2ww4Lvnw = text;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1522697859 ^ -1522707599));
			}
		}
	}

	public TyWIoV2wZcgWJ133CWEB()
	{
		dlpIieDfpfLOldJeGauI();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void TER2wCJ32Ui(object P_0, RoutedEventArgs P_1)
	{
		base.DialogResult = true;
		Mw1aMjDfudZE8IFMd2TX(this);
	}

	private void raZ2wrrBZoM(object P_0, RoutedEventArgs P_1)
	{
		Close();
	}

	public static bool FlQ2wKApitN(Window P_0)
	{
		int ordersCount = DataManager.GetOrdersCount();
		int num = KjZI6TDfzvhiRI07NoiH();
		if (ordersCount == 0)
		{
			goto IL_017c;
		}
		goto IL_01e0;
		IL_01e0:
		StringBuilder stringBuilder = new StringBuilder();
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
		{
			num2 = 0;
		}
		goto IL_0009;
		IL_017c:
		if (num == 0)
		{
			num2 = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 != 0)
			{
				num2 = 3;
			}
			goto IL_0009;
		}
		goto IL_01e0;
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			case 5:
			case 7:
				if (ordersCount > 0)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (num > 0)
				{
					goto case 2;
				}
				goto case 6;
			case 1:
				U8G6dxD9HwZuLdg2tQex(stringBuilder, string.Format((string)CcqOAnD92KQTawvv5amG(), ordersCount));
				goto case 6;
			default:
				if (ordersCount <= 0)
				{
					num2 = 7;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
					{
						num2 = 6;
					}
					continue;
				}
				if (num > 0)
				{
					stringBuilder.Append(string.Format((string)TQJqBuD90Ug9WX6llKVC(), ordersCount, num));
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 5;
			case 4:
			{
				TyWIoV2wZcgWJ133CWEB obj = new TyWIoV2wZcgWJ133CWEB
				{
					Owner = P_0
				};
				GMArLOD9fiKnvPJ6Ypuv(obj, stringBuilder.ToString());
				return obj.ShowDialog() == true;
			}
			case 2:
				stringBuilder.Append(string.Format(TigerTrade.Properties.Resources.ExitConfirmWindowQuestionPositions, num));
				goto case 6;
			case 8:
				break;
			case 3:
				return true;
			case 6:
				stringBuilder.Append(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CD6EAF));
				stringBuilder.Append(TigerTrade.Properties.Resources.ExitConfirmWindowQuestionConfirm);
				num2 = 4;
				continue;
			}
			break;
		}
		goto IL_017c;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!z6Y2w7P5c9o)
		{
			z6Y2w7P5c9o = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1962651919 ^ -1962627221), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)rmUt3bD99iy9oUmHRyOS(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num2;
		if (P_0 != 1)
		{
			if (P_0 == 2)
			{
				ButtonNo = (Button)P_1;
				ButtonNo.Click += raZ2wrrBZoM;
				int num = 2;
				num2 = num;
			}
			else
			{
				z6Y2w7P5c9o = true;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
				{
					num2 = 1;
				}
			}
		}
		else
		{
			ButtonYes = (Button)P_1;
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
			{
				num2 = 0;
			}
		}
		switch (num2)
		{
		case 1:
			return;
		case 2:
			return;
		}
		kbk5CeD9nlFDDBETGhsj(ButtonYes, new RoutedEventHandler(TER2wCJ32Ui));
	}

	static TyWIoV2wZcgWJ133CWEB()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool WYYdAZDfFalJrBJbuZ15()
	{
		return ogsBeVDfJCAG5SALcHNl == null;
	}

	internal static TyWIoV2wZcgWJ133CWEB tPVk5lDf3C6DsBGV7uiP()
	{
		return ogsBeVDfJCAG5SALcHNl;
	}

	internal static void dlpIieDfpfLOldJeGauI()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void Mw1aMjDfudZE8IFMd2TX(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static int KjZI6TDfzvhiRI07NoiH()
	{
		return DataManager.GetPositionsCount();
	}

	internal static object TQJqBuD90Ug9WX6llKVC()
	{
		return TigerTrade.Properties.Resources.ExitConfirmWindowQuestionOrdersPositions;
	}

	internal static object CcqOAnD92KQTawvv5amG()
	{
		return TigerTrade.Properties.Resources.ExitConfirmWindowQuestionOrders;
	}

	internal static object U8G6dxD9HwZuLdg2tQex(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static void GMArLOD9fiKnvPJ6Ypuv(object P_0, object P_1)
	{
		((TyWIoV2wZcgWJ133CWEB)P_0).Message = (string)P_1;
	}

	internal static object rmUt3bD99iy9oUmHRyOS(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void kbk5CeD9nlFDDBETGhsj(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
