using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Core.Utils.Logging;
using TuAMtrl1Nd3XoZQQUXf0;

namespace EFtXja9ny4ZaDEaJuMa2;

internal static class JBplhi9nTXhbb2E3caqw
{
	private static readonly Dictionary<string, string> zQJ9nVN09hI;

	private static readonly Dictionary<string, string> qe39nCY3L35;

	private static JBplhi9nTXhbb2E3caqw KHSQHbbN12qJtl4g5sQt;

	static JBplhi9nTXhbb2E3caqw()
	{
		int num = 1;
		int num2 = num;
		string[] directories = default(string[]);
		int num5 = default(int);
		string fileNameWithoutExtension2 = default(string);
		string text2 = default(string);
		int num4 = default(int);
		string[] files = default(string[]);
		string fileNameWithoutExtension = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				zQJ9nVN09hI = new Dictionary<string, string>();
				qe39nCY3L35 = new Dictionary<string, string>();
				try
				{
					string directoryName = Path.GetDirectoryName((string)iDMKSObNx5OkAsEJori3(Assembly.GetExecutingAssembly()));
					int num3;
					if (directoryName != null)
					{
						directories = Directory.GetDirectories(Path.Combine(directoryName, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1878953018 ^ -1878700060)));
						num3 = 10;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
						{
							num3 = 9;
						}
					}
					else
					{
						num3 = 4;
					}
					while (true)
					{
						switch (num3)
						{
						case 3:
							return;
						case 4:
							return;
						case 14:
							return;
						case 10:
							num5 = 0;
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 != 0)
							{
								num3 = 0;
							}
							continue;
						case 12:
							if (!zQJ9nVN09hI.ContainsKey(fileNameWithoutExtension2))
							{
								zQJ9nVN09hI.Add(fileNameWithoutExtension2, text2);
							}
							num4++;
							num3 = 7;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
							{
								num3 = 6;
							}
							continue;
						case 7:
							if (num4 >= files.Length)
							{
								num5++;
								goto default;
							}
							text2 = files[num4];
							num3 = 2;
							continue;
						case 13:
							qe39nCY3L35.Add(fileNameWithoutExtension, text);
							break;
						case 6:
							num4 = 0;
							goto case 7;
						case 2:
							fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(text2);
							num3 = 12;
							continue;
						case 5:
							files = Directory.GetFiles(directories[num5]);
							num3 = 6;
							continue;
						default:
							if (num5 >= directories.Length)
							{
								num3 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 5;
						case 1:
							if (!OHEkTvbNLfFi32JUte6o())
							{
								directories = Directory.GetDirectories((string)m5QxJDbNeqdJpQJ5cF1B(directoryName, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E001ACA)));
								num5 = 0;
								goto IL_020e;
							}
							num3 = 14;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd != 0)
							{
								num3 = 4;
							}
							continue;
						case 9:
							if (num4 < files.Length)
							{
								text = files[num4];
								fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
								if (qe39nCY3L35.ContainsKey(fileNameWithoutExtension))
								{
									num3 = 11;
									continue;
								}
								goto case 13;
							}
							num5++;
							goto IL_020e;
						case 8:
							num4 = 0;
							goto case 9;
						case 11:
							break;
							IL_020e:
							if (num5 >= directories.Length)
							{
								num3 = 3;
								continue;
							}
							files = Directory.GetFiles(directories[num5]);
							num3 = 8;
							continue;
						}
						num4++;
						num3 = 9;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
						{
							num3 = 3;
						}
					}
				}
				catch (Exception)
				{
					CsoIA8bNsbINRMEG65BX();
					return;
				}
			default:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static Assembly D0L9nZOmWmi(string P_0)
	{
		Assembly result = default(Assembly);
		try
		{
			int num;
			if (!qe39nCY3L35.ContainsKey(P_0))
			{
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
				{
					num = 1;
				}
			}
			else
			{
				result = Assembly.LoadFile(qe39nCY3L35[P_0]);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
				{
					num = 1;
				}
			}
			switch (num)
			{
			case 2:
				if (!zQJ9nVN09hI.ContainsKey(P_0))
				{
					break;
				}
				result = Assembly.LoadFile(zQJ9nVN09hI[P_0]);
				goto IL_00fb;
			case 0:
				break;
			case 1:
				goto IL_00fb;
			}
		}
		catch (Exception)
		{
			CsoIA8bNsbINRMEG65BX();
		}
		return null;
		IL_00fb:
		return result;
	}

	internal static object iDMKSObNx5OkAsEJori3(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static bool OHEkTvbNLfFi32JUte6o()
	{
		return Environment.Is64BitProcess;
	}

	internal static object m5QxJDbNeqdJpQJ5cF1B(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static void CsoIA8bNsbINRMEG65BX()
	{
		LogManager.WriteFake();
	}

	internal static bool bEJGLLbN52SxYCsumDKA()
	{
		return KHSQHbbN12qJtl4g5sQt == null;
	}

	internal static JBplhi9nTXhbb2E3caqw g0EedcbNSgvsieXDaa5E()
	{
		return KHSQHbbN12qJtl4g5sQt;
	}
}
