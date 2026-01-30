using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Automation.Peers;
using ActiproSoftware.Windows.Data.Filtering;
using ActiproSoftware.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

[TemplatePart(Name = "PART_TextBlock", Type = typeof(TextBlock))]
public class AdvancedTextBlock : Control
{
	private TextBlock Nlk;

	private List<string> mll;

	private TextBlock hlA;

	public static readonly DependencyProperty CapturesProperty;

	public static readonly DependencyProperty HasToolTipOnOverflowProperty;

	public static readonly DependencyProperty HighlightBackgroundProperty;

	public static readonly DependencyProperty HighlightFontWeightProperty;

	public static readonly DependencyProperty HighlightForegroundProperty;

	public static readonly DependencyProperty IsOverflowedProperty;

	public static readonly DependencyProperty TextProperty;

	public static readonly DependencyProperty TextTrimmingProperty;

	private static AdvancedTextBlock hqF;

	private TextBlock TextBlock
	{
		get
		{
			return hlA;
		}
		set
		{
			hlA = value;
		}
	}

	public IEnumerable<StringFilterCapture> Captures
	{
		get
		{
			return (IEnumerable<StringFilterCapture>)GetValue(CapturesProperty);
		}
		set
		{
			SetValue(CapturesProperty, value);
		}
	}

	public bool HasToolTipOnOverflow
	{
		get
		{
			return (bool)GetValue(HasToolTipOnOverflowProperty);
		}
		set
		{
			SetValue(HasToolTipOnOverflowProperty, value);
		}
	}

	public Brush HighlightBackground
	{
		get
		{
			return (Brush)GetValue(HighlightBackgroundProperty);
		}
		set
		{
			SetValue(HighlightBackgroundProperty, value);
		}
	}

	public FontWeight HighlightFontWeight
	{
		get
		{
			return (FontWeight)GetValue(HighlightFontWeightProperty);
		}
		set
		{
			SetValue(HighlightFontWeightProperty, value);
		}
	}

	public Brush HighlightForeground
	{
		get
		{
			return (Brush)GetValue(HighlightForegroundProperty);
		}
		set
		{
			SetValue(HighlightForegroundProperty, value);
		}
	}

