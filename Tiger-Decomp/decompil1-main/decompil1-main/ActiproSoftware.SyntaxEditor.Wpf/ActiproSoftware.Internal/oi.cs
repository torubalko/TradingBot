using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

namespace ActiproSoftware.Internal;

internal class oi : IOutliningNode, IEnumerable<IOutliningNode>, IEnumerable
{
	private xp LvL;

	internal static oi Q7n;

	public int Count
	{
		get
		{
			Jc jc = LvL.tm8();
			return jc.iv9() ? jc.Wvk().Count : 0;
		}
	}

	public IOutliningNodeDefinition Definition => LvL.tm8().lvr();

	public bool IsCollapsed
	{
		get
		{
			return LvL.tm8().Gvq();
		}
		set
		{
			LvL.xm5().AAz(LvL, value2);
		}
	}

	public bool IsOpen => LvL.tm8().Hvi();

	public bool IsRoot => LvL.tm8().CvM();

	public IOutliningNode ParentNode
	{
		get
		{
			xp xp2 = LvL.ymm();
			return (xp2 != null) ? new oi(xp2) : null;
		}
	}

	public TextSnapshotRange SnapshotRange => LvL.tmb();

	public IOutliningNode this[int P_0]
	{
		get
		{
			xp xp2 = LvL.EmA(P_0);
			return (xp2 != null) ? new oi(xp2) : null;
		}
	}

	internal oi(xp P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11534));
		}
		LvL = P_0;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public IOutliningNode FindNodeRecursive(int P_0)
	{
		xp xp2 = LvL.Umv();
		int num3 = default(int);
		while (true)
		{
			bool flag = true;
			int num = xp2.Umu(P_0);
			bool flag2 = num >= 0;
			int num2 = 0;
			if (!y7q())
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
			if (flag2)
			{
				xp2.HmF(num);
				continue;
			}
			if (xp2.tm8() != LvL.tm8())
			{
				return new oi(xp2);
			}
			return null;
		}
	}

	public IEnumerator<IOutliningNode> GetEnumerator()
	{
		for (int index = 0; index < Count; index++)
		{
			yield return this[index];
		}
	}

	public string ToTreeString(int P_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(new string('\t', P_0));
		IOutliningNodeDefinition definition = Definition;
		stringBuilder.Append((definition != null) ? definition.Key : Q7Z.tqM(11550));
		if (IsCollapsed)
		{
			stringBuilder.Append(Q7Z.tqM(11572));
		}
		TextSnapshotRange snapshotRange = SnapshotRange;
		if (!snapshotRange.IsDeleted)
		{
			string text = Q7Z.tqM(11598);
			TextSnapshotRange textSnapshotRange = snapshotRange;
			stringBuilder.Append(text + textSnapshotRange.ToString());
		}
		if (Count > 0)
		{
			stringBuilder.AppendLine(Q7Z.tqM(11634));
			using (IEnumerator<IOutliningNode> enumerator = GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					IOutliningNode current = enumerator.Current;
					if (current != null)
					{
						stringBuilder.Append(current.ToTreeString(Math.Min(1000000, P_0) + 1));
					}
				}
			}
			stringBuilder.Append(new string('\t', P_0));
			stringBuilder.Append(Q7Z.tqM(11640));
		}
		stringBuilder.AppendLine();
		return stringBuilder.ToString();
	}

	internal static bool y7q()
	{
		return Q7n == null;
	}

	internal static oi E7x()
	{
		return Q7n;
	}
}
