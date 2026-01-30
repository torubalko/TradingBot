using System.ComponentModel;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Markup;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Dialogs;

[ToolboxItem(false)]
public partial class PrintPreviewWindow : Window, IComponentConnector
{
	private bool fnK;

	internal static PrintPreviewWindow ORQ;

	public IDocumentPaginatorSource Document
	{
		get
		{
			return documentViewer.Document;
		}
		set
		{
			documentViewer.Document = value;
		}
	}

	public SyntaxEditor SyntaxEditor
	{
		get
		{
			return documentViewer.SyntaxEditor;
		}
		set
		{
			documentViewer.SyntaxEditor = value;
		}
	}

	public PrintPreviewWindow()
	{
		grA.DaB7cz();
		base._002Ector();
		InitializeComponent();
	}

	internal static bool IRy()
	{
		return ORQ == null;
	}

	internal static PrintPreviewWindow eRh()
	{
		return ORQ;
	}
}
