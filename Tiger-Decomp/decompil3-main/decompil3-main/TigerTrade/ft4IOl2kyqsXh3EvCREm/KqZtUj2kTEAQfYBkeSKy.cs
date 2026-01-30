using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Annotations;
using TigerTrade.Config.Common;
using TuAMtrl1Nd3XoZQQUXf0;
using yqMoTS2b51ljCloOExWZ;

namespace ft4IOl2kyqsXh3EvCREm;

[DataContract(Name = "DocSettingsBase", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Windows.Settings")]
internal abstract class KqZtUj2kTEAQfYBkeSKy : INotifyPropertyChanged
{
	private string TaJ21iKv1Na;

	[CompilerGenerated]
	private bool UGS21le588U;

	private int? sdF214h8g7R;

	[CompilerGenerated]
	private int PDh21DqhpX9;

	private bool uw121bqDEM8;

	[CompilerGenerated]
	private string BfX21NG1OI6;

	private double ccN21kM7cRm;

	private SAsgut2b1cjk7MEKAnCA BbX211kR7op;

	private SAsgut2b1cjk7MEKAnCA IxG215HQd9S;

	private SAsgut2b1cjk7MEKAnCA coF21S9Lndr;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static KqZtUj2kTEAQfYBkeSKy yWSRK44yFURgPS2AUsq4;

	[DataMember(Name = "WindowTitle")]
	public string vlP2kmioDGU
	{
		get
		{
			return TaJ21iKv1Na;
		}
		set
		{
			TaJ21iKv1Na = (string)(string.IsNullOrEmpty(text) ? JvGYkw4yuIPW0OCXnGix(this) : text);
		}
	}

	[DataMember(Name = "CustomTitle")]
	public bool zDi2k7CwL38
	{
		[CompilerGenerated]
		get
		{
			return UGS21le588U;
		}
		[CompilerGenerated]
		set
		{
			UGS21le588U = uGS21le588U;
		}
	}

	[DataMember(Name = "LinkGroupID_68")]
	public int? LinkGroupID
	{
		get
		{
			return sdF214h8g7R;
		}
		set
		{
			if (num != sdF214h8g7R)
			{
				sdF214h8g7R = num;
				if (num <= 26)
				{
					Tmc2kFdel17 = num.Value;
				}
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-338769610 ^ -338794940));
			}
		}
	}

	[DataMember(Name = "LinkGroupID")]
	public int Tmc2kFdel17
	{
		[CompilerGenerated]
		get
		{
			return PDh21DqhpX9;
		}
		[CompilerGenerated]
		set
		{
			PDh21DqhpX9 = pDh21DqhpX;
		}
	}

	[DataMember(Name = "LinkActiveWindow")]
	public bool LinkActiveWindow
	{
		get
		{
			return uw121bqDEM8;
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
				case 0:
					return;
				case 1:
					if (flag != uw121bqDEM8)
					{
						uw121bqDEM8 = flag;
						ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-90307782 ^ -90264394));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "SymbolID")]
	public string Qom210PQiuE
	{
		[CompilerGenerated]
		get
		{
			return BfX21NG1OI6;
		}
		[CompilerGenerated]
		set
		{
			BfX21NG1OI6 = bfX21NG1OI;
		}
	}

	public double LotStep
	{
		get
		{
			return ccN21kM7cRm;
		}
		set
		{
			ccN21kM7cRm = num;
			ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--134855371 ^ 0x809157B));
		}
	}

	[DataMember(Name = "AccountParam")]
	public SAsgut2b1cjk7MEKAnCA cK121ntjdg5
	{
		get
		{
			return BbX211kR7op ?? (BbX211kR7op = new SAsgut2b1cjk7MEKAnCA(null));
		}
		set
		{
			BbX211kR7op = bbX211kR7op;
		}
	}

	[DataMember(Name = "AccountSimParam")]
	public SAsgut2b1cjk7MEKAnCA rqW21oJvunS
	{
		get
		{
			return IxG215HQd9S ?? (IxG215HQd9S = new SAsgut2b1cjk7MEKAnCA(null));
		}
		set
		{
			IxG215HQd9S = ixG215HQd9S;
		}
	}

	[DataMember(Name = "AccountPlrParam")]
	public SAsgut2b1cjk7MEKAnCA gKB21aN69Gr
	{
		get
		{
			return coF21S9Lndr ?? (coF21S9Lndr = new SAsgut2b1cjk7MEKAnCA(null));
		}
		set
		{
			coF21S9Lndr = sAsgut2b1cjk7MEKAnCA;
		}
	}

	public abstract string DefaultTitle { get; }

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
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				}
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)kdlntP4ZHQxxXRnJIDa3(propertyChangedEventHandler2, propertyChangedEventHandler3);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
				{
					num2 = 0;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 2;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					break;
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				}
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	public string cWO2kZ9hC6O()
	{
		int num = 1;
		int num2 = num;
		AppTradeMode appTradeMode = default(AppTradeMode);
		while (true)
		{
			switch (num2)
			{
			default:
				return appTradeMode switch
				{
					AppTradeMode.Live => cK121ntjdg5.kOx2DhNaCjU(Qom210PQiuE, ""), 
					AppTradeMode.Simulator => rqW21oJvunS.kOx2DhNaCjU(Qom210PQiuE, ""), 
					AppTradeMode.Player => gKB21aN69Gr.kOx2DhNaCjU(Qom210PQiuE, ""), 
					_ => null, 
				};
			case 1:
				appTradeMode = j18iDj9nukSCmEyZs5lH.Settings.TradeMode;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Ddk2kVPVJWO(string P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				return;
			case 2:
				if (!jcLUlG4yzZbItQr69vSc(P_0))
				{
					switch (q4h8aO4Z2y6vBe1rUJLQ(ulyX7U4Z0bheA6cCtgAQ()))
					{
					case AppTradeMode.Live:
						cK121ntjdg5.wmb2bSyvnPW(Qom210PQiuE, P_0);
						return;
					case AppTradeMode.Player:
						gKB21aN69Gr.wmb2bSyvnPW(Qom210PQiuE, P_0);
						return;
					case AppTradeMode.Simulator:
						rqW21oJvunS.wmb2bSyvnPW(Qom210PQiuE, P_0);
						return;
					default:
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	protected KqZtUj2kTEAQfYBkeSKy()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				LinkGroupID = 0;
				Qom210PQiuE = "";
				return;
			}
			vlP2kmioDGU = "";
			zDi2k7CwL38 = false;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
			{
				num = 0;
			}
		}
	}

	[OnDeserialized]
	protected void CxO2kCP58dc(StreamingContext P_0)
	{
		int num = 1;
		int num2 = num;
		int? num3 = default(int?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = LinkGroupID;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!num3.HasValue)
				{
					LinkGroupID = Tmc2kFdel17;
				}
				return;
			}
		}
	}

	[NotifyPropertyChangedInvocator]
	protected virtual void ifWlfmRSlkr([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	static KqZtUj2kTEAQfYBkeSKy()
	{
		Ptrf3Y4ZfM7ARh2BNZuT();
	}

	internal static object JvGYkw4yuIPW0OCXnGix(object P_0)
	{
		return ((KqZtUj2kTEAQfYBkeSKy)P_0).DefaultTitle;
	}

	internal static bool wIQlqi4y3BYa0ljSIRr2()
	{
		return yWSRK44yFURgPS2AUsq4 == null;
	}

	internal static KqZtUj2kTEAQfYBkeSKy C4v2H74ypaoLQpiPO9Ue()
	{
		return yWSRK44yFURgPS2AUsq4;
	}

	internal static bool jcLUlG4yzZbItQr69vSc(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object ulyX7U4Z0bheA6cCtgAQ()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static AppTradeMode q4h8aO4Z2y6vBe1rUJLQ(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).TradeMode;
	}

	internal static object kdlntP4ZHQxxXRnJIDa3(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static void Ptrf3Y4ZfM7ARh2BNZuT()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
