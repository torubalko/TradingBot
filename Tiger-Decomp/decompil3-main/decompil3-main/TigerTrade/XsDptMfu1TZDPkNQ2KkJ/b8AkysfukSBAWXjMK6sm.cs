using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using dV5LggXFqPRU9hEU4k;
using ECOEgqlSad8NUJZ2Dr9n;
using EPTTTK9AHwAIaZbPECNj;
using fl2m71HISn0woXH4Aohv;
using fYhUk9HUsRUVM7KyKaq5;
using H7MLZrHyh5mmqf5q1aQM;
using hnRSFQHLWIs9WKnIZiIr;
using hUVABgfuidfseul80XeP;
using IQYLj190jO7J9KJxPiiQ;
using j4uWsqHWYQ1yIRgwX0yT;
using Jgts7nfznYcKf4dWwwEP;
using Oieg4S9ABk6Envg2Z2KM;
using OyR48UfuGdxSarpKFeyt;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Core.Utils.Binary;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using uPAbnGG980DscR4DZEMf;
using VJ7BEJHXz8aOVDmNP5pJ;
using vSyfydHTvH6DJGMLfl88;
using XF1Tgs90kedR1Bnx4jOX;
using yTUn42HtsQvWm8KqT3n7;
using YXN4729A10DxKcBAQEu4;

namespace XsDptMfu1TZDPkNQ2KkJ;

