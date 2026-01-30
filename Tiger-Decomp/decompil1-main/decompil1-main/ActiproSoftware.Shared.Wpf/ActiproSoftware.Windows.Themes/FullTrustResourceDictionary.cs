using System;
using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

public class FullTrustResourceDictionary : ResourceDictionary
{
	private static FullTrustResourceDictionary hME;

	public new Uri Source
	{
		get
		{
			return base.Source;
		}
		set
		{
			if (SecurityHelper.IsFullTrust)
			{
				base.Source = value;
			}
		}
	}

	public FullTrustResourceDictionary()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool RMx()
	{
		return hME == null;
	}

	internal static FullTrustResourceDictionary vMS()
	{
		return hME;
	}
}
