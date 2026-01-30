using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Reflection;
using System.Text;

namespace MimeKit.Cryptography;

public class SqliteCertificateDatabase : SqlCertificateDatabase
{
	private class SQLiteAssembly
	{
		public Type ConnectionStringBuilderType { get; private set; }

		public Type ConnectionType { get; private set; }

		public Assembly Assembly { get; private set; }

		public PropertyInfo ConnectionStringProperty { get; private set; }

		public PropertyInfo DateTimeFormatProperty { get; private set; }

		public PropertyInfo DataSourceProperty { get; private set; }

		public static SQLiteAssembly Load(string assemblyName)
		{
			try
			{
				int num = assemblyName.LastIndexOf('.');
				string text = assemblyName.Substring(num + 1);
				Assembly assembly = Assembly.Load(new AssemblyName(assemblyName));
				Type type = assembly.GetType(assemblyName + "." + text + "ConnectionStringBuilder");
				Type type2 = assembly.GetType(assemblyName + "." + text + "Connection");
				PropertyInfo property = type.GetProperty("ConnectionString");
				PropertyInfo property2 = type.GetProperty("DateTimeFormat");
				PropertyInfo property3 = type.GetProperty("DataSource");
				return new SQLiteAssembly
				{
					Assembly = assembly,
					ConnectionType = type2,
					ConnectionStringBuilderType = type,
					ConnectionStringProperty = property,
					DateTimeFormatProperty = property2,
					DataSourceProperty = property3
				};
			}
			catch
			{
				return null;
			}
		}
	}

	private static readonly SQLiteAssembly sqliteAssembly;

	internal static bool IsAvailable { get; private set; }

	static SqliteCertificateDatabase()
	{
		PlatformID platform = Environment.OSVersion.Platform;
		if ((platform == PlatformID.Unix || platform == PlatformID.MacOSX) && (sqliteAssembly = SQLiteAssembly.Load("Mono.Data.Sqlite")) != null && VerifySQLiteAssemblyIsUsable())
		{
			IsAvailable = true;
		}
		else if ((sqliteAssembly = SQLiteAssembly.Load("System.Data.SQLite")) != null && VerifySQLiteAssemblyIsUsable())
		{
			IsAvailable = true;
		}
	}

	private static bool VerifySQLiteAssemblyIsUsable()
	{
		string tempFileName = Path.GetTempFileName();
		try
		{
			DbConnection dbConnection = CreateConnection(tempFileName);
			dbConnection.Dispose();
			return true;
		}
		catch
		{
			return false;
		}
		finally
		{
			File.Delete(tempFileName);
		}
	}

	private static DbConnection CreateConnection(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException("The file name cannot be empty.", "fileName");
		}
		if (!File.Exists(fileName))
		{
			string directoryName = Path.GetDirectoryName(fileName);
			if (!string.IsNullOrEmpty(directoryName) && !Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			File.Create(fileName).Dispose();
		}
		object obj = Activator.CreateInstance(sqliteAssembly.ConnectionStringBuilderType);
		sqliteAssembly.DataSourceProperty.SetValue(obj, fileName, null);
		sqliteAssembly.DateTimeFormatProperty?.SetValue(obj, 0, null);
		string text = (string)sqliteAssembly.ConnectionStringProperty.GetValue(obj, null);
		Type connectionType = sqliteAssembly.ConnectionType;
		object[] args = new string[1] { text };
		return (DbConnection)Activator.CreateInstance(connectionType, args);
	}

	public SqliteCertificateDatabase(string fileName, string password)
		: this(CreateConnection(fileName), password)
	{
	}

	public SqliteCertificateDatabase(DbConnection connection, string password)
		: base(connection, password)
	{
	}

