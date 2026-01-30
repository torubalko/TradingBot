using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Cms;

public class CmsAuthenticatedDataStreamGenerator : CmsAuthenticatedGenerator
{
	private class CmsAuthenticatedDataOutputStream : BaseOutputStream
	{
		private readonly Stream macStream;

		private readonly IMac mac;

		private readonly BerSequenceGenerator cGen;

		private readonly BerSequenceGenerator authGen;

		private readonly BerSequenceGenerator eiGen;

		public CmsAuthenticatedDataOutputStream(Stream macStream, IMac mac, BerSequenceGenerator cGen, BerSequenceGenerator authGen, BerSequenceGenerator eiGen)
		{
			this.macStream = macStream;
			this.mac = mac;
			this.cGen = cGen;
			this.authGen = authGen;
			this.eiGen = eiGen;
		}

		public override void WriteByte(byte b)
		{
			macStream.WriteByte(b);
		}

		public override void Write(byte[] bytes, int off, int len)
		{
			macStream.Write(bytes, off, len);
		}

		public override void Close()
		{
			Platform.Dispose(macStream);
			eiGen.Close();
			byte[] macOctets = MacUtilities.DoFinal(mac);
			authGen.AddObject(new DerOctetString(macOctets));
			authGen.Close();
			cGen.Close();
			base.Close();
		}
	}

	private int _bufferSize;

	private bool _berEncodeRecipientSet;

	public CmsAuthenticatedDataStreamGenerator()
	{
	}

	public CmsAuthenticatedDataStreamGenerator(SecureRandom rand)
		: base(rand)
	{
	}

	public void SetBufferSize(int bufferSize)
	{
		_bufferSize = bufferSize;
	}

	public void SetBerEncodeRecipients(bool berEncodeRecipientSet)
	{
		_berEncodeRecipientSet = berEncodeRecipientSet;
	}

	private Stream Open(Stream outStr, string macOid, CipherKeyGenerator keyGen)
	{
		byte[] encKeyBytes = keyGen.GenerateKey();
		KeyParameter encKey = ParameterUtilities.CreateKeyParameter(macOid, encKeyBytes);
		Asn1Encodable asn1Params = GenerateAsn1Parameters(macOid, encKeyBytes);
		ICipherParameters cipherParameters;
		AlgorithmIdentifier macAlgId = GetAlgorithmIdentifier(macOid, encKey, asn1Params, out cipherParameters);
		Asn1EncodableVector recipientInfos = new Asn1EncodableVector();
		foreach (RecipientInfoGenerator rig in recipientInfoGenerators)
		{
			try
			{
				recipientInfos.Add(rig.Generate(encKey, rand));
			}
			catch (InvalidKeyException e)
			{
				throw new CmsException("key inappropriate for algorithm.", e);
			}
			catch (GeneralSecurityException e2)
			{
				throw new CmsException("error making encrypted content.", e2);
			}
		}
		return Open(outStr, macAlgId, encKey, recipientInfos);
	}

	protected Stream Open(Stream outStr, AlgorithmIdentifier macAlgId, ICipherParameters cipherParameters, Asn1EncodableVector recipientInfos)
	{
		try
		{
			BerSequenceGenerator cGen = new BerSequenceGenerator(outStr);
			cGen.AddObject(CmsObjectIdentifiers.AuthenticatedData);
			BerSequenceGenerator authGen = new BerSequenceGenerator(cGen.GetRawOutputStream(), 0, isExplicit: true);
			authGen.AddObject(new DerInteger(AuthenticatedData.CalculateVersion(null)));
			Stream authRaw = authGen.GetRawOutputStream();
			Asn1Generator recipGen = (_berEncodeRecipientSet ? ((Asn1Generator)new BerSetGenerator(authRaw)) : ((Asn1Generator)new DerSetGenerator(authRaw)));
			foreach (Asn1Encodable ae in recipientInfos)
			{
				recipGen.AddObject(ae);
			}
			recipGen.Close();
			authGen.AddObject(macAlgId);
			BerSequenceGenerator eiGen = new BerSequenceGenerator(authRaw);
			eiGen.AddObject(CmsObjectIdentifiers.Data);
			Stream output = CmsUtilities.CreateBerOctetOutputStream(eiGen.GetRawOutputStream(), 0, isExplicit: true, _bufferSize);
			IMac mac = MacUtilities.GetMac(macAlgId.Algorithm);
			mac.Init(cipherParameters);
			return new CmsAuthenticatedDataOutputStream(new TeeOutputStream(output, new MacSink(mac)), mac, cGen, authGen, eiGen);
		}
		catch (SecurityUtilityException e)
		{
			throw new CmsException("couldn't create cipher.", e);
		}
		catch (InvalidKeyException e2)
		{
			throw new CmsException("key invalid in message.", e2);
		}
		catch (IOException e3)
		{
			throw new CmsException("exception decoding algorithm parameters.", e3);
		}
	}

	public Stream Open(Stream outStr, string encryptionOid)
	{
		CipherKeyGenerator keyGen = GeneratorUtilities.GetKeyGenerator(encryptionOid);
		keyGen.Init(new KeyGenerationParameters(rand, keyGen.DefaultStrength));
		return Open(outStr, encryptionOid, keyGen);
	}

	public Stream Open(Stream outStr, string encryptionOid, int keySize)
	{
		CipherKeyGenerator keyGen = GeneratorUtilities.GetKeyGenerator(encryptionOid);
		keyGen.Init(new KeyGenerationParameters(rand, keySize));
		return Open(outStr, encryptionOid, keyGen);
	}
}
