using System;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace ActiproSoftware.Internal;

internal class rT9
{
	private ScrollEventType? ywh;

	private int AwN;

	private int Awd;

	private int iwz;

	private DateTime n6W;

	private DateTime V6P;

	private Orientation n6E;

	internal static rT9 Wlf;

	public rT9(Orientation P_0, ScrollEventType P_1, int P_2, int P_3)
	{
		grA.DaB7cz();
		base._002Ector();
		n6E = P_0;
		Awd = Math.Max(250, Math.Min(10000, P_2));
		iwz = Math.Max(1, Math.Min(10, P_3));
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		n6W = DateTime.Now;
		ywh = P_1;
		V6P = DateTime.Now;
		AwN = 1;
	}

	[SpecialName]
	public int ywt()
	{
		return AwN;
	}

	public bool YwJ(Orientation P_0, ScrollEventType P_1)
	{
		DateTime now = DateTime.Now;
		if (n6E == P_0 && ywh == P_1 && now.Subtract(n6W).TotalMilliseconds <= 250.0)
		{
			n6W = now;
			bool flag = now.Subtract(V6P).TotalMilliseconds > (double)Awd;
			int num = 0;
			if (!Gli())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				if (flag)
				{
					V6P = now;
					AwN = Math.Min(iwz, AwN + 1);
				}
				return true;
			case 1:
			{
				bool result = default(bool);
				return result;
			}
			}
		}
		return false;
	}

	internal static bool Gli()
	{
		return Wlf == null;
	}

	internal static rT9 yl2()
	{
		return Wlf;
	}
}
