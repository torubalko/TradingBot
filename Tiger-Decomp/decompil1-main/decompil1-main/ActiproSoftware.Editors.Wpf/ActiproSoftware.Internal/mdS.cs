using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;

namespace ActiproSoftware.Internal;

internal class mdS : IValueConverter
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool zqV;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private double IqC;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private double Oq6;

	internal static mdS XSq;

	public mdS(double P_0, double P_1, bool P_2)
	{
		awj.QuEwGz();
		base._002Ector();
		fGz((P_0 != 0.0) ? P_0 : 1.0);
		TGw(P_1);
		xG4(P_2);
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		double result = 0.0;
		if (P_0 is double)
		{
			result = (double)P_0;
		}
		else if (P_0 != null && !double.TryParse(P_0.ToString(), out result))
		{
			result = 0.0;
		}
		double num = result + oGh();
		double num2 = num * zGU();
		if (PG7())
		{
			num2 = Math.Min(359.999999999, num2);
		}
		return num2;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		double num = (double)P_0;
		double num2 = Math.Round(num / zGU(), 8, MidpointRounding.AwayFromZero);
		return num2 - oGh();
	}

	[SpecialName]
	[CompilerGenerated]
	public bool PG7()
	{
		return zqV;
	}

	[SpecialName]
	[CompilerGenerated]
	private void xG4(bool P_0)
	{
		zqV = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public double oGh()
	{
		return IqC;
	}

	[SpecialName]
	[CompilerGenerated]
	private void TGw(double P_0)
	{
		IqC = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public double zGU()
	{
		return Oq6;
	}

	[SpecialName]
	[CompilerGenerated]
	private void fGz(double P_0)
	{
		Oq6 = P_0;
	}

	internal static bool ASn()
	{
		return XSq == null;
	}

	internal static mdS QSg()
	{
		return XSq;
	}
}
