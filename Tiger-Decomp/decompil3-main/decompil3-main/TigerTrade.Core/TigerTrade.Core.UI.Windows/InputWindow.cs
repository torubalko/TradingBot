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

public sealed class InputWindow : Window, IComponentConnector
{
	internal TextBlock LabelMessage;

	internal TextBox TextBoxValue;

	internal Button ButtonOk;

	internal Button ButtonCancel;

	private bool _contentLoaded;

	internal static InputWindow XgNBhPk9YqQTRei1TueF;

	public string Message { get; set; }

	public string Value { get; set; }

	public InputWindow()
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_0797e62afb0c4241b7a0c427b8e94e96 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void InputWindow_Loaded(object sender, RoutedEventArgs e)
	{
		LabelMessage.Text = Message;
		TextBoxValue.Text = Value;
		dr27iSk9BIWMX43yWsIJ(TextBoxValue);
		int num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_92c4ace445eb447c9e2014e7097157ae == 0)
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
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.DialogResult = true;
				num2 = 0;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_3a80f21f876f4cfd845b5629c73a033f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Value = TextBoxValue.Text;
				Close();
				return;
			}
		}
	}

	private void ButtonCancel_Click(object sender, RoutedEventArgs e)
	{
		qyIvA9k9asd9FxUoHGCc(this);
	}

	public static bool ShowWindow(Window owner, string title, string message, out string value, string defaultValue = "")
	{
		int num = 1;
		int num2 = num;
		InputWindow inputWindow = default(InputWindow);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				InputWindow inputWindow2 = new InputWindow();
				oG58RMk9i8lCYXdiUU82(inputWindow2, owner);
				inputWindow2.Title = title;
				inputWindow2.Message = message;
				inputWindow2.Value = defaultValue;
				inputWindow = inputWindow2;
				num2 = 0;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_0d7fed5333b948279b5aff1eb871b253 == 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
			{
				bool? flag = inputWindow.ShowDialog();
				value = (string)IYB0GHk9lwrS68L6pVAL(inputWindow);
				return flag == true;
			}
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
			{
				_contentLoaded = true;
				Uri resourceLocator = new Uri(RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(0x9F0F634 ^ 0x9F0F2E0), UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
				num2 = 2;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_d401fbaf628348a0be4da9939ee685ed == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
				if (_contentLoaded)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_3003f96c370e481ba4f92d4c1a0a7ae5 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		int num;
		switch (connectionId)
		{
		case 2:
			LabelMessage = (TextBlock)target;
			return;
		case 5:
			ButtonCancel = (Button)target;
			ButtonCancel.Click += ButtonCancel_Click;
			return;
		case 3:
			TextBoxValue = (TextBox)target;
			num = 0;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_72d4a9b4578145a7901cd7ce7ec9e17e == 0)
			{
				num = 2;
			}
			goto IL_0009;
		case 4:
			ButtonOk = (Button)target;
			num = 0;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_c15ee73cea4e4b56b74a2d79b4e4679c != 0)
			{
				num = 0;
			}
			goto IL_0009;
		default:
			_contentLoaded = true;
			return;
		case 1:
			break;
			IL_0009:
			while (true)
			{
				switch (num)
				{
				case 3:
					return;
				default:
					goto IL_0064;
				case 2:
					return;
				case 1:
					break;
				}
				break;
				IL_0064:
				ButtonOk.Click += ButtonOk_Click;
				num = 3;
			}
			break;
		}
		((InputWindow)target).Loaded += InputWindow_Loaded;
	}

	static InputWindow()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool x28RUik9odDS3gHo4r1D()
	{
		return XgNBhPk9YqQTRei1TueF == null;
	}

	internal static InputWindow F6JliFk9vf3AsSLm7nkE()
	{
		return XgNBhPk9YqQTRei1TueF;
	}

	internal static bool dr27iSk9BIWMX43yWsIJ(object P_0)
	{
		return ((UIElement)P_0).Focus();
	}

	internal static void qyIvA9k9asd9FxUoHGCc(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static void oG58RMk9i8lCYXdiUU82(object P_0, object P_1)
	{
		((Window)P_0).Owner = (Window)P_1;
	}

	internal static object IYB0GHk9lwrS68L6pVAL(object P_0)
	{
		return ((InputWindow)P_0).Value;
	}
}
