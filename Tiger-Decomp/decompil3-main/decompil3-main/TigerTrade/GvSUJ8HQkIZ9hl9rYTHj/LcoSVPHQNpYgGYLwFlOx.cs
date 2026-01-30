using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace GvSUJ8HQkIZ9hl9rYTHj;

[Obsolete("Use TigerTrade.Sockets.SocketClient")]
internal sealed class LcoSVPHQNpYgGYLwFlOx
{
	[CompilerGenerated]
	private readonly TcpClient wuaHQslXEb4;

	private static LcoSVPHQNpYgGYLwFlOx ltNAgoDdHTLKTNvOf84Z;

	[SpecialName]
	[CompilerGenerated]
	public TcpClient GRxHQStV9QZ()
	{
		return wuaHQslXEb4;
	}

	[SpecialName]
	public bool uYsHQLBKDk6()
	{
		try
		{
			return GRxHQStV9QZ()?.Connected ?? false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public LcoSVPHQNpYgGYLwFlOx(TcpClient P_0)
	{
		qVGEKIDdnsiArOpTaNHC();
		base._002Ector();
		wuaHQslXEb4 = P_0;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				GRxHQStV9QZ().NoDelay = true;
				GRxHQStV9QZ().Client.NoDelay = true;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public Task v4rHQ1Cyj5Y(byte[] P_0 = null)
	{
		if (GRxHQStV9QZ() != null && dZQB65DdGBsvoVTpc7Gn(GRxHQStV9QZ()))
		{
			int num = 2;
			int num2 = num;
			Task task = default(Task);
			byte[] array = default(byte[]);
			while (true)
			{
				switch (num2)
				{
				default:
					task = null;
					try
					{
						task = GRxHQStV9QZ().GetStream().WriteAsync(array, 0, array.Length);
					}
					catch (Exception ex)
					{
						d3XHQ5df44D((string)tRLqM1DdYMOpLZS00eXq(-490987856 ^ -490748066), ex);
					}
					goto case 1;
				case 1:
					return task ?? Task.FromResult(result: false);
				case 2:
					break;
				}
				if (P_0 == null || P_0.Length == 0)
				{
					break;
				}
				List<byte> list = new List<byte>(P_0.Length + 4);
				list.AddRange(BitConverter.GetBytes(P_0.Length));
				list.AddRange(P_0);
				array = list.ToArray();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c != 0)
				{
					num2 = 0;
				}
			}
		}
		return Task.FromResult(result: false);
	}

	private static void d3XHQ5df44D(string P_0, Exception P_1 = null)
	{
	}

	static LcoSVPHQNpYgGYLwFlOx()
	{
		v6uNBuDdoytIYJvPKi4G();
	}

	internal static bool LfDCUgDdf8xksJ9gRCak()
	{
		return ltNAgoDdHTLKTNvOf84Z == null;
	}

	internal static LcoSVPHQNpYgGYLwFlOx vTCGqXDd93kPXB98VPgb()
	{
		return ltNAgoDdHTLKTNvOf84Z;
	}

	internal static void qVGEKIDdnsiArOpTaNHC()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool dZQB65DdGBsvoVTpc7Gn(object P_0)
	{
		return ((TcpClient)P_0).Connected;
	}

	internal static object tRLqM1DdYMOpLZS00eXq(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void v6uNBuDdoytIYJvPKi4G()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
