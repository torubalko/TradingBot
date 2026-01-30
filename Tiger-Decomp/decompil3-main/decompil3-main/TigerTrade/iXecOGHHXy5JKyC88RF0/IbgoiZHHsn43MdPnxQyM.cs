using System.Windows;
using System.Windows.Controls;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.UI.Controls.Toolbar;
using TuAMtrl1Nd3XoZQQUXf0;

namespace iXecOGHHXy5JKyC88RF0;

internal class IbgoiZHHsn43MdPnxQyM : DataTemplateSelector
{
	private readonly ResourceDictionary XnJHHc90WDm;

	private static IbgoiZHHsn43MdPnxQyM nBCFB2Dla5AZR759GCM2;

	public IbgoiZHHsn43MdPnxQyM(ResourceDictionary P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		XnJHHc90WDm = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override DataTemplate SelectTemplate(object P_0, DependencyObject P_1)
	{
		if (!(P_0 is ToolBarItemViewModel toolBarItemViewModel))
		{
			return null;
		}
		object obj = (DataTemplate)XnJHHc90WDm[toolBarItemViewModel.BqIHHgUn8fl()];
		if (obj == null)
		{
			obj = (DataTemplate)((Application)eAf77TDl44eXQvUmB5LO()).Resources[ApN5ogDlDgaEX2CtLakp(toolBarItemViewModel)];
			if (obj == null)
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				obj = (DataTemplate)((ResourceDictionary)aYP51MDlbRw4Yw1pEiWK(Application.Current))[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7ADBF691 ^ 0x7ADAF5CD)];
			}
		}
		return (DataTemplate)obj;
	}

	static IbgoiZHHsn43MdPnxQyM()
	{
		p8PlpfDlNJ3TCTZVk2xi();
	}

	internal static bool HnAxM3Dli7jYyfl2MaXK()
	{
		return nBCFB2Dla5AZR759GCM2 == null;
	}

	internal static IbgoiZHHsn43MdPnxQyM DDoD7DDlljHib0WqBYCC()
	{
		return nBCFB2Dla5AZR759GCM2;
	}

	internal static object eAf77TDl44eXQvUmB5LO()
	{
		return Application.Current;
	}

	internal static object ApN5ogDlDgaEX2CtLakp(object P_0)
	{
		return ((ToolBarItemViewModel)P_0).BqIHHgUn8fl();
	}

	internal static object aYP51MDlbRw4Yw1pEiWK(object P_0)
	{
		return ((Application)P_0).Resources;
	}

	internal static void p8PlpfDlNJ3TCTZVk2xi()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
