using System;
using System.IO;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Utilities.IO.Pem;

public class PemWriter
{
	private const int LineLength = 64;

	private readonly TextWriter writer;

	private readonly int nlLength;

	private char[] buf = new char[64];

	public TextWriter Writer => writer;

	public PemWriter(TextWriter writer)
	{
		if (writer == null)
		{
			throw new ArgumentNullException("writer");
		}
		this.writer = writer;
		nlLength = Platform.NewLine.Length;
	}

	public int GetOutputSize(PemObject obj)
	{
		int size = 2 * (obj.Type.Length + 10 + nlLength) + 6 + 4;
		if (obj.Headers.Count > 0)
		{
			foreach (PemHeader header in obj.Headers)
			{
				size += header.Name.Length + ": ".Length + header.Value.Length + nlLength;
			}
			size += nlLength;
		}
		int dataLen = (obj.Content.Length + 2) / 3 * 4;
		return size + (dataLen + (dataLen + 64 - 1) / 64 * nlLength);
	}

	public void WriteObject(PemObjectGenerator objGen)
	{
		PemObject obj = objGen.Generate();
		WritePreEncapsulationBoundary(obj.Type);
		if (obj.Headers.Count > 0)
		{
			foreach (PemHeader header in obj.Headers)
			{
				writer.Write(header.Name);
				writer.Write(": ");
				writer.WriteLine(header.Value);
			}
			writer.WriteLine();
		}
		WriteEncoded(obj.Content);
		WritePostEncapsulationBoundary(obj.Type);
	}

	private void WriteEncoded(byte[] bytes)
	{
		bytes = Base64.Encode(bytes);
		for (int i = 0; i < bytes.Length; i += buf.Length)
		{
			int index;
			for (index = 0; index != buf.Length && i + index < bytes.Length; index++)
			{
				buf[index] = (char)bytes[i + index];
			}
			writer.WriteLine(buf, 0, index);
		}
	}

	private void WritePreEncapsulationBoundary(string type)
	{
		writer.WriteLine("-----BEGIN " + type + "-----");
	}

	private void WritePostEncapsulationBoundary(string type)
	{
		writer.WriteLine("-----END " + type + "-----");
	}
}
