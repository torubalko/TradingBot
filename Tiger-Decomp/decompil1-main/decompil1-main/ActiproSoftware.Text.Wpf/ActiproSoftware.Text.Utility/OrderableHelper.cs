using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

public static class OrderableHelper
{
	private class DT<q2> : IComparer<q2>
	{
		private Comparison<q2> eLF;

		private Comparison<q2> bLx;

		public DT(Comparison<q2> P_0, Comparison<q2> P_1)
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
			bLx = P_0;
			eLF = P_1;
		}

		[SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		public int Compare(q2 rm, q2 Ic)
		{
			if (bLx != null)
			{
				int num = bLx(rm, Ic);
				if (num != 0)
				{
					return num;
				}
			}
			IOrderable orderable = rm as IOrderable;
			IOrderable orderable2 = Ic as IOrderable;
			if (orderable != null)
			{
				if (orderable2 == null)
				{
					return -1;
				}
			}
			else if (orderable2 != null)
			{
				return 1;
			}
			if (eLF != null)
			{
				return eLF(rm, Ic);
			}
			return 0;
		}
	}

	private class Ch<Yd>
	{
		private List<Ch<Yd>> JLJ;

		private List<Ch<Yd>> HLX;

		private int VLN;

		private Yd ELR;

		private string KLf;

		private static object hcW;

		public Ch(string P_0)
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
			KLf = P_0;
		}

