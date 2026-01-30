using System;
using System.Globalization;

namespace Org.BouncyCastle.Utilities.Net;

public class IPAddress
{
	public static bool IsValid(string address)
	{
		if (!IsValidIPv4(address))
		{
			return IsValidIPv6(address);
		}
		return true;
	}

	public static bool IsValidWithNetMask(string address)
	{
		if (!IsValidIPv4WithNetmask(address))
		{
			return IsValidIPv6WithNetmask(address);
		}
		return true;
	}

	public static bool IsValidIPv4(string address)
	{
		try
		{
			return unsafeIsValidIPv4(address);
		}
		catch (FormatException)
		{
		}
		catch (OverflowException)
		{
		}
		return false;
	}

	private static bool unsafeIsValidIPv4(string address)
	{
		if (address.Length == 0)
		{
			return false;
		}
		int octets = 0;
		string temp = address + ".";
		int start = 0;
		int pos;
		while (start < temp.Length && (pos = temp.IndexOf('.', start)) > start)
		{
			if (octets == 4)
			{
				return false;
			}
			int octet = int.Parse(temp.Substring(start, pos - start));
			if (octet < 0 || octet > 255)
			{
				return false;
			}
			start = pos + 1;
			octets++;
		}
		return octets == 4;
	}

	public static bool IsValidIPv4WithNetmask(string address)
	{
		int index = address.IndexOf('/');
		string mask = address.Substring(index + 1);
		if (index > 0 && IsValidIPv4(address.Substring(0, index)))
		{
			if (!IsValidIPv4(mask))
			{
				return IsMaskValue(mask, 32);
			}
			return true;
		}
		return false;
	}

	public static bool IsValidIPv6WithNetmask(string address)
	{
		int index = address.IndexOf('/');
		string mask = address.Substring(index + 1);
		if (index > 0)
		{
			if (IsValidIPv6(address.Substring(0, index)))
			{
				if (!IsValidIPv6(mask))
				{
					return IsMaskValue(mask, 128);
				}
				return true;
			}
			return false;
		}
		return false;
	}

	private static bool IsMaskValue(string component, int size)
	{
		int val = int.Parse(component);
		try
		{
			return val >= 0 && val <= size;
		}
		catch (FormatException)
		{
		}
		catch (OverflowException)
		{
		}
		return false;
	}

	public static bool IsValidIPv6(string address)
	{
		try
		{
			return unsafeIsValidIPv6(address);
		}
		catch (FormatException)
		{
		}
		catch (OverflowException)
		{
		}
		return false;
	}

	private static bool unsafeIsValidIPv6(string address)
	{
		if (address.Length == 0)
		{
			return false;
		}
		int octets = 0;
		string temp = address + ":";
		bool doubleColonFound = false;
		int start = 0;
		int pos;
		while (start < temp.Length && (pos = temp.IndexOf(':', start)) >= start)
		{
			if (octets == 8)
			{
				return false;
			}
			if (start != pos)
			{
				string value = temp.Substring(start, pos - start);
				if (pos == temp.Length - 1 && value.IndexOf('.') > 0)
				{
					if (!IsValidIPv4(value))
					{
						return false;
					}
					octets++;
				}
				else
				{
					int octet = int.Parse(temp.Substring(start, pos - start), NumberStyles.AllowHexSpecifier);
					if (octet < 0 || octet > 65535)
					{
						return false;
					}
				}
			}
			else
			{
				if (pos != 1 && pos != temp.Length - 1 && doubleColonFound)
				{
					return false;
				}
				doubleColonFound = true;
			}
			start = pos + 1;
			octets++;
		}
		return octets == 8 || doubleColonFound;
	}
}
