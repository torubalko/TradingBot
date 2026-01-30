using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Threading;
using aEpmU09nz6MEoNmc0pGJ;
using De5nppfnpARnAi0A5Za4;
using DQIo3790ym4PqFa5dl3o;
using ECOEgqlSad8NUJZ2Dr9n;
using GnxfH9H684TvY2jg66vS;
using HWd9ES2bXNr0YZqBy5d0;
using J3rFECfGQmHQ9sLCyCue;
using Ki5UMm4zgRG9YQRpEjE;
using M7Qhok2zS37wTYN0rqJn;
using MailKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using nPSrw5fYUXeiMC9Ux0xS;
using pj0D9xfYObu44WjqZJeq;
using reuqbSHkyZtO3nPa1eKn;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Properties;
using TigerTrade.UI.Controls.Notifications;
using TuAMtrl1Nd3XoZQQUXf0;
using wse3wd2zgF9O4VW2DUfZ;

namespace w1lE3p4MSVZb7S0mVrv;

internal sealed class uPJaqK46ZA7lVpRfCuO : xRgq7gHkTVINiHGAKc0y
{
	[CompilerGenerated]
	private sealed class DLLKfVnbY8WPKoFrZSQN
	{
		public Iafnb1fn3j4C49y3SFn7 D7YnbB5Ro1V;

		public uPJaqK46ZA7lVpRfCuO tGcnbax5dI9;

		internal static DLLKfVnbY8WPKoFrZSQN iPkxkkN2gyjOyqP6fyxo;

		public DLLKfVnbY8WPKoFrZSQN()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void UAonbofrcNP()
		{
			RM5s4c4uga18xZ0DLZF obj = new RM5s4c4uga18xZ0DLZF(D7YnbB5Ro1V)
			{
				Source = tGcnbax5dI9.HQj4q7ScYp(D7YnbB5Ro1V.Source)
			};
			uJ9S8LN2MnVeG7tGLi8S(obj, D7YnbB5Ro1V.Symbol);
			obj.Exchange = D7YnbB5Ro1V.Exchange;
			obj.Message = (string)ckMvvbN2OsVjyIsLO2UX(D7YnbB5Ro1V);
			RM5s4c4uga18xZ0DLZF item = obj;
			tGcnbax5dI9.Alerts.Insert(0, item);
		}

		internal void AsfnbvhvdyI()
		{
			if (!string.IsNullOrEmpty(D7YnbB5Ro1V.tVYfnuTRD4g()))
			{
				qEYTeV2bsvVIVI3Hs7LY.mgg2bOwTcC2((string)Fgqo7MN2qGZvPyiA56LX(D7YnbB5Ro1V));
			}
		}

		static DLLKfVnbY8WPKoFrZSQN()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool Up0YS9N2Rc3pvHZgH4d6()
		{
			return iPkxkkN2gyjOyqP6fyxo == null;
		}

		internal static DLLKfVnbY8WPKoFrZSQN TCCpunN26vakhLM5UQoE()
		{
			return iPkxkkN2gyjOyqP6fyxo;
		}

		internal static void uJ9S8LN2MnVeG7tGLi8S(object P_0, object P_1)
		{
			((RM5s4c4uga18xZ0DLZF)P_0).Symbol = (string)P_1;
		}

		internal static object ckMvvbN2OsVjyIsLO2UX(object P_0)
		{
			return ((Iafnb1fn3j4C49y3SFn7)P_0).Message;
		}

