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

namespace kHAs2cfl7hDVW64jByhf;

[DataContract(Name = "MarketSettingsBase", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Market.Settings")]
internal abstract class wNkTg8flwnoQb0vtSgf4 : INotifyPropertyChanged, IDynamicProperty, ICloneable
{
	[CompilerGenerated]
	private string mb3f408be7T;

	[CompilerGenerated]
	private string Yupf42KwGbw;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static wNkTg8flwnoQb0vtSgf4 XO4KO7DmIIRHv0mcWJTY;

	[Browsable(false)]
	protected string Ba1fl3DsTPU
	{
		[CompilerGenerated]
		get
		{
			return mb3f408be7T;
		}
		[CompilerGenerated]
		set
		{
			mb3f408be7T = text;
		}
	}

	[Browsable(false)]
	protected string OURflzaw42X
	{
		[CompilerGenerated]
		get
		{
			return Yupf42KwGbw;
		}
		[CompilerGenerated]
		set
		{
			Yupf42KwGbw = yupf42KwGbw;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
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
					value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					goto default;
				case 1:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
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
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
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
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	protected virtual void Wfpl9gyO7In()
	{
	}

	protected virtual void Piql9R7MF1M()
	{
	}

	[OnDeserializing]
	private void LKtfl8Vvbyi(StreamingContext P_0)
	{
		q4jj28DmUW8ZyJnWc2sq(this);
	}

	[OnDeserialized]
	private void orLflAnKm0k(StreamingContext P_0)
	{
		Piql9R7MF1M();
	}

	[NotifyPropertyChangedInvocator]
	protected void aETflPO46K0([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			YHSEMXDmTCFFRS2SIgc3(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
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

	public virtual string GetSymbolId()
	{
		return Ba1fl3DsTPU;
	}

	public virtual object Clone()
	{
		return MemberwiseClone();
	}

	protected wNkTg8flwnoQb0vtSgf4()
	{
		aRNdmADmypX22dLg7K8h();
		base._002Ector();
	}

	static wNkTg8flwnoQb0vtSgf4()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool Fg4NX9DmW0shvcdvv2hw()
	{
		return XO4KO7DmIIRHv0mcWJTY == null;
	}

	internal static wNkTg8flwnoQb0vtSgf4 litGQPDmtOdDlbCg5oYP()
	{
		return XO4KO7DmIIRHv0mcWJTY;
	}

	internal static void q4jj28DmUW8ZyJnWc2sq(object P_0)
	{
		((wNkTg8flwnoQb0vtSgf4)P_0).Wfpl9gyO7In();
	}

	internal static void YHSEMXDmTCFFRS2SIgc3(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}

	internal static void aRNdmADmypX22dLg7K8h()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
