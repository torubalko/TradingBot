using System;
using System.Collections.Generic;

namespace MailKit;

public class Annotation
{
	public AnnotationEntry Entry { get; private set; }

	public Dictionary<AnnotationAttribute, string> Properties { get; private set; }

	public Annotation(AnnotationEntry entry)
	{
		if (entry == null)
		{
			throw new ArgumentNullException("entry");
		}
		Properties = new Dictionary<AnnotationAttribute, string>();
		Entry = entry;
	}
}
