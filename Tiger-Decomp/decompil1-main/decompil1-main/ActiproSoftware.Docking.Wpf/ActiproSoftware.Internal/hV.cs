using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls;

namespace ActiproSoftware.Internal;

internal static class hV
{
	internal delegate IntPtr qt(int nCode, IntPtr wParam, IntPtr lParam);

	public class V2
	{
		private qt hR0;

		private IntPtr ORh;

		private int[] zRg;

		private Action<Key> SRX;

		private Action<Key> mR5;

		private static V2 AKt;

		public V2(Action<Key> P_0, Action<Key> P_1, params Key[] keysToWatch)
		{
			IVH.CecNqz();
			ORh = IntPtr.Zero;
			base._002Ector();
			if (P_0 == null)
			{
				throw new ArgumentNullException(vVK.ssH(28050));
			}
			if (P_1 == null)
			{
				throw new ArgumentNullException(vVK.ssH(28092));
			}
			if (keysToWatch == null)
			{
				throw new ArgumentNullException(vVK.ssH(28130));
			}
			SRX = P_0;
			mR5 = P_1;
			zRg = keysToWatch.Select((Key k) => KeyInterop.VirtualKeyFromKey(k)).ToArray();
			hR0 = TRb;
		}

		private IntPtr iRZ()
		{
			using Process process = Process.GetCurrentProcess();
			using ProcessModule processModule = process.MainModule;
			IntPtr intPtr = pE(processModule.ModuleName);
			return X6(13, hR0, intPtr, 0u);
		}

		private IntPtr TRb(int P_0, IntPtr P_1, IntPtr P_2)
		{
			if (P_0 >= 0)
			{
				switch (P_1.ToInt32())
				{
				case 256:
				{
					int num2 = Marshal.ReadInt32(P_2);
					if (Array.IndexOf(zRg, num2) != -1)
					{
						SRX(KeyInterop.KeyFromVirtualKey(num2));
						return IntPtr.Zero;
					}
					break;
				}
				case 257:
				{
					int num = Marshal.ReadInt32(P_2);
					if (Array.IndexOf(zRg, num) != -1)
					{
						mR5(KeyInterop.KeyFromVirtualKey(num));
						return IntPtr.Zero;
					}
					break;
				}
				}
			}
			return yO(ORh, P_0, P_1, P_2);
		}

		public void qRA()
		{
			ORh = iRZ();
		}

		public void RRH()
		{
			if (ORh != IntPtr.Zero)
			{
				i9(ORh);
				ORh = IntPtr.Zero;
			}
		}

		internal static bool GKp()
		{
			return AKt == null;
		}

		internal static V2 MK4()
		{
			return AKt;
		}
	}

	[StructLayout(LayoutKind.Sequential)]
	private class yz
	{
		public int kRy;

		public UVV tRo;

		public UVV ARt;

		public int pRu;

		private static yz JK2;

		public yz()
		{
			IVH.CecNqz();
			kRy = Marshal.SizeOf(typeof(yz));
			base._002Ector();
		}

		internal static bool tK6()
		{
			return JK2 == null;
		}

		internal static yz GKW()
		{
			return JK2;
		}
	}

	private struct LVS
	{
		public int gRz;

		public int DSi;
	}

	internal struct UVV
	{
		public int qSw;

		public int QS2;

		public int tSe;

		public int eSG;

		private static object uKs;

		public UVV(Rect P_0)
		{
			IVH.CecNqz();
			eSG = (int)Math.Ceiling(P_0.Bottom);
			qSw = (int)Math.Ceiling(P_0.Left);
			tSe = (int)Math.Ceiling(P_0.Right);
			QS2 = (int)Math.Ceiling(P_0.Top);
		}

		public Rect DSd()
		{
			return new Rect(qSw, QS2, tSe - qSw, eSG - QS2);
		}

		internal static bool bKQ()
		{
			return uKs == null;
		}

		internal static object LKv()
		{
			return uKs;
		}
	}

	private static bool? TP;

	private static bool? Uf;

	private static hV jG;

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public static bool Bp
	{
		get
		{
			if (!TP.HasValue)
			{
				TP = false;
				if (BF())
				{
					try
					{
						if (qx(IntPtr.Zero, out var num) == 0)
						{
							TP = num == 2;
						}
					}
					catch
					{
					}
				}
			}
			return TP.Value;
		}
	}

