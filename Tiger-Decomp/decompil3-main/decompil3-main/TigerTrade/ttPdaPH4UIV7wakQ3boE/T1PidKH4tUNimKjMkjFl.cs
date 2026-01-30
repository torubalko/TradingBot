using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Docking;
using dpoTZ395JPmKdIOgCedl;
using ECOEgqlSad8NUJZ2Dr9n;
using Gsw4NVHiTDDL7gpIRhFY;
using inUerCfHMLVDbG9HvwwZ;
using OWUMXkHkWgCUprHQ3jb9;
using TeKe9DHvMky5awWIwL0S;
using TuAMtrl1Nd3XoZQQUXf0;
using U2AoR19TNRFWN9WoaNy;
using X6SdNQfbpTDIYC7YsKf;

namespace ttPdaPH4UIV7wakQ3boE;

internal static class T1PidKH4tUNimKjMkjFl
{
	[CompilerGenerated]
	private sealed class KQRYOcnTgiXsDHLDAMY6
	{
		public Window kDQnT61SVsL;

		private static KQRYOcnTgiXsDHLDAMY6 wTqbm7NxTdqo0uOZECfc;

		public KQRYOcnTgiXsDHLDAMY6()
		{
			FpYHVyNxVLn6mYWJagG1();
			base._002Ector();
		}

		internal bool JpSnTRaT8DL(XGCC7uHiU9mHapo7PkJ2 lw)
		{
			return lw.JjDHiw4M1ib().Equals(kDQnT61SVsL);
		}

		static KQRYOcnTgiXsDHLDAMY6()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static void FpYHVyNxVLn6mYWJagG1()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool r2Qm8pNxy0GyXnKCBXJj()
		{
			return wTqbm7NxTdqo0uOZECfc == null;
		}

		internal static KQRYOcnTgiXsDHLDAMY6 mp5c4INxZuJCOxyXeoyD()
		{
			return wTqbm7NxTdqo0uOZECfc;
		}
	}

	private static bool Q1YHD2Uqv6j;

	private static vGAIWNHv6VDDXsQkVUsi jIaHDH4JekY;

	private static List<PbGEeJHkI13kYvWpne18> H58HDfXaGML;

	private static readonly List<SR0mvgfDf5j2LlP9Nlb> gDhHD9pf0HK;

	private static readonly List<XGCC7uHiU9mHapo7PkJ2> vMHHDnO6lrj;

	private static readonly List<HwndSource> D7DHDG7Gvrv;

	private static Action<PreProcessInputEventArgs> FPqHDYUVr5a;

	private static Window OpaHDoVWVd3;

	internal static T1PidKH4tUNimKjMkjFl nBSRTCD1KnnKl8u1L5HK;

	public static bool IsLocked => Q1YHD2Uqv6j;

	public static void XD6H4TUwqly(Window P_0)
	{
		OpaHDoVWVd3 = P_0;
		CpiB9dD1wV3p83iy90YZ();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		((InputManager)JiFW1rD173ogRbeHZNxA()).PreProcessInput += Et5H4wZmq7U;
	}

