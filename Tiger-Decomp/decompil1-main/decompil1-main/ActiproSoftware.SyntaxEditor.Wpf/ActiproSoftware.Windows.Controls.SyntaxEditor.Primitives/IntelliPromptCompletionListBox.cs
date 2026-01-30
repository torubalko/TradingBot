using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Intelli")]
[ToolboxItem(false)]
public class IntelliPromptCompletionListBox : ListBox
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public bool fVv;

		public IntelliPromptCompletionListBox JVm;

		public ICompletionItem fVC;

		private static _003C_003Ec__DisplayClass15_0 bH0;

		public _003C_003Ec__DisplayClass15_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal object zVA(object arg)
		{
			if (fVv && JVm.ItemContainerGenerator.Status == GeneratorStatus.ContainersGenerated)
			{
				int num = JVm.Items.IndexOf(fVC);
				if (VisualTreeHelperExtended.GetDescendant(JVm, typeof(ScrollViewer), 0) is ScrollViewer scrollViewer)
				{
					int num2 = (int)scrollViewer.VerticalOffset;
					if (num2 >= 0 && num2 < JVm.Items.Count)
					{
						int num3 = (int)scrollViewer.ViewportHeight;
						if (num3 <= 1)
						{
							scrollViewer.ScrollToVerticalOffset(num);
							return null;
						}
						scrollViewer.ScrollToVerticalOffset(Math.Max(0, num - Math.Max(0, (num3 - 1) / 2)));
						return null;
					}
				}
			}
			JVm.ScrollIntoView(fVC);
			return null;
		}

		internal static bool FH7()
		{
			return bH0 == null;
		}

		internal static _003C_003Ec__DisplayClass15_0 qHn()
		{
			return bH0;
		}
	}

	public static readonly DependencyProperty IsPartialSelectionProperty;

	internal static IntelliPromptCompletionListBox HBt;

	public bool IsPartialSelection
	{
		get
		{
			return (bool)GetValue(IsPartialSelectionProperty);
		}
		set
		{
			SetValue(IsPartialSelectionProperty, value);
		}
	}

	public IntelliPromptCompletionListBox()
	{
		grA.DaB7cz();
		base._002Ector();
		base.DefaultStyleKey = typeof(IntelliPromptCompletionListBox);
		base.SelectionChanged += sem;
	}

	private static void Eev(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		IntelliPromptCompletionListBox intelliPromptCompletionListBox = (IntelliPromptCompletionListBox)P_0;
		intelliPromptCompletionListBox.peC();
	}

	private void sem(object P_0, SelectionChangedEventArgs P_1)
	{
		peC();
	}

	internal void peC()
	{
		object selectedItem = base.SelectedItem;
		if (selectedItem != null)
		{
			IntelliPromptCompletionListBoxItem intelliPromptCompletionListBoxItem = selectedItem as IntelliPromptCompletionListBoxItem;
			if (intelliPromptCompletionListBoxItem == null)
			{
				intelliPromptCompletionListBoxItem = base.ItemContainerGenerator.ContainerFromItem(selectedItem) as IntelliPromptCompletionListBoxItem;
			}
			if (intelliPromptCompletionListBoxItem != null)
			{
				intelliPromptCompletionListBoxItem.IsPartialSelection = IsPartialSelection;
			}
		}
	}

	protected override void ClearContainerForItemOverride(DependencyObject element, object item)
	{
		base.ClearContainerForItemOverride(element, item);
		if (element is IntelliPromptCompletionListBoxItem intelliPromptCompletionListBoxItem && base.DataContext is CompletionSession completionSession)
		{
			intelliPromptCompletionListBoxItem.oeF(completionSession, _0020: false);
		}
	}

	protected override DependencyObject GetContainerForItemOverride()
	{
		return new IntelliPromptCompletionListBoxItem();
	}

	protected override bool IsItemItsOwnContainerOverride(object item)
	{
		return item is IntelliPromptCompletionListBoxItem;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		double height = new FormattedText(Q7Z.tqM(9134), CultureInfo.CurrentCulture, FlowDirection.LeftToRight, new Typeface(base.FontFamily, base.FontStyle, base.FontWeight, base.FontStretch), base.FontSize, base.Foreground).Height;
		double num = Math.Max(16.0, Math.Ceiling(height + 2.0));
		double num2 = 9.0 * num;
		int num3 = 0;
		if (jBb() != null)
		{
			int num4 = default(int);
			num3 = num4;
		}
		switch (num3)
		{
		default:
			if (availableSize.Height > num2)
			{
				availableSize.Height = num2;
			}
			return base.MeasureOverride(availableSize);
		}
	}

	protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
	{
		base.PrepareContainerForItemOverride(element, item);
		if (element is IntelliPromptCompletionListBoxItem intelliPromptCompletionListBoxItem)
		{
			intelliPromptCompletionListBoxItem.IsPartialSelection = IsPartialSelection;
			if (base.DataContext is CompletionSession completionSession)
			{
				intelliPromptCompletionListBoxItem.oeF(completionSession, _0020: true);
			}
		}
	}

	internal ICompletionItem ueu(bool P_0)
	{
		int selectedIndex = base.SelectedIndex;
		if (selectedIndex != -1 && VisualTreeHelperExtended.GetDescendant(this, typeof(ScrollViewer), 0) is ScrollViewer scrollViewer)
		{
			int num = (int)scrollViewer.VerticalOffset;
			if (num >= 0 && num < base.Items.Count)
			{
				int num2 = (int)scrollViewer.ViewportHeight;
				if (P_0)
				{
					int num3 = Math.Min(base.Items.Count - 1, num + num2 - 1);
					if (selectedIndex < num3)
					{
						return base.Items[num3] as ICompletionItem;
					}
					return base.Items[Math.Min(base.Items.Count - 1, selectedIndex + num2)] as ICompletionItem;
				}
				if (selectedIndex > num)
				{
					return base.Items[num] as ICompletionItem;
				}
				return base.Items[Math.Max(0, selectedIndex - num2)] as ICompletionItem;
			}
		}
		return null;
	}

	internal void Be1(ICompletionItem P_0, bool P_1)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals12 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals12.fVv = P_1;
		CS_0024_003C_003E8__locals12.JVm = this;
		CS_0024_003C_003E8__locals12.fVC = P_0;
		if (CS_0024_003C_003E8__locals12.fVC == null)
		{
			return;
		}
		base.Dispatcher.BeginInvoke(DispatcherPriority.Loaded, (DispatcherOperationCallback)delegate
		{
			if (CS_0024_003C_003E8__locals12.fVv && CS_0024_003C_003E8__locals12.JVm.ItemContainerGenerator.Status == GeneratorStatus.ContainersGenerated)
			{
				int num = CS_0024_003C_003E8__locals12.JVm.Items.IndexOf(CS_0024_003C_003E8__locals12.fVC);
				if (VisualTreeHelperExtended.GetDescendant(CS_0024_003C_003E8__locals12.JVm, typeof(ScrollViewer), 0) is ScrollViewer scrollViewer)
				{
					int num2 = (int)scrollViewer.VerticalOffset;
					if (num2 >= 0 && num2 < CS_0024_003C_003E8__locals12.JVm.Items.Count)
					{
						int num3 = (int)scrollViewer.ViewportHeight;
						if (num3 <= 1)
						{
							scrollViewer.ScrollToVerticalOffset(num);
							return (object)null;
						}
						scrollViewer.ScrollToVerticalOffset(Math.Max(0, num - Math.Max(0, (num3 - 1) / 2)));
						return (object)null;
					}
				}
			}
			CS_0024_003C_003E8__locals12.JVm.ScrollIntoView(CS_0024_003C_003E8__locals12.fVC);
			return (object)null;
		}, null);
	}

	static IntelliPromptCompletionListBox()
	{
		grA.DaB7cz();
		IsPartialSelectionProperty = DependencyProperty.Register(Q7Z.tqM(9142), typeof(bool), typeof(IntelliPromptCompletionListBox), new PropertyMetadata(false, Eev));
	}

	internal static bool TBY()
	{
		return HBt == null;
	}

	internal static IntelliPromptCompletionListBox jBb()
	{
		return HBt;
	}
}