	public bool IsOverflowed
	{
		get
		{
			return (bool)GetValue(IsOverflowedProperty);
		}
		private set
		{
			SetValue(IsOverflowedProperty, value);
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

	public TextTrimming TextTrimming
	{
		get
		{
			return (TextTrimming)GetValue(TextTrimmingProperty);
		}
		set
		{
			SetValue(TextTrimmingProperty, value);
		}
	}

	public AdvancedTextBlock()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		Nlk = new TextBlock();
		mll = new List<string>();
		base._002Ector();
		base.DefaultStyleKey = typeof(AdvancedTextBlock);
	}

	private Size Rl4()
	{
		if (hlA != null && Nlk.Style != hlA.Style)
		{
			Nlk.Style = hlA.Style;
		}
		if (Nlk.FontFamily != base.FontFamily)
		{
			Nlk.FontFamily = base.FontFamily;
		}
		if (Nlk.FontStyle != base.FontStyle)
		{
			Nlk.FontStyle = base.FontStyle;
		}
		if (!Nlk.FontWeight.Equals(base.FontWeight))
		{
			Nlk.FontWeight = base.FontWeight;
		}
		if (Nlk.FontStretch != base.FontStretch)
		{
			Nlk.FontStretch = base.FontStretch;
		}
		if (Nlk.FontSize != base.FontSize)
		{
			Nlk.FontSize = base.FontSize;
		}
		if (Nlk.FlowDirection != base.FlowDirection)
		{
			Nlk.FlowDirection = base.FlowDirection;
		}
		TextFormattingMode textFormattingMode = TextOptions.GetTextFormattingMode(this);
		if (TextOptions.GetTextFormattingMode(Nlk) != textFormattingMode)
		{
			TextOptions.SetTextFormattingMode(Nlk, textFormattingMode);
		}
		Nlk.Inlines.Clear();
		if (hlA != null && !FontWeights.Normal.Equals(HighlightFontWeight))
		{
			foreach (Inline inline in hlA.Inlines)
			{
				if (inline is Span span)
				{
					string text = ((Run)span.Inlines.First()).Text;
					Span item = new Span
					{
						Inlines = { (Inline)new Run
						{
							Text = text
						} }
					};
					Nlk.Inlines.Add(item);
				}
				else if (inline is Run run)
				{
					Nlk.Inlines.Add(new Run
					{
						Text = run.Text
					});
				}
			}
		}
		else
		{
			Nlk.Inlines.Add(new Run
			{
				Text = Text
			});
		}
		Nlk.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
		return Nlk.DesiredSize;
	}

	private static void Flu(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AdvancedTextBlock advancedTextBlock = (AdvancedTextBlock)P_0;
		advancedTextBlock.Olo();
	}

	private static void nl2(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AdvancedTextBlock advancedTextBlock = (AdvancedTextBlock)P_0;
		advancedTextBlock.plF();
		advancedTextBlock.Jl7(advancedTextBlock.ActualWidth);
	}

	private static void ile(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AdvancedTextBlock advancedTextBlock = (AdvancedTextBlock)P_0;
		advancedTextBlock.plF();
		advancedTextBlock.Jl7(advancedTextBlock.ActualWidth);
		advancedTextBlock.Olo();
	}

	private void Jl7(double P_0)
	{
		bool flag = P_0 > 0.0;
		if (flag)
		{
			double width = Rl4().Width;
			flag = width > P_0;
		}
		IsOverflowed = flag;
	}

	private void plF()
	{
		if (hlA == null)
		{
			return;
		}
		string text = Text;
		mll.Clear();
		IEnumerable<StringFilterCapture> captures = Captures;
		if (captures != null)
		{
			int num = 0;
			foreach (StringFilterCapture item in captures)
			{
				if (item != null && item.Index >= num && item.Index + item.Length <= text.Length)
				{
					mll.Add(text.Substring(num, item.Index - num));
					mll.Add(text.Substring(item.Index, item.Length));
					num = item.Index + item.Length;
				}
			}
			if (num <= text.Length)
			{
				mll.Add(text.Substring(num));
			}
		}
		else
		{
			mll.Add(text);
		}
		hlA.Inlines.Clear();
		if (mll.Count > 1)
		{
			bool flag = false;
			Brush highlightBackground = HighlightBackground;
			Brush brush = HighlightForeground;
			FontWeight highlightFontWeight = HighlightFontWeight;
			if (brush != null && brush is SolidColorBrush solidColorBrush && base.Foreground is SolidColorBrush solidColorBrush2)
			{
				UIColor uIColor = UIColor.FromColor(solidColorBrush.Color);
				UIColor uIColor2 = UIColor.FromColor(solidColorBrush2.Color);
				if (uIColor.IsLight != uIColor2.IsLight)
				{
					SolidColorBrush solidColorBrush3 = new SolidColorBrush();
					solidColorBrush3.Color = Color.FromArgb(192, uIColor2.R, uIColor2.G, uIColor2.B);
					if (solidColorBrush3.CanFreeze)
					{
						solidColorBrush3.Freeze();
					}
					brush = solidColorBrush3;
				}
			}
			{
				foreach (string item2 in mll)
				{
					if (!string.IsNullOrEmpty(item2))
					{
						if (flag)
						{
							Span span = new Span
							{
								Inlines = { (Inline)new Run
								{
									Text = item2
								} }
							};
							if (highlightBackground != null)
							{
								span.Background = highlightBackground;
							}
							if (brush != null)
							{
								span.Foreground = brush;
							}
							if (!FontWeights.Normal.Equals(highlightFontWeight))
							{
								span.FontWeight = highlightFontWeight;
							}
							hlA.Inlines.Add(span);
						}
						else
						{
							hlA.Inlines.Add(new Run
							{
								Text = item2
							});
						}
					}
					flag = !flag;
				}
				return;
			}
		}
		if (mll.Count == 1)
		{
			hlA.Inlines.Add(new Run
			{
				Text = mll[0]
			});
		}
	}

	private void Olo()
	{
		string text = Text;
		if (HasToolTipOnOverflow && IsOverflowed && !string.IsNullOrEmpty(text))
		{
			ToolTipService.SetToolTip(this, new TextBlock
			{
				FontFamily = base.FontFamily,
				FontSize = base.FontSize,
				FontStyle = base.FontStyle,
				FontWeight = base.FontWeight,
				Text = text
			});
		}
		else
		{
			ToolTipService.SetToolTip(this, null);
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		Jl7(finalSize.Width);
		return base.ArrangeOverride(finalSize);
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		TextBlock = GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113184)) as TextBlock;
		plF();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new AdvancedTextBlockAutomationPeer(this);
	}

	static AdvancedTextBlock()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		CapturesProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112998), typeof(IEnumerable<StringFilterCapture>), typeof(AdvancedTextBlock), new PropertyMetadata(null, nl2));
		HasToolTipOnOverflowProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113216), typeof(bool), typeof(AdvancedTextBlock), new PropertyMetadata(true));
		HighlightBackgroundProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113260), typeof(Brush), typeof(AdvancedTextBlock), new PropertyMetadata(null, nl2));
		HighlightFontWeightProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113302), typeof(FontWeight), typeof(AdvancedTextBlock), new PropertyMetadata(FontWeights.Bold, nl2));
		HighlightForegroundProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113344), typeof(Brush), typeof(AdvancedTextBlock), new PropertyMetadata(null, nl2));
		IsOverflowedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113386), typeof(bool), typeof(AdvancedTextBlock), new PropertyMetadata(false, Flu));
		TextProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113414), typeof(string), typeof(AdvancedTextBlock), new PropertyMetadata(string.Empty, ile));
		TextTrimmingProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113426), typeof(TextTrimming), typeof(AdvancedTextBlock), new PropertyMetadata(TextTrimming.CharacterEllipsis, nl2));
	}

	internal static bool Eqd()
	{
		return hqF == null;
	}

	internal static AdvancedTextBlock Uqv()
	{
		return hqF;
	}
}
