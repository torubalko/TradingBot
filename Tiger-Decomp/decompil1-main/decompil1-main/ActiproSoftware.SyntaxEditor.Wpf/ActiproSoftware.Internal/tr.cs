using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Internal;

internal class tr : StackPanel
{
	internal class IAz : ListBoxItem
	{
		internal static IAz QNz;

		protected override void OnMouseLeftButtonDown(MouseButtonEventArgs P_0)
		{
			if (P_0 != null)
			{
				P_0.Handled = true;
			}
			base.OnMouseLeftButtonDown(P_0);
			base.IsSelected = true;
		}

		public IAz()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool yHm()
		{
			return QNz == null;
		}

		internal static IAz CHp()
		{
			return QNz;
		}
	}

	private class M7S : ListBox
	{
		private static M7S KH4;

		protected override DependencyObject GetContainerForItemOverride()
		{
			return new IAz();
		}

		protected override bool IsItemItsOwnContainerOverride(object P_0)
		{
			return P_0 is IAz;
		}

		protected override void PrepareContainerForItemOverride(DependencyObject P_0, object P_1)
		{
			base.PrepareContainerForItemOverride(P_0, P_1);
			if (P_1 is CompletionFilter completionFilter && P_0 is ListBoxItem listBoxItem)
			{
				listBoxItem.ToolTip = completionFilter.ToolTip;
			}
		}

		public M7S()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool lHD()
		{
			return KH4 == null;
		}

		internal static M7S GHB()
		{
			return KH4;
		}
	}

	private CompletionFilter eQ9;

	private List<CompletionFilter> PQy;

	private IntelliPromptCompletionList AQq;

	private ICompletionSession XQ2;

	private List<CompletionFilter> kQ7;

	internal static tr NB2;

	public tr(ICompletionSession P_0, IntelliPromptCompletionList P_1)
	{
		grA.DaB7cz();
		PQy = new List<CompletionFilter>();
		kQ7 = new List<CompletionFilter>();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8536));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8560));
		}
		XQ2 = P_0;
		AQq = P_1;
		mQs();
		tQr();
	}

	private FrameworkElement uQB()
	{
		if (PQy.Count > 0)
		{
			StackPanel stackPanel = new StackPanel
			{
				Orientation = Orientation.Horizontal
			};
			string text = null;
			foreach (CompletionFilter item in PQy)
			{
				if (stackPanel.Children.Count > 0 && item.GroupName != text)
				{
					Separator separator = new Separator();
					separator.SetBinding(FrameworkElement.StyleProperty, vAE.A0X(AQq, Q7Z.tqM(8592), BindingMode.OneWay, null));
					stackPanel.Children.Add(separator);
				}
				text = item.GroupName;
				object obj = item.Content;
				if (obj is ImageSource imageSource)
				{
					obj = new DynamicImage
					{
						Width = imageSource.Width,
						Height = imageSource.Height,
						Source = imageSource
					};
				}
				ToggleButton toggleButton = new ToggleButton
				{
					Content = obj,
					DataContext = item,
					IsChecked = item.IsActive,
					IsTabStop = false,
					Margin = new Thickness(1.0, 1.0, 0.0, 1.0)
				};
				toggleButton.Focusable = false;
				toggleButton.ToolTip = item.ToolTip;
				toggleButton.Click += iQS;
				toggleButton.SetBinding(FrameworkElement.StyleProperty, vAE.A0X(AQq, Q7Z.tqM(8636), BindingMode.OneWay, null));
				stackPanel.Children.Add(toggleButton);
			}
			Border border = new Border
			{
				BorderThickness = new Thickness(0.0, 1.0, 0.0, 0.0),
				Child = stackPanel,
				Padding = new Thickness(1.0, 1.0, 2.0, 1.0)
			};
			border.SetBinding(Border.BorderBrushProperty, vAE.A0X(AQq, Q7Z.tqM(7958), BindingMode.OneWay, null));
			return border;
		}
		return null;
	}

	private FrameworkElement pQV()
	{
		FrameworkElement result;
		if (kQ7.Count <= 0)
		{
			result = null;
			int num = 0;
			if (aBI() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				goto IL_01cd;
			}
			goto IL_00c7;
		}
		if (eQ9 == null)
		{
			throw new ArgumentException(SR.GetString(SRName.ExNoAllTabFilter));
		}
		M7S m7S = new M7S
		{
			Focusable = false,
			IsTabStop = false
		};
		m7S.SetBinding(FrameworkElement.StyleProperty, vAE.A0X(AQq, Q7Z.tqM(8686), BindingMode.OneWay, null));
		m7S.SelectionChanged += nQk;
		foreach (CompletionFilter item in kQ7)
		{
			m7S.Items.Add(item);
			if (item.IsActive)
			{
				m7S.SelectedItem = item;
			}
		}
		if ((m7S.SelectedIndex == -1) & (m7S.Items.Count > 0))
		{
			goto IL_01cd;
		}
		goto IL_0206;
		IL_01cd:
		m7S.SelectedIndex = 0;
		goto IL_0206;
		IL_0206:
		Border border = new Border
		{
			BorderThickness = new Thickness(0.0, 1.0, 0.0, 0.0),
			Child = m7S
		};
		border.SetBinding(Border.BorderBrushProperty, vAE.A0X(AQq, Q7Z.tqM(7958), BindingMode.OneWay, null));
		result = border;
		goto IL_00c7;
		IL_00c7:
		return result;
	}

	private void tQr()
	{
		FrameworkElement frameworkElement = uQB();
		if (frameworkElement != null)
		{
			base.Children.Add(frameworkElement);
		}
		FrameworkElement frameworkElement2 = pQV();
		if (frameworkElement2 != null)
		{
			base.Children.Add(frameworkElement2);
		}
	}

	private void mQs()
	{
		int num2 = default(int);
		foreach (ICompletionFilter filter in XQ2.Filters)
		{
			if (!(filter is CompletionFilter completionFilter))
			{
				continue;
			}
			switch (completionFilter.DisplayMode)
			{
			case CompletionFilterDisplayMode.ToggleButton:
				PQy.Add(completionFilter);
				break;
			case CompletionFilterDisplayMode.AllTab:
				while (true)
				{
					if (eQ9 != null)
					{
						throw new ArgumentException(SR.GetString(SRName.ExOneAllTabFilter));
					}
					eQ9 = completionFilter;
					int num = 0;
					if (!hBV())
					{
						num = num2;
					}
					switch (num)
					{
					case 1:
						continue;
					}
					break;
				}
				kQ7.Add(completionFilter);
				break;
			case CompletionFilterDisplayMode.Tab:
				kQ7.Add(completionFilter);
				break;
			}
		}
	}

	private void nQk(object P_0, SelectionChangedEventArgs P_1)
	{
		M7S m7S = P_0 as M7S;
		bool flag = m7S != null;
		int num = 0;
		if (!hBV())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (!flag || !(m7S.SelectedItem is CompletionFilter completionFilter))
		{
			return;
		}
		foreach (CompletionFilter item in kQ7)
		{
			if (item.DisplayMode == CompletionFilterDisplayMode.Tab)
			{
				item.IsActive = item == completionFilter;
			}
		}
		XQ2.ApplyFilters();
	}

	private void iQS(object P_0, RoutedEventArgs P_1)
	{
		if (P_0 is ToggleButton { DataContext: CompletionFilter dataContext })
		{
			dataContext.IsActive = !dataContext.IsActive;
			XQ2.ApplyFilters();
		}
	}

	internal static bool hBV()
	{
		return NB2 == null;
	}

	internal static tr aBI()
	{
		return NB2;
	}
}
