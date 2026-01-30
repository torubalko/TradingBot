using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class ContentProviderPresenter : ContentControl
{
	public static readonly DependencyProperty ContentProviderProperty;

	internal static ContentProviderPresenter LDh;

	public IContentProvider ContentProvider
	{
		get
		{
			return (IContentProvider)GetValue(ContentProviderProperty);
		}
		set
		{
			SetValue(ContentProviderProperty, value);
		}
	}

	private static void qXZ(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		ContentProviderPresenter contentProviderPresenter = (ContentProviderPresenter)P_0;
		if (!(P_1.NewValue is IContentProvider contentProvider))
		{
			contentProviderPresenter.Content = null;
			return;
		}
		object content = contentProvider.GetContent();
		if (content is TextBlock textBlock)
		{
			textBlock.TextWrapping = TextWrapping.NoWrap;
			int num = 0;
			if (MDK() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		contentProviderPresenter.Content = content;
	}

	public ContentProviderPresenter()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	static ContentProviderPresenter()
	{
		grA.DaB7cz();
		ContentProviderProperty = DependencyProperty.Register(Q7Z.tqM(7630), typeof(IContentProvider), typeof(ContentProviderPresenter), new PropertyMetadata(null, qXZ));
	}

	internal static bool HD6()
	{
		return LDh == null;
	}

	internal static ContentProviderPresenter MDK()
	{
		return LDh;
	}
}
