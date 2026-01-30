using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Searching.Implementation;

public class DefaultSearchPatternProviderFactory : ISearchPatternProviderFactory
{
	internal static DefaultSearchPatternProviderFactory rV8;

	public virtual ISearchPatternProviderCollection CreateProviders()
	{
		ISearchPatternProviderCollection searchPatternProviderCollection = new SearchPatternProviderCollection();
		searchPatternProviderCollection.Add(SearchPatternProviders.Normal);
		searchPatternProviderCollection.Add(SearchPatternProviders.RegularExpression);
		searchPatternProviderCollection.Add(SearchPatternProviders.Wildcard);
		searchPatternProviderCollection.Add(SearchPatternProviders.Acronym);
		searchPatternProviderCollection.Add(SearchPatternProviders.Shorthand);
		return searchPatternProviderCollection;
	}

	public DefaultSearchPatternProviderFactory()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool OVL()
	{
		return rV8 == null;
	}

	internal static DefaultSearchPatternProviderFactory kVs()
	{
		return rV8;
	}
}
