using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace SEQqPqH4nNhm8nd75hCj;

public class Ao2vqfH49QiMtSHMTg7e : UserControl, IComponentConnector
{
	public static readonly DependencyProperty M5XH4EkSb8e;

	public static readonly DependencyProperty iExH4QTTVcA;

	public static readonly DependencyProperty UuVH4dXscSm;

	public static readonly DependencyProperty jD8H4g2SCU0;

	public static readonly DependencyProperty IsErrorProperty;

	public static readonly DependencyProperty JNFH4RZVfJN;

	public static readonly DependencyProperty JpqH46gHRBa;

	public static readonly DependencyProperty ITmH4MKbpnl;

	public static readonly DependencyProperty o8kH4OpNfcV;

	internal Ao2vqfH49QiMtSHMTg7e ButtonControl;

	internal Button MainButton;

	internal Popup PART_Popup;

	private bool qYGH4qH5921;

	internal static Ao2vqfH49QiMtSHMTg7e Vl5Wx8D1j2iKEB6L7N16;

	public ICommand Command
	{
		get
		{
			return (ICommand)GetValue(M5XH4EkSb8e);
		}
		set
		{
			SetValue(M5XH4EkSb8e, value2);
		}
	}

	public object CommandParameter
	{
		get
		{
			return AYEOFuD1gONIOaAJBAHH(this, iExH4QTTVcA);
		}
		set
		{
			SetValue(iExH4QTTVcA, value2);
		}
	}

	public Brush ButtonBackground
	{
		get
		{
			return (Brush)GetValue(UuVH4dXscSm);
		}
		set
		{
			xxD1ZAD1ROrGrahI5N4v(this, UuVH4dXscSm, brush);
		}
	}

	public object ButtonContent
	{
		get
		{
			return GetValue(jD8H4g2SCU0);
		}
		set
		{
			xxD1ZAD1ROrGrahI5N4v(this, jD8H4g2SCU0, obj);
		}
	}

	public bool IsError
	{
		get
		{
			return (bool)GetValue(IsErrorProperty);
		}
		set
		{
			SetValue(IsErrorProperty, flag);
		}
	}

	public bool ShowError
	{
		get
		{
			return (bool)GetValue(JNFH4RZVfJN);
		}
		set
		{
			xxD1ZAD1ROrGrahI5N4v(this, JNFH4RZVfJN, flag);
		}
	}

	public object ErrorContent
	{
		get
		{
			return GetValue(jD8H4g2SCU0);
		}
		set
		{
			SetValue(jD8H4g2SCU0, value2);
		}
	}

	public bool IsPopupOpened
	{
		get
		{
			return (bool)GetValue(ITmH4MKbpnl);
		}
		set
		{
			xxD1ZAD1ROrGrahI5N4v(this, ITmH4MKbpnl, flag);
		}
	}

	public PlacementMode ErrorPlacementMode
	{
		get
		{
			return (PlacementMode)GetValue(o8kH4OpNfcV);
		}
		set
		{
			SetValue(o8kH4OpNfcV, placementMode);
		}
	}

