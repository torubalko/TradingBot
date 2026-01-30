using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;
using System.Windows.Interop;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace hRoKytHllo3Ow1DKENcG;

internal static class XnGRixHliJoPWDlKeqnW
{
	public enum v2GASonUfWgJpowXQ29u
	{

	}

	[Flags]
	public enum mX8ZBynUnlH85I0xdnU1 : uint
	{

	}

	public enum ITTK4JnURkfA0mRF45ys
	{

	}

	[StructLayout(LayoutKind.Sequential)]
	public sealed class sBdnxvnUZbsYgGdnXWly
	{
		public int Bottom;

		public int Left;

		public int Right;

		public int Top;

		private static sBdnxvnUZbsYgGdnXWly vrr4HsNSzh0GB2ZAvbZa;

		public sBdnxvnUZbsYgGdnXWly()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		static sBdnxvnUZbsYgGdnXWly()
		{
			iBLxakNxHjwb4LhIj1YN();
		}

		internal static bool j2mnaMNx0ZkKlSNWGvTZ()
		{
			return vrr4HsNSzh0GB2ZAvbZa == null;
		}

		internal static sBdnxvnUZbsYgGdnXWly ybf2RrNx2ExYmOCKuPqJ()
		{
			return vrr4HsNSzh0GB2ZAvbZa;
		}

		internal static void iBLxakNxHjwb4LhIj1YN()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	public struct NBh0g4nUV1ktlt1gyyfq
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	[StructLayout(LayoutKind.Sequential)]
	public sealed class FnadGCnUCBGV0lvp3AD6
	{
		public int VvinUrCEHuB;

		public NBh0g4nUV1ktlt1gyyfq fydnUKSFbUo;

		public NBh0g4nUV1ktlt1gyyfq ru6nUmEB77A;

		public uint tNEnUhk7pP6;

		private static FnadGCnUCBGV0lvp3AD6 SyoLeeNxGmu6BvuxGDFA;

		public FnadGCnUCBGV0lvp3AD6()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			VvinUrCEHuB = Marshal.SizeOf<FnadGCnUCBGV0lvp3AD6>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static FnadGCnUCBGV0lvp3AD6()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool eGCAAJNxYR1eVCdNn23q()
		{
			return SyoLeeNxGmu6BvuxGDFA == null;
		}

		internal static FnadGCnUCBGV0lvp3AD6 wIFHk2NxoWHgSUWMYnsg()
		{
			return SyoLeeNxGmu6BvuxGDFA;
		}
	}

	public enum Gejy2SnUwIPNrcduOmS2
	{

	}

	public enum oMoY2ynU8OdTg03VryAc
	{

	}

	public delegate bool GLvBcCnUFOHNPsk3XrJS(IntPtr monitor, IntPtr hdc, IntPtr lprcMonitor, IntPtr lParam);

	public static readonly HandleRef G5hHlgFICL2;

	public static readonly IntPtr Md9HlIdTQQ3;

	public static readonly IntPtr oY9HlW1yNxT;

	public static readonly IntPtr Hm6HltEOo1J;

	public static readonly IntPtr PJAHlU5bb8Z;

	private static XnGRixHliJoPWDlKeqnW aNHSFhD1DchWdGKcPZXJ;

	[DllImport("user32.dll", EntryPoint = "GetSystemMetrics")]
	[SecurityCritical]
	public static extern int LYRHl4o5JNG(v2GASonUfWgJpowXQ29u P_0);

	[DllImport("user32.dll", EntryPoint = "EnumDisplayMonitors")]
	public static extern bool GocHlD0skYF(HandleRef P_0, sBdnxvnUZbsYgGdnXWly P_1, GLvBcCnUFOHNPsk3XrJS P_2, IntPtr P_3);

	[DllImport("user32.dll", EntryPoint = "GetMonitorInfo", SetLastError = true)]
	[SecurityCritical]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool z5iHlb3f1Hm(IntPtr P_0, [In][Out] FnadGCnUCBGV0lvp3AD6 P_1);

