namespace ActiproSoftware.Text.Tagging;

public interface IIntraLineSpacerTag : ITag
{
	double BottomMargin { get; }

	object Key { get; }

	double TopMargin { get; }
}
