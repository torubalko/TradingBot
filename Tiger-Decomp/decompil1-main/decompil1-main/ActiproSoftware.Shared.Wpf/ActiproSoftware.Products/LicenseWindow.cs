using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Security;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Products.Shared;
using dg3ypDAonQcOidMs0w;
using Microsoft.Win32;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products;

[ToolboxItem(false)]
public partial class LicenseWindow : Window, IComponentConnector
{
	private DispatcherTimer kqm;

	private ActiproLicense lqw;

	private string Uq4;

	private string iqu;

	private bool Rq2;

	internal static LicenseWindow og8;

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	internal LicenseWindow(ActiproLicense license)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		Uq4 = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129978);
		iqu = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127522);
		base._002Ector();
		lqw = license;
		InitializeComponent();
		bool flag = license != null && license.ExceptionType == 6 && string.IsNullOrEmpty(license.Licensee) && string.IsNullOrEmpty(license.LicenseKey) && Debugger.IsAttached;
		evaluationTabItem.Visibility = ((!flag) ? Visibility.Collapsed : Visibility.Visible);
		if (evaluationTabItem.Visibility == Visibility.Visible)
		{
			tabControl.SelectedItem = evaluationTabItem;
			FocusManager.SetFocusedElement(this, organizationNameTextBox);
		}
		copyrightTextBlock.Text = license.AssemblyInfo.Copyright;
		licenseErrorCodeTextBox.Text = license.ExceptionType.ToString(CultureInfo.CurrentCulture);
		licenseeTextBox.Text = license.Licensee;
		if (license.LicenseKey != null && license.LicenseKey.Length > 20)
		{
			if (license.SourceLocation == ActiproLicenseSourceLocation.Registry && license.LicenseType == AssemblyLicenseType.Full)
			{
				licenseKeyTextBox.Text = license.ExpandedLicenseKey;
			}
			else
			{
				licenseKeyTextBox.Text = license.ExpandedLicenseKey.Substring(0, 18) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123364);
			}
		}
		licenseQuickInfoTextBlock.Text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130086);
		licenseSourceLocationTextBox.Text = license.SourceLocation.ToString();
		productNameTextBlock.Text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127018);
		base.Title = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130276);
		versionTextBlock.Text = string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129664), new object[1] { license.AssemblyInfo.Version });
		AssemblyInfo instance = ActiproSoftware.Products.Shared.AssemblyInfo.Instance;
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.Studio,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130320),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130360)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130408)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.Essentials,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130652),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130360)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130702)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.BarCode,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130876),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130896)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130940)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.Charts,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131012),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131028)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130940)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.Docking,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131070),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131100)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131144)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.Editors,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131256),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131274)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131144)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.Gauge,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131318),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131332)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130940)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.Grids,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131372),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131386)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130940)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.MicroCharts,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131426),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131454)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130940)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.Navigation,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131506),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131530)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131144)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.Ribbon,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131580),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131596)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131144)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.Shell,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131638),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131652)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130940)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.SyntaxEditor,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131692),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131720)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130940)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.Invalid,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131774),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131790)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131832)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.Views,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131912),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131926)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131144)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.Wizard,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131966),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131982)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131144)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.Invalid,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132024),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132056)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(131832)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.SyntaxEditorDotNetLanguagesAddon,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132098),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132144)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132208)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.SyntaxEditorPythonLanguageAddon,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132346),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132144)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132208)
		});
		productsListView.Items.Add(new ProductData
		{
			ProductCode = AlgorithmGLicenseProductCodes.SyntaxEditorWebLanguagesAddon,
			Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132394),
			ImageSource = instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132144)),
			Description = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132208)
		});
		AssemblyLicenseType licenseType = license.LicenseType;
		AssemblyLicenseType assemblyLicenseType = licenseType;
		if (assemblyLicenseType != AssemblyLicenseType.Invalid && assemblyLicenseType != AssemblyLicenseType.Evaluation)
		{
			foreach (ProductData item in (IEnumerable)productsListView.Items)
			{
				if ((license.ProductIDs & (uint)item.ProductCode) == (uint)item.ProductCode)
				{
					item.IsLicensed = true;
				}
			}
		}
		foreach (ProductData item2 in (IEnumerable)productsListView.Items)
		{
			if (item2.ProductCode == (AlgorithmGLicenseProductCodes)license.AssemblyInfo.ProductId)
			{
				item2.UseEmphasis = true;
				productsListView.SelectedItem = item2;
				break;
			}
		}
		kqm = new DispatcherTimer();
		kqm.Interval = new TimeSpan(0, 0, 0, 0, 400);
		kqm.Tick += zqy;
		string text = null;
		switch (license.AssemblyInfo.LicenseType)
		{
		case AssemblyLicenseType.Beta:
			text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129690);
			break;
		case AssemblyLicenseType.Prerelease:
			text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129718);
			break;
		default:
			if (license.LicenseType == AssemblyLicenseType.Full)
			{
				text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129744);
			}
			else
			{
				try
				{
					string name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132438) + license.AssemblyInfo.Version.Substring(0, 4);
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
					if (registryKey == null)
					{
						name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132520) + license.AssemblyInfo.Version.Substring(0, 4);
						registryKey = Registry.LocalMachine.OpenSubKey(name);
					}
					if (registryKey != null)
					{
						text = registryKey.GetValue(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(127430)) as string;
						registryKey.Close();
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
			if (text != null && string.Compare(text.Trim(), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132626), StringComparison.OrdinalIgnoreCase) == 0)
			{
				kqm = null;
			}
			else
			{
				text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129772);
			}
			break;
		}
		licenseTypeHyperLink.Inlines.Add(new Run(text));
		licenseQuickInfoTextBlock.Text = license.GetQuickInfo();
	}

	private void zqy(object P_0, EventArgs P_1)
	{
		if (licenseTypeHyperLink.Foreground == Brushes.Blue)
		{
			licenseTypeHyperLink.Foreground = Brushes.Red;
		}
		else
		{
			licenseTypeHyperLink.Foreground = Brushes.Blue;
		}
	}

	private void dqf(object P_0, EventArgs P_1)
	{
		Close();
	}

	private void Lqi(object P_0, EventArgs P_1)
	{
		string text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132654);
		try
		{
			text = Environment.OSVersion.ToString();
		}
		catch (InvalidOperationException)
		{
		}
		string text2 = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123240) + lqw.AssemblyInfo.Product + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106636) + lqw.AssemblyInfo.Version + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123262) + lqw.AssemblyInfo.LicenseType.ToString() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123270) + Environment.NewLine + Environment.NewLine + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123276) + lqw.LicenseType.ToString() + Environment.NewLine + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123308) + licenseeTextBox.Text + Environment.NewLine + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123332) + licenseKeyTextBox.Text + Environment.NewLine + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132678) + licenseSourceLocationTextBox.Text + Environment.NewLine + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123418) + lqw.Platform.ToString() + Environment.NewLine + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123442) + lqw.OrganizationID + Environment.NewLine + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132716) + text + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132746) + Environment.Version?.ToString() + Environment.NewLine + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123454) + lqw.ExceptionType + Environment.NewLine + Environment.NewLine + licenseQuickInfoTextBlock.Text;
		Clipboard.SetText(text2);
		MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132766));
	}

	private void jqS(object P_0, EventArgs P_1)
	{
		string text2 = default(string);
		int num;
		bool flag = default(bool);
		if (Keyboard.Modifiers != (ModifierKeys.Control | ModifierKeys.Shift))
		{
			string text = ((Run)licenseTypeHyperLink.Inlines.FirstInline).Text;
			text2 = text;
			num = 1;
			if (ege() != null)
			{
				goto IL_0005;
			}
		}
		else
		{
			flag = licenseTabItem.Visibility != Visibility.Visible;
			num = 0;
			if (ege() != null)
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		case 1:
			if (text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129690))
			{
				MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(132862), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(133356), MessageBoxButton.OK, MessageBoxImage.Asterisk);
			}
			else if (!(text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129718)))
			{
				if (text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129744))
				{
					MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(133898), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(133356), MessageBoxButton.OK, MessageBoxImage.Asterisk);
				}
				else if (text2 == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129772))
				{
					MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(134188), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(133356), MessageBoxButton.OK, MessageBoxImage.Asterisk);
				}
				else
				{
					Jqh();
				}
			}
			else
			{
				MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(133384), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(133356), MessageBoxButton.OK, MessageBoxImage.Asterisk);
			}
			break;
		default:
			if (flag)
			{
				licenseTabItem.Visibility = Visibility.Visible;
			}
			tabControl.SelectedItem = licenseTabItem;
			break;
		}
		return;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private void lq3(object P_0, EventArgs P_1)
	{
		sq9();
	}

	private void sqt(object P_0, EventArgs P_1)
	{
		Jqh();
	}

	private void TqJ(object P_0, RoutedEventArgs P_1)
	{
		string text = organizationNameTextBox.Text.Trim();
		if (string.IsNullOrEmpty(text) || text.Length <= 3)
		{
			MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(134778), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135022), MessageBoxButton.OK, MessageBoxImage.Asterisk);
			organizationNameTextBox.Focus();
			return;
		}
		try
		{
			ActiproLicenseManager.StartEvaluationInRegistry(text);
			base.DialogResult = true;
			Close();
		}
		catch (Exception ex)
		{
			MessageBox.Show(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135068) + ex.Message, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135270), MessageBoxButton.OK, MessageBoxImage.Exclamation);
		}
	}

	private void sq9()
	{
		Process.Start(Uq4);
	}

	private void Jqh()
	{
		Process.Start(iqu);
	}

	protected override void OnActivated(EventArgs e)
	{
		base.OnActivated(e);
		if (kqm != null && !kqm.IsEnabled)
		{
			kqm.Start();
		}
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		base.OnClosing(e);
		if (kqm != null && kqm.IsEnabled)
		{
			kqm.Stop();
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	[GeneratedCode("PresentationBuildTasks", "5.0.3.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	internal static bool Sgj()
	{
		return og8 == null;
	}

	internal static LicenseWindow ege()
	{
		return og8;
	}
}
