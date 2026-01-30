using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using aEpmU09nz6MEoNmc0pGJ;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Core.Utils.Logging;
using TuAMtrl1Nd3XoZQQUXf0;

namespace hUVABgfuidfseul80XeP;

internal static class fcDaIGfua3ieQHnfpB9v
{
	private static readonly Dictionary<string, byte[]> FOifuDES2mN;

	private static readonly string hbwfubtlqs1;

	private static readonly object QtSfuN9V19c;

	private static fcDaIGfua3ieQHnfpB9v zJc3nFblPlJoCCJTY0Ls;

	static fcDaIGfua3ieQHnfpB9v()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		FOifuDES2mN = new Dictionary<string, byte[]>();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				hbwfubtlqs1 = (string)crrB6rblphmUjyo4kp3N(FFCXSDbl3kRfoFqFPSjk(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-5977659 ^ -6226265));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
				{
					num = 0;
				}
				break;
			default:
				if (!Directory.Exists(hbwfubtlqs1))
				{
					Directory.CreateDirectory(hbwfubtlqs1);
				}
				return;
			case 2:
				QtSfuN9V19c = new object();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public static void fGZfulYnZwK(string P_0, byte[] P_1)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return;
		}
		lock (QtSfuN9V19c)
		{
			try
			{
				File.WriteAllBytes((string)crrB6rblphmUjyo4kp3N(hbwfubtlqs1, P_0 + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2123795572 ^ -2123718260)), P_1);
				if (FOifuDES2mN.ContainsKey(P_0))
				{
					int num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
					{
						num = 0;
					}
					switch (num)
					{
					}
					FOifuDES2mN.Remove(P_0);
				}
				FOifuDES2mN.Add(P_0, P_1);
			}
			catch (Exception e)
			{
				LogManager.WriteError(e);
			}
		}
	}

	public static byte[] xWKfu45hbJu(string P_0)
	{
		int num = 1;
		int num2 = num;
		byte[] result = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!v7QZFsbluX2RklqJkt5Y(P_0))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
					{
						num2 = 0;
					}
					continue;
				}
				return null;
			case 2:
				break;
			default:
				lock (QtSfuN9V19c)
				{
					try
					{
						int num3;
						if (FOifuDES2mN.ContainsKey(P_0))
						{
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
							{
								num3 = 0;
							}
							goto IL_00bd;
						}
						goto IL_00d7;
						IL_00bd:
						switch (num3)
						{
						case 3:
							break;
						case 1:
							goto end_IL_008f;
						default:
							result = FOifuDES2mN[P_0];
							goto end_IL_008f;
						case 2:
							FOifuDES2mN.Add(P_0, array);
							result = array;
							goto end_IL_008f;
						}
						goto IL_00d7;
						IL_00d7:
						string text = Path.Combine(hbwfubtlqs1, P_0 + (string)fZG1BOblzE8VvS1gcTyw(0x3544E813 ^ 0x35473A13));
						if (!File.Exists(text))
						{
							result = null;
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
							{
								num3 = 1;
							}
						}
						else
						{
							array = (byte[])Gywg0gb403vUvs2DNKnH(text);
							num3 = 2;
						}
						goto IL_00bd;
						end_IL_008f:;
					}
					catch (Exception e)
					{
						LogManager.WriteError(e);
						goto IL_0071;
					}
					goto end_IL_0051;
					IL_0071:
					result = null;
					int num4 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
					end_IL_0051:;
				}
				break;
			}
			break;
		}
		return result;
	}

	public static void Clear()
	{
		object qtSfuN9V19c = QtSfuN9V19c;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(qtSfuN9V19c, ref lockTaken);
			try
			{
				FOifuDES2mN.Clear();
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				Directory.Delete(hbwfubtlqs1, recursive: true);
				JUNsxEb42vJmDaXhuO4o(hbwfubtlqs1);
			}
			catch (Exception ex)
			{
				ydJV22b4HhtDRQKAGCFi(ex);
			}
		}
		finally
		{
			if (lockTaken)
			{
				Lo4vtLb4fHv42mc8yy47(qtSfuN9V19c);
			}
		}
	}

	public static void ClearMemory()
	{
		int num = 1;
		int num2 = num;
		object qtSfuN9V19c = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
				qtSfuN9V19c = QtSfuN9V19c;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			bool lockTaken = false;
			try
			{
				Monitor.Enter(qtSfuN9V19c, ref lockTaken);
				try
				{
					FOifuDES2mN.Clear();
					return;
				}
				catch (Exception e)
				{
					LogManager.WriteError(e);
					return;
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(qtSfuN9V19c);
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	internal static object FFCXSDbl3kRfoFqFPSjk()
	{
		return j18iDj9nukSCmEyZs5lH.YZj9YpD9GB1();
	}

	internal static object crrB6rblphmUjyo4kp3N(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool ANaH4AblJFUhDwXvInNr()
	{
		return zJc3nFblPlJoCCJTY0Ls == null;
	}

	internal static fcDaIGfua3ieQHnfpB9v dH7b7hblF5jJDCFwHbp6()
	{
		return zJc3nFblPlJoCCJTY0Ls;
	}

	internal static bool v7QZFsbluX2RklqJkt5Y(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object fZG1BOblzE8VvS1gcTyw(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object Gywg0gb403vUvs2DNKnH(object P_0)
	{
		return File.ReadAllBytes((string)P_0);
	}

	internal static object JUNsxEb42vJmDaXhuO4o(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static void ydJV22b4HhtDRQKAGCFi(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}

	internal static void Lo4vtLb4fHv42mc8yy47(object P_0)
	{
		Monitor.Exit(P_0);
	}
}
