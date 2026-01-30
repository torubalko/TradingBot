using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using CCdXCfHSgQc7h5yAmOdL;
using ECOEgqlSad8NUJZ2Dr9n;
using m5kKroH39ZiR9W2RfHIU;
using MIA3eC2ZXsuRyAB0mjn;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Annotations;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace lj4T8ZHF7x3Bq5iQiaUo;

[DataContract(Name = "GroupPortfolio", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.Trust")]
internal sealed class bPlY5UHFwpoioxZbeXFB : INotifyPropertyChanged, ICloneable
{
	[CompilerGenerated]
	private string JgAH30mAVJn;

	private string LgFH32WC15l;

	private List<Gq6c51H3fl7aCYAJ5FOV> omHH3HpOoOb;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static bPlY5UHFwpoioxZbeXFB tbVIYkDZlW8r2NXajWmM;

	[DataMember(Name = "ID")]
	[Browsable(false)]
	public string L4uHFJO69K1
	{
		[CompilerGenerated]
		get
		{
			return JgAH30mAVJn;
		}
		[CompilerGenerated]
		set
		{
			JgAH30mAVJn = jgAH30mAVJn;
		}
	}

	[Browsable(false)]
	public string FullName
	{
		get
		{
			if (K3RMVJDZbhwaQPEiryKs(Name))
			{
				return Resources.GroupPortfolioNewTitle;
			}
			return Name;
		}
	}

	[DataMember(Name = "Name")]
	[bBo0Zd2ycQQr3LNHQf4("GroupPortfolioName")]
	[T4IXj62qBfXCaxs2RI5("GroupPortfolioParameters")]
	public string Name
	{
		get
		{
			return LgFH32WC15l;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (bK8F3kDZN4hB5gfYUfSn(text, LgFH32WC15l))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 != 0)
						{
							num2 = 0;
						}
						break;
					}
					LgFH32WC15l = text ?? "";
					d6uHF8wnnvw(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461292091 ^ -1461314651));
					d6uHF8wnnvw((string)tmZ4MADZk7oQSLkZLYuI(0x1A5F1B9E ^ 0x1A5E16B6));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[T4IXj62qBfXCaxs2RI5("GroupPortfolioParameters")]
	[bBo0Zd2ycQQr3LNHQf4("GroupPortfolioPortfolios")]
	[TypeConverter(typeof(jQ2GTsHSde7tbnyxJTLc))]
	[DataMember(Name = "Portfolios")]
	public List<Gq6c51H3fl7aCYAJ5FOV> Portfolios
	{
		get
		{
			return omHH3HpOoOb ?? (omHH3HpOoOb = new List<Gq6c51H3fl7aCYAJ5FOV>());
		}
		set
		{
			if (omHH3HpOoOb != list)
			{
				omHH3HpOoOb = list;
				d6uHF8wnnvw(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-29702950 ^ -29805998));
			}
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
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
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
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
					{
						num = 0;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)aRoxGADZ5IOL38wvrHyO(propertyChangedEventHandler2, propertyChangedEventHandler3);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
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
	}

	public bPlY5UHFwpoioxZbeXFB()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		L4uHFJO69K1 = Guid.NewGuid().ToString();
	}

	public object Clone()
	{
		return yQOBnfDZ19SRU3u9jk8W(this);
	}

	[NotifyPropertyChangedInvocator]
	private void d6uHF8wnnvw([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			z8ju6IDZS0L7hB33QxZA(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	static bPlY5UHFwpoioxZbeXFB()
	{
		aXZoDWDZx7YdO6qEtJAc();
	}

	internal static bool Sp60lvDZ4bhl7mweRAmM()
	{
		return tbVIYkDZlW8r2NXajWmM == null;
	}

	internal static bPlY5UHFwpoioxZbeXFB PbVbp7DZDOImDWH4rRmg()
	{
		return tbVIYkDZlW8r2NXajWmM;
	}

	internal static bool K3RMVJDZbhwaQPEiryKs(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool bK8F3kDZN4hB5gfYUfSn(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object tmZ4MADZk7oQSLkZLYuI(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object yQOBnfDZ19SRU3u9jk8W(object P_0)
	{
		return P_0.MemberwiseClone();
	}

	internal static object aRoxGADZ5IOL38wvrHyO(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static void z8ju6IDZS0L7hB33QxZA(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}

	internal static void aXZoDWDZx7YdO6qEtJAc()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
