using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using aEpmU09nz6MEoNmc0pGJ;
using e5wb8L92AMGKXo2swM6Y;
using ECOEgqlSad8NUJZ2Dr9n;
using EyD6NKGhRYBSlyBqPfrJ;
using fvG2vw9SsQ14N1VVEdDb;
using hEwMq0H6DxEWbimUXILu;
using hRoKytHllo3Ow1DKENcG;
using p1ENNX2VjjucDYsXModf;
using TigerTrade.Annotations;
using TigerTrade.Config.Common;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Core.Utils.Config;
using TigerTrade.Core.Utils.Time;
using TigerTrade.UI.Windows;
using ttPdaPH4UIV7wakQ3boE;
using TuAMtrl1Nd3XoZQQUXf0;
using U2AoR19TNRFWN9WoaNy;
using ybHq6A2rHAvSQPrG7tV;

namespace bH8FLH27RbwucasG5M5;

public class hPhGyr2wZQvcFSgThHc : Window, INotifyPropertyChanged, IComponentConnector
{
	[CompilerGenerated]
	private static FclDWv2CFJNTaJMi6B4 kIqHNxaKct;

	[CompilerGenerated]
	private readonly ICommand kqmHkFp3J4;

	[CompilerGenerated]
	private readonly ICommand ad4H1HJtT3;

	[CompilerGenerated]
	private readonly ICommand wj5H5Myn55;

	[CompilerGenerated]
	private readonly X8sGST928Ln8DbhUZy6y FhVHSDcyds;

	[CompilerGenerated]
	private readonly string dLnHxmCe6X;

	[CompilerGenerated]
	private string cmIHLkoqeI;

	private bool lQgHeYFoOr;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	private bool RYYHsfmbcu;

	internal static hPhGyr2wZQvcFSgThHc cYVrRjlyV0WKNVwEwrag;

	public static FclDWv2CFJNTaJMi6B4 State
	{
		[CompilerGenerated]
		get
		{
			return kIqHNxaKct;
		}
		[CompilerGenerated]
		set
		{
			kIqHNxaKct = fclDWv2CFJNTaJMi6B;
		}
	}

	public ICommand LockCommand
	{
		[CompilerGenerated]
		get
		{
			return kqmHkFp3J4;
		}
	}

	public ICommand OpenClockPropertiesCommand
	{
		[CompilerGenerated]
		get
		{
			return ad4H1HJtT3;
		}
	}

	public ICommand CloseClockCommand
	{
		[CompilerGenerated]
		get
		{
			return wj5H5Myn55;
		}
	}

