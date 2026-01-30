using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace NUg99iae75BZkMF6sUSt;

public class n0pqLLaew7FU1mkgf3xY : DataTemplateSelector
{
	[CompilerGenerated]
	private DataTemplate SEpaeFE7e2d;

	[CompilerGenerated]
	private DataTemplate us9ae3FlplN;

	internal static n0pqLLaew7FU1mkgf3xY NaLXQGxmMRvtUvjEEeHF;

	public DataTemplate SelectedTemplate
	{
		[CompilerGenerated]
		get
		{
			return SEpaeFE7e2d;
		}
		[CompilerGenerated]
		set
		{
			SEpaeFE7e2d = sEpaeFE7e2d;
		}
	}

	public DataTemplate DropDownTemplate
	{
		[CompilerGenerated]
		get
		{
			return us9ae3FlplN;
		}
		[CompilerGenerated]
		set
		{
			us9ae3FlplN = dataTemplate;
		}
	}

	public override DataTemplate SelectTemplate(object P_0, DependencyObject P_1)
	{
		while (P_1 != null)
		{
			P_1 = VisualTreeHelper.GetParent(P_1);
			if (P_1 is ComboBoxItem)
			{
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a != 0)
				{
					num = 0;
				}
				return num switch
				{
					_ => DropDownTemplate, 
				};
			}
		}
		return SelectedTemplate;
	}

	public n0pqLLaew7FU1mkgf3xY()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static n0pqLLaew7FU1mkgf3xY()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		goOBjgxmIjfkRwxZq1Af();
	}

	internal static bool EfDMAExmOY9LVVn31Xik()
	{
		return NaLXQGxmMRvtUvjEEeHF == null;
	}

	internal static n0pqLLaew7FU1mkgf3xY aDfJBoxmqxW0SuEYYS1R()
	{
		return NaLXQGxmMRvtUvjEEeHF;
	}

	internal static void goOBjgxmIjfkRwxZq1Af()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
