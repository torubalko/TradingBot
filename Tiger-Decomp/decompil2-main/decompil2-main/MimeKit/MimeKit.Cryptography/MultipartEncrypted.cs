using System;
using System.Collections.Generic;
using System.Threading;
using MimeKit.IO;
using MimeKit.IO.Filters;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace MimeKit.Cryptography;

public class MultipartEncrypted : Multipart
{
	public MultipartEncrypted(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public MultipartEncrypted()
		: base("encrypted")
	{
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitMultipartEncrypted(this);
	}

	public static MultipartEncrypted SignAndEncrypt(OpenPgpContext ctx, MailboxAddress signer, DigestAlgorithm digestAlgo, EncryptionAlgorithm cipherAlgo, IEnumerable<MailboxAddress> recipients, MimeEntity entity)
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
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		FormatOptions formatOptions = FormatOptions.CloneDefault();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		entity.WriteTo(formatOptions, memoryBlockStream);
		memoryBlockStream.Position = 0L;
		MultipartEncrypted multipartEncrypted = new MultipartEncrypted();
		multipartEncrypted.ContentType.Parameters["protocol"] = ctx.EncryptionProtocol;
		multipartEncrypted.Add(new ApplicationPgpEncrypted());
		multipartEncrypted.Add(ctx.SignAndEncrypt(signer, digestAlgo, cipherAlgo, recipients, memoryBlockStream));
		return multipartEncrypted;
	}

