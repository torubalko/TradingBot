using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using MimeKit.Utils;
using Org.BouncyCastle.X509;

namespace MimeKit.Cryptography;

public class SQLServerCertificateDatabase : SqlCertificateDatabase
{
	public SQLServerCertificateDatabase(DbConnection connection, string password)
		: base(connection, password)
	{
	}

	protected override void AddTableColumn(DbConnection connection, DataTable table, DataColumn column)
	{
		StringBuilder stringBuilder = new StringBuilder("ALTER TABLE ");
		DataColumn[] primaryKey = table.PrimaryKey;
		int primaryKeys = ((primaryKey != null) ? primaryKey.Length : 0);
		stringBuilder.Append(table.TableName);
		stringBuilder.Append(" ADD COLUMN ");
		Build(stringBuilder, table, column, ref primaryKeys);
		using DbCommand dbCommand = connection.CreateCommand();
		dbCommand.CommandText = stringBuilder.ToString();
		dbCommand.CommandType = CommandType.Text;
		dbCommand.ExecuteNonQuery();
	}

	protected override void CreateTable(DbConnection connection, DataTable table)
	{
		StringBuilder stringBuilder = new StringBuilder("if not exists (select * from sysobjects where name='" + table.TableName + "' and xtype='U') ");
		int primaryKeys = 0;
		stringBuilder.Append("Create table " + table.TableName + " (");
		foreach (DataColumn column in table.Columns)
		{
			Build(stringBuilder, table, column, ref primaryKeys);
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

	private static void Build(StringBuilder statement, DataTable table, DataColumn column, ref int primaryKeys)
	{
		statement.Append(column.ColumnName);
		statement.Append(' ');
		if (column.DataType == typeof(long) || column.DataType == typeof(int))
		{
			if (column.AutoIncrement)
			{
				statement.Append("int identity(1,1)");
			}
			else if (column.DataType == typeof(long))
			{
				statement.Append("DateTime");
			}
			else
			{
				statement.Append("int");
			}
		}
		else if (column.DataType == typeof(bool))
		{
			statement.Append("bit");
		}
		else if (column.DataType == typeof(byte[]))
		{
			statement.Append("varbinary(4096)");
		}
		else
		{
			if (!(column.DataType == typeof(string)))
			{
				throw new NotImplementedException();
			}
			statement.Append("varchar(256)");
		}
		if (table != null && table.PrimaryKey != null && primaryKeys < table.PrimaryKey.Length)
		{
			for (int i = 0; i < table.PrimaryKey.Length; i++)
			{
				if (column == table.PrimaryKey[i])
				{
					statement.Append(" PRIMARY KEY Clustered");
					primaryKeys++;
					break;
				}
			}
		}
		if (!column.AllowDBNull)
		{
			statement.Append(" NOT NULL");
		}
	}

	protected override IList<DataColumn> GetTableColumns(DbConnection connection, string tableName)
	{
		using DbCommand dbCommand = connection.CreateCommand();
		dbCommand.CommandText = "select top 1 * from " + tableName;
		using DbDataReader dbDataReader = dbCommand.ExecuteReader();
		List<DataColumn> list = new List<DataColumn>();
		DataTable schemaTable = dbDataReader.GetSchemaTable();
		foreach (DataRow row in schemaTable.Rows)
		{
			list.Add(new DataColumn
			{
				ColumnName = row.Field<string>("ColumnName")
			});
		}
		return list;
	}

	protected override void CreateIndex(DbConnection connection, string tableName, string[] columnNames)
	{
		string indexName = GetIndexName(tableName, columnNames);
		string commandText = string.Format("IF NOT EXISTS (Select 8 from sys.indexes where name='{0}' and object_id=OBJECT_ID('{1}')) CREATE INDEX {0} ON {1}({2})", indexName, tableName, string.Join(", ", columnNames));
		using DbCommand dbCommand = connection.CreateCommand();
		dbCommand.CommandText = commandText;
		dbCommand.ExecuteNonQuery();
	}

	protected override void RemoveIndex(DbConnection connection, string tableName, string[] columnNames)
	{
		string indexName = GetIndexName(tableName, columnNames);
		string commandText = string.Format("IF EXISTS (Select 8 from sys.indexes where name='{0}' and object_id=OBJECT_ID('{1}')) DROP INDEX {0} ON {1}", indexName, tableName);
		using DbCommand dbCommand = connection.CreateCommand();
		dbCommand.CommandText = commandText;
		dbCommand.ExecuteNonQuery();
	}

	protected override DbCommand GetSelectCommand(X509Certificate certificate, X509CertificateRecordFields fields)
	{
		string value = certificate.GetFingerprint().ToLowerInvariant();
		string value2 = certificate.SerialNumber.ToString();
		string value3 = certificate.IssuerDN.ToString();
		DbCommand dbCommand = base.Connection.CreateCommand();
		StringBuilder stringBuilder = CreateSelectQuery(fields).Replace("SELECT", "SELECT top 1");
		stringBuilder = stringBuilder.Append(" WHERE ISSUERNAME = @ISSUERNAME AND SERIALNUMBER = @SERIALNUMBER AND FINGERPRINT = @FINGERPRINT");
		dbCommand.AddParameterWithValue("@ISSUERNAME", value3);
		dbCommand.AddParameterWithValue("@SERIALNUMBER", value2);
		dbCommand.AddParameterWithValue("@FINGERPRINT", value);
		dbCommand.CommandText = stringBuilder.ToString();
		dbCommand.CommandType = CommandType.Text;
		return dbCommand;
	}

	protected override DbCommand GetInsertCommand(X509CertificateRecord record)
	{
		StringBuilder stringBuilder = new StringBuilder("INSERT INTO CERTIFICATES(");
		StringBuilder stringBuilder2 = new StringBuilder("VALUES(");
		DbCommand dbCommand = base.Connection.CreateCommand();
		DataColumnCollection columns = base.CertificatesTable.Columns;
		for (int i = 1; i < columns.Count; i++)
		{
			if (i > 1)
			{
				stringBuilder.Append(", ");
				stringBuilder2.Append(", ");
			}
			object obj = GetValue(record, columns[i].ColumnName);
			if (obj is DateTime dateTime && dateTime < DateUtils.UnixEpoch)
			{
				obj = DateUtils.UnixEpoch;
			}
			if (columns[i].ColumnName == "PRIVATEKEY" && obj is DBNull)
			{
				obj = new byte[0];
			}
			string text = "@" + columns[i];
			dbCommand.AddParameterWithValue(text, obj);
			stringBuilder.Append(columns[i]);
			stringBuilder2.Append(text);
		}
		stringBuilder.Append(')');
		stringBuilder2.Append(')');
		dbCommand.CommandText = stringBuilder?.ToString() + " " + stringBuilder2;
		dbCommand.CommandType = CommandType.Text;
		return dbCommand;
	}
}
