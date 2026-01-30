using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Dialogs;

[ToolboxItem(false)]
public class EditorDocumentViewer : DocumentViewer
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private SyntaxEditor vnX;

	private static EditorDocumentViewer tRs;

	public SyntaxEditor SyntaxEditor
	{
		[CompilerGenerated]
		get
		{
			return vnX;
		}
		[CompilerGenerated]
		set
		{
			vnX = value;
		}
	}

	public EditorDocumentViewer()
	{
		grA.DaB7cz();
		base._002Ector();
		base.ContextMenu = new ContextMenu
		{
			Items = 
			{
				(object)new MenuItem
				{
					Command = NavigationCommands.IncreaseZoom,
					CommandTarget = this
				},
				(object)new MenuItem
				{
					Command = NavigationCommands.DecreaseZoom,
					CommandTarget = this
				}
			}
		};
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		if (!(VisualTreeHelperExtended.GetFirstDescendant(this, typeof(Grid)) is Grid grid))
		{
			return;
		}
		foreach (UIElement child in grid.Children)
		{
			if (child is ContentControl contentControl && contentControl.Name == Q7Z.tqM(196104))
			{
				contentControl.Visibility = Visibility.Collapsed;
				break;
			}
		}
	}

	protected override void OnPrintCommand()
	{
		if (SyntaxEditor == null)
		{
			base.OnPrintCommand();
		}
		else
		{
			SyntaxEditor.ShowPrintDialog();
		}
	}

	internal static bool RRP()
	{
		return tRs == null;
	}

	internal static EditorDocumentViewer MRo()
	{
		return tRs;
	}
}
