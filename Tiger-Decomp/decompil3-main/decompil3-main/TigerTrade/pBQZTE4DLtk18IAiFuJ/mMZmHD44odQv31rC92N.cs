using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Windows.Controls.Docking;
using aEpmU09nz6MEoNmc0pGJ;
using bnYBBQ4RRnJxHbvk4Rm;
using ciQ7MQHkM693awgKHy3A;
using ECOEgqlSad8NUJZ2Dr9n;
using euNCE9lsfjbYKw86YuS;
using HWd9ES2bXNr0YZqBy5d0;
using mBOuwh2x7WYCRTWvJexc;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Core.Utils.Config;
using TigerTrade.Tc.Data;
using TigerTrade.UI.DocControls.Common.Link;
using TuAMtrl1Nd3XoZQQUXf0;
using uZqyk925mKGgabaJGJq6;
using xfdMo0lS4TP9pN36Goka;
using xIFN882xDj3AcM7r1d4F;

namespace pBQZTE4DLtk18IAiFuJ;

[ToolboxItem(false)]
internal class mMZmHD44odQv31rC92N : aUQvKjHk6H77hbYGG0GM
{
	private readonly string cDP4cmkDZy;

	private readonly string n9y4jaC7Js;

	[CompilerGenerated]
	private readonly DocLinkContext RLG4E0muXv;

	public static readonly DependencyProperty RT64QaLffG;

	[CompilerGenerated]
	private int ULu4ddyJeu;

	private static mMZmHD44odQv31rC92N gCWg3XlJplVtw3cNIhYu;

	protected DocLinkContext DocLinkContext
	{
		[CompilerGenerated]
		get
		{
			return RLG4E0muXv;
		}
	}

	public ToolWindow ToolWindow
	{
		get
		{
			return (ToolWindow)GetValue(RT64QaLffG);
		}
		set
		{
			SetValue(RT64QaLffG, value2);
		}
	}

	public virtual int SeIlfLmGQY2
	{
		[CompilerGenerated]
		get
		{
			return ULu4ddyJeu;
		}
		[CompilerGenerated]
		protected set
		{
			ULu4ddyJeu = uLu4ddyJeu;
		}
	}

