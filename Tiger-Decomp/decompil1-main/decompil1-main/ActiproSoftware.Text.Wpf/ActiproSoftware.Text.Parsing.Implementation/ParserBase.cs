using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Parsing.Implementation;

public abstract class ParserBase : IParser, IKeyedObject
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string dTS;

	internal static ParserBase u1R;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return dTS;
		}
		[CompilerGenerated]
		protected set
		{
			dTS = value;
		}
	}

	protected ParserBase(string key)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (key == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5194));
		}
		Key = key;
	}

	public abstract IParseData Parse(IParseRequest request);

	internal static bool v10()
	{
		return u1R == null;
	}

	internal static ParserBase E1N()
	{
		return u1R;
	}
}
