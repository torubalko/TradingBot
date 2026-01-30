using System.ServiceModel;
using vZnnVkYDnry7DpKxoAu6;

namespace Qk5NBsYoArSMdUZGlvTX;

[ServiceContract]
internal interface x1LyagYo83y8Ar0GEt6Y
{
	[OperationContract(Name = "SendTrans", IsOneWay = true)]
	void B9sloQFZKOB([MessageParameter(Name = "trans")] n1iJxrYD95hlVUridLEE trans);

	[OperationContract(Name = "RequestData", IsOneWay = true)]
	void gvg5bW0rmux();

	[OperationContract(Name = "RequestTicks", IsOneWay = true)]
	void PnDlYXj2m35([MessageParameter(Name = "id")] string id);

	[OperationContract(Name = "RegisterSecurity", IsOneWay = true)]
	void gtDlodYSyiE([MessageParameter(Name = "id")] string id);

	[OperationContract(Name = "UnRegisterSecurity", IsOneWay = true)]
	void p42log7iNy8([MessageParameter(Name = "id")] string id);

	[OperationContract(Name = "RegisterTicks", IsOneWay = true)]
	void lrUloRXiXCY([MessageParameter(Name = "id")] string id);

	[OperationContract(Name = "UnRegisterTicks", IsOneWay = true)]
	void FV8lo6vJwXE([MessageParameter(Name = "id")] string id);

	[OperationContract(Name = "RegisterQuotes", IsOneWay = true)]
	void oQPloM6Pfcb([MessageParameter(Name = "id")] string id);

	[OperationContract(Name = "UnRegisterQuotes", IsOneWay = true)]
	void XebloOnFjYO([MessageParameter(Name = "id")] string id);
}
