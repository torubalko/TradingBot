using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using ciQ7MQHkM693awgKHy3A;
using ECOEgqlSad8NUJZ2Dr9n;
using JbtcCQfvnTuno7NXkd9W;
using nPSrw5fYUXeiMC9Ux0xS;
using TigerTrade.Chart.Alerts;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace JIuKAU2pFp93ABKxASsI;

internal sealed class VomJb52pJkXsYJNpafk3 : aUQvKjHk6H77hbYGG0GM, IComponentConnector
{
	[CompilerGenerated]
	private sealed class W0B3mqnIUL7BSaFLsBsf
	{
		public VomJb52pJkXsYJNpafk3 IuFnIykQw2m;

		private static W0B3mqnIUL7BSaFLsBsf RemojCN1F623iT24WRP4;

		public W0B3mqnIUL7BSaFLsBsf()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void ltDnITgaQ2k(object sender, PropertyChangedEventArgs eventArgs)
		{
			IuFnIykQw2m.cY7HkOvo1nf(eventArgs.PropertyName);
			IuFnIykQw2m.cY7HkOvo1nf((string)PkeLFcN1up0P76eMqhK4(0x37B74BDF ^ 0x37B70A41));
		}

		static W0B3mqnIUL7BSaFLsBsf()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool mAFO1lN13h71gDxXcx2Y()
		{
			return RemojCN1F623iT24WRP4 == null;
		}

		internal static W0B3mqnIUL7BSaFLsBsf Ojew74N1pl1O2VfJHBBt()
		{
			return RemojCN1F623iT24WRP4;
		}

		internal static object PkeLFcN1up0P76eMqhK4(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}
	}

	private static ChartAlertSettings IX92uQDYnGy;

	public static readonly DependencyProperty vA12ud8v2bE;

	[CompilerGenerated]
	private readonly ICommand HwA2ug3IOBf;

	internal Border Border;

	private bool a5T2uRyj7fk;

	internal static VomJb52pJkXsYJNpafk3 WaufxsDvYbPw65E0h7kr;

	public ChartAlertSettings Value
	{
		get
		{
			return ((ChartAlertSettings)GetValue(vA12ud8v2bE)) ?? IX92uQDYnGy;
		}
		set
		{
			gNZ6aVDvB34Svi1WTurg(this, vA12ud8v2bE, chartAlertSettings);
		}
	}

	public string Title
	{
		get
		{
			if (Active)
			{
				DateTime? dateTime;
				while (true)
				{
					dateTime = Expiration;
					int num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
					{
						num = 1;
					}
					switch (num)
					{
					case 1:
						break;
					default:
						continue;
					}
					break;
				}
				if (!dateTime.HasValue || Expiration.Value > kFDYqgDviPRIqWEQJotF())
				{
					return TigerTrade.Properties.Resources.AlertSetupControlActive;
				}
			}
			return TigerTrade.Properties.Resources.AlertSetupControlInactive;
		}
	}

	public List<string> Signals => PPM8INfv9VK01EnoXpRO.k8xfv4kERpL();

