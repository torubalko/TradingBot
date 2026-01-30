using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using aEpmU09nz6MEoNmc0pGJ;
using ECOEgqlSad8NUJZ2Dr9n;
using f2JVnFGom8EMhUtDPoRs;
using fBHT6DGGgfdv46RGeHaP;
using KiO2evfnJMWP5FSRIWFl;
using NAudio.Wave;
using Of41k4GoTg1Qdp4KrF2m;
using TigerTrade.Core.Utils.Logging;
using TuAMtrl1Nd3XoZQQUXf0;

namespace JbtcCQfvnTuno7NXkd9W;

internal static class PPM8INfv9VK01EnoXpRO
{
	[CompilerGenerated]
	private sealed class bLbxUUn8OvhirC2bHmlj
	{
		public bool Y2bn8Iq0aab;

		public WaveOutEvent FW9n8WNuksO;

		public AudioFileReader VY5n8t88ayP;

		internal static bLbxUUn8OvhirC2bHmlj HkmucUNRUZJpLNCNgPFk;

		public bLbxUUn8OvhirC2bHmlj()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void kw8n8qAkaTB(object s, StoppedEventArgs a)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (Y2bn8Iq0aab)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
						{
							num2 = 0;
						}
						break;
					}
					try
					{
						VY5n8t88ayP.Position = 0L;
						FW9n8WNuksO.Play();
						return;
					}
					catch (Exception e2)
					{
						int num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						}
						LogManager.WriteError((string)PKdTtSNRVpPJNGdgl6o0(0x1EFE0A28 ^ 0x1EFA91EE), e2);
						Y2bn8Iq0aab = true;
						try
						{
							FW9n8WNuksO.Dispose();
							VY5n8t88ayP.Dispose();
							return;
						}
						catch
						{
							return;
						}
					}
				default:
					try
					{
						FW9n8WNuksO.Dispose();
						d9SvIoNRZhhqqlvxKHKo(VY5n8t88ayP);
						return;
					}
					catch (Exception e)
					{
						LogManager.WriteError(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1AB79299 ^ 0x1AB309F7), e);
						return;
					}
				}
			}
		}

		static bLbxUUn8OvhirC2bHmlj()
		{
			AyvHcuNRCKfD4rNcoSHd();
		}

		internal static bool sGaPSuNRT9HZB1UBRm0E()
		{
			return HkmucUNRUZJpLNCNgPFk == null;
		}

		internal static bLbxUUn8OvhirC2bHmlj hfXI56NRy3qvNYsUOTu0()
		{
			return HkmucUNRUZJpLNCNgPFk;
		}

		internal static void d9SvIoNRZhhqqlvxKHKo(object P_0)
		{
			((Stream)P_0).Dispose();
		}

		internal static object PKdTtSNRVpPJNGdgl6o0(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static void AyvHcuNRCKfD4rNcoSHd()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct Yqb0ZLn8UPY0bZtTF5Im : IAsyncStateMachine
	{
		public int AAXn8TUJ2SD;

		public AsyncVoidMethodBuilder Nckn8yg2nlh;

		public string yVcn8ZG7K6F;

		public int o49n8VAuuvC;

		public int VHHn8CePeU5;

		private bLbxUUn8OvhirC2bHmlj gmGn8rpGyhu;

		private TaskAwaiter je7n8K6DBYo;

		internal static object acHmlLNRrkpAI2AwyTZS;

		private void MoveNext()
		{
			int num = AAXn8TUJ2SD;
			try
			{
				if (num != 0)
				{
					goto IL_0055;
				}
				goto IL_006a;
				IL_006a:
				int num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
				{
					num2 = 1;
				}
				switch (num2)
				{
				default:
					goto end_IL_0025;
				case 2:
					break;
				case 1:
					try
					{
						TaskAwaiter awaiter = default(TaskAwaiter);
						int num3;
						if (num == 0)
						{
							awaiter = je7n8K6DBYo;
							je7n8K6DBYo = default(TaskAwaiter);
							num = (AAXn8TUJ2SD = -1);
							num3 = 6;
						}
						else
						{
							gmGn8rpGyhu = new bLbxUUn8OvhirC2bHmlj();
							if (WaveOut.DeviceCount != 0)
							{
								gmGn8rpGyhu.FW9n8WNuksO = new WaveOutEvent
								{
									Volume = (float)Math.Max(0.1, Math.Min((double)o49n8VAuuvC / 10.0, 1.0))
								};
								gmGn8rpGyhu.VY5n8t88ayP = new AudioFileReader(yVcn8ZG7K6F);
								gmGn8rpGyhu.Y2bn8Iq0aab = false;
								num3 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
								{
									num3 = 1;
								}
							}
							else
							{
								num3 = 9;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
								{
									num3 = 6;
								}
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								qsSXOPNRw4VItpS3B7pi(gmGn8rpGyhu.FW9n8WNuksO);
								if (VHHn8CePeU5 <= 0)
								{
									gmGn8rpGyhu.Y2bn8Iq0aab = true;
									gmGn8rpGyhu.FW9n8WNuksO.Play();
									goto IL_017a;
								}
								num3 = 3;
								continue;
							case 2:
								num = (AAXn8TUJ2SD = 0);
								je7n8K6DBYo = awaiter;
								Nckn8yg2nlh.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 3;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
								{
									num3 = 11;
								}
								continue;
							case 10:
								awaiter = Task.Delay(TimeSpan.FromSeconds(VHHn8CePeU5), CancellationToken.None).GetAwaiter();
								num3 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
								{
									num3 = 0;
								}
								continue;
							case 4:
								break;
							case 9:
								bafECINRh04B5OLh3EYo(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D35A8DD));
								num3 = 4;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								gmGn8rpGyhu.FW9n8WNuksO.PlaybackStopped += gmGn8rpGyhu.kw8n8qAkaTB;
								num3 = 7;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
								{
									num3 = 3;
								}
								continue;
							case 11:
								return;
							case 3:
								gmGn8rpGyhu.FW9n8WNuksO.Play();
								num3 = 10;
								continue;
							case 6:
								awaiter.GetResult();
								num3 = 8;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
								{
									num3 = 8;
								}
								continue;
							case 8:
								gmGn8rpGyhu.Y2bn8Iq0aab = true;
								sU6TKJNR70BYLSpDnnJo(gmGn8rpGyhu.FW9n8WNuksO);
								goto IL_017a;
							case 7:
								gmGn8rpGyhu.FW9n8WNuksO.Init(gmGn8rpGyhu.VY5n8t88ayP);
								num3 = 5;
								continue;
							default:
								{
									if (!awaiter.IsCompleted)
									{
										num3 = 2;
										continue;
									}
									goto case 6;
								}
								IL_017a:
								gmGn8rpGyhu = null;
								break;
							}
							break;
						}
					}
					catch (Exception e)
					{
						LogManager.WriteError(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x34407BB ^ 0x3409BCB), e);
					}
					goto end_IL_0025;
				case 0:
					goto end_IL_0025;
				}
				goto IL_0055;
				IL_0055:
				if (!string.IsNullOrEmpty(yVcn8ZG7K6F) && File.Exists(yVcn8ZG7K6F))
				{
					goto IL_006a;
				}
				end_IL_0025:;
			}
			catch (Exception exception)
			{
				AAXn8TUJ2SD = -2;
				Nckn8yg2nlh.SetException(exception);
				int num4 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
				return;
			}
			AAXn8TUJ2SD = -2;
			Nckn8yg2nlh.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			Nckn8yg2nlh.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static Yqb0ZLn8UPY0bZtTF5Im()
		{
			V8pZwNNR8QmhrTZSKV3i();
		}

		internal static void bafECINRh04B5OLh3EYo(object P_0)
		{
			LogManager.WriteInfo((string)P_0);
		}

		internal static void qsSXOPNRw4VItpS3B7pi(object P_0)
		{
			((WaveOutEvent)P_0).Play();
		}

		internal static void sU6TKJNR70BYLSpDnnJo(object P_0)
		{
			((WaveOutEvent)P_0).Stop();
		}

		internal static bool Wo9kyVNRKvoSXfNbo15v()
		{
			return acHmlLNRrkpAI2AwyTZS == null;
		}

		internal static object tZcv1RNRmSHd8yBfAd2e()
		{
			return acHmlLNRrkpAI2AwyTZS;
		}

		internal static void V8pZwNNR8QmhrTZSKV3i()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[CompilerGenerated]
	private static readonly List<string> k4dfvk4YR8x;

	[CompilerGenerated]
	private static readonly List<string> torfv1eo4iZ;

	[CompilerGenerated]
	private static readonly List<string> yfafv5TMmVM;

	private static string Dx5fvSwHpUO;

	private static string An1fvxxIugA;

	private static string kPwfvLYTf0K;

	private static readonly vCn3XRGoKVvafsvAHLC0 Player;

	private static readonly slmhRGGGdUolw80JrkF4 hlTfveMf8nK;

	private static readonly object KIvfvslcdHV;

	private static string pXDfvXpPump;

	private static DateTime VfWfvcn16dx;

	private static PPM8INfv9VK01EnoXpRO Q9TLt6DrFUfDASvsKmLH;

	[SpecialName]
	[CompilerGenerated]
	public static List<string> ipNfvio6OFp()
	{
		return k4dfvk4YR8x;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<string> k8xfv4kERpL()
	{
		return torfv1eo4iZ;
	}

	[SpecialName]
	[CompilerGenerated]
	public static List<string> DWefvbI6fZt()
	{
		return yfafv5TMmVM;
	}

	static PPM8INfv9VK01EnoXpRO()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				KIvfvslcdHV = new object();
				k4dfvk4YR8x = new List<string>();
				torfv1eo4iZ = new List<string>();
				yfafv5TMmVM = new List<string>();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				Player = new TRZpYMfnPmuWrJM1KiAr();
				break;
			case 1:
				if (j18iDj9nukSCmEyZs5lH.nUi9vUo9G42)
				{
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto default;
			case 3:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 2;
				continue;
			case 4:
				Player = new NHpwW4GoUQLCJDZZpJg3();
				break;
			}
			break;
		}
		hlTfveMf8nK = new slmhRGGGdUolw80JrkF4();
	}

	public static void gc7fvG1VEQo()
	{
		VQEfvYk6a6Y(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-710503328 ^ -710503760), ipNfvio6OFp());
		VQEfvYk6a6Y(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1416986301 ^ -1416721517), k8xfv4kERpL());
		VQEfvYk6a6Y(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-3429745 ^ -3170221), DWefvbI6fZt());
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private static void VQEfvYk6a6Y(string P_0, List<string> P_1)
	{
		try
		{
			string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			if (string.IsNullOrEmpty(directoryName))
			{
				return;
			}
			string text = Path.Combine(directoryName, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1192989954 ^ -1193254892), P_0);
			if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x706541F3 ^ 0x70654723)))
			{
				if (!(P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2074141628 ^ -2074405228)))
				{
					if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1878953018 ^ -1878689510))
					{
						kPwfvLYTf0K = text;
					}
				}
				else
				{
					An1fvxxIugA = text;
				}
			}
			else
			{
				Dx5fvSwHpUO = text;
			}
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			string[] files = Directory.GetFiles(text, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1346994499 ^ -1347259321));
			P_1.AddRange(files.Select(Path.GetFileNameWithoutExtension));
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
	}

	public static void oSVfvocGSUI(string P_0, int P_1)
	{
		if (!string.IsNullOrEmpty(P_0))
		{
			PlaySound((string)ubUBRxDrzlYiF88ZiYRc(Dx5fvSwHpUO, P_0 + (string)vRW9MeDruDVBqG50O1Nw(-225822163 ^ -225562331)), P_1);
		}
	}

	public static void LvifvvFF118()
	{
		hlTfveMf8nK.bIZGGq4jlH8();
	}

	public static void TwdfvBBcAR9(string P_0)
	{
		try
		{
			int num;
			string text = default(string);
			if (string.IsNullOrEmpty(P_0))
			{
				num = 2;
			}
			else
			{
				text = Path.Combine(kPwfvLYTf0K, (string)tlvFLCDK0V74QtJ73WFR(P_0, vRW9MeDruDVBqG50O1Nw(0x2BD86B18 ^ 0x2BDC6010)));
				num = 6;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 3:
					return;
				case 4:
					return;
				case 5:
					return;
				case 6:
					if (YW8dGNDK2ck0lRIiSfDC(text) || !File.Exists(text))
					{
						return;
					}
					if (!pP8vbODKHq9nR19gqbf3(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1774602229 ^ -1774630057)))
					{
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
						{
							num = 0;
						}
						continue;
					}
					XuiisDDKfmeQGRQRQAFL(hlTfveMf8nK, text);
					num = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
					{
						num = 0;
					}
					continue;
				default:
					if (VfWfvcn16dx != DateTime.MinValue)
					{
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				case 1:
					if (myRhSoDKGN3DPdbbl7PJ(eAVsVNDK9EGywJ5dgWvu() - VfWfvcn16dx, w1LF7mDKne6G4Afw6WOa(1000.0)))
					{
						return;
					}
					break;
				}
				break;
			}
			pXDfvXpPump = text;
			VfWfvcn16dx = eAVsVNDK9EGywJ5dgWvu();
			lock (KIvfvslcdHV)
			{
				int num2;
				if (P_0 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C435F8))
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
					{
						num2 = 1;
					}
					goto IL_0100;
				}
				goto IL_0171;
				IL_0100:
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					break;
				}
				hlTfveMf8nK.bIZGGq4jlH8();
				goto IL_0171;
				IL_0171:
				dtvFxIDKYcXCvqG52gdX(hlTfveMf8nK);
				vrbX9iDKoZMKO6AwWEbA(hlTfveMf8nK, text);
				hlTfveMf8nK.Q2mGGMJKxto();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
				{
					num2 = 0;
				}
				goto IL_0100;
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
	}

	public static void AGCfvafhMkf(string P_0, int P_1, int P_2)
	{
		if (!string.IsNullOrEmpty(P_0))
		{
			E5eMHFDKvtRqLg6sl7fr(Path.Combine(An1fvxxIugA, P_0 + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009258113)), P_1, P_2);
		}
	}

	private static void PlaySound(string soundFile, int volume)
	{
		int num = 3;
		int num2 = num;
		object kIvfvslcdHV = default(object);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!string.IsNullOrEmpty(soundFile))
				{
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				return;
			case 1:
				kIvfvslcdHV = KIvfvslcdHV;
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				if (pXDfvXpPump == soundFile && FgsqkWDKa7eOTpewkhwU(VfWfvcn16dx, DateTime.MinValue) && myRhSoDKGN3DPdbbl7PJ(DateTime.Now - VfWfvcn16dx, TimeSpan.FromMilliseconds(700.0)))
				{
					return;
				}
				goto IL_00a8;
			case 2:
				{
					if (!g4Au9ADKBlNO7K7DgsaP(soundFile))
					{
						return;
					}
					if (!string.IsNullOrEmpty(pXDfvXpPump))
					{
						num2 = 4;
						continue;
					}
					goto IL_00a8;
				}
				IL_00a8:
				pXDfvXpPump = soundFile;
				VfWfvcn16dx = eAVsVNDK9EGywJ5dgWvu();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				Monitor.Enter(kIvfvslcdHV, ref lockTaken);
				int num3 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
				{
					num3 = 0;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						grQ8fMDKiORc9QsCwgic(Player);
						UvPL7vDKlaac5b7Vrep7(Player, soundFile);
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec == 0)
						{
							num3 = 0;
						}
						break;
					default:
						QSmRSfDKbad0tSshqKJB(Player, CYFlDiDKDiePrRxUTtWZ(0.1, k9xfgPDK4FW09yq6Vtq9((double)volume / 10.0, 1.0)));
						Player.Fy1l9cyZWeh();
						return;
					}
				}
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(kIvfvslcdHV);
				}
			}
		}
	}

	[AsyncStateMachine(typeof(Yqb0ZLn8UPY0bZtTF5Im))]
	private static void PlaySound(string soundFile, int duration, int volume)
	{
		Yqb0ZLn8UPY0bZtTF5Im stateMachine = default(Yqb0ZLn8UPY0bZtTF5Im);
		stateMachine.Nckn8yg2nlh = AsyncVoidMethodBuilder.Create();
		stateMachine.yVcn8ZG7K6F = soundFile;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine.Nckn8yg2nlh.Start(ref stateMachine);
				return;
			}
			stateMachine.VHHn8CePeU5 = duration;
			stateMachine.o49n8VAuuvC = volume;
			stateMachine.AAXn8TUJ2SD = -1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool PtxteUDr3AhtYgZwIhHh()
	{
		return Q9TLt6DrFUfDASvsKmLH == null;
	}

	internal static PPM8INfv9VK01EnoXpRO Wo2KO6DrpQhhUUKW2vaK()
	{
		return Q9TLt6DrFUfDASvsKmLH;
	}

	internal static object vRW9MeDruDVBqG50O1Nw(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object ubUBRxDrzlYiF88ZiYRc(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object tlvFLCDK0V74QtJ73WFR(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool YW8dGNDK2ck0lRIiSfDC(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool pP8vbODKHq9nR19gqbf3(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void XuiisDDKfmeQGRQRQAFL(object P_0, object P_1)
	{
		((slmhRGGGdUolw80JrkF4)P_0).abIGGOm0IKj((string)P_1);
	}

	internal static DateTime eAVsVNDK9EGywJ5dgWvu()
	{
		return DateTime.Now;
	}

	internal static TimeSpan w1LF7mDKne6G4Afw6WOa(double P_0)
	{
		return TimeSpan.FromMilliseconds(P_0);
	}

	internal static bool myRhSoDKGN3DPdbbl7PJ(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 < P_1;
	}

	internal static void dtvFxIDKYcXCvqG52gdX(object P_0)
	{
		((slmhRGGGdUolw80JrkF4)P_0).UsQGG6BuPR7();
	}

	internal static void vrbX9iDKoZMKO6AwWEbA(object P_0, object P_1)
	{
		((slmhRGGGdUolw80JrkF4)P_0).gNEGGRWuTCe((string)P_1);
	}

	internal static void E5eMHFDKvtRqLg6sl7fr(object P_0, int duration, int volume)
	{
		PlaySound((string)P_0, duration, volume);
	}

	internal static bool g4Au9ADKBlNO7K7DgsaP(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static bool FgsqkWDKa7eOTpewkhwU(DateTime P_0, DateTime P_1)
	{
		return P_0 != P_1;
	}

	internal static void grQ8fMDKiORc9QsCwgic(object P_0)
	{
		((vCn3XRGoKVvafsvAHLC0)P_0).Stop();
	}

	internal static void UvPL7vDKlaac5b7Vrep7(object P_0, object P_1)
	{
		((vCn3XRGoKVvafsvAHLC0)P_0).Open((string)P_1);
	}

	internal static double k9xfgPDK4FW09yq6Vtq9(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static double CYFlDiDKDiePrRxUTtWZ(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void QSmRSfDKbad0tSshqKJB(object P_0, double P_1)
	{
		((vCn3XRGoKVvafsvAHLC0)P_0).Dsol9eLTWeh = P_1;
	}
}
