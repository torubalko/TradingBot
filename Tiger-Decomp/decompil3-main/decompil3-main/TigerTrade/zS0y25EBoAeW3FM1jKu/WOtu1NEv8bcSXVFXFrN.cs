using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using ksQPwTiw35RnECmeKarT;
using TuAMtrl1Nd3XoZQQUXf0;
using zJRLkvjQYeLbRipD6tI;

namespace zS0y25EBoAeW3FM1jKu;

internal class WOtu1NEv8bcSXVFXFrN : Y40wjbjEJwBDdxlJjPo<string>
{
	[CompilerGenerated]
	private readonly ObservableCollection<string> vDYELQ8C8A;

	[CompilerGenerated]
	private readonly ICollectionView QELEeOvfG6;

	private string[] dxLEsJSkMZ;

	private Func<string, string, bool> XUgEXBISyZ;

	private string kDpEc5p9F7;

	private Func<string> lW8EjqJfkx;

	internal static WOtu1NEv8bcSXVFXFrN xKlO384nWMrGrsYl373h;

	public ObservableCollection<string> Values
	{
		[CompilerGenerated]
		get
		{
			return vDYELQ8C8A;
		}
	}

	public ICollectionView View
	{
		[CompilerGenerated]
		get
		{
			return QELEeOvfG6;
		}
	}

	public string SearchText
	{
		get
		{
			return kDpEc5p9F7;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					kDpEc5p9F7 = text;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					View?.Refresh();
					e2O6NG4nT7JoQcSLjYMx(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2017337494 ^ -2017337300));
					return;
				}
			}
		}
	}

	[SpecialName]
	public Func<string> whJEbqNCOd()
	{
		return lW8EjqJfkx;
	}

	[SpecialName]
	public void k1WEN25WHt(Func<string> P_0)
	{
		lW8EjqJfkx = P_0;
		XiIiwzjTvfE();
		zQWi70AxQTn(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1153206687 ^ -1153218265), lW8EjqJfkx);
	}

	public WOtu1NEv8bcSXVFXFrN(string P_0, string P_1, IEnumerable<string> P_2)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(P_0, P_1);
		dxLEsJSkMZ = P_2.ToArray();
		vDYELQ8C8A = new ObservableCollection<string>(dxLEsJSkMZ);
		QELEeOvfG6 = CollectionViewSource.GetDefaultView(Values);
	}

	public void neAEad5Iob(IEnumerable<string> P_0)
	{
		dxLEsJSkMZ = P_0.ToArray();
		Values.Clear();
		string[] array = dxLEsJSkMZ;
		foreach (string item in array)
		{
			Values.Add(item);
		}
		base.Value = Values.FirstOrDefault();
		View.Filter = null;
	}

	public void VN3Eii603D(IEnumerable<string> P_0, Func<string, string, bool> P_1)
	{
		neAEad5Iob(P_0);
		XUgEXBISyZ = P_1;
		View.Filter = Filter;
	}

	private bool Filter(object obj)
	{
		if (!string.IsNullOrEmpty(SearchText) && !Values.Contains(SearchText))
		{
			string text = obj as string;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return XUgEXBISyZ(SearchText, text);
				}
				if (text != null)
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
					{
						num = 1;
					}
					continue;
				}
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public int q5WESt2ERc()
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return num3;
			case 1:
				num3 = 0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac != 0)
				{
					num2 = 0;
				}
				continue;
			}
			while (true)
			{
				if (num3 < Values.Count)
				{
					if (Values[num3] == base.Value)
					{
						break;
					}
					num3++;
					continue;
				}
				return -1;
			}
			num2 = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
			{
				num2 = 0;
			}
		}
	}

	public QiemyulaGHDG0BH8DVd7 gWEElxgS6a<hNT72qlanuVV35IZdBp9, QiemyulaGHDG0BH8DVd7>(IEnumerable<hNT72qlanuVV35IZdBp9> P_0, Func<hNT72qlanuVV35IZdBp9, QiemyulaGHDG0BH8DVd7> P_1)
	{
		hNT72qlanuVV35IZdBp9[] array = P_0.ToArray();
		int num = q5WESt2ERc();
		if (num >= 0 && num < array.Length)
		{
			return P_1(array[num]);
		}
		return default(QiemyulaGHDG0BH8DVd7);
	}

	static WOtu1NEv8bcSXVFXFrN()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void e2O6NG4nT7JoQcSLjYMx(object P_0, object P_1)
	{
		((L34dcYiwF8r2NgF7JX2P)P_0).ifWlfmRSlkr((string)P_1);
	}

	internal static bool hCv6dg4ntLaefSyE1vmT()
	{
		return xKlO384nWMrGrsYl373h == null;
	}

	internal static WOtu1NEv8bcSXVFXFrN Eu7G6E4nUGnUP17rcn4v()
	{
		return xKlO384nWMrGrsYl373h;
	}
}
