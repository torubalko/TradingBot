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

[assembly: AssemblyProduct("Docking")]
[assembly: AssemblyCompany("Actipro Software LLC")]
[assembly: AssemblyCopyright("Copyright (c) 2007-2021 Actipro Software LLC.  All rights reserved.")]
[assembly: ComVisible(false)]
[assembly: AssemblyTrademark("")]
[assembly: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.Primitives.DockingWindowContainerBase.#activePopup")]
[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "ActiproSoftware.Windows.Themes")]
[assembly: AssemblyTitle("Actipro Docking/MDI (for WPF)")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyDescription("A docking window and MDI control suite for for WPF.")]
[assembly: CLSCompliant(true)]
[assembly: XmlnsDefinition("http://schemas.actiprosoftware.com/winfx/xaml/docking", "ActiproSoftware.Windows.Controls.Docking")]
[assembly: XmlnsDefinition("http://schemas.actiprosoftware.com/winfx/xaml/docking", "ActiproSoftware.Products.Docking")]
[assembly: XmlnsDefinition("http://schemas.actiprosoftware.com/winfx/xaml/docking", "ActiproSoftware.Windows.Controls.Docking.Primitives")]
[assembly: AssemblyInformationalVersion("21.1.0.0")]
[assembly: ThemeInfo(ResourceDictionaryLocation.None, ResourceDictionaryLocation.SourceAssembly)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: XmlnsPrefix("http://schemas.actiprosoftware.com/winfx/xaml/themes", "themes")]
[assembly: XmlnsPrefix("http://schemas.actiprosoftware.com/winfx/xaml/docking", "docking")]
[assembly: XmlnsDefinition("http://schemas.actiprosoftware.com/winfx/xaml/themes", "ActiproSoftware.Windows.Themes")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.DockHost.#ActiproSoftware.Windows.Controls.Docking.IDockTarget.DockHost")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro", Scope = "namespace", Target = "ActiproSoftware.Windows.Controls.Docking.Serialization")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro", Scope = "namespace", Target = "ActiproSoftware.Windows.Controls.Docking.Primitives")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro", Scope = "namespace", Target = "ActiproSoftware.Windows.Themes")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.Workspace.#ActiproSoftware.Windows.Controls.Docking.IDockTarget.GetState(System.Nullable`1<ActiproSoftware.Windows.Controls.Side>)")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro", Scope = "namespace", Target = "ActiproSoftware.Windows.Controls.Docking.Automation.Peers")]
[assembly: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro", Scope = "namespace", Target = "ActiproSoftware.Windows.Controls.Docking")]
[assembly: SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.AdvancedTabControl+AdvancedTabControlDragProcessor.#StartOrContinueTabDragIfApplicable(ActiproSoftware.Windows.Input.InputPointerEventArgs)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.Primitives.DockingWindowContainerBase.#ActiproSoftware.Windows.Controls.IOrientedElement.Orientation")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.DockSite.#ActiproSoftware.Windows.Controls.Docking.IDockTarget.DockHost")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.DockingWindow.#ActiproSoftware.Windows.Controls.Docking.IDockTarget.GetState(System.Nullable`1<ActiproSoftware.Windows.Controls.Side>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.DockHost.#ActiproSoftware.Windows.Controls.Docking.IDockTarget.DockSite")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.DockHost.#ActiproSoftware.Windows.Controls.Docking.IDockTarget.GetState(System.Nullable`1<ActiproSoftware.Windows.Controls.Side>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.DockSite.#ActiproSoftware.Windows.Controls.Docking.IDockTarget.DockSite")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.TabbedMdiHost.#ActiproSoftware.Windows.Controls.Docking.IDockTarget.GetState(System.Nullable`1<ActiproSoftware.Windows.Controls.Side>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.ToolWindowContainer.#ActiproSoftware.Windows.Controls.Docking.IDockTarget.GetState(System.Nullable`1<ActiproSoftware.Windows.Controls.Side>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.TabbedMdiContainer.#ActiproSoftware.Windows.Controls.Docking.IDockTarget.GetState(System.Nullable`1<ActiproSoftware.Windows.Controls.Side>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.DockSite.#ActiproSoftware.Windows.Controls.Docking.IDockTarget.GetState(System.Nullable`1<ActiproSoftware.Windows.Controls.Side>)")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", Target = "ActiproSoftware.Windows.Controls.Docking.StandardMdiHost.#ActiproSoftware.Windows.Controls.Docking.IDockTarget.GetState(System.Nullable`1<ActiproSoftware.Windows.Controls.Side>)")]
[assembly: AssemblyVersion("21.1.0.0")]
