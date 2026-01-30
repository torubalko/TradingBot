using System.Diagnostics.CodeAnalysis;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Products;
using ActiproSoftware.Products.Editors;
using ActiproSoftware.Windows.Controls.Editors.Automation.Peers;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
public abstract class PickerBase : Control
{
	internal static PickerBase Hhu;

	protected PickerBase()
	{
		awj.QuEwGz();
		base._002Ector();
		ActiproLicenseValidator.ValidateLicense(ActiproSoftware.Products.Editors.AssemblyInfo.Instance, GetType(), this);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new PickerBaseAutomationPeer(this);
	}

	internal static bool uhH()
	{
		return Hhu == null;
	}

	internal static PickerBase PhU()
	{
		return Hhu;
	}
}
