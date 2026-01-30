using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace EZmIFqiz5oDVq7Kw7dIG;

[TemplateVisualState(Name = "Pressed")]
[TemplateVisualState(Name = "Normal")]
[TemplateVisualState(Name = "MouseOver")]
[TemplateVisualState(Name = "Selected")]
public class CahRbBiz1UGRx7tbhujj : Control
{
	public static readonly DependencyProperty NmTizOQnU5P;

	public static readonly DependencyProperty J2pizqcqJbm;

	public static readonly DependencyProperty E0iizIn93A5;

	public static readonly DependencyProperty eGqizWc3TRg;

	internal static CahRbBiz1UGRx7tbhujj DyNasjXB5CGAaNMRFEt2;

	public DataTemplate ContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(NmTizOQnU5P);
		}
		set
		{
			SetValue(NmTizOQnU5P, value2);
		}
	}

	public object Content
	{
		get
		{
			return pLPa5YXBLf6wLWDwIM5F(this, J2pizqcqJbm);
		}
		set
		{
			UILhKEXBe4rbYdYPtIa6(this, J2pizqcqJbm, obj);
		}
	}

	public bool IsSelected
	{
		get
		{
			return (bool)GetValue(E0iizIn93A5);
		}
		set
		{
			SetValue(E0iizIn93A5, flag);
		}
	}

	public bool IsPressed
	{
		get
		{
			return (bool)GetValue(eGqizWc3TRg);
		}
		set
		{
			SetValue(eGqizWc3TRg, flag);
		}
	}

	public CahRbBiz1UGRx7tbhujj()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
		WBugiOXBsaLr7AmEJGrs(this, new MouseButtonEventHandler(Ijjizx6WKB7));
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_de599029a5c7471f9afafcb351c68d36 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.MouseLeftButtonUp += hsLizLgu9LD;
	}

	private static void rrhizSuvHVS(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		CahRbBiz1UGRx7tbhujj cahRbBiz1UGRx7tbhujj = P_0 as CahRbBiz1UGRx7tbhujj;
		int num;
		if (cahRbBiz1UGRx7tbhujj != null)
		{
			num = 4;
			goto IL_0009;
		}
		int num2 = 1;
		goto IL_0142;
		IL_0142:
		bool flag = (byte)num2 != 0;
		num = 2;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_950e000f8b8e487a9fb408c5cce03cd7 == 0)
		{
			num = 2;
		}
		goto IL_0009;
		IL_0009:
		bool flag2 = default(bool);
		object newValue = default(object);
		int num3;
		while (true)
		{
			switch (num)
			{
			case 1:
				VisualStateManager.GoToState(cahRbBiz1UGRx7tbhujj, OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x385FFAB ^ 0x385F64B), useTransitions: true);
				return;
			case 5:
				return;
			case 3:
				if (!flag2)
				{
					VisualStateManager.GoToState(cahRbBiz1UGRx7tbhujj, OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-2017337494 ^ -2017339368), useTransitions: true);
					num = 5;
					continue;
				}
				num = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_737065c8a4b74d1d9d7a50423d7ba3fc != 0)
				{
					num = 0;
				}
				continue;
			case 4:
				newValue = P_1.NewValue;
				if (newValue is bool)
				{
					num = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0c51149f95a846678c44c1ff181aee24 != 0)
					{
						num = 0;
					}
					continue;
				}
				num3 = 0;
				break;
			default:
				flag2 = (bool)newValue;
				num3 = 1;
				break;
			case 2:
				if (flag)
				{
					return;
				}
				goto case 3;
			}
			break;
		}
		num2 = ((num3 == 0) ? 1 : 0);
		goto IL_0142;
	}

	private void Ijjizx6WKB7(object P_0, MouseButtonEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		CahRbBiz1UGRx7tbhujj cahRbBiz1UGRx7tbhujj = default(CahRbBiz1UGRx7tbhujj);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				cahRbBiz1UGRx7tbhujj = P_0 as CahRbBiz1UGRx7tbhujj;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_d226d78a4e104f1db903a0d012416f7b == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				if (cahRbBiz1UGRx7tbhujj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f803e8ef04c14ef097ea51825f131558 != 0)
					{
						num2 = 0;
					}
					break;
				}
				cahRbBiz1UGRx7tbhujj.IsPressed = true;
				return;
			}
		}
	}

	private void hsLizLgu9LD(object P_0, MouseButtonEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		CahRbBiz1UGRx7tbhujj cahRbBiz1UGRx7tbhujj = default(CahRbBiz1UGRx7tbhujj);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				cahRbBiz1UGRx7tbhujj = P_0 as CahRbBiz1UGRx7tbhujj;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f4b1c8890eb74a208beeb28d12eddc3d == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (cahRbBiz1UGRx7tbhujj == null)
			{
				num2 = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_0c51149f95a846678c44c1ff181aee24 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			JASZHaXBXUJmlXehgsKH(cahRbBiz1UGRx7tbhujj, false);
			return;
		}
	}

	static CahRbBiz1UGRx7tbhujj()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		say0FkXBcjhRvhtk1vck();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				E0iizIn93A5 = (DependencyProperty)fQN6emXBdiFLGUf3b0LT(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(--134855371 ^ 0x809BB7F), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(ySAZv6XBQH7xltXkJp8h(33554476)), new PropertyMetadata(false, rrhizSuvHVS));
				eGqizWc3TRg = DependencyProperty.Register((string)r8O7YhXBg3G9G8cJBY2V(0xB15786A ^ 0xB157A20), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554476)), new PropertyMetadata(false));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5181c84710c64ff897e0d62573bc5717 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
				NmTizOQnU5P = (DependencyProperty)tXqkAIXBjefECsKL4HXa(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-602153869 ^ -602153581), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777294)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554476)));
				J2pizqcqJbm = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-176525661 ^ -176526175), Ff0awhXBEp0IetOTMj3x(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777236)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554476)));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a0279c4ba1c84315962e441eb713cbcc == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool RIxL7fXBSXGqyi4Bnulb()
	{
		return DyNasjXB5CGAaNMRFEt2 == null;
	}

	internal static CahRbBiz1UGRx7tbhujj VQVjVsXBxAdULYAqkf0Z()
	{
		return DyNasjXB5CGAaNMRFEt2;
	}

	internal static object pLPa5YXBLf6wLWDwIM5F(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void UILhKEXBe4rbYdYPtIa6(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void WBugiOXBsaLr7AmEJGrs(object P_0, object P_1)
	{
		((UIElement)P_0).MouseLeftButtonDown += (MouseButtonEventHandler)P_1;
	}

	internal static void JASZHaXBXUJmlXehgsKH(object P_0, bool P_1)
	{
		((CahRbBiz1UGRx7tbhujj)P_0).IsPressed = P_1;
	}

	internal static void say0FkXBcjhRvhtk1vck()
	{
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object tXqkAIXBjefECsKL4HXa(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}

	internal static Type Ff0awhXBEp0IetOTMj3x(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static RuntimeTypeHandle ySAZv6XBQH7xltXkJp8h(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static object fQN6emXBdiFLGUf3b0LT(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}

	internal static object r8O7YhXBg3G9G8cJBY2V(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}
}
