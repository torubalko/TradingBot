using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace yfNCRpHQcVf2WUsqGglJ;

internal static class aMnSRyHQX6KthEOa784F
{
	[Serializable]
	[CompilerGenerated]
	private sealed class ECfhkhnrAF8ClhyhstWV
	{
		public static readonly ECfhkhnrAF8ClhyhstWV OTynrJ2hmAd;

		public static AsyncCallback QMLnrFw3xnA;

		internal static ECfhkhnrAF8ClhyhstWV wRwUSXNjvu7H6t2Qu8a6;

		static ECfhkhnrAF8ClhyhstWV()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			OTynrJ2hmAd = new ECfhkhnrAF8ClhyhstWV();
		}

		public ECfhkhnrAF8ClhyhstWV()
		{
			PVoPc2NjiHpyLyxVwAsf();
			base._002Ector();
		}

		internal void HVEnrP1UQpC(IAsyncResult iar)
		{
			TaskCompletionSource<bool> taskCompletionSource = (TaskCompletionSource<bool>)iar.AsyncState;
			try
			{
				((Socket)zH5oiVNjloYtWoWcdf00(taskCompletionSource.Task)).EndConnect(iar);
				taskCompletionSource.TrySetResult(result: true);
			}
			catch (Exception ex)
			{
				b3msBpNj4lDB6g6F9L2j(taskCompletionSource, ex);
			}
		}

		internal static bool aUOY8BNjBFccLkM1JcdP()
		{
			return wRwUSXNjvu7H6t2Qu8a6 == null;
		}

		internal static ECfhkhnrAF8ClhyhstWV q2f5ehNjaZXVkvOSkADh()
		{
			return wRwUSXNjvu7H6t2Qu8a6;
		}

		internal static void PVoPc2NjiHpyLyxVwAsf()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static object zH5oiVNjloYtWoWcdf00(object P_0)
		{
			return ((Task)P_0).AsyncState;
		}

		internal static bool b3msBpNj4lDB6g6F9L2j(object P_0, object P_1)
		{
			return ((TaskCompletionSource<bool>)P_0).TrySetException((Exception)P_1);
		}
	}

	private static aMnSRyHQX6KthEOa784F KCaQJKDdvi7fghKct8kZ;

	public static Task q30HQjgdWpq(this Socket P_0, IPAddress P_1, int P_2)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>(P_0);
		P_0.BeginConnect(P_1, P_2, delegate(IAsyncResult iar)
		{
			TaskCompletionSource<bool> taskCompletionSource2 = (TaskCompletionSource<bool>)iar.AsyncState;
			try
			{
				((Socket)ECfhkhnrAF8ClhyhstWV.zH5oiVNjloYtWoWcdf00(taskCompletionSource2.Task)).EndConnect(iar);
				taskCompletionSource2.TrySetResult(result: true);
			}
			catch (Exception ex)
			{
				ECfhkhnrAF8ClhyhstWV.b3msBpNj4lDB6g6F9L2j(taskCompletionSource2, ex);
			}
		}, taskCompletionSource);
		return taskCompletionSource.Task;
	}

	static aMnSRyHQX6KthEOa784F()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool s1pGxDDdByNa78VH2ets()
	{
		return KCaQJKDdvi7fghKct8kZ == null;
	}

	internal static aMnSRyHQX6KthEOa784F t4EMmADdaHRrhTPVTkri()
	{
		return KCaQJKDdvi7fghKct8kZ;
	}
}
