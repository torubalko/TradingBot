using System;
using System.Text;

namespace MimeKit;

internal class Boundary
{
	public static readonly byte[] MboxFrom = Encoding.ASCII.GetBytes("From ");

	public byte[] Marker { get; private set; }

	public int FinalLength => Marker.Length;

	public int Length { get; private set; }

	public int MaxLength { get; private set; }

	public Boundary(string boundary, int currentMaxLength)
	{
		Marker = Encoding.UTF8.GetBytes("--" + boundary + "--");
		Length = Marker.Length - 2;
		MaxLength = Math.Max(currentMaxLength, Marker.Length);
	}

	private Boundary()
	{
	}

	public static Boundary CreateMboxBoundary()
	{
		Boundary boundary = new Boundary();
		boundary.Marker = MboxFrom;
		boundary.MaxLength = 5;
		boundary.Length = 5;
		return boundary;
	}
}
