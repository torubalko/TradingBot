using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Markup;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[MarkupExtensionReturnType(typeof(Type))]
public class NullableExtension : MarkupExtension
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Type akM;

	private static NullableExtension HOg;

	public Type TypeArgument
	{
		[CompilerGenerated]
		get
		{
			return akM;
		}
		[CompilerGenerated]
		private set
		{
			akM = value;
		}
	}

	public NullableExtension(Type typeArgument)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		TypeArgument = typeArgument;
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		return typeof(Nullable<>).MakeGenericType(TypeArgument);
	}

	internal static bool PO8()
	{
		return HOg == null;
	}

	internal static NullableExtension mOj()
	{
		return HOg;
	}
}
