using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace De4V5DiALQ1Nw33vCbmj;

public class SU7YPfiAxgiZxFkYPjLg : Control
{
	public static readonly DependencyProperty TliiAM3D8e4;

	public static readonly DependencyProperty V0niAO1SEe1;

	public static readonly DependencyProperty BDdiAqN7PIu;

	public static readonly DependencyProperty fwdiAIqKN70;

	public static readonly DependencyProperty kb0iAW4T9Zy;

	internal static SU7YPfiAxgiZxFkYPjLg mkqHhYXGOrskritl3JK3;

	public string Title
	{
		get
		{
			return (string)GetValue(TliiAM3D8e4);
		}
		set
		{
			SetValue(TliiAM3D8e4, value2);
		}
	}

	public string SubTitle
	{
		get
		{
			return (string)GetValue(V0niAO1SEe1);
		}
		set
		{
			SetValue(V0niAO1SEe1, value2);
		}
	}

	public ICommand ClickCommand
	{
		get
		{
			return (ICommand)GetValue(BDdiAqN7PIu);
		}
		set
		{
			SetValue(BDdiAqN7PIu, value2);
		}
	}

	public bool IsClickEnabled
	{
		get
		{
			return (bool)GetValue(fwdiAIqKN70);
		}
		set
		{
			SetValue(fwdiAIqKN70, flag);
		}
	}

	public object ClickCommandParameter
	{
		get
		{
			return aS90emXGUGTDLYEucfmc(this, kb0iAW4T9Zy);
		}
		set
		{
			naXGQGXGTM7b50S2uJq0(this, kb0iAW4T9Zy, obj);
		}
	}

	public SU7YPfiAxgiZxFkYPjLg()
	{
		aGoebGXGWJS8hfqWkF6O();
		base._002Ector();
		hYiUfMXGtmcJhDrnThUo(this, new MouseButtonEventHandler(TIZiAeXs4Uf));
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_678158a448ed4ed6b138db9d9cc5ca75 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void TIZiAeXs4Uf(object P_0, MouseButtonEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
			{
				ICommand command = ClickCommand;
				if (command == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_747acb5925c7480aa9dfd38106a74c05 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				if (!command.CanExecute(ClickCommandParameter))
				{
					return;
				}
				break;
			}
			}
			break;
		}
		ClickCommand.Execute(ClickCommandParameter);
	}

	static SU7YPfiAxgiZxFkYPjLg()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		TliiAM3D8e4 = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x4220DA8 ^ 0x4220E3E), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Tfs76gXGydR1cCVwOJ0U(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554456)));
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				kb0iAW4T9Zy = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1801468030 ^ -1801468810), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777236)), Tfs76gXGydR1cCVwOJ0U(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554456)));
				return;
			case 1:
				fwdiAIqKN70 = (DependencyProperty)zrvUeQXGChH5wqQ8GkQP(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-2108526692 ^ -2108527544), Tfs76gXGydR1cCVwOJ0U(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777220)), Tfs76gXGydR1cCVwOJ0U(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554456)));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_148384daf661411383613097e5a99904 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				V0niAO1SEe1 = DependencyProperty.Register((string)Kua6vyXGZph7UTQTJdS3(-338769610 ^ -338769262), Tfs76gXGydR1cCVwOJ0U(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777225)), Tfs76gXGydR1cCVwOJ0U(oCh4RZXGVeFPGlDHLWH8(33554456)));
				BDdiAqN7PIu = DependencyProperty.Register((string)Kua6vyXGZph7UTQTJdS3(0xC1DDB3B ^ 0xC1DD883), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777255)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554456)));
				num = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_972dd0905aa74735b7862b8138b18a1d == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void aGoebGXGWJS8hfqWkF6O()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static void hYiUfMXGtmcJhDrnThUo(object P_0, object P_1)
	{
		((UIElement)P_0).MouseLeftButtonUp += (MouseButtonEventHandler)P_1;
	}

	internal static bool tawZBYXGqTE1rou4vCti()
	{
		return mkqHhYXGOrskritl3JK3 == null;
	}

	internal static SU7YPfiAxgiZxFkYPjLg kaWqy2XGInuedpUP5BIc()
	{
		return mkqHhYXGOrskritl3JK3;
	}

	internal static object aS90emXGUGTDLYEucfmc(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void naXGQGXGTM7b50S2uJq0(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static Type Tfs76gXGydR1cCVwOJ0U(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Kua6vyXGZph7UTQTJdS3(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}

	internal static RuntimeTypeHandle oCh4RZXGVeFPGlDHLWH8(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static object zrvUeQXGChH5wqQ8GkQP(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}
}
