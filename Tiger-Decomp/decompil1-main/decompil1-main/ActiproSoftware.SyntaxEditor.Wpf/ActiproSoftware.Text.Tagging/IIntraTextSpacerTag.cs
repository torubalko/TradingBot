using System.Windows;

namespace ActiproSoftware.Text.Tagging;

public interface IIntraTextSpacerTag : ITag
{
	double Baseline { get; }

	object Key { get; }

	Size Size { get; }
}
