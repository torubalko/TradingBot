using System;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;

namespace TigerTrade.Dx;

public class DxHwndHostBase : HwndHost
{
	internal struct NrImmbGBcV6MwVUJWthQ
	{
		public IntPtr DeXGBj96Q84;

		public bool FGhGBEmoq0c;

		public tJZk77GB6jIJkbjxD8e0 z4FGBQt4nMN;

		public bool SIQGBd7YV4o;

		public bool eHLGBgCH89W;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public byte[] OfFGBRg88j9;
	}

	internal struct tJZk77GB6jIJkbjxD8e0
	{
		public int Db1GBMoOK8H;

		public int GLGGBO7qfjX;

		public int mPyGBqN2dWH;

		public int iUaGBIYFchN;
	}

	private IntPtr _hwndHost;

	internal static DxHwndHostBase jRFGMckjJXkiSUQB0aIS;

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	internal static extern IntPtr CreateWindowEx(int dwExStyle, string lpszClassName, string lpszWindowName, int style, int x, int y, int width, int height, IntPtr hwndParent, IntPtr hMenu, IntPtr hInst, [MarshalAs(UnmanagedType.AsAny)] object pvParam);

	[DllImport("user32.dll", CharSet = CharSet.Unicode)]
	internal static extern bool DestroyWindow(IntPtr hwnd);

	protected override HandleRef BuildWindowCore(HandleRef hwndParent)
	{
		_hwndHost = CreateWindowEx(0, vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x3E0426F0 ^ 0x3E0421F8), "", 1409286144, 0, 0, 100, 100, hwndParent.Handle, (IntPtr)2, IntPtr.Zero, 0);
		return new HandleRef(this, _hwndHost);
	}

	protected override void DestroyWindowCore(HandleRef hwnd)
	{
		DestroyWindow(hwnd.Handle);
	}

	[DllImport("user32.dll")]
	internal static extern IntPtr BeginPaint(IntPtr hwnd, out NrImmbGBcV6MwVUJWthQ lpPaint);

	[DllImport("user32.dll")]
	internal static extern bool EndPaint(IntPtr hWnd, [In] ref NrImmbGBcV6MwVUJWthQ lpPaint);

	protected override IntPtr WndProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
	{
		int num;
		if (msg != 15)
		{
			if (msg != 20)
			{
				handled = false;
				return IntPtr.Zero;
			}
			num = 2;
		}
		else
		{
			NrImmbGBcV6MwVUJWthQ lpPaint = default(NrImmbGBcV6MwVUJWthQ);
			BeginPaint(_hwndHost, out lpPaint);
			EndPaint(_hwndHost, ref lpPaint);
			int num2 = 3;
			num = num2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return new IntPtr(1);
			case 3:
				Adgj5SkjpbqYROMRbTy5(this);
				num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_3373f89df52c4ee49b0e1056b7a5f0be != 0)
				{
					num = 1;
				}
				break;
			case 1:
				handled = true;
				return IntPtr.Zero;
			case 2:
				handled = true;
				num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_6d5d3c8cbc2d408ab6adb1ecc4804915 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected virtual void OnPaintBackground()
	{
	}

	public DxHwndHostBase()
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		base._002Ector();
	}

	static DxHwndHostBase()
	{
		M0VyjxkjuHQWcnvwVr4e();
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool Dr2KmckjFQD0Q09goLID()
	{
		return jRFGMckjJXkiSUQB0aIS == null;
	}

	internal static DxHwndHostBase N2GiGvkj3yfNeMqNffrv()
	{
		return jRFGMckjJXkiSUQB0aIS;
	}

	internal static void Adgj5SkjpbqYROMRbTy5(object P_0)
	{
		((DxHwndHostBase)P_0).OnPaintBackground();
	}

	internal static void M0VyjxkjuHQWcnvwVr4e()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
	}
}
