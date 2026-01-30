using System;
using System.Collections.Generic;
using System.Diagnostics;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Internal;

internal class fAF
{
	private List<DAp> VTP;

	private HashSet<QAR> UTE;

	private static fAF CWR;

	private void Hbi(QAR P_0)
	{
		if (UTE == null)
		{
			UTE = new HashSet<QAR>();
		}
		UTE.Add(P_0);
	}

	private int qbp(int P_0)
	{
		int num = 0;
		int num2 = VTP.Count - 1;
		while (num <= num2)
		{
			int num3 = (num + num2) / 2;
			TextRange textRangeIncludingLineTerminator = VTP[num3].TextRangeIncludingLineTerminator;
			if (textRangeIncludingLineTerminator.IsZeroLength ? (textRangeIncludingLineTerminator.StartOffset == P_0) : textRangeIncludingLineTerminator.Contains(P_0))
			{
				return num3;
			}
			if (textRangeIncludingLineTerminator.EndOffset > P_0)
			{
				num2 = num3 - 1;
			}
			else
			{
				num = num3 + 1;
			}
		}
		if (num2 >= 0)
		{
			if (VTP[num2].EndOffsetIncludingLineTerminator > P_0)
			{
				return ~num2;
			}
			return ~(num2 + 1);
		}
		return -1;
	}

	private int rbM(int P_0, bool P_1)
	{
		QAR qAR = VTP[P_0].XbF();
		if (P_1)
		{
			while (P_0 + 1 < VTP.Count && VTP[P_0 + 1].XbF() == qAR)
			{
				P_0++;
			}
		}
		else
		{
			while (P_0 - 1 >= 0 && VTP[P_0 - 1].XbF() == qAR)
			{
				P_0--;
			}
		}
		return P_0;
	}

