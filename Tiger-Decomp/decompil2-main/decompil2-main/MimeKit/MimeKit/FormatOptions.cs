using System;
using System.Collections.Generic;
using MimeKit.IO.Filters;

namespace MimeKit;

public class FormatOptions
{
	private static readonly byte[][] NewLineFormats;

	internal const int MaximumLineLength = 998;

	internal const int MinimumLineLength = 60;

	private const int DefaultMaxLineLength = 78;

	private ParameterEncodingMethod parameterEncodingMethod;

	private bool alwaysQuoteParameterValues;

	private bool allowMixedHeaderCharsets;

	private NewLineFormat newLineFormat;

	private bool verifyingSignature;

	private bool ensureNewLine;

	private bool international;

	private int maxLineLength;

	public static readonly FormatOptions Default;

	public int MaxLineLength
	{
		get
		{
			return maxLineLength;
		}
		set
		{
			if (this == Default)
			{
				throw new InvalidOperationException("The default formatting options cannot be changed.");
			}
			if (value < 60 || value > 998)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			maxLineLength = value;
		}
	}

	public NewLineFormat NewLineFormat
	{
		get
		{
			return newLineFormat;
		}
		set
		{
			if (this == Default)
			{
				throw new InvalidOperationException("The default formatting options cannot be changed.");
			}
			NewLineFormat newLineFormat = this.newLineFormat;
			if (newLineFormat <= NewLineFormat.Dos)
			{
				this.newLineFormat = value;
				return;
			}
			throw new ArgumentOutOfRangeException("value");
		}
	}

	public bool EnsureNewLine
	{
		get
		{
			return ensureNewLine;
		}
		set
		{
			if (this == Default)
			{
				throw new InvalidOperationException("The default formatting options cannot be changed.");
			}
			ensureNewLine = value;
		}
	}

	internal string NewLine
	{
		get
		{
			if (NewLineFormat != NewLineFormat.Unix)
			{
				return "\r\n";
			}
			return "\n";
		}
	}

	internal byte[] NewLineBytes => NewLineFormats[(uint)NewLineFormat];

	internal bool VerifyingSignature
	{
		get
		{
			return verifyingSignature;
		}
		set
		{
			verifyingSignature = value;
		}
	}

	public HashSet<HeaderId> HiddenHeaders { get; private set; }

	public bool International
	{
		get
		{
			return international;
		}
		set
		{
			if (this == Default)
			{
				throw new InvalidOperationException("The default formatting options cannot be changed.");
			}
			international = value;
		}
	}

	public bool AllowMixedHeaderCharsets
	{
		get
		{
			return allowMixedHeaderCharsets;
		}
		set
		{
			if (this == Default)
			{
				throw new InvalidOperationException("The default formatting options cannot be changed.");
			}
			allowMixedHeaderCharsets = value;
		}
	}

	public ParameterEncodingMethod ParameterEncodingMethod
	{
		get
		{
			return parameterEncodingMethod;
		}
		set
		{
			if (this == Default)
			{
				throw new InvalidOperationException("The default formatting options cannot be changed.");
			}
			if ((uint)(value - 1) <= 1u)
			{
				parameterEncodingMethod = value;
				return;
			}
			throw new ArgumentOutOfRangeException("value");
		}
	}

	public bool AlwaysQuoteParameterValues
	{
		get
		{
			return alwaysQuoteParameterValues;
		}
		set
		{
			if (this == Default)
			{
				throw new InvalidOperationException("The default formatting options cannot be changed.");
			}
			alwaysQuoteParameterValues = value;
		}
	}

	internal IMimeFilter CreateNewLineFilter(bool ensureNewLine = false)
	{
		if (NewLineFormat == NewLineFormat.Unix)
		{
			return new Dos2UnixFilter(ensureNewLine);
		}
		return new Unix2DosFilter(ensureNewLine);
	}

	static FormatOptions()
	{
		NewLineFormats = new byte[2][]
		{
			new byte[1] { 10 },
			new byte[2] { 13, 10 }
		};
		Default = new FormatOptions();
	}

	public FormatOptions()
	{
		HiddenHeaders = new HashSet<HeaderId>();
		parameterEncodingMethod = ParameterEncodingMethod.Rfc2231;
		alwaysQuoteParameterValues = false;
		maxLineLength = 78;
		allowMixedHeaderCharsets = false;
		ensureNewLine = false;
		international = false;
		if (Environment.NewLine.Length == 1)
		{
			newLineFormat = NewLineFormat.Unix;
		}
		else
		{
			newLineFormat = NewLineFormat.Dos;
		}
	}

	public FormatOptions Clone()
	{
		FormatOptions formatOptions = new FormatOptions();
		formatOptions.maxLineLength = maxLineLength;
		formatOptions.newLineFormat = newLineFormat;
		formatOptions.ensureNewLine = ensureNewLine;
		formatOptions.HiddenHeaders = new HashSet<HeaderId>(HiddenHeaders);
		formatOptions.allowMixedHeaderCharsets = allowMixedHeaderCharsets;
		formatOptions.parameterEncodingMethod = parameterEncodingMethod;
		formatOptions.alwaysQuoteParameterValues = alwaysQuoteParameterValues;
		formatOptions.verifyingSignature = verifyingSignature;
		formatOptions.international = international;
		return formatOptions;
	}

	internal static FormatOptions CloneDefault()
	{
		lock (Default)
		{
			return Default.Clone();
		}
	}
}
