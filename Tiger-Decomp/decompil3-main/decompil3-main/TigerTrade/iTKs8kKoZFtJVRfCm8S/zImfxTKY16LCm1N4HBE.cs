using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Annotations;
using TigerTrade.Core.UI.Common;
using TuAMtrl1Nd3XoZQQUXf0;

namespace iTKs8kKoZFtJVRfCm8S;

[DataContract(Name = "SmartTapeSettingsBase", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.SmartTape.Settings")]
internal abstract class zImfxTKY16LCm1N4HBE : INotifyPropertyChanged, IDynamicProperty
{
	[CompilerGenerated]
	private string wMuKl5jwEj;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static zImfxTKY16LCm1N4HBE IAcDP84N1kKhLMTxOl4h;

	[Browsable(false)]
	public string E2PKiCBBGy
	{
		[CompilerGenerated]
		get
		{
			return wMuKl5jwEj;
		}
		[CompilerGenerated]
		set
		{
			wMuKl5jwEj = text;
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
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
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
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
					{
						num = 1;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			PropertyChangedEventHandler value2 = default(PropertyChangedEventHandler);
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				}
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	[NotifyPropertyChangedInvocator]
	protected void GgMKvYwS7c([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			OsrM1C4NxHdKtqEedGRG(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	public virtual bool GetPropertyVisibility(string P_0)
	{
		return true;
	}

	public virtual bool GetPropertyHasStandardValues(string P_0)
	{
		return false;
	}

	public virtual bool GetPropertyReadOnly(string P_0)
	{
		return false;
	}

	public virtual IEnumerable<object> GetPropertyStandardValues(string P_0)
	{
		return null;
	}

	protected zImfxTKY16LCm1N4HBE()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static zImfxTKY16LCm1N4HBE()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool scZBf64N5Xa0lw9b7oGm()
	{
		return IAcDP84N1kKhLMTxOl4h == null;
	}

	internal static zImfxTKY16LCm1N4HBE eX1wJO4NSjAPoy0QA7l5()
	{
		return IAcDP84N1kKhLMTxOl4h;
	}

	internal static void OsrM1C4NxHdKtqEedGRG(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}
}
