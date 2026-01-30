using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using ECOEgqlSad8NUJZ2Dr9n;
using OWUMXkHkWgCUprHQ3jb9;
using pjO9twi2wnxVu9eTnHp;
using TigerTrade.Annotations;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Core.UI.Windows.SelectFolder;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TigerTrade.UI.Common;
using TuAMtrl1Nd3XoZQQUXf0;

namespace PaiaBwitDGVrqPrN87B;

internal class CxxE1SiWKriMgEOKuTj : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	public class hoK4AwnbHKSJ04Sk1da3 : INotifyPropertyChanged
	{
		public MPdIMTi0styk2MD4qWM Y4fnbGiNT84;

		[CompilerGenerated]
		private PropertyChangedEventHandler m_PropertyChanged;

		internal static hoK4AwnbHKSJ04Sk1da3 QCrsISN2jj2g1ST5bnqR;

		public bool IsChecked
		{
			get
			{
				return Y4fnbGiNT84.waaif4Okwr;
			}
			set
			{
				Y4fnbGiNT84.waaif4Okwr = waaif4Okwr;
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225816179));
			}
		}

		public string Name => Y4fnbGiNT84.Name;

		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				int num = 1;
				int num2 = num;
				PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
				while (true)
				{
					switch (num2)
					{
					case 2:
						return;
					case 1:
						propertyChangedEventHandler = this.m_PropertyChanged;
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
						{
							num2 = 0;
						}
						continue;
					}
					PropertyChangedEventHandler propertyChangedEventHandler2;
					do
					{
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					}
					while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
					{
						num2 = 2;
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
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					int num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 != 0)
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
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
						{
							num = 1;
						}
					}
				}
			}
		}

		public hoK4AwnbHKSJ04Sk1da3(MPdIMTi0styk2MD4qWM P_0)
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Y4fnbGiNT84 = P_0;
		}

		[NotifyPropertyChangedInvocator]
		protected virtual void ifWlfmRSlkr([CallerMemberName] string propertyName = null)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				h943BhN2dhMdeih5XBeg(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
			}
		}

		static hoK4AwnbHKSJ04Sk1da3()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool aBeVo7N2ELrq89BXevj2()
		{
			return QCrsISN2jj2g1ST5bnqR == null;
		}

		internal static hoK4AwnbHKSJ04Sk1da3 QOTl73N2Q5dLpHeqtYYG()
		{
			return QCrsISN2jj2g1ST5bnqR;
		}

		internal static void h943BhN2dhMdeih5XBeg(object P_0, object P_1, object P_2)
		{
			P_0(P_1, (PropertyChangedEventArgs)P_2);
		}
	}

	private string uBqlas8R8E;

	private string g2SlioJXQ4;

	private DateTime BRXll55DLh;

	[CompilerGenerated]
	private ObservableCollection<hoK4AwnbHKSJ04Sk1da3> Ctel4eipH7;

	private readonly List<MPdIMTi0styk2MD4qWM> GFilDgmvix;

	[CompilerGenerated]
	private readonly List<MPdIMTi0styk2MD4qWM> oDvlbPTFNa;

	[CompilerGenerated]
	private readonly ObservableCollection<Symbol> ThBlNq4W2V;

	private Symbol DcplkfToSV;

	private ICommand ztKl15MlDo;

	private ICommand Wsyl5qjeu3;

	private ICommand QAwlSwBs5B;

	private ICommand uTFlx4PkcE;

	internal TabControl TabControl;

	internal PopupButton PopupButtonSymbols;

	internal ListBox ListBoxSymbols;

	internal TextBox TextBoxSearch;

	internal ListBox ListBoxRecords;

	internal Button ButtonSelectPath;

	internal TextBox TextBoxPath;

	internal Button ButtonOk;

	internal Button ButtonCancel;

	private bool DE2lLJxTQ6;

	private static CxxE1SiWKriMgEOKuTj DvjSxLlJXOKC3NTVoWD0;

	public string SearchString
	{
		get
		{
			return uBqlas8R8E;
		}
		set
		{
			int num;
			if (XDyacXlJEcitUs525iE5(uBqlas8R8E, text.ToLower()))
			{
				itliyVxL7Y(uBqlas8R8E);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
				{
					num = 0;
				}
			}
			else
			{
				uBqlas8R8E = (string)TkRD6IlJQ6quqPSuHi3x(text);
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C7C112));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
				{
					num = 1;
				}
			}
			switch (num)
			{
			case 0:
				break;
			case 1:
				itliyVxL7Y(uBqlas8R8E);
				break;
			}
		}
	}

	public string RecordsPath
	{
		get
		{
			return g2SlioJXQ4;
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
					if (text == g2SlioJXQ4)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
						{
							num2 = 0;
						}
						break;
					}
					g2SlioJXQ4 = text;
					ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1487846E ^ 0x1487A87E));
					WOLiUGOYta();
					return;
				case 0:
					return;
				}
			}
		}
	}

	public DateTime RecordsDate
	{
		get
		{
			return BRXll55DLh;
		}
		set
		{
			if (I39lgilJdmKbD33P5oB9(dateTime, TimeHelper.LocalTime.Date.AddYears(-10)) || dateTime > UeugZAlJgSpFYqi3OULs().Date.AddDays(2.0))
			{
				dateTime = UeugZAlJgSpFYqi3OULs();
			}
			if (dateTime == BRXll55DLh)
			{
				return;
			}
			BRXll55DLh = dateTime;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-181342698 ^ -181353924));
					num = 2;
					break;
				case 1:
					return;
				case 2:
					WOLiUGOYta();
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
					{
						num = 1;
					}
					break;
				}
			}
		}
	}

	public ObservableCollection<hoK4AwnbHKSJ04Sk1da3> Records
	{
		[CompilerGenerated]
		get
		{
			return Ctel4eipH7;
		}
		[CompilerGenerated]
		set
		{
			Ctel4eipH7 = ctel4eipH;
		}
	}

	public ObservableCollection<Symbol> Symbols
	{
		[CompilerGenerated]
		get
		{
			return ThBlNq4W2V;
		}
	}

	public Symbol SelectedSymbol
	{
		get
		{
			return DcplkfToSV;
		}
		set
		{
			if (!eTdYmwlJKns0iidUWSAn(symbol, DcplkfToSV))
			{
				DcplkfToSV = symbol;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-29702950 ^ -29693794));
			}
		}
	}

	public ICommand MoveUpCommand => ztKl15MlDo ?? (ztKl15MlDo = new RelayCommand(delegate
	{
		rjciCmeYbm(-1);
	}, (object P_0) => SelectedSymbol != null && Symbols.IndexOf(SelectedSymbol) != 0));

	public ICommand MoveDownCommand => Wsyl5qjeu3 ?? (Wsyl5qjeu3 = new RelayCommand(delegate
	{
		rjciCmeYbm(1);
	}, (object P_0) => SelectedSymbol != null && Symbols.IndexOf(SelectedSymbol) != Symbols.Count - 1));

	public ICommand RemoveCommand => QAwlSwBs5B ?? (QAwlSwBs5B = new RelayCommand(delegate
	{
		Symbols.Remove(SelectedSymbol);
	}, (object P_0) => SelectedSymbol != null));

	public ICommand ClearCommand => uTFlx4PkcE ?? (uTFlx4PkcE = new RelayCommand(delegate
	{
		QIYWISlJ8eCpKWEiatso(Symbols);
	}));

	[SpecialName]
	[CompilerGenerated]
	public List<MPdIMTi0styk2MD4qWM> kbll0Z7cvD()
	{
		return oDvlbPTFNa;
	}

	public CxxE1SiWKriMgEOKuTj()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				RecordsDate = UeugZAlJgSpFYqi3OULs().Date;
				ThBlNq4W2V = new ObservableCollection<Symbol>();
				InitializeComponent();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 2:
				Records = new ObservableCollection<hoK4AwnbHKSJ04Sk1da3>();
				GFilDgmvix = new List<MPdIMTi0styk2MD4qWM>();
				oDvlbPTFNa = new List<MPdIMTi0styk2MD4qWM>();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	private void WOLiUGOYta()
	{
		gkQhTClJRxeqOgLciGm0(GFilDgmvix);
		IUhM5TlJ6RrL0OmTpPwt(Records);
		try
		{
			int num;
			if (oqdqBllJMAWLWfYHXxNA(RecordsPath))
			{
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
				{
					num = 6;
				}
				goto IL_0066;
			}
			goto IL_00c2;
			IL_0066:
			string fileNameWithoutExtension = default(string);
			MPdIMTi0styk2MD4qWM mPdIMTi0styk2MD4qWM = default(MPdIMTi0styk2MD4qWM);
			string text = default(string);
			int num2 = default(int);
			string[] files = default(string[]);
			while (true)
			{
				switch (num)
				{
				case 2:
				{
					if (fileNameWithoutExtension == null)
					{
						goto IL_00f8;
					}
					mPdIMTi0styk2MD4qWM = new MPdIMTi0styk2MD4qWM
					{
						lk2iHiwjDf = RecordsDate,
						Name = fileNameWithoutExtension.Substring(0, Cj1mlNlJOvqKeDLtFIqj(fileNameWithoutExtension) - 11),
						OMbi9LrenC = text
					};
					GFilDgmvix.Add(mPdIMTi0styk2MD4qWM);
					int num3 = 4;
					num = num3;
					continue;
				}
				case 6:
					return;
				case 3:
					break;
				case 4:
					Records.Add(new hoK4AwnbHKSJ04Sk1da3(mPdIMTi0styk2MD4qWM));
					goto IL_00f8;
				default:
					fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
					num = 2;
					continue;
				case 1:
				case 5:
					{
						if (num2 < files.Length)
						{
							text = files[num2];
							num = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
							{
								num = 0;
							}
							continue;
						}
						return;
					}
					IL_00f8:
					num2++;
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 != 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
			goto IL_00c2;
			IL_00c2:
			if (!Directory.Exists(RecordsPath))
			{
				return;
			}
			files = Directory.GetFiles(RecordsPath, string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D311F79), RecordsDate), SearchOption.AllDirectories);
			num2 = 0;
			num = 5;
			goto IL_0066;
		}
		catch (Exception ex)
		{
			JOSiQelJqBKryfobT6IX(ex);
		}
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		int num = 1;
		int num2 = num;
		Symbol symbol = default(Symbol);
		while (true)
		{
			switch (num2)
			{
			case 1:
				RecordsPath = ((MhMDPU9v8rkigy1ao0Th)qTco7RlJINkhKQiB7vUP()).RecordsPath;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				TabControl.SelectedIndex = 1;
				return;
			}
			RecordsDate = AXG626lJW0ZYTy3xSt7n(j18iDj9nukSCmEyZs5lH.Settings);
			using (List<string>.Enumerator enumerator = j18iDj9nukSCmEyZs5lH.Settings.MIF9l1e2psr.GetEnumerator())
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
						{
							num3 = 0;
						}
					}
					else
					{
						symbol = (Symbol)sVFZlTlJteyjAIplVJmO(enumerator.Current);
						if (symbol == null)
						{
							continue;
						}
						num3 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
						{
							num3 = 1;
						}
					}
					switch (num3)
					{
					case 1:
						Symbols.Add(symbol);
						continue;
					case 0:
						break;
					}
					break;
				}
			}
			if (!j18iDj9nukSCmEyZs5lH.Settings.JTx9likwZsd)
			{
				return;
			}
			num2 = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec == 0)
			{
				num2 = 0;
			}
		}
	}

	private void WwHiTpOCXc(object P_0, SelectionChangedEventArgs P_1)
	{
		MbK65ylJUsiB3IQ6VWed(ListBoxRecords, -1);
	}

	private void itliyVxL7Y(string P_0)
	{
		Records.Clear();
		if (GFilDgmvix == null)
		{
			return;
		}
		int num = 3;
		List<MPdIMTi0styk2MD4qWM>.Enumerator enumerator = default(List<MPdIMTi0styk2MD4qWM>.Enumerator);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 3:
			{
				if (string.IsNullOrEmpty(P_0))
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
					{
						num = 2;
					}
					break;
				}
				string text = P_0.ToLower();
				using List<MPdIMTi0styk2MD4qWM>.Enumerator enumerator2 = GFilDgmvix.GetEnumerator();
				while (true)
				{
					if (!enumerator2.MoveNext())
					{
						int num3 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
						{
							num3 = 1;
						}
						switch (num3)
						{
						case 1:
							return;
						}
					}
					MPdIMTi0styk2MD4qWM current2 = enumerator2.Current;
					if (pgI86ylJT7slNHejpWmx(TkRD6IlJQ6quqPSuHi3x(current2.Name), text))
					{
						Records.Add(new hoK4AwnbHKSJ04Sk1da3(current2));
					}
				}
			}
			case 2:
				enumerator = GFilDgmvix.GetEnumerator();
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				try
				{
					while (enumerator.MoveNext())
					{
						MPdIMTi0styk2MD4qWM current = enumerator.Current;
						Records.Add(new hoK4AwnbHKSJ04Sk1da3(current));
						int num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						}
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
			}
		}
	}

	private void mAJiZhJN9q(object P_0, RoutedEventArgs P_1)
	{
		N2ZiYWlJy0VQVB5nwYVo(j18iDj9nukSCmEyZs5lH.Settings, RecordsPath);
		j18iDj9nukSCmEyZs5lH.Settings.RecordsDate = RecordsDate;
		kbll0Z7cvD().Clear();
		IEnumerator<hoK4AwnbHKSJ04Sk1da3> enumerator = Records.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				hoK4AwnbHKSJ04Sk1da3 current = enumerator.Current;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						if (current.IsChecked)
						{
							kbll0Z7cvD().Add(current.Y4fnbGiNT84);
							num = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
							{
								num = 0;
							}
							continue;
						}
						break;
					case 1:
						break;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator == null)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			else
			{
				enumerator.Dispose();
			}
		}
		while (true)
		{
			((MhMDPU9v8rkigy1ao0Th)qTco7RlJINkhKQiB7vUP()).MIF9l1e2psr.Clear();
			int num3 = 3;
			while (true)
			{
				switch (num3)
				{
				case 1:
					return;
				case 3:
				{
					IEnumerator<Symbol> enumerator2 = Symbols.GetEnumerator();
					try
					{
						while (UwLSQHlJZwPnF8fIx3Ja(enumerator2))
						{
							Symbol current2 = enumerator2.Current;
							j18iDj9nukSCmEyZs5lH.Settings.MIF9l1e2psr.Add(current2.ID);
							int num4 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d3afdd6ad27a4c3b87071f1be51e7ef3 != 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							}
						}
					}
					finally
					{
						if (enumerator2 == null)
						{
							int num5 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
							{
								num5 = 0;
							}
							switch (num5)
							{
							case 0:
								break;
							}
						}
						else
						{
							oKAJWplJVWJpjpqEso2Z(enumerator2);
						}
					}
					oBUt1mlJCsun63a5Gfp9(j18iDj9nukSCmEyZs5lH.Settings, TabControl.SelectedIndex != 0);
					num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
					{
						num3 = 2;
					}
					continue;
				}
				case 2:
					base.DialogResult = true;
					PNM5pqlJruNCNkqBZYDq(this);
					num3 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
					{
						num3 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private void ln9iVluSeQ(object P_0, RoutedEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		SelectFolderWindow selectFolderWindow = default(SelectFolderWindow);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (selectFolderWindow.ShowDialog() != true)
				{
					return;
				}
				RecordsPath = selectFolderWindow.SelectedFolder;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				selectFolderWindow = new SelectFolderWindow
				{
					Owner = this
				};
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void rjciCmeYbm(int P_0)
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		int num4 = default(int);
		Symbol symbol = default(Symbol);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (num3 >= 0 && num4 >= 0)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto IL_0063;
			default:
				num3 = Symbols.IndexOf(symbol);
				num4 = num3 + P_0;
				num2 = 4;
				break;
			case 3:
				leg4HdlJhRO8lCpy86Fo(Symbols, num3);
				Symbols.Insert(num3 + P_0, symbol);
				goto IL_0063;
			case 2:
				if (num4 < YnbBR4lJmSnTsQXeLiDD(Symbols))
				{
					num2 = 3;
					break;
				}
				goto IL_0063;
			case 1:
				{
					symbol = SelectedSymbol;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
					{
						num2 = 0;
					}
					break;
				}
				IL_0063:
				SelectedSymbol = symbol;
				return;
			}
		}
	}

	private void SymbolSearchControl_OnSymbolSelected(Symbol symbol)
	{
		PopupButtonSymbols.IsPopupOpen = false;
		if (symbol == null)
		{
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
		else if (!Symbols.Contains(symbol))
		{
			Symbols.Add(symbol);
		}
	}

	[SpecialName]
	public bool BxUlv4HRTr()
	{
		return TabControl.SelectedIndex == 0;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!DE2lLJxTQ6)
		{
			DE2lLJxTQ6 = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-176525661 ^ -176536889), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
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
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 9:
			ButtonCancel = (Button)P_1;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 6:
			ButtonSelectPath = (Button)P_1;
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 3:
			ListBoxSymbols = (ListBox)P_1;
			num = 4;
			goto IL_0009;
		case 7:
			TextBoxPath = (TextBox)P_1;
			break;
		default:
			DE2lLJxTQ6 = true;
			break;
		case 5:
			ListBoxRecords = (ListBox)P_1;
			eAHLBdlJwaC3RK19GDgW(ListBoxRecords, new SelectionChangedEventHandler(WwHiTpOCXc));
			break;
		case 1:
			TabControl = (TabControl)P_1;
			break;
		case 2:
			PopupButtonSymbols = (PopupButton)P_1;
			break;
		case 8:
			ButtonOk = (Button)P_1;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
			{
				num = 3;
			}
			goto IL_0009;
		case 4:
			{
				TextBoxSearch = (TextBox)P_1;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
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
				case 5:
					return;
				case 1:
					return;
				case 0:
					return;
				case 3:
					kmGK9AlJ7eyxRjPt3465(ButtonOk, new RoutedEventHandler(mAJiZhJN9q));
					return;
				case 2:
					break;
				case 4:
					return;
				}
				ButtonSelectPath.Click += ln9iVluSeQ;
				num = 5;
			}
		}
	}

	[CompilerGenerated]
	private void I89ir81uJy(object P_0)
	{
		rjciCmeYbm(-1);
	}

	[CompilerGenerated]
	private bool Qj9iK8ERtB(object P_0)
	{
		if (SelectedSymbol != null)
		{
			return Symbols.IndexOf(SelectedSymbol) != 0;
		}
		return false;
	}

	[CompilerGenerated]
	private void U50imy1Isa(object P_0)
	{
		rjciCmeYbm(1);
	}

	[CompilerGenerated]
	private bool PT0ih6xCnR(object P_0)
	{
		if (SelectedSymbol != null)
		{
			return Symbols.IndexOf(SelectedSymbol) != Symbols.Count - 1;
		}
		return false;
	}

	[CompilerGenerated]
	private void jtWiwAUY8R(object P_0)
	{
		Symbols.Remove(SelectedSymbol);
	}

	[CompilerGenerated]
	private bool eZei7xJcRB(object P_0)
	{
		return SelectedSymbol != null;
	}

	[CompilerGenerated]
	private void tg1i8vTIrm(object P_0)
	{
		QIYWISlJ8eCpKWEiatso(Symbols);
	}

	static CxxE1SiWKriMgEOKuTj()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool XDyacXlJEcitUs525iE5(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object TkRD6IlJQ6quqPSuHi3x(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static bool w1oef7lJcRKEDVY19u23()
	{
		return DvjSxLlJXOKC3NTVoWD0 == null;
	}

	internal static CxxE1SiWKriMgEOKuTj E1qxYmlJjdRP1liBAM5k()
	{
		return DvjSxLlJXOKC3NTVoWD0;
	}

	internal static bool I39lgilJdmKbD33P5oB9(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static DateTime UeugZAlJgSpFYqi3OULs()
	{
		return TimeHelper.LocalTime;
	}

	internal static void gkQhTClJRxeqOgLciGm0(object P_0)
	{
		((List<MPdIMTi0styk2MD4qWM>)P_0).Clear();
	}

	internal static void IUhM5TlJ6RrL0OmTpPwt(object P_0)
	{
		((Collection<hoK4AwnbHKSJ04Sk1da3>)P_0).Clear();
	}

	internal static bool oqdqBllJMAWLWfYHXxNA(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static int Cj1mlNlJOvqKeDLtFIqj(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static void JOSiQelJqBKryfobT6IX(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}

	internal static object qTco7RlJINkhKQiB7vUP()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static DateTime AXG626lJW0ZYTy3xSt7n(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).RecordsDate;
	}

	internal static object sVFZlTlJteyjAIplVJmO(object P_0)
	{
		return SymbolManager.Get((string)P_0);
	}

	internal static void MbK65ylJUsiB3IQ6VWed(object P_0, int P_1)
	{
		((Selector)P_0).SelectedIndex = P_1;
	}

	internal static bool pgI86ylJT7slNHejpWmx(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static void N2ZiYWlJy0VQVB5nwYVo(object P_0, object P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).RecordsPath = (string)P_1;
	}

	internal static bool UwLSQHlJZwPnF8fIx3Ja(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void oKAJWplJVWJpjpqEso2Z(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void oBUt1mlJCsun63a5Gfp9(object P_0, bool P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).JTx9likwZsd = P_1;
	}

	internal static void PNM5pqlJruNCNkqBZYDq(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static bool eTdYmwlJKns0iidUWSAn(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static int YnbBR4lJmSnTsQXeLiDD(object P_0)
	{
		return ((Collection<Symbol>)P_0).Count;
	}

	internal static void leg4HdlJhRO8lCpy86Fo(object P_0, int P_1)
	{
		((Collection<Symbol>)P_0).RemoveAt(P_1);
	}

	internal static void eAHLBdlJwaC3RK19GDgW(object P_0, object P_1)
	{
		((Selector)P_0).SelectionChanged += (SelectionChangedEventHandler)P_1;
	}

	internal static void kmGK9AlJ7eyxRjPt3465(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static void QIYWISlJ8eCpKWEiatso(object P_0)
	{
		((Collection<Symbol>)P_0).Clear();
	}
}
