using System.Buffers.Binary;
using System.Buffers.Text;
using System.Diagnostics.CodeAnalysis;

namespace System.Diagnostics;

public readonly struct ActivitySpanId : IEquatable<ActivitySpanId>
{
	private readonly string _hexString;

	internal ActivitySpanId(string hexString)
	{
		_hexString = hexString;
	}

	public unsafe static ActivitySpanId CreateRandom()
	{
		ulong num = default(ulong);
		ActivityTraceId.SetToRandomBytes(new System.Span<byte>((void*)(&num), 8));
		return new ActivitySpanId(HexConverter.ToString(new System.ReadOnlySpan<byte>((void*)(&num), 8), HexConverter.Casing.Lower));
	}

	public static ActivitySpanId CreateFromBytes(System.ReadOnlySpan<byte> idData)
	{
		if (idData.Length != 8)
		{
			throw new ArgumentOutOfRangeException("idData");
		}
		return new ActivitySpanId(HexConverter.ToString(idData, HexConverter.Casing.Lower));
	}

	public static ActivitySpanId CreateFromUtf8String(System.ReadOnlySpan<byte> idData)
	{
		return new ActivitySpanId(idData);
	}

	public static ActivitySpanId CreateFromString(System.ReadOnlySpan<char> idData)
	{
		if (idData.Length != 16 || !ActivityTraceId.IsLowerCaseHexAndNotAllZeros(idData))
		{
			throw new ArgumentOutOfRangeException("idData");
		}
		return new ActivitySpanId(idData.ToString());
	}

	public string ToHexString()
	{
		return _hexString ?? "0000000000000000";
	}

	public override string ToString()
	{
		return ToHexString();
	}

	public static bool operator ==(ActivitySpanId spanId1, ActivitySpanId spandId2)
	{
		return spanId1._hexString == spandId2._hexString;
	}

	public static bool operator !=(ActivitySpanId spanId1, ActivitySpanId spandId2)
	{
		return spanId1._hexString != spandId2._hexString;
	}

	public bool Equals(ActivitySpanId spanId)
	{
		return _hexString == spanId._hexString;
	}

	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is ActivitySpanId activitySpanId)
		{
			return _hexString == activitySpanId._hexString;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ToHexString().GetHashCode();
	}

	private unsafe ActivitySpanId(System.ReadOnlySpan<byte> idData)
	{
		if (idData.Length != 16)
		{
			throw new ArgumentOutOfRangeException("idData");
		}
		ulong num = default(ulong);
		int num2 = default(int);
		if (!Utf8Parser.TryParse(idData, ref num, ref num2, 'x'))
		{
			_hexString = CreateRandom()._hexString;
			return;
		}
		if (BitConverter.IsLittleEndian)
		{
			num = BinaryPrimitives.ReverseEndianness(num);
		}
		_hexString = HexConverter.ToString(new System.ReadOnlySpan<byte>((void*)(&num), 8), HexConverter.Casing.Lower);
	}

	public void CopyTo(System.Span<byte> destination)
	{
		ActivityTraceId.SetSpanFromHexChars(MemoryExtensions.AsSpan(ToHexString()), destination);
	}
}
