using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Parsing.Implementation;

public class ParseRequest : IParseRequest
{
	public const int HighPriority = 300;

	public const int MediumPriority = 200;

	public const int LowPriority = 100;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private DateTime JT2;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ISyntaxLanguage jTm;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string VTc;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IParser pTh;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int fTd;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int STL;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextSnapshot wTq;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string HTs;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ParseRequestState NTI;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object fT7;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IParseTarget HTM;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ITextBufferReader oTw;

	internal static ParseRequest v1r;

	public DateTime CreatedDateTime
	{
		[CompilerGenerated]
		get
		{
			return JT2;
		}
		[CompilerGenerated]
		private set
		{
			JT2 = value;
		}
	}

	public ISyntaxLanguage Language
	{
		[CompilerGenerated]
		get
		{
			return jTm;
		}
		[CompilerGenerated]
		private set
		{
			jTm = value;
		}
	}

	public string ParseHashKey
	{
		[CompilerGenerated]
		get
		{
			return VTc;
		}
		[CompilerGenerated]
		private set
		{
			VTc = value;
		}
	}

	public IParser Parser
	{
		[CompilerGenerated]
		get
		{
			return pTh;
		}
		[CompilerGenerated]
		private set
		{
			pTh = value;
		}
	}

	public int Priority
	{
		[CompilerGenerated]
		get
		{
			return fTd;
		}
		[CompilerGenerated]
		set
		{
			fTd = value;
		}
	}

	public int RepeatedRequestPause
	{
		[CompilerGenerated]
		get
		{
			return STL;
		}
		[CompilerGenerated]
		set
		{
			STL = value;
		}
	}

	public ITextSnapshot Snapshot
	{
		[CompilerGenerated]
		get
		{
			return wTq;
		}
		[CompilerGenerated]
		set
		{
			wTq = value;
		}
	}

	public string SourceKey
	{
		[CompilerGenerated]
		get
		{
			return HTs;
		}
		[CompilerGenerated]
		private set
		{
			HTs = value;
		}
	}

	public ParseRequestState State
	{
		[CompilerGenerated]
		get
		{
			return NTI;
		}
		[CompilerGenerated]
		set
		{
			NTI = value;
		}
	}

	public object Tag
	{
		[CompilerGenerated]
		get
		{
			return fT7;
		}
		[CompilerGenerated]
		set
		{
			fT7 = value;
		}
	}

	public IParseTarget Target
	{
		[CompilerGenerated]
		get
		{
			return HTM;
		}
		[CompilerGenerated]
		private set
		{
			HTM = value;
		}
	}

	public ITextBufferReader TextBufferReader
	{
		[CompilerGenerated]
		get
		{
			return oTw;
		}
		[CompilerGenerated]
		private set
		{
			oTw = value;
		}
	}

	public ParseRequest(string sourceKey, ITextBufferReader textBufferReader, IParser parser, IParseTarget parseTarget)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (sourceKey != null)
		{
			if (textBufferReader != null)
			{
				if (parser == null)
				{
					throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7756));
				}
				State = ParseRequestState.Created;
				CreatedDateTime = DateTime.Now;
				Priority = 200;
				ParseHashKey = string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7772), new object[2]
				{
					sourceKey,
					(parseTarget != null) ? parseTarget.UniqueId.ToString() : string.Empty
				});
				RepeatedRequestPause = 250;
				int num = 0;
				if (1 == 0)
				{
					int num2;
					num = num2;
				}
				switch (num)
				{
				}
				SourceKey = sourceKey;
				TextBufferReader = textBufferReader;
				Parser = parser;
				Target = parseTarget;
				return;
			}
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7720));
		}
		throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7698));
	}

	public ParseRequest(string sourceKey, ITextBufferReader textBufferReader, ISyntaxLanguage language, IParseTarget parseTarget)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(sourceKey, textBufferReader, language?.GetService<IParser>(), parseTarget);
		Language = language;
	}

	public static string GetParseHashKey(ICodeDocument document)
	{
		if (document == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5516));
		}
		string text = (string.IsNullOrEmpty(document.FileName) ? document.UniqueId.ToString() : document.FileName);
		return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7772), new object[2] { text, document.UniqueId });
	}

	internal static bool a1j()
	{
		return v1r == null;
	}

	internal static ParseRequest B1K()
	{
		return v1r;
	}
}
