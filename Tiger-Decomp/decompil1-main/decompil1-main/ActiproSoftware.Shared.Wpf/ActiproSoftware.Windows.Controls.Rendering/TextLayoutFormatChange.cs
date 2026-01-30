using System.Globalization;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

internal struct TextLayoutFormatChange
{
	private int KIh;

	private TextLayoutFormat pIm;

	internal static object gnT;

	public int CharacterIndex => KIh;

	public TextLayoutFormat Format => pIm;

	public TextLayoutFormatChange(int characterIndex, TextLayoutFormat format)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		KIh = characterIndex;
		pIm = format;
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117772), new object[2] { KIh, pIm });
	}

	internal static bool dnX()
	{
		return gnT == null;
	}

	internal static object anU()
	{
		return gnT;
	}
}
