using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;
using MimeKit.IO.Filters;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace MimeKit.Cryptography;

public class MultipartSigned : Multipart
{
	public MultipartSigned(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public MultipartSigned()
		: base("signed")
	{
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitMultipartSigned(this);
	}

	private static MimeEntity Prepare(MimeEntity entity, Stream memory)
	{
		entity.Prepare(EncodingConstraint.SevenBit);
		using (FilteredStream filteredStream = new FilteredStream(memory))
		{
			filteredStream.Add(new ArmoredFromFilter());
			filteredStream.Add(new TrailingWhitespaceFilter());
			filteredStream.Add(new Unix2DosFilter());
			entity.WriteTo(filteredStream);
			filteredStream.Flush();
		}
		memory.Position = 0L;
		MimeParser mimeParser = new MimeParser(memory, MimeFormat.Entity);
		return mimeParser.ParseEntity();
	}

	private static MultipartSigned Create(CryptographyContext ctx, DigestAlgorithm digestAlgo, MimeEntity entity, MimeEntity signature)
	{
		string digestAlgorithmName = ctx.GetDigestAlgorithmName(digestAlgo);
		MultipartSigned multipartSigned = new MultipartSigned();
		multipartSigned.ContentType.Parameters["protocol"] = ctx.SignatureProtocol;
		multipartSigned.ContentType.Parameters["micalg"] = digestAlgorithmName;
		multipartSigned.Add(entity);
		multipartSigned.Add(signature);
		return multipartSigned;
	}

	public static MultipartSigned Create(CryptographyContext ctx, MailboxAddress signer, DigestAlgorithm digestAlgo, MimeEntity entity)
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
		MimeEntity entity2 = Prepare(entity, memoryBlockStream);
		memoryBlockStream.Position = 0L;
		MimePart signature = ctx.Sign(signer, digestAlgo, memoryBlockStream);
		return Create(ctx, digestAlgo, entity2, signature);
	}

	public static MultipartSigned Create(OpenPgpContext ctx, PgpSecretKey signer, DigestAlgorithm digestAlgo, MimeEntity entity)
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
		MimeEntity entity2 = Prepare(entity, memoryBlockStream);
		memoryBlockStream.Position = 0L;
		ApplicationPgpSignature signature = ctx.Sign(signer, digestAlgo, memoryBlockStream);
		return Create(ctx, digestAlgo, entity2, signature);
	}

	public static MultipartSigned Create(PgpSecretKey signer, DigestAlgorithm digestAlgo, MimeEntity entity)
	{
		using OpenPgpContext ctx = (OpenPgpContext)CryptographyContext.Create("application/pgp-signature");
		return Create(ctx, signer, digestAlgo, entity);
	}

	public static MultipartSigned Create(SecureMimeContext ctx, CmsSigner signer, MimeEntity entity)
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
		MimeEntity entity2 = Prepare(entity, memoryBlockStream);
		memoryBlockStream.Position = 0L;
		ApplicationPkcs7Signature signature = ctx.Sign(signer, memoryBlockStream);
		return Create(ctx, signer.DigestAlgorithm, entity2, signature);
	}

	public static MultipartSigned Create(CmsSigner signer, MimeEntity entity)
	{
		using SecureMimeContext ctx = (SecureMimeContext)CryptographyContext.Create("application/pkcs7-signature");
		return Create(ctx, signer, entity);
	}

	public override void Prepare(EncodingConstraint constraint, int maxLineLength = 78)
	{
		if (maxLineLength < 60 || maxLineLength > 998)
		{
			throw new ArgumentOutOfRangeException("maxLineLength");
		}
	}

	public DigitalSignatureCollection Verify(CryptographyContext ctx, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		string text = base.ContentType.Parameters["protocol"]?.Trim();
		if (string.IsNullOrEmpty(text))
		{
			throw new FormatException("The multipart/signed part did not specify a protocol.");
		}
		if (!ctx.Supports(text))
		{
			throw new NotSupportedException("The specified cryptography context does not support the signature protocol.");
		}
		if (base.Count < 2)
		{
			throw new FormatException("The multipart/signed part did not contain the expected children.");
		}
		if (!(base[1] is MimePart { Content: not null, ContentType: var contentType } mimePart))
		{
			throw new FormatException("The signature part could not be found.");
		}
		string text2 = $"{contentType.MediaType}/{contentType.MediaSubtype}";
		if (!ctx.Supports(text2))
		{
			throw new NotSupportedException($"The specified cryptography context does not support '{text2}'.");
		}
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		mimePart.Content.DecodeTo(memoryBlockStream, cancellationToken);
		memoryBlockStream.Position = 0L;
		using MemoryBlockStream memoryBlockStream2 = new MemoryBlockStream();
		FormatOptions formatOptions = FormatOptions.CloneDefault();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		formatOptions.VerifyingSignature = true;
		base[0].WriteTo(formatOptions, memoryBlockStream2);
		memoryBlockStream2.Position = 0L;
		return ctx.Verify(memoryBlockStream2, memoryBlockStream, cancellationToken);
	}

	public async Task<DigitalSignatureCollection> VerifyAsync(CryptographyContext ctx, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (ctx == null)
		{
			throw new ArgumentNullException("ctx");
		}
		string text = base.ContentType.Parameters["protocol"]?.Trim();
		if (string.IsNullOrEmpty(text))
		{
			throw new FormatException("The multipart/signed part did not specify a protocol.");
		}
		if (!ctx.Supports(text))
		{
			throw new NotSupportedException("The specified cryptography context does not support the signature protocol.");
		}
		if (base.Count < 2)
		{
			throw new FormatException("The multipart/signed part did not contain the expected children.");
		}
		if (!(base[1] is MimePart { Content: not null, ContentType: var contentType } mimePart))
		{
			throw new FormatException("The signature part could not be found.");
		}
		string text2 = $"{contentType.MediaType}/{contentType.MediaSubtype}";
		if (!ctx.Supports(text2))
		{
			throw new NotSupportedException($"The specified cryptography context does not support '{text2}'.");
		}
		using MemoryBlockStream signatureData = new MemoryBlockStream();
		await mimePart.Content.DecodeToAsync(signatureData, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		signatureData.Position = 0L;
		using MemoryBlockStream cleartext = new MemoryBlockStream();
		FormatOptions formatOptions = FormatOptions.CloneDefault();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		formatOptions.VerifyingSignature = true;
		await base[0].WriteToAsync(formatOptions, cleartext, cancellationToken);
		cleartext.Position = 0L;
		return await ctx.VerifyAsync(cleartext, signatureData, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public DigitalSignatureCollection Verify(CancellationToken cancellationToken = default(CancellationToken))
	{
		string text = base.ContentType.Parameters["protocol"]?.Trim();
		if (string.IsNullOrEmpty(text))
		{
			throw new FormatException("The multipart/signed part did not specify a protocol.");
		}
		using CryptographyContext ctx = CryptographyContext.Create(text);
		return Verify(ctx, cancellationToken);
	}

	public async Task<DigitalSignatureCollection> VerifyAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		string text = base.ContentType.Parameters["protocol"]?.Trim();
		if (string.IsNullOrEmpty(text))
		{
			throw new FormatException("The multipart/signed part did not specify a protocol.");
		}
		using CryptographyContext ctx = CryptographyContext.Create(text);
		return await VerifyAsync(ctx, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}
}
