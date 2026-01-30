using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Annotations;
using x97CE55GhEYKgt7TSVZT;
using xtKZMnaLHhXNCotZhjGh;

namespace mG7ZbBaeTKns1XlK1xAT;

internal class gZE1IoaeUYyr4B5hitju : INotifyPropertyChanged
{
	[CompilerGenerated]
	private readonly int hl9aeKlK4rB;

	[CompilerGenerated]
	private readonly Brush hNgaemS8uwj;

	private bool P0jaehXZh9H;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static gZE1IoaeUYyr4B5hitju hTG6SuxmE1UkxTcwCiae;

	public int Id
	{
		[CompilerGenerated]
		get
		{
			return hl9aeKlK4rB;
		}
	}

	public Brush ColorBrush
	{
		[CompilerGenerated]
		get
		{
			return hNgaemS8uwj;
		}
	}

	public bool IsSelected
	{
		get
		{
			return P0jaehXZh9H;
		}
		set
		{
			SetProperty(ref P0jaehXZh9H, value2, (string)IRL2Bpxmg3OjhovXPPHS(-1763895751 ^ -1763902537));
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			while (true)
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				int num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf == 0)
				{
					num = 1;
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
						break;
					}
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
					{
						num = 0;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 1;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler value2 = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					goto default;
				}
			}
		}
	}

	public gZE1IoaeUYyr4B5hitju(int P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		hl9aeKlK4rB = P_0;
		hNgaemS8uwj = u8myvQaL2lirBxlZIa7k.uJmaLfsMTvY(P_0);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[NotifyPropertyChangedInvocator]
	protected void SWpaeyqj0ac([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			BA4DT7xmRdOv1KceuXjO(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
	{
		if (string.IsNullOrEmpty(propertyName))
		{
			throw new ArgumentException(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x5EA8FF2A ^ 0x5EA9128C), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x684F243E ^ 0x684ECA32));
		}
		if (EqualityComparer<T>.Default.Equals(field, value))
		{
			return false;
		}
		field = value;
		SWpaeyqj0ac(propertyName);
		return true;
	}

	static gZE1IoaeUYyr4B5hitju()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		eCJVE5xm6cFZ0H6F5oWb();
	}

	internal static bool DHsgZVxmQjKjUxjR2CcZ()
	{
		return hTG6SuxmE1UkxTcwCiae == null;
	}

	internal static gZE1IoaeUYyr4B5hitju gRBPXexmdSitbm4WTYaX()
	{
		return hTG6SuxmE1UkxTcwCiae;
	}

	internal static object IRL2Bpxmg3OjhovXPPHS(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static void BA4DT7xmRdOv1KceuXjO(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}

	internal static void eCJVE5xm6cFZ0H6F5oWb()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
