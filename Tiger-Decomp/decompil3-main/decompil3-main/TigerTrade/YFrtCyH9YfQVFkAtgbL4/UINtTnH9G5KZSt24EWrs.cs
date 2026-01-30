using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using jKxkD8HfxfM8pAInciSU;
using TigerTrade.Annotations;
using TigerTrade.Properties;
using TigerTrade.UI.Controls.Toolbar;
using TuAMtrl1Nd3XoZQQUXf0;

namespace YFrtCyH9YfQVFkAtgbL4;

[DataContract(Name = "XToolbar", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.UI.Controls.Toolbar")]
internal class UINtTnH9G5KZSt24EWrs : INotifyPropertyChanged
{
	private string wYOH9bXExfD;

	private XToolbarPosition E7mH9NPKdWT;

	private List<string> vWoH9kFP7aF;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private static UINtTnH9G5KZSt24EWrs bo23qdD4K5nbjlJw6D69;

	public string FullName
	{
		get
		{
			if (!y9LF19D4wpVB5JL6J5A6(Title))
			{
				return Title + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-673683647 ^ -673645451) + FY07xYHfSCiM5E3465o7.suYHfE4hBHG(Position.ToString()) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D31AFF5);
			}
			return Resources.ToolbarNewToolbar;
		}
	}

	[DataMember(Name = "Title")]
	public string Title
	{
		get
		{
			return wYOH9bXExfD;
		}
		set
		{
			if (!(text == wYOH9bXExfD))
			{
				wYOH9bXExfD = text;
				AA3H9oiRgD1((string)SotWiRD475kAGuTLXAPT(-1251569705 ^ -1251553719));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				AA3H9oiRgD1((string)SotWiRD475kAGuTLXAPT(0x6EC99CAF ^ 0x6EC89187));
			}
		}
	}

	[DataMember(Name = "Position")]
	public XToolbarPosition Position
	{
		get
		{
			return E7mH9NPKdWT;
		}
		set
		{
			if (xToolbarPosition != E7mH9NPKdWT)
			{
				E7mH9NPKdWT = xToolbarPosition;
				AA3H9oiRgD1(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1416986301 ^ -1416987329));
				AA3H9oiRgD1(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-57768881 ^ -57702041));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
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
	}

	[DataMember(Name = "Items")]
	public List<string> Items
	{
		get
		{
			return vWoH9kFP7aF ?? (vWoH9kFP7aF = new List<string>());
		}
		set
		{
			vWoH9kFP7aF = list;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
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
				case 0:
					return;
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				}
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
				{
					num2 = 0;
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
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
						{
							num = 0;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public override string ToString()
	{
		return FullName;
	}

	[NotifyPropertyChangedInvocator]
	private void AA3H9oiRgD1([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public UINtTnH9G5KZSt24EWrs()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static UINtTnH9G5KZSt24EWrs()
	{
		O3dev1D48leBrapLO1yv();
	}

	internal static bool y9LF19D4wpVB5JL6J5A6(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool ClxPW2D4mIPAtBw9WWpC()
	{
		return bo23qdD4K5nbjlJw6D69 == null;
	}

	internal static UINtTnH9G5KZSt24EWrs wO2Wr2D4hus8lEFhJnx7()
	{
		return bo23qdD4K5nbjlJw6D69;
	}

	internal static object SotWiRD475kAGuTLXAPT(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void O3dev1D48leBrapLO1yv()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