	[SecurityCritical]
	public static FnadGCnUCBGV0lvp3AD6 kWJHlNXkrH2(IntPtr P_0)
	{
		FnadGCnUCBGV0lvp3AD6 fnadGCnUCBGV0lvp3AD = new FnadGCnUCBGV0lvp3AD6();
		if (!z5iHlb3f1Hm(P_0, fnadGCnUCBGV0lvp3AD))
		{
			throw new Win32Exception();
		}
		return fnadGCnUCBGV0lvp3AD;
	}

	[DllImport("gdi32.dll", CharSet = CharSet.Auto, EntryPoint = "GetDeviceCaps", SetLastError = true)]
	[SecurityCritical]
	[SuppressUnmanagedCodeSecurity]
	public static extern int MaNHlkSQmyG(HandleRef P_0, int P_1);

	[DllImport("shcore.dll", EntryPoint = "GetDpiForMonitor")]
	public static extern IntPtr T4FHl14E8jj([In] IntPtr P_0, [In] Gejy2SnUwIPNrcduOmS2 P_1, out uint P_2, out uint P_3);

	[DllImport("shcore.dll", EntryPoint = "GetProcessDpiAwareness")]
	public static extern int kPTHl5cGulm([In] IntPtr P_0, out oMoY2ynU8OdTg03VryAc P_1);

	[DllImport("user32.dll", EntryPoint = "GetDC")]
	public static extern IntPtr BWcHlSsWugh(IntPtr P_0);

	[DllImport("user32.dll", EntryPoint = "ReleaseDC")]
	public static extern int K81HlxeRmWc(IntPtr P_0, IntPtr P_1);

	[DllImport("user32.dll", EntryPoint = "MonitorFromWindow")]
	public static extern IntPtr HQOHlLOjndl(IntPtr P_0, int P_1);

	[DllImport("user32.dll", EntryPoint = "SetWindowPos")]
	public static extern IntPtr n7RHleXdO9O(IntPtr P_0, IntPtr P_1, int P_2, int P_3, int P_4, int P_5, uint P_6);

	[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
	public static extern long kraHlsFL11e(IntPtr P_0, int P_1);

	[DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
	public static extern long XsSHlXRk6Lm(IntPtr P_0, int P_1, long P_2);

	[DllImport("user32.dll", EntryPoint = "GetWindowRect")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool uEpHlcSSnAa(IntPtr P_0, out NBh0g4nUV1ktlt1gyyfq P_1);

	public static Rect oasHlj5a4Fw(Window P_0)
	{
		IntPtr handle = new WindowInteropHelper(P_0).Handle;
		if (!(handle == IntPtr.Zero))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
			{
				if (uEpHlcSSnAa(handle, out var nBh0g4nUV1ktlt1gyyfq))
				{
					return new Rect(nBh0g4nUV1ktlt1gyyfq.Left, nBh0g4nUV1ktlt1gyyfq.Top, nBh0g4nUV1ktlt1gyyfq.Right - nBh0g4nUV1ktlt1gyyfq.Left, nBh0g4nUV1ktlt1gyyfq.Bottom - nBh0g4nUV1ktlt1gyyfq.Top);
				}
				return Rect.Empty;
			}
			}
		}
		return Rect.Empty;
	}

	static XnGRixHliJoPWDlKeqnW()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		G5hHlgFICL2 = new HandleRef(null, IntPtr.Zero);
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
			{
				Hm6HltEOo1J = new IntPtr(0);
				int num2 = 2;
				num = num2;
				break;
			}
			case 2:
				PJAHlU5bb8Z = new IntPtr(1);
				return;
			case 1:
				Md9HlIdTQQ3 = new IntPtr(-1);
				oY9HlW1yNxT = new IntPtr(-2);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static bool OqAQCaD1bBDlKNbbOXwA()
	{
		return aNHSFhD1DchWdGKcPZXJ == null;
	}

	internal static XnGRixHliJoPWDlKeqnW sQXrCnD1NfvXJbDs7SeU()
	{
		return aNHSFhD1DchWdGKcPZXJ;
	}
}
