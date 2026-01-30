using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class CdA : Id4
{
	internal static CdA shC;

	public override bool IsOptional => true;

	public CdA()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool ohE()
	{
		return shC == null;
	}

	internal static CdA nh3()
	{
		return shC;
	}
}
internal static class cda
{
	internal static cda USA;

	public static string NbM(byte? P_0, string P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		return P_0.Value.ToString(P_1, CultureInfo.CurrentCulture);
	}

	public static IList<IPart> jbs(string P_0, CultureInfo P_1)
	{
		P_0 = Xbj(P_0, P_1);
		List<IPart> list = new List<IPart>();
		Dm dm = new Dm();
		dm.Format = P_0;
		list.Add(dm);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static string Xbj(string P_0, CultureInfo P_1)
	{
		if (P_1 == null)
		{
			P_1 = CultureInfo.CurrentCulture;
		}
		if (P_0 != null)
		{
			int num = 0;
			if (!kSt())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			P_0 = P_0.Trim();
		}
		if (string.IsNullOrEmpty(P_0))
		{
			P_0 = QdM.AR8(1942);
		}
		return P_0;
	}

	public static byte DbP(byte P_0, int P_1, byte? P_2, byte? P_3, SpinWrapping P_4)
	{
		byte valueOrDefault = P_2.GetValueOrDefault();
		byte b = P_3 ?? byte.MaxValue;
		try
		{
			P_0 = ((P_1 >= 0) ? ((P_0 <= b - P_1) ? zbf((byte)(P_0 + P_1), valueOrDefault, b) : ((P_0 < b || P_4 == SpinWrapping.NoWrap) ? b : valueOrDefault)) : ((P_0 >= valueOrDefault - P_1) ? zbf((byte)(P_0 + P_1), valueOrDefault, b) : ((P_0 > valueOrDefault || P_4 == SpinWrapping.NoWrap) ? valueOrDefault : b)));
		}
		catch (OverflowException)
		{
			P_0 = ((P_1 > 0) ? b : valueOrDefault);
		}
		return P_0;
	}

	public static byte wb2(byte P_0, byte P_1)
	{
		return (P_0 > P_1) ? P_0 : P_1;
	}

	public static byte eba(byte P_0, byte P_1)
	{
		return (P_0 < P_1) ? P_0 : P_1;
	}

	[SpecialName]
	public static string bbX()
	{
		char c = ',';
		string numberDecimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
		if (!string.IsNullOrEmpty(numberDecimalSeparator) && c == numberDecimalSeparator[0])
		{
			int num = 0;
			if (fSe() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			c = ';';
		}
		return c + QdM.AR8(23766);
	}

	public static byte zbf(byte P_0, byte P_1, byte P_2)
	{
		return wb2(P_1, eba(P_0, P_2));
	}

	public static bool Hbl(string P_0, string P_1, out byte? P_2)
	{
		P_2 = null;
		if (string.IsNullOrEmpty(P_0))
		{
			return true;
		}
		byte result;
		if (P_1.StartsWith(QdM.AR8(20000), StringComparison.OrdinalIgnoreCase))
		{
			if (byte.TryParse(P_0, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out result))
			{
				P_2 = result;
				return true;
			}
			return false;
		}
		if (P_1.StartsWith(QdM.AR8(23296), StringComparison.OrdinalIgnoreCase))
		{
			if (byte.TryParse(P_0, NumberStyles.Currency, CultureInfo.CurrentCulture, out result))
			{
				P_2 = result;
				return true;
			}
			return false;
		}
		string[] array = wdv.nGG(P_0, P_1);
		if (byte.TryParse(array[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result) || byte.TryParse(array[0], NumberStyles.Any, CultureInfo.CurrentCulture, out result))
		{
			P_2 = result;
			return true;
		}
		return false;
	}

	internal static bool kSt()
	{
		return USA == null;
	}

	internal static cda fSe()
	{
		return USA;
	}
}
