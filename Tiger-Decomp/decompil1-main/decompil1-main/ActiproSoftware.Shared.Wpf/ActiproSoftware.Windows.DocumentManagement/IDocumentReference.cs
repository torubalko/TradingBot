using System;
using System.Windows.Media;

namespace ActiproSoftware.Windows.DocumentManagement;

public interface IDocumentReference
{
	string Description { get; set; }

	ImageSource ImageSourceLarge { get; set; }

	ImageSource ImageSourceSmall { get; set; }

	bool IsPinnedRecentDocument { get; set; }

	DateTime LastOpenedDateTime { get; set; }

	Uri Location { get; set; }

	string Name { get; set; }

	object Tag { get; set; }
}
