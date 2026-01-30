using System;
using System.Collections;
using System.Collections.Generic;

namespace MimeKit.Text;

public class HtmlAttributeCollection : IEnumerable<HtmlAttribute>, IEnumerable
{
	public static readonly HtmlAttributeCollection Empty = new HtmlAttributeCollection();

	private readonly List<HtmlAttribute> attributes = new List<HtmlAttribute>();

	public int Count => attributes.Count;

	public HtmlAttribute this[int index] => attributes[index];

	public HtmlAttributeCollection(IEnumerable<HtmlAttribute> collection)
	{
		attributes = new List<HtmlAttribute>(collection);
	}

	internal HtmlAttributeCollection()
	{
		attributes = new List<HtmlAttribute>();
	}

	internal void Add(HtmlAttribute attribute)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		attributes.Add(attribute);
	}

	public IEnumerator<HtmlAttribute> GetEnumerator()
	{
		return attributes.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return attributes.GetEnumerator();
	}
}
