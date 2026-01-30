using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using e8uAwsHRUSBpJlZjY5ZZ;
using ECOEgqlSad8NUJZ2Dr9n;
using EyD6NKGhRYBSlyBqPfrJ;
using TuAMtrl1Nd3XoZQQUXf0;

namespace PRFWWXHRiRJkA5aE4wSU;

public class eXgu2DHRaLyQBZFG8q30
{
	private enum BdKLXYnKdmL7ApA3YNii
	{

	}

	[CompilerGenerated]
	private long rXNHRgWwxh6;

	private byte[] pNUHR6C3DRm;

	private DateTime FBZHRIZ5ds1;

	private readonly string OqhHRWa2vpZ;

	internal static eXgu2DHRaLyQBZFG8q30 xYu9EfDgWu6vdkr0fTbD;

	private long Duration
	{
		[CompilerGenerated]
		get
		{
			return rXNHRgWwxh6;
		}
		[CompilerGenerated]
		set
		{
			rXNHRgWwxh6 = num;
		}
	}

	private BdKLXYnKdmL7ApA3YNii Mode => (byte)(pNUHR6C3DRm[0] & 7) switch
	{
		1 => (BdKLXYnKdmL7ApA3YNii)0, 
		2 => (BdKLXYnKdmL7ApA3YNii)1, 
		3 => (BdKLXYnKdmL7ApA3YNii)2, 
		4 => (BdKLXYnKdmL7ApA3YNii)3, 
		5 => (BdKLXYnKdmL7ApA3YNii)4, 
		_ => (BdKLXYnKdmL7ApA3YNii)5, 
	};

	[SpecialName]
	private DateTime OSSHRLgdfn7()
	{
		return DlGHRlb21xj(k14HR4gE1D1(24));
	}