	public bool Active
	{
		get
		{
			return Value.Active;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				default:
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1047165041 ^ -1047170197));
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1D7BA1ED ^ 0x1D7BE073));
					M7r2puVvJM1();
					return;
				case 2:
					if (flag != lpqBmaDvlO6H87UHj7Wk(Value))
					{
						uEQpyIDv4sFeB06A4RiK(Value, flag);
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
						{
							num2 = 1;
						}
					}
					break;
				}
			}
		}
	}

	public ChartAlertExecution Execution
	{
		get
		{
			return Value.Execution;
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
					if (chartAlertExecution == Value.Execution)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
						{
							num2 = 0;
						}
						break;
					}
					Value.Execution = chartAlertExecution;
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x446A43D0));
					M7r2puVvJM1();
					return;
				case 0:
					return;
				}
			}
		}
	}

	public bool DeleteLevelAfterAlert
	{
		get
		{
			return Value.DeleteLevelAfterAlert;
		}
		set
		{
			if (flag != Value.DeleteLevelAfterAlert)
			{
				Value.DeleteLevelAfterAlert = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				cY7HkOvo1nf((string)r60eH6Dva2WoMufipZ2T(-2063361985 ^ -2063373003));
				M7r2puVvJM1();
			}
		}
	}

	public DateTime? Expiration
	{
		get
		{
			return Value.Expiration;
		}
		set
		{
			if (!expiration.Equals(Value.Expiration))
			{
				Value.Expiration = expiration;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x4297AA47));
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1522697859 ^ -1522714397));
				M7r2puVvJM1();
			}
		}
	}

	public bool PlaySound
	{
		get
		{
			return Value.PlaySound;
		}
		set
		{
			if (flag != Value.PlaySound)
			{
				Value.PlaySound = flag;
				cY7HkOvo1nf((string)r60eH6Dva2WoMufipZ2T(-90307782 ^ -90245630));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				M7r2puVvJM1();
			}
		}
	}

	public string Signal
	{
		get
		{
			return (string)WxP3VODvDbZ2Rtgaiykt(Value);
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
					if (DWPmOlDvbha3gTtVPKe8(text, Value.Signal))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
						{
							num2 = 0;
						}
						break;
					}
					Value.Signal = text;
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1087080834 ^ -1087077584));
					M7r2puVvJM1();
					return;
				case 0:
					return;
				}
			}
		}
	}

	public ChartAlertPlayDuration Duration
	{
		get
		{
			return Value.Duration;
		}
		set
		{
			if (chartAlertPlayDuration != DBjH48DvNnTaEwEUHx9N(Value))
			{
				jKJXhADvk00jQVRNZlKl(Value, chartAlertPlayDuration);
				cY7HkOvo1nf((string)r60eH6Dva2WoMufipZ2T(-2123795572 ^ -2123790638));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				M7r2puVvJM1();
			}
		}
	}

	public ICommand PlaySelectedAlertCommand
	{
		[CompilerGenerated]
		get
		{
			return HwA2ug3IOBf;
		}
	}

	public bool ShowPopup
	{
		get
		{
			return Value.ShowPopup;
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
					if (flag == Value.ShowPopup)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
						{
							num2 = 0;
						}
						break;
					}
					EGJbANDv16eIRZ7JMxNm(Value, flag);
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1311293279 ^ -1311263277));
					M7r2puVvJM1();
					return;
				case 0:
					return;
				}
			}
		}
	}

	public bool SendEmail
	{
		get
		{
			return Value.SendEmail;
		}
		set
		{
			if (flag != naOSqKDv5mNYQ6DBaeoh(Value))
			{
				Value.SendEmail = flag;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746E218D));
				M7r2puVvJM1();
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac != 0)
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

	public bool SendTelegram
	{
		get
		{
			return pk64FODvSNDM6qLZEhgd(Value);
		}
		set
		{
			if (flag != Value.SendTelegram)
			{
				Value.SendTelegram = flag;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746E219B));
				M7r2puVvJM1();
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
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

	public string Message
	{
		get
		{
			return Value.Message;
		}
		set
		{
			if (text == Value.Message)
			{
				return;
			}
			FHDjdhDvxaY24uygUjRf(Value, text);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					M7r2puVvJM1();
					return;
				}
				cY7HkOvo1nf((string)r60eH6Dva2WoMufipZ2T(-198991962 ^ -198986326));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
				{
					num = 1;
				}
			}
		}
	}

	public bool Log
	{
		get
		{
			return Value.Log;
		}
		set
		{
			if (flag != Value.Log)
			{
				Value.Log = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-894902996 ^ -894949226));
				M7r2puVvJM1();
			}
		}
	}

	private static void CV42p37Vsgc(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		W0B3mqnIUL7BSaFLsBsf CS_0024_003C_003E8__locals18 = new W0B3mqnIUL7BSaFLsBsf();
		CS_0024_003C_003E8__locals18.IuFnIykQw2m = P_0 as VomJb52pJkXsYJNpafk3;
		if (CS_0024_003C_003E8__locals18.IuFnIykQw2m == null)
		{
			return;
		}
		CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5EA8FF2A ^ 0x5EA8BEB4));
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 1:
				CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1311293279 ^ -1311263447));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
				{
					num = 6;
				}
				break;
			case 3:
				return;
			case 4:
			{
				CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf((string)r60eH6Dva2WoMufipZ2T(-1848952786 ^ -1848946302));
				CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6AB40973 ^ 0x6AB4FC4B));
				CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6EC99CAF ^ 0x6EC969E1));
				int num2 = 2;
				num = num2;
				break;
			}
			case 5:
				CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1487846E ^ 0x1487708A));
				CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf((string)r60eH6Dva2WoMufipZ2T(0x3E0426F0 ^ 0x3E04D204));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
				{
					num = 0;
				}
				break;
			default:
				CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4662F6AF ^ 0x466203A5));
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
				{
					num = 4;
				}
				break;
			case 2:
				CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf((string)r60eH6Dva2WoMufipZ2T(0x3544E813 ^ 0x35441D4D));
				CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x16AD7E76 ^ 0x16AD8B04));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
				{
					num = 1;
				}
				break;
			case 6:
				CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf((string)r60eH6Dva2WoMufipZ2T(-838841832 ^ -838811770));
				CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x315A9BEF));
				CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1192989954 ^ -1192976572));
				CS_0024_003C_003E8__locals18.IuFnIykQw2m.Value.PropertyChanged += delegate(object sender, PropertyChangedEventArgs eventArgs)
				{
					CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf(eventArgs.PropertyName);
					CS_0024_003C_003E8__locals18.IuFnIykQw2m.cY7HkOvo1nf((string)W0B3mqnIUL7BSaFLsBsf.PkeLFcN1up0P76eMqhK4(0x37B74BDF ^ 0x37B70A41));
				};
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	public VomJb52pJkXsYJNpafk3()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		HwA2ug3IOBf = new RelayCommand(delegate
		{
			PSx2pzB5Kjn();
		});
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void C212ppYycFc(object P_0, MouseButtonEventArgs P_1)
	{
		PTtv3VDvLuq3WYZ5Bgn4(P_1, true);
	}

	private void M7r2puVvJM1()
	{
		Value = Value;
	}

	private void PSx2pzB5Kjn()
	{
		oZu29WfYtbVlhlMVGiDk.UX8fY7ZbJhw(Value.Signal);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!a5T2uRyj7fk)
		{
			a5T2uRyj7fk = true;
			Uri resourceLocator = new Uri((string)r60eH6Dva2WoMufipZ2T(-1962651919 ^ -1962624203), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
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

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		if (P_0 == 1)
		{
			Border = (Border)P_1;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Border.MouseDown += C212ppYycFc;
		}
		else
		{
			a5T2uRyj7fk = true;
		}
	}

	static VomJb52pJkXsYJNpafk3()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		IX92uQDYnGy = new ChartAlertSettings();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		vA12ud8v2bE = DependencyProperty.Register((string)r60eH6Dva2WoMufipZ2T(0x68DEE0F ^ 0x68DD0CF), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777744)), Type.GetTypeFromHandle(Lsw8enDvevCvALbw2UbY(33555169)), new PropertyMetadata(null, CV42p37Vsgc));
	}

	[CompilerGenerated]
	private void dd02u0Ua8Tq(object P_0)
	{
		PSx2pzB5Kjn();
	}

	internal static bool JkbcNIDvo4xEi7qKak6b()
	{
		return WaufxsDvYbPw65E0h7kr == null;
	}

	internal static VomJb52pJkXsYJNpafk3 KLMmx1Dvv5OlXjQrx44Z()
	{
		return WaufxsDvYbPw65E0h7kr;
	}

	internal static void gNZ6aVDvB34Svi1WTurg(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static object r60eH6Dva2WoMufipZ2T(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static DateTime kFDYqgDviPRIqWEQJotF()
	{
		return TimeHelper.LocalTime;
	}

	internal static bool lpqBmaDvlO6H87UHj7Wk(object P_0)
	{
		return ((ChartAlertSettings)P_0).Active;
	}

	internal static void uEQpyIDv4sFeB06A4RiK(object P_0, bool P_1)
	{
		((ChartAlertSettings)P_0).Active = P_1;
	}

	internal static object WxP3VODvDbZ2Rtgaiykt(object P_0)
	{
		return ((ChartAlertSettings)P_0).Signal;
	}

	internal static bool DWPmOlDvbha3gTtVPKe8(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static ChartAlertPlayDuration DBjH48DvNnTaEwEUHx9N(object P_0)
	{
		return ((ChartAlertSettings)P_0).Duration;
	}

	internal static void jKJXhADvk00jQVRNZlKl(object P_0, ChartAlertPlayDuration P_1)
	{
		((ChartAlertSettings)P_0).Duration = P_1;
	}

	internal static void EGJbANDv16eIRZ7JMxNm(object P_0, bool P_1)
	{
		((ChartAlertSettings)P_0).ShowPopup = P_1;
	}

	internal static bool naOSqKDv5mNYQ6DBaeoh(object P_0)
	{
		return ((ChartAlertSettings)P_0).SendEmail;
	}

	internal static bool pk64FODvSNDM6qLZEhgd(object P_0)
	{
		return ((ChartAlertSettings)P_0).SendTelegram;
	}

	internal static void FHDjdhDvxaY24uygUjRf(object P_0, object P_1)
	{
		((ChartAlertSettings)P_0).Message = (string)P_1;
	}

	internal static void PTtv3VDvLuq3WYZ5Bgn4(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}

	internal static RuntimeTypeHandle Lsw8enDvevCvALbw2UbY(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}
}
