using System;

namespace MailKit.Search;

public class AnnotationSearchQuery : SearchQuery
{
	public AnnotationEntry Entry { get; private set; }

	public AnnotationAttribute Attribute { get; private set; }

	public string Value { get; private set; }

	public AnnotationSearchQuery(AnnotationEntry entry, AnnotationAttribute attribute, string value)
		: base(SearchTerm.Annotation)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (attribute.Name != "value")
		{
			throw new ArgumentException("Only the \"value\", \"value.priv\", and \"value.shared\" attributes can be searched.", "attribute");
		}
		Attribute = attribute;
		Entry = entry;
		Value = value;
	}
}
