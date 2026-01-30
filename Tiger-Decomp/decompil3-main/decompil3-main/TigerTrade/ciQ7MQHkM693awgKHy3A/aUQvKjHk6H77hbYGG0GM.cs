using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Annotations;
using TuAMtrl1Nd3XoZQQUXf0;
using U2AoR19TNRFWN9WoaNy;

namespace ciQ7MQHkM693awgKHy3A;

internal class aUQvKjHk6H77hbYGG0GM : UserControl, INotifyPropertyChanged
{
	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static aUQvKjHk6H77hbYGG0GM o0THSuDxlYilJnl1ZDt6;

	protected Window ParentWindow
	{
		get
		{
			Window result = default(Window);
			try
			{
				DependencyObject dependencyObject = (DependencyObject)JBW6XnDxN4thy18bMC64(this);
				int num = 2;
				while (true)
				{
					switch (num)
					{
					case 2:
						if (dependencyObject == null)
						{
							result = hNXfXl9U6G1YI9MQ7eq.Instance.MainWindow;
							num = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea != 0)
							{
								num = 1;
							}
							continue;
						}
						goto IL_0067;
					default:
						dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
						goto IL_0067;
					case 1:
						goto end_IL_001f;
						IL_0067:
						if (dependencyObject == null || dependencyObject is Window)
						{
							break;
						}
						goto default;
					}
					result = dependencyObject as Window;
					break;
					continue;
					end_IL_001f:
					break;
				}
			}
			catch (Exception)
			{
				result = ((hNXfXl9U6G1YI9MQ7eq)O7nIqCDxkE27Fw1iDyQd()).MainWindow;
			}
			return result;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 2;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
				{
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					goto case 1;
				}
				case 1:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			while (true)
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)IRSOwQDxbhDhgeZEs8h6(propertyChangedEventHandler2, propertyChangedEventHandler3);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return;
					}
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
					{
						num = 1;
					}
				}
			}
		}
	}

	[NotifyPropertyChangedInvocator]
	public void cY7HkOvo1nf([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public aUQvKjHk6H77hbYGG0GM()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static aUQvKjHk6H77hbYGG0GM()
	{
		DbE7V7Dx1LX2b28Xu5lw();
	}

	internal static bool jmDBR5Dx4ifG3EIYsfyK()
	{
		return o0THSuDxlYilJnl1ZDt6 == null;
	}

	internal static aUQvKjHk6H77hbYGG0GM dcUj7FDxDgcm0CBpHSMX()
	{
		return o0THSuDxlYilJnl1ZDt6;
	}

	internal static object IRSOwQDxbhDhgeZEs8h6(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static object JBW6XnDxN4thy18bMC64(object P_0)
	{
		return VisualTreeHelper.GetParent((DependencyObject)P_0);
	}

	internal static object O7nIqCDxkE27Fw1iDyQd()
	{
		return hNXfXl9U6G1YI9MQ7eq.Instance;
	}

	internal static void DbE7V7Dx1LX2b28Xu5lw()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
