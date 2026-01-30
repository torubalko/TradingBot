using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using bnYBBQ4RRnJxHbvk4Rm;
using cyhoyCiGaNUIwttCuOK;
using dpoTZ395JPmKdIOgCedl;
using Dq9qGtf0S8tbnXB1O4NE;
using ECOEgqlSad8NUJZ2Dr9n;
using euNCE9lsfjbYKw86YuS;
using inUerCfHMLVDbG9HvwwZ;
using KMjX5iiSaC9I5xcH5v2;
using PaiaBwitDGVrqPrN87B;
using pBQZTE4DLtk18IAiFuJ;
using qCQIuYGJryFOsEw3GPHq;
using sMFne2GHAlf89keFJ43Q;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc.Connectors.Simulator.Player;
using TigerTrade.Tc.Manager;
using TigerTrade.UI.Windows;
using TuAMtrl1Nd3XoZQQUXf0;
using U2AoR19TNRFWN9WoaNy;
using vG0WidHawbhpKdkcelf8;
using WgpZwxGJT3LVlqrS4Ppx;

namespace TigerTrade.UI.ToolControls.Player;

internal sealed class PlayerControl : mMZmHD44odQv31rC92N, C9uTJdGH8bibVknh46Q6, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class NqWy9xnDRlHxjXVU9fJ1
	{
		public static readonly NqWy9xnDRlHxjXVU9fJ1 oEKnDIepA9m;

		public static Action<object> jEenDWeVVLq;

		public static Action<object> wPlnDtPQb78;

		public static Action<object> hxEnDUiqiUm;

		public static Action<object> zCPnDThdh59;

		private static NqWy9xnDRlHxjXVU9fJ1 x8gogeN2YkUbcKs4sZf4;

		static NqWy9xnDRlHxjXVU9fJ1()
		{
			pVM3SFN2BPMtMhlUCYdt();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			oEKnDIepA9m = new NqWy9xnDRlHxjXVU9fJ1();
		}

		public NqWy9xnDRlHxjXVU9fJ1()
		{
			vXTSefN2ao04CesST32t();
			base._002Ector();
		}

		internal void rT5nD6Flsj7(object item)
		{
			iiZRoNN2lQ6Xpbtr99Ce(((hNXfXl9U6G1YI9MQ7eq)P1qB8ON2i2E44MKHpDhL()).MainWindow);
			tJG5ceN24p8f49uSxGd7();
			PlayerRecordsInfo.NMHiaPbl1Z(-1);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal void INpnDMsF96s(object item)
		{
			hNXfXl9U6G1YI9MQ7eq.Instance.MainWindow.SetPlayerMode();
			HistoryPlayerModule.Clear();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			PlayerRecordsInfo.NMHiaPbl1Z(1);
		}

		internal void rN2nDOjYpeP(object item)
		{
			HistoryPlayerModule.Pause();
		}

		internal void dJ0nDqsgNux(object item)
		{
			HistoryPlayerModule.Stop();
		}

		internal static void pVM3SFN2BPMtMhlUCYdt()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool CQ4gELN2or6faIheQqRH()
		{
			return x8gogeN2YkUbcKs4sZf4 == null;
		}

		internal static NqWy9xnDRlHxjXVU9fJ1 PK3IwON2vUZOm7OeRs0K()
		{
			return x8gogeN2YkUbcKs4sZf4;
		}

		internal static void vXTSefN2ao04CesST32t()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static object P1qB8ON2i2E44MKHpDhL()
		{
			return hNXfXl9U6G1YI9MQ7eq.Instance;
		}

		internal static void iiZRoNN2lQ6Xpbtr99Ce(object P_0)
		{
			((MainWindow)P_0).SetPlayerMode();
		}

		internal static void tJG5ceN24p8f49uSxGd7()
		{
			HistoryPlayerModule.Clear();
		}
	}

	private readonly Dictionary<string, OJV20Gi5LoyHmc8hciG> _records;

	private readonly Dictionary<string, HistoryPlayerStats> _stats;

	private readonly Dictionary<string, int> _playFwValues;

	private static readonly sG6fxPineAdO5jRoY00 PlayerRecordsInfo;

	private DispatcherTimer _timer1;

	public bool WindowLoaded;

	private ICommand _openRecordsCommand;

	private ICommand _prevDayCommand;

	private ICommand _nextDayCommand;

	private ICommand _startPlayCommand;

	private ICommand _pausePlayCommand;

	private ICommand _stopPlayCommand;

	private ICommand _skipToTimeCommand;

	private ICommand _skipToValueCommand;

	private bool _pausePlayIsChecked;

	private int _playSpeed;

	private TimeSpan _skipTime;

	private string _skipValue;

	internal u0GAIHHahyHxCr1XJKud DataGrid;

	private bool _contentLoaded;

	private static PlayerControl NZLnDelPOTSNNo5ym2oB;

	public ObservableCollection<OJV20Gi5LoyHmc8hciG> Records { get; }

	public ObservableCollection<string> PlayFwValues { get; private set; }

	public ICommand OpenRecordsCommand => _openRecordsCommand ?? (_openRecordsCommand = new RelayCommand(delegate
	{
		CxxE1SiWKriMgEOKuTj cxxE1SiWKriMgEOKuTj = new CxxE1SiWKriMgEOKuTj
		{
			Owner = base.ParentWindow
		};
		bool? flag = cxxE1SiWKriMgEOKuTj.ShowDialog();
		int num = 2;
		int num2 = num;
		bool flag2 = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (flag == flag2)
				{
					hNXfXl9U6G1YI9MQ7eq.Instance.MainWindow.SetPlayerMode();
					if (cxxE1SiWKriMgEOKuTj.BxUlv4HRTr())
					{
						PlayerRecordsInfo.mrpioIELYU(cxxE1SiWKriMgEOKuTj.Symbols.ToList(), eTQK3ElP3rhdHDkAy8jL(cxxE1SiWKriMgEOKuTj));
					}
					else
					{
						PlayerRecordsInfo.a8EiBoZgao(cxxE1SiWKriMgEOKuTj.kbll0Z7cvD());
					}
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				flag2 = true;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}, (object item) => !InPlay));

	public ICommand PrevDayCommand => _prevDayCommand ?? (_prevDayCommand = new RelayCommand(delegate
	{
		NqWy9xnDRlHxjXVU9fJ1.iiZRoNN2lQ6Xpbtr99Ce(((hNXfXl9U6G1YI9MQ7eq)NqWy9xnDRlHxjXVU9fJ1.P1qB8ON2i2E44MKHpDhL()).MainWindow);
		NqWy9xnDRlHxjXVU9fJ1.tJG5ceN24p8f49uSxGd7();
		PlayerRecordsInfo.NMHiaPbl1Z(-1);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}, (object item) => IsActive && !InPlay));

	public ICommand NextDayCommand => _nextDayCommand ?? (_nextDayCommand = new RelayCommand(delegate
	{
		hNXfXl9U6G1YI9MQ7eq.Instance.MainWindow.SetPlayerMode();
		HistoryPlayerModule.Clear();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
		{
			num = 0;
		}
		switch (num)
		{
		default:
			PlayerRecordsInfo.NMHiaPbl1Z(1);
			break;
		}
	}, (object item) => IsActive && !InPlay));

	public ICommand StartPlayCommand => _startPlayCommand ?? (_startPlayCommand = new RelayCommand(delegate
	{
		((hNXfXl9U6G1YI9MQ7eq)tFI62ElPpDxb6KTpUpE7()).MainWindow.SetPlayerMode();
		HistoryPlayerModule.SetSpeed(PlaySpeed);
		HistoryPlayerModule.Play();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}, (object item) => IsReady && !InPlay));

	public ICommand PausePlayCommand => _pausePlayCommand ?? (_pausePlayCommand = new RelayCommand(delegate
	{
		HistoryPlayerModule.Pause();
	}, (object item) => InPlay));

	public ICommand StopPlayCommand => _stopPlayCommand ?? (_stopPlayCommand = new RelayCommand(delegate
	{
		HistoryPlayerModule.Stop();
	}, (object item) => InPlay));

	public ICommand SkipToTimeCommand => _skipToTimeCommand ?? (_skipToTimeCommand = new RelayCommand(delegate
	{
		ghMdxdlPu9yNbKvwF6KH(SkipTime);
	}, (object item) => InPlay));

	public ICommand SkipToValueCommand => _skipToValueCommand ?? (_skipToValueCommand = new RelayCommand(delegate
	{
		HistoryPlayerModule.Skip(_playFwValues[SkipValue]);
	}, (object item) => InPlay));

	public bool InPlay { get; set; }

	public bool IsReady { get; set; }

	public bool IsActive { get; set; }

	public bool PausePlayIsChecked
	{
		get
		{
			return _pausePlayIsChecked;
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
					if (value == _pausePlayIsChecked)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
						{
							num2 = 0;
						}
						break;
					}
					_pausePlayIsChecked = value;
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5EA8FF2A ^ 0x5EA8D42C));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public int PlaySpeed
	{
		get
		{
			return _playSpeed;
		}
		set
		{
			value = Math.Max(1, value);
			if (value == _playSpeed)
			{
				return;
			}
			_playSpeed = value;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
				{
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x78D396D8 ^ 0x78D3BC1E));
					Action<string, object> syncParam = PlayerControl.SyncParam;
					if (syncParam == null)
					{
						goto case 2;
					}
					syncParam((string)nY28K2lPW2j4isBORqhm(-1192989954 ^ -1193000904), value);
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
					{
						num = 1;
					}
					break;
				}
				case 2:
					jWSIKQlPrtDNHKQk1Y59(value);
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
					{
						num = 1;
					}
					break;
				case 1:
					return;
				}
			}
		}
	}

	public TimeSpan SkipTime
	{
		get
		{
			return _skipTime;
		}
		set
		{
			if (rq7cWHlPKhSMORyBF5n4(value, _skipTime))
			{
				return;
			}
			_skipTime = value;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
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
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x385FFAB ^ 0x385D577));
				Action<string, object> syncParam = PlayerControl.SyncParam;
				if (syncParam == null)
				{
					return;
				}
				syncParam((string)nY28K2lPW2j4isBORqhm(-1736566656 ^ -1736560036), value);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac != 0)
				{
					num = 1;
				}
			}
		}
	}

	public string SkipValue
	{
		get
		{
			return _skipValue;
		}
		set
		{
			if (value == null)
			{
				goto IL_0041;
			}
			int num;
			if (!_playFwValues.ContainsKey(value))
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			goto IL_009f;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 1:
					PlayerControl.SyncParam?.Invoke((string)nY28K2lPW2j4isBORqhm(0x741B85CB ^ 0x741BAF3B), value);
					return;
				case 2:
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-29702950 ^ -29692374));
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
					{
						num = 1;
					}
					continue;
				}
				break;
			}
			goto IL_0041;
			IL_009f:
			if (value == _skipValue)
			{
				return;
			}
			_skipValue = value;
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
			{
				num = 0;
			}
			goto IL_0009;
			IL_0041:
			value = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D313048 ^ 0x2D311A06);
			goto IL_009f;
		}
	}

	public bool IsPlayerModeOn => DataManager.Player;

	public static event Action<string, object> SyncParam;

	public PlayerControl()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(OaCAQw4g9HMlYQ2QToH.Player);
		int num = 3;
		Dictionary<string, int>.Enumerator enumerator = default(Dictionary<string, int>.Enumerator);
		while (true)
		{
			switch (num)
			{
			case 2:
				PlayFwValues = new ObservableCollection<string>();
				_playFwValues = new Dictionary<string, int>
				{
					{
						stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-198991962 ^ -198986312),
						5
					},
					{
						stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xC1DDB3B ^ 0xC1DF11D),
						10
					},
					{
						stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F645F3C ^ 0x7F64750C),
						15
					},
					{
						stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842051259),
						20
					},
					{
						(string)nY28K2lPW2j4isBORqhm(0x37B74BDF ^ 0x37B7619B),
						30
					},
					{
						stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x735715F1 ^ 0x73573FBF),
						60
					},
					{
						stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x86EFEF6 ^ 0x86ED4A0),
						120
					},
					{
						stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2BD86B18 ^ 0x2BD84146),
						180
					},
					{
						stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CD6573),
						240
					},
					{
						stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-3429745 ^ -3440415),
						300
					},
					{
						stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-671204305 ^ -671213991),
						360
					},
					{
						stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F645F3C ^ 0x7F647542),
						600
					},
					{
						(string)nY28K2lPW2j4isBORqhm(-1161619942 ^ -1161610094),
						900
					},
					{
						(string)nY28K2lPW2j4isBORqhm(0x2D313048 ^ 0x2D311ADA),
						1200
					},
					{
						stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1763895751 ^ -1763885915),
						1800
					},
					{
						(string)nY28K2lPW2j4isBORqhm(0x16AD7E76 ^ 0x16AD54D0),
						3600
					},
					{
						(string)nY28K2lPW2j4isBORqhm(-1878953018 ^ -1878959768),
						7200
					},
					{
						(string)nY28K2lPW2j4isBORqhm(-90307782 ^ -90297972),
						14400
					},
					{
						(string)nY28K2lPW2j4isBORqhm(--18459671 ^ 0x11986A9),
						86400
					}
				};
				enumerator = _playFwValues.GetEnumerator();
				num = 4;
				break;
			case 1:
				SyncParam += OnSyncParam;
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				Records = new ObservableCollection<OJV20Gi5LoyHmc8hciG>();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
				{
					num = 0;
				}
				break;
			case 5:
				return;
			default:
				_records = new Dictionary<string, OJV20Gi5LoyHmc8hciG>();
				_stats = new Dictionary<string, HistoryPlayerStats>();
				num = 2;
				break;
			case 4:
				try
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<string, int> current = enumerator.Current;
						PlayFwValues.Add(current.Key);
					}
					int num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					case 0:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				PlaySpeed = j18iDj9nukSCmEyZs5lH.Settings.roG9lxfdTed;
				SkipTime = LfnHKblPtEIp7ALcuZAb(j18iDj9nukSCmEyZs5lH.Settings);
				SkipValue = j18iDj9nukSCmEyZs5lH.Settings.dmw9ljH69PD;
				InitializeComponent();
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	private void OnSyncParam(string paramName, object paramValue)
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					if (Rf6gm0lPUtkyvK6qiF8V(paramName, nY28K2lPW2j4isBORqhm(-690510723 ^ -690516319)))
					{
						SkipTime = (TimeSpan)paramValue;
						return;
					}
					goto case 1;
				case 0:
					return;
				case 1:
					if (!(paramName == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x20B584D2 ^ 0x20B5AE22)))
					{
						return;
					}
					SkipValue = (string)paramValue;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (paramName == (string)nY28K2lPW2j4isBORqhm(0x5CD4F15 ^ 0x5CD65D3))
					{
						PlaySpeed = (int)paramValue;
						return;
					}
					num = 2;
					break;
				}
				break;
			}
		}
	}

	private void PlayerControl_Loaded(object sender, RoutedEventArgs e)
	{
		if (WindowLoaded)
		{
			return;
		}
		SetupPlayer();
		WindowLoaded = true;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
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
			_timer1 = new DispatcherTimer(TimeSpan.FromMilliseconds(500.0), DispatcherPriority.Normal, delegate
			{
				UpdateStats();
			}, base.Dispatcher);
			TimeHelper.PlayerTimeProvider = this;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
			{
				num = 1;
			}
		}
	}

	private void DataGrid_OnMouseRightButtonUp(object sender, MouseButtonEventArgs e)
	{
		int num = 3;
		int num2 = num;
		DependencyObject dependencyObject = default(DependencyObject);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				if (dependencyObject is DataGridColumnHeader)
				{
					goto IL_0055;
				}
				goto case 1;
			case 3:
				dependencyObject = (DependencyObject)vnLEErlPTgcwNPihp9cD(e);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				if (dependencyObject != null && !(dependencyObject is DataGridCell))
				{
					num2 = 4;
					break;
				}
				goto IL_0055;
			case 1:
				dependencyObject = VisualTreeHelper.GetParent(dependencyObject);
				goto case 2;
			case 0:
				return;
				IL_0055:
				if (dependencyObject is DataGridColumnHeader)
				{
					DataGrid.rWAHi2QjAqn();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			}
		}
	}

	public override void Deserialize(string workspaceID, bBd5AkleWrv2LnDCh5X settings)
	{
		vSch46lPyndNhclNVvH4(DataGrid, b0Y45wEcGs(workspaceID));
	}

	public override void Serialize(string workspaceID, bBd5AkleWrv2LnDCh5X settings)
	{
		DataGrid.kUmHi9sIHwh(b0Y45wEcGs(workspaceID));
		j18iDj9nukSCmEyZs5lH.Settings.roG9lxfdTed = PlaySpeed;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		IKMRW9lPVPjMe4vUHOKu(okCnthlPZRoSwW5eOV6Y(), SkipTime);
		yv6uYklPC7D75FpGuXNm(j18iDj9nukSCmEyZs5lH.Settings, SkipValue);
	}

	private void SetupPlayer()
	{
		int num = 3;
		int num2 = num;
		HistoryPlayerState state = default(HistoryPlayerState);
		List<HistoryPlayerStats> stats = default(List<HistoryPlayerStats>);
		while (true)
		{
			switch (num2)
			{
			default:
				ChangeState(state);
				stats = HistoryPlayerModule.GetStats();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				HistoryPlayerModule.StatsChanged += delegate(jDhdBvGJCYyeucPOsxGw e)
				{
					UpdateStats(e.slOGJmyfo9X());
				};
				state = dTnUVQlPm3EeYwp8uFd8();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				HistoryPlayerModule.StateChanged += delegate(j7hE9bGJUtiuJ2DVMLti e)
				{
					ChangeState(e.State);
				};
				num2 = 2;
				break;
			case 1:
				if (stats == null)
				{
					return;
				}
				{
					foreach (HistoryPlayerStats item in stats)
					{
						int num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						}
						UpdateStats(item);
					}
					return;
				}
			}
		}
	}

	private void UpdateStats(HistoryPlayerStats stats)
	{
		_stats[(string)UotjBFlPhUDxt94cUOyw(stats)] = stats;
	}

	private void UpdateStats()
	{
		using (Dictionary<string, HistoryPlayerStats>.ValueCollection.Enumerator enumerator = _stats.Values.GetEnumerator())
		{
			HistoryPlayerStats current = default(HistoryPlayerStats);
			OJV20Gi5LoyHmc8hciG oJV20Gi5LoyHmc8hciG = default(OJV20Gi5LoyHmc8hciG);
			while (true)
			{
				IL_00d5:
				int num;
				if (enumerator.MoveNext())
				{
					current = enumerator.Current;
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
					{
						num = 1;
					}
				}
				else
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 == 0)
					{
						num = 0;
					}
				}
				while (true)
				{
					switch (num)
					{
					default:
						goto end_IL_004e;
					case 2:
						_records.Add(current.SymbolID, oJV20Gi5LoyHmc8hciG);
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
						{
							num = 3;
						}
						continue;
					case 1:
						if (_records.ContainsKey(current.SymbolID))
						{
							_records[(string)UotjBFlPhUDxt94cUOyw(current)].U6Aix9k4np(current);
							break;
						}
						oJV20Gi5LoyHmc8hciG = new OJV20Gi5LoyHmc8hciG(current);
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
						{
							num = 2;
						}
						continue;
					case 3:
						Records.Add(oJV20Gi5LoyHmc8hciG);
						break;
					case 0:
						goto end_IL_004e;
					}
					goto IL_00d5;
					continue;
					end_IL_004e:
					break;
				}
				break;
			}
		}
		_stats.Clear();
	}

	private void ChangeState(HistoryPlayerState state)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					PausePlayIsChecked = false;
					goto case 1;
				default:
					goto IL_007a;
				case 8:
					goto end_IL_0012;
				case 2:
					switch (state)
					{
					case HistoryPlayerState.Pause:
						break;
					case HistoryPlayerState.Stop:
						goto IL_0062;
					case HistoryPlayerState.Clear:
						goto IL_007a;
					case HistoryPlayerState.Ready:
						goto IL_009b;
					default:
						goto IL_00f7;
					case HistoryPlayerState.Play:
						goto end_IL_0012_2;
					}
					PausePlayIsChecked = true;
					goto case 1;
				case 6:
					_records.Clear();
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
					{
						num2 = 7;
					}
					continue;
				case 1:
				case 3:
				case 7:
					lnlfbmlPw1C7MNiIJ3an();
					return;
				case 5:
					break;
					IL_007a:
					IsReady = false;
					Records.Clear();
					num2 = 6;
					continue;
					IL_00f7:
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
					{
						num2 = 1;
					}
					continue;
					IL_009b:
					IsReady = true;
					num2 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 != 0)
					{
						num2 = 4;
					}
					continue;
					IL_0062:
					InPlay = false;
					IsReady = true;
					PausePlayIsChecked = false;
					goto case 1;
					end_IL_0012_2:
					break;
				}
				InPlay = true;
				IsReady = false;
				num2 = 4;
				continue;
				end_IL_0012:
				break;
			}
			IsActive = true;
			num = 3;
		}
	}

	public void ProcessKeyDown(KeyEventArgs e)
	{
		int num = 8;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 5:
				PlaySpeed = num3 + 1;
				e.Handled = true;
				num2 = 3;
				break;
			case 6:
				e.Handled = true;
				return;
			case 7:
				if (StartPlayCommand.CanExecute(null))
				{
					StartPlayCommand.Execute(null);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 6;
			case 1:
				e.Handled = true;
				num2 = 4;
				break;
			case 2:
				e.Handled = true;
				return;
			case 3:
				return;
			case 4:
				return;
			default:
				foJQGElPAZWg5nVo3UcP(e, true);
				return;
			case 8:
				if (vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().PlayerPlayStart.Check(e))
				{
					num2 = 7;
					break;
				}
				if (!((KedBU3f05IsrqcZmlPn5)OnlOtYlP7RunuR9IpOC6()).PlayerPlayStop.Check(e))
				{
					if (UffxTDlP8ajtOVln6Nyj(((KedBU3f05IsrqcZmlPn5)OnlOtYlP7RunuR9IpOC6()).PlayerIncreaseSpeed, e))
					{
						num3 = PlaySpeed;
						num2 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
						{
							num2 = 5;
						}
						break;
					}
					if (!vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().PlayerDecreaseSpeed.Check(e))
					{
						if (!vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().PlayerFastForward.Check(e))
						{
							return;
						}
						if (SkipToValueCommand.CanExecute(null))
						{
							SkipToValueCommand.Execute(null);
							num2 = 2;
							break;
						}
						goto case 2;
					}
					num3 = PlaySpeed--;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (StopPlayCommand.CanExecute(null))
				{
					StopPlayCommand.Execute(null);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	public void ProcessKeyUp(KeyEventArgs e)
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 5:
					PausePlayCommand.Execute(null);
					goto IL_0056;
				case 3:
					if (NRR6JelPP0XQIlvhwL9W(PausePlayCommand, null))
					{
						num2 = 5;
						break;
					}
					goto IL_0056;
				case 4:
					if (UffxTDlP8ajtOVln6Nyj(vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().PlayerPlayPause, e))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
						{
							num2 = 3;
						}
						break;
					}
					if (UffxTDlP8ajtOVln6Nyj(((KedBU3f05IsrqcZmlPn5)OnlOtYlP7RunuR9IpOC6()).PlayerPrevDay, e))
					{
						if (PrevDayCommand.CanExecute(null))
						{
							goto end_IL_0012;
						}
						goto case 1;
					}
					if (vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().PlayerNextDay.Check(e))
					{
						if (NextDayCommand.CanExecute(null))
						{
							fAR1J2lPJBXphHPiuL0x(NextDayCommand, null);
						}
						foJQGElPAZWg5nVo3UcP(e, true);
					}
					return;
				case 0:
					return;
				case 1:
					foJQGElPAZWg5nVo3UcP(e, true);
					return;
				case 2:
					{
						fAR1J2lPJBXphHPiuL0x(PrevDayCommand, null);
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
						{
							num2 = 1;
						}
						break;
					}
					IL_0056:
					foJQGElPAZWg5nVo3UcP(e, true);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public DateTime GetCurrentPlayerTime(string chartSymbolCode)
	{
		if (!_records.TryGetValue(chartSymbolCode, out var value))
		{
			return DateTime.MinValue;
		}
		return value.CurrentTime;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri uri = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F55E538 ^ 0x7F55CE16), UriKind.Relative);
			VDXitblPF1emwwwCEpkc(this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId == 1)
		{
			DataGrid = (u0GAIHHahyHxCr1XJKud)target;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			_contentLoaded = true;
		}
	}

	static PlayerControl()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				PlayerRecordsInfo = new sG6fxPineAdO5jRoY00(Dispatcher.CurrentDispatcher);
				return;
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object nY28K2lPW2j4isBORqhm(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static TimeSpan LfnHKblPtEIp7ALcuZAb(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).Xot9lsMkFyn;
	}

	internal static bool YFfNYhlPqtUXjrIhvLoT()
	{
		return NZLnDelPOTSNNo5ym2oB == null;
	}

	internal static PlayerControl zp4SsvlPIFYL6tDoeEQO()
	{
		return NZLnDelPOTSNNo5ym2oB;
	}

	internal static bool Rf6gm0lPUtkyvK6qiF8V(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object vnLEErlPTgcwNPihp9cD(object P_0)
	{
		return ((RoutedEventArgs)P_0).OriginalSource;
	}

	internal static void vSch46lPyndNhclNVvH4(object P_0, object P_1)
	{
		((u0GAIHHahyHxCr1XJKud)P_0).to8HinyXyDi((string)P_1);
	}

	internal static object okCnthlPZRoSwW5eOV6Y()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static void IKMRW9lPVPjMe4vUHOKu(object P_0, TimeSpan P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).Xot9lsMkFyn = P_1;
	}

	internal static void yv6uYklPC7D75FpGuXNm(object P_0, object P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).dmw9ljH69PD = (string)P_1;
	}

	internal static void jWSIKQlPrtDNHKQk1Y59(int P_0)
	{
		HistoryPlayerModule.SetSpeed(P_0);
	}

	internal static bool rq7cWHlPKhSMORyBF5n4(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 == P_1;
	}

	internal static HistoryPlayerState dTnUVQlPm3EeYwp8uFd8()
	{
		return HistoryPlayerModule.GetState();
	}

	internal static object UotjBFlPhUDxt94cUOyw(object P_0)
	{
		return ((HistoryPlayerStats)P_0).SymbolID;
	}

	internal static void lnlfbmlPw1C7MNiIJ3an()
	{
		CommandManager.InvalidateRequerySuggested();
	}

	internal static object OnlOtYlP7RunuR9IpOC6()
	{
		return vspL39fH6Hd69qemUHrA.YXwfHUcZiBY();
	}

	internal static bool UffxTDlP8ajtOVln6Nyj(object P_0, object P_1)
	{
		return ((UQpOEF95Pl27GeSpKZ6s)P_0).Check((KeyEventArgs)P_1);
	}

	internal static void foJQGElPAZWg5nVo3UcP(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}

	internal static bool NRR6JelPP0XQIlvhwL9W(object P_0, object P_1)
	{
		return ((ICommand)P_0).CanExecute(P_1);
	}

	internal static void fAR1J2lPJBXphHPiuL0x(object P_0, object P_1)
	{
		((ICommand)P_0).Execute(P_1);
	}

	internal static void VDXitblPF1emwwwCEpkc(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static DateTime eTQK3ElP3rhdHDkAy8jL(object P_0)
	{
		return ((CxxE1SiWKriMgEOKuTj)P_0).RecordsDate;
	}

	internal static object tFI62ElPpDxb6KTpUpE7()
	{
		return hNXfXl9U6G1YI9MQ7eq.Instance;
	}

	internal static void ghMdxdlPu9yNbKvwF6KH(TimeSpan P_0)
	{
		HistoryPlayerModule.SkipTo(P_0);
	}
}
