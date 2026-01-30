using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using C7UvAf9ri2R97XEwp7o2;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Chart.Indicators.Common;
using TuAMtrl1Nd3XoZQQUXf0;

namespace LuhTk09IM2UNqIu1VNrV;

[DefaultMember("Item")]
internal sealed class hOOnlr9I6ptNbuV3ApFP : IEnumerable<IndicatorBase>, IEnumerable, IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class jEau5fnpnFVD6Qi4xoET
	{
		public static readonly jEau5fnpnFVD6Qi4xoET BrxnpYAUpuy;

		public static Func<IndicatorBase, ChartDataType> JqDnpoecNBi;

		internal static jEau5fnpnFVD6Qi4xoET qItgEnNWdG0PtdL50hyd;

		static jEau5fnpnFVD6Qi4xoET()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			BrxnpYAUpuy = new jEau5fnpnFVD6Qi4xoET();
		}

		public jEau5fnpnFVD6Qi4xoET()
		{
			DRWSiGNW6olpYGYwlwom();
			base._002Ector();
		}

		internal ChartDataType pyBnpGdgcSp(IndicatorBase indicator)
		{
			return indicator.ChartDataType;
		}

		internal static bool mD1A7sNWgNEkaqrDlBTK()
		{
			return qItgEnNWdG0PtdL50hyd == null;
		}

		internal static jEau5fnpnFVD6Qi4xoET fYybE1NWRl3af598lUSS()
		{
			return qItgEnNWdG0PtdL50hyd;
		}

		internal static void DRWSiGNW6olpYGYwlwom()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}
	}

	private readonly List<IndicatorBase> iUj9IVRlSwq;

	internal static hOOnlr9I6ptNbuV3ApFP iGM18IbORi3S44qT6T2T;

	public int Count => yoOgpmbOOdUNbNrOa1LM(iUj9IVRlSwq);

	public void CF39IOeHlh0(IndicatorBase P_0)
	{
		iUj9IVRlSwq.Add(P_0);
	}

	public void Nsh9IqGqpgh(int P_0, IndicatorBase P_1)
	{
		iUj9IVRlSwq.Insert(P_0, P_1);
	}

	public void Remove(IndicatorBase indicator)
	{
		iUj9IVRlSwq.Remove(indicator);
		fi0dX39rarBK9dp2dGQR fi0dX39rarBK9dp2dGQR = indicator as fi0dX39rarBK9dp2dGQR;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		fi0dX39rarBK9dp2dGQR?.Dispose();
	}

	public void Clear()
	{
		iUj9IVRlSwq.Clear();
	}

	public void cCG9IIvyCaj(IndicatorBase P_0, int P_1)
	{
		int num = iUj9IVRlSwq.IndexOf(P_0);
		iUj9IVRlSwq.Remove(P_0);
		int num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
		{
			num2 = 0;
		}
		switch (num2)
		{
		}
		iUj9IVRlSwq.Insert(num + P_1, P_0);
	}

	public void cQF9IWlUGl2(IndicatorBase P_0, IndicatorBase P_1)
	{
		int num = 2;
		int num2 = num;
		int i = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				for (; i < yoOgpmbOOdUNbNrOa1LM(iUj9IVRlSwq); i++)
				{
					if (P_0 == iUj9IVRlSwq[i])
					{
						iUj9IVRlSwq[i] = P_1;
						return;
					}
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				i = 0;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[SpecialName]
	public IndicatorBase Obe9IyeEFV4(int P_0)
	{
		return iUj9IVRlSwq[P_0];
	}

	public List<IndicatorBase> ktE9It6My7P()
	{
		return iUj9IVRlSwq.ToList();
	}

	public IEnumerator<IndicatorBase> GetEnumerator()
	{
		return iUj9IVRlSwq.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable)iUj9IVRlSwq).GetEnumerator();
	}

	public ChartDataType[] P459IURoIaI()
	{
		return iUj9IVRlSwq.Select((IndicatorBase indicator) => indicator.ChartDataType).ToArray();
	}

	public void Dispose()
	{
		foreach (IndicatorBase item in iUj9IVRlSwq)
		{
			fi0dX39rarBK9dp2dGQR fi0dX39rarBK9dp2dGQR = item as fi0dX39rarBK9dp2dGQR;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					if (fi0dX39rarBK9dp2dGQR != null)
					{
						hEfRpxbOqItdlTr28wBq(fi0dX39rarBK9dp2dGQR);
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
						{
							num = 1;
						}
						continue;
					}
					break;
				case 1:
					break;
				}
				break;
			}
		}
	}

	public hOOnlr9I6ptNbuV3ApFP()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		iUj9IVRlSwq = new List<IndicatorBase>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static hOOnlr9I6ptNbuV3ApFP()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool f0xFFZbO6xhB9JjrcgPF()
	{
		return iGM18IbORi3S44qT6T2T == null;
	}

	internal static hOOnlr9I6ptNbuV3ApFP UVrHpnbOMUFHso1Q9f9H()
	{
		return iGM18IbORi3S44qT6T2T;
	}

	internal static int yoOgpmbOOdUNbNrOa1LM(object P_0)
	{
		return ((List<IndicatorBase>)P_0).Count;
	}

	internal static void hEfRpxbOqItdlTr28wBq(object P_0)
	{
		((fi0dX39rarBK9dp2dGQR)P_0).Dispose();
	}
}
