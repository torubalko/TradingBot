using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Internal;

internal interface BTZ : IKeyedObject
{
	bool IsEnabled { get; }

	void Destroy();

	void Start(int P_0);

	void Stop();
}
