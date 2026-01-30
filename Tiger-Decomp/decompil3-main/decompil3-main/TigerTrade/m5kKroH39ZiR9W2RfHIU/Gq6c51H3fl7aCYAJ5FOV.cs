using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using MIA3eC2ZXsuRyAB0mjn;
using TiCeIH2IsQBNx4GCkaT;
using TigerTrade.Annotations;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace m5kKroH39ZiR9W2RfHIU;

[ReadOnly(true)]
[TypeConverter(typeof(ExpandableObjectConverter))]
[DataContract(Name = "GroupPortfolioItem", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config.Trust")]
internal sealed class Gq6c51H3fl7aCYAJ5FOV : INotifyPropertyChanged, ICloneable
{
	private string wtRH3BHdptU;

	private decimal LjxH3a1BD6J;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static Gq6c51H3fl7aCYAJ5FOV NvTheaDZLJstcckUwDUC;

	[bBo0Zd2ycQQr3LNHQf4("GroupPortfolioItemAccount")]
	[NotifyParentProperty(true)]
	[T4IXj62qBfXCaxs2RI5("GroupPortfolioItemParameters")]
	[DataMember(Name = "Account")]
	public string Account
	{
		get
		{
			return wtRH3BHdptU;
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
					if (wtRH3BHdptU == text)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
						{
							num2 = 0;
						}
						break;
					}
					wtRH3BHdptU = text ?? "";
					BnGH3nIZAqO(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x34407BB ^ 0x3441BB5));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "Weight")]
	[T4IXj62qBfXCaxs2RI5("GroupPortfolioItemParameters")]
	[bBo0Zd2ycQQr3LNHQf4("GroupPortfolioItemWeight")]
	[NotifyParentProperty(true)]
	public decimal Weight
	{
		get
		{
			return LjxH3a1BD6J;
		}
		set
		{
			num = QMYpw6DZXHootC4SYplk(0m, num);
			if (!LYCGZaDZcunX47PpstAC(LjxH3a1BD6J, num))
			{
				LjxH3a1BD6J = num;
				BnGH3nIZAqO(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-45476899 ^ -45488771));
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		}
	}

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
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
					{
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)T1FsNnDZdWUCcQpo13ri(propertyChangedEventHandler2, propertyChangedEventHandler3);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
						{
							num = 0;
						}
						continue;
					}
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
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						break;
					default:
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
						{
							num = 1;
						}
						continue;
					}
					break;
				}
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public override string ToString()
	{
		if (WSKcKMDZjDjIx8nHxig3(Account))
		{
			return "";
		}
		string text = ((Account)LlVGWGDZEJ6BCL92cWlf(Account))?.Name;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => (string)vKxfajDZQpXPZltRLAQX(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-3429745 ^ -3414329), text, Weight), 
		};
	}

	public object Clone()
	{
		return MemberwiseClone();
	}

	[NotifyPropertyChangedInvocator]
	private void BnGH3nIZAqO([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			lq4TcJDZgl1FXyEmoN7b(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	public Gq6c51H3fl7aCYAJ5FOV()
	{
		NVIuhrDZRXqHufnLAPeM();
		base._002Ector();
	}

	static Gq6c51H3fl7aCYAJ5FOV()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool N5aSDbDZefaJfUIuw0Gc()
	{
		return NvTheaDZLJstcckUwDUC == null;
	}

	internal static Gq6c51H3fl7aCYAJ5FOV jieWDYDZs6tAwi7S3wlB()
	{
		return NvTheaDZLJstcckUwDUC;
	}

	internal static decimal QMYpw6DZXHootC4SYplk(decimal P_0, decimal P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool LYCGZaDZcunX47PpstAC(decimal P_0, decimal P_1)
	{
		return P_0 == P_1;
	}

	internal static bool WSKcKMDZjDjIx8nHxig3(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object LlVGWGDZEJ6BCL92cWlf(object P_0)
	{
		return DataManager.GetAccount((string)P_0);
	}

	internal static object vKxfajDZQpXPZltRLAQX(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object T1FsNnDZdWUCcQpo13ri(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static void lq4TcJDZgl1FXyEmoN7b(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}

	internal static void NVIuhrDZRXqHufnLAPeM()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
