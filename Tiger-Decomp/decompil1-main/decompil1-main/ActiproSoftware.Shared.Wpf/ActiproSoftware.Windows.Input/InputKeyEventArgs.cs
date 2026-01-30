using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

public class InputKeyEventArgs : EventArgs
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private KeyEventArgs O08;

	internal static InputKeyEventArgs sJe;

	public bool Handled
	{
		get
		{
			return WrappedEventArgs.Handled;
		}
		set
		{
			WrappedEventArgs.Handled = value;
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	public ModifierKeys ModifierKeys => Keyboard.Modifiers;

	public Key Key => (WrappedEventArgs.SystemKey != Key.None) ? WrappedEventArgs.SystemKey : WrappedEventArgs.Key;

	public object OriginalSource => WrappedEventArgs.OriginalSource;

	public KeyEventArgs WrappedEventArgs
	{
		[CompilerGenerated]
		get
		{
			return O08;
		}
		[CompilerGenerated]
		private set
		{
			O08 = value;
		}
	}

	public InputKeyEventArgs(KeyEventArgs e)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (e == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107336));
		}
		WrappedEventArgs = e;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110624), Key);
		if (ModifierKeys != ModifierKeys.None)
		{
			stringBuilder.AppendFormat(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110646), ModifierKeys);
		}
		stringBuilder.AppendFormat(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110584), (OriginalSource != null) ? OriginalSource.GetType().Name : null);
		return stringBuilder.ToString();
	}

	internal static bool eJ6()
	{
		return sJe == null;
	}

	internal static InputKeyEventArgs KJw()
	{
		return sJe;
	}
}
