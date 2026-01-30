using System.Collections.Generic;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace VRsApd2ilCEhtIGFXcpy;

internal class v6IITN2iiGSrbfxWwCYF
{
	public static v6IITN2iiGSrbfxWwCYF h6w2i4Y9djW;

	private int EwY2iDrG4un;

	private readonly Dictionary<string, int> q1j2ibDJ06A;

	internal static v6IITN2iiGSrbfxWwCYF fC2EKj4INDZ4EMiIGWZh;

	public string GetName(string connectionID)
	{
		int num = 1;
		int num2 = num;
		int value;
		while (true)
		{
			switch (num2)
			{
			default:
				value = ++EwY2iDrG4un;
				q1j2ibDJ06A[connectionID] = value;
				break;
			case 1:
				if (!q1j2ibDJ06A.TryGetValue(connectionID, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			break;
		}
		return (string)L6fUNX4I5KmonZ3JImYA(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D19D9D), value);
	}

	public void Clear()
	{
		EwY2iDrG4un = 0;
		q1j2ibDJ06A.Clear();
	}

	public v6IITN2iiGSrbfxWwCYF()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		q1j2ibDJ06A = new Dictionary<string, int>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static v6IITN2iiGSrbfxWwCYF()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				CR7I8g4ISfysFc73ihqM();
				h6w2i4Y9djW = new v6IITN2iiGSrbfxWwCYF();
				return;
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object L6fUNX4I5KmonZ3JImYA(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static bool KPKvNw4IkouyUNHsKU0u()
	{
		return fC2EKj4INDZ4EMiIGWZh == null;
	}

	internal static v6IITN2iiGSrbfxWwCYF Waj0GK4I1TjtVMdX0fBQ()
	{
		return fC2EKj4INDZ4EMiIGWZh;
	}

	internal static void CR7I8g4ISfysFc73ihqM()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
