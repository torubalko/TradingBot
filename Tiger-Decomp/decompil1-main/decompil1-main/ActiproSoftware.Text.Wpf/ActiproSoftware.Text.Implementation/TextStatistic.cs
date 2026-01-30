using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class TextStatistic : ITextStatistic, IKeyedObject
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string SdS;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string ddV;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object cdB;

	private static TextStatistic I24;

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return SdS;
		}
		[CompilerGenerated]
		set
		{
			SdS = value;
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return ddV;
		}
		[CompilerGenerated]
		set
		{
			ddV = value;
		}
	}

	public string StringValue
	{
		get
		{
			if (Value is double)
			{
				return ((double)Value).ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9266), CultureInfo.CurrentCulture);
			}
			if (Value != null)
			{
				return Value.ToString();
			}
			return string.Empty;
		}
	}

	public object Value
	{
		[CompilerGenerated]
		get
		{
			return cdB;
		}
		[CompilerGenerated]
		set
		{
			cdB = value;
		}
	}

	public TextStatistic()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool f2u()
	{
		return I24 == null;
	}

	internal static TextStatistic W2R()
	{
		return I24;
	}
}
