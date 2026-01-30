#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ActiproSoftware.Internal;

internal class XA
{
	private enum XdR
	{

	}

	internal fw Ho4;

	internal u2 KoB;

	internal int Maximum;

	internal int Minimum;

	internal int poh;

	internal string Qow;

	internal string qoN;

	private List<XA> eoU;

	internal static XA eaV;

	internal XA(int P_0)
	{
		awj.QuEwGz();
		Ho4 = (fw)0;
		base._002Ector();
		poh = P_0;
	}

	internal XA(int P_0, string P_1)
	{
		awj.QuEwGz();
		Ho4 = (fw)0;
		base._002Ector();
		poh = P_0;
		qoN = P_1;
	}

	internal XA(int P_0, char P_1, fw P_2)
	{
		awj.QuEwGz();
		Ho4 = (fw)0;
		base._002Ector();
		poh = P_0;
		qoN = P_1.ToString();
		Ho4 = P_2;
	}

	internal XA(int P_0, string P_1, fw P_2)
	{
		awj.QuEwGz();
		Ho4 = (fw)0;
		base._002Ector();
		poh = P_0;
		qoN = P_1;
		Ho4 = P_2;
	}

	internal XA(int P_0, int P_1, int P_2)
	{
		awj.QuEwGz();
		Ho4 = (fw)0;
		base._002Ector();
		poh = P_0;
		Minimum = P_1;
		Maximum = P_2;
	}

	internal XA(int P_0, XA P_1)
	{
		awj.QuEwGz();
		Ho4 = (fw)0;
		base._002Ector();
		poh = P_0;
		Poe().Add(P_1);
	}

