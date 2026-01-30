using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using BfZtb759KlUg4482QKym;
using r8oOHiajFPNBXu6XiAHj;
using x97CE55GhEYKgt7TSVZT;

namespace EVGZtPaSqYL38OPuRcMs;

public static class plXx4qaSO0mUHx2yKA05
{
	internal static plXx4qaSO0mUHx2yKA05 sMC12ZxKip9eaVVvD8Og;

	public static HttpClient UrBaSI80GWN(string P_0, C3trUsajJIHJMtdo9pBg P_1 = null)
	{
		int num = 1;
		int num2 = num;
		WebProxy webProxy = default(WebProxy);
		HttpClientHandler httpClientHandler = default(HttpClientHandler);
		while (true)
		{
			switch (num2)
			{
			case 3:
			{
				if (!P_1.TRAaE0bpPZ4())
				{
					goto case 2;
				}
				WebProxy webProxy2 = new WebProxy();
				j7aZ2IxKDWx3L38gFRTw(webProxy2, new Uri(P_1.Proxy));
				webProxy2.BypassProxyOnLocal = false;
				QKYm0gxKbSQGAipoEqcF(webProxy2, true);
				webProxy = webProxy2;
				if (string.IsNullOrEmpty((string)CwpVZRxKN46hGaRUM7HD(P_1)))
				{
					num2 = 4;
					break;
				}
				if (!string.IsNullOrEmpty(P_1.Password))
				{
					webProxy.Credentials = new NetworkCredential((string)CwpVZRxKN46hGaRUM7HD(P_1), (string)T7dAn6xKkin0q45dwJdF(P_1));
				}
				goto case 4;
			}
			case 2:
				return new HttpClient(httpClientHandler)
				{
					BaseAddress = new Uri(P_0),
					Timeout = wBueXWxK1Gv18t9g7mR3(20.0),
					DefaultRequestHeaders = 
					{
						Accept = 
						{
							new MediaTypeWithQualityHeaderValue(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1153206687 ^ -1153292185))
						}
					}
				};
			case 4:
				httpClientHandler.Proxy = webProxy;
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				httpClientHandler = new HttpClientHandler
				{
					AutomaticDecompression = (DecompressionMethods.GZip | DecompressionMethods.Deflate)
				};
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (P_1 != null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			}
		}
	}

	static plXx4qaSO0mUHx2yKA05()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		eND2vdxK5irIXwlq9Bjy();
	}

	internal static void j7aZ2IxKDWx3L38gFRTw(object P_0, object P_1)
	{
		((WebProxy)P_0).Address = (Uri)P_1;
	}

	internal static void QKYm0gxKbSQGAipoEqcF(object P_0, bool P_1)
	{
		((WebProxy)P_0).UseDefaultCredentials = P_1;
	}

	internal static object CwpVZRxKN46hGaRUM7HD(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).OCiaEYswnjC();
	}

	internal static object T7dAn6xKkin0q45dwJdF(object P_0)
	{
		return ((C3trUsajJIHJMtdo9pBg)P_0).Password;
	}

	internal static TimeSpan wBueXWxK1Gv18t9g7mR3(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static bool TcRCw7xKlhNA9gQEPvG0()
	{
		return sMC12ZxKip9eaVVvD8Og == null;
	}

	internal static plXx4qaSO0mUHx2yKA05 jp8Gt4xK4w54VkjtLb77()
	{
		return sMC12ZxKip9eaVVvD8Og;
	}

	internal static void eND2vdxK5irIXwlq9Bjy()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
