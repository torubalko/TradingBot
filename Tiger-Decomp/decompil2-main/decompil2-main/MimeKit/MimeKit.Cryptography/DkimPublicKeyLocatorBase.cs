using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;

namespace MimeKit.Cryptography;

public abstract class DkimPublicKeyLocatorBase : IDkimPublicKeyLocator
{
	protected AsymmetricKeyParameter GetPublicKey(string txt)
	{
		string text = "rsa";
		string text2 = null;
		int i = 0;
		if (txt == null)
		{
			throw new ArgumentNullException("txt");
		}
		while (i < txt.Length)
		{
			for (; i < txt.Length && char.IsWhiteSpace(txt[i]); i++)
			{
			}
			if (i == txt.Length)
			{
				break;
			}
			int num = i;
			for (; i < txt.Length && txt[i] != '='; i++)
			{
			}
			if (i == txt.Length)
			{
				break;
			}
			string text3 = txt.Substring(num, i - num);
			i++;
			num = i;
			for (; i < txt.Length && txt[i] != ';'; i++)
			{
			}
			string text4 = txt.Substring(num, i - num);
			if (!(text3 == "k"))
			{
				if (text3 == "p")
				{
					text2 = text4.Replace(" ", "");
				}
			}
			else
			{
				if (!(text4 == "rsa") && !(text4 == "ed25519"))
				{
					throw new ParseException("Unknown public key algorithm: " + text4, num, i);
				}
				text = text4;
			}
			i++;
		}
		if (text2 != null)
		{
			if (text == "ed25519")
			{
				byte[] buf = Convert.FromBase64String(text2);
				return new Ed25519PublicKeyParameters(buf, 0);
			}
			string s = "-----BEGIN PUBLIC KEY-----\r\n" + text2 + "\r\n-----END PUBLIC KEY-----\r\n";
			byte[] bytes = Encoding.ASCII.GetBytes(s);
			using MemoryStream stream = new MemoryStream(bytes, writable: false);
			using StreamReader reader = new StreamReader(stream);
			PemReader pemReader = new PemReader(reader);
			if (pemReader.ReadObject() is AsymmetricKeyParameter result)
			{
				return result;
			}
		}
		throw new ParseException("Public key parameters not found in DNS TXT record.", 0, txt.Length);
	}

	public abstract AsymmetricKeyParameter LocatePublicKey(string methods, string domain, string selector, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<AsymmetricKeyParameter> LocatePublicKeyAsync(string methods, string domain, string selector, CancellationToken cancellationToken = default(CancellationToken));
}
