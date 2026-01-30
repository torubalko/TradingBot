using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Threading;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public abstract class DataFactoryBase : IDataFactory
{
	private class ad
	{
		[CompilerGenerated]
		private ICategoryModel wga;

		[CompilerGenerated]
		private IList<IDataModel> wgi;

		[CompilerGenerated]
		private bool jgb;

		private static ad gRt;

		public ad(ICategoryModel P_0)
		{
			fc.taYSkz();
			base._002Ector();
			Fg2(P_0);
			Cg9(new List<IDataModel>());
		}

		[SpecialName]
		[CompilerGenerated]
		public ICategoryModel fgX()
		{
			return wga;
		}

		[SpecialName]
		[CompilerGenerated]
		private void Fg2(ICategoryModel P_0)
		{
			wga = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public IList<IDataModel> Xg8()
		{
			return wgi;
		}

		[SpecialName]
		[CompilerGenerated]
		private void Cg9(IList<IDataModel> P_0)
		{
			wgi = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public bool BgL()
		{
			return jgb;
		}

		[SpecialName]
		[CompilerGenerated]
		public void mgj(bool P_0)
		{
			jgb = P_0;
		}

		internal static bool mR4()
		{
			return gRt == null;
		}

		internal static ad XRl()
		{
			return gRt;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public DataFactoryBase dgV;

		public IDataFactoryRequest hgf;

		internal static _003C_003Ec__DisplayClass12_0 SRy;

		public _003C_003Ec__DisplayClass12_0()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal IList<IDataModel> egc(object dataObject)
		{
			IList<IDataModel> list = null;
			if (dataObject != null)
			{
				IList<IPropertyModel> propertyModels = dgV.GetPropertyModels(dataObject, hgf);
				if (propertyModels != null && propertyModels.Count > 0)
				{
					foreach (IPropertyModel item in propertyModels)
					{
						if (item != null)
						{
							if (list == null)
							{
								list = new List<IDataModel>();
							}
							VWe(item, hgf);
							list.Add(item);
						}
					}
				}
			}
			return list;
		}

		internal static bool tRf()
		{
			return SRy == null;
		}

		internal static _003C_003Ec__DisplayClass12_0 LRo()
		{
			return SRy;
		}
	}

	private IEqualityComparer<IPropertyModel> WWG;

	private static DataFactoryBase N6P;

	private void bWB(ad P_0, CategoryEditor[] P_1, IDataFactoryRequest P_2)
	{
		string ch = PropertyGrid.ch;
		string text = P_2.MiscCategoryName ?? ch;
		int num = 0;
		int num3 = default(int);
		ICategoryEditorModel categoryEditorModel = default(ICategoryEditorModel);
		foreach (CategoryEditor categoryEditor in P_1)
		{
			if (categoryEditor == null)
			{
				continue;
			}
			string text2 = categoryEditor.Category;
			if (!string.IsNullOrEmpty(text2))
			{
				if (!(text2 == ch))
				{
					goto IL_01af;
				}
				int num2 = 1;
				if (!M6h())
				{
					num2 = num3;
				}
				switch (num2)
				{
				case 1:
					break;
				default:
					goto IL_0196;
				}
			}
			text2 = text;
			goto IL_01af;
			IL_01af:
			if (!(P_0.fgX().Name == text2))
			{
				continue;
			}
			IList<IPropertyModel> list = IU.V5k(categoryEditor, P_0.Xg8());
			if (list == null)
			{
				continue;
			}
			categoryEditorModel = CreateCategoryEditorModel(categoryEditor, P_2);
			if (categoryEditorModel == null)
			{
				continue;
			}
			foreach (IPropertyModel item in list)
			{
				P_0.Xg8().Remove(item);
				categoryEditorModel.Children.Add(item);
			}
			goto IL_0196;
			IL_0196:
			P_0.Xg8().Insert(num++, categoryEditorModel);
		}
	}

	private ad BWR(string P_0, IDataFactoryRequest P_1, Dictionary<string, ad> P_2)
	{
		ad ad = null;
		int num = 0;
		int num2 = (P_1.AreNestedCategoriesSupported ? P_0.IndexOf('\\', num) : (-1));
		while (true)
		{
			int num3 = ((num2 != -1) ? num2 : P_0.Length);
			string name = P_0.Substring(num, num3 - num);
			string key = P_0.Substring(0, num3);
			ad value = null;
			if (!P_2.TryGetValue(key, out value))
			{
				ICategoryModel obj = CreateCategoryModel(name, P_1) ?? new CategoryModel(name);
				value = new ad(obj);
				LWM(obj, P_1);
				P_2[key] = value;
				if (ad != null)
				{
					ad.Xg8().Add(value.fgX());
					value.mgj(_0020: true);
				}
			}
			ad = value;
			if (num2 == -1)
			{
				break;
			}
			num = num2 + 1;
			num2 = P_0.IndexOf('\\', num);
		}
		return ad;
	}

	private static void LWM(ICategoryModel P_0, IDataFactoryRequest P_1)
	{
		if (P_1.AreCategoriesAutoExpanded)
		{
			P_0.IsExpanded = true;
		}
	}

	private static void VWe(IPropertyModel P_0, IDataFactoryRequest P_1)
	{
		P_0.IsHostReadOnly = P_1.IsHostReadOnly;
		if (P_1.ArePropertiesAutoExpanded)
		{
			P_0.IsExpanded = true;
		}
	}

	private static bool iWr(object P_0)
	{
		if (P_0 is Freezable freezable)
		{
			Converter<Freezable, bool> converter = (Freezable f) => f.IsFrozen;
			if (freezable.Dispatcher == null || freezable.Dispatcher.CheckAccess())
			{
				return converter(freezable);
			}
			return (bool)freezable.Dispatcher.Invoke(DispatcherPriority.Normal, converter, freezable);
		}
		return false;
	}

	protected virtual void AutoConfigurePropertyModel(PropertyModel propertyModel, IDataFactoryRequest request)
	{
	}

	protected virtual IList<IDataModel> CategorizeDataModels(IList<IDataModel> models, IDataFactoryRequest request)
	{
		if (models == null)
		{
			return null;
		}
		if (request == null)
		{
			throw new ArgumentNullException(xv.hTz(8834));
		}
		string ch = PropertyGrid.ch;
		string text = request.MiscCategoryName ?? ch;
		IList<IDataModel> list = new List<IDataModel>();
		Dictionary<string, ad> dictionary = new Dictionary<string, ad>();
		foreach (IDataModel model in models)
		{
			if (model is ICategoryModel { Name: var text2 } categoryModel)
			{
				if (string.IsNullOrEmpty(text2) || text2 == ch)
				{
					text2 = text;
				}
				LWM(categoryModel, request);
				dictionary[text2] = new ad(categoryModel);
			}
		}
		foreach (IDataModel model2 in models)
		{
			if (model2 is IPropertyModel { Category: var text3 } propertyModel)
			{
				if (string.IsNullOrEmpty(text3) || text3 == ch)
				{
					text3 = text;
				}
				BWR(text3, request, dictionary).Xg8().Add(propertyModel);
			}
			else if (!(model2 is ICategoryModel) && model2 != null)
			{
				list.Add(model2);
			}
		}
		if (request.CategoryEditors != null && request.CategoryEditors.Any())
		{
			CategoryEditor[] array = request.CategoryEditors.ToArray();
			foreach (ad value in dictionary.Values)
			{
				bWB(value, array, request);
			}
		}
		foreach (ad value2 in dictionary.Values)
		{
			ICategoryModel categoryModel2 = value2.fgX();
			IList<IDataModel> list2 = SortDataModels(value2.Xg8(), request, categoryModel2.SortComparer);
			categoryModel2.Xn8();
			foreach (IDataModel item in list2)
			{
				categoryModel2.Children.Add(item);
			}
			if (!value2.BgL())
			{
				list.Add(categoryModel2);
			}
		}
		DataModelSortComparer sortComparer = ((request.Parent != null) ? request.Parent.SortComparer : null);
		return SortDataModels(list, request, sortComparer);
	}

	protected virtual ICategoryModel CreateCategoryModel(string name, IDataFactoryRequest request)
	{
		return new CategoryModel(name);
	}

	protected virtual ICategoryEditorModel CreateCategoryEditorModel(CategoryEditor categoryEditor, IDataFactoryRequest request)
	{
		return new CategoryEditorModel(categoryEditor);
	}

	protected virtual IPropertyModel CreateMergedPropertyModel(IList<IPropertyModel> propertyModels, IDataFactoryRequest request)
	{
		return new MergedPropertyModel(propertyModels);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public virtual IList<IDataModel> GetDataModels(IDataFactoryRequest request)
	{
		_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals21 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals21.dgV = this;
		CS_0024_003C_003E8__locals21.hgf = request;
		if (CS_0024_003C_003E8__locals21.hgf == null)
		{
			throw new ArgumentNullException(xv.hTz(8834));
		}
		IList<IDataModel> list = null;
		IList<object> dataObjects = CS_0024_003C_003E8__locals21.hgf.DataObjects;
		if (dataObjects != null && dataObjects.Count > 0)
		{
			if (dataObjects.Any((object o) => iWr(o)))
			{
				return null;
			}
			Func<object, IList<IDataModel>> func = delegate(object dataObject)
			{
				IList<IDataModel> list4 = null;
				if (dataObject != null)
				{
					IList<IPropertyModel> propertyModels = CS_0024_003C_003E8__locals21.dgV.GetPropertyModels(dataObject, CS_0024_003C_003E8__locals21.hgf);
					if (propertyModels != null && propertyModels.Count > 0)
					{
						foreach (IPropertyModel item in propertyModels)
						{
							if (item != null)
							{
								if (list4 == null)
								{
									list4 = new List<IDataModel>();
								}
								VWe(item, CS_0024_003C_003E8__locals21.hgf);
								list4.Add(item);
							}
						}
					}
				}
				return list4;
			};
			if (dataObjects.Count > 1)
			{
				Dictionary<IPropertyModel, List<IPropertyModel>> dictionary = new Dictionary<IPropertyModel, List<IPropertyModel>>(WWG);
				foreach (object item2 in dataObjects)
				{
					IList<IDataModel> list2 = func(item2);
					if (list2 == null)
					{
						continue;
					}
					foreach (IPropertyModel item3 in list2)
					{
						if (item3.IsMergeable)
						{
							List<IPropertyModel> value = null;
							if (!dictionary.TryGetValue(item3, out value))
							{
								value = (dictionary[item3] = new List<IPropertyModel>(dataObjects.Count));
							}
							value.Add(item3);
						}
					}
				}
				foreach (KeyValuePair<IPropertyModel, List<IPropertyModel>> item4 in dictionary)
				{
					if (item4.Value.Count != dataObjects.Count)
					{
						continue;
					}
					IPropertyModel propertyModel2 = CreateMergedPropertyModel(item4.Value, CS_0024_003C_003E8__locals21.hgf);
					if (propertyModel2 != null)
					{
						if (list == null)
						{
							list = new List<IDataModel>();
						}
						VWe(propertyModel2, CS_0024_003C_003E8__locals21.hgf);
						list.Add(propertyModel2);
					}
				}
			}
			else
			{
				list = func(dataObjects[0]);
			}
		}
		if ((CS_0024_003C_003E8__locals21.hgf.Parent == null || CS_0024_003C_003E8__locals21.hgf.Parent.IsRoot) && CS_0024_003C_003E8__locals21.hgf.Properties != null)
		{
			foreach (IPropertyModel property in CS_0024_003C_003E8__locals21.hgf.Properties)
			{
				if (property != null)
				{
					if (list == null)
					{
						list = new List<IDataModel>();
					}
					VWe(property, CS_0024_003C_003E8__locals21.hgf);
					list.Add(property);
				}
			}
		}
		if (list != null)
		{
			foreach (PropertyModel item5 in from pm in list.OfType<PropertyModel>()
				where pm.CanAutoConfigure
				select pm)
			{
				AutoConfigurePropertyModel(item5, CS_0024_003C_003E8__locals21.hgf);
			}
		}
		if (list != null && list.Count > 0)
		{
			if (CS_0024_003C_003E8__locals21.hgf.Parent == null && CS_0024_003C_003E8__locals21.hgf.IsCategorized)
			{
				list = CategorizeDataModels(list, CS_0024_003C_003E8__locals21.hgf);
			}
			else
			{
				DataModelSortComparer sortComparer = ((CS_0024_003C_003E8__locals21.hgf.Parent != null) ? CS_0024_003C_003E8__locals21.hgf.Parent.SortComparer : null);
				list = SortDataModels(list, CS_0024_003C_003E8__locals21.hgf, sortComparer);
			}
			if (list.Count > 0)
			{
				return list;
			}
		}
		return null;
	}

	[SuppressMessage("Microsoft.Naming", "CA1720:IdentifiersShouldNotContainTypeNames", MessageId = "object")]
	protected abstract IList<IPropertyModel> GetPropertyModels(object dataObject, IDataFactoryRequest request);

	protected virtual IList<IDataModel> SortDataModels(IList<IDataModel> models, IDataFactoryRequest request, DataModelSortComparer sortComparer)
	{
		if (models == null || models.Count <= 1)
		{
			return models;
		}
		if (request == null)
		{
			throw new ArgumentNullException(xv.hTz(8834));
		}
		if (sortComparer == null)
		{
			sortComparer = request.SortComparer;
		}
		if (sortComparer == null)
		{
			return models;
		}
		List<IDataModel> obj = (models as List<IDataModel>) ?? new List<IDataModel>(models);
		obj.Sort(sortComparer);
		return obj;
	}

	protected DataFactoryBase()
	{
		fc.taYSkz();
		WWG = new tW();
		base._002Ector();
	}

	internal static bool M6h()
	{
		return N6P == null;
	}

	internal static DataFactoryBase c6u()
	{
		return N6P;
	}
}
