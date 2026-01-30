using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Xml;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

public class WindowChromeTitleBarHeaderTemplateSelector : DataTemplateSelector
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DataTemplate oem;

	internal static WindowChromeTitleBarHeaderTemplateSelector AY4;

	public DataTemplate DefaultStringTemplate
	{
		[CompilerGenerated]
		get
		{
			return oem;
		}
		[CompilerGenerated]
		set
		{
			oem = value;
		}
	}

	public WindowChromeTitleBarHeaderTemplateSelector()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		DefaultStringTemplate = Oeh();
	}

	private static DataTemplate Oeh()
	{
		string s = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(100920);
		DataTemplate result = null;
		using (StringReader input = new StringReader(s))
		{
			using XmlReader reader = XmlReader.Create(input);
			result = XamlReader.Load(reader) as DataTemplate;
		}
		return result;
	}

	public override DataTemplate SelectTemplate(object item, DependencyObject container)
	{
		if (!(item is string))
		{
			return null;
		}
		return DefaultStringTemplate;
	}

	internal static bool nYs()
	{
		return AY4 == null;
	}

	internal static WindowChromeTitleBarHeaderTemplateSelector lYi()
	{
		return AY4;
	}
}