	public Ao2vqfH49QiMtSHMTg7e()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		InitializeComponent();
		MainButton.Click += t4hH4vSQLQD;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				PART_Popup.Opened += eLUH4o6aRYv;
				num = 2;
				continue;
			case 2:
				xBUI8qD1ddXZ28gXqjet(this, new MouseButtonEventHandler(b4SH4BDkWy3));
				return;
			}
			PART_Popup.Closed += wopH4YhxOfs;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 != 0)
			{
				num = 1;
			}
		}
	}

	private static void ENlH4GtrUeK(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Ao2vqfH49QiMtSHMTg7e ao2vqfH49QiMtSHMTg7e = P_0 as Ao2vqfH49QiMtSHMTg7e;
		object newValue = default(object);
		int num;
		if (ao2vqfH49QiMtSHMTg7e != null)
		{
			newValue = P_1.NewValue;
			if (!(newValue is bool))
			{
				return;
			}
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				return;
			}
			bool isOpen = (bool)newValue;
			ao2vqfH49QiMtSHMTg7e.PART_Popup.IsOpen = isOpen;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
			{
				num = 1;
			}
		}
	}

	private void wopH4YhxOfs(object P_0, EventArgs P_1)
	{
		ShowError = false;
	}

	private void eLUH4o6aRYv(object P_0, EventArgs P_1)
	{
		ShowError = true;
	}

	private void t4hH4vSQLQD(object P_0, RoutedEventArgs P_1)
	{
		if (IsError)
		{
			PART_Popup.IsOpen = !e75g2OD16KIAYd1c8IH7(PART_Popup);
			P_1.Handled = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
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
			Command.Execute(CommandParameter);
		}
	}

	private void b4SH4BDkWy3(object P_0, MouseButtonEventArgs P_1)
	{
		fuHXypD1MQElxSnqgBN0(P_1, true);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (qYGH4qH5921)
		{
			return;
		}
		qYGH4qH5921 = true;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
		{
			num = 0;
		}
		Uri resourceLocator = default(Uri);
		while (true)
		{
			switch (num)
			{
			case 1:
				resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-198991962 ^ -199064272), UriKind.Relative);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
				{
					num = 0;
				}
				break;
			default:
				Application.LoadComponent(this, resourceLocator);
				return;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)RW4DG6D1O2sVG4Icwcu1(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 2:
			MainButton = (Button)P_1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		default:
			qYGH4qH5921 = true;
			break;
		case 1:
			ButtonControl = (Ao2vqfH49QiMtSHMTg7e)P_1;
			break;
		case 3:
			{
				PART_Popup = (Popup)P_1;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
				{
					num = 1;
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

	static Ao2vqfH49QiMtSHMTg7e()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				ITmH4MKbpnl = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x12620268 ^ 0x126319F4), Kh73BmD1qxoSnNJMTQ3W(qIJZt7D1I2de03r9ZgDb(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555284)), new PropertyMetadata(false));
				o8kH4OpNfcV = (DependencyProperty)dlQWgJD1UTmXnNRjPnt4(o9LKIJD1ttGqKsXUx1Ct(-1309555870 ^ -1309615912), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777451)), Kh73BmD1qxoSnNJMTQ3W(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555284)), new PropertyMetadata(PlacementMode.Top));
				return;
			case 1:
				UuVH4dXscSm = DependencyProperty.Register((string)o9LKIJD1ttGqKsXUx1Ct(0x12620268 ^ 0x12631956), Kh73BmD1qxoSnNJMTQ3W(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777400)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555284)));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 3;
				break;
			case 2:
				jD8H4g2SCU0 = (DependencyProperty)UNqxL3D1WJpJ1TX0fO2G(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53853482), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777240)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555284)));
				IsErrorProperty = (DependencyProperty)dlQWgJD1UTmXnNRjPnt4(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1161619942 ^ -1161583858), Type.GetTypeFromHandle(qIJZt7D1I2de03r9ZgDb(16777221)), Type.GetTypeFromHandle(qIJZt7D1I2de03r9ZgDb(33555284)), new PropertyMetadata(false));
				JNFH4RZVfJN = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x684F243E ^ 0x684F917C), Type.GetTypeFromHandle(qIJZt7D1I2de03r9ZgDb(16777221)), Kh73BmD1qxoSnNJMTQ3W(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555284)), new PropertyMetadata(false, ENlH4GtrUeK));
				JpqH46gHRBa = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--18459671 ^ 0x118B797), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777240)), Type.GetTypeFromHandle(qIJZt7D1I2de03r9ZgDb(33555284)));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				M5XH4EkSb8e = (DependencyProperty)UNqxL3D1WJpJ1TX0fO2G(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009589889), Kh73BmD1qxoSnNJMTQ3W(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777377)), Type.GetTypeFromHandle(qIJZt7D1I2de03r9ZgDb(33555284)));
				iExH4QTTVcA = (DependencyProperty)UNqxL3D1WJpJ1TX0fO2G(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741A9ED1), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777240)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555284)));
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void xBUI8qD1ddXZ28gXqjet(object P_0, object P_1)
	{
		((UIElement)P_0).MouseRightButtonUp += (MouseButtonEventHandler)P_1;
	}

	internal static bool KlEZqyD1EKN1OLSqxCY8()
	{
		return Vl5Wx8D1j2iKEB6L7N16 == null;
	}

	internal static Ao2vqfH49QiMtSHMTg7e eyVcKgD1Q6ctBONinohx()
	{
		return Vl5Wx8D1j2iKEB6L7N16;
	}

	internal static object AYEOFuD1gONIOaAJBAHH(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void xxD1ZAD1ROrGrahI5N4v(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static bool e75g2OD16KIAYd1c8IH7(object P_0)
	{
		return ((Popup)P_0).IsOpen;
	}

	internal static void fuHXypD1MQElxSnqgBN0(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}

	internal static object RW4DG6D1O2sVG4Icwcu1(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static Type Kh73BmD1qxoSnNJMTQ3W(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static RuntimeTypeHandle qIJZt7D1I2de03r9ZgDb(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static object UNqxL3D1WJpJ1TX0fO2G(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}

	internal static object o9LKIJD1ttGqKsXUx1Ct(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object dlQWgJD1UTmXnNRjPnt4(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
