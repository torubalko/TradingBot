using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using n0pHVoH9Rok0LZdfPCeU;
using OEo2UkH9XCLtdQn4ngDm;
using reuqbSHkyZtO3nPa1eKn;
using TigerTrade.UI.Controls.Toolbar;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TnsUjXHHy7KFZTRRNgfB;

internal class La0ca4HHTc6Pirgseila : xRgq7gHkTVINiHGAKc0y
{
	private readonly xRgq7gHkTVINiHGAKc0y J5XHHmwnfsS;

	private readonly bool wN4HHh4cFNb;

	private ObservableCollection<ToolBarItemViewModel> QjHHHwpdquJ;

	private static La0ca4HHTc6Pirgseila NQiCEHDlLrGeUTnbIi3w;

	public ObservableCollection<ToolBarItemViewModel> Items => QjHHHwpdquJ;

	public La0ca4HHTc6Pirgseila(xRgq7gHkTVINiHGAKc0y P_0, bool P_1)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				J5XHHmwnfsS = P_0;
				wN4HHh4cFNb = P_1;
				return;
			}
			QjHHHwpdquJ = new ObservableCollection<ToolBarItemViewModel>();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
			{
				num = 1;
			}
		}
	}

	[SpecialName]
	public xRgq7gHkTVINiHGAKc0y Rs6HHr6ZFt1()
	{
		return J5XHHmwnfsS;
	}

	public void nRWHHZLWQ5h(string P_0)
	{
		if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x385FFAB ^ 0x384FC2B))
		{
			ObservableCollection<ToolBarItemViewModel> qjHHHwpdquJ = QjHHHwpdquJ;
			ToolBarItemViewModel toolBarItemViewModel = new ToolBarItemViewModel(J5XHHmwnfsS, wN4HHh4cFNb);
			toolBarItemViewModel.uW7HHRN5Ouq(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x315BB275));
			qjHHHwpdquJ.Add(toolBarItemViewModel);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			ObservableCollection<ToolBarItemViewModel> qjHHHwpdquJ2 = QjHHHwpdquJ;
			ToolBarItemViewModel toolBarItemViewModel2 = new ToolBarItemViewModel(J5XHHmwnfsS, wN4HHh4cFNb);
			toolBarItemViewModel2.uW7HHRN5Ouq((string)f3kQnsDlXCq539lDyrhx(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x9F0F634 ^ 0x9F1F5F6), P_0));
			qjHHHwpdquJ2.Add(toolBarItemViewModel2);
		}
	}

	public void jHZHHVwL8Qy(mAHhmOH9gHTWcA6hYgFE P_0, XToolbarPosition P_1)
	{
		QjHHHwpdquJ.Add(new jsMnb6H9sfObcuUSFkih(J5XHHmwnfsS, wN4HHh4cFNb, P_0, P_1));
	}

	static La0ca4HHTc6Pirgseila()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool zCRmomDlejC6cLR0gMFR()
	{
		return NQiCEHDlLrGeUTnbIi3w == null;
	}

	internal static La0ca4HHTc6Pirgseila f9wbRbDlspRKftOqIRpJ()
	{
		return NQiCEHDlLrGeUTnbIi3w;
	}

	internal static object f3kQnsDlXCq539lDyrhx(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
