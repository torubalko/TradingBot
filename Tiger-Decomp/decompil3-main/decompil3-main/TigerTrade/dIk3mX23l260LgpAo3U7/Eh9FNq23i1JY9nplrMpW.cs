using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ActiproSoftware.Windows.Controls.Primitives;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Annotations;
using TigerTrade.Properties;
using TigerTrade.Tc;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace dIk3mX23l260LgpAo3U7;

public sealed class Eh9FNq23i1JY9nplrMpW : PartEditBoxBase<string>, INotifyPropertyChanged
{
	private enum TXZf3jnIXlDLjDCAYOd1
	{
		AccountName
	}

	public class v7YxEHnIjkWUgh2kmFuH
	{
		private readonly string qNinIgb7WBs;

		private readonly string mspnIRklq8A;

		private static v7YxEHnIjkWUgh2kmFuH uwAkgeN1WueaIqvIgobc;

		public string Value => mspnIRklq8A;

		public string Title => qNinIgb7WBs;

		public v7YxEHnIjkWUgh2kmFuH(string P_0, string P_1)
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			qNinIgb7WBs = P_0;
			mspnIRklq8A = P_1;
		}

		public v7YxEHnIjkWUgh2kmFuH(Account P_0)
		{
			LO64V7N1TAjy3jyAn8VE();
			this._002Ector(VfXnIEvMYJb(P_0), P_0.AccountID);
		}

		public v7YxEHnIjkWUgh2kmFuH()
		{
			LO64V7N1TAjy3jyAn8VE();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			mspnIRklq8A = null;
			qNinIgb7WBs = VfXnIEvMYJb(null);
		}

		public override string ToString()
		{
			return qNinIgb7WBs;
		}

