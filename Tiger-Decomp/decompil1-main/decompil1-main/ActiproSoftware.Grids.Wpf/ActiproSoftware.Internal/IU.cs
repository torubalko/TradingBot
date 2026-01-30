using System;
using System.Collections.Generic;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

namespace ActiproSoftware.Internal;

internal static class IU
{
	internal static IU QCN;

	private static int W5o(Type P_0, string P_1, Type P_2, IPropertyModel P_3)
	{
		bool num = P_0 != null;
		bool flag = !string.IsNullOrEmpty(P_1);
		bool flag2 = P_2 != null;
		int? num2 = V5Y(P_0, P_3.TargetType);
		bool flag3 = flag && P_1 == P_3.Name;
		int? num3 = V5Y(P_2, P_3.ValueType);
		if (!num)
		{
			if (flag)
			{
				if (!flag2)
				{
					if (flag3)
					{
						return 4000;
					}
				}
				else if (flag3 && num3.HasValue)
				{
					return 3000 + num3.Value;
				}
			}
			else
			{
				if (!flag2)
				{
					return 6000;
				}
				if (num3.HasValue)
				{
					return 5000 + num3.Value;
				}
			}
		}
		else if (!flag)
		{
			if (flag2 && num2.HasValue && num3.HasValue)
			{
				return 2000 + num2.Value * 5;
			}
		}
		else if (!flag2)
		{
			if (num2.HasValue && flag3)
			{
				return 1000 + num2.Value * 5;
			}
		}
		else
		{
			int num4 = 1;
			if (TCT() == null)
			{
				num4 = 1;
			}
			int num5 = default(int);
			while (true)
			{
				switch (num4)
				{
				default:
					return num2.Value * 5 + num3.Value;
				case 1:
					break;
				}
				if (!(num2.HasValue && flag3) || !num3.HasValue)
				{
					break;
				}
				num4 = 0;
				if (TCT() != null)
				{
					num4 = num5;
				}
			}
		}
		return int.MaxValue;
	}

	private static int? V5Y(Type P_0, Type P_1)
	{
		if (P_0 != null)
		{
			if (P_0 == P_1)
			{
				return 0;
			}
			if (P_1 != null)
			{
				if (P_1.IsSubclassOf(P_0))
				{
					return 1;
				}
				if (P_0.IsInterface)
				{
					if (P_0.IsAssignableFrom(P_1))
					{
						return 2;
					}
					if (P_0.IsGenericType && P_0.ContainsGenericParameters)
					{
						Type genericTypeDefinition = P_0.GetGenericTypeDefinition();
						if (P_1.IsInterface && P_1.IsGenericType && P_1.GetGenericTypeDefinition() == genericTypeDefinition)
						{
							return 3;
						}
						Type[] interfaces = P_1.GetInterfaces();
						foreach (Type type in interfaces)
						{
							if (type.IsGenericType && type.GetGenericTypeDefinition() == genericTypeDefinition)
							{
								return 4;
							}
						}
					}
				}
			}
		}
		return null;
	}

	public static IList<IPropertyModel> V5k(CategoryEditor P_0, IList<IDataModel> P_1)
	{
		if (P_0.Properties != null && P_0.Properties.Count > 0)
		{
			List<IPropertyModel> list = null;
			{
				foreach (CategoryEditorProperty property in P_0.Properties)
				{
					if (property == null)
					{
						continue;
					}
					bool flag = false;
					foreach (IDataModel item in P_1)
					{
						if (item is IPropertyModel propertyModel && q5Q(property, propertyModel) != int.MaxValue)
						{
							flag = true;
							if (list == null)
							{
								list = new List<IPropertyModel>();
							}
							list.Add(propertyModel);
						}
					}
					if (!flag)
					{
						return null;
					}
				}
				return list;
			}
		}
		return new List<IPropertyModel>();
	}

	public static int q5Q(CategoryEditorProperty P_0, IPropertyModel P_1)
	{
		return W5o(P_0.ObjectType, P_0.PropertyName, P_0.PropertyType, P_1);
	}

	public static int q5y(PropertyEditor P_0, IPropertyModel P_1)
	{
		return W5o(P_0.ObjectType, P_0.PropertyName, P_0.PropertyType, P_1);
	}

	internal static bool wC3()
	{
		return QCN == null;
	}

	internal static IU TCT()
	{
		return QCN;
	}
}
