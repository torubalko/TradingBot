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

namespace O4MOGg9s9Mb8ki42CBMv;

[DataContract(Name = "ChartSettingsBase", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Settings")]
internal abstract class VUcpcX9sfGdSlTmYZQvV : INotifyPropertyChanged, IDynamicProperty, ICloneable
{
	[CompilerGenerated]
	private string CZ69s4jpmRI;

	[CompilerGenerated]
	private string Erg9sD2SRq4;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static VUcpcX9sfGdSlTmYZQvV XSjqp2bc2YVH6ujOLrcX;

	[Browsable(false)]
	protected string RYc9sBOlPSU
	{
		[CompilerGenerated]
		get
		{
			return CZ69s4jpmRI;
		}
		[CompilerGenerated]
		set
		{
			CZ69s4jpmRI = cZ69s4jpmRI;
		}
	}

	[Browsable(false)]
	protected string d8J9slSlLBq
	{
		[CompilerGenerated]
		get
		{
			return Erg9sD2SRq4;
		}
		[CompilerGenerated]
		set
		{
			Erg9sD2SRq4 = erg9sD2SRq;
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
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
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
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
					{
						num = 1;
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
			while (true)
			{
				switch (num2)
				{
				default:
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
					{
						num2 = 2;
					}
					break;
				}
				case 1:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					goto default;
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
	private void XM49snBGbyC(StreamingContext P_0)
	{
		Wfpl9gyO7In();
	}

	[OnDeserialized]
	private void yM79sG53e4L(StreamingContext P_0)
	{
		Piql9R7MF1M();
	}

	[NotifyPropertyChangedInvocator]
	protected void sQM9sYVV4VP([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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

	public virtual object Clone()
	{
		return MemberwiseClone();
	}

	protected VUcpcX9sfGdSlTmYZQvV()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static VUcpcX9sfGdSlTmYZQvV()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool JdT4l4bcH8kbO7mw6yEL()
	{
		return XSjqp2bc2YVH6ujOLrcX == null;
	}

	internal static VUcpcX9sfGdSlTmYZQvV GIEwCfbcfk96eHWHlFfG()
	{
		return XSjqp2bc2YVH6ujOLrcX;
	}
}
