using System;
using System.IO;

namespace MimeKit.Cryptography;

public class ApplicationPkcs7Signature : MimePart
{
	public ApplicationPkcs7Signature(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public ApplicationPkcs7Signature(Stream stream)
		: base("application", "pkcs7-signature")
	{
		base.ContentDisposition = new ContentDisposition("attachment");
		base.ContentTransferEncoding = ContentEncoding.Base64;
		base.Content = new MimeContent(stream);
		base.FileName = "smime.p7s";
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitApplicationPkcs7Signature(this);
	}
}
