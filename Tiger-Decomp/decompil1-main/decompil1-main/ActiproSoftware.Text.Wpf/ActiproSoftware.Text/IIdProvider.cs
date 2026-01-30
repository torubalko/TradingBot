namespace ActiproSoftware.Text;

public interface IIdProvider
{
	int MaxId { get; }

	int MinId { get; }

	bool ContainsId(int id);

	string GetDescription(int id);

	string GetKey(int id);
}
