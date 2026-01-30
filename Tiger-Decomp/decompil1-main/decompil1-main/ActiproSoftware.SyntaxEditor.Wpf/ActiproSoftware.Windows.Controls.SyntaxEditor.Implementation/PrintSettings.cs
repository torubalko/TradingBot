using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Markup;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

public class PrintSettings : IPrintSettings
{
	private string twr;

	private bool ows;

	private bool Vwk;

	private bool kwS;

	private IHighlightingStyleRegistry Gw9;

	private bool pwy;

	private bool fwq;

	private bool Kw2;

	private bool Xw7;

	private bool Mwi;

	private bool rwp;

	private IPrinterViewMarginFactoryCollection hwM;

	private Thickness ywO;

	private Size VwU;

	private static PrintSettings nlM;

	public bool AreCollapsedOutliningNodesAllowed
	{
		get
		{
			return ows;
		}
		set
		{
			ows = value;
		}
	}

	public bool AreIndentationGuidesVisible
	{
		get
		{
			return Vwk;
		}
		set
		{
			Vwk = value;
		}
	}

	public bool AreSquiggleLinesVisible
	{
		get
		{
			return kwS;
		}
		set
		{
			kwS = value;
		}
	}

	public string DocumentTitle
	{
		get
		{
			return twr;
		}
		set
		{
			twr = value;
		}
	}

	public IHighlightingStyleRegistry HighlightingStyleRegistry
	{
		get
		{
			return Gw9;
		}
		set
		{
			Gw9 = value;
		}
	}

	public bool IsDocumentTitleMarginVisible
	{
		get
		{
			return pwy;
		}
		set
		{
			pwy = value;
		}
	}

	public bool IsLineNumberMarginVisible
	{
		get
		{
			return fwq;
		}
		set
		{
			fwq = value;
		}
	}

	public bool IsPageNumberMarginVisible
	{
		get
		{
			return Kw2;
		}
		set
		{
			Kw2 = value;
		}
	}

	public bool IsSyntaxHighlightingEnabled
	{
		get
		{
			return Xw7;
		}
		set
		{
			Xw7 = value;
		}
	}

	public bool IsWhitespaceVisible
	{
		get
		{
			return Mwi;
		}
		set
		{
			Mwi = value;
		}
	}

	public bool IsWordWrapGlyphMarginVisible
	{
		get
		{
			return rwp;
		}
		set
		{
			rwp = value;
		}
	}

	public IPrinterViewMarginFactoryCollection ViewMarginFactories => hwM;

	public Thickness PageMargin
	{
		get
		{
			return ywO;
		}
		set
		{
			ywO = value;
		}
	}

	public Size PageSize
	{
		get
		{
			return VwU;
		}
		set
		{
			VwU = value;
		}
	}

	public PrintSettings()
	{
		grA.DaB7cz();
		pwy = true;
		Kw2 = true;
		Xw7 = true;
		rwp = true;
		ywO = new Thickness(72.0);
		VwU = new Size(816.0, 1056.0);
		base._002Ector();
		hwM = new PrinterViewMarginFactoryCollection();
		hwM.Add(new DefaultPrinterViewMarginFactory());
	}

	private static IHighlightingStyleRegistry DwV()
	{
		HighlightingStyleRegistry highlightingStyleRegistry = new HighlightingStyleRegistry();
		highlightingStyleRegistry.Register(cT.PlainText, new HighlightingStyle(Color.FromArgb(byte.MaxValue, 0, 0, 0)));
		highlightingStyleRegistry.Register(cT.LineNumbers, new HighlightingStyle(Color.FromArgb(byte.MaxValue, 128, 128, 128)));
		highlightingStyleRegistry.Register(cT.VisibleWhitespace, new HighlightingStyle(Color.FromArgb(byte.MaxValue, 128, 128, 128)));
		return highlightingStyleRegistry;
	}

	public FixedDocument CreateFixedDocument(SyntaxEditor syntaxEditor)
	{
		if (syntaxEditor == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8238));
		}
		FixedDocument fixedDocument = new FixedDocument();
		fixedDocument.DocumentPaginator.PageSize = VwU;
		Rect finalRect = new Rect(ywO.Left, ywO.Top, VwU.Width - ywO.Left - ywO.Right, VwU.Height - ywO.Top - ywO.Bottom);
		IHighlightingStyleRegistry highlightingStyleRegistry = (Xw7 ? (Gw9 ?? syntaxEditor.HG8()) : DwV());
		List<HTX> list = new List<HTX>();
		int num = 0;
		int num2 = 0;
		ITextSnapshot currentSnapshot = syntaxEditor.Document.CurrentSnapshot;
		while (num < currentSnapshot.Length)
		{
			HTX hTX = new HTX(syntaxEditor, ++num2, highlightingStyleRegistry);
			hTX.ScrollState = new TextViewScrollState(hTX.OffsetToPosition(num))
			{
				CanScrollPastDocumentEnd = true
			};
			FixedPage.SetLeft(hTX, finalRect.Left);
			FixedPage.SetTop(hTX, finalRect.Top);
			hTX.Width = finalRect.Width;
			hTX.Height = finalRect.Height;
			hTX.ClipToBounds = true;
			syntaxEditor.TxT(new TextViewEventArgs(hTX));
			hTX.Measure(finalRect.Size);
			hTX.Arrange(finalRect);
			hTX.UpdateLayout();
			if (hTX.VisibleViewLines.Count == 0)
			{
				break;
			}
			list.Add(hTX);
			ITextViewLine textViewLine = hTX.VisibleViewLines[hTX.VisibleViewLines.Count - 1];
			int num3 = textViewLine.EndOffsetIncludingLineTerminator + ((!textViewLine.HasHardLineBreak) ? 1 : 0);
			if (num3 <= num)
			{
				break;
			}
			num = num3;
		}
		foreach (HTX item in list)
		{
			item.PageCount = num2;
			item.InvalidateRender();
			PageContent pageContent = new PageContent();
			fixedDocument.Pages.Add(pageContent);
			FixedPage fixedPage = new FixedPage();
			((IAddChild)pageContent).AddChild((object)fixedPage);
			fixedPage.Children.Add(item);
		}
		return fixedDocument;
	}

	internal static bool ol3()
	{
		return nlM == null;
	}

	internal static PrintSettings mlv()
	{
		return nlM;
	}
}
