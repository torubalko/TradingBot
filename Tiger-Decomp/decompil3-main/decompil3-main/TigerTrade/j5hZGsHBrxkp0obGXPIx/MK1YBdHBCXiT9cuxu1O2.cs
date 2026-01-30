using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace j5hZGsHBrxkp0obGXPIx;

public class MK1YBdHBCXiT9cuxu1O2 : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private Action<object, int> m_GroupChanged;

	public static readonly DependencyProperty pTtHBAupGNB;

	internal MK1YBdHBCXiT9cuxu1O2 SecurityGroup;

	private bool gKQHBPVS2EN;

	private static MK1YBdHBCXiT9cuxu1O2 OejXPEDNDt3s6hjP33rV;

	public bool IsAllGroupVisible
	{
		get
		{
			return (bool)GetValue(pTtHBAupGNB);
		}
		set
		{
			SetValue(pTtHBAupGNB, flag);
		}
	}

	public event Action<object, int> GroupChanged
	{
		[CompilerGenerated]
		add
		{
			Action<object, int> action = this.m_GroupChanged;
			Action<object, int> action2;
			do
			{
				action2 = action;
				Action<object, int> value2 = (Action<object, int>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_GroupChanged, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<object, int> action = this.m_GroupChanged;
			Action<object, int> action2;
			do
			{
				action2 = action;
				Action<object, int> value2 = (Action<object, int>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_GroupChanged, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public MK1YBdHBCXiT9cuxu1O2()
	{
		HlB6NpDNkUd2Rs1fFqpy();
		base._002Ector();
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public static GBuirPli4t3ytMPj1yE8 g7dHBKp3nf3<GBuirPli4t3ytMPj1yE8>(DependencyObject P_0) where GBuirPli4t3ytMPj1yE8 : DependencyObject
	{
		DependencyObject parent = LogicalTreeHelper.GetParent(P_0);
		if (parent == null)
		{
			return null;
		}
		return (parent as GBuirPli4t3ytMPj1yE8) ?? g7dHBKp3nf3<GBuirPli4t3ytMPj1yE8>(parent);
	}

	private void Bj4HBmiqp4O(object P_0, MouseButtonEventArgs P_1)
	{
		P_1.Handled = true;
		FrameworkElement frameworkElement = pFapKaDN1rE4avEWi4nN(P_1) as FrameworkElement;
		int num = 4;
		PopupButton popupButton = default(PopupButton);
		int arg = default(int);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 3:
				popupButton.IsPopupOpen = false;
				break;
			case 2:
				if (popupButton != null)
				{
					num = 3;
					continue;
				}
				break;
			default:
				num2 = 0;
				goto IL_0114;
			case 1:
				return;
			case 5:
			{
				object obj = ADhYVFDN5XnUYV25SoLm(pFapKaDN1rE4avEWi4nN(P_1) as FrameworkElement);
				if (obj == null)
				{
					goto default;
				}
				num2 = Convert.ToInt32(obj);
				goto IL_0114;
			}
			case 4:
				{
					if (frameworkElement == null)
					{
						return;
					}
					num = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 != 0)
					{
						num = 1;
					}
					continue;
				}
				IL_0114:
				arg = num2;
				popupButton = g7dHBKp3nf3<PopupButton>(this);
				num = 2;
				continue;
			}
			break;
		}
		this.GroupChanged?.Invoke(frameworkElement.DataContext, arg);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
			{
				if (gKQHBPVS2EN)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
					{
						num2 = 0;
					}
					break;
				}
				gKQHBPVS2EN = true;
				Uri resourceLocator = new Uri((string)UGjSqSDNSdt1c6JDhFuI(-690510723 ^ -690570199), UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
				return;
			}
			case 0:
				return;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
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
					gKQHBPVS2EN = true;
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				SecurityGroup = (MK1YBdHBCXiT9cuxu1O2)P_1;
				SecurityGroup.PreviewMouseDown += Bj4HBmiqp4O;
				return;
			}
		}
	}

	static MK1YBdHBCXiT9cuxu1O2()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		HlB6NpDNkUd2Rs1fFqpy();
		pTtHBAupGNB = (DependencyProperty)RiYfqPDNLlVLSCvH0p28(UGjSqSDNSdt1c6JDhFuI(0x12620268 ^ 0x12631A8A), Type.GetTypeFromHandle(LmyDgGDNxJbMSN1Pyqrk(16777221)), Type.GetTypeFromHandle(LmyDgGDNxJbMSN1Pyqrk(33555246)), new PropertyMetadata(true));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void HlB6NpDNkUd2Rs1fFqpy()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool R52oYvDNbFkDeYIfwWP4()
	{
		return OejXPEDNDt3s6hjP33rV == null;
	}

	internal static MK1YBdHBCXiT9cuxu1O2 QUtWu2DNNNQ3J5d0kCxC()
	{
		return OejXPEDNDt3s6hjP33rV;
	}

	internal static object pFapKaDN1rE4avEWi4nN(object P_0)
	{
		return ((RoutedEventArgs)P_0).OriginalSource;
	}

	internal static object ADhYVFDN5XnUYV25SoLm(object P_0)
	{
		return ((FrameworkElement)P_0).Tag;
	}

	internal static object UGjSqSDNSdt1c6JDhFuI(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static RuntimeTypeHandle LmyDgGDNxJbMSN1Pyqrk(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static object RiYfqPDNLlVLSCvH0p28(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
