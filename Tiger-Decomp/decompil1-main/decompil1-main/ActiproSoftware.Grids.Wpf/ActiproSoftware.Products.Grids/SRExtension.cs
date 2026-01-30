using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Security;
using System.Windows.Markup;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.Grids;

[TypeConverter(typeof(Vw))]
[MarkupExtensionReturnType(typeof(string))]
public class SRExtension : MarkupExtension
{
	internal class Vw : TypeConverter
	{
		private static Vw MXe;

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
				throw new ArgumentException(xv.hTz(12202));
			}
			return new InstanceDescriptor(typeof(SRExtension).GetConstructor(new Type[1] { typeof(string) }), new object[1] { sRExtension.Name });
		}

		public Vw()
		{
			fc.taYSkz();
			base._002Ector();
		}

		internal static bool zXv()
		{
			return MXe == null;
		}

		internal static Vw sXn()
		{
			return MXe;
		}
	}

	private string Ply;

	internal static SRExtension oc0;

	[ConstructorArgument("name")]
	public string Name
	{
		get
		{
			return Ply;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(xv.hTz(11900));
			}
			Ply = value;
		}
	}

	public SRExtension()
	{
		fc.taYSkz();
		base._002Ector();
	}

	public SRExtension(string name)
	{
		fc.taYSkz();
		base._002Ector();
		if (name == null)
		{
			throw new ArgumentNullException(xv.hTz(11888));
		}
		Ply = name;
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (Ply != null)
		{
			try
			{
				Enum.Parse(typeof(SRName), Ply);
			}
			catch (ArgumentException)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, xv.hTz(11994), new object[1] { Ply }));
			}
			return SR.GetString(Ply);
		}
		throw new ArgumentException(xv.hTz(11914));
	}

	internal static bool fcj()
	{
		return oc0 == null;
	}

	internal static SRExtension McL()
	{
		return oc0;
	}
}
