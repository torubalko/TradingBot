using System;
using System.Linq;
using System.Runtime.CompilerServices;
using e1gqnHlHyrZNEp5krOqp;
using fw65ZwlH80L69M3hSoIg;
using HuO5Y0lHnExR4FQdnCur;
using LXGfFLlHesUWvrggcyd9;
using Mp0rQhXtcD2M433xKykv;
using Newtonsoft.Json;
using nXNMiwXTSjaRAVOuyCXd;
using oXyYyLlHhTmFPSxGiS65;
using QSiDZalflVDTvl4pbnjn;
using stgQjolf9YnaMr4Rx1Rc;
using tCyQUylHIGW2a3Cd06Sk;
using Vp7yuqlHpFxIftwTTcfE;
using WebSocketSharp;
using WebSocketSharp.Server;
using WUsie0XTELvQJLckfItk;
using yOonpUlHPoaAHc7b5cY5;

namespace QuE5CilHDXZ5kwVUBQSj;

internal class NLa9PylH4n6RJrlR13Mq : WebSocketBehavior
{
	private readonly Action<nciIUmlHmmRAonJs47XR, VoUcLvlH9KoApXATZoKl> VaGlHSdL6tu;

	private readonly GXmvf7lfiXtpqKM447jv lM1lHxgFnQQ;

	internal static NLa9PylH4n6RJrlR13Mq A926DIX7oYRUnxpj5OuE;

	public NLa9PylH4n6RJrlR13Mq(Action<nciIUmlHmmRAonJs47XR, VoUcLvlH9KoApXATZoKl> P_0, GXmvf7lfiXtpqKM447jv P_1)
	{
		ooDtSaXT5GMuQpfaOSTC.YJLXz0V1scY();
		((WebSocketBehavior)this)._002Ector();
		VaGlHSdL6tu = P_0;
		lM1lHxgFnQQ = P_1;
	}

