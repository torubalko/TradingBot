using System;
using System.IO;
using System.Text;

namespace MimeKit.Cryptography;

public class ApplicationPgpEncrypted : MimePart
{
	public ApplicationPgpEncrypted(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public ApplicationPgpEncrypted()
		: base("application", "pgp-encrypted")
	{
		base.ContentDisposition = new ContentDisposition("attachment");
		base.ContentTransferEncoding = ContentEncoding.SevenBit;
		MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes("Version: 1\n"), writable: false);
		base.Content = new MimeContent(stream);
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitApplicationPgpEncrypted(this);
	}
}
