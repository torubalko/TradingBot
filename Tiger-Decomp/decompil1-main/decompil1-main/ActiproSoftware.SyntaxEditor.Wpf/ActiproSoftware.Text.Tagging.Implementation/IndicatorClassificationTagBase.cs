using ActiproSoftware.Internal;

namespace ActiproSoftware.Text.Tagging.Implementation;

public abstract class IndicatorClassificationTagBase : IndicatorTagBase, IClassificationTag, ITag
{
	private static IndicatorClassificationTagBase X5v;

	public abstract IClassificationType ClassificationType { get; }

	protected IndicatorClassificationTagBase()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool l5f()
	{
		return X5v == null;
	}

	internal static IndicatorClassificationTagBase G5i()
	{
		return X5v;
	}
}
