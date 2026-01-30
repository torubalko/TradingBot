using System.Runtime.CompilerServices;
using System.Windows.Controls;
using ActiproSoftware.Windows.Controls;
using ECOEgqlSad8NUJZ2Dr9n;
using reuqbSHkyZtO3nPa1eKn;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Controls.Toolbar;

internal class ToolBarItemViewModel : xRgq7gHkTVINiHGAKc0y
{
	[CompilerGenerated]
	private readonly bool Rj4HHIIKKW5;

	[CompilerGenerated]
	private string RP6HHW6CwfU;

	[CompilerGenerated]
	private readonly object U39HHtxRDrY;

	[CompilerGenerated]
	private readonly PopupButtonDisplayMode RUQHHU9eKE8;

	private static ToolBarItemViewModel FGMpOUDlktjii7oHjGiY;

	public bool IsHorizontal => !M5gHHjNt9s8();

	public Orientation Orientation
	{
		get
		{
			if (!M5gHHjNt9s8())
			{
				return Orientation.Horizontal;
			}
			return Orientation.Vertical;
		}
	}

	public object Parent
	{
		[CompilerGenerated]
		get
		{
			return U39HHtxRDrY;
		}
	}

	public ToolBarItemViewModel(object P_0, bool P_1)
	{
		UWuiAuDlSSDtoqO6gi2P();
		base._002Ector();
		U39HHtxRDrY = P_0;
		Rj4HHIIKKW5 = P_1;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				RUQHHU9eKE8 = (P_1 ? PopupButtonDisplayMode.ButtonOnly : PopupButtonDisplayMode.Merged);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public bool M5gHHjNt9s8()
	{
		return Rj4HHIIKKW5;
	}

	[SpecialName]
	[CompilerGenerated]
	public string BqIHHgUn8fl()
	{
		return RP6HHW6CwfU;
	}

	[SpecialName]
	[CompilerGenerated]
	public void uW7HHRN5Ouq(string P_0)
	{
		RP6HHW6CwfU = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public PopupButtonDisplayMode TrxHHOVqQeE()
	{
		return RUQHHU9eKE8;
	}

	static ToolBarItemViewModel()
	{
		k4WV0nDlx3J4gumkXEdD();
	}

	internal static void UWuiAuDlSSDtoqO6gi2P()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool knZUFvDl1LXpACSN4aDi()
	{
		return FGMpOUDlktjii7oHjGiY == null;
	}

	internal static ToolBarItemViewModel RsZat1Dl53hlynF7qvFQ()
	{
		return FGMpOUDlktjii7oHjGiY;
	}

	internal static void k4WV0nDlx3J4gumkXEdD()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
