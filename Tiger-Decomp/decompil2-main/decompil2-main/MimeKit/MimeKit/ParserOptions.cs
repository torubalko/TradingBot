using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using MimeKit.Cryptography;
using MimeKit.Tnef;
using MimeKit.Utils;

namespace MimeKit;

public class ParserOptions
{
	private readonly Dictionary<string, ConstructorInfo> mimeTypes = new Dictionary<string, ConstructorInfo>(StringComparer.Ordinal);

	private static readonly Type[] ConstructorArgTypes = new Type[1] { typeof(MimeEntityConstructorArgs) };

	public static readonly ParserOptions Default = new ParserOptions();

	public RfcComplianceMode AddressParserComplianceMode { get; set; }

	public bool AllowUnquotedCommasInAddresses { get; set; }

	public bool AllowAddressesWithoutDomain { get; set; }

	public int MaxAddressGroupDepth { get; set; }

	public int MaxMimeDepth { get; set; }

	public RfcComplianceMode ParameterComplianceMode { get; set; }

	public RfcComplianceMode Rfc2047ComplianceMode { get; set; }

	public bool RespectContentLength { get; set; }

	public Encoding CharsetEncoding { get; set; }

	public ParserOptions()
	{
		AddressParserComplianceMode = RfcComplianceMode.Loose;
		ParameterComplianceMode = RfcComplianceMode.Loose;
		Rfc2047ComplianceMode = RfcComplianceMode.Loose;
		CharsetEncoding = CharsetUtils.UTF8;
		AllowUnquotedCommasInAddresses = true;
		AllowAddressesWithoutDomain = true;
		RespectContentLength = false;
		MaxAddressGroupDepth = 3;
		MaxMimeDepth = 1024;
	}

	public ParserOptions Clone()
	{
		ParserOptions parserOptions = new ParserOptions();
		parserOptions.AddressParserComplianceMode = AddressParserComplianceMode;
		parserOptions.AllowUnquotedCommasInAddresses = AllowUnquotedCommasInAddresses;
		parserOptions.AllowAddressesWithoutDomain = AllowAddressesWithoutDomain;
		parserOptions.ParameterComplianceMode = ParameterComplianceMode;
		parserOptions.Rfc2047ComplianceMode = Rfc2047ComplianceMode;
		parserOptions.MaxAddressGroupDepth = MaxAddressGroupDepth;
		parserOptions.RespectContentLength = RespectContentLength;
		parserOptions.CharsetEncoding = CharsetEncoding;
		parserOptions.MaxMimeDepth = MaxMimeDepth;
		foreach (KeyValuePair<string, ConstructorInfo> mimeType in mimeTypes)
		{
			parserOptions.mimeTypes.Add(mimeType.Key, mimeType.Value);
		}
		return parserOptions;
	}

	public void RegisterMimeType(string mimeType, Type type)
	{
		if (mimeType == null)
		{
			throw new ArgumentNullException("mimeType");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		mimeType = mimeType.ToLowerInvariant();
		if (!type.IsSubclassOf(typeof(MessagePart)) && !type.IsSubclassOf(typeof(Multipart)) && !type.IsSubclassOf(typeof(MimePart)))
		{
			throw new ArgumentException("The specified type must be a subclass of MessagePart, Multipart, or MimePart.", "type");
		}
		ConstructorInfo constructor = type.GetConstructor(ConstructorArgTypes);
		if (constructor == null)
		{
			throw new ArgumentException("The specified type must have a constructor that takes a MimeEntityConstructorArgs argument.", "type");
		}
		mimeTypes[mimeType] = constructor;
	}

	private static bool IsEncoded(IList<Header> headers)
	{
		for (int i = 0; i < headers.Count; i++)
		{
			if (headers[i].Id == HeaderId.ContentTransferEncoding)
			{
				MimeUtils.TryParse(headers[i].Value, out ContentEncoding encoding);
				if ((uint)(encoding - 1) <= 2u)
				{
					return false;
				}
				return true;
			}
		}
		return false;
	}

	internal MimeEntity CreateEntity(ContentType contentType, IList<Header> headers, bool toplevel, int depth)
	{
		MimeEntityConstructorArgs mimeEntityConstructorArgs = new MimeEntityConstructorArgs(this, contentType, headers, toplevel);
		if (depth >= MaxMimeDepth)
		{
			return new MimePart(mimeEntityConstructorArgs);
		}
		string text = contentType.MediaSubtype.ToLowerInvariant();
		string text2 = contentType.MediaType.ToLowerInvariant();
		if (mimeTypes.Count > 0)
		{
			string key = $"{text2}/{text}";
			if (mimeTypes.TryGetValue(key, out var value))
			{
				return (MimeEntity)value.Invoke(new object[1] { mimeEntityConstructorArgs });
			}
		}
		if (text2 == "message")
		{
			switch (text)
			{
			case "global-disposition-notification":
			case "disposition-notification":
				return new MessageDispositionNotification(mimeEntityConstructorArgs);
			case "global-delivery-status":
			case "delivery-status":
				return new MessageDeliveryStatus(mimeEntityConstructorArgs);
			case "partial":
				if (!IsEncoded(headers))
				{
					return new MessagePartial(mimeEntityConstructorArgs);
				}
				break;
			case "global-headers":
				if (!IsEncoded(headers))
				{
					return new TextRfc822Headers(mimeEntityConstructorArgs);
				}
				break;
			case "external-body":
			case "rfc2822":
			case "rfc822":
			case "global":
			case "news":
				if (!IsEncoded(headers))
				{
					return new MessagePart(mimeEntityConstructorArgs);
				}
				break;
			}
		}
		if (text2 == "multipart")
		{
			return text switch
			{
				"alternative" => new MultipartAlternative(mimeEntityConstructorArgs), 
				"related" => new MultipartRelated(mimeEntityConstructorArgs), 
				"report" => new MultipartReport(mimeEntityConstructorArgs), 
				"encrypted" => new MultipartEncrypted(mimeEntityConstructorArgs), 
				"signed" => new MultipartSigned(mimeEntityConstructorArgs), 
				_ => new Multipart(mimeEntityConstructorArgs), 
			};
		}
		if (text2 == "application")
		{
			switch (text)
			{
			case "x-pkcs7-signature":
			case "pkcs7-signature":
				return new ApplicationPkcs7Signature(mimeEntityConstructorArgs);
			case "x-pgp-encrypted":
			case "pgp-encrypted":
				return new ApplicationPgpEncrypted(mimeEntityConstructorArgs);
			case "x-pgp-signature":
			case "pgp-signature":
				return new ApplicationPgpSignature(mimeEntityConstructorArgs);
			case "x-pkcs7-mime":
			case "pkcs7-mime":
				return new ApplicationPkcs7Mime(mimeEntityConstructorArgs);
			case "vnd.ms-tnef":
			case "ms-tnef":
				return new TnefPart(mimeEntityConstructorArgs);
			case "rtf":
				return new TextPart(mimeEntityConstructorArgs);
			}
		}
		if (text2 == "text")
		{
			if (text == "rfc822-headers" && !IsEncoded(headers))
			{
				return new TextRfc822Headers(mimeEntityConstructorArgs);
			}
			return new TextPart(mimeEntityConstructorArgs);
		}
		return new MimePart(mimeEntityConstructorArgs);
	}
}
