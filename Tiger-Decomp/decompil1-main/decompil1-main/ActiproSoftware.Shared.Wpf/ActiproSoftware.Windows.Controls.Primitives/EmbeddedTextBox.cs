using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

[ToolboxItem(false)]
public class EmbeddedTextBox : TextBox
{
	private static ContextMenu NxR;

	private static EmbeddedTextBox pbn;

	static EmbeddedTextBox()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		FrameworkElement.ContextMenuProperty.OverrideMetadata(typeof(EmbeddedTextBox), new FrameworkPropertyMetadata(null, null, tx5));
	}

	public EmbeddedTextBox()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		base.DefaultStyleKey = typeof(EmbeddedTextBox);
	}

	private static object tx5(DependencyObject P_0, object P_1)
	{
		if (P_0 is EmbeddedTextBox && P_1 == null)
		{
			if (NxR == null)
			{
				NxR = new ContextMenu
				{
					Items = 
					{
						(object)new MenuItem
						{
							Command = ApplicationCommands.Cut
						},
						(object)new MenuItem
						{
							Command = ApplicationCommands.Copy
						},
						(object)new MenuItem
						{
							Command = ApplicationCommands.Paste
						},
						(object)new Separator(),
						(object)new MenuItem
						{
							Command = ApplicationCommands.SelectAll
						}
					}
				};
			}
			return NxR;
		}
		return P_1;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		CoerceValue(FrameworkElement.ContextMenuProperty);
	}

	internal static bool Jb0()
	{
		return pbn == null;
	}

	internal static EmbeddedTextBox Vbb()
	{
		return pbn;
	}
}