	private static void l0mH4yW9afH()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				FPqHDYUVr5a = fB2H48FN991;
				return;
			case 1:
				if (Q1YHD2Uqv6j)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
					{
						num2 = 0;
					}
					break;
				}
				FPqHDYUVr5a = LAEH47gcw5R;
				return;
			}
		}
	}

	public static void WEoH4ZJ8LCY()
	{
		InputManager.Current.PreProcessInput -= Et5H4wZmq7U;
		OpaHDoVWVd3 = null;
	}

	public static void bYFH4VA7N0W(vGAIWNHv6VDDXsQkVUsi P_0)
	{
		jIaHDH4JekY = P_0;
	}

	public static void zO0H4C3wa1t(PbGEeJHkI13kYvWpne18 P_0)
	{
		if (!H58HDfXaGML.Contains(P_0))
		{
			H58HDfXaGML.Add(P_0);
		}
	}

	public static void Dx9H4rRn2in(PbGEeJHkI13kYvWpne18 P_0)
	{
		H58HDfXaGML.Remove(P_0);
	}

	public static void G0tH4KBIVe2(SR0mvgfDf5j2LlP9Nlb P_0)
	{
		if (!gDhHD9pf0HK.Contains(P_0))
		{
			gDhHD9pf0HK.Add(P_0);
		}
	}

	public static void gLXH4mGSGxH(SR0mvgfDf5j2LlP9Nlb P_0)
	{
		gDhHD9pf0HK.Remove(P_0);
	}

	public static void Lock()
	{
		if (Q1YHD2Uqv6j || jIaHDH4JekY == null)
		{
			return;
		}
		Q1YHD2Uqv6j = true;
		int num = 3;
		IEnumerator<DocumentWindow> enumerator2 = default(IEnumerator<DocumentWindow>);
		List<PbGEeJHkI13kYvWpne18>.Enumerator enumerator4 = default(List<PbGEeJHkI13kYvWpne18>.Enumerator);
		while (true)
		{
			switch (num)
			{
			case 3:
				jIaHDH4JekY.Locked = true;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
				{
					num = 2;
				}
				continue;
			case 2:
			{
				l0mH4yW9afH();
				using (List<SR0mvgfDf5j2LlP9Nlb>.Enumerator enumerator = gDhHD9pf0HK.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						SR0mvgfDf5j2LlP9Nlb current;
						while (true)
						{
							current = enumerator.Current;
							int num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
							{
								num2 = 1;
							}
							while (true)
							{
								switch (num2)
								{
								case 1:
									enumerator2 = current.DockSite.DocumentWindows.GetEnumerator();
									num2 = 2;
									continue;
								case 2:
									goto end_IL_0124;
								}
								break;
							}
							continue;
							end_IL_0124:
							break;
						}
						try
						{
							while (enumerator2.MoveNext())
							{
								xVKDNED18ckoG1uPw9xs(enumerator2.Current);
								int num3 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
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
							if (enumerator2 != null)
							{
								q8f0vkD1A5i3NNUClOaX(enumerator2);
								int num4 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
							}
						}
						IEnumerator<ToolWindow> enumerator3 = current.DockSite.ToolWindows.GetEnumerator();
						try
						{
							while (enumerator3.MoveNext())
							{
								BGvH4F9oCIc(enumerator3.Current);
							}
						}
						finally
						{
							if (enumerator3 != null)
							{
								enumerator3.Dispose();
								int num5 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
								{
									num5 = 0;
								}
								switch (num5)
								{
								case 0:
									break;
								}
							}
						}
					}
				}
				enumerator4 = H58HDfXaGML.GetEnumerator();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
				{
					num = 0;
				}
				continue;
			}
			case 1:
				return;
			}
			try
			{
				while (enumerator4.MoveNext())
				{
					PmjwDmD1PpVmRn7TR4xR(enumerator4.Current);
					int num6 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					}
				}
				return;
			}
			finally
			{
				((IDisposable)enumerator4/*cast due to .constrained prefix*/).Dispose();
			}
		}
	}

	public static void WrpH4hGq9Hn()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				jIaHDH4JekY.Locked = false;
				break;
			case 1:
				vMHHDnO6lrj.Clear();
				D7DHDG7Gvrv.Clear();
				return;
			default:
			{
				foreach (HwndSource item in D7DHDG7Gvrv)
				{
					item.RemoveHook(zSkH4uwkqYx);
				}
				using (List<XGCC7uHiU9mHapo7PkJ2>.Enumerator enumerator2 = vMHHDnO6lrj.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						mCrsswD1JIriQFBJyihT(enumerator2.Current);
					}
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			}
			case 2:
				return;
			case 3:
				if (Q1YHD2Uqv6j)
				{
					Q1YHD2Uqv6j = false;
					if (jIaHDH4JekY != null)
					{
						num2 = 4;
						continue;
					}
					break;
				}
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
				{
					num2 = 2;
				}
				continue;
			}
			l0mH4yW9afH();
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
			{
				num2 = 0;
			}
		}
	}

	private static void Et5H4wZmq7U(object P_0, PreProcessInputEventArgs P_1)
	{
		FPqHDYUVr5a(P_1);
	}

	private static void LAEH47gcw5R(PreProcessInputEventArgs P_0)
	{
		if (!(((StagingAreaInputItem)fVidkeD1FYh9aMfA5Ph5(P_0)).Input is KeyEventArgs e))
		{
			return;
		}
		int num;
		if (V5jIseD13U2GHngvKGVV(vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().SecurityLock, e))
		{
			Window opaHDoVWVd = OpaHDoVWVd3;
			if (opaHDoVWVd != null)
			{
				opaHDoVWVd.Focus();
				return;
			}
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		case 1:
			break;
		case 0:
			break;
		}
	}

	private static void fB2H48FN991(PreProcessInputEventArgs P_0)
	{
		InputEventArgs input = P_0.StagingItem.Input;
		int num;
		if (!(input is KeyEventArgs args))
		{
			if (input is KeyboardEventArgs)
			{
				P_0.Cancel();
				return;
			}
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 != 0)
			{
				num = 1;
			}
		}
		else if (!vspL39fH6Hd69qemUHrA.YXwfHUcZiBY().SecurityLock.Check(args))
		{
			P_0.Cancel();
			num = 2;
		}
		else
		{
			Window opaHDoVWVd = OpaHDoVWVd3;
			if (opaHDoVWVd == null)
			{
				return;
			}
			opaHDoVWVd.Focus();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
			{
				num = 0;
			}
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				return;
			case 0:
				return;
			case 1:
				P_0.Cancel();
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd != 0)
				{
					num = 2;
				}
				break;
			case 4:
				if (!(input is MouseEventArgs) || IMKH4JmJhVu((IInputElement)s8EUR5D1uq4VicwP7QaF(((InputManager)sN9EWND1pYqWFbw0A09Y(P_0)).PrimaryMouseDevice)))
				{
					return;
				}
				goto case 1;
			case 2:
				return;
			}
		}
	}

	private static bool GnuH4A20L9y(IInputElement P_0)
	{
		if (jIaHDH4JekY != null)
		{
			return jIaHDH4JekY.RnMl9Hhj8oL(P_0);
		}
		return false;
	}

	private static bool CnSH4PTLDMD(FrameworkElement P_0)
	{
		if (!oXNH4zW74wp(P_0.Name))
		{
			DependencyObject dependencyObject = P_0;
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
			{
				num = 0;
			}
			FrameworkElement frameworkElement = default(FrameworkElement);
			while (true)
			{
				object obj;
				switch (num)
				{
				case 1:
					if (dependencyObject == null)
					{
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
						{
							num = 0;
						}
						break;
					}
					frameworkElement = dependencyObject as FrameworkElement;
					if (frameworkElement != null)
					{
						int num2 = 3;
						num = num2;
						break;
					}
					goto IL_008e;
				default:
					return false;
				case 3:
					if (oXNH4zW74wp((string)XIs5M0D1zxDdP0G4O3kU(frameworkElement)))
					{
						return true;
					}
					goto IL_008e;
				case 2:
					{
						obj = LogicalTreeHelper.GetParent(dependencyObject);
						goto IL_00e8;
					}
					IL_008e:
					obj = rQcw35D50MVOuOaLLt3L(dependencyObject);
					if (obj == null)
					{
						num = 2;
						break;
					}
					goto IL_00e8;
					IL_00e8:
					dependencyObject = (DependencyObject)obj;
					goto case 1;
				}
			}
		}
		return true;
	}

	private static bool IMKH4JmJhVu(IInputElement P_0)
	{
		int num = 1;
		int num2 = num;
		FrameworkElement frameworkElement = default(FrameworkElement);
		while (true)
		{
			switch (num2)
			{
			case 1:
				frameworkElement = P_0 as FrameworkElement;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (frameworkElement != null)
			{
				if (!NdTBhoD52y18eLo3qi4i(frameworkElement))
				{
					return tSOYn0D5HpwSktuhtYsq(frameworkElement);
				}
				return true;
			}
			return false;
		}
	}

	private static void BGvH4F9oCIc(DockingWindow P_0)
	{
		Window window = nufH4pNvv0Q(P_0);
		if (window != null)
		{
			PmjwDmD1PpVmRn7TR4xR(window);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
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

	private static void AmXH43waMFg(Window P_0)
	{
		KQRYOcnTgiXsDHLDAMY6 CS_0024_003C_003E8__locals5 = new KQRYOcnTgiXsDHLDAMY6();
		CS_0024_003C_003E8__locals5.kDQnT61SVsL = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
		{
			num = 0;
		}
		XGCC7uHiU9mHapo7PkJ2 xGCC7uHiU9mHapo7PkJ = default(XGCC7uHiU9mHapo7PkJ2);
		HwndSource hwndSource = default(HwndSource);
		while (true)
		{
			switch (num)
			{
			default:
				if (!ohIyecD5fU5QcWU4UGpA(CS_0024_003C_003E8__locals5.kDQnT61SVsL))
				{
					return;
				}
				if (!vMHHDnO6lrj.Any((XGCC7uHiU9mHapo7PkJ2 lw) => lw.JjDHiw4M1ib().Equals(CS_0024_003C_003E8__locals5.kDQnT61SVsL)))
				{
					xGCC7uHiU9mHapo7PkJ = new XGCC7uHiU9mHapo7PkJ2(CS_0024_003C_003E8__locals5.kDQnT61SVsL);
					vMHHDnO6lrj.Add(xGCC7uHiU9mHapo7PkJ);
					hwndSource = rbsNPsD595jglZoJTOXc(CS_0024_003C_003E8__locals5.kDQnT61SVsL) as HwndSource;
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
					{
						num = 0;
					}
				}
				else
				{
					num = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
					{
						num = 3;
					}
				}
				continue;
			case 3:
				return;
			case 1:
				if (hwndSource != null)
				{
					vm8XbgD5nrIKpaYdcEoS(hwndSource, new HwndSourceHook(zSkH4uwkqYx));
					num = 2;
					continue;
				}
				break;
			case 2:
				D7DHDG7Gvrv.Add(hwndSource);
				break;
			}
			break;
		}
		xGCC7uHiU9mHapo7PkJ.Lock();
	}

	private static Window nufH4pNvv0Q(DockingWindow P_0)
	{
		int num;
		if (P_0?.DockHost != null)
		{
			Window parentWindow = hNXfXl9U6G1YI9MQ7eq.Instance.MainWindow.GetParentWindow((DependencyObject)NY7sd9D5GuSR0RouKlMm(P_0));
			if (parentWindow == null)
			{
				goto IL_006b;
			}
			if (!(parentWindow is PbGEeJHkI13kYvWpne18))
			{
				return parentWindow;
			}
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 1:
			return null;
		}
		goto IL_006b;
		IL_006b:
		return null;
	}

	private static IntPtr zSkH4uwkqYx(IntPtr P_0, int P_1, IntPtr P_2, IntPtr P_3, ref bool P_4)
	{
		if (!IsLocked)
		{
			return IntPtr.Zero;
		}
		int num;
		if (P_1 > 161)
		{
			if (P_1 > 274)
			{
				if ((uint)(P_1 - 278) <= 1u)
				{
					goto IL_01df;
				}
				if (P_1 == 532)
				{
					P_4 = true;
					return IntPtr.Zero;
				}
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
				{
					num = 9;
				}
			}
			else
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
				{
					num = 0;
				}
			}
		}
		else
		{
			if (P_1 == 123)
			{
				goto IL_01df;
			}
			num = 2;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				if ((uint)(P_1 - 163) > 2u)
				{
					num = 8;
					continue;
				}
				goto IL_014c;
			case 2:
				if (P_1 != 132)
				{
					num = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
					{
						num = 5;
					}
					continue;
				}
				P_4 = true;
				return new IntPtr(1);
			case 5:
				if (P_1 != 161)
				{
					num = 4;
					continue;
				}
				goto IL_014c;
			case 7:
				if (num2 == 61440)
				{
					goto IL_00cd;
				}
				goto case 4;
			case 4:
			case 6:
			case 9:
				return IntPtr.Zero;
			case 3:
				P_4 = true;
				return IntPtr.Zero;
			case 8:
				{
					if (P_1 == 274)
					{
						num2 = P_2.ToInt32() & 0xFFF0;
						if (num2 != 61456 && num2 != 61696)
						{
							num = 5;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
							{
								num = 7;
							}
							continue;
						}
						goto IL_00cd;
					}
					num = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 != 0)
					{
						num = 6;
					}
					continue;
				}
				IL_00cd:
				P_4 = true;
				return IntPtr.Zero;
				IL_014c:
				if (P_2.ToInt32() == 2)
				{
					num = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
					{
						num = 3;
					}
					continue;
				}
				goto case 4;
			}
			break;
		}
		goto IL_01df;
		IL_01df:
		P_4 = true;
		return IntPtr.Zero;
	}

	static T1PidKH4tUNimKjMkjFl()
	{
		fOnEQjD5YJpoSdSJ44Ej();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				D7DHDG7Gvrv = new List<HwndSource>();
				return;
			}
			H58HDfXaGML = new List<PbGEeJHkI13kYvWpne18>();
			gDhHD9pf0HK = new List<SR0mvgfDf5j2LlP9Nlb>();
			vMHHDnO6lrj = new List<XGCC7uHiU9mHapo7PkJ2>();
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
			{
				num = 1;
			}
		}
	}

	[CompilerGenerated]
	internal static bool oXNH4zW74wp(string P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2108526692 ^ -2108460130)) && !(P_0 == (string)uTPNy6D5oonhB5jMhwT3(-710503328 ^ -710440894)))
				{
					return skyjeUD5v0ue3MRpJxCB(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1251569705 ^ -1251503125));
				}
				goto IL_003b;
			case 1:
				{
					if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1192989954 ^ -1192922852)))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_003b;
				}
				IL_003b:
				return true;
			}
		}
	}

	internal static void CpiB9dD1wV3p83iy90YZ()
	{
		l0mH4yW9afH();
	}

	internal static object JiFW1rD173ogRbeHZNxA()
	{
		return InputManager.Current;
	}

	internal static bool d8csLeD1mAf1nWtRLFcR()
	{
		return nBSRTCD1KnnKl8u1L5HK == null;
	}

	internal static T1PidKH4tUNimKjMkjFl DGOPGMD1hXOdfnqXC7pf()
	{
		return nBSRTCD1KnnKl8u1L5HK;
	}

	internal static void xVKDNED18ckoG1uPw9xs(object P_0)
	{
		BGvH4F9oCIc((DockingWindow)P_0);
	}

	internal static void q8f0vkD1A5i3NNUClOaX(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void PmjwDmD1PpVmRn7TR4xR(object P_0)
	{
		AmXH43waMFg((Window)P_0);
	}

	internal static void mCrsswD1JIriQFBJyihT(object P_0)
	{
		((XGCC7uHiU9mHapo7PkJ2)P_0).xSIHimZ15dm();
	}

	internal static object fVidkeD1FYh9aMfA5Ph5(object P_0)
	{
		return ((NotifyInputEventArgs)P_0).StagingItem;
	}

	internal static bool V5jIseD13U2GHngvKGVV(object P_0, object P_1)
	{
		return ((UQpOEF95Pl27GeSpKZ6s)P_0).Check((KeyEventArgs)P_1);
	}

	internal static object sN9EWND1pYqWFbw0A09Y(object P_0)
	{
		return ((NotifyInputEventArgs)P_0).InputManager;
	}

	internal static object s8EUR5D1uq4VicwP7QaF(object P_0)
	{
		return ((InputDevice)P_0).Target;
	}

	internal static object XIs5M0D1zxDdP0G4O3kU(object P_0)
	{
		return ((FrameworkElement)P_0).Name;
	}

	internal static object rQcw35D50MVOuOaLLt3L(object P_0)
	{
		return VisualTreeHelper.GetParent((DependencyObject)P_0);
	}

	internal static bool NdTBhoD52y18eLo3qi4i(object P_0)
	{
		return CnSH4PTLDMD((FrameworkElement)P_0);
	}

	internal static bool tSOYn0D5HpwSktuhtYsq(object P_0)
	{
		return GnuH4A20L9y((IInputElement)P_0);
	}

	internal static bool ohIyecD5fU5QcWU4UGpA(object P_0)
	{
		return ((UIElement)P_0).IsVisible;
	}

	internal static object rbsNPsD595jglZoJTOXc(object P_0)
	{
		return PresentationSource.FromVisual((Visual)P_0);
	}

	internal static void vm8XbgD5nrIKpaYdcEoS(object P_0, object P_1)
	{
		((HwndSource)P_0).AddHook((HwndSourceHook)P_1);
	}

	internal static object NY7sd9D5GuSR0RouKlMm(object P_0)
	{
		return ((DockingWindow)P_0).DockHost;
	}

	internal static void fOnEQjD5YJpoSdSJ44Ej()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object uTPNy6D5oonhB5jMhwT3(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool skyjeUD5v0ue3MRpJxCB(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}
}
