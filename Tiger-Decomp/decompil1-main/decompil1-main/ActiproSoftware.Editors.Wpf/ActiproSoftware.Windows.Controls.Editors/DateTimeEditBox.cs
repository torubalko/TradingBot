using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Editors;

public class DateTimeEditBox : PartEditBoxBase<DateTime?>
{
	private DelegateCommand<object> eMq;

	private DelegateCommand<object> DMu;

	private static Regex HMK;

	public static readonly DependencyProperty FormatProperty;

	public static readonly DependencyProperty MaximumProperty;

	public static readonly DependencyProperty MinimumProperty;

	public static readonly DependencyProperty ResolvedFormatProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler iMR;

	private static DateTimeEditBox fBR;

	public string Format
	{
		get
		{
			return (string)GetValue(FormatProperty);
		}
		set
		{
			SetValue(FormatProperty, value);
		}
	}

	protected override bool HasPopupButtonWhenReadOnly => true;

	public DateTime Maximum
	{
		get
		{
			return (DateTime)GetValue(MaximumProperty);
		}
		set
		{
			SetValue(MaximumProperty, value);
		}
	}

	public DateTime Minimum
	{
		get
		{
			return (DateTime)GetValue(MinimumProperty);
		}
		set
		{
			SetValue(MinimumProperty, value);
		}
	}

	public string ResolvedFormat
	{
		get
		{
			return (string)GetValue(ResolvedFormatProperty);
		}
		private set
		{
			SetValue(ResolvedFormatProperty, value);
		}
	}

	public ICommand SetValueToNowCommand
	{
		get
		{
			if (eMq == null)
			{
				eMq = new DelegateCommand<object>(delegate
				{
					base.Value = ldZ.BDP(DateTime.Now, Minimum, Maximum);
				});
			}
			return eMq;
		}
	}

