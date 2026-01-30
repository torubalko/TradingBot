using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes.Generation;

internal abstract class ColorRampBase : List<IColorRampShade>, IColorRamp, IEnumerable<IColorRampShade>, IEnumerable
{
	private Dictionary<int, IColorRampShade> Hes;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ColorFamilyName EeL;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string ved;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool ueN;

	private static ColorRampBase Qtw;

	public IColorRampShade Base => this[ShadeName.Base];

	public IColorRampShade Darkest => this[ShadeName.Darkest];

	public ColorFamilyName FamilyName
	{
		[CompilerGenerated]
		get
		{
			return EeL;
		}
		[CompilerGenerated]
		private set
		{
			EeL = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return ved;
		}
		[CompilerGenerated]
		private set
		{
			ved = value;
		}
	}

	protected bool IsDarkTheme
	{
		[CompilerGenerated]
		get
		{
			return ueN;
		}
		[CompilerGenerated]
		private set
		{
			ueN = value;
		}
	}

	public IColorRampShade this[ShadeName shadeName] => GetShade((int)shadeName);

	public ColorRampBase(ColorFamilyName familyName, bool isDarkTheme)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(familyName, isDarkTheme, null);
	}

	public ColorRampBase(ColorFamilyName familyName, bool isDarkTheme, string name)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		FamilyName = familyName;
		IsDarkTheme = isDarkTheme;
		Name = name ?? familyName.ToString();
	}

	internal void AddDefaultShades()
	{
		ShadeName[] array = je6();
		foreach (ShadeName shadeName in array)
		{
			Add(this[shadeName]);
		}
	}

	[SpecialName]
	private static ShadeName[] je6()
	{
		return new ShadeName[9]
		{
			ShadeName.Darkest,
			ShadeName.Darker,
			ShadeName.Dark,
			ShadeName.Dim,
			ShadeName.Base,
			ShadeName.Lit,
			ShadeName.Light,
			ShadeName.Lighter,
			ShadeName.Lightest
		};
	}

	public IColorRampShade GetShade(int shadeNumber)
	{
		if (Hes == null)
		{
			Hes = new Dictionary<int, IColorRampShade>();
		}
		shadeNumber = ColorRampShade.CoerceShadeNumber(shadeNumber);
		if (Hes.TryGetValue(shadeNumber, out var value))
		{
			return value;
		}
		value = GetShadeCore(shadeNumber);
		Hes[shadeNumber] = value;
		return value;
	}

	protected abstract IColorRampShade GetShadeCore(int shadeNumber);

	internal static bool Stk()
	{
		return Qtw == null;
	}

	internal static ColorRampBase FtF()
	{
		return Qtw;
	}
}