	private static void lS34blewWj(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is mMZmHD44odQv31rC92N mMZmHD44odQv31rC92N2) || !(P_1.NewValue is ToolWindow toolWindow))
		{
			return;
		}
		mMZmHD44odQv31rC92N2.DocLinkContext.LedBrush = MfLO4e2xwx7qp1Q89I0Y.kp22x8aRS0a(mMZmHD44odQv31rC92N2.SeIlfLmGQY2, jv3GI2lF2beWWSJruacT(GkUmFilF0j3H0aLMmIm0(mMZmHD44odQv31rC92N2)));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
		{
			num = 2;
		}
		DataTemplate dataTemplate2 = default(DataTemplate);
		DataTemplate dataTemplate = default(DataTemplate);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 1:
				toolWindow.TabbedMdiTabContextContentTemplate = dataTemplate2;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
				{
					num = 0;
				}
				break;
			default:
				if (dataTemplate == null)
				{
					return;
				}
				num2 = 5;
				goto IL_0005;
			case 3:
				dataTemplate = (DataTemplate)mMZmHD44odQv31rC92N2.Resources[lpyfYvlFfXqalh5ilLvS(-3429745 ^ -3438677)];
				num2 = 4;
				goto IL_0005;
			case 4:
				if (dataTemplate2 != null)
				{
					p6xArSlF9M6uJALuLP6X(toolWindow, dataTemplate2);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
					{
						num = 1;
					}
					break;
				}
				goto default;
			case 2:
				toolWindow.DataContext = mMZmHD44odQv31rC92N2.DocLinkContext;
				dataTemplate2 = (DataTemplate)((ResourceDictionary)avvhE0lFH4WnMLdkBaMQ(mMZmHD44odQv31rC92N2))[lpyfYvlFfXqalh5ilLvS(0x37B74BDF ^ 0x37B7672B)];
				num = 3;
				break;
			case 5:
				{
					toolWindow.ToolWindowContainerTitleBarContextContentTemplate = dataTemplate;
					return;
				}
				IL_0005:
				num = num2;
				break;
			}
		}
	}

	public mMZmHD44odQv31rC92N()
	{
		sfjFi7lFnNUJNofTcQEn();
		this._002Ector(OaCAQw4g9HMlYQ2QToH.None);
	}

	protected mMZmHD44odQv31rC92N(OaCAQw4g9HMlYQ2QToH P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				n9y4jaC7Js = (string)y9f8rmlFGPAtHSBLCnK8();
				return;
			}
			RLG4E0muXv = new DocLinkContext();
			DocLinkContext.CloseCommand = new RelayCommand(wI44LOLZDZ);
			cDP4cmkDZy = P_0.ToString();
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
			{
				num = 1;
			}
		}
	}

	protected void O1I4NQwQCH(int P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				SeIlfLmGQY2 = P_0;
				DocLinkContext.GroupId = SeIlfLmGQY2;
				DocLinkContext.LedBrush = MfLO4e2xwx7qp1Q89I0Y.kp22x8aRS0a(SeIlfLmGQY2, DocLinkContext.LinkActiveWindow);
				num2 = 3;
				continue;
			case 3:
				if (tx5dPrlFY6BiTiO7e4eQ(this) == 0)
				{
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				OqHyre2x4ermamEtk9EZ.Remove(tx5dPrlFY6BiTiO7e4eQ(this), cDP4cmkDZy);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (!jv3GI2lF2beWWSJruacT(DocLinkContext))
				{
					return;
				}
				break;
			}
			break;
		}
		OqHyre2x4ermamEtk9EZ.G9V2xb8pnoo(tx5dPrlFY6BiTiO7e4eQ(this), null, cDP4cmkDZy, DocLinkContext.LinkMarketLevels);
	}

	public void GGi4kNPKJO(Symbol P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (SeIlfLmGQY2 == 0)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (P_0 == null)
			{
				return;
			}
			foreach (z6kMSs25KYyGVf55FxBT item in qEYTeV2bsvVIVI3Hs7LY.YUk2bge0Bpn(tx5dPrlFY6BiTiO7e4eQ(this)))
			{
				item.TQ525pb1OP3(P_0);
			}
			return;
		}
	}

	public virtual void Deserialize(string P_0, bBd5AkleWrv2LnDCh5X P_1)
	{
	}

	public virtual void Serialize(string P_0, bBd5AkleWrv2LnDCh5X P_1)
	{
	}

	public void MGs41HM3dR()
	{
		O1I4NQwQCH(SeIlfLmGQY2);
	}

	public virtual void fQBlfXK3OgJ()
	{
	}

	protected string b0Y45wEcGs(string P_0)
	{
		return Path.Combine(n9y4jaC7Js, (string)mIp91FlFo2E8muloZfZF(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842050001), cDP4cmkDZy, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x86EFEF6 ^ 0x86ED3A0)));
	}

	protected RoFOv2lBOIh1HQKxulso PZE4Sv4P3a<RoFOv2lBOIh1HQKxulso>(string P_0)
	{
		return ConfigSerializer.LoadFromFile<RoFOv2lBOIh1HQKxulso>(P_0);
	}

	protected void ukI4xakRS0<PoHi8IlBqDyreBtwnU05>(PoHi8IlBqDyreBtwnU05 WV2RUjlBIlnGIrS8NARU, string P_1)
	{
		ConfigSerializer.SaveToFile(WV2RUjlBIlnGIrS8NARU, P_1);
	}

	public void CloseAllDocuments()
	{
		foreach (DockingWindow item in ToolWindow.DockSite.Documents.ToList())
		{
			item.Close();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
	}

	private void wI44LOLZDZ(object P_0)
	{
		ToolWindow toolWindow = ToolWindow;
		if (toolWindow != null)
		{
			miZcj0lFvlkQU8vNSXVp(toolWindow);
		}
	}

	static mMZmHD44odQv31rC92N()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		RT64QaLffG = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1306877528 ^ -1306882852), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777430)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33554595)), new PropertyMetadata(null, lS34blewWj));
	}

	internal static bool StP8oKlJuL8pdqsr1RbK()
	{
		return gCWg3XlJplVtw3cNIhYu == null;
	}

	internal static mMZmHD44odQv31rC92N NY2VR9lJzc0O30wW6MPL()
	{
		return gCWg3XlJplVtw3cNIhYu;
	}

	internal static object GkUmFilF0j3H0aLMmIm0(object P_0)
	{
		return ((mMZmHD44odQv31rC92N)P_0).DocLinkContext;
	}

	internal static bool jv3GI2lF2beWWSJruacT(object P_0)
	{
		return ((DocLinkContext)P_0).LinkActiveWindow;
	}

	internal static object avvhE0lFH4WnMLdkBaMQ(object P_0)
	{
		return ((FrameworkElement)P_0).Resources;
	}

	internal static object lpyfYvlFfXqalh5ilLvS(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void p6xArSlF9M6uJALuLP6X(object P_0, object P_1)
	{
		((DockingWindow)P_0).StandardMdiTitleBarContextContentTemplate = (DataTemplate)P_1;
	}

	internal static void sfjFi7lFnNUJNofTcQEn()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object y9f8rmlFGPAtHSBLCnK8()
	{
		return j18iDj9nukSCmEyZs5lH.mCD9GU85vS2();
	}

	internal static int tx5dPrlFY6BiTiO7e4eQ(object P_0)
	{
		return ((mMZmHD44odQv31rC92N)P_0).SeIlfLmGQY2;
	}

	internal static object mIp91FlFo2E8muloZfZF(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static bool miZcj0lFvlkQU8vNSXVp(object P_0)
	{
		return ((DockingWindow)P_0).Close();
	}
}
