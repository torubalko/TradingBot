using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

public abstract class ThemeCatalogBase
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public string EqM;

		public Func<string, bool> pqK;

		private static _003C_003Ec__DisplayClass2_0 j8f;

		public _003C_003Ec__DisplayClass2_0()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal bool rqN(string t)
		{
			return string.Equals(t, EqM, StringComparison.OrdinalIgnoreCase);
		}

		internal static bool H87()
		{
			return j8f == null;
		}

		internal static _003C_003Ec__DisplayClass2_0 S8H()
		{
			return j8f;
		}
	}

	internal static ThemeCatalogBase MYK;

	public abstract IEnumerable<ThemedResourceDictionaryReference> DictionaryReferences { get; }

	public virtual int Priority => 0;

	public IEnumerable<ThemedResourceDictionaryReference> GetDictionaryReferencesForTheme(string theme)
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass2_0();
		CS_0024_003C_003E8__locals3.EqM = theme;
		IEnumerable<ThemedResourceDictionaryReference> references = DictionaryReferences;
		if (references == null)
		{
			yield break;
		}
		foreach (ThemedResourceDictionaryReference reference in references)
		{
			IEnumerable<string> referenceThemes = reference.Themes;
			if (referenceThemes != null && CS_0024_003C_003E8__locals3.EqM != null)
			{
				bool any = referenceThemes.Any((string t) => string.Equals(t, CS_0024_003C_003E8__locals3.EqM, StringComparison.OrdinalIgnoreCase));
				if (any == reference.AreThemesExclusive)
				{
					continue;
				}
			}
			yield return reference;
		}
	}

	protected ThemeCatalogBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool qYM()
	{
		return MYK == null;
	}

	internal static ThemeCatalogBase VYY()
	{
		return MYK;
	}
}
