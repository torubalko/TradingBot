using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ActiproSoftware.Internal;

[ValueConversion(typeof(Thickness), typeof(Thickness))]
internal sealed class Mr : IValueConverter
{
	[CompilerGenerated]
	private Dock GxO;

	private static Mr NAG;

	public Dock TabStripPlacement
	{
		[CompilerGenerated]
		get
		{
			return GxO;
		}
		[CompilerGenerated]
		set
		{
			GxO = gxO;
		}
	}

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (P_0 is Thickness thickness)
		{
			return TabStripPlacement switch
			{
				Dock.Bottom => new Thickness(thickness.Right, thickness.Bottom, thickness.Left, thickness.Top), 
				Dock.Left => new Thickness(thickness.Top, thickness.Right, thickness.Bottom, thickness.Left), 
				Dock.Right => new Thickness(thickness.Bottom, thickness.Left, thickness.Top, thickness.Right), 
				_ => thickness, 
			};
		}
		throw new ArgumentException(vVK.ssH(22076));
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public Mr()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool MAc()
	{
		return NAG == null;
	}

	internal static Mr WAM()
	{
		return NAG;
	}
}
