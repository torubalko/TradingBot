using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.Rendering;

namespace ActiproSoftware.Internal;

internal class NA5 : ITextProvider
{
	private TextRange eHu;

	private IList<TextRange> IH1;

	private ITextSnapshot THF;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int YH3;

	internal static NA5 NWn;

	public int Length
	{
		[CompilerGenerated]
		get
		{
			return YH3;
		}
		[CompilerGenerated]
		private set
		{
			YH3 = yH;
		}
	}

	public NA5(TextSnapshotRange P_0, NormalizedTextSnapshotRangeCollection P_1)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(194096));
		}
		THF = P_0.Snapshot;
		eHu = P_0;
		IH1 = P_1.Select((TextSnapshotRange r) => r.TextRange).ToArray();
		Length = P_1.Sum((TextSnapshotRange sr) => sr.Length);
	}

	public string GetSubstring(int P_0, int P_1)
	{
		if (P_0 == 0 && P_1 == Length)
		{
			if (IH1.Count == 1)
			{
				return THF.GetSubstring(IH1[0], LineTerminator.Newline);
			}
			StringBuilder stringBuilder = new StringBuilder();
			foreach (TextRange item in IH1)
			{
				stringBuilder.Append(THF.GetSubstring(item, LineTerminator.Newline));
			}
			return stringBuilder.ToString();
		}
		int num = 0;
		int num2 = P_0 + P_1;
		StringBuilder stringBuilder2 = null;
		for (int i = 0; i < IH1.Count; i++)
		{
			TextRange textRange = IH1[i];
			int num3 = num;
			if (num < P_0)
			{
				int num4 = P_0 - num;
				if (num4 >= textRange.Length)
				{
					num += textRange.Length;
					continue;
				}
				num += num4;
			}
			int num5 = textRange.StartOffset + (num - num3);
			int num6 = Math.Min(textRange.EndOffset, num5 + P_1) - num5;
			string substring = THF.GetSubstring(num5, num6, LineTerminator.Newline);
			if (stringBuilder2 != null || IH1.Count > 1)
			{
				if (stringBuilder2 == null)
				{
					stringBuilder2 = new StringBuilder();
				}
				stringBuilder2.Append(substring);
				num += num6;
				if (num >= num2)
				{
					break;
				}
				continue;
			}
			return substring;
		}
		return (stringBuilder2 != null) ? stringBuilder2.ToString() : string.Empty;
	}

	public void THl(ITextSnapshot P_0)
	{
		THF = P_0;
	}

	public int Translate(int P_0, TextProviderTranslateModes P_1)
	{
		bool flag = (P_1 & TextProviderTranslateModes.PositiveTracking) == TextProviderTranslateModes.PositiveTracking;
		switch (P_1)
		{
		case TextProviderTranslateModes.FromSourceText:
		case TextProviderTranslateModes.PositiveTracking:
		{
			int num2 = P_0;
			bool flag2 = false;
			if (IH1.Count > 0)
			{
				if (num2 <= eHu.StartOffset)
				{
					P_0 = 0;
				}
				else if (num2 <= IH1[0].StartOffset)
				{
					P_0 = 0;
					flag2 = true;
				}
				else if (num2 >= IH1[IH1.Count - 1].EndOffset)
				{
					P_0 = IH1.Sum((TextRange sr) => sr.Length);
					flag2 = true;
				}
				else
				{
					P_0 = 0;
					for (int num3 = 0; num3 < IH1.Count; num3++)
					{
						TextRange textRange2 = IH1[num3];
						if (num2 < textRange2.EndOffset)
						{
							P_0 += num2 - textRange2.StartOffset;
							flag2 = true;
							break;
						}
						P_0 += textRange2.Length;
						if (num2 == textRange2.EndOffset)
						{
							break;
						}
					}
				}
			}
			else
			{
				P_0 = 0;
				flag2 = num2 >= eHu.EndOffset;
			}
			if (flag && !flag2)
			{
				P_0 = ~P_0;
			}
			return P_0;
		}
		case TextProviderTranslateModes.ToSourceText:
		case TextProviderTranslateModes.ToSourceText | TextProviderTranslateModes.PositiveTracking:
			if (IH1.Count > 0)
			{
				if (P_0 == 0 && !flag)
				{
					return eHu.StartOffset;
				}
				int num = P_0;
				for (int i = 0; i < IH1.Count; i++)
				{
					TextRange textRange = IH1[i];
					if (num <= 0)
					{
						return textRange.StartOffset;
					}
					if (num < textRange.Length + ((!flag) ? 1 : 0))
					{
						return textRange.StartOffset + num;
					}
					num -= textRange.Length;
				}
				return (!flag) ? IH1[IH1.Count - 1].EndOffset : eHu.EndOffset;
			}
			return (!flag) ? eHu.StartOffset : eHu.EndOffset;
		default:
			return P_0;
		}
	}

	public void JHA(int P_0)
	{
		eHu = new TextRange(eHu.StartOffset + P_0, eHu.EndOffset + P_0);
		for (int num = IH1.Count - 1; num >= 0; num--)
		{
			IH1[num] = new TextRange(IH1[num].StartOffset + P_0, IH1[num].EndOffset + P_0);
		}
	}

	[SpecialName]
	public IList<TextRange> sHm()
	{
		return IH1;
	}

	internal static bool uWq()
	{
		return NWn == null;
	}

	internal static NA5 KWx()
	{
		return NWn;
	}
}
