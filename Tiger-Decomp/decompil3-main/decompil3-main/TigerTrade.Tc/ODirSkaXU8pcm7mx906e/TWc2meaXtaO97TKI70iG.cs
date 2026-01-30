using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BfZtb759KlUg4482QKym;
using dgZJY3GhircmyNVV0iAS;
using TigerTrade.Core.Utils.Logging;
using x97CE55GhEYKgt7TSVZT;

namespace ODirSkaXU8pcm7mx906e;

[wxMJrmGhaoZN9BPmFRb2]
public static class TWc2meaXtaO97TKI70iG
{
	private static TWc2meaXtaO97TKI70iG nuHxe8xhKbwyMyUt2liC;

	[wxMJrmGhaoZN9BPmFRb2]
	public static Hashtable r9SaXTLt3K8(BinaryReader P_0)
	{
		Hashtable result = null;
		Hashtable result2 = default(Hashtable);
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			try
			{
				int num = P_0.ReadInt32();
				long num2 = P_0.BaseStream.Length - P_0.BaseStream.Position;
				int num3 = 5;
				byte[] array = default(byte[]);
				while (true)
				{
					int num4;
					switch (num3)
					{
					case 3:
						return result;
					case 5:
						if (num >= 0)
						{
							num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto IL_0140;
					case 7:
						array = (byte[])nTYxxTxhPkDrKNjv3wBZ(P_0, num);
						num3 = 4;
						continue;
					case 6:
						result2 = null;
						break;
					case 1:
						break;
					case 4:
						if (array.Length != num)
						{
							LogManager.WriteError((string)wyaXT0xh7Qkgpc0Br5OM(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7D553BE0 ^ 0x7D54CACE), num, array.Length));
							num4 = 8;
							goto IL_0029;
						}
						goto case 2;
					case 2:
					{
						BinaryFormatter binaryFormatter = new BinaryFormatter();
						memoryStream.Write(array, 0, array.Length);
						memoryStream.Seek(0L, SeekOrigin.Begin);
						result = (Hashtable)binaryFormatter.Deserialize(memoryStream);
						num4 = 3;
						goto IL_0029;
					}
					default:
						if (num <= num2)
						{
							if (num > 51200)
							{
								LogManager.WriteError(string.Format((string)FEL9D7xhwtAP4ytrI2sZ(0x6F7F734B ^ 0x6F7E8331), num));
								if (num > num2)
								{
									LogManager.WriteError(string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28BBDCA ^ 0x28A4D12), num, num2));
								}
								else
								{
									((Stream)xZmMC6xhA3gqhIaEEbaF(P_0)).Seek((long)num, SeekOrigin.Current);
								}
								result2 = null;
								break;
							}
							goto case 7;
						}
						goto IL_0140;
					case 8:
						{
							result2 = null;
							num3 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 != 0)
							{
								num3 = 1;
							}
							continue;
						}
						IL_0029:
						num3 = num4;
						continue;
						IL_0140:
						gCYM2nxh8jZ9JHExnbo4(wyaXT0xh7Qkgpc0Br5OM(FEL9D7xhwtAP4ytrI2sZ(0x741B85CB ^ 0x741A75D9), num, num2));
						num3 = 6;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 == 0)
						{
							num3 = 4;
						}
						continue;
					}
					break;
				}
			}
			finally
			{
				if (memoryStream != null)
				{
					nZSWY7xhJeRu5JMr59i1(memoryStream);
				}
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
			result2 = null;
		}
		return result2;
	}

	static TWc2meaXtaO97TKI70iG()
	{
		G5ms6fxhFXL3c1oiVktR();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object FEL9D7xhwtAP4ytrI2sZ(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object wyaXT0xh7Qkgpc0Br5OM(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void gCYM2nxh8jZ9JHExnbo4(object P_0)
	{
		LogManager.WriteError((string)P_0);
	}

	internal static object xZmMC6xhA3gqhIaEEbaF(object P_0)
	{
		return ((BinaryReader)P_0).BaseStream;
	}

	internal static object nTYxxTxhPkDrKNjv3wBZ(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	internal static void nZSWY7xhJeRu5JMr59i1(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool lPv9FIxhmteN72oHfVsd()
	{
		return nuHxe8xhKbwyMyUt2liC == null;
	}

	internal static TWc2meaXtaO97TKI70iG ktyuOSxhhnkOpacByE26()
	{
		return nuHxe8xhKbwyMyUt2liC;
	}

	internal static void G5ms6fxhFXL3c1oiVktR()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
