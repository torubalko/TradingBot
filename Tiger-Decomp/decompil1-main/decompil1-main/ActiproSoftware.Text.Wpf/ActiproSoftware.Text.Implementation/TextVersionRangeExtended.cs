using System;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class TextVersionRangeExtended : ITextVersionRange
{
	private TextRange Tdj;

	private ITextVersion DdF;

	private Func<TextRangeTrackingModes> Pdx;

	private static TextVersionRangeExtended b26;

	public ITextDocument Document => DdF.Document;

	public TextRangeTrackingModes TrackingModes => Pdx();

	public TextVersionRangeExtended(ITextVersion version, TextRange textRange, Func<TextRangeTrackingModes> trackingModesFunc)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (version == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9990));
		}
		if (trackingModesFunc == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(10008));
		}
		DdF = version;
		Tdj = textRange.NormalizedTextRange;
		Pdx = trackingModesFunc;
	}

	public override bool Equals(object obj)
	{
		if (obj is TextVersionRangeExtended textVersionRangeExtended)
		{
			return DdF == textVersionRangeExtended.DdF && Tdj.Equals(textVersionRangeExtended.Tdj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Tdj.GetHashCode();
	}

	public TextSnapshotRange Translate(ITextSnapshot toSnapshot)
	{
		if (toSnapshot == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1652));
		}
		return new TextSnapshotRange(toSnapshot, Translate(toSnapshot.Version));
	}

	public TextRange Translate(ITextVersion toVersion)
	{
		if (toVersion != null)
		{
			TextRange result;
			if (toVersion == DdF)
			{
				result = Tdj;
			}
			else if (toVersion.Number > DdF.Number)
			{
				Tdj = Tdj.Translate(DdF, toVersion, TrackingModes);
				DdF = toVersion;
				result = Tdj;
			}
			else
			{
				result = Tdj.Translate(DdF, toVersion, TrackingModes);
				int num = 0;
				if (r2G() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			return result;
		}
		throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1546));
	}

	internal static bool x2E()
	{
		return b26 == null;
	}

	internal static TextVersionRangeExtended r2G()
	{
		return b26;
	}
}
