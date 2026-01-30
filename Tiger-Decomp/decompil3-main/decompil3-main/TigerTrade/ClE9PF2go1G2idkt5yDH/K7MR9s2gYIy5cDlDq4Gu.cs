using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using ECOEgqlSad8NUJZ2Dr9n;
using jS3Y2j9pTQRy0FnOknFG;
using MhuHG52gko4W6kV6Mqnl;
using Mjla299M344ZWOF3ROHJ;
using TigerTrade.Chart.Objects.Common;
using TuAMtrl1Nd3XoZQQUXf0;
using VNNS7k9MJWTB0F2UfSVa;

namespace ClE9PF2go1G2idkt5yDH;

internal class K7MR9s2gYIy5cDlDq4Gu<HSbh7nlaLlg3kfxDpnxS> : poLM8x9MPUgdGZpBmXt9 where HSbh7nlaLlg3kfxDpnxS : UIElement, poLM8x9MPUgdGZpBmXt9
{
	private readonly Func<HSbh7nlaLlg3kfxDpnxS> KIN2glDqsVL;

	private readonly ContentControl uZk2g463Sk3;

	private Lazy<HSbh7nlaLlg3kfxDpnxS> fO52gDmesHE;

	private bool rp62gboWkEK;

	private static object Ie6P2N4ApURRdVFLl5wF;

	public DependencyObject Parent => ARQ2gaw5ZEA().Parent;

	public event Action<rl9GXq9MFNRC5VT7hPqj> Command
	{
		[CompilerGenerated]
		add
		{
			Action<rl9GXq9MFNRC5VT7hPqj> action = this.Command;
			Action<rl9GXq9MFNRC5VT7hPqj> action2;
			do
			{
				action2 = action;
				Action<rl9GXq9MFNRC5VT7hPqj> value2 = (Action<rl9GXq9MFNRC5VT7hPqj>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.Command, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<rl9GXq9MFNRC5VT7hPqj> action = this.Command;
			Action<rl9GXq9MFNRC5VT7hPqj> action2;
			do
			{
				action2 = action;
				Action<rl9GXq9MFNRC5VT7hPqj> value2 = (Action<rl9GXq9MFNRC5VT7hPqj>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.Command, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	[SpecialName]
	public HSbh7nlaLlg3kfxDpnxS ARQ2gaw5ZEA()
	{
		return fO52gDmesHE.Value;
	}

	public K7MR9s2gYIy5cDlDq4Gu(Func<HSbh7nlaLlg3kfxDpnxS> P_0, ContentControl P_1)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		rp62gboWkEK = true;
		base._002Ector();
		KIN2glDqsVL = P_0;
		uZk2g463Sk3 = P_1;
		fO52gDmesHE = new Lazy<HSbh7nlaLlg3kfxDpnxS>(lnc2gvjJyTM);
	}

	private HSbh7nlaLlg3kfxDpnxS lnc2gvjJyTM()
	{
		Func<HSbh7nlaLlg3kfxDpnxS> kIN2glDqsVL = KIN2glDqsVL;
		HSbh7nlaLlg3kfxDpnxS obj = ((kIN2glDqsVL != null) ? kIN2glDqsVL() : null);
		obj.Command += AqP2gBcmFR2;
		return obj;
	}

	private void AqP2gBcmFR2(rl9GXq9MFNRC5VT7hPqj P_0)
	{
		this.Command?.Invoke(P_0);
	}

	public void Open(ObjectBase P_0, jjKtVJ9pUSOpdg38tqnP P_1)
	{
		int num;
		if (rp62gboWkEK)
		{
			uZk2g463Sk3.Content = ARQ2gaw5ZEA();
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
			{
				num = 2;
			}
			goto IL_0009;
		}
		goto IL_00dc;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 2:
			{
				qAN2ZB2gNPbBAbr7ZB2I qAN2ZB2gNPbBAbr7ZB2I = new qAN2ZB2gNPbBAbr7ZB2I
				{
					IsOpen = true,
					StaysOpen = true,
					Placement = PlacementMode.RelativePoint,
					PlacementTarget = P_1,
					HorizontalOffset = 20.0,
					VerticalOffset = 40.0
				};
				uZk2g463Sk3.Content = qAN2ZB2gNPbBAbr7ZB2I;
				if (!(ARQ2gaw5ZEA().Parent is qAN2ZB2gNPbBAbr7ZB2I))
				{
					qAN2ZB2gNPbBAbr7ZB2I.Child = ARQ2gaw5ZEA();
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
					{
						num = 1;
					}
				}
				else
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
					{
						num = 0;
					}
				}
				continue;
			}
			}
			break;
		}
		rp62gboWkEK = false;
		goto IL_00dc;
		IL_00dc:
		ARQ2gaw5ZEA().Open(P_0, P_1);
		num = 3;
		goto IL_0009;
	}

	public void Close()
	{
		ARQ2gaw5ZEA().Close();
	}

	static K7MR9s2gYIy5cDlDq4Gu()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool eNtXha4AunfrPUepoKQL()
	{
		return Ie6P2N4ApURRdVFLl5wF == null;
	}

	internal static object nqBUgU4Az7wcdW5uJ0Y8()
	{
		return Ie6P2N4ApURRdVFLl5wF;
	}
}
