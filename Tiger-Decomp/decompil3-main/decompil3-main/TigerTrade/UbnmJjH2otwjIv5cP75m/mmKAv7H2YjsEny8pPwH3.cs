using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using beISYsH03nsuO140os4O;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace UbnmJjH2otwjIv5cP75m;

internal sealed class mmKAv7H2YjsEny8pPwH3 : UserControl, IComponentConnector
{
	public static readonly DependencyProperty HskH2eg90xH;

	public static readonly DependencyProperty UNuH2s2W4Bn;

	public static readonly RoutedEvent zwPH2XgBsSo;

	private static Brush oarH2cPNm7q;

	internal mmKAv7H2YjsEny8pPwH3 ColorPicker;

	internal ComboBox ComboBoxColors;

	private bool RFtH2jtMii3;

	internal static mmKAv7H2YjsEny8pPwH3 rvJD52DazROala3f5rTe;

	public Color SelectedColor
	{
		get
		{
			return (Color)GetValue(HskH2eg90xH);
		}
		set
		{
			IHUJmQDiH7lhDFVrNExj(this, HskH2eg90xH, color);
		}
	}

	public Brush SelectedBrush
	{
		get
		{
			return (Brush)GetValue(UNuH2s2W4Bn);
		}
		set
		{
			IHUJmQDiH7lhDFVrNExj(this, UNuH2s2W4Bn, brush);
		}
	}

	public static Brush CheckerBrush => oarH2cPNm7q ?? (oarH2cPNm7q = mJxH2bCMZVD());

	public event RoutedPropertyChangedEventHandler<Color> ColorChanged
	{
		add
		{
			AddHandler(zwPH2XgBsSo, handler);
		}
		remove
		{
			RemoveHandler(zwPH2XgBsSo, handler);
		}
	}

