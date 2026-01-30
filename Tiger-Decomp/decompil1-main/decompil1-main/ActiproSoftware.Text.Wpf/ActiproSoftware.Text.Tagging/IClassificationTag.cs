namespace ActiproSoftware.Text.Tagging;

public interface IClassificationTag : ITag
{
	IClassificationType ClassificationType { get; }
}
