using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using EDugZvNwF6e5LYsQZ3C5;
using nff6NvN8pYC4xeKDOd05;
using OrDDjnN8w7riQsQI5MiI;

namespace TigerTrade.Core.UI.Windows;

public sealed class MessageWindow : Window, IComponentConnector
{
	internal TextBlock LabelMessage;

	internal Button ButtonOk;

	private bool _contentLoaded;

	private static MessageWindow siJpUFk94mIbSsXPjvk1;

	public string Message { get; set; }

	public MessageWindow()
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		base._002Ector();
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_b4f383c2ef60442582501c46cbd6e5c8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void ButtonOk_Click(object sender, RoutedEventArgs e)
	{
		base.DialogResult = true;
		lKOWoZk9N4y4qXBOvIo5(this);
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		LabelMessage.Text = Message;
	}

	public static bool ShowWindow(Window owner, string title, string message)
	{
		MessageWindow messageWindow = new MessageWindow
		{
			Owner = owner,
			Title = title,
			Message = message
		};
		int num;
		if (owner == null)
		{
			messageWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			num = 0;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_0d7fed5333b948279b5aff1eb871b253 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_001b;
		IL_0009:
		bool? flag = default(bool?);
		bool flag2 = default(bool);
		switch (num)
		{
		case 1:
			return flag == flag2;
		}
		goto IL_001b;
		IL_001b:
		flag = messageWindow.ShowDialog();
		flag2 = true;
		num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_ddd61f309d844557b98cb748068df4e1 != 0)
		{
			num = 1;
		}
		goto IL_0009;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			int num = 0;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_5934edd4aa44472ab56379415e38746d == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				return;
			}
			Uri resourceLocator = new Uri(RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1583344314 ^ -1583345662), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		default:
			_contentLoaded = true;
			num = 2;
			goto IL_0009;
		case 3:
			ButtonOk = (Button)target;
			ButtonOk.Click += ButtonOk_Click;
			break;
		case 2:
			LabelMessage = (TextBlock)target;
			break;
		case 1:
			{
				((MessageWindow)target).Loaded += Window_Loaded;
				num = 0;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_c953a2674cb94043ac2458182f2ba594 == 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			IL_0009:
			switch (num)
			{
			default:
				return;
			case 2:
				return;
			case 0:
				return;
			case 1:
				break;
			}
			goto case 1;
		}
	}

	static MessageWindow()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool PDgZKWk9D5xaRf9RJhJu()
	{
		return siJpUFk94mIbSsXPjvk1 == null;
	}

	internal static MessageWindow nv2NO1k9beh0vJSaEWoO()
	{
		return siJpUFk94mIbSsXPjvk1;
	}

	internal static void lKOWoZk9N4y4qXBOvIo5(object P_0)
	{
		((Window)P_0).Close();
	}
}
