using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using BfZtb759KlUg4482QKym;
using EBwZqeajkUULymgLZ6pW;
using jhuDCPG8d8bbdl4R91vn;
using K1GcsD5GTtMSlaiJI0Xh;
using p9D0WNaxgVP5IJuowluK;
using r8oOHiajFPNBXu6XiAHj;
using TigerTrade.Tc.Annotations;
using TigerTrade.Tc.Properties;
using x97CE55GhEYKgt7TSVZT;

namespace OhwR2LaxHYJ0lj0C9GSK;

[DataContract(Name = "ProxyData", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Tc.Config")]
public class qXLXHlax25yCgG9femcG : INotifyPropertyChanged
{
	[CompilerGenerated]
	private string dyiax1EWu2V;

	[CompilerGenerated]
	private string DMNax5CFNab;

	[CompilerGenerated]
	private string ftgaxSMWbx5;

	[CompilerGenerated]
	private string vJuaxxFqBVC;

	[CompilerGenerated]
	private string qBoaxLVwD0i;

	[CompilerGenerated]
	private int Jutaxe6lPCH;

	public static readonly qXLXHlax25yCgG9femcG jVxaxscCLFW;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static qXLXHlax25yCgG9femcG oOdNgAxKQfOCvtrwbNv1;

	[DataMember(Name = "Id")]
	public string Id
	{
		[CompilerGenerated]
		get
		{
			return dyiax1EWu2V;
		}
		[CompilerGenerated]
		set
		{
			dyiax1EWu2V = text;
		}
	}

	[DataMember(Name = "Name")]
	public string Name
	{
		[CompilerGenerated]
		get
		{
			return DMNax5CFNab;
		}
		[CompilerGenerated]
		set
		{
			DMNax5CFNab = dMNax5CFNab;
		}
	}

	[DataMember(Name = "Address")]
	public string Address
	{
		[CompilerGenerated]
		get
		{
			return ftgaxSMWbx5;
		}
		[CompilerGenerated]
		set
		{
			ftgaxSMWbx5 = text;
		}
	}

	[DataMember(Name = "Login")]
	public string Login
	{
		[CompilerGenerated]
		get
		{
			return vJuaxxFqBVC;
		}
		[CompilerGenerated]
		set
		{
			vJuaxxFqBVC = text;
		}
	}

	[DataMember(Name = "Password")]
	public string dbDax4GhDGP
	{
		[CompilerGenerated]
		get
		{
			return qBoaxLVwD0i;
		}
		[CompilerGenerated]
		set
		{
			qBoaxLVwD0i = text;
		}
	}

	[DataMember(Name = "Order")]
	public int Order
	{
		[CompilerGenerated]
		get
		{
			return Jutaxe6lPCH;
		}
		[CompilerGenerated]
		set
		{
			Jutaxe6lPCH = jutaxe6lPCH;
		}
	}

	public string Password
	{
		get
		{
			return bKiVl7ajN7b8mPCIOURL.GcUajSSfECS(dbDax4GhDGP);
		}
		set
		{
			dbDax4GhDGP = (string)hvUxhnxKRkfjMMwAyQmC(text);
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
				int num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						break;
					case 0:
						return;
					}
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
					{
						num = 0;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 2;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
				{
					PropertyChangedEventHandler propertyChangedEventHandler2;
					do
					{
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					}
					while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 0:
					return;
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	internal static qXLXHlax25yCgG9femcG FcJaxf0QrAV(gpnr5oG8Q1cRMmiYT0Ut P_0)
	{
		C3trUsajJIHJMtdo9pBg c3trUsajJIHJMtdo9pBg = (C3trUsajJIHJMtdo9pBg)((P_0 != null) ? BjUET9xK6MFR6X7GesHa(P_0) : null);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			if (c3trUsajJIHJMtdo9pBg != null)
			{
				return rwlc60axdATOINfnxFFP.JYhaxV3KmOl().O6CaxthB4xR(c3trUsajJIHJMtdo9pBg.Id);
			}
			return null;
		}
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void ifWlfmRSlkr([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public qXLXHlax25yCgG9femcG()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static qXLXHlax25yCgG9femcG()
	{
		fayL1cxKMYhbMOBbCWNP();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		BrsHq0xKOhZjQYQS43Xx();
		qXLXHlax25yCgG9femcG obj = new qXLXHlax25yCgG9femcG();
		ar7ntoxKq5ot6QbiH9Lw(obj, default(Guid).ToString());
		LyigBgxKIuWTTETaj1GX(obj, string.Empty);
		obj.Name = Resources.ConnectionsWindowNoProxyElementTitle;
		jVxaxscCLFW = obj;
	}

	internal static bool usQ2WAxKd18vB83YgOha()
	{
		return oOdNgAxKQfOCvtrwbNv1 == null;
	}

	internal static qXLXHlax25yCgG9femcG tPtJKtxKgLD3V0pRyCCc()
	{
		return oOdNgAxKQfOCvtrwbNv1;
	}

	internal static object hvUxhnxKRkfjMMwAyQmC(object P_0)
	{
		return bKiVl7ajN7b8mPCIOURL.I1Uaj5WJ3yL((string)P_0);
	}

	internal static object BjUET9xK6MFR6X7GesHa(object P_0)
	{
		return ((gpnr5oG8Q1cRMmiYT0Ut)P_0).j6RloBnORGD();
	}

	internal static void fayL1cxKMYhbMOBbCWNP()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void BrsHq0xKOhZjQYQS43Xx()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void ar7ntoxKq5ot6QbiH9Lw(object P_0, object P_1)
	{
		((qXLXHlax25yCgG9femcG)P_0).Id = (string)P_1;
	}

	internal static void LyigBgxKIuWTTETaj1GX(object P_0, object P_1)
	{
		((qXLXHlax25yCgG9femcG)P_0).Address = (string)P_1;
	}
}
