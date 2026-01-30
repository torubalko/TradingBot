using System.Data.Common;

namespace MimeKit.Cryptography;

internal static class DbExtensions
{
	public static int AddParameterWithValue(this DbCommand command, string name, object value)
	{
		DbParameter dbParameter = command.CreateParameter();
		dbParameter.ParameterName = name;
		dbParameter.Value = value;
		return command.Parameters.Add(dbParameter);
	}
}
