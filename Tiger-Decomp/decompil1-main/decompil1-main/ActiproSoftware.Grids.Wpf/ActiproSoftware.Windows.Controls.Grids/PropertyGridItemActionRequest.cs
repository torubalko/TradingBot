using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids;

public class PropertyGridItemActionRequest
{
	[CompilerGenerated]
	private PropertyGridItem aPg;

	[CompilerGenerated]
	private FrameworkElement pPm;

	[CompilerGenerated]
	private string bPT;

	internal static PropertyGridItemActionRequest d0;

	public PropertyGridItem Container
	{
		[CompilerGenerated]
		get
		{
			return aPg;
		}
		[CompilerGenerated]
		private set
		{
			aPg = value;
		}
	}

	public FrameworkElement Element
	{
		[CompilerGenerated]
		get
		{
			return pPm;
		}
		[CompilerGenerated]
		private set
		{
			pPm = value;
		}
	}

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return bPT;
		}
		[CompilerGenerated]
		private set
		{
			bPT = value;
		}
	}

	public PropertyGridItemActionRequest(PropertyGridItem container, FrameworkElement element, string text)
	{
		fc.taYSkz();
		base._002Ector();
		Container = container;
		Element = element;
		Text = text;
	}

	internal static bool ej()
	{
		return d0 == null;
	}

	internal static PropertyGridItemActionRequest AL()
	{
		return d0;
	}
}
