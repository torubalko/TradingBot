using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using EDugZvNwF6e5LYsQZ3C5;
using nff6NvN8pYC4xeKDOd05;
using OrDDjnN8w7riQsQI5MiI;

namespace TigerTrade.Core.UI.Windows;

public sealed class YesNoWindow : Window, IComponentConnector
{
	internal TextBlock LabelMessage;

	internal Button ButtonYes;

	internal Button ButtonNo;

	private bool _contentLoaded;

	internal static YesNoWindow A6N2eWk9k0hu0KK2b5Ki;

	public string Message { get; set; }

	public YesNoWindow()
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_1ee8544a5d2a4e188b1bba7c085a5ca3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void ButtonYes_Click(object sender, RoutedEventArgs e)
	{
		base.DialogResult = true;
		Close();
	}

	private void ButtonNo_Click(object sender, RoutedEventArgs e)
	{
		Close();
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		KFrBAkk9SUWgcTRtdHyC(LabelMessage, Message);
	}

	public static bool ShowWindow(Window owner, string title, string message)
	{
		YesNoWindow obj = new YesNoWindow
		{
			Owner = owner
		};
		kcWjksk9x9Y6DALxWOVu(obj, title);
		KN24m9k9LkYdjAC65I2r(obj, message);
		return obj.ShowDialog() == true;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri resourceLocator = new Uri(RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(-1047165041 ^ -1047166409), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_ea254caae95d42b3aa53bb0cc92a4816 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
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
			return;
		case 2:
			LabelMessage = (TextBlock)target;
			return;
		case 1:
			break;
		case 4:
			ButtonNo = (Button)target;
			ButtonNo.Click += ButtonNo_Click;
			num = 0;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_c953a2674cb94043ac2458182f2ba594 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 3:
			{
				ButtonYes = (Button)target;
				num = 1;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_b4f383c2ef60442582501c46cbd6e5c8 != 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			IL_0009:
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					break;
				case 3:
					return;
				case 1:
					goto IL_0097;
				}
				break;
				IL_0097:
				kNJkL1k9eyMxYt9dHAL4(ButtonYes, new RoutedEventHandler(ButtonYes_Click));
				num = 3;
			}
			break;
		}
		((YesNoWindow)target).Loaded += Window_Loaded;
	}

	static YesNoWindow()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
		mtZQjok9sbqsacYBHEy5();
	}

	internal static bool WfNfLNk91MGKag4378TO()
	{
		return A6N2eWk9k0hu0KK2b5Ki == null;
	}

	internal static YesNoWindow AijW3Mk95T43Fc6Ay5uS()
	{
		return A6N2eWk9k0hu0KK2b5Ki;
	}

	internal static void KFrBAkk9SUWgcTRtdHyC(object P_0, object P_1)
	{
		((TextBlock)P_0).Text = (string)P_1;
	}

	internal static void kcWjksk9x9Y6DALxWOVu(object P_0, object P_1)
	{
		((Window)P_0).Title = (string)P_1;
	}

	internal static void KN24m9k9LkYdjAC65I2r(object P_0, object P_1)
	{
		((YesNoWindow)P_0).Message = (string)P_1;
	}

	internal static void kNJkL1k9eyMxYt9dHAL4(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static void mtZQjok9sbqsacYBHEy5()
	{
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}
}
