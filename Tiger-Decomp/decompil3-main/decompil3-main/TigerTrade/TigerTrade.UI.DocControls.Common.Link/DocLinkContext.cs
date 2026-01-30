using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using b7SHZp24T2db2cd8KRFM;
using ECOEgqlSad8NUJZ2Dr9n;
using mBOuwh2x7WYCRTWvJexc;
using TigerTrade.Annotations;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TigerTrade.UI.Common;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.DocControls.Common.Link;

public sealed class DocLinkContext : INotifyPropertyChanged
{
	[CompilerGenerated]
	private sealed class grrNgHn6U1rd1jEYeWn6
	{
		public DocLinkContext Sqon6ZejckR;

		public string sC8n6V6nIT8;

		internal static grrNgHn6U1rd1jEYeWn6 i8d9LaNbqlF7n3r8ZfNt;

		public grrNgHn6U1rd1jEYeWn6()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void w62n6TCq6eQ(object o)
		{
			Sqon6ZejckR.IsExchangeLocked = false;
			Sqon6ZejckR.LockedExchange = null;
		}

		internal void jwMn6yAnnjB(object o)
		{
			Sqon6ZejckR.LockedExchange = sC8n6V6nIT8;
			Sqon6ZejckR.IsExchangeLocked = true;
		}

		static grrNgHn6U1rd1jEYeWn6()
		{
			TnOyOwNbttW7NXyeJRE4();
		}

		internal static bool vSk3n9NbIvRGuN515Ov2()
		{
			return i8d9LaNbqlF7n3r8ZfNt == null;
		}

		internal static grrNgHn6U1rd1jEYeWn6 mq8HNbNbWF6f5S9DFaBE()
		{
			return i8d9LaNbqlF7n3r8ZfNt;
		}

		internal static void TnOyOwNbttW7NXyeJRE4()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	private Brush w442sCe39RC;

	private bool veh2sr6T1YR;

	private int WTu2sK3KVnb;

	private bool uHt2smu7U58;

	private ICommand ILW2shZj88D;

	private ICommand FTr2swvqWjb;

	[CompilerGenerated]
	private ICommand uDy2s7ncaR6;

	[CompilerGenerated]
	private ICommand lKB2s8GZw3K;

	[CompilerGenerated]
	private ICommand uqu2sAlk2hy;

	[CompilerGenerated]
	private ICommand NKu2sPQO2mn;

	[CompilerGenerated]
	private ICommand ixI2sJG55Qh;

	private bool tA02sFhRBD9;

	private bool TCq2s3U6L54;

	private Brush rRO2sphedQq;

	private bool qGV2suQwJIx;

	private bool v1P2szR6ioU;

	private bool twN2X0dZHig;

	private ErrorType ieO2X2oUjdh;

	private string f5V2XHd6K6X;

	private string Eyo2Xf9i9tc;

	private string NVW2X9rXnM4;

	private SymbolType VHP2Xnrd5HF;

	private string j2X2XGUOsIl;

	private string uSI2XYa7WSa;

	private bool M4x2XopX8Fd;

	private bool byb2XvTh8SX;

	private string LOj2XBIBD5G;

	private UIElement YMm2XaeLC1A;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static DocLinkContext HxAfeV4rn7d0wji7qSKb;

