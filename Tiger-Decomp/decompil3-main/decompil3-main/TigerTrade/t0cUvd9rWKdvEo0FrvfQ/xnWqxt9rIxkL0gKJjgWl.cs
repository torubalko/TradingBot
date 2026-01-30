using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using Microsoft.IdentityModel.Tokens;
using TigerTrade.Chart.Indicators.Common;
using TuAMtrl1Nd3XoZQQUXf0;

namespace t0cUvd9rWKdvEo0FrvfQ;

internal static class xnWqxt9rIxkL0gKJjgWl
{
	[CompilerGenerated]
	private static Action<string, string, ChartDataType> qYr9rhOm9xj;

	private static readonly Dictionary<string, int[]> e3X9rw4Asva;

	private static xnWqxt9rIxkL0gKJjgWl bmyPJ0bZDi1FDTDF81rW;

	[SpecialName]
	[CompilerGenerated]
	public static void YPx9rrmx6KJ(Action<string, string, ChartDataType> P_0)
	{
		Action<string, string, ChartDataType> action = qYr9rhOm9xj;
		Action<string, string, ChartDataType> action2;
		do
		{
			action2 = action;
			Action<string, string, ChartDataType> value = (Action<string, string, ChartDataType>)Delegate.Combine(action2, P_0);
			action = Interlocked.CompareExchange(ref qYr9rhOm9xj, value, action2);
		}
		while ((object)action != action2);
	}

	[SpecialName]
	[CompilerGenerated]
	public static void WNg9rKNp3tY(Action<string, string, ChartDataType> P_0)
	{
		Action<string, string, ChartDataType> action = qYr9rhOm9xj;
		Action<string, string, ChartDataType> action2;
		do
		{
			action2 = action;
			Action<string, string, ChartDataType> value = (Action<string, string, ChartDataType>)Delegate.Remove(action2, P_0);
			action = Interlocked.CompareExchange(ref qYr9rhOm9xj, value, action2);
		}
		while ((object)action != action2);
	}