	[SpecialName]
	private bool NU5lH1xgKmL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		return (int)PyoagpX7ad5Krvj6qDoh(this) == 1;
	}

	protected override void OnOpen()
	{
		XiwvfXX7lmm93YoD8qOp(lM1lHxgFnQQ, KDyrkkX7i0DVEN2DkeCl(--927068468 ^ 0x3741F134));
	}

	protected override void OnClose(CloseEventArgs P_0)
	{
		lM1lHxgFnQQ.Debug(string.Format((string)KDyrkkX7i0DVEN2DkeCl(-520155535 ^ -520155537), P_0.Code, P_0.Reason));
	}

	protected override void OnError(ErrorEventArgs P_0)
	{
		nNTKShX7DcWwiRegZlQh(lM1lHxgFnQQ, T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(-225822163 ^ -225822091) + (string)wNAWUCX74JOv0wWS7ZeW(P_0));
	}

	protected override void OnMessage(MessageEventArgs P_0)
	{
		int num = 6;
		nciIUmlHmmRAonJs47XR nciIUmlHmmRAonJs47XR = default(nciIUmlHmmRAonJs47XR);
		PCQe3ulHL4gGs7oLUrB7 pCQe3ulHL4gGs7oLUrB = default(PCQe3ulHL4gGs7oLUrB7);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 6:
					if (!P_0.IsText)
					{
						num = 5;
						break;
					}
					if (!XPnJ94X7NyeRK4s60s0Y(Qq37OCX7bH9kBGuG258K(P_0), T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(0x6E2DFBED ^ 0x6E2DFB53)))
					{
						lM1lHxgFnQQ.Debug(T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(-1606927328 ^ -1606927114) + P_0.Data);
						nciIUmlHmmRAonJs47XR = FCDlHb81qgI(P_0.Data);
						if (nciIUmlHmmRAonJs47XR == null)
						{
							num = 2;
							break;
						}
						pCQe3ulHL4gGs7oLUrB = new PCQe3ulHL4gGs7oLUrB7(this, nciIUmlHmmRAonJs47XR);
						string[] array = nciIUmlHmmRAonJs47XR.yhflvW2XaTA().ToArray();
						if (array.Length == 0)
						{
							num2 = 3;
							continue;
						}
						pCQe3ulHL4gGs7oLUrB.zhPlvR4QyyN(T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(0xECA3F28 ^ 0xECA3FDC), T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(0x78D396D8 ^ 0x78D397FE), (string)N5NjAxX7kxPuyuXmygEh(T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(-225822163 ^ -225821833), array));
						return;
					}
					((WebSocketBehavior)this).Send(T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(0x16AD7E76 ^ 0x16AD7EBC));
					return;
				case 3:
					if (nciIUmlHmmRAonJs47XR.dcVlHwVKOi0() != (nbvcNklHAOOciDsckIHy)1)
					{
						VaGlHSdL6tu(nciIUmlHmmRAonJs47XR, pCQe3ulHL4gGs7oLUrB);
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bbfaf0d55_002D19c0_002D4098_002Db583_002Dda26819b7a96_007D.m_b83e6c3cec4846c78f79ca94a9bb21df == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					return;
				case 7:
					return;
				default:
					pCQe3ulHL4gGs7oLUrB.hsQlv6upxUO();
					num2 = 4;
					continue;
				case 2:
					VmdlHkZ0fan(P_0.Data);
					num2 = 1;
					if (_003CModule_003E_007Bbfaf0d55_002D19c0_002D4098_002Db583_002Dda26819b7a96_007D.m_c1891612c6da4820840208e6b217a4f6 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					Close((CloseStatusCode)1003, T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(-1763895751 ^ -1763895737));
					num = 7;
					break;
				}
				break;
			}
		}
	}

	private nciIUmlHmmRAonJs47XR FCDlHb81qgI(string P_0)
	{
		try
		{
			nbvcNklHAOOciDsckIHy nbvcNklHAOOciDsckIHy = JsonConvert.DeserializeObject<nciIUmlHmmRAonJs47XR>(P_0).dcVlHwVKOi0();
			int num = 0;
			if (_003CModule_003E_007Bbfaf0d55_002D19c0_002D4098_002Db583_002Dda26819b7a96_007D.m_213cad9cfe4a40b2935d9da1dcc2fbeb == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					if (nbvcNklHAOOciDsckIHy != (nbvcNklHAOOciDsckIHy)1)
					{
						num = 2;
						if (_003CModule_003E_007Bbfaf0d55_002D19c0_002D4098_002Db583_002Dda26819b7a96_007D.m_c9fa8a91dc4646f4b7815b51086dbf5f != 0)
						{
							num = 1;
						}
						continue;
					}
					return JsonConvert.DeserializeObject<fOWy5VlH7TFYrmq0jpVX>(P_0);
				case 2:
					if (nbvcNklHAOOciDsckIHy == (nbvcNklHAOOciDsckIHy)2)
					{
						num = 1;
						if (_003CModule_003E_007Bbfaf0d55_002D19c0_002D4098_002Db583_002Dda26819b7a96_007D.m_c1891612c6da4820840208e6b217a4f6 != 0)
						{
							num = 1;
						}
						continue;
					}
					break;
				case 1:
					return JsonConvert.DeserializeObject<AC60jelff9vfeYJnXXxt>(P_0);
				}
				break;
			}
		}
		catch (Exception ex)
		{
			lM1lHxgFnQQ.Debug(T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(-1251569705 ^ -1251569995) + P_0 + T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(--500511424 ^ 0x1DD53362) + (string)C9wxowX71RCjfsqJVb3H(ex));
		}
		return null;
	}

	public void FVxlHNe8IBX(MtonmplHTxtIU9dniV2g P_0)
	{
		if (!NU5lH1xgKmL())
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007Bbfaf0d55_002D19c0_002D4098_002Db583_002Dda26819b7a96_007D.m_9946b411aedd4982baf68cd65fa81de6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			string text = (string)St4YwHX75a39QgRPpDue(P_0);
			int num2 = 0;
			if (_003CModule_003E_007Bbfaf0d55_002D19c0_002D4098_002Db583_002Dda26819b7a96_007D.m_63f412af8cf046b29513737dc0460ae8 != 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			}
			lM1lHxgFnQQ.Debug((string)MBKYrHX7SbUetHKZGlHQ(T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(0x28BBDCA ^ 0x28BBC7C), text));
			((WebSocketBehavior)this).Send(text);
		}
		catch (Exception exception)
		{
			lM1lHxgFnQQ.Error(T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(0x28B345BB ^ 0x28B3446D), exception);
		}
	}

	private void Close(CloseStatusCode closeStatusCode, string message)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		lM1lHxgFnQQ.Debug((string)KDyrkkX7i0DVEN2DkeCl(-527080372 ^ -527079860));
		try
		{
			((WebSocketBehavior)this).Context.WebSocket.Close(closeStatusCode, message);
		}
		catch (Exception exception)
		{
			lM1lHxgFnQQ.Error(T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(0x28B345BB ^ 0x28B3479F), exception);
		}
	}

	private void VmdlHkZ0fan(string P_0)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected I4, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		CloseStatusCode val = (CloseStatusCode)1007;
		object wf0lHZP8J0e = null;
		int num = 1;
		if (_003CModule_003E_007Bbfaf0d55_002D19c0_002D4098_002Db583_002Dda26819b7a96_007D.m_1c675215f8ba486f96c158d79017d661 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
			{
				try
				{
					wf0lHZP8J0e = JsonConvert.DeserializeObject<object>(P_0);
				}
				catch
				{
				}
				MtonmplHTxtIU9dniV2g mtonmplHTxtIU9dniV2g = new MtonmplHTxtIU9dniV2g
				{
					Title = T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(-1461292091 ^ -1461292655),
					Message = T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(-60853733 ^ -60854123),
					wf0lHZP8J0e = wf0lHZP8J0e,
					u5nlHVeY9fR = EHgpUtlH3TM8NZAaLXfQ.cgZlHzI0g2s((string)KDyrkkX7i0DVEN2DkeCl(0x7DB10E6E ^ 0x7DB10CB4), 400),
					phqlHCKJrWG = new cqadDelHqN3AFwINWGPP
					{
						Code = (int)val,
						V2klHWT0DLR = T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(--737722733 ^ 0x2BF8C3B7)
					}
				};
				FVxlHNe8IBX(mtonmplHTxtIU9dniV2g);
				Close(val, T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(-1311293279 ^ -1311292805));
				num = 0;
				if (_003CModule_003E_007Bbfaf0d55_002D19c0_002D4098_002Db583_002Dda26819b7a96_007D.m_b7fe544937c4426aa6da832dcc172216 == 0)
				{
					num = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	static NLa9PylH4n6RJrlR13Mq()
	{
		COaSINX7xNfB8EoePJA6();
		gwl1XaX7LqMslufDCAQZ();
	}

	internal static WebSocketState PyoagpX7ad5Krvj6qDoh(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((WebSocketBehavior)P_0).State;
	}

	internal static bool OePNKqX7vT6IScUKkCrS()
	{
		return A926DIX7oYRUnxpj5OuE == null;
	}

	internal static NLa9PylH4n6RJrlR13Mq UScKSFX7B1guuuIoWfHV()
	{
		return A926DIX7oYRUnxpj5OuE;
	}

	internal static object KDyrkkX7i0DVEN2DkeCl(int P_0)
	{
		return T2OXZhXtXqRemtkpvtX8.cdCXtmiQMBZ(P_0);
	}

	internal static void XiwvfXX7lmm93YoD8qOp(object P_0, object P_1)
	{
		((GXmvf7lfiXtpqKM447jv)P_0).Debug((string)P_1);
	}

	internal static object wNAWUCX74JOv0wWS7ZeW(object P_0)
	{
		return ((ErrorEventArgs)P_0).Message;
	}

	internal static void nNTKShX7DcWwiRegZlQh(object P_0, object P_1)
	{
		((GXmvf7lfiXtpqKM447jv)P_0).Error((string)P_1);
	}

	internal static object Qq37OCX7bH9kBGuG258K(object P_0)
	{
		return ((MessageEventArgs)P_0).Data;
	}

	internal static bool XPnJ94X7NyeRK4s60s0Y(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object N5NjAxX7kxPuyuXmygEh(object P_0, object P_1)
	{
		return string.Join((string)P_0, (string[])P_1);
	}

	internal static object C9wxowX71RCjfsqJVb3H(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object St4YwHX75a39QgRPpDue(object P_0)
	{
		return JsonConvert.SerializeObject(P_0);
	}

	internal static object MBKYrHX7SbUetHKZGlHQ(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void COaSINX7xNfB8EoePJA6()
	{
		T2OXZhXtXqRemtkpvtX8.g1uXtTdsjEL();
	}

	internal static void gwl1XaX7LqMslufDCAQZ()
	{
		opEHbQXTjwOP89DtxKKp.kLjw4iIsCLsZtxc4lksN0j();
	}
}
