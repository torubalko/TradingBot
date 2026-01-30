using System;
using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplatePart(Name = "PART_Picker", Type = typeof(DatePicker))]
public class DateEditBox : DateTimeEditBox
{
	private DatePicker picker;

	public static readonly DependencyProperty CanRetainTimeProperty;

	private static DateEditBox TBm;

	public bool CanRetainTime
	{
		get
		{
			return (bool)GetValue(CanRetainTimeProperty);
		}
		set
		{
			SetValue(CanRetainTimeProperty, value);
		}
	}

	public DateEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DateEditBox);
	}

	[SpecialName]
	private DatePicker FMC()
	{
		return picker;
	}

	[SpecialName]
	private void oM6(DatePicker value)
	{
		if (picker == value)
		{
			return;
		}
		if (picker != null)
		{
			picker.ValueCommitted -= VMV;
		}
		picker = value;
		int num = 0;
		if (eB8() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (picker != null)
		{
			picker.ValueCommitted += VMV;
		}
	}

	private void VMV(object P_0, EventArgs P_1)
	{
		base.IsPopupOpen = false;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		oM6(GetTemplateChild(QdM.AR8(2520)) as DatePicker);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<DateTime?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<DateTime?>.ValueProperty, ldZ.BDP(DateTime.Today, base.Minimum, base.Maximum));
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out DateTime? value)
	{
		bool flag = base.TryConvertFromString(textToConvert, canCoerce, out value);
		if (flag && value.HasValue)
		{
			DateTime value2 = value.Value.Date;
			if (CanRetainTime && base.Value.HasValue)
			{
				DateTime value3 = base.Value.Value;
				value2 = value2.AddHours(value3.Hour).AddMinutes(value3.Minute).AddSeconds(value3.Second)
					.AddMilliseconds(value3.Millisecond);
			}
			value = value2;
			if (canCoerce)
			{
				value = ldZ.BDP(value.Value, base.Minimum, base.Maximum);
			}
		}
		return flag;
	}

	static DateEditBox()
	{
		awj.QuEwGz();
		CanRetainTimeProperty = DependencyProperty.Register(QdM.AR8(18702), typeof(bool), typeof(DateEditBox), new PropertyMetadata(false));
	}

	internal static bool VBP()
	{
		return TBm == null;
	}

	internal static DateEditBox eB8()
	{
		return TBm;
	}
}