	public ICommand SetValueToTodayCommand
	{
		get
		{
			if (DMu == null)
			{
				DMu = new DelegateCommand<object>(delegate
				{
					base.Value = ldZ.BDP(DateTime.Today, Minimum, Maximum);
				});
			}
			return DMu;
		}
	}

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = iMR;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref iMR, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = iMR;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref iMR, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public DateTimeEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DateTimeEditBox);
	}

	private static void TMO(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DateTimeEditBox dateTimeEditBox = (DateTimeEditBox)P_0;
		dateTimeEditBox.ResolvedFormat = ldZ.bbk(P_1.NewValue as string, CultureInfo.CurrentCulture);
		dateTimeEditBox.InvalidateParts();
		dateTimeEditBox.QTc();
	}

	private static void HMT(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DateTimeEditBox dateTimeEditBox = (DateTimeEditBox)P_0;
		dateTimeEditBox.CoerceValue(PartEditBoxBase<DateTime?>.ValueProperty);
	}

	private static void FMI(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DateTimeEditBox dateTimeEditBox = (DateTimeEditBox)P_0;
		dateTimeEditBox.CoerceValue(PartEditBoxBase<DateTime?>.ValueProperty);
	}

	protected virtual DateTime? CoerceParsedValue(DateTime? value)
	{
		return value;
	}

	protected override DateTime? CoerceValidValue(DateTime? value)
	{
		if (value.HasValue)
		{
			return ldZ.BDP(value.Value, Minimum, Maximum);
		}
		return base.CoerceValidValue(value);
	}

	protected internal override string ConvertToString(DateTime? valueToConvert)
	{
		string result = string.Empty;
		if (valueToConvert.HasValue && ldZ.TDM(valueToConvert.Value))
		{
			result = valueToConvert.Value.ToString(ResolvedFormat, CultureInfo.CurrentCulture);
		}
		return result;
	}

	protected override IncrementalChangeRequest<DateTime?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<DateTime?> incrementalChangeRequest = new IncrementalChangeRequest<DateTime?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.Maximum = Maximum;
		incrementalChangeRequest.Minimum = Minimum;
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? ldZ.BDP(DateTime.Now, Minimum, Maximum);
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return ldZ.vbr(ResolvedFormat, CultureInfo.CurrentCulture);
	}

	protected override bool IsValidValue(DateTime? value)
	{
		if (value.HasValue)
		{
			DateTime value2 = ldZ.BDP(value.Value, Minimum, Maximum);
			DateTime? dateTime = value;
			return value2 == dateTime;
		}
		return base.IsNullAllowed;
	}

	protected override void RaiseValueChangedEvent()
	{
		iMR?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (!base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<DateTime?>.ValueProperty, ldZ.BDP(DateTime.Now, Minimum, Maximum));
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<DateTime?>.ValueProperty, null);
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out DateTime? value)
	{
		value = null;
		if (string.IsNullOrEmpty(textToConvert))
		{
			return base.IsNullAllowed;
		}
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		string resolvedFormat = ResolvedFormat;
		if (DateTime.TryParseExact(textToConvert, new string[17]
		{
			resolvedFormat,
			QdM.AR8(18772),
			QdM.AR8(2648),
			QdM.AR8(18778),
			QdM.AR8(18784),
			QdM.AR8(18790),
			QdM.AR8(1942),
			QdM.AR8(18796),
			QdM.AR8(18802),
			QdM.AR8(18808),
			QdM.AR8(18814),
			QdM.AR8(18820),
			QdM.AR8(2618),
			QdM.AR8(18826),
			QdM.AR8(18832),
			QdM.AR8(18838),
			QdM.AR8(18844)
		}, currentCulture, DateTimeStyles.AllowWhiteSpaces, out var result))
		{
			value = CoerceParsedValue(result);
			if (canCoerce)
			{
				value = ldZ.BDP(value.Value, Minimum, Maximum);
			}
			return true;
		}
		if (DateTime.TryParse(textToConvert, currentCulture, DateTimeStyles.AllowWhiteSpaces, out result))
		{
			value = CoerceParsedValue(result);
			if (canCoerce)
			{
				value = ldZ.BDP(value.Value, Minimum, Maximum);
			}
			return true;
		}
		string text = HMK.Replace(Format ?? string.Empty, string.Empty);
		bool flag = false;
		string text2 = text;
		string text3 = text2;
		DateTimeFormatInfo dateTimeFormat;
		string text4;
		DateTimeFormatInfo dateTimeFormat2;
		string text5;
		switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(text3))
		{
		case 1200092049u:
			if (!(text3 == QdM.AR8(18850)))
			{
				break;
			}
			goto IL_04b0;
		case 2177869907u:
			if (!(text3 == QdM.AR8(18866)))
			{
				break;
			}
			goto IL_04b0;
		case 2312285473u:
			if (!(text3 == QdM.AR8(18886)))
			{
				break;
			}
			goto IL_04b0;
		case 3249909347u:
			if (!(text3 == QdM.AR8(18902)))
			{
				break;
			}
			goto IL_04b0;
		case 2673540025u:
			if (!(text3 == QdM.AR8(18922)))
			{
				break;
			}
			goto IL_04b0;
		case 1948729059u:
			if (!(text3 == QdM.AR8(18938)))
			{
				break;
			}
			goto IL_04b0;
		case 3775669363u:
			if (!(text3 == QdM.AR8(18790)))
			{
				break;
			}
			goto IL_04b0;
		case 2701014103u:
			if (!(text3 == QdM.AR8(18958)))
			{
				break;
			}
			goto IL_0609;
		case 459445399u:
			if (!(text3 == QdM.AR8(18970)))
			{
				break;
			}
			goto IL_0609;
		case 3113290885u:
			if (!(text3 == QdM.AR8(18986)))
			{
				break;
			}
			goto IL_0609;
		case 3198150871u:
			if (!(text3 == QdM.AR8(19004)))
			{
				break;
			}
			goto IL_0609;
		case 3149569303u:
			if (!(text3 == QdM.AR8(19016)))
			{
				break;
			}
			goto IL_0609;
		case 2753981957u:
			if (!(text3 == QdM.AR8(19032)))
			{
				break;
			}
			goto IL_0609;
		case 4044111267u:
			{
				if (!(text3 == QdM.AR8(18796)))
				{
					break;
				}
				goto IL_0609;
			}
			IL_0609:
			dateTimeFormat = currentCulture.DateTimeFormat;
			text4 = ((dateTimeFormat != null) ? dateTimeFormat.TimeSeparator : QdM.AR8(19056));
			if (!textToConvert.Contains(text4))
			{
				int length = textToConvert.Length;
				int num = length;
				if (num == 4 || (uint)(num - 6) <= 1u)
				{
					textToConvert = textToConvert.Substring(0, 2) + text4 + textToConvert.Substring(2);
					flag = true;
				}
			}
			break;
			IL_04b0:
			dateTimeFormat2 = currentCulture.DateTimeFormat;
			text5 = ((dateTimeFormat2 != null) ? dateTimeFormat2.DateSeparator : QdM.AR8(19050));
			if (textToConvert.Contains(text5))
			{
				break;
			}
			switch (textToConvert.Length)
			{
			case 6:
				textToConvert = textToConvert.Substring(0, 2) + text5 + textToConvert.Substring(2, 2) + text5 + textToConvert.Substring(4);
				flag = true;
				break;
			case 8:
				switch (resolvedFormat.IndexOf('y'))
				{
				case 0:
					textToConvert = textToConvert.Substring(0, 4) + text5 + textToConvert.Substring(4, 2) + text5 + textToConvert.Substring(6);
					flag = true;
					break;
				case 4:
					textToConvert = textToConvert.Substring(0, 2) + text5 + textToConvert.Substring(2, 2) + text5 + textToConvert.Substring(4);
					flag = true;
					break;
				}
				break;
			}
			break;
		}
		if (flag && DateTime.TryParse(textToConvert, currentCulture, DateTimeStyles.AllowWhiteSpaces, out result))
		{
			value = CoerceParsedValue(result);
			if (canCoerce)
			{
				value = ldZ.BDP(value.Value, Minimum, Maximum);
			}
			return true;
		}
		return false;
	}

	static DateTimeEditBox()
	{
		awj.QuEwGz();
		HMK = new Regex(QdM.AR8(19062), RegexOptions.Compiled);
		FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(DateTimeEditBox), new PropertyMetadata(QdM.AR8(18772), TMO));
		MaximumProperty = DependencyProperty.Register(QdM.AR8(1974), typeof(DateTime), typeof(DateTimeEditBox), new PropertyMetadata(ldZ.YD2, HMT));
		MinimumProperty = DependencyProperty.Register(QdM.AR8(1992), typeof(DateTime), typeof(DateTimeEditBox), new PropertyMetadata(ldZ.ADa, FMI));
		ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(DateTimeEditBox), new PropertyMetadata(ldZ.bbk(QdM.AR8(18772), CultureInfo.CurrentCulture)));
	}

	[CompilerGenerated]
	private void TMb(object P_0)
	{
		base.Value = ldZ.BDP(DateTime.Now, Minimum, Maximum);
	}

	[CompilerGenerated]
	private void TMD(object P_0)
	{
		base.Value = ldZ.BDP(DateTime.Today, Minimum, Maximum);
	}

	internal static bool EBi()
	{
		return fBR == null;
	}

	internal static DateTimeEditBox xB5()
	{
		return fBR;
	}
}
