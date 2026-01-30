using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BfZtb759KlUg4482QKym;
using dgZJY3GhircmyNVV0iAS;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace r19VrrY6urN3CSj6U03f;

[wxMJrmGhaoZN9BPmFRb2]
internal static class qDThctY6paCd6SuDnjQo
{
	[Serializable]
	[CompilerGenerated]
	private sealed class WgIZ7BatiHOptJJnXd0w
	{
		public static readonly WgIZ7BatiHOptJJnXd0w C6Pat4DRvOe;

		public static AsyncCallback nN4atDlZbVJ;

		internal static WgIZ7BatiHOptJJnXd0w MHmAm8L25a0MNTyyQNHe;

		static WgIZ7BatiHOptJJnXd0w()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			C6Pat4DRvOe = new WgIZ7BatiHOptJJnXd0w();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public WgIZ7BatiHOptJJnXd0w()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal void IFhatlLLRWY(IAsyncResult iar)
		{
			TaskCompletionSource<bool> taskCompletionSource = (TaskCompletionSource<bool>)iar.AsyncState;
			try
			{
				((Socket)taskCompletionSource.Task.AsyncState).EndConnect(iar);
				taskCompletionSource.TrySetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource.TrySetException(exception);
			}
		}

		internal static bool NQCIciL2SaMUUrTNoDH1()
		{
			return MHmAm8L25a0MNTyyQNHe == null;
		}

		internal static WgIZ7BatiHOptJJnXd0w tpMfJyL2xGySX53dtbcn()
		{
			return MHmAm8L25a0MNTyyQNHe;
		}
	}

	private static qDThctY6paCd6SuDnjQo rdHdMtSeJSc3Dht1ujKo;

	[wxMJrmGhaoZN9BPmFRb2]
	public static byte[] FvkY6zifoOT(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return null;
		}
		return Encoding.ASCII.GetBytes(P_0);
	}

	[wxMJrmGhaoZN9BPmFRb2]
	public static string sG1YM0qQTIw(byte[] P_0)
	{
		if (P_0 == null || P_0.Length == 0)
		{
			return null;
		}
		return Encoding.ASCII.GetString(P_0);
	}

	[wxMJrmGhaoZN9BPmFRb2]
	public static string b5EYM2cpZR8(List<byte> P_0)
	{
		if (P_0 == null || P_0.Count == 0)
		{
			return null;
		}
		return sG1YM0qQTIw(P_0.ToArray());
	}

	[wxMJrmGhaoZN9BPmFRb2]
	public static Task cpYYMHZ0vN2(Socket P_0, IPAddress P_1, int P_2)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>(P_0);
		P_0.BeginConnect(P_1, P_2, delegate(IAsyncResult iar)
		{
			TaskCompletionSource<bool> taskCompletionSource2 = (TaskCompletionSource<bool>)iar.AsyncState;
			try
			{
				((Socket)taskCompletionSource2.Task.AsyncState).EndConnect(iar);
				taskCompletionSource2.TrySetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource2.TrySetException(exception);
			}
		}, taskCompletionSource);
		return taskCompletionSource.Task;
	}

	static qDThctY6paCd6SuDnjQo()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool jF0UIZSeFhPFJPkiiZHk()
	{
		return rdHdMtSeJSc3Dht1ujKo == null;
	}

	internal static qDThctY6paCd6SuDnjQo tyBP4fSe3KcrRV1j5EYC()
	{
		return rdHdMtSeJSc3Dht1ujKo;
	}
}