	public static MultipartEncrypted SignAndEncrypt(OpenPgpContext ctx, MailboxAddress signer, DigestAlgorithm digestAlgo, IEnumerable<MailboxAddress> recipients, MimeEntity entity)
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
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		FormatOptions formatOptions = FormatOptions.CloneDefault();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		entity.WriteTo(formatOptions, memoryBlockStream);
		memoryBlockStream.Position = 0L;
		MultipartEncrypted multipartEncrypted = new MultipartEncrypted();
		multipartEncrypted.ContentType.Parameters["protocol"] = ctx.EncryptionProtocol;
		multipartEncrypted.Add(new ApplicationPgpEncrypted());
		multipartEncrypted.Add(ctx.SignAndEncrypt(signer, digestAlgo, recipients, memoryBlockStream));
		return multipartEncrypted;
	}

	public static MultipartEncrypted SignAndEncrypt(MailboxAddress signer, DigestAlgorithm digestAlgo, EncryptionAlgorithm cipherAlgo, IEnumerable<MailboxAddress> recipients, MimeEntity entity)
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
		using OpenPgpContext ctx = (OpenPgpContext)CryptographyContext.Create("application/pgp-encrypted");
		return SignAndEncrypt(ctx, signer, digestAlgo, cipherAlgo, recipients, entity);
	}

	public static MultipartEncrypted SignAndEncrypt(MailboxAddress signer, DigestAlgorithm digestAlgo, IEnumerable<MailboxAddress> recipients, MimeEntity entity)
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
		using OpenPgpContext ctx = (OpenPgpContext)CryptographyContext.Create("application/pgp-encrypted");
		return SignAndEncrypt(ctx, signer, digestAlgo, recipients, entity);
	}

	public static MultipartEncrypted SignAndEncrypt(OpenPgpContext ctx, PgpSecretKey signer, DigestAlgorithm digestAlgo, EncryptionAlgorithm cipherAlgo, IEnumerable<PgpPublicKey> recipients, MimeEntity entity)
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
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		FormatOptions formatOptions = FormatOptions.CloneDefault();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		entity.WriteTo(formatOptions, memoryBlockStream);
		memoryBlockStream.Position = 0L;
		MultipartEncrypted multipartEncrypted = new MultipartEncrypted();
		multipartEncrypted.ContentType.Parameters["protocol"] = ctx.EncryptionProtocol;
		multipartEncrypted.Add(new ApplicationPgpEncrypted());
		multipartEncrypted.Add(ctx.SignAndEncrypt(signer, digestAlgo, cipherAlgo, recipients, memoryBlockStream));
		return multipartEncrypted;
	}

	public static MultipartEncrypted SignAndEncrypt(OpenPgpContext ctx, PgpSecretKey signer, DigestAlgorithm digestAlgo, IEnumerable<PgpPublicKey> recipients, MimeEntity entity)
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
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		FormatOptions formatOptions = FormatOptions.CloneDefault();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		entity.WriteTo(formatOptions, memoryBlockStream);
		memoryBlockStream.Position = 0L;
		MultipartEncrypted multipartEncrypted = new MultipartEncrypted();
		multipartEncrypted.ContentType.Parameters["protocol"] = ctx.EncryptionProtocol;
		multipartEncrypted.Add(new ApplicationPgpEncrypted());
		multipartEncrypted.Add(ctx.SignAndEncrypt(signer, digestAlgo, recipients, memoryBlockStream));
		return multipartEncrypted;
	}

	public static MultipartEncrypted SignAndEncrypt(PgpSecretKey signer, DigestAlgorithm digestAlgo, EncryptionAlgorithm cipherAlgo, IEnumerable<PgpPublicKey> recipients, MimeEntity entity)
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
		using OpenPgpContext ctx = (OpenPgpContext)CryptographyContext.Create("application/pgp-encrypted");
		return SignAndEncrypt(ctx, signer, digestAlgo, cipherAlgo, recipients, entity);
	}

	public static MultipartEncrypted SignAndEncrypt(PgpSecretKey signer, DigestAlgorithm digestAlgo, IEnumerable<PgpPublicKey> recipients, MimeEntity entity)
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
		using OpenPgpContext ctx = (OpenPgpContext)CryptographyContext.Create("application/pgp-encrypted");
		return SignAndEncrypt(ctx, signer, digestAlgo, recipients, entity);
	}

	public static MultipartEncrypted Encrypt(OpenPgpContext ctx, EncryptionAlgorithm algorithm, IEnumerable<MailboxAddress> recipients, MimeEntity entity)
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
		using (FilteredStream filteredStream = new FilteredStream(memoryBlockStream))
		{
			filteredStream.Add(new Unix2DosFilter());
			entity.WriteTo(filteredStream);
			filteredStream.Flush();
		}
		memoryBlockStream.Position = 0L;
		MultipartEncrypted multipartEncrypted = new MultipartEncrypted();
		multipartEncrypted.ContentType.Parameters["protocol"] = ctx.EncryptionProtocol;
		multipartEncrypted.Add(new ApplicationPgpEncrypted());
		multipartEncrypted.Add(ctx.Encrypt(algorithm, recipients, memoryBlockStream));
		return multipartEncrypted;
	}

	public static MultipartEncrypted Encrypt(OpenPgpContext ctx, IEnumerable<MailboxAddress> recipients, MimeEntity entity)
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
		using (FilteredStream filteredStream = new FilteredStream(memoryBlockStream))
		{
			filteredStream.Add(new Unix2DosFilter());
			entity.WriteTo(filteredStream);
			filteredStream.Flush();
		}
		memoryBlockStream.Position = 0L;
		MultipartEncrypted multipartEncrypted = new MultipartEncrypted();
		multipartEncrypted.ContentType.Parameters["protocol"] = ctx.EncryptionProtocol;
		multipartEncrypted.Add(new ApplicationPgpEncrypted());
		multipartEncrypted.Add(ctx.Encrypt(recipients, memoryBlockStream));
		return multipartEncrypted;
	}

	public static MultipartEncrypted Encrypt(EncryptionAlgorithm algorithm, IEnumerable<MailboxAddress> recipients, MimeEntity entity)
	{
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using OpenPgpContext ctx = (OpenPgpContext)CryptographyContext.Create("application/pgp-encrypted");
		return Encrypt(ctx, algorithm, recipients, entity);
	}

	public static MultipartEncrypted Encrypt(IEnumerable<MailboxAddress> recipients, MimeEntity entity)
	{
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using OpenPgpContext ctx = (OpenPgpContext)CryptographyContext.Create("application/pgp-encrypted");
		return Encrypt(ctx, recipients, entity);
	}

	public static MultipartEncrypted Encrypt(OpenPgpContext ctx, EncryptionAlgorithm algorithm, IEnumerable<PgpPublicKey> recipients, MimeEntity entity)
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
		using (FilteredStream filteredStream = new FilteredStream(memoryBlockStream))
		{
			filteredStream.Add(new Unix2DosFilter());
			entity.WriteTo(filteredStream);
			filteredStream.Flush();
		}
		memoryBlockStream.Position = 0L;
		MultipartEncrypted multipartEncrypted = new MultipartEncrypted();
		multipartEncrypted.ContentType.Parameters["protocol"] = ctx.EncryptionProtocol;
		multipartEncrypted.Add(new ApplicationPgpEncrypted());
		multipartEncrypted.Add(ctx.Encrypt(algorithm, recipients, memoryBlockStream));
		return multipartEncrypted;
	}

	public static MultipartEncrypted Encrypt(OpenPgpContext ctx, IEnumerable<PgpPublicKey> recipients, MimeEntity entity)
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
		using (FilteredStream filteredStream = new FilteredStream(memoryBlockStream))
		{
			filteredStream.Add(new Unix2DosFilter());
			entity.WriteTo(filteredStream);
			filteredStream.Flush();
		}
		memoryBlockStream.Position = 0L;
		MultipartEncrypted multipartEncrypted = new MultipartEncrypted();
		multipartEncrypted.ContentType.Parameters["protocol"] = ctx.EncryptionProtocol;
		multipartEncrypted.Add(new ApplicationPgpEncrypted());
		multipartEncrypted.Add(ctx.Encrypt(recipients, memoryBlockStream));
		return multipartEncrypted;
	}

	public static MultipartEncrypted Encrypt(EncryptionAlgorithm algorithm, IEnumerable<PgpPublicKey> recipients, MimeEntity entity)
	{
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using OpenPgpContext ctx = (OpenPgpContext)CryptographyContext.Create("application/pgp-encrypted");
		return Encrypt(ctx, algorithm, recipients, entity);
	}

	public static MultipartEncrypted Encrypt(IEnumerable<PgpPublicKey> recipients, MimeEntity entity)
	{
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		using OpenPgpContext ctx = (OpenPgpContext)CryptographyContext.Create("application/pgp-encrypted");
		return Encrypt(ctx, recipients, entity);
	}

	public MimeEntity Decrypt(OpenPgpContext ctx, out DigitalSignatureCollection signatures, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		string text = base.ContentType.Parameters["protocol"]?.Trim();
		if (string.IsNullOrEmpty(text))
		{
			throw new FormatException();
		}
		if (!ctx.Supports(text))
		{
			throw new NotSupportedException();
		}
		if (base.Count < 2)
		{
			throw new FormatException();
		}
		if (!(base[0] is MimePart { ContentType: var contentType }))
		{
			throw new FormatException();
		}
		string text2 = $"{contentType.MediaType}/{contentType.MediaSubtype}";
		if (!text2.Equals(text, StringComparison.OrdinalIgnoreCase))
		{
			throw new FormatException();
		}
		if (!(base[1] is MimePart { Content: not null } mimePart2))
		{
			throw new FormatException();
		}
		if (!mimePart2.ContentType.IsMimeType("application", "octet-stream"))
		{
			throw new FormatException();
		}
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		mimePart2.Content.DecodeTo(memoryBlockStream, cancellationToken);
		memoryBlockStream.Position = 0L;
		return ctx.Decrypt(memoryBlockStream, out signatures, cancellationToken);
	}

	public MimeEntity Decrypt(OpenPgpContext ctx, CancellationToken cancellationToken = default(CancellationToken))
	{
		DigitalSignatureCollection signatures;
		return Decrypt(ctx, out signatures, cancellationToken);
	}

	public MimeEntity Decrypt(out DigitalSignatureCollection signatures, CancellationToken cancellationToken = default(CancellationToken))
	{
		string text = base.ContentType.Parameters["protocol"]?.Trim();
		if (string.IsNullOrEmpty(text))
		{
			throw new FormatException();
		}
		if (base.Count < 2)
		{
			throw new FormatException();
		}
		if (!(base[0] is MimePart { ContentType: var contentType }))
		{
			throw new FormatException();
		}
		string text2 = $"{contentType.MediaType}/{contentType.MediaSubtype}";
		if (!text2.Equals(text, StringComparison.OrdinalIgnoreCase))
		{
			throw new FormatException();
		}
		if (!(base[1] is MimePart { Content: not null } mimePart2))
		{
			throw new FormatException();
		}
		if (!mimePart2.ContentType.IsMimeType("application", "octet-stream"))
		{
			throw new FormatException();
		}
		using CryptographyContext cryptographyContext = CryptographyContext.Create(text);
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		OpenPgpContext openPgpContext = cryptographyContext as OpenPgpContext;
		mimePart2.Content.DecodeTo(memoryBlockStream, cancellationToken);
		memoryBlockStream.Position = 0L;
		if (openPgpContext != null)
		{
			return openPgpContext.Decrypt(memoryBlockStream, out signatures, cancellationToken);
		}
		signatures = null;
		return cryptographyContext.Decrypt(memoryBlockStream, cancellationToken);
	}

	public MimeEntity Decrypt(CancellationToken cancellationToken = default(CancellationToken))
	{
		DigitalSignatureCollection signatures;
		return Decrypt(out signatures, cancellationToken);
	}
}
