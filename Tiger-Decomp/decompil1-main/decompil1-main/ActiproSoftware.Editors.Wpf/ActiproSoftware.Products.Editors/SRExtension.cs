using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Security;
using System.Windows.Markup;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.Editors;

[TypeConverter(typeof(YdQ))]
[MarkupExtensionReturnType(typeof(string))]
public class SRExtension : MarkupExtension
{
	internal class YdQ : TypeConverter
	{
		internal static YdQ PeO;

		public override bool CanConvertTo(ITypeDescriptorContext P_0, Type P_1)
		{
			return P_1 == typeof(InstanceDescriptor) || base.CanConvertTo(P_0, P_1);
		}

		[SecuritySafeCritical]
		public override object ConvertTo(ITypeDescriptorContext P_0, CultureInfo P_1, object P_2, Type P_3)
		{
			int num = 1;
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				do
				{
					switch (num2)
					{
					default:
						if (flag)
						{
							return base.ConvertTo(P_0, P_1, P_2, P_3);
						}
						if (!(P_2 is SRExtension sRExtension))
						{
							throw new ArgumentException(QdM.AR8(34500));
						}
						return new InstanceDescriptor(typeof(SRExtension).GetConstructor(new Type[1] { typeof(string) }), new object[1] { sRExtension.Name });
					case 1:
						break;
					}
					flag = P_3 != typeof(InstanceDescriptor);
					num2 = 0;
				}
				while (Cem());
			}
		}

		public YdQ()
		{
			awj.QuEwGz();
			base._002Ector();
		}

		internal static bool Cem()
		{
			return PeO == null;
		}

		internal static YdQ yeP()
		{
			return PeO;
		}
	}

	private string Tuq;

	internal static SRExtension QAN;

	[ConstructorArgument("name")]
	public string Name
	{
		get
		{
			return Tuq;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(QdM.AR8(23908));
			}
			Tuq = value;
		}
	}

	public SRExtension()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	public SRExtension(string name)
	{
		awj.QuEwGz();
		base._002Ector();
		if (name == null)
		{
			throw new ArgumentNullException(QdM.AR8(34170));
		}
		Tuq = name;
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (Tuq == null)
		{
			throw new ArgumentException(QdM.AR8(34182));
		}
		try
		{
			Enum.Parse(typeof(SRName), Tuq);
		}
		catch (ArgumentException)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, QdM.AR8(34262), new object[1] { Tuq }));
		}
		return SR.GetString(Tuq);
	}

	internal static bool SAL()
	{
		return QAN == null;
	}

	internal static SRExtension KAq()
	{
		return QAN;
	}
}
