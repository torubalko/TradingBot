using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using r19VrrY6urN3CSj6U03f;
using x97CE55GhEYKgt7TSVZT;

namespace F7fL8iY6KuWEb91ZVDrv;

internal class MwkhAOY6rI1NhC5OsMmu
{
	private readonly byte[] Hc2Y6FoFDrn;

	[CompilerGenerated]
	private readonly TcpClient O23Y63EOQtq;

	internal static MwkhAOY6rI1NhC5OsMmu oMJL7CSeCBi6RCcN3loA;

	public bool IsConnected
	{
		get
		{
			if (yGaY671cuAo() != null)
			{
				return yGaY671cuAo().Connected;
			}
			return false;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public TcpClient yGaY671cuAo()
	{
		return O23Y63EOQtq;
	}

	[SpecialName]
	public string PnIY6AJA1xK()
	{
		if (yGaY671cuAo() == null)
		{
			return null;
		}
		return (string)TjfXmYSehOFSZEuryHtx(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-624753169 ^ -624799329), ((Socket)EBkPNiSemBgKu6Uj8X8H(yGaY671cuAo())).RemoteEndPoint);
	}

	public MwkhAOY6rI1NhC5OsMmu(TcpClient P_0, byte[] P_1)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 != 0)
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
			O23Y63EOQtq = P_0;
			isQDdASewc6pj1FE7BeN(yGaY671cuAo(), true);
			yGaY671cuAo().Client.NoDelay = true;
			Hc2Y6FoFDrn = P_1;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
			{
				num = 1;
			}
		}
	}

	public Task nhWY6mAD8yf(byte[] P_0 = null)
	{
		if (yGaY671cuAo() != null)
		{
			int num;
			List<byte> list = default(List<byte>);
			if (!yGaY671cuAo().Connected)
			{
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d != 0)
				{
					num = 3;
				}
			}
			else
			{
				list = new List<byte>();
				num = 2;
			}
			Task result = default(Task);
			byte[] array = default(byte[]);
			while (true)
			{
				switch (num)
				{
				case 1:
					try
					{
						result = ((Stream)pfvdLXSe7cpchPr4l0fQ(yGaY671cuAo())).WriteAsync(array, 0, array.Length);
					}
					catch (Exception ex)
					{
						TfyY6w01uJ7(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x50C1C840 ^ 0x50C09C3A), ex);
					}
					return result;
				case 2:
					if (P_0 != null && P_0.Length != 0)
					{
						list.AddRange(P_0);
					}
					list.AddRange(Hc2Y6FoFDrn);
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 != 0)
					{
						num = 0;
					}
					continue;
				default:
					array = list.ToArray();
					result = null;
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
					{
						num = 0;
					}
					continue;
				case 3:
					break;
				}
				break;
			}
		}
		return null;
	}

	public Task tOOY6hlJvf8(string P_0)
	{
		Task result = null;
		if (!vUpwd0Se8CeesEhhEWuR(P_0))
		{
			result = nhWY6mAD8yf((byte[])HwtXdUSeAPZhDvl2dwnd(P_0));
		}
		return result;
	}

	private static void TfyY6w01uJ7(string P_0, Exception P_1 = null)
	{
		Console.WriteLine(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1841489831 ^ -1841541891), P_0, P_1));
	}

	static MwkhAOY6rI1NhC5OsMmu()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		hw9E4pSeP0PpqRZvNsIK();
	}

	internal static object EBkPNiSemBgKu6Uj8X8H(object P_0)
	{
		return ((TcpClient)P_0).Client;
	}

	internal static object TjfXmYSehOFSZEuryHtx(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static bool ORMVhOSer5Pejm4qR1kl()
	{
		return oMJL7CSeCBi6RCcN3loA == null;
	}

	internal static MwkhAOY6rI1NhC5OsMmu pIB4x0SeKhnGbec6rW0k()
	{
		return oMJL7CSeCBi6RCcN3loA;
	}

	internal static void isQDdASewc6pj1FE7BeN(object P_0, bool P_1)
	{
		((TcpClient)P_0).NoDelay = P_1;
	}

	internal static object pfvdLXSe7cpchPr4l0fQ(object P_0)
	{
		return ((TcpClient)P_0).GetStream();
	}

	internal static bool vUpwd0Se8CeesEhhEWuR(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object HwtXdUSeAPZhDvl2dwnd(object P_0)
	{
		return qDThctY6paCd6SuDnjQo.FvkY6zifoOT((string)P_0);
	}

	internal static void hw9E4pSeP0PpqRZvNsIK()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
