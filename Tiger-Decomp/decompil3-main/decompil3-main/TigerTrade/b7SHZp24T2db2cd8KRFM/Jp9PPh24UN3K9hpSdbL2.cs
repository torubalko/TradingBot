using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using ActiproSoftware.Windows.Controls.Docking;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;
using uZqyk925mKGgabaJGJq6;

namespace b7SHZp24T2db2cd8KRFM;

public class Jp9PPh24UN3K9hpSdbL2
{
	[Serializable]
	[CompilerGenerated]
	private sealed class EfBqTlngsC62tk4kJEDv
	{
		public static readonly EfBqTlngsC62tk4kJEDv GTgngcfAXVo;

		public static Func<MenuItem, string> WCOngjtryP6;

		private static EfBqTlngsC62tk4kJEDv mlKS7uN4pgbKGiFTfSjp;

		static EfBqTlngsC62tk4kJEDv()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
					GTgngcfAXVo = new EfBqTlngsC62tk4kJEDv();
					return;
				}
			}
		}

		public EfBqTlngsC62tk4kJEDv()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal string htYngXdwBQw(MenuItem s)
		{
			return s.Name;
		}

		internal static bool bWgbcwN4uBqxpt7AdYB8()
		{
			return mlKS7uN4pgbKGiFTfSjp == null;
		}

		internal static EfBqTlngsC62tk4kJEDv MTElbxN4zvjG58lo6frD()
		{
			return mlKS7uN4pgbKGiFTfSjp;
		}
	}

	[CompilerGenerated]
	private sealed class m9Kq09ngEUN9Dti24157
	{
		public ContextMenu zV2ngdid5Ow;

		public UIElement ytpnggCmkwl;

		private static m9Kq09ngEUN9Dti24157 bCldftND0t9ySn0lfqH1;

		public m9Kq09ngEUN9Dti24157()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void y4ZngQRtZpa(object sender, RoutedEventArgs e)
		{
			// Found self-referencing delegate construction. Abort transformation to avoid stack overflow.
			YTiArwNDfNeoYF2E9kCI(zV2ngdid5Ow, new RoutedEventHandler(y4ZngQRtZpa));
			zV2ngdid5Ow.PlacementTarget = ytpnggCmkwl;
			zV2ngdid5Ow.Placement = PlacementMode.Bottom;
			zV2ngdid5Ow.HorizontalOffset = 1.0;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static m9Kq09ngEUN9Dti24157()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool Ix0gN8ND2XnastnjRhCT()
		{
			return bCldftND0t9ySn0lfqH1 == null;
		}

		internal static m9Kq09ngEUN9Dti24157 orMUdPNDHaeki44YyNpk()
		{
			return bCldftND0t9ySn0lfqH1;
		}

		internal static void YTiArwNDfNeoYF2E9kCI(object P_0, object P_1)
		{
			((ContextMenu)P_0).Opened -= (RoutedEventHandler)P_1;
		}
	}

	private readonly DockingWindow OXj248cEBWH;

	private readonly Style lsR24A8ACWL;

	private readonly z6kMSs25KYyGVf55FxBT mQb24PpH66y;

	private readonly Dictionary<string, MenuItem> ckt24JZ19P4;

	private readonly List<object> h1d24FgNuVc;

	internal static Jp9PPh24UN3K9hpSdbL2 aUs3CR4tB7FOAjpsSw3v;

	public Jp9PPh24UN3K9hpSdbL2(IEnumerable<MenuItem> P_0, DockingWindow P_1, Style P_2)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		h1d24FgNuVc = new List<object>();
		base._002Ector();
		OXj248cEBWH = P_1;
		lsR24A8ACWL = P_2;
		mQb24PpH66y = OXj248cEBWH.Content as z6kMSs25KYyGVf55FxBT;
		ckt24JZ19P4 = P_0.ToDictionary((MenuItem s) => s.Name);
	}

	public void Bv924yNjxlN(string P_0)
	{
		int num = 2;
		int num2 = num;
		MenuItem value = default(MenuItem);
		MenuItem menuItem = default(MenuItem);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!ckt24JZ19P4.TryGetValue(P_0, out value))
				{
					menuItem = g9i24rtv2ft(P_0);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
					{
						num2 = 0;
					}
				}
				break;
			default:
				if (menuItem != null)
				{
					h1d24FgNuVc.Add(menuItem);
				}
				return;
			case 3:
				h1d24FgNuVc.Add(value);
				return;
			case 1:
				if (!((ICommand)f9HK464tlJJfimKtlMGP(value)).CanExecute((object)null))
				{
					return;
				}
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public void F1124ZUrmJR(string P_0, ICommand P_1)
	{
		h1d24FgNuVc.Add(new MenuItem
		{
			Header = P_0,
			Command = P_1
		});
	}

	public void bG324VmHG0s(string P_0, Action<object> P_1)
	{
		h1d24FgNuVc.Add(new MenuItem
		{
			Header = P_0,
			Command = new RelayCommand(P_1)
		});
	}

	public void Fc724CfkdG8()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (!(h1d24FgNuVc.Last() is Separator))
				{
					h1d24FgNuVc.Add(new Separator());
				}
				return;
			case 1:
				if (RomhIk4t4sxHrRFTvu3i(h1d24FgNuVc) == 0)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private MenuItem g9i24rtv2ft(string P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (mQb24PpH66y == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
					{
						num2 = 1;
					}
					continue;
				}
				if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-5977659 ^ -5979535))
				{
					return yjB24KB3hOo((string)NPdEp04tD9i1gdfJfJPL(), delegate
					{
						RRsBNt4tkgsRIJ97rw5J(mQb24PpH66y);
					});
				}
				goto default;
			case 1:
				break;
			default:
				if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -123773891))
				{
					return yjB24KB3hOo((string)XuW1Tr4tbwJqOQwbxPmy(), delegate
					{
						uIreD94t1SvHCcq1djub(mQb24PpH66y);
					});
				}
				break;
			}
			break;
		}
		return null;
	}

	private MenuItem yjB24KB3hOo(string P_0, Action<object> P_1)
	{
		return new MenuItem
		{
			Header = P_0,
			Command = new RelayCommand(P_1)
		};
	}

	public ContextMenu RHQ24mkuxAW(UIElement P_0 = null)
	{
		int num = 2;
		int num2 = num;
		List<object>.Enumerator enumerator = default(List<object>.Enumerator);
		ContextMenu contextMenu = default(ContextMenu);
		while (true)
		{
			switch (num2)
			{
			case 3:
				enumerator = h1d24FgNuVc.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				zf1gj44tNXtr9PSCCdjR(contextMenu, lsR24A8ACWL);
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				contextMenu = new ContextMenu();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					object current = enumerator.Current;
					contextMenu.Items.Add(current);
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					}
				}
			}
			finally
			{
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
			}
			if (P_0 != null)
			{
				EiK24h1vni1(P_0, contextMenu);
			}
			return contextMenu;
		}
	}

	private void EiK24h1vni1(UIElement P_0, ContextMenu P_1)
	{
		int num = 1;
		int num2 = num;
		m9Kq09ngEUN9Dti24157 m9Kq09ngEUN9Dti = default(m9Kq09ngEUN9Dti24157);
		while (true)
		{
			switch (num2)
			{
			case 1:
				m9Kq09ngEUN9Dti = new m9Kq09ngEUN9Dti24157();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				m9Kq09ngEUN9Dti.zV2ngdid5Ow = P_1;
				m9Kq09ngEUN9Dti.ytpnggCmkwl = P_0;
				m9Kq09ngEUN9Dti.zV2ngdid5Ow.Opened += m9Kq09ngEUN9Dti.y4ZngQRtZpa;
				return;
			}
		}
	}

	[CompilerGenerated]
	private void o4D24w6oUBT(object P_0)
	{
		RRsBNt4tkgsRIJ97rw5J(mQb24PpH66y);
	}

	[CompilerGenerated]
	private void kqZ247S3o6n(object P_0)
	{
		uIreD94t1SvHCcq1djub(mQb24PpH66y);
	}

	static Jp9PPh24UN3K9hpSdbL2()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object f9HK464tlJJfimKtlMGP(object P_0)
	{
		return ((MenuItem)P_0).Command;
	}

	internal static bool Y0i3TT4ta25upQJKtkOK()
	{
		return aUs3CR4tB7FOAjpsSw3v == null;
	}

	internal static Jp9PPh24UN3K9hpSdbL2 WvlTjf4tios4Wdu0tpKg()
	{
		return aUs3CR4tB7FOAjpsSw3v;
	}

	internal static int RomhIk4t4sxHrRFTvu3i(object P_0)
	{
		return ((List<object>)P_0).Count;
	}

	internal static object NPdEp04tD9i1gdfJfJPL()
	{
		return Resources.MainWindowRenameTab;
	}

	internal static object XuW1Tr4tbwJqOQwbxPmy()
	{
		return Resources.MainWindowCloneTab;
	}

	internal static void zf1gj44tNXtr9PSCCdjR(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Style = (Style)P_1;
	}

	internal static void RRsBNt4tkgsRIJ97rw5J(object P_0)
	{
		((z6kMSs25KYyGVf55FxBT)P_0).gkn2SaenV1l();
	}

	internal static void uIreD94t1SvHCcq1djub(object P_0)
	{
		((z6kMSs25KYyGVf55FxBT)P_0).xAs2SB8odxC();
	}
}
