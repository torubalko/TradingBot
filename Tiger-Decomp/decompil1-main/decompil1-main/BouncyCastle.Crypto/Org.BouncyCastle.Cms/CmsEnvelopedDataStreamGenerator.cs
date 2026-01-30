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

public class CmsEnvelopedDataStreamGenerator : CmsEnvelopedGenerator
{
	private class CmsEnvelopedDataOutputStream : BaseOutputStream
	{
		private readonly CmsEnvelopedGenerator _outer;

		private readonly CipherStream _out;

		private readonly BerSequenceGenerator _cGen;

		private readonly BerSequenceGenerator _envGen;

		private readonly BerSequenceGenerator _eiGen;

		public CmsEnvelopedDataOutputStream(CmsEnvelopedGenerator outer, CipherStream outStream, BerSequenceGenerator cGen, BerSequenceGenerator envGen, BerSequenceGenerator eiGen)
		{
			_outer = outer;
			_out = outStream;
			_cGen = cGen;
			_envGen = envGen;
			_eiGen = eiGen;
		}

		public override void WriteByte(byte b)
		{
			_out.WriteByte(b);
		}

		public override void Write(byte[] bytes, int off, int len)
		{
			_out.Write(bytes, off, len);
		}

		public override void Close()
		{
			Platform.Dispose(_out);
			_eiGen.Close();
			if (_outer.unprotectedAttributeGenerator != null)
			{
				Asn1Set unprotectedAttrs = new BerSet(_outer.unprotectedAttributeGenerator.GetAttributes(Platform.CreateHashtable()).ToAsn1EncodableVector());
				_envGen.AddObject(new DerTaggedObject(explicitly: false, 1, unprotectedAttrs));
			}
			_envGen.Close();
			_cGen.Close();
			base.Close();
		}
	}

	private object _originatorInfo;

	private object _unprotectedAttributes;

	private int _bufferSize;

	private bool _berEncodeRecipientSet;

	private DerInteger Version => new DerInteger((_originatorInfo != null || _unprotectedAttributes != null) ? 2 : 0);

	public CmsEnvelopedDataStreamGenerator()
	{
	}

	public CmsEnvelopedDataStreamGenerator(SecureRandom rand)
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

	private Stream Open(Stream outStream, string encryptionOid, CipherKeyGenerator keyGen)
	{
		byte[] encKeyBytes = keyGen.GenerateKey();
		KeyParameter encKey = ParameterUtilities.CreateKeyParameter(encryptionOid, encKeyBytes);
		Asn1Encodable asn1Params = GenerateAsn1Parameters(encryptionOid, encKeyBytes);
		ICipherParameters cipherParameters;
		AlgorithmIdentifier encAlgID = GetAlgorithmIdentifier(encryptionOid, encKey, asn1Params, out cipherParameters);
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
		return Open(outStream, encAlgID, cipherParameters, recipientInfos);
	}

	private Stream Open(Stream outStream, AlgorithmIdentifier encAlgID, ICipherParameters cipherParameters, Asn1EncodableVector recipientInfos)
	{
		try
		{
			BerSequenceGenerator cGen = new BerSequenceGenerator(outStream);
			cGen.AddObject(CmsObjectIdentifiers.EnvelopedData);
			BerSequenceGenerator envGen = new BerSequenceGenerator(cGen.GetRawOutputStream(), 0, isExplicit: true);
			envGen.AddObject(Version);
			Stream envRaw = envGen.GetRawOutputStream();
			Asn1Generator recipGen = (_berEncodeRecipientSet ? ((Asn1Generator)new BerSetGenerator(envRaw)) : ((Asn1Generator)new DerSetGenerator(envRaw)));
			foreach (Asn1Encodable ae in recipientInfos)
			{
				recipGen.AddObject(ae);
			}
			recipGen.Close();
			BerSequenceGenerator eiGen = new BerSequenceGenerator(envRaw);
			eiGen.AddObject(CmsObjectIdentifiers.Data);
			eiGen.AddObject(encAlgID);
			Stream stream = CmsUtilities.CreateBerOctetOutputStream(eiGen.GetRawOutputStream(), 0, isExplicit: false, _bufferSize);
			IBufferedCipher cipher = CipherUtilities.GetCipher(encAlgID.Algorithm);
			cipher.Init(forEncryption: true, new ParametersWithRandom(cipherParameters, rand));
			CipherStream cOut = new CipherStream(stream, null, cipher);
			return new CmsEnvelopedDataOutputStream(this, cOut, cGen, envGen, eiGen);
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

	public Stream Open(Stream outStream, string encryptionOid)
	{
		CipherKeyGenerator keyGen = GeneratorUtilities.GetKeyGenerator(encryptionOid);
		keyGen.Init(new KeyGenerationParameters(rand, keyGen.DefaultStrength));
		return Open(outStream, encryptionOid, keyGen);
	}

	public Stream Open(Stream outStream, string encryptionOid, int keySize)
	{
		CipherKeyGenerator keyGen = GeneratorUtilities.GetKeyGenerator(encryptionOid);
		keyGen.Init(new KeyGenerationParameters(rand, keySize));
		return Open(outStream, encryptionOid, keyGen);
	}
}
