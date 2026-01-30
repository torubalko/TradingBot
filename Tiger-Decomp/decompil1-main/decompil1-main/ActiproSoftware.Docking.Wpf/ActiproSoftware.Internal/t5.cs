using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Data;

namespace ActiproSoftware.Internal;

[ValueConversion(typeof(Dock), typeof(Orientation))]
internal sealed class t5 : IValueConverter
{
	[CompilerGenerated]
	private bool jEZ;

	private static t5 rnU;

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (!(P_0 is Dock dock))
		{
			throw new ArgumentException(vVK.ssH(21492));
		}
		if (dock == Dock.Left || dock == Dock.Right)
		{
			return jEc() ? Orientation.Vertical : Orientation.Horizontal;
		}
		return (!jEc()) ? Orientation.Vertical : Orientation.Horizontal;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	[SpecialName]
	[CompilerGenerated]
	public bool jEc()
	{
		return jEZ;
	}

	[SpecialName]
	[CompilerGenerated]
	public void zE4(bool P_0)
	{
		jEZ = P_0;
	}

	public t5()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool DnF()
	{
		return rnU == null;
	}

	internal static t5 Cnd()
	{
		return rnU;
	}
}
