using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace rsMINhHaymWoa3uMVnRK;

[DataContract(Name = "XDataGridColumnInfo", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.UI.Controls.XDataGrid")]
internal struct FxMMZlHaTQsidTyCItUJ
{
	[DataMember(Name = "PropertyPath")]
	public string lfqHaCmpXQM;

	[DataMember(Name = "SortDirection")]
	public ListSortDirection? SortDirection;

	[DataMember(Name = "DisplayIndex")]
	public int RlyHarHQHFD;

	[DataMember(Name = "WidthValue")]
	public double UReHaKnxiD9;

	[DataMember(Name = "WidthType")]
	public DataGridLengthUnitType lSPHamGHqui;

	[DataMember(Name = "Visibility")]
	public Visibility Visibility;

	internal static object qaCAxXDNwloOSvIKTbTy;

	public FxMMZlHaTQsidTyCItUJ(DataGridColumn P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				Visibility = vHpVxXDNAXjCHug3Mv0U(P_0);
				return;
			default:
				UReHaKnxiD9 = P_0.Width.DisplayValue;
				lSPHamGHqui = P_0.Width.UnitType;
				SortDirection = P_0.SortDirection;
				RlyHarHQHFD = P_0.DisplayIndex;
				num = 2;
				break;
			case 1:
				lfqHaCmpXQM = L2YHaZPIM9U(P_0);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public static string L2YHaZPIM9U(DataGridColumn P_0)
	{
		int num = 2;
		int num2 = num;
		DataGridBoundColumn dataGridBoundColumn = default(DataGridBoundColumn);
		DataGridTemplateColumn dataGridTemplateColumn = default(DataGridTemplateColumn);
		while (true)
		{
			switch (num2)
			{
			case 2:
				dataGridBoundColumn = P_0 as DataGridBoundColumn;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd != 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (dataGridTemplateColumn != null)
				{
					return dataGridTemplateColumn.SortMemberPath;
				}
				return string.Empty;
			case 1:
				if (dataGridBoundColumn != null)
				{
					return (string)Cr8DGkDNJHVJj48pF9sU(((Binding)v1wRukDNP6j9hKLVnfVO(dataGridBoundColumn)).Path);
				}
				dataGridTemplateColumn = P_0 as DataGridTemplateColumn;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void TWuHaVjjV6W(DataGridColumn P_0, int P_1, SortDescriptionCollection P_2)
	{
		T2Hdo2DNF4lLGenh1Sjf(P_0, new DataGridLength(UReHaKnxiD9, lSPHamGHqui));
		P_0.SortDirection = SortDirection;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				P_2.Add(new SortDescription(lfqHaCmpXQM, SortDirection.Value));
				num = 3;
				break;
			case 3:
				if (P_0.DisplayIndex != RlyHarHQHFD)
				{
					int num2 = ((P_1 != 0) ? (P_1 - 1) : 0);
					P_0.DisplayIndex = ((RlyHarHQHFD <= num2) ? RlyHarHQHFD : num2);
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
					{
						num = 0;
					}
					break;
				}
				goto case 1;
			default:
				if (SortDirection.HasValue)
				{
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
					{
						num = 2;
					}
					break;
				}
				goto case 3;
			case 1:
				P_0.Visibility = Visibility;
				return;
			}
		}
	}

	static FxMMZlHaTQsidTyCItUJ()
	{
		eVqenQDN3bjR7Dd9F3kK();
	}

	internal static Visibility vHpVxXDNAXjCHug3Mv0U(object P_0)
	{
		return ((DataGridColumn)P_0).Visibility;
	}

	internal static bool wWvl8RDN7yBFaQ4lrirC()
	{
		return qaCAxXDNwloOSvIKTbTy == null;
	}

	internal static object sqlk1FDN86Q60iUrHV7E()
	{
		return qaCAxXDNwloOSvIKTbTy;
	}

	internal static object v1wRukDNP6j9hKLVnfVO(object P_0)
	{
		return ((DataGridBoundColumn)P_0).Binding;
	}

	internal static object Cr8DGkDNJHVJj48pF9sU(object P_0)
	{
		return ((PropertyPath)P_0).Path;
	}

	internal static void T2Hdo2DNF4lLGenh1Sjf(object P_0, DataGridLength P_1)
	{
		((DataGridColumn)P_0).Width = P_1;
	}

	internal static void eVqenQDN3bjR7Dd9F3kK()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
