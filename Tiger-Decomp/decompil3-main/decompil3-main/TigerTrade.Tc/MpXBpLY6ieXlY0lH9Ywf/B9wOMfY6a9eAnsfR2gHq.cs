using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using soid6MYR7PDNNAsJuMFA;
using TigerTrade.Tc.Annotations;
using TigerTrade.Tc.Manager;
using wRZx5aaX1rIduT2GytfS;
using WwnakJY6cqYmLv4tQWkA;
using x97CE55GhEYKgt7TSVZT;

namespace MpXBpLY6ieXlY0lH9Ywf;

internal sealed class B9wOMfY6a9eAnsfR2gHq : SuSj0gaXkIlYcfCsT0qp, INotifyPropertyChanged, IComponentConnector
{
	internal class T9rGNxaWuEg8ZZet4HIj : INotifyPropertyChanged
	{
		[CompilerGenerated]
		private readonly string UqMatfudVkJ;

		[CompilerGenerated]
		private readonly List<string> DY6at9al7y7;

		[CompilerGenerated]
		private readonly bool YMLatnQWdT0;

		[CompilerGenerated]
		private PropertyChangedEventHandler m_PropertyChanged;

		private static T9rGNxaWuEg8ZZet4HIj NDAhQPL2BgYYO3jO1F4W;

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return UqMatfudVkJ;
			}
		}

		public List<string> Exchanges
		{
			[CompilerGenerated]
			get
			{
				return DY6at9al7y7;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					int num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
					{
						num = 0;
					}
					while (true)
					{
						switch (num)
						{
						default:
						{
							PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
							propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
							num = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_70b4b4a3c8d3471f9796e8c8caf6f35b == 0)
							{
								num = 0;
							}
							continue;
						}
						case 1:
							break;
						}
						break;
					}
				}
				while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
				while (true)
				{
					PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)qjCS3AL2lekbnvnNcqXr(propertyChangedEventHandler2, propertyChangedEventHandler3);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					int num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 != 0)
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
						num = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 == 0)
						{
							num = 1;
						}
					}
				}
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public bool t6wat2kTdNO()
		{
			return YMLatnQWdT0;
		}

		public T9rGNxaWuEg8ZZet4HIj(string P_0, bool P_1)
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					DY6at9al7y7 = new List<string>();
					return;
				}
				UqMatfudVkJ = P_0;
				YMLatnQWdT0 = P_1;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c != 0)
				{
					num = 0;
				}
			}
		}

		public override string ToString()
		{
			return Name;
		}

		[NotifyPropertyChangedInvocator]
		protected virtual void ifWlfmRSlkr([CallerMemberName] string propertyName = null)
		{
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		static T9rGNxaWuEg8ZZet4HIj()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool s9qlFYL2aiE0bZocshKr()
		{
			return NDAhQPL2BgYYO3jO1F4W == null;
		}

		internal static T9rGNxaWuEg8ZZet4HIj uSwMFTL2iN1UhU4BIyCG()
		{
			return NDAhQPL2BgYYO3jO1F4W;
		}

		internal static object qjCS3AL2lekbnvnNcqXr(object P_0, object P_1)
		{
			return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
		}
	}

	internal class nFsfL1atGG8PUmojWevr : INotifyPropertyChanged
	{
		[CompilerGenerated]
		private readonly string xq5atBsDr2G;

		private bool Jskataej2wN;

		[CompilerGenerated]
		private PropertyChangedEventHandler m_PropertyChanged;

		private static nFsfL1atGG8PUmojWevr koHZvkL24xxaDDsS9BH1;

		public string Name
		{
			[CompilerGenerated]
			get
			{
				return xq5atBsDr2G;
			}
		}

		public bool IsChecked
		{
			get
			{
				return Jskataej2wN;
			}
			set
			{
				if (flag != Jskataej2wN)
				{
					Jskataej2wN = flag;
					int num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc == 0)
					{
						num = 0;
					}
					switch (num)
					{
					}
					ifWlfmRSlkr((string)UsEZ2XL2NsoVVwjq6WvA(-90307782 ^ -90179172));
				}
			}
		}

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
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 != 0)
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
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					}
					while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 == 0)
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
				PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
				PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
				while (true)
				{
					switch (num2)
					{
					case 1:
					{
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)PhKcbeL2kDC1mfoCG14M(propertyChangedEventHandler2, propertyChangedEventHandler3);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 != 0)
						{
							num2 = 0;
						}
						break;
					}
					default:
						if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							return;
						}
						goto case 1;
					case 2:
						propertyChangedEventHandler = this.m_PropertyChanged;
						num2 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 == 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			}
		}

		public nFsfL1atGG8PUmojWevr(string P_0, bool P_1 = false)
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
			xq5atBsDr2G = P_0;
			IsChecked = P_1;
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 != 0)
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
			return Name;
		}

		[NotifyPropertyChangedInvocator]
		protected virtual void ifWlfmRSlkr([CallerMemberName] string propertyName = null)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				skey1AL21tKPlPsAgRop(propertyChangedEventHandler, this, new PropertyChangedEventArgs(propertyName));
			}
		}

		static nFsfL1atGG8PUmojWevr()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static object UsEZ2XL2NsoVVwjq6WvA(int P_0)
		{
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
		}

		internal static bool OUOlxxL2DqqcDwZThRoO()
		{
			return koHZvkL24xxaDDsS9BH1 == null;
		}

		internal static nFsfL1atGG8PUmojWevr XNUJh5L2bv4LdT6IGB90()
		{
			return koHZvkL24xxaDDsS9BH1;
		}

		internal static object PhKcbeL2kDC1mfoCG14M(object P_0, object P_1)
		{
			return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
		}

		internal static void skey1AL21tKPlPsAgRop(object P_0, object P_1, object P_2)
		{
			P_0(P_1, (PropertyChangedEventArgs)P_2);
		}
	}

	private readonly H2ESniY6XhkkXGLofFqD AAJY65ehDwk;

	private readonly ba091pYRwwE4XvQnUsd8 aFgY6Sm8JHy;

	private readonly ObservableCollection<T9rGNxaWuEg8ZZet4HIj> SbvY6xNKgTE;

	private T9rGNxaWuEg8ZZet4HIj d7vY6LZlaD0;

	private readonly ObservableCollection<nFsfL1atGG8PUmojWevr> wsxY6eiW4Vx;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal ComboBox ComboBoxServer;

	internal TextBox TextBoxLogin;

	internal PasswordBox TextBoxPassword;

	private bool L8BY6siQCD6;

	internal static B9wOMfY6a9eAnsfR2gHq VY2gXLSe1og1paq0RfMg;

	public IEnumerable<T9rGNxaWuEg8ZZet4HIj> Servers => SbvY6xNKgTE;

	public T9rGNxaWuEg8ZZet4HIj SelectedServer
	{
		get
		{
			return d7vY6LZlaD0;
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
					if (jj1SkYSexEIrdbwDZCpE(t9rGNxaWuEg8ZZet4HIj, d7vY6LZlaD0))
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 != 0)
						{
							num2 = 0;
						}
						break;
					}
					d7vY6LZlaD0 = t9rGNxaWuEg8ZZet4HIj;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e != 0)
					{
						num2 = 2;
					}
					break;
				case 3:
					WAPY6l5YjPp(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1161619942 ^ -1161673396));
					num2 = 4;
					break;
				case 2:
					WAPY6l5YjPp(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xB15786A ^ 0xB142B5C));
					dk4q78SeLW35UXWuymhO(wsxY6eiW4Vx);
					if (d7vY6LZlaD0 != null)
					{
						foreach (string item in d7vY6LZlaD0.Exchanges)
						{
							int num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 == 0)
							{
								num3 = 0;
							}
							switch (num3)
							{
							}
							wsxY6eiW4Vx.Add(new nFsfL1atGG8PUmojWevr(item, AAJY65ehDwk.Exchanges.Contains(item)));
						}
					}
					goto case 3;
				case 0:
					return;
				case 4:
					WAPY6l5YjPp(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-894902996 ^ -894857542));
					return;
				}
			}
		}
	}

	public IEnumerable<nFsfL1atGG8PUmojWevr> Exchanges => wsxY6eiW4Vx;

	public Visibility ExchangesDescriptionVisibility
	{
		get
		{
			if (wsxY6eiW4Vx.Count == 0)
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

	public Visibility LoginPasswordVisibility
	{
		get
		{
			if (d7vY6LZlaD0 == null || !zL4atxSeeltpecKJOufJ(d7vY6LZlaD0))
			{
				return Visibility.Collapsed;
			}
			return Visibility.Visible;
		}
	}

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
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				case 0:
					return;
				}
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
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
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				default:
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					break;
				}
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	public B9wOMfY6a9eAnsfR2gHq()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				SbvY6xNKgTE = new ObservableCollection<T9rGNxaWuEg8ZZet4HIj>();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 != 0)
				{
					num = 0;
				}
				break;
			default:
				wsxY6eiW4Vx = new ObservableCollection<nFsfL1atGG8PUmojWevr>();
				TcEvents.RiseTrackWindow(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-490987856 ^ -490910344));
				InitializeComponent();
				return;
			}
		}
	}

	public B9wOMfY6a9eAnsfR2gHq(H2ESniY6XhkkXGLofFqD P_0, ba091pYRwwE4XvQnUsd8 P_1)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector();
		AAJY65ehDwk = P_0;
		aFgY6Sm8JHy = P_1;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void Control_Loaded(object sender, RoutedEventArgs e)
	{
		int num = 2;
		string[] array2 = default(string[]);
		int num3 = default(int);
		int num4 = default(int);
		T9rGNxaWuEg8ZZet4HIj t9rGNxaWuEg8ZZet4HIj = default(T9rGNxaWuEg8ZZet4HIj);
		string[] array = default(string[]);
		string[] array3 = default(string[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (AAJY65ehDwk == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					uTKMBhSesYq44bIfJCUv(SbvY6xNKgTE);
					array2 = ((string)iOZbTySeXXHmjcuinUYd(AAJY65ehDwk)).Split(new char[1] { ';' });
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
				{
					IEnumerator<T9rGNxaWuEg8ZZet4HIj> enumerator = SbvY6xNKgTE.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							while (true)
							{
								T9rGNxaWuEg8ZZet4HIj current = enumerator.Current;
								if (!omut6ESecSaOs67ARauq(sVPI7VSeE5ukWwI1JL81(current), AAJY65ehDwk.UC6Y6gSMCGg))
								{
									break;
								}
								SelectedServer = current;
								int num5 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 == 0)
								{
									num5 = 1;
								}
								switch (num5)
								{
								case 1:
									goto end_IL_0115;
								}
							}
							continue;
							end_IL_0115:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							enumerator.Dispose();
							int num6 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a != 0)
							{
								num6 = 0;
							}
							switch (num6)
							{
							case 0:
								break;
							}
						}
					}
					LkmWkISedv9KBYfHvXEW(TextBoxLogin, i9mFGQSeQTuysyEEJgd2(AAJY65ehDwk));
					TextBoxPassword.Password = AAJY65ehDwk.Password;
					num2 = 4;
					continue;
				}
				default:
					num3 = 0;
					goto case 6;
				case 1:
					return;
				case 8:
					num4++;
					num2 = 11;
					continue;
				case 9:
					t9rGNxaWuEg8ZZet4HIj = new T9rGNxaWuEg8ZZet4HIj(array[0], omut6ESecSaOs67ARauq(array[2], F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6EC99CAF ^ 0x6EC9093D)));
					array3 = (string[])HTwEwHSejnCDOHmBI2MH(array[3], new char[1] { '|' });
					num4 = 0;
					num2 = 5;
					continue;
				case 4:
					return;
				case 5:
				case 11:
					if (num4 < array3.Length)
					{
						string text = array3[num4];
						if (!string.IsNullOrEmpty(text))
						{
							t9rGNxaWuEg8ZZet4HIj.Exchanges.Add(text);
							num = 8;
							break;
						}
						goto case 8;
					}
					SbvY6xNKgTE.Add(t9rGNxaWuEg8ZZet4HIj);
					goto IL_0244;
				case 6:
					if (num3 >= array2.Length)
					{
						num = 3;
						break;
					}
					goto case 10;
				case 7:
					if (array.Length == 4)
					{
						num2 = 9;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto IL_0244;
				case 10:
					{
						string text2 = array2[num3];
						if (!string.IsNullOrEmpty(text2))
						{
							array = text2.Split('@');
							num2 = 7;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b != 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto IL_0244;
					}
					IL_0244:
					num3++;
					num2 = 6;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			}
		}
	}

	public override void SaveSettings()
	{
		if (AAJY65ehDwk == null)
		{
			return;
		}
		AiZORvSeRKHuj1mEUFLP(AAJY65ehDwk, ((string)bNV21TSegvSK8dnmdVwR(TextBoxLogin)).Trim());
		n3qBp6Se6adhAPCf6v3c(AAJY65ehDwk, TextBoxPassword.Password.Trim());
		int num = 2;
		IEnumerator<nFsfL1atGG8PUmojWevr> enumerator = default(IEnumerator<nFsfL1atGG8PUmojWevr>);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
			{
				ePCHIySeOdSMTyYOdN8Z(aFgY6Sm8JHy);
				AAJY65ehDwk.Exchanges.Clear();
				enumerator = wsxY6eiW4Vx.GetEnumerator();
				int num3 = 3;
				num = num3;
				break;
			}
			case 0:
				return;
			case 4:
				AAJY65ehDwk.Exchanges.Clear();
				return;
			case 3:
				try
				{
					while (enumerator.MoveNext())
					{
						while (true)
						{
							nFsfL1atGG8PUmojWevr current = enumerator.Current;
							if (current.IsChecked)
							{
								int num2 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
								{
									num2 = 1;
								}
								switch (num2)
								{
								case 1:
									break;
								default:
									continue;
								}
								AAJY65ehDwk.Exchanges.Add((string)pAKd8oSeqgTRgjC3cUNI(current));
							}
							break;
						}
					}
				}
				finally
				{
					enumerator?.Dispose();
				}
				AAJY65ehDwk.gpqG8g0ePAk();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				if (SelectedServer != null)
				{
					AAJY65ehDwk.UC6Y6gSMCGg = SelectedServer.Name;
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
					{
						num = 1;
					}
				}
				else
				{
					Pvgvl9SeM7aMtJAJcamt(AAJY65ehDwk, "");
					num = 4;
				}
				break;
			}
		}
	}

	[NotifyPropertyChangedInvocator]
	private void WAPY6l5YjPp([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!L8BY6siQCD6)
		{
			L8BY6siQCD6 = true;
			Uri resourceLocator = new Uri((string)x6R1CNSeIEcaHpjWHwhM(0x7394D272 ^ 0x73958198), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 != 0)
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

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		default:
			L8BY6siQCD6 = true;
			break;
		case 2:
			TextBoxLogin = (TextBox)P_1;
			break;
		case 3:
			TextBoxPassword = (PasswordBox)P_1;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 1:
			{
				ComboBoxServer = (ComboBox)P_1;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 == 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			IL_0009:
			switch (num)
			{
			case 1:
				break;
			case 0:
				break;
			}
			break;
		}
	}

	static B9wOMfY6a9eAnsfR2gHq()
	{
		gdMWbMSeWXJMcwek6w1A();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool jj1SkYSexEIrdbwDZCpE(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static void dk4q78SeLW35UXWuymhO(object P_0)
	{
		((Collection<nFsfL1atGG8PUmojWevr>)P_0).Clear();
	}

	internal static bool iokjJiSe5g22vfFSBqwu()
	{
		return VY2gXLSe1og1paq0RfMg == null;
	}

	internal static B9wOMfY6a9eAnsfR2gHq EbWegKSeSYoSTSf1O6NW()
	{
		return VY2gXLSe1og1paq0RfMg;
	}

	internal static bool zL4atxSeeltpecKJOufJ(object P_0)
	{
		return ((T9rGNxaWuEg8ZZet4HIj)P_0).t6wat2kTdNO();
	}

	internal static void uTKMBhSesYq44bIfJCUv(object P_0)
	{
		((Collection<T9rGNxaWuEg8ZZet4HIj>)P_0).Clear();
	}

	internal static object iOZbTySeXXHmjcuinUYd(object P_0)
	{
		return ((H2ESniY6XhkkXGLofFqD)P_0).Servers;
	}

	internal static bool omut6ESecSaOs67ARauq(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object HTwEwHSejnCDOHmBI2MH(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object sVPI7VSeE5ukWwI1JL81(object P_0)
	{
		return ((T9rGNxaWuEg8ZZet4HIj)P_0).Name;
	}

	internal static object i9mFGQSeQTuysyEEJgd2(object P_0)
	{
		return ((H2ESniY6XhkkXGLofFqD)P_0).Login;
	}

	internal static void LkmWkISedv9KBYfHvXEW(object P_0, object P_1)
	{
		((TextBox)P_0).Text = (string)P_1;
	}

	internal static object bNV21TSegvSK8dnmdVwR(object P_0)
	{
		return ((TextBox)P_0).Text;
	}

	internal static void AiZORvSeRKHuj1mEUFLP(object P_0, object P_1)
	{
		((H2ESniY6XhkkXGLofFqD)P_0).Login = (string)P_1;
	}

	internal static void n3qBp6Se6adhAPCf6v3c(object P_0, object P_1)
	{
		((H2ESniY6XhkkXGLofFqD)P_0).Password = (string)P_1;
	}

	internal static void Pvgvl9SeM7aMtJAJcamt(object P_0, object P_1)
	{
		((H2ESniY6XhkkXGLofFqD)P_0).UC6Y6gSMCGg = (string)P_1;
	}

	internal static void ePCHIySeOdSMTyYOdN8Z(object P_0)
	{
		((ba091pYRwwE4XvQnUsd8)P_0).RWAYR8BSfam();
	}

	internal static object pAKd8oSeqgTRgjC3cUNI(object P_0)
	{
		return ((nFsfL1atGG8PUmojWevr)P_0).Name;
	}

	internal static object x6R1CNSeIEcaHpjWHwhM(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static void gdMWbMSeWXJMcwek6w1A()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
