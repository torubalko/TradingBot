using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Windows.Themes;
using ActiproSoftware.Windows.Themes.Generation;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using AwMBKq9nKHSPm0Db9gdp;
using bEJP0paStKlCKw7pwDhU;
using CA00IGfn6UyfKXYOM3Is;
using CjttZVHEzEWfhqQAXjq2;
using ECOEgqlSad8NUJZ2Dr9n;
using EFtXja9ny4ZaDEaJuMa2;
using hnRSFQHLWIs9WKnIZiIr;
using Hsf3Pm2wASNSwohaZG0V;
using Ji6wvg9k3QpQZWdR8bsf;
using JoKBoElSUBwVPr4PkuGe;
using k1HkEmlS1dtfyOJUb1At;
using MIvvHOGHJlMW3Jb19Bls;
using othWlreIPa8fk89Yim;
using r87LMG92bECaMClNvtxP;
using rjqQqKHEAfxvWqQhJB4Z;
using TigerTrade.Core.UI.Windows;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;
using TigerTrade.Properties;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using uPAbnGG980DscR4DZEMf;
using uyZAkjGzbty6fP4YlLSY;
using VJ7BEJHXz8aOVDmNP5pJ;

namespace dV5LggXFqPRU9hEU4k;

internal class dSdtjnsurkSDIOox0m : Application
{
	[CompilerGenerated]
	private sealed class ufISqwnlKjfBQ2Zb0uV1
	{
		public EventArgs h4Cnlhkkaun;

		public dSdtjnsurkSDIOox0m AePnlwoLGdZ;

		internal static ufISqwnlKjfBQ2Zb0uV1 d7npTqbutbvMwO1sJo6k;

