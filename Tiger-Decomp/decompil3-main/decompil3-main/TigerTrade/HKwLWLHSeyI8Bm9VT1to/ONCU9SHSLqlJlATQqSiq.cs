using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace HKwLWLHSeyI8Bm9VT1to;

public class ONCU9SHSLqlJlATQqSiq : DependencyObject, IValueConverter
{
	public static readonly DependencyProperty NSOHSEnvu54;

	public static readonly DependencyProperty N6UHSQpgJhW;

	private static ONCU9SHSLqlJlATQqSiq W0W7vpDeXA9kQlohvhDX;

	public object TrueValue
	{
		get
		{
			return GetValue(NSOHSEnvu54);
		}
		set
		{
			LjaiBoDeECPkVTmUuKfw(this, NSOHSEnvu54, obj);
		}
	}

	public object FalseValue
	{
		get
		{
			return GetValue(N6UHSQpgJhW);
		}
		set
		{
			SetValue(N6UHSQpgJhW, value2);
		}
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (P_0 is bool flag)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				if (!flag)
				{
					return FalseValue;
				}
				return TrueValue;
			}
		}
		return null;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public ONCU9SHSLqlJlATQqSiq()
	{
		LMIfWuDeQx5KwsykB9pb();
		base._002Ector();
	}

	static ONCU9SHSLqlJlATQqSiq()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				NSOHSEnvu54 = (DependencyProperty)DmdnFQDeRFEiCh5Qpq4d(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2123795572 ^ -2123870084), J86elvDeg5GFUku12qpE(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777240)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555334)));
				N6UHSQpgJhW = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7394D272 ^ 0x7395F674), J86elvDeg5GFUku12qpE(HfyGGODe6ixthp6Lreju(16777240)), J86elvDeg5GFUku12qpE(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555334)));
				return;
			case 1:
				DrjIo9Dedc6Boo5IC64V();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool Q9Xsk0DecGB7RWiX4SOl()
	{
		return W0W7vpDeXA9kQlohvhDX == null;
	}

	internal static ONCU9SHSLqlJlATQqSiq VnT9k3Dejo7vaetn2uU2()
	{
		return W0W7vpDeXA9kQlohvhDX;
	}

	internal static void LjaiBoDeECPkVTmUuKfw(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void LMIfWuDeQx5KwsykB9pb()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void DrjIo9Dedc6Boo5IC64V()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static Type J86elvDeg5GFUku12qpE(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object DmdnFQDeRFEiCh5Qpq4d(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}

	internal static RuntimeTypeHandle HfyGGODe6ixthp6Lreju(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}
}
