using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Windows.Controls.Rendering;

namespace ActiproSoftware.Internal;

internal class A0 : Panel
{
	private CanvasControl Ier;

	private IQ mes;

	private Rect Bek;

	internal static A0 V07;

	public A0(HTX P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		Se0(P_0);
	}

	private void Se0(HTX P_0)
	{
		UIElementCollection uIElementCollection = this.v0D();
		Ier = P_0.aAY();
		if (Ier != null)
		{
			uIElementCollection.Add(Ier);
		}
		mes = P_0.ow4();
		if (mes != null)
		{
			uIElementCollection.Add(mes);
		}
	}

	protected override Size ArrangeOverride(Size P_0)
	{
		int num = 1;
		Rect rect = default(Rect);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					Bek = rect;
					if (mes != null)
					{
						mes.Arrange(Bek);
					}
					if (Ier != null)
					{
						Ier.Arrange(rect);
					}
					return P_0;
				case 1:
					break;
				}
				rect = new Rect(default(Point), P_0);
				num2 = 0;
			}
			while (p0q() == null);
		}
	}

	[SpecialName]
	public Rect IeB()
	{
		return Bek;
	}

	protected override Size MeasureOverride(Size P_0)
	{
		double width = P_0.Width;
		double height = P_0.Height;
		if (Ier != null)
		{
			Ier.Measure(P_0);
		}
		if (mes != null)
		{
			mes.Measure(P_0);
			int num = 0;
			if (p0q() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		Size result = default(Size);
		if (!double.IsPositiveInfinity(P_0.Width))
		{
			result.Width = Math.Max(result.Width, P_0.Width);
		}
		if (!double.IsPositiveInfinity(P_0.Height))
		{
			result.Height = Math.Max(result.Height, P_0.Height);
		}
		return result;
	}

	internal static bool w0n()
	{
		return V07 == null;
	}

	internal static A0 p0q()
	{
		return V07;
	}
}
