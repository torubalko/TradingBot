using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.BC;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace MimeKit.Cryptography;

public abstract class X509CertificateDatabase : IX509CertificateDatabase, IX509Store, IDisposable
{
	private const X509CertificateRecordFields PrivateKeyFields = X509CertificateRecordFields.Certificate | X509CertificateRecordFields.PrivateKey;

	private static readonly DerObjectIdentifier DefaultEncryptionAlgorithm = BCObjectIdentifiers.bc_pbe_sha256_pkcs12_aes256_cbc;

	private const int DefaultMinIterations = 1024;

	private const int DefaultSaltSize = 20;

	private readonly char[] passwd;

	protected DerObjectIdentifier EncryptionAlgorithm { get; set; }

	protected int MinIterations { get; set; }

	protected int SaltSize { get; set; }

	protected X509CertificateDatabase(string password)
	{
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		EncryptionAlgorithm = DefaultEncryptionAlgorithm;
		MinIterations = 1024;
		SaltSize = 20;
		passwd = password.ToCharArray();
	}

	~X509CertificateDatabase()
	{
		Dispose(disposing: false);
	}

	private static int ReadBinaryBlob(DbDataReader reader, int column, ref byte[] buffer)
	{
		long bytes;
		if ((bytes = reader.GetBytes(column, 0L, null, 0, buffer.Length)) > buffer.Length)
		{
			Array.Resize(ref buffer, (int)bytes);
		}
		return (int)reader.GetBytes(column, 0L, buffer, 0, (int)bytes);
	}

	private static X509Certificate DecodeCertificate(DbDataReader reader, X509CertificateParser parser, int column, ref byte[] buffer)
	{
		int count = ReadBinaryBlob(reader, column, ref buffer);
		using MemoryStream inStream = new MemoryStream(buffer, 0, count, writable: false);
		return parser.ReadCertificate(inStream);
	}

	private static X509Crl DecodeX509Crl(DbDataReader reader, X509CrlParser parser, int column, ref byte[] buffer)
	{
		int count = ReadBinaryBlob(reader, column, ref buffer);
		using MemoryStream inStream = new MemoryStream(buffer, 0, count, writable: false);
		return parser.ReadCrl(inStream);
	}

	private byte[] EncryptAsymmetricKeyParameter(AsymmetricKeyParameter key)
	{
		IBufferedCipher bufferedCipher = PbeUtilities.CreateEngine(EncryptionAlgorithm.Id) as IBufferedCipher;
		PrivateKeyInfo privateKeyInfo = PrivateKeyInfoFactory.CreatePrivateKeyInfo(key);
		SecureRandom secureRandom = new SecureRandom();
		byte[] array = new byte[SaltSize];
		if (bufferedCipher == null)
		{
			throw new Exception("Unknown encryption algorithm: " + EncryptionAlgorithm.Id);
		}
		secureRandom.NextBytes(array);
		Asn1Encodable parameters = PbeUtilities.GenerateAlgorithmParameters(EncryptionAlgorithm.Id, array, MinIterations);
		AlgorithmIdentifier algorithmIdentifier = new AlgorithmIdentifier(EncryptionAlgorithm, parameters);
		ICipherParameters cipherParameters = PbeUtilities.GenerateCipherParameters(algorithmIdentifier, passwd);
		if (cipherParameters == null)
		{
			throw new Exception("BouncyCastle bug detected: Failed to generate cipher parameters.");
		}
		bufferedCipher.Init(forEncryption: true, cipherParameters);
		byte[] encoding = bufferedCipher.DoFinal(privateKeyInfo.GetEncoded());
		EncryptedPrivateKeyInfo encryptedPrivateKeyInfo = new EncryptedPrivateKeyInfo(algorithmIdentifier, encoding);
		return encryptedPrivateKeyInfo.GetEncoded();
	}

