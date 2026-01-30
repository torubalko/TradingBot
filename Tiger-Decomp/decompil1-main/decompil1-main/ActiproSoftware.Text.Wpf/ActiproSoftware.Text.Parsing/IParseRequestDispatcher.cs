using System;

namespace ActiproSoftware.Text.Parsing;

public interface IParseRequestDispatcher : IDisposable
{
	bool IsBusy { get; }

	int PendingRequestCount { get; }

	IParseRequest[] GetPendingRequests();

	bool HasPendingRequest(string parseHashKey);

	void QueueRequest(IParseRequest request);

	int RemovePendingRequests(string parseHashKey);

	bool WaitForParse(string parseHashKey);

	bool WaitForParse(string parseHashKey, int maximumWaitTime);
}
