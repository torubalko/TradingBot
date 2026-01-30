using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using ActiproSoftware.Windows.Interop;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products;

public abstract class AssemblyInfo
{
	private static AssemblyInfo O1P;

	public Assembly Assembly => GetType().Assembly;

	public string Copyright
	{
		get
		{
			if (Attribute.GetCustomAttribute(Assembly, typeof(AssemblyCopyrightAttribute)) is AssemblyCopyrightAttribute { Copyright: var copyright })
			{
				return copyright;
			}
			return null;
		}
	}

	public string Description
	{
		get
		{
			if (!(Attribute.GetCustomAttribute(Assembly, typeof(AssemblyDescriptionAttribute)) is AssemblyDescriptionAttribute { Description: var description }))
			{
				return null;
			}
			return description;
		}
	}

	public abstract AssemblyLicenseType LicenseType { get; }

	public abstract AssemblyPlatform Platform { get; }

	public string Product
	{
		get
		{
			if (!(Attribute.GetCustomAttribute(Assembly, typeof(AssemblyProductAttribute)) is AssemblyProductAttribute { Product: var product }))
			{
				return null;
			}
			return product;
		}
	}

	public abstract string ProductCode { get; }

	public abstract int ProductId { get; }

	public string Title
	{
		get
		{
			if (!(Attribute.GetCustomAttribute(Assembly, typeof(AssemblyTitleAttribute)) is AssemblyTitleAttribute { Title: var title }))
			{
				return null;
			}
			return title;
		}
	}

	public string Version
	{
		get
		{
			Version assemblyVersion = GetAssemblyVersion();
			return string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129578), new object[3] { assemblyVersion.Major, assemblyVersion.Minor, assemblyVersion.Build });
		}
	}

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "System.Int32.TryParse(System.String,System.Int32@)")]
	internal static Version GetAssemblyVersion(string version)
	{
		int result = 1;
		int result2 = 0;
		int result3 = 0;
		int result4 = 0;
		if (version != null)
		{
			string[] array = version.Split('.');
			if (array.Length >= 1 && int.TryParse(array[0], out result) && array.Length >= 2 && int.TryParse(array[1], out result2) && array.Length >= 3 && int.TryParse(array[2], out result3) && array.Length >= 4 && !int.TryParse(array[3], out result4))
			{
			}
		}
		return new Version(result, result2, result3, result4);
	}

	public Version GetAssemblyVersion()
	{
		if (Attribute.GetCustomAttribute(Assembly, typeof(AssemblyInformationalVersionAttribute)) is AssemblyInformationalVersionAttribute assemblyInformationalVersionAttribute)
		{
			return GetAssemblyVersion(assemblyInformationalVersionAttribute.InformationalVersion);
		}
		return new Version(0, 0, 0, 0);
	}

	public Image GetImage(string name)
	{
		Image image = new Image();
		image.Source = GetImageSource(name);
		return image;
	}

	public ImageSource GetImageSource(string name)
	{
		Assembly assembly = Assembly;
		string text = assembly.FullName;
		int num = text.IndexOf(',');
		if (num != -1)
		{
			text = text.Substring(0, num).Trim();
		}
		string text2 = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129470) + text + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129520) + GetType().Namespace.Replace('.', '/').Substring(15) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129544) + name;
		if (!text2.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129564), StringComparison.OrdinalIgnoreCase))
		{
			return new BitmapImage(new Uri(text2));
		}
		StreamResourceInfo resourceStream = Application.GetResourceStream(new Uri(text2));
		bool flag = resourceStream != null;
		int num2 = 0;
		if (!F1W())
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		default:
			if (flag)
			{
				using (Stream stream = resourceStream.Stream)
				{
					return XamlReader.Load(stream) as ImageSource;
				}
			}
			break;
		case 1:
			break;
		}
		return null;
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	public bool ShowLicenseWindow(ActiproLicense license)
	{
		bool result = false;
		if (license != null)
		{
			Window topWindow = NativeMethods.GetTopWindow();
			LicenseWindow licenseWindow = new LicenseWindow(license);
			licenseWindow.Owner = topWindow;
			bool? flag = licenseWindow.ShowDialog();
			bool flag2 = true;
			int num = 0;
			if (U1z() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			result = flag == flag2;
			licenseWindow = null;
		}
		return result;
	}

	protected AssemblyInfo()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool F1W()
	{
		return O1P == null;
	}

	internal static AssemblyInfo U1z()
	{
		return O1P;
	}
}
