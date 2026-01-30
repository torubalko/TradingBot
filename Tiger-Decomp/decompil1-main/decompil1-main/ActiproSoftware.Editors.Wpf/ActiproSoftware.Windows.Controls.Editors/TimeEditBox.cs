using System;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors;

public class TimeEditBox : DateTimeEditBox
{
	internal static TimeEditBox Srq;

	protected override bool HasPopupButtonWhenReadOnly => false;

	public TimeEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(TimeEditBox);
	}

	protected override DateTime? CoerceParsedValue(DateTime? value)
	{
		if (value.HasValue)
		{
			DateTime? value2 = base.Value;
			if (value2.HasValue)
			{
				value = new DateTime(value2.Value.Year, value2.Value.Month, value2.Value.Day, value.Value.Hour, value.Value.Minute, value.Value.Second, value.Value.Millisecond, value.Value.Kind);
			}
		}
		return value;
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
			SetCurrentValue(PartEditBoxBase<DateTime?>.ValueProperty, ldZ.BDP(DateTime.Now, base.Minimum, base.Maximum));
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out DateTime? value)
	{
		bool flag = base.TryConvertFromString(textToConvert, canCoerce, out value);
		if (flag && value.HasValue)
		{
			if (base.Value.HasValue)
			{
				DateTime value2 = base.Value.Value;
				value = new DateTime(value2.Year, value2.Month, value2.Day, value.Value.Hour, value.Value.Minute, value.Value.Second, value.Value.Millisecond, value.Value.Kind);
			}
			if (canCoerce)
			{
				value = ldZ.BDP(value.Value, base.Minimum, base.Maximum);
			}
		}
		return flag;
	}

	internal static bool nrn()
	{
		return Srq == null;
	}

	internal static TimeEditBox Srg()
	{
		return Srq;
	}
}
