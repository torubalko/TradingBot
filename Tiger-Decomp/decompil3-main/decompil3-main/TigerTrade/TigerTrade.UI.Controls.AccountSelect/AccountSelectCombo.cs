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
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls;
using ciQ7MQHkM693awgKHy3A;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Properties;
using TigerTrade.Tc;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace TigerTrade.UI.Controls.AccountSelect;

internal sealed class AccountSelectCombo : aUQvKjHk6H77hbYGG0GM, IComponentConnector
{
	public class VAUtclnIIkRnDlOgsNi4
	{
		[CompilerGenerated]
		private readonly Account ALInItLpx5b;

		internal static VAUtclnIIkRnDlOgsNi4 KaCrM1N1wrjRwDZbZn5C;

		public Account Account
		{
			[CompilerGenerated]
			get
			{
				return ALInItLpx5b;
			}
		}

		public VAUtclnIIkRnDlOgsNi4(Account P_0)
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			ALInItLpx5b = P_0;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public override string ToString()
		{
			int num = 2;
			int num2 = num;
			object obj;
			while (true)
			{
				switch (num2)
				{
				case 2:
				{
					Account account = Account;
					if (account == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					ConnectionInfo connection = account.Connection;
					if (connection == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea != 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = connection.ConnectionName;
					break;
				}
				case 1:
					obj = null;
					break;
				default:
					obj = null;
					break;
				}
				break;
			}
			string text = (string)obj;
			if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-490987856 ^ -490995392))
			{
				text = TigerTrade.Properties.Resources.AccountSimulatorViewName;
			}
			string text2 = text;
			object obj2 = iUy6SJN1A3nYSF1Rgahj(-1461949456 ^ -1461915102);
			Account account2 = Account;
			return text2 + (string)obj2 + (string)((account2 != null) ? iSY3U6N1PPcvWA4nfUaT(account2) : null);
		}

		static VAUtclnIIkRnDlOgsNi4()
		{
			nhhLLBN1Jp5ybkZlj3QW();
		}

		internal static bool E4ZslVN17hgxTqC4UFDx()
		{
			return KaCrM1N1wrjRwDZbZn5C == null;
		}

		internal static VAUtclnIIkRnDlOgsNi4 MdQgAkN18rsa0RufIioW()
		{
			return KaCrM1N1wrjRwDZbZn5C;
		}

		internal static object iUy6SJN1A3nYSF1Rgahj(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static object iSY3U6N1PPcvWA4nfUaT(object P_0)
		{
			return ((Account)P_0).Name;
		}

		internal static void nhhLLBN1Jp5ybkZlj3QW()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	private string _accountName;

	public static readonly DependencyProperty SelectedAccountProperty;

	public static readonly DependencyProperty SymbolFilterProperty;

	internal PopupButton PopupButton;

	internal ListBox ListBoxAccounts;

	private bool _contentLoaded;

	internal static AccountSelectCombo R1SydZDo1wPlLpKmP8qH;

	public string AccountName
	{
		get
		{
			return _accountName;
		}
		set
		{
			if (!(value == _accountName))
			{
				_accountName = value;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2BD86B18 ^ 0x2BD8994C));
			}
		}
	}

	public ObservableCollection<VAUtclnIIkRnDlOgsNi4> Accounts { get; set; }

	public string SelectedAccount
	{
		get
		{
			return (string)GetValue(SelectedAccountProperty);
		}
		set
		{
			SetValue(SelectedAccountProperty, value);
		}
	}

	public string SymbolFilter
	{
		get
		{
			return (string)GetValue(SymbolFilterProperty);
		}
		set
		{
			foy3j8DoePgQ22c87map(this, SymbolFilterProperty, value);
		}
	}

