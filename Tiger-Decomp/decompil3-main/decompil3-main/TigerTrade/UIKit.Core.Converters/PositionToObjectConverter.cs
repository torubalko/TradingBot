using System;
using System.Globalization;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.UI.Controls.Toolbar;
using TuAMtrl1Nd3XoZQQUXf0;

namespace UIKit.Core.Converters;

[ValueConversion(typeof(XToolbarPosition), typeof(Placement))]
internal class PositionToObjectConverter : IValueConverter
{
	private static PositionToObjectConverter o0BFkblIa5UH9DvEnqLq;

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		int num = 2;
		int num2 = num;
		XToolbarPosition xToolbarPosition = default(XToolbarPosition);
		while (true)
		{
			switch (num2)
			{
			default:
				return xToolbarPosition switch
				{
					XToolbarPosition.Left => Placement.Right, 
					XToolbarPosition.Right => Placement.Left, 
					XToolbarPosition.Top => Placement.Bottom, 
					XToolbarPosition.Bottom => Placement.Top, 
					_ => Binding.DoNothing, 
				};
			case 1:
				xToolbarPosition = (XToolbarPosition)P_0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (!(P_0 is XToolbarPosition))
				{
					return Binding.DoNothing;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (!(P_0 is Placement))
		{
			return Binding.DoNothing;
		}
		return (Placement)P_0 switch
		{
			Placement.Right => XToolbarPosition.Left, 
			Placement.Left => XToolbarPosition.Right, 
			Placement.Bottom => XToolbarPosition.Top, 
			Placement.Top => XToolbarPosition.Bottom, 
			_ => Binding.DoNothing, 
		};
	}

	public PositionToObjectConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static PositionToObjectConverter()
	{
		SPXhQmlI4GrsFc39PLIR();
	}

	internal static bool K9SsaflIik1JaETkAPrT()
	{
		return o0BFkblIa5UH9DvEnqLq == null;
	}

	internal static PositionToObjectConverter lPth52lIljB61XeTe9Yk()
	{
		return o0BFkblIa5UH9DvEnqLq;
	}

	internal static void SPXhQmlI4GrsFc39PLIR()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
