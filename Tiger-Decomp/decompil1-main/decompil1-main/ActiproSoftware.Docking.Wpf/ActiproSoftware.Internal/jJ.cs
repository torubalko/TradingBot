using System.Collections.Generic;
using ActiproSoftware.Windows.Controls.Docking;

namespace ActiproSoftware.Internal;

internal interface jJ : wH, lX
{
	bool CanCascade { get; }

	bool CanTile { get; }

	MdiKind Kind { get; }

	DockingWindow PrimaryWindow { get; }

	void AddRange(IEnumerable<DockingWindow> P_0);

	bool BringToFront(DockingWindow P_0);

	void Cascade();

	jJ CloneForFloatingDockHost();

	void DetachFromPrimaryDockHost();

	IDockTarget GetDefaultDockTarget();

	int GetIndexInContainer(DockingWindow P_0);

	IList<DockingWindow> GetDocuments();

	void Remove(DockingWindow P_0, bool P_1);

	bool RestoreToDefaultLocation(DockingWindow P_0);

	void TileHorizontally();

	void TileVertically();

	void UpdateIsEmpty();
}
