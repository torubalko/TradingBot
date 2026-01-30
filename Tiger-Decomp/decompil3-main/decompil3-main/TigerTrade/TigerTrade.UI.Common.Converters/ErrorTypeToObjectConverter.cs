using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.UI.DocControls.Common.Link;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace TigerTrade.UI.Common.Converters;

public class ErrorTypeToObjectConverter : DependencyObject, IValueConverter
{
	public static readonly DependencyProperty b8gHk7K7Rjd;

	public static readonly DependencyProperty PeJHk8Laa3D;

	private static ErrorTypeToObjectConverter RYWNrrDxRCm9wYSXnAxt;

	public object ErrorType1
	{
		get
		{
			return GetValue(b8gHk7K7Rjd);
		}
		set
		{
			SetValue(b8gHk7K7Rjd, value2);
		}
	}

	public object ErrorType2
	{
		get
		{
			return GetValue(PeJHk8Laa3D);
		}
		set
		{
			QqIiXYDxOwwEhlGGip07(this, PeJHk8Laa3D, obj);
		}
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return ErrorType1;
			case 1:
				switch ((ErrorType)P_0)
				{
				case ErrorType.ErrorType1:
					break;
				case ErrorType.ErrorType2:
					return ErrorType2;
				default:
					return null;
				}
				goto default;
			case 2:
				if (P_0 is ErrorType)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return null;
			}
		}
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public ErrorTypeToObjectConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static ErrorTypeToObjectConverter()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		b8gHk7K7Rjd = (DependencyProperty)aass0pDxIoANprsUqcWP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1799510641 ^ -1799583801), Type.GetTypeFromHandle(xc4TtJDxqeQTPWtVeP74(16777240)), Type.GetTypeFromHandle(xc4TtJDxqeQTPWtVeP74(33555313)));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		PeJHk8Laa3D = (DependencyProperty)aass0pDxIoANprsUqcWP(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x3300B5CF), lymi1eDxWt4StDUQrPu6(xc4TtJDxqeQTPWtVeP74(16777240)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555313)));
	}

	internal static bool ta6ivNDx6QZlcOeUWgWX()
	{
		return RYWNrrDxRCm9wYSXnAxt == null;
	}

	internal static ErrorTypeToObjectConverter LjRGt6DxMcFYYc6NsqMh()
	{
		return RYWNrrDxRCm9wYSXnAxt;
	}

	internal static void QqIiXYDxOwwEhlGGip07(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static RuntimeTypeHandle xc4TtJDxqeQTPWtVeP74(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static object aass0pDxIoANprsUqcWP(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}

	internal static Type lymi1eDxWt4StDUQrPu6(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
