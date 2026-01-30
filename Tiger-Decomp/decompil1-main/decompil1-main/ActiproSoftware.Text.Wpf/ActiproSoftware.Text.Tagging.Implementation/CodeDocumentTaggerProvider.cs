using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Tagging.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
public class CodeDocumentTaggerProvider<TTagger> : TaggerProviderBase<TTagger>, ICodeDocumentTaggerProvider where TTagger : class
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0<T> where T : ITag
	{
		public CodeDocumentTaggerProvider<TTagger> _003C_003E4__this;

		public ICodeDocument document;

		private static object ocx;

		public _003C_003Ec__DisplayClass4_0()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal ITagger<T> Dqj()
		{
			return _003C_003E4__this.n9l.Invoke(new object[1] { document }) as ITagger<T>;
		}

		internal static bool lcT()
		{
			return ocx == null;
		}

		internal static object Jck()
		{
			return ocx;
		}
	}

	private ConstructorInfo n9l;

	private object S9i;

	private static object HAW;

	public CodeDocumentTaggerProvider()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector((object)null);
	}

	public CodeDocumentTaggerProvider(object singletonKey)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		S9i = singletonKey;
		try
		{
			n9l = typeof(TTagger).GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, new Type[1] { typeof(ICodeDocument) }, null);
			if (!(n9l == null))
			{
				return;
			}
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExTaggerConstructorNotFound), new object[1] { typeof(TTagger).FullName }));
		}
		catch (Exception innerException)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExTaggerConstructorUnableToLoad), new object[1] { typeof(TTagger).FullName }), innerException);
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	public ITagger<T> GetTagger<T>(ICodeDocument document) where T : ITag
	{
		_003C_003Ec__DisplayClass4_0<T> CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass4_0<T>();
		CS_0024_003C_003E8__locals7._003C_003E4__this = this;
		CS_0024_003C_003E8__locals7.document = document;
		if (CS_0024_003C_003E8__locals7.document == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5516));
		}
		if (S9i != null)
		{
			return CS_0024_003C_003E8__locals7.document.Properties.GetOrCreateSingleton(S9i, () => CS_0024_003C_003E8__locals7._003C_003E4__this.n9l.Invoke(new object[1] { CS_0024_003C_003E8__locals7.document }) as ITagger<T>);
		}
		return n9l.Invoke(new object[1] { CS_0024_003C_003E8__locals7.document }) as ITagger<T>;
	}

	internal static bool UAn()
	{
		return HAW == null;
	}

	internal static object CAA()
	{
		return HAW;
	}
}
