using System.Collections.Generic;

namespace ActiproSoftware.Windows.Controls.Grids.PropertyData;

public interface IDataFactory
{
	IList<IDataModel> GetDataModels(IDataFactoryRequest request);
}
