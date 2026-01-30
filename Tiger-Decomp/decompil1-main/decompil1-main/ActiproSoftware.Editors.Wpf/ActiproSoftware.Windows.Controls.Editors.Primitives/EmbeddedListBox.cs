using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Data.Filtering;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ToolboxItem(false)]
public class EmbeddedListBox : ListBox
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler uOa;

	internal static EmbeddedListBox ajG;

	[SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
	internal event EventHandler gO2
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = uOa;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref uOa, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = uOa;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref uOa, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public EmbeddedListBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(EmbeddedListBox);
		base.Loaded += LOM;
	}

	private void LOM(object P_0, RoutedEventArgs P_1)
	{
		object selectedItem = base.SelectedItem;
		if (selectedItem != null)
		{
			ScrollIntoView(selectedItem);
		}
	}

	internal void jOs()
	{
		uOa?.Invoke(this, EventArgs.Empty);
	}

	protected override DependencyObject GetContainerForItemOverride()
	{
		return new EmbeddedListBoxItem();
	}

	protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
	{
		base.PrepareContainerForItemOverride(element, item);
		if (element is EmbeddedListBoxItem embeddedListBoxItem)
		{
			bool flag = false;
			if (base.TemplatedParent is AutoCompleteBox autoCompleteBox)
			{
				StringFilterCapture.SetCaptures(embeddedListBoxItem, autoCompleteBox.kj(item));
				flag = autoCompleteBox.InputMode == AutoCompleteBoxInputMode.Search || !string.IsNullOrEmpty(autoCompleteBox.Text);
			}
			if (flag && base.SelectedItem == null && embeddedListBoxItem.IsEnabled)
			{
				base.SelectedItem = item;
			}
		}
	}

	internal static bool xjJ()
	{
		return ajG == null;
	}

	internal static EmbeddedListBox zjh()
	{
		return ajG;
	}
}
