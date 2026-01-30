namespace ActiproSoftware.Windows;

public interface ILogicalParent
{
	void AddLogicalChild(object child);

	void RemoveLogicalChild(object child);
}