	public mmKAv7H2YjsEny8pPwH3()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		EckH2lb8frR();
	}

	private static void p7cH2vCda6K(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		mmKAv7H2YjsEny8pPwH3 mmKAv7H2YjsEny8pPwH4 = P_0 as mmKAv7H2YjsEny8pPwH3;
		Color color = (Color)P_1.NewValue;
		Color color2 = (Color)P_1.OldValue;
		if (color == color2)
		{
			return;
		}
		SN7atRH0F5U5QsuBRM5b sN7atRH0F5U5QsuBRM5b = mmKAv7H2YjsEny8pPwH4.ComboBoxColors.SelectedValue as SN7atRH0F5U5QsuBRM5b;
		int num;
		if (sN7atRH0F5U5QsuBRM5b != null)
		{
			num = 4;
			goto IL_0009;
		}
		goto IL_004b;
		IL_004b:
		if (MpBfTtDif8veLvgChgVV(mmKAv7H2YjsEny8pPwH4, color))
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_011f;
		IL_011f:
		mmKAv7H2YjsEny8pPwH4.AJcH24S7vxW(color, color.ToString(), _0020: true);
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
		{
			num = 1;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 2:
				mmKAv7H2YjsEny8pPwH4.hnDH2iuHmpJ(color2, color);
				return;
			default:
				mmKAv7H2YjsEny8pPwH4.SelectedBrush = new SolidColorBrush(color);
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
				{
					num = 2;
				}
				continue;
			case 4:
				if (sN7atRH0F5U5QsuBRM5b.Color != color)
				{
					goto IL_004b;
				}
				goto default;
			case 3:
				break;
			}
			break;
		}
		goto IL_011f;
	}

	private bool H29H2BK6tAu(Color P_0)
	{
		IEnumerator enumerator = (IEnumerator)nvEJaXDi9WgHQ98wkYOD(ComboBoxColors.Items);
		try
		{
			bool result = default(bool);
			while (D3QKX8DiGdgCkGr3CHWC(enumerator))
			{
				SN7atRH0F5U5QsuBRM5b sN7atRH0F5U5QsuBRM5b = OVd1LMDinn6mqqZIMSZt(enumerator) as SN7atRH0F5U5QsuBRM5b;
				int num = 2;
				while (true)
				{
					switch (num)
					{
					default:
						return result;
					case 2:
						break;
					case 1:
						result = true;
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
						{
							num = 0;
						}
						continue;
					}
					if (sN7atRH0F5U5QsuBRM5b == null || !(sN7atRH0F5U5QsuBRM5b.Color == P_0))
					{
						break;
					}
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
					{
						num = 0;
					}
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				default:
					disposable.Dispose();
					break;
				}
			}
		}
		return false;
	}

	private static void X5AH2ayTcAu(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		mmKAv7H2YjsEny8pPwH3 mmKAv7H2YjsEny8pPwH4 = (mmKAv7H2YjsEny8pPwH3)P_0;
		SolidColorBrush solidColorBrush = (SolidColorBrush)P_1.NewValue;
		if (uld4XtDiY7e902vrNCMV(mmKAv7H2YjsEny8pPwH4) != solidColorBrush.Color)
		{
			mmKAv7H2YjsEny8pPwH4.SelectedColor = qUC997Dio1qjtndunWif(solidColorBrush);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
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

	private void hnDH2iuHmpJ(Color P_0, Color P_1)
	{
		RoutedPropertyChangedEventArgs<Color> e = new RoutedPropertyChangedEventArgs<Color>(P_0, P_1)
		{
			RoutedEvent = zwPH2XgBsSo
		};
		RaiseEvent(e);
	}

	public void EckH2lb8frR()
	{
		int num = 3;
		int num2 = num;
		int num3 = default(int);
		PropertyInfo[] properties = default(PropertyInfo[]);
		while (true)
		{
			switch (num2)
			{
			default:
				num3 = 0;
				num2 = 5;
				break;
			case 3:
				ComboBoxColors.Items.Clear();
				num2 = 2;
				break;
			case 4:
				num3++;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			case 5:
			{
				if (num3 >= properties.Length)
				{
					SMf7QUDi48PB18tZUoAC(ComboBoxColors, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F645F3C ^ 0x7F655F96));
					return;
				}
				PropertyInfo propertyInfo = properties[num3];
				if ((string)tqYhrlDiaGd1NmhmEDmO(propertyInfo) != (string)cbbFD9DiiCMcTpZ4LRCn(-837284864 ^ -837219184))
				{
					AJcH24S7vxW((Color)jwY2IpDilIVn1ZnqnkCI(propertyInfo, null, null), (string)tqYhrlDiaGd1NmhmEDmO(propertyInfo));
					num2 = 4;
					break;
				}
				goto case 4;
			}
			case 2:
				AJcH24S7vxW(Colors.Transparent, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x34407BB ^ 0x345072B));
				properties = vDmo7pDiBWA3yE7orCuu(pVylBpDivfJJK7EoCXr8(16777745)).GetProperties();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void AJcH24S7vxW(Color P_0, string P_1, bool P_2 = false)
	{
		int num = 3;
		int num2 = num;
		SN7atRH0F5U5QsuBRM5b newItem = default(SN7atRH0F5U5QsuBRM5b);
		SN7atRH0F5U5QsuBRM5b sN7atRH0F5U5QsuBRM5b = default(SN7atRH0F5U5QsuBRM5b);
		while (true)
		{
			switch (num2)
			{
			case 1:
				ComboBoxColors.Items.Add(newItem);
				return;
			default:
				if (sN7atRH0F5U5QsuBRM5b != null && sN7atRH0F5U5QsuBRM5b.Custom)
				{
					ComboBoxColors.Items.Remove(sN7atRH0F5U5QsuBRM5b);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 1;
			case 3:
				if (!P_1.StartsWith(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28C965BE ^ 0x28C99BB0), StringComparison.Ordinal))
				{
					P_1 = (string)e0ktLTDiDrA13Wl1CEWX(P_1);
					num2 = 4;
				}
				else
				{
					num2 = 2;
				}
				break;
			case 2:
			case 4:
			{
				SN7atRH0F5U5QsuBRM5b obj = new SN7atRH0F5U5QsuBRM5b
				{
					Color = P_0,
					Name = P_1
				};
				DHylXJDib96vFE1GXUKL(obj, P_2);
				newItem = obj;
				if (ComboBoxColors.Items.Count > 0)
				{
					sN7atRH0F5U5QsuBRM5b = ComboBoxColors.Items[((CollectionView)B7cP7aDiNFUw93Iip7lN(ComboBoxColors)).Count - 1] as SN7atRH0F5U5QsuBRM5b;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
			}
		}
	}

	private static string kaDH2D8m1LV(string P_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		while (num < dqOdDJDi5C3lbYVDAeHX(P_0))
		{
			while (true)
			{
				if (num <= 0 || !char.IsUpper(P_0[num]))
				{
					goto IL_0035;
				}
				int num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
				{
					num2 = 2;
				}
				goto IL_0009;
				IL_0035:
				stringBuilder.Append(J1IXWgDi13DS8dvFKh1x(P_0, num));
				num++;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
				{
					num2 = 1;
				}
				goto IL_0009;
				IL_00e2:
				k9kJQRDikwLFGm4vtRA8(stringBuilder, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225829993));
				goto IL_0035;
				IL_0009:
				switch (num2)
				{
				case 2:
					break;
				case 1:
					goto end_IL_010d;
				case 3:
					goto IL_00e2;
				default:
					continue;
				}
				goto end_IL_00b5;
				continue;
				end_IL_010d:
				break;
			}
			continue;
			end_IL_00b5:
			break;
		}
		return stringBuilder.ToString();
	}

	public static Brush mJxH2bCMZVD()
	{
		DrawingBrush drawingBrush = new DrawingBrush();
		GeometryDrawing geometryDrawing = new GeometryDrawing((Brush)dCd1jfDiSMStM4pVMxCs(), null, new RectangleGeometry(new Rect(0.0, 0.0, 14.0, 14.0)));
		GeometryGroup geometryGroup = new GeometryGroup();
		L45DZwDixlO3UJi5fcCp(geometryGroup.Children, new RectangleGeometry(new Rect(0.0, 0.0, 7.0, 7.0)));
		L45DZwDixlO3UJi5fcCp(geometryGroup.Children, new RectangleGeometry(new Rect(7.0, 7.0, 7.0, 7.0)));
		GeometryDrawing value = new GeometryDrawing(Brushes.Black, null, geometryGroup);
		DrawingGroup drawingGroup = new DrawingGroup();
		ijyXrGDieTHIqGp3dyrL(BeqJt3DiLv1FJlovyoq2(drawingGroup), geometryDrawing);
		drawingGroup.Children.Add(value);
		ArWqXIDisREm7OOpOKM4(drawingBrush, drawingGroup);
		nZ4fppDiXAIP5cQ7AMq5(drawingBrush, new Rect(0.0, 0.0, 0.25, 0.5));
		drawingBrush.TileMode = TileMode.Tile;
		return drawingBrush;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
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
			case 0:
				return;
			case 1:
				if (!RFtH2jtMii3)
				{
					RFtH2jtMii3 = true;
					Uri resourceLocator = new Uri((string)cbbFD9DiiCMcTpZ4LRCn(-1325234765 ^ -1325169397), UriKind.Relative);
					Application.LoadComponent(this, resourceLocator);
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (P_0 != 2)
				{
					RFtH2jtMii3 = true;
				}
				else
				{
					ComboBoxColors = (ComboBox)P_1;
				}
				return;
			case 1:
				if (P_0 == 1)
				{
					ColorPicker = (mmKAv7H2YjsEny8pPwH3)P_1;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 2:
				return;
			}
		}
	}

	static mmKAv7H2YjsEny8pPwH3()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			HskH2eg90xH = DependencyProperty.Register((string)cbbFD9DiiCMcTpZ4LRCn(0x22BF43FC ^ 0x22BFBDE0), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777498)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555202)), new FrameworkPropertyMetadata(p7cH2vCda6K));
			UNuH2s2W4Bn = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53847818), vDmo7pDiBWA3yE7orCuu(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777400)), Type.GetTypeFromHandle(pVylBpDivfJJK7EoCXr8(33555202)), new FrameworkPropertyMetadata(X5AH2ayTcAu));
			zwPH2XgBsSo = (RoutedEvent)JXomafDic9GZXpQRbQvn(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24B0B9E6 ^ 0x24B1B886), RoutingStrategy.Bubble, typeof(RoutedPropertyChangedEventHandler<Color>), vDmo7pDiBWA3yE7orCuu(pVylBpDivfJJK7EoCXr8(33555202)));
			num2 = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
			{
				num2 = 1;
			}
		}
	}

	internal static bool Fpn6KRDi0TFofbE9su0d()
	{
		return rvJD52DazROala3f5rTe == null;
	}

	internal static mmKAv7H2YjsEny8pPwH3 H43oPPDi2GGpXFfMH3yk()
	{
		return rvJD52DazROala3f5rTe;
	}

	internal static void IHUJmQDiH7lhDFVrNExj(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static bool MpBfTtDif8veLvgChgVV(object P_0, Color P_1)
	{
		return ((mmKAv7H2YjsEny8pPwH3)P_0).H29H2BK6tAu(P_1);
	}

	internal static object nvEJaXDi9WgHQ98wkYOD(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object OVd1LMDinn6mqqZIMSZt(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool D3QKX8DiGdgCkGr3CHWC(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static Color uld4XtDiY7e902vrNCMV(object P_0)
	{
		return ((mmKAv7H2YjsEny8pPwH3)P_0).SelectedColor;
	}

	internal static Color qUC997Dio1qjtndunWif(object P_0)
	{
		return ((SolidColorBrush)P_0).Color;
	}

	internal static RuntimeTypeHandle pVylBpDivfJJK7EoCXr8(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static Type vDmo7pDiBWA3yE7orCuu(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object tqYhrlDiaGd1NmhmEDmO(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object cbbFD9DiiCMcTpZ4LRCn(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object jwY2IpDilIVn1ZnqnkCI(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static void SMf7QUDi48PB18tZUoAC(object P_0, object P_1)
	{
		((Selector)P_0).SelectedValuePath = (string)P_1;
	}

	internal static object e0ktLTDiDrA13Wl1CEWX(object P_0)
	{
		return kaDH2D8m1LV((string)P_0);
	}

	internal static void DHylXJDib96vFE1GXUKL(object P_0, bool P_1)
	{
		((SN7atRH0F5U5QsuBRM5b)P_0).Custom = P_1;
	}

	internal static object B7cP7aDiNFUw93Iip7lN(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static object k9kJQRDikwLFGm4vtRA8(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static char J1IXWgDi13DS8dvFKh1x(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static int dqOdDJDi5C3lbYVDAeHX(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object dCd1jfDiSMStM4pVMxCs()
	{
		return Brushes.White;
	}

	internal static void L45DZwDixlO3UJi5fcCp(object P_0, object P_1)
	{
		((GeometryCollection)P_0).Add((Geometry)P_1);
	}

	internal static object BeqJt3DiLv1FJlovyoq2(object P_0)
	{
		return ((DrawingGroup)P_0).Children;
	}

	internal static void ijyXrGDieTHIqGp3dyrL(object P_0, object P_1)
	{
		((DrawingCollection)P_0).Add((Drawing)P_1);
	}

	internal static void ArWqXIDisREm7OOpOKM4(object P_0, object P_1)
	{
		((DrawingBrush)P_0).Drawing = (Drawing)P_1;
	}

	internal static void nZ4fppDiXAIP5cQ7AMq5(object P_0, Rect P_1)
	{
		((TileBrush)P_0).Viewport = P_1;
	}

	internal static object JXomafDic9GZXpQRbQvn(object P_0, RoutingStrategy P_1, Type P_2, Type P_3)
	{
		return EventManager.RegisterRoutedEvent((string)P_0, P_1, P_2, P_3);
	}
}
