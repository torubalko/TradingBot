using System.Windows.Media;

namespace ActiproSoftware.Windows.Themes.Generation;

public interface IColorRampShade
{
	double Brightness { get; }

	Color Color { get; }

	string ContrastName { get; }

	Color ForegroundColor { get; }

	bool IsLight { get; }

	string Name { get; }

	int Number { get; }

	IColorRamp Ramp { get; }

	Color GetForegroundColor(double contrastPercentage);
}
