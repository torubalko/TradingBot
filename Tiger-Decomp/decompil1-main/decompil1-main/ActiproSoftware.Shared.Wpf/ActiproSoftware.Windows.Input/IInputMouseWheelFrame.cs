namespace ActiproSoftware.Windows.Input;

public interface IInputMouseWheelFrame
{
	int Delta { get; }

	bool Handled { get; set; }
}