	internal XA(u2 P_0, u2 P_1, bool P_2, fw P_3)
	{
		awj.QuEwGz();
		Ho4 = (fw)0;
		base._002Ector();
		Ho4 = P_3;
		if (P_0.hYK())
		{
			int num = 0;
			if (false)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			}
			poh = ((!P_2) ? 1 : 2);
			qoN = P_0.TYd(0).IYp().ToString();
		}
		else
		{
			poh = 3;
			if (P_2)
			{
				P_0.tYq(!P_0.xYG());
				P_1.tYq(!P_1.xYG());
			}
			qoN = P_0.K0y();
			Qow = P_1.K0y();
			KoB = P_0;
		}
	}

	[SpecialName]
	internal List<XA> Poe()
	{
		if (eoU == null)
		{
			eoU = new List<XA>();
		}
		return eoU;
	}

	internal void uoZ(int P_0)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (eoU.Count <= 0)
					{
						return;
					}
					{
						foreach (XA item in eoU)
						{
							item.uoZ(P_0 + 1);
						}
						return;
					}
				case 1:
					flag = P_0 > 0;
					num2 = 0;
					if (caH() == null)
					{
						continue;
					}
					break;
				default:
					if (flag)
					{
						Debug.Write(new string('\t', P_0));
					}
					if (KoB == null)
					{
						if (qoN != null)
						{
							Debug.WriteLine(string.Format(CultureInfo.InvariantCulture, QdM.AR8(23788), new object[2]
							{
								Enum.GetName(typeof(XdR), poh),
								qoN
							}));
						}
						else if (Minimum > 0 || Maximum > 0)
						{
							Debug.WriteLine(string.Format(CultureInfo.InvariantCulture, QdM.AR8(23808), new object[3]
							{
								Enum.GetName(typeof(XdR), poh),
								Minimum,
								Maximum
							}));
						}
						else
						{
							Debug.WriteLine(string.Format(CultureInfo.InvariantCulture, QdM.AR8(23838), new object[1] { Enum.GetName(typeof(XdR), poh) }));
						}
					}
					else
					{
						Debug.WriteLine(string.Format(CultureInfo.InvariantCulture, QdM.AR8(23788), new object[2]
						{
							Enum.GetName(typeof(XdR), poh),
							KoB
						}));
					}
					if (eoU == null)
					{
						return;
					}
					num2 = 2;
					if (caH() == null)
					{
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal bool Vot(u2 P_0)
	{
		switch (poh)
		{
		case 34:
			P_0.t0r(u2.F0J());
			return true;
		case 36:
			P_0.t0r(u2.Q0k());
			return true;
		case 16:
		{
			u2 u3 = new u2();
			foreach (XA item in Poe())
			{
				if (!item.Vot(u3))
				{
					return false;
				}
			}
			P_0.t0r(u3);
			return true;
		}
		case 1:
			if (Ho4 == (fw)0 || !char.IsLetter(qoN[0]))
			{
				P_0.Add(qoN[0]);
			}
			else
			{
				P_0.Add(char.ToLowerInvariant(qoN[0]));
				P_0.Add(char.ToUpperInvariant(qoN[0]));
			}
			return true;
		case 3:
			P_0.t0r(KoB);
			return true;
		case 17:
			foreach (XA item2 in Poe())
			{
				if (!item2.Vot(P_0))
				{
					return false;
				}
				if (P_0.Count > 0)
				{
					return true;
				}
			}
			return true;
		case 38:
			P_0.t0r(u2.z07());
			return true;
		case 44:
			P_0.t0r(u2.e0w());
			return true;
		case 46:
			P_0.t0r(u2.V0z);
			return true;
		case 40:
			P_0.t0r(u2.w0B());
			return true;
		case 37:
			P_0.t0r(u2.aYQ());
			return true;
		case 2:
		{
			u2 u4 = new u2();
			if (Ho4 == (fw)0 || !char.IsLetter(qoN[0]))
			{
				u4.Add(qoN[0]);
			}
			else
			{
				u4.Add(char.ToLowerInvariant(qoN[0]));
				u4.Add(char.ToUpperInvariant(qoN[0]));
			}
			u4.tYq(!u4.xYG());
			P_0.t0r(u4);
			return true;
		}
		case 39:
			P_0.t0r(u2.RYC());
			return true;
		case 41:
			P_0.t0r(u2.CYs());
			return true;
		case 45:
			P_0.t0r(u2.JYP());
			return true;
		case 47:
			P_0.t0r(u2.TYf);
			return true;
		case 43:
			P_0.t0r(u2.YYX);
			return true;
		case 33:
			P_0.t0r(u2.UYx());
			return true;
		case 27:
			if (Minimum == 0 || Poe().Count == 0)
			{
				return false;
			}
			return eoU[0].Vot(P_0);
		case 4:
			if (Ho4 == (fw)0 || !char.IsLetter(qoN[0]))
			{
				P_0.Add(qoN[0]);
			}
			else
			{
				P_0.Add(char.ToLowerInvariant(qoN[0]));
				P_0.Add(char.ToUpperInvariant(qoN[0]));
			}
			return true;
		case 42:
			P_0.t0r(u2.cYg);
			return true;
		case 32:
			P_0.t0r(u2.qYo());
			return true;
		case 18:
		case 19:
			if (Poe().Count == 1)
			{
				return Poe()[0].Vot(P_0);
			}
			return true;
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
		case 20:
		case 21:
		case 22:
		case 23:
		case 24:
			return true;
		default:
			return false;
		}
	}

	[SpecialName]
	internal bool poE()
	{
		return eoU != null;
	}

	internal XA Jon(int P_0, int P_1)
	{
		if (P_0 == 1 && P_1 == 1)
		{
			return this;
		}
		XA xA = new XA(27, P_0, P_1);
		xA.Poe().Add(this);
		return xA;
	}

	internal XA LoJ()
	{
		XA result = this;
		if (eoU != null)
		{
			for (int i = 0; i < eoU.Count; i++)
			{
				eoU[i] = eoU[i].LoJ();
				if (poh == 17 && eoU[i].poh == 17)
				{
					XA xA = eoU[i];
					eoU.RemoveAt(i);
					eoU.InsertRange(i, xA.Poe());
					i += xA.Poe().Count - 1;
				}
			}
		}
		int num = poh;
		int num2 = num;
		if (num2 == 17 && eoU != null && eoU.Count > 0)
		{
			int num3 = eoU[0].poh;
			int num4 = num3;
			bool flag = ((num4 == 1 || num4 == 4) ? true : false);
			for (int j = 1; j < eoU.Count; j++)
			{
				int num5 = eoU[j].poh;
				int num6 = num5;
				bool flag2 = ((num6 == 1 || num6 == 4) ? true : false);
				if (flag && flag2)
				{
					eoU[j - 1].poh = 4;
					eoU[j - 1].qoN = eoU[j - 1].qoN + eoU[j].qoN;
					eoU.RemoveAt(j);
					j--;
				}
				flag = flag2;
			}
			if (eoU.Count == 1)
			{
				result = eoU[0];
			}
		}
		return result;
	}

	internal static bool dau()
	{
		return eaV == null;
	}

	internal static XA caH()
	{
		return eaV;
	}
}
