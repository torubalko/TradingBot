using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class ME : hC<string>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string VIF;

	private static ME wJ3;

	public override bool IsEditable => false;

	public override bool IsLiteral => true;

	public string Text
	{
		[CompilerGenerated]
		get
		{
			return VIF;
		}
		[CompilerGenerated]
		set
		{
			VIF = vIF;
		}
	}

	[SpecialName]
	public virtual bool fkx()
	{
		return false;
	}

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_2;
		string text = Text;
		if (P_1.WC(text, P_2, StringComparison.OrdinalIgnoreCase))
		{
			P_4 = P_2 + text.Length;
			return true;
		}
		string text2 = text.Trim();
		if (!string.IsNullOrEmpty(text2) && text2 != text && P_1.WC(text2, P_2, StringComparison.OrdinalIgnoreCase))
		{
			P_4 = P_2 + text2.Length;
			return true;
		}
		return false;
	}

	public ME()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool wJb()
	{
		return wJ3 == null;
	}

	internal static ME iJd()
	{
		return wJ3;
	}
}
