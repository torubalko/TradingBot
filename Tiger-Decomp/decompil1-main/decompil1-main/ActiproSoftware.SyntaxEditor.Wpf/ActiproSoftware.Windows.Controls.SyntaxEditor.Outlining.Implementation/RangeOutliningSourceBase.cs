using System;
using System.Collections.Generic;
using System.Globalization;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining.Implementation;

public abstract class RangeOutliningSourceBase : IOutliningSource
{
	private struct m70 : IComparable<m70>
	{
		public OutliningNodeAction wra;

		public IOutliningNodeDefinition Grx;

		public int qrG;

		public int nrX;

		internal static object XHw;

		public int CompareTo(m70 P_0)
		{
			int result;
			if (qrG == P_0.qrG)
			{
				if (wra == P_0.wra)
				{
					result = nrX.CompareTo(P_0.nrX);
					int num = 0;
					if (YH8() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
				}
				else
				{
					result = P_0.wra.CompareTo(wra);
				}
			}
			else
			{
				result = qrG.CompareTo(P_0.qrG);
			}
			return result;
		}

		public override string ToString()
		{
			return string.Format(CultureInfo.InvariantCulture, Q7Z.tqM(219394), new object[3]
			{
				qrG,
				wra,
				((Grx != null) ? Grx.Key : null) ?? Q7Z.tqM(219512)
			});
		}

		internal static bool cHu()
		{
			return XHw == null;
		}

		internal static object YH8()
		{
			return XHw;
		}
	}

	private List<m70> om2;

	private bool gm7;

	private int Bmi;

	private ITextVersion Bmp;

	private static RangeOutliningSourceBase L7F;

	protected RangeOutliningSourceBase(ITextSnapshot snapshot)
	{
		grA.DaB7cz();
		om2 = new List<m70>();
		Bmi = -1;
		base._002Ector();
		if (snapshot != null)
		{
			Bmp = snapshot.Version;
		}
	}

	private int smy(int P_0)
	{
		int num = 0;
		int num2 = om2.Count - 1;
		int result;
		if (num2 != -1)
		{
			int num3;
			int num6 = default(int);
			while (true)
			{
				if (num > num2)
				{
					result = ~num;
					num3 = 0;
					if (C79())
					{
						num3 = 0;
					}
					break;
				}
				int num4 = num + (num2 - num >> 1);
				int num5 = om2[num4].qrG.CompareTo(P_0);
				if (num5 != 0)
				{
					if (num5 < 0)
					{
						num = num4 + 1;
					}
					else
					{
						num2 = num4 - 1;
					}
					continue;
				}
				result = num4;
				num3 = 1;
				if (o7J() != null)
				{
					num3 = num6;
				}
				break;
			}
			switch (num3)
			{
			}
		}
		else
		{
			result = -1;
		}
		return result;
	}

	private void Omq()
	{
		om2.Sort();
		for (int num = om2.Count - 1; num >= 1; num--)
		{
			if (om2[num].qrG == om2[num - 1].qrG)
			{
				om2.RemoveAt(num);
			}
		}
		Bmi = -1;
		gm7 = false;
	}

	public virtual void AddNode(TextRange textRange, IOutliningNodeDefinition definition)
	{
		if (definition == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11988));
		}
		if (!textRange.IsNormalized)
		{
			textRange.Normalize();
		}
		if (textRange.Length >= 2)
		{
			gm7 = true;
			om2.Add(new m70
			{
				qrG = textRange.StartOffset,
				nrX = textRange.StartOffset,
				wra = OutliningNodeAction.Start,
				Grx = definition
			});
			om2.Add(new m70
			{
				qrG = textRange.EndOffset - 1,
				nrX = textRange.StartOffset,
				wra = OutliningNodeAction.End,
				Grx = definition
			});
		}
	}

	public virtual void AddOpenNode(int startOffset, IOutliningNodeDefinition definition)
	{
		if (definition == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11988));
		}
		gm7 = true;
		om2.Add(new m70
		{
			qrG = startOffset,
			nrX = startOffset,
			wra = OutliningNodeAction.Start,
			Grx = definition
		});
	}

	public virtual OutliningNodeAction GetNodeAction(ref int offset, out IOutliningNodeDefinition definition)
	{
		if (gm7)
		{
			Omq();
		}
		if (Bmi != -1 && (Bmi >= om2.Count || offset > om2[Bmi].qrG))
		{
			Bmi = -1;
		}
		if (Bmi == -1)
		{
			Bmi = smy(offset);
			if (Bmi < 0)
			{
				Bmi = ~Bmi;
			}
		}
		if (Bmi < om2.Count && om2[Bmi].qrG == offset)
		{
			if (Bmi + 1 < om2.Count)
			{
				offset = om2[Bmi + 1].qrG;
			}
			definition = om2[Bmi].Grx;
			return om2[Bmi++].wra;
		}
		if (Bmi < om2.Count)
		{
			offset = om2[Bmi].qrG;
		}
		definition = null;
		return OutliningNodeAction.None;
	}

	public void TranslateTo(ITextSnapshot targetSnapshot)
	{
		if (targetSnapshot == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12012));
		}
		if (Bmp != null && targetSnapshot.Document == Bmp.Document && targetSnapshot.Version != Bmp)
		{
			List<m70> list = new List<m70>();
			for (int i = 0; i < om2.Count; i++)
			{
				ITextVersionRange textVersionRange = Bmp.CreateRange(om2[i].qrG, 0, TextRangeTrackingModes.DeleteWhenZeroLength);
				TextSnapshotRange textSnapshotRange = textVersionRange.Translate(targetSnapshot);
				list.Add(new m70
				{
					qrG = textSnapshotRange.StartOffset,
					nrX = om2[i].nrX,
					wra = om2[i].wra,
					Grx = om2[i].Grx
				});
			}
			gm7 = true;
			om2 = list;
			Bmi = -1;
		}
	}

	internal static bool C79()
	{
		return L7F == null;
	}

	internal static RangeOutliningSourceBase o7J()
	{
		return L7F;
	}
}
