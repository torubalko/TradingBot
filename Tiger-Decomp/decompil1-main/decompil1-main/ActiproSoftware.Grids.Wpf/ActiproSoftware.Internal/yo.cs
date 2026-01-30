using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Grids;
using ActiproSoftware.Windows.Controls.Grids.Primitives;

namespace ActiproSoftware.Internal;

internal class yo : ITreeItemNavigator
{
	private int dlK;

	[CompilerGenerated]
	private oT TlN;

	internal static yo tsw;

	public object CurrentItem => Nln()?.sNm();

	public int Depth
	{
		get
		{
			return dlK;
		}
		set
		{
			dlK = Math.Max(0, val);
		}
	}

	public yo(oT P_0)
	{
		fc.taYSkz();
		base._002Ector();
		if (P_0 != null)
		{
			qlp(P_0);
			Depth = P_0.LKi();
			return;
		}
		throw new ArgumentNullException(xv.hTz(10194));
	}

	private static IList<oT> YlJ(oT P_0)
	{
		List<oT> list = new List<oT>();
		while (P_0 != null)
		{
			list.Insert(0, P_0);
			P_0 = P_0.tNd();
		}
		return list;
	}

	[SpecialName]
	[CompilerGenerated]
	public oT Nln()
	{
		return TlN;
	}

	[SpecialName]
	[CompilerGenerated]
	private void qlp(oT P_0)
	{
		TlN = P_0;
	}

	public bool GoToCommonAncestor(object P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(10206));
		}
		TreeListBox treeListBox = Nln().nNQ();
		if (treeListBox != null)
		{
			oT oT2 = treeListBox.pPb(P_0, _0020: false, null);
			if (oT2 != null)
			{
				IList<oT> list = YlJ(oT2);
				IList<oT> list2 = YlJ(Nln());
				int num = -1;
				for (int i = 0; i < list.Count && i < list2.Count && list[i] == list2[i]; i++)
				{
					num = i;
				}
				if (num >= 0)
				{
					qlp(list2[num]);
					Depth = Nln().LKi();
					return true;
				}
			}
		}
		return false;
	}

	public bool GoToFirstChild()
	{
		if (Nln().aKd(_0020: true))
		{
			oT oT2 = Nln().kK3().FirstOrDefault();
			if (oT2 != null)
			{
				qlp(oT2);
				Depth++;
				return true;
			}
		}
		return false;
	}

	public bool GoToFirstVisible()
	{
		TreeNodeItemCollection treeNodeItemCollection = Nln().nNQ().lt1();
		if (treeNodeItemCollection.Count > 0)
		{
			oT oT2 = treeNodeItemCollection.uNx(0);
			if (Nln() != oT2)
			{
				qlp(oT2);
				Depth = Nln().LKi();
				return true;
			}
		}
		return false;
	}

	public bool GoToLastVisible()
	{
		TreeNodeItemCollection treeNodeItemCollection = Nln().nNQ().lt1();
		if (treeNodeItemCollection.Count > 0)
		{
			oT oT2 = treeNodeItemCollection.uNx(treeNodeItemCollection.Count - 1);
			if (Nln() != oT2)
			{
				qlp(oT2);
				Depth = Nln().LKi();
				return true;
			}
		}
		return false;
	}

	public void ul5(bool P_0, bool P_1)
	{
		if (P_0 && Nln().aKd(P_1))
		{
			oT oT2 = Nln().kK3().FirstOrDefault();
			if (oT2 != null)
			{
				qlp(oT2);
				Depth++;
				return;
			}
		}
		oT oT3 = Nln();
		oT oT4 = oT3.tNd();
		int num = Depth - 1;
		while (oT4 != null)
		{
			int num2 = oT4.kK3().IndexOf(oT3);
			if (num2 != -1 && num2 < oT4.kK3().Count - 1)
			{
				qlp(oT4.kK3()[num2 + 1]);
				Depth = num + 1;
				break;
			}
			oT3 = oT4;
			oT4 = oT3.tNd();
			num--;
		}
	}

	public bool GoToNextSibling()
	{
		oT oT2 = Nln();
		oT oT3 = oT2.tNd();
		int num = Depth - 1;
		if (oT3 != null)
		{
			int num2 = oT3.kK3().IndexOf(oT2);
			int num3 = 0;
			if (!vs2())
			{
				int num4 = default(int);
				num3 = num4;
			}
			switch (num3)
			{
			}
			if (num2 != -1 && num2 < oT3.kK3().Count - 1)
			{
				qlp(oT3.kK3()[num2 + 1]);
				Depth = num + 1;
				return true;
			}
		}
		return false;
	}

	public bool GoToNextVisible()
	{
		TreeNodeItemCollection treeNodeItemCollection = Nln().nNQ().lt1();
		int num = treeNodeItemCollection.GNi(Nln());
		if (num < treeNodeItemCollection.Count - 1)
		{
			qlp(treeNodeItemCollection.uNx(num + 1));
			Depth = Nln().LKi();
			return true;
		}
		return false;
	}

	public void YlW(Func<oT, bool> P_0)
	{
		TreeNodeItemCollection treeNodeItemCollection = Nln().nNQ().lt1();
		int num = treeNodeItemCollection.GNi(Nln());
		int num2 = num;
		if (num2 == -1)
		{
			return;
		}
		int num3 = num;
		while (++num3 < treeNodeItemCollection.Count)
		{
			oT arg = treeNodeItemCollection.uNx(num3);
			if (P_0(arg))
			{
				num2 = num3;
				break;
			}
		}
		if (num2 == num)
		{
			num3 = -1;
			while (++num3 < num)
			{
				oT arg = treeNodeItemCollection.uNx(num3);
				if (P_0(arg))
				{
					num2 = num3;
					break;
				}
			}
		}
		qlp(treeNodeItemCollection.uNx(num2));
		Depth = Nln().LKi();
	}

	public bool GoToParent()
	{
		oT oT2 = Nln().tNd();
		if (oT2 != null)
		{
			if (!oT2.HNU())
			{
				qlp(oT2);
				Depth--;
				return true;
			}
			TreeListBox treeListBox = oT2.nNQ();
			if (treeListBox != null && !treeListBox.IsRootItemVisible)
			{
				qlp(oT2);
				Depth--;
				return true;
			}
		}
		return false;
	}

	public bool GoToPreviousSibling()
	{
		oT oT2 = Nln();
		oT oT3 = oT2.tNd();
		int num = Depth - 1;
		if (oT3 != null)
		{
			int num2 = oT3.kK3().IndexOf(oT2);
			if (num2 != -1 && num2 > 0)
			{
				qlp(oT3.kK3()[num2 - 1]);
				Depth = num + 1;
				return true;
			}
		}
		return false;
	}

	public bool GoToPreviousVisible()
	{
		TreeNodeItemCollection treeNodeItemCollection = Nln().nNQ().lt1();
		int num = treeNodeItemCollection.GNi(Nln());
		if (num > 0)
		{
			qlp(treeNodeItemCollection.uNx(num - 1));
			Depth = Nln().LKi();
			return true;
		}
		return false;
	}

	internal static bool vs2()
	{
		return tsw == null;
	}

	internal static yo xsV()
	{
		return tsw;
	}
}
