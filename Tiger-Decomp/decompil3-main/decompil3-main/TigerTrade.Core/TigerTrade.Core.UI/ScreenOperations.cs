using System.Windows;
using EDugZvNwF6e5LYsQZ3C5;
using nff6NvN8pYC4xeKDOd05;

namespace TigerTrade.Core.UI;

public static class ScreenOperations
{
	private static ScreenOperations M68doRk9fZpNIaUUyDgl;

	public static void WindowCorrect(Window window)
	{
		if (window.Top < SystemParameters.VirtualScreenTop)
		{
			window.Top = KCDqwFk9GGZum0kXeXWe();
		}
		if (window.Left < SystemParameters.VirtualScreenLeft)
		{
			window.Left = SystemParameters.VirtualScreenLeft;
			int num = 0;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_24b0446a14894cbb8d00600e568b3f06 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	static ScreenOperations()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static double KCDqwFk9GGZum0kXeXWe()
	{
		return SystemParameters.VirtualScreenTop;
	}

	internal static bool cFE9j4k99BgZlOrBQ8x5()
	{
		return M68doRk9fZpNIaUUyDgl == null;
	}

	internal static ScreenOperations ekAHCyk9nOwpmNZd2HQV()
	{
		return M68doRk9fZpNIaUUyDgl;
	}
}
