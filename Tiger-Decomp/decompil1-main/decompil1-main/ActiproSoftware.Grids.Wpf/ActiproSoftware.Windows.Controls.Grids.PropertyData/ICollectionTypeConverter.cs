namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public interface ICollectionTypeConverter
{
	bool AddItem(IPropertyModel propertyModel, object item);

	bool CanAddItem(IPropertyModel propertyModel);

	object CreateItem(IPropertyModel propertyModel);
}
