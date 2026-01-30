using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace MailKit.Security;

internal class DigestResponse
{
	public string UserName { get; private set; }

	public string Realm { get; private set; }

	public string Nonce { get; private set; }

	public string CNonce { get; private set; }

	public int Nc { get; private set; }

	public string Qop { get; private set; }

	public string DigestUri { get; private set; }

	public string Response { get; private set; }

	public int? MaxBuf { get; private set; }

	public string Charset { get; private set; }

	public string Algorithm { get; private set; }

	public string Cipher { get; private set; }

	public string AuthZid { get; private set; }

	public DigestResponse(DigestChallenge challenge, Encoding encoding, string protocol, string hostName, string authzid, string userName, string password, string cnonce)
	{
		UserName = userName;
		if (challenge.Realms != null && challenge.Realms.Length != 0)
		{
			Realm = challenge.Realms[0];
		}
		else
		{
			Realm = string.Empty;
		}
		Nonce = challenge.Nonce;
		CNonce = cnonce;
		Nc = 1;
		Qop = "auth";
		DigestUri = $"{protocol}/{hostName}";
		Algorithm = challenge.Algorithm;
		Charset = challenge.Charset;
		MaxBuf = challenge.MaxBuf;
		AuthZid = authzid;
		Cipher = null;
		Response = ComputeHash(encoding, password, client: true);
	}

	private static string HexEncode(byte[] digest)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < digest.Length; i++)
		{
			stringBuilder.Append(digest[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	public string ComputeHash(Encoding encoding, string password, bool client)
	{
		string s = $"{UserName}:{Realm}:{password}";
		byte[] bytes = encoding.GetBytes(s);
		byte[] array;
		using (MD5 mD = MD5.Create())
		{
			array = mD.ComputeHash(bytes);
		}
		string text;
		using (MD5 mD2 = MD5.Create())
		{
			mD2.TransformBlock(array, 0, array.Length, null, 0);
			s = $":{Nonce}:{CNonce}";
			if (!string.IsNullOrEmpty(AuthZid))
			{
				s = s + ":" + AuthZid;
			}
			bytes = encoding.GetBytes(s);
			mD2.TransformFinalBlock(bytes, 0, bytes.Length);
			text = HexEncode(mD2.Hash);
		}
		s = (client ? "AUTHENTICATE:" : ":");
		s += DigestUri;
		if (Qop == "auth-int" || Qop == "auth-conf")
		{
			s += ":00000000000000000000000000000000";
		}
		bytes = encoding.GetBytes(s);
		using (MD5 mD3 = MD5.Create())
		{
			array = mD3.ComputeHash(bytes);
		}
		string text2 = HexEncode(array);
		s = $"{text}:{Nonce}:{Nc:x8}:{CNonce}:{Qop}:{text2}";
		bytes = encoding.GetBytes(s);
		using (MD5 mD4 = MD5.Create())
		{
			array = mD4.ComputeHash(bytes);
		}
		return HexEncode(array);
	}

	private static string Quote(string text)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("\"");
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == '\\' || text[i] == '"')
			{
				stringBuilder.Append('\\');
			}
			stringBuilder.Append(text[i]);
		}
		stringBuilder.Append("\"");
		return stringBuilder.ToString();
	}

	public byte[] Encode(Encoding encoding)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("username={0}", Quote(UserName));
		stringBuilder.AppendFormat(",realm=\"{0}\"", Realm);
		stringBuilder.AppendFormat(",nonce=\"{0}\"", Nonce);
		stringBuilder.AppendFormat(",cnonce=\"{0}\"", CNonce);
		stringBuilder.AppendFormat(",nc={0:x8}", Nc);
		stringBuilder.AppendFormat(",qop=\"{0}\"", Qop);
		stringBuilder.AppendFormat(",digest-uri=\"{0}\"", DigestUri);
		stringBuilder.AppendFormat(",response={0}", Response);
		if (MaxBuf.HasValue)
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, ",maxbuf={0}", MaxBuf.Value);
		}
		if (!string.IsNullOrEmpty(Charset))
		{
			stringBuilder.AppendFormat(",charset={0}", Charset);
		}
		if (!string.IsNullOrEmpty(Algorithm))
		{
			stringBuilder.AppendFormat(",algorithm={0}", Algorithm);
		}
		if (!string.IsNullOrEmpty(Cipher))
		{
			stringBuilder.AppendFormat(",cipher=\"{0}\"", Cipher);
		}
		if (!string.IsNullOrEmpty(AuthZid))
		{
			stringBuilder.AppendFormat(",authzid=\"{0}\"", AuthZid);
		}
		return encoding.GetBytes(stringBuilder.ToString());
	}
}
