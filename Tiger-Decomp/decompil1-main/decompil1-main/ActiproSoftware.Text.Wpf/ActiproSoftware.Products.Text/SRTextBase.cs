using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products.Text;

[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class SRTextBase
{
	private Dictionary<string, string> WLw;

	internal static SRTextBase XqQ;

	public abstract ResourceManager ResourceManager { get; }

	[SpecialName]
	private Dictionary<string, string> IL7()
	{
		if (WLw == null)
		{
			WLw = new Dictionary<string, string>();
		}
		return WLw;
	}

	protected void ClearCustomStringsCore()
	{
		if (WLw != null)
		{
			WLw.Clear();
		}
	}

	protected bool ContainsCustomStringCore(string name)
	{
		if (WLw == null)
		{
			return false;
		}
		return WLw.ContainsKey(name);
	}

	protected string GetCustomStringCore(string name)
	{
		if (WLw != null && WLw.ContainsKey(name))
		{
			return WLw[name];
		}
		return null;
	}

	protected string GetStringCore(string name, params object[] args)
	{
		string text = null;
		text = ((!ContainsCustomStringCore(name)) ? ResourceManager.GetString(name) : GetCustomStringCore(name));
		if (text == null || args == null || args.Length == 0)
		{
			return text;
		}
		return string.Format(CultureInfo.CurrentCulture, text, args);
	}

	protected void RemoveCustomStringCore(string name)
	{
		if (WLw != null && WLw.ContainsKey(name))
		{
			WLw.Remove(name);
		}
	}

	protected void SetCustomStringCore(string name, string value)
	{
		RemoveCustomStringCore(name);
		IL7().Add(name, value);
	}

	protected SRTextBase()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool Oqx()
	{
		return XqQ == null;
	}

	internal static SRTextBase lqT()
	{
		return XqQ;
	}
}
