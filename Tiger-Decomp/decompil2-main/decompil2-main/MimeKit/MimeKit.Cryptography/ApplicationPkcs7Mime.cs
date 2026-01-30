using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using MimeKit.IO;

namespace MimeKit.Cryptography;

public class ApplicationPkcs7Mime : MimePart
{
	public SecureMimeType SecureMimeType
	{
		get
		{
			string text = base.ContentType.Parameters["smime-type"];
			if (text == null)
			{
				return SecureMimeType.Unknown;
			}
			return text.ToLowerInvariant() switch
			{
				"authenveloped-data" => SecureMimeType.AuthEnvelopedData, 
				"compressed-data" => SecureMimeType.CompressedData, 
				"enveloped-data" => SecureMimeType.EnvelopedData, 
				"signed-data" => SecureMimeType.SignedData, 
				"certs-only" => SecureMimeType.CertsOnly, 
				_ => SecureMimeType.Unknown, 
			};
		}
	}

	public ApplicationPkcs7Mime(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public ApplicationPkcs7Mime(SecureMimeType type, Stream stream)
		: base("application", "pkcs7-mime")
	{
		base.ContentDisposition = new ContentDisposition("attachment");
		base.ContentTransferEncoding = ContentEncoding.Base64;
		base.Content = new MimeContent(stream);
		switch (type)
		{
		case SecureMimeType.CompressedData:
			base.ContentType.Parameters["smime-type"] = "compressed-data";
			base.ContentDisposition.FileName = "smime.p7z";
			base.ContentType.Name = "smime.p7z";
			break;
		case SecureMimeType.EnvelopedData:
			base.ContentType.Parameters["smime-type"] = "enveloped-data";
			base.ContentDisposition.FileName = "smime.p7m";
			base.ContentType.Name = "smime.p7m";
			break;
		case SecureMimeType.SignedData:
			base.ContentType.Parameters["smime-type"] = "signed-data";
			base.ContentDisposition.FileName = "smime.p7m";
			base.ContentType.Name = "smime.p7m";
			break;
		case SecureMimeType.CertsOnly:
			base.ContentType.Parameters["smime-type"] = "certs-only";
			base.ContentDisposition.FileName = "smime.p7c";
			base.ContentType.Name = "smime.p7c";
			break;
		default:
			throw new ArgumentOutOfRangeException("type");
		}
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitApplicationPkcs7Mime(this);
	}

	public MimeEntity Decompress(SecureMimeContext ctx)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (SecureMimeType != SecureMimeType.CompressedData && SecureMimeType != SecureMimeType.Unknown)
		{
			throw new InvalidOperationException();
		}
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		base.Content.DecodeTo(memoryBlockStream);
		memoryBlockStream.Position = 0L;
		return ctx.Decompress(memoryBlockStream);
	}

	public MimeEntity Decompress()
	{
		if (SecureMimeType != SecureMimeType.CompressedData && SecureMimeType != SecureMimeType.Unknown)
		{
			throw new InvalidOperationException();
		}
		using SecureMimeContext ctx = (SecureMimeContext)CryptographyContext.Create("application/pkcs7-mime");
		return Decompress(ctx);
	}

	public MimeEntity Decrypt(SecureMimeContext ctx, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (SecureMimeType != SecureMimeType.EnvelopedData && SecureMimeType != SecureMimeType.Unknown)
		{
			throw new InvalidOperationException();
		}
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		base.Content.DecodeTo(memoryBlockStream);
		memoryBlockStream.Position = 0L;
		return ctx.Decrypt(memoryBlockStream, cancellationToken);
	}

	public MimeEntity Decrypt(CancellationToken cancellationToken = default(CancellationToken))
	{
		using SecureMimeContext ctx = (SecureMimeContext)CryptographyContext.Create("application/pkcs7-mime");
		return Decrypt(ctx, cancellationToken);
	}