		public ufISqwnlKjfBQ2Zb0uV1()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void gtJnlmrRODa()
		{
			try
			{
				Exception ex = null;
				UnhandledExceptionEventArgs e = h4Cnlhkkaun as UnhandledExceptionEventArgs;
				int num = 8;
				UnobservedTaskExceptionEventArgs e2 = default(UnobservedTaskExceptionEventArgs);
				bool? flag = default(bool?);
				bool flag2 = default(bool);
				DispatcherUnhandledExceptionEventArgs e3 = default(DispatcherUnhandledExceptionEventArgs);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 3:
							return;
						case 5:
							if (e2 != null)
							{
								AePnlwoLGdZ.Xm9MfruvG((string)uTlcnSbuyXjCqAEuNFsA(-338769610 ^ -339063486), e2.Exception);
								return;
							}
							if (!(h4Cnlhkkaun is DispatcherUnhandledExceptionEventArgs e4))
							{
								num2 = 2;
								continue;
							}
							ex = e4.Exception;
							goto case 2;
						case 7:
							AePnlwoLGdZ.Xm9MfruvG((string)uTlcnSbuyXjCqAEuNFsA(0x32DEA4F1 ^ 0x32DA20B7), e.ExceptionObject as Exception);
							num = 3;
							break;
						case 4:
							flag = new d24A9O2w8euv7NyW18YM
							{
								Error = ex.ToString()
							}.ShowDialog();
							flag2 = true;
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
							{
								num2 = 0;
							}
							continue;
						case 6:
							e3.Handled = true;
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
							{
								num2 = 1;
							}
							continue;
						default:
							if (flag != flag2)
							{
								return;
							}
							e3 = h4Cnlhkkaun as DispatcherUnhandledExceptionEventArgs;
							if (e3 != null)
							{
								num2 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
								{
									num2 = 6;
								}
								continue;
							}
							return;
						case 8:
							if (e == null)
							{
								e2 = h4Cnlhkkaun as UnobservedTaskExceptionEventArgs;
								num = 5;
								break;
							}
							goto case 7;
						case 2:
							AePnlwoLGdZ.Xm9MfruvG(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D35B065), ex);
							if (ex == null)
							{
								return;
							}
							goto case 4;
						case 1:
							return;
						}
						break;
					}
				}
			}
			catch (Exception ex2)
			{
				AePnlwoLGdZ.Xm9MfruvG(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225526077), ex2);
			}
			finally
			{
				AePnlwoLGdZ.sHf61jN6Z();
			}
		}

		static ufISqwnlKjfBQ2Zb0uV1()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}

		internal static bool ywQYqAbuUyJIK5l7dKe4()
		{
			return d7npTqbutbvMwO1sJo6k == null;
		}

		internal static ufISqwnlKjfBQ2Zb0uV1 tBgIBxbuT7NTxSZQC2Fe()
		{
			return d7npTqbutbvMwO1sJo6k;
		}

		internal static object uTlcnSbuyXjCqAEuNFsA(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}
	}

	private readonly ActivitySource GMYJZGDGA = new ActivitySource((string)RkStE7lILo9I6vq5H6VU(-1799510641 ^ -1799511201));

	private Mutex kOoFfIWxX;

	private bool uMq33tHKu;

	private bool yIrpqOkBf;

	private Mutex SXFu34BvE;

	[CompilerGenerated]
	private bool B7mzPQrDN;

	[CompilerGenerated]
	private static string RRE20tEVKi;

	[CompilerGenerated]
	private IPavdHHXuGgrKgtTe2T3 C7j22iJYOJ;

	[CompilerGenerated]
	private tj7IVyHLIiNJqBQROZUd a0B2Hxj5ty;

	private bool wWt29Hlh6D;

	internal static dSdtjnsurkSDIOox0m lQLZuVlI1yiPK6rBjUZk;

	[SpecialName]
	[CompilerGenerated]
	internal bool TM2ZuTVfu()
	{
		return B7mzPQrDN;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void A0WVVeACP(bool P_0)
	{
		B7mzPQrDN = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static string zb4rnOukr()
	{
		return RRE20tEVKi;
	}

	[SpecialName]
	[CompilerGenerated]
	internal static void uZaKxpOKS(string P_0)
	{
		RRE20tEVKi = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal IPavdHHXuGgrKgtTe2T3 wFghDOqc9()
	{
		return C7j22iJYOJ;
	}

	[SpecialName]
	[CompilerGenerated]
	private void Wu9wICsrV(IPavdHHXuGgrKgtTe2T3 P_0)
	{
		C7j22iJYOJ = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal tj7IVyHLIiNJqBQROZUd z5j8gprRS()
	{
		return a0B2Hxj5ty;
	}

	[SpecialName]
	[CompilerGenerated]
	private void WVJAHkQtc(tj7IVyHLIiNJqBQROZUd P_0)
	{
		a0B2Hxj5ty = P_0;
	}

	private void FWActeg5r(string P_0)
	{
		if (Directory.GetFiles(j18iDj9nukSCmEyZs5lH.xMY9GW43dIb()).Length == 0)
		{
			aJQ3Aw9nrHYxvhL6prtg.CCv9npjBqhE(P_0, j18iDj9nukSCmEyZs5lH.Gkq9Gq4JkDc(), out var _);
		}
	}

	private void TVxjFUHm3()
	{
		aJQ3Aw9nrHYxvhL6prtg.Kuk9nhiUXsB((string)BCKLlclIsh7DtflYK6G5(sr7PmylIx0dORYydU0hW(), Cqlc9VlIeHmnpGJqrvTM(RkStE7lILo9I6vq5H6VU(-527080372 ^ -527081460), TimeHelper.LocalTime)));
	}

	private void EkCE0C0jp(object P_0, StartupEventArgs P_1)
	{
		int num = 3;
		int num2 = num;
		string text = default(string);
		string[] array = default(string[]);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 10:
				if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-198991962 ^ -198993096)))
				{
					num2 = 14;
					break;
				}
				TVxjFUHm3();
				array = array.Skip(1).ToArray();
				flag = true;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
				{
					num2 = 6;
				}
				break;
			case 15:
				mycy5LHEu3qqvRcny9Mb.gDgHQ0aMTM5();
				TY1PvDlIEAytRDA7qS1e(AppDomain.CurrentDomain, new ResolveEventHandler(MVPq37q3o));
				ThemeManager.BeginUpdate();
				try
				{
					ThemeManager.RegisterThemeCatalog(RkStE7lILo9I6vq5H6VU(0x7DB10E6E ^ 0x7DB10866), new EJx3sOLA0gJI3P3Io1());
					MetroThemeDefinition metroThemeDefinition = new MetroThemeDefinition(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7D553BE0 ^ 0x7D55384C));
					cN4ZSXlIQ1QMTdCR5bUU(metroThemeDefinition, ThemeIntent.Dark);
					metroThemeDefinition.BaseGrayscaleSaturation = 4;
					KDQ51ilIdcmAR9RPFytv(metroThemeDefinition, 30);
					metroThemeDefinition.GraySilverRatio = 0.7;
					metroThemeDefinition.SilverMax = 200;
					metroThemeDefinition.DefaultFontFamily = (FontFamily)s3R0qUlIgXTX747BiOg8(j18iDj9nukSCmEyZs5lH.Settings.FontName);
					metroThemeDefinition.BaseFontSize = ((MhMDPU9v8rkigy1ao0Th)bbmME8lIRvKLtyWWW2B6()).FontSize;
					metroThemeDefinition.ScrollBarThumbCornerRadius = 0.0;
					y9BhnklI6mfcRtLZQsa1(metroThemeDefinition, 3.0);
					metroThemeDefinition.WindowTitleBarBackgroundKind = WindowTitleBarBackgroundKind.ThemeMinimum;
					metroThemeDefinition.WindowBorderKind = WindowBorderKind.LowContrast;
					LKgBIilIMnoVpjLSnRwM(metroThemeDefinition, BorderContrastKind.Lowest);
					metroThemeDefinition.ButtonBorderContrastKind = BorderContrastKind.Low;
					UFN3NElIOOfgpgZ9F5my(metroThemeDefinition, BorderContrastKind.Low);
					metroThemeDefinition.PopupBorderContrastKind = BorderContrastKind.Lowest;
					metroThemeDefinition.DockGuideColorFamilyName = ColorFamilyName.Blue;
					ThemeManager.RegisterThemeDefinition(metroThemeDefinition);
					MetroThemeDefinition obj = new MetroThemeDefinition((string)RkStE7lILo9I6vq5H6VU(0x7ADBF691 ^ 0x7ADBF28D))
					{
						Intent = ThemeIntent.Light
					};
					xA8vqMlIqLTOSnnHPMfp(obj, s3R0qUlIgXTX747BiOg8(j18iDj9nukSCmEyZs5lH.Settings.FontName));
					obj.BaseFontSize = WfpSMrlIIvQBbEJOY3NJ(j18iDj9nukSCmEyZs5lH.Settings);
					N95VUHlIWa6GsNSq3xgh(obj, 0.0);
					obj.ScrollBarThumbMargin = 3.0;
					obj.WindowTitleBarBackgroundKind = WindowTitleBarBackgroundKind.ThemeMinimum;
					XVUjSnlItIlu9JjUqi4C(obj, WindowBorderKind.LowContrast);
					obj.BarItemBorderContrastKind = BorderContrastKind.Lowest;
					obj.ButtonBorderContrastKind = BorderContrastKind.Low;
					obj.ContainerBorderContrastKind = BorderContrastKind.Low;
					WNnBvglIUSIiZF63MDqV(obj, BorderContrastKind.Lowest);
					ThemeManager.RegisterThemeDefinition(obj);
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							XhDOgElITEfAHViTKxXB(true);
							ThemeManager.CurrentTheme = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2017337494 ^ -2017338170);
							num3 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				finally
				{
					lOKZtulIyBeck3v4KUfy();
				}
				goto default;
			case 8:
				if (array.Length > 1)
				{
					FWActeg5r(array[1]);
					num2 = 12;
					break;
				}
				goto case 6;
			case 5:
				text = array[0];
				if (!(text == (string)RkStE7lILo9I6vq5H6VU(0x446AB724 ^ 0x446AB3A0)))
				{
					num2 = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 8;
			case 3:
				if (P_1.Args.Length != 0)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto IL_03f2;
			case 11:
				RJQ40bG97fddixgFUWO6.E7wG9ADNJtk();
				AppContext.SetSwitch(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-123775059 ^ -123776137), isEnabled: true);
				AppContext.SetSwitch(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68C7EAE6 ^ 0x68C7EF8A), isEnabled: true);
				num2 = 15;
				break;
			case 13:
				TyQc4592DMLUgJktHLQL.qq592k7WG8f(_0020: true);
				array = array.Skip(1).ToArray();
				goto case 6;
			case 2:
				array = (string[])Hv4LfilIXtTbDGo5EObL(P_1);
				flag = false;
				goto case 6;
			case 16:
			{
				if (!uMq33tHKu)
				{
					MessageWindow.ShowWindow(null, TigerTrade.Properties.Resources.AppName, (string)iUSkIDlIZxggSFdUPow3());
					X73VXqlIVZ7AhmbXox0V(Application.Current);
					return;
				}
				Activity activity = GMYJZGDGA.StartActivity((string)RkStE7lILo9I6vq5H6VU(-2123795572 ^ -2123795022));
				try
				{
					AppStartup();
					return;
				}
				finally
				{
					if (activity != null)
					{
						i9BNkIlICWaK9B9DgtA0(activity);
					}
				}
			}
			default:
				kOoFfIWxX = new Mutex(initiallyOwned: true, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1311293279 ^ -1311291719), out uMq33tHKu);
				num2 = 16;
				break;
			case 14:
				if (!AS8DVslIcmrE41EgKomF(text, RkStE7lILo9I6vq5H6VU(-1251569705 ^ -1251570839)))
				{
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 13;
			case 6:
			case 9:
				if (array.Length == 0)
				{
					num2 = 7;
					break;
				}
				goto case 5;
			case 7:
				if (flag)
				{
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto IL_03f2;
			case 4:
				((Application)taNX8GlIjsgDZvVCqdoL()).Shutdown();
				return;
			case 12:
				array = array.Skip(2).ToArray();
				flag = true;
				goto case 6;
			case 1:
				return;
				IL_03f2:
				PauYyPaSWR11R7KmruRj.HmNaSUIXhQx();
				num2 = 11;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
				{
					num2 = 7;
				}
				break;
			}
		}
	}

	private void AppStartup()
	{
		object[] array = new object[0];
		FEyTCPlStyZXoF8uKFOP.BcBlSVT9FuL(0, array, this);
	}

	private void maFQ0Z8L9()
	{
		((AppDomain)Ge4WqHlIrCTO1qStbfCs()).UnhandledException += DdaOYBpvI;
		TaskScheduler.UnobservedTaskException += DdaOYBpvI;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.Dispatcher.UnhandledException += delegate(object P_0, DispatcherUnhandledExceptionEventArgs P_1)
		{
			if (!Debugger.IsAttached)
			{
				DdaOYBpvI(P_0, P_1);
			}
		};
	}

	private void heSdMEsE0(object P_0, SessionEndingCancelEventArgs P_1)
	{
		yIrpqOkBf = true;
	}

	private void tT4gGmDgY(object P_0, ExitEventArgs P_1)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (!uMq33tHKu)
					{
						num2 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					dy5nQnlImT2NaWPlrObx(NyrFVmGHPXyKPYKdru7t.oLhGH39dPyi, (Action)delegate
					{
						int num3 = 1;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							default:
								h8uiRtfnRZ9JJpkepmSl.OOrfnUuElvP();
								kE4yISlW2FH07yTn3dSg();
								num4 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
								{
									num4 = 2;
								}
								break;
							case 1:
								hLKGyWlW08vOMPtXCXm7();
								num4 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd != 0)
								{
									num4 = 0;
								}
								break;
							case 2:
								if (!TM2ZuTVfu() && EEiCbZlWHvRTbwr7jfbl(j18iDj9nukSCmEyZs5lH.Settings))
								{
									aJQ3Aw9nrHYxvhL6prtg.Kuk9nhiUXsB((string)BCKLlclIsh7DtflYK6G5(j18iDj9nukSCmEyZs5lH.zQ09occ1hRy(), string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1435596783 ^ -1435595061), hiAT49lWfPgCbQejYJSt())));
								}
								return;
							}
						}
					});
					UETH72GzDcyNAirT5ahJ.E09GzekvJKi()?.Dispose();
					if (TM2ZuTVfu())
					{
						break;
					}
					goto case 8;
				case 2:
					j18iDj9nukSCmEyZs5lH.lmf9GS9l7aG().LYv99rUJr94 = (string)Jxg76ZlIKgtMT5VNu2hb();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					return;
				case 8:
				{
					Mutex sXFu34BvE = SXFu34BvE;
					if (sXFu34BvE == null)
					{
						num2 = 6;
						continue;
					}
					sXFu34BvE.ReleaseMutex();
					num2 = 10;
					continue;
				}
				case 4:
					if (!string.IsNullOrEmpty(zb4rnOukr()))
					{
						PRTtIblI75FRtDl68NYU(new ProcessStartInfo
						{
							Arguments = zb4rnOukr(),
							FileName = ((Assembly)dGdTEUlIwYCXdkRZhOXH()).Location
						});
						goto IL_01c4;
					}
					num2 = 7;
					continue;
				case 9:
					goto end_IL_0012;
				case 3:
					if (TM2ZuTVfu())
					{
						nmOWZtlIhXEUGFy43iSU(1000);
						num2 = 4;
						continue;
					}
					goto IL_01c4;
				case 5:
					mycy5LHEu3qqvRcny9Mb.O4RHQlb8unY();
					sHf61jN6Z();
					return;
				case 7:
					Process.Start(Application.ResourceAssembly.Location);
					goto IL_01c4;
				case 6:
				case 10:
					break;
					IL_01c4:
					RJQ40bG97fddixgFUWO6.B0oG9PDf0PT();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				wFghDOqc9()?.XojHceADGxN();
				mycy5LHEu3qqvRcny9Mb.O4RHQlb8unY();
				sHf61jN6Z();
				num2 = 9;
				continue;
				end_IL_0012:
				break;
			}
			kOoFfIWxX.Close();
			num = 3;
		}
	}

	public void U0ARtY0WI()
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
			{
				if (!yIrpqOkBf)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
					{
						num2 = 0;
					}
					break;
				}
				wFghDOqc9()?.XojHceADGxN();
				dJasUClI8VvQjIZWHsiP();
				sHf61jN6Z();
				kOoFfIWxX.ReleaseMutex();
				Mutex sXFu34BvE = SXFu34BvE;
				if (sXFu34BvE == null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 != 0)
					{
						num2 = 2;
					}
					break;
				}
				sXFu34BvE.ReleaseMutex();
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 3:
				return;
			case 0:
				return;
			case 2:
				return;
			}
		}
	}

	private void sHf61jN6Z()
	{
		LgW8j1lIAodLBW4Egjwo();
		LogManager.WriteLogs();
	}

	private void Xm9MfruvG(string P_0, Exception P_1)
	{
		try
		{
			LgpnvYlIPbmwDSa8gyxn(P_0);
			H5w15HlIJiuXTha3e7ND(P_1);
		}
		catch (Exception e)
		{
			LogManager.WriteError(e);
		}
		LogManager.WriteError(P_1);
	}

	private void DdaOYBpvI(object P_0, EventArgs P_1)
	{
		ufISqwnlKjfBQ2Zb0uV1 CS_0024_003C_003E8__locals11 = new ufISqwnlKjfBQ2Zb0uV1();
		CS_0024_003C_003E8__locals11.h4Cnlhkkaun = P_1;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		CS_0024_003C_003E8__locals11.AePnlwoLGdZ = this;
		dy5nQnlImT2NaWPlrObx(futGg9lIFE7ficxxp4AR(taNX8GlIjsgDZvVCqdoL()), (Action)delegate
		{
			try
			{
				Exception ex = null;
				UnhandledExceptionEventArgs e = CS_0024_003C_003E8__locals11.h4Cnlhkkaun as UnhandledExceptionEventArgs;
				int num2 = 8;
				UnobservedTaskExceptionEventArgs e2 = default(UnobservedTaskExceptionEventArgs);
				bool? flag = default(bool?);
				bool flag2 = default(bool);
				DispatcherUnhandledExceptionEventArgs e3 = default(DispatcherUnhandledExceptionEventArgs);
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 3:
							return;
						case 5:
							if (e2 != null)
							{
								CS_0024_003C_003E8__locals11.AePnlwoLGdZ.Xm9MfruvG((string)ufISqwnlKjfBQ2Zb0uV1.uTlcnSbuyXjCqAEuNFsA(-338769610 ^ -339063486), e2.Exception);
								return;
							}
							if (!(CS_0024_003C_003E8__locals11.h4Cnlhkkaun is DispatcherUnhandledExceptionEventArgs e4))
							{
								num3 = 2;
								continue;
							}
							ex = e4.Exception;
							goto case 2;
						case 7:
							CS_0024_003C_003E8__locals11.AePnlwoLGdZ.Xm9MfruvG((string)ufISqwnlKjfBQ2Zb0uV1.uTlcnSbuyXjCqAEuNFsA(0x32DEA4F1 ^ 0x32DA20B7), e.ExceptionObject as Exception);
							num2 = 3;
							break;
						case 4:
							flag = new d24A9O2w8euv7NyW18YM
							{
								Error = ex.ToString()
							}.ShowDialog();
							flag2 = true;
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
							{
								num3 = 0;
							}
							continue;
						case 6:
							e3.Handled = true;
							num3 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
							{
								num3 = 1;
							}
							continue;
						default:
							if (flag == flag2)
							{
								e3 = CS_0024_003C_003E8__locals11.h4Cnlhkkaun as DispatcherUnhandledExceptionEventArgs;
								if (e3 != null)
								{
									num3 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
									{
										num3 = 6;
									}
									continue;
								}
							}
							return;
						case 8:
							if (e == null)
							{
								e2 = CS_0024_003C_003E8__locals11.h4Cnlhkkaun as UnobservedTaskExceptionEventArgs;
								num2 = 5;
								break;
							}
							goto case 7;
						case 2:
							CS_0024_003C_003E8__locals11.AePnlwoLGdZ.Xm9MfruvG(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D35B065), ex);
							if (ex == null)
							{
								return;
							}
							goto case 4;
						case 1:
							return;
						}
						break;
					}
				}
			}
			catch (Exception ex2)
			{
				CS_0024_003C_003E8__locals11.AePnlwoLGdZ.Xm9MfruvG(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225526077), ex2);
			}
			finally
			{
				CS_0024_003C_003E8__locals11.AePnlwoLGdZ.sHf61jN6Z();
			}
		});
	}

	private static Assembly MVPq37q3o(object P_0, ResolveEventArgs P_1)
	{
		Assembly result = default(Assembly);
		try
		{
			string text = ((string)ASAqfqlI3wI5CcfOYrJ2(P_1)).Split(new char[1] { ',' })[0];
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!text.Contains((string)RkStE7lILo9I6vq5H6VU(--927068468 ^ 0x3741F762)) && !text.Contains(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E04209E)))
					{
						result = JBplhi9nTXhbb2E3caqw.D0L9nZOmWmi(text);
						num = 2;
						continue;
					}
					result = null;
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 != 0)
					{
						num = 0;
					}
					continue;
				case 0:
					break;
				case 2:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
			result = null;
		}
		return result;
	}

	public static void RZtI2o4O8(Action P_0)
	{
		int num = 1;
		int num2 = num;
		Dispatcher dispatcher = default(Dispatcher);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				dispatcher = Application.Current.Dispatcher;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (dispatcher == null || dispatcher.HasShutdownStarted)
			{
				return;
			}
			if (T69p7xlIpUBqBbUWb5ea(dispatcher))
			{
				P_0();
				return;
			}
			RP04gnlIupQQoBsENDyG(dispatcher, P_0, Array.Empty<object>());
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
			{
				num2 = 2;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void z0nWNyRCU()
	{
		int num = 3;
		int num2 = num;
		Uri resourceLocator = default(Uri);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				if (!wWt29Hlh6D)
				{
					wWt29Hlh6D = true;
					base.Startup += EkCE0C0jp;
					AWN1MQlIzsc7a2ZZOCfa(this, new SessionEndingCancelEventHandler(heSdMEsE0));
					base.Exit += tT4gGmDgY;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
				}
				break;
			default:
				Application.LoadComponent(this, resourceLocator);
				return;
			case 1:
				resourceLocator = new Uri((string)RkStE7lILo9I6vq5H6VU(0x68C7EAE6 ^ 0x68C7EC76), UriKind.Relative);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[STAThread]
	public static void LFwtOg57a()
	{
		aMVIXxlSkgpiTGaSyVJP.kLjw4iIsCLsZtxc4lksN0j();
		dSdtjnsurkSDIOox0m obj = new dSdtjnsurkSDIOox0m();
		obj.z0nWNyRCU();
		obj.Run();
	}

	[CompilerGenerated]
	private void dGTUAhOHl()
	{
		q48ujcHE8NavndQm2cwj.PWPHEJ2d7o4(wFghDOqc9().TkDHcJQq773());
	}

	[CompilerGenerated]
	private void x5bTvs8nV(object P_0, DispatcherUnhandledExceptionEventArgs P_1)
	{
		if (!Debugger.IsAttached)
		{
			DdaOYBpvI(P_0, P_1);
		}
	}

	[CompilerGenerated]
	private void HKoywwMEp()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				hLKGyWlW08vOMPtXCXm7();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (!TM2ZuTVfu() && EEiCbZlWHvRTbwr7jfbl(j18iDj9nukSCmEyZs5lH.Settings))
				{
					aJQ3Aw9nrHYxvhL6prtg.Kuk9nhiUXsB((string)BCKLlclIsh7DtflYK6G5(j18iDj9nukSCmEyZs5lH.zQ09occ1hRy(), string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1435596783 ^ -1435595061), hiAT49lWfPgCbQejYJSt())));
				}
				return;
			}
			h8uiRtfnRZ9JJpkepmSl.OOrfnUuElvP();
			kE4yISlW2FH07yTn3dSg();
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
			{
				num2 = 2;
			}
		}
	}

	static dSdtjnsurkSDIOox0m()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				GdTiP8lW9vSrrRdqCbZM();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
				{
					num2 = 0;
				}
				break;
			default:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				aMVIXxlSkgpiTGaSyVJP.kLjw4iIsCLsZtxc4lksN0j();
				return;
			}
		}
	}

	internal static bool XwZWpvlI5tNrBlrVYegy()
	{
		return lQLZuVlI1yiPK6rBjUZk == null;
	}

	internal static dSdtjnsurkSDIOox0m x8D4sIlIStBCOXBZMqnX()
	{
		return lQLZuVlI1yiPK6rBjUZk;
	}

	internal static object sr7PmylIx0dORYydU0hW()
	{
		return j18iDj9nukSCmEyZs5lH.zQ09occ1hRy();
	}

	internal static object RkStE7lILo9I6vq5H6VU(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object Cqlc9VlIeHmnpGJqrvTM(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object BCKLlclIsh7DtflYK6G5(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object Hv4LfilIXtTbDGo5EObL(object P_0)
	{
		return ((StartupEventArgs)P_0).Args;
	}

	internal static bool AS8DVslIcmrE41EgKomF(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object taNX8GlIjsgDZvVCqdoL()
	{
		return Application.Current;
	}

	internal static void TY1PvDlIEAytRDA7qS1e(object P_0, object P_1)
	{
		((AppDomain)P_0).AssemblyResolve += (ResolveEventHandler)P_1;
	}

	internal static void cN4ZSXlIQ1QMTdCR5bUU(object P_0, ThemeIntent P_1)
	{
		((ThemeDefinition)P_0).Intent = P_1;
	}

	internal static void KDQ51ilIdcmAR9RPFytv(object P_0, int P_1)
	{
		((ThemeDefinition)P_0).GrayMin = P_1;
	}

	internal static object s3R0qUlIgXTX747BiOg8(object P_0)
	{
		return XFont.GetFont((string)P_0);
	}

	internal static object bbmME8lIRvKLtyWWW2B6()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static void y9BhnklI6mfcRtLZQsa1(object P_0, double P_1)
	{
		((ThemeDefinition)P_0).ScrollBarThumbMargin = P_1;
	}

	internal static void LKgBIilIMnoVpjLSnRwM(object P_0, BorderContrastKind P_1)
	{
		((ThemeDefinition)P_0).BarItemBorderContrastKind = P_1;
	}

	internal static void UFN3NElIOOfgpgZ9F5my(object P_0, BorderContrastKind P_1)
	{
		((ThemeDefinition)P_0).ContainerBorderContrastKind = P_1;
	}

	internal static void xA8vqMlIqLTOSnnHPMfp(object P_0, object P_1)
	{
		((ThemeDefinition)P_0).DefaultFontFamily = (FontFamily)P_1;
	}

	internal static int WfpSMrlIIvQBbEJOY3NJ(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).FontSize;
	}

	internal static void N95VUHlIWa6GsNSq3xgh(object P_0, double P_1)
	{
		((ThemeDefinition)P_0).ScrollBarThumbCornerRadius = P_1;
	}

	internal static void XVUjSnlItIlu9JjUqi4C(object P_0, WindowBorderKind P_1)
	{
		((ThemeDefinition)P_0).WindowBorderKind = P_1;
	}

	internal static void WNnBvglIUSIiZF63MDqV(object P_0, BorderContrastKind P_1)
	{
		((ThemeDefinition)P_0).PopupBorderContrastKind = P_1;
	}

	internal static void XhDOgElITEfAHViTKxXB(bool P_0)
	{
		ThemeManager.AreNativeThemesEnabled = P_0;
	}

	internal static void lOKZtulIyBeck3v4KUfy()
	{
		ThemeManager.EndUpdate();
	}

	internal static object iUSkIDlIZxggSFdUPow3()
	{
		return TigerTrade.Properties.Resources.AppOnlyOneInstanceAllowed;
	}

	internal static void X73VXqlIVZ7AhmbXox0V(object P_0)
	{
		((Application)P_0).Shutdown();
	}

	internal static void i9BNkIlICWaK9B9DgtA0(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object Ge4WqHlIrCTO1qStbfCs()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object Jxg76ZlIKgtMT5VNu2hb()
	{
		return nRFqo49kFMgmB0IF2keU.BE591abZ7ab();
	}

	internal static void dy5nQnlImT2NaWPlrObx(object P_0, object P_1)
	{
		((Dispatcher)P_0).Invoke((Action)P_1);
	}

	internal static void nmOWZtlIhXEUGFy43iSU(int P_0)
	{
		Thread.Sleep(P_0);
	}

	internal static object dGdTEUlIwYCXdkRZhOXH()
	{
		return Application.ResourceAssembly;
	}

	internal static object PRTtIblI75FRtDl68NYU(object P_0)
	{
		return Process.Start((ProcessStartInfo)P_0);
	}

	internal static void dJasUClI8VvQjIZWHsiP()
	{
		mycy5LHEu3qqvRcny9Mb.O4RHQlb8unY();
	}

	internal static void LgW8j1lIAodLBW4Egjwo()
	{
		mycy5LHEu3qqvRcny9Mb.NIfHQDo0BxH();
	}

	internal static void LgpnvYlIPbmwDSa8gyxn(object P_0)
	{
		mycy5LHEu3qqvRcny9Mb.DFcHQ9cDevd((string)P_0);
	}

	internal static void H5w15HlIJiuXTha3e7ND(object P_0)
	{
		mycy5LHEu3qqvRcny9Mb.XGWHQnKaUNQ((Exception)P_0);
	}

	internal static object futGg9lIFE7ficxxp4AR(object P_0)
	{
		return ((DispatcherObject)P_0).Dispatcher;
	}

	internal static object ASAqfqlI3wI5CcfOYrJ2(object P_0)
	{
		return ((ResolveEventArgs)P_0).Name;
	}

	internal static bool T69p7xlIpUBqBbUWb5ea(object P_0)
	{
		return ((Dispatcher)P_0).CheckAccess();
	}

	internal static object RP04gnlIupQQoBsENDyG(object P_0, object P_1, object P_2)
	{
		return ((Dispatcher)P_0).BeginInvoke((Delegate)P_1, (object[])P_2);
	}

	internal static void AWN1MQlIzsc7a2ZZOCfa(object P_0, object P_1)
	{
		((Application)P_0).SessionEnding += (SessionEndingCancelEventHandler)P_1;
	}

	internal static void hLKGyWlW08vOMPtXCXm7()
	{
		TcManager.Save();
	}

	internal static void kE4yISlW2FH07yTn3dSg()
	{
		j18iDj9nukSCmEyZs5lH.Pvm9GoIbX5i();
	}

	internal static bool EEiCbZlWHvRTbwr7jfbl(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).SaveConfigOnExit;
	}

	internal static DateTime hiAT49lWfPgCbQejYJSt()
	{
		return TimeHelper.LocalTime;
	}

	internal static void GdTiP8lW9vSrrRdqCbZM()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
