using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[TemplateVisualState(Name = "NoItems", GroupName = "ContentStates")]
[TemplateVisualState(Name = "HasItems", GroupName = "ContentStates")]
[TemplatePart(Name = "PART_ItemListBox", Type = typeof(ListBox))]
[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
[ToolboxItem(false)]
public class IntelliPromptCompletionList : Control
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler UeD;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ICompletionSession Aeg;

	private double KeQ;

	private Dictionary<string, double> Bee;

	private bool Del;

	private IntelliPromptCompletionListBox VeA;

	public static readonly DependencyProperty FilterElementProperty;

	public static readonly DependencyProperty FilterSeparatorStyleProperty;

	public static readonly DependencyProperty FilterTabPanelStyleProperty;

	public static readonly DependencyProperty FilterToggleButtonStyleProperty;

	public static readonly DependencyProperty HorizontalOffsetProperty;

	public static readonly DependencyProperty ItemListItemContainerStyleProperty;

	public static readonly DependencyProperty ItemListItemContainerStyleSelectorProperty;

	public static readonly DependencyProperty ItemListItemTemplateProperty;

	public static readonly DependencyProperty ItemListItemTemplateSelectorProperty;

	public static readonly DependencyProperty NoItemsTemplateProperty;

	private static IntelliPromptCompletionList gBc;

	internal ICompletionItem SelectedItem
	{
		get
		{
			if (VeA == null)
			{
				return null;
			}
			return VeA.SelectedItem as ICompletionItem;
		}
	}

	public ICompletionSession Session
	{
		[CompilerGenerated]
		get
		{
			return Aeg;
		}
		[CompilerGenerated]
		private set
		{
			Aeg = value;
		}
	}

	public UIElement FilterElement
	{
		get
		{
			return (UIElement)GetValue(FilterElementProperty);
		}
		set
		{
			SetValue(FilterElementProperty, value);
		}
	}

	public Style FilterSeparatorStyle
	{
		get
		{
			return (Style)GetValue(FilterSeparatorStyleProperty);
		}
		set
		{
			SetValue(FilterSeparatorStyleProperty, value);
		}
	}

	public Style FilterTabPanelStyle
	{
		get
		{
			return (Style)GetValue(FilterTabPanelStyleProperty);
		}
		set
		{
			SetValue(FilterTabPanelStyleProperty, value);
		}
	}

	public Style FilterToggleButtonStyle
	{
		get
		{
			return (Style)GetValue(FilterToggleButtonStyleProperty);
		}
		set
		{
			SetValue(FilterToggleButtonStyleProperty, value);
		}
	}

	public double HorizontalOffset
	{
		get
		{
			return (double)GetValue(HorizontalOffsetProperty);
		}
		set
		{
			SetValue(HorizontalOffsetProperty, value);
		}
	}

	public Style ItemListItemContainerStyle
	{
		get
		{
			return (Style)GetValue(ItemListItemContainerStyleProperty);
		}
		set
		{
			SetValue(ItemListItemContainerStyleProperty, value);
		}
	}

	public StyleSelector ItemListItemContainerStyleSelector
	{
		get
		{
			return (StyleSelector)GetValue(ItemListItemContainerStyleSelectorProperty);
		}
		set
		{
			SetValue(ItemListItemContainerStyleSelectorProperty, value);
		}
	}

	public DataTemplate ItemListItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ItemListItemTemplateProperty);
		}
		set
		{
			SetValue(ItemListItemTemplateProperty, value);
		}
	}

	public DataTemplateSelector ItemListItemTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(ItemListItemTemplateSelectorProperty);
		}
		set
		{
			SetValue(ItemListItemTemplateSelectorProperty, value);
		}
	}

	public DataTemplate NoItemsTemplate
	{
		get
		{
			return (DataTemplate)GetValue(NoItemsTemplateProperty);
		}
		set
		{
			SetValue(NoItemsTemplateProperty, value);
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal void yeX(EventHandler value)
	{
		EventHandler eventHandler = UeD;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref UeD, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	[SpecialName]
	[CompilerGenerated]
	internal void oeK(EventHandler value)
	{
		EventHandler eventHandler = UeD;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
			eventHandler = Interlocked.CompareExchange(ref UeD, value2, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	public IntelliPromptCompletionList(ICompletionSession session)
	{
		grA.DaB7cz();
		Bee = new Dictionary<string, double>();
		base._002Ector();
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		if (session == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8536));
		}
		Session = session;
		BQi(Session as CompletionSession, _0020: true);
		base.DefaultStyleKey = typeof(IntelliPromptCompletionList);
		IQO();
	}

	private void BQi(CompletionSession P_0, bool P_1)
	{
		if (P_0 != null)
		{
			if (P_1)
			{
				P_0.Closed += nQp;
				P_0.FilteredItems.CollectionChanged += hQJ;
			}
			else
			{
				P_0.Closed -= nQp;
				P_0.FilteredItems.CollectionChanged -= hQJ;
			}
		}
	}

	private void nQp(object P_0, CancelEventArgs P_1)
	{
		CompletionSession completionSession = (CompletionSession)P_0;
		BQi(completionSession, _0020: false);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new IntelliPromptCompletionListAutomationPeer(this);
	}

	internal ICompletionItem nQM(bool P_0)
	{
		return (VeA != null) ? VeA.ueu(P_0) : null;
	}

	private void IQO()
	{
		FilterElement = new tr(Session, this);
	}

	private void LQU()
	{
		Del = true;
		try
		{
			CompletionSelection selection = Session.Selection;
			if (selection != null)
			{
				IQN(selection, _0020: true);
			}
		}
		finally
		{
			Del = false;
		}
	}

	[SpecialName]
	private IntelliPromptCompletionListBox eea()
	{
		return VeA;
	}

	[SpecialName]
	private void cex(IntelliPromptCompletionListBox value)
	{
		if (VeA != null)
		{
			ScrollViewer descendant = VisualTreeHelperExtended.GetDescendant<ScrollViewer>(VeA, 0);
			if (descendant != null)
			{
				descendant.ScrollChanged -= UQZ;
			}
			VeA.SelectionChanged -= iQt;
		}
		VeA = value;
		if (VeA != null)
		{
			VeA.ApplyTemplate();
			ScrollViewer descendant2 = VisualTreeHelperExtended.GetDescendant<ScrollViewer>(VeA, 0);
			if (descendant2 != null)
			{
				descendant2.ScrollChanged += UQZ;
			}
			VeA.SelectionChanged += iQt;
			LQU();
		}
	}

	private void hQJ(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		HeW(_0020: false);
	}

	private void iQt(object P_0, SelectionChangedEventArgs P_1)
	{
		if (vAE.y0m(this) && Session.View != null)
		{
			Session.View.Focus();
		}
		if (!Del)
		{
			UeD?.Invoke(this, EventArgs.Empty);
		}
	}

	private void UQZ(object P_0, object P_1)
	{
		vAE.d0c<object>(this, delegate
		{
			Session.RestartDescriptionTipTimer();
		}, null);
	}

	internal void mQh(bool P_0)
	{
		if (VeA != null && VeA.SelectedItem is ICompletionItem completionItem)
		{
			VeA.Be1(completionItem, P_0);
		}
	}

	internal void IQN(CompletionSelection P_0, bool P_1)
	{
		if (VeA != null && P_0 != null)
		{
			VeA.SelectedItem = P_0.Item;
			VeA.IsPartialSelection = P_0.State == CompletionSelectionState.Partial;
			VeA.Be1(P_0.Item, P_1);
		}
	}

	internal bool JQd(out UIElement P_0, out Rect P_1)
	{
		P_0 = null;
		P_1 = default(Rect);
		if (VeA != null)
		{
			int selectedIndex = VeA.SelectedIndex;
			bool flag = selectedIndex != -1;
			int num = 1;
			if (!BBd())
			{
				int num2 = default(int);
				num = num2;
			}
			ListBoxItem listBoxItem = default(ListBoxItem);
			while (true)
			{
				switch (num)
				{
				default:
					if (listBoxItem != null)
					{
						Rect rect = new Rect(default(Point), VeA.RenderSize);
						Rect rect2 = new Rect(default(Point), listBoxItem.RenderSize);
						rect2 = vAE.M03(listBoxItem, VeA).TransformBounds(P_1);
						if (rect.IntersectsWith(rect2))
						{
							P_0 = VeA;
							P_1 = new Rect(rect.Left - -2.0, rect2.Top, rect.Width + -4.0, rect2.Height);
							return true;
						}
					}
					break;
				case 1:
					if (flag)
					{
						listBoxItem = VeA.ItemContainerGenerator.ContainerFromIndex(selectedIndex) as ListBoxItem;
						num = 0;
						if (BBd())
						{
							num = 0;
						}
						continue;
					}
					break;
				}
				break;
			}
		}
		return false;
	}

	private void NQz()
	{
		KeQ = 0.0;
		ICompletionItemCollectionView filteredItems = Session.FilteredItems;
		if (filteredItems == null)
		{
			return;
		}
		double num = 0.0;
		int num2 = 0;
		ICompletionItem completionItem = null;
		FontFamily fontFamily = ((VeA != null) ? VeA.FontFamily : base.FontFamily);
		double fontSize = ((VeA != null) ? VeA.FontSize : base.FontSize);
		Typeface typeface = new Typeface(fontFamily, base.FontStyle, base.FontWeight, base.FontStretch);
		TextFormattingMode textFormattingMode = TextOptions.GetTextFormattingMode(this);
		double verticalScrollBarWidth = SystemParameters.VerticalScrollBarWidth;
		foreach (ICompletionItem item in filteredItems)
		{
			if (item == null)
			{
				continue;
			}
			string text = item.Text;
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			int length = text.Length;
			if (length >= num2 - 2)
			{
				num2 = Math.Max(num2, length);
				if (!Bee.TryGetValue(text, out var value))
				{
					FormattedText formattedText = new FormattedText(text, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, typeface, base.FontSize, Brushes.Black, null, textFormattingMode);
					value = formattedText.WidthIncludingTrailingWhitespace;
					Bee[text] = value;
				}
				if (value > num)
				{
					num = value;
					completionItem = item;
				}
			}
		}
		ContentControl contentControl = new ContentControl();
		TextOptions.SetTextFormattingMode(contentControl, textFormattingMode);
		StyleSelector itemListItemContainerStyleSelector = ItemListItemContainerStyleSelector;
		contentControl.FontFamily = fontFamily;
		contentControl.FontSize = fontSize;
		contentControl.Style = itemListItemContainerStyleSelector?.SelectStyle(completionItem, contentControl) ?? ItemListItemContainerStyle;
		contentControl.ContentTemplate = ItemListItemTemplate;
		contentControl.ContentTemplateSelector = ItemListItemTemplateSelector;
		contentControl.Content = completionItem;
		contentControl.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
		Thickness borderThickness = base.BorderThickness;
		Thickness thickness = ((VeA != null) ? VeA.Padding : default(Thickness));
		double width = contentControl.DesiredSize.Width;
		KeQ = borderThickness.Left + thickness.Left + width + verticalScrollBarWidth + thickness.Right + borderThickness.Right;
	}

	private void HeW(bool P_0)
	{
		if (Session.FilteredItems != null && !Session.FilteredItems.IsEmpty)
		{
			VisualStateManager.GoToState(this, Q7Z.tqM(8728), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, Q7Z.tqM(8748), P_0);
		}
	}

	protected override Size MeasureOverride(Size constraint)
	{
		Size result = base.MeasureOverride(constraint);
		result.Width = Math.Max(result.Width, KeQ);
		KeQ = result.Width;
		return result;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		cex(GetTemplateChild(Q7Z.tqM(8766)) as IntelliPromptCompletionListBox);
		NQz();
		HeW(_0020: false);
	}

	static IntelliPromptCompletionList()
	{
		grA.DaB7cz();
		FilterElementProperty = DependencyProperty.Register(Q7Z.tqM(8802), typeof(UIElement), typeof(IntelliPromptCompletionList), new PropertyMetadata(null));
		FilterSeparatorStyleProperty = DependencyProperty.Register(Q7Z.tqM(8592), typeof(Style), typeof(IntelliPromptCompletionList), new PropertyMetadata(null));
		FilterTabPanelStyleProperty = DependencyProperty.Register(Q7Z.tqM(8686), typeof(Style), typeof(IntelliPromptCompletionList), new PropertyMetadata(null));
		FilterToggleButtonStyleProperty = DependencyProperty.Register(Q7Z.tqM(8636), typeof(Style), typeof(IntelliPromptCompletionList), new PropertyMetadata(null));
		HorizontalOffsetProperty = DependencyProperty.Register(Q7Z.tqM(8832), typeof(double), typeof(IntelliPromptCompletionList), new PropertyMetadata(-21.0));
		ItemListItemContainerStyleProperty = DependencyProperty.Register(Q7Z.tqM(8868), typeof(Style), typeof(IntelliPromptCompletionList), new PropertyMetadata(null));
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		ItemListItemContainerStyleSelectorProperty = DependencyProperty.Register(Q7Z.tqM(8924), typeof(StyleSelector), typeof(IntelliPromptCompletionList), new PropertyMetadata(null));
		ItemListItemTemplateProperty = DependencyProperty.Register(Q7Z.tqM(8996), typeof(DataTemplate), typeof(IntelliPromptCompletionList), new PropertyMetadata(null));
		ItemListItemTemplateSelectorProperty = DependencyProperty.Register(Q7Z.tqM(9040), typeof(DataTemplateSelector), typeof(IntelliPromptCompletionList), new PropertyMetadata(null));
		NoItemsTemplateProperty = DependencyProperty.Register(Q7Z.tqM(9100), typeof(DataTemplate), typeof(IntelliPromptCompletionList), new PropertyMetadata(null));
	}

	[CompilerGenerated]
	private void xeP(object P_0)
	{
		Session.RestartDescriptionTipTimer();
	}

	internal static bool BBd()
	{
		return gBc == null;
	}

	internal static IntelliPromptCompletionList FBT()
	{
		return gBc;
	}
}
