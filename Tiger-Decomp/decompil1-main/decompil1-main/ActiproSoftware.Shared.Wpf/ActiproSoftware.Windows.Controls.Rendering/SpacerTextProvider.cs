using System;
using System.Collections.Generic;
using System.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

internal class SpacerTextProvider : ITextProvider
{
	private ITextSpacer[] LYx;

	private ITextProvider XYr;

	internal const string SpacerText = "_";

	internal static SpacerTextProvider an9;

	public int Length => XYr.Length + ((LYx != null) ? LYx.Length : 0);

	public IList<ITextSpacer> Spacers => LYx;

	public SpacerTextProvider(ITextProvider wrappedProvider, IEnumerable<ITextSpacer> spacers)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (wrappedProvider == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117020));
		}
		XYr = wrappedProvider;
		if (spacers == null)
		{
			return;
		}
		foreach (ITextSpacer spacer in spacers)
		{
			vYI(spacer);
		}
	}

	internal ITextSpacer GetSpacer(int characterIndex)
	{
		if (LYx != null)
		{
			int num = 0;
			if (Unu() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			ITextSpacer[] lYx = LYx;
			foreach (ITextSpacer textSpacer in lYx)
			{
				if (textSpacer.CharacterIndex == characterIndex)
				{
					return textSpacer;
				}
			}
		}
		return null;
	}

	private void vYI(ITextSpacer P_0)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					break;
				default:
					if (flag)
					{
						throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117054));
					}
					if (LYx != null)
					{
						Array.Resize(ref LYx, LYx.Length + 1);
						LYx[LYx.Length - 1] = P_0;
						Array.Sort(LYx, (ITextSpacer x, ITextSpacer y) => x.CharacterIndex.CompareTo(y.CharacterIndex));
					}
					else
					{
						LYx = new ITextSpacer[1] { P_0 };
					}
					return;
				}
				flag = P_0 == null;
				num2 = 0;
			}
			while (dnc());
		}
	}

	public string GetSubstring(int characterIndex, int characterCount)
	{
		if (LYx != null)
		{
			int num = 0;
			int num2 = characterCount;
			StringBuilder stringBuilder = new StringBuilder();
			ITextSpacer[] lYx = LYx;
			foreach (ITextSpacer textSpacer in lYx)
			{
				if (characterIndex < textSpacer.CharacterIndex)
				{
					int num3 = Math.Min(num2, textSpacer.CharacterIndex - characterIndex);
					stringBuilder.Append(XYr.GetSubstring(characterIndex - num, num3));
					characterIndex += num3;
					num2 -= num3;
				}
				if (num2 <= 0)
				{
					break;
				}
				num++;
				if (characterIndex == textSpacer.CharacterIndex)
				{
					stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117070));
					characterIndex++;
					if (--num2 <= 0)
					{
						break;
					}
				}
			}
			if (num2 > 0)
			{
				stringBuilder.Append(XYr.GetSubstring(characterIndex - num, num2));
			}
			return stringBuilder.ToString();
		}
		return XYr.GetSubstring(characterIndex, characterCount);
	}

	public int Translate(int characterIndex, TextProviderTranslateModes modes)
	{
		modes &= ~TextProviderTranslateModes.PositiveTracking;
		if (LYx != null)
		{
			switch (modes)
			{
			case TextProviderTranslateModes.FromSourceText:
			case TextProviderTranslateModes.PositiveTracking:
			{
				characterIndex = XYr.Translate(characterIndex, modes | TextProviderTranslateModes.PositiveTracking);
				bool flag2 = characterIndex >= 0;
				if (!flag2)
				{
					characterIndex = ~characterIndex;
				}
				ITextSpacer[] lYx2 = LYx;
				foreach (ITextSpacer textSpacer2 in lYx2)
				{
					if (textSpacer2.CharacterIndex >= characterIndex + (flag2 ? 1 : 0))
					{
						break;
					}
					characterIndex++;
				}
				return characterIndex;
			}
			case TextProviderTranslateModes.ToSourceText:
			case TextProviderTranslateModes.ToSourceText | TextProviderTranslateModes.PositiveTracking:
			{
				bool flag = false;
				int num = characterIndex;
				ITextSpacer[] lYx = LYx;
				foreach (ITextSpacer textSpacer in lYx)
				{
					if (textSpacer.CharacterIndex >= characterIndex)
					{
						break;
					}
					flag |= textSpacer.CharacterIndex == characterIndex - 1;
					num--;
				}
				if (flag)
				{
					modes |= TextProviderTranslateModes.PositiveTracking;
				}
				return XYr.Translate(num, modes);
			}
			}
		}
		return XYr.Translate(characterIndex, modes);
	}

	internal static bool dnc()
	{
		return an9 == null;
	}

	internal static SpacerTextProvider Unu()
	{
		return an9;
	}
}
