using System;

namespace MailKit.Search;

public class OrderByAnnotation : OrderBy
{
	public AnnotationEntry Entry { get; private set; }

	public AnnotationAttribute Attribute { get; private set; }

	public OrderByAnnotation(AnnotationEntry entry, AnnotationAttribute attribute, SortOrder order)
		: base(OrderByType.Annotation, order)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		if (attribute.Name != "value" || attribute.Scope == AnnotationScope.Both)
		{
			throw new ArgumentException("Only the \"value.priv\" and \"value.shared\" attributes can be used for sorting.", "attribute");
		}
		Entry = entry;
		Attribute = attribute;
	}
}
