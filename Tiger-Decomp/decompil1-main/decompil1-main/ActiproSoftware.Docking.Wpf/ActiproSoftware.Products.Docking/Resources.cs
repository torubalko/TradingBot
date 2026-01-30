using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.Docking;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
public class Resources
{
	private static ResourceManager kRp;

	private static CultureInfo URs;

	internal static Resources aK8;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (kRp == null)
			{
				kRp = new ResourceManager("ActiproSoftware.Products.Docking.Resources", typeof(Resources).Assembly);
			}
			return kRp;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
	{
		get
		{
			return URs;
		}
		set
		{
			URs = value;
		}
	}

	public static string ExDockingWindowNoDockSiteRegistered => ResourceManager.GetString(vVK.ssH(24302), URs);

	public static string ExDockingWindowTargetNotLinked => ResourceManager.GetString(vVK.ssH(24376), URs);

	public static string ExDockSiteDockingWindowAlreadyRegistered => ResourceManager.GetString(vVK.ssH(24440), URs);

	public static string ExDockSiteNoMdiHost => ResourceManager.GetString(vVK.ssH(24524), URs);

	public static string ExDockSiteNoTargetDockHost => ResourceManager.GetString(vVK.ssH(24566), URs);

	public static string ExDockSiteRegistryAlreadyContainsDockingWindow => ResourceManager.GetString(vVK.ssH(24622), URs);

	public static string ExSplitContainerChildrenCollectionReset => ResourceManager.GetString(vVK.ssH(24718), URs);

	public static string ExSplitContainerSlotResizeRatioMustBeGreaterThanZero => ResourceManager.GetString(vVK.ssH(24800), URs);

	public static string ExToolWindowRequired => ResourceManager.GetString(vVK.ssH(24908), URs);

	public static string ExWorkspaceCannotRemoveFromParent => ResourceManager.GetString(vVK.ssH(24952), URs);

	public static string UIAdvancedTabControlScrollBackwardButtonToolTip => ResourceManager.GetString(vVK.ssH(25022), URs);

	public static string UIAdvancedTabControlScrollForwardButtonToolTip => ResourceManager.GetString(vVK.ssH(25120), URs);

	public static string UIAdvancedTabItemCloseButtonToolTip => ResourceManager.GetString(vVK.ssH(25216), URs);

	public static string UIAdvancedTabItemKeepOpenButtonToolTip => ResourceManager.GetString(vVK.ssH(25290), URs);

	public static string UIAdvancedTabItemToggleLayoutKindButtonToolTip => ResourceManager.GetString(vVK.ssH(25370), URs);

	public static string UICommandActivateNextDocumentText => ResourceManager.GetString(vVK.ssH(25466), URs);

	public static string UICommandActivatePreviousDocumentText => ResourceManager.GetString(vVK.ssH(25536), URs);

	public static string UICommandActivatePrimaryDocumentText => ResourceManager.GetString(vVK.ssH(25614), URs);

	public static string UICommandCloseAllDocumentsText => ResourceManager.GetString(vVK.ssH(25690), URs);

	public static string UICommandCloseAllInContainerText => ResourceManager.GetString(vVK.ssH(25754), URs);

	public static string UICommandCloseOthersText => ResourceManager.GetString(vVK.ssH(25822), URs);

	public static string UICommandClosePrimaryDocumentText => ResourceManager.GetString(vVK.ssH(25874), URs);

	public static string UICommandCloseWindowText => ResourceManager.GetString(vVK.ssH(25944), URs);

	public static string UICommandKeepTabOpenText => ResourceManager.GetString(vVK.ssH(25996), URs);

	public static string UICommandMakeDockedWindowText => ResourceManager.GetString(vVK.ssH(26048), URs);

	public static string UICommandMakeDocumentWindowText => ResourceManager.GetString(vVK.ssH(26110), URs);

	public static string UICommandMakeFloatingWindowText => ResourceManager.GetString(vVK.ssH(26176), URs);

	public static string UICommandMoveToNewHorizontalContainerText => ResourceManager.GetString(vVK.ssH(26242), URs);

	public static string UICommandMoveToNewVerticalContainerText => ResourceManager.GetString(vVK.ssH(26328), URs);

	public static string UICommandMoveToNextContainerText => ResourceManager.GetString(vVK.ssH(26410), URs);

	public static string UICommandMoveToPreviousContainerText => ResourceManager.GetString(vVK.ssH(26478), URs);

	public static string UICommandMoveToPrimaryMdiHostText => ResourceManager.GetString(vVK.ssH(26554), URs);

	public static string UICommandPinTabText => ResourceManager.GetString(vVK.ssH(26624), URs);

	public static string UICommandToggleWindowAutoHideStateText => ResourceManager.GetString(vVK.ssH(26666), URs);

	public static string UIStandardSwitcherDocumentsText => ResourceManager.GetString(vVK.ssH(26746), URs);

	public static string UIStandardSwitcherToolWindowsText => ResourceManager.GetString(vVK.ssH(26812), URs);

	public static string UIToolWindowContainerCloseButtonToolTip => ResourceManager.GetString(vVK.ssH(26882), URs);

	public static string UIToolWindowContainerMaximizeButtonToolTip => ResourceManager.GetString(vVK.ssH(26964), URs);

	public static string UIToolWindowContainerMinimizeButtonToolTip => ResourceManager.GetString(vVK.ssH(27052), URs);

	public static string UIToolWindowContainerOptionsButtonToolTip => ResourceManager.GetString(vVK.ssH(27140), URs);

	public static string UIToolWindowContainerRestoreButtonToolTip => ResourceManager.GetString(vVK.ssH(27226), URs);

	public static string UIToolWindowContainerToggleAutoHideButtonToolTip => ResourceManager.GetString(vVK.ssH(27312), URs);

	public static string UIWindowControlCloseButtonToolTip => ResourceManager.GetString(vVK.ssH(27412), URs);

	public static string UIWindowControlMaximizeButtonToolTip => ResourceManager.GetString(vVK.ssH(27482), URs);

	public static string UIWindowControlMinimizeButtonToolTip => ResourceManager.GetString(vVK.ssH(27558), URs);

	public static string UIWindowControlRestoreButtonToolTip => ResourceManager.GetString(vVK.ssH(27634), URs);

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal Resources()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool EKn()
	{
		return aK8 == null;
	}

	internal static Resources bKA()
	{
		return aK8;
	}
}
