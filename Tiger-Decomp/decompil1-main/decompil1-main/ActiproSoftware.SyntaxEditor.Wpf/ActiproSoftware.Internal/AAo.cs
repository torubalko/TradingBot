using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Internal;

internal class AAo
{
	private class S7C
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private double SSn;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ITextSnapshotLine iS8;

		internal static S7C t3O;

		public S7C(ITextSnapshotLine P_0, double P_1)
		{
			grA.DaB7cz();
			base._002Ector();
			if (P_0 == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(192840));
			}
			VST(P_0);
			ES6(P_1);
		}

		[SpecialName]
		[CompilerGenerated]
		public double dSw()
		{
			return SSn;
		}

		[SpecialName]
		[CompilerGenerated]
		public void ES6(double P_0)
		{
			SSn = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public ITextSnapshotLine eSb()
		{
			return iS8;
		}

		[SpecialName]
		[CompilerGenerated]
		public void VST(ITextSnapshotLine P_0)
		{
			iS8 = P_0;
		}

		internal static bool A31()
		{
			return t3O == null;
		}

		internal static S7C h35()
		{
			return t3O;
		}
	}

	private S7C[] FTO;

	private int OTU;

	private double QTJ;

	internal static AAo IW3;

	private void KT9(int P_0)
	{
		S7C s7C = FTO[P_0];
		if (s7C.dSw() == QTJ)
		{
			QTJ = double.MaxValue;
		}
		if (P_0 < OTU - 1)
		{
			FTO[P_0] = FTO[OTU - 1];
		}
		OTU--;
	}

	private void hTy(ITextViewLine P_0)
	{
		double width = P_0.Size.Width;
		if (width > QTJ)
		{
			QTJ = width;
		}
		ITextSnapshotLine startLine = P_0.SnapshotRange.StartLine;
		for (int i = 0; i < OTU; i++)
		{
			S7C s7C = FTO[i];
			if (s7C.eSb().StartOffset == startLine.StartOffset)
			{
				if (s7C.dSw() == QTJ && width < QTJ)
				{
					QTJ = double.MaxValue;
				}
				s7C.ES6(width);
				return;
			}
		}
		if (OTU < 20)
		{
			FTO[OTU++] = new S7C(startLine, width);
			return;
		}
		double num = double.MaxValue;
		int num2 = 0;
		for (int j = 1; j < OTU; j++)
		{
			S7C s7C2 = FTO[j];
			if (s7C2.dSw() < num)
			{
				num2 = j;
				num = s7C2.dSw();
			}
		}
		if (width > num)
		{
			FTO[num2] = new S7C(startLine, width);
		}
	}

	public void PTq()
	{
		OTU = 0;
		QTJ = double.MaxValue;
	}

	public void jT2(TextSnapshotRange P_0)
	{
		for (int num = OTU - 1; num >= 0; num--)
		{
			if (FTO[num].eSb().SnapshotRange.IntersectsWith(P_0))
			{
				KT9(num);
			}
		}
	}

	[SpecialName]
	public double OTp()
	{
		if (QTJ == double.MaxValue)
		{
			QTJ = 0.0;
			for (int i = 0; i < OTU; i++)
			{
				QTJ = Math.Max(QTJ, FTO[i].dSw());
			}
		}
		return QTJ;
	}

	public void LT7(ITextSnapshot P_0, ITextSnapshot P_1)
	{
		int num = 1;
		bool flag = default(bool);
		int num3 = default(int);
		S7C s7C = default(S7C);
		TextSnapshotRange textSnapshotRange = default(TextSnapshotRange);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					if (!flag)
					{
						return;
					}
					if (P_0.Document != P_1.Document)
					{
						PTq();
						return;
					}
					num3 = 0;
					goto IL_00dd;
				case 1:
					break;
				case 2:
					{
						s7C.VST(textSnapshotRange.StartLine);
						goto IL_0155;
					}
					IL_00dd:
					if (num3 < OTU)
					{
						s7C = FTO[num3];
						textSnapshotRange = s7C.eSb().SnapshotRange.TranslateTo(P_1, TextRangeTrackingModes.DeleteWhenSurrounded);
						if (!textSnapshotRange.IsDeleted)
						{
							goto case 2;
						}
						KT9(num3);
						goto IL_0155;
					}
					return;
					IL_0155:
					num3++;
					goto IL_00dd;
				}
				flag = OTU > 0;
				num2 = 0;
			}
			while (vWv());
		}
	}

	public void hTi(IList<ITextViewLine> P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		foreach (ITextViewLine item in P_0)
		{
			hTy(item);
		}
	}

	public AAo()
	{
		grA.DaB7cz();
		FTO = new S7C[20];
		QTJ = double.MaxValue;
		base._002Ector();
	}

	internal static bool vWv()
	{
		return IW3 == null;
	}

	internal static AAo AWf()
	{
		return IW3;
	}
}
