using System;
using System.Collections.Generic;
using System.Globalization;
using ECOEgqlSad8NUJZ2Dr9n;
using Newtonsoft.Json.Linq;
using TuAMtrl1Nd3XoZQQUXf0;
using xDCpWkHyiuKZ3Q54rgJS;

namespace OYIsFQHrBM06TYgBhIvZ;

internal abstract class o2SAf6HrvB8BfCRtT7oF
{
	internal static o2SAf6HrvB8BfCRtT7oF HpDVRbDWKEHdNEXAU78v;

	public static List<dKSpGiHyaUa6LiEfhK5I> TvcHracN0aC(string P_0)
	{
		List<dKSpGiHyaUa6LiEfhK5I> list = new List<dKSpGiHyaUa6LiEfhK5I>();
		JArray obj = JArray.Parse(P_0);
		DateTime dateTime = new DateTime(1970, 1, 1);
		foreach (JToken item in obj)
		{
			if (long.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x12620268 ^ 0x1261F3F2)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result))
			{
				dKSpGiHyaUa6LiEfhK5I dKSpGiHyaUa6LiEfhK5I = new dKSpGiHyaUa6LiEfhK5I(dateTime.AddMilliseconds(result));
				if (long.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009772415)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result2))
				{
					dKSpGiHyaUa6LiEfhK5I.C7PHyDjhF2K = result2;
				}
				if (long.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4220DA8 ^ 0x421FC08)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result3))
				{
					dKSpGiHyaUa6LiEfhK5I.jdxHybNY54C = result3;
				}
				if (long.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1435596783 ^ -1435665993)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result4))
				{
					dKSpGiHyaUa6LiEfhK5I.sW6HyNmJLUK = result4;
				}
				if (long.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--927068468 ^ 0x37422788)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result5))
				{
					dKSpGiHyaUa6LiEfhK5I.Close = result5;
				}
				if (long.TryParse(((object)item[(object)stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x22BF43FC ^ 0x22BCB250)])?.ToString(), NumberStyles.Currency, CultureInfo.InvariantCulture, out var result6))
				{
					dKSpGiHyaUa6LiEfhK5I.Volume = result6;
				}
				list.Add(dKSpGiHyaUa6LiEfhK5I);
			}
		}
		return list;
	}

	protected o2SAf6HrvB8BfCRtT7oF()
	{
		W8RKc2DWw584vJFc0KXL();
		base._002Ector();
	}

	static o2SAf6HrvB8BfCRtT7oF()
	{
		XB5ZHqDW7gYpA2vSShbM();
	}

	internal static void W8RKc2DWw584vJFc0KXL()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool dERQQLDWm33L1iDNNxLE()
	{
		return HpDVRbDWKEHdNEXAU78v == null;
	}

	internal static o2SAf6HrvB8BfCRtT7oF ARTSdGDWhjE8jEL3HAD8()
	{
		return HpDVRbDWKEHdNEXAU78v;
	}

	internal static void XB5ZHqDW7gYpA2vSShbM()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
