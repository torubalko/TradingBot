using System.IO;
using System.Net.Security;

namespace MailKit.Net;

internal class SslStream : System.Net.Security.SslStream
{
	public new Stream InnerStream => base.InnerStream;

	public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback)
		: base(innerStream, leaveInnerStreamOpen, userCertificateValidationCallback)
	{
	}
}
