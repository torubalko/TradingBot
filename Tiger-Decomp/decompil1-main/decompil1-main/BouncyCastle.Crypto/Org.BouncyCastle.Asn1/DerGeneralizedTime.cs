using System;
using System.Globalization;
using System.Text;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerGeneralizedTime : Asn1Object
{
	private readonly string time;

	public string TimeString => time;

	private bool HasFractionalSeconds => time.IndexOf('.') == 14;

	public static DerGeneralizedTime GetInstance(object obj)
	{
		if (obj == null || obj is DerGeneralizedTime)
		{
			return (DerGeneralizedTime)obj;
		}
		throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj), "obj");
	}

	public static DerGeneralizedTime GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object o = obj.GetObject();
		if (isExplicit || o is DerGeneralizedTime)
		{
			return GetInstance(o);
		}
		return new DerGeneralizedTime(((Asn1OctetString)o).GetOctets());
	}

	public DerGeneralizedTime(string time)
	{
		this.time = time;
		try
		{
			ToDateTime();
		}
		catch (FormatException ex)
		{
			throw new ArgumentException("invalid date string: " + ex.Message);
		}
	}

	public DerGeneralizedTime(DateTime time)
	{
		this.time = time.ToString("yyyyMMddHHmmss\\Z");
	}

	internal DerGeneralizedTime(byte[] bytes)
	{
		time = Strings.FromAsciiByteArray(bytes);
	}

	public string GetTime()
	{
		if (time[time.Length - 1] == 'Z')
		{
			return time.Substring(0, time.Length - 1) + "GMT+00:00";
		}
		int signPos = time.Length - 5;
		char sign = time[signPos];
		if (sign == '-' || sign == '+')
		{
			return time.Substring(0, signPos) + "GMT" + time.Substring(signPos, 3) + ":" + time.Substring(signPos + 3);
		}
		signPos = time.Length - 3;
		sign = time[signPos];
		if (sign == '-' || sign == '+')
		{
			return time.Substring(0, signPos) + "GMT" + time.Substring(signPos) + ":00";
		}
		return time + CalculateGmtOffset();
	}

	private string CalculateGmtOffset()
	{
		char sign = '+';
		DateTime time = ToDateTime();
		TimeSpan offset = TimeZone.CurrentTimeZone.GetUtcOffset(time);
		if (offset.CompareTo(TimeSpan.Zero) < 0)
		{
			sign = '-';
			offset = offset.Duration();
		}
		int hours = offset.Hours;
		int minutes = offset.Minutes;
		return "GMT" + sign + Convert(hours) + ":" + Convert(minutes);
	}

	private static string Convert(int time)
	{
		if (time < 10)
		{
			return "0" + time;
		}
		return time.ToString();
	}

	public DateTime ToDateTime()
	{
		string d = time;
		bool makeUniversal = false;
		string formatStr;
		if (Platform.EndsWith(d, "Z"))
		{
			if (HasFractionalSeconds)
			{
				int fCount = d.Length - d.IndexOf('.') - 2;
				formatStr = "yyyyMMddHHmmss." + FString(fCount) + "\\Z";
			}
			else
			{
				formatStr = "yyyyMMddHHmmss\\Z";
			}
		}
		else if (time.IndexOf('-') > 0 || time.IndexOf('+') > 0)
		{
			d = GetTime();
			makeUniversal = true;
			if (HasFractionalSeconds)
			{
				int fCount2 = Platform.IndexOf(d, "GMT") - 1 - d.IndexOf('.');
				formatStr = "yyyyMMddHHmmss." + FString(fCount2) + "'GMT'zzz";
			}
			else
			{
				formatStr = "yyyyMMddHHmmss'GMT'zzz";
			}
		}
		else if (HasFractionalSeconds)
		{
			int fCount3 = d.Length - 1 - d.IndexOf('.');
			formatStr = "yyyyMMddHHmmss." + FString(fCount3);
		}
		else
		{
			formatStr = "yyyyMMddHHmmss";
		}
		return ParseDateString(d, formatStr, makeUniversal);
	}

	private string FString(int count)
	{
		StringBuilder sb = new StringBuilder();
		for (int i = 0; i < count; i++)
		{
			sb.Append('f');
		}
		return sb.ToString();
	}

	private DateTime ParseDateString(string s, string format, bool makeUniversal)
	{
		DateTimeStyles style = DateTimeStyles.None;
		if (Platform.EndsWith(format, "Z"))
		{
			try
			{
				style = (DateTimeStyles)(object)Enums.GetEnumValue(typeof(DateTimeStyles), "AssumeUniversal");
			}
			catch (Exception)
			{
			}
			style |= DateTimeStyles.AdjustToUniversal;
		}
		DateTime dt = DateTime.ParseExact(s, format, DateTimeFormatInfo.InvariantInfo, style);
		if (!makeUniversal)
		{
			return dt;
		}
		return dt.ToUniversalTime();
	}

	private byte[] GetOctets()
	{
		return Strings.ToAsciiByteArray(time);
	}

	internal override int EncodedLength(bool withID)
	{
		return Asn1OutputStream.GetLengthOfEncodingDL(withID, time.Length);
	}

	internal override void Encode(Asn1OutputStream asn1Out, bool withID)
	{
		asn1Out.WriteEncodingDL(withID, 24, GetOctets());
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerGeneralizedTime other))
		{
			return false;
		}
		return time.Equals(other.time);
	}

	protected override int Asn1GetHashCode()
	{
		return time.GetHashCode();
	}
}
