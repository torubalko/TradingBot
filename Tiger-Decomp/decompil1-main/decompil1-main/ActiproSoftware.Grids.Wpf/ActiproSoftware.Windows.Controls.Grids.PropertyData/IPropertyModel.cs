using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public interface IPropertyModel : IDataModel, IDisposable
{
	ICommand AddChildCommand { get; }

	bool CanAddChild { get; }

	bool CanRemove { get; }

	bool CanResetValue { get; }

	string Category { get; }

	TypeConverter Converter { get; }

	bool HasStandardValues { get; }

	bool IsHostReadOnly { get; set; }

	bool IsImmutable { get; }

	bool IsLimitedToStandardValues { get; }

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Mergeable")]
	bool IsMergeable { get; }

	bool IsReadOnly { get; }

	bool IsValueReadOnly { get; set; }

	PropertyEditor NamePropertyEditor { get; set; }

	DataTemplate NameTemplate { get; }

	object NameTemplateKey { get; }

	DataTemplateSelector NameTemplateSelector { get; }

	ICommand RemoveCommand { get; }

	ICommand ResetValueCommand { get; }

	bool ShouldNotifyParentOnValueChange { get; }

	IEnumerable StandardValues { get; }

	IEnumerable<string> StandardValuesAsStrings { get; }

	string StandardValuesDisplayMemberPath { get; set; }

	string StandardValuesSelectedValuePath { get; set; }

	object Target { get; }

	Type TargetType { get; }

	object Value { get; set; }

	string ValueAsString { get; set; }

	PropertyEditor ValuePropertyEditor { get; set; }

	IList<object> Values { get; }

	DataTemplate ValueTemplate { get; }

	object ValueTemplateKey { get; }

	DefaultValueTemplateKind ValueTemplateKind { get; }

	DataTemplateSelector ValueTemplateSelector { get; }

	Type ValueType { get; }

	void AddChild();

	bool CycleToNextStandardValue();

	void Refresh(PropertyRefreshReason reason);

	void Remove();

	void ResetValue();
}