	private AsymmetricKeyParameter DecryptAsymmetricKeyParameter(byte[] buffer, int length)
	{
		using MemoryStream input = new MemoryStream(buffer, 0, length, writable: false);
		using Asn1InputStream asn1InputStream = new Asn1InputStream(input);
		if (!(asn1InputStream.ReadObject() is Asn1Sequence obj))
		{
			return null;
		}
		EncryptedPrivateKeyInfo instance = EncryptedPrivateKeyInfo.GetInstance(obj);
		AlgorithmIdentifier encryptionAlgorithm = instance.EncryptionAlgorithm;
		byte[] encryptedData = instance.GetEncryptedData();
		if (!(PbeUtilities.CreateEngine(encryptionAlgorithm) is IBufferedCipher bufferedCipher))
		{
			return null;
		}
		ICipherParameters cipherParameters = PbeUtilities.GenerateCipherParameters(encryptionAlgorithm, passwd);
		if (cipherParameters == null)
		{
			throw new Exception("BouncyCastle bug detected: Failed to generate cipher parameters.");
		}
		bufferedCipher.Init(forEncryption: false, cipherParameters);
		byte[] obj2 = bufferedCipher.DoFinal(encryptedData);
		PrivateKeyInfo instance2 = PrivateKeyInfo.GetInstance(obj2);
		return PrivateKeyFactory.CreateKey(instance2);
	}

	private AsymmetricKeyParameter DecodePrivateKey(DbDataReader reader, int column, ref byte[] buffer)
	{
		if (reader.IsDBNull(column))
		{
			return null;
		}
		int length = ReadBinaryBlob(reader, column, ref buffer);
		return DecryptAsymmetricKeyParameter(buffer, length);
	}

	private object EncodePrivateKey(AsymmetricKeyParameter key)
	{
		if (key == null)
		{
			return DBNull.Value;
		}
		return EncryptAsymmetricKeyParameter(key);
	}

