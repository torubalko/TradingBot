using System;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MailKit.Security;

[Serializable]
public class SslHandshakeException : Exception
{
	private const string SslHandshakeHelpLink = "https://github.com/jstedfast/MailKit/blob/master/FAQ.md#SslHandshakeException";

	private const string DefaultMessage = "An error occurred while attempting to establish an SSL or TLS connection.";

	public X509Certificate ServerCertificate { get; private set; }

	public X509Certificate RootCertificateAuthority { get; private set; }

	protected SslHandshakeException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		string text = info.GetString("ServerCertificate");
		if (text != null)
		{
			ServerCertificate = new X509Certificate2(Convert.FromBase64String(text));
		}
		text = info.GetString("RootCertificateAuthority");
		if (text != null)
		{
			RootCertificateAuthority = new X509Certificate2(Convert.FromBase64String(text));
		}
	}

	public SslHandshakeException(string message, Exception innerException)
		: base(message, innerException)
	{
		HelpLink = "https://github.com/jstedfast/MailKit/blob/master/FAQ.md#SslHandshakeException";
	}

	public SslHandshakeException(string message)
		: base(message)
	{
		HelpLink = "https://github.com/jstedfast/MailKit/blob/master/FAQ.md#SslHandshakeException";
	}

	public SslHandshakeException()
		: base("An error occurred while attempting to establish an SSL or TLS connection.")
	{
		HelpLink = "https://github.com/jstedfast/MailKit/blob/master/FAQ.md#SslHandshakeException";
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		if (ServerCertificate != null)
		{
			info.AddValue("ServerCertificate", Convert.ToBase64String(ServerCertificate.GetRawCertData()));
		}
		else
		{
			info.AddValue("ServerCertificate", null, typeof(string));
		}
		if (RootCertificateAuthority != null)
		{
			info.AddValue("RootCertificateAuthority", Convert.ToBase64String(RootCertificateAuthority.GetRawCertData()));
		}
		else
		{
			info.AddValue("RootCertificateAuthority", null, typeof(string));
		}
	}

	internal static SslHandshakeException Create(MailService client, Exception ex, bool starttls, string protocol, string host, int port, int sslPort, params int[] standardPorts)
	{
		StringBuilder stringBuilder = new StringBuilder("An error occurred while attempting to establish an SSL or TLS connection.");
		AggregateException ex2 = ex as AggregateException;
		X509Certificate serverCertificate = null;
		X509Certificate rootCertificateAuthority = null;
		if (ex2 != null)
		{
			ex2 = ex2.Flatten();
			ex = ((ex2.InnerExceptions.Count != 1) ? ex2 : ex2.InnerExceptions[0]);
		}
		stringBuilder.AppendLine();
		stringBuilder.AppendLine();
		SslCertificateValidationInfo sslCertificateValidationInfo = client?.SslCertificateValidationInfo;
		if (sslCertificateValidationInfo != null)
		{
			client.SslCertificateValidationInfo = null;
			try
			{
				int num = sslCertificateValidationInfo.ChainElements.Count - 1;
				if (num > 0)
				{
					rootCertificateAuthority = new X509Certificate2(sslCertificateValidationInfo.ChainElements[num].Certificate.RawData);
				}
				serverCertificate = new X509Certificate2(sslCertificateValidationInfo.Certificate.RawData);
				if ((sslCertificateValidationInfo.SslPolicyErrors & SslPolicyErrors.RemoteCertificateNotAvailable) != SslPolicyErrors.None)
				{
					stringBuilder.AppendLine("The SSL certificate for the server was not available.");
				}
				else if ((sslCertificateValidationInfo.SslPolicyErrors & SslPolicyErrors.RemoteCertificateNameMismatch) != SslPolicyErrors.None)
				{
					stringBuilder.AppendLine("The host name did not match the name given in the server's SSL certificate.");
				}
				else
				{
					stringBuilder.AppendLine("The server's SSL certificate could not be validated for the following reasons:");
					bool flag = false;
					for (int i = 0; i < sslCertificateValidationInfo.ChainElements.Count; i++)
					{
						SslChainElement sslChainElement = sslCertificateValidationInfo.ChainElements[i];
						if (sslChainElement.ChainElementStatus != null && sslChainElement.ChainElementStatus.Length != 0)
						{
							if (i == 0)
							{
								stringBuilder.AppendLine("• The server certificate has the following errors:");
							}
							else if (i == num)
							{
								stringBuilder.AppendLine("• The root certificate has the following errors:");
							}
							else
							{
								stringBuilder.AppendLine("• An intermediate certificate has the following errors:");
							}
							X509ChainStatus[] chainElementStatus = sslChainElement.ChainElementStatus;
							foreach (X509ChainStatus x509ChainStatus in chainElementStatus)
							{
								stringBuilder.AppendFormat("  • {0}{1}", x509ChainStatus.StatusInformation, Environment.NewLine);
							}
							flag = true;
						}
					}
					if (!flag)
					{
						Exception ex3 = ex;
						while (ex3.InnerException != null)
						{
							ex3 = ex3.InnerException;
						}
						stringBuilder.AppendLine("• " + ex3.Message);
					}
				}
			}
			finally
			{
				sslCertificateValidationInfo.Dispose();
			}
		}
		else if (!starttls && standardPorts.Contains(port))
		{
			string text = (("AEHIOS".IndexOf(protocol[0]) != -1) ? "an" : "a");
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "When connecting to {0} {1} service, port {2} is typically reserved for plain-text connections. If{3}", text, protocol, port, Environment.NewLine);
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "you intended to connect to {0} on the SSL port, try connecting to port {1} instead. Otherwise,{2}", protocol, sslPort, Environment.NewLine);
			stringBuilder.AppendLine("if you intended to use STARTTLS, make sure to use the following code:");
			stringBuilder.AppendLine();
			stringBuilder.AppendFormat("client.Connect (\"{0}\", {1}, SecureSocketOptions.StartTls);{2}", host, port, Environment.NewLine);
		}
		else
		{
			stringBuilder.AppendLine("This usually means that the SSL certificate presented by the server is not trusted by the system for one or more of");
			stringBuilder.AppendLine("the following reasons:");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("1. The server is using a self-signed certificate which cannot be verified.");
			stringBuilder.AppendLine("2. The local system is missing a Root or Intermediate certificate needed to verify the server's certificate.");
			stringBuilder.AppendLine("3. A Certificate Authority CRL server for one or more of the certificates in the chain is temporarily unavailable.");
			stringBuilder.AppendLine("4. The certificate presented by the server is expired or invalid.");
			stringBuilder.AppendLine("5. The set of SSL/TLS protocols supported by the client and server do not match.");
			if (!starttls)
			{
				stringBuilder.AppendLine("6. You are trying to connect to a port which does not support SSL/TLS.");
			}
			stringBuilder.AppendLine();
			stringBuilder.AppendLine("See https://github.com/jstedfast/MailKit/blob/master/FAQ.md#SslHandshakeException for possible solutions.");
		}
		return new SslHandshakeException(stringBuilder.ToString(), ex)
		{
			ServerCertificate = serverCertificate,
			RootCertificateAuthority = rootCertificateAuthority
		};
	}
}
