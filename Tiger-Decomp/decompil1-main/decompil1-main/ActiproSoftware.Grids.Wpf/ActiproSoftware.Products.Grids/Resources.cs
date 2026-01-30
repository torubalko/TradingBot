using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.Grids;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
public class Resources
{
	private static ResourceManager AlT;

	private static CultureInfo slo;

	private static Resources QcP;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (AlT == null)
			{
				AlT = new ResourceManager("ActiproSoftware.Products.Grids.Resources", typeof(Resources).Assembly);
			}
			return AlT;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
	{
		get
		{
			return slo;
		}
		set
		{
			slo = value;
		}
	}

	public static string UICommandCopyNameText => ResourceManager.GetString(xv.hTz(10624), slo);

	public static string UICommandCopyValueText => ResourceManager.GetString(xv.hTz(10670), slo);

	public static string UICommandDescriptionText => ResourceManager.GetString(xv.hTz(10718), slo);

	public static string UICommandPasteValueText => ResourceManager.GetString(xv.hTz(10770), slo);

	public static string UICommandResetText => ResourceManager.GetString(xv.hTz(10820), slo);

	public static string UICommandSizeAllColumnsToFitText => ResourceManager.GetString(xv.hTz(10860), slo);

	public static string UICommandSizeColumnToFitText => ResourceManager.GetString(xv.hTz(10928), slo);

	public static string UIExpandableCollectionConverterIndexFormat => ResourceManager.GetString(xv.hTz(10988), slo);

	public static string UIExpandableCollectionConverterMultipleItemsFormat => ResourceManager.GetString(xv.hTz(11076), slo);

	public static string UIExpandableCollectionConverterNoItemsText => ResourceManager.GetString(xv.hTz(11180), slo);

	public static string UIExpandableCollectionConverterNullText => ResourceManager.GetString(xv.hTz(11268), slo);

	public static string UIExpandableCollectionConverterOneItemText => ResourceManager.GetString(xv.hTz(11350), slo);

	public static string UIPropertyGridAddChildButtonToolTip => ResourceManager.GetString(xv.hTz(11438), slo);

	public static string UIPropertyGridColumnHeaderNameText => ResourceManager.GetString(xv.hTz(11512), slo);

	public static string UIPropertyGridColumnHeaderValueText => ResourceManager.GetString(xv.hTz(11584), slo);

	public static string UIPropertyGridRemoveButtonToolTip => ResourceManager.GetString(xv.hTz(11658), slo);

	public static string UIPropertyGridSummaryNoDescriptionText => ResourceManager.GetString(xv.hTz(11728), slo);

	public static string UIPropertyGridSummaryNoDisplayNameText => ResourceManager.GetString(xv.hTz(11808), slo);

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal Resources()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool Dch()
	{
		return QcP == null;
	}

	internal static Resources Ocu()
	{
		return QcP;
	}
}
