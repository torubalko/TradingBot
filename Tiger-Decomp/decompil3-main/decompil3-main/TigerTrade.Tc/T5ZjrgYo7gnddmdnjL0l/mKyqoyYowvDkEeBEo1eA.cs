using System.ServiceModel;
using conBMMYBtKf7u05w6mBZ;
using GBTptOYlZysXFLCCB4JB;
using lKxADVYvSkLdNjbvOrBi;
using OX2b7TYbXbjH2i4QRB1T;
using Qk5NBsYoArSMdUZGlvTX;
using tBBmH4Ya1gMdS6owZ4UN;
using urffJxYvae90muGelARv;
using vSM8GrY41W7BCAxSYNEL;
using wiKheyYlFtxtdvACwDSe;
using yIl9ETYoJmR0T9XqLZUb;
using YYikqHYinlbJd3fAKXQw;

namespace T5ZjrgYo7gnddmdnjL0l;

[ServiceContract(Name = "IQuikService", CallbackContract = typeof(x1LyagYo83y8Ar0GEt6Y))]
internal interface mKyqoyYowvDkEeBEo1eA
{
	[OperationContract(Name = "Ping")]
	bool xWUloD1FdfW();

	[OperationContract(Name = "Start")]
	void dHqlnXLmFxp([MessageParameter(Name = "path")] string path);

	[OperationContract(Name = "Stop")]
	void Stop();

	[OperationContract(Name = "OnConnected", IsOneWay = true)]
	void Uu4lobsMACD();

	[OperationContract(Name = "OnDisconnected", IsOneWay = true)]
	void YBsloNtGCL7();

	[OperationContract(Name = "OnSymbols", IsOneWay = true)]
	void UxKlokxSCCI([MessageParameter(Name = "symbols")] mJ4PtaYlyx9OwiiAYiE6[] symbols);

	[OperationContract(Name = "OnAccounts", IsOneWay = true)]
	void PYSlo1BUi0R([MessageParameter(Name = "accounts")] mCMoDUYoPpg9XOXnETgw[] accounts);

	[OperationContract(Name = "OnTicks", IsOneWay = true)]
	void Hlslo5UTGnw([MessageParameter(Name = "id")] string id, [MessageParameter(Name = "data")] byte[] data);

	[OperationContract(Name = "OnTick", IsOneWay = true)]
	void b9oloSDQXFb([MessageParameter(Name = "tick")] Av0ZjvYlJa9VldBWm8Fn tick);

	[OperationContract(Name = "OnDom", IsOneWay = true)]
	void onMloxMsZn9([MessageParameter(Name = "dom")] Soi9F3YvBpUWe4vk9UAq dom);

	[OperationContract(Name = "OnSecurity", IsOneWay = true)]
	void mFTloLkqCv8([MessageParameter(Name = "security")] MhypANYi9h2fDLRUrR3d security);

	[OperationContract(Name = "OnTrade", IsOneWay = true)]
	void MwQloeu8i7D([MessageParameter(Name = "trade")] YKo5OsY4krj5Aou5U5ZM trade);

	[OperationContract(Name = "OnOrder", IsOneWay = true)]
	void ThYlosYNvKY([MessageParameter(Name = "order")] Eckcw3Yv5NOg4bCrD6Hb order);

	[OperationContract(Name = "OnPosition", IsOneWay = true)]
	void tTvloXtZnCt([MessageParameter(Name = "position")] zPK74CYakrQXC7jZKDXc position);

	[OperationContract(Name = "OnPortfolio", IsOneWay = true)]
	void v51locvjv1v([MessageParameter(Name = "portfolio")] UXs7tXYBWXaq62OHgYEN portfolio);

	[OperationContract(Name = "OnTransReply", IsOneWay = true)]
	void e0qlojeoQ0u([MessageParameter(Name = "reply")] ON0ubVYbs7yv2WLb4qg3 reply);

	[OperationContract(Name = "OnRequestDataFinish", IsOneWay = true)]
	void lLJloEl1YxK();
}