		internal static object Fgqo7MN2qGZvPyiA56LX(object P_0)
		{
			return ((Iafnb1fn3j4C49y3SFn7)P_0).tVYfnuTRD4g();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct dgFhscnbifOCePoXOG99 : IAsyncStateMachine
	{
		public int HTonbl5Ls5u;

		public AsyncVoidMethodBuilder Qngnb4RJfeU;

		public Iafnb1fn3j4C49y3SFn7 NcVnbDGBlB9;

		public uPJaqK46ZA7lVpRfCuO jTRnbbVHus1;

		private DLLKfVnbY8WPKoFrZSQN sRgnbNqgmSM;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter MUFnbkNX0Yx;

		private static object sgqbGUN2IfAjdW8LnIwm;

		private void MoveNext()
		{
			int num = HTonbl5Ls5u;
			try
			{
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				int num2;
				if (num == 0)
				{
					awaiter = MUFnbkNX0Yx;
					num2 = 5;
					goto IL_003c;
				}
				goto IL_02ad;
				IL_00cf:
				if (sRgnbNqgmSM.D7YnbB5Ro1V.ShowPopup)
				{
					K6lE4P2zdkKlpKsuOtJY.Vyf2z6nK1t1(new FcjPXM2z5nD8Dwq2mFW6((string)iE02TfN2CF1T5HGMA2Xw(sRgnbNqgmSM.D7YnbB5Ro1V) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1461292091 ^ -1461300609) + sRgnbNqgmSM.D7YnbB5Ro1V.Exchange, sRgnbNqgmSM.D7YnbB5Ro1V.Message, NotificationType.Signal), "", G5s2SMN2rPj5HW9xQiP6(5.0), sRgnbNqgmSM.AsfnbvhvdyI);
				}
				if (!sRgnbNqgmSM.D7YnbB5Ro1V.SendEmail)
				{
					goto IL_0255;
				}
				awaiter = ky5A8tN2hTjbcZFy07VM(EPE4Ijf0RS(sRgnbNqgmSM.D7YnbB5Ro1V.Symbol, (string)jfSxbLN2KsIuX49Rw6gg(sRgnbNqgmSM.D7YnbB5Ro1V), (string)kEdSOON2mHuGXab4nOTS(sRgnbNqgmSM.D7YnbB5Ro1V)), false).GetAwaiter();
				num2 = 11;
				goto IL_003c;
				IL_003c:
				while (true)
				{
					switch (num2)
					{
					case 5:
						MUFnbkNX0Yx = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
						num = (HTonbl5Ls5u = -1);
						goto IL_0076;
					case 1:
						break;
					case 11:
						if (awaiter.IsCompleted)
						{
							goto IL_0076;
						}
						goto IL_0134;
					case 6:
						bASpOCH67Vpotti1nEMy.BPMHM0fYgZT(string.Concat(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2017337494 ^ -2017109260) + sRgnbNqgmSM.D7YnbB5Ro1V.Symbol + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1763895751 ^ -1763847421), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1127423276 ^ -1127437614), sRgnbNqgmSM.D7YnbB5Ro1V.Message), sRgnbNqgmSM.D7YnbB5Ro1V.tVYfnuTRD4g());
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
						{
							num2 = 8;
						}
						continue;
					case 7:
						return;
					case 9:
						goto IL_0255;
					default:
						goto IL_02ad;
					case 2:
						goto end_IL_002c;
					case 10:
						goto IL_03ad;
					case 3:
						num = (HTonbl5Ls5u = 0);
						num2 = 4;
						continue;
					case 4:
						MUFnbkNX0Yx = awaiter;
						Qngnb4RJfeU.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = 7;
						continue;
					case 8:
						goto end_IL_002c;
						IL_0076:
						awaiter.GetResult();
						num2 = 9;
						continue;
					}
					break;
				}
				goto IL_00cf;
				IL_0255:
				int num3;
				if (sRgnbNqgmSM.D7YnbB5Ro1V.SendTelegram)
				{
					num3 = 6;
					goto IL_0038;
				}
				goto end_IL_002c;
				IL_0038:
				num2 = num3;
				goto IL_003c;
				IL_02ad:
				sRgnbNqgmSM = new DLLKfVnbY8WPKoFrZSQN();
				sRgnbNqgmSM.D7YnbB5Ro1V = NcVnbDGBlB9;
				sRgnbNqgmSM.tGcnbax5dI9 = jTRnbbVHus1;
				if (sRgnbNqgmSM.D7YnbB5Ro1V.Log)
				{
					xpMXK7N2yNfaKhXAoRJc(BgToKaN2TF99pwBg6j0p(PRNiOHN2U1Smxou08k80()), new Action(sRgnbNqgmSM.UAonbofrcNP));
					num3 = 10;
					goto IL_0038;
				}
				goto IL_03ad;
				IL_03ad:
				if (!sRgnbNqgmSM.D7YnbB5Ro1V.aZAfGlZmiC7())
				{
					sRgnbNqgmSM.D7YnbB5Ro1V.FbofG4soyOb(_0020: true);
					if (string.IsNullOrEmpty((string)AwmXGHN2ZMtyRRxUgelI(sRgnbNqgmSM.D7YnbB5Ro1V)))
					{
						goto IL_00cf;
					}
					oZu29WfYtbVlhlMVGiDk.UX8fY7ZbJhw((string)AwmXGHN2ZMtyRRxUgelI(sRgnbNqgmSM.D7YnbB5Ro1V), g3ZoP3N2VSBpbeiBOB50(sRgnbNqgmSM.D7YnbB5Ro1V));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 != 0)
					{
						num2 = 2;
					}
				}
				goto IL_003c;
				IL_0134:
				num3 = 3;
				goto IL_0038;
				end_IL_002c:;
			}
			catch (Exception exception)
			{
				HTonbl5Ls5u = -2;
				sRgnbNqgmSM = null;
				Qngnb4RJfeU.SetException(exception);
				int num4 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
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
			while (true)
			{
				HTonbl5Ls5u = -2;
				sRgnbNqgmSM = null;
				int num5 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 != 0)
				{
					num5 = 1;
				}
				switch (num5)
				{
				case 1:
					Qngnb4RJfeU.SetResult();
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
			Qngnb4RJfeU.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static dgFhscnbifOCePoXOG99()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static object PRNiOHN2U1Smxou08k80()
		{
			return Application.Current;
		}

		internal static object BgToKaN2TF99pwBg6j0p(object P_0)
		{
			return ((DispatcherObject)P_0).Dispatcher;
		}

		internal static void xpMXK7N2yNfaKhXAoRJc(object P_0, object P_1)
		{
			((Dispatcher)P_0).Invoke((Action)P_1);
		}

		internal static object AwmXGHN2ZMtyRRxUgelI(object P_0)
		{
			return ((Iafnb1fn3j4C49y3SFn7)P_0).Signal;
		}

		internal static int g3ZoP3N2VSBpbeiBOB50(object P_0)
		{
			return ((Iafnb1fn3j4C49y3SFn7)P_0).Duration;
		}

		internal static object iE02TfN2CF1T5HGMA2Xw(object P_0)
		{
			return ((Iafnb1fn3j4C49y3SFn7)P_0).Symbol;
		}

		internal static TimeSpan G5s2SMN2rPj5HW9xQiP6(double P_0)
		{
			return TimeSpan.FromSeconds(P_0);
		}

		internal static object jfSxbLN2KsIuX49Rw6gg(object P_0)
		{
			return ((Iafnb1fn3j4C49y3SFn7)P_0).Message;
		}

		internal static object kEdSOON2mHuGXab4nOTS(object P_0)
		{
			return ((Iafnb1fn3j4C49y3SFn7)P_0).tVYfnuTRD4g();
		}

		internal static ConfiguredTaskAwaitable ky5A8tN2hTjbcZFy07VM(object P_0, bool P_1)
		{
			return ((Task)P_0).ConfigureAwait(P_1);
		}

		internal static bool wNFIJnN2W4sYAQGXJwT4()
		{
			return sgqbGUN2IfAjdW8LnIwm == null;
		}

		internal static object lGi6igN2tnvm24L8HkoR()
		{
			return sgqbGUN2IfAjdW8LnIwm;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct oJG1Rvnb1Vv1FI6iOLvk : IAsyncStateMachine
	{
		public int T59nb51XPw5;

		public AsyncTaskMethodBuilder pr7nbS1IuJF;

		public string RaSnbxQiF6p;

		public string qP0nbLUvTHs;

		public string j7fnbeOEL94;

		private oPtcN290TuwfxN9qnftN XDAnbsrecmq;

		private SmtpClient XFFnbX9oyIN;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter nxsnbcG8ZmM;

		internal static object hJENJcN2w4ee0OLt5dq2;

		private void MoveNext()
		{
			int num = 1;
			int num2 = num;
			int num3 = default(int);
			string[] array = default(string[]);
			int port = default(int);
			string host = default(string);
			ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
			ConfiguredTaskAwaitable configuredTaskAwaitable = default(ConfiguredTaskAwaitable);
			MimeMessage mimeMessage = default(MimeMessage);
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = T59nb51XPw5;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				try
				{
					_ = 3;
					int num4 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						try
						{
							int num5;
							if ((uint)num3 > 3u)
							{
								num5 = 6;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
								{
									num5 = 6;
								}
								goto IL_0083;
							}
							goto IL_0103;
							IL_0083:
							while (true)
							{
								switch (num5)
								{
								default:
									goto end_IL_0083;
								case 6:
									XDAnbsrecmq = j18iDj9nukSCmEyZs5lH.aFH9GeRevRU();
									if (!XDAnbsrecmq.Enable || string.IsNullOrEmpty(XDAnbsrecmq.From) || string.IsNullOrEmpty((string)DLrotIN2AQKWKkDXaimd(XDAnbsrecmq)) || string.IsNullOrEmpty(XDAnbsrecmq.nHI907hLrQI) || string.IsNullOrEmpty(XDAnbsrecmq.Yw190PdupgM) || vo6AKKN2PH9I017s2nce(XDAnbsrecmq.urH90pheTH7()))
									{
										goto end_IL_0083;
									}
									goto case 5;
								case 7:
									XDAnbsrecmq = null;
									num5 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
									{
										num5 = 0;
									}
									continue;
								case 3:
									break;
								case 1:
									if (array.Length != 2)
									{
										goto end_IL_0083;
									}
									goto case 4;
								case 2:
									port = ivYUNBN2F3bWqkBBgCFw(array[1]);
									XFFnbX9oyIN = new SmtpClient();
									num5 = 3;
									continue;
								case 5:
									array = (string[])zviy7hN2Jlq7sBKFQnip(XDAnbsrecmq.nHI907hLrQI, new char[1] { ':' });
									num5 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
									{
										num5 = 1;
									}
									continue;
								case 4:
									host = array[0];
									num5 = 2;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
									{
										num5 = 2;
									}
									continue;
								case 0:
									goto end_IL_0083;
								}
								goto IL_0103;
								continue;
								end_IL_0083:
								break;
							}
							goto end_IL_005d;
							IL_0103:
							try
							{
								int num6;
								switch (num3)
								{
								default:
									num6 = 4;
									goto IL_0128;
								case 3:
									awaiter = nxsnbcG8ZmM;
									nxsnbcG8ZmM = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
									num3 = (T59nb51XPw5 = -1);
									break;
								case 1:
									awaiter = nxsnbcG8ZmM;
									nxsnbcG8ZmM = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
									num6 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
									{
										num6 = 0;
									}
									goto IL_0128;
								case 2:
									awaiter = nxsnbcG8ZmM;
									nxsnbcG8ZmM = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
									num3 = (T59nb51XPw5 = -1);
									num6 = 8;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
									{
										num6 = 4;
									}
									goto IL_0128;
								case 0:
									goto IL_061c;
									IL_0128:
									while (true)
									{
										int num7;
										switch (num6)
										{
										default:
											num3 = (T59nb51XPw5 = -1);
											num6 = 22;
											continue;
										case 5:
											awaiter = configuredTaskAwaitable.GetAwaiter();
											if (!awaiter.IsCompleted)
											{
												num3 = (T59nb51XPw5 = 1);
												nxsnbcG8ZmM = awaiter;
												num6 = 12;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
												{
													num6 = 21;
												}
												continue;
											}
											goto case 22;
										case 10:
											awaiter = configuredTaskAwaitable.GetAwaiter();
											if (awaiter.IsCompleted)
											{
												goto case 11;
											}
											num3 = (T59nb51XPw5 = 0);
											nxsnbcG8ZmM = awaiter;
											num6 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
											{
												num6 = 7;
											}
											continue;
										case 22:
											awaiter.GetResult();
											num6 = 19;
											continue;
										case 21:
											pr7nbS1IuJF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											return;
										case 15:
											num3 = (T59nb51XPw5 = 3);
											num6 = 18;
											continue;
										case 2:
											mimeMessage.From.Add(new MailboxAddress(Encoding.UTF8, (string)pyr2RbN2pPaDOucTXMXH(-44540535 ^ -44294817), XDAnbsrecmq.From));
											num6 = 20;
											continue;
										case 14:
										{
											MimeMessage mimeMessage2 = mimeMessage;
											TextPart textPart = new TextPart(TextFormat.Plain);
											QH0ByyN2zDVHdGKISYVL(textPart, qP0nbLUvTHs);
											mimeMessage2.Body = textPart;
											num6 = 13;
											continue;
										}
										case 3:
											return;
										case 1:
											num3 = (T59nb51XPw5 = 2);
											nxsnbcG8ZmM = awaiter;
											num7 = 16;
											goto IL_0124;
										case 9:
											return;
										case 13:
											configuredTaskAwaitable = ((Task)XUiJIENH0Qc8N1kq1wKQ(XFFnbX9oyIN, mimeMessage, default(CancellationToken), null)).ConfigureAwait(continueOnCapturedContext: false);
											awaiter = configuredTaskAwaitable.GetAwaiter();
											if (!awaiter.IsCompleted)
											{
												num6 = 0;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
												{
													num6 = 1;
												}
												continue;
											}
											goto IL_0559;
										case 7:
											pr7nbS1IuJF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num7 = 9;
											goto IL_0124;
										case 11:
											awaiter.GetResult();
											configuredTaskAwaitable = XFFnbX9oyIN.AuthenticateAsync(XDAnbsrecmq.Yw190PdupgM, XDAnbsrecmq.urH90pheTH7()).ConfigureAwait(continueOnCapturedContext: false);
											num6 = 5;
											continue;
										case 17:
											break;
										case 8:
											goto IL_0559;
										case 18:
											nxsnbcG8ZmM = awaiter;
											pr7nbS1IuJF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num6 = 6;
											continue;
										case 19:
											mimeMessage = new MimeMessage();
											num6 = 2;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
											{
												num6 = 0;
											}
											continue;
										case 16:
											pr7nbS1IuJF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num6 = 1;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
											{
												num6 = 3;
											}
											continue;
										case 20:
											((InternetAddressList)Vpjx8gN2uSKvmxH89CEd(mimeMessage)).Add((InternetAddress)new MailboxAddress(string.Empty, (string)DLrotIN2AQKWKkDXaimd(XDAnbsrecmq)));
											mimeMessage.Subject = RaSnbxQiF6p;
											num6 = 14;
											continue;
										case 6:
											return;
										case 12:
											goto IL_061c;
										case 4:
											{
												kvJhqwN23ljme5xdF2DK(XFFnbX9oyIN, 10000);
												configuredTaskAwaitable = XFFnbX9oyIN.ConnectAsync(host, port).ConfigureAwait(continueOnCapturedContext: false);
												num6 = 10;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
												{
													num6 = 10;
												}
												continue;
											}
											IL_0124:
											num6 = num7;
											continue;
										}
										break;
										IL_0559:
										awaiter.GetResult();
										configuredTaskAwaitable = NIr0V5NH20A0whdhHCtb(XFFnbX9oyIN.DisconnectAsync(quit: true), false);
										awaiter = configuredTaskAwaitable.GetAwaiter();
										if (awaiter.IsCompleted)
										{
											goto end_IL_0105;
										}
										num6 = 15;
									}
									goto case 2;
									IL_061c:
									awaiter = nxsnbcG8ZmM;
									nxsnbcG8ZmM = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
									num3 = (T59nb51XPw5 = -1);
									num6 = 11;
									goto IL_0128;
									end_IL_0105:
									break;
								}
								awaiter.GetResult();
							}
							finally
							{
								if (num3 < 0 && XFFnbX9oyIN != null)
								{
									int num8 = 0;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
									{
										num8 = 0;
									}
									switch (num8)
									{
									default:
										((IDisposable)XFFnbX9oyIN).Dispose();
										break;
									}
								}
							}
							XFFnbX9oyIN = null;
							num5 = 7;
							goto IL_0083;
							end_IL_005d:;
						}
						catch (TimeoutException ex)
						{
							pWt4WjH0jr(j7fnbeOEL94, Resources.AlertsControlViewModelErrorConnectionMessage, ex);
						}
						catch (SocketException ex2)
						{
							u1DpRMNHfkNIbTr8n6rf(j7fnbeOEL94, XpcuCTNHH7UDiG5rVyFr(), ex2);
						}
						catch (AuthenticationException ex3)
						{
							pWt4WjH0jr(j7fnbeOEL94, Resources.AlertsControlViewMidelErrorAuthentificationMessage, ex3);
						}
						catch (Exception ex4)
						{
							pWt4WjH0jr(j7fnbeOEL94, string.Empty, ex4);
						}
						break;
					}
				}
				catch (Exception exception)
				{
					int num9 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
					{
						num9 = 0;
					}
					switch (num9)
					{
					}
					T59nb51XPw5 = -2;
					pr7nbS1IuJF.SetException(exception);
					return;
				}
				T59nb51XPw5 = -2;
				pr7nbS1IuJF.SetResult();
				return;
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
			pr7nbS1IuJF.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static oJG1Rvnb1Vv1FI6iOLvk()
		{
			sx555MNH93vYGuiUaetx();
		}

		internal static object DLrotIN2AQKWKkDXaimd(object P_0)
		{
			return ((oPtcN290TuwfxN9qnftN)P_0).To;
		}

		internal static bool vo6AKKN2PH9I017s2nce(object P_0)
		{
			return string.IsNullOrEmpty((string)P_0);
		}

		internal static object zviy7hN2Jlq7sBKFQnip(object P_0, object P_1)
		{
			return ((string)P_0).Split((char[])P_1);
		}

		internal static int ivYUNBN2F3bWqkBBgCFw(object P_0)
		{
			return Convert.ToInt32((string)P_0);
		}

		internal static void kvJhqwN23ljme5xdF2DK(object P_0, int P_1)
		{
			((MailService)P_0).Timeout = P_1;
		}

		internal static object pyr2RbN2pPaDOucTXMXH(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}

		internal static object Vpjx8gN2uSKvmxH89CEd(object P_0)
		{
			return ((MimeMessage)P_0).To;
		}

		internal static void QH0ByyN2zDVHdGKISYVL(object P_0, object P_1)
		{
			((TextPart)P_0).Text = (string)P_1;
		}

		internal static object XUiJIENH0Qc8N1kq1wKQ(object P_0, object P_1, CancellationToken P_2, object P_3)
		{
			return ((MailTransport)P_0).SendAsync((MimeMessage)P_1, P_2, (ITransferProgress)P_3);
		}

		internal static ConfiguredTaskAwaitable NIr0V5NH20A0whdhHCtb(object P_0, bool P_1)
		{
			return ((Task)P_0).ConfigureAwait(P_1);
		}

		internal static object XpcuCTNHH7UDiG5rVyFr()
		{
			return Resources.AlertsControlViewModelErrorConnectionMessage;
		}

		internal static void u1DpRMNHfkNIbTr8n6rf(object P_0, object P_1, object P_2)
		{
			pWt4WjH0jr((string)P_0, (string)P_1, (Exception)P_2);
		}

		internal static bool cgeRbHN27ET8yk8yO3aY()
		{
			return hJENJcN2w4ee0OLt5dq2 == null;
		}

		internal static object qOc79bN28tgpSIaneabP()
		{
			return hJENJcN2w4ee0OLt5dq2;
		}

		internal static void sx555MNH93vYGuiUaetx()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[CompilerGenerated]
	private sealed class ItGPDBnbjfPX6SgtklKi
	{
		public string mJHnbQKxkEp;

		private static ItGPDBnbjfPX6SgtklKi cGp4GONHn2Ov7andaYI4;

		public ItGPDBnbjfPX6SgtklKi()
		{
			nXeKPmNHofGUuBZylfMZ();
			base._002Ector();
		}

		internal void wCqnbEC7mH1()
		{
			if (string.IsNullOrEmpty(mJHnbQKxkEp))
			{
				qEYTeV2bsvVIVI3Hs7LY.mgg2bOwTcC2(mJHnbQKxkEp);
			}
		}

		static ItGPDBnbjfPX6SgtklKi()
		{
			UuKEydNHvymhbMCbyr8s();
		}

		internal static void nXeKPmNHofGUuBZylfMZ()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool rAQbIVNHGbKaOD5hClIL()
		{
			return cGp4GONHn2Ov7andaYI4 == null;
		}

		internal static ItGPDBnbjfPX6SgtklKi joGk0vNHYhV75jmDR1rP()
		{
			return cGp4GONHn2Ov7andaYI4;
		}

		internal static void UuKEydNHvymhbMCbyr8s()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	[CompilerGenerated]
	private readonly ObservableCollection<RM5s4c4uga18xZ0DLZF> NbG48ltxgw;

	private RM5s4c4uga18xZ0DLZF sME4AJ3cgA;

	private ICollectionView owP4PFxZiw;

	private bool TM24JdAgEb;

	private bool oFk4FlE4vl;

	private bool sgt43BEjLA;

	private bool NP64pRrRJK;

	private static uPJaqK46ZA7lVpRfCuO Q0Nbh2lFTECm1N4fCYrh;

	public ObservableCollection<RM5s4c4uga18xZ0DLZF> Alerts
	{
		[CompilerGenerated]
		get
		{
			return NbG48ltxgw;
		}
	}

	public RM5s4c4uga18xZ0DLZF SelectedAlert
	{
		get
		{
			return sME4AJ3cgA;
		}
		set
		{
			if (!ywttx3lFVbAeR3rdjt10(rM5s4c4uga18xZ0DLZF, sME4AJ3cgA))
			{
				sME4AJ3cgA = rM5s4c4uga18xZ0DLZF;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x446AB724 ^ 0x446A9938));
			}
		}
	}

	public ICollectionView Collection
	{
		get
		{
			return owP4PFxZiw;
		}
		set
		{
			owP4PFxZiw = collectionView;
			JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -123765123));
		}
	}

	public bool SourceChart
	{
		get
		{
			return TM24JdAgEb;
		}
		set
		{
			if (flag != TM24JdAgEb)
			{
				TM24JdAgEb = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741BABF1));
				jZkP4glFCYbT1ECmLK6F(Collection);
			}
		}
	}

	public bool SourceDom
	{
		get
		{
			return oFk4FlE4vl;
		}
		set
		{
			if (flag != oFk4FlE4vl)
			{
				oFk4FlE4vl = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x315A9FB7));
				jZkP4glFCYbT1ECmLK6F(Collection);
			}
		}
	}

	public bool SourceTape
	{
		get
		{
			return sgt43BEjLA;
		}
		set
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
					if (flag == sgt43BEjLA)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
						{
							num2 = 0;
						}
						break;
					}
					sgt43BEjLA = flag;
					JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x769C7931 ^ 0x769C575B));
					jZkP4glFCYbT1ECmLK6F(Collection);
					return;
				case 0:
					return;
				}
			}
		}
	}

	public bool SourceServerAlerts
	{
		get
		{
			return NP64pRrRJK;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (flag != NP64pRrRJK)
					{
						NP64pRrRJK = flag;
						JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1325225167));
						jZkP4glFCYbT1ECmLK6F(Collection);
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public uPJaqK46ZA7lVpRfCuO()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		TM24JdAgEb = true;
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				Collection = CollectionViewSource.GetDefaultView(Alerts);
				Collection.Filter = Filter;
				c8EcTUfGEuMy2llFqsdF.FgQfG8DffSh(Hrm4OagBgS);
				return;
			case 2:
				oFk4FlE4vl = true;
				NP64pRrRJK = true;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				sgt43BEjLA = true;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				NbG48ltxgw = new ObservableCollection<RM5s4c4uga18xZ0DLZF>();
				num2 = 3;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(dgFhscnbifOCePoXOG99))]
	private void Hrm4OagBgS(Iafnb1fn3j4C49y3SFn7 P_0)
	{
		dgFhscnbifOCePoXOG99 stateMachine = default(dgFhscnbifOCePoXOG99);
		stateMachine.Qngnb4RJfeU = uiL1hblFrlPWX7N24Cy4();
		stateMachine.jTRnbbVHus1 = this;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine.HTonbl5Ls5u = -1;
				stateMachine.Qngnb4RJfeU.Start(ref stateMachine);
				return;
			}
			stateMachine.NcVnbDGBlB9 = P_0;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
			{
				num = 1;
			}
		}
	}

	private string HQj4q7ScYp(krjr6dfYMJotfdc9ATKx P_0)
	{
		return P_0 switch
		{
			krjr6dfYMJotfdc9ATKx.Chart => (string)bt1SXXlFKBi6YZaB008E(), 
			(krjr6dfYMJotfdc9ATKx)2 => Resources.AlertsControlViewModelSourceDom, 
			(krjr6dfYMJotfdc9ATKx)3 => Resources.AlertsControlViewModelSourceSmartTape, 
			(krjr6dfYMJotfdc9ATKx)4 => Resources.AlertsControlViewModelSourceServerAlert, 
			_ => (string)dgYTJglFmH0diE4yndZO(), 
		};
	}

	public void Clear()
	{
		Alerts.Clear();
	}

	public bool Filter(object obj)
	{
		int num;
		krjr6dfYMJotfdc9ATKx krjr6dfYMJotfdc9ATKx = default(krjr6dfYMJotfdc9ATKx);
		if (!(obj is RM5s4c4uga18xZ0DLZF rM5s4c4uga18xZ0DLZF))
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
			{
				num = 0;
			}
		}
		else
		{
			krjr6dfYMJotfdc9ATKx = mAo7gOlFwoms3BXDIW0e(OW2qvUlFht1BnayNn7VK(rM5s4c4uga18xZ0DLZF));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
			{
				num = 0;
			}
		}
		return num switch
		{
			1 => false, 
			_ => krjr6dfYMJotfdc9ATKx switch
			{
				krjr6dfYMJotfdc9ATKx.Chart => SourceChart, 
				(krjr6dfYMJotfdc9ATKx)2 => SourceDom, 
				(krjr6dfYMJotfdc9ATKx)3 => SourceTape, 
				(krjr6dfYMJotfdc9ATKx)4 => SourceServerAlerts, 
				_ => false, 
			}, 
		};
	}

	[AsyncStateMachine(typeof(oJG1Rvnb1Vv1FI6iOLvk))]
	private static Task EPE4Ijf0RS(string P_0, string P_1, string P_2)
	{
		oJG1Rvnb1Vv1FI6iOLvk stateMachine = default(oJG1Rvnb1Vv1FI6iOLvk);
		stateMachine.pr7nbS1IuJF = ig4P4KlF79gSDGrFxQhn();
		stateMachine.RaSnbxQiF6p = P_0;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				stateMachine.qP0nbLUvTHs = P_1;
				stateMachine.j7fnbeOEL94 = P_2;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
				{
					num = 0;
				}
				break;
			default:
				stateMachine.T59nb51XPw5 = -1;
				stateMachine.pr7nbS1IuJF.Start(ref stateMachine);
				return stateMachine.pr7nbS1IuJF.Task;
			}
		}
	}

	private static void pWt4WjH0jr(string P_0, string P_1, Exception P_2)
	{
		ItGPDBnbjfPX6SgtklKi CS_0024_003C_003E8__locals3 = new ItGPDBnbjfPX6SgtklKi();
		CS_0024_003C_003E8__locals3.mJHnbQKxkEp = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		gxGLJFlF8rrjvYJDwqfa(P_2);
		K6lE4P2zdkKlpKsuOtJY.Vyf2z6nK1t1(new FcjPXM2z5nD8Dwq2mFW6(Resources.AlertsControlViewModelErrorSendEmailTitle, P_1, NotificationType.Error), "", TimeSpan.FromSeconds(5.0), delegate
		{
			if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals3.mJHnbQKxkEp))
			{
				qEYTeV2bsvVIVI3Hs7LY.mgg2bOwTcC2(CS_0024_003C_003E8__locals3.mJHnbQKxkEp);
			}
		});
	}

	static uPJaqK46ZA7lVpRfCuO()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool ywttx3lFVbAeR3rdjt10(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static bool fVQaYilFyhRuFrd83c3J()
	{
		return Q0Nbh2lFTECm1N4fCYrh == null;
	}

	internal static uPJaqK46ZA7lVpRfCuO Jldp24lFZpJUCgJatZBT()
	{
		return Q0Nbh2lFTECm1N4fCYrh;
	}

	internal static void jZkP4glFCYbT1ECmLK6F(object P_0)
	{
		((ICollectionView)P_0).Refresh();
	}

	internal static AsyncVoidMethodBuilder uiL1hblFrlPWX7N24Cy4()
	{
		return AsyncVoidMethodBuilder.Create();
	}

	internal static object bt1SXXlFKBi6YZaB008E()
	{
		return Resources.AlertsControlViewModelSourceChart;
	}

	internal static object dgYTJglFmH0diE4yndZO()
	{
		return Resources.AlertsControlViewModelSourceUnknown;
	}

	internal static object OW2qvUlFht1BnayNn7VK(object P_0)
	{
		return ((RM5s4c4uga18xZ0DLZF)P_0).Alert;
	}

	internal static krjr6dfYMJotfdc9ATKx mAo7gOlFwoms3BXDIW0e(object P_0)
	{
		return ((Iafnb1fn3j4C49y3SFn7)P_0).Source;
	}

	internal static AsyncTaskMethodBuilder ig4P4KlF79gSDGrFxQhn()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static void gxGLJFlF8rrjvYJDwqfa(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}
}
