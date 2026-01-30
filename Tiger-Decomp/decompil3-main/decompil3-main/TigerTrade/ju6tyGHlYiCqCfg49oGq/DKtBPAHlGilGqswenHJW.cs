using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace ju6tyGHlYiCqCfg49oGq;

public class DKtBPAHlGilGqswenHJW<xWQLgAliNteTL461eTrN> : ObservableCollection<xWQLgAliNteTL461eTrN>, IDisposable
{
	private readonly DispatcherTimer hFLHlBXy0GZ;

	private NotifyCollectionChangedEventArgs b38HlahLhLD;

	internal static object H7aUoQD1iWfAYtN7jWPx;

	public DKtBPAHlGilGqswenHJW(int P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		hFLHlBXy0GZ = new DispatcherTimer
		{
			Interval = TimeSpan.FromMilliseconds(P_0)
		};
		hFLHlBXy0GZ.Tick += PmGHlov3mj7;
	}

	protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs P_0)
	{
		if (P_0.Action == NotifyCollectionChangedAction.Reset)
		{
			goto IL_005c;
		}
		if (P_0.Action == NotifyCollectionChangedAction.Add)
		{
			goto IL_00cf;
		}
		goto IL_00e2;
		IL_00cf:
		IList newItems = P_0.NewItems;
		if (newItems != null && newItems.Count == 1)
		{
			goto IL_005c;
		}
		goto IL_00e2;
		IL_00e2:
		int num;
		if (!hFLHlBXy0GZ.IsEnabled)
		{
			b38HlahLhLD = P_0;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
			{
				num = 1;
			}
		}
		else
		{
			num = 3;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 != 0)
			{
				num = 3;
			}
		}
		goto IL_0009;
		IL_005c:
		if (hFLHlBXy0GZ.IsEnabled)
		{
			hFLHlBXy0GZ.Stop();
			b38HlahLhLD = null;
		}
		base.OnCollectionChanged(P_0);
		num = 4;
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 5:
				break;
			case 1:
				hFLHlBXy0GZ.Start();
				return;
			case 2:
				goto IL_00cf;
			case 4:
				return;
			case 3:
				b38HlahLhLD = new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
				{
					num = 0;
				}
				continue;
			}
			break;
		}
		goto IL_005c;
	}

	private void PmGHlov3mj7(object P_0, EventArgs P_1)
	{
		hFLHlBXy0GZ.Stop();
		base.OnCollectionChanged(b38HlahLhLD);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		b38HlahLhLD = null;
	}

	protected override void ClearItems()
	{
		CheckReentrancy();
		base.Items.Clear();
		OnPropertyChanged(new PropertyChangedEventArgs(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--871424829 ^ 0x33F1F945)));
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
				return;
			case 1:
				OnPropertyChanged(new PropertyChangedEventArgs(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-448941864 ^ -449009058)));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void QWTHlvtr5Xn(IEnumerable<xWQLgAliNteTL461eTrN> P_0)
	{
		CheckReentrancy();
		foreach (xWQLgAliNteTL461eTrN item in P_0)
		{
			base.Items.Add(item);
		}
		OnPropertyChanged(new PropertyChangedEventArgs(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--871424829 ^ 0x33F1F945)));
		OnPropertyChanged(new PropertyChangedEventArgs(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1606927328 ^ -1606867290)));
		OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
	}

	public void Dispose()
	{
		hFLHlBXy0GZ.Tick -= PmGHlov3mj7;
		hFLHlBXy0GZ.Stop();
	}

	static DKtBPAHlGilGqswenHJW()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool wkPXl5D1lDriiFKNjM8e()
	{
		return H7aUoQD1iWfAYtN7jWPx == null;
	}

	internal static object yoI7jOD14BxUNqVuAud4()
	{
		return H7aUoQD1iWfAYtN7jWPx;
	}
}
