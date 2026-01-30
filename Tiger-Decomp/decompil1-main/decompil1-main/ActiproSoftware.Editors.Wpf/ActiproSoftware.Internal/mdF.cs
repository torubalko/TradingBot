using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;

namespace ActiproSoftware.Internal;

internal class mdF : IValueConverter
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private double kqP;

	internal static mdF OSs;

	public mdF(double P_0)
	{
		awj.QuEwGz();
		base._002Ector();
		Lqs((P_0 != 0.0) ? P_0 : 1.0);
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		int result = 0;
		if (P_0 is int)
		{
			result = (int)P_0;
		}
		else if (P_0 != null && !int.TryParse(P_0.ToString(), out result))
		{
			result = 0;
		}
		double num = (double)result * FqM();
		return num;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		double num = (double)P_0;
		int num2 = (int)Math.Round(num / FqM(), MidpointRounding.AwayFromZero);
		return num2;
	}

	[SpecialName]
	[CompilerGenerated]
	public double FqM()
	{
		return kqP;
	}

	[SpecialName]
	[CompilerGenerated]
	private void Lqs(double P_0)
	{
		kqP = P_0;
	}

	internal static bool NSY()
	{
		return OSs == null;
	}

	internal static mdF NSx()
	{
		return OSs;
	}
}
