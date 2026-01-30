using System;
using System.IO;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace iFFtULHQFb31SjMhcK50;

internal sealed class x5JXegHQJnVOYyryU7QQ
{
	private readonly MemoryStream KgnHdYy9bWy;

	private readonly BinaryWriter KGaHdoh4k1d;

	private static x5JXegHQJnVOYyryU7QQ cE3kTcDdekBGZdNmGyZ7;

	public x5JXegHQJnVOYyryU7QQ()
	{
		gdnvwEDdcAoaXAc2KJse();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		KgnHdYy9bWy = new MemoryStream();
		KGaHdoh4k1d = new BinaryWriter(KgnHdYy9bWy);
	}

	public void QGrHQ33P7V1(long P_0)
	{
		if (P_0 < 0)
		{
			goto IL_009c;
		}
		goto IL_00ec;
		IL_00ec:
		int num = (int)(P_0 & 0x7F);
		int num2 = 4;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
		{
			num2 = 5;
		}
		goto IL_0009;
		IL_009c:
		int num3 = (int)(P_0 & 0x7F);
		num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
		{
			num2 = 3;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			case 4:
				KGaHdoh4k1d.BaseStream.WriteByte((byte)(num | 0x80));
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				break;
			case 2:
				goto IL_009c;
			default:
				goto IL_00be;
			case 5:
				P_0 >>= 7;
				if (P_0 == 0L)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 1:
				goto IL_00ec;
			}
			break;
			IL_00be:
			if ((num & 0x40) != 0)
			{
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
				{
					num2 = 4;
				}
				continue;
			}
			((Stream)JIoO2UDdjDjEBZXOLmEX(KGaHdoh4k1d)).WriteByte((byte)num);
			return;
		}
		P_0 >>= 7;
		if (P_0 == -1 && (num3 & 0x40) != 0)
		{
			KGaHdoh4k1d.BaseStream.WriteByte((byte)num3);
			return;
		}
		((Stream)JIoO2UDdjDjEBZXOLmEX(KGaHdoh4k1d)).WriteByte((byte)(num3 | 0x80));
		goto IL_009c;
	}

	public void X9ZHQplvXme(bool P_0)
	{
		KGaHdoh4k1d.Write(P_0);
	}

	public void ynPHQu3A8GJ(byte P_0)
	{
		KGaHdoh4k1d.Write(P_0);
	}

	public void WZ1HQzQeCUb(DateTime P_0)
	{
		MZvmNnDdEncnX5gsyGxv(KGaHdoh4k1d, P_0.ToBinary());
	}

	public void MciHd0D6nn5(byte[] P_0)
	{
		if (P_0 != null && P_0.Length != 0)
		{
			KGaHdoh4k1d.Write(P_0.Length);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
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
				KGaHdoh4k1d.Write(P_0);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
				{
					num = 1;
				}
			}
		}
		Y9MZw1DdQwXDlFOVay5k(KGaHdoh4k1d, 0);
	}

	public void ww3Hd2Oji6l(int P_0)
	{
		KGaHdoh4k1d.Write(P_0);
	}

	public void wakHdHaAVOI(long P_0)
	{
		KGaHdoh4k1d.Write(P_0);
	}

	public void CiQHdfW5T8x(uint P_0)
	{
		KGaHdoh4k1d.Write(P_0);
	}

	public void IovHd9TWioW(double P_0)
	{
		KGaHdoh4k1d.Write(P_0);
	}

	public void WDTHdnuC4Wn(string P_0)
	{
		KGaHdoh4k1d.Write(P_0 ?? "");
	}

	public byte[] vWNHdGaiv8a()
	{
		return KgnHdYy9bWy.ToArray();
	}

	static x5JXegHQJnVOYyryU7QQ()
	{
		yoH8BUDddik5wkLjsn8c();
	}

	internal static void gdnvwEDdcAoaXAc2KJse()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool rAfyJCDdsD7G4y3uAPBD()
	{
		return cE3kTcDdekBGZdNmGyZ7 == null;
	}

	internal static x5JXegHQJnVOYyryU7QQ JB0Hy9DdXL2HkcPduOnm()
	{
		return cE3kTcDdekBGZdNmGyZ7;
	}

	internal static object JIoO2UDdjDjEBZXOLmEX(object P_0)
	{
		return ((BinaryWriter)P_0).BaseStream;
	}

	internal static void MZvmNnDdEncnX5gsyGxv(object P_0, long P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	internal static void Y9MZw1DdQwXDlFOVay5k(object P_0, int P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	internal static void yoH8BUDddik5wkLjsn8c()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
