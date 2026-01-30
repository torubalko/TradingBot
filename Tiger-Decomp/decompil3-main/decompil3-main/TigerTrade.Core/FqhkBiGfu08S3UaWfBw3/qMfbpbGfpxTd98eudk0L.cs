using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using EDugZvNwF6e5LYsQZ3C5;
using nff6NvN8pYC4xeKDOd05;
using OrDDjnN8w7riQsQI5MiI;

namespace FqhkBiGfu08S3UaWfBw3;

public sealed class qMfbpbGfpxTd98eudk0L : Window, IComponentConnector
{
	[CompilerGenerated]
	private string pfNG9vbJqv7;

	[CompilerGenerated]
	private string IlOG9BKdLoE;

	private bool LBlG9a4olT3;

	internal TextBlock LabelMessage;

	internal CheckBox CheckBox;

	internal Button ButtonYes;

	internal Button ButtonNo;

	private bool NAeG9iVwBDR;

	internal static qMfbpbGfpxTd98eudk0L zJtGONk9XNpDsWFhUpYe;

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return pfNG9vbJqv7;
		}
		[CompilerGenerated]
		set
		{
			pfNG9vbJqv7 = text;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public string eBaG99kbKCH()
	{
		return IlOG9BKdLoE;
	}

	[SpecialName]
	[CompilerGenerated]
	public void FjnG9nLl98l(string P_0)
	{
		IlOG9BKdLoE = P_0;
	}

	public qMfbpbGfpxTd98eudk0L()
	{
		y26gGyk9EtItX4MBNUJu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_fde1e2b988414f6aa0c032a729a39c63 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void WArGfzZsENH(object P_0, RoutedEventArgs P_1)
	{
		base.DialogResult = true;
		Close();
	}

	private void FFjG9009rpy(object P_0, RoutedEventArgs P_1)
	{
		Close();
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		LabelMessage.Text = Message;
		SP304xk9Qvu4Mo75JX7k(CheckBox, eBaG99kbKCH());
		CheckBox.IsChecked = LBlG9a4olT3;
		int num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_602f961efba14121b5babc65d1c5b5fc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	[SpecialName]
	private bool x92G9Y7sFLZ()
	{
		return CheckBox.IsChecked == true;
	}

	public static bool XlTG92VZOea(Window P_0, string P_1, string P_2, string P_3, bool P_4, out bool P_5)
	{
		qMfbpbGfpxTd98eudk0L obj = new qMfbpbGfpxTd98eudk0L();
		Kk35D9k9dfwYtC1M8g6j(obj, P_0);
		obj.Title = P_1;
		zibcBJk9gJtO3e5N3E6k(obj, P_2);
		obj.FjnG9nLl98l(P_3);
		obj.LBlG9a4olT3 = P_4;
		qMfbpbGfpxTd98eudk0L qMfbpbGfpxTd98eudk0L2 = obj;
		bool? flag = qMfbpbGfpxTd98eudk0L2.ShowDialog();
		P_5 = DwkIDZk9REvVqyLu3Q1q(qMfbpbGfpxTd98eudk0L2);
		bool? flag2 = flag;
		int num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_958fb4ed0ac04088853ded3c38efcdda == 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => flag2 == true, 
		};
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!NAeG9iVwBDR)
		{
			NAeG9iVwBDR = true;
			int num = 0;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_1891602e3a22430c914d0abbabc69a04 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri resourceLocator = new Uri(RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(--871424829 ^ 0x33F0E515), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					ButtonYes.Click += WArGfzZsENH;
					num2 = 0;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_2ed2eb31b0094dc99a75fe815613d9e5 != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					return;
				case 2:
					NAeG9iVwBDR = true;
					return;
				case 0:
					return;
				case 3:
					{
						switch (P_0)
						{
						case 4:
							ButtonYes = (Button)P_1;
							num2 = 0;
							if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_783c5ce2dc1c46a2a6e7d2bdb7898bca != 0)
							{
								num2 = 1;
							}
							goto end_IL_0012;
						case 5:
							ButtonNo = (Button)P_1;
							ButtonNo.Click += FFjG9009rpy;
							return;
						case 1:
							((qMfbpbGfpxTd98eudk0L)P_1).Loaded += Window_Loaded;
							return;
						default:
							num2 = 2;
							goto end_IL_0012;
						case 3:
							break;
						case 2:
							LabelMessage = (TextBlock)P_1;
							return;
						}
						CheckBox = (CheckBox)P_1;
						num = 4;
						goto end_IL_0012_2;
					}
					end_IL_0012:
					break;
				}
				continue;
				end_IL_0012_2:
				break;
			}
		}
	}

	static qMfbpbGfpxTd98eudk0L()
	{
		coM0Xyk96EXRMLfABuQd();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool huF7SZk9chGh47Kx8clJ()
	{
		return zJtGONk9XNpDsWFhUpYe == null;
	}

	internal static qMfbpbGfpxTd98eudk0L e8rE4fk9jtBB4cdfQQDD()
	{
		return zJtGONk9XNpDsWFhUpYe;
	}

	internal static void y26gGyk9EtItX4MBNUJu()
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
	}

	internal static void SP304xk9Qvu4Mo75JX7k(object P_0, object P_1)
	{
		((ContentControl)P_0).Content = P_1;
	}

	internal static void Kk35D9k9dfwYtC1M8g6j(object P_0, object P_1)
	{
		((Window)P_0).Owner = (Window)P_1;
	}

	internal static void zibcBJk9gJtO3e5N3E6k(object P_0, object P_1)
	{
		((qMfbpbGfpxTd98eudk0L)P_0).Message = (string)P_1;
	}

	internal static bool DwkIDZk9REvVqyLu3Q1q(object P_0)
	{
		return ((qMfbpbGfpxTd98eudk0L)P_0).x92G9Y7sFLZ();
	}

	internal static void coM0Xyk96EXRMLfABuQd()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
	}
}
