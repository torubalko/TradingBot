using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using aEpmU09nz6MEoNmc0pGJ;
using Cd9gDBHe7p0apEd7AdMg;
using ECOEgqlSad8NUJZ2Dr9n;
using gye4ecHbAhUURhS3ga;
using Newtonsoft.Json;
using TigerTrade.Core.Utils.Logging;
using TuAMtrl1Nd3XoZQQUXf0;

namespace PM3qWdHIib5KwN8KfVYB;

internal class YBaxiwHIaqg0ZAjd8CAL
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct koHuKDnmPCsD17HgIf8U : IAsyncStateMachine
	{
		public int qVAnmJSeY7o;

		public AsyncTaskMethodBuilder<HUvclsHewvbEZGvt3TVD> v1XnmFe7LXK;

		public YBaxiwHIaqg0ZAjd8CAL g8mnm3ySHvH;

		public string tl3nmpP2BBZ;

		private HttpResponseMessage A66nmuPjWHT;

		private string L4onmzSPtI4;

		private string XkHnh07UBu1;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter XW5nh2AoFPC;

		private TaskAwaiter<string> QwNnhH4bVLv;

		internal static object lOpB13NEuSxGOitRfgvP;

		private void MoveNext()
		{
			int num = qVAnmJSeY7o;
			YBaxiwHIaqg0ZAjd8CAL yBaxiwHIaqg0ZAjd8CAL = g8mnm3ySHvH;
			HUvclsHewvbEZGvt3TVD result2;
			try
			{
				if ((uint)num > 1u)
				{
					A66nmuPjWHT = null;
					L4onmzSPtI4 = string.Empty;
					int num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							XkHnh07UBu1 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x42D899B5 ^ 0x42DC0D05);
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					}
				}
				try
				{
					int num3;
					ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
					if (num != 0)
					{
						num3 = 5;
					}
					else
					{
						awaiter = XW5nh2AoFPC;
						num3 = 3;
					}
					TaskAwaiter<string> awaiter2 = default(TaskAwaiter<string>);
					ConfiguredTaskAwaitable<HttpResponseMessage> configuredTaskAwaitable = default(ConfiguredTaskAwaitable<HttpResponseMessage>);
					string result = default(string);
					while (true)
					{
						HttpResponseMessage result3;
						switch (num3)
						{
						case 10:
							v1XnmFe7LXK.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						case 4:
							awaiter = configuredTaskAwaitable.GetAwaiter();
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
							{
								num3 = 0;
							}
							continue;
						case 7:
							QwNnhH4bVLv = default(TaskAwaiter<string>);
							num = (qVAnmJSeY7o = -1);
							num3 = 2;
							continue;
						case 2:
							result = awaiter2.GetResult();
							num3 = 11;
							continue;
						case 1:
							configuredTaskAwaitable = yBaxiwHIaqg0ZAjd8CAL.QJuHIDMffkI(XkHnh07UBu1, new b2L9F92gx63f5rMQcH<string>(tl3nmpP2BBZ)).ConfigureAwait(continueOnCapturedContext: false);
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
							{
								num3 = 4;
							}
							continue;
						case 6:
							v1XnmFe7LXK.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 9:
							XW5nh2AoFPC = awaiter;
							num3 = 6;
							continue;
						case 5:
							if (num == 1)
							{
								awaiter2 = QwNnhH4bVLv;
								num3 = 7;
								continue;
							}
							num3 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
							{
								num3 = 1;
							}
							continue;
						default:
							if (!awaiter.IsCompleted)
							{
								num = (qVAnmJSeY7o = 0);
								int num4 = 9;
								num3 = num4;
								continue;
							}
							goto IL_02fd;
						case 3:
							XW5nh2AoFPC = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
							num = (qVAnmJSeY7o = -1);
							goto IL_02fd;
						case 8:
							QwNnhH4bVLv = awaiter2;
							num3 = 10;
							continue;
						case 11:
							{
								L4onmzSPtI4 = result;
								A66nmuPjWHT.EnsureSuccessStatusCode();
								result2 = (HUvclsHewvbEZGvt3TVD)10000;
								break;
							}
							IL_02fd:
							result3 = awaiter.GetResult();
							A66nmuPjWHT = result3;
							awaiter2 = A66nmuPjWHT.Content.ReadAsStringAsync().GetAwaiter();
							if (awaiter2.IsCompleted)
							{
								goto case 2;
							}
							num = (qVAnmJSeY7o = 1);
							num3 = 8;
							continue;
						}
						break;
					}
				}
				catch (HttpRequestException)
				{
					int num5 = 2;
					HUvclsHewvbEZGvt3TVD hUvclsHewvbEZGvt3TVD = default(HUvclsHewvbEZGvt3TVD);
					while (true)
					{
						switch (num5)
						{
						case 3:
							LogManager.WriteError(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D58E1B), 31010));
							result2 = (HUvclsHewvbEZGvt3TVD)31010;
							goto end_IL_036a;
						case 2:
							if (A66nmuPjWHT != null)
							{
								num5 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
								{
									num5 = 1;
								}
							}
							else
							{
								LogManager.WriteError(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1522697859 ^ -1522929413) + L4onmzSPtI4);
								num5 = 3;
							}
							break;
						default:
							LogManager.WriteError((string)GErqWtNQ2TD64RgSHufg(-842040449 ^ -842272007) + L4onmzSPtI4);
							num5 = 4;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
							{
								num5 = 3;
							}
							break;
						case 4:
							LogManager.WriteError((string)nHS4vbNQfWBKacc2SiHE(string.Format((string)GErqWtNQ2TD64RgSHufg(0x12620268 ^ 0x126691B8), (int)LElfyLNQHeK4Y4eiab7P(A66nmuPjWHT)), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1161619942 ^ -1161322522), A66nmuPjWHT.ReasonPhrase));
							LogManager.WriteError(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BA275A), (int)hUvclsHewvbEZGvt3TVD));
							goto IL_0388;
						case 1:
							{
								hUvclsHewvbEZGvt3TVD = yBaxiwHIaqg0ZAjd8CAL.vIMHIklnvlI(A66nmuPjWHT.StatusCode);
								if (hUvclsHewvbEZGvt3TVD == (HUvclsHewvbEZGvt3TVD)31900)
								{
									LogManager.WriteError((string)GErqWtNQ2TD64RgSHufg(-842040449 ^ -842274627) + yBaxiwHIaqg0ZAjd8CAL.I7lHI11cqDB + XkHnh07UBu1);
									num5 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
									{
										num5 = 0;
									}
									break;
								}
								goto IL_0388;
							}
							IL_0388:
							result2 = hUvclsHewvbEZGvt3TVD;
							goto end_IL_036a;
						}
						continue;
						end_IL_036a:
						break;
					}
				}
				catch (Exception)
				{
					int num6 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
					{
						num6 = 0;
					}
					switch (num6)
					{
					default:
						LogManager.WriteError((string)T1dyuxNQ9ccjQqQf8otS(GErqWtNQ2TD64RgSHufg(-1153206687 ^ -1152909337), L4onmzSPtI4));
						LogManager.WriteError(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D58E1B), 31900));
						result2 = (HUvclsHewvbEZGvt3TVD)31900;
						break;
					}
				}
			}
			catch (Exception exception)
			{
				qVAnmJSeY7o = -2;
				A66nmuPjWHT = null;
				int num7 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
				{
					num7 = 1;
				}
				while (true)
				{
					switch (num7)
					{
					case 1:
						L4onmzSPtI4 = null;
						num7 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
						{
							num7 = 0;
						}
						break;
					default:
						XkHnh07UBu1 = null;
						v1XnmFe7LXK.SetException(exception);
						return;
					}
				}
			}
			qVAnmJSeY7o = -2;
			int num8 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
			{
				num8 = 0;
			}
			while (true)
			{
				switch (num8)
				{
				case 1:
					XkHnh07UBu1 = null;
					num8 = 2;
					continue;
				case 2:
					v1XnmFe7LXK.SetResult(result2);
					return;
				}
				A66nmuPjWHT = null;
				L4onmzSPtI4 = null;
				num8 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
				{
					num8 = 1;
				}
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			v1XnmFe7LXK.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static koHuKDnmPCsD17HgIf8U()
		{
			XS4rsGNQn61n2cC9DpCP();
		}

		internal static object GErqWtNQ2TD64RgSHufg(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static HttpStatusCode LElfyLNQHeK4Y4eiab7P(object P_0)
		{
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		internal static object nHS4vbNQfWBKacc2SiHE(object P_0, object P_1, object P_2)
		{
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		internal static object T1dyuxNQ9ccjQqQf8otS(object P_0, object P_1)
		{
			return (string)P_0 + (string)P_1;
		}

		internal static bool GFbpSFNEzuSwr4NlpcVi()
		{
			return lOpB13NEuSxGOitRfgvP == null;
		}

		internal static object BMFclhNQ0RwtINuQZwBy()
		{
			return lOpB13NEuSxGOitRfgvP;
		}

		internal static void XS4rsGNQn61n2cC9DpCP()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct RvCdVinhfQPsPQMBdM96 : IAsyncStateMachine
	{
		public int k4Ynh9DgIO2;

		public AsyncTaskMethodBuilder<HUvclsHewvbEZGvt3TVD> skQnhn5Y8cm;

		public YBaxiwHIaqg0ZAjd8CAL xo5nhGgVpQf;

		public string BAknhYI9OoU;

		private HttpResponseMessage U2LnhotxCNb;

		private string NW2nhvbmwUU;

		private string xvFnhBhp4rJ;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter C3YnhauoAHb;

		private TaskAwaiter<string> FbEnhij9E9b;

		private static object akgnsNNQGS8nRYfH9KWW;

		private void MoveNext()
		{
			int num = k4Ynh9DgIO2;
			YBaxiwHIaqg0ZAjd8CAL yBaxiwHIaqg0ZAjd8CAL = xo5nhGgVpQf;
			HUvclsHewvbEZGvt3TVD result3;
			try
			{
				int num2;
				if ((uint)num > 1u)
				{
					U2LnhotxCNb = null;
					NW2nhvbmwUU = string.Empty;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
					{
						num2 = 1;
					}
					goto IL_00a9;
				}
				goto IL_00bb;
				IL_00a9:
				switch (num2)
				{
				case 1:
					xvFnhBhp4rJ = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1487846E ^ 0x148310B4);
					break;
				default:
					try
					{
						int num3;
						if (num != 0)
						{
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
							{
								num3 = 0;
							}
							goto IL_014e;
						}
						goto IL_02cc;
						IL_014e:
						TaskAwaiter<string> awaiter = default(TaskAwaiter<string>);
						ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter2 = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
						while (true)
						{
							HttpResponseMessage result;
							switch (num3)
							{
							case 5:
								return;
							case 4:
							{
								string result2 = awaiter.GetResult();
								NW2nhvbmwUU = result2;
								U2LnhotxCNb.EnsureSuccessStatusCode();
								result3 = (HUvclsHewvbEZGvt3TVD)10000;
								goto end_IL_014e;
							}
							case 10:
								num = (k4Ynh9DgIO2 = 1);
								num3 = 11;
								continue;
							case 9:
								C3YnhauoAHb = awaiter2;
								skQnhn5Y8cm.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							default:
								if (num == 1)
								{
									goto case 6;
								}
								awaiter2 = yBaxiwHIaqg0ZAjd8CAL.QJuHIDMffkI(xvFnhBhp4rJ, new b2L9F92gx63f5rMQcH<string>(BAknhYI9OoU)).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num = (k4Ynh9DgIO2 = 0);
									num3 = 9;
									continue;
								}
								goto IL_02e7;
							case 3:
								skQnhn5Y8cm.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num3 = 5;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
								{
									num3 = 5;
								}
								continue;
							case 6:
								awaiter = FbEnhij9E9b;
								FbEnhij9E9b = default(TaskAwaiter<string>);
								num3 = 8;
								continue;
							case 2:
								break;
							case 11:
								FbEnhij9E9b = awaiter;
								num3 = 3;
								continue;
							case 8:
							{
								num = (k4Ynh9DgIO2 = -1);
								int num4 = 4;
								num3 = num4;
								continue;
							}
							case 1:
								awaiter = ((HttpContent)Dc0SMDNQvoXMupPHGpTI(U2LnhotxCNb)).ReadAsStringAsync().GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num3 = 10;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 != 0)
									{
										num3 = 9;
									}
									continue;
								}
								goto case 4;
							case 7:
								{
									num = (k4Ynh9DgIO2 = -1);
									goto IL_02e7;
								}
								IL_02e7:
								result = awaiter2.GetResult();
								U2LnhotxCNb = result;
								num3 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto IL_02cc;
							continue;
							end_IL_014e:
							break;
						}
						goto end_IL_0129;
						IL_02cc:
						awaiter2 = C3YnhauoAHb;
						C3YnhauoAHb = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
						num3 = 7;
						goto IL_014e;
						end_IL_0129:;
					}
					catch (HttpRequestException)
					{
						int num5 = 2;
						HUvclsHewvbEZGvt3TVD hUvclsHewvbEZGvt3TVD = default(HUvclsHewvbEZGvt3TVD);
						while (true)
						{
							switch (num5)
							{
							case 2:
								if (U2LnhotxCNb != null)
								{
									hUvclsHewvbEZGvt3TVD = yBaxiwHIaqg0ZAjd8CAL.lEhHIN3uXQp(U2LnhotxCNb.StatusCode);
									if (hUvclsHewvbEZGvt3TVD == (HUvclsHewvbEZGvt3TVD)30900)
									{
										num5 = 4;
										continue;
									}
									goto default;
								}
								goto case 1;
							case 4:
								LogManager.WriteError((string)FTJkL1NQBKLKLBRlyM8l(-2108526692 ^ -2108228514) + yBaxiwHIaqg0ZAjd8CAL.I7lHI11cqDB + xvFnhBhp4rJ);
								LogManager.WriteError(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--927068468 ^ 0x374578B2) + NW2nhvbmwUU);
								Rgk5ikNQlYW4PHLJ0jFA(odIKRjNQiHgV6TNNxHEl(string.Format((string)FTJkL1NQBKLKLBRlyM8l(0xAD5B8B3 ^ 0xAD12CF5), (int)U2LnhotxCNb.StatusCode), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xB15786A ^ 0xB11F196), A1ZO7PNQa4uhSVIuBdRw(U2LnhotxCNb)));
								LogManager.WriteError(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-44540535 ^ -44247143), (int)hUvclsHewvbEZGvt3TVD));
								num5 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
								{
									num5 = 0;
								}
								continue;
							default:
								result3 = hUvclsHewvbEZGvt3TVD;
								break;
							case 1:
								LogManager.WriteError(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-837284864 ^ -836991610) + NW2nhvbmwUU);
								num5 = 3;
								continue;
							case 3:
								LogManager.WriteError(string.Format((string)FTJkL1NQBKLKLBRlyM8l(0x11D1040B ^ 0x11D58E1B), 30010));
								result3 = (HUvclsHewvbEZGvt3TVD)30010;
								break;
							}
							break;
						}
					}
					catch (Exception)
					{
						LogManager.WriteError((string)FTJkL1NQBKLKLBRlyM8l(0x6AB40973 ^ 0x6AB080F5) + NW2nhvbmwUU);
						Rgk5ikNQlYW4PHLJ0jFA(string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--146713930 ^ 0x8BA275A), 30900));
						int num6 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
						{
							num6 = 0;
						}
						result3 = num6 switch
						{
							_ => (HUvclsHewvbEZGvt3TVD)30900, 
						};
					}
					goto end_IL_0098;
				}
				goto IL_00bb;
				IL_00bb:
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
				{
					num2 = 0;
				}
				goto IL_00a9;
				end_IL_0098:;
			}
			catch (Exception exception)
			{
				int num7 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
				{
					num7 = 0;
				}
				while (true)
				{
					switch (num7)
					{
					case 1:
						NW2nhvbmwUU = null;
						xvFnhBhp4rJ = null;
						skQnhn5Y8cm.SetException(exception);
						return;
					}
					k4Ynh9DgIO2 = -2;
					U2LnhotxCNb = null;
					num7 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
					{
						num7 = 1;
					}
				}
			}
			while (true)
			{
				k4Ynh9DgIO2 = -2;
				int num8 = 2;
				while (true)
				{
					switch (num8)
					{
					default:
						return;
					case 0:
						return;
					case 2:
						U2LnhotxCNb = null;
						NW2nhvbmwUU = null;
						xvFnhBhp4rJ = null;
						skQnhn5Y8cm.SetResult(result3);
						num8 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
						{
							num8 = 0;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			skQnhn5Y8cm.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static RvCdVinhfQPsPQMBdM96()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static object Dc0SMDNQvoXMupPHGpTI(object P_0)
		{
			return ((HttpResponseMessage)P_0).Content;
		}

		internal static object FTJkL1NQBKLKLBRlyM8l(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static object A1ZO7PNQa4uhSVIuBdRw(object P_0)
		{
			return ((HttpResponseMessage)P_0).ReasonPhrase;
		}

		internal static object odIKRjNQiHgV6TNNxHEl(object P_0, object P_1, object P_2)
		{
			return (string)P_0 + (string)P_1 + (string)P_2;
		}

		internal static void Rgk5ikNQlYW4PHLJ0jFA(object P_0)
		{
			LogManager.WriteError((string)P_0);
		}

		internal static bool FwhmUeNQYVQsuZhx8cjE()
		{
			return akgnsNNQGS8nRYfH9KWW == null;
		}

		internal static object zDpU4SNQotyEP7JwbLjL()
		{
			return akgnsNNQGS8nRYfH9KWW;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct mQ88ilnhl7fGLlKI06R9 : IAsyncStateMachine
	{
		public int Raonh4XaFNb;

		public AsyncTaskMethodBuilder<HttpResponseMessage> AjsnhDOJY9F;

		public YBaxiwHIaqg0ZAjd8CAL seCnhb7FfyL;

		public object VCDnhN0gW5k;

		public string YDSnhk5Knht;

		private HttpClient fCfnh1bQuKP;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter ovcnh5Xa9p5;

		internal static object kAHWnLNQ4Yq54ajbEctI;

		private void MoveNext()
		{
			int num = Raonh4XaFNb;
			YBaxiwHIaqg0ZAjd8CAL yBaxiwHIaqg0ZAjd8CAL = seCnhb7FfyL;
			HttpResponseMessage result = default(HttpResponseMessage);
			try
			{
				if (num != 0)
				{
					fCfnh1bQuKP = yBaxiwHIaqg0ZAjd8CAL.oA5HIbTwNM1();
					int num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
				}
				try
				{
					ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter awaiter;
					int num3;
					if (num == 0)
					{
						awaiter = ovcnh5Xa9p5;
						ovcnh5Xa9p5 = default(ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter);
						num = (Raonh4XaFNb = -1);
						num3 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
						{
							num3 = 2;
						}
						goto IL_00bc;
					}
					goto IL_01a4;
					IL_00bc:
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						case 2:
							if (awaiter.IsCompleted)
							{
								goto case 3;
							}
							num = (Raonh4XaFNb = 0);
							num3 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
							{
								num3 = 5;
							}
							continue;
						case 5:
							ovcnh5Xa9p5 = awaiter;
							AjsnhDOJY9F.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num3 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
							{
								num3 = 1;
							}
							continue;
						case 3:
							result = awaiter.GetResult();
							num3 = 4;
							continue;
						case 4:
							goto end_IL_00bc;
						}
						goto IL_01a4;
						continue;
						end_IL_00bc:
						break;
					}
					goto end_IL_00ac;
					IL_01a4:
					StringContent content = new StringContent(JsonConvert.SerializeObject(VCDnhN0gW5k), Encoding.UTF8, (string)CANO3nNQNvb4fjR0HUIa(0x1AB79299 ^ 0x1AB473BD));
					awaiter = fCfnh1bQuKP.PostAsync(YDSnhk5Knht, content).ConfigureAwait(continueOnCapturedContext: false).GetAwaiter();
					num3 = 2;
					goto IL_00bc;
					end_IL_00ac:;
				}
				catch (Exception ex)
				{
					JfJfDFNQ1TxwCC6CtnFW(vbGdSGNQkGWgZTVi4Nos(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28BBDCA ^ 0x28F37F2), fCfnh1bQuKP.BaseAddress, YDSnhk5Knht), ex);
					throw;
				}
				finally
				{
					if (num >= 0)
					{
						int num4 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
						{
							num4 = 1;
						}
						switch (num4)
						{
						case 1:
							goto end_IL_0275;
						}
					}
					if (fCfnh1bQuKP != null)
					{
						XKWMImNQ5hVSqNhCAEpI(fCfnh1bQuKP);
					}
					end_IL_0275:;
				}
			}
			catch (Exception exception)
			{
				int num5 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				}
				Raonh4XaFNb = -2;
				AjsnhDOJY9F.SetException(exception);
				return;
			}
			Raonh4XaFNb = -2;
			int num6 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
			{
				num6 = 1;
			}
			while (true)
			{
				switch (num6)
				{
				default:
					return;
				case 1:
					AjsnhDOJY9F.SetResult(result);
					num6 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 != 0)
					{
						num6 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			AjsnhDOJY9F.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static mQ88ilnhl7fGLlKI06R9()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static object CANO3nNQNvb4fjR0HUIa(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static object vbGdSGNQkGWgZTVi4Nos(object P_0, object P_1, object P_2)
		{
			return string.Format((string)P_0, P_1, P_2);
		}

		internal static void JfJfDFNQ1TxwCC6CtnFW(object P_0, object P_1)
		{
			LogManager.WriteError((string)P_0, (Exception)P_1);
		}

		internal static void XKWMImNQ5hVSqNhCAEpI(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static bool zGEjwjNQDp7Pg0R7CQuJ()
		{
			return kAHWnLNQ4Yq54ajbEctI == null;
		}

		internal static object r5gyD4NQbBuiyW7fpcua()
		{
			return kAHWnLNQ4Yq54ajbEctI;
		}
	}

	private readonly string I7lHI11cqDB;

	internal static YBaxiwHIaqg0ZAjd8CAL lT4dDYDMVFrWhpv350hf;

	[AsyncStateMachine(typeof(koHuKDnmPCsD17HgIf8U))]
	public Task<HUvclsHewvbEZGvt3TVD> RZ5HIlZvduu(string P_0)
	{
		koHuKDnmPCsD17HgIf8U stateMachine = default(koHuKDnmPCsD17HgIf8U);
		stateMachine.v1XnmFe7LXK = AsyncTaskMethodBuilder<HUvclsHewvbEZGvt3TVD>.Create();
		stateMachine.g8mnm3ySHvH = this;
		stateMachine.tl3nmpP2BBZ = P_0;
		stateMachine.qVAnmJSeY7o = -1;
		stateMachine.v1XnmFe7LXK.Start(ref stateMachine);
		return stateMachine.v1XnmFe7LXK.Task;
	}

	[AsyncStateMachine(typeof(RvCdVinhfQPsPQMBdM96))]
	public Task<HUvclsHewvbEZGvt3TVD> IrqHI45ZWPA(string P_0)
	{
		RvCdVinhfQPsPQMBdM96 stateMachine = default(RvCdVinhfQPsPQMBdM96);
		stateMachine.skQnhn5Y8cm = AsyncTaskMethodBuilder<HUvclsHewvbEZGvt3TVD>.Create();
		stateMachine.xo5nhGgVpQf = this;
		stateMachine.BAknhYI9OoU = P_0;
		stateMachine.k4Ynh9DgIO2 = -1;
		stateMachine.skQnhn5Y8cm.Start(ref stateMachine);
		return stateMachine.skQnhn5Y8cm.Task;
	}

	[AsyncStateMachine(typeof(mQ88ilnhl7fGLlKI06R9))]
	private Task<HttpResponseMessage> QJuHIDMffkI(string P_0, object P_1)
	{
		mQ88ilnhl7fGLlKI06R9 stateMachine = default(mQ88ilnhl7fGLlKI06R9);
		stateMachine.AjsnhDOJY9F = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
		stateMachine.seCnhb7FfyL = this;
		stateMachine.YDSnhk5Knht = P_0;
		stateMachine.VCDnhN0gW5k = P_1;
		stateMachine.Raonh4XaFNb = -1;
		stateMachine.AjsnhDOJY9F.Start(ref stateMachine);
		return stateMachine.AjsnhDOJY9F.Task;
	}

	private HttpClient oA5HIbTwNM1()
	{
		HttpClient httpClient = new HttpClient();
		GmVBMZDMKQ4LHnVApopG(httpClient, new Uri(new Uri(j18iDj9nukSCmEyZs5lH.Uoh9v6fS7bO), I7lHI11cqDB));
		return httpClient;
	}

	private HUvclsHewvbEZGvt3TVD lEhHIN3uXQp(HttpStatusCode P_0)
	{
		switch (P_0)
		{
		case HttpStatusCode.OK:
		case HttpStatusCode.Created:
			return (HUvclsHewvbEZGvt3TVD)10000;
		case HttpStatusCode.NoContent:
			return (HUvclsHewvbEZGvt3TVD)30204;
		case HttpStatusCode.InternalServerError:
			return (HUvclsHewvbEZGvt3TVD)30500;
		case HttpStatusCode.ServiceUnavailable:
			return (HUvclsHewvbEZGvt3TVD)30503;
		default:
			return (HUvclsHewvbEZGvt3TVD)30900;
		}
	}

	private HUvclsHewvbEZGvt3TVD vIMHIklnvlI(HttpStatusCode P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return P_0 switch
				{
					HttpStatusCode.InternalServerError => (HUvclsHewvbEZGvt3TVD)31500, 
					HttpStatusCode.ServiceUnavailable => (HUvclsHewvbEZGvt3TVD)31503, 
					_ => (HUvclsHewvbEZGvt3TVD)31900, 
				};
			case 2:
				if ((uint)(P_0 - 200) <= 1u)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 1:
				return (HUvclsHewvbEZGvt3TVD)10000;
			}
		}
	}

	public YBaxiwHIaqg0ZAjd8CAL()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		I7lHI11cqDB = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1848952786 ^ -1849108992);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static YBaxiwHIaqg0ZAjd8CAL()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void GmVBMZDMKQ4LHnVApopG(object P_0, object P_1)
	{
		((HttpClient)P_0).BaseAddress = (Uri)P_1;
	}

	internal static bool lhAX0RDMCe41pdrRQUET()
	{
		return lT4dDYDMVFrWhpv350hf == null;
	}

	internal static YBaxiwHIaqg0ZAjd8CAL UKcSTbDMrDkdHc8LhPGq()
	{
		return lT4dDYDMVFrWhpv350hf;
	}
}
