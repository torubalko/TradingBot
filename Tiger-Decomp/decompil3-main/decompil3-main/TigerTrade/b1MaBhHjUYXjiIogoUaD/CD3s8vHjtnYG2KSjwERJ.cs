using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using aEpmU09nz6MEoNmc0pGJ;
using ECOEgqlSad8NUJZ2Dr9n;
using PIK1LVHjqnwZDfDQB94a;
using TigerTrade.Core.Utils.Logging;
using TuAMtrl1Nd3XoZQQUXf0;
using XnCphcHqoPcPGCkgYLFw;

namespace b1MaBhHjUYXjiIogoUaD;

internal abstract class CD3s8vHjtnYG2KSjwERJ<YLBprklijSmZG3ZSi3Gc, YVHhEYliE4TTF15Coyuu> where YVHhEYliE4TTF15Coyuu : PHiyjfHjO4OeOgqVJPSo
{
	protected class CurrentItem
	{
		public string mGWnr7VQHvZ;

		public YVHhEYliE4TTF15Coyuu yhDnr8WGWX2;

		public CurrentItem(string P_0, YVHhEYliE4TTF15Coyuu qQFMIAl1vpBURWhZJsgZ = null)
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
			mGWnr7VQHvZ = P_0;
			yhDnr8WGWX2 = qQFMIAl1vpBURWhZJsgZ;
		}

		static CurrentItem()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	protected readonly ReaderWriterLock vBtHjCa2RWA;

	protected readonly string m1KHjr8aj5D;

	protected DateTime GBpHjKpw9Q8;

	protected ConcurrentDictionary<string, CurrentItem> qlPHjmBIMkE;

	private Timer xMNHjhIWFBO;

	private bool XX2HjwYmxx6;

	private bool WFaHj7X3YTT;

	protected Dictionary<long, long> sbrHj8dPHT1;

	internal static object ek3wA5DQcuPjaMIUW7YI;

