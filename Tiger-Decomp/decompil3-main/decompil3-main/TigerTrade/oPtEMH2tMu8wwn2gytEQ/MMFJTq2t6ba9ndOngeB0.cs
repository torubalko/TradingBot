using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using ECOEgqlSad8NUJZ2Dr9n;
using OWUMXkHkWgCUprHQ3jb9;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;

namespace oPtEMH2tMu8wwn2gytEQ;

internal class MMFJTq2t6ba9ndOngeB0 : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	public class DeCqsEnMutTim23yM34E
	{
		[CompilerGenerated]
		private readonly Account JFvnO07NWhX;

		private static DeCqsEnMutTim23yM34E ITRolCNNRI1anZX0NTkB;

		public Account Account
		{
			[CompilerGenerated]
			get
			{
				return JFvnO07NWhX;
			}
		}

		public DeCqsEnMutTim23yM34E(Account P_0)
		{
			EpG775NNOMpZT98FQeCC();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			JFvnO07NWhX = P_0;
		}

		public DeCqsEnMutTim23yM34E()
		{
			EpG775NNOMpZT98FQeCC();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			JFvnO07NWhX = null;
		}

		public override string ToString()
		{
			if (Account != null)
			{
				return Account.Connection.ConnectionName + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2123795572 ^ -2123765154) + Account.Name;
			}
			return TigerTrade.Properties.Resources.SelectAccountWindowNoAccounts;
		}

		static DeCqsEnMutTim23yM34E()
		{
			kQ8EO5NNqFea2TSYTaYE();
		}

		internal static void EpG775NNOMpZT98FQeCC()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool G3TtbvNN6oBnj8KhjHn4()
		{
			return ITRolCNNRI1anZX0NTkB == null;
		}

		internal static DeCqsEnMutTim23yM34E LIeKRPNNMS7EIgqrNfT7()
		{
			return ITRolCNNRI1anZX0NTkB;
		}

		internal static void kQ8EO5NNqFea2TSYTaYE()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[CompilerGenerated]
	private ObservableCollection<DeCqsEnMutTim23yM34E> F8X2trVchLm;

	private DeCqsEnMutTim23yM34E eHj2tKFd19P;

	[CompilerGenerated]
	private Symbol zTQ2tmtwDO0;

	[CompilerGenerated]
	private Account ASb2thBYmal;

	internal Button ButtonOk;

	internal Button ButtonCancel;

	private bool peq2twLjHnJ;

	internal static MMFJTq2t6ba9ndOngeB0 YBnNsn4pc8iYogvPWkwy;

	public ObservableCollection<DeCqsEnMutTim23yM34E> Accounts
	{
		[CompilerGenerated]
		get
		{
			return F8X2trVchLm;
		}
		[CompilerGenerated]
		set
		{
			F8X2trVchLm = f8X2trVchLm;
		}
	}

	public DeCqsEnMutTim23yM34E SelectedAccount
	{
		get
		{
			return eHj2tKFd19P;
		}
		set
		{
			eHj2tKFd19P = deCqsEnMutTim23yM34E;
			ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6F7F734B ^ 0x6F7FA31F));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			ifWlfmRSlkr((string)uIndJ24pQ0vO7eVC4yFj(-1583344314 ^ -1583299280));
		}
	}

	public Symbol Symbol
	{
		[CompilerGenerated]
		get
		{
			return zTQ2tmtwDO0;
		}
		[CompilerGenerated]
		set
		{
			zTQ2tmtwDO0 = symbol;
		}
	}

	public Account Account
	{
		[CompilerGenerated]
		get
		{
			return ASb2thBYmal;
		}
		[CompilerGenerated]
		set
		{
			ASb2thBYmal = aSb2thBYmal;
		}
	}

	public bool ButtonOkEnabled => SelectedAccount?.Account != null;

	public MMFJTq2t6ba9ndOngeB0()
	{
		KaiNMp4pdjDHWsZ7VKpZ();
		base._002Ector();
		Accounts = new ObservableCollection<DeCqsEnMutTim23yM34E>();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void SelectAccountWindow_Loaded(object sender, RoutedEventArgs e)
	{
		int num = 2;
		int num2 = num;
		List<Account>.Enumerator enumerator = default(List<Account>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				enumerator = DataManager.GetAccounts(Symbol).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					while (enumerator.MoveNext())
					{
						Account current = enumerator.Current;
						int num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						}
						Accounts.Add(new DeCqsEnMutTim23yM34E(current));
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				if (Accounts.Count != 0)
				{
					return;
				}
				Accounts.Add(new DeCqsEnMutTim23yM34E());
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void UWj2tOU3RrH(object P_0, RoutedEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (SelectedAccount?.Account != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_003a;
			default:
				Account = SelectedAccount.Account;
				goto IL_003a;
			case 2:
				{
					base.DialogResult = true;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
					{
						num2 = 0;
					}
					break;
				}
				IL_003a:
				Close();
				return;
			}
		}
	}

	private void erv2tqF9n07(object P_0, RoutedEventArgs P_1)
	{
		mZyq3Z4pgXDDHLv4Ix1y(this);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
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
			{
				if (peq2twLjHnJ)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
					{
						num2 = 0;
					}
					break;
				}
				peq2twLjHnJ = true;
				Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24B0B9E6 ^ 0x24B0697E), UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
				return;
			}
			case 0:
				return;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		if (P_0 != 1)
		{
			if (P_0 != 2)
			{
				peq2twLjHnJ = true;
				return;
			}
			ButtonCancel = (Button)P_1;
			UPyY4F4pRLjcPQVVQwri(ButtonCancel, new RoutedEventHandler(erv2tqF9n07));
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
			{
				num = 2;
			}
		}
		else
		{
			ButtonOk = (Button)P_1;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
			{
				num = 0;
			}
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				return;
			case 1:
				ButtonOk.Click += UWj2tOU3RrH;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	static MMFJTq2t6ba9ndOngeB0()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object uIndJ24pQ0vO7eVC4yFj(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool KJIKot4pjcYY5oRCKG45()
	{
		return YBnNsn4pc8iYogvPWkwy == null;
	}

	internal static MMFJTq2t6ba9ndOngeB0 IFHVgZ4pEUEtejuB1jHr()
	{
		return YBnNsn4pc8iYogvPWkwy;
	}

	internal static void KaiNMp4pdjDHWsZ7VKpZ()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void mZyq3Z4pgXDDHLv4Ix1y(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static void UPyY4F4pRLjcPQVVQwri(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