	public void Import(SecureMimeContext ctx)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (SecureMimeType != SecureMimeType.CertsOnly && SecureMimeType != SecureMimeType.Unknown)
		{
			throw new InvalidOperationException();
		}
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		base.Content.DecodeTo(memoryBlockStream);
		memoryBlockStream.Position = 0L;
		ctx.Import(memoryBlockStream);
	}

	public DigitalSignatureCollection Verify(SecureMimeContext ctx, out MimeEntity entity, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (SecureMimeType != SecureMimeType.SignedData && SecureMimeType != SecureMimeType.Unknown)
		{
			throw new InvalidOperationException();
		}
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		base.Content.DecodeTo(memoryBlockStream);
		memoryBlockStream.Position = 0L;
		return ctx.Verify((Stream)memoryBlockStream, out entity, cancellationToken);
	}

	public DigitalSignatureCollection Verify(out MimeEntity entity, CancellationToken cancellationToken = default(CancellationToken))
	{
		using SecureMimeContext ctx = (SecureMimeContext)CryptographyContext.Create("application/pkcs7-mime");
		return Verify(ctx, out entity, cancellationToken);
	}

	public static ApplicationPkcs7Mime Compress(SecureMimeContext ctx, MimeEntity entity)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		FormatOptions formatOptions = FormatOptions.CloneDefault();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		entity.WriteTo(formatOptions, memoryBlockStream);
		memoryBlockStream.Position = 0L;
		return ctx.Compress(memoryBlockStream);
	}

	public static ApplicationPkcs7Mime Compress(MimeEntity entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using SecureMimeContext ctx = (SecureMimeContext)CryptographyContext.Create("application/pkcs7-mime");
		return Compress(ctx, entity);
	}

	public static ApplicationPkcs7Mime Encrypt(SecureMimeContext ctx, CmsRecipientCollection recipients, MimeEntity entity)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		FormatOptions formatOptions = FormatOptions.CloneDefault();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		entity.WriteTo(formatOptions, memoryBlockStream);
		memoryBlockStream.Position = 0L;
		return ctx.Encrypt(recipients, memoryBlockStream);
	}

	public static ApplicationPkcs7Mime Encrypt(CmsRecipientCollection recipients, MimeEntity entity)
	{
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using SecureMimeContext ctx = (SecureMimeContext)CryptographyContext.Create("application/pkcs7-mime");
		return Encrypt(ctx, recipients, entity);
	}

	public static ApplicationPkcs7Mime Encrypt(SecureMimeContext ctx, IEnumerable<MailboxAddress> recipients, MimeEntity entity)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		FormatOptions formatOptions = FormatOptions.CloneDefault();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		entity.WriteTo(formatOptions, memoryBlockStream);
		memoryBlockStream.Position = 0L;
		return (ApplicationPkcs7Mime)ctx.Encrypt(recipients, memoryBlockStream);
	}

	public static ApplicationPkcs7Mime Encrypt(IEnumerable<MailboxAddress> recipients, MimeEntity entity)
	{
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using SecureMimeContext ctx = (SecureMimeContext)CryptographyContext.Create("application/pkcs7-mime");
		return Encrypt(ctx, recipients, entity);
	}

	public static ApplicationPkcs7Mime Sign(SecureMimeContext ctx, CmsSigner signer, MimeEntity entity)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		FormatOptions formatOptions = FormatOptions.CloneDefault();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		entity.WriteTo(formatOptions, memoryBlockStream);
		memoryBlockStream.Position = 0L;
		return ctx.EncapsulatedSign(signer, memoryBlockStream);
	}

	public static ApplicationPkcs7Mime Sign(CmsSigner signer, MimeEntity entity)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using SecureMimeContext ctx = (SecureMimeContext)CryptographyContext.Create("application/pkcs7-mime");
		return Sign(ctx, signer, entity);
	}

	public static ApplicationPkcs7Mime Sign(SecureMimeContext ctx, MailboxAddress signer, DigestAlgorithm digestAlgo, MimeEntity entity)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		FormatOptions formatOptions = FormatOptions.CloneDefault();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		entity.WriteTo(formatOptions, memoryBlockStream);
		memoryBlockStream.Position = 0L;
		return ctx.EncapsulatedSign(signer, digestAlgo, memoryBlockStream);
	}

	public static ApplicationPkcs7Mime Sign(MailboxAddress signer, DigestAlgorithm digestAlgo, MimeEntity entity)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using SecureMimeContext ctx = (SecureMimeContext)CryptographyContext.Create("application/pkcs7-mime");
		return Sign(ctx, signer, digestAlgo, entity);
	}

	public static ApplicationPkcs7Mime SignAndEncrypt(SecureMimeContext ctx, CmsSigner signer, CmsRecipientCollection recipients, MimeEntity entity)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		return Encrypt(ctx, recipients, MultipartSigned.Create(ctx, signer, entity));
	}

	public static ApplicationPkcs7Mime SignAndEncrypt(CmsSigner signer, CmsRecipientCollection recipients, MimeEntity entity)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using SecureMimeContext ctx = (SecureMimeContext)CryptographyContext.Create("application/pkcs7-mime");
		return SignAndEncrypt(ctx, signer, recipients, entity);
	}

	public static ApplicationPkcs7Mime SignAndEncrypt(SecureMimeContext ctx, MailboxAddress signer, DigestAlgorithm digestAlgo, IEnumerable<MailboxAddress> recipients, MimeEntity entity)
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		return Encrypt(ctx, recipients, MultipartSigned.Create(ctx, signer, digestAlgo, entity));
	}

	public static ApplicationPkcs7Mime SignAndEncrypt(MailboxAddress signer, DigestAlgorithm digestAlgo, IEnumerable<MailboxAddress> recipients, MimeEntity entity)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using SecureMimeContext ctx = (SecureMimeContext)CryptographyContext.Create("application/pkcs7-mime");
		return SignAndEncrypt(ctx, signer, digestAlgo, recipients, entity);
	}
}