		public Ch(Yd lq, int P_1)
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
			ELR = lq;
			VLN = P_1;
		}

		private void tLg(OrderPlacement P_0, Ch<Yd> P_1)
		{
			if (P_0 == OrderPlacement.After)
			{
				if (JLJ == null)
				{
					JLJ = new List<Ch<Yd>>();
				}
				if (!JLJ.Contains(P_1))
				{
					JLJ.Add(P_1);
				}
			}
			else
			{
				if (HLX == null)
				{
					HLX = new List<Ch<Yd>>();
				}
				if (!HLX.Contains(P_1))
				{
					HLX.Add(P_1);
				}
			}
		}

		private void CLO(OrderPlacement P_0, Ch<Yd> P_1)
		{
			if (P_1 == null)
			{
				return;
			}
			List<Ch<Yd>> list = ((P_0 == OrderPlacement.After) ? JLJ : HLX);
			if (list == null)
			{
				return;
			}
			for (int num = list.Count - 1; num >= 0; num--)
			{
				if (list[num] == P_1)
				{
					list.RemoveAt(num);
					break;
				}
			}
		}

		public void HLl(List<Ch<Yd>> P_0, Dictionary<string, Ch<Yd>> P_1, OrderPlacement P_2, string P_3)
		{
			if (!string.IsNullOrEmpty(P_3))
			{
				if (!P_1.TryGetValue(P_3, out var value))
				{
					value = new Ch<Yd>(P_3);
					P_0.Add(value);
					P_1[P_3] = value;
				}
				tLg(P_2, value);
				value.tLg((P_2 == OrderPlacement.After) ? OrderPlacement.Before : OrderPlacement.After, this);
			}
		}

		[SpecialName]
		public IEnumerable<Ch<Yd>> rLW()
		{
			return JLJ;
		}

		[SpecialName]
		public int oL6()
		{
			return (JLJ != null) ? JLJ.Count : 0;
		}

		[SpecialName]
		public IEnumerable<Ch<Yd>> KL0()
		{
			return HLX;
		}

		[SpecialName]
		public int GLY()
		{
			return (HLX != null) ? HLX.Count : 0;
		}

		public bool gLi(IList<Ch<Yd>> P_0)
		{
			bool result = false;
			if (oL6() > 0)
			{
				foreach (Ch<Yd> item in JLJ)
				{
					item.CLO(OrderPlacement.Before, this);
				}
				JLJ = null;
			}
			if (GLY() > 0)
			{
				foreach (Ch<Yd> item2 in HLX)
				{
					item2.CLO(OrderPlacement.After, this);
					if (P_0 != null && item2.oL6() == 0)
					{
						P_0.Add(item2);
						result = true;
					}
				}
				HLX = null;
			}
			return result;
		}

		[SpecialName]
		public int MLD()
		{
			return VLN;
		}

		[SpecialName]
		public void kL1(int P_0)
		{
			VLN = P_0;
		}

		[SpecialName]
		public Yd nLK()
		{
			return ELR;
		}

		[SpecialName]
		public void xLk(Yd ts)
		{
			ELR = ts;
		}

		[SpecialName]
		public string DLr()
		{
			return KLf;
		}

		internal static bool Ncn()
		{
			return hcW == null;
		}

		internal static object LcA()
		{
			return hcW;
		}
	}

	private class dI<u7> : IComparer<Ch<u7>>
	{
		private Comparison<u7> iLt;

		private Comparison<u7> aLQ;

		public dI(Comparison<u7> P_0, Comparison<u7> P_1)
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
			aLQ = P_0;
			iLt = P_1;
		}

		[SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		public int Compare(Ch<u7> P_0, Ch<u7> P_1)
		{
			if (P_0 == P_1)
			{
				return 0;
			}
			if (P_0 != null)
			{
				if (P_1 == null)
				{
					return -1;
				}
				if (aLQ != null)
				{
					int num = aLQ(P_0.nLK(), P_1.nLK());
					if (num != 0)
					{
						return num;
					}
				}
				IOrderable orderable = P_0.nLK() as IOrderable;
				IOrderable orderable2 = P_1.nLK() as IOrderable;
				if (orderable != null)
				{
					if (orderable2 == null)
					{
						return -1;
					}
				}
				else if (orderable2 != null)
				{
					return 1;
				}
				if (iLt != null)
				{
					return iLt(P_0.nLK(), P_1.nLK());
				}
				int num2 = P_0.oL6().CompareTo(P_1.oL6());
				if (num2 != 0)
				{
					return num2;
				}
				return P_0.MLD().CompareTo(P_1.MLD());
			}
			return (P_1 != null) ? 1 : 0;
		}
	}

	private static IList<Ch<iV>> hVR<iV>(IEnumerable<iV> P_0)
	{
		List<Ch<iV>> list = new List<Ch<iV>>();
		Dictionary<string, Ch<iV>> dictionary = new Dictionary<string, Ch<iV>>();
		int num = 0;
		foreach (iV item in P_0)
		{
			if (item == null)
			{
				continue;
			}
			if (item is IKeyedObject keyedObject && !string.IsNullOrEmpty(keyedObject.Key))
			{
				if (dictionary.TryGetValue(keyedObject.Key, out var value))
				{
					if (value.nLK() != null)
					{
						list.Add(new Ch<iV>(item, ++num));
						continue;
					}
				}
				else
				{
					value = new Ch<iV>(keyedObject.Key);
					list.Add(value);
					dictionary[keyedObject.Key] = value;
				}
				if (value.nLK() == null)
				{
					value.xLk(item);
					value.kL1(++num);
				}
				if (!(keyedObject is IOrderable { Orderings: { } orderings }))
				{
					continue;
				}
				foreach (Ordering item2 in orderings)
				{
					value.HLl(list, dictionary, item2.Placement, item2.Key);
				}
			}
			else
			{
				list.Add(new Ch<iV>(item, ++num));
			}
		}
		pVt(list);
		return list;
	}

	private static IList<Ch<CB>> xVf<CB>(IEnumerable<CB> P_0) where CB : IOrderable
	{
		List<Ch<CB>> list = new List<Ch<CB>>();
		Dictionary<string, Ch<CB>> dictionary = new Dictionary<string, Ch<CB>>();
		int num = 0;
		foreach (CB item in P_0)
		{
			if (item == null)
			{
				continue;
			}
			if (dictionary.TryGetValue(item.Key, out var value))
			{
				if (value.nLK() != null)
				{
					list.Add(new Ch<CB>(item, ++num));
					continue;
				}
			}
			else
			{
				value = new Ch<CB>(item.Key);
				list.Add(value);
				dictionary[item.Key] = value;
			}
			if (value.nLK() == null)
			{
				value.xLk(item);
				value.kL1(++num);
			}
			IEnumerable<Ordering> orderings = item.Orderings;
			if (orderings == null)
			{
				continue;
			}
			foreach (Ordering item2 in orderings)
			{
				value.HLl(list, dictionary, item2.Placement, item2.Key);
			}
		}
		pVt(list);
		return list;
	}

	private static void pVt<I9>(List<Ch<I9>> P_0)
	{
		for (int num = P_0.Count - 1; num >= 0; num--)
		{
			if (P_0[num].nLK() == null)
			{
				P_0[num].gLi(null);
				P_0.RemoveAt(num);
			}
		}
	}

	private static bool iVQ<KA>(IEnumerable<KA> P_0)
	{
		return P_0.Any((KA i) => i is IOrderable { Orderings: { } orderings } && orderings.Any());
	}

	private static zu[] GVn<zu>(IList<Ch<zu>> P_0, dI<zu> P_1)
	{
		List<Ch<zu>> list = P_0.Where((Ch<zu> n) => n.oL6() == 0).OrderBy((Ch<zu> n) => n, P_1).ToList();
		zu[] array = new zu[P_0.Count];
		int num = 0;
		while (P_0.Count > 0)
		{
			Ch<zu> ch;
			if (list.Count > 0)
			{
				ch = list.First();
				list.RemoveAt(0);
			}
			else
			{
				ch = null;
				foreach (Ch<zu> item in P_0)
				{
					if (ch == null || P_1.Compare(item, ch) < 0)
					{
						ch = item;
					}
				}
			}
			if (ch.gLi(list))
			{
				list.Sort(P_1);
			}
			array[num++] = ch.nLK();
			P_0.Remove(ch);
		}
		return array;
	}

	public static T[] Sort<T>(IEnumerable<T> unsortedItems) where T : IOrderable
	{
		if (unsortedItems == null)
		{
			return new T[0];
		}
		int num = unsortedItems.Count();
		if (num <= 1 || !iVQ(unsortedItems))
		{
			return unsortedItems.ToArray();
		}
		IList<Ch<T>> list = xVf(unsortedItems);
		return GVn(list, new dI<T>(null, null));
	}

	[SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
	public static T[] Sort<T>(IEnumerable<T> unsortedItems, Comparison<T> preComparison, Comparison<T> fallbackComparison)
	{
		if (unsortedItems == null)
		{
			return new T[0];
		}
		int num = unsortedItems.Count();
		if (num <= 1)
		{
			return unsortedItems.ToArray();
		}
		if (!iVQ(unsortedItems))
		{
			T[] array = unsortedItems.ToArray();
			if (preComparison != null || fallbackComparison != null)
			{
				Array.Sort(array, new DT<T>(preComparison, fallbackComparison));
			}
			return array;
		}
		IList<Ch<T>> list = hVR(unsortedItems);
		return GVn(list, new dI<T>(preComparison, fallbackComparison));
	}
}
