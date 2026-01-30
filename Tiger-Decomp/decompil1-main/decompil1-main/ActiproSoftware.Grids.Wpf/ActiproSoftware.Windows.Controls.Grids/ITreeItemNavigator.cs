namespace ActiproSoftware.Windows.Controls.Grids;

public interface ITreeItemNavigator
{
	object CurrentItem { get; }

	int Depth { get; }

	bool GoToCommonAncestor(object otherItem);

	bool GoToFirstChild();

	bool GoToFirstVisible();

	bool GoToLastVisible();

	bool GoToNextSibling();

	bool GoToNextVisible();

	bool GoToParent();

	bool GoToPreviousSibling();

	bool GoToPreviousVisible();
}