internal static class b8AkysfukSBAWXjMK6sm
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct Q1vn58nJdAPbKNUlws88 : IAsyncStateMachine
	{
		public int yZ6nJgAYNsF;

		public AsyncTaskMethodBuilder oBwnJRKLuv3;

		public Symbol RfinJ64CGNt;

		public DataCycle yZwnJM51GBA;

		public long caHnJOBsZS4;

		private TaskAwaiter KQmnJqFlO2O;

		internal static object GTcwZiNOIaA531k0w6Zw;

		private void MoveNext()
		{
			int num = 1;
			int num2 = num;
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = yZ6nJgAYNsF;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				try
				{
					TaskAwaiter awaiter;
					int num4;
					if (num3 != 0)
					{
						awaiter = P9tOBdNOTGJfvG0GubmC(pPJtYHNOUIaIHdgLLo9W(RfinJ64CGNt, yZwnJM51GBA, caHnJOBsZS4));
						if (!awaiter.IsCompleted)
						{
							num3 = (yZ6nJgAYNsF = 0);
							num4 = 2;
							goto IL_0075;
						}
						goto IL_00fa;
					}
					goto IL_015c;
					IL_00fa:
					awaiter.GetResult();
					goto end_IL_0065;
					IL_015c:
					awaiter = KQmnJqFlO2O;
					KQmnJqFlO2O = default(TaskAwaiter);
					num3 = (yZ6nJgAYNsF = -1);
					num4 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
					{
						num4 = 0;
					}
					goto IL_0075;
					IL_0075:
					while (true)
					{
						switch (num4)
						{
						case 2:
							KQmnJqFlO2O = awaiter;
							num4 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							oBwnJRKLuv3.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 3:
							goto IL_015c;
						}
						break;
					}
					goto IL_00fa;
					end_IL_0065:;
				}
				catch (Exception exception)
				{
					int num5 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					}
					yZ6nJgAYNsF = -2;
					oBwnJRKLuv3.SetException(exception);
					return;
				}
				yZ6nJgAYNsF = -2;
				oBwnJRKLuv3.SetResult();
				return;
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			oBwnJRKLuv3.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static Q1vn58nJdAPbKNUlws88()
		{
			sFKnxFNOy7GgiRSRZ8EA();
		}

		internal static object pPJtYHNOUIaIHdgLLo9W(object P_0, object P_1, long P_2)
		{
			return tj7IVyHLIiNJqBQROZUd.CBdHLZmAbeV((Symbol)P_0, (DataCycle)P_1, P_2);
		}

		internal static TaskAwaiter P9tOBdNOTGJfvG0GubmC(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		internal static bool SKrki9NOWZX3Q59RZuPc()
		{
			return GTcwZiNOIaA531k0w6Zw == null;
		}

		internal static object xmIRypNOt5G1CQyx1xkY()
		{
			return GTcwZiNOIaA531k0w6Zw;
		}

		internal static void sFKnxFNOy7GgiRSRZ8EA()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class vfeHdrnJIRWrLxGlbFu7
	{
		public static readonly vfeHdrnJIRWrLxGlbFu7 yPMnJtPHepf;

		internal static vfeHdrnJIRWrLxGlbFu7 EPCnLJNOZTqaqMC4QiWf;

		static vfeHdrnJIRWrLxGlbFu7()
		{
			Q0N3v2NOruZmpOnKtKHh();
			nwfIbaNOKuXkoVa4YMM8();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			yPMnJtPHepf = new vfeHdrnJIRWrLxGlbFu7();
		}

		public vfeHdrnJIRWrLxGlbFu7()
		{
			nwfIbaNOKuXkoVa4YMM8();
			base._002Ector();
		}

		internal void mNWnJWh4WOQ(object x)
		{
			oiYfuF80lSV.Set();
		}

		internal static void Q0N3v2NOruZmpOnKtKHh()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static void nwfIbaNOKuXkoVa4YMM8()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool GHN9Z9NOVwqnsgBKpAtu()
		{
			return EPCnLJNOZTqaqMC4QiWf == null;
		}

		internal static vfeHdrnJIRWrLxGlbFu7 N3g7XhNOCL3CJxR1V1BS()
		{
			return EPCnLJNOZTqaqMC4QiWf;
		}
	}

	private static readonly KeyValuePair<string, object> YEdfuwrxu8F;

	private static readonly RJQ40bG97fddixgFUWO6.RHMfWeGG1Zy17MVuKmAd mgPfu7UWqbm;

	private static readonly ActivitySource m03fu8jxA9A;

	private static readonly ConcurrentDictionary<string, string> eKafuApTgZC;

	private static readonly BlockingCollection<t8QNqWfz9x1DweDKl161> bFofuP5dh4Q;

	private static readonly CancellationTokenSource oc8fuJyYAv8;

	private static readonly EventWaitHandle oiYfuF80lSV;

	private static readonly Timer uJmfu3SVArc;

	private static readonly int t4PfupO8B8t;

	[CompilerGenerated]
	private static Action<h3GPi790NINi0SKF01rq> O0ufuuLP5c8;

	private static IPavdHHXuGgrKgtTe2T3 yaNfuz1kUfk;

	private static tj7IVyHLIiNJqBQROZUd uAufz0HSpAC;

	private static readonly ConcurrentDictionary<string, t8QNqWfz9x1DweDKl161> VvUfz2vwrDC;

	private static readonly List<t8QNqWfz9x1DweDKl161> PMcfzH4vOiU;

	[CompilerGenerated]
	private static bool VoCfzfrkCAm;

	private static b8AkysfukSBAWXjMK6sm x8TcBmb49Jb3WMduA2My;

	public static bool Loaded
	{
		[CompilerGenerated]
		get
		{
			return VoCfzfrkCAm;
		}
		[CompilerGenerated]
		set
		{
			VoCfzfrkCAm = voCfzfrkCAm;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public static void IBcfuKIDIDv(Action<h3GPi790NINi0SKF01rq> P_0)
	{
		Action<h3GPi790NINi0SKF01rq> action = O0ufuuLP5c8;
		Action<h3GPi790NINi0SKF01rq> action2;
		do
		{
			action2 = action;
			Action<h3GPi790NINi0SKF01rq> value = (Action<h3GPi790NINi0SKF01rq>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref O0ufuuLP5c8, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void TFNfumSaQuM(Action<h3GPi790NINi0SKF01rq> P_0)
	{
		Action<h3GPi790NINi0SKF01rq> action = O0ufuuLP5c8;
		Action<h3GPi790NINi0SKF01rq> action2;
		do
		{
			action2 = action;
			Action<h3GPi790NINi0SKF01rq> value = (Action<h3GPi790NINi0SKF01rq>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref O0ufuuLP5c8, value, action2);
		}
		while ((object)action != action2);
	}

	public static void mhIfu54W3VV()
	{
		JxBLTBb4Yy2NoDMn9NVi(_0020: true);
		t4UfuLgv0f0(_0020: true, new YsCJFHHToNuX7stTEovm
		{
			IsValid = (yaNfuz1kUfk?.sjWHcuHPsbS() ?? false)
		});
	}

	public static void wfgfuSBxkS7()
	{
		yaNfuz1kUfk = ((dSdtjnsurkSDIOox0m)u1eHglb4oec80EWfvDWg()).wFghDOqc9();
		uAufz0HSpAC = ((dSdtjnsurkSDIOox0m)Application.Current).z5j8gprRS();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				yaNfuz1kUfk.wYFHj9xAe7P(t4UfuLgv0f0);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
				{
					num = 0;
				}
				continue;
			case 1:
				uAufz0HSpAC.yl3HeBJxvYp(wZjfusamjc4);
				vwmsbVb4BZ0Xn3vLbZpn(OJD5kCb4vLp2sly49omF(), new Action(mI5fux9kwc5), oc8fuJyYAv8.Token, TaskCreationOptions.LongRunning, TaskScheduler.Default);
				return;
			}
			yaNfuz1kUfk.Disconnected += Ug9fueuSXOf;
			yaNfuz1kUfk.p92HjYsSAMT(wZjfusamjc4);
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
			{
				num = 1;
			}
		}
	}

	public static void Clear()
	{
		if (yaNfuz1kUfk == null)
		{
			return;
		}
		yaNfuz1kUfk.R5wHjnS6MvE(t4UfuLgv0f0);
		int num = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				uJmfu3SVArc.Dispose();
				return;
			case 2:
				yaNfuz1kUfk.Disconnected -= Ug9fueuSXOf;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
				{
					num = 0;
				}
				continue;
			}
			yaNfuz1kUfk.LckHjoclwAN(wZjfusamjc4);
			uAufz0HSpAC.NwtHealZNOF(wZjfusamjc4);
			Q9CNVXb4ak7DcTVv0r0U(oc8fuJyYAv8);
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
			{
				num = 1;
			}
		}
	}

	private static void mI5fux9kwc5()
	{
		while (!Om7Donb4lEeYiSLkqXEh(oc8fuJyYAv8))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				return;
			}
			try
			{
				re9JWAb4imoAAbdXe6Dj(oiYfuF80lSV);
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b != 0)
				{
					num2 = 1;
				}
				switch (num2)
				{
				default:
					goto end_IL_0066;
				case 1:
					break;
				case 0:
					goto end_IL_0066;
				}
				t8QNqWfz9x1DweDKl161 item;
				while (bFofuP5dh4Q.TryTake(out item, 0, oc8fuJyYAv8.Token))
				{
					if (!eKafuApTgZC.TryGetValue(item.UyTfz4sb9ku(), out var _))
					{
						RequestData(item);
					}
				}
				end_IL_0066:;
			}
			catch
			{
				return;
			}
			finally
			{
				eKafuApTgZC.Clear();
			}
		}
	}

	private static void t4UfuLgv0f0(bool P_0, YsCJFHHToNuX7stTEovm P_1)
	{
		if (!P_0 || !P_1.IsValid)
		{
			return;
		}
		List<t8QNqWfz9x1DweDKl161> list = PMcfzH4vOiU.ToList();
		PMcfzH4vOiU.Clear();
		List<t8QNqWfz9x1DweDKl161>.Enumerator enumerator = list.GetEnumerator();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			try
			{
				while (enumerator.MoveNext())
				{
					t8QNqWfz9x1DweDKl161 current = enumerator.Current;
					bFofuP5dh4Q.Add(current);
				}
			}
			finally
			{
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
			}
			uJmfu3SVArc.Change(0, 0);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
			{
				num = 1;
			}
		}
	}

	private static void Ug9fueuSXOf()
	{
		PMcfzH4vOiU.AddRange(VvUfz2vwrDC.Values);
		using (List<t8QNqWfz9x1DweDKl161>.Enumerator enumerator = PMcfzH4vOiU.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				enumerator.Current.iZ5fzaaA308();
			}
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		VvUfz2vwrDC.Clear();
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
		{
			num2 = 0;
		}
		switch (num2)
		{
		case 0:
			break;
		}
	}

	private static void wZjfusamjc4(t0g5x0HUeQ3nJK56KReg P_0)
	{
		int num;
		int num2 = default(int);
		if (P_0.YBFHUdSpYL1())
		{
			BZsk4Ib4DsQsFQBnf4T8(P_0.qGsHUjjASwb());
			num = 6;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
			{
				num = 6;
			}
		}
		else
		{
			num2 = P_0.DataType;
			if (num2 > 211)
			{
				if (num2 <= 221)
				{
					goto IL_0187;
				}
				num = 3;
			}
			else
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
				{
					num = 1;
				}
			}
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				return;
			case 7:
				return;
			case 3:
				switch (num2)
				{
				case 301:
					g9afuOy5TZ4(P_0);
					num = 2;
					break;
				default:
					return;
				case 222:
					CQwfujy9PCU(P_0);
					num = 5;
					break;
				}
				continue;
			case 0:
				return;
			case 5:
				return;
			case 6:
				return;
			case 1:
				switch (num2)
				{
				case 211:
					LuQfuRbP5iE(P_0);
					break;
				case 201:
					QJ7wfHb44R2IC8qIgZJN(P_0);
					break;
				case 202:
					lLgfudk0ciy(P_0);
					break;
				}
				return;
			case 4:
				break;
			}
			break;
		}
		goto IL_0187;
		IL_0187:
		if (num2 == 212)
		{
			oFafu6F4jy5(P_0);
			return;
		}
		if (num2 == 221)
		{
			scYfuciSfu4(P_0);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 7;
		}
		goto IL_0009;
	}

	private static void CQifuXvayYB(string P_0)
	{
		if (!VvUfz2vwrDC.TryGetValue(P_0, out var value))
		{
			return;
		}
		JDGMnCb4bmpGm4kyjVDc(value);
		int num = 4;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
		{
			num = 1;
		}
		while (true)
		{
			Action<h3GPi790NINi0SKF01rq> o0ufuuLP5c;
			switch (num)
			{
			case 4:
			{
				VvUfz2vwrDC.TryRemove(P_0, out var _);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
				{
					num = 0;
				}
				break;
			}
			case 1:
			{
				Activity jfa90bfCtOF = value.Jfa90bfCtOF;
				if (jfa90bfCtOF == null)
				{
					goto case 3;
				}
				jfa90bfCtOF.SetStatus(ActivityStatusCode.Error);
				num = 3;
				break;
			}
			case 3:
				value.Jfa90bfCtOF?.Dispose();
				return;
			default:
				if (IWWsTIb4NgxBmh3P4XEy(VvUfz2vwrDC) == 0)
				{
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
					{
						num = 2;
					}
					break;
				}
				goto IL_0027;
			case 2:
				{
					fcDaIGfua3ieQHnfpB9v.ClearMemory();
					goto IL_0027;
				}
				IL_0027:
				o0ufuuLP5c = O0ufuuLP5c8;
				if (o0ufuuLP5c == null)
				{
					goto case 1;
				}
				o0ufuuLP5c(new h3GPi790NINi0SKF01rq(value, _0020: false));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private static void scYfuciSfu4(t0g5x0HUeQ3nJK56KReg P_0)
	{
		if (!VvUfz2vwrDC.TryGetValue(P_0.qGsHUjjASwb(), out var value))
		{
			return;
		}
		value.qkNfzdKnifX(P_0.TC5HU7q9frO());
		value.H1Ofz6MgKbS(P_0.arDHUPDMIgG());
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
		{
			num = 1;
		}
		StringBuilder stringBuilder = default(StringBuilder);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				return;
			case 4:
			{
				if (zaHl1tb41hgmHNlIDGsk(P_0))
				{
					goto IL_00c0;
				}
				stringBuilder = new StringBuilder();
				int num2 = 2;
				num = num2;
				break;
			}
			case 0:
				return;
			case 2:
			{
				h0906KHWGPWh3jcGMAc5 h0906KHWGPWh3jcGMAc = new h0906KHWGPWh3jcGMAc5(P_0.Data);
				try
				{
					while (I1xyupb45SpRvg8lgFH1(h0906KHWGPWh3jcGMAc))
					{
						while (true)
						{
							zVZJmtHymfLn6rNDRE2e lastItem = h0906KHWGPWh3jcGMAc.LastItem;
							int num3 = 3;
							while (true)
							{
								switch (num3)
								{
								case 2:
									array = fcDaIGfua3ieQHnfpB9v.xWKfu45hbJu(lastItem.PTNHy78GPEx);
									num3 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
									{
										num3 = 1;
									}
									continue;
								case 3:
									if (lastItem == null)
									{
										goto end_IL_014d;
									}
									goto case 2;
								case 1:
								{
									if (array != null)
									{
										value.AgNfzCUZiJG().Add(lastItem.XN5Hyw3Qdk1, array);
									}
									else
									{
										stringBuilder.Append(lastItem.XN5Hyw3Qdk1 + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D01E3D));
									}
									t8QNqWfz9x1DweDKl161 t8QNqWfz9x1DweDKl = value;
									int num4 = t8QNqWfz9x1DweDKl.dYtfze6Lf8K();
									t8QNqWfz9x1DweDKl.EUYfzsSjV5L(num4 + 1);
									goto end_IL_014d;
								}
								}
								break;
							}
							continue;
							end_IL_014d:
							break;
						}
					}
				}
				finally
				{
					if (h0906KHWGPWh3jcGMAc != null)
					{
						VeVy30b4SQ7GEAypgAJG(h0906KHWGPWh3jcGMAc);
					}
				}
				if (kDnFifb4xOBgMi8tBH25(stringBuilder) <= 0)
				{
					LuyfuEteoF3(value);
				}
				else
				{
					yaNfuz1kUfk.mmKHcLJT2yU(iKCR2MHtemRfkSuS8bq4.XgtHtcp7olq(value.MTofziryBDr(), value.Symbol.ID, Eirhhgb4ens4Dww2tNPu(FDbb0Ub4LdWIWQZrnyeo(value.DataCycle)), y12hKxb4sSTnXB80cjUh(value), value.RepeatParam1, value.RepeatParam2, VOW49lb4XIc4oMpqKGO3(value), stringBuilder.ToString(), value.LQ5fzcyZ2h4()));
				}
				return;
			}
			case 1:
				{
					if (!tOipwCb4kB7DEagmPOCo(P_0))
					{
						num = 4;
						break;
					}
					goto IL_00c0;
				}
				IL_00c0:
				LuyfuEteoF3(value);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private static void CQwfujy9PCU(t0g5x0HUeQ3nJK56KReg P_0)
	{
		int num = 6;
		t8QNqWfz9x1DweDKl161 value = default(t8QNqWfz9x1DweDKl161);
		SortedDictionary<string, byte[]> sortedDictionary = default(SortedDictionary<string, byte[]>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (!VvUfz2vwrDC.TryGetValue(P_0.qGsHUjjASwb(), out value))
					{
						goto end_IL_0012;
					}
					if (!P_0.YBFHUdSpYL1())
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				default:
					LuyfuEteoF3(value);
					num2 = 3;
					break;
				case 1:
					if (zaHl1tb41hgmHNlIDGsk(P_0))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						sortedDictionary = value.AgNfzCUZiJG();
						num2 = 2;
					}
					break;
				case 4:
					if (sortedDictionary.Count == value.dYtfze6Lf8K())
					{
						dOHKE2b4QDKlTMlXKiQO(value);
					}
					return;
				case 2:
					if (!sortedDictionary.ContainsKey((string)t93TXUb4cc0cc6wgNG9j(P_0)))
					{
						byte[] array = (byte[])rTe5lmb4jYmoEKZyIGlh(P_0.Data);
						sortedDictionary.Add((string)t93TXUb4cc0cc6wgNG9j(P_0), array);
						t8QNqWfz9x1DweDKl161 t8QNqWfz9x1DweDKl = value;
						long num3 = O2ojlVb4E8OJ9XrhspPq(t8QNqWfz9x1DweDKl);
						byte[] array2 = P_0.Data;
						t8QNqWfz9x1DweDKl.ebJfzmmMJLw(num3 + ((array2 != null) ? array2.Length : 0));
						if (P_0.Cache && array != null)
						{
							fcDaIGfua3ieQHnfpB9v.fGZfulYnZwK(P_0.kCQHUruTLAt(), array);
							num2 = 4;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
							{
								num2 = 4;
							}
							break;
						}
					}
					goto case 4;
				case 3:
					return;
				case 5:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	private static void LuyfuEteoF3(t8QNqWfz9x1DweDKl161 P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				P_0.Jfa90bfCtOF?.Dispose();
				return;
			case 1:
			{
				VvUfz2vwrDC.TryRemove(P_0.MTofziryBDr(), out var _);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
			{
				if (VvUfz2vwrDC.Count == 0)
				{
					fcDaIGfua3ieQHnfpB9v.ClearMemory();
				}
				ActivitySource activitySource = m03fu8jxA9A;
				object name = EmIlDGb4dTk5Fscs4uX5(0x741B85CB ^ 0x741FB2B7);
				Activity jfa90bfCtOF = P_0.Jfa90bfCtOF;
				Activity? activity = activitySource.StartActivity((string)name, ActivityKind.Internal, (jfa90bfCtOF != null) ? ouoWvsb4gPS3pXvtn8rg(jfa90bfCtOF) : default(ActivityContext));
				bool flag = (P_0.ErQfzQiZ5ix() || P_0.OKofzRUZbvX()) && P_0.LQ5fzcyZ2h4();
				O0ufuuLP5c8?.Invoke(new h3GPi790NINi0SKF01rq(P_0, flag));
				if (flag)
				{
					DataManager.ClientRequestTicks((Symbol)JKOkaRb4RIrZkHUfH7rx(P_0), (string)bivsQrb46hqrk5XAFlms(P_0), P_0.bYPfzbUluTq(), customData: false);
				}
				if (activity == null)
				{
					goto case 3;
				}
				Nv1RsYb4M189ObF2CPkR(activity);
				num2 = 3;
				break;
			}
			case 2:
				JDGMnCb4bmpGm4kyjVDc(P_0);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static void v3xfuQZ0gOL(t0g5x0HUeQ3nJK56KReg P_0)
	{
		if (!VvUfz2vwrDC.TryGetValue(P_0.qGsHUjjASwb(), out var value))
		{
			return;
		}
		value.qkNfzdKnifX(P_0.TC5HU7q9frO());
		value.H1Ofz6MgKbS(hPXYGub4OHTUOkfPmRxC(P_0));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
		{
			num = 0;
		}
		StringBuilder stringBuilder = default(StringBuilder);
		iKCR2MHtemRfkSuS8bq4 iKCR2MHtemRfkSuS8bq = default(iKCR2MHtemRfkSuS8bq4);
		while (true)
		{
			switch (num)
			{
			case 3:
				if (stringBuilder.Length > 0)
				{
					iKCR2MHtemRfkSuS8bq = iKCR2MHtemRfkSuS8bq4.uD0HtETfO7N((string)d8JSbGb4WT0RpuuJVxrp(value), value.Symbol.ID, a04fuZWTOWT(value.DataCycle.CycleBase), value.Repeat, value.RepeatParam1, value.RepeatParam2, value.DataScale, stringBuilder.ToString(), cC3XUBb4tPriBKCnJwWa(value));
					num = 6;
					break;
				}
				slZfugXBXIs(value);
				return;
			case 1:
				sWkiXHb4qHUIrCowiMAP(value);
				return;
			case 4:
				MgbCcRb4UuQf9PtYfKXj(uAufz0HSpAC, iKCR2MHtemRfkSuS8bq, value);
				return;
			default:
				if (!P_0.YBFHUdSpYL1())
				{
					if (P_0.vq5HU6irH9J())
					{
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
						{
							num = 1;
						}
					}
					else
					{
						stringBuilder = new StringBuilder();
						num = 5;
					}
					break;
				}
				goto case 1;
			case 5:
			{
				h0906KHWGPWh3jcGMAc5 h0906KHWGPWh3jcGMAc = new h0906KHWGPWh3jcGMAc5(P_0.Data);
				try
				{
					while (h0906KHWGPWh3jcGMAc.Read())
					{
						while (true)
						{
							IL_0123:
							zVZJmtHymfLn6rNDRE2e lastItem = h0906KHWGPWh3jcGMAc.LastItem;
							if (lastItem == null)
							{
								break;
							}
							int num3 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
							{
								num3 = 0;
							}
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_00bd;
								case 2:
									goto IL_0123;
								}
								byte[] array = (byte[])SbRSBDb4Iq8Tqc9CpSV5(lastItem.PTNHy78GPEx);
								if (array != null)
								{
									value.AgNfzCUZiJG().Add(lastItem.XN5Hyw3Qdk1, array);
									num3 = 3;
									continue;
								}
								stringBuilder.Append(lastItem.XN5Hyw3Qdk1 + (string)EmIlDGb4dTk5Fscs4uX5(-1380525184 ^ -1380466250));
								num3 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
								{
									num3 = 0;
								}
								continue;
								end_IL_00bd:
								break;
							}
							t8QNqWfz9x1DweDKl161 t8QNqWfz9x1DweDKl = value;
							int num4 = t8QNqWfz9x1DweDKl.dYtfze6Lf8K();
							t8QNqWfz9x1DweDKl.EUYfzsSjV5L(num4 + 1);
							break;
						}
					}
				}
				finally
				{
					if (h0906KHWGPWh3jcGMAc == null)
					{
						int num5 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					else
					{
						((IDisposable)h0906KHWGPWh3jcGMAc).Dispose();
					}
				}
				goto case 3;
			}
			case 6:
				if (zhZBf5HI5x0qedOPCfJX.EONHIxYU95i(value))
				{
					int num2 = 4;
					num = num2;
					break;
				}
				yaNfuz1kUfk.mmKHcLJT2yU(iKCR2MHtemRfkSuS8bq);
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	private static void lLgfudk0ciy(t0g5x0HUeQ3nJK56KReg P_0)
	{
		int num = 6;
		int num2 = num;
		SortedDictionary<string, byte[]> sortedDictionary = default(SortedDictionary<string, byte[]>);
		byte[] array2 = default(byte[]);
		t8QNqWfz9x1DweDKl161 value = default(t8QNqWfz9x1DweDKl161);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 3:
				return;
			case 2:
				if (!sortedDictionary.ContainsKey(P_0.Date))
				{
					array2 = QMVfuVwcVPj(P_0.Data);
					sortedDictionary.Add(P_0.Date, array2);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				if (sortedDictionary.Count != value.dYtfze6Lf8K())
				{
					return;
				}
				sWkiXHb4qHUIrCowiMAP(value);
				num2 = 4;
				break;
			case 6:
				if (!VvUfz2vwrDC.TryGetValue(P_0.qGsHUjjASwb(), out value))
				{
					num2 = 5;
					break;
				}
				if (!P_0.YBFHUdSpYL1() && !P_0.vq5HU6irH9J())
				{
					sortedDictionary = value.AgNfzCUZiJG();
					num2 = 2;
					break;
				}
				sWkiXHb4qHUIrCowiMAP(value);
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				return;
			case 1:
			{
				t8QNqWfz9x1DweDKl161 t8QNqWfz9x1DweDKl = value;
				long num3 = t8QNqWfz9x1DweDKl.dvWfzKo0p5l();
				byte[] array = P_0.Data;
				t8QNqWfz9x1DweDKl.ebJfzmmMJLw(num3 + ((array != null) ? array.Length : 0));
				if (WmEUidb4TpvZ10BWpp4M(P_0) && array2 != null)
				{
					VMbQDjb4yBi75KGyLS1H(P_0.kCQHUruTLAt(), array2);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
			}
		}
	}

	private static void slZfugXBXIs(t8QNqWfz9x1DweDKl161 P_0)
	{
		P_0.JK7fzYPEtll();
		VvUfz2vwrDC.TryRemove(P_0.MTofziryBDr(), out var _);
		int num;
		if (IWWsTIb4NgxBmh3P4XEy(VvUfz2vwrDC) == 0)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_009d;
		IL_009d:
		ActivitySource activitySource = m03fu8jxA9A;
		object name = EmIlDGb4dTk5Fscs4uX5(0x7ADBF691 ^ 0x7ADFC123);
		Activity jfa90bfCtOF = P_0.Jfa90bfCtOF;
		Activity? activity = activitySource.StartActivity((string)name, ActivityKind.Internal, (jfa90bfCtOF != null) ? ouoWvsb4gPS3pXvtn8rg(jfa90bfCtOF) : default(ActivityContext));
		bool flag = (P_0.ErQfzQiZ5ix() || P_0.OKofzRUZbvX()) && P_0.LQ5fzcyZ2h4();
		O0ufuuLP5c8?.Invoke(new h3GPi790NINi0SKF01rq(P_0, flag));
		if (flag)
		{
			DataManager.ClientRequestTicks((Symbol)JKOkaRb4RIrZkHUfH7rx(P_0), (string)bivsQrb46hqrk5XAFlms(P_0), (string)VQmi6Eb4Veckh3wlG0HC(P_0), customData: false);
		}
		if (activity == null)
		{
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
			{
				num = 2;
			}
			goto IL_0009;
		}
		activity.Dispose();
		goto IL_0080;
		IL_0080:
		Activity jfa90bfCtOF2 = P_0.Jfa90bfCtOF;
		if (jfa90bfCtOF2 != null)
		{
			Nv1RsYb4M189ObF2CPkR(jfa90bfCtOF2);
		}
		return;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				hcBinrb4ZApuI1FfvpTc();
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc != 0)
				{
					num = 1;
				}
				continue;
			case 2:
				break;
			case 1:
				goto IL_009d;
			}
			break;
		}
		goto IL_0080;
	}

	private static void LuQfuRbP5iE(t0g5x0HUeQ3nJK56KReg P_0)
	{
		if (!VvUfz2vwrDC.TryGetValue(P_0.qGsHUjjASwb(), out var value))
		{
			return;
		}
		value.qkNfzdKnifX(X25vhkb4C9XYXS1m7bLJ(P_0));
		value.H1Ofz6MgKbS(hPXYGub4OHTUOkfPmRxC(P_0));
		StringBuilder stringBuilder = default(StringBuilder);
		int num;
		if (!P_0.YBFHUdSpYL1() && !zaHl1tb41hgmHNlIDGsk(P_0))
		{
			stringBuilder = new StringBuilder();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
			{
				num = 0;
			}
		}
		else
		{
			wAHfuMPD76p(value);
			num = 6;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 != 0)
			{
				num = 6;
			}
		}
		h0906KHWGPWh3jcGMAc5 h0906KHWGPWh3jcGMAc = default(h0906KHWGPWh3jcGMAc5);
		iKCR2MHtemRfkSuS8bq4 iKCR2MHtemRfkSuS8bq = default(iKCR2MHtemRfkSuS8bq4);
		zVZJmtHymfLn6rNDRE2e lastItem = default(zVZJmtHymfLn6rNDRE2e);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num)
			{
			default:
				h0906KHWGPWh3jcGMAc = new h0906KHWGPWh3jcGMAc5(P_0.Data);
				num = 3;
				continue;
			case 2:
				iKCR2MHtemRfkSuS8bq = iKCR2MHtemRfkSuS8bq4.uDmHtdKW9bf(value.MTofziryBDr(), ((Symbol)JKOkaRb4RIrZkHUfH7rx(value)).ID, Eirhhgb4ens4Dww2tNPu(FDbb0Ub4LdWIWQZrnyeo(value.DataCycle)), y12hKxb4sSTnXB80cjUh(value), value.RepeatParam1, value.RepeatParam2, value.DataScale, value.BarType, stringBuilder.ToString(), cC3XUBb4tPriBKCnJwWa(value));
				num = 5;
				continue;
			case 1:
				uAufz0HSpAC.cP7HLtcUURX(iKCR2MHtemRfkSuS8bq, value);
				return;
			case 5:
				if (zhZBf5HI5x0qedOPCfJX.EONHIxYU95i(value))
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
					{
						num = 0;
					}
					continue;
				}
				yaNfuz1kUfk.mmKHcLJT2yU(iKCR2MHtemRfkSuS8bq);
				return;
			case 6:
				return;
			case 4:
				break;
			case 3:
				try
				{
					while (true)
					{
						IL_0276:
						int num2;
						if (I1xyupb45SpRvg8lgFH1(h0906KHWGPWh3jcGMAc))
						{
							lastItem = h0906KHWGPWh3jcGMAc.LastItem;
							if (lastItem == null)
							{
								continue;
							}
							array = (byte[])SbRSBDb4Iq8Tqc9CpSV5(lastItem.PTNHy78GPEx);
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
							{
								num2 = 1;
							}
						}
						else
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 != 0)
							{
								num2 = 0;
							}
						}
						while (true)
						{
							switch (num2)
							{
							default:
								goto end_IL_0199;
							case 3:
							{
								t8QNqWfz9x1DweDKl161 t8QNqWfz9x1DweDKl = value;
								int num3 = LI6ZgJb4rqdfClek8Zca(t8QNqWfz9x1DweDKl);
								t8QNqWfz9x1DweDKl.EUYfzsSjV5L(num3 + 1);
								break;
							}
							case 2:
								goto IL_0227;
							case 1:
								if (array == null)
								{
									goto IL_0227;
								}
								value.AgNfzCUZiJG().Add(lastItem.XN5Hyw3Qdk1, array);
								goto case 3;
							case 0:
								goto end_IL_0199;
							}
							goto IL_0276;
							IL_0227:
							stringBuilder.Append(lastItem.XN5Hyw3Qdk1 + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -529984977));
							num2 = 3;
							continue;
							end_IL_0199:
							break;
						}
						break;
					}
				}
				finally
				{
					if (h0906KHWGPWh3jcGMAc == null)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					else
					{
						((IDisposable)h0906KHWGPWh3jcGMAc).Dispose();
					}
				}
				break;
			}
			if (stringBuilder.Length <= 0)
			{
				break;
			}
			num = 2;
		}
		VkkyUMb4K8MF6Lw0sueS(value);
	}

	private static void oFafu6F4jy5(t0g5x0HUeQ3nJK56KReg P_0)
	{
		int num = 6;
		SortedDictionary<string, byte[]> sortedDictionary = default(SortedDictionary<string, byte[]>);
		t8QNqWfz9x1DweDKl161 value = default(t8QNqWfz9x1DweDKl161);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 5:
					return;
				case 1:
					if (P_0.vq5HU6irH9J())
					{
						goto IL_00bc;
					}
					sortedDictionary = value.AgNfzCUZiJG();
					if (!sortedDictionary.ContainsKey(P_0.Date))
					{
						array = (byte[])rTe5lmb4jYmoEKZyIGlh(HfNuY5b4mdkr7FfqNTAK(P_0));
						sortedDictionary.Add((string)t93TXUb4cc0cc6wgNG9j(P_0), array);
						t8QNqWfz9x1DweDKl161 t8QNqWfz9x1DweDKl = value;
						long num3 = t8QNqWfz9x1DweDKl.dvWfzKo0p5l();
						object obj = HfNuY5b4mdkr7FfqNTAK(P_0);
						t8QNqWfz9x1DweDKl.ebJfzmmMJLw(num3 + ((obj != null) ? ((Array)obj).Length : 0));
						if (P_0.Cache && array != null)
						{
							goto end_IL_0012;
						}
					}
					goto IL_006d;
				case 2:
					return;
				case 4:
					return;
				case 0:
					return;
				case 3:
					fcDaIGfua3ieQHnfpB9v.fGZfulYnZwK(P_0.kCQHUruTLAt(), array);
					goto IL_006d;
				case 6:
					{
						if (VvUfz2vwrDC.TryGetValue(P_0.qGsHUjjASwb(), out value))
						{
							if (!P_0.YBFHUdSpYL1())
							{
								goto case 1;
							}
							goto IL_00bc;
						}
						num2 = 5;
						break;
					}
					IL_00bc:
					wAHfuMPD76p(value);
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
					{
						num2 = 2;
					}
					break;
					IL_006d:
					if (sortedDictionary.Count != value.dYtfze6Lf8K())
					{
						num2 = 4;
						break;
					}
					wAHfuMPD76p(value);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	private static void wAHfuMPD76p(t8QNqWfz9x1DweDKl161 P_0)
	{
		JDGMnCb4bmpGm4kyjVDc(P_0);
		VvUfz2vwrDC.TryRemove((string)d8JSbGb4WT0RpuuJVxrp(P_0), out var _);
		int num;
		if (IWWsTIb4NgxBmh3P4XEy(VvUfz2vwrDC) == 0)
		{
			fcDaIGfua3ieQHnfpB9v.ClearMemory();
			num = 3;
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
			{
				num = 0;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 2:
			{
				Activity jfa90bfCtOF2 = P_0.Jfa90bfCtOF;
				if (jfa90bfCtOF2 == null)
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
					{
						num = 1;
					}
					break;
				}
				jfa90bfCtOF2.Dispose();
				return;
			}
			default:
			{
				ActivitySource activitySource = m03fu8jxA9A;
				string name = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6EC99CAF ^ 0x6ECDAB41);
				Activity jfa90bfCtOF = P_0.Jfa90bfCtOF;
				Activity? activity = activitySource.StartActivity(name, ActivityKind.Internal, (jfa90bfCtOF != null) ? ouoWvsb4gPS3pXvtn8rg(jfa90bfCtOF) : default(ActivityContext));
				bool flag = (P_0.ErQfzQiZ5ix() || eA3TjXb4h84HodB5OSLs(P_0)) && cC3XUBb4tPriBKCnJwWa(P_0);
				O0ufuuLP5c8?.Invoke(new h3GPi790NINi0SKF01rq(P_0, flag));
				if (flag)
				{
					DataManager.ClientRequestTicks(P_0.Symbol, P_0.UyTfz4sb9ku(), P_0.bYPfzbUluTq(), customData: false);
				}
				if (activity == null)
				{
					goto case 2;
				}
				Nv1RsYb4M189ObF2CPkR(activity);
				num = 2;
				break;
			}
			case 1:
				return;
			}
		}
	}

	private static void g9afuOy5TZ4(t0g5x0HUeQ3nJK56KReg P_0)
	{
		int num = 8;
		int num2 = num;
		SortedDictionary<string, byte[]> sortedDictionary = default(SortedDictionary<string, byte[]>);
		t8QNqWfz9x1DweDKl161 value = default(t8QNqWfz9x1DweDKl161);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 1:
				if (!zaHl1tb41hgmHNlIDGsk(P_0))
				{
					sortedDictionary = value.AgNfzCUZiJG();
					if (!sortedDictionary.ContainsKey(P_0.Date))
					{
						sortedDictionary.Add((string)t93TXUb4cc0cc6wgNG9j(P_0), P_0.Data);
						t8QNqWfz9x1DweDKl161 t8QNqWfz9x1DweDKl = value;
						long num3 = t8QNqWfz9x1DweDKl.dvWfzKo0p5l();
						byte[] array = P_0.Data;
						t8QNqWfz9x1DweDKl.ebJfzmmMJLw(num3 + ((array != null) ? array.Length : 0));
						num2 = 4;
						break;
					}
					goto case 4;
				}
				goto IL_0167;
			case 8:
				if (VvUfz2vwrDC.TryGetValue(P_0.qGsHUjjASwb(), out value))
				{
					VvUfz2vwrDC.TryRemove(value.MTofziryBDr(), out var _);
					num2 = 6;
				}
				else
				{
					num2 = 7;
				}
				break;
			default:
				value.H1Ofz6MgKbS(P_0.arDHUPDMIgG());
				if (!P_0.YBFHUdSpYL1())
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_0167;
			case 6:
				if (VvUfz2vwrDC.Count == 0)
				{
					hcBinrb4ZApuI1FfvpTc();
					num2 = 5;
					break;
				}
				goto case 5;
			case 5:
				value.qkNfzdKnifX(P_0.TC5HU7q9frO());
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (sortedDictionary.Count != P_0.TiZHUUGZqqo())
				{
					return;
				}
				goto IL_0167;
			case 2:
			{
				Activity? activity = m03fu8jxA9A.StartActivity((string)EmIlDGb4dTk5Fscs4uX5(-1841489831 ^ -1841749893), ActivityKind.Internal, value.Jfa90bfCtOF?.Context ?? default(ActivityContext));
				bool flag = (cIqPQWb4wSi2bpigyo0e(value) || value.OKofzRUZbvX()) && value.LQ5fzcyZ2h4();
				O0ufuuLP5c8?.Invoke(new h3GPi790NINi0SKF01rq(value, flag));
				if (flag)
				{
					DataManager.ClientRequestTicks(value.Symbol, value.UyTfz4sb9ku(), (string)VQmi6Eb4Veckh3wlG0HC(value), customData: true);
				}
				if (activity != null)
				{
					Nv1RsYb4M189ObF2CPkR(activity);
				}
				Activity jfa90bfCtOF = value.Jfa90bfCtOF;
				if (jfa90bfCtOF != null)
				{
					Nv1RsYb4M189ObF2CPkR(jfa90bfCtOF);
					return;
				}
				num2 = 3;
				break;
			}
			case 3:
				return;
				IL_0167:
				value.JK7fzYPEtll();
				num2 = 2;
				break;
			}
		}
	}

	public static void juPfuqdenpe(string P_0 = null)
	{
		uAufz0HSpAC.tT6HLyTvMjw(P_0);
	}

	public static void QtCfuI0uZUQ(string P_0)
	{
		if (!string.IsNullOrEmpty(P_0))
		{
			eKafuApTgZC.TryAdd(P_0, P_0);
		}
	}

	public static void BrHfuWeREBg(string P_0, string P_1, string P_2, Symbol P_3, DataCycle P_4, int P_5)
	{
		if (P_3 == null)
		{
			return;
		}
		DateTime? endDate = default(DateTime?);
		while (P_4 != null)
		{
			t8QNqWfz9x1DweDKl161 t8QNqWfz9x1DweDKl = new t8QNqWfz9x1DweDKl161(P_0, P_1, P_2, (jRw7Dn90c0fQ7x3w42EX)1, P_3, P_4, P_5, null);
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
			{
				num = 3;
			}
			while (true)
			{
				switch (num)
				{
				default:
					bFofuP5dh4Q.Add(t8QNqWfz9x1DweDKl);
					cMnjf1b4AI33HRPiDIZv(uJmfu3SVArc, t4PfupO8B8t, 0);
					return;
				case 2:
					break;
				case 1:
					endDate = P_4.EndDate;
					if (!YAPniOb47GXIXbaJRdZC(endDate.Value.Date, TimeHelper.GetCurrDate(P_3.Exchange)))
					{
						goto default;
					}
					goto IL_00d8;
				case 4:
					if (endDate.HasValue)
					{
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
						{
							num = 1;
						}
						continue;
					}
					goto IL_00d8;
				case 3:
					{
						endDate = P_4.EndDate;
						num = 4;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
						{
							num = 3;
						}
						continue;
					}
					IL_00d8:
					B3IKJTb48oxBHuHr5NKf(t8QNqWfz9x1DweDKl, true);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	public static void WQWfutfLbDb(string P_0, string P_1, string P_2, Symbol P_3, DataCycle P_4, int P_5, axPjFZfun2Bno6s19iFs P_6 = null)
	{
		if (P_3 == null || P_4 == null)
		{
			return;
		}
		t8QNqWfz9x1DweDKl161 t8QNqWfz9x1DweDKl = new t8QNqWfz9x1DweDKl161(P_0, P_1, P_2, (jRw7Dn90c0fQ7x3w42EX)2, P_3, P_4, P_5);
		PDy35eb4PU0AiPQdluGn(t8QNqWfz9x1DweDKl, P_6);
		t8QNqWfz9x1DweDKl161 t8QNqWfz9x1DweDKl2 = t8QNqWfz9x1DweDKl;
		DateTime? endDate = P_4.EndDate;
		int num = 2;
		int num2 = num;
		DateTime value = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			default:
				if (value.Date >= EGltMAb4JxOlPFBN0UU6(P_3.Exchange))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_003d;
			case 2:
				if (endDate.HasValue)
				{
					endDate = P_4.EndDate;
					value = endDate.Value;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				return;
			case 1:
				{
					t8QNqWfz9x1DweDKl2.n0sfzjJRh4u(_0020: true);
					goto IL_003d;
				}
				IL_003d:
				bFofuP5dh4Q.Add(t8QNqWfz9x1DweDKl2);
				uJmfu3SVArc.Change(t4PfupO8B8t, 0);
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public static void BNOfuUJrnqX(string P_0, string P_1, string P_2, Symbol P_3, DataCycle P_4, int P_5, axPjFZfun2Bno6s19iFs P_6 = null)
	{
		if (P_3 == null)
		{
			return;
		}
		int num;
		t8QNqWfz9x1DweDKl161 t8QNqWfz9x1DweDKl2 = default(t8QNqWfz9x1DweDKl161);
		DateTime? endDate = default(DateTime?);
		if (P_4 == null)
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
			{
				num = 1;
			}
		}
		else
		{
			t8QNqWfz9x1DweDKl161 t8QNqWfz9x1DweDKl = new t8QNqWfz9x1DweDKl161(P_0, P_1, P_2, (jRw7Dn90c0fQ7x3w42EX)3, P_3, P_4, P_5);
			PDy35eb4PU0AiPQdluGn(t8QNqWfz9x1DweDKl, P_6);
			t8QNqWfz9x1DweDKl2 = t8QNqWfz9x1DweDKl;
			endDate = P_4.EndDate;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c != 0)
			{
				num = 0;
			}
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				if (endDate.Value.Date >= TimeHelper.GetCurrDate(P_3.Exchange))
				{
					break;
				}
				goto case 4;
			case 4:
				bFofuP5dh4Q.Add(t8QNqWfz9x1DweDKl2);
				cMnjf1b4AI33HRPiDIZv(uJmfu3SVArc, t4PfupO8B8t, 0);
				return;
			case 2:
				endDate = P_4.EndDate;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
				{
					num = 3;
				}
				continue;
			default:
				if (!endDate.HasValue)
				{
					break;
				}
				goto case 2;
			case 1:
				return;
			}
			B3IKJTb48oxBHuHr5NKf(t8QNqWfz9x1DweDKl2, true);
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
			{
				num = 0;
			}
		}
	}

	public static void YwQfuTmP4Lf(string P_0, string P_1, string P_2, Symbol P_3, DataCycle P_4, int P_5, ykUIZR9AvyGh9sCU0wPo P_6)
	{
		int num = 3;
		int num2 = num;
		DateTime value = default(DateTime);
		t8QNqWfz9x1DweDKl161 t8QNqWfz9x1DweDKl = default(t8QNqWfz9x1DweDKl161);
		DateTime? endDate = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (!YAPniOb47GXIXbaJRdZC(value.Date, TimeHelper.GetCurrDate((string)Ve0aVTb4FUpVswOmnrFD(P_3))))
				{
					break;
				}
				goto default;
			case 2:
				if (P_4 == null)
				{
					return;
				}
				t8QNqWfz9x1DweDKl = new t8QNqWfz9x1DweDKl161(P_0, P_1, P_2, (jRw7Dn90c0fQ7x3w42EX)4, P_3, P_4, P_5, P_6);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				if (endDate.HasValue)
				{
					endDate = P_4.EndDate;
					value = endDate.Value;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto default;
			case 1:
				endDate = P_4.EndDate;
				num2 = 4;
				continue;
			case 3:
				if (P_3 == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
				{
					num2 = 2;
				}
				continue;
			default:
				B3IKJTb48oxBHuHr5NKf(t8QNqWfz9x1DweDKl, true);
				break;
			}
			break;
		}
		bFofuP5dh4Q.Add(t8QNqWfz9x1DweDKl);
		cMnjf1b4AI33HRPiDIZv(uJmfu3SVArc, t4PfupO8B8t, 0);
	}

	private static void RequestData(t8QNqWfz9x1DweDKl161 request)
	{
		int num = 32;
		Stopwatch stopwatch = default(Stopwatch);
		iKCR2MHtemRfkSuS8bq4 iKCR2MHtemRfkSuS8bq = default(iKCR2MHtemRfkSuS8bq4);
		DateTime? dateTime = default(DateTime?);
		string text = default(string);
		string text2 = default(string);
		Activity activity = default(Activity);
		iKCR2MHtemRfkSuS8bq4 iKCR2MHtemRfkSuS8bq3 = default(iKCR2MHtemRfkSuS8bq4);
		iKCR2MHtemRfkSuS8bq4 iKCR2MHtemRfkSuS8bq2 = default(iKCR2MHtemRfkSuS8bq4);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					request.Repeat = 1;
					goto IL_04f7;
				case 18:
					request.OvufzGAcApI(stopwatch.ElapsedMilliseconds);
					num2 = 6;
					continue;
				case 5:
					if (request.lDQfzxjl4mT() is RktveN9A29kC5WSbk87T)
					{
						num2 = 9;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
						{
							num2 = 22;
						}
						continue;
					}
					yaNfuz1kUfk.mmKHcLJT2yU(iKCR2MHtemRfkSuS8bq);
					goto IL_0443;
				case 9:
					dateTime = ((DataCycle)Mfyj5Nb4z6dHL2KrItB7(request)).StartDate;
					num2 = 2;
					continue;
				case 30:
					text = dateTime.Value.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1774602229 ^ -1774554469));
					goto IL_012d;
				case 24:
					if (oc8wSLbDoYoyQAUilobA(Mfyj5Nb4z6dHL2KrItB7(request)) == DataCycleDataType.ExtendedBars)
					{
						request.BarType = 2;
						num2 = 7;
						continue;
					}
					goto case 3;
				case 6:
					text = "";
					text2 = "";
					num2 = 9;
					continue;
				case 8:
					activity.AddEvent(new ActivityEvent(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x20B584D2 ^ 0x20B1BCA8)));
					return;
				case 12:
					request.Jfa90bfCtOF = activity;
					num2 = 18;
					continue;
				case 17:
					request.Repeat = 1;
					num2 = 26;
					continue;
				default:
					dateTime = ((DataCycle)Mfyj5Nb4z6dHL2KrItB7(request)).EndDate;
					text2 = dateTime.Value.ToString((string)EmIlDGb4dTk5Fscs4uX5(-2123795572 ^ -2123712228));
					goto IL_0803;
				case 15:
				case 26:
					iKCR2MHtemRfkSuS8bq3 = iKCR2MHtemRfkSuS8bq4.HkmHtjtYulE(request.MTofziryBDr(), ((Symbol)JKOkaRb4RIrZkHUfH7rx(request)).ID, a04fuZWTOWT(((DataCycle)Mfyj5Nb4z6dHL2KrItB7(request)).CycleBase), request.Repeat, request.RepeatParam1, UE58PNbDnMCUu5DAfxvO(request), VOW49lb4XIc4oMpqKGO3(request), text, text2, request.LQ5fzcyZ2h4(), (string)TGm8XNbDGtC7eJBmuBaZ(request));
					num2 = 21;
					continue;
				case 13:
					goto IL_0443;
				case 3:
				case 7:
					iKCR2MHtemRfkSuS8bq2 = (iKCR2MHtemRfkSuS8bq4)dUeGhDbDBlPLlltRPjeo(request.MTofziryBDr(), bGrkC5bDvDQE4BDySJsk(request.Symbol), Eirhhgb4ens4Dww2tNPu(request.DataCycle.CycleBase), y12hKxb4sSTnXB80cjUh(request), rfeiWbbD9VxstNhWhssW(request), request.RepeatParam2, request.DataScale, request.BarType, text, text2, cC3XUBb4tPriBKCnJwWa(request), request.Source);
					num2 = 11;
					continue;
				case 21:
					if (!zhZBf5HI5x0qedOPCfJX.EONHIxYU95i(request))
					{
						kniY2nbDYYPLYP7iRqjP(yaNfuz1kUfk, iKCR2MHtemRfkSuS8bq3);
						num2 = 13;
						continue;
					}
					num2 = 23;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
					{
						num2 = 14;
					}
					continue;
				case 25:
					return;
				case 11:
					if (zhZBf5HI5x0qedOPCfJX.EONHIxYU95i(request))
					{
						uAufz0HSpAC.cP7HLtcUURX(iKCR2MHtemRfkSuS8bq2, request);
						return;
					}
					yaNfuz1kUfk.mmKHcLJT2yU(iKCR2MHtemRfkSuS8bq2);
					goto IL_0443;
				case 19:
					goto end_IL_0012;
				case 27:
					activity?.SetTag(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F55E538 ^ 0x7F51DD54), Mfyj5Nb4z6dHL2KrItB7(request));
					if (activity != null)
					{
						activity.SetTag(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x746ED405 ^ 0x746FD095), VOW49lb4XIc4oMpqKGO3(request));
						num2 = 12;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 12;
				case 2:
					if (!dateTime.HasValue)
					{
						goto IL_012d;
					}
					goto case 29;
				case 16:
					goto IL_061f;
				case 23:
					uAufz0HSpAC.cP7HLtcUURX(iKCR2MHtemRfkSuS8bq3, request);
					return;
				case 22:
					uAufz0HSpAC.cP7HLtcUURX(iKCR2MHtemRfkSuS8bq, request);
					return;
				case 4:
					if (dateTime.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_0803;
				case 32:
					stopwatch = (Stopwatch)iDA10nb43iiRbsLPeXRm();
					num2 = 31;
					continue;
				case 20:
					goto IL_076c;
				case 31:
					stopwatch.Stop();
					if (!qL06XCb4pOTuN2H74dg9(yaNfuz1kUfk))
					{
						break;
					}
					if (!Loaded)
					{
						num2 = 14;
						continue;
					}
					if (VvUfz2vwrDC.ContainsKey((string)d8JSbGb4WT0RpuuJVxrp(request)))
					{
						return;
					}
					VvUfz2vwrDC.TryAdd(request.MTofziryBDr(), request);
					activity = m03fu8jxA9A.StartActivity(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xC1DDB3B ^ 0xC19E369));
					if (activity != null)
					{
						jnV6jjb4uwaCMCpGJEbh(activity, EmIlDGb4dTk5Fscs4uX5(-1346994499 ^ -1347002965), request.Type);
					}
					if (activity != null)
					{
						activity.SetTag(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24085900 ^ 0x2408466C), request.Symbol.Name);
						num2 = 27;
						continue;
					}
					goto case 27;
				case 29:
					dateTime = ((DataCycle)Mfyj5Nb4z6dHL2KrItB7(request)).StartDate;
					num2 = 30;
					continue;
				case 14:
					break;
				case 28:
					request.Repeat = ((request.Repeat % 5 != 0) ? 1 : 5);
					goto case 15;
				case 1:
					{
						request.Repeat = ((request.Repeat % 5 != 0) ? 1 : 5);
						goto IL_04f7;
					}
					IL_061f:
					if (FDbb0Ub4LdWIWQZrnyeo(request.DataCycle) != DataCycleBase.Hour)
					{
						if (FDbb0Ub4LdWIWQZrnyeo(Mfyj5Nb4z6dHL2KrItB7(request)) != DataCycleBase.Minute && request.DataCycle.CycleBase != DataCycleBase.Second)
						{
							num2 = 14;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
							{
								num2 = 15;
							}
							continue;
						}
						goto case 28;
					}
					num2 = 17;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
					{
						num2 = 5;
					}
					continue;
					IL_012d:
					dateTime = request.DataCycle.EndDate;
					num2 = 4;
					continue;
					IL_04f7:
					if (((DataCycle)Mfyj5Nb4z6dHL2KrItB7(request)).DataType == DataCycleDataType.BasicBars)
					{
						num2 = 19;
						continue;
					}
					goto case 24;
					IL_0443:
					if (activity == null)
					{
						return;
					}
					num2 = 8;
					continue;
					IL_0803:
					request.Repeat = Wev6FMbD0KROW9UgxidV(request.DataCycle);
					request.RepeatParam1 = xL5hr8bD2LGAF3EPdxEx(request.DataCycle);
					ywMWrxbDfU7eYSX88oaf(request, DYwwLsbDHPHL6XcELx3g(Mfyj5Nb4z6dHL2KrItB7(request)));
					switch (request.Type)
					{
					case (jRw7Dn90c0fQ7x3w42EX)3:
						break;
					case (jRw7Dn90c0fQ7x3w42EX)1:
						yaNfuz1kUfk.mmKHcLJT2yU(iKCR2MHtemRfkSuS8bq4.hsgHtXp9k6r(request.MTofziryBDr(), ((Symbol)JKOkaRb4RIrZkHUfH7rx(request)).ID, a04fuZWTOWT(request.DataCycle.CycleBase), request.Repeat, rfeiWbbD9VxstNhWhssW(request), UE58PNbDnMCUu5DAfxvO(request), request.DataScale, text, text2, request.LQ5fzcyZ2h4(), request.Source));
						goto IL_0443;
					default:
						goto IL_0443;
					case (jRw7Dn90c0fQ7x3w42EX)2:
						goto IL_061f;
					case (jRw7Dn90c0fQ7x3w42EX)4:
						goto IL_076c;
					}
					if (((DataCycle)Mfyj5Nb4z6dHL2KrItB7(request)).CycleBase != DataCycleBase.Hour)
					{
						if (request.DataCycle.CycleBase != DataCycleBase.Minute)
						{
							if (FDbb0Ub4LdWIWQZrnyeo(request.DataCycle) == DataCycleBase.Second)
							{
								num2 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
								{
									num2 = 1;
								}
								continue;
							}
							goto IL_04f7;
						}
						goto case 1;
					}
					num2 = 10;
					continue;
					IL_076c:
					iKCR2MHtemRfkSuS8bq = iKCR2MHtemRfkSuS8bq4.YMoHtgJbMFr(request.MTofziryBDr(), (string)bGrkC5bDvDQE4BDySJsk(JKOkaRb4RIrZkHUfH7rx(request)), Eirhhgb4ens4Dww2tNPu(request.DataCycle.CycleBase), y12hKxb4sSTnXB80cjUh(request), rfeiWbbD9VxstNhWhssW(request), request.RepeatParam2, request.DataScale, text, text2, xDy0aE9Aku9AKqgeCykH.Dup9A56Cr2W((ykUIZR9AvyGh9sCU0wPo)zMv7kWbDa0Oa5bX8cEuI(request)), request.Source);
					num2 = 5;
					continue;
				}
				PMcfzH4vOiU.Add(request);
				num2 = 25;
				continue;
				end_IL_0012:
				break;
			}
			request.BarType = 1;
			num = 3;
		}
	}

	[AsyncStateMachine(typeof(Q1vn58nJdAPbKNUlws88))]
	public static Task kWXfuyrkpiM(Symbol P_0, DataCycle P_1, long P_2)
	{
		Q1vn58nJdAPbKNUlws88 stateMachine = default(Q1vn58nJdAPbKNUlws88);
		stateMachine.oBwnJRKLuv3 = xUjE5ObDiRIx7aqARYpd();
		stateMachine.RfinJ64CGNt = P_0;
		stateMachine.yZwnJM51GBA = P_1;
		stateMachine.caHnJOBsZS4 = P_2;
		stateMachine.yZ6nJgAYNsF = -1;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return stateMachine.oBwnJRKLuv3.Task;
			}
			stateMachine.oBwnJRKLuv3.Start(ref stateMachine);
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
			{
				num = 1;
			}
		}
	}

	public static int a04fuZWTOWT(DataCycleBase P_0)
	{
		return P_0 switch
		{
			DataCycleBase.Second => 1, 
			DataCycleBase.Minute => 2, 
			DataCycleBase.Hour => 3, 
			DataCycleBase.Day => 4, 
			DataCycleBase.Week => 5, 
			DataCycleBase.Month => 6, 
			DataCycleBase.Year => 7, 
			DataCycleBase.Tick => 8, 
			DataCycleBase.Volume => 9, 
			DataCycleBase.Delta => 10, 
			DataCycleBase.Range => 11, 
			DataCycleBase.Renko => 12, 
			DataCycleBase.Reversal => 13, 
			_ => 0, 
		};
	}

	public static byte[] QMVfuVwcVPj(byte[] P_0)
	{
		int num = 1;
		int num2 = num;
		byte[] result = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (P_0 != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0081;
			case 2:
			{
				if (P_0[0] != 31 || P_0[1] != 139)
				{
					goto IL_0081;
				}
				MemoryStream memoryStream = new MemoryStream();
				try
				{
					using MemoryStream stream = new MemoryStream(P_0);
					using GZipStream gZipStream = new GZipStream(stream, CompressionMode.Decompress);
					gZipStream.CopyTo(memoryStream);
					memoryStream.Position = 0L;
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						_ => memoryStream.ToArray(), 
					};
				}
				finally
				{
					if (memoryStream != null)
					{
						VeVy30b4SQ7GEAypgAJG(memoryStream);
					}
				}
			}
			case 3:
				return result;
			default:
				{
					if (P_0.Length != 0 && P_0.Length >= 2)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto IL_0081;
				}
				IL_0081:
				return P_0;
			}
		}
	}

	static b8AkysfukSBAWXjMK6sm()
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					VvUfz2vwrDC = new ConcurrentDictionary<string, t8QNqWfz9x1DweDKl161>();
					PMcfzH4vOiU = new List<t8QNqWfz9x1DweDKl161>();
					num2 = 5;
					continue;
				case 5:
					return;
				case 4:
					stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					uJmfu3SVArc = new Timer(delegate
					{
						oiYfuF80lSV.Set();
					}, null, -1, -1);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					break;
				case 1:
					t4PfupO8B8t = 150;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			PVXAYcbDl8hUmTjtXCrD();
			YEdfuwrxu8F = new KeyValuePair<string, object>((string)EmIlDGb4dTk5Fscs4uX5(-82860344 ^ -82868770), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2063361985 ^ -2063097707));
			mgPfu7UWqbm = RJQ40bG97fddixgFUWO6.BkxG9FH1BRH;
			m03fu8jxA9A = new ActivitySource((string)EmIlDGb4dTk5Fscs4uX5(0x1A5F1B9E ^ 0x1A5B2334));
			eKafuApTgZC = new ConcurrentDictionary<string, string>();
			bFofuP5dh4Q = new BlockingCollection<t8QNqWfz9x1DweDKl161>();
			oc8fuJyYAv8 = new CancellationTokenSource();
			oiYfuF80lSV = new AutoResetEvent(initialState: false);
			num = 2;
		}
	}

	internal static void JxBLTBb4Yy2NoDMn9NVi(bool P_0)
	{
		Loaded = P_0;
	}

	internal static bool MDI0cvb4nTOImixq9Non()
	{
		return x8TcBmb49Jb3WMduA2My == null;
	}

	internal static b8AkysfukSBAWXjMK6sm t0dnTpb4GguHOGiHUHig()
	{
		return x8TcBmb49Jb3WMduA2My;
	}

	internal static object u1eHglb4oec80EWfvDWg()
	{
		return Application.Current;
	}

	internal static object OJD5kCb4vLp2sly49omF()
	{
		return Task.Factory;
	}

	internal static object vwmsbVb4BZ0Xn3vLbZpn(object P_0, object P_1, CancellationToken P_2, TaskCreationOptions P_3, object P_4)
	{
		return ((TaskFactory)P_0).StartNew((Action)P_1, P_2, P_3, (TaskScheduler)P_4);
	}

	internal static void Q9CNVXb4ak7DcTVv0r0U(object P_0)
	{
		((CancellationTokenSource)P_0).Cancel();
	}

	internal static bool re9JWAb4imoAAbdXe6Dj(object P_0)
	{
		return ((WaitHandle)P_0).WaitOne();
	}

	internal static bool Om7Donb4lEeYiSLkqXEh(object P_0)
	{
		return ((CancellationTokenSource)P_0).IsCancellationRequested;
	}

	internal static void QJ7wfHb44R2IC8qIgZJN(object P_0)
	{
		v3xfuQZ0gOL((t0g5x0HUeQ3nJK56KReg)P_0);
	}

	internal static void BZsk4Ib4DsQsFQBnf4T8(object P_0)
	{
		CQifuXvayYB((string)P_0);
	}

	internal static void JDGMnCb4bmpGm4kyjVDc(object P_0)
	{
		((t8QNqWfz9x1DweDKl161)P_0).JK7fzYPEtll();
	}

	internal static int IWWsTIb4NgxBmh3P4XEy(object P_0)
	{
		return ((ConcurrentDictionary<string, t8QNqWfz9x1DweDKl161>)P_0).Count;
	}

	internal static bool tOipwCb4kB7DEagmPOCo(object P_0)
	{
		return ((t0g5x0HUeQ3nJK56KReg)P_0).YBFHUdSpYL1();
	}

	internal static bool zaHl1tb41hgmHNlIDGsk(object P_0)
	{
		return ((t0g5x0HUeQ3nJK56KReg)P_0).vq5HU6irH9J();
	}

	internal static bool I1xyupb45SpRvg8lgFH1(object P_0)
	{
		return ((BinReader<zVZJmtHymfLn6rNDRE2e>)P_0).Read();
	}

	internal static void VeVy30b4SQ7GEAypgAJG(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static int kDnFifb4xOBgMi8tBH25(object P_0)
	{
		return ((StringBuilder)P_0).Length;
	}

	internal static DataCycleBase FDbb0Ub4LdWIWQZrnyeo(object P_0)
	{
		return ((DataCycle)P_0).CycleBase;
	}

	internal static int Eirhhgb4ens4Dww2tNPu(DataCycleBase P_0)
	{
		return a04fuZWTOWT(P_0);
	}

	internal static int y12hKxb4sSTnXB80cjUh(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).Repeat;
	}

	internal static int VOW49lb4XIc4oMpqKGO3(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).DataScale;
	}

	internal static object t93TXUb4cc0cc6wgNG9j(object P_0)
	{
		return ((t0g5x0HUeQ3nJK56KReg)P_0).Date;
	}

	internal static object rTe5lmb4jYmoEKZyIGlh(object P_0)
	{
		return QMVfuVwcVPj((byte[])P_0);
	}

	internal static long O2ojlVb4E8OJ9XrhspPq(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).dvWfzKo0p5l();
	}

	internal static void dOHKE2b4QDKlTMlXKiQO(object P_0)
	{
		LuyfuEteoF3((t8QNqWfz9x1DweDKl161)P_0);
	}

	internal static object EmIlDGb4dTk5Fscs4uX5(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static ActivityContext ouoWvsb4gPS3pXvtn8rg(object P_0)
	{
		return ((Activity)P_0).Context;
	}

	internal static object JKOkaRb4RIrZkHUfH7rx(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).Symbol;
	}

	internal static object bivsQrb46hqrk5XAFlms(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).UyTfz4sb9ku();
	}

	internal static void Nv1RsYb4M189ObF2CPkR(object P_0)
	{
		((Activity)P_0).Dispose();
	}

	internal static bool hPXYGub4OHTUOkfPmRxC(object P_0)
	{
		return ((t0g5x0HUeQ3nJK56KReg)P_0).arDHUPDMIgG();
	}

	internal static void sWkiXHb4qHUIrCowiMAP(object P_0)
	{
		slZfugXBXIs((t8QNqWfz9x1DweDKl161)P_0);
	}

	internal static object SbRSBDb4Iq8Tqc9CpSV5(object P_0)
	{
		return fcDaIGfua3ieQHnfpB9v.xWKfu45hbJu((string)P_0);
	}

	internal static object d8JSbGb4WT0RpuuJVxrp(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).MTofziryBDr();
	}

	internal static bool cC3XUBb4tPriBKCnJwWa(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).LQ5fzcyZ2h4();
	}

	internal static void MgbCcRb4UuQf9PtYfKXj(object P_0, object P_1, object P_2)
	{
		((tj7IVyHLIiNJqBQROZUd)P_0).cP7HLtcUURX((iKCR2MHtemRfkSuS8bq4)P_1, (t8QNqWfz9x1DweDKl161)P_2);
	}

	internal static bool WmEUidb4TpvZ10BWpp4M(object P_0)
	{
		return ((t0g5x0HUeQ3nJK56KReg)P_0).Cache;
	}

	internal static void VMbQDjb4yBi75KGyLS1H(object P_0, object P_1)
	{
		fcDaIGfua3ieQHnfpB9v.fGZfulYnZwK((string)P_0, (byte[])P_1);
	}

	internal static void hcBinrb4ZApuI1FfvpTc()
	{
		fcDaIGfua3ieQHnfpB9v.ClearMemory();
	}

	internal static object VQmi6Eb4Veckh3wlG0HC(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).bYPfzbUluTq();
	}

	internal static bool X25vhkb4C9XYXS1m7bLJ(object P_0)
	{
		return ((t0g5x0HUeQ3nJK56KReg)P_0).TC5HU7q9frO();
	}

	internal static int LI6ZgJb4rqdfClek8Zca(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).dYtfze6Lf8K();
	}

	internal static void VkkyUMb4K8MF6Lw0sueS(object P_0)
	{
		wAHfuMPD76p((t8QNqWfz9x1DweDKl161)P_0);
	}

	internal static object HfNuY5b4mdkr7FfqNTAK(object P_0)
	{
		return ((t0g5x0HUeQ3nJK56KReg)P_0).Data;
	}

	internal static bool eA3TjXb4h84HodB5OSLs(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).OKofzRUZbvX();
	}

	internal static bool cIqPQWb4wSi2bpigyo0e(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).ErQfzQiZ5ix();
	}

	internal static bool YAPniOb47GXIXbaJRdZC(DateTime P_0, DateTime P_1)
	{
		return P_0 >= P_1;
	}

	internal static void B3IKJTb48oxBHuHr5NKf(object P_0, bool P_1)
	{
		((t8QNqWfz9x1DweDKl161)P_0).n0sfzjJRh4u(P_1);
	}

	internal static bool cMnjf1b4AI33HRPiDIZv(object P_0, int P_1, int P_2)
	{
		return ((Timer)P_0).Change(P_1, P_2);
	}

	internal static void PDy35eb4PU0AiPQdluGn(object P_0, object P_1)
	{
		((t8QNqWfz9x1DweDKl161)P_0).EIbfz7Av9rA((axPjFZfun2Bno6s19iFs)P_1);
	}

	internal static DateTime EGltMAb4JxOlPFBN0UU6(object P_0)
	{
		return TimeHelper.GetCurrDate((string)P_0);
	}

	internal static object Ve0aVTb4FUpVswOmnrFD(object P_0)
	{
		return ((SymbolBase)P_0).Exchange;
	}

	internal static object iDA10nb43iiRbsLPeXRm()
	{
		return Stopwatch.StartNew();
	}

	internal static bool qL06XCb4pOTuN2H74dg9(object P_0)
	{
		return ((IPavdHHXuGgrKgtTe2T3)P_0).sjWHcuHPsbS();
	}

	internal static object jnV6jjb4uwaCMCpGJEbh(object P_0, object P_1, object P_2)
	{
		return ((Activity)P_0).SetTag((string)P_1, P_2);
	}

	internal static object Mfyj5Nb4z6dHL2KrItB7(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).DataCycle;
	}

	internal static int Wev6FMbD0KROW9UgxidV(object P_0)
	{
		return ((DataCycle)P_0).Repeat;
	}

	internal static int xL5hr8bD2LGAF3EPdxEx(object P_0)
	{
		return ((DataCycle)P_0).RepeatParam1;
	}

	internal static int DYwwLsbDHPHL6XcELx3g(object P_0)
	{
		return ((DataCycle)P_0).RepeatParam2;
	}

	internal static void ywMWrxbDfU7eYSX88oaf(object P_0, int P_1)
	{
		((t8QNqWfz9x1DweDKl161)P_0).RepeatParam2 = P_1;
	}

	internal static int rfeiWbbD9VxstNhWhssW(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).RepeatParam1;
	}

	internal static int UE58PNbDnMCUu5DAfxvO(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).RepeatParam2;
	}

	internal static object TGm8XNbDGtC7eJBmuBaZ(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).Source;
	}

	internal static void kniY2nbDYYPLYP7iRqjP(object P_0, object P_1)
	{
		((IPavdHHXuGgrKgtTe2T3)P_0).mmKHcLJT2yU((iKCR2MHtemRfkSuS8bq4)P_1);
	}

	internal static DataCycleDataType oc8wSLbDoYoyQAUilobA(object P_0)
	{
		return ((DataCycle)P_0).DataType;
	}

	internal static object bGrkC5bDvDQE4BDySJsk(object P_0)
	{
		return ((Symbol)P_0).ID;
	}

	internal static object dUeGhDbDBlPLlltRPjeo(object P_0, object P_1, int P_2, int P_3, int P_4, int P_5, int P_6, int P_7, object P_8, object P_9, bool P_10, object P_11)
	{
		return iKCR2MHtemRfkSuS8bq4.EdVHtQjJ8p0((string)P_0, (string)P_1, P_2, P_3, P_4, P_5, P_6, P_7, (string)P_8, (string)P_9, P_10, (string)P_11);
	}

	internal static object zMv7kWbDa0Oa5bX8cEuI(object P_0)
	{
		return ((t8QNqWfz9x1DweDKl161)P_0).lDQfzxjl4mT();
	}

	internal static AsyncTaskMethodBuilder xUjE5ObDiRIx7aqARYpd()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static void PVXAYcbDl8hUmTjtXCrD()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
