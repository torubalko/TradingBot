namespace ActiproSoftware.Windows.Controls.Popups;

internal interface IPopupAnchor
{
	bool IsPopupOpen { get; set; }

	bool PopupStaysOpen { get; }

	bool SupportsAltDownToOpen { get; }
}
