using System;
using System.Runtime.CompilerServices;

namespace MimeKit.Text;

internal class CharBuffer
{
	private char[] buffer;

	public int Length
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get;
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set;
	}

	public char this[int index]
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			return buffer[index];
		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		set
		{
			buffer[index] = value;
		}
	}

	public CharBuffer(int capacity)
	{
		buffer = new char[capacity];
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private void EnsureCapacity(int length)
	{
		if (length >= buffer.Length)
		{
			int num;
			for (num = buffer.Length << 1; num <= length; num <<= 1)
			{
			}
			Array.Resize(ref buffer, num);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Append(char c)
	{
		EnsureCapacity(Length + 1);
		buffer[Length++] = c;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void Append(string str)
	{
		EnsureCapacity(Length + str.Length);
		str.CopyTo(0, buffer, Length, str.Length);
		Length += str.Length;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public override string ToString()
	{
		return new string(buffer, 0, Length);
	}

	public static implicit operator string(CharBuffer buffer)
	{
		return buffer.ToString();
	}
}
