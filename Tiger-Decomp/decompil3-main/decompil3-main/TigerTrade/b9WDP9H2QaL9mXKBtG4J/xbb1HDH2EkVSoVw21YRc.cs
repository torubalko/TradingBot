using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ECOEgqlSad8NUJZ2Dr9n;
using qK52IFH2WpFQpklt3aW3;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace b9WDP9H2QaL9mXKBtG4J;

public class xbb1HDH2EkVSoVw21YRc : UserControl, uUWLIoH2IMa6ubyC18Xq, IComponentConnector
{
	private string mMVH2M2EDCK;

	public static readonly DependencyProperty UTIH2OVaK8I;

	internal xbb1HDH2EkVSoVw21YRc Root;

	private bool uIvH2qFpw9S;

	internal static xbb1HDH2EkVSoVw21YRc xuRJOODijHr9MqbFVvKj;

	public ImageSource ThumbnailSource
	{
		get
		{
			return (ImageSource)sT71Z8DidQL3A2BxHBDb(this, UTIH2OVaK8I);
		}
		private set
		{
			SetValue(UTIH2OVaK8I, value2);
		}
	}

	public xbb1HDH2EkVSoVw21YRc()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void Navigate(Uri P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
			{
				if (ar3tTNDigvEMTFJPB7fx(P_0, null))
				{
					return;
				}
				string arg = P_0.AbsoluteUri.Split('/').Last();
				BitmapImage bitmapImage = new BitmapImage(new Uri(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1346994499 ^ -1346928703), arg)));
				ThumbnailSource = bitmapImage;
				mMVH2M2EDCK = P_0.AbsoluteUri;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 0:
				return;
			case 2:
				mMVH2M2EDCK = null;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void jbaH2d7Lguo(object P_0, RoutedEventArgs P_1)
	{
		if (string.IsNullOrWhiteSpace(mMVH2M2EDCK))
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Process.Start(new ProcessStartInfo(mMVH2M2EDCK));
		}
		catch (Exception)
		{
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!uIvH2qFpw9S)
		{
			uIvH2qFpw9S = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				return;
			}
			Uri uri = new Uri((string)Y7BjplDiR0wG0RjSOit9(-1461292091 ^ -1461226995), UriKind.Relative);
			Sxddr0Di6JPlsV0tXyV8(this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		switch (P_0)
		{
		case 2:
		{
			((Button)P_1).Click += jbaH2d7Lguo;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				break;
			}
			break;
		}
		default:
			uIvH2qFpw9S = true;
			return;
		case 1:
			break;
		}
		Root = (xbb1HDH2EkVSoVw21YRc)P_1;
	}

	static xbb1HDH2EkVSoVw21YRc()
	{
		eRYypADiMSwJB2kpOoUa();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		UTIH2OVaK8I = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CC4D41), QevaY5DiO1dGreT003qp(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777809)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555203)), new PropertyMetadata(null));
	}

	[SpecialName]
	Visibility uUWLIoH2IMa6ubyC18Xq.get_Visibility()
	{
		return base.Visibility;
	}

	[SpecialName]
	void uUWLIoH2IMa6ubyC18Xq.set_Visibility(Visibility P_0)
	{
		base.Visibility = P_0;
	}

	internal static object sT71Z8DidQL3A2BxHBDb(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static bool WPm7K1DiEmHsBFM2CTiJ()
	{
		return xuRJOODijHr9MqbFVvKj == null;
	}

	internal static xbb1HDH2EkVSoVw21YRc fTdXPDDiQqvOFdacDOJm()
	{
		return xuRJOODijHr9MqbFVvKj;
	}

	internal static bool ar3tTNDigvEMTFJPB7fx(object P_0, object P_1)
	{
		return (Uri)P_0 == (Uri)P_1;
	}

	internal static object Y7BjplDiR0wG0RjSOit9(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void Sxddr0Di6JPlsV0tXyV8(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static void eRYypADiMSwJB2kpOoUa()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static Type QevaY5DiO1dGreT003qp(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
