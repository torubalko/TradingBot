using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media.Animation;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Internal;

internal class tTD
{
	private class A7v
	{
		private WeakReference lsA;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private double psv;

		internal static A7v OMF;

		public double ControlKeyDownOpacity
		{
			[CompilerGenerated]
			get
			{
				return psv;
			}
			[CompilerGenerated]
			private set
			{
				psv = num;
			}
		}

		public A7v(UIElement P_0, double P_1)
		{
			grA.DaB7cz();
			base._002Ector();
			if (P_0 == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(193602));
			}
			lsA = new WeakReference(P_0);
			ControlKeyDownOpacity = P_1;
		}

		[SpecialName]
		public UIElement Ose()
		{
			if (lsA != null)
			{
				if (lsA.IsAlive)
				{
					return lsA.Target as UIElement;
				}
				lsA = null;
			}
			return null;
		}

		internal static bool FM9()
		{
			return OMF == null;
		}

		internal static A7v UMJ()
		{
			return OMF;
		}
	}

	private enum l74
	{

	}

	private List<A7v> EjK;

	private BTZ Bjf;

	private l74 cjD;

	private static tTD TlD;

	public tTD(SyntaxEditor P_0)
	{
		grA.DaB7cz();
		cjD = (l74)0;
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8238));
		}
		Bjf = P_0.FGR().PLW(Q7Z.tqM(193546), Roz);
	}

	private static bool aoh()
	{
		if (BrowserInteropHelper.IsBrowserHosted)
		{
			return false;
		}
		ModifierKeys modifierKeys = vAE.A0o();
		bool flag = (modifierKeys & ModifierKeys.Control) == ModifierKeys.Control;
		bool flag2 = (modifierKeys & ModifierKeys.Alt) == ModifierKeys.Alt;
		return flag && !flag2;
	}

	private int JoN(UIElement P_0)
	{
		int num = -1;
		if (EjK != null)
		{
			int num2 = EjK.Count - 1;
			int num3 = 1;
			if (!elB())
			{
				int num4 = default(int);
				num3 = num4;
			}
			switch (num3)
			{
			default:
			{
				int result = default(int);
				return result;
			}
			case 1:
				break;
			}
			while (num2 >= 0)
			{
				UIElement uIElement = EjK[num2].Ose();
				if (uIElement == null)
				{
					EjK.RemoveAt(num2);
					if (num != -1)
					{
						num--;
					}
				}
				else if (uIElement == P_0)
				{
					num = num2;
				}
				num2--;
			}
		}
		return num;
	}

	private static bool zod(KeyEventArgs P_0)
	{
		Key key = P_0.Key;
		Key key2 = key;
		if ((uint)(key2 - 118) > 3u)
		{
			return false;
		}
		return true;
	}

	private void Roz()
	{
		if (aoh())
		{
			AjP();
		}
		else
		{
			sjW();
		}
	}

	private void sjW()
	{
		if (cjD == (l74)0)
		{
			return;
		}
		cjD = (l74)0;
		if (EjK == null)
		{
			return;
		}
		for (int num = EjK.Count - 1; num >= 0; num--)
		{
			UIElement uIElement = EjK[num].Ose();
			if (uIElement != null)
			{
				KjE(uIElement, 1.0, 100);
			}
			else
			{
				EjK.RemoveAt(num);
			}
		}
	}

	private void AjP()
	{
		if (cjD == (l74)2)
		{
			return;
		}
		cjD = (l74)2;
		if (EjK == null)
		{
			return;
		}
		for (int num = EjK.Count - 1; num >= 0; num--)
		{
			UIElement uIElement = EjK[num].Ose();
			if (uIElement != null)
			{
				KjE(uIElement, EjK[num].ControlKeyDownOpacity, 200);
			}
			else
			{
				EjK.RemoveAt(num);
			}
		}
	}

	private static void KjE(UIElement P_0, double P_1, int P_2)
	{
		if (P_0.Opacity != P_1)
		{
			DoubleAnimation doubleAnimation = new DoubleAnimation();
			doubleAnimation.To = P_1;
			doubleAnimation.Duration = new Duration(TimeSpan.FromMilliseconds(P_2));
			doubleAnimation.FillBehavior = FillBehavior.HoldEnd;
			P_0.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
		}
	}

	private void bjc()
	{
		if (cjD == (l74)0)
		{
			cjD = (l74)1;
			if (!Bjf.IsEnabled)
			{
				Bjf.Start(500);
			}
		}
	}

	public void sja()
	{
		sjW();
	}

	public void wjx(KeyEventArgs P_0)
	{
		if (zod(P_0))
		{
			if (aoh())
			{
				bjc();
			}
			else
			{
				sjW();
			}
		}
	}

	public void ojG(UIElement P_0, double P_1)
	{
		if (P_0 == null || P_1 == 1.0)
		{
			return;
		}
		if (EjK == null)
		{
			EjK = new List<A7v>();
			int num = 0;
			if (cl0() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		int num3 = JoN(P_0);
		if (num3 == -1)
		{
			EjK.Add(new A7v(P_0, P_1));
		}
		Bjf.Stop();
	}

	public void UjX(UIElement P_0)
	{
		if (P_0 != null)
		{
			int num = JoN(P_0);
			if (num != -1)
			{
				EjK.RemoveAt(num);
			}
		}
	}

	internal static bool elB()
	{
		return TlD == null;
	}

	internal static tTD cl0()
	{
		return TlD;
	}
}
