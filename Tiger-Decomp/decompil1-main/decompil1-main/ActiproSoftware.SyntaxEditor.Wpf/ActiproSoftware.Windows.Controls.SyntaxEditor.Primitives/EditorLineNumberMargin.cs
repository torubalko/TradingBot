using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class EditorLineNumberMargin : EditorViewMarginBase
{
	private InputAdapter xKX;

	private static EditorLineNumberMargin BDE;

	public EditorLineNumberMargin(IEditorView view)
	{
		grA.DaB7cz();
		base._002Ector(view, Q7Z.tqM(7686), EditorViewMarginPlacement.ScrollableLeft, new Ordering[2]
		{
			new Ordering(Q7Z.tqM(7712), OrderPlacement.After),
			new Ordering(Q7Z.tqM(7734), OrderPlacement.After)
		});
		base.DefaultStyleKey = typeof(EditorLineNumberMargin);
		vAE.P01(this, CustomCursors.ReverseArrow);
		AKW();
		view.MarginsDestroyed += iKc;
		view.TextAreaLayout += kKa;
	}

	private void AKW()
	{
		xKX = new InputAdapter(this);
		xKX.PointerPressed += AKx;
		xKX.AttachedEventKinds = InputAdapterEventKinds.PointerPressed;
	}

	private void BKP(out string P_0, out float P_1, out bool P_2, out bool P_3)
	{
		P_0 = null;
		P_1 = 0f;
		P_2 = false;
		P_3 = false;
		IEditorView view = base.View;
		IHighlightingStyle highlightingStyle = view.HighlightingStyleRegistry?[cT.LineNumbers];
		P_0 = view.SyntaxEditor.LineNumberMarginFontFamily?.Source;
		P_1 = (float)view.SyntaxEditor.LineNumberMarginFontSize;
		if (string.IsNullOrEmpty(P_0) && highlightingStyle != null)
		{
			P_0 = highlightingStyle.FontFamilyName;
		}
		if (string.IsNullOrEmpty(P_0))
		{
			P_0 = view.DefaultFontFamilyName;
		}
		if (P_1 == 0f && highlightingStyle != null)
		{
			P_1 = highlightingStyle.FontSize;
		}
		if (P_1 == 0f)
		{
			P_1 = view.DefaultFontSize;
		}
	}

	private ITextViewLineNumberProvider xKE()
	{
		ITextViewLineNumberProvider textViewLineNumberProvider = null;
		ICodeDocument document = base.View.SyntaxEditor.Document;
		if (document != null)
		{
			ISyntaxLanguage language = document.Language;
			if (language != null)
			{
				textViewLineNumberProvider = language.GetTextViewLineNumberProvider();
			}
		}
		object obj = textViewLineNumberProvider;
		if (obj == null)
		{
			int num = 0;
			if (!MDw())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			obj = DefaultTextViewLineNumberProvider.fY4();
		}
		return (ITextViewLineNumberProvider)obj;
	}

	private void iKc(object P_0, EventArgs P_1)
	{
		base.View.MarginsDestroyed -= iKc;
		base.View.TextAreaLayout -= kKa;
	}

	private void kKa(object P_0, TextViewTextAreaLayoutEventArgs P_1)
	{
		bool flag = P_1 != null && P_1.HadSnapshotChange && base.Visibility == Visibility.Visible;
		int num = 0;
		if (XDu() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			int num3 = nKG();
			if ((double)num3 != base.DesiredSize.Width)
			{
				InvalidateMeasure();
			}
		}
	}

	private void AKx(object P_0, InputPointerButtonEventArgs P_1)
	{
		IEditorView view = base.View;
		if (view != null && P_1 != null && !P_1.Handled && P_1.IsPrimaryButton)
		{
			view.StartPointerSelection(P_1);
		}
	}

	public override void Draw(TextViewDrawContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7756));
		}
		Rect bounds = context.Bounds;
		ICanvas canvas = context.Canvas;
		double right = base.Padding.Right;
		Brush lineNumberMarginBackground = context.LineNumberMarginBackground;
		if (lineNumberMarginBackground != null)
		{
			context.FillRectangle(bounds, lineNumberMarginBackground);
		}
		Brush lineNumberMarginForeground = context.LineNumberMarginForeground;
		TextFormattingMode textFormattingMode = TextOptions.GetTextFormattingMode(this);
		if (lineNumberMarginForeground == null)
		{
			return;
		}
		using IDisposable batch = canvas.CreateTextBatch();
		BKP(out var fontFamilyName, out var fontSize, out var flag, out var flag2);
		ITextViewLineNumberProvider textViewLineNumberProvider = xKE();
		ITextViewLineCollection visibleViewLines = base.View.VisibleViewLines;
		foreach (ITextViewLine item in visibleViewLines)
		{
			string lineNumberText = textViewLineNumberProvider.GetLineNumberText(item);
			if (string.IsNullOrEmpty(lineNumberText))
			{
				continue;
			}
			using ITextLayout textLayout = canvas.CreateTextLayout(lineNumberText, 0f, fontFamilyName, fontSize, lineNumberMarginForeground);
			textLayout.TextFormattingMode = textFormattingMode;
			if (flag)
			{
				textLayout.SetFontWeight(0, lineNumberText.Length, FontWeights.Bold);
			}
			if (flag2)
			{
				textLayout.SetFontStyle(0, lineNumberText.Length, FontStyles.Italic);
			}
			textLayout.RunTextFormatter(batch);
			ITextLayoutLine textLayoutLine = textLayout.Lines[0];
			double y = bounds.Y + item.TextBounds.Y + (double)(int)Math.Round(item.Baseline - textLayoutLine.Baseline, MidpointRounding.AwayFromZero);
			context.DrawText(new Point(bounds.Right - textLayoutLine.Width - right, y), textLayoutLine);
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new EditorLineNumberMarginAutomationPeer(this);
	}

	public override void UpdateVisibility()
	{
		base.Visibility = ((!base.View.SyntaxEditor.IsLineNumberMarginVisible) ? Visibility.Collapsed : Visibility.Visible);
	}

	private int nKG()
	{
		ITextViewLineNumberProvider textViewLineNumberProvider = xKE();
		string largestLineNumberText = textViewLineNumberProvider.GetLargestLineNumberText(base.View);
		BKP(out var familyName, out var num, out var flag, out var flag2);
		Typeface typeface = new Typeface(new FontFamily(familyName), flag2 ? FontStyles.Italic : FontStyles.Normal, flag ? FontWeights.Bold : FontWeights.Normal, FontStretches.Normal);
		TextFormattingMode textFormattingMode = TextOptions.GetTextFormattingMode(this);
		int num2 = 0;
		if (!MDw())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		default:
		{
			FormattedText formattedText = new FormattedText(largestLineNumberText, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, typeface, num, base.Foreground, null, textFormattingMode);
			double widthIncludingTrailingWhitespace = formattedText.WidthIncludingTrailingWhitespace;
			return (int)Math.Ceiling(Math.Max(base.MinWidth, base.Padding.Left + widthIncludingTrailingWhitespace + base.Padding.Right));
		}
		}
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		base.MeasureOverride(availableSize);
		if (double.IsPositiveInfinity(availableSize.Height))
		{
			availableSize.Height = 0.0;
		}
		int num = nKG();
		return new Size(num, availableSize.Height);
	}

	internal static bool MDw()
	{
		return BDE == null;
	}

	internal static EditorLineNumberMargin XDu()
	{
		return BDE;
	}
}
