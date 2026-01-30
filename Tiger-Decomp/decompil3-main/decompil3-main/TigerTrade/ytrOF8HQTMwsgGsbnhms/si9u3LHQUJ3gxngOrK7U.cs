using System;
using System.IO;
using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace ytrOF8HQTMwsgGsbnhms;

internal sealed class si9u3LHQUJ3gxngOrK7U : IDisposable
{
	private readonly BinaryReader OO3HQPHuQfb;

	private static si9u3LHQUJ3gxngOrK7U O3D4rYDdbbs97aqc9FLm;

	public si9u3LHQUJ3gxngOrK7U(byte[] P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		OO3HQPHuQfb = new BinaryReader(new MemoryStream(P_0));
	}

	public long YwNHQyCu9Vs()
	{
		long num = 0L;
		int num2 = 0;
		int num3 = 3;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
		{
			num3 = 2;
		}
		int num4 = default(int);
		while (true)
		{
			switch (num3)
			{
			case 2:
				throw new EndOfStreamException();
			default:
				num |= -(1L << num2);
				break;
			case 3:
				num4 = ((Stream)hZ2ZPsDd15qV6tD5jMN4(OO3HQPHuQfb)).ReadByte();
				if (num4 == -1)
				{
					int num5 = 2;
					num3 = num5;
					continue;
				}
				num |= (long)(num4 & 0x7F) << num2;
				num3 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
				{
					num3 = 1;
				}
				continue;
			case 1:
				num2 += 7;
				if ((num4 & 0x80) == 0)
				{
					if (num2 < 64 && (num4 & 0x40) != 0)
					{
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
						{
							num3 = 0;
						}
						continue;
					}
					break;
				}
				goto case 3;
			}
			break;
		}
		return num;
	}

	[SpecialName]
	public bool sVHHQ8rtniK()
	{
		return OO3HQPHuQfb.BaseStream.Length > ((Stream)hZ2ZPsDd15qV6tD5jMN4(OO3HQPHuQfb)).Position;
	}

	public bool MMlHQZlKlZm()
	{
		return TZitJDDd5jGLFNODpQht(OO3HQPHuQfb);
	}

	public DateTime REIHQVCgpof()
	{
		return DateTime.FromBinary(OO3HQPHuQfb.ReadInt64());
	}

	public byte f2QHQCRWWGt()
	{
		return u22LMrDdSdalRSJ71fBB(OO3HQPHuQfb);
	}

	public byte[] NmnHQroWiBc()
	{
		int num = OO3HQPHuQfb.ReadInt32();
		if (num == 0)
		{
			return null;
		}
		return OO3HQPHuQfb.ReadBytes(num);
	}

	public int vC2HQK5KOrk()
	{
		return OO3HQPHuQfb.ReadInt32();
	}

	public uint u3THQmT9J1T()
	{
		return OO3HQPHuQfb.ReadUInt32();
	}

	public long iT9HQhdySfg()
	{
		return dVtbbqDdxNNqkPJL5Uo1(OO3HQPHuQfb);
	}

	public double q0fHQwOITnk()
	{
		return OO3HQPHuQfb.ReadDouble();
	}

	public string lGGHQ7KoRcw()
	{
		return OO3HQPHuQfb.ReadString();
	}

	public void Dispose()
	{
		BinaryReader oO3HQPHuQfb = OO3HQPHuQfb;
		if (oO3HQPHuQfb != null)
		{
			YiFsb9DdLwnWHSlw28iA(oO3HQPHuQfb);
		}
	}

	static si9u3LHQUJ3gxngOrK7U()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool w0BxRnDdNoh1Ja3XGHSR()
	{
		return O3D4rYDdbbs97aqc9FLm == null;
	}

	internal static si9u3LHQUJ3gxngOrK7U da9VhEDdk0kHdkmDcPYP()
	{
		return O3D4rYDdbbs97aqc9FLm;
	}

	internal static object hZ2ZPsDd15qV6tD5jMN4(object P_0)
	{
		return ((BinaryReader)P_0).BaseStream;
	}

	internal static bool TZitJDDd5jGLFNODpQht(object P_0)
	{
		return ((BinaryReader)P_0).ReadBoolean();
	}

	internal static byte u22LMrDdSdalRSJ71fBB(object P_0)
	{
		return ((BinaryReader)P_0).ReadByte();
	}

	internal static long dVtbbqDdxNNqkPJL5Uo1(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt64();
	}

	internal static void YiFsb9DdLwnWHSlw28iA(object P_0)
	{
		((BinaryReader)P_0).Dispose();
	}
}
