using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

[TemplatePart(Name = "PART_Canvas", Type = typeof(CanvasControl))]
[ContentProperty("Text")]
public class TextStylePreview : Control
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public IHighlightingStyle QBX;

		private static _003C_003Ec__DisplayClass7_0 oN5;

		public _003C_003Ec__DisplayClass7_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void FBG(WeakEventListener<TextStylePreview, PropertyChangedEventArgs> weakEventListener)
		{
			QBX.PropertyChanged -= weakEventListener.OnEvent;
		}

		internal static bool QNG()
		{
			return oN5 == null;
		}

		internal static _003C_003Ec__DisplayClass7_0 rNN()
		{
			return oN5;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public IHighlightingStyleRegistry jBl;

		internal static _003C_003Ec__DisplayClass8_0 gN3;

		public _003C_003Ec__DisplayClass8_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void fBe(WeakEventListener<TextStylePreview, EventArgs> weakEventListener)
		{
			jBl.Changed -= weakEventListener.OnEvent;
		}

		internal static bool XNv()
		{
			return gN3 == null;
		}

		internal static _003C_003Ec__DisplayClass8_0 SNf()
		{
			return gN3;
		}
	}

	private CanvasControl vXn;

	private WeakEventListener<TextStylePreview, PropertyChangedEventArgs> xX8;

	private WeakEventListener<TextStylePreview, EventArgs> jXI;

	public static readonly DependencyProperty HighlightingStyleProperty;

	public static readonly DependencyProperty HighlightingStyleRegistryProperty;

	public static readonly DependencyProperty TextProperty;

	internal static TextStylePreview eDF;

	public IHighlightingStyle HighlightingStyle
	{
		get
		{
			return (IHighlightingStyle)GetValue(HighlightingStyleProperty);
		}
		set
		{
			SetValue(HighlightingStyleProperty, value);
		}
	}

	public IHighlightingStyleRegistry HighlightingStyleRegistry
	{
		get
		{
			return (IHighlightingStyleRegistry)GetValue(HighlightingStyleRegistryProperty);
		}
		set
		{
			SetValue(HighlightingStyleRegistryProperty, value);
		}
	}

	public string Text
	{
		get
		{
			return (string)GetValue(TextProperty);
		}
		set
		{
			SetValue(TextProperty, value);
		}
	}

	public TextStylePreview()
	{
		grA.DaB7cz();
		base._002Ector();
		base.DefaultStyleKey = typeof(TextStylePreview);
	}

	private void aXu(IHighlightingStyle P_0, IHighlightingStyle P_1)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals5.QBX = P_1;
		if (P_0 == CS_0024_003C_003E8__locals5.QBX)
		{
			return;
		}
		if (xX8 != null)
		{
			xX8.Detach();
			xX8 = null;
		}
		if (CS_0024_003C_003E8__locals5.QBX != null)
		{
			xX8 = new WeakEventListener<TextStylePreview, PropertyChangedEventArgs>(this, delegate(TextStylePreview instance, object source, PropertyChangedEventArgs eventArgs)
			{
				instance.fXY(source, eventArgs);
			}, delegate(WeakEventListener<TextStylePreview, PropertyChangedEventArgs> weakEventListener)
			{
				CS_0024_003C_003E8__locals5.QBX.PropertyChanged -= weakEventListener.OnEvent;
			});
			CS_0024_003C_003E8__locals5.QBX.PropertyChanged += xX8.OnEvent;
		}
	}

	private void EX1(IHighlightingStyleRegistry P_0, IHighlightingStyleRegistry P_1)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals5.jBl = P_1;
		if (P_0 == CS_0024_003C_003E8__locals5.jBl)
		{
			return;
		}
		if (jXI != null)
		{
			jXI.Detach();
			jXI = null;
		}
		if (CS_0024_003C_003E8__locals5.jBl != null)
		{
			jXI = new WeakEventListener<TextStylePreview, EventArgs>(this, delegate(TextStylePreview instance, object source, EventArgs eventArgs)
			{
				instance.lX4(source, eventArgs);
			}, delegate(WeakEventListener<TextStylePreview, EventArgs> weakEventListener)
			{
				CS_0024_003C_003E8__locals5.jBl.Changed -= weakEventListener.OnEvent;
			});
			int num = 0;
			if (!tD9())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			CS_0024_003C_003E8__locals5.jBl.Changed += jXI.OnEvent;
		}
	}

	[SpecialName]
	internal CanvasControl xXb()
	{
		return vXn;
	}

	[SpecialName]
	private void VXT(CanvasControl value)
	{
		if (vXn == value)
		{
			return;
		}
		if (vXn != null)
		{
			vXn.Draw -= xXR;
		}
		vXn = value;
		int num = 0;
		if (!tD9())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (vXn != null)
		{
			vXn.Draw += xXR;
		}
	}

	private IHighlightingStyle HXF()
	{
		IHighlightingStyle highlightingStyle = HighlightingStyle;
		HighlightingStyle highlightingStyle2 = ((highlightingStyle != null) ? new HighlightingStyle
		{
			Background = highlightingStyle.Background,
			Bold = highlightingStyle.Bold,
			BorderColor = highlightingStyle.BorderColor,
			BorderCornerKind = highlightingStyle.BorderCornerKind,
			BorderKind = highlightingStyle.BorderKind,
			FontFamilyName = highlightingStyle.FontFamilyName,
			FontSize = highlightingStyle.FontSize,
			Foreground = highlightingStyle.Foreground,
			IsBackgroundEditable = highlightingStyle.IsBackgroundEditable,
			IsBoldEditable = highlightingStyle.IsBoldEditable,
			IsBorderEditable = highlightingStyle.IsBorderEditable,
			IsForegroundEditable = highlightingStyle.IsForegroundEditable,
			IsItalicEditable = highlightingStyle.IsItalicEditable,
			Italic = highlightingStyle.Italic,
			StrikethroughColor = highlightingStyle.StrikethroughColor,
			StrikethroughKind = highlightingStyle.StrikethroughKind,
			StrikethroughWeight = highlightingStyle.StrikethroughWeight,
			UnderlineColor = highlightingStyle.UnderlineColor,
			UnderlineKind = highlightingStyle.UnderlineKind,
			UnderlineWeight = highlightingStyle.UnderlineWeight
		} : new HighlightingStyle
		{
			IsBackgroundEditable = false,
			IsBoldEditable = false,
			IsBorderEditable = false,
			IsForegroundEditable = false,
			IsItalicEditable = false
		});
		int num = 5;
		if (!tD9())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		IHighlightingStyle highlightingStyle3 = default(IHighlightingStyle);
		bool flag = default(bool);
		IHighlightingStyleRegistry highlightingStyleRegistry = default(IHighlightingStyleRegistry);
		FontFamily fontFamily = default(FontFamily);
		while (true)
		{
			switch (num)
			{
			default:
				if (!highlightingStyle2.Foreground.HasValue)
				{
					highlightingStyle2.Foreground = highlightingStyle3.Foreground;
				}
				if (!highlightingStyle2.Italic.HasValue)
				{
					num = 3;
					continue;
				}
				goto IL_0195;
			case 3:
				highlightingStyle2.Italic = highlightingStyle3.Italic;
				goto IL_0195;
			case 1:
				if (!flag)
				{
					goto IL_0195;
				}
				if (!highlightingStyle2.Background.HasValue)
				{
					highlightingStyle2.Background = highlightingStyle3.Background;
					num = 2;
					continue;
				}
				goto case 2;
			case 5:
				highlightingStyleRegistry = HighlightingStyleRegistry ?? AmbientHighlightingStyleRegistry.Instance;
				num = 4;
				continue;
			case 6:
				if (fontFamily != null)
				{
					highlightingStyle2.FontFamilyName = fontFamily.Source;
				}
				else
				{
					highlightingStyle2.FontFamilyName = DisplayItemClassificationTypeProvider.rPa;
				}
				goto IL_0094;
			case 2:
				if (!highlightingStyle2.Bold.HasValue)
				{
					highlightingStyle2.Bold = highlightingStyle3.Bold;
				}
				if (string.IsNullOrEmpty(highlightingStyle2.FontFamilyName))
				{
					highlightingStyle2.FontFamilyName = highlightingStyle3.FontFamilyName;
				}
				if (highlightingStyle2.FontSize == 0f)
				{
					highlightingStyle2.FontSize = highlightingStyle3.FontSize;
					num = 0;
					if (tD9())
					{
						continue;
					}
					break;
				}
				goto default;
			case 4:
				{
					highlightingStyle3 = highlightingStyleRegistry[cT.PlainText];
					flag = highlightingStyle3 != null;
					num = 1;
					if (rDJ() == null)
					{
						continue;
					}
					break;
				}
				IL_0094:
				if (highlightingStyle2.FontSize == 0f)
				{
					highlightingStyle2.FontSize = (float)base.FontSize;
				}
				if (!highlightingStyle2.Foreground.HasValue)
				{
					if (base.Foreground is SolidColorBrush solidColorBrush)
					{
						highlightingStyle2.Foreground = solidColorBrush.Color;
					}
					if (!highlightingStyle2.Foreground.HasValue)
					{
						highlightingStyle2.Foreground = Colors.Black;
					}
				}
				if (!highlightingStyle2.Italic.HasValue)
				{
					highlightingStyle2.Italic = false;
				}
				return highlightingStyle2;
				IL_0195:
				if (!highlightingStyle2.Bold.HasValue)
				{
					highlightingStyle2.Bold = false;
				}
				if (string.IsNullOrEmpty(highlightingStyle2.FontFamilyName))
				{
					fontFamily = base.FontFamily;
					num = 6;
					if (tD9())
					{
						continue;
					}
					break;
				}
				goto IL_0094;
			}
			break;
		}
		goto IL_0005;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private void FX3()
	{
		if (vXn != null)
		{
			vXn.InvalidateRender();
		}
	}

	private void xXR(object P_0, CanvasDrawEventArgs P_1)
	{
		OnDraw(P_1);
	}

	private void fXY(object P_0, PropertyChangedEventArgs P_1)
	{
		FX3();
	}

	private void lX4(object P_0, EventArgs P_1)
	{
		FX3();
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		base.MeasureOverride(availableSize);
		Thickness borderThickness = base.BorderThickness;
		Thickness padding = base.Padding;
		Size result = PXH();
		result.Width += borderThickness.Left + padding.Left + 2.0 + padding.Right + borderThickness.Right;
		result.Height += borderThickness.Top + padding.Top + padding.Bottom + borderThickness.Bottom;
		if (!double.IsPositiveInfinity(availableSize.Width))
		{
			int num = 0;
			if (!tD9())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			result.Width = Math.Min(result.Width, availableSize.Width);
		}
		if (!double.IsPositiveInfinity(availableSize.Height))
		{
			result.Height = Math.Min(result.Height, availableSize.Height);
		}
		return result;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		VXT(GetTemplateChild(Q7Z.tqM(7518)) as CanvasControl);
	}

	protected virtual void OnDraw(CanvasDrawEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		Rect bounds = e.Context.Bounds;
		e.Context.FillRectangle(bounds, base.Background);
		IHighlightingStyle highlightingStyle = HXF();
		if (highlightingStyle.HasBackground)
		{
			e.Context.FillRectangle(bounds, highlightingStyle.Background.Value);
		}
		string text = Text;
		if (!string.IsNullOrEmpty(text))
		{
			using ITextLayout textLayout = e.Context.Canvas.CreateTextLayout(text, 0f, highlightingStyle.FontFamilyName, highlightingStyle.FontSize, highlightingStyle.Foreground ?? Colors.Black);
			if (true.Equals(highlightingStyle.Bold))
			{
				textLayout.SetFontWeight(0, text.Length, FontWeights.Bold);
			}
			if (true.Equals(highlightingStyle.Italic))
			{
				textLayout.SetFontStyle(0, text.Length, FontStyles.Italic);
			}
			if (highlightingStyle.HasUnderline)
			{
				textLayout.SetUnderline(0, text.Length, highlightingStyle.UnderlineKind, highlightingStyle.UnderlineColor, highlightingStyle.UnderlineWeight);
			}
			if (highlightingStyle.HasStrikethrough)
			{
				textLayout.SetStrikethrough(0, text.Length, highlightingStyle.StrikethroughKind, highlightingStyle.StrikethroughColor, highlightingStyle.StrikethroughWeight);
			}
			ITextLayoutLine textLayoutLine = textLayout.Lines[0];
			Rect bounds2 = new Rect((int)((bounds.Width - textLayoutLine.Width) / 2.0), (int)((bounds.Height - textLayoutLine.Height) / 2.0), textLayoutLine.Width, textLayoutLine.Height);
			if (highlightingStyle.HasBorder)
			{
				if (highlightingStyle.BorderCornerKind == HighlightingStyleBorderCornerKind.Rounded)
				{
					e.Context.DrawRoundedRectangle(bounds2, 1.75f, highlightingStyle.BorderColor.Value, highlightingStyle.BorderKind, 1f);
				}
				else
				{
					e.Context.DrawRectangle(bounds2, highlightingStyle.BorderColor.Value, highlightingStyle.BorderKind, 1f);
				}
			}
			if (highlightingStyle.Foreground.HasValue)
			{
				e.Context.DrawText(new Point(bounds2.X, bounds2.Y), textLayoutLine);
			}
		}
		if (base.BorderThickness.Left > 0.0)
		{
			Pen pen = new Pen(base.BorderBrush, base.BorderThickness.Left);
			e.Context.DrawRectangle(bounds, pen);
		}
	}

	private static void SXo(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TextStylePreview textStylePreview = (TextStylePreview)P_0;
		bool flag = true;
		IHighlightingStyle highlightingStyle = (IHighlightingStyle)P_1.OldValue;
		IHighlightingStyle highlightingStyle2 = (IHighlightingStyle)P_1.NewValue;
		textStylePreview.aXu(highlightingStyle, highlightingStyle2);
		textStylePreview.FX3();
	}

	private static void VXj(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TextStylePreview textStylePreview = (TextStylePreview)P_0;
		bool flag = true;
		IHighlightingStyleRegistry highlightingStyleRegistry = (IHighlightingStyleRegistry)P_1.OldValue;
		IHighlightingStyleRegistry highlightingStyleRegistry2 = (IHighlightingStyleRegistry)P_1.NewValue;
		textStylePreview.EX1(highlightingStyleRegistry, highlightingStyleRegistry2);
		textStylePreview.FX3();
	}

	private static void zXw(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TextStylePreview textStylePreview = (TextStylePreview)P_0;
		textStylePreview.FX3();
	}

	private static void UX6(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		TextStylePreview textStylePreview = (TextStylePreview)P_0;
		textStylePreview.InvalidateMeasure();
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static TextStylePreview()
	{
		grA.DaB7cz();
		HighlightingStyleProperty = DependencyProperty.Register(Q7Z.tqM(7544), typeof(IHighlightingStyle), typeof(TextStylePreview), new PropertyMetadata(null, SXo));
		HighlightingStyleRegistryProperty = DependencyProperty.Register(Q7Z.tqM(4246), typeof(IHighlightingStyleRegistry), typeof(TextStylePreview), new PropertyMetadata(null, VXj));
		TextProperty = DependencyProperty.Register(Q7Z.tqM(7058), typeof(string), typeof(TextStylePreview), new PropertyMetadata(Q7Z.tqM(7582), UX6));
		Control.FontFamilyProperty.OverrideMetadata(typeof(TextStylePreview), new FrameworkPropertyMetadata(new FontFamily(DisplayItemClassificationTypeProvider.rPa), zXw));
		Control.FontSizeProperty.OverrideMetadata(typeof(TextStylePreview), new FrameworkPropertyMetadata((double)DisplayItemClassificationTypeProvider.jPx, zXw));
	}

	private Size PXH()
	{
		IHighlightingStyle highlightingStyle = HXF();
		FontStyle style = (true.Equals(highlightingStyle.Italic) ? FontStyles.Italic : FontStyles.Normal);
		FontWeight weight = (true.Equals(highlightingStyle.Bold) ? FontWeights.Bold : FontWeights.Normal);
		Typeface typeface = new Typeface(new FontFamily(highlightingStyle.FontFamilyName), style, weight, FontStretches.Normal);
		float fontSize = highlightingStyle.FontSize;
		string textToFormat = Text ?? string.Empty;
		TextFormattingMode textFormattingMode = TextOptions.GetTextFormattingMode(this);
		FormattedText formattedText = new FormattedText(textToFormat, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, typeface, fontSize, Brushes.Black, null, textFormattingMode);
		return new Size(formattedText.WidthIncludingTrailingWhitespace, formattedText.Height);
	}

	internal static bool tD9()
	{
		return eDF == null;
	}

	internal static TextStylePreview rDJ()
	{
		return eDF;
	}
}
