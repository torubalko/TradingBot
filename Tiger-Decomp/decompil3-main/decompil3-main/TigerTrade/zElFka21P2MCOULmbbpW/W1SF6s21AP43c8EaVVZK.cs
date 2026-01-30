using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Caching;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Timers;
using aEpmU09nz6MEoNmc0pGJ;
using df6c2Q21gMRI7PIyQV9L;
using ECOEgqlSad8NUJZ2Dr9n;
using iT1EeM21mJC8yYxJ99pX;
using s7Ae0Z21LF5mOEF22dUH;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Core.Utils.Config;
using TuAMtrl1Nd3XoZQQUXf0;

namespace zElFka21P2MCOULmbbpW;

internal static class W1SF6s21AP43c8EaVVZK
{
	[Serializable]
	[CompilerGenerated]
	private sealed class HE8CZ2n6f075r0FPXLAx
	{
		public static readonly HE8CZ2n6f075r0FPXLAx RmYn6nybgb1;

		internal static HE8CZ2n6f075r0FPXLAx cbrMm6NDuDpVVmqFbpAM;

		static HE8CZ2n6f075r0FPXLAx()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
					RmYn6nybgb1 = new HE8CZ2n6f075r0FPXLAx();
					return;
				case 1:
					stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public HE8CZ2n6f075r0FPXLAx()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void DSNn69K3KXQ(object s, ElapsedEventArgs e)
		{
			object rOG25GaEiOF = W1SF6s21AP43c8EaVVZK.rOG25GaEiOF;
			bool lockTaken = false;
			try
			{
				Monitor.Enter(rOG25GaEiOF, ref lockTaken);
				try
				{
					ConfigSerializer.SaveToFile(kN925Y94DRv, OB2259r4FDT());
					CacheItemPolicy policy = new CacheItemPolicy
					{
						ChangeMonitors = { (ChangeMonitor)new HostFileChangeMonitor(new List<string> { (string)agSc37Nb2S47nxuKMg3Q() }) },
						SlidingExpiration = TimeSpan.FromMinutes(15.0)
					};
					int num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
					{
						num = 0;
					}
					switch (num)
					{
					}
					if (kN925Y94DRv != null)
					{
						h2O25owCtRn.Set(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-894902996 ^ -894930226), kN925Y94DRv, policy);
					}
				}
				catch
				{
				}
			}
			finally
			{
				if (lockTaken)
				{
					cq4FMxNbHoyBXpAGvhMi(rOG25GaEiOF);
				}
			}
		}

		internal static bool AqHpAtNDz6lAZUqvegWu()
		{
			return cbrMm6NDuDpVVmqFbpAM == null;
		}

		internal static HE8CZ2n6f075r0FPXLAx ebwydSNb0UriTMkcRNwS()
		{
			return cbrMm6NDuDpVVmqFbpAM;
		}

		internal static object agSc37Nb2S47nxuKMg3Q()
		{
			return OB2259r4FDT();
		}

