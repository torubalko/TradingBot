namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public interface ICollectionItemPropertyDescriptor
{
	bool CanRemove { get; }

	bool Remove();
}
