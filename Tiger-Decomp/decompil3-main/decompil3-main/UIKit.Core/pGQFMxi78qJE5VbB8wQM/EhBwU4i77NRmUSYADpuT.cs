using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace pGQFMxi78qJE5VbB8wQM;

[TemplateVisualState(Name = "MouseOver")]
[TemplateVisualState(Name = "Normal")]
[TemplateVisualState(Name = "Pressed")]
[TemplateVisualState(Name = "Selected")]
public class EhBwU4i77NRmUSYADpuT : Control
{
	public static readonly DependencyProperty Ewhi8B65LiV;

	public static readonly DependencyProperty v8Ni8aWD0kG;

	public static readonly DependencyProperty D2Ai8i3G5aw;

	public static readonly DependencyProperty Ynei8lIj4Da;

	public static readonly DependencyProperty zFOi84XxgVa;

	public static readonly DependencyProperty wkui8DLWfaJ;

	internal static EhBwU4i77NRmUSYADpuT jngwumXnjh9yc4EwLw3O;

	public DataTemplate ContentTemplate
	{
		get
		{
			return (DataTemplate)GetValue(Ewhi8B65LiV);
		}
		set
		{
			SetValue(Ewhi8B65LiV, value2);
		}
	}

	public object Content
	{
		get
		{
			return GetValue(v8Ni8aWD0kG);
		}
		set
		{
			SetValue(v8Ni8aWD0kG, value2);
		}
	}

	public string Description
	{
		get
		{
			return (string)GetValue(D2Ai8i3G5aw);
		}
		set
		{
			SetValue(D2Ai8i3G5aw, value2);
		}
	}

	public bool IsSelectable
	{
		get
		{
			return (bool)GetValue(Ynei8lIj4Da);
		}
		set
		{
			otA2yYXndK6sc3pmMgJt(this, Ynei8lIj4Da, flag);
		}
	}

	public bool IsSelected
	{
		get
		{
			return (bool)WfrZtAXngWjxwgXV6gVh(this, zFOi84XxgVa);
		}
		set
		{
			SetValue(zFOi84XxgVa, flag);
		}
	}

	public bool IsPressed
	{
		get
		{
			return (bool)WfrZtAXngWjxwgXV6gVh(this, wkui8DLWfaJ);
		}
		set
		{
			otA2yYXndK6sc3pmMgJt(this, wkui8DLWfaJ, flag);
		}
	}

	public EhBwU4i77NRmUSYADpuT()
	{
		qKjlbVXnRtamHRx5GGGt();
		base._002Ector();
		base.MouseLeftButtonDown += zuei7A3OJ9j;
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_800979ef175f4570a283be4fa8173624 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.MouseLeftButtonUp += LrMi7PHUh6N;
	}

	private void zuei7A3OJ9j(object P_0, MouseButtonEventArgs P_1)
	{
		EhBwU4i77NRmUSYADpuT ehBwU4i77NRmUSYADpuT = P_0 as EhBwU4i77NRmUSYADpuT;
		bool flag = ehBwU4i77NRmUSYADpuT == null;
		int num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_8cdc9ad005814fe2a98187bc4b0a89ab != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (!flag)
				{
					ehBwU4i77NRmUSYADpuT.IsPressed = true;
					num = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_97352da3f1db406e82084031ac91a168 != 0)
					{
						num = 0;
					}
					break;
				}
				return;
			}
		}
	}

	private void LrMi7PHUh6N(object P_0, MouseButtonEventArgs P_1)
	{
		if (P_0 is EhBwU4i77NRmUSYADpuT ehBwU4i77NRmUSYADpuT)
		{
			ehBwU4i77NRmUSYADpuT.IsPressed = false;
		}
	}

	static EhBwU4i77NRmUSYADpuT()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
					num2 = 1;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_df0a40d144cf4cfbb9b3ae4d9199b671 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					v8Ni8aWD0kG = (DependencyProperty)Idv2s7XnOnMNFsL1WYLN(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-82860344 ^ -82860854), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777236)), Type.GetTypeFromHandle(UckRb6Xn6YQKOBhd40PE(33554447)));
					D2Ai8i3G5aw = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x6D18F862 ^ 0x6D18FA76), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554447)));
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5cd8e53bfc054438a37c94de95b33088 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
					RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
					Ewhi8B65LiV = (DependencyProperty)Idv2s7XnOnMNFsL1WYLN(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x1AB79299 ^ 0x1AB79379), apiZ37XnML4opdJFcsu0(UckRb6Xn6YQKOBhd40PE(16777294)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554447)));
					num2 = 1;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_98790ccfa91e4cc4b8e56de14d056b9b == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					wkui8DLWfaJ = (DependencyProperty)gpjmKXXnISZywptGcHtr(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-2056710528 ^ -2056710966), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(UckRb6Xn6YQKOBhd40PE(33554447)), new PropertyMetadata(false));
					return;
				}
				break;
			}
			Ynei8lIj4Da = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-176525661 ^ -176526195), apiZ37XnML4opdJFcsu0(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554447)));
			zFOi84XxgVa = DependencyProperty.Register((string)AgRqA5Xnq5gyQc5ifNfM(-342738082 ^ -342738198), apiZ37XnML4opdJFcsu0(UckRb6Xn6YQKOBhd40PE(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554447)));
			num = 2;
		}
	}

	internal static bool IJgS2pXnEHG5LQutEXLP()
	{
		return jngwumXnjh9yc4EwLw3O == null;
	}

	internal static EhBwU4i77NRmUSYADpuT agMh3rXnQ1UoMZ9cWWLu()
	{
		return jngwumXnjh9yc4EwLw3O;
	}

	internal static void otA2yYXndK6sc3pmMgJt(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static object WfrZtAXngWjxwgXV6gVh(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void qKjlbVXnRtamHRx5GGGt()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static RuntimeTypeHandle UckRb6Xn6YQKOBhd40PE(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static Type apiZ37XnML4opdJFcsu0(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Idv2s7XnOnMNFsL1WYLN(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}

	internal static object AgRqA5Xnq5gyQc5ifNfM(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}

	internal static object gpjmKXXnISZywptGcHtr(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
