using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products;

[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class SRBase
{
	private Dictionary<string, string> Aql;

	internal static SRBase VgF;

	public abstract ResourceManager ResourceManager { get; }

	[SpecialName]
	private Dictionary<string, string> Pq0()
	{
		if (Aql == null)
		{
			Aql = new Dictionary<string, string>();
		}
		return Aql;
	}

	protected void ClearCustomStringsCore()
	{
		if (Aql != null)
		{
			Aql.Clear();
		}
	}

	protected bool ContainsCustomStringCore(string name)
	{
		if (Aql == null)
		{
			return false;
		}
		return Aql.ContainsKey(name);
	}

	protected string GetCustomStringCore(string name)
	{
		if (Aql != null && Aql.ContainsKey(name))
		{
			return Aql[name];
		}
		return null;
	}

	protected string GetStringCore(string name, params object[] args)
	{
		string text = null;
		text = ((!ContainsCustomStringCore(name)) ? ResourceManager.GetString(name) : GetCustomStringCore(name));
		if (text == null || args == null || args.Length == 0)
		{
			int num = 0;
			if (!rgd())
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => text, 
			};
		}
		return string.Format(CultureInfo.CurrentCulture, text, args);
	}

	protected void RemoveCustomStringCore(string name)
	{
		if (Aql != null && Aql.ContainsKey(name))
		{
			Aql.Remove(name);
		}
	}

	protected void SetCustomStringCore(string name, string value)
	{
		RemoveCustomStringCore(name);
		Pq0().Add(name, value);
	}

	protected SRBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool rgd()
	{
		return VgF == null;
	}

	internal static SRBase Dgv()
	{
		return VgF;
	}
}
