using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Annotations;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace reuqbSHkyZtO3nPa1eKn;

internal abstract class xRgq7gHkTVINiHGAKc0y : INotifyPropertyChanged
{
	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static xRgq7gHkTVINiHGAKc0y cAK5aDDxcn7J6KfDOwZP;

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e != 0)
						{
							num = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			while (true)
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
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
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	[NotifyPropertyChangedInvocator]
	public void JZYHkZsWiJ6([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			rac3SiDxQSrGpOfKb7ns(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
	{
		if (string.IsNullOrEmpty(propertyName))
		{
			throw new ArgumentException(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-690510723 ^ -690584133), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1878953018 ^ -1879027222));
		}
		if (EqualityComparer<T>.Default.Equals(field, value))
		{
			return false;
		}
		field = value;
		JZYHkZsWiJ6(propertyName);
		return true;
	}

	protected static string MWWHkVY8Jg0(double P_0)
	{
		if (P_0 > 0.0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1306877528 ^ -1306867740);
		}
		if (P_0 < 0.0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--500511424 ^ 0x1DD554AA);
		}
		return null;
	}

	protected static string CvyHkCuX0cX(Side P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (P_0 != Side.Buy)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
					{
						num2 = 0;
					}
					break;
				}
				return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CD2959);
			default:
				if (P_0 == Side.Sell)
				{
					return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1AB79299 ^ 0x1AB7F4F3);
				}
				return null;
			}
		}
	}

	protected static string OVnHkrEwZ71(long P_0)
	{
		if (P_0 <= 0)
		{
			if (P_0 >= 0)
			{
				return (string)vQR1d7DxdSx1lIjQjZOl();
			}
			return Resources.PositionSideShort;
		}
		return Resources.PositionSideLong;
	}

	protected xRgq7gHkTVINiHGAKc0y()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static xRgq7gHkTVINiHGAKc0y()
	{
		ALoX9oDxgR8UvoewC16r();
	}

	internal static bool CThTWSDxj9HWueZjqaTA()
	{
		return cAK5aDDxcn7J6KfDOwZP == null;
	}

	internal static xRgq7gHkTVINiHGAKc0y hY71uZDxE1O6ShoougQW()
	{
		return cAK5aDDxcn7J6KfDOwZP;
	}

	internal static void rac3SiDxQSrGpOfKb7ns(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}

	internal static object vQR1d7DxdSx1lIjQjZOl()
	{
		return Resources.PositionSideFlat;
	}

	internal static void ALoX9oDxgR8UvoewC16r()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
