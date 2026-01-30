using System;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace MailKit.Security;

public abstract class SaslMechanism
{
	public static readonly string[] AuthMechanismRank;

	private static readonly bool md5supported;

	public abstract string MechanismName { get; }

	public NetworkCredential Credentials { get; private set; }

	public virtual bool SupportsInitialResponse => false;

	public bool IsAuthenticated { get; protected set; }

	public virtual bool NegotiatedSecurityLayer => false;

	internal Uri Uri { get; set; }

	static SaslMechanism()
	{
		AuthMechanismRank = new string[8] { "SCRAM-SHA-512", "SCRAM-SHA-256", "SCRAM-SHA-1", "CRAM-MD5", "DIGEST-MD5", "PLAIN", "LOGIN", "NTLM" };
		try
		{
			using (MD5.Create())
			{
				md5supported = true;
			}
		}
		catch
		{
			md5supported = false;
		}
	}

	[Obsolete("Use SaslMechanism(NetworkCredential) instead.")]
	protected SaslMechanism(Uri uri, ICredentials credentials)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		if (credentials == null)
		{
			throw new ArgumentNullException("credentials");
		}
		Credentials = credentials.GetCredential(uri, MechanismName);
		Uri = uri;
	}

	[Obsolete("Use SaslMechanism(string, string) instead.")]
	protected SaslMechanism(Uri uri, string userName, string password)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		if (userName == null)
		{
			throw new ArgumentNullException("userName");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		Credentials = new NetworkCredential(userName, password);
		Uri = uri;
	}

	protected SaslMechanism(NetworkCredential credentials)
	{
		if (credentials == null)
		{
			throw new ArgumentNullException("credentials");
		}
		Credentials = credentials;
	}

	protected SaslMechanism(string userName, string password)
	{
		if (userName == null)
		{
			throw new ArgumentNullException("userName");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		Credentials = new NetworkCredential(userName, password);
	}

	protected abstract byte[] Challenge(byte[] token, int startIndex, int length);

	public string Challenge(string token)
	{
		byte[] array = null;
		int length = 0;
		if (token != null)
		{
			try
			{
				array = Convert.FromBase64String(token.Trim());
				length = array.Length;
			}
			catch (FormatException)
			{
			}
		}
		byte[] array2 = Challenge(array, 0, length);
		if (array2 == null || array2.Length == 0)
		{
			return string.Empty;
		}
		return Convert.ToBase64String(array2);
	}

	public virtual void Reset()
	{
		IsAuthenticated = false;
	}

	public static bool IsSupported(string mechanism)
	{
		if (mechanism == null)
		{
			throw new ArgumentNullException("mechanism");
		}
		return mechanism switch
		{
			"SCRAM-SHA-512" => true, 
			"SCRAM-SHA-256" => true, 
			"SCRAM-SHA-1" => true, 
			"DIGEST-MD5" => md5supported, 
			"CRAM-MD5" => md5supported, 
			"OAUTHBEARER" => true, 
			"XOAUTH2" => true, 
			"PLAIN" => true, 
			"LOGIN" => true, 
			"NTLM" => true, 
			_ => false, 
		};
	}

	public static SaslMechanism Create(string mechanism, Uri uri, Encoding encoding, ICredentials credentials)
	{
		if (mechanism == null)
		{
			throw new ArgumentNullException("mechanism");
		}
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		if (credentials == null)
		{
			throw new ArgumentNullException("credentials");
		}
		NetworkCredential credential = credentials.GetCredential(uri, mechanism);
		switch (mechanism)
		{
		case "SCRAM-SHA-512":
			return new SaslMechanismScramSha512(credential)
			{
				Uri = uri
			};
		case "SCRAM-SHA-256":
			return new SaslMechanismScramSha256(credential)
			{
				Uri = uri
			};
		case "SCRAM-SHA-1":
			return new SaslMechanismScramSha1(credential)
			{
				Uri = uri
			};
		case "DIGEST-MD5":
			if (!md5supported)
			{
				return null;
			}
			return new SaslMechanismDigestMd5(credential)
			{
				Uri = uri
			};
		case "CRAM-MD5":
			if (!md5supported)
			{
				return null;
			}
			return new SaslMechanismCramMd5(credential)
			{
				Uri = uri
			};
		case "OAUTHBEARER":
			return new SaslMechanismOAuthBearer(credential)
			{
				Uri = uri
			};
		case "XOAUTH2":
			return new SaslMechanismOAuth2(credential)
			{
				Uri = uri
			};
		case "PLAIN":
			return new SaslMechanismPlain(encoding, credential)
			{
				Uri = uri
			};
		case "LOGIN":
			return new SaslMechanismLogin(encoding, credential)
			{
				Uri = uri
			};
		case "NTLM":
			return new SaslMechanismNtlm(credential)
			{
				Uri = uri
			};
		default:
			return null;
		}
	}

	public static SaslMechanism Create(string mechanism, Uri uri, ICredentials credentials)
	{
		return Create(mechanism, uri, Encoding.UTF8, credentials);
	}

	private static bool IsNonAsciiSpace(char c)
	{
		switch (c)
		{
		case '\u00a0':
		case '\u1680':
		case '\u2000':
		case '\u2001':
		case '\u2002':
		case '\u2003':
		case '\u2004':
		case '\u2005':
		case '\u2006':
		case '\u2007':
		case '\u2008':
		case '\u2009':
		case '\u200a':
		case '\u200b':
		case '\u202f':
		case '\u205f':
		case '\u3000':
			return true;
		default:
			return false;
		}
	}

	private static bool IsCommonlyMappedToNothing(char c)
	{
		switch (c)
		{
		case '\u00ad':
		case '\u034f':
		case '᠆':
		case '\u180b':
		case '\u180c':
		case '\u180d':
		case '\u200b':
		case '\u200c':
		case '\u200d':
		case '\u2060':
		case '\ufe00':
		case '\ufe01':
		case '\ufe02':
		case '\ufe03':
		case '\ufe04':
		case '\ufe05':
		case '\ufe06':
		case '\ufe07':
		case '\ufe08':
		case '\ufe09':
		case '\ufe0a':
		case '\ufe0b':
		case '\ufe0c':
		case '\ufe0d':
		case '\ufe0e':
		case '\ufe0f':
		case '\ufeff':
			return true;
		default:
			return false;
		}
	}

	private static bool IsProhibited(string s, int index)
	{
		int num = char.ConvertToUtf32(s, index);
		if ((num >= 57344 && num <= 63743) || (num >= 983040 && num <= 1048573) || (num >= 1048576 && num <= 1114109))
		{
			return true;
		}
		if ((num >= 64976 && num <= 65007) || (num >= 65534 && num <= 65535) || (num >= 131070 && num <= 131071) || (num >= 196606 && num <= 196607) || (num >= 262142 && num <= 262143) || (num >= 327678 && num <= 327679) || (num >= 393214 && num <= 393215) || (num >= 458750 && num <= 458751) || (num >= 524286 && num <= 524287) || (num >= 589822 && num <= 589823) || (num >= 655358 && num <= 655359) || (num >= 720894 && num <= 720895) || (num >= 786430 && num <= 786431) || (num >= 851966 && num <= 851967) || (num >= 917502 && num <= 917503) || (num >= 983038 && num <= 983039) || (num >= 1048574 && num <= 1048575) || (num >= 1114110 && num <= 1114111))
		{
			return true;
		}
		if (num >= 55296 && num <= 57343)
		{
			return true;
		}
		switch (num)
		{
		case 65529:
		case 65530:
		case 65531:
		case 65532:
		case 65533:
			return true;
		case 12272:
		case 12273:
		case 12274:
		case 12275:
		case 12276:
		case 12277:
		case 12278:
		case 12279:
		case 12280:
		case 12281:
		case 12282:
		case 12283:
			return true;
		default:
			switch (num)
			{
			case 832:
			case 833:
			case 8206:
			case 8207:
			case 8234:
			case 8235:
			case 8236:
			case 8237:
			case 8238:
			case 8298:
			case 8299:
			case 8300:
			case 8301:
			case 8302:
			case 8303:
				return true;
			default:
				switch (num)
				{
				case 917505:
				case 917536:
				case 917537:
				case 917538:
				case 917539:
				case 917540:
				case 917541:
				case 917542:
				case 917543:
				case 917544:
				case 917545:
				case 917546:
				case 917547:
				case 917548:
				case 917549:
				case 917550:
				case 917551:
				case 917552:
				case 917553:
				case 917554:
				case 917555:
				case 917556:
				case 917557:
				case 917558:
				case 917559:
				case 917560:
				case 917561:
				case 917562:
				case 917563:
				case 917564:
				case 917565:
				case 917566:
				case 917567:
				case 917568:
				case 917569:
				case 917570:
				case 917571:
				case 917572:
				case 917573:
				case 917574:
				case 917575:
				case 917576:
				case 917577:
				case 917578:
				case 917579:
				case 917580:
				case 917581:
				case 917582:
				case 917583:
				case 917584:
				case 917585:
				case 917586:
				case 917587:
				case 917588:
				case 917589:
				case 917590:
				case 917591:
				case 917592:
				case 917593:
				case 917594:
				case 917595:
				case 917596:
				case 917597:
				case 917598:
				case 917599:
				case 917600:
				case 917601:
				case 917602:
				case 917603:
				case 917604:
				case 917605:
				case 917606:
				case 917607:
				case 917608:
				case 917609:
				case 917610:
				case 917611:
				case 917612:
				case 917613:
				case 917614:
				case 917615:
				case 917616:
				case 917617:
				case 917618:
				case 917619:
				case 917620:
				case 917621:
				case 917622:
				case 917623:
				case 917624:
				case 917625:
				case 917626:
				case 917627:
				case 917628:
				case 917629:
				case 917630:
				case 917631:
					return true;
				default:
					return false;
				}
			}
		}
	}

	public static string SaslPrep(string s)
	{
		if (s == null)
		{
			throw new ArgumentNullException("s");
		}
		if (s.Length == 0)
		{
			return s;
		}
		StringBuilder stringBuilder = new StringBuilder(s.Length);
		for (int i = 0; i < s.Length; i++)
		{
			if (IsNonAsciiSpace(s[i]))
			{
				stringBuilder.Append(' ');
			}
			else if (!IsCommonlyMappedToNothing(s[i]))
			{
				if (char.IsControl(s[i]))
				{
					throw new ArgumentException("Control characters are prohibited.", "s");
				}
				if (IsProhibited(s, i))
				{
					throw new ArgumentException("One or more characters in the string are prohibited.", "s");
				}
				stringBuilder.Append(s[i]);
			}
		}
		return stringBuilder.ToString().Normalize(NormalizationForm.FormKC);
	}

	internal static string GenerateEntropy(int n)
	{
		byte[] array = new byte[n];
		using (RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create())
		{
			randomNumberGenerator.GetBytes(array);
		}
		return Convert.ToBase64String(array);
	}
}
