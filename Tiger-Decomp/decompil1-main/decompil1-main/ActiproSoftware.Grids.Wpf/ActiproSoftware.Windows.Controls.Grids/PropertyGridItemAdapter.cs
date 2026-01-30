using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;

namespace ActiproSoftware.Windows.Controls.Grids;

public class PropertyGridItemAdapter : TreeListBoxItemAdapter
{
	private static PropertyGridItemAdapter SB;

	public PropertyGridItemAdapter()
	{
		fc.taYSkz();
		base._002Ector();
		base.ChildrenPath = xv.hTz(3112);
		base.IsExpandedPath = xv.hTz(3132);
		base.IsSelectedPath = xv.hTz(3156);
	}

	private static void gPo(IDataModel P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		for (int num = P_0.Children.Count - 1; num >= 0; num--)
		{
			IDataModel dataModel = P_0.Children[num];
			if (dataModel != null)
			{
				dataModel.Parent = null;
			}
		}
		P_0.Children.Clear();
	}

	private static aq TPY(PropertyGrid P_0, IDataModel P_1, IList<object> P_2)
	{
		return new aq(P_0.F1())
		{
			DataObjects = P_2,
			Parent = ((P_1 == null) ? null : (P_1.IsRoot ? null : P_1))
		};
	}

	internal static bool VPk(PropertyGrid P_0, IDataModel P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(xv.hTz(3180));
		}
		if (P_1 is IPropertyModel propertyModel)
		{
			IDataFactory dataFactory = P_0.DataFactory;
			if (dataFactory != null)
			{
				aq request = TPY(P_0, P_1, propertyModel.Values);
				IList<IDataModel> dataModels = dataFactory.GetDataModels(request);
				gPo(P_1);
				if (dataModels != null)
				{
					foreach (IDataModel item in dataModels)
					{
						if (item != null)
						{
							if (item is IPropertyModel propertyModel2)
							{
								propertyModel2.IsHostReadOnly = propertyModel.IsHostReadOnly;
							}
							P_1.Children.Add(item);
						}
					}
				}
				return true;
			}
			gPo(P_1);
		}
		return false;
	}

	public override IEnumerable GetChildren(TreeListBox ownerControl, object item)
	{
		if (item is IDataModel dataModel)
		{
			if (!dataModel.IsInitialized && ownerControl is PropertyGrid propertyGrid && VPk(propertyGrid, dataModel))
			{
				dataModel.IsInitialized = true;
			}
			if (!(dataModel is ICategoryEditorModel))
			{
				return dataModel.Children;
			}
		}
		return null;
	}

	[SuppressMessage("Microsoft.Usage", "CA2233:OperationsShouldNotOverflow", MessageId = "depth-1")]
	public override double GetIndentAmount(TreeListBox ownerControl, object item, int depth)
	{
		if (ownerControl != null)
		{
			if (item is IPropertyModel propertyModel && !(propertyModel.AnL() is IPropertyModel))
			{
				return Math.Max(0.0, ownerControl.TopLevelIndent + (double)Math.Max(0, depth - 1) * ownerControl.IndentIncrement);
			}
			if (item is ICategoryEditorModel)
			{
				return Math.Max(0.0, ownerControl.TopLevelIndent + (double)Math.Max(0, depth - 1) * ownerControl.IndentIncrement);
			}
		}
		return base.GetIndentAmount(ownerControl, item, depth);
	}

	public override bool GetIsExpanded(TreeListBox ownerControl, object item)
	{
		if (!(item is IDataModel dataModel))
		{
			return false;
		}
		return dataModel.IsExpanded;
	}

	public override bool GetIsSelected(TreeListBox ownerControl, object item)
	{
		if (!(item is IDataModel dataModel))
		{
			return false;
		}
		return dataModel.IsSelected;
	}

	public override string GetPath(TreeListBox ownerControl, object item)
	{
		if (!(item is IDataModel dataModel))
		{
			return null;
		}
		return dataModel.Name;
	}

	public virtual bool InitializeDataObjectWithDisplayName(PropertyGrid sourceControl, IDataObject dataObject, IDataModel model)
	{
		if (sourceControl == null)
		{
			throw new ArgumentNullException(xv.hTz(3208));
		}
		if (dataObject == null)
		{
			throw new ArgumentNullException(xv.hTz(3238));
		}
		if (model == null)
		{
			throw new ArgumentNullException(xv.hTz(2872));
		}
		string text = model.DisplayName ?? model.Name;
		if (!string.IsNullOrEmpty(text))
		{
			dataObject.SetData(DataFormats.Text, text, autoConvert: true);
			return true;
		}
		return false;
	}

	public virtual bool InitializeDataObjectWithPropertyValue(PropertyGrid sourceControl, IDataObject dataObject, IPropertyModel propertyModel)
	{
		if (sourceControl == null)
		{
			throw new ArgumentNullException(xv.hTz(3208));
		}
		if (dataObject == null)
		{
			throw new ArgumentNullException(xv.hTz(3238));
		}
		if (propertyModel == null)
		{
			throw new ArgumentNullException(xv.hTz(3262));
		}
		string valueAsString = propertyModel.ValueAsString;
		if (!string.IsNullOrEmpty(valueAsString))
		{
			dataObject.SetData(DataFormats.Text, valueAsString, autoConvert: true);
			return true;
		}
		return false;
	}

	public override void SetIsExpanded(TreeListBox ownerControl, object item, bool value)
	{
		if (item is IDataModel dataModel)
		{
			dataModel.IsExpanded = value;
		}
	}

	public override void SetIsSelected(TreeListBox ownerControl, object item, bool value)
	{
		if (item is IDataModel dataModel)
		{
			dataModel.IsSelected = value;
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public virtual bool SetPropertyValueFromDataObject(PropertyGrid sourceControl, IDataObject dataObject, IPropertyModel propertyModel)
	{
		if (sourceControl == null)
		{
			throw new ArgumentNullException(xv.hTz(3208));
		}
		if (dataObject == null)
		{
			throw new ArgumentNullException(xv.hTz(3238));
		}
		if (propertyModel == null)
		{
			throw new ArgumentNullException(xv.hTz(3262));
		}
		try
		{
			string text = null;
			if (dataObject.GetDataPresent(DataFormats.UnicodeText))
			{
				text = dataObject.GetData(DataFormats.UnicodeText) as string;
			}
			if (string.IsNullOrEmpty(text) && dataObject.GetDataPresent(DataFormats.Text))
			{
				text = dataObject.GetData(DataFormats.Text) as string;
			}
			if (!string.IsNullOrEmpty(text))
			{
				propertyModel.ValueAsString = text;
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	internal static bool yt()
	{
		return SB == null;
	}

	internal static PropertyGridItemAdapter S4()
	{
		return SB;
	}
}
