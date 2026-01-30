using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments.Implementation;

public class AdornmentManagerProvider<TManager> : IAdornmentManagerProvider where TManager : IAdornmentManager
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public ITextView view;

		internal static object LfA;

		public _003C_003Ec__DisplayClass3_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool ffl()
		{
			return LfA == null;
		}

		internal static object KfW()
		{
			return LfA;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_1
	{
		public ConstructorInfo constructor;

		public _003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals1;

		internal static object wfS;

		public _003C_003Ec__DisplayClass3_1()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal IAdornmentManager Qym()
		{
			return constructor.Invoke(new object[1] { CS_0024_003C_003E8__locals1.view }) as IAdornmentManager;
		}

		internal static bool Kfk()
		{
			return wfS == null;
		}

		internal static object vfZ()
		{
			return wfS;
		}
	}

	private object nnh;

	private static object Y1p;

	public AdornmentManagerProvider()
	{
		grA.DaB7cz();
		this._002Ector((object)null);
	}

	public AdornmentManagerProvider(object singletonKey)
	{
		grA.DaB7cz();
		base._002Ector();
		nnh = singletonKey;
		int num = 0;
		try
		{
			ConstructorInfo[] constructors = typeof(TManager).GetConstructors(BindingFlags.Instance | BindingFlags.Public);
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
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExAdornmentManagerConstructorUnableToLoad), new object[1] { typeof(TManager).FullName }), innerException);
		}
		if (num == 0)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExAdornmentManagerConstructorNotFound), new object[1] { typeof(TManager).FullName }));
		}
	}

	public IAdornmentManager GetAdornmentManager(ITextView view)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.view = view;
		if (_003C_003Ec__DisplayClass3_.view != null)
		{
			ConstructorInfo[] constructors = typeof(TManager).GetConstructors(BindingFlags.Instance | BindingFlags.Public);
			if (constructors != null)
			{
				ConstructorInfo[] array = constructors;
				for (int i = 0; i < array.Length; i++)
				{
					_003C_003Ec__DisplayClass3_1 CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass3_1();
					CS_0024_003C_003E8__locals9.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass3_;
					CS_0024_003C_003E8__locals9.constructor = array[i];
					ParameterInfo[] parameters = CS_0024_003C_003E8__locals9.constructor.GetParameters();
					if (parameters == null || parameters.Length != 1 || !parameters[0].ParameterType.IsAssignableFrom(CS_0024_003C_003E8__locals9.CS_0024_003C_003E8__locals1.view.GetType()))
					{
						continue;
					}
					if (nnh != null)
					{
						return CS_0024_003C_003E8__locals9.CS_0024_003C_003E8__locals1.view.Properties.GetOrCreateSingleton(nnh, () => CS_0024_003C_003E8__locals9.constructor.Invoke(new object[1] { CS_0024_003C_003E8__locals9.CS_0024_003C_003E8__locals1.view }) as IAdornmentManager);
					}
					return CS_0024_003C_003E8__locals9.constructor.Invoke(new object[1] { CS_0024_003C_003E8__locals9.CS_0024_003C_003E8__locals1.view }) as IAdornmentManager;
				}
			}
		}
		return null;
	}

	internal static bool e14()
	{
		return Y1p == null;
	}

	internal static object R1D()
	{
		return Y1p;
	}
}
