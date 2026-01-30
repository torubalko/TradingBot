using System.Collections.Generic;
using System.Windows;

namespace ActiproSoftware.Internal;

internal class eAS : dTt
{
	private Dictionary<string, object> m6Y;

	internal static eAS Bld;

	public override object GetData(string P_0)
	{
		if (!m6Y.TryGetValue(P_0, out var value))
		{
			return null;
		}
		return value;
	}

	public override bool GetDataPresent(string P_0)
	{
		return m6Y.ContainsKey(P_0);
	}

	protected override void W8y(string P_0, object P_1, bool P_2)
	{
		if (P_1 == null)
		{
			if (GetDataPresent(P_0))
			{
				m6Y.Remove(P_0);
			}
		}
		else
		{
			m6Y.Add(P_0, P_1);
		}
	}

	public override IDataObject ToDataObject()
	{
		return null;
	}

	public eAS()
	{
		grA.DaB7cz();
		m6Y = new Dictionary<string, object>();
		base._002Ector();
	}

	internal static bool flT()
	{
		return Bld == null;
	}

	internal static eAS flt()
	{
		return Bld;
	}
}
