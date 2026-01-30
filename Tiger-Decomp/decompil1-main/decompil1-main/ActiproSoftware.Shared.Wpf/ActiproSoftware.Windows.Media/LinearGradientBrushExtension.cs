using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media;

[MarkupExtensionReturnType(typeof(LinearGradientBrush))]
public class LinearGradientBrushExtension : MarkupExtension
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int XQ3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private double oQt;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Color aQJ;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private LinearGradientType CQ9;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Color NQh;

	private static LinearGradientBrushExtension m7C;

	public int AdditionalStopCount
	{
		[CompilerGenerated]
		get
		{
			return XQ3;
		}
		[CompilerGenerated]
		set
		{
			XQ3 = value;
		}
	}

	[DefaultValue(0.0)]
	public double Angle
	{
		[CompilerGenerated]
		get
		{
			return oQt;
		}
		[CompilerGenerated]
		set
		{
			oQt = value;
		}
	}

	[ConstructorArgument("endColor")]
	public Color EndColor
	{
		[CompilerGenerated]
		get
		{
			return aQJ;
		}
		[CompilerGenerated]
		set
		{
			aQJ = value;
		}
	}

	public LinearGradientType GradientType
	{
		[CompilerGenerated]
		get
		{
			return CQ9;
		}
		[CompilerGenerated]
		set
		{
			CQ9 = value;
		}
	}

	[ConstructorArgument("startColor")]
	public Color StartColor
	{
		[CompilerGenerated]
		get
		{
			return NQh;
		}
		[CompilerGenerated]
		set
		{
			NQh = value;
		}
	}

	public LinearGradientBrushExtension()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(Colors.Black, Colors.White);
	}

	public LinearGradientBrushExtension(Color startColor, Color endColor)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		StartColor = startColor;
		EndColor = endColor;
	}

	private static LinearGradientBrush SQS(Color P_0, Color P_1, LinearGradientType P_2, double P_3, int P_4)
	{
		if (P_4 < 0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106648), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106690));
		}
		GradientStopCollection gradientStopCollection = new GradientStopCollection();
		gradientStopCollection.Add(new GradientStop(P_0, 0.0));
		if (P_4 != 0)
		{
			int num = P_4 + 1;
			double num2 = 1.0 / (double)num;
			double num3 = num2;
			for (int i = 0; i < num; i++)
			{
				if (i == num - 1)
				{
					num3 = 1.0;
				}
				if (i % 2 == 0)
				{
					gradientStopCollection.Add(new GradientStop(P_1, num3));
				}
				else
				{
					gradientStopCollection.Add(new GradientStop(P_0, num3));
				}
				num3 += num2;
			}
		}
		else
		{
			gradientStopCollection.Add(new GradientStop(P_1, 1.0));
		}
		return P_2 switch
		{
			LinearGradientType.LeftToRight => new LinearGradientBrush(gradientStopCollection, new Point(0.0, 0.5), new Point(1.0, 0.5)), 
			LinearGradientType.RightToLeft => new LinearGradientBrush(gradientStopCollection, new Point(1.0, 0.5), new Point(0.0, 0.5)), 
			LinearGradientType.TopToBottom => new LinearGradientBrush(gradientStopCollection, new Point(0.5, 0.0), new Point(0.5, 1.0)), 
			LinearGradientType.BottomToTop => new LinearGradientBrush(gradientStopCollection, new Point(0.5, 1.0), new Point(0.5, 0.0)), 
			LinearGradientType.TopLeftToBottomRight => new LinearGradientBrush(gradientStopCollection, new Point(0.0, 0.0), new Point(1.0, 1.0)), 
			LinearGradientType.BottomRightToTopLeft => new LinearGradientBrush(gradientStopCollection, new Point(1.0, 1.0), new Point(0.0, 0.0)), 
			LinearGradientType.TopRightToBottomLeft => new LinearGradientBrush(gradientStopCollection, new Point(1.0, 0.0), new Point(0.0, 1.0)), 
			LinearGradientType.BottomLeftToTopRight => new LinearGradientBrush(gradientStopCollection, new Point(0.0, 1.0), new Point(1.0, 0.0)), 
			_ => new LinearGradientBrush(gradientStopCollection, P_3), 
		};
	}

	public static LinearGradientBrush CreateBrush(Color startColor, Color endColor, double angle)
	{
		return SQS(startColor, endColor, LinearGradientType.CustomAngle, angle, 0);
	}

	public static LinearGradientBrush CreateBrush(Color startColor, Color endColor, double angle, int additionalStopCount)
	{
		return SQS(startColor, endColor, LinearGradientType.CustomAngle, angle, additionalStopCount);
	}

	public static LinearGradientBrush CreateBrush(Color startColor, Color endColor, LinearGradientType gradientType)
	{
		return SQS(startColor, endColor, gradientType, double.NaN, 0);
	}

	public static LinearGradientBrush CreateBrush(Color startColor, Color endColor, LinearGradientType gradientType, int additionalStopCount)
	{
		return SQS(startColor, endColor, gradientType, double.NaN, additionalStopCount);
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return SQS(StartColor, EndColor, GradientType, Angle, AdditionalStopCount);
	}

	internal static bool p7R()
	{
		return m7C == null;
	}

	internal static LinearGradientBrushExtension y79()
	{
		return m7C;
	}
}
