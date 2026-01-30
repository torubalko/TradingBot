using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Windows;
using System.Windows.Markup;

[assembly: AssemblyProduct("Grids")]
[assembly: AssemblyCompany("Actipro Software LLC")]
[assembly: AssemblyConfiguration("")]
[assembly: ComVisible(false)]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCopyright("Copyright (c) 2011-2021 Actipro Software LLC.  All rights reserved.")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.PropertyModel.#ActiproSoftware.Windows.Controls.Grids.PropertyData.IDataModel.Parent")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.PropertyModel.#ActiproSoftware.Windows.Controls.Grids.PropertyData.IDataModel.IsInitialized")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.PropertyModel.#System.ComponentModel.IDataErrorInfo.Item[System.String]")]
[assembly: AssemblyDescription("Advanced data grids for WPF.")]
[assembly: AssemblyTitle("Actipro Grids (for WPF)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro", Scope = "namespace", Target = "ActiproSoftware.Windows.Controls.Grids.Automation.Peers")]
[assembly: XmlnsDefinition("http://schemas.actiprosoftware.com/winfx/xaml/grids", "ActiproSoftware.Windows.Controls.Grids.PropertyData")]
[assembly: XmlnsDefinition("http://schemas.actiprosoftware.com/winfx/xaml/grids", "ActiproSoftware.Windows.Controls.Grids")]
[assembly: XmlnsDefinition("http://schemas.actiprosoftware.com/winfx/xaml/grids", "ActiproSoftware.Products.Grids")]
[assembly: AssemblyInformationalVersion("21.1.0.0")]
[assembly: XmlnsDefinition("http://schemas.actiprosoftware.com/winfx/xaml/grids", "ActiproSoftware.Windows.Controls.Grids.PropertyEditors")]
[assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: CLSCompliant(true)]
[assembly: XmlnsPrefix("http://schemas.actiprosoftware.com/winfx/xaml/grids", "grids")]
[assembly: XmlnsDefinition("http://schemas.actiprosoftware.com/winfx/xaml/themes", "ActiproSoftware.Windows.Themes")]
[assembly: XmlnsPrefix("http://schemas.actiprosoftware.com/winfx/xaml/themes", "themes")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.PropertyModel.#System.ComponentModel.IDataErrorInfo.Error")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ActiproSoftware.Windows.Themes")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ActiproSoftware.Windows.Controls.Grids.Primitives")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.DataModelBase.#ActiproSoftware.Windows.Controls.Grids.PropertyData.IDataModel.DisplayName")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.DataModelBase.#ActiproSoftware.Windows.Controls.Grids.PropertyData.IDataModel.Description")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro", Scope = "namespace", Target = "ActiproSoftware.Windows.Themes")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro", Scope = "namespace", Target = "ActiproSoftware.Windows.Controls.Grids")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro", Scope = "namespace", Target = "ActiproSoftware.Windows.Controls.Grids.Primitives")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.PropertyModelBase.#System.ComponentModel.IDataErrorInfo.Item[System.String]")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.PropertyModelBase.#System.ComponentModel.IDataErrorInfo.Error")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.PropertyDescriptorPropertyModel.#System.ComponentModel.ITypeDescriptorContext.PropertyDescriptor")]
[assembly: SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.DataFactoryBase.#GetOrCreateCategory(System.String,ActiproSoftware.Windows.Controls.Grids.PropertyData.IDataFactoryRequest,System.Collections.Generic.Dictionary`2<System.String,ActiproSoftware.Windows.Controls.Grids.PropertyData.DataFactoryBase+CategoryDataItem>)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro", Scope = "namespace", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyEditors")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro", Scope = "namespace", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.DataModelBase.#ActiproSoftware.Windows.Controls.Grids.PropertyData.IDataModel.Name")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.DataModelBase.#ActiproSoftware.Windows.Controls.Grids.PropertyData.IDataModel.IsModified")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.DataModelBase.#ActiproSoftware.Windows.Controls.Grids.PropertyData.IDataModel.IsInitialized")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.DataModelBase.#ActiproSoftware.Windows.Controls.Grids.PropertyData.IDataModel.SortOrder")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.DataModelBase.#ActiproSoftware.Windows.Controls.Grids.PropertyData.IDataModel.SortImportance")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Grids.PropertyData.DataModelBase.#ActiproSoftware.Windows.Controls.Grids.PropertyData.IDataModel.Parent")]
[assembly: AssemblyVersion("21.1.0.0")]
