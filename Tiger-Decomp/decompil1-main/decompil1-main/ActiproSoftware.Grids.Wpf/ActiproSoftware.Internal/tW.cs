using System;
using System.Collections.Generic;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;

namespace ActiproSoftware.Internal;

internal class tW : IEqualityComparer<IPropertyModel>
{
	internal static tW WFy;

	public bool Equals(IPropertyModel P_0, IPropertyModel P_1)
	{
		if (P_0 == null && P_1 == null)
		{
			return true;
		}
		if (P_0 == null || P_1 == null)
		{
			return false;
		}
		if (P_0.Name == P_1.Name)
		{
			return P_0.ValueType == P_1.ValueType;
		}
		return false;
	}

	public int GetHashCode(IPropertyModel P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(3974));
		}
		string name = P_0.Name;
		Type valueType = P_0.ValueType;
		if (name != null)
		{
			if (valueType != null)
			{
				return ((name.GetHashCode() << 5) + name.GetHashCode()) ^ valueType.GetHashCode();
			}
			return name.GetHashCode();
		}
		if (valueType != null)
		{
			return valueType.GetHashCode();
		}
		return 0;
	}

	public tW()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool iFf()
	{
		return WFy == null;
	}

	internal static tW pFo()
	{
		return WFy;
	}
}
