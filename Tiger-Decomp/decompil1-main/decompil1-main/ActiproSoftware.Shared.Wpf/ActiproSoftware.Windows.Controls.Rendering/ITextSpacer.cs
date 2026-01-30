using System.Windows;

namespace ActiproSoftware.Windows.Controls.Rendering;

public interface ITextSpacer
{
	double Baseline { get; }

	int CharacterIndex { get; }

	object Key { get; }

	Size Size { get; }
}
