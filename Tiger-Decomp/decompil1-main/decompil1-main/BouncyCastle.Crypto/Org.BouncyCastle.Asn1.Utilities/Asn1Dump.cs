using System.IO;
using System.Text;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Asn1.Utilities;

public sealed class Asn1Dump
{
	private static readonly string NewLine = Platform.NewLine;

	private const string Tab = "    ";

	private const int SampleSize = 32;

	private Asn1Dump()
	{
	}

	private static void AsString(string indent, bool verbose, Asn1Object obj, StringBuilder buf)
	{
		if (obj is Asn1Null)
		{
			buf.Append(indent);
			buf.Append("NULL");
			buf.Append(NewLine);
		}
		else if (obj is Asn1Sequence)
		{
			buf.Append(indent);
			if (obj is BerSequence)
			{
				buf.Append("BER Sequence");
			}
			else if (obj is DerSequence)
			{
				buf.Append("DER Sequence");
			}
			else
			{
				buf.Append("Sequence");
			}
			buf.Append(NewLine);
			Asn1Sequence sequence = (Asn1Sequence)obj;
			string elementsIndent = indent + "    ";
			int i = 0;
			for (int count = sequence.Count; i < count; i++)
			{
				AsString(elementsIndent, verbose, sequence[i].ToAsn1Object(), buf);
			}
		}
		else if (obj is Asn1Set)
		{
			buf.Append(indent);
			if (obj is BerSet)
			{
				buf.Append("BER Set");
			}
			else if (obj is DerSet)
			{
				buf.Append("DER Set");
			}
			else
			{
				buf.Append("Set");
			}
			buf.Append(NewLine);
			Asn1Set set = (Asn1Set)obj;
			string elementsIndent2 = indent + "    ";
			int j = 0;
			for (int count2 = set.Count; j < count2; j++)
			{
				AsString(elementsIndent2, verbose, set[j].ToAsn1Object(), buf);
			}
		}
		else if (obj is Asn1TaggedObject)
		{
			string tab = indent + "    ";
			buf.Append(indent);
			if (obj is BerTaggedObject)
			{
				buf.Append("BER Tagged [");
			}
			else
			{
				buf.Append("Tagged [");
			}
			Asn1TaggedObject o = (Asn1TaggedObject)obj;
			buf.Append(o.TagNo.ToString());
			buf.Append(']');
			if (!o.IsExplicit())
			{
				buf.Append(" IMPLICIT ");
			}
			buf.Append(NewLine);
			if (o.IsEmpty())
			{
				buf.Append(tab);
				buf.Append("EMPTY");
				buf.Append(NewLine);
			}
			else
			{
				AsString(tab, verbose, o.GetObject(), buf);
			}
		}
		else if (obj is DerObjectIdentifier)
		{
			buf.Append(indent + "ObjectIdentifier(" + ((DerObjectIdentifier)obj).Id + ")" + NewLine);
		}
		else if (obj is DerBoolean)
		{
			buf.Append(indent + "Boolean(" + ((DerBoolean)obj).IsTrue + ")" + NewLine);
		}
		else if (obj is DerInteger)
		{
			buf.Append(indent + "Integer(" + ((DerInteger)obj).Value?.ToString() + ")" + NewLine);
		}
		else if (obj is BerOctetString)
		{
			byte[] octets = ((Asn1OctetString)obj).GetOctets();
			string extra = (verbose ? dumpBinaryDataAsString(indent, octets) : "");
			buf.Append(indent + "BER Octet String[" + octets.Length + "] " + extra + NewLine);
		}
		else if (obj is DerOctetString)
		{
			byte[] octets2 = ((Asn1OctetString)obj).GetOctets();
			string extra2 = (verbose ? dumpBinaryDataAsString(indent, octets2) : "");
			buf.Append(indent + "DER Octet String[" + octets2.Length + "] " + extra2 + NewLine);
		}
		else if (obj is DerBitString)
		{
			DerBitString bt = (DerBitString)obj;
			byte[] bytes = bt.GetBytes();
			string extra3 = (verbose ? dumpBinaryDataAsString(indent, bytes) : "");
			buf.Append(indent + "DER Bit String[" + bytes.Length + ", " + bt.PadBits + "] " + extra3 + NewLine);
		}
		else if (obj is DerIA5String)
		{
			buf.Append(indent + "IA5String(" + ((DerIA5String)obj).GetString() + ") " + NewLine);
		}
		else if (obj is DerUtf8String)
		{
			buf.Append(indent + "UTF8String(" + ((DerUtf8String)obj).GetString() + ") " + NewLine);
		}
		else if (obj is DerPrintableString)
		{
			buf.Append(indent + "PrintableString(" + ((DerPrintableString)obj).GetString() + ") " + NewLine);
		}
		else if (obj is DerVisibleString)
		{
			buf.Append(indent + "VisibleString(" + ((DerVisibleString)obj).GetString() + ") " + NewLine);
		}
		else if (obj is DerBmpString)
		{
			buf.Append(indent + "BMPString(" + ((DerBmpString)obj).GetString() + ") " + NewLine);
		}
		else if (obj is DerT61String)
		{
			buf.Append(indent + "T61String(" + ((DerT61String)obj).GetString() + ") " + NewLine);
		}
		else if (obj is DerGraphicString)
		{
			buf.Append(indent + "GraphicString(" + ((DerGraphicString)obj).GetString() + ") " + NewLine);
		}
		else if (obj is DerVideotexString)
		{
			buf.Append(indent + "VideotexString(" + ((DerVideotexString)obj).GetString() + ") " + NewLine);
		}
		else if (obj is DerUtcTime)
		{
			buf.Append(indent + "UTCTime(" + ((DerUtcTime)obj).TimeString + ") " + NewLine);
		}
		else if (obj is DerGeneralizedTime)
		{
			buf.Append(indent + "GeneralizedTime(" + ((DerGeneralizedTime)obj).GetTime() + ") " + NewLine);
		}
		else if (obj is BerApplicationSpecific)
		{
			buf.Append(outputApplicationSpecific("BER", indent, verbose, (BerApplicationSpecific)obj));
		}
		else if (obj is DerApplicationSpecific)
		{
			buf.Append(outputApplicationSpecific("DER", indent, verbose, (DerApplicationSpecific)obj));
		}
		else if (obj is DerEnumerated)
		{
			DerEnumerated en = (DerEnumerated)obj;
			buf.Append(indent + "DER Enumerated(" + en.Value?.ToString() + ")" + NewLine);
		}
		else if (obj is DerExternal)
		{
			DerExternal ext = (DerExternal)obj;
			buf.Append(indent + "External " + NewLine);
			string tab2 = indent + "    ";
			if (ext.DirectReference != null)
			{
				buf.Append(tab2 + "Direct Reference: " + ext.DirectReference.Id + NewLine);
			}
			if (ext.IndirectReference != null)
			{
				buf.Append(tab2 + "Indirect Reference: " + ext.IndirectReference.ToString() + NewLine);
			}
			if (ext.DataValueDescriptor != null)
			{
				AsString(tab2, verbose, ext.DataValueDescriptor, buf);
			}
			buf.Append(tab2 + "Encoding: " + ext.Encoding + NewLine);
			AsString(tab2, verbose, ext.ExternalContent, buf);
		}
		else
		{
			buf.Append(indent + obj.ToString() + NewLine);
		}
	}

