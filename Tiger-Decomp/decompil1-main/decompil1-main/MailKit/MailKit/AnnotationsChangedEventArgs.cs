using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MailKit;

public class AnnotationsChangedEventArgs : MessageEventArgs
{
	public IList<Annotation> Annotations { get; internal set; }

	public ulong? ModSeq { get; internal set; }

	internal AnnotationsChangedEventArgs(int index)
		: base(index)
	{
	}

	public AnnotationsChangedEventArgs(int index, IEnumerable<Annotation> annotations)
		: base(index)
	{
		if (annotations == null)
		{
			throw new ArgumentNullException("annotations");
		}
		Annotations = new ReadOnlyCollection<Annotation>(annotations.ToArray());
	}
}
