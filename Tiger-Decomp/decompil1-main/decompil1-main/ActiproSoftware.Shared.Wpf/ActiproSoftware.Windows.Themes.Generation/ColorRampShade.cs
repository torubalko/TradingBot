using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using ActiproSoftware.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes.Generation;

internal class ColorRampShade : IColorRampShade
{
	private UIColor LeD;

	private Color? IeP;

	internal const int MinShadeNumber = 0;

	internal const int MaxShadeNumber = 1000;

	internal const int FullShadeStep = 100;

	internal const int HalfShadeStep = 50;

	internal const int QuarterShadeStep = 25;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string eeG;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string Me1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int Yez;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IColorRamp E7c;

	private static ColorRampShade Jtd;

	public double Brightness => LeD.HsbBrightness;

	public Color Color => LeD.ToColor();

	public string ContrastName
	{
		[CompilerGenerated]
		get
		{
			return eeG;
		}
		[CompilerGenerated]
		private set
		{
			eeG = value;
		}
	}

	public Color ForegroundColor
	{
		get
		{
			if (!IeP.HasValue)
			{
				IeP = GetForegroundColor(1.0);
			}
			return IeP.Value;
		}
	}

	public bool IsLight => LeD.IsLight;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return Me1;
		}
		[CompilerGenerated]
		private set
		{
			Me1 = value;
		}
	}

	public int Number
	{
		[CompilerGenerated]
		get
		{
			return Yez;
		}
		[CompilerGenerated]
		private set
		{
			Yez = value;
		}
	}

	public IColorRamp Ramp
	{
		[CompilerGenerated]
		get
		{
			return E7c;
		}
		[CompilerGenerated]
		private set
		{
			E7c = value;
		}
	}

	public ColorRampShade(IColorRamp ramp, UIColor color, ShadeName shadeName, bool isDarkTheme)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(ramp, color, (int)shadeName, shadeName.ToString(), shadeName.ToContrastName(isDarkTheme).ToString());
	}

	public ColorRampShade(IColorRamp ramp, UIColor color, int shadeNumber)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(ramp, color, shadeNumber, shadeNumber.ToString(), null);
	}

	public ColorRampShade(IColorRamp ramp, UIColor color, int shadeNumber, string shadeName, string shadeContrastName)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (ramp == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102066));
		}
		if (string.IsNullOrEmpty(shadeName))
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102078));
		}
		Ramp = ramp;
		LeD = color;
		Number = CoerceShadeNumber(shadeNumber);
		Name = shadeName;
		ContrastName = shadeContrastName;
	}

	internal static int CoerceShadeNumber(int shadeNumber)
	{
		return Math.Max(0, Math.Min(1000, shadeNumber));
	}

	public Color GetForegroundColor(double contrastPercentage)
	{
		Color color;
		if (IsLight)
		{
			UIColor uIColor = UIColor.FromColor(Ramp.Darkest.Color);
			color = ((uIColor.W3CBrightness > 100) ? Colors.Black : uIColor.ToColor());
		}
		else
		{
			color = Colors.White;
		}
		if (contrastPercentage < 1.0)
		{
			contrastPercentage = Math.Max(0.0, Math.Min(1.0, contrastPercentage));
			color = UIColor.FromMix(Color, color, contrastPercentage).ToColor();
		}
		return color;
	}

	public override string ToString()
	{
		return LeD.ToWebColor();
	}

	internal static bool Utv()
	{
		return Jtd == null;
	}

	internal static ColorRampShade uta()
	{
		return Jtd;
	}
}
