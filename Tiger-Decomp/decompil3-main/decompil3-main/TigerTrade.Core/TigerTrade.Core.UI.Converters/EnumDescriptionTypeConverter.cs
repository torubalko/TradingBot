using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using EDugZvNwF6e5LYsQZ3C5;
using gyWf8lN8Aps6C4Xje11n;
using nff6NvN8pYC4xeKDOd05;
using OrDDjnN8w7riQsQI5MiI;

namespace TigerTrade.Core.UI.Converters;

public sealed class EnumDescriptionTypeConverter : EnumConverter
{
	private readonly Type _type;

	internal static EnumDescriptionTypeConverter x3FBh0kn0Pd1kbPMvARb;

	public EnumDescriptionTypeConverter(Type type)
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		base._002Ector(type);
		_type = type;
		int num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_b64dfac6d37145c6bb2c7f3f47bc17a2 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				if (text == null)
				{
					return base.ConvertFrom(context, culture, value);
				}
				return GetValue(_type, text);
			case 1:
				text = value as string;
				num2 = 0;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_e0a3c02bb89040119bce3183e167cfdc != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == null)
		{
			throw new ArgumentNullException((string)COsQ0QknfFWvKWDh0k1p(-1087080834 ^ -1087078880));
		}
		if (value != null)
		{
			int num = 0;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_373428409f1e4944a16e6e1a459b6f73 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			if (destinationType == Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(16777226)))
			{
				return GetDescription(_type, value.ToString());
			}
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	public static string GetDescription(Type type, string fieldName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (fieldName == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_7c432fb6ac314e0dac07b628339ad04f == 0)
					{
						num2 = 2;
					}
					continue;
				}
				if (type.GetField(fieldName)?.GetCustomAttributes(xpkMoOknnWoPJDO7jkVS(V666v0N8875hxUavxV17.cHJk4pLGZX2(16777247)), inherit: false) is DescriptionAttribute[] array && array.Length != 0)
				{
					return array[0].Description;
				}
				return fieldName;
			case 1:
				if (!ToTQ15kn96OjmReEHpQh(null, type))
				{
					num2 = 0;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_32677ad3cfd244ce9f2c7603d0c2367e != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				break;
			}
			break;
		}
		return string.Empty;
	}

	public static object GetValue(Type type, string description)
	{
		int num = 2;
		int num2 = num;
		FieldInfo[] fields = default(FieldInfo[]);
		DescriptionAttribute[] array = default(DescriptionAttribute[]);
		FieldInfo fieldInfo = default(FieldInfo);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				fields = type.GetFields();
				num2 = 1;
				if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_d4c05ecce72042a689087de91a91d628 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				array = fieldInfo.GetCustomAttributes(Type.GetTypeFromHandle(V666v0N8875hxUavxV17.cHJk4pLGZX2(16777247)), inherit: false) as DescriptionAttribute[];
				if (array != null && array.Length != 0)
				{
					num2 = 5;
					break;
				}
				goto IL_00f2;
			case 3:
				return fieldInfo.GetValue(ahxlaLknY7YMR5eeUTZm(fieldInfo));
			case 4:
				num3++;
				goto IL_00d3;
			case 5:
				if (array[0].Description == description)
				{
					return LBuZnXknGYtCWLO6jaaq(fieldInfo, fieldInfo.Name);
				}
				goto IL_00f2;
			case 1:
				{
					num3 = 0;
					goto IL_00d3;
				}
				IL_00d3:
				if (num3 < fields.Length)
				{
					fieldInfo = fields[num3];
					num2 = 0;
					if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_cd71425f651a4405a1288e9be5595ce4 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return description;
				IL_00f2:
				if (!(fieldInfo.Name == description))
				{
					num2 = 4;
					break;
				}
				goto case 3;
			}
		}
	}

	static EnumDescriptionTypeConverter()
	{
		SnRvmWknoREZX6Z9q49p();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool X3Va8Zkn2xLQTUxc8AAj()
	{
		return x3FBh0kn0Pd1kbPMvARb == null;
	}

	internal static EnumDescriptionTypeConverter xwta1dknHbjqDqMowAsb()
	{
		return x3FBh0kn0Pd1kbPMvARb;
	}

	internal static object COsQ0QknfFWvKWDh0k1p(int P_0)
	{
		return RUVZnUNwJg2VA9xTOL2q.PIwN7NHVqJi(P_0);
	}

	internal static bool ToTQ15kn96OjmReEHpQh(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Type xpkMoOknnWoPJDO7jkVS(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object LBuZnXknGYtCWLO6jaaq(object P_0, object P_1)
	{
		return ((FieldInfo)P_0).GetValue(P_1);
	}

	internal static object ahxlaLknY7YMR5eeUTZm(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static void SnRvmWknoREZX6Z9q49p()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
	}
}
