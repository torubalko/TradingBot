using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace j3XGTE2R7ZlXosIAOUCl;

internal class eIKx7e2RwaY7jcJ4kgJZ : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private Action<string> m_IconSelected;

	private bool ct12RJnWANs;

	private static eIKx7e2RwaY7jcJ4kgJZ mnajka4P8UxbubA6N963;

	public event Action<string> IconSelected
	{
		[CompilerGenerated]
		add
		{
			Action<string> action = this.m_IconSelected;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> value2 = (Action<string>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_IconSelected, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<string> action = this.m_IconSelected;
			Action<string> action2;
			do
			{
				action2 = action;
				Action<string> value2 = (Action<string>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_IconSelected, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public eIKx7e2RwaY7jcJ4kgJZ()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void ibn2R8KQjq6(object P_0, RoutedEventArgs P_1)
	{
		string obj = ((Button)P_1.OriginalSource).CommandParameter.ToString();
		Action<string> action = this.IconSelected;
		if (action != null)
		{
			action(obj);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!ct12RJnWANs)
		{
			ct12RJnWANs = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2108526692 ^ -2108513264), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				case 10:
					return;
				case 6:
					return;
				case 3:
					return;
				case 7:
					return;
				case 2:
					return;
				case 4:
					return;
				default:
					ct12RJnWANs = true;
					num2 = 4;
					break;
				case 1:
					switch (P_0)
					{
					case 17:
						DKclML4PJGVsY4FGvdnk((Button)P_1, new RoutedEventHandler(ibn2R8KQjq6));
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
						{
							num2 = 8;
						}
						goto end_IL_0012;
					case 2:
						break;
					case 5:
						DKclML4PJGVsY4FGvdnk((Button)P_1, new RoutedEventHandler(ibn2R8KQjq6));
						return;
					case 9:
						DKclML4PJGVsY4FGvdnk((Button)P_1, new RoutedEventHandler(ibn2R8KQjq6));
						return;
					case 15:
						((Button)P_1).Click += ibn2R8KQjq6;
						num2 = 9;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
						{
							num2 = 6;
						}
						goto end_IL_0012;
					case 10:
						DKclML4PJGVsY4FGvdnk((Button)P_1, new RoutedEventHandler(ibn2R8KQjq6));
						num2 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
						{
							num2 = 5;
						}
						goto end_IL_0012;
					case 1:
						((Button)P_1).Click += ibn2R8KQjq6;
						return;
					case 11:
						((Button)P_1).Click += ibn2R8KQjq6;
						return;
					case 13:
						DKclML4PJGVsY4FGvdnk((Button)P_1, new RoutedEventHandler(ibn2R8KQjq6));
						num2 = 6;
						goto end_IL_0012;
					case 3:
						((Button)P_1).Click += ibn2R8KQjq6;
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
						{
							num2 = 2;
						}
						goto end_IL_0012;
					case 14:
						DKclML4PJGVsY4FGvdnk((Button)P_1, new RoutedEventHandler(ibn2R8KQjq6));
						return;
					case 20:
						((Button)P_1).Click += ibn2R8KQjq6;
						return;
					case 19:
						DKclML4PJGVsY4FGvdnk((Button)P_1, new RoutedEventHandler(ibn2R8KQjq6));
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
						{
							num2 = 1;
						}
						goto end_IL_0012;
					case 4:
						DKclML4PJGVsY4FGvdnk((Button)P_1, new RoutedEventHandler(ibn2R8KQjq6));
						return;
					default:
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
						{
							num2 = 0;
						}
						goto end_IL_0012;
					case 6:
						((Button)P_1).Click += ibn2R8KQjq6;
						return;
					case 7:
						((Button)P_1).Click += ibn2R8KQjq6;
						return;
					case 12:
						DKclML4PJGVsY4FGvdnk((Button)P_1, new RoutedEventHandler(ibn2R8KQjq6));
						return;
					case 18:
						((Button)P_1).Click += ibn2R8KQjq6;
						num2 = 7;
						goto end_IL_0012;
					case 8:
						((Button)P_1).Click += ibn2R8KQjq6;
						return;
					case 16:
						((Button)P_1).Click += ibn2R8KQjq6;
						return;
					}
					((Button)P_1).Click += ibn2R8KQjq6;
					num = 10;
					goto end_IL_0012_2;
				case 8:
					return;
				case 9:
					return;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_0012_2:
				break;
			}
		}
	}

	static eIKx7e2RwaY7jcJ4kgJZ()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool O0J7d34PAQNALTaxHHWy()
	{
		return mnajka4P8UxbubA6N963 == null;
	}

	internal static eIKx7e2RwaY7jcJ4kgJZ H2DaG84PPdDDsIIT9X45()
	{
		return mnajka4P8UxbubA6N963;
	}

	internal static void DKclML4PJGVsY4FGvdnk(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