	public X8sGST928Ln8DbhUZy6y Settings
	{
		[CompilerGenerated]
		get
		{
			return FhVHSDcyds;
		}
	}

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return dLnHxmCe6X;
		}
	}

	public string CurrentTime
	{
		[CompilerGenerated]
		get
		{
			return cmIHLkoqeI;
		}
		[CompilerGenerated]
		set
		{
			cmIHLkoqeI = text;
		}
	}

	public bool PanelEnabled
	{
		get
		{
			return lQgHeYFoOr;
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
					if (lQgHeYFoOr != flag)
					{
						lQgHeYFoOr = flag;
						Lw22zNXm8a((string)zpgRfxlyK54TDG7jvfre(0x7394D272 ^ 0x7394D56A));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 1;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler value2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 1:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
					{
						return;
					}
					break;
				}
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				value2 = (PropertyChangedEventHandler)XKJ1YolZ2gJpwIWysDTo(propertyChangedEventHandler2, propertyChangedEventHandler3);
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
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
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
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
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
					if ((object)propertyChangedEventHandler != propertyChangedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	public hPhGyr2wZQvcFSgThHc(string P_0 = null, X8sGST928Ln8DbhUZy6y P_1 = null)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				ad4H1HJtT3 = new RelayCommand(mIY2JPHF64);
				wj5H5Myn55 = new RelayCommand(FtZ23pyaPf);
				num2 = 3;
				break;
			case 2:
			{
				r3tmamH64L9eF2h3qdmT r3tmamH64L9eF2h3qdmT = r3tmamH64L9eF2h3qdmT.jUHH6XrOaMC();
				r3tmamH64L9eF2h3qdmT.qtqH6IFCaxN = (Action<bool>)Delegate.Combine(r3tmamH64L9eF2h3qdmT.qtqH6IFCaxN, new Action<bool>(zfL2AhogwR));
				Settings.PropertyChanged += IQ328jbiCL;
				return;
			}
			case 4:
				InitializeComponent();
				base.DataContext = this;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				kqmHkFp3J4 = new RelayCommand(Lock);
				r3tmamH64L9eF2h3qdmT.jUHH6XrOaMC().bA8H6jgYMZp().Add(this);
				num2 = 2;
				break;
			default:
				dLnHxmCe6X = P_0 ?? xNXh9klymr6f6tlAEUXq().ToString();
				FhVHSDcyds = P_1 ?? lw8HnHQjPD();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void IQ328jbiCL(object P_0, PropertyChangedEventArgs P_1)
	{
		SaveTemplate();
	}

	private void zfL2AhogwR(bool P_0)
	{
		try
		{
			CurrentTime = UWceNylyhhdjAJ4UBpw5(((AppTimeZone)Settings.TimeZone/*cast due to .constrained prefix*/).ToString()).AddMilliseconds(Acj0FgGhg83F5A0lfPa4.q3hGwXLLhPb()).ToString((string)zpgRfxlyK54TDG7jvfre(0x2D313048 ^ 0x2D31377C));
			Lw22zNXm8a((string)zpgRfxlyK54TDG7jvfre(-1848952786 ^ -1848950938));
		}
		catch (Exception)
		{
		}
	}

	private void OD12PWL857(object P_0, MouseButtonEventArgs P_1)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 2:
				return;
			case 0:
				return;
			case 3:
				if (P_1.ChangedButton == MouseButton.Left)
				{
					if (!PanelEnabled)
					{
						PanelEnabled = true;
					}
					if (G6dAsJlywAdS7uut7AXu(Settings) || AAGgJFly7LhvcCg5nmDT())
					{
						return;
					}
					DragMove();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private void Lock(object p)
	{
		sE6ehdly816RgwfY8N8q(Settings, !Settings.IsLocked);
	}

	private void mIY2JPHF64(object P_0)
	{
		UfSnjq2VcDBJAcKUG52V ufSnjq2VcDBJAcKUG52V = new UfSnjq2VcDBJAcKUG52V(Settings);
		ufSnjq2VcDBJAcKUG52V.Owner = base.Owner;
		ufSnjq2VcDBJAcKUG52V.ShowDialog();
	}

	private void qbT2F5AYv2(object P_0, MouseButtonEventArgs P_1)
	{
		mIY2JPHF64(null);
	}

	private void FtZ23pyaPf(object P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				r3tmamH64L9eF2h3qdmT r3tmamH64L9eF2h3qdmT = r3tmamH64L9eF2h3qdmT.jUHH6XrOaMC();
				r3tmamH64L9eF2h3qdmT.qtqH6IFCaxN = (Action<bool>)Delegate.Remove(r3tmamH64L9eF2h3qdmT.qtqH6IFCaxN, new Action<bool>(zfL2AhogwR));
				num2 = 3;
				break;
			}
			case 1:
				((r3tmamH64L9eF2h3qdmT)NRYDIqlyAToKWZhvdoqb()).bA8H6jgYMZp().Remove(this);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
			{
				Window owner = base.Owner;
				if (owner != null)
				{
					JQcvJilyPZc1hftRuKD3(owner);
				}
				object obj = lsBjlylyJ3C8wu6BDHv9(this);
				if (obj != null)
				{
					EdcbUVlyFLZbI41UDjjR(obj);
				}
				nQic4Bly36pDiDGnjpDK(this);
				return;
			}
			case 3:
				Settings.PropertyChanged -= IQ328jbiCL;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public void oZ62pFm9Tn(string P_0)
	{
		string fileName = Path.Combine(j18iDj9nukSCmEyZs5lH.mCD9GU85vS2(), (string)lJGmR7lypoMPePetVR4l(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1D7BA1ED ^ 0x1D7BA68F)));
		ConfigSerializer.SaveToFile(Settings, fileName);
	}

	internal void vVn2u9skjm(tqXNh49SeOFpHXm7ME1X P_0)
	{
		base.Left = uX97FslyucmFwYbVK8V9(P_0);
		base.Top = P_0.Top;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.Width = PkUe3qlyzhPVSBt6nKnU(P_0);
		base.Height = ajpIfXlZ0I0UpFN2NP07(P_0);
	}

	[NotifyPropertyChangedInvocator]
	private void Lw22zNXm8a([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	private void lmvH0frgYx(object P_0, EventArgs P_1)
	{
		PanelEnabled = false;
	}

	private void NAkH218Uei(object P_0, KeyEventArgs P_1)
	{
		if (P_1.Key != Key.Delete || Settings.IsLocked)
		{
			return;
		}
		while (true)
		{
			FtZ23pyaPf(null);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				continue;
			}
			P_1.Handled = true;
			return;
		}
	}

	private void YUQHHiIklL(object P_0, EventArgs P_1)
	{
		base.Owner = tIJHfImniF();
	}

	private Window tIJHfImniF()
	{
		MainWindow mainWindow = hNXfXl9U6G1YI9MQ7eq.Instance.MainWindow;
		if (fHNH93v2Sn(mainWindow))
		{
			return mainWindow;
		}
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => (Window)(((object)hNXfXl9U6G1YI9MQ7eq.Instance.RHVnB7wwZt().FirstOrDefault(fHNH93v2Sn)) ?? ((object)mainWindow)), 
		};
	}

	private bool fHNH93v2Sn(Window P_0)
	{
		Rect rect = XnGRixHliJoPWDlKeqnW.oasHlj5a4Fw(this);
		Rect rect2 = XnGRixHliJoPWDlKeqnW.oasHlj5a4Fw(P_0);
		return rect.IntersectsWith(rect2);
	}

	private static X8sGST928Ln8DbhUZy6y lw8HnHQjPD()
	{
		X8sGST928Ln8DbhUZy6y obj = ConfigSerializer.LoadFromFile<X8sGST928Ln8DbhUZy6y>(j18iDj9nukSCmEyZs5lH.Jeg9Y2gpkPo()) ?? new X8sGST928Ln8DbhUZy6y();
		obj.IsLocked = false;
		return obj;
	}

	private void SaveTemplate()
	{
		ConfigSerializer.SaveToFile(Settings, j18iDj9nukSCmEyZs5lH.Jeg9Y2gpkPo());
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (RYYHsfmbcu)
		{
			return;
		}
		RYYHsfmbcu = true;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
			{
				Uri uri = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1AB79299 ^ 0x1AB79519), UriKind.Relative);
				FxJW2ClZHCAX1NyISWtP(this, uri);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
				{
					num = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
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
			RYYHsfmbcu = true;
			num = 2;
			goto IL_0009;
		case 1:
			((hPhGyr2wZQvcFSgThHc)P_1).Deactivated += lmvH0frgYx;
			num = 3;
			goto IL_0009;
		case 3:
			((ContentControl)P_1).MouseDown += OD12PWL857;
			break;
		case 2:
			{
				RNIit8lZ9oOp33k4D9ij((Border)P_1, new MouseButtonEventHandler(OD12PWL857));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
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
				case 0:
					return;
				case 1:
					yi0OaClZfRSR5bmMmoOM((hPhGyr2wZQvcFSgThHc)P_1, new EventHandler(YUQHHiIklL));
					return;
				case 2:
					return;
				case 3:
					((hPhGyr2wZQvcFSgThHc)P_1).MouseDoubleClick += qbT2F5AYv2;
					((hPhGyr2wZQvcFSgThHc)P_1).KeyDown += NAkH218Uei;
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	static hPhGyr2wZQvcFSgThHc()
	{
		txBD66lZnwpT1xxgBtus();
	}

	internal static bool XghqvdlyCmI0xmgbhNRU()
	{
		return cYVrRjlyV0WKNVwEwrag == null;
	}

	internal static hPhGyr2wZQvcFSgThHc otQNBHlyryni83JklfGX()
	{
		return cYVrRjlyV0WKNVwEwrag;
	}

	internal static object zpgRfxlyK54TDG7jvfre(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static Guid xNXh9klymr6f6tlAEUXq()
	{
		return Guid.NewGuid();
	}

	internal static DateTime UWceNylyhhdjAJ4UBpw5(object P_0)
	{
		return TimeHelper.GetCityTime((string)P_0);
	}

	internal static bool G6dAsJlywAdS7uut7AXu(object P_0)
	{
		return ((X8sGST928Ln8DbhUZy6y)P_0).IsLocked;
	}

	internal static bool AAGgJFly7LhvcCg5nmDT()
	{
		return T1PidKH4tUNimKjMkjFl.IsLocked;
	}

	internal static void sE6ehdly816RgwfY8N8q(object P_0, bool P_1)
	{
		((X8sGST928Ln8DbhUZy6y)P_0).IsLocked = P_1;
	}

	internal static object NRYDIqlyAToKWZhvdoqb()
	{
		return r3tmamH64L9eF2h3qdmT.jUHH6XrOaMC();
	}

	internal static bool JQcvJilyPZc1hftRuKD3(object P_0)
	{
		return ((Window)P_0).Activate();
	}

	internal static object lsBjlylyJ3C8wu6BDHv9(object P_0)
	{
		return ((Window)P_0).Owner;
	}

	internal static bool EdcbUVlyFLZbI41UDjjR(object P_0)
	{
		return ((UIElement)P_0).Focus();
	}

	internal static void nQic4Bly36pDiDGnjpDK(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static object lJGmR7lypoMPePetVR4l(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static double uX97FslyucmFwYbVK8V9(object P_0)
	{
		return ((tqXNh49SeOFpHXm7ME1X)P_0).Left;
	}

	internal static double PkUe3qlyzhPVSBt6nKnU(object P_0)
	{
		return ((tqXNh49SeOFpHXm7ME1X)P_0).Width;
	}

	internal static double ajpIfXlZ0I0UpFN2NP07(object P_0)
	{
		return ((tqXNh49SeOFpHXm7ME1X)P_0).Height;
	}

	internal static object XKJ1YolZ2gJpwIWysDTo(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static void FxJW2ClZHCAX1NyISWtP(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static void yi0OaClZfRSR5bmMmoOM(object P_0, object P_1)
	{
		((Window)P_0).LocationChanged += (EventHandler)P_1;
	}

	internal static void RNIit8lZ9oOp33k4D9ij(object P_0, object P_1)
	{
		((UIElement)P_0).MouseDown += (MouseButtonEventHandler)P_1;
	}

	internal static void txBD66lZnwpT1xxgBtus()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
