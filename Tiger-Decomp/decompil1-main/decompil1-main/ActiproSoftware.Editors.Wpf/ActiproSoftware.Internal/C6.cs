using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal abstract class C6<mc> : hC<mc>, Hs, IPart
{
	private string jIG;

	private static object NGf;

	public string Format
	{
		get
		{
			return jIG;
		}
		set
		{
			jIG = BkT(text);
		}
	}

	protected virtual string BkT(string P_0)
	{
		return P_0;
	}

	protected C6()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool JGN()
	{
		return NGf == null;
	}

	internal static object RGL()
	{
		return NGf;
	}
}
