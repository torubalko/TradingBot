using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class TextChangeType : ITextChangeType, IKeyedObject
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string shB;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string Oh9;

	internal static TextChangeType i2n;

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return shB;
		}
		[CompilerGenerated]
		private set
		{
			shB = value;
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return Oh9;
		}
		[CompilerGenerated]
		private set
		{
			Oh9 = value;
		}
	}

	public TextChangeType(string key, string description)
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

	internal static bool c2A()
	{
		return i2n == null;
	}

	internal static TextChangeType t2V()
	{
		return i2n;
	}
}