	public Brush LedBrush
	{
		get
		{
			return w442sCe39RC;
		}
		set
		{
			if (!OHtIXW4roahEJ9AQK7ED(brush, w442sCe39RC))
			{
				w442sCe39RC = brush;
				n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-176525661 ^ -176498127));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
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

	public bool LinkActiveWindow
	{
		get
		{
			return veh2sr6T1YR;
		}
		set
		{
			if (!object.Equals(flag, veh2sr6T1YR))
			{
				veh2sr6T1YR = flag;
				n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2C8374E4 ^ 0x2C83DB68));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae != 0)
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

	public int GroupId
	{
		get
		{
			return WTu2sK3KVnb;
		}
		set
		{
			if (!OHtIXW4roahEJ9AQK7ED(num, WTu2sK3KVnb))
			{
				WTu2sK3KVnb = num;
				n9h2eJvUA1f((string)SePI874rvw7LY9FGrsVk(-2108526692 ^ -2108553262));
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
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

	public bool LinkMarketLevels
	{
		get
		{
			return false;
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
					if (flag == uHt2smu7U58)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
						{
							num2 = 0;
						}
						break;
					}
					uHt2smu7U58 = flag;
					n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-5977659 ^ -5997159));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public ICommand CloseCommand
	{
		[CompilerGenerated]
		get
		{
			return uDy2s7ncaR6;
		}
		[CompilerGenerated]
		set
		{
			uDy2s7ncaR6 = command;
		}
	}

	public ICommand MenuCommand
	{
		[CompilerGenerated]
		get
		{
			return lKB2s8GZw3K;
		}
		[CompilerGenerated]
		set
		{
			lKB2s8GZw3K = command;
		}
	}

	public ICommand SwitchMarketCommand
	{
		[CompilerGenerated]
		get
		{
			return uqu2sAlk2hy;
		}
		[CompilerGenerated]
		set
		{
			uqu2sAlk2hy = command;
		}
	}

	public ICommand LinkNewMarketCommand
	{
		[CompilerGenerated]
		get
		{
			return NKu2sPQO2mn;
		}
		[CompilerGenerated]
		set
		{
			NKu2sPQO2mn = nKu2sPQO2mn;
		}
	}

	public ICommand KeepOldMarketCommand
	{
		[CompilerGenerated]
		get
		{
			return ixI2sJG55Qh;
		}
		[CompilerGenerated]
		set
		{
			ixI2sJG55Qh = command;
		}
	}

	public bool IsSwitchEnabled
	{
		get
		{
			return tA02sFhRBD9;
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
					tA02sFhRBD9 = flag;
					n9h2eJvUA1f((string)SePI874rvw7LY9FGrsVk(-1311293279 ^ -1311247353));
					return;
				case 1:
					if (tA02sFhRBD9 == flag)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsAccountEnabled
	{
		get
		{
			return TCq2s3U6L54;
		}
		set
		{
			TCq2s3U6L54 = tCq2s3U6L;
			n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1583344314 ^ -1583308402));
		}
	}

	public Brush ConnectionLedBrush
	{
		get
		{
			return rRO2sphedQq;
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
					if (rRO2sphedQq == brush)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
						{
							num2 = 0;
						}
						break;
					}
					rRO2sphedQq = brush;
					n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--927068468 ^ 0x374145D8));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public bool IsError
	{
		get
		{
			return qGV2suQwJIx;
		}
		set
		{
			if (qGV2suQwJIx != flag)
			{
				qGV2suQwJIx = flag;
				n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842019221));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
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

	public bool NoSwitchPair
	{
		get
		{
			return v1P2szR6ioU;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (v1P2szR6ioU == flag)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					v1P2szR6ioU = flag;
					n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-82860344 ^ -82897938));
					return;
				}
			}
		}
	}