	protected override IList<DataColumn> GetTableColumns(DbConnection connection, string tableName)
	{
		using DbCommand dbCommand = connection.CreateCommand();
		dbCommand.CommandText = "PRAGMA table_info(" + tableName + ")";
		using DbDataReader dbDataReader = dbCommand.ExecuteReader();
		List<DataColumn> list = new List<DataColumn>();
		while (dbDataReader.Read())
		{
			DataColumn dataColumn = new DataColumn();
			for (int i = 0; i < dbDataReader.FieldCount; i++)
			{
				switch (dbDataReader.GetName(i).ToUpperInvariant())
				{
				case "NAME":
					dataColumn.ColumnName = dbDataReader.GetString(i);
					break;
				case "TYPE":
					switch (dbDataReader.GetString(i))
					{
					case "INTEGER":
						dataColumn.DataType = typeof(long);
						break;
					case "BLOB":
						dataColumn.DataType = typeof(byte[]);
						break;
					case "TEXT":
						dataColumn.DataType = typeof(string);
						break;
					}
					break;
				case "NOTNULL":
					dataColumn.AllowDBNull = !dbDataReader.GetBoolean(i);
					break;
				}
			}
			list.Add(dataColumn);
		}
		return list;
	}

	private static void Build(StringBuilder statement, DataTable table, DataColumn column, ref int primaryKeys, bool create)
	{
		statement.Append(column.ColumnName);
		statement.Append(' ');
		if (column.DataType == typeof(long) || column.DataType == typeof(int) || column.DataType == typeof(bool))
		{
			statement.Append("INTEGER");
		}
		else if (column.DataType == typeof(byte[]))
		{
			statement.Append("BLOB");
		}
		else
		{
			if (!(column.DataType == typeof(string)))
			{
				throw new NotImplementedException();
			}
			statement.Append("TEXT");
		}
		bool flag = false;
		if (table != null && table.PrimaryKey != null && primaryKeys < table.PrimaryKey.Length)
		{
			for (int i = 0; i < table.PrimaryKey.Length; i++)
			{
				if (column == table.PrimaryKey[i])
				{
					statement.Append(" PRIMARY KEY");
					flag = true;
					primaryKeys++;
					break;
				}
			}
		}
		if (column.AutoIncrement)
		{
			statement.Append(" AUTOINCREMENT");
		}
		if (column.Unique && !flag)
		{
			statement.Append(" UNIQUE");
		}
		if (create && !column.AllowDBNull)
		{
			statement.Append(" NOT NULL");
		}
	}

	protected override void CreateTable(DbConnection connection, DataTable table)
	{
		StringBuilder stringBuilder = new StringBuilder("CREATE TABLE IF NOT EXISTS ");
		int primaryKeys = 0;
		stringBuilder.Append(table.TableName);
		stringBuilder.Append('(');
		foreach (DataColumn column in table.Columns)
		{
			Build(stringBuilder, table, column, ref primaryKeys, create: true);
			stringBuilder.Append(", ");
		}
		if (table.Columns.Count > 0)
		{
			stringBuilder.Length -= 2;
		}
		stringBuilder.Append(')');
		using DbCommand dbCommand = connection.CreateCommand();
		dbCommand.CommandText = stringBuilder.ToString();
		dbCommand.CommandType = CommandType.Text;
		dbCommand.ExecuteNonQuery();
	}

	protected override void AddTableColumn(DbConnection connection, DataTable table, DataColumn column)
	{
		StringBuilder stringBuilder = new StringBuilder("ALTER TABLE ");
		DataColumn[] primaryKey = table.PrimaryKey;
		int primaryKeys = ((primaryKey != null) ? primaryKey.Length : 0);
		stringBuilder.Append(table.TableName);
		stringBuilder.Append(" ADD COLUMN ");
		Build(stringBuilder, table, column, ref primaryKeys, create: false);
		using DbCommand dbCommand = connection.CreateCommand();
		dbCommand.CommandText = stringBuilder.ToString();
		dbCommand.CommandType = CommandType.Text;
		dbCommand.ExecuteNonQuery();
	}
}