	[SpecialName]
	private DateTime DDmHRslSDpo()
	{
		DateTime dateTime = DlGHRlb21xj(k14HR4gE1D1(32));
		TimeSpan utcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now);
		return dateTime + utcOffset;
	}

	[SpecialName]
	private DateTime HpBHRcVDCL0()
	{
		DateTime dateTime = rEJInCDgTntVjh9V2wKj(k14HR4gE1D1(40));
		TimeSpan utcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now);
		return dateTime + utcOffset;
	}

	[SpecialName]
	private void doSHRjyIVHm(DateTime P_0)
	{
		IFtHRDcJrBB(40, P_0);
	}

	[SpecialName]
	private long wqfHRQ1Ui32()
	{
		return (long)((DDmHRslSDpo() - OSSHRLgdfn7() + vK5DSFDgyXsuVaBEFqmK(HpBHRcVDCL0(), FBZHRIZ5ds1)).TotalMilliseconds / 2.0);
	}

	private static DateTime DlGHRlb21xj(ulong P_0)
	{
		TimeSpan timeSpan = TimeSpan.FromMilliseconds(P_0);
		return A4lDNaDgZA9HOZ2gry22(new DateTime(1900, 1, 1), timeSpan);
	}

	private ulong k14HR4gE1D1(byte P_0)
	{
		ulong num = 0uL;
		ulong num2 = 0uL;
		int i = 0;
		int num3 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
		{
			num3 = 1;
		}
		int num4 = default(int);
		while (true)
		{
			switch (num3)
			{
			case 2:
				num4++;
				num3 = 4;
				continue;
			case 1:
				for (; i <= 3; i++)
				{
					num = 256 * num + pNUHR6C3DRm[P_0 + i];
				}
				num3 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
				{
					num3 = 3;
				}
				continue;
			case 3:
				num4 = 4;
				num3 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
				{
					num3 = 0;
				}
				continue;
			}
			if (num4 <= 7)
			{
				num2 = 256 * num2 + pNUHR6C3DRm[P_0 + num4];
				num3 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
				{
					num3 = 2;
				}
				continue;
			}
			return num * 1000 + num2 * 1000 / 4294967296L;
		}
	}

	private void IFtHRDcJrBB(byte P_0, DateTime P_1)
	{
		DateTime dateTime = new DateTime(1900, 1, 1, 0, 0, 0);
		ulong num = (ulong)(P_1 - dateTime).TotalMilliseconds;
		ulong num2 = num / 1000;
		ulong num3 = num % 1000 * 4294967296L / 1000;
		int num4 = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
		{
			num4 = 6;
		}
		int num5 = default(int);
		ulong num6 = default(ulong);
		int num8 = default(int);
		while (true)
		{
			switch (num4)
			{
			case 3:
				pNUHR6C3DRm[P_0 + num5] = (byte)(num6 % 256);
				num4 = 5;
				break;
			case 5:
				num6 /= 256;
				num5--;
				num4 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
				{
					num4 = 4;
				}
				break;
			default:
				num6 = num3;
				num8 = 7;
				goto IL_0088;
			case 1:
				pNUHR6C3DRm[P_0 + num8] = (byte)(num6 % 256);
				num6 /= 256;
				num8--;
				goto IL_0088;
			case 6:
			{
				num6 = num2;
				num5 = 3;
				int num7 = 2;
				num4 = num7;
				break;
			}
			case 2:
			case 4:
				{
					if (num5 < 0)
					{
						num4 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
						{
							num4 = 0;
						}
						break;
					}
					goto case 3;
				}
				IL_0088:
				if (num8 < 4)
				{
					return;
				}
				goto case 1;
			}
		}
	}

	private void liPHRbEaZ6o()
	{
		int num = 3;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (num3 >= 48)
				{
					doSHRjyIVHm(DateTime.Now);
					return;
				}
				goto default;
			default:
				pNUHR6C3DRm[num3] = 0;
				num3++;
				goto case 1;
			case 2:
				num3 = 1;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				pNUHR6C3DRm[0] = 27;
				num2 = 2;
				break;
			}
		}
	}

	public eXgu2DHRaLyQBZFG8q30(string P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		pNUHR6C3DRm = new byte[48];
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				OqhHRWa2vpZ = P_0;
				n20HRNdUttK();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void n20HRNdUttK()
	{
		Stopwatch stopwatch = new Stopwatch();
		try
		{
			using UdpClient udpClient = new UdpClient();
			IPEndPoint remoteEP = new IPEndPoint(Dns.GetHostEntry(OqhHRWa2vpZ).AddressList[0], 123);
			int optionValue = ((NNWGMCDgVk7XRwK3oY58() == 0L) ? 5000 : 30000);
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					((Socket)CkF6CIDgCw6yPkMhwRDy(udpClient)).SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, optionValue);
					lZfbMQDgr9GbpoHK0i8Q(stopwatch);
					num = 3;
					break;
				case 3:
					HndO3GDgKJl8XHCfFIvu(udpClient, remoteEP);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
					{
						num = 1;
					}
					break;
				case 1:
					liPHRbEaZ6o();
					udpClient.Send(pNUHR6C3DRm, pNUHR6C3DRm.Length);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
					{
						num = 0;
					}
					break;
				default:
					pNUHR6C3DRm = udpClient.Receive(ref remoteEP);
					FBZHRIZ5ds1 = M0mYQfDgmi1X2sPuGQJZ();
					return;
				}
			}
		}
		catch (SocketException)
		{
		}
		finally
		{
			stopwatch.Stop();
			Duration = CmhcNUDghj4IZ7ixG1N3(stopwatch);
		}
	}

	public KI2DMYHRt5d0DevHJrKj RBpHRkaTFRp()
	{
		return new KI2DMYHRt5d0DevHJrKj(rs3HR1rNB9I(), wqfHRQ1Ui32(), Duration);
	}

	private bool rs3HR1rNB9I()
	{
		if (pNUHR6C3DRm.Length >= 48)
		{
			return Mode == (BdKLXYnKdmL7ApA3YNii)3;
		}
		return false;
	}

	static eXgu2DHRaLyQBZFG8q30()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool lLPPx7Dgt9LC65jJjfxM()
	{
		return xYu9EfDgWu6vdkr0fTbD == null;
	}

	internal static eXgu2DHRaLyQBZFG8q30 rnbrPCDgUOGPErBpf1sR()
	{
		return xYu9EfDgWu6vdkr0fTbD;
	}

	internal static DateTime rEJInCDgTntVjh9V2wKj(ulong P_0)
	{
		return DlGHRlb21xj(P_0);
	}

	internal static TimeSpan vK5DSFDgyXsuVaBEFqmK(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static DateTime A4lDNaDgZA9HOZ2gry22(DateTime P_0, TimeSpan P_1)
	{
		return P_0 + P_1;
	}

	internal static long NNWGMCDgVk7XRwK3oY58()
	{
		return Acj0FgGhg83F5A0lfPa4.q3hGwXLLhPb();
	}

	internal static object CkF6CIDgCw6yPkMhwRDy(object P_0)
	{
		return ((UdpClient)P_0).Client;
	}

	internal static void lZfbMQDgr9GbpoHK0i8Q(object P_0)
	{
		((Stopwatch)P_0).Start();
	}

	internal static void HndO3GDgKJl8XHCfFIvu(object P_0, object P_1)
	{
		((UdpClient)P_0).Connect((IPEndPoint)P_1);
	}

	internal static DateTime M0mYQfDgmi1X2sPuGQJZ()
	{
		return DateTime.Now;
	}

	internal static long CmhcNUDghj4IZ7ixG1N3(object P_0)
	{
		return ((Stopwatch)P_0).ElapsedMilliseconds;
	}
}
