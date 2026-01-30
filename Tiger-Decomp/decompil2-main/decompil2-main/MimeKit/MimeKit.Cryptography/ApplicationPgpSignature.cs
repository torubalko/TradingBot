using System;
using System.IO;

namespace MimeKit.Cryptography;

public class ApplicationPgpSignature : MimePart
{
	public ApplicationPgpSignature(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public ApplicationPgpSignature(Stream stream)
		: base("application", "pgp-signature")
	{
		base.ContentDisposition = new ContentDisposition("attachment");
		base.ContentTransferEncoding = ContentEncoding.SevenBit;
		base.Content = new MimeContent(stream);
		base.FileName = "signature.asc";
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitApplicationPgpSignature(this);
	}
}