		public static string VfXnIEvMYJb(Account P_0)
		{
			int num = 1;
			int num2 = num;
			string text;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
				{
					if (P_0 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					object obj2 = ScJNrLN1yH3eDi3cTAQe(P_0);
					if (obj2 == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = ((ConnectionInfo)obj2).ConnectionName;
					goto IL_0100;
				}
				case 3:
					text = (string)JNvaloN1ZcJq39TMZlHR();
					break;
				default:
					obj = null;
					goto IL_0100;
				case 2:
					{
						obj = null;
						goto IL_0100;
					}
					IL_0100:
					text = (string)obj;
					if (text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-617064403 ^ -617068579))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					break;
				}
				break;
			}
			if (P_0 != null)
			{
				return text + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-671204305 ^ -671177219) + (string)YgxuFkN1VLa1AJcsGiot(P_0);
			}
			return TigerTrade.Properties.Resources.SelectAccountWindowNoAccounts;
		}

		static v7YxEHnIjkWUgh2kmFuH()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool ydye9DN1tN6mJWeV15AB()
		{
			return uwAkgeN1WueaIqvIgobc == null;
		}

		internal static v7YxEHnIjkWUgh2kmFuH JP2PUMN1UA88LdHKHKHv()
		{
			return uwAkgeN1WueaIqvIgobc;
		}

		internal static void LO64V7N1TAjy3jyAn8VE()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static object ScJNrLN1yH3eDi3cTAQe(object P_0)
		{
			return ((Account)P_0).Connection;
		}

		internal static object JNvaloN1ZcJq39TMZlHR()
		{
			return TigerTrade.Properties.Resources.AccountSimulatorViewName;
		}

		internal static object YgxuFkN1VLa1AJcsGiot(object P_0)
		{
			return ((Account)P_0).Name;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class RrijRKnI6Mw1uFihrw1A
	{
		public static readonly RrijRKnI6Mw1uFihrw1A iPOnIOQCHMU;

		public static Func<Account, string> ONmnIq73leC;

		internal static RrijRKnI6Mw1uFihrw1A ly1dEiN1CJeHjtdV6xvg;

		static RrijRKnI6Mw1uFihrw1A()
		{
			rnUAMxN1mBfOYTNiD1np();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			iPOnIOQCHMU = new RrijRKnI6Mw1uFihrw1A();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public RrijRKnI6Mw1uFihrw1A()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal string hMUnIMtcExc(Account c)
		{
			return (string)FIYdIGN1hqXHtmY73PnU(c);
		}

		internal static void rnUAMxN1mBfOYTNiD1np()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool LLyDCxN1r4ybV8aReFli()
		{
			return ly1dEiN1CJeHjtdV6xvg == null;
		}

		internal static RrijRKnI6Mw1uFihrw1A RKvlflN1KXafbhscdXxC()
		{
			return ly1dEiN1CJeHjtdV6xvg;
		}

		internal static object FIYdIGN1hqXHtmY73PnU(object P_0)
		{
			return ((Account)P_0).Name;
		}
	}

	[CompilerGenerated]
	private ObservableCollection<v7YxEHnIjkWUgh2kmFuH> cl123eircxn;

	public static readonly DependencyProperty HGW23sDVrpf;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static Eh9FNq23i1JY9nplrMpW USdGJ0DYpJtVFGjRhFfy;

	public v7YxEHnIjkWUgh2kmFuH Account
	{
		get
		{
			return null;
		}
		set
		{
			base.Value = v7YxEHnIjkWUgh2kmFuH?.Value;
			base.IsPopupOpen = false;
		}
	}

	public ObservableCollection<v7YxEHnIjkWUgh2kmFuH> Accounts
	{
		[CompilerGenerated]
		get
		{
			return cl123eircxn;
		}
		[CompilerGenerated]
		set
		{
			cl123eircxn = observableCollection;
		}
	}

	public string SymbolFilter
	{
		get
		{
			return (string)KJsf4LDo0PX7qD7iFktI(this, HGW23sDVrpf);
		}
		set
		{
			SetValue(HGW23sDVrpf, value2);
		}
	}

	private TXZf3jnIXlDLjDCAYOd1 Mode
	{
		get
		{
			if (!u7PIASDo9xlY12eh2JG9(this))
			{
				return (TXZf3jnIXlDLjDCAYOd1)1;
			}
			return TXZf3jnIXlDLjDCAYOd1.AccountName;
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
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
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
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
					{
						num = 1;
					}
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 2;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
				{
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					goto case 1;
				}
				case 1:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected override void OnTextInput(TextCompositionEventArgs P_0)
	{
		Iur73xDo25js0cagwO3U(this, P_0);
		if (!base.IsEditable)
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.Value = Accounts.FirstOrDefault((v7YxEHnIjkWUgh2kmFuH v7YxEHnIjkWUgh2kmFuH) => (string)MoylayDoNcU0YMnB87jN(v7YxEHnIjkWUgh2kmFuH) == (string)YbZbc3DokDWbeY74hKGp(this))?.Value;
	}

	public Eh9FNq23i1JY9nplrMpW()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		Accounts = new ObservableCollection<v7YxEHnIjkWUgh2kmFuH>();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override void OnKeyDown(KeyEventArgs P_0)
	{
		int num;
		if (!base.IsEditable || (P_0.Key != Key.Return && WEU6BJDoHJH2eVNxZf9i(P_0) != Key.Return))
		{
			base.OnKeyDown(P_0);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
			{
				num = 0;
			}
		}
		else
		{
			EmbeddedTextBox obj = P_0.OriginalSource as EmbeddedTextBox;
			if (obj == null)
			{
				goto IL_001f;
			}
			obj.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
			{
				num = 2;
			}
		}
		goto IL_0009;
		IL_001f:
		M0FeyWDofdn29xsZ5Hei(P_0, true);
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
		{
			num = 1;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		default:
			return;
		case 2:
			break;
		case 1:
			return;
		case 0:
			return;
		}
		goto IL_001f;
	}

	private void XBN234YlNN0()
	{
		if (!base.IsPopupOpen)
		{
			return;
		}
		VeOlgbDonFgvXWNUkegR(Accounts);
		int num = 7;
		Symbol symbol = default(Symbol);
		List<Account>.Enumerator enumerator = default(List<Account>.Enumerator);
		List<Account> list = default(List<Account>);
		while (true)
		{
			switch (num)
			{
			case 3:
				symbol = SymbolManager.Get(SymbolFilter);
				num = 4;
				break;
			case 1:
				try
				{
					while (enumerator.MoveNext())
					{
						Account current2 = enumerator.Current;
						Accounts.Add(new v7YxEHnIjkWUgh2kmFuH(current2));
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				if (drTQEfDoG8agEIgpjOy1(Accounts) == 0)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 == 0)
					{
						num = 0;
					}
					break;
				}
				goto case 2;
			case 7:
				list = new List<Account>();
				if (!string.IsNullOrEmpty(SymbolFilter))
				{
					num = 3;
					break;
				}
				goto case 6;
			case 4:
				if (symbol != null)
				{
					list = DataManager.GetAccounts(symbol);
				}
				goto IL_0206;
			default:
				Accounts.Add(new v7YxEHnIjkWUgh2kmFuH());
				num = 5;
				break;
			case 2:
			case 5:
				IO023D0a9UA((string)I3vsRMDooNAqY120nTI3(0x6F7F734B ^ 0x6F7F6F45));
				return;
			case 6:
				{
					list = DataManager.GetAccounts();
					goto IL_0206;
				}
				IL_0206:
				if (Mode == (TXZf3jnIXlDLjDCAYOd1)1)
				{
					enumerator = list.GetEnumerator();
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
					{
						num = 1;
					}
					break;
				}
				if (Mode == TXZf3jnIXlDLjDCAYOd1.AccountName)
				{
					IEnumerator<string> enumerator2 = list.Select((Account c) => (string)RrijRKnI6Mw1uFihrw1A.FIYdIGN1hqXHtmY73PnU(c)).Distinct().GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							string current = enumerator2.Current;
							Accounts.Add(new v7YxEHnIjkWUgh2kmFuH(current, current));
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							QVCE8RDoY6HSOkXAvfp9(enumerator2);
						}
					}
				}
				goto case 2;
			}
		}
	}

	protected override string ConvertToString(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return null;
		}
		if (Mode == TXZf3jnIXlDLjDCAYOd1.AccountName)
		{
			return P_0;
		}
		return v7YxEHnIjkWUgh2kmFuH.VfXnIEvMYJb((Account)jGfvUHDov9sbPjIXQZ3b(P_0));
	}

	protected override IncrementalChangeRequest<string> CreateIncrementalChangeRequest(IncrementalChangeRequestKind P_0)
	{
		return new IncrementalChangeRequest<string>();
	}

	protected override IList<IPart> GenerateParts()
	{
		return new List<IPart>();
	}

	protected override bool IsValidValue(string P_0)
	{
		return true;
	}

	protected override void RaiseValueChangedEvent()
	{
	}

	protected override void ResetValue()
	{
	}

	protected override bool TryConvertFromString(string P_0, bool P_1, out string P_2)
	{
		P_2 = P_0;
		return true;
	}

	[NotifyPropertyChangedInvocator]
	private void IO023D0a9UA([CallerMemberName] string propertyName = null)
	{
		PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
		if (propertyChangedEventHandler != null)
		{
			jpLPa0DoBpeUnLA6t8rH(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
		}
	}

	protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (o11Vd0DolmmIq1YfZ9ah(R0TpDLDoi5NqTVsEiYMn(P_0.Property), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28C965BE ^ 0x28C997A0)))
				{
					XBN234YlNN0();
				}
				return;
			case 1:
				EWvaxKDoaYb36PYjmCP8(this, P_0);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static Eh9FNq23i1JY9nplrMpW()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		ORsZcpDo4bUHyOr4smcy();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		HGW23sDVrpf = DependencyProperty.Register((string)I3vsRMDooNAqY120nTI3(-671204305 ^ -671166953), axd7fADobRHLBvdXA3mS(AqYJXNDoDXJ69EcHR9DE(16777226)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555160)), new PropertyMetadata(""));
	}

	[CompilerGenerated]
	private bool C3y23bvEEHg(v7YxEHnIjkWUgh2kmFuH P_0)
	{
		return (string)MoylayDoNcU0YMnB87jN(P_0) == (string)YbZbc3DokDWbeY74hKGp(this);
	}

	internal static bool vZZdHADYu6eaNdpn44Gp()
	{
		return USdGJ0DYpJtVFGjRhFfy == null;
	}

	internal static Eh9FNq23i1JY9nplrMpW Rckk5ZDYzjAnWoOCl4oQ()
	{
		return USdGJ0DYpJtVFGjRhFfy;
	}

	internal static object KJsf4LDo0PX7qD7iFktI(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void Iur73xDo25js0cagwO3U(object P_0, object P_1)
	{
		((UIElement)P_0).OnTextInput((TextCompositionEventArgs)P_1);
	}

	internal static Key WEU6BJDoHJH2eVNxZf9i(object P_0)
	{
		return ((KeyEventArgs)P_0).Key;
	}

	internal static void M0FeyWDofdn29xsZ5Hei(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}

	internal static bool u7PIASDo9xlY12eh2JG9(object P_0)
	{
		return ((PartEditBoxBase<string>)P_0).IsEditable;
	}

	internal static void VeOlgbDonFgvXWNUkegR(object P_0)
	{
		((Collection<v7YxEHnIjkWUgh2kmFuH>)P_0).Clear();
	}

	internal static int drTQEfDoG8agEIgpjOy1(object P_0)
	{
		return ((Collection<v7YxEHnIjkWUgh2kmFuH>)P_0).Count;
	}

	internal static void QVCE8RDoY6HSOkXAvfp9(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object I3vsRMDooNAqY120nTI3(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object jGfvUHDov9sbPjIXQZ3b(object P_0)
	{
		return DataManager.GetAccount((string)P_0);
	}

	internal static void jpLPa0DoBpeUnLA6t8rH(object P_0, object P_1, object P_2)
	{
		P_0(P_1, (PropertyChangedEventArgs)P_2);
	}

	internal static void EWvaxKDoaYb36PYjmCP8(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((FrameworkElement)P_0).OnPropertyChanged(P_1);
	}

	internal static object R0TpDLDoi5NqTVsEiYMn(object P_0)
	{
		return ((DependencyProperty)P_0).Name;
	}

	internal static bool o11Vd0DolmmIq1YfZ9ah(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void ORsZcpDo4bUHyOr4smcy()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static RuntimeTypeHandle AqYJXNDoDXJ69EcHR9DE(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static Type axd7fADobRHLBvdXA3mS(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object MoylayDoNcU0YMnB87jN(object P_0)
	{
		return ((v7YxEHnIjkWUgh2kmFuH)P_0).Title;
	}

	internal static object YbZbc3DokDWbeY74hKGp(object P_0)
	{
		return ((PartEditBoxBase<string>)P_0).CurrentText;
	}
}