	private int BbO(TextRange P_0, bool P_1 = false)
	{
		int num = qbp(P_0.StartOffset);
		int num2 = num;
		bool flag = default(bool);
		int num3;
		if (num < 0)
		{
			num = ~num;
			flag = num > 0;
			num3 = 0;
			if (VW1() != null)
			{
				goto IL_0005;
			}
		}
		else
		{
			num3 = 3;
			if (!jWO())
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_0009:
		bool flag2 = default(bool);
		do
		{
			switch (num3)
			{
			default:
				if (flag)
				{
					DAp dAp = VTP[num - 1];
					if (!dAp.HasHardLineBreak && dAp.EndOffsetIncludingLineTerminator == P_0.StartOffset)
					{
						num = rbM(num - 1, _0020: false);
					}
				}
				goto IL_00aa;
			case 3:
				num = rbM(num, _0020: false);
				goto IL_00aa;
			case 1:
				if (flag2)
				{
					UbU(num, num2);
				}
				break;
			case 2:
				{
					num2 = ~num2 - 1;
					goto IL_003b;
				}
				IL_00aa:
				if (VTP.Count <= 0 || P_0.EndOffset + ((!P_1) ? 1 : 0) <= VTP[VTP.Count - 1].EndOffsetIncludingLineTerminator)
				{
					if (!P_0.IsZeroLength)
					{
						num2 = qbp(P_0.EndOffset - 1);
					}
					if (num2 < 0)
					{
						goto case 2;
					}
					num2 = rbM(num2, _0020: true);
				}
				else
				{
					num2 = VTP.Count - 1;
				}
				goto IL_003b;
				IL_003b:
				if (num > num2 || num >= VTP.Count)
				{
					break;
				}
				goto IL_0242;
			}
			return num;
			IL_0242:
			flag2 = VTP[num].StartOffset <= P_0.EndOffset;
			num3 = 1;
		}
		while (jWO());
		goto IL_0005;
		IL_0005:
		int num4 = default(int);
		num3 = num4;
		goto IL_0009;
	}

	private void UbU(int P_0, int P_1)
	{
		for (int num = P_1; num >= P_0; num--)
		{
			Hbi(VTP[num].XbF());
		}
		VTP.RemoveRange(P_0, P_1 - P_0 + 1);
	}

	private void XbJ(int P_0, int P_1)
	{
		int num = 1;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				flag = P_0 > 0;
				num2 = 0;
				if (VW1() != null)
				{
					num2 = 0;
				}
				continue;
			}
			if (flag)
			{
				P_0 = rbM(P_0 - 1, _0020: true) + 1;
			}
			if (P_1 < VTP.Count - 1)
			{
				P_1 = rbM(P_1 + 1, _0020: false) - 1;
			}
			if (P_0 <= P_1)
			{
				UbU(P_0, P_1);
			}
			return;
		}
	}

	public IEnumerable<DAp> rbt(ITextView P_0, TextSnapshotRange P_1, QAR P_2)
	{
		IList<ITextLayoutLine> layoutLines = P_2.Lines;
		int cacheIndex = BbO(layoutLines[layoutLines.Count - 1].HasHardLineBreak, (TextRange)P_1);
		int layoutLineIndex = 0;
		using IEnumerator<ITextLayoutLine> enumerator = layoutLines.GetEnumerator();
		if (!enumerator.MoveNext())
		{
			yield break;
		}
		while (true)
		{
			_ = enumerator.Current;
			DAp viewLine = new DAp(P_0, P_2, layoutLineIndex++);
			switch (2)
			{
			case 2:
				VTP.Insert(cacheIndex, viewLine);
				yield return viewLine;
				/*Error: Unable to find 'return true' for yield return*/;
			case 1:
				break;
			default:
				/*Error near IL_026b: Unexpected return in MoveNext()*/;
			}
		}
	}

	public void RbZ(ITextViewLineCollection P_0)
	{
		int count = VTP.Count;
		int num = count - 150;
		if (num > 0)
		{
			if (P_0.Count > 0)
			{
				int startOffset = P_0[0].StartOffset;
				int endOffsetIncludingLineTerminator = P_0[P_0.Count - 1].EndOffsetIncludingLineTerminator;
				int num2 = qbp(startOffset);
				if (num2 >= 0)
				{
					QAR qAR = VTP[num2].XbF();
					while (num2 > 0 && VTP[num2 - 1].XbF() == qAR)
					{
						num2--;
					}
				}
				else
				{
					num2 = ~num2;
				}
				int i = qbp(endOffsetIncludingLineTerminator);
				if (i >= 0)
				{
					for (QAR qAR2 = VTP[i].XbF(); i < count - 1 && VTP[i + 1].XbF() == qAR2; i++)
					{
					}
				}
				else
				{
					i = ~i;
				}
				int num3 = Math.Max(0, num2 - 1);
				int num4 = Math.Max(0, count - Math.Min(count, i + 1));
				if (num > 0 && num4 > 0)
				{
					num4 = Math.Min(num4, num);
					num -= num4;
					XbJ(count - num4, count - 1);
				}
				if (num > 0 && num3 > 0)
				{
					num3 = Math.Min(num3, num);
					num -= num3;
					XbJ(0, num3 - 1);
				}
			}
			else
			{
				XbJ(0, num - 1);
			}
		}
		if (UTE == null)
		{
			return;
		}
		foreach (QAR item in UTE)
		{
			item.Dispose();
		}
		UTE.Clear();
	}

	public void Sbh()
	{
		foreach (DAp item in VTP)
		{
			Hbi(item.XbF());
		}
		VTP.Clear();
	}

	public void qbN(TextRange P_0)
	{
		BbO(P_0);
	}

	public void Qbd(ITextSnapshot P_0, ITextSnapshot P_1)
	{
		if (P_0.Document != P_1.Document || P_0.Version.Number >= P_1.Version.Number)
		{
			Sbh();
			return;
		}
		int num = 0;
		ITextVersion textVersion = P_0.Version;
		while (textVersion != null && textVersion != P_1.Version)
		{
			IList<ITextChangeRangedOperation> operations = textVersion.Operations;
			if (operations != null)
			{
				num += operations.Count;
				if (num > 35)
				{
					Sbh();
					return;
				}
				foreach (ITextChangeRangedOperation item in operations)
				{
					int num2 = item.DeletionEndOffset;
					if (item.DeletionLength > 0 && item.DeletionEndPosition.Character == 0)
					{
						num2++;
					}
					int num3 = BbO(new TextRange(item.StartOffset, num2));
					int lengthDelta = item.LengthDelta;
					if (lengthDelta != 0)
					{
						for (int num4 = VTP.Count - 1; num4 >= num3; num4--)
						{
							VTP[num4].tbC(lengthDelta);
						}
					}
				}
			}
			textVersion = textVersion.Next;
		}
		foreach (DAp item2 in VTP)
		{
			item2.rbA(P_1);
		}
	}

	public bool abz(int P_0, bool P_1, out DAp P_2)
	{
		int num = qbp(P_0);
		if (num >= 0)
		{
			P_2 = VTP[num];
			if (!P_1 && P_2.StartOffset == P_0 && num > 0)
			{
				DAp dAp = VTP[num - 1];
				if (!dAp.HasHardLineBreak && dAp.EndOffsetIncludingLineTerminator == P_0)
				{
					P_2 = dAp;
				}
			}
			return true;
		}
		num = ~num;
		if (num > 0 && num == VTP.Count)
		{
			P_2 = VTP[num - 1];
			if (P_2.EndOffsetIncludingLineTerminator == P_0 && P_2.IsLastLine)
			{
				return true;
			}
		}
		P_2 = null;
		return false;
	}

	[Conditional("DEBUG")]
	public void YTW()
	{
		if (VTP.Count <= 0)
		{
			return;
		}
		int num = VTP[0].StartOffset - 1;
		int num2 = 0;
		if (VW1() != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		}
		for (int i = 0; i < VTP.Count; i++)
		{
			DAp dAp = VTP[i];
			if (dAp.StartOffset < num + ((!dAp.IsWrapped) ? 1 : 0))
			{
				throw new InvalidOperationException();
			}
			num = dAp.EndOffset;
		}
	}

	public fAF()
	{
		grA.DaB7cz();
		VTP = new List<DAp>();
		base._002Ector();
	}

	internal static bool jWO()
	{
		return CWR == null;
	}

	internal static fAF VW1()
	{
		return CWR;
	}
}
