using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class TextVersionRange : ITextVersionRange
{
	private TextRange GdC;

	private ITextVersion HdU;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextRangeTrackingModes Fda;

	private static TextVersionRange V2o;

	public ITextDocument Document => HdU.Document;

	public TextRangeTrackingModes TrackingModes
	{
		[CompilerGenerated]
		get
		{
			return Fda;
		}
		[CompilerGenerated]
		private set
		{
			Fda = value;
		}
	}

	public TextVersionRange(ITextVersion version, TextRange textRange, TextRangeTrackingModes trackingModes)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (version == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9990));
		}
		HdU = version;
		GdC = textRange.NormalizedTextRange;
		TrackingModes = trackingModes;
	}

	public override bool Equals(object obj)
	{
		if (obj is TextVersionRange textVersionRange)
		{
			return HdU == textVersionRange.HdU && GdC.Equals(textVersionRange.GdC);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return GdC.GetHashCode();
	}

	public TextSnapshotRange Translate(ITextSnapshot toSnapshot)
	{
		if (toSnapshot == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1652));
		}
		TextSnapshotRange textSnapshotRange = new TextSnapshotRange(toSnapshot, Translate(toSnapshot.Version));
		int num;
		if (!textSnapshotRange.IsDeleted)
		{
			num = 1;
			if (N2H() != null)
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_00ce;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				if ((TrackingModes & TextRangeTrackingModes.LineBased) != TextRangeTrackingModes.LineBased)
				{
					break;
				}
				TextRange textRange = textSnapshotRange.EndLine.TextRange;
				if (!(textSnapshotRange != textRange))
				{
					break;
				}
				textSnapshotRange = new TextSnapshotRange(toSnapshot, textSnapshotRange.EndLine.TextRange);
				if (toSnapshot.Version.Number < HdU.Number)
				{
					break;
				}
				goto IL_0076;
			}
			}
			break;
			IL_0076:
			GdC = textSnapshotRange;
			HdU = toSnapshot.Version;
			num = 0;
			if (N2H() == null)
			{
				continue;
			}
			goto IL_0005;
		}
		goto IL_00ce;
		IL_00ce:
		return textSnapshotRange;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	public TextRange Translate(ITextVersion toVersion)
	{
		if (toVersion == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1546));
		}
		if (toVersion == HdU)
		{
			return GdC;
		}
		if (toVersion.Number > HdU.Number)
		{
			GdC = GdC.Translate(HdU, toVersion, TrackingModes);
			HdU = toVersion;
			return GdC;
		}
		return GdC.Translate(HdU, toVersion, TrackingModes);
	}

	internal static bool U2I()
	{
		return V2o == null;
	}

	internal static TextVersionRange N2H()
	{
		return V2o;
	}
}
