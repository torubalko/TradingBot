using ActiproSoftware.Text.Searching.Implementation;

namespace ActiproSoftware.Text.Searching;

public static class SearchPatternProviders
{
	private static ISearchPatternProvider oAW;

	private static ISearchPatternProvider nA5;

	private static ISearchPatternProvider jA6;

	private static ISearchPatternProvider vAZ;

	private static ISearchPatternProvider FA0;

	private static SearchPatternProviders hVq;

	public static ISearchPatternProvider Acronym
	{
		get
		{
			if (oAW == null)
			{
				oAW = new AcronymSearchPatternProvider();
			}
			return oAW;
		}
	}

	public static ISearchPatternProvider Normal
	{
		get
		{
			if (nA5 == null)
			{
				nA5 = new NormalSearchPatternProvider();
			}
			return nA5;
		}
	}

	public static ISearchPatternProvider RegularExpression
	{
		get
		{
			if (jA6 == null)
			{
				jA6 = new RegexSearchPatternProvider();
			}
			return jA6;
		}
	}

	public static ISearchPatternProvider Shorthand
	{
		get
		{
			if (vAZ == null)
			{
				vAZ = new ShorthandSearchPatternProvider();
			}
			return vAZ;
		}
	}

	public static ISearchPatternProvider Wildcard
	{
		get
		{
			if (FA0 == null)
			{
				FA0 = new WildcardSearchPatternProvider();
			}
			return FA0;
		}
	}

	internal static bool yVc()
	{
		return hVq == null;
	}

	internal static SearchPatternProviders HVf()
	{
		return hVq;
	}
}
