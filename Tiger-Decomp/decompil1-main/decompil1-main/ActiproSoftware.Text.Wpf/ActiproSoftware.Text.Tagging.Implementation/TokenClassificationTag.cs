using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Lexing;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Tagging.Implementation;

public class TokenClassificationTag : IClassificationTag, ITag, ITokenTag
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IClassificationType eAV;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IToken hAB;

	internal static TokenClassificationTag xAs;

	public IClassificationType ClassificationType
	{
		[CompilerGenerated]
		get
		{
			return eAV;
		}
		[CompilerGenerated]
		set
		{
			eAV = value;
		}
	}

	public IToken Token
	{
		[CompilerGenerated]
		get
		{
			return hAB;
		}
		[CompilerGenerated]
		set
		{
			hAB = value;
		}
	}

	public TokenClassificationTag()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	public TokenClassificationTag(IToken token, IClassificationType classificationType)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		Token = token;
		ClassificationType = classificationType;
	}

	public override string ToString()
	{
		if (ClassificationType != null)
		{
			return GetType().Name + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5660) + ClassificationType.Key + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
		}
		return GetType().Name;
	}

	internal static bool CA4()
	{
		return xAs == null;
	}

	internal static TokenClassificationTag wAu()
	{
		return xAs;
	}
}
