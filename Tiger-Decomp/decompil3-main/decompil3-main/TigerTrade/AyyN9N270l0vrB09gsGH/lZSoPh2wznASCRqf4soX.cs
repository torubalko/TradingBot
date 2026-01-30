using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Navigation;
using aEpmU09nz6MEoNmc0pGJ;
using CjttZVHEzEWfhqQAXjq2;
using ECOEgqlSad8NUJZ2Dr9n;
using OWUMXkHkWgCUprHQ3jb9;
using TigerTrade.Core.Utils.Logging;
using TuAMtrl1Nd3XoZQQUXf0;
using TXgXf59nvX2WgiwG2gcq;
using vwaruI999smF85ZbYXcY;

namespace AyyN9N270l0vrB09gsGH;

internal sealed class lZSoPh2wznASCRqf4soX : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	private string vkX27lJ7bks;

	private bool pfY274sXV0o;

	private WebClient l4Z27DrKmq5;

	private bool xLS27b2RFpr;

	internal TextBlock TextBlockUpdateLink;

	internal Hyperlink ChangelogHyperlink;

	internal CheckBox CheckBoxHideUpdate;

	internal ProgressBar ProgressBar;

	internal Button ButtonUpdate;

	internal Button ButtonCancel;

	private bool TYO27NodUon;

	internal static lZSoPh2wznASCRqf4soX Hk7lUXD9iteWe2T9s5BZ;

	public string UpdateVersion
	{
		get
		{
			return vkX27lJ7bks;
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
					if (!NQvDnLD9DJhVGDo8AOib(text, vkX27lJ7bks))
					{
						vkX27lJ7bks = text;
						ifWlfmRSlkr((string)YUGuCaD9bhBu9HiUCK1O(0x684F243E ^ 0x684FC6F0));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool HideUpdate
	{
		get
		{
			return pfY274sXV0o;
		}
		set
		{
			if (flag != pfY274sXV0o)
			{
				pfY274sXV0o = flag;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1380525184 ^ -1380566676));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
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

	public lZSoPh2wznASCRqf4soX()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		zxMDhcD9NRINb6OyIHsH(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-894902996 ^ -894943704));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				MwZ272npaaM();
				return;
			case 1:
				InitializeComponent();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void MwZ272npaaM()
	{
		string empty = string.Empty;
		if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x446A5404))
		{
			empty = HCyG5O9noVsgyuSFnBDR.p6y9n18B7ch();
			goto IL_0094;
		}
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		default:
			return;
		case 1:
		case 2:
			break;
		case 0:
			return;
		}
		empty = (string)UloMZsD9kItd2j03FX8J();
		goto IL_0094;
		IL_0094:
		GglF3fD91IT6wpuH92at(ChangelogHyperlink, new Uri(empty));
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
		{
			num = 0;
		}
		goto IL_0009;
	}

	private void UpdateWindow_Loaded(object sender, RoutedEventArgs e)
	{
		UpdateVersion = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28B345BB ^ 0x28B3A693) + (string)e16Mp8D95JkPfhMsgRH7() + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x684F243E ^ 0x684FBF0A) + HCyG5O9noVsgyuSFnBDR.qGP9nbdqs15() + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-839659358 ^ -839693410);
	}

	private void FeB27H2UtLy(object P_0, RoutedEventArgs P_1)
	{
		ButtonUpdate.IsEnabled = false;
		CheckBoxHideUpdate.Visibility = Visibility.Collapsed;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				l4Z27DrKmq5 = new WebClient();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
				{
					num = 0;
				}
				continue;
			case 1:
				vxkiPPD9SMXXlgWRsuHF(ProgressBar, Visibility.Visible);
				num = 2;
				continue;
			}
			l4Z27DrKmq5.DownloadProgressChanged += delegate(object obj, DownloadProgressChangedEventArgs e)
			{
				if (!xLS27b2RFpr)
				{
					ProgressBar.Value = e.ProgressPercentage;
				}
			};
			A1hE4ED9xS6xjKrgdJ7D(l4Z27DrKmq5, (AsyncCompletedEventHandler)delegate
			{
				int num2 = 1;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						base.DialogResult = true;
						YBM4e4D9esMs7JiVqrUc(this);
						return;
					case 1:
						if (xLS27b2RFpr)
						{
							return;
						}
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
						{
							num3 = 0;
						}
						break;
					}
				}
			});
			l4Z27DrKmq5.DownloadFileAsync(new Uri(HCyG5O9noVsgyuSFnBDR.Oot9nsOnVj6()), HCyG5O9noVsgyuSFnBDR.ejh9nd4SZZ5());
			return;
		}
	}

	private void sig27f70N2b(object P_0, RoutedEventArgs P_1)
	{
		xLS27b2RFpr = true;
		WebClient webClient = l4Z27DrKmq5;
		if (webClient == null)
		{
			goto IL_001b;
		}
		webClient.CancelAsync();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			goto IL_004a;
		}
		goto IL_001b;
		IL_004a:
		YBM4e4D9esMs7JiVqrUc(this);
		return;
		IL_001b:
		if (HideUpdate)
		{
			((zObClP99fKcOtAs5v4hK)jci6l3D9Lu6Pus4JLT84()).VnT99x65kA1 = HCyG5O9noVsgyuSFnBDR.UpdateVersion;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_004a;
	}

	private void swb279N8Ty9(object P_0, RequestNavigateEventArgs P_1)
	{
		try
		{
			jIl2SaD9XpjfmZyevyGl(Y7WC6GD9sZwNqabCH1nR(P_1.Uri));
		}
		catch (Exception)
		{
			LogManager.WriteFake();
		}
		finally
		{
			P_1.Handled = true;
		}
	}

	private void Hm327n1YPxL(object P_0, MouseEventArgs P_1)
	{
		N01114D9jMMBQxgWggGn(ChangelogHyperlink, DHhTuPD9cJnQxu9jQCbs());
	}

	private void vom27Ga4ykt(object P_0, MouseEventArgs P_1)
	{
		ChangelogHyperlink.TextDecorations = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!TYO27NodUon)
		{
			TYO27NodUon = true;
			Uri resourceLocator = new Uri((string)YUGuCaD9bhBu9HiUCK1O(-1325234765 ^ -1325242639), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
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
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 2:
			ChangelogHyperlink = (Hyperlink)P_1;
			ChangelogHyperlink.RequestNavigate += swb279N8Ty9;
			ChangelogHyperlink.MouseEnter += Hm327n1YPxL;
			ChangelogHyperlink.MouseLeave += vom27Ga4ykt;
			num = 2;
			goto IL_0009;
		default:
			TYO27NodUon = true;
			break;
		case 1:
			TextBlockUpdateLink = (TextBlock)P_1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 5:
			ButtonUpdate = (Button)P_1;
			ButtonUpdate.Click += FeB27H2UtLy;
			num = 5;
			goto IL_0009;
		case 3:
			CheckBoxHideUpdate = (CheckBox)P_1;
			break;
		case 6:
			ButtonCancel = (Button)P_1;
			num = 4;
			goto IL_0009;
		case 4:
			{
				ProgressBar = (ProgressBar)P_1;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			IL_0009:
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					return;
				case 3:
					return;
				case 4:
					UysKWFD9ENfvD78vJPGp(ButtonCancel, new RoutedEventHandler(sig27f70N2b));
					num = 3;
					break;
				case 0:
					return;
				case 2:
					return;
				case 5:
					return;
				}
			}
		}
	}

	[CompilerGenerated]
	private void BKC27YKVOTe(object P_0, DownloadProgressChangedEventArgs P_1)
	{
		if (!xLS27b2RFpr)
		{
			ProgressBar.Value = P_1.ProgressPercentage;
		}
	}

	[CompilerGenerated]
	private void h3M27owVa2g(object P_0, AsyncCompletedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				base.DialogResult = true;
				YBM4e4D9esMs7JiVqrUc(this);
				return;
			case 1:
				if (xLS27b2RFpr)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static lZSoPh2wznASCRqf4soX()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool NQvDnLD9DJhVGDo8AOib(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object YUGuCaD9bhBu9HiUCK1O(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool rUjO1ND9lbtQ3l3qgOVP()
	{
		return Hk7lUXD9iteWe2T9s5BZ == null;
	}

	internal static lZSoPh2wznASCRqf4soX VQvMFID94vvVq64EgnWE()
	{
		return Hk7lUXD9iteWe2T9s5BZ;
	}

	internal static void zxMDhcD9NRINb6OyIHsH(object P_0)
	{
		mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW((string)P_0);
	}

	internal static object UloMZsD9kItd2j03FX8J()
	{
		return HCyG5O9noVsgyuSFnBDR.Sw69nx7UhJ0();
	}

	internal static void GglF3fD91IT6wpuH92at(object P_0, object P_1)
	{
		((Hyperlink)P_0).NavigateUri = (Uri)P_1;
	}

	internal static object e16Mp8D95JkPfhMsgRH7()
	{
		return HCyG5O9noVsgyuSFnBDR.UpdateVersion;
	}

	internal static void vxkiPPD9SMXXlgWRsuHF(object P_0, Visibility P_1)
	{
		((UIElement)P_0).Visibility = P_1;
	}

	internal static void A1hE4ED9xS6xjKrgdJ7D(object P_0, object P_1)
	{
		((WebClient)P_0).DownloadFileCompleted += (AsyncCompletedEventHandler)P_1;
	}

	internal static object jci6l3D9Lu6Pus4JLT84()
	{
		return j18iDj9nukSCmEyZs5lH.lmf9GS9l7aG();
	}

	internal static void YBM4e4D9esMs7JiVqrUc(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static object Y7WC6GD9sZwNqabCH1nR(object P_0)
	{
		return ((Uri)P_0).AbsoluteUri;
	}

	internal static object jIl2SaD9XpjfmZyevyGl(object P_0)
	{
		return Process.Start((string)P_0);
	}

	internal static object DHhTuPD9cJnQxu9jQCbs()
	{
		return TextDecorations.Underline;
	}

	internal static void N01114D9jMMBQxgWggGn(object P_0, object P_1)
	{
		((Inline)P_0).TextDecorations = (TextDecorationCollection)P_1;
	}

	internal static void UysKWFD9ENfvD78vJPGp(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
