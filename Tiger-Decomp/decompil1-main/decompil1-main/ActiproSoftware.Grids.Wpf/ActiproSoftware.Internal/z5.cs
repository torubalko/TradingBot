using ActiproSoftware.Windows.Controls.Grids;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;

namespace ActiproSoftware.Internal;

internal static class z5
{
	internal static z5 A6M;

	public static void Xn8(this IDataModel P_0)
	{
		DataModelCollection dataModelCollection = P_0?.Children;
		if (dataModelCollection != null)
		{
			for (int num = dataModelCollection.Count - 1; num >= 0; num--)
			{
				dataModelCollection.RemoveAt(num);
			}
		}
	}

	public static PropertyGrid En9(this IDataModel P_0)
	{
		if (P_0 != null)
		{
			pn pn2 = P_0.zn3();
			if (pn2 != null)
			{
				return pn2.wEW();
			}
		}
		return null;
	}

	public static pn zn3(this IDataModel P_0)
	{
		while (P_0 != null)
		{
			if (P_0.IsRoot && P_0 is pn result)
			{
				return result;
			}
			P_0 = P_0.Parent;
		}
		return null;
	}

	public static IDataModel AnL(this IDataModel P_0)
	{
		if (P_0 == null)
		{
			return P_0;
		}
		IDataModel parent = P_0.Parent;
		while (parent != null && !parent.IsRoot)
		{
			P_0 = parent;
			parent = P_0.Parent;
		}
		return P_0;
	}

	internal static bool G6y()
	{
		return A6M == null;
	}

	internal static z5 y6f()
	{
		return A6M;
	}
}
