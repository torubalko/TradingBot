using System;
using System.ServiceModel;
using AdLbwZYjeixWF0WHbS4K;
using GTLILlYXK9CZAtrEW5Ov;
using H1JNoZYdsGpw9R2ENOnC;
using Iw9ai3YRc5qQDX3FAdgI;
using ME6xTfYEtZ6IAeYZrk6P;
using NpPp04YcjX7Z32p7fQxj;
using pjg2ZIYcDvDGBQxLHyZf;
using Q1hlZtYd310DdVgq8xBK;
using r5tk1FYdb3wghuwemfLI;
using xhjo3XYjAKxYRH0k5iB1;
using YmLUebYXCRZa3JyS4MWE;

namespace jXpee7YXZyFJRs3dBfd4;

[ServiceContract(Name = "IMt5Service", CallbackContract = typeof(fikfkiYXVWYI6UabveGU))]
internal interface JtcCwqYXyEQFynH8emV4
{
	[OperationContract(Name = "Ping")]
	bool xWUloD1FdfW();

	[OperationContract(Name = "Start")]
	void dHqlnXLmFxp([MessageParameter(Name = "path")] string path, [MessageParameter(Name = "broker")] string broker, [MessageParameter(Name = "brokerTimeOffset")] TimeSpan brokerTimeOffset);

	[OperationContract(Name = "Stop")]
	void Stop();

	[OperationContract(Name = "OnConnected", IsOneWay = true)]
	void Uu4lobsMACD();

	[OperationContract(Name = "OnDisconnected", IsOneWay = true)]
	void YBsloNtGCL7();

	[OperationContract(Name = "OnSymbols", IsOneWay = true)]
	void UxKlokxSCCI([MessageParameter(Name = "symbols")] KSEJIQYdDVOkeZU0LWU5[] symbols);

	[OperationContract(Name = "OnAccounts", IsOneWay = true)]
	void PYSlo1BUi0R([MessageParameter(Name = "accounts")] S48lmjYXrJ4Q59RxkkkG[] accounts);

	[OperationContract(Name = "OnTicks", IsOneWay = true)]
	void Hlslo5UTGnw([MessageParameter(Name = "symbol")] string symbol, [MessageParameter(Name = "data")] byte[] data);

	[OperationContract(Name = "OnTick", IsOneWay = true)]
	void b9oloSDQXFb([MessageParameter(Name = "tick")] DrDjfgYdeuJS2KqRRX5b tick);

	[OperationContract(Name = "OnDom", IsOneWay = true)]
	void onMloxMsZn9([MessageParameter(Name = "dom")] VQUp5GYc4fEFG1A4R01F dom);

	[OperationContract(Name = "OnEmptyDom", IsOneWay = true)]
	void dqAloU7PJo5([MessageParameter(Name = "dom")] VQUp5GYc4fEFG1A4R01F dom);

	[OperationContract(Name = "OnSecurity", IsOneWay = true)]
	void mFTloLkqCv8([MessageParameter(Name = "security")] rginoPYEWJ2N98c8yybm security);

	[OperationContract(Name = "OnTrade", IsOneWay = true)]
	void MwQloeu8i7D([MessageParameter(Name = "trade")] uVu1bPYdFSYNtHvpyi1f trade);

	[OperationContract(Name = "OnOrder", IsOneWay = true)]
	void ThYlosYNvKY([MessageParameter(Name = "order")] g2aDPXYccy9KYR83W4tv order);

	[OperationContract(Name = "OnPosition", IsOneWay = true)]
	void tTvloXtZnCt([MessageParameter(Name = "position")] GBCEGhYj8OBdqtMEbgmD position);

	[OperationContract(Name = "OnPositions", IsOneWay = true)]
	void An4loTxdvGb([MessageParameter(Name = "positions")] GBCEGhYj8OBdqtMEbgmD[] positions);

	[OperationContract(Name = "OnPortfolio", IsOneWay = true)]
	void v51locvjv1v([MessageParameter(Name = "portfolio")] sL6wTZYjLnpqdk3BxHTV portfolio);

	[OperationContract(Name = "OnTransReply", IsOneWay = true)]
	void e0qlojeoQ0u([MessageParameter(Name = "reply")] tu0W6xYRXmu1GsJGftj0 reply);
}