	private static Point jd(IntPtr P_0)
	{
		return new Point(K2(P_0.ToInt64()), Hw(P_0.ToInt64()));
	}

	private static short Hw(long P_0)
	{
		return (short)((P_0 >> 16) & 0xFFFF);
	}

	private static short K2(long P_0)
	{
		return (short)(P_0 & 0xFFFF);
	}

	private static IEnumerable<Window> te(IEnumerable<Window> P_0)
	{
		Dictionary<IntPtr, Window> windowsDictionary = new Dictionary<IntPtr, Window>();
		foreach (Window item in P_0)
		{
			if (item != null)
			{
				IntPtr handle = new WindowInteropHelper(item).Handle;
				if (handle != IntPtr.Zero)
				{
					windowsDictionary[handle] = item;
				}
			}
		}
		IntPtr hWnd = WM(IntPtr.Zero);
		while (hWnd != IntPtr.Zero)
		{
			if (windowsDictionary.ContainsKey(hWnd))
			{
				yield return windowsDictionary[hWnd];
			}
			hWnd = Gv(hWnd, 2u);
		}
	}

	public static bool IG(Window P_0)
	{
		bool result = false;
		bool flag = cs();
		if (P_0 != null && flag)
		{
			result = iL(new WindowInteropHelper(P_0).Handle, 161, new IntPtr(2), new IntPtr(XD())) == IntPtr.Zero;
		}
		return result;
	}

	public static Rect mI(Rect P_0, double P_1)
	{
		Point point = mC(null);
		P_0.X *= Math.Max(0.01, point.X);
		P_0.Y *= Math.Max(0.01, point.Y);
		int num = 0;
		if (SM() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
		{
			UVV uVV = new UVV(P_0);
			IntPtr intPtr = GR(ref uVV, 2);
			if (intPtr != IntPtr.Zero)
			{
				yz yz = new yz();
				if (cr(intPtr, yz))
				{
					Rect rect = yz.ARt.DSd();
					P_0 = xN.XlL(P_0, rect, P_1);
				}
			}
			P_0.X /= Math.Max(0.01, point.X);
			P_0.Y /= Math.Max(0.01, point.Y);
			return P_0;
		}
		}
	}

	public static Point Sk()
	{
		Dn(out var lVS);
		return new Point(lVS.gRz, lVS.DSi);
	}

	[SuppressMessage("Microsoft.Security", "CA2122:DoNotIndirectlyExposeMethodsWithLinkDemands")]
	public static Point mC(Window P_0)
	{
		if (P_0 == null && Application.Current != null)
		{
			int num = 0;
			if (!sc())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (Application.Current.Dispatcher.Thread == Thread.CurrentThread)
			{
				P_0 = Application.Current.MainWindow;
			}
		}
		if (P_0 != null)
		{
			IntPtr handle = new WindowInteropHelper(P_0).Handle;
			if (handle != IntPtr.Zero)
			{
				HwndSource hwndSource = HwndSource.FromHwnd(handle);
				if (hwndSource != null && hwndSource.CompositionTarget != null)
				{
					Matrix transformToDevice = hwndSource.CompositionTarget.TransformToDevice;
					return new Point(transformToDevice.M11, transformToDevice.M22);
				}
			}
		}
		return new Point(1.0, 1.0);
	}

	public static Point s1(Rect P_0)
	{
		if (BF())
		{
			UVV uVV = new UVV(P_0);
			IntPtr intPtr = GR(ref uVV, 2);
			if (intPtr != IntPtr.Zero && zT(intPtr, 0, out var num, out var _) == 0 && (double)num > 96.0)
			{
				return new Point((double)num / 96.0, (double)num / 96.0);
			}
		}
		return new Point(1.0, 1.0);
	}

	public static Point iN()
	{
		return jd(new IntPtr(XD()));
	}

	public static Window NQ(IEnumerable<Window> P_0, Point P_1)
	{
		if (P_0 != null)
		{
			P_0 = te(P_0);
			foreach (Window item in P_0)
			{
				if (item != null && sm(item).Contains(P_1))
				{
					return item;
				}
			}
		}
		return null;
	}

