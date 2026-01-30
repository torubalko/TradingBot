using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Editors;

public class GuidEditBox : PartEditBoxBase<Guid?>
{
	public static readonly DependencyProperty FormatProperty;

	public static readonly DependencyProperty NewGuidButtonToolTipProperty;

	public static readonly DependencyProperty ResolvedFormatProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler CjF;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ICommand ojA;

	internal static GuidEditBox zBN;

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

	public object NewGuidButtonToolTip
	{
		get
		{
			return GetValue(NewGuidButtonToolTipProperty);
		}
		set
		{
			SetValue(NewGuidButtonToolTipProperty, value);
		}
	}

	public ICommand NewGuidCommand
	{
		[CompilerGenerated]
		get
		{
			return ojA;
		}
		[CompilerGenerated]
		private set
		{
			ojA = value;
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

	public event EventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = CjF;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref CjF, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = CjF;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref CjF, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public GuidEditBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(GuidEditBox);
		Bj9();
	}

	private void Bj9()
	{
		NewGuidCommand = new DelegateCommand<object>(delegate
		{
			base.Value = Ody.oDy();
		});
	}

	private static void Xj5(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		GuidEditBox guidEditBox = (GuidEditBox)P_0;
		guidEditBox.ResolvedFormat = Ody.kDS(P_1.NewValue as string);
		guidEditBox.InvalidateParts();
		guidEditBox.QTc();
	}

	protected internal override string ConvertToString(Guid? valueToConvert)
	{
		return Ody.aD3(valueToConvert, ResolvedFormat) ?? string.Empty;
	}

	protected override IncrementalChangeRequest<Guid?> CreateIncrementalChangeRequest(IncrementalChangeRequestKind kind)
	{
		IncrementalChangeRequest<Guid?> incrementalChangeRequest = new IncrementalChangeRequest<Guid?>();
		incrementalChangeRequest.Kind = (base.IntermediateValue.HasValue ? kind : IncrementalChangeRequestKind.None);
		incrementalChangeRequest.SpinWrapping = base.SpinWrapping;
		incrementalChangeRequest.Value = base.IntermediateValue ?? Ody.oDy();
		return incrementalChangeRequest;
	}

	protected override IList<IPart> GenerateParts()
	{
		return Ody.nDm(ResolvedFormat);
	}

	protected override bool IsValidValue(Guid? value)
	{
		if (value.HasValue)
		{
			return true;
		}
		return base.IsNullAllowed;
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		base.OnKeyDown(e);
		if (e != null && !e.Handled && !base.IsEditable)
		{
			Key key = e.Key;
			Key key2 = key;
			if (key2 == Key.Space && !base.IsReadOnly)
			{
				e.Handled = true;
				base.Value = Ody.oDy();
			}
		}
	}

	protected override void RaiseValueChangedEvent()
	{
		CjF?.Invoke(this, EventArgs.Empty);
	}

	protected override void ResetValue()
	{
		QTc();
		if (base.IsNullAllowed)
		{
			SetCurrentValue(PartEditBoxBase<Guid?>.ValueProperty, null);
		}
		else
		{
			SetCurrentValue(PartEditBoxBase<Guid?>.ValueProperty, Ody.oDy());
		}
	}

	protected internal override bool TryConvertFromString(string textToConvert, bool canCoerce, out Guid? value)
	{
		if (Ody.YD1(textToConvert, out value))
		{
			if (!value.HasValue)
			{
				return base.IsNullAllowed;
			}
			return true;
		}
		return false;
	}

	static GuidEditBox()
	{
		awj.QuEwGz();
		FormatProperty = DependencyProperty.Register(QdM.AR8(1926), typeof(string), typeof(GuidEditBox), new PropertyMetadata(QdM.AR8(1942), Xj5));
		NewGuidButtonToolTipProperty = DependencyProperty.Register(QdM.AR8(19882), typeof(object), typeof(GuidEditBox), new PropertyMetadata(SR.GetString(SRName.UINewGuidButtonToolTip)));
		ResolvedFormatProperty = DependencyProperty.Register(QdM.AR8(2034), typeof(string), typeof(GuidEditBox), new PropertyMetadata(Ody.kDS(QdM.AR8(1942))));
	}

	[CompilerGenerated]
	private void Hjc(object P_0)
	{
		base.Value = Ody.oDy();
	}

	internal static bool HBL()
	{
		return zBN == null;
	}

	internal static GuidEditBox bBq()
	{
		return zBN;
	}
}
