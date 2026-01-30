using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

public class ClassificationType : IClassificationType, IKeyedObject
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string SmQ;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string Cmn;

	private static ClassificationType lUR;

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return SmQ;
		}
		[CompilerGenerated]
		private set
		{
			SmQ = value;
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return Cmn;
		}
		[CompilerGenerated]
		private set
		{
			Cmn = value;
		}
	}

	public ClassificationType(string key)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(key, key);
	}

	public ClassificationType(string key, string description)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (key == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5194));
		}
		if (description == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6304));
		}
		Key = key;
		Description = description;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is IClassificationType classificationType))
		{
			return false;
		}
		return Key.Equals(classificationType.Key);
	}

	public override int GetHashCode()
	{
		return Key.GetHashCode();
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8624), new object[2]
		{
			GetType().Name,
			Key
		});
	}

	internal static bool pU0()
	{
		return lUR == null;
	}

	internal static ClassificationType VUN()
	{
		return lUR;
	}
}
