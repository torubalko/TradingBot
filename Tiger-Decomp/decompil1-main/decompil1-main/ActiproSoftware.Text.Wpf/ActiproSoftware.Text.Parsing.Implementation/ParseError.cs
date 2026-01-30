using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Parsing.Implementation;

public class ParseError : IParseError
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IClassificationType k8G;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string X8e;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ParseErrorLevel S8y;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextPositionRange I8z;

	internal static ParseError V1s;

	public IClassificationType ClassificationType
	{
		[CompilerGenerated]
		get
		{
			return k8G;
		}
		[CompilerGenerated]
		set
		{
			k8G = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return X8e;
		}
		[CompilerGenerated]
		set
		{
			X8e = value;
		}
	}

	public ParseErrorLevel Level
	{
		[CompilerGenerated]
		get
		{
			return S8y;
		}
		[CompilerGenerated]
		set
		{
			S8y = value;
		}
	}

	public TextPositionRange PositionRange
	{
		[CompilerGenerated]
		get
		{
			return I8z;
		}
		[CompilerGenerated]
		set
		{
			I8z = value;
		}
	}

	public ParseError()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(ParseErrorLevel.Error, null, TextPositionRange.Empty);
	}

	public ParseError(ParseErrorLevel level, string description, TextPositionRange positionRange)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		Level = level;
		Description = description;
		int num = 0;
		if (1 == 0)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		PositionRange = positionRange;
		switch (level)
		{
		case ParseErrorLevel.Warning:
			ClassificationType = ClassificationTypes.Warning;
			break;
		case ParseErrorLevel.Error:
			ClassificationType = ClassificationTypes.SyntaxError;
			break;
		}
	}

	public override bool Equals(object obj)
	{
		if (obj is ParseError parseError)
		{
			return ClassificationType == parseError.ClassificationType && Description == parseError.Description && Level == parseError.Level && PositionRange == parseError.PositionRange;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (Description != null) ? Description.GetHashCode() : base.GetHashCode();
	}

	public override string ToString()
	{
		return Level.ToString() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7690) + Description + (PositionRange.IsEmpty ? string.Empty : (WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7682) + (PositionRange.StartPosition.Line + 1) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1904) + (PositionRange.StartPosition.Character + 1) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6120)));
	}

	internal static bool K14()
	{
		return V1s == null;
	}

	internal static ParseError M1u()
	{
		return V1s;
	}
}
