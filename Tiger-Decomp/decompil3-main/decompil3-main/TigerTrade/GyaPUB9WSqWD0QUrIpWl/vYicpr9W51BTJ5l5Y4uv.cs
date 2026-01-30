using System.Collections.Generic;
using System.Runtime.Serialization;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using YA7hHI9Witfe8JGQQyp2;

namespace GyaPUB9WSqWD0QUrIpWl;

[DataContract(Name = "ChartIndicatorStyles", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators.Styles.Storage")]
internal sealed class vYicpr9W51BTJ5l5Y4uv
{
	private Dictionary<string, GT814n9Was7GuBCu1NxO> GtI9WXT0xfS;

	private static vYicpr9W51BTJ5l5Y4uv HAnWE8bOPBmfxfNWOKqN;

	[DataMember(Name = "StylesList")]
	public Dictionary<string, GT814n9Was7GuBCu1NxO> Styles
	{
		get
		{
			return GtI9WXT0xfS ?? (GtI9WXT0xfS = new Dictionary<string, GT814n9Was7GuBCu1NxO>());
		}
		set
		{
			GtI9WXT0xfS = gtI9WXT0xfS;
		}
	}

	public vYicpr9W51BTJ5l5Y4uv()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Styles = new Dictionary<string, GT814n9Was7GuBCu1NxO>();
	}

	public void vYJ9WxFCWLX(GT814n9Was7GuBCu1NxO P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!Styles.ContainsKey((string)aEshjTbO3NePlrweYJK1(P_0)))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
					{
						num2 = 0;
					}
					continue;
				}
				Styles.Remove(P_0.iVa9WDiDmW6);
				break;
			}
			break;
		}
		Styles.Add(P_0.iVa9WDiDmW6, P_0);
	}

	public GT814n9Was7GuBCu1NxO iyp9WLVUIOh(string P_0)
	{
		if (!Styles.ContainsKey(P_0))
		{
			return null;
		}
		return Styles[P_0];
	}

	public void Remove(string id)
	{
		if (Styles.ContainsKey(id))
		{
			Styles.Remove(id);
		}
	}

	static vYicpr9W51BTJ5l5Y4uv()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool zE5oqabOJoGkjd93c4FE()
	{
		return HAnWE8bOPBmfxfNWOKqN == null;
	}

	internal static vYicpr9W51BTJ5l5Y4uv uvvcspbOF2Cb4pAwIJl5()
	{
		return HAnWE8bOPBmfxfNWOKqN;
	}

	internal static object aEshjTbO3NePlrweYJK1(object P_0)
	{
		return ((GT814n9Was7GuBCu1NxO)P_0).iVa9WDiDmW6;
	}
}
