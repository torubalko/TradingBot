using System;
using System.Windows;
using System.Windows.Controls;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace UIKit.Core;

public class Progress : Control
{
	public static readonly DependencyProperty p9wiPLhR3rD;

	internal static Progress b1gcWYXYXnw3kTryYjQk;

	public bool IsActive
	{
		get
		{
			return (bool)GetValue(p9wiPLhR3rD);
		}
		set
		{
			SetValue(p9wiPLhR3rD, flag);
		}
	}

	public Progress()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		VisualStateManager.GoToState(this, OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x60620FC1 ^ 0x60620AEB), useTransitions: true);
	}

	static Progress()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_8e3e4338deec43e48dad5ad47c3daa41 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
				RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
				p9wiPLhR3rD = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x50C1C840 ^ 0x50C1C98C), sihjrSXYQq1ZTZqKKlvT(amh25mXYEE9vAShXdG7e(16777220)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554462)));
				return;
			}
		}
	}

	internal static bool EP544gXYcjprO5gEu1Pk()
	{
		return b1gcWYXYXnw3kTryYjQk == null;
	}

	internal static Progress PQhZpKXYjdHVOhXEQAyC()
	{
		return b1gcWYXYXnw3kTryYjQk;
	}

	internal static RuntimeTypeHandle amh25mXYEE9vAShXdG7e(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static Type sihjrSXYQq1ZTZqKKlvT(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
