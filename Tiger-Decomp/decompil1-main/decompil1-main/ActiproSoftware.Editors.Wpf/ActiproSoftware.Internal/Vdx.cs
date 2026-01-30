using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal static class Vdx
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public object[] kRg;

		internal static _003C_003Ec__DisplayClass5_0 seJ;

		public _003C_003Ec__DisplayClass5_0()
		{
			awj.QuEwGz();
			base._002Ector();
		}

		internal bool cRY(object v)
		{
			return !kRg.Contains(v);
		}

		internal static bool Beh()
		{
			return seJ == null;
		}

		internal static _003C_003Ec__DisplayClass5_0 peS()
		{
			return seJ;
		}
	}

	private static Vdx XSc;

	public static Type PDG(Type P_0, object P_1)
	{
		if (P_0 == null && P_1 != null)
		{
			P_0 = P_1.GetType();
		}
		return P_0;
	}

	public static string hDq(object P_0, bool P_1)
	{
		if (P_0 == null)
		{
			return null;
		}
		if (P_1)
		{
			Type type = P_0.GetType();
			string text = vD9(type, P_0);
			if (string.IsNullOrEmpty(text))
			{
				string[] array = P_0.ToString().Split(CDF());
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < array.Length; i++)
				{
					if (i != 0)
					{
						stringBuilder.Append(QdM.AR8(28190));
					}
					stringBuilder.Append(wDd(type, array[i].Trim()));
				}
				return stringBuilder.ToString();
			}
			return text;
		}
		return P_0.ToString();
	}

	[SpecialName]
	public static char CDF()
	{
		return ',';
	}

	public static IList<IPart> ADu()
	{
		List<IPart> list = new List<IPart>();
		jb item = new jb();
		list.Add(item);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static Array BDK(Type P_0)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals3.kRg = (from f in P_0.GetFields()
			where f.GetCustomAttributes(typeof(EditorBrowsableAttribute), inherit: true).FirstOrDefault() is EditorBrowsableAttribute editorBrowsableAttribute && editorBrowsableAttribute.State == EditorBrowsableState.Never
			select f.GetValue(null)).ToArray();
		if (CS_0024_003C_003E8__locals3.kRg.Length != 0)
		{
			return (from v in Enum.GetValues(P_0).OfType<object>()
				where !CS_0024_003C_003E8__locals3.kRg.Contains(v)
				select v).ToArray();
		}
		return Enum.GetValues(P_0);
	}

	public static object yDR(Type P_0)
	{
		if (P_0 != null && P_0.IsEnum)
		{
			Array values = Enum.GetValues(P_0);
			foreach (object item in values)
			{
				if (0.Equals(item))
				{
					return item;
				}
			}
			if (values.Length > 0)
			{
				return values.GetValue(0);
			}
		}
		return null;
	}

	public static string wDd(Type P_0, string P_1)
	{
		if (P_0 != null && P_1 != null)
		{
			FieldInfo field = P_0.GetField(P_1);
			if (field != null)
			{
				if (field.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false) is DescriptionAttribute[] array && array.Length != 0 && !string.IsNullOrEmpty(array[0].Description))
				{
					return array[0].Description;
				}
				if (field.GetCustomAttributes(typeof(DisplayAttribute), inherit: false) is DisplayAttribute[] array2 && array2.Length != 0)
				{
					string name = array2[0].GetName();
					if (!string.IsNullOrEmpty(name))
					{
						return name;
					}
				}
				return P_1.ToString();
			}
		}
		return null;
	}

	public static string vD9(Type P_0, object P_1)
	{
		if (P_0 != null && P_1 != null)
		{
			FieldInfo field = P_0.GetField(P_1.ToString());
			if (field != null)
			{
				if (field.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false) is DescriptionAttribute[] array && array.Length != 0)
				{
					return array[0].Description;
				}
				if (field.GetCustomAttributes(typeof(DisplayAttribute), inherit: false) is DisplayAttribute[] array2 && array2.Length != 0)
				{
					string name = array2[0].GetName();
					if (!string.IsNullOrEmpty(name))
					{
						return name;
					}
				}
			}
		}
		return null;
	}

	public static object uD5(Type P_0, string P_1)
	{
		if (P_0 != null && P_1 != null)
		{
			FieldInfo[] fields = P_0.GetFields();
			FieldInfo[] array = fields;
			foreach (FieldInfo fieldInfo in array)
			{
				if (fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false) is DescriptionAttribute[] array2 && array2.Length != 0 && string.Compare(array2[0].Description, P_1, StringComparison.CurrentCultureIgnoreCase) == 0)
				{
					return fieldInfo.GetValue(fieldInfo.Name) as Enum;
				}
				if (fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), inherit: false) is DisplayAttribute[] array3 && array3.Length != 0)
				{
					string name = array3[0].GetName();
					if (string.Compare(name, P_1, StringComparison.CurrentCultureIgnoreCase) == 0)
					{
						return fieldInfo.GetValue(fieldInfo.Name) as Enum;
					}
				}
				if (string.Compare(fieldInfo.Name, P_1, StringComparison.CurrentCultureIgnoreCase) == 0)
				{
					return fieldInfo.GetValue(fieldInfo.Name) as Enum;
				}
			}
		}
		return null;
	}

	public static bool JDc(Type P_0)
	{
		return P_0 != null && P_0.IsEnum && P_0.IsDefined(typeof(FlagsAttribute), inherit: true);
	}

	public static bool IDH(Type P_0, object P_1)
	{
		if (P_0 != null && P_0.IsEnum && P_1 != null)
		{
			if (JDc(P_0))
			{
				int num = 0;
				Array values = Enum.GetValues(P_0);
				foreach (object item in values)
				{
					num |= (int)item;
				}
				int num2 = (int)P_1;
				return (num & num2) == num2;
			}
			return Enum.IsDefined(P_0, P_1);
		}
		return false;
	}

	public static bool xDL(Type P_0, string P_1, bool P_2, out object P_3)
	{
		if (P_0 == null)
		{
			P_3 = null;
			return false;
		}
		P_3 = null;
		if (string.IsNullOrEmpty(P_1))
		{
			return true;
		}
		if (P_2)
		{
			string[] array = P_1.ToString().Split(CDF());
			int num = 0;
			string[] array2 = array;
			foreach (string text in array2)
			{
				P_3 = uD5(P_0, text.Trim());
				if (P_3 != null)
				{
					num |= Convert.ToInt32(P_3, CultureInfo.InvariantCulture);
				}
			}
			try
			{
				P_3 = Enum.ToObject(P_0, num) as Enum;
				return true;
			}
			catch (ArgumentException)
			{
			}
		}
		else
		{
			if (char.IsDigit(P_1[0]) || P_1[0] == '-' || P_1[0] == '+')
			{
				return false;
			}
			try
			{
				P_3 = Enum.Parse(P_0, P_1, ignoreCase: true);
				return true;
			}
			catch (ArgumentException)
			{
			}
		}
		return false;
	}

	internal static bool sSD()
	{
		return XSc == null;
	}

	internal static Vdx QSy()
	{
		return XSc;
	}
}
