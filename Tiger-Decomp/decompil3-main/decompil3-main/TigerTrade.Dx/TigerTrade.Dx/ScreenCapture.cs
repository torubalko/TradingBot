using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;

namespace TigerTrade.Dx;

public static class ScreenCapture
{
	private class NubOUAGBWMLFhGw8hBa6
	{
		private static NubOUAGBWMLFhGw8hBa6 kElK49kddUk2wKHDDyFR;

		[DllImport("gdi32.dll", EntryPoint = "BitBlt")]
		public static extern bool cxfGBt4L3IT(IntPtr P_0, int P_1, int P_2, int P_3, int P_4, IntPtr P_5, int P_6, int P_7, int P_8);

		[DllImport("gdi32.dll", EntryPoint = "CreateCompatibleBitmap")]
		public static extern IntPtr i3DGBUAg5u9(IntPtr P_0, int P_1, int P_2);

		[DllImport("gdi32.dll", EntryPoint = "CreateCompatibleDC")]
		public static extern IntPtr vgAGBTvduQO(IntPtr P_0);

		[DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
		public static extern bool N0wGByphDem(IntPtr P_0);

		[DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
		public static extern bool yJEGBZGSBuE(IntPtr P_0);

		[DllImport("gdi32.dll", EntryPoint = "SelectObject")]
		public static extern IntPtr XpfGBVK4eZU(IntPtr P_0, IntPtr P_1);

		public NubOUAGBWMLFhGw8hBa6()
		{
			qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
			base._002Ector();
		}

		static NubOUAGBWMLFhGw8hBa6()
		{
			vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
			l86oiQkd6BnYkd2B8rnk();
		}

		internal static bool GwY9bykdghfPXjgZIvwI()
		{
			return kElK49kddUk2wKHDDyFR == null;
		}

		internal static NubOUAGBWMLFhGw8hBa6 DKH5fdkdRdeQoTN9vUTM()
		{
			return kElK49kddUk2wKHDDyFR;
		}

		internal static void l86oiQkd6BnYkd2B8rnk()
		{
			P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	private class A4oDTgGBrfl1xwjBTtTe
	{
		public struct tLc7XNGBFMknGdJFJsGC
		{
			public int HrrGB3xObRn;

			public int jfwGBpHKgEB;

			public int YNSGBupfWrE;

			public int QTJGBzNfb89;
		}

		internal static A4oDTgGBrfl1xwjBTtTe DAiQm3kdMiJLVMQEn9FE;

		[DllImport("user32.dll", EntryPoint = "GetWindowDC")]
		public static extern IntPtr YKGGBKdOAcD(IntPtr P_0);

		[DllImport("user32.dll", EntryPoint = "ReleaseDC")]
		public static extern IntPtr AUhGBmlP7xr(IntPtr P_0, IntPtr P_1);

		[DllImport("user32.dll", EntryPoint = "GetWindowRect")]
		public static extern IntPtr jH1GBhYUHik(IntPtr P_0, ref tLc7XNGBFMknGdJFJsGC P_1);

		public A4oDTgGBrfl1xwjBTtTe()
		{
			qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
			base._002Ector();
		}

		static A4oDTgGBrfl1xwjBTtTe()
		{
			vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
			P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool w3YSNqkdOdINjbJTvb6l()
		{
			return DAiQm3kdMiJLVMQEn9FE == null;
		}

		internal static A4oDTgGBrfl1xwjBTtTe BNxPb4kdqeiVUS45LciR()
		{
			return DAiQm3kdMiJLVMQEn9FE;
		}
	}

	internal static ScreenCapture USW7ljkjzNYk2Zg8MtYf;

	public static BitmapSource CaptureWindow(IntPtr handle)
	{
		int num = 3;
		int num3 = default(int);
		A4oDTgGBrfl1xwjBTtTe.tLc7XNGBFMknGdJFJsGC tLc7XNGBFMknGdJFJsGC = default(A4oDTgGBrfl1xwjBTtTe.tLc7XNGBFMknGdJFJsGC);
		int num4 = default(int);
		IntPtr intPtr2 = default(IntPtr);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					num3 = tLc7XNGBFMknGdJFJsGC.YNSGBupfWrE - tLc7XNGBFMknGdJFJsGC.HrrGB3xObRn;
					num4 = tLc7XNGBFMknGdJFJsGC.QTJGBzNfb89 - tLc7XNGBFMknGdJFJsGC.jfwGBpHKgEB;
					num2 = 1;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_7e2cedcef3cc4cf38b7bccbb81c290d2 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					break;
				case 2:
					tLc7XNGBFMknGdJFJsGC = default(A4oDTgGBrfl1xwjBTtTe.tLc7XNGBFMknGdJFJsGC);
					A4oDTgGBrfl1xwjBTtTe.jH1GBhYUHik(handle, ref tLc7XNGBFMknGdJFJsGC);
					num2 = 0;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_a88909e12c974739b0a37dd0a505569a != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
				{
					IntPtr intPtr = NubOUAGBWMLFhGw8hBa6.vgAGBTvduQO(intPtr2);
					IntPtr intPtr3 = NubOUAGBWMLFhGw8hBa6.i3DGBUAg5u9(intPtr2, num3, num4);
					IntPtr intPtr4 = NubOUAGBWMLFhGw8hBa6.XpfGBVK4eZU(intPtr, intPtr3);
					NubOUAGBWMLFhGw8hBa6.cxfGBt4L3IT(intPtr, 0, 0, num3, num4, intPtr2, 0, 0, 13369376);
					NubOUAGBWMLFhGw8hBa6.XpfGBVK4eZU(intPtr, intPtr4);
					NubOUAGBWMLFhGw8hBa6.N0wGByphDem(intPtr);
					A4oDTgGBrfl1xwjBTtTe.AUhGBmlP7xr(handle, intPtr2);
					object result = pXeV3DkEHU3ylupGVCSO(intPtr3, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
					NubOUAGBWMLFhGw8hBa6.yJEGBZGSBuE(intPtr3);
					return (BitmapSource)result;
				}
				}
				break;
			}
			intPtr2 = A4oDTgGBrfl1xwjBTtTe.YKGGBKdOAcD(handle);
			num = 2;
		}
	}

	static ScreenCapture()
	{
		DPo145kEfG3qYpoIjuEs();
		MFbsffkE9WYfTx3ZydtT();
	}

	internal static object pXeV3DkEHU3ylupGVCSO(IntPtr P_0, IntPtr P_1, Int32Rect P_2, object P_3)
	{
		return Imaging.CreateBitmapSourceFromHBitmap(P_0, P_1, P_2, (BitmapSizeOptions)P_3);
	}

	internal static bool yqCyT8kE0X9SwPI3OmID()
	{
		return USW7ljkjzNYk2Zg8MtYf == null;
	}

	internal static ScreenCapture h81loqkE2WmwMZv3kvPF()
	{
		return USW7ljkjzNYk2Zg8MtYf;
	}

	internal static void DPo145kEfG3qYpoIjuEs()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
	}

	internal static void MFbsffkE9WYfTx3ZydtT()
	{
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}
}
