using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace MailKit.Security;

public abstract class SaslMechanismScramBase : SaslMechanism
{
	private enum LoginState
	{
		Initial,
		Final,
		Validate
	}

	internal string cnonce;

	private string client;

	private string server;

	private byte[] salted;

	private byte[] auth;

	private LoginState state;

	public override bool SupportsInitialResponse => true;

	[Obsolete("Use SaslMechanismScramBase(NetworkCredential) instead.")]
	protected SaslMechanismScramBase(Uri uri, ICredentials credentials)
		: base(uri, credentials)
	{
	}

	[Obsolete("Use SaslMechanismScramBase(string, string) instead.")]
	protected SaslMechanismScramBase(Uri uri, string userName, string password)
		: base(uri, userName, password)
	{
	}

	protected SaslMechanismScramBase(NetworkCredential credentials)
		: base(credentials)
	{
	}

	protected SaslMechanismScramBase(string userName, string password)
		: base(userName, password)
	{
	}

	private static string Normalize(string str)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string text = SaslMechanism.SaslPrep(str);
		for (int i = 0; i < text.Length; i++)
		{
			switch (text[i])
			{
			case ',':
				stringBuilder.Append("=2C");
				break;
			case '=':
				stringBuilder.Append("=3D");
				break;
			default:
				stringBuilder.Append(text[i]);
				break;
			}
		}
		return stringBuilder.ToString();
	}

	protected abstract KeyedHashAlgorithm CreateHMAC(byte[] key);

	private byte[] HMAC(byte[] key, byte[] str)
	{
		using KeyedHashAlgorithm keyedHashAlgorithm = CreateHMAC(key);
		return keyedHashAlgorithm.ComputeHash(str);
	}

	protected abstract byte[] Hash(byte[] str);

	private static void Xor(byte[] a, byte[] b)
	{
		for (int i = 0; i < a.Length; i++)
		{
			a[i] ^= b[i];
		}
	}

	private byte[] Hi(byte[] str, byte[] salt, int count)
	{
		using KeyedHashAlgorithm keyedHashAlgorithm = CreateHMAC(str);
		byte[] array = new byte[salt.Length + 4];
		Buffer.BlockCopy(salt, 0, array, 0, salt.Length);
		array[array.Length - 1] = 1;
		byte[] buffer;
		byte[] array2 = (buffer = keyedHashAlgorithm.ComputeHash(array));
		for (int i = 1; i < count; i++)
		{
			byte[] array3 = keyedHashAlgorithm.ComputeHash(buffer);
			Xor(array2, array3);
			buffer = array3;
		}
		return array2;
	}

	private static Dictionary<char, string> ParseServerChallenge(string challenge)
	{
		Dictionary<char, string> dictionary = new Dictionary<char, string>();
		string[] array = challenge.Split(',');
		foreach (string text in array)
		{
			if (text.Length >= 2 && text[1] == '=')
			{
				dictionary.Add(text[0], text.Substring(2));
			}
		}
		return dictionary;
	}

	protected override byte[] Challenge(byte[] token, int startIndex, int length)
	{
		if (base.IsAuthenticated)
		{
			return null;
		}
		byte[] result;
		switch (state)
		{
		case LoginState.Initial:
			cnonce = cnonce ?? SaslMechanism.GenerateEntropy(18);
			client = "n=" + Normalize(base.Credentials.UserName) + ",r=" + cnonce;
			result = Encoding.UTF8.GetBytes("n,," + client);
			state = LoginState.Final;
			break;
		case LoginState.Final:
		{
			server = Encoding.UTF8.GetString(token, startIndex, length);
			Dictionary<char, string> dictionary = ParseServerChallenge(server);
			if (!dictionary.TryGetValue('s', out var value))
			{
				throw new SaslException(MechanismName, SaslErrorCode.IncompleteChallenge, "Challenge did not contain a salt.");
			}
			if (!dictionary.TryGetValue('r', out var value2))
			{
				throw new SaslException(MechanismName, SaslErrorCode.IncompleteChallenge, "Challenge did not contain a nonce.");
			}
			if (!dictionary.TryGetValue('i', out var value3))
			{
				throw new SaslException(MechanismName, SaslErrorCode.IncompleteChallenge, "Challenge did not contain an iteration count.");
			}
			if (!value2.StartsWith(cnonce, StringComparison.Ordinal))
			{
				throw new SaslException(MechanismName, SaslErrorCode.InvalidChallenge, "Challenge contained an invalid nonce.");
			}
			if (!int.TryParse(value3, NumberStyles.None, CultureInfo.InvariantCulture, out var result2) || result2 < 1)
			{
				throw new SaslException(MechanismName, SaslErrorCode.InvalidChallenge, "Challenge contained an invalid iteration count.");
			}
			byte[] bytes = Encoding.UTF8.GetBytes(SaslMechanism.SaslPrep(base.Credentials.Password));
			salted = Hi(bytes, Convert.FromBase64String(value), result2);
			Array.Clear(bytes, 0, bytes.Length);
			string text2 = "c=" + Convert.ToBase64String(Encoding.ASCII.GetBytes("n,,")) + ",r=" + value2;
			auth = Encoding.UTF8.GetBytes(client + "," + server + "," + text2);
			byte[] array3 = HMAC(salted, Encoding.ASCII.GetBytes("Client Key"));
			byte[] array = HMAC(Hash(array3), auth);
			Xor(array3, array);
			result = Encoding.UTF8.GetBytes(text2 + ",p=" + Convert.ToBase64String(array3));
			state = LoginState.Validate;
			break;
		}
		case LoginState.Validate:
		{
			string text = Encoding.UTF8.GetString(token, startIndex, length);
			if (!text.StartsWith("v=", StringComparison.Ordinal))
			{
				throw new SaslException(MechanismName, SaslErrorCode.InvalidChallenge, "Challenge did not start with a signature.");
			}
			byte[] array = Convert.FromBase64String(text.Substring(2));
			byte[] key = HMAC(salted, Encoding.ASCII.GetBytes("Server Key"));
			byte[] array2 = HMAC(key, auth);
			if (array.Length != array2.Length)
			{
				throw new SaslException(MechanismName, SaslErrorCode.IncorrectHash, "Challenge contained a signature with an invalid length.");
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != array2[i])
				{
					throw new SaslException(MechanismName, SaslErrorCode.IncorrectHash, "Challenge contained an invalid signatire.");
				}
			}
			base.IsAuthenticated = true;
			result = new byte[0];
			break;
		}
		default:
			throw new IndexOutOfRangeException("state");
		}
		return result;
	}

	public override void Reset()
	{
		state = LoginState.Initial;
		client = null;
		server = null;
		salted = null;
		cnonce = null;
		auth = null;
		base.Reset();
	}
}
