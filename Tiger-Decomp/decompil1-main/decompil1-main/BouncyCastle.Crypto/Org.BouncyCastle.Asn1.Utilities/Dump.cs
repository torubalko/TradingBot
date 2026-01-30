using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Utilities;

public sealed class Dump
{
	private Dump()
	{
	}

	public static void Main(string[] args)
	{
		Asn1InputStream bIn = new Asn1InputStream(File.OpenRead(args[0]));
		Asn1Object obj;
		while ((obj = bIn.ReadObject()) != null)
		{
			Console.WriteLine(Asn1Dump.DumpAsString(obj));
		}
		Platform.Dispose(bIn);
	}
}
