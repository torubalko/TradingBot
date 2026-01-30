using System;
using System.Globalization;
using System.Reflection;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining.Implementation;

public class TokenOutliner<TOutliningSource> : IOutliner where TOutliningSource : TokenOutliningSourceBase
{
	internal static object u7R;

	public AutomaticOutliningUpdateTrigger UpdateTrigger => AutomaticOutliningUpdateTrigger.TextChanged;

	public TokenOutliner()
	{
		grA.DaB7cz();
		base._002Ector();
		int num = 0;
		try
		{
			ConstructorInfo[] constructors = typeof(TOutliningSource).GetConstructors(BindingFlags.Instance | BindingFlags.Public);
			if (constructors != null)
			{
				ConstructorInfo[] array = constructors;
				foreach (ConstructorInfo constructorInfo in array)
				{
					ParameterInfo[] parameters = constructorInfo.GetParameters();
					if (parameters != null && parameters.Length == 1 && typeof(ITextSnapshot).IsAssignableFrom(parameters[0].ParameterType))
					{
						num++;
					}
				}
			}
		}
		catch (Exception innerException)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExOutliningSourceConstructorNotFound), new object[1] { typeof(TOutliningSource).FullName }), innerException);
		}
		if (num == 0)
		{
			throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExOutliningSourceConstructorUnableToLoad), new object[1] { typeof(TOutliningSource).FullName }));
		}
	}

	public IOutliningSource GetOutliningSource(ITextSnapshot snapshot)
	{
		ConstructorInfo[] constructors = typeof(TOutliningSource).GetConstructors(BindingFlags.Instance | BindingFlags.Public);
		if (constructors != null)
		{
			ConstructorInfo[] array = constructors;
			foreach (ConstructorInfo constructorInfo in array)
			{
				ParameterInfo[] parameters = constructorInfo.GetParameters();
				if (parameters != null && parameters.Length == 1 && typeof(ITextSnapshot).IsAssignableFrom(parameters[0].ParameterType))
				{
					return constructorInfo.Invoke(new object[1] { snapshot }) as IOutliningSource;
				}
			}
		}
		return null;
	}

	internal static bool j7O()
	{
		return u7R == null;
	}

	internal static object q71()
	{
		return u7R;
	}
}
