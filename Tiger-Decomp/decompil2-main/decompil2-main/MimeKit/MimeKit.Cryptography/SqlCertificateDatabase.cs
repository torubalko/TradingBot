using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace MimeKit.Cryptography;

public abstract class SqlCertificateDatabase : X509CertificateDatabase
{
	private bool disposed;

	protected DbConnection Connection { get; private set; }

	protected DataTable CertificatesTable { get; private set; }

	protected DataTable CrlsTable { get; private set; }

	protected SqlCertificateDatabase(DbConnection connection, string password)
		: base(password)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		Connection = connection;
		if (connection.State != ConnectionState.Open)
		{
			connection.Open();
		}
		CertificatesTable = CreateCertificatesDataTable("CERTIFICATES");
		CrlsTable = CreateCrlsDataTable("CRLS");
		CreateCertificatesTable(CertificatesTable);
		CreateCrlsTable(CrlsTable);
	}

	private static DataTable CreateCertificatesDataTable(string tableName)
	{
		DataTable dataTable = new DataTable(tableName);
		dataTable.Columns.Add(new DataColumn("ID", typeof(int))
		{
			AutoIncrement = true
		});
		dataTable.Columns.Add(new DataColumn("TRUSTED", typeof(bool))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("ANCHOR", typeof(bool))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("BASICCONSTRAINTS", typeof(int))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("KEYUSAGE", typeof(int))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("NOTBEFORE", typeof(long))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("NOTAFTER", typeof(long))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("ISSUERNAME", typeof(string))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("SERIALNUMBER", typeof(string))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("SUBJECTNAME", typeof(string))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("SUBJECTKEYIDENTIFIER", typeof(string))
		{
			AllowDBNull = true
		});
		dataTable.Columns.Add(new DataColumn("SUBJECTEMAIL", typeof(string))
		{
			AllowDBNull = true
		});
		dataTable.Columns.Add(new DataColumn("FINGERPRINT", typeof(string))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("ALGORITHMS", typeof(string))
		{
			AllowDBNull = true
		});
		dataTable.Columns.Add(new DataColumn("ALGORITHMSUPDATED", typeof(long))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("CERTIFICATE", typeof(byte[]))
		{
			AllowDBNull = false,
			Unique = true
		});
		dataTable.Columns.Add(new DataColumn("PRIVATEKEY", typeof(byte[]))
		{
			AllowDBNull = true
		});
		dataTable.PrimaryKey = new DataColumn[1] { dataTable.Columns[0] };
		return dataTable;
	}

	private static DataTable CreateCrlsDataTable(string tableName)
	{
		DataTable dataTable = new DataTable(tableName);
		dataTable.Columns.Add(new DataColumn("ID", typeof(int))
		{
			AutoIncrement = true
		});
		dataTable.Columns.Add(new DataColumn("DELTA", typeof(bool))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("ISSUERNAME", typeof(string))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("THISUPDATE", typeof(long))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("NEXTUPDATE", typeof(long))
		{
			AllowDBNull = false
		});
		dataTable.Columns.Add(new DataColumn("CRL", typeof(byte[]))
		{
			AllowDBNull = false
		});
		dataTable.PrimaryKey = new DataColumn[1] { dataTable.Columns[0] };
		return dataTable;
	}

	protected abstract IList<DataColumn> GetTableColumns(DbConnection connection, string tableName);

	protected abstract void CreateTable(DbConnection connection, DataTable table);

	protected abstract void AddTableColumn(DbConnection connection, DataTable table, DataColumn column);

	protected string GetIndexName(string tableName, string[] columnNames)
	{
		return string.Format("{0}_{1}_INDEX", tableName, string.Join("_", columnNames));
	}

	protected virtual void CreateIndex(DbConnection connection, string tableName, string[] columnNames)
	{
		string indexName = GetIndexName(tableName, columnNames);
		string commandText = string.Format("CREATE INDEX IF NOT EXISTS {0} ON {1}({2})", indexName, tableName, string.Join(", ", columnNames));
		using DbCommand dbCommand = connection.CreateCommand();
		dbCommand.CommandText = commandText;
		dbCommand.ExecuteNonQuery();
	}

	protected virtual void RemoveIndex(DbConnection connection, string tableName, string[] columnNames)
	{
		string indexName = GetIndexName(tableName, columnNames);
		string commandText = $"DROP INDEX IF EXISTS {indexName}";
		using DbCommand dbCommand = connection.CreateCommand();
		dbCommand.CommandText = commandText;
		dbCommand.ExecuteNonQuery();
	}

	private void CreateCertificatesTable(DataTable table)
	{
		CreateTable(Connection, table);
		IList<DataColumn> tableColumns = GetTableColumns(Connection, table.TableName);
		bool flag = false;
		for (int i = 0; i < tableColumns.Count; i++)
		{
			if (tableColumns[i].ColumnName.Equals("ANCHOR", StringComparison.Ordinal))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			using (DbTransaction dbTransaction = Connection.BeginTransaction())
			{
				try
				{
					DataColumn column = table.Columns[table.Columns.IndexOf("ANCHOR")];
					AddTableColumn(Connection, table, column);
					column = table.Columns[table.Columns.IndexOf("SUBJECTNAME")];
					AddTableColumn(Connection, table, column);
					column = table.Columns[table.Columns.IndexOf("SUBJECTKEYIDENTIFIER")];
					AddTableColumn(Connection, table, column);
					foreach (X509CertificateRecord item in Find(null, trustedAnchorsOnly: false, X509CertificateRecordFields.Id | X509CertificateRecordFields.Certificate))
					{
						string commandText = "UPDATE CERTIFICATES SET ANCHOR = @ANCHOR, SUBJECTNAME = @SUBJECTNAME, SUBJECTKEYIDENTIFIER = @SUBJECTKEYIDENTIFIER WHERE ID = @ID";
						using DbCommand dbCommand = Connection.CreateCommand();
						dbCommand.AddParameterWithValue("@ID", item.Id);
						dbCommand.AddParameterWithValue("@ANCHOR", item.IsAnchor);
						dbCommand.AddParameterWithValue("@SUBJECTNAME", item.SubjectName);
						dbCommand.AddParameterWithValue("@SUBJECTKEYIDENTIFIER", item.SubjectKeyIdentifier?.AsHex());
						dbCommand.CommandType = CommandType.Text;
						dbCommand.CommandText = commandText;
						dbCommand.ExecuteNonQuery();
					}
					dbTransaction.Commit();
				}
				catch
				{
					dbTransaction.Rollback();
					throw;
				}
			}
			RemoveIndex(Connection, table.TableName, new string[1] { "TRUSTED" });
			RemoveIndex(Connection, table.TableName, new string[4] { "TRUSTED", "BASICCONSTRAINTS", "ISSUERNAME", "SERIALNUMBER" });
			RemoveIndex(Connection, table.TableName, new string[3] { "BASICCONSTRAINTS", "ISSUERNAME", "SERIALNUMBER" });
			RemoveIndex(Connection, table.TableName, new string[2] { "BASICCONSTRAINTS", "FINGERPRINT" });
			RemoveIndex(Connection, table.TableName, new string[2] { "BASICCONSTRAINTS", "SUBJECTEMAIL" });
		}
		CreateIndex(Connection, table.TableName, new string[3] { "ISSUERNAME", "SERIALNUMBER", "FINGERPRINT" });
		CreateIndex(Connection, table.TableName, new string[4] { "BASICCONSTRAINTS", "FINGERPRINT", "NOTBEFORE", "NOTAFTER" });
		CreateIndex(Connection, table.TableName, new string[4] { "BASICCONSTRAINTS", "SUBJECTEMAIL", "NOTBEFORE", "NOTAFTER" });
		CreateIndex(Connection, table.TableName, new string[3] { "TRUSTED", "ANCHOR", "KEYUSAGE" });
	}

	private void CreateCrlsTable(DataTable table)
	{
		CreateTable(Connection, table);
		CreateIndex(Connection, table.TableName, new string[1] { "ISSUERNAME" });
		CreateIndex(Connection, table.TableName, new string[3] { "DELTA", "ISSUERNAME", "THISUPDATE" });
	}

	protected StringBuilder CreateSelectQuery(X509CertificateRecordFields fields)
	{
		StringBuilder stringBuilder = new StringBuilder("SELECT ");
		string[] columnNames = X509CertificateDatabase.GetColumnNames(fields);
		for (int i = 0; i < columnNames.Length; i++)
		{
			if (i > 0)
			{
				stringBuilder = stringBuilder.Append(", ");
			}
			stringBuilder = stringBuilder.Append(columnNames[i]);
		}
		return stringBuilder.Append(" FROM CERTIFICATES");
	}

	protected override DbCommand GetSelectCommand(X509Certificate certificate, X509CertificateRecordFields fields)
	{
		string value = certificate.GetFingerprint().ToLowerInvariant();
		string value2 = certificate.SerialNumber.ToString();
		string value3 = certificate.IssuerDN.ToString();
		DbCommand dbCommand = Connection.CreateCommand();
		StringBuilder stringBuilder = CreateSelectQuery(fields);
		stringBuilder = stringBuilder.Append(" WHERE ISSUERNAME = @ISSUERNAME AND SERIALNUMBER = @SERIALNUMBER AND FINGERPRINT = @FINGERPRINT LIMIT 1");
		dbCommand.AddParameterWithValue("@ISSUERNAME", value3);
		dbCommand.AddParameterWithValue("@SERIALNUMBER", value2);
		dbCommand.AddParameterWithValue("@FINGERPRINT", value);
		dbCommand.CommandText = stringBuilder.ToString();
		dbCommand.CommandType = CommandType.Text;
		return dbCommand;
	}

	protected override DbCommand GetSelectCommand(MailboxAddress mailbox, DateTime now, bool requirePrivateKey, X509CertificateRecordFields fields)
	{
		SecureMailboxAddress secureMailboxAddress = mailbox as SecureMailboxAddress;
		DbCommand dbCommand = Connection.CreateCommand();
		StringBuilder stringBuilder = CreateSelectQuery(fields);
		stringBuilder = stringBuilder.Append(" WHERE BASICCONSTRAINTS = @BASICCONSTRAINTS ");
		dbCommand.AddParameterWithValue("@BASICCONSTRAINTS", -1);
		if (secureMailboxAddress != null && !string.IsNullOrEmpty(secureMailboxAddress.Fingerprint))
		{
			if (secureMailboxAddress.Fingerprint.Length < 40)
			{
				dbCommand.AddParameterWithValue("@FINGERPRINT", secureMailboxAddress.Fingerprint.ToLowerInvariant() + "%");
				stringBuilder = stringBuilder.Append("AND FINGERPRINT LIKE @FINGERPRINT ");
			}
			else
			{
				dbCommand.AddParameterWithValue("@FINGERPRINT", secureMailboxAddress.Fingerprint.ToLowerInvariant());
				stringBuilder = stringBuilder.Append("AND FINGERPRINT = @FINGERPRINT ");
			}
		}
		else
		{
			dbCommand.AddParameterWithValue("@SUBJECTEMAIL", mailbox.Address.ToLowerInvariant());
			stringBuilder = stringBuilder.Append("AND SUBJECTEMAIL = @SUBJECTEMAIL ");
		}
		stringBuilder = stringBuilder.Append("AND NOTBEFORE < @NOW AND NOTAFTER > @NOW");
		dbCommand.AddParameterWithValue("@NOW", now.ToUniversalTime());
		if (requirePrivateKey)
		{
			stringBuilder = stringBuilder.Append(" AND PRIVATEKEY IS NOT NULL");
		}
		dbCommand.CommandText = stringBuilder.ToString();
		dbCommand.CommandType = CommandType.Text;
		return dbCommand;
	}

	protected override DbCommand GetSelectCommand(IX509Selector selector, bool trustedAnchorsOnly, bool requirePrivateKey, X509CertificateRecordFields fields)
	{
		X509CertStoreSelector x509CertStoreSelector = selector as X509CertStoreSelector;
		DbCommand dbCommand = Connection.CreateCommand();
		StringBuilder stringBuilder = CreateSelectQuery(fields);
		int length = stringBuilder.Length;
		stringBuilder = stringBuilder.Append(" WHERE ");
		if (trustedAnchorsOnly)
		{
			stringBuilder = stringBuilder.Append("TRUSTED = @TRUSTED AND ANCHOR = @ANCHOR");
			dbCommand.AddParameterWithValue("@TRUSTED", true);
			dbCommand.AddParameterWithValue("@ANCHOR", true);
		}
		if (x509CertStoreSelector != null)
		{
			if (x509CertStoreSelector.BasicConstraints >= 0 || x509CertStoreSelector.BasicConstraints == -2)
			{
				if (dbCommand.Parameters.Count > 0)
				{
					stringBuilder = stringBuilder.Append(" AND ");
				}
				if (x509CertStoreSelector.BasicConstraints == -2)
				{
					dbCommand.AddParameterWithValue("@BASICCONSTRAINTS", -1);
					stringBuilder = stringBuilder.Append("BASICCONSTRAINTS = @BASICCONSTRAINTS");
				}
				else
				{
					dbCommand.AddParameterWithValue("@BASICCONSTRAINTS", x509CertStoreSelector.BasicConstraints);
					stringBuilder = stringBuilder.Append("BASICCONSTRAINTS >= @BASICCONSTRAINTS");
				}
			}
			if (x509CertStoreSelector.CertificateValid != null)
			{
				if (dbCommand.Parameters.Count > 0)
				{
					stringBuilder = stringBuilder.Append(" AND ");
				}
				dbCommand.AddParameterWithValue("@DATETIME", x509CertStoreSelector.CertificateValid.Value.ToUniversalTime());
				stringBuilder = stringBuilder.Append("NOTBEFORE < @DATETIME AND NOTAFTER > @DATETIME");
			}
			if (x509CertStoreSelector.Issuer != null || x509CertStoreSelector.Certificate != null)
			{
				X509Name x509Name = x509CertStoreSelector.Issuer ?? x509CertStoreSelector.Certificate.IssuerDN;
				if (dbCommand.Parameters.Count > 0)
				{
					stringBuilder = stringBuilder.Append(" AND ");
				}
				dbCommand.AddParameterWithValue("@ISSUERNAME", x509Name.ToString());
				stringBuilder = stringBuilder.Append("ISSUERNAME = @ISSUERNAME");
			}
			if (x509CertStoreSelector.SerialNumber != null || x509CertStoreSelector.Certificate != null)
			{
				BigInteger bigInteger = x509CertStoreSelector.SerialNumber ?? x509CertStoreSelector.Certificate.SerialNumber;
				if (dbCommand.Parameters.Count > 0)
				{
					stringBuilder = stringBuilder.Append(" AND ");
				}
				dbCommand.AddParameterWithValue("@SERIALNUMBER", bigInteger.ToString());
				stringBuilder = stringBuilder.Append("SERIALNUMBER = @SERIALNUMBER");
			}
			if (x509CertStoreSelector.Certificate != null)
			{
				if (dbCommand.Parameters.Count > 0)
				{
					stringBuilder = stringBuilder.Append(" AND ");
				}
				dbCommand.AddParameterWithValue("@FINGERPRINT", x509CertStoreSelector.Certificate.GetFingerprint());
				stringBuilder = stringBuilder.Append("FINGERPRINT = @FINGERPRINT");
			}
			if (x509CertStoreSelector.Subject != null)
			{
				if (dbCommand.Parameters.Count > 0)
				{
					stringBuilder = stringBuilder.Append(" AND ");
				}
				dbCommand.AddParameterWithValue("@SUBJECTNAME", x509CertStoreSelector.Subject.ToString());
				stringBuilder = stringBuilder.Append("SUBJECTNAME = @SUBJECTNAME");
			}
			if (x509CertStoreSelector.SubjectKeyIdentifier != null)
			{
				if (dbCommand.Parameters.Count > 0)
				{
					stringBuilder = stringBuilder.Append(" AND ");
				}
				Asn1OctetString asn1OctetString = (Asn1OctetString)Asn1Object.FromByteArray(x509CertStoreSelector.SubjectKeyIdentifier);
				string value = asn1OctetString.GetOctets().AsHex();
				dbCommand.AddParameterWithValue("@SUBJECTKEYIDENTIFIER", value);
				stringBuilder = stringBuilder.Append("SUBJECTKEYIDENTIFIER = @SUBJECTKEYIDENTIFIER");
			}
			if (x509CertStoreSelector.KeyUsage != null)
			{
				X509KeyUsageFlags keyUsageFlags = BouncyCastleCertificateExtensions.GetKeyUsageFlags(x509CertStoreSelector.KeyUsage);
				if (keyUsageFlags != X509KeyUsageFlags.None)
				{
					if (dbCommand.Parameters.Count > 0)
					{
						stringBuilder = stringBuilder.Append(" AND ");
					}
					dbCommand.AddParameterWithValue("@FLAGS", (int)keyUsageFlags);
					stringBuilder = stringBuilder.Append("(KEYUSAGE = 0 OR (KEYUSAGE & @FLAGS) = @FLAGS)");
				}
			}
		}
		if (requirePrivateKey)
		{
			if (dbCommand.Parameters.Count > 0)
			{
				stringBuilder = stringBuilder.Append(" AND ");
			}
			stringBuilder = stringBuilder.Append("PRIVATEKEY IS NOT NULL");
		}
		else if (dbCommand.Parameters.Count == 0)
		{
			stringBuilder.Length = length;
		}
		dbCommand.CommandText = stringBuilder.ToString();
		dbCommand.CommandType = CommandType.Text;
		return dbCommand;
	}

	protected override DbCommand GetSelectCommand(X509Name issuer, X509CrlRecordFields fields)
	{
		string text = "SELECT " + string.Join(", ", X509CertificateDatabase.GetColumnNames(fields)) + " FROM CRLS ";
		DbCommand dbCommand = Connection.CreateCommand();
		dbCommand.CommandText = text + "WHERE ISSUERNAME = @ISSUERNAME";
		dbCommand.AddParameterWithValue("@ISSUERNAME", issuer.ToString());
		dbCommand.CommandType = CommandType.Text;
		return dbCommand;
	}

	protected override DbCommand GetSelectCommand(X509Crl crl, X509CrlRecordFields fields)
	{
		string text = "SELECT " + string.Join(", ", X509CertificateDatabase.GetColumnNames(fields)) + " FROM CRLS ";
		string value = crl.IssuerDN.ToString();
		DbCommand dbCommand = Connection.CreateCommand();
		dbCommand.CommandText = text + "WHERE DELTA = @DELTA AND ISSUERNAME = @ISSUERNAME AND THISUPDATE = @THISUPDATE LIMIT 1";
		dbCommand.AddParameterWithValue("@DELTA", crl.IsDelta());
		dbCommand.AddParameterWithValue("@ISSUERNAME", value);
		dbCommand.AddParameterWithValue("@THISUPDATE", crl.ThisUpdate.ToUniversalTime());
		dbCommand.CommandType = CommandType.Text;
		return dbCommand;
	}

	protected override DbCommand GetSelectAllCrlsCommand()
	{
		DbCommand dbCommand = Connection.CreateCommand();
		dbCommand.CommandText = "SELECT ID, CRL FROM CRLS";
		dbCommand.CommandType = CommandType.Text;
		return dbCommand;
	}

	protected override DbCommand GetDeleteCommand(X509CertificateRecord record)
	{
		DbCommand dbCommand = Connection.CreateCommand();
		dbCommand.CommandText = "DELETE FROM CERTIFICATES WHERE ID = @ID";
		dbCommand.AddParameterWithValue("@ID", record.Id);
		dbCommand.CommandType = CommandType.Text;
		return dbCommand;
	}

	protected override DbCommand GetDeleteCommand(X509CrlRecord record)
	{
		DbCommand dbCommand = Connection.CreateCommand();
		dbCommand.CommandText = "DELETE FROM CRLS WHERE ID = @ID";
		dbCommand.AddParameterWithValue("@ID", record.Id);
		dbCommand.CommandType = CommandType.Text;
		return dbCommand;
	}

	protected override DbCommand GetInsertCommand(X509CertificateRecord record)
	{
		StringBuilder stringBuilder = new StringBuilder("INSERT INTO CERTIFICATES(");
		StringBuilder stringBuilder2 = new StringBuilder("VALUES(");
		DbCommand dbCommand = Connection.CreateCommand();
		DataColumnCollection columns = CertificatesTable.Columns;
		for (int i = 1; i < columns.Count; i++)
		{
			if (i > 1)
			{
				stringBuilder.Append(", ");
				stringBuilder2.Append(", ");
			}
			object value = GetValue(record, columns[i].ColumnName);
			string text = "@" + columns[i];
			dbCommand.AddParameterWithValue(text, value);
			stringBuilder.Append(columns[i]);
			stringBuilder2.Append(text);
		}
		stringBuilder.Append(')');
		stringBuilder2.Append(')');
		dbCommand.CommandText = stringBuilder?.ToString() + " " + stringBuilder2;
		dbCommand.CommandType = CommandType.Text;
		return dbCommand;
	}

	protected override DbCommand GetInsertCommand(X509CrlRecord record)
	{
		StringBuilder stringBuilder = new StringBuilder("INSERT INTO CRLS(");
		StringBuilder stringBuilder2 = new StringBuilder("VALUES(");
		DbCommand dbCommand = Connection.CreateCommand();
		DataColumnCollection columns = CrlsTable.Columns;
		for (int i = 1; i < columns.Count; i++)
		{
			if (i > 1)
			{
				stringBuilder.Append(", ");
				stringBuilder2.Append(", ");
			}
			object value = X509CertificateDatabase.GetValue(record, columns[i].ColumnName);
			string text = "@" + columns[i];
			dbCommand.AddParameterWithValue(text, value);
			stringBuilder.Append(columns[i]);
			stringBuilder2.Append(text);
		}
		stringBuilder.Append(')');
		stringBuilder2.Append(')');
		dbCommand.CommandText = stringBuilder?.ToString() + " " + stringBuilder2;
		dbCommand.CommandType = CommandType.Text;
		return dbCommand;
	}

	protected override DbCommand GetUpdateCommand(X509CertificateRecord record, X509CertificateRecordFields fields)
	{
		StringBuilder stringBuilder = new StringBuilder("UPDATE CERTIFICATES SET ");
		string[] columnNames = X509CertificateDatabase.GetColumnNames(fields & ~X509CertificateRecordFields.Id);
		DbCommand dbCommand = Connection.CreateCommand();
		for (int i = 0; i < columnNames.Length; i++)
		{
			object value = GetValue(record, columnNames[i]);
			string text = "@" + columnNames[i];
			if (i > 0)
			{
				stringBuilder.Append(", ");
			}
			stringBuilder.Append(columnNames[i]);
			stringBuilder.Append(" = ");
			stringBuilder.Append(text);
			dbCommand.AddParameterWithValue(text, value);
		}
		stringBuilder.Append(" WHERE ID = @ID");
		dbCommand.AddParameterWithValue("@ID", record.Id);
		dbCommand.CommandText = stringBuilder.ToString();
		dbCommand.CommandType = CommandType.Text;
		return dbCommand;
	}

	protected override DbCommand GetUpdateCommand(X509CrlRecord record)
	{
		StringBuilder stringBuilder = new StringBuilder("UPDATE CRLS SET ");
		DbCommand dbCommand = Connection.CreateCommand();
		DataColumnCollection columns = CrlsTable.Columns;
		for (int i = 1; i < columns.Count; i++)
		{
			object value = X509CertificateDatabase.GetValue(record, columns[i].ColumnName);
			string text = "@" + columns[i];
			if (i > 1)
			{
				stringBuilder.Append(", ");
			}
			stringBuilder.Append(columns[i]);
			stringBuilder.Append(" = ");
			stringBuilder.Append(text);
			dbCommand.AddParameterWithValue(text, value);
		}
		stringBuilder.Append(" WHERE ID = @ID");
		dbCommand.AddParameterWithValue("@ID", record.Id);
		dbCommand.CommandText = stringBuilder.ToString();
		dbCommand.CommandType = CommandType.Text;
		return dbCommand;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && !disposed)
		{
			if (Connection != null)
			{
				Connection.Dispose();
			}
			disposed = true;
		}
		base.Dispose(disposing);
	}
}