	private static void PropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
	{
		int num = 3;
		int num2 = num;
		AccountSelectCombo accountSelectCombo = default(AccountSelectCombo);
		Account account = default(Account);
		string text = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				return;
			case 2:
				if (accountSelectCombo == null)
				{
					return;
				}
				account = DataManager.GetAccount(args.NewValue as string);
				if (account == null)
				{
					obj = null;
				}
				else
				{
					ConnectionInfo connection = account.Connection;
					if (connection == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					obj = kpGDjqDoxj8dtRb13TtK(connection);
				}
				goto IL_00ef;
			case 3:
				accountSelectCombo = dependencyObject as AccountSelectCombo;
				num2 = 2;
				continue;
			case 0:
				return;
			case 1:
				obj = null;
				goto IL_00ef;
			case 4:
				break;
				IL_00ef:
				text = (string)obj;
				if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C7F516))
				{
					text = TigerTrade.Properties.Resources.AccountSimulatorViewName;
					num2 = 4;
					continue;
				}
				break;
			}
			accountSelectCombo.AccountName = ((account != null) ? (text + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2074141628 ^ -2074114666) + (string)x1TIPXDoLNjsOVvZZp49(account)) : "");
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
			{
				num2 = 0;
			}
		}
	}

	public AccountSelectCombo()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Accounts = new ObservableCollection<VAUtclnIIkRnDlOgsNi4>();
		InitializeComponent();
	}

	private void AccountSelectCombo_OnLoaded(object sender, RoutedEventArgs e)
	{
	}

	private void ListBoxAccounts_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		PopupButton.IsPopupOpen = false;
		if (g9Wa4fDosnMBL5VFeFZV(ListBoxAccounts) != null)
		{
			SelectedAccount = (ListBoxAccounts.SelectedItem as VAUtclnIIkRnDlOgsNi4)?.Account.AccountID;
			ListBoxAccounts.SelectedItem = null;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
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

	private void PopupButton_PopupOpening(object sender, CancelRoutedEventArgs e)
	{
		Accounts.Clear();
		List<Account> list = new List<Account>();
		Symbol symbol = default(Symbol);
		int num;
		if (!string.IsNullOrEmpty(SymbolFilter))
		{
			symbol = SymbolManager.Get(SymbolFilter);
			num = 3;
		}
		else
		{
			list = DataManager.GetAccounts();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
			{
				num = 0;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				list = DataManager.GetAccounts(symbol);
				break;
			case 3:
				if (symbol != null)
				{
					goto IL_009b;
				}
				break;
			case 1:
				return;
			}
			break;
			IL_009b:
			num = 2;
		}
		foreach (Account item in list)
		{
			Accounts.Add(new VAUtclnIIkRnDlOgsNi4(item));
			int num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E04D49E), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)jaP3ZCDoX9dmixbINLM2(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId != 1)
		{
			int num;
			if (connectionId != 2)
			{
				_contentLoaded = true;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
				{
					num = 0;
				}
			}
			else
			{
				ListBoxAccounts = (ListBox)target;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
				{
					num = 1;
				}
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
					return;
				case 1:
					ListBoxAccounts.SelectionChanged += ListBoxAccounts_OnSelectionChanged;
					num = 2;
					break;
				case 0:
					return;
				}
			}
		}
		PopupButton = (PopupButton)target;
		PopupButton.PopupOpening += PopupButton_PopupOpening;
	}

	static AccountSelectCombo()
	{
		UvcaL4DocDeelun2Nbfh();
		Q6vmuKDojPX9WlGr2Znf();
		SelectedAccountProperty = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--134855371 ^ 0x8096A9F), Type.GetTypeFromHandle(Wq0IWfDoEBdJ7I7ybNHg(16777226)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555164)), new PropertyMetadata("", PropertyChangedCallback));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		SymbolFilterProperty = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1487846E ^ 0x14877656), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777226)), Type.GetTypeFromHandle(Wq0IWfDoEBdJ7I7ybNHg(33555164)), new PropertyMetadata(""));
	}

	internal static bool VT3jDoDo51l5pTfpEGjy()
	{
		return R1SydZDo1wPlLpKmP8qH == null;
	}

	internal static AccountSelectCombo PwlxenDoSQt843NterZ6()
	{
		return R1SydZDo1wPlLpKmP8qH;
	}

	internal static object kpGDjqDoxj8dtRb13TtK(object P_0)
	{
		return ((ConnectionInfo)P_0).ConnectionName;
	}

	internal static object x1TIPXDoLNjsOVvZZp49(object P_0)
	{
		return ((Account)P_0).Name;
	}

	internal static void foy3j8DoePgQ22c87map(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static object g9Wa4fDosnMBL5VFeFZV(object P_0)
	{
		return ((Selector)P_0).SelectedItem;
	}

	internal static object jaP3ZCDoX9dmixbINLM2(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void UvcaL4DocDeelun2Nbfh()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void Q6vmuKDojPX9WlGr2Znf()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static RuntimeTypeHandle Wq0IWfDoEBdJ7I7ybNHg(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}
}
