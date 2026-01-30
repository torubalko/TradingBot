using System.Windows;
using System.Windows.Data;

namespace ActiproSoftware.Internal;

internal static class Ldu
{
	internal static Ldu NSa;

	public static Binding EIz(object P_0, string P_1, BindingMode P_2, IValueConverter P_3, object P_4 = null)
	{
		Binding binding = new Binding();
		binding.Path = new PropertyPath(P_1);
		binding.Source = P_0;
		binding.Mode = P_2;
		if (P_3 != null)
		{
			binding.Converter = P_3;
		}
		if (P_4 != null)
		{
			binding.ConverterParameter = P_4;
		}
		return binding;
	}

	internal static bool YSj()
	{
		return NSa == null;
	}

	internal static Ldu tSG()
	{
		return NSa;
	}
}
