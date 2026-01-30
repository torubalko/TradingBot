using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using BfZtb759KlUg4482QKym;
using jhuDCPG8d8bbdl4R91vn;
using K1GcsD5GTtMSlaiJI0Xh;
using OKex6uY9PfSPs604d9aT;
using siIK6eY9t5vjpCCCFKlo;
using TigerTrade.Tc.Manager;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;

namespace Y2MoWZY9O1fRUjkRUTuC;

internal sealed class UvSvYSY9MQlqt7LjJGAl : SuSj0gaXkIlYcfCsT0qp, IComponentConnector
{
	private readonly wdPKZNY9Ay1YLba4YZ9Q lXMY9qhCJXN;

	internal ComboBox ComboBoxServer;

	internal TextBox TextBoxLogin;

	internal PasswordBox TextBoxPassword;

	private bool MGPY9IPvMU8;

	private static UvSvYSY9MQlqt7LjJGAl fk7XRRSfhd6so3x0xaNC;

	public UvSvYSY9MQlqt7LjJGAl()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		TcEvents.RiseTrackWindow(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x769C7931 ^ 0x769C8613));
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public UvSvYSY9MQlqt7LjJGAl(wdPKZNY9Ay1YLba4YZ9Q P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		lXMY9qhCJXN = P_0;
	}

	private void SmartComControl_Loaded(object sender, RoutedEventArgs e)
	{
		if (lXMY9qhCJXN == null)
		{
			return;
		}
		((ItemCollection)klnUQnSf8uP0P1Zm9PIe(ComboBoxServer)).Clear();
		using (List<wSisEnY9W3gHNPIFUdbR>.Enumerator enumerator = wdPKZNY9Ay1YLba4YZ9Q.Servers.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				while (true)
				{
					wSisEnY9W3gHNPIFUdbR current = enumerator.Current;
					ComboBoxServer.Items.Add(current);
					if (lXMY9qhCJXN.jRXY9zuuBax == current.yQRY9mcRdk0())
					{
						ComboBoxServer.SelectedItem = current;
						int num = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d == 0)
						{
							num = 1;
						}
						switch (num)
						{
						case 1:
							break;
						default:
							continue;
						}
					}
					break;
				}
			}
		}
		while (true)
		{
			TextBoxLogin.Text = (string)V4Ua5nSfAmIYG459LGoj(lXMY9qhCJXN);
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 != 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			TextBoxPassword.Password = (string)AItxS9SfPt1083Tbbd7p(lXMY9qhCJXN);
			return;
		}
	}

	public override void SaveSettings()
	{
		if (lXMY9qhCJXN == null)
		{
			return;
		}
		lXMY9qhCJXN.jRXY9zuuBax = ((X7gGcWSfJE8siVIsZqeh(ComboBoxServer) is wSisEnY9W3gHNPIFUdbR wSisEnY9W3gHNPIFUdbR) ? wSisEnY9W3gHNPIFUdbR.yQRY9mcRdk0() : "");
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				lXMY9qhCJXN.Password = TextBoxPassword.Password.Trim();
				KbQ6XhSf37Sc3HoLOYVM(lXMY9qhCJXN);
				return;
			}
			lXMY9qhCJXN.Login = (string)EEDu9uSfFvyNI1JAC8G6(TextBoxLogin.Text);
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f != 0)
			{
				num = 0;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!MGPY9IPvMU8)
		{
			MGPY9IPvMU8 = true;
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri resourceLocator = new Uri(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x78D396D8 ^ 0x78D3699C), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 3:
			TextBoxPassword = (PasswordBox)P_1;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 2:
			TextBoxLogin = (TextBox)P_1;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		default:
			MGPY9IPvMU8 = true;
			break;
		case 1:
			{
				ComboBoxServer = (ComboBox)P_1;
				break;
			}
			IL_0009:
			switch (num)
			{
			case 1:
				break;
			case 0:
				break;
			}
			break;
		}
	}

	static UvSvYSY9MQlqt7LjJGAl()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		apU1QVSfp4YnfSuye71l();
	}

	internal static bool sAgIJYSfwGC9wG5SZtZ9()
	{
		return fk7XRRSfhd6so3x0xaNC == null;
	}

	internal static UvSvYSY9MQlqt7LjJGAl dhC8lQSf7tUpRnqk1aX0()
	{
		return fk7XRRSfhd6so3x0xaNC;
	}

	internal static object klnUQnSf8uP0P1Zm9PIe(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static object V4Ua5nSfAmIYG459LGoj(object P_0)
	{
		return ((wdPKZNY9Ay1YLba4YZ9Q)P_0).Login;
	}

	internal static object AItxS9SfPt1083Tbbd7p(object P_0)
	{
		return ((wdPKZNY9Ay1YLba4YZ9Q)P_0).Password;
	}

	internal static object X7gGcWSfJE8siVIsZqeh(object P_0)
	{
		return ((Selector)P_0).SelectedItem;
	}

	internal static object EEDu9uSfFvyNI1JAC8G6(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static void KbQ6XhSf37Sc3HoLOYVM(object P_0)
	{
		((gpnr5oG8Q1cRMmiYT0Ut)P_0).gpqG8g0ePAk();
	}

	internal static void apU1QVSfp4YnfSuye71l()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