	private static EncryptionAlgorithm[] DecodeEncryptionAlgorithms(DbDataReader reader, int column)
	{
		if (reader.IsDBNull(column))
		{
			return null;
		}
		List<EncryptionAlgorithm> list = new List<EncryptionAlgorithm>();
		string text = reader.GetString(column);
		string[] array = text.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text2 in array)
		{
			if (Enum.TryParse<EncryptionAlgorithm>(text2.Trim(), ignoreCase: true, out var result))
			{
				list.Add(result);
			}
		}
		return list.ToArray();
	}

	private static object EncodeEncryptionAlgorithms(EncryptionAlgorithm[] algorithms)
	{
		if (algorithms == null || algorithms.Length == 0)
		{
			return DBNull.Value;
		}
		string[] array = new string[algorithms.Length];
		for (int i = 0; i < algorithms.Length; i++)
		{
			array[i] = algorithms[i].ToString();
		}
		return string.Join(",", array);
	}

	private X509CertificateRecord LoadCertificateRecord(DbDataReader reader, X509CertificateParser parser, ref byte[] buffer)
	{
		X509CertificateRecord x509CertificateRecord = new X509CertificateRecord();
		for (int i = 0; i < reader.FieldCount; i++)
		{
			switch (reader.GetName(i).ToUpperInvariant())
			{
			case "CERTIFICATE":
				x509CertificateRecord.Certificate = DecodeCertificate(reader, parser, i, ref buffer);
				break;
			case "PRIVATEKEY":
				x509CertificateRecord.PrivateKey = DecodePrivateKey(reader, i, ref buffer);
				break;
			case "ALGORITHMS":
				x509CertificateRecord.Algorithms = DecodeEncryptionAlgorithms(reader, i);
				break;
			case "ALGORITHMSUPDATED":
				x509CertificateRecord.AlgorithmsUpdated = DateTime.SpecifyKind(reader.GetDateTime(i), DateTimeKind.Utc);
				break;
			case "TRUSTED":
				x509CertificateRecord.IsTrusted = reader.GetBoolean(i);
				break;
			case "ID":
				x509CertificateRecord.Id = reader.GetInt32(i);
				break;
			}
		}
		return x509CertificateRecord;
	}

	private X509CrlRecord LoadCrlRecord(DbDataReader reader, X509CrlParser parser, ref byte[] buffer)
	{
		X509CrlRecord x509CrlRecord = new X509CrlRecord();
		for (int i = 0; i < reader.FieldCount; i++)
		{
			switch (reader.GetName(i).ToUpperInvariant())
			{
			case "CRL":
				x509CrlRecord.Crl = DecodeX509Crl(reader, parser, i, ref buffer);
				break;
			case "THISUPDATE":
				x509CrlRecord.ThisUpdate = DateTime.SpecifyKind(reader.GetDateTime(i), DateTimeKind.Utc);
				break;
			case "NEXTUPDATE":
				x509CrlRecord.NextUpdate = DateTime.SpecifyKind(reader.GetDateTime(i), DateTimeKind.Utc);
				break;
			case "DELTA":
				x509CrlRecord.IsDelta = reader.GetBoolean(i);
				break;
			case "ID":
				x509CrlRecord.Id = reader.GetInt32(i);
				break;
			}
		}
		return x509CrlRecord;
	}

	protected static string[] GetColumnNames(X509CertificateRecordFields fields)
	{
		List<string> list = new List<string>();
		if ((fields & X509CertificateRecordFields.Id) != 0)
		{
			list.Add("ID");
		}
		if ((fields & X509CertificateRecordFields.Trusted) != 0)
		{
			list.Add("TRUSTED");
		}
		if ((fields & X509CertificateRecordFields.Algorithms) != 0)
		{
			list.Add("ALGORITHMS");
		}
		if ((fields & X509CertificateRecordFields.AlgorithmsUpdated) != 0)
		{
			list.Add("ALGORITHMSUPDATED");
		}
		if ((fields & X509CertificateRecordFields.Certificate) != 0)
		{
			list.Add("CERTIFICATE");
		}
		if ((fields & X509CertificateRecordFields.PrivateKey) != 0)
		{
			list.Add("PRIVATEKEY");
		}
		return list.ToArray();
	}

	protected abstract DbCommand GetSelectCommand(X509Certificate certificate, X509CertificateRecordFields fields);

	protected abstract DbCommand GetSelectCommand(MailboxAddress mailbox, DateTime now, bool requirePrivateKey, X509CertificateRecordFields fields);

	protected abstract DbCommand GetSelectCommand(IX509Selector selector, bool trustedAnchorsOnly, bool requirePrivateKey, X509CertificateRecordFields fields);

	protected static string[] GetColumnNames(X509CrlRecordFields fields)
	{
		List<string> list = new List<string>();
		if ((fields & X509CrlRecordFields.Id) != 0)
		{
			list.Add("ID");
		}
		if ((fields & X509CrlRecordFields.IsDelta) != 0)
		{
			list.Add("DELTA");
		}
		if ((fields & X509CrlRecordFields.IssuerName) != 0)
		{
			list.Add("ISSUERNAME");
		}
		if ((fields & X509CrlRecordFields.ThisUpdate) != 0)
		{
			list.Add("THISUPDATE");
		}
		if ((fields & X509CrlRecordFields.NextUpdate) != 0)
		{
			list.Add("NEXTUPDATE");
		}
		if ((fields & X509CrlRecordFields.Crl) != 0)
		{
			list.Add("CRL");
		}
		return list.ToArray();
	}

	protected abstract DbCommand GetSelectCommand(X509Name issuer, X509CrlRecordFields fields);

	protected abstract DbCommand GetSelectCommand(X509Crl crl, X509CrlRecordFields fields);

	protected abstract DbCommand GetSelectAllCrlsCommand();

	protected abstract DbCommand GetDeleteCommand(X509CertificateRecord record);

	protected abstract DbCommand GetDeleteCommand(X509CrlRecord record);

	protected object GetValue(X509CertificateRecord record, string columnName)
	{
		switch (columnName)
		{
		case "BASICCONSTRAINTS":
			return record.BasicConstraints;
		case "TRUSTED":
			return record.IsTrusted;
		case "ANCHOR":
			return record.IsAnchor;
		case "KEYUSAGE":
			return (int)record.KeyUsage;
		case "NOTBEFORE":
			return record.NotBefore.ToUniversalTime();
		case "NOTAFTER":
			return record.NotAfter.ToUniversalTime();
		case "ISSUERNAME":
			return record.IssuerName;
		case "SERIALNUMBER":
			return record.SerialNumber;
		case "SUBJECTNAME":
			return record.SubjectName;
		case "SUBJECTKEYIDENTIFIER":
			return record.SubjectKeyIdentifier?.AsHex();
		case "SUBJECTEMAIL":
			if (record.SubjectEmail == null)
			{
				return string.Empty;
			}
			return record.SubjectEmail.ToLowerInvariant();
		case "FINGERPRINT":
			return record.Fingerprint.ToLowerInvariant();
		case "ALGORITHMS":
			return EncodeEncryptionAlgorithms(record.Algorithms);
		case "ALGORITHMSUPDATED":
			return record.AlgorithmsUpdated;
		case "CERTIFICATE":
			return record.Certificate.GetEncoded();
		case "PRIVATEKEY":
			return EncodePrivateKey(record.PrivateKey);
		default:
			throw new ArgumentException($"Unknown column name: {columnName}", "columnName");
		}
	}

	protected static object GetValue(X509CrlRecord record, string columnName)
	{
		return columnName switch
		{
			"DELTA" => record.IsDelta, 
			"ISSUERNAME" => record.IssuerName, 
			"THISUPDATE" => record.ThisUpdate, 
			"NEXTUPDATE" => record.NextUpdate, 
			"CRL" => record.Crl.GetEncoded(), 
			_ => throw new ArgumentException($"Unknown column name: {columnName}", "columnName"), 
		};
	}

	protected abstract DbCommand GetInsertCommand(X509CertificateRecord record);

	protected abstract DbCommand GetInsertCommand(X509CrlRecord record);

	protected abstract DbCommand GetUpdateCommand(X509CertificateRecord record, X509CertificateRecordFields fields);

	protected abstract DbCommand GetUpdateCommand(X509CrlRecord record);

	public X509CertificateRecord Find(X509Certificate certificate, X509CertificateRecordFields fields)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		using (DbCommand dbCommand = GetSelectCommand(certificate, fields))
		{
			using DbDataReader dbDataReader = dbCommand.ExecuteReader();
			if (dbDataReader.Read())
			{
				X509CertificateParser parser = new X509CertificateParser();
				byte[] buffer = new byte[4096];
				return LoadCertificateRecord(dbDataReader, parser, ref buffer);
			}
		}
		return null;
	}

	public IEnumerable<X509Certificate> FindCertificates(IX509Selector selector)
	{
		using DbCommand command = GetSelectCommand(selector, trustedAnchorsOnly: false, requirePrivateKey: false, X509CertificateRecordFields.Certificate);
		using DbDataReader reader = command.ExecuteReader();
		X509CertificateParser parser = new X509CertificateParser();
		byte[] buffer = new byte[4096];
		while (reader.Read())
		{
			X509CertificateRecord x509CertificateRecord = LoadCertificateRecord(reader, parser, ref buffer);
			if (selector == null || selector.Match(x509CertificateRecord.Certificate))
			{
				yield return x509CertificateRecord.Certificate;
			}
		}
	}

	public IEnumerable<AsymmetricKeyParameter> FindPrivateKeys(IX509Selector selector)
	{
		using DbCommand command = GetSelectCommand(selector, trustedAnchorsOnly: false, requirePrivateKey: true, X509CertificateRecordFields.Certificate | X509CertificateRecordFields.PrivateKey);
		using DbDataReader reader = command.ExecuteReader();
		X509CertificateParser parser = new X509CertificateParser();
		byte[] buffer = new byte[4096];
		while (reader.Read())
		{
			X509CertificateRecord x509CertificateRecord = LoadCertificateRecord(reader, parser, ref buffer);
			if (selector == null || selector.Match(x509CertificateRecord.Certificate))
			{
				yield return x509CertificateRecord.PrivateKey;
			}
		}
	}

	public IEnumerable<X509CertificateRecord> Find(MailboxAddress mailbox, DateTime now, bool requirePrivateKey, X509CertificateRecordFields fields)
	{
		if (mailbox == null)
		{
			throw new ArgumentNullException("mailbox");
		}
		using DbCommand command = GetSelectCommand(mailbox, now, requirePrivateKey, fields);
		using DbDataReader reader = command.ExecuteReader();
		X509CertificateParser parser = new X509CertificateParser();
		byte[] buffer = new byte[4096];
		while (reader.Read())
		{
			yield return LoadCertificateRecord(reader, parser, ref buffer);
		}
	}

	public IEnumerable<X509CertificateRecord> Find(IX509Selector selector, bool trustedAnchorsOnly, X509CertificateRecordFields fields)
	{
		using DbCommand command = GetSelectCommand(selector, trustedAnchorsOnly, requirePrivateKey: false, fields | X509CertificateRecordFields.Certificate);
		using DbDataReader reader = command.ExecuteReader();
		X509CertificateParser parser = new X509CertificateParser();
		byte[] buffer = new byte[4096];
		while (reader.Read())
		{
			X509CertificateRecord x509CertificateRecord = LoadCertificateRecord(reader, parser, ref buffer);
			if (selector == null || selector.Match(x509CertificateRecord.Certificate))
			{
				yield return x509CertificateRecord;
			}
		}
	}

	public void Add(X509CertificateRecord record)
	{
		if (record == null)
		{
			throw new ArgumentNullException("record");
		}
		using DbCommand dbCommand = GetInsertCommand(record);
		dbCommand.ExecuteNonQuery();
	}

	public void Remove(X509CertificateRecord record)
	{
		if (record == null)
		{
			throw new ArgumentNullException("record");
		}
		using DbCommand dbCommand = GetDeleteCommand(record);
		dbCommand.ExecuteNonQuery();
	}

	public void Update(X509CertificateRecord record, X509CertificateRecordFields fields)
	{
		if (record == null)
		{
			throw new ArgumentNullException("record");
		}
		using DbCommand dbCommand = GetUpdateCommand(record, fields);
		dbCommand.ExecuteNonQuery();
	}

	public IEnumerable<X509CrlRecord> Find(X509Name issuer, X509CrlRecordFields fields)
	{
		if (issuer == null)
		{
			throw new ArgumentNullException("issuer");
		}
		using DbCommand command = GetSelectCommand(issuer, fields);
		using DbDataReader reader = command.ExecuteReader();
		X509CrlParser parser = new X509CrlParser();
		byte[] buffer = new byte[4096];
		while (reader.Read())
		{
			yield return LoadCrlRecord(reader, parser, ref buffer);
		}
	}

	public X509CrlRecord Find(X509Crl crl, X509CrlRecordFields fields)
	{
		if (crl == null)
		{
			throw new ArgumentNullException("crl");
		}
		using (DbCommand dbCommand = GetSelectCommand(crl, fields))
		{
			using DbDataReader dbDataReader = dbCommand.ExecuteReader();
			if (dbDataReader.Read())
			{
				X509CrlParser parser = new X509CrlParser();
				byte[] buffer = new byte[4096];
				return LoadCrlRecord(dbDataReader, parser, ref buffer);
			}
		}
		return null;
	}

	public void Add(X509CrlRecord record)
	{
		if (record == null)
		{
			throw new ArgumentNullException("record");
		}
		using DbCommand dbCommand = GetInsertCommand(record);
		dbCommand.ExecuteNonQuery();
	}

	public void Remove(X509CrlRecord record)
	{
		if (record == null)
		{
			throw new ArgumentNullException("record");
		}
		using DbCommand dbCommand = GetDeleteCommand(record);
		dbCommand.ExecuteNonQuery();
	}

	public void Update(X509CrlRecord record)
	{
		if (record == null)
		{
			throw new ArgumentNullException("record");
		}
		using DbCommand dbCommand = GetUpdateCommand(record);
		dbCommand.ExecuteNonQuery();
	}

	public IX509Store GetCrlStore()
	{
		List<X509Crl> list = new List<X509Crl>();
		using (DbCommand dbCommand = GetSelectAllCrlsCommand())
		{
			using DbDataReader dbDataReader = dbCommand.ExecuteReader();
			X509CrlParser parser = new X509CrlParser();
			byte[] buffer = new byte[4096];
			while (dbDataReader.Read())
			{
				X509CrlRecord x509CrlRecord = LoadCrlRecord(dbDataReader, parser, ref buffer);
				list.Add(x509CrlRecord.Crl);
			}
		}
		return X509StoreFactory.Create("Crl/Collection", new X509CollectionStoreParameters(list));
	}

	ICollection IX509Store.GetMatches(IX509Selector selector)
	{
		return new List<X509Certificate>(FindCertificates(selector));
	}

	protected virtual void Dispose(bool disposing)
	{
		if (passwd != null)
		{
			for (int i = 0; i < passwd.Length; i++)
			{
				passwd[i] = '\0';
			}
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
