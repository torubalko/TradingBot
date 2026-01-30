using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MimeKit.Utils;

internal sealed class OptimizedOrdinalIgnoreCaseComparer : IEqualityComparer<string>
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static int ToUpper(int c)
	{
		if ((uint)(c - 97) <= 25u)
		{
			return c - 32;
		}
		return c;
	}

	public bool Equals(string x, string y)
	{
		if (x.Length != y.Length)
		{
			return false;
		}
		int length = x.Length;
		for (int i = 0; i < length; i++)
		{
			if (ToUpper(x[i]) != ToUpper(y[i]))
			{
				return false;
			}
		}
		return true;
	}

	public unsafe int GetHashCode(string obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		fixed (char* ptr = obj)
		{
			int num = 5381;
			int num2 = num;
			char* ptr2 = ptr;
			int c;
			while ((c = *ptr2) != 0)
			{
				num = ((num << 5) + num) ^ ToUpper(c);
				if ((c = ptr2[1]) == 0)
				{
					break;
				}
				num2 = ((num2 << 5) + num2) ^ ToUpper(c);
				ptr2 += 2;
			}
			return num + num2 * 1566083941;
		}
	}
}
