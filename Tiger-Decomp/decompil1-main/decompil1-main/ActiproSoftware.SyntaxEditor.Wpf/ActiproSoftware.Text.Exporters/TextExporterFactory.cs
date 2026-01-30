using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;

namespace ActiproSoftware.Text.Exporters;

public class TextExporterFactory
{
	private IHighlightingStyleRegistry U5Q;

	internal static TextExporterFactory UGx;

	public TextExporterFactory()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	public TextExporterFactory(IHighlightingStyleRegistry registry)
	{
		grA.DaB7cz();
		this._002Ector();
		U5Q = registry;
	}

	public IHtmlTextExporter CreateHtmlClassBased()
	{
		return new QA3
		{
			HighlightingStyleRegistry = U5Q
		};
	}

	public IHtmlTextExporter CreateHtmlClipboard()
	{
		return new sAD
		{
			HighlightingStyleRegistry = U5Q
		};
	}

	public IHtmlTextExporter CreateHtmlInline()
	{
		return new uAh
		{
			HighlightingStyleRegistry = U5Q
		};
	}

	public IHtmlTextExporter CreateHtmlInlineFragment()
	{
		return new kAk
		{
			HighlightingStyleRegistry = U5Q
		};
	}

	public IRtfTextExporter CreateRtf()
	{
		cAG cAG = new cAG
		{
			HighlightingStyleRegistry = U5Q
		};
		IHighlightingStyleRegistry highlightingStyleRegistry = U5Q ?? AmbientHighlightingStyleRegistry.Instance;
		IHighlightingStyle highlightingStyle = highlightingStyleRegistry[cT.PlainText];
		if (highlightingStyle != null)
		{
			if (!string.IsNullOrEmpty(highlightingStyle.FontFamilyName))
			{
				cAG.FontFamily = highlightingStyle.FontFamilyName;
				int num = 0;
				if (wGL() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			if (highlightingStyle.FontSize > 0f)
			{
				cAG.FontSizeInPoints = Math.Round(highlightingStyle.FontSize * 0.75f, MidpointRounding.AwayFromZero);
			}
		}
		return cAG;
	}

	internal static bool gGa()
	{
		return UGx == null;
	}

	internal static TextExporterFactory wGL()
	{
		return UGx;
	}
}
