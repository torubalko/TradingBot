using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Security;
using System.Windows.Markup;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.Docking;

[TypeConverter(typeof(TVd))]
[MarkupExtensionReturnType(typeof(string))]
public class SRExtension : MarkupExtension
{
	internal class TVd : TypeConverter
	{
		private static TVd shR;

		public override bool CanConvertTo(ITypeDescriptorContext P_0, Type P_1)
		{
			if (!(P_1 == typeof(InstanceDescriptor)))
			{
				return base.CanConvertTo(P_0, P_1);
			}
			return true;
		}

		[SecuritySafeCritical]
		public override object ConvertTo(ITypeDescriptorContext P_0, CultureInfo P_1, object P_2, Type P_3)
		{
			if (P_3 != typeof(InstanceDescriptor))
			{
				return base.ConvertTo(P_0, P_1, P_2, P_3);
			}
			if (!(P_2 is SRExtension sRExtension))
			{
				throw new ArgumentException(vVK.ssH(28272));
			}
			return new InstanceDescriptor(typeof(SRExtension).GetConstructor(new Type[1] { typeof(string) }), new object[1] { sRExtension.Name });
		}

		public TVd()
		{
			IVH.CecNqz();
			base._002Ector();
		}

		internal static bool xhD()
		{
			return shR == null;
		}

		internal static TVd nhE()
		{
			return shR;
		}
	}

	private string iRP;

	private static SRExtension FKG;

	[ConstructorArgument("name")]
	public string Name
	{
		get
		{
			return iRP;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(vVK.ssH(27720));
			}
			iRP = value;
		}
	}

	public SRExtension()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	public SRExtension(string name)
	{
		IVH.CecNqz();
		base._002Ector();
		if (name == null)
		{
			throw new ArgumentNullException(vVK.ssH(27708));
		}
		iRP = name;
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (iRP != null)
		{
			try
			{
				Enum.Parse(typeof(SRName), iRP);
			}
			catch (ArgumentException)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, vVK.ssH(27814), new object[1] { iRP }));
			}
			return SR.GetString(iRP);
		}
		throw new ArgumentException(vVK.ssH(27734));
	}

	internal static bool eKc()
	{
		return FKG == null;
	}

	internal static SRExtension pKM()
	{
		return FKG;
	}
}
