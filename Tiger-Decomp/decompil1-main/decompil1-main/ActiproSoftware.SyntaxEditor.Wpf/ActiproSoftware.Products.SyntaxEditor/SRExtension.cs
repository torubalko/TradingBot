using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Security;
using System.Windows.Markup;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.SyntaxEditor;

[MarkupExtensionReturnType(typeof(string))]
[TypeConverter(typeof(S7V))]
public class SRExtension : MarkupExtension
{
	internal class S7V : TypeConverter
	{
		internal static S7V jik;

		public override bool CanConvertTo(ITypeDescriptorContext P_0, Type P_1)
		{
			return P_1 == typeof(InstanceDescriptor) || base.CanConvertTo(P_0, P_1);
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
				int num = 0;
				if (ciF() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					throw new ArgumentException(SR.GetString(SRName.ExExtensionMustBeSRExtension));
				}
			}
			return new InstanceDescriptor(typeof(SRExtension).GetConstructor(new Type[1] { typeof(string) }), new object[1] { sRExtension.Name });
		}

		public S7V()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool RiZ()
		{
			return jik == null;
		}

		internal static S7V ciF()
		{
			return jik;
		}
	}

	private string R0E;

	internal static SRExtension SGX;

	[ConstructorArgument("name")]
	public string Name
	{
		get
		{
			return R0E;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException(Q7Z.tqM(191580));
			}
			R0E = value;
		}
	}

	public SRExtension()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	public SRExtension(string name)
	{
		grA.DaB7cz();
		base._002Ector();
		if (name == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(219354));
		}
		R0E = name;
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (R0E != null)
		{
			try
			{
				Enum.Parse(typeof(SRName), R0E);
			}
			catch (ArgumentException)
			{
				throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExInvalidStringResourceName), new object[1] { R0E }));
			}
			return SR.GetString(R0E);
		}
		throw new ArgumentException(SR.GetString(SRName.ExNoStringResource));
	}

	internal static bool UGE()
	{
		return SGX == null;
	}

	internal static SRExtension NGw()
	{
		return SGX;
	}
}
