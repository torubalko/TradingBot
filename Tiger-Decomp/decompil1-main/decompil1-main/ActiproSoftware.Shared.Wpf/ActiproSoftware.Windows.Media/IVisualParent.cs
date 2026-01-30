using System.Windows.Media;

namespace ActiproSoftware.Windows.Media;

public interface IVisualParent
{
	void AddVisualChild(Visual child);

	void RemoveVisualChild(Visual child);
}
