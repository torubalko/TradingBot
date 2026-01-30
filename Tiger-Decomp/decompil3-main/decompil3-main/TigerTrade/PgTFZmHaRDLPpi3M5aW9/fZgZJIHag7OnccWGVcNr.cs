using System.ComponentModel;
using System.Windows.Controls;
using TuAMtrl1Nd3XoZQQUXf0;

namespace PgTFZmHaRDLPpi3M5aW9;

public static class fZgZJIHag7OnccWGVcNr
{
	private static fZgZJIHag7OnccWGVcNr NHucYuDNyp00PGmZAHjy;

	public static void PdwHa6wgtGq(this DataGridColumn P_0)
	{
		int num = 2;
		int num2 = num;
		ListSortDirection? listSortDirection2 = default(ListSortDirection?);
		ListSortDirection listSortDirection3 = default(ListSortDirection);
		ListSortDirection? listSortDirection;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (listSortDirection2.HasValue)
				{
					listSortDirection2 = P_0.SortDirection;
					listSortDirection3 = ListSortDirection.Ascending;
					num2 = 4;
					continue;
				}
				listSortDirection = ListSortDirection.Ascending;
				break;
			case 2:
				listSortDirection2 = P_0.SortDirection;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				listSortDirection2 = null;
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				if (listSortDirection2 == listSortDirection3)
				{
					listSortDirection = ListSortDirection.Descending;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				listSortDirection = listSortDirection2;
				break;
			}
			break;
		}
		ListSortDirection? sortDirection = listSortDirection;
		P_0.SortDirection = sortDirection;
	}

	static fZgZJIHag7OnccWGVcNr()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool XCmus8DNZaiKGG7qlF1O()
	{
		return NHucYuDNyp00PGmZAHjy == null;
	}

	internal static fZgZJIHag7OnccWGVcNr RMsi8EDNVZwCFJYUIoZG()
	{
		return NHucYuDNyp00PGmZAHjy;
	}
}
