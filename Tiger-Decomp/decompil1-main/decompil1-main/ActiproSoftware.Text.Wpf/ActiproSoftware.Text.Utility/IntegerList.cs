using System;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

public class IntegerList
{
	private int[] wVW;

	private short[] dV5;

	private int EV6;

	private static IntegerList OtY;

	public int Count => EV6;

	public int this[int index]
	{
		get
		{
			if (dV5 == null)
			{
				return wVW[index];
			}
			return dV5[index];
		}
		set
		{
			if (dV5 != null)
			{
				if (value <= 32767 && value >= -32768)
				{
					dV5[index] = (short)value;
					return;
				}
				eVO();
			}
			wVW[index] = value;
		}
	}

	public IntegerList(int capacity)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (capacity < 0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1782));
		}
		capacity = Math.Max(50, capacity);
		if (capacity <= 32767 && capacity >= -32768)
		{
			dV5 = new short[capacity];
		}
		else
		{
			wVW = new int[capacity];
		}
	}

	private void eVO()
	{
		wVW = new int[dV5.Length];
		Array.Copy(dV5, wVW, dV5.Length);
		dV5 = null;
	}

	private void NVl(int P_0)
	{
		if (wVW.Length < P_0)
		{
			int[] sourceArray = wVW;
			int num = Math.Max(P_0, (wVW.Length != 0) ? (wVW.Length * 2) : 4);
			wVW = new int[num];
			Array.Copy(sourceArray, wVW, EV6);
		}
	}

	private void MVi(int P_0)
	{
		if (dV5 != null && dV5.Length < P_0)
		{
			short[] sourceArray = dV5;
			int num = Math.Max(P_0, (dV5.Length != 0) ? (dV5.Length * 2) : 4);
			dV5 = new short[num];
			Array.Copy(sourceArray, dV5, EV6);
		}
	}

	public int Add(int value)
	{
		if (dV5 != null)
		{
			if (value <= 32767 && value >= -32768)
			{
				if (EV6 == dV5.Length)
				{
					MVi(EV6 + 1);
				}
				dV5[EV6++] = (short)value;
				return EV6;
			}
			eVO();
		}
		if (EV6 == wVW.Length)
		{
			NVl(EV6 + 1);
		}
		wVW[EV6++] = value;
		return EV6;
	}

	public int BinarySearch(int value)
	{
		if (dV5 != null)
		{
			if (value > 32767 || value < -32768)
			{
				if (value > 32767)
				{
					return ~EV6;
				}
				return -1;
			}
			return Array.BinarySearch(dV5, 0, EV6, (short)value);
		}
		return Array.BinarySearch(wVW, 0, EV6, value);
	}

	public void Increment(int index, int delta)
	{
		if (EV6 == 0 || delta == 0)
		{
			return;
		}
		if (dV5 != null)
		{
			if (dV5[EV6 - 1] + delta <= 32767 && (index >= EV6 || dV5[index] + delta >= -32768))
			{
				while (index < EV6)
				{
					dV5[index] = (short)(dV5[index] + delta);
					index++;
				}
				return;
			}
			eVO();
		}
		while (index < EV6)
		{
			wVW[index] += delta;
			index++;
		}
	}

	public void Insert(int index, int value)
	{
		if (dV5 != null)
		{
			if (value <= 32767 && value >= -32768)
			{
				if (EV6 == dV5.Length)
				{
					MVi(EV6 + 1);
				}
				if (index < EV6)
				{
					Array.Copy(dV5, index, dV5, index + 1, EV6 - index);
				}
				dV5[index] = (short)value;
				EV6++;
				return;
			}
			eVO();
		}
		if (EV6 == wVW.Length)
		{
			NVl(EV6 + 1);
		}
		if (index < EV6)
		{
			Array.Copy(wVW, index, wVW, index + 1, EV6 - index);
		}
		wVW[index] = value;
		EV6++;
	}

	public void RemoveAt(int index)
	{
		EV6--;
		bool flag = dV5 != null;
		int num = 0;
		if (!yte())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (!flag)
		{
			if (index < EV6)
			{
				Array.Copy(wVW, index + 1, wVW, index, EV6 - index);
			}
			wVW[EV6] = 0;
		}
		else
		{
			if (index < EV6)
			{
				Array.Copy(dV5, index + 1, dV5, index, EV6 - index);
			}
			dV5[EV6] = 0;
		}
	}

	public void RemoveRange(int index, int count)
	{
		if (count == 0)
		{
			return;
		}
		int num = EV6;
		EV6 -= count;
		if (dV5 != null)
		{
			if (index < EV6)
			{
				Array.Copy(dV5, index + count, dV5, index, EV6 - index);
			}
			while (num > EV6)
			{
				dV5[--num] = 0;
			}
		}
		else
		{
			if (index < EV6)
			{
				Array.Copy(wVW, index + count, wVW, index, EV6 - index);
			}
			while (num > EV6)
			{
				wVW[--num] = 0;
			}
		}
	}

	public int[] ToArray()
	{
		int[] array = new int[EV6];
		if (dV5 == null)
		{
			Array.Copy(wVW, array, EV6);
		}
		else
		{
			Array.Copy(dV5, array, EV6);
		}
		return array;
	}

	internal static bool yte()
	{
		return OtY == null;
	}

	internal static IntegerList Utg()
	{
		return OtY;
	}
}
