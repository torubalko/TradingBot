using System.Windows;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Themes;

public static class DataGridResourceKeys
{
	private static ComponentResourceKey PN;

	private static ComponentResourceKey io;

	private static ComponentResourceKey Ki;

	private static ComponentResourceKey hY;

	private static ComponentResourceKey B9;

	private static ComponentResourceKey XL;

	internal static DataGridResourceKeys AP;

	public static ResourceKey DataGridCellStyleKey
	{
		get
		{
			if (PN == null)
			{
				PN = new ComponentResourceKey(typeof(DataGridResourceKeys), Ng.cn(356));
			}
			return PN;
		}
	}

	public static ResourceKey DataGridColumnHeaderStyleKey
	{
		get
		{
			if (io == null)
			{
				io = new ComponentResourceKey(typeof(DataGridResourceKeys), Ng.cn(400));
			}
			return io;
		}
	}

	public static ResourceKey DataGridRowHeaderStyleKey
	{
		get
		{
			if (Ki == null)
			{
				Ki = new ComponentResourceKey(typeof(DataGridResourceKeys), Ng.cn(460));
			}
			return Ki;
		}
	}

	public static ResourceKey DataGridRowStyleKey
	{
		get
		{
			if (hY == null)
			{
				hY = new ComponentResourceKey(typeof(DataGridResourceKeys), Ng.cn(514));
			}
			return hY;
		}
	}

	public static ResourceKey DataGridSelectAllButtonStyleKey
	{
		get
		{
			if (B9 == null)
			{
				B9 = new ComponentResourceKey(typeof(DataGridResourceKeys), Ng.cn(556));
			}
			return B9;
		}
	}

	public static ResourceKey DataGridStyleKey
	{
		get
		{
			if (XL == null)
			{
				XL = new ComponentResourceKey(typeof(DataGridResourceKeys), Ng.cn(622));
			}
			return XL;
		}
	}

	internal static bool gC()
	{
		return AP == null;
	}

	internal static DataGridResourceKeys eU()
	{
		return AP;
	}
}
