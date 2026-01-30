using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

public sealed class EmptyObjectToVisibilityConverter : IValueConverter
{
	[CompilerGenerated]
	private bool laWH57HQAZc;

	private static EmptyObjectToVisibilityConverter i4ZS53DLPtZiFaYvsI0J;

	public bool IsInverted
	{
		[CompilerGenerated]
		get
		{
			return laWH57HQAZc;
		}
		[CompilerGenerated]
		set
		{
			laWH57HQAZc = flag;
		}
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		bool flag = P_0 != null;
		int num2;
		if (IsInverted ^ flag)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			num2 = 0;
		}
		else
		{
			num2 = 2;
		}
		return (Visibility)num2;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public EmptyObjectToVisibilityConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static EmptyObjectToVisibilityConverter()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool VGOg5kDLJ2QN340Kuww2()
	{
		return i4ZS53DLPtZiFaYvsI0J == null;
	}

	internal static EmptyObjectToVisibilityConverter qdfr7CDLF1uleOL7pKEI()
	{
		return i4ZS53DLPtZiFaYvsI0J;
	}
}
