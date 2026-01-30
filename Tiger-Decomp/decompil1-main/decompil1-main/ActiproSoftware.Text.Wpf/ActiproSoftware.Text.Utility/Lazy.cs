using System;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

internal sealed class Lazy<T>
{
	private readonly Func<T> fVZ;

	private bool iV0;

	private readonly object nVv;

	private T sVY;

	internal static object MWP;

	public bool IsValueCreated
	{
		get
		{
			lock (nVv)
			{
				return iV0;
			}
		}
	}

	public T Value
	{
		get
		{
			if (!iV0)
			{
				lock (nVv)
				{
					if (!iV0)
					{
						sVY = fVZ();
						iV0 = true;
					}
				}
			}
			return sVY;
		}
	}

	public Lazy(Func<T> createValue)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		nVv = new object();
		base._002Ector();
		if (createValue == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1802));
		}
		fVZ = createValue;
	}

	internal static bool LWU()
	{
		return MWP == null;
	}

	internal static object YW2()
	{
		return MWP;
	}
}
