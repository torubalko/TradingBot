namespace ActiproSoftware.Windows.Controls.Docking;

public interface IDockTarget
{
	DockHost DockHost { get; }

	DockSite DockSite { get; }

	DockingWindowState GetState(Side? side);
}