		internal static void cq4FMxNbHoyBXpAGvhMi(object P_0)
		{
			Monitor.Exit(P_0);
		}
	}

	private static readonly object rOG25GaEiOF;

	private static RfdDdg21KolOk9YjtSdD kN925Y94DRv;

	private static readonly ObjectCache h2O25owCtRn;

	private static readonly System.Timers.Timer j6P25BvO3Ux;

	private static W1SF6s21AP43c8EaVVZK kqPgad4Z4PIYg4Xa3qEJ;

	[SpecialName]
	private static string OB2259r4FDT()
	{
		return (string)mLufhT4ZkVXj1L4aIjpm(j18iDj9nukSCmEyZs5lH.aYr9YmGALFf(), HW9iFi4ZNgDJypcHgQxa(-2063361985 ^ -2063386627));
	}

	static W1SF6s21AP43c8EaVVZK()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		iS3aCX4Z1RvpIbd8byIc();
		rOG25GaEiOF = new object();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				h2O25owCtRn = (ObjectCache)h9IuhD4Z5wKfDb6NZ2sA();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
				{
					num = 0;
				}
				continue;
			}
			System.Timers.Timer obj = new System.Timers.Timer
			{
				AutoReset = false
			};
			aGcGg14ZSnC9i8ZyF8xU(obj, 500.0);
			j6P25BvO3Ux = obj;
			j6P25BvO3Ux.Elapsed += delegate
			{
				object obj2 = rOG25GaEiOF;
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj2, ref lockTaken);
					try
					{
						ConfigSerializer.SaveToFile(kN925Y94DRv, OB2259r4FDT());
						CacheItemPolicy policy = new CacheItemPolicy
						{
							ChangeMonitors = { (ChangeMonitor)new HostFileChangeMonitor(new List<string> { (string)HE8CZ2n6f075r0FPXLAx.agSc37Nb2S47nxuKMg3Q() }) },
							SlidingExpiration = TimeSpan.FromMinutes(15.0)
						};
						int num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						default:
							if (kN925Y94DRv != null)
							{
								h2O25owCtRn.Set(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-894902996 ^ -894930226), kN925Y94DRv, policy);
							}
							break;
						}
					}
					catch
					{
					}
				}
				finally
				{
					if (lockTaken)
					{
						HE8CZ2n6f075r0FPXLAx.cq4FMxNbHoyBXpAGvhMi(obj2);
					}
				}
			};
			return;
		}
	}

	private static void TM521J9FxtM()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (kN925Y94DRv != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
					{
						num2 = 0;
					}
					break;
				}
				lock (rOG25GaEiOF)
				{
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						RfdDdg21KolOk9YjtSdD rfdDdg21KolOk9YjtSdD;
						switch (num3)
						{
						case 2:
							if (h2O25owCtRn.Get(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1161619942 ^ -1161577992)) is RfdDdg21KolOk9YjtSdD rfdDdg21KolOk9YjtSdD2)
							{
								kN925Y94DRv = rfdDdg21KolOk9YjtSdD2;
								return;
							}
							rfdDdg21KolOk9YjtSdD = ConfigSerializer.LoadFromFile<RfdDdg21KolOk9YjtSdD>(OB2259r4FDT());
							if (rfdDdg21KolOk9YjtSdD == null)
							{
								num3 = 4;
								continue;
							}
							break;
						case 3:
							return;
						case 1:
						{
							CacheItemPolicy policy = new CacheItemPolicy
							{
								ChangeMonitors = { (ChangeMonitor)new HostFileChangeMonitor(new List<string> { (string)iBXnVR4Zxnm99MYYVw5n() }) },
								SlidingExpiration = TimeSpan.FromMinutes(15.0)
							};
							h2O25owCtRn.Set((string)HW9iFi4ZNgDJypcHgQxa(-602153869 ^ -602180719), kN925Y94DRv, policy);
							return;
						}
						default:
							if (kN925Y94DRv != null)
							{
								num3 = 3;
								continue;
							}
							goto case 2;
						case 4:
							rfdDdg21KolOk9YjtSdD = new RfdDdg21KolOk9YjtSdD();
							break;
						}
						kN925Y94DRv = rfdDdg21KolOk9YjtSdD;
						num3 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
						{
							num3 = 1;
						}
					}
				}
			case 0:
				return;
			}
		}
	}

	private static void HdM21F1hcw3()
	{
		W0oVCw4ZLeVVMarY42kg(j6P25BvO3Ux);
		j6P25BvO3Ux.Start();
	}

	public static int? AyW2139W2gA(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return null;
		}
		TM521J9FxtM();
		lock (rOG25GaEiOF)
		{
			if (kN925Y94DRv.ic8217AZKO4.TryGetValue(P_0, out var value))
			{
				return value.Chart;
			}
		}
		return null;
	}

	public static int? IPL21piRZKs(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return null;
		}
		TM521J9FxtM();
		lock (rOG25GaEiOF)
		{
			lqFNVN21dB2SKOrW3VCg value;
			return kN925Y94DRv.ic8217AZKO4.TryGetValue(P_0, out value) ? value.EtI21qNbUuu : ((int?)null);
		}
	}

	public static DataCycle hLf21uYGGsC(string P_0)
	{
		if (!string.IsNullOrEmpty(P_0))
		{
			TM521J9FxtM();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 != 0)
			{
				num = 0;
			}
			object obj = default(object);
			lqFNVN21dB2SKOrW3VCg value = default(lqFNVN21dB2SKOrW3VCg);
			while (true)
			{
				switch (num)
				{
				default:
					obj = rOG25GaEiOF;
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
					{
						num = 1;
					}
					break;
				case 1:
				{
					bool lockTaken = false;
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
						{
							num2 = 0;
						}
						while (true)
						{
							switch (num2)
							{
							default:
								if (kN925Y94DRv.ic8217AZKO4.TryGetValue(P_0, out value))
								{
									num2 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c != 0)
									{
										num2 = 1;
									}
									continue;
								}
								break;
							case 1:
								if (k9eKlB4ZeAc0q1uPmXBO(value) != null)
								{
									return new DataCycle
									{
										CycleBase = gfPWQS4Zs4weDrjnIPkb(value.hXF21ttipKA),
										Repeat = value.hXF21ttipKA.Repeat
									};
								}
								break;
							}
							break;
						}
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(obj);
						}
					}
					return null;
				}
				}
			}
		}
		return null;
	}

	public static DataCycle xaY21zG98fg(string P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!D0Eohl4ZXC0IYD5QUijq(P_0))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return null;
			case 2:
				lock (rOG25GaEiOF)
				{
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
						{
							if (!kN925Y94DRv.ic8217AZKO4.TryGetValue(P_0, out var value))
							{
								num3 = 2;
								continue;
							}
							if (gbWskR4Zc3YoWuXXQOme(value) != null)
							{
								DataCycle dataCycle = new DataCycle();
								VdWRvG4ZjXFRyeAgkPNM(dataCycle, value.waY21y1qGlF.Cla21X2p5xl);
								OYvXlr4ZELaVR7tXVZ7s(dataCycle, value.waY21y1qGlF.Repeat);
								return dataCycle;
							}
							break;
						}
						case 2:
							break;
						case 1:
							break;
						}
						break;
					}
				}
				return null;
			default:
				TM521J9FxtM();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public static void BOv250mYU5j(string P_0, int P_1)
	{
		if (D0Eohl4ZXC0IYD5QUijq(P_0))
		{
			return;
		}
		xeAv9D4ZQymk1EZxY33g();
		object obj = rOG25GaEiOF;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
		{
			num = 1;
		}
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num)
			{
			case 1:
				lockTaken = false;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
				{
					num = 0;
				}
				continue;
			}
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				int num2;
				if (!kN925Y94DRv.ic8217AZKO4.TryGetValue(P_0, out var value))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
					{
						num2 = 0;
					}
					goto IL_004a;
				}
				goto IL_00ac;
				IL_004a:
				switch (num2)
				{
				case 1:
					return;
				}
				lqFNVN21dB2SKOrW3VCg lqFNVN21dB2SKOrW3VCg = (kN925Y94DRv.ic8217AZKO4[P_0] = new lqFNVN21dB2SKOrW3VCg());
				value = lqFNVN21dB2SKOrW3VCg;
				goto IL_00ac;
				IL_00ac:
				value.Chart = P_1;
				HdM21F1hcw3();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
				{
					num2 = 1;
				}
				goto IL_004a;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
		}
	}

	public static void ppf252L0P7B(string P_0, int P_1)
	{
		int num = 1;
		int num2 = num;
		object obj = default(object);
		bool lockTaken = default(bool);
		lqFNVN21dB2SKOrW3VCg value = default(lqFNVN21dB2SKOrW3VCg);
		lqFNVN21dB2SKOrW3VCg lqFNVN21dB2SKOrW3VCg = default(lqFNVN21dB2SKOrW3VCg);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (string.IsNullOrEmpty(P_0))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 != 0)
					{
						num2 = 0;
					}
					break;
				}
				TM521J9FxtM();
				obj = rOG25GaEiOF;
				lockTaken = false;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 2:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							value = lqFNVN21dB2SKOrW3VCg;
							goto default;
						default:
							value.EtI21qNbUuu = P_1;
							HdM21F1hcw3();
							return;
						case 1:
							if (!kN925Y94DRv.ic8217AZKO4.TryGetValue(P_0, out value))
							{
								lqFNVN21dB2SKOrW3VCg = (kN925Y94DRv.ic8217AZKO4[P_0] = new lqFNVN21dB2SKOrW3VCg());
								num3 = 2;
								break;
							}
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			}
		}
	}

	public static void RSi25HdehwR(string P_0, DataCycle P_1)
	{
		int num = 2;
		int num2 = num;
		object obj = default(object);
		bool lockTaken = default(bool);
		lqFNVN21dB2SKOrW3VCg lqFNVN21dB2SKOrW3VCg = default(lqFNVN21dB2SKOrW3VCg);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (P_1 == null)
				{
					return;
				}
				TM521J9FxtM();
				obj = rOG25GaEiOF;
				lockTaken = false;
				num2 = 3;
				break;
			case 3:
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num3;
					if (!kN925Y94DRv.ic8217AZKO4.TryGetValue(P_0, out var value))
					{
						lqFNVN21dB2SKOrW3VCg = (kN925Y94DRv.ic8217AZKO4[P_0] = new lqFNVN21dB2SKOrW3VCg());
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
						{
							num3 = 0;
						}
						goto IL_0056;
					}
					goto IL_0068;
					IL_0056:
					switch (num3)
					{
					case 1:
						HdM21F1hcw3();
						return;
					}
					value = lqFNVN21dB2SKOrW3VCg;
					goto IL_0068;
					IL_0068:
					lqFNVN21dB2SKOrW3VCg lqFNVN21dB2SKOrW3VCg3 = value;
					sCHrNY21xHdCE3FVpjwB sCHrNY21xHdCE3FVpjwB = new sCHrNY21xHdCE3FVpjwB();
					GhyMfJ4ZgFMvPrHH9K6g(sCHrNY21xHdCE3FVpjwB, iApYm84ZdXP8xBLq2hoX(P_1));
					sCHrNY21xHdCE3FVpjwB.Repeat = KiNZpf4ZRq5yR5pNgKCD(P_1);
					lqFNVN21dB2SKOrW3VCg3.hXF21ttipKA = sCHrNY21xHdCE3FVpjwB;
					num3 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 != 0)
					{
						num3 = 1;
					}
					goto IL_0056;
				}
				finally
				{
					if (lockTaken)
					{
						Monitor.Exit(obj);
					}
				}
			case 2:
				if (!string.IsNullOrEmpty(P_0))
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 0:
				return;
			}
		}
	}

	public static void rfh25fHlPPj(string P_0, DataCycle P_1)
	{
		if (D0Eohl4ZXC0IYD5QUijq(P_0))
		{
			return;
		}
		int num;
		object obj = default(object);
		if (P_1 == null)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
			{
				num = 0;
			}
		}
		else
		{
			xeAv9D4ZQymk1EZxY33g();
			obj = rOG25GaEiOF;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 1:
		{
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				int num2;
				if (kN925Y94DRv.ic8217AZKO4.TryGetValue(P_0, out var value))
				{
					num2 = 2;
					goto IL_0083;
				}
				goto IL_010b;
				IL_010b:
				lqFNVN21dB2SKOrW3VCg lqFNVN21dB2SKOrW3VCg = (kN925Y94DRv.ic8217AZKO4[P_0] = new lqFNVN21dB2SKOrW3VCg());
				value = lqFNVN21dB2SKOrW3VCg;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd != 0)
				{
					num2 = 1;
				}
				goto IL_0083;
				IL_0083:
				switch (num2)
				{
				case 1:
				case 2:
				{
					lqFNVN21dB2SKOrW3VCg lqFNVN21dB2SKOrW3VCg3 = value;
					sCHrNY21xHdCE3FVpjwB sCHrNY21xHdCE3FVpjwB = new sCHrNY21xHdCE3FVpjwB();
					GhyMfJ4ZgFMvPrHH9K6g(sCHrNY21xHdCE3FVpjwB, P_1.CycleBase);
					sCHrNY21xHdCE3FVpjwB.Repeat = P_1.Repeat;
					lqFNVN21dB2SKOrW3VCg3.waY21y1qGlF = sCHrNY21xHdCE3FVpjwB;
					HdM21F1hcw3();
					return;
				}
				}
				goto IL_010b;
			}
			finally
			{
				if (lockTaken)
				{
					IQlbdA4Z6VyRj1J6vjQc(obj);
				}
			}
		}
		case 0:
			break;
		}
	}

	internal static object HW9iFi4ZNgDJypcHgQxa(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object mLufhT4ZkVXj1L4aIjpm(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool gvFnIx4ZD0fUGUKP9XIZ()
	{
		return kqPgad4Z4PIYg4Xa3qEJ == null;
	}

	internal static W1SF6s21AP43c8EaVVZK ImlbP44ZbnyMFGnAouPY()
	{
		return kqPgad4Z4PIYg4Xa3qEJ;
	}

	internal static void iS3aCX4Z1RvpIbd8byIc()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object h9IuhD4Z5wKfDb6NZ2sA()
	{
		return MemoryCache.Default;
	}

	internal static void aGcGg14ZSnC9i8ZyF8xU(object P_0, double P_1)
	{
		((System.Timers.Timer)P_0).Interval = P_1;
	}

	internal static object iBXnVR4Zxnm99MYYVw5n()
	{
		return OB2259r4FDT();
	}

	internal static void W0oVCw4ZLeVVMarY42kg(object P_0)
	{
		((System.Timers.Timer)P_0).Stop();
	}

	internal static object k9eKlB4ZeAc0q1uPmXBO(object P_0)
	{
		return ((lqFNVN21dB2SKOrW3VCg)P_0).hXF21ttipKA;
	}

	internal static DataCycleBase gfPWQS4Zs4weDrjnIPkb(object P_0)
	{
		return ((sCHrNY21xHdCE3FVpjwB)P_0).Cla21X2p5xl;
	}

	internal static bool D0Eohl4ZXC0IYD5QUijq(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object gbWskR4Zc3YoWuXXQOme(object P_0)
	{
		return ((lqFNVN21dB2SKOrW3VCg)P_0).waY21y1qGlF;
	}

	internal static void VdWRvG4ZjXFRyeAgkPNM(object P_0, DataCycleBase value)
	{
		((DataCycle)P_0).CycleBase = value;
	}

	internal static void OYvXlr4ZELaVR7tXVZ7s(object P_0, int value)
	{
		((DataCycle)P_0).Repeat = value;
	}

	internal static void xeAv9D4ZQymk1EZxY33g()
	{
		TM521J9FxtM();
	}

	internal static DataCycleBase iApYm84ZdXP8xBLq2hoX(object P_0)
	{
		return ((DataCycle)P_0).CycleBase;
	}

	internal static void GhyMfJ4ZgFMvPrHH9K6g(object P_0, DataCycleBase P_1)
	{
		((sCHrNY21xHdCE3FVpjwB)P_0).Cla21X2p5xl = P_1;
	}

	internal static int KiNZpf4ZRq5yR5pNgKCD(object P_0)
	{
		return ((DataCycle)P_0).Repeat;
	}

	internal static void IQlbdA4Z6VyRj1J6vjQc(object P_0)
	{
		Monitor.Exit(P_0);
	}
}
