using System;
using System.Globalization;
using System.Windows.Data;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

public class PnlSignConverter : IValueConverter
{
	private static PnlSignConverter ncjJgvDL00mHW3ehiCFk;

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (P_0 is double)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return null;
			case 1:
			{
				double num3 = (double)P_0;
				_ = ((MhMDPU9v8rkigy1ao0Th)kXLir1DLffwTCKZEpDTZ()).AppTheme;
				if (num3 > double.Epsilon)
				{
					return 1;
				}
				if (num3 < -5E-324)
				{
					return -1;
				}
				return 0;
			}
			}
		}
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public PnlSignConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static PnlSignConverter()
	{
		zpSFqLDL9tI737S3KpQt();
	}

	internal static object kXLir1DLffwTCKZEpDTZ()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static bool vjoQikDL2i1ITVxgnKXI()
	{
		return ncjJgvDL00mHW3ehiCFk == null;
	}

	internal static PnlSignConverter hKOyr8DLHxI5sxA6jKPg()
	{
		return ncjJgvDL00mHW3ehiCFk;
	}

	internal static void zpSFqLDL9tI737S3KpQt()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
