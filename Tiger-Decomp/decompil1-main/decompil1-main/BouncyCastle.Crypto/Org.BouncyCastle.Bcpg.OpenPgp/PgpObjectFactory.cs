using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpObjectFactory
{
	private readonly BcpgInputStream bcpgIn;

	public PgpObjectFactory(Stream inputStream)
	{
		bcpgIn = BcpgInputStream.Wrap(inputStream);
	}

	public PgpObjectFactory(byte[] bytes)
		: this(new MemoryStream(bytes, writable: false))
	{
	}

	public PgpObject NextPgpObject()
	{
		switch (bcpgIn.NextPacketTag())
		{
		case (PacketTag)(-1):
			return null;
		case PacketTag.Signature:
		{
			IList l2 = Platform.CreateArrayList();
			while (bcpgIn.NextPacketTag() == PacketTag.Signature)
			{
				try
				{
					l2.Add(new PgpSignature(bcpgIn));
				}
				catch (UnsupportedPacketVersionException)
				{
				}
				catch (PgpException ex4)
				{
					throw new IOException("can't create signature object: " + ex4);
				}
			}
			PgpSignature[] sigs2 = new PgpSignature[l2.Count];
			for (int j = 0; j < l2.Count; j++)
			{
				sigs2[j] = (PgpSignature)l2[j];
			}
			return new PgpSignatureList(sigs2);
		}
		case PacketTag.SecretKey:
			try
			{
				return new PgpSecretKeyRing(bcpgIn);
			}
			catch (PgpException ex2)
			{
				throw new IOException("can't create secret key object: " + ex2);
			}
		case PacketTag.PublicKey:
			return new PgpPublicKeyRing(bcpgIn);
		case PacketTag.CompressedData:
			return new PgpCompressedData(bcpgIn);
		case PacketTag.LiteralData:
			return new PgpLiteralData(bcpgIn);
		case PacketTag.PublicKeyEncryptedSession:
		case PacketTag.SymmetricKeyEncryptedSessionKey:
			return new PgpEncryptedDataList(bcpgIn);
		case PacketTag.OnePassSignature:
		{
			IList l = Platform.CreateArrayList();
			while (bcpgIn.NextPacketTag() == PacketTag.OnePassSignature)
			{
				try
				{
					l.Add(new PgpOnePassSignature(bcpgIn));
				}
				catch (PgpException ex)
				{
					throw new IOException("can't create one pass signature object: " + ex);
				}
			}
			PgpOnePassSignature[] sigs = new PgpOnePassSignature[l.Count];
			for (int i = 0; i < l.Count; i++)
			{
				sigs[i] = (PgpOnePassSignature)l[i];
			}
			return new PgpOnePassSignatureList(sigs);
		}
		case PacketTag.Marker:
			return new PgpMarker(bcpgIn);
		case PacketTag.Experimental1:
		case PacketTag.Experimental2:
		case PacketTag.Experimental3:
		case PacketTag.Experimental4:
			return new PgpExperimental(bcpgIn);
		default:
			throw new IOException("unknown object in stream " + bcpgIn.NextPacketTag());
		}
	}

	[Obsolete("Use NextPgpObject() instead")]
	public object NextObject()
	{
		return NextPgpObject();
	}

	public IList AllPgpObjects()
	{
		IList result = Platform.CreateArrayList();
		PgpObject pgpObject;
		while ((pgpObject = NextPgpObject()) != null)
		{
			result.Add(pgpObject);
		}
		return result;
	}

	public IList FilterPgpObjects(Type type)
	{
		IList result = Platform.CreateArrayList();
		PgpObject pgpObject;
		while ((pgpObject = NextPgpObject()) != null)
		{
			if (type.IsInstanceOfType(pgpObject))
			{
				result.Add(pgpObject);
			}
		}
		return result;
	}
}
