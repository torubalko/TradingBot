using System.Collections.Generic;
using System.Globalization;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal class Gu : hC<Brush>
{
	internal static Gu Kj2;

	public override bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4)
	{
		P_4 = P_1?.Length ?? 0;
		return true;
	}

	public Gu()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool Bjl()
	{
		return Kj2 == null;
	}

	internal static Gu tjV()
	{
		return Kj2;
	}
}
