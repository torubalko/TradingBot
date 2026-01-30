using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Tagging.Implementation;

public class ClassificationTag : IClassificationTag, ITag
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IClassificationType a9O;

	internal static ClassificationTag sAd;

	public IClassificationType ClassificationType
	{
		[CompilerGenerated]
		get
		{
			return a9O;
		}
		[CompilerGenerated]
		set
		{
			a9O = value;
		}
	}

	public ClassificationTag()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	public ClassificationTag(IClassificationType classificationType)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector();
		ClassificationType = classificationType;
	}

	public override string ToString()
	{
		if (ClassificationType == null)
		{
			return GetType().Name;
		}
		return GetType().Name + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5660) + ClassificationType.Key + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	internal static bool rAi()
	{
		return sAd == null;
	}

	internal static ClassificationTag UAt()
	{
		return sAd;
	}
}