	protected CD3s8vHjtnYG2KSjwERJ(string P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		sbrHj8dPHT1 = new Dictionary<long, long>();
		base._002Ector();
		XX2HjwYmxx6 = false;
		WFaHj7X3YTT = false;
		vBtHjCa2RWA = new ReaderWriterLock();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				GBpHjKpw9Q8 = DateTime.UtcNow.Date;
				qlPHjmBIMkE = new ConcurrentDictionary<string, CurrentItem>();
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
				{
					num = 0;
				}
				break;
			case 1:
				wWNHjZK7UEu(GBpHjKpw9Q8);
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				xMNHjhIWFBO = new Timer(uNTHjTB2a6V, null, 10000, 10000);
				return;
			default:
				m1KHjr8aj5D = P_0;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	private void uNTHjTB2a6V(object P_0)
	{
		UpdHjVwu7Yh();
	}

	protected abstract void DMTl9DqUpsF(YLBprklijSmZG3ZSi3Gc avmE3DliQrfluvtVrngX);

	protected abstract string fpxl9ipreiH(DateTime P_0);

	protected abstract string eW5l9lOVbya(string P_0);

	protected abstract long Yrgl94G8xJf(string P_0);

	protected abstract string ywSl9bBBL3E(YVHhEYliE4TTF15Coyuu a5EXUylidf6EyoDwkMSw);

	public static string rtpHjygsB5b(string P_0)
	{
		if (!P_0.EndsWith(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741857CB)))
		{
			return null;
		}
		byte[] bytes = Convert.FromBase64String(P_0.Substring(0, P_0.Length - 4));
		return Encoding.UTF8.GetString(bytes) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2108526692 ^ -2108500642);
	}

	protected void wWNHjZK7UEu(DateTime P_0, bool P_1 = false)
	{
		string path = fpxl9ipreiH(P_0);
		if (!Directory.Exists(j18iDj9nukSCmEyZs5lH.mtr9YPp5CVF()) || !File.Exists(path))
		{
			return;
		}
		byte[] array;
		try
		{
			array = File.ReadAllBytes(path);
		}
		catch
		{
			if (!XX2HjwYmxx6)
			{
				LogManager.WriteError(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-3429745 ^ -3639165));
				XX2HjwYmxx6 = true;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
			return;
		}
		long num4 = default(long);
		long value = default(long);
		long key = default(long);
		DateTimeOffset dateTimeOffset = default(DateTimeOffset);
		DateTime utcDateTime = default(DateTime);
		while (true)
		{
			string text = EncwAYHqYSg6vo08yxsi.IayHqiu7VFU(array);
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				case 4:
					break;
				default:
					if (XX2HjwYmxx6)
					{
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 5:
				{
					if (string.IsNullOrEmpty(text))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b != 0)
						{
							num2 = 0;
						}
						continue;
					}
					using StringReader stringReader = new StringReader(text);
					string text2;
					for (bool flag = true; (text2 = stringReader.ReadLine()) != null; flag = false)
					{
						if (flag || string.IsNullOrEmpty(text2))
						{
							continue;
						}
						int num3;
						if (!P_1)
						{
							num3 = 4;
							goto IL_004c;
						}
						goto IL_0135;
						IL_0135:
						num4 = Yrgl94G8xJf(text2);
						num3 = 3;
						goto IL_004c;
						IL_004c:
						while (true)
						{
							switch (num3)
							{
							case 6:
								if (num4 > value)
								{
									sbrHj8dPHT1[key] = num4;
									num3 = 5;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto IL_01eb;
							case 7:
							case 9:
								sbrHj8dPHT1.Add(key, num4);
								goto IL_01eb;
							case 3:
								if (num4 > 0)
								{
									dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(num4);
									num3 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto IL_01eb;
							case 2:
								break;
							case 1:
							{
								key = new DateTimeOffset(utcDateTime.Date).ToUnixTimeMilliseconds();
								int num5 = 8;
								num3 = num5;
								continue;
							}
							case 8:
								if (!sbrHj8dPHT1.TryGetValue(key, out value))
								{
									num3 = 9;
									continue;
								}
								goto case 6;
							default:
								utcDateTime = dateTimeOffset.UtcDateTime;
								num3 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
								{
									num3 = 1;
								}
								continue;
							case 5:
								goto IL_01eb;
							case 4:
							{
								string text3 = eW5l9lOVbya(text2);
								if (!string.IsNullOrEmpty(text3))
								{
									qlPHjmBIMkE[text3] = new CurrentItem(text2);
									num3 = 2;
									continue;
								}
								break;
							}
							}
							break;
						}
						goto IL_0135;
						IL_01eb:;
					}
					return;
				}
				case 1:
					return;
				case 3:
					LogManager.WriteError(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-176525661 ^ -176571217));
					XX2HjwYmxx6 = true;
					return;
				case 2:
					return;
				}
				break;
			}
		}
	}

	protected void UpdHjVwu7Yh()
	{
		if (qlPHjmBIMkE == null)
		{
			return;
		}
		if (qlPHjmBIMkE.Count != 0)
		{
			try
			{
				int num;
				if (!Directory.Exists(j18iDj9nukSCmEyZs5lH.mtr9YPp5CVF()))
				{
					Directory.CreateDirectory(j18iDj9nukSCmEyZs5lH.mtr9YPp5CVF());
					num = 5;
					goto IL_0048;
				}
				goto IL_01aa;
				IL_01aa:
				StringBuilder stringBuilder = new StringBuilder(m1KHjr8aj5D);
				CurrentItem[] array = qlPHjmBIMkE.Values.ToArray();
				int num2 = 0;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
				{
					num = 6;
				}
				goto IL_0048;
				IL_0048:
				CurrentItem currentItem = default(CurrentItem);
				byte[] array2 = default(byte[]);
				while (true)
				{
					switch (num)
					{
					case 2:
						return;
					case 3:
						stringBuilder.Append(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x86EFEF6 ^ 0x86EB6F0) + currentItem.mGWnr7VQHvZ);
						if (currentItem.yhDnr8WGWX2 != null)
						{
							currentItem.yhDnr8WGWX2 = null;
							num = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
							{
								num = 0;
							}
							continue;
						}
						goto default;
					case 1:
					case 6:
						if (num2 >= array.Length)
						{
							array2 = EncwAYHqYSg6vo08yxsi.l6SHqaWXoEI(stringBuilder.ToString());
							if (array2 != null)
							{
								vBtHjCa2RWA.AcquireWriterLock(int.MaxValue);
								num = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
								{
									num = 4;
								}
							}
							else
							{
								num = 2;
							}
						}
						else
						{
							currentItem = array[num2];
							num = 3;
						}
						continue;
					case 4:
						File.WriteAllBytes(fpxl9ipreiH(GBpHjKpw9Q8), array2);
						return;
					default:
						num2++;
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
						{
							num = 0;
						}
						continue;
					case 5:
						break;
					}
					break;
				}
				goto IL_01aa;
			}
			catch (Exception)
			{
				if (!WFaHj7X3YTT)
				{
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						LogManager.WriteError(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1325312117));
						WFaHj7X3YTT = true;
						break;
					}
				}
				return;
			}
			finally
			{
				vBtHjCa2RWA.ReleaseWriterLock();
			}
		}
		int num4 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 != 0)
		{
			num4 = 0;
		}
		switch (num4)
		{
		case 0:
			break;
		}
	}

	static CD3s8vHjtnYG2KSjwERJ()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool WshMnKDQjrB9ukRodefI()
	{
		return ek3wA5DQcuPjaMIUW7YI == null;
	}

	internal static object YJpohGDQEsMB3ZDkfpOq()
	{
		return ek3wA5DQcuPjaMIUW7YI;
	}
}
