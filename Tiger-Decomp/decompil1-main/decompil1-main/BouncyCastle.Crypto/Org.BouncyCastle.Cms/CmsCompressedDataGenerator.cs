using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Zlib;

namespace Org.BouncyCastle.Cms;

public class CmsCompressedDataGenerator
{
	public const string ZLib = "1.2.840.113549.1.9.16.3.8";

	public CmsCompressedData Generate(CmsProcessable content, string compressionOid)
	{
		AlgorithmIdentifier comAlgId;
		Asn1OctetString comOcts;
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			ZOutputStream zOut = new ZOutputStream(memoryStream, -1);
			content.Write(zOut);
			Platform.Dispose(zOut);
			comAlgId = new AlgorithmIdentifier(new DerObjectIdentifier(compressionOid));
			comOcts = new BerOctetString(memoryStream.ToArray());
		}
		catch (IOException e)
		{
			throw new CmsException("exception encoding data.", e);
		}
		ContentInfo comContent = new ContentInfo(CmsObjectIdentifiers.Data, comOcts);
		return new CmsCompressedData(new ContentInfo(CmsObjectIdentifiers.CompressedData, new CompressedData(comAlgId, comContent)));
	}
}
