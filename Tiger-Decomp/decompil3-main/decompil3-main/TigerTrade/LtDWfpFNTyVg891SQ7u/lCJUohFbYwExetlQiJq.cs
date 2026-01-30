using System.Collections;
using ActiproSoftware.Windows.Controls.Grids;
using aoP01sFJf5y8YNhtSvg;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace LtDWfpFNTyVg891SQ7u;

internal class lCJUohFbYwExetlQiJq : TreeListBoxItemAdapter
{
	private static lCJUohFbYwExetlQiJq pqVWmh4LLkNoHZXfjWUt;

	public lCJUohFbYwExetlQiJq()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		z55uV04LX5Gr9GfxHOUn(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -530029649));
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				base.IsEditingPath = (string)o6ytLm4LcS2BBDNELSSd(-1461949456 ^ -1461977030);
				KeBgRk4Ljx85V303AIR6(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-53782092 ^ -53792172));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 1:
				base.IsLoadingPath = (string)o6ytLm4LcS2BBDNELSSd(-962524685 ^ -962502133);
				U6TOVG4LETu86Uj5lhQa(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DEC8FF));
				base.IsSelectedPath = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-962524685 ^ -962501159);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override IEnumerable GetChildren(TreeListBox P_0, object P_1)
	{
		if (P_1 is HHOU6AFPMb0k62giSmc hHOU6AFPMb0k62giSmc)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => hHOU6AFPMb0k62giSmc.Children, 
			};
		}
		return null;
	}

	public override bool GetIsDraggable(TreeListBox P_0, object P_1)
	{
		if (!(P_1 is HHOU6AFPMb0k62giSmc hHOU6AFPMb0k62giSmc))
		{
			return false;
		}
		return hHOU6AFPMb0k62giSmc.IsDraggable;
	}

	public override bool GetIsEditable(TreeListBox P_0, object P_1)
	{
		if (!(P_1 is HHOU6AFPMb0k62giSmc hHOU6AFPMb0k62giSmc))
		{
			return false;
		}
		return hHOU6AFPMb0k62giSmc.IsEditable;
	}

	public override bool GetIsEditing(TreeListBox P_0, object P_1)
	{
		if (P_1 is HHOU6AFPMb0k62giSmc hHOU6AFPMb0k62giSmc)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => hHOU6AFPMb0k62giSmc.IsEditing, 
			};
		}
		return false;
	}

	public override bool GetIsExpanded(TreeListBox P_0, object P_1)
	{
		int num = 1;
		int num2 = num;
		HHOU6AFPMb0k62giSmc hHOU6AFPMb0k62giSmc = default(HHOU6AFPMb0k62giSmc);
		while (true)
		{
			switch (num2)
			{
			default:
				if (hHOU6AFPMb0k62giSmc == null)
				{
					return false;
				}
				return TXwNPi4LQmybhoRJw3s7(hHOU6AFPMb0k62giSmc);
			case 1:
				hHOU6AFPMb0k62giSmc = P_1 as HHOU6AFPMb0k62giSmc;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool GetIsLoading(TreeListBox P_0, object P_1)
	{
		if (!(P_1 is HHOU6AFPMb0k62giSmc hHOU6AFPMb0k62giSmc))
		{
			return false;
		}
		return hHOU6AFPMb0k62giSmc.IsLoading;
	}

	public override bool GetIsSelectable(TreeListBox P_0, object P_1)
	{
		if (!(P_1 is HHOU6AFPMb0k62giSmc hHOU6AFPMb0k62giSmc))
		{
			return true;
		}
		return hHOU6AFPMb0k62giSmc.IsSelectable;
	}

	public override bool GetIsSelected(TreeListBox P_0, object P_1)
	{
		if (!(P_1 is HHOU6AFPMb0k62giSmc hHOU6AFPMb0k62giSmc))
		{
			return false;
		}
		return hHOU6AFPMb0k62giSmc.IsSelected;
	}

	public override string GetPath(TreeListBox P_0, object P_1)
	{
		if (!(P_1 is HHOU6AFPMb0k62giSmc hHOU6AFPMb0k62giSmc))
		{
			return null;
		}
		return hHOU6AFPMb0k62giSmc.Name;
	}

	public override string GetSearchText(TreeListBox P_0, object P_1)
	{
		if (!(P_1 is HHOU6AFPMb0k62giSmc hHOU6AFPMb0k62giSmc))
		{
			return null;
		}
		return (string)kktcjt4LdaJBL9bY7myQ(hHOU6AFPMb0k62giSmc);
	}

	public override void SetIsEditing(TreeListBox P_0, object P_1, bool P_2)
	{
		if (P_1 is HHOU6AFPMb0k62giSmc hHOU6AFPMb0k62giSmc)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			hHOU6AFPMb0k62giSmc.IsEditing = P_2;
		}
	}

	public override void SetIsExpanded(TreeListBox P_0, object P_1, bool P_2)
	{
		if (P_1 is HHOU6AFPMb0k62giSmc hHOU6AFPMb0k62giSmc)
		{
			hHOU6AFPMb0k62giSmc.IsExpanded = P_2;
		}
	}

	public override void SetIsSelected(TreeListBox P_0, object P_1, bool P_2)
	{
		int num = 1;
		int num2 = num;
		HHOU6AFPMb0k62giSmc hHOU6AFPMb0k62giSmc = default(HHOU6AFPMb0k62giSmc);
		while (true)
		{
			switch (num2)
			{
			default:
				if (hHOU6AFPMb0k62giSmc != null)
				{
					hHOU6AFPMb0k62giSmc.IsSelected = P_2;
				}
				return;
			case 1:
				hHOU6AFPMb0k62giSmc = P_1 as HHOU6AFPMb0k62giSmc;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static lCJUohFbYwExetlQiJq()
	{
		INApxT4Lg4ljB54NmpMp();
	}

	internal static void z55uV04LX5Gr9GfxHOUn(object P_0, object P_1)
	{
		((TreeListBoxItemAdapter)P_0).ChildrenPath = (string)P_1;
	}

	internal static object o6ytLm4LcS2BBDNELSSd(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void KeBgRk4Ljx85V303AIR6(object P_0, object P_1)
	{
		((TreeListBoxItemAdapter)P_0).IsExpandedPath = (string)P_1;
	}

	internal static void U6TOVG4LETu86Uj5lhQa(object P_0, object P_1)
	{
		((TreeListBoxItemAdapter)P_0).IsSelectablePath = (string)P_1;
	}

	internal static bool TmAxGY4LevkYFvMmY1D2()
	{
		return pqVWmh4LLkNoHZXfjWUt == null;
	}

	internal static lCJUohFbYwExetlQiJq HtKnVr4LsyBssLooqB4F()
	{
		return pqVWmh4LLkNoHZXfjWUt;
	}

	internal static bool TXwNPi4LQmybhoRJw3s7(object P_0)
	{
		return ((HHOU6AFPMb0k62giSmc)P_0).IsExpanded;
	}

	internal static object kktcjt4LdaJBL9bY7myQ(object P_0)
	{
		return ((HHOU6AFPMb0k62giSmc)P_0).Name;
	}

	internal static void INApxT4Lg4ljB54NmpMp()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
