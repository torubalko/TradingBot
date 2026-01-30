using System;
using System.Runtime.InteropServices;
using EDugZvNwF6e5LYsQZ3C5;
using nff6NvN8pYC4xeKDOd05;

namespace TOoRACGHtuJUumeRKpC2;

public static class AogQRbGHWSbjV05POjjW
{
	public struct BphUpWGnnSwS1WTtDHSH
	{
		public uint kTWGnG8ewqs;

		public uint yymGnYarT4F;
	}

	public delegate void zvaRp2GnoUKQmXfgVlwk(uint uID, uint uMsg, uint dwUser, uint dw1, uint dw2);

	public delegate void sVkrbiGnvAi9VokGCvY5(IntPtr lpParameter, bool TimerOrWaitFired);

	private static AogQRbGHWSbjV05POjjW om1NEYk2zbtuZjUC4CTg;

	[DllImport("winmm.dll", EntryPoint = "timeGetDevCaps")]
	public static extern uint CtCGHUEdAtB(ref BphUpWGnnSwS1WTtDHSH P_0, uint P_1);

	[DllImport("winmm.dll", EntryPoint = "timeBeginPeriod")]
	public static extern uint FAPGHTwtNHB(uint P_0);

	[DllImport("winmm.dll", EntryPoint = "timeEndPeriod")]
	public static extern uint a4ZGHy0A748(uint P_0);

	[DllImport("winmm.dll", EntryPoint = "timeSetEvent")]
	public static extern uint a8sGHZqaTyH(uint P_0, uint P_1, zvaRp2GnoUKQmXfgVlwk P_2, IntPtr P_3, uint P_4);

	[DllImport("winmm.dll", EntryPoint = "timeKillEvent")]
	public static extern uint kHXGHVWKJfi(uint P_0);

	[DllImport("kernel32.dll", EntryPoint = "CreateTimerQueueTimer")]
	public static extern bool U3pGHCcinH9(ref IntPtr P_0, IntPtr P_1, sVkrbiGnvAi9VokGCvY5 P_2, IntPtr P_3, uint P_4, uint P_5, uint P_6);

	[DllImport("kernel32.dll", EntryPoint = "DeleteTimerQueueTimer")]
	public static extern bool ysFGHrY7l4x(IntPtr P_0, IntPtr P_1, IntPtr P_2);

	public static uint CDhGHKNIsM4(int P_0)
	{
		BphUpWGnnSwS1WTtDHSH structure = default(BphUpWGnnSwS1WTtDHSH);
		CtCGHUEdAtB(ref structure, (uint)Marshal.SizeOf(structure));
		uint num = LkwXUUkHHsMd9onsZyQS(Math.Max(structure.kTWGnG8ewqs, (uint)P_0), structure.yymGnYarT4F);
		FAPGHTwtNHB(num);
		return num;
	}

	public static void w5dGHmqL6EE(uint P_0)
	{
		a4ZGHy0A748(P_0);
	}

	static AogQRbGHWSbjV05POjjW()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static uint LkwXUUkHHsMd9onsZyQS(uint P_0, uint P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static bool z4wObkkH0adg6dTRme4T()
	{
		return om1NEYk2zbtuZjUC4CTg == null;
	}

	internal static AogQRbGHWSbjV05POjjW NvvsKWkH2fUfk01K8Kbk()
	{
		return om1NEYk2zbtuZjUC4CTg;
	}
}
