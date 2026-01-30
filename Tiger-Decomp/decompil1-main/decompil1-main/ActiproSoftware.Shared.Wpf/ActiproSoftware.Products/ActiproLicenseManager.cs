using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Interop;
using System.Windows.Threading;
using ActiproSoftware.Products.Shared;
using dg3ypDAonQcOidMs0w;
using Microsoft.Win32;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro")]
public static class ActiproLicenseManager
{
	private class Ma
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public ActiproLicense X67;

			public LicenseException D6F;

			public Ma n6o;

			internal static _003C_003Ec__DisplayClass3_0 Bwg;

			public _003C_003Ec__DisplayClass3_0()
			{
				hHEYokUTtehNq5ji0d.LrmWXz();
				base._002Ector();
			}

			internal void W6e()
			{
				ShowLicenseUIAndThrowLicenseException(X67, D6F, n6o.m6T);
			}

			internal static bool Sw8()
			{
				return Bwg == null;
			}

			internal static _003C_003Ec__DisplayClass3_0 mwj()
			{
				return Bwg;
			}
		}

		private Control m6T;

		private LicenseException a6B;

		private ActiproLicense s6p;

		internal static Ma b6R;

		public Ma(ActiproLicense P_0, LicenseException P_1, object P_2)
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass3_0();
			CS_0024_003C_003E8__locals9.X67 = P_0;
			CS_0024_003C_003E8__locals9.D6F = P_1;
			base._002Ector();
			CS_0024_003C_003E8__locals9.n6o = this;
			if (CS_0024_003C_003E8__locals9.X67 == null)
			{
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(137014));
			}
			if (P_2 == null)
			{
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(137032));
			}
			s6p = CS_0024_003C_003E8__locals9.X67;
			m6T = P_2 as Control;
			a6B = CS_0024_003C_003E8__locals9.D6F;
			if (m6T != null)
			{
				m6T.Loaded += Y6v;
				return;
			}
			Dispatcher.CurrentDispatcher?.BeginInvoke(DispatcherPriority.Loaded, (Action)delegate
			{
				ShowLicenseUIAndThrowLicenseException(CS_0024_003C_003E8__locals9.X67, CS_0024_003C_003E8__locals9.D6F, CS_0024_003C_003E8__locals9.n6o.m6T);
			});
		}

		private void Y6v(object P_0, RoutedEventArgs P_1)
		{
			m6T.Loaded -= Y6v;
			m6T.Dispatcher.BeginInvoke(DispatcherPriority.Loaded, (Action)delegate
			{
				ShowLicenseUIAndThrowLicenseException(s6p, a6B, m6T);
			});
		}

		[CompilerGenerated]
		private void l6X()
		{
			ShowLicenseUIAndThrowLicenseException(s6p, a6B, m6T);
		}

		internal static bool S69()
		{
			return b6R == null;
		}

		internal static Ma J6c()
		{
			return b6R;
		}
	}

	private class R5
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string F6m;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string S6w;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string S64;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ActiproLicenseSourceLocation I6u;

		internal static R5 d6u;

		public string Licensee
		{
			[CompilerGenerated]
			get
			{
				return F6m;
			}
			[CompilerGenerated]
			set
			{
				F6m = f6m;
			}
		}

		public string LicenseKey
		{
			[CompilerGenerated]
			get
			{
				return S6w;
			}
			[CompilerGenerated]
			set
			{
				S6w = s6w;
			}
		}

		[SpecialName]
		[CompilerGenerated]
		public string B6S()
		{
			return S64;
		}

		[SpecialName]
		[CompilerGenerated]
		public void G63(string P_0)
		{
			S64 = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public ActiproLicenseSourceLocation l6J()
		{
			return I6u;
		}

		[SpecialName]
		[CompilerGenerated]
		public void b69(ActiproLicenseSourceLocation P_0)
		{
			I6u = P_0;
		}

		public R5()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal static bool R6o()
		{
			return d6u == null;
		}

		internal static R5 g65()
		{
			return d6u;
		}
	}

	private enum Jh
	{
		None
	}

	private class O0 : AssemblyInfo
	{
		private static O0 q6I;

		public override AssemblyLicenseType LicenseType => AssemblyLicenseType.Full;

		public override AssemblyPlatform Platform => AssemblyPlatform.Wpf;

		public sealed override string ProductCode => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135502);

		public sealed override int ProductId => 0;

		public O0()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal static bool s6D()
		{
			return q6I == null;
		}

		internal static O0 A62()
		{
			return q6I;
		}
	}

	private static Dictionary<Type, ActiproLicense> Ua3;

	private static Dictionary<Type, R5> Cat;

	private static List<string> saJ;

	private static bool? xa9;

	private static bool? Bah;

	private static object Tam;

	private static Jh uaw;

	internal static ActiproLicenseManager V1o;

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static ActiproLicenseManager()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		Tam = new object();
	}

	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "Actipro")]
	private static void Un8(FrameworkElement P_0, ActiproLicense P_1)
	{
		if (P_1 != null)
		{
			AdornerLayer.GetAdornerLayer(P_0)?.Add(new LicenseAdorner(P_1, P_0));
			return;
		}
		throw new LicenseException(P_0.GetType(), string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126578), new object[1] { P_0.GetType().FullName }));
	}

	internal static string DecryptString(string source, int key)
	{
		int length = source.Length;
		int[] array = new int[length];
		int num = 11 + key % 233;
		int num2 = 7 + key % 239;
		int num3 = 5 + key % 241;
		int num4 = 3 + key % 251;
		for (int i = 0; i < length; i++)
		{
			if (source[i] == 'Ā')
			{
				array[i] = 0;
			}
			else
			{
				array[i] = source[i];
			}
		}
		for (int i = 0; i < length - 2; i++)
		{
			array[i] = array[i] ^ array[i + 2] ^ (num4 * array[i + 1] % 256);
		}
		for (int i = length - 1; i >= 2; i--)
		{
			array[i] = array[i] ^ array[i - 2] ^ (num3 * array[i - 1] % 256);
		}
		for (int i = 0; i < length - 1; i++)
		{
			array[i] = array[i] ^ array[i + 1] ^ (num2 * array[i + 1] % 256);
		}
		for (int i = length - 1; i >= 1; i--)
		{
			array[i] = array[i] ^ array[i - 1] ^ (num * array[i - 1] % 256);
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < length; i++)
		{
			stringBuilder.Append((char)array[i]);
		}
		return stringBuilder.ToString();
	}

	private static string BnD(string P_0, int P_1)
	{
		int length = P_0.Length;
		int[] array = new int[length];
		int num = 11 + P_1 % 233;
		int num2 = 7 + P_1 % 239;
		int num3 = 5 + P_1 % 241;
		int num4 = 3 + P_1 % 251;
		for (int i = 0; i < length; i++)
		{
			array[i] = P_0[i];
		}
		for (int i = 1; i < length; i++)
		{
			array[i] = array[i] ^ array[i - 1] ^ (num * array[i - 1] % 256);
		}
		for (int i = length - 2; i >= 0; i--)
		{
			array[i] = array[i] ^ array[i + 1] ^ (num2 * array[i + 1] % 256);
		}
		for (int i = 2; i < length; i++)
		{
			array[i] = array[i] ^ array[i - 2] ^ (num3 * array[i - 1] % 256);
		}
		for (int i = length - 3; i >= 0; i--)
		{
			array[i] = array[i] ^ array[i + 2] ^ (num4 * array[i + 1] % 256);
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < length; i++)
		{
			if (array[i] == 0)
			{
				stringBuilder.Append('Ā');
			}
			else
			{
				stringBuilder.Append((char)array[i]);
			}
		}
		return stringBuilder.ToString();
	}

	private static int PnP()
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
			{
				for (int i = 0; i < WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126684).Length; i++)
				{
					num3 += WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126684)[i];
				}
				return num3;
			}
			case 1:
				num3 = 0;
				num2 = 0;
				if (M15())
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	internal static ActiproLicense GetLicense(AssemblyInfo assemblyInfo, LicenseContext context)
	{
		if (assemblyInfo == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126704));
		}
		ActiproLicense value = null;
		if (Ua3 == null || !Ua3.TryGetValue(assemblyInfo.GetType(), out value))
		{
			value = rnG(assemblyInfo, context);
			if (Ua3 == null)
			{
				Ua3 = new Dictionary<Type, ActiproLicense>();
			}
			Ua3[assemblyInfo.GetType()] = value;
		}
		return value;
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static ActiproLicense rnG(AssemblyInfo P_0, LicenseContext P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126704));
		}
		string licensee = string.Empty;
		string text = string.Empty;
		ActiproLicenseSourceLocation sourceLocation = ActiproLicenseSourceLocation.None;
		AlgorithmGLicenseDecryptor algorithmGLicenseDecryptor = null;
		AlgorithmGLicenseDecryptor.LicenseExceptionType exceptionType = AlgorithmGLicenseDecryptor.LicenseExceptionType.InvalidLicensee;
		bool flag = true;
		int num = PnP();
		IEnumerable<R5> enumerable = hn1(P_0, P_1, num);
		foreach (R5 item in enumerable)
		{
			string text2 = item?.Licensee ?? string.Empty;
			string text3 = item?.LicenseKey ?? string.Empty;
			ActiproLicenseSourceLocation actiproLicenseSourceLocation = item?.l6J() ?? ActiproLicenseSourceLocation.None;
			AlgorithmGLicenseDecryptor algorithmGLicenseDecryptor2 = null;
			AlgorithmGLicenseDecryptor.LicenseExceptionType licenseExceptionType = AlgorithmGLicenseDecryptor.LicenseExceptionType.None;
			bool flag2 = true;
			try
			{
				if (text2.Length == 0)
				{
					licenseExceptionType = AlgorithmGLicenseDecryptor.LicenseExceptionType.InvalidLicensee;
				}
				else if (text3.Length == 0)
				{
					licenseExceptionType = AlgorithmGLicenseDecryptor.LicenseExceptionType.InvalidLicenseKeyLength;
				}
				else
				{
					algorithmGLicenseDecryptor2 = new AlgorithmGLicenseDecryptor(text2, text3);
					flag2 = false;
					if (P_1 != null && P_1.UsageMode == LicenseUsageMode.Designtime && algorithmGLicenseDecryptor2.UsageAllowed == AlgorithmGLicenseDecryptor.LicenseUsageAllowed.RuntimeOnly)
					{
						licenseExceptionType = AlgorithmGLicenseDecryptor.LicenseExceptionType.DesignModeProhibited;
					}
				}
			}
			catch (AlgorithmGLicenseDecryptor.LicenseException ex)
			{
				licenseExceptionType = (AlgorithmGLicenseDecryptor.LicenseExceptionType)ex.ExceptionType;
			}
			catch
			{
				licenseExceptionType = AlgorithmGLicenseDecryptor.LicenseExceptionType.Other;
			}
			bool flag3 = !flag2 && licenseExceptionType == AlgorithmGLicenseDecryptor.LicenseExceptionType.None && algorithmGLicenseDecryptor2 != null && algorithmGLicenseDecryptor2.LicenseType == AssemblyLicenseType.Full && ((uint)algorithmGLicenseDecryptor2.ProductCodes & (uint)P_0.ProductId) == (uint)P_0.ProductId;
			if (string.IsNullOrEmpty(text) || flag3)
			{
				licensee = text2;
				text = text3;
				sourceLocation = actiproLicenseSourceLocation;
				algorithmGLicenseDecryptor = algorithmGLicenseDecryptor2;
				exceptionType = licenseExceptionType;
				flag = flag2;
				if (flag3)
				{
					break;
				}
			}
		}
		ActiproLicense actiproLicense = ((!flag) ? new ActiproLicense(P_0, licensee, text, sourceLocation, (int)exceptionType, (uint)algorithmGLicenseDecryptor.ProductCodes, algorithmGLicenseDecryptor.MajorVersion, algorithmGLicenseDecryptor.MinorVersion, algorithmGLicenseDecryptor.LicenseType, algorithmGLicenseDecryptor.LicenseCount, algorithmGLicenseDecryptor.Platform, algorithmGLicenseDecryptor.OrganizationID, algorithmGLicenseDecryptor.Date) : new ActiproLicense(P_0, licensee, text, sourceLocation, (int)exceptionType));
		if (P_1 != null && algorithmGLicenseDecryptor != null && actiproLicense.IsValid)
		{
			AaT(P_1, Vai(), num, algorithmGLicenseDecryptor);
		}
		if (actiproLicense.IsValid && actiproLicense.LicenseType == AssemblyLicenseType.Full && (actiproLicense.ProductIDs & P_0.ProductId) != P_0.ProductId)
		{
			actiproLicense.SetExceptionType(42);
		}
		return actiproLicense;
	}

	private static IEnumerable<R5> hn1(AssemblyInfo P_0, LicenseContext P_1, int P_2)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126704));
		}
		R5 info = sav(P_0, P_2);
		if (info != null)
		{
			yield return info;
		}
		if (P_1 == null || P_1.UsageMode != LicenseUsageMode.Designtime)
		{
			info = Yaj(P_1, Vai(), P_2);
			if (info != null)
			{
				yield return info;
			}
			info = qnz(Assembly.GetEntryAssembly(), Vai(), P_2);
			if (info != null)
			{
				yield return info;
			}
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			if (saJ != null)
			{
				Assembly[] array = assemblies;
				foreach (Assembly assembly in array)
				{
					string fullName = assembly.FullName;
					if (string.IsNullOrEmpty(fullName))
					{
						continue;
					}
					foreach (string hintAssemblyName in saJ)
					{
						if (fullName.StartsWith(hintAssemblyName, StringComparison.OrdinalIgnoreCase))
						{
							info = qnz(assembly, Vai(), P_2);
							if (info != null)
							{
								yield return info;
							}
						}
					}
				}
			}
			Assembly[] array2 = assemblies;
			foreach (Assembly assembly2 in array2)
			{
				try
				{
					if (assembly2.ManifestModule != null && assembly2.ManifestModule.Name == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(137052))
					{
						continue;
					}
				}
				catch
				{
				}
				info = qnz(assembly2, Vai(), P_2);
				if (info != null)
				{
					yield return info;
				}
			}
		}
		string assemblyVersion = P_0.Version.Substring(0, 4);
		string primaryRegKeyName = string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126924), new object[2]
		{
			WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127018),
			assemblyVersion
		});
		string secondaryRegKeyName = string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(137092), new object[2]
		{
			WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127018),
			assemblyVersion
		});
		info = saX(primaryRegKeyName) ?? saX(secondaryRegKeyName);
		if (info != null)
		{
			yield return info;
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	private static R5 qnz(Assembly P_0, Type P_1, int P_2)
	{
		string text = null;
		string text2 = null;
		string text3 = null;
		if (P_0 != null && !P_0.IsDynamic)
		{
			try
			{
				string[] manifestResourceNames = P_0.GetManifestResourceNames();
				string[] array = manifestResourceNames;
				foreach (string text4 in array)
				{
					if (!text4.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126732), StringComparison.OrdinalIgnoreCase))
					{
						continue;
					}
					if (!Nap())
					{
						using Stream stream = P_0.GetManifestResourceStream(text4);
						if (stream == null)
						{
							continue;
						}
						object obj = new BinaryFormatter().Deserialize(stream);
						if (obj != null && P_1 != null)
						{
							object[] array2 = (object[])obj;
							Hashtable hashtable = (Hashtable)array2[1];
							object obj2 = hashtable[P_1.AssemblyQualifiedName];
							if (obj2 != null)
							{
								text3 = obj2.ToString();
								break;
							}
						}
					}
					else
					{
						if (text4.IndexOf(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126754), StringComparison.OrdinalIgnoreCase) == -1)
						{
							continue;
						}
						using Stream stream2 = P_0.GetManifestResourceStream(text4);
						if (stream2 != null)
						{
							StreamReader streamReader = new StreamReader(stream2);
							text = streamReader.ReadLine();
							text2 = streamReader.ReadLine();
							text3 = streamReader.ReadToEnd();
							break;
						}
					}
				}
			}
			catch
			{
			}
		}
		if (text3 != null)
		{
			R5 r = Sac(text3, P_2);
			if (r != null && Nap())
			{
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				bool flag = false;
				Assembly[] array3 = assemblies;
				foreach (Assembly assembly in array3)
				{
					if (assembly.FullName.StartsWith(r.B6S() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110902), StringComparison.OrdinalIgnoreCase))
					{
						flag = true;
						break;
					}
				}
				if (!flag || r.Licensee != text || r.B6S() != text2)
				{
					return null;
				}
			}
			return r;
		}
		return null;
	}

	private static R5 Sac(string P_0, int P_1)
	{
		if (P_0 != null)
		{
			P_0 = DecryptString(P_0, P_1);
			string[] array = P_0.Split(';');
			int num = ((!Nap()) ? (-1) : 0);
			int num2 = num;
			int num3 = num + 1;
			int num4 = num + 2;
			if (!string.IsNullOrEmpty(array[num4]) && !string.IsNullOrEmpty(array[num3]))
			{
				R5 r = new R5();
				r.Licensee = array[num4];
				r.LicenseKey = array[num3];
				r.b69(ActiproLicenseSourceLocation.AssemblySavedContext);
				r.G63((num2 >= 0) ? array[num2] : null);
				return r;
			}
		}
		return null;
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	private static R5 Yaj(LicenseContext P_0, Type P_1, int P_2)
	{
		string text = null;
		if (P_1 != null && P_0 != null && !Nap())
		{
			try
			{
				text = P_0.GetSavedLicenseKey(P_1, null);
			}
			catch
			{
			}
		}
		if (!string.IsNullOrEmpty(text))
		{
			return Sac(text, P_2);
		}
		return null;
	}

	private static R5 sav(AssemblyInfo P_0, int P_1)
	{
		if (Cat != null && P_0 != null)
		{
			if (Cat.TryGetValue(P_0.GetType(), out var value))
			{
				R5 r = new R5();
				r.Licensee = DecryptString(value.Licensee, P_1);
				r.LicenseKey = DecryptString(value.LicenseKey, P_1);
				r.b69(ActiproLicenseSourceLocation.Fixed);
				return r;
			}
			if (Cat.TryGetValue(typeof(O0), out value))
			{
				R5 r2 = new R5();
				r2.Licensee = DecryptString(value.Licensee, P_1);
				r2.LicenseKey = DecryptString(value.LicenseKey, P_1);
				r2.b69(ActiproLicenseSourceLocation.Fixed);
				return r2;
			}
		}
		return null;
	}

	private static R5 saX(string P_0)
	{
		if (!Nap())
		{
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(P_0);
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.OpenSubKey(P_0);
				}
				if (registryKey != null)
				{
					string text = (registryKey.GetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126790)) as string) ?? string.Empty;
					string text2 = (registryKey.GetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126810)) as string) ?? string.Empty;
					registryKey.Close();
					if (!string.IsNullOrEmpty(text2))
					{
						if (string.IsNullOrEmpty(text))
						{
							text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126834);
						}
						R5 r = new R5();
						r.Licensee = text.Trim();
						r.LicenseKey = text2.ToUpper(CultureInfo.InvariantCulture).Trim();
						r.b69(ActiproLicenseSourceLocation.Registry);
						return r;
					}
				}
			}
			catch (ArgumentNullException)
			{
			}
			catch (ArgumentException)
			{
			}
			catch (IOException)
			{
			}
			catch (ObjectDisposedException)
			{
			}
			catch (SecurityException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
		}
		return null;
	}

	[SpecialName]
	private static bool Nap()
	{
		if (!xa9.HasValue)
		{
			xa9 = BrowserInteropHelper.IsBrowserHosted;
		}
		return xa9.Value;
	}

	[SpecialName]
	private static bool Pay()
	{
		if (!Bah.HasValue)
		{
			DependencyObject element = new DependencyObject();
			Bah = DesignerProperties.GetIsInDesignMode(element);
		}
		return Bah.Value;
	}

	[SpecialName]
	private static Type Vai()
	{
		return typeof(ActiproLicenseToken);
	}

	private static void AaT(LicenseContext P_0, Type P_1, int P_2, AlgorithmGLicenseDecryptor P_3)
	{
		if (P_0 != null)
		{
			if (P_1 == null)
			{
				int num = 0;
				if (j1m() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126870));
				}
			}
			if (P_3 == null)
			{
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126896));
			}
			P_3.UsageAllowed = AlgorithmGLicenseDecryptor.LicenseUsageAllowed.RuntimeOnly;
			P_0.SetSavedLicenseKey(P_1, BnD(P_3.LicenseKey + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126918) + P_3.Licensee, P_2));
			return;
		}
		throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117002));
	}

	internal static void ShowLicenseUIAndThrowLicenseException(ActiproLicense license, LicenseException exception, object instance)
	{
		if (Pay())
		{
			return;
		}
		if (uaw == Jh.None && license != null)
		{
			AssemblyInfo assemblyInfo = license.AssemblyInfo;
			if (assemblyInfo != null)
			{
				if (Nap())
				{
					if (instance is FrameworkElement frameworkElement)
					{
						Un8(frameworkElement, license);
					}
				}
				else
				{
					uaw = (Jh)1;
					try
					{
						if (assemblyInfo.ShowLicenseWindow(license))
						{
							exception = null;
						}
					}
					finally
					{
						uaw = (Jh)2;
					}
				}
			}
		}
		if ((uaw != (Jh)1 || exception == null) && exception != null)
		{
			throw exception;
		}
	}

	internal static void StartEvaluationInRegistry(string licensee)
	{
		if (!Nap())
		{
			string version = ActiproSoftware.Products.Shared.AssemblyInfo.Instance.Version;
			string text = version.Substring(0, 4);
			byte majorVersion = byte.Parse(version.Substring(0, 2));
			byte minorVersion = byte.Parse(version.Substring(3, 1));
			int num = 0;
			if (!M15())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			string text2 = string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126924), new object[2]
			{
				WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127018),
				text
			});
			string value = new AlgorithmGLicenseEncryptor().EncryptEvaluation(AlgorithmGLicenseProductCodes.All, majorVersion, minorVersion, ActiproSoftware.Products.Shared.AssemblyInfo.Instance.Platform, licensee);
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(text2);
				if (registryKey != null)
				{
					registryKey.Close();
					throw new ApplicationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127046));
				}
				if (registryKey == null)
				{
					registryKey = Registry.CurrentUser.CreateSubKey(text2, RegistryKeyPermissionCheck.ReadWriteSubTree);
					if (registryKey != null)
					{
						registryKey.SetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127404), DateTime.Today.ToShortDateString());
						registryKey.SetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126790), licensee);
						int num3 = 0;
						if (j1m() != null)
						{
							int num4 = default(int);
							num3 = num4;
						}
						switch (num3)
						{
						}
						registryKey.SetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126810), value);
						registryKey.SetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127430), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127456));
						registryKey.SetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127496), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127522));
						registryKey.SetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127616), Environment.UserName);
						registryKey.Close();
						return;
					}
					throw new ApplicationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127636));
				}
			}
			catch (ArgumentNullException)
			{
			}
			catch (ArgumentException)
			{
			}
			catch (IOException)
			{
			}
			catch (ObjectDisposedException)
			{
			}
			catch (SecurityException)
			{
			}
			catch (UnauthorizedAccessException)
			{
			}
			throw new ApplicationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127996));
		}
		throw new ApplicationException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(128366));
	}

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "ActiproSoftware.Products.ActiproLicenseManager+DelayedLicenseUIRenderer")]
	private static void waB(ActiproLicense P_0, Type P_1, object P_2)
	{
		LicenseException ex = null;
		bool flag = true;
		bool isValid = default(bool);
		int num;
		if (P_0 != null)
		{
			if (P_0.LicenseType != AssemblyLicenseType.Full || !P_0.IsUnlicensedProduct)
			{
				isValid = P_0.IsValid;
				num = 2;
				goto IL_0009;
			}
			flag = false;
		}
		goto IL_009a;
		IL_0009:
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				break;
			case 1:
				goto end_IL_0009;
			}
			if (isValid)
			{
				if (P_0.LicenseType == AssemblyLicenseType.Full)
				{
					num = 0;
					if (j1m() != null)
					{
						num = num2;
					}
					continue;
				}
				flag = false;
			}
			goto IL_009a;
			continue;
			end_IL_0009:
			break;
		}
		if (P_0 != null && P_0.AssemblyInfo != null)
		{
			new Ma(P_0, ex, P_2);
			return;
		}
		goto IL_01d4;
		IL_01d4:
		ShowLicenseUIAndThrowLicenseException(P_0, ex, P_2);
		return;
		IL_009a:
		if (flag && ex == null && !Nap())
		{
			string text = string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(128454), new object[1] { P_1 });
			if (P_0 != null)
			{
				text += string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(128910), new object[3]
				{
					Environment.NewLine,
					P_0.GetQuickInfo(),
					P_0.GetDetails()
				});
			}
			ex = new LicenseException(P_1, text);
		}
		if (uaw == Jh.None)
		{
			num = 1;
			if (j1m() == null)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_01d4;
	}

	public static void AddHintAssemblyName(string assemblyName)
	{
		if (string.IsNullOrEmpty(assemblyName))
		{
			return;
		}
		bool flag = saJ == null;
		int num = 0;
		if (j1m() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			saJ = new List<string>();
		}
		assemblyName = assemblyName.Trim();
		if (assemblyName.IndexOf(',') == -1)
		{
			assemblyName += WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110902);
		}
		if (!saJ.Contains(assemblyName))
		{
			saJ.Add(assemblyName);
		}
	}

	public static string GetWatermarkText(AssemblyLicenseType licenseType)
	{
		if (licenseType != AssemblyLicenseType.Evaluation)
		{
			return null;
		}
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(128984);
	}

	public static void RegisterLicense(string licensee, string licenseKey)
	{
		RegisterLicense(new O0(), licensee, licenseKey);
	}

	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "licenseKey")]
	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "RegisterLicense")]
	[SuppressMessage("Microsoft.Naming", "CA2204:Literals should be spelled correctly", MessageId = "ActiproLicenseManager")]
	public static void RegisterLicense(AssemblyInfo assemblyInfo, string licensee, string licenseKey)
	{
		if (assemblyInfo == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126704));
		}
		if (string.IsNullOrEmpty(licensee))
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129008));
		}
		if (string.IsNullOrEmpty(licenseKey))
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129028));
		}
		Type type = assemblyInfo.GetType();
		if (assemblyInfo is O0 && Cat != null && Cat.ContainsKey(type))
		{
			throw new NotSupportedException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129052));
		}
		int num = PnP();
		if (Cat == null)
		{
			Cat = new Dictionary<Type, R5>();
		}
		Dictionary<Type, R5> cat = Cat;
		R5 r = new R5();
		r.Licensee = BnD(licensee, num);
		r.LicenseKey = BnD(licenseKey, num);
		r.b69(ActiproLicenseSourceLocation.Fixed);
		cat[type] = r;
	}

	public static AssemblyLicenseType ValidateLicense(AssemblyInfo assemblyInfo, Type type, object instance)
	{
		if (assemblyInfo == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126704));
		}
		if (type == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129262));
		}
		lock (Tam)
		{
			ActiproLicense license = GetLicense(assemblyInfo, LicenseManager.CurrentContext);
			AssemblyLicenseType assemblyLicenseType = license?.LicenseType ?? AssemblyLicenseType.Invalid;
			if (assemblyLicenseType == AssemblyLicenseType.Full && license.IsUnlicensedProduct && (license.ProductIDs & 0x11800) != 0)
			{
				int num = 0;
				if (j1m() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				assemblyLicenseType = AssemblyLicenseType.Evaluation;
			}
			waB(license, type, instance);
			return assemblyLicenseType;
		}
	}

	internal static bool M15()
	{
		return V1o == null;
	}

	internal static ActiproLicenseManager j1m()
	{
		return V1o;
	}
}
