using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class TextVersion : ITextVersion
{
	private TextVersion IdM;

	private IList<ITextChangeRangedOperation> idw;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextDocument LdH;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int EdP;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int Ydp;

	private static TextVersion l2j;

	public ITextDocument Document
	{
		[CompilerGenerated]
		get
		{
			return LdH;
		}
		[CompilerGenerated]
		private set
		{
			LdH = value;
		}
	}

	public int Length
	{
		[CompilerGenerated]
		get
		{
			return EdP;
		}
		[CompilerGenerated]
		private set
		{
			EdP = value;
		}
	}

	public ITextVersion Next => IdM;

	public int Number
	{
		[CompilerGenerated]
		get
		{
			return Ydp;
		}
		[CompilerGenerated]
		private set
		{
			Ydp = value;
		}
	}

	public IList<ITextChangeRangedOperation> Operations => idw;

	internal TextVersion(ITextDocument document, int number, int length)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		Document = document;
		Number = number;
		Length = length;
	}

	internal void ClearNext()
	{
		idw = null;
		IdM = null;
	}

	internal TextVersion CreateNext()
	{
		idw = new ITextChangeRangedOperation[0];
		int number = ((Number >= 2147483646) ? int.MinValue : (Number + 1));
		IdM = new TextVersion(Document, number, Length);
		return IdM;
	}

	internal TextVersion CreateNext(ITextChange textChange)
	{
		if (textChange == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5454));
		}
		if (textChange.Operations == null || textChange.Operations.Count == 0)
		{
			throw new ArgumentException(SR.GetString(SRName.ExTextChangeRequiresOneOperation), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5454));
		}
		int num = 0;
		IList<ITextChangeOperation> operations = textChange.Operations;
		List<ITextChangeRangedOperation> list = new List<ITextChangeRangedOperation>();
		for (int i = 0; i < operations.Count; i++)
		{
			num += operations[i].LengthDelta;
			list.Add(new VersionedTextChangeOperation(operations[i]));
		}
		idw = new ReadOnlyCollection<ITextChangeRangedOperation>(list);
		int number = ((Number >= 2147483646) ? int.MinValue : (Number + 1));
		IdM = new TextVersion(Document, number, Length + num);
		return IdM;
	}

	public ITextVersionRange CreateRange(int startOffset, int length)
	{
		return CreateRange(TextRange.FromSpan(startOffset, length), TextRangeTrackingModes.Default);
	}

	public ITextVersionRange CreateRange(int startOffset, int length, TextRangeTrackingModes trackingModes)
	{
		return CreateRange(TextRange.FromSpan(startOffset, length), trackingModes);
	}

	public ITextVersionRange CreateRange(TextRange textRange)
	{
		return CreateRange(textRange, TextRangeTrackingModes.Default);
	}

	public ITextVersionRange CreateRange(TextRange textRange, TextRangeTrackingModes trackingModes)
	{
		return new TextVersionRange(this, textRange, trackingModes);
	}

	public ITextVersionRange CreateRange(TextRange textRange, Func<TextRangeTrackingModes> trackingModesFunc)
	{
		return new TextVersionRangeExtended(this, textRange, trackingModesFunc);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9954), new object[1] { Number });
	}

	internal static bool Q2K()
	{
		return l2j == null;
	}

	internal static TextVersion W2l()
	{
		return l2j;
	}
}