	public bool ShowError
	{
		get
		{
			return twN2X0dZHig;
		}
		set
		{
			if (twN2X0dZHig != flag)
			{
				twN2X0dZHig = flag;
				n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F55E538 ^ 0x7F55507A));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
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

	public ErrorType ErrorType
	{
		get
		{
			return ieO2X2oUjdh;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (ieO2X2oUjdh != errorType)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				default:
					ieO2X2oUjdh = errorType;
					n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1774602229 ^ -1774645933));
					return;
				}
			}
		}
	}

	public string ErrorMessage
	{
		get
		{
			return f5V2XHd6K6X;
		}
		set
		{
			if (f5V2XHd6K6X != text)
			{
				f5V2XHd6K6X = text;
				n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x22BF43FC ^ 0x22BFF692));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
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

	public string ErrorLinkNewMarketLabel
	{
		get
		{
			return Eyo2Xf9i9tc;
		}
		set
		{
			if (Eyo2Xf9i9tc != text)
			{
				Eyo2Xf9i9tc = text;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-57768881 ^ -57790011));
			}
		}
	}

	public string ErrorKeepOldMarket
	{
		get
		{
			return NVW2X9rXnM4;
		}
		set
		{
			if (NVW2X9rXnM4 != text)
			{
				NVW2X9rXnM4 = text;
				n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-198991962 ^ -199022054));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
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

	public SymbolType SymbolType
	{
		get
		{
			return VHP2Xnrd5HF;
		}
		set
		{
			if (VHP2Xnrd5HF != symbolType)
			{
				VHP2Xnrd5HF = symbolType;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1999650146 ^ -1999654294));
			}
		}
	}

	public string LinkNewMarketLabel
	{
		get
		{
			return j2X2XGUOsIl;
		}
		set
		{
			if (j2X2XGUOsIl != text)
			{
				j2X2XGUOsIl = text;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				n9h2eJvUA1f((string)SePI874rvw7LY9FGrsVk(0x7ADBF691 ^ 0x7ADB4375));
			}
		}
	}

	public string KeepOldMarketLabel
	{
		get
		{
			return uSI2XYa7WSa;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (uSI2XYa7WSa != text)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				default:
					uSI2XYa7WSa = text;
					n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-5977659 ^ -5996599));
					return;
				}
			}
		}
	}

	public bool IsMarketLocked
	{
		get
		{
			return M4x2XopX8Fd;
		}
		set
		{
			if (M4x2XopX8Fd != flag)
			{
				M4x2XopX8Fd = flag;
				n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--500511424 ^ 0x1DD543CC));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
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

	public bool IsExchangeLocked
	{
		get
		{
			return byb2XvTh8SX;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (byb2XvTh8SX != flag)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				default:
					byb2XvTh8SX = flag;
					n9h2eJvUA1f(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1606927328 ^ -1606893594));
					return;
				}
			}
		}
	}

	public string LockedExchange
	{
		get
		{
			return LOj2XBIBD5G;
		}
		set
		{
			if (LOj2XBIBD5G != text)
			{
				LOj2XBIBD5G = text;
				n9h2eJvUA1f((string)SePI874rvw7LY9FGrsVk(-1192989954 ^ -1192957676));
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
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
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
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
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
			while (true)
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
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
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)o9LrJ14r4WbLu5QPPL79(propertyChangedEventHandler2, propertyChangedEventHandler3);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	public DocLinkContext()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		MenuCommand = new RelayCommand(QA42ehq6j62);
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				ILW2shZj88D = new RelayCommand(ccI2ewFOElD);
				FTr2swvqWjb = new RelayCommand(hsU2e7WA47r);
				num = 2;
				break;
			case 1:
				KeepOldMarketCommand = new RelayCommand(delegate
				{
					int num2 = 1;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							IsError = false;
							NoSwitchPair = false;
							return;
						case 1:
							ShowError = false;
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 != 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				});
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
				{
					num = 0;
				}
				break;
			case 2:
				w442sCe39RC = MfLO4e2xwx7qp1Q89I0Y.qgD2xAaJCfb();
				return;
			}
		}
	}

	private void QA42ehq6j62(object P_0)
	{
		int num = 1;
		int num2 = num;
		PopupButton popupButton = default(PopupButton);
		while (true)
		{
			switch (num2)
			{
			default:
			{
				YMm2XaeLC1A = popupButton;
				InputManager current = InputManager.Current;
				MouseButtonEventArgs e = new MouseButtonEventArgs(Mouse.PrimaryDevice, Environment.TickCount, MouseButton.Right);
				zfXt674rBS5AJA4c3keJ(e, Mouse.MouseUpEvent);
				e.Source = popupButton?.Parent;
				Q9TJV44raiSiAI5fFUU2(current, e);
				return;
			}
			case 1:
				popupButton = P_0 as PopupButton;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void ccI2ewFOElD(object P_0)
	{
		IsMarketLocked = !IsMarketLocked;
	}

	private void hsU2e7WA47r(object P_0)
	{
		IsExchangeLocked = !IsExchangeLocked;
		if (!IsExchangeLocked)
		{
			LockedExchange = null;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
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

	public void cEa2e8So1Sa(Jp9PPh24UN3K9hpSdbL2 P_0)
	{
		if (!IsSwitchEnabled)
		{
			return;
		}
		int num;
		if (!IsMarketLocked)
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		string text = Resources.UnlockMarketLabel;
		goto IL_0078;
		IL_0078:
		string text2 = text;
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			break;
		default:
			P_0.F1124ZUrmJR(text2, ILW2shZj88D);
			return;
		}
		text = Resources.LockMarketLabel;
		goto IL_0078;
	}

	public void pSw2eA88Uqo(Jp9PPh24UN3K9hpSdbL2 P_0, string P_1)
	{
		grrNgHn6U1rd1jEYeWn6 CS_0024_003C_003E8__locals8 = new grrNgHn6U1rd1jEYeWn6();
		CS_0024_003C_003E8__locals8.Sqon6ZejckR = this;
		CS_0024_003C_003E8__locals8.sC8n6V6nIT8 = P_1;
		int num;
		if (!K0TagT4ri6PnnfGGHtvS(CS_0024_003C_003E8__locals8.sC8n6V6nIT8))
		{
			if (IsExchangeLocked)
			{
				num = 2;
				goto IL_0009;
			}
			goto IL_0104;
		}
		return;
		IL_006d:
		string text = default(string);
		ICommand command = default(ICommand);
		P_0.F1124ZUrmJR(text, command);
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0104:
		text = (string)EjxqiJ4rlr9vfRWkw5rY();
		command = new RelayCommand(delegate
		{
			CS_0024_003C_003E8__locals8.Sqon6ZejckR.LockedExchange = CS_0024_003C_003E8__locals8.sC8n6V6nIT8;
			CS_0024_003C_003E8__locals8.Sqon6ZejckR.IsExchangeLocked = true;
		});
		goto IL_006d;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				break;
			case 2:
				if (string.IsNullOrEmpty(LockedExchange))
				{
					num = 4;
					continue;
				}
				goto case 1;
			case 1:
			{
				text = Resources.UnlockExchangeLabel;
				command = new RelayCommand(delegate
				{
					CS_0024_003C_003E8__locals8.Sqon6ZejckR.IsExchangeLocked = false;
					CS_0024_003C_003E8__locals8.Sqon6ZejckR.LockedExchange = null;
				});
				int num2 = 3;
				num = num2;
				continue;
			}
			case 4:
				goto IL_0104;
			}
			break;
		}
		goto IL_006d;
	}

	public UIElement D8c2ePUI8pp()
	{
		UIElement yMm2XaeLC1A = YMm2XaeLC1A;
		YMm2XaeLC1A = null;
		return yMm2XaeLC1A;
	}

	[NotifyPropertyChangedInvocator]
	private void n9h2eJvUA1f([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	[CompilerGenerated]
	private void AMk2eFcBlXK(object P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				IsError = false;
				NoSwitchPair = false;
				return;
			case 1:
				ShowError = false;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static DocLinkContext()
	{
		YYIjo24rD4ZueMiWGW3X();
	}

	internal static bool OHtIXW4roahEJ9AQK7ED(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static bool hZHtvW4rGvVnjiPT3pLL()
	{
		return HxAfeV4rn7d0wji7qSKb == null;
	}

	internal static DocLinkContext zI5Au74rYop4UZOiA4OK()
	{
		return HxAfeV4rn7d0wji7qSKb;
	}

	internal static object SePI874rvw7LY9FGrsVk(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void zfXt674rBS5AJA4c3keJ(object P_0, object P_1)
	{
		((RoutedEventArgs)P_0).RoutedEvent = (RoutedEvent)P_1;
	}

	internal static bool Q9TJV44raiSiAI5fFUU2(object P_0, object P_1)
	{
		return ((InputManager)P_0).ProcessInput((InputEventArgs)P_1);
	}

	internal static bool K0TagT4ri6PnnfGGHtvS(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object EjxqiJ4rlr9vfRWkw5rY()
	{
		return Resources.LockExchangeLabel;
	}

	internal static object o9LrJ14r4WbLu5QPPL79(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static void YYIjo24rD4ZueMiWGW3X()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
