using System;

namespace ActiproSoftware.Products;

[Flags]
internal enum AlgorithmGLicenseProductCodes
{
	Invalid = 0,
	Shared = 0,
	Wizard = 1,
	SyntaxEditor = 2,
	Ribbon = 4,
	BarCode = 8,
	Navigation = 0x10,
	Docking = 0x20,
	Gauge = 0x40,
	Grids = 0x80,
	PropertyGrid = 0x80,
	Editors = 0x100,
	Views = 0x200,
	UnusedEssentials = 0x400,
	DataGrid = 0x400,
	Bars = 0x2000,
	MicroCharts = 0x4000,
	Charts = 0x8000,
	Shell = 0x20000,
	UnusedStudio = 0x40000,
	Essentials = 0x535,
	Studio = 0x6E7FF,
	StudioPre181 = 0xE7FF,
	SyntaxEditorDotNetLanguagesAddon = 0x800,
	SyntaxEditorWebLanguagesAddon = 0x1000,
	SyntaxEditorPythonLanguageAddon = 0x10000,
	Addons = 0x11800,
	All = 0x7FFFF,
	AllPre181 = 0x1FFFF
}
