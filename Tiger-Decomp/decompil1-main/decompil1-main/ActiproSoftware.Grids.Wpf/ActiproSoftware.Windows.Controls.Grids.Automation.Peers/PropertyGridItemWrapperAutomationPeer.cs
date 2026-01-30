using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;

namespace ActiproSoftware.Windows.Controls.Grids.Automation.Peers;

public class PropertyGridItemWrapperAutomationPeer : TreeListViewItemWrapperAutomationPeer
{
	private static PropertyGridItemWrapperAutomationPeer ns7;

	public PropertyGridItemWrapperAutomationPeer(PropertyGridItem owner)
	{
		fc.taYSkz();
		base._002Ector(owner);
	}

	protected override string GetItemTypeCore()
	{
		if (base.Owner is PropertyGridItem { DataContext: IDataModel dataContext })
		{
			if (dataContext is IPropertyModel)
			{
				return xv.hTz(9620);
			}
			if (dataContext is ICategoryModel)
			{
				return xv.hTz(7708);
			}
			if (dataContext is ICategoryEditorModel)
			{
				return xv.hTz(10294);
			}
		}
		return base.GetItemTypeCore();
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return xv.hTz(10328);
	}

	protected override string GetNameCore()
	{
		if (base.Owner is PropertyGridItem { DataContext: IDataModel dataContext })
		{
			return dataContext.DisplayName;
		}
		return base.GetNameCore();
	}

	internal static bool qsO()
	{
		return ns7 == null;
	}

	internal static PropertyGridItemWrapperAutomationPeer NsD()
	{
		return ns7;
	}
}
