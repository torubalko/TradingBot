using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public class DataModelSortComparer : IComparer<IDataModel>
{
	[CompilerGenerated]
	private bool rnj;

	[CompilerGenerated]
	private bool Anx;

	[CompilerGenerated]
	private bool Yna;

	[CompilerGenerated]
	private bool ani;

	internal static DataModelSortComparer U6o;

	public bool CanCompareDisplayName
	{
		[CompilerGenerated]
		get
		{
			return rnj;
		}
		[CompilerGenerated]
		set
		{
			rnj = value;
		}
	}

	public bool CanCompareIndex
	{
		[CompilerGenerated]
		get
		{
			return Anx;
		}
		[CompilerGenerated]
		set
		{
			Anx = value;
		}
	}

	public bool CanCompareSortImportance
	{
		[CompilerGenerated]
		get
		{
			return Yna;
		}
		[CompilerGenerated]
		set
		{
			Yna = value;
		}
	}

	public bool CanCompareSortOrder
	{
		[CompilerGenerated]
		get
		{
			return ani;
		}
		[CompilerGenerated]
		set
		{
			ani = value;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#")]
	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "1#")]
	public virtual int Compare(IDataModel left, IDataModel right)
	{
		if (left != null)
		{
			if (right == null)
			{
				return -1;
			}
			if (CanCompareSortImportance)
			{
				int num = CompareSortImportance(left.SortImportance, right.SortImportance);
				if (num != 0)
				{
					return num;
				}
			}
			if (CanCompareSortOrder)
			{
				int num2 = CompareSortOrder(left.SortOrder, right.SortOrder);
				if (num2 != 0)
				{
					return num2;
				}
			}
			if (CanCompareIndex)
			{
				int num3 = CompareIndex(left.DisplayName, right.DisplayName);
				if (num3 != 0)
				{
					return num3;
				}
			}
			if (CanCompareDisplayName)
			{
				int num4 = CompareDisplayName(left.DisplayName, right.DisplayName);
				if (num4 != 0)
				{
					return num4;
				}
			}
		}
		else if (right != null)
		{
			return 1;
		}
		return 0;
	}

	protected virtual int CompareDisplayName(string left, string right)
	{
		return string.Compare(left, right, StringComparison.CurrentCulture);
	}

	protected virtual int CompareIndex(string left, string right)
	{
		if (!string.IsNullOrEmpty(left) && left.Length > 2 && left[0] == '[' && left[left.Length - 1] == ']' && !string.IsNullOrEmpty(right) && right.Length > 2 && right[0] == '[' && right[right.Length - 1] == ']' && int.TryParse(left.Substring(1, left.Length - 2), out var result) && int.TryParse(right.Substring(1, right.Length - 2), out var result2))
		{
			return result.CompareTo(result2);
		}
		return 0;
	}

	protected virtual int CompareSortImportance(DataModelSortImportance left, DataModelSortImportance right)
	{
		return left.CompareTo(right);
	}

	protected virtual int CompareSortOrder(int left, int right)
	{
		return left.CompareTo(right);
	}

	public DataModelSortComparer()
	{
		fc.taYSkz();
		rnj = true;
		Anx = true;
		Yna = true;
		ani = true;
		base._002Ector();
	}

	internal static bool z6Z()
	{
		return U6o == null;
	}

	internal static DataModelSortComparer Q6x()
	{
		return U6o;
	}
}
