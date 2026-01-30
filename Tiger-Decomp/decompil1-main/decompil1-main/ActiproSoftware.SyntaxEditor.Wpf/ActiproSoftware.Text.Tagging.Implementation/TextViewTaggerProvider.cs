using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Text.Tagging.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
public class TextViewTaggerProvider<TTagger> : TaggerProviderBase<TTagger>, ITextViewTaggerProvider where TTagger : class
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0<T> where T : ITag
	{
		public ITextView view;

		internal static object Ufz;

		public _003C_003Ec__DisplayClass3_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool mim()
		{
			return Ufz == null;
		}

		internal static object sip()
		{
			return Ufz;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_1<T> where T : ITag
	{
		public ConstructorInfo constructor;

		public _003C_003Ec__DisplayClass3_0<T> CS_0024_003C_003E8__locals1;

		private static object Hi4;

		public _003C_003Ec__DisplayClass3_1()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal ITagger<T> Eyq()
		{
			return constructor.Invoke(new object[1] { CS_0024_003C_003E8__locals1.view }) as ITagger<T>;
		}

		internal static bool WiD()
		{
			return Hi4 == null;
		}

		internal static object SiB()
		{
			return Hi4;
		}
	}

	private object MIB;

	private static object T5U;

	public TextViewTaggerProvider()
	{
		grA.DaB7cz();
		this._002Ector((object)null);
	}

	public TextViewTaggerProvider(object singletonKey)
	{
		grA.DaB7cz();
		base._002Ector();
		MIB = singletonKey;
		int num = 0;
		try
		{
			ConstructorInfo[] constructors = typeof(TTagger).GetConstructors(BindingFlags.Instance | BindingFlags.Public);
			if (constructors != null)
			{
				ConstructorInfo[] array = constructors;
				foreach (ConstructorInfo constructorInfo in array)
				{
					ParameterInfo[] parameters = constructorInfo.GetParameters();
					if (parameters != null && parameters.Length == 1 && typeof(ITextView).IsAssignableFrom(parameters[0].ParameterType))
					{
						num++;
					}
				}
			}
		}
		catch (Exception innerException)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExTaggerConstructorUnableToLoad), new object[1] { typeof(TTagger).FullName }), innerException);
		}
		if (num == 0)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExTaggerConstructorNotFound), new object[1] { typeof(TTagger).FullName }));
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	public ITagger<T> GetTagger<T>(ITextView view) where T : ITag
	{
		_003C_003Ec__DisplayClass3_0<T> _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0<T>();
		_003C_003Ec__DisplayClass3_.view = view;
		if (_003C_003Ec__DisplayClass3_.view != null)
		{
			ConstructorInfo[] constructors = typeof(TTagger).GetConstructors(BindingFlags.Instance | BindingFlags.Public);
			if (constructors != null)
			{
				ConstructorInfo[] array = constructors;
				for (int i = 0; i < array.Length; i++)
				{
					_003C_003Ec__DisplayClass3_1<T> CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass3_1<T>();
					CS_0024_003C_003E8__locals9.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass3_;
					CS_0024_003C_003E8__locals9.constructor = array[i];
					ParameterInfo[] parameters = CS_0024_003C_003E8__locals9.constructor.GetParameters();
					if (parameters == null || parameters.Length != 1 || !parameters[0].ParameterType.IsAssignableFrom(CS_0024_003C_003E8__locals9.CS_0024_003C_003E8__locals1.view.GetType()))
					{
						continue;
					}
					if (MIB != null)
					{
						return CS_0024_003C_003E8__locals9.CS_0024_003C_003E8__locals1.view.Properties.GetOrCreateSingleton(MIB, () => CS_0024_003C_003E8__locals9.constructor.Invoke(new object[1] { CS_0024_003C_003E8__locals9.CS_0024_003C_003E8__locals1.view }) as ITagger<T>);
					}
					return CS_0024_003C_003E8__locals9.constructor.Invoke(new object[1] { CS_0024_003C_003E8__locals9.CS_0024_003C_003E8__locals1.view }) as ITagger<T>;
				}
			}
		}
		return null;
	}

	internal static bool u5e()
	{
		return T5U == null;
	}

	internal static object X5z()
	{
		return T5U;
	}
}
