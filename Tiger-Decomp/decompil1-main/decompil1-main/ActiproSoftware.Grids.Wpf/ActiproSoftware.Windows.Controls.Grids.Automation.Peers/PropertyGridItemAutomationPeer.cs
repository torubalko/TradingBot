using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;

namespace ActiproSoftware.Windows.Controls.Grids.Automation.Peers;

public class PropertyGridItemAutomationPeer : TreeListBoxItemAutomationPeer
{
	internal static PropertyGridItemAutomationPeer psN;

	public PropertyGridItemAutomationPeer(object item, PropertyGridAutomationPeer itemsControlAutomationPeer)
	{
		fc.taYSkz();
		base._002Ector(item, itemsControlAutomationPeer);
	}

	protected override string GetClassNameCore()
	{
		return xv.hTz(10258);
	}

	protected override string GetItemTypeCore()
	{
		if (base.Item is IDataModel dataModel)
		{
			if (dataModel is IPropertyModel)
			{
				return xv.hTz(9620);
			}
			if (dataModel is ICategoryModel)
			{
				return xv.hTz(7708);
			}
			if (dataModel is ICategoryEditorModel)
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

	internal static bool Ks3()
	{
		return psN == null;
	}

	internal static PropertyGridItemAutomationPeer JsT()
	{
		return psN;
	}
}