	public static Rect sm(Window P_0)
	{
		if (P_0 == null)
		{
			return default(Rect);
		}
		R7(new WindowInteropHelper(P_0).Handle, out var uVV);
		return uVV.DSd();
	}

	public static ResizeOperation? La(IntPtr P_0)
	{
		return P_0.ToInt32() switch
		{
			4 => ResizeOperation.NorthWest, 
			3 => ResizeOperation.North, 
			5 => ResizeOperation.NorthEast, 
			2 => ResizeOperation.East, 
			8 => ResizeOperation.SouthEast, 
			6 => ResizeOperation.South, 
			7 => ResizeOperation.SouthWest, 
			1 => ResizeOperation.West, 
			_ => null, 
		};
	}

	public static bool TW()
	{
		return rl(80) <= 1;
	}

	[SpecialName]
	public static bool cs()
	{
		return l8(1) < 0;
	}

	[SpecialName]
	public static bool BF()
	{
		if (!Uf.HasValue)
		{
			Uf = Environment.OSVersion.Version.Major > 6 || (Environment.OSVersion.Version.Major == 6 && Environment.OSVersion.Version.Minor >= 3);
		}
		return Uf.Value;
	}

	public static void sB(Window P_0, Window P_1)
	{
		if (P_0 != null && P_1 != null)
		{
			IntPtr handle = new WindowInteropHelper(P_0).Handle;
			IntPtr handle2 = new WindowInteropHelper(P_1).Handle;
			H3(handle, handle2, 0, 0, 0, 0, 1051);
		}
	}

	public static void nK(IntPtr P_0, double P_1, double P_2)
	{
		zS(P_0, (int)P_1, (int)P_2);
	}

	public static Point JJ(Control P_0, Point P_1)
	{
		if (P_0 != null)
		{
			P_1 = P_0.PointToScreen(P_1);
			Window window = Window.GetWindow(P_0);
			if (window != null)
			{
				Point point = mC(window);
				P_1 = new Point(P_1.X * ((point.X > 0.0) ? (1.0 / point.X) : 1.0), P_1.Y * ((point.Y > 0.0) ? (1.0 / point.Y) : 1.0));
			}
		}
		return P_1;
	}

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetCursorPos")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool Dn(out LVS P_0);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "CallNextHookEx", SetLastError = true)]
	private static extern IntPtr yO(IntPtr P_0, int P_1, IntPtr P_2, IntPtr P_3);

	[DllImport("Shcore.dll", CharSet = CharSet.Auto, EntryPoint = "GetDpiForMonitor")]
	private static extern int zT(IntPtr P_0, int P_1, out uint P_2, out uint P_3);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetKeyState")]
	private static extern short l8(int P_0);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetMessagePos")]
	private static extern int XD();

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GetModuleHandle", SetLastError = true)]
	private static extern IntPtr pE([MarshalAs(UnmanagedType.LPWStr)] string P_0);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetMonitorInfo")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool cr(IntPtr P_0, yz P_1);

	[DllImport("Shcore.dll", CharSet = CharSet.Auto, EntryPoint = "GetProcessDpiAwareness")]
	private static extern int qx(IntPtr P_0, out int P_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetSystemMetrics")]
	public static extern int rl(int P_0);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetTopWindow")]
	private static extern IntPtr WM(IntPtr P_0);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWindow")]
	private static extern IntPtr Gv(IntPtr P_0, uint P_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWindowRect")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool R7(IntPtr P_0, out UVV P_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "MonitorFromRect")]
	private static extern IntPtr GR(ref UVV P_0, int P_1);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "OffsetRect")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool zS(IntPtr P_0, int P_1, int P_2);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
	private static extern IntPtr iL(IntPtr P_0, int P_1, IntPtr P_2, IntPtr P_3);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowPos")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool H3(IntPtr P_0, IntPtr P_1, int P_2, int P_3, int P_4, int P_5, int P_6);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowsHookEx", SetLastError = true)]
	private static extern IntPtr X6(int P_0, qt P_1, IntPtr P_2, uint P_3);

	[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "UnhookWindowsHookEx", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool i9(IntPtr P_0);

	internal static bool sc()
	{
		return jG == null;
	}

	internal static hV SM()
	{
		return jG;
	}
}
