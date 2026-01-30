using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Internal;

internal class eTh
{
	internal static class f7w
	{
		private struct j7d
		{
			public int Tqu;

			public x7k Hq1;

			public R7h GqF;
		}

		[ComImport]
		[Guid("aa80e801-2021-11d2-93e0-0060b067b86e")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		private interface C73
		{
			[SuppressUnmanagedCodeSecurity]
			[SecurityCritical]
			void Activate(out int P_0);

			[SecurityCritical]
			[SuppressUnmanagedCodeSecurity]
			void yw3();

			[SuppressUnmanagedCodeSecurity]
			[SecurityCritical]
			void vwg(out object P_0);

			void bwq(out object P_0);

			void fwQ(out IntPtr P_0);

			[SecurityCritical]
			[SuppressUnmanagedCodeSecurity]
			void zwN(IntPtr P_0);

			void Qwp(IntPtr P_0, object P_1, out object P_2);

			void bwB([MarshalAs(UnmanagedType.Bool)] out bool P_0);

			[PreserveSig]
			[SuppressUnmanagedCodeSecurity]
			[SecurityCritical]
			int TwP(ref Guid P_0, out object P_1);

			void Uwu(out object P_0);

			[SecurityCritical]
			[SuppressUnmanagedCodeSecurity]
			void Mw8(out object P_0);
		}

		[StructLayout(LayoutKind.Sequential)]
		private class l7D
		{
			public int Hq3;

			public R7h HqR;

			public R7h QqY;

			public int Uq4;

			private static l7D hiG;

			public l7D()
			{
				grA.DaB7cz();
				Hq3 = Marshal.SizeOf(typeof(l7D));
				base._002Ector();
			}

			internal static bool NiN()
			{
				return hiG == null;
			}

			internal static l7D ViH()
			{
				return hiG;
			}
		}

		private struct x7k
		{
			public int rqo;

			public int dqj;
		}

		private struct R7h
		{
			public int fq6;

			public int bqH;

			public int zqb;

			public int oqT;

			internal static object jiv;

			public R7h(Rect P_0)
			{
				grA.DaB7cz();
				oqT = (int)Math.Ceiling(P_0.Bottom);
				fq6 = (int)Math.Ceiling(P_0.Left);
				zqb = (int)Math.Ceiling(P_0.Right);
				bqH = (int)Math.Ceiling(P_0.Top);
			}

			public Rect Qqw()
			{
				return new Rect(fq6, bqH, zqb - fq6, oqT - bqH);
			}

			internal static bool Bif()
			{
				return jiv == null;
			}

			internal static object xii()
			{
				return jiv;
			}
		}

		[ThreadStatic]
		private static C73 ts0;

		[ThreadStatic]
		private static bool EsB;

		internal static f7w BM5;

		[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "GetMonitorInfo")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool msm(IntPtr P_0, l7D P_1);

		[DllImport("imm32.dll", EntryPoint = "ImmAssociateContext")]
		private static extern IntPtr xsC(IntPtr P_0, IntPtr P_1);

		[DllImport("imm32.dll", EntryPoint = "ImmCreateContext")]
		private static extern IntPtr Esu();

		[DllImport("imm32.dll", EntryPoint = "ImmDestroyContext")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool Qs1(IntPtr P_0);

		[DllImport("imm32.dll", CharSet = CharSet.Auto, EntryPoint = "ImmGetCompositionStringW")]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern int RsF(IntPtr P_0, int P_1, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder P_2, int P_3);

		[DllImport("imm32.dll", EntryPoint = "ImmGetContext")]
		private static extern IntPtr ts3(IntPtr P_0);

		[DllImport("imm32.dll", EntryPoint = "ImmNotifyIME")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CsR(IntPtr P_0, int P_1, int P_2, int P_3);

		[DllImport("imm32.dll", EntryPoint = "ImmReleaseContext")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool LsY(IntPtr P_0, IntPtr P_1);

		[DllImport("imm32.dll", EntryPoint = "ImmSetCompositionWindow")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool Ms4(IntPtr P_0, IntPtr P_1);

		[DllImport("User32.dll", CharSet = CharSet.Auto, EntryPoint = "MonitorFromRect")]
		private static extern IntPtr tso(ref R7h P_0, int P_1);

		[DllImport("msctf.dll", EntryPoint = "TF_CreateThreadMgr")]
		private static extern int nsj(out C73 P_0);

		[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation.ImeCompositionHelper+NativeMethods.TF_CreateThreadMgr(ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation.ImeCompositionHelper+NativeMethods+ITfThreadMgr@)")]
		public static void vsw()
		{
			if (EsB)
			{
				return;
			}
			if (ts0 == null)
			{
				nsj(out ts0);
				if (ts0 == null)
				{
					EsB = true;
					return;
				}
			}
			ts0.zwN(IntPtr.Zero);
		}

		public static Rect us6(Rect P_0)
		{
			R7h r7h = new R7h(P_0);
			IntPtr intPtr = tso(ref r7h, 2);
			Rect result;
			if (intPtr != IntPtr.Zero)
			{
				l7D l7D = new l7D();
				msm(intPtr, l7D);
				result = l7D.QqY.Qqw();
			}
			else
			{
				result = new Rect(0.0, 0.0, SystemParameters.PrimaryScreenWidth, SystemParameters.PrimaryScreenHeight);
				int num = 0;
				if (qMN() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			return result;
		}

		public static IntPtr CsH(HwndSource P_0, IntPtr P_1)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(219594));
			}
			return xsC(P_0.Handle, P_1);
		}

		public static bool ksb(IntPtr P_0)
		{
			return CsR(P_0, 21, 4, 0);
		}

		public static IntPtr YsT()
		{
			return Esu();
		}

		public static bool PsL(IntPtr P_0)
		{
			return P_0 != IntPtr.Zero && Qs1(P_0);
		}

		public static string hsn(IntPtr P_0)
		{
			if (P_0 == IntPtr.Zero)
			{
				return null;
			}
			int num = RsF(P_0, 8, null, 0);
			if (num <= 0)
			{
				return null;
			}
			int num2 = num / 2;
			StringBuilder stringBuilder = new StringBuilder(num2);
			num = RsF(P_0, 8, stringBuilder, num);
			if (num <= 0)
			{
				return null;
			}
			return stringBuilder.ToString().Substring(0, num2);
		}

		public static IntPtr Ts8(HwndSource P_0)
		{
			if (P_0 == null)
			{
				return IntPtr.Zero;
			}
			return ts3(P_0.Handle);
		}

		public static bool KsI(HwndSource P_0, IntPtr P_1)
		{
			return P_0 != null && P_1 != IntPtr.Zero && LsY(P_0.Handle, P_1);
		}

		public static bool ls5(HwndSource P_0, IntPtr P_1, EditorView P_2, Rect P_3, Rect P_4)
		{
			if (P_1 == IntPtr.Zero)
			{
				throw new ArgumentNullException(Q7Z.tqM(219618));
			}
			Matrix transformToDevice = default(Matrix);
			int num;
			if (P_2 != null)
			{
				if (!(VisualTreeHelperExtended.GetRoot(P_2) is Visual ancestor))
				{
					return false;
				}
				GeneralTransform generalTransform = P_2.TransformToAncestor(ancestor);
				P_3 = generalTransform.TransformBounds(P_3);
				P_4 = generalTransform.TransformBounds(P_4);
				if (P_0 != null)
				{
					transformToDevice = P_0.CompositionTarget.TransformToDevice;
					num = 1;
					if (qMN() != null)
					{
						goto IL_0005;
					}
					goto IL_0009;
				}
				goto IL_00b5;
			}
			throw new ArgumentNullException(Q7Z.tqM(952));
			IL_0005:
			int num2 = default(int);
			num = num2;
			goto IL_0009;
			IL_00b5:
			j7d structure = default(j7d);
			structure.Tqu = 1;
			structure.Hq1 = default(x7k);
			structure.Hq1.rqo = (int)Math.Max(P_4.Left, P_3.Left);
			structure.Hq1.dqj = (int)Math.Max(P_4.Top, P_3.Top);
			structure.GqF.fq6 = (int)P_3.Left;
			structure.GqF.bqH = (int)P_3.Top;
			structure.GqF.zqb = (int)P_3.Right;
			structure.GqF.oqT = (int)P_3.Bottom;
			IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(structure));
			num = 2;
			if (qMN() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
			IL_0009:
			bool result = default(bool);
			switch (num)
			{
			case 1:
				break;
			default:
				return result;
			case 2:
				try
				{
					Marshal.StructureToPtr(structure, intPtr, fDeleteOld: true);
					result = Ms4(P_1, intPtr);
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr);
				}
				goto default;
			}
			P_3.Transform(transformToDevice);
			P_4.Transform(transformToDevice);
			goto IL_00b5;
		}

		internal static bool uMG()
		{
			return BM5 == null;
		}

		internal static f7w qMN()
		{
			return BM5;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public int rsr;

		public eTh Sss;

		internal static _003C_003Ec__DisplayClass18_0 IMH;

		public _003C_003Ec__DisplayClass18_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void osV()
		{
			if (rsr == Sss.Vjp)
			{
				Sss.HjS();
			}
		}

		internal static bool DMj()
		{
			return IMH == null;
		}

		internal static _003C_003Ec__DisplayClass18_0 bMM()
		{
			return IMH;
		}
	}

	private EditorView Lj9;

	private IntPtr Cjy;

	private bool gjq;

	private IntPtr Pj2;

	private HwndSource vj7;

	private HwndSourceHook Rji;

	private int Vjp;

	internal static eTh Ilx;

	private eTh(EditorView P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(193842));
		}
		if (SecurityHelper.IsFullTrust)
		{
			Lj9 = P_0;
			int num = 0;
			if (1 == 0)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			}
			Bj0();
		}
	}

	private void Vj8()
	{
		if (vj7 != null)
		{
			vj7.RemoveHook(Rji);
			f7w.CsH(vj7, Pj2);
			Pj2 = IntPtr.Zero;
			if (gjq)
			{
				f7w.PsL(Cjy);
			}
			else
			{
				f7w.KsI(vj7, Cjy);
			}
			vj7 = null;
			Cjy = IntPtr.Zero;
			gjq = false;
		}
	}

	private void djI()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					if (Lj9 == null)
					{
						return;
					}
					break;
				default:
					if (vj7 != null)
					{
						return;
					}
					vj7 = (HwndSource)PresentationSource.FromVisual(Lj9.SyntaxEditor);
					if (vj7 != null)
					{
						Cjy = f7w.Ts8(vj7);
						gjq = Cjy == IntPtr.Zero;
						if (gjq)
						{
							Cjy = f7w.YsT();
						}
						Pj2 = f7w.CsH(vj7, Cjy);
						vj7.AddHook(Rji);
						f7w.vsw();
					}
					return;
				}
				num2 = 0;
			}
			while (jlL() == null);
		}
	}

	public static Rect vj5(Rect P_0)
	{
		return f7w.us6(P_0);
	}

	private void Bj0()
	{
		if (Lj9 != null)
		{
			InputMethod.SetIsInputMethodSuspended(Lj9, value: true);
			Lj9.Closed += ojB;
			Lj9.HasFocusChanged += xjV;
			Cjy = IntPtr.Zero;
			Pj2 = IntPtr.Zero;
			Rji = Bjs;
		}
	}

	private void ojB(object P_0, EventArgs P_1)
	{
		if (Lj9 != null)
		{
			Lj9.Closed -= ojB;
			Lj9.HasFocusChanged -= xjV;
			Lj9 = null;
		}
		Vj8();
		Rji = null;
	}

	private void xjV(object P_0, EventArgs P_1)
	{
		if (Lj9 == null || Lj9.SyntaxEditor == null || !Lj9.SyntaxEditor.IsImeEnabled)
		{
			return;
		}
		int num = 0;
		if (jlL() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 1:
			return;
		}
		if (!Lj9.HasFocus)
		{
			if (Cjy != IntPtr.Zero)
			{
				string text = f7w.hsn(Cjy);
				if (!string.IsNullOrEmpty(text))
				{
					Njr(text);
				}
				f7w.ksb(Cjy);
			}
			Vj8();
		}
		else
		{
			djI();
		}
	}

	private void Njr(string P_0)
	{
		if (Lj9 != null)
		{
			TextComposition composition = new TextComposition(InputManager.Current, Lj9, P_0);
			TextCompositionEventArgs e = new TextCompositionEventArgs(Keyboard.PrimaryDevice, composition)
			{
				RoutedEvent = UIElement.TextInputEvent,
				Source = Lj9
			};
			Lj9.ufE(e);
		}
	}

	private IntPtr Bjs(IntPtr P_0, int P_1, IntPtr P_2, IntPtr P_3, ref bool P_4)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					if (flag && Lj9 != null)
					{
						_003C_003Ec__DisplayClass18_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass18_0();
						CS_0024_003C_003E8__locals5.Sss = this;
						Vjp = (Vjp + 1) % 100000;
						CS_0024_003C_003E8__locals5.rsr = Vjp;
						Lj9.Dispatcher.BeginInvoke(DispatcherPriority.Input, (Action)delegate
						{
							if (CS_0024_003C_003E8__locals5.rsr == CS_0024_003C_003E8__locals5.Sss.Vjp)
							{
								CS_0024_003C_003E8__locals5.Sss.HjS();
							}
						});
					}
					return IntPtr.Zero;
				case 1:
					break;
				}
				flag = P_1 == 271;
				num2 = 0;
			}
			while (ala());
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives.ImeCompositionHelper")]
	public static eTh Gjk(EditorView P_0)
	{
		return new eTh(P_0);
	}

	public void HjS()
	{
		if (Cjy != IntPtr.Zero && Lj9 != null)
		{
			Rect textAreaViewportBounds = Lj9.TextAreaViewportBounds;
			TextBounds characterBounds = Lj9.GetCharacterBounds(Lj9.SyntaxEditor.ActiveView.Selection.EndPosition);
			Rect rect = characterBounds.Rect;
			if (!characterBounds.IsYValid)
			{
				rect.Y = 0.0;
			}
			rect = Lj9.TransformFromTextArea(rect);
			f7w.ls5(vj7, Cjy, Lj9, textAreaViewportBounds, rect);
		}
	}

	internal static bool ala()
	{
		return Ilx == null;
	}

	internal static eTh jlL()
	{
		return Ilx;
	}
}
