namespace TigerTrade.Tc.History;

public interface IDataReader<out T>
{
	bool IsEmpty { get; }

	T LastItem { get; }

	T PrevItem { get; }

	bool Read();

	void Reset();

	void Dispose();
}
