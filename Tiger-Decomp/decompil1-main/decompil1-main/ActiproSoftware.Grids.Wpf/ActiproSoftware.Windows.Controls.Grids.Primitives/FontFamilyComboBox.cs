using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.Primitives;

[ToolboxItem(false)]
public class FontFamilyComboBox : ComboBox
{
	private static FontFamilyComboBox EFT;

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public FontFamilyComboBox()
	{
		fc.taYSkz();
		base._002Ector();
		base.ItemsSource = GetFontFamilies();
	}

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	protected virtual IEnumerable<FontFamily> GetFontFamilies()
	{
		List<FontFamily> list = new List<FontFamily>();
		try
		{
			list.AddRange(Fonts.SystemFontFamilies);
		}
		catch
		{
		}
		list?.Sort((FontFamily x, FontFamily y) => string.Compare(x.Source ?? string.Empty, y.Source ?? string.Empty, StringComparison.CurrentCulture));
		return list;
	}

	internal static bool UF7()
	{
		return EFT == null;
	}

	internal static FontFamilyComboBox pFO()
	{
		return EFT;
	}
}