	private static string PUj9rtNxK8L(string P_0, string P_1)
	{
		if (P_0.IsNullOrEmpty())
		{
			return null;
		}
		if (!P_1.IsNullOrEmpty())
		{
			return (string)EK8CudbZkigyup5QAqXh(P_1, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1763895751 ^ -1763847421), P_0);
		}
		return P_0;
	}

	private static void TCY9rUd0Wca(string P_0, out string P_1, out string P_2)
	{
		int num = 1;
		int num2 = num;
		string[] array = default(string[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				array = (string[])aFsr2jbZ1hB1iLcivmxD(P_0, new char[1] { '*' });
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				P_2 = array[0];
				P_1 = array[1];
				return;
			}
			if (array.Length != 2)
			{
				P_2 = null;
				P_1 = array[0];
				return;
			}
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf != 0)
			{
				num2 = 2;
			}
		}
	}

	public static void LOt9rTY0hlD(string P_0, ChartDataType P_1, string P_2)
	{
		wWO9ryqdIei(P_0, new ChartDataType[1] { P_1 }, new string[1] { P_2 });
	}

	public static void wWO9ryqdIei(string P_0, ChartDataType[] P_1, string[] P_2)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return;
		}
		int? num = default(int?);
		int num2;
		if (P_1 == null)
		{
			num = null;
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
			{
				num2 = 0;
			}
			goto IL_0009;
		}
		int? num3 = P_1.Length;
		goto IL_02de;
		IL_02de:
		int? num4 = num3;
		if (P_2 == null)
		{
			num = null;
			num2 = 3;
		}
		else
		{
			num2 = 2;
		}
		goto IL_0009;
		IL_0009:
		int? num6 = default(int?);
		Dictionary<string, int[]> obj = default(Dictionary<string, int[]>);
		ChartDataType chartDataType = default(ChartDataType);
		string key = default(string);
		string text = default(string);
		while (true)
		{
			int? num5;
			switch (num2)
			{
			case 5:
				if (num4 != num6)
				{
					return;
				}
				obj = e3X9rw4Asva;
				num2 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
				{
					num2 = 4;
				}
				continue;
			case 1:
				return;
			case 4:
			{
				bool lockTaken = false;
				try
				{
					Monitor.Enter(obj, ref lockTaken);
					int num7 = 0;
					int num8 = 5;
					while (true)
					{
						switch (num8)
						{
						case 6:
							return;
						case 4:
							switch (chartDataType)
							{
							case ChartDataType.Cluster:
								e3X9rw4Asva[key][1]++;
								num8 = 2;
								goto end_IL_00e7;
							case ChartDataType.Bar:
								e3X9rw4Asva[key][0]++;
								num8 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
								{
									num8 = 0;
								}
								goto end_IL_00e7;
							}
							goto default;
						case 2:
							if (e3X9rw4Asva[key][1] == 1)
							{
								Action<string, string, ChartDataType> action = qYr9rhOm9xj;
								if (action != null)
								{
									action(P_0, text, ChartDataType.Cluster);
									num8 = 7;
									break;
								}
							}
							goto default;
						case 5:
							if (num7 < P_1.Length)
							{
								chartDataType = P_1[num7];
								num8 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
								{
									num8 = 0;
								}
							}
							else
							{
								num8 = 6;
							}
							break;
						default:
							num7++;
							goto case 5;
						case 3:
							key = PUj9rtNxK8L(P_0, text);
							if (!e3X9rw4Asva.ContainsKey(key))
							{
								e3X9rw4Asva.Add(key, new int[2]);
								num8 = 4;
								break;
							}
							goto case 4;
						case 1:
							{
								text = P_2[num7];
								num8 = 3;
								break;
							}
							end_IL_00e7:
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
			case 3:
				num5 = num;
				goto IL_02ed;
			case 2:
				{
					num5 = P_2.Length;
					goto IL_02ed;
				}
				IL_02ed:
				num6 = num5;
				num2 = 5;
				continue;
			}
			break;
		}
		num3 = num;
		goto IL_02de;
	}

	public static void wDV9rZqc8Au(string P_0, ChartDataType P_1, string P_2)
	{
		bD9wBYbZ5Sh7UGRegsKP(P_0, new ChartDataType[1] { P_1 }, new string[1] { P_2 });
	}

	public static void mn19rVvMxuZ(string P_0, ChartDataType[] P_1, string[] P_2)
	{
		int num = 2;
		int num2 = num;
		int? num8 = default(int?);
		bool lockTaken = default(bool);
		Dictionary<string, int[]> obj = default(Dictionary<string, int[]>);
		string key = default(string);
		ChartDataType chartDataType = default(ChartDataType);
		string text = default(string);
		int? num6 = default(int?);
		while (true)
		{
			int? num5;
			int? num7;
			switch (num2)
			{
			case 2:
				if (!string.IsNullOrEmpty(P_0))
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				return;
			case 3:
				num8 = null;
				num5 = num8;
				goto IL_032a;
			default:
				num7 = num8;
				break;
			case 6:
				lockTaken = false;
				num2 = 4;
				continue;
			case 5:
				num8 = null;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				if (P_1 == null)
				{
					goto case 3;
				}
				num5 = P_1.Length;
				goto IL_032a;
			case 4:
				{
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 0;
						int num4 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
						{
							num4 = 6;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								if (e3X9rw4Asva[key][0] > 0)
								{
									num4 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
									{
										num4 = 1;
									}
									break;
								}
								goto case 4;
							case 7:
								if (chartDataType == ChartDataType.Bar)
								{
									num4 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
									{
										num4 = 0;
									}
									break;
								}
								if (chartDataType == ChartDataType.Cluster && e3X9rw4Asva[key][1] > 0)
								{
									num4 = 5;
									break;
								}
								goto case 4;
							case 1:
								e3X9rw4Asva[key][0]--;
								goto case 4;
							case 4:
								num3++;
								num4 = 2;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
								{
									num4 = 1;
								}
								break;
							case 2:
							case 6:
								if (num3 >= P_1.Length)
								{
									return;
								}
								chartDataType = P_1[num3];
								text = P_2[num3];
								key = PUj9rtNxK8L(P_0, text);
								if (e3X9rw4Asva.ContainsKey(key))
								{
									num4 = 7;
									break;
								}
								goto case 4;
							case 3:
								if (e3X9rw4Asva[key][1] == 0)
								{
									Action<string, string, ChartDataType> action = qYr9rhOm9xj;
									if (action == null)
									{
										num4 = 4;
										break;
									}
									action(P_0, text, ChartDataType.Bar);
								}
								goto case 4;
							case 5:
								e3X9rw4Asva[key][1]--;
								num4 = 3;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
								{
									num4 = 2;
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
				IL_032a:
				num6 = num5;
				if (P_2 == null)
				{
					num2 = 5;
					continue;
				}
				num7 = P_2.Length;
				break;
			}
			if (num6 != num7)
			{
				break;
			}
			obj = e3X9rw4Asva;
			num2 = 6;
		}
	}

	internal static bool pQC9rCOUwwn(string P_0, string P_1)
	{
		lock (e3X9rw4Asva)
		{
			if (!e3X9rw4Asva.TryGetValue(P_0, out var value))
			{
				goto IL_004c;
			}
			int num;
			if (value[1] <= 0)
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd != 0)
				{
					num = 1;
				}
				goto IL_0036;
			}
			int num2 = 1;
			goto IL_00d6;
			IL_0036:
			bool result = default(bool);
			switch (num)
			{
			case 1:
				break;
			default:
				goto IL_00b9;
			case 2:
				return result;
			}
			goto IL_004c;
			IL_00b9:
			int[] value2 = default(int[]);
			num2 = ((value2[1] > 0) ? 1 : 0);
			goto IL_00d6;
			IL_004c:
			if (e3X9rw4Asva.TryGetValue((string)nD37wDbZSKnVqIcrw106(P_0, P_1), out value2))
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
				{
					num = 0;
				}
				goto IL_0036;
			}
			num2 = 0;
			goto IL_00d6;
			IL_00d6:
			result = (byte)num2 != 0;
			num = 2;
			goto IL_0036;
		}
	}

	static xnWqxt9rIxkL0gKJjgWl()
	{
		XxhmIDbZxMJRXsdBUXiA();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		e3X9rw4Asva = new Dictionary<string, int[]>();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object EK8CudbZkigyup5QAqXh(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool UbHYKrbZbdv8SQ5jpJs9()
	{
		return bmyPJ0bZDi1FDTDF81rW == null;
	}

	internal static xnWqxt9rIxkL0gKJjgWl CBimW5bZNmp3pp9VckXb()
	{
		return bmyPJ0bZDi1FDTDF81rW;
	}

	internal static object aFsr2jbZ1hB1iLcivmxD(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static void bD9wBYbZ5Sh7UGRegsKP(object P_0, object P_1, object P_2)
	{
		mn19rVvMxuZ((string)P_0, (ChartDataType[])P_1, (string[])P_2);
	}

	internal static object nD37wDbZSKnVqIcrw106(object P_0, object P_1)
	{
		return PUj9rtNxK8L((string)P_0, (string)P_1);
	}

	internal static void XxhmIDbZxMJRXsdBUXiA()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