	private static string outputApplicationSpecific(string type, string indent, bool verbose, DerApplicationSpecific app)
	{
		StringBuilder buf = new StringBuilder();
		if (app.IsConstructed())
		{
			try
			{
				Asn1Sequence s = Asn1Sequence.GetInstance(app.GetObject(16));
				buf.Append(indent + type + " ApplicationSpecific[" + app.ApplicationTag + "]" + NewLine);
				foreach (Asn1Encodable ae in s)
				{
					AsString(indent + "    ", verbose, ae.ToAsn1Object(), buf);
				}
			}
			catch (IOException value)
			{
				buf.Append(value);
			}
			return buf.ToString();
		}
		return indent + type + " ApplicationSpecific[" + app.ApplicationTag + "] (" + Hex.ToHexString(app.GetContents()) + ")" + NewLine;
	}

	public static string DumpAsString(Asn1Encodable obj)
	{
		return DumpAsString(obj, verbose: false);
	}

	public static string DumpAsString(Asn1Encodable obj, bool verbose)
	{
		StringBuilder buf = new StringBuilder();
		AsString("", verbose, obj.ToAsn1Object(), buf);
		return buf.ToString();
	}

	private static string dumpBinaryDataAsString(string indent, byte[] bytes)
	{
		indent += "    ";
		StringBuilder buf = new StringBuilder(NewLine);
		for (int i = 0; i < bytes.Length; i += 32)
		{
			if (bytes.Length - i > 32)
			{
				buf.Append(indent);
				buf.Append(Hex.ToHexString(bytes, i, 32));
				buf.Append("    ");
				buf.Append(calculateAscString(bytes, i, 32));
				buf.Append(NewLine);
				continue;
			}
			buf.Append(indent);
			buf.Append(Hex.ToHexString(bytes, i, bytes.Length - i));
			for (int j = bytes.Length - i; j != 32; j++)
			{
				buf.Append("  ");
			}
			buf.Append("    ");
			buf.Append(calculateAscString(bytes, i, bytes.Length - i));
			buf.Append(NewLine);
		}
		return buf.ToString();
	}

	private static string calculateAscString(byte[] bytes, int off, int len)
	{
		StringBuilder buf = new StringBuilder();
		for (int i = off; i != off + len; i++)
		{
			char c = (char)bytes[i];
			if (c >= ' ' && c <= '~')
			{
				buf.Append(c);
			}
		}
		return buf.ToString();
	}
}
