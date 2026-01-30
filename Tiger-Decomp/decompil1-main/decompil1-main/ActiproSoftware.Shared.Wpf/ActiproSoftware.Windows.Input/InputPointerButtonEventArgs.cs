using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

public class InputPointerButtonEventArgs : InputPointerEventArgs
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private InputPointerButtonKind p01;

	internal static InputPointerButtonEventArgs wJQ;

	public InputPointerButtonKind ButtonKind
	{
		[CompilerGenerated]
		get
		{
			return p01;
		}
		[CompilerGenerated]
		private set
		{
			p01 = value;
		}
	}

	public bool IsPrimaryButton => ButtonKind == InputPointerButtonKind.Primary;

	public new InputEventArgs WrappedEventArgs => base.WrappedEventArgs;

	public InputPointerButtonEventArgs(InputEventArgs e, InputPointerButtonKind buttonKind)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(e);
		ButtonKind = buttonKind;
	}

	internal static bool zJC()
	{
		return wJQ == null;
	}

	internal static InputPointerButtonEventArgs UJR()
	{
		return wJQ;
	}
}
