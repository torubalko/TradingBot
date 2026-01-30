using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class VersionedTextChangeOperation : ITextChangeRangedOperation
{
	private int fdg;

	private TextPosition tdO;

	private int odl;

	private TextPosition mdi;

	private bool BdW;

	private int od5;

	private TextPosition Gd6;

	internal static VersionedTextChangeOperation h2h;

	public int DeletionEndOffset => fdg;

	public TextPosition DeletionEndPosition => tdO;

	public int DeletionLength => fdg - od5;

	public bool HasDeletion => DeletionLength > 0;

	public bool HasInsertion => InsertionLength > 0;

	public int InsertionEndOffset => odl;

	public TextPosition InsertionEndPosition => mdi;

	public int InsertionLength => odl - od5;

	public bool IsIgnoredForTranslation => BdW;

	public int LengthDelta => InsertionLength - DeletionLength;

	public int LinesDeleted => tdO.Line - Gd6.Line;

	public int LinesDelta => LinesInserted - LinesDeleted;

	public int LinesInserted => mdi.Line - Gd6.Line;

	public int StartOffset => od5;

	public TextPosition StartPosition => Gd6;

	internal VersionedTextChangeOperation(ITextChangeOperation operation)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		fdg = operation.DeletionEndOffset;
		tdO = operation.DeletionEndPosition;
		odl = operation.InsertionEndOffset;
		mdi = operation.InsertionEndPosition;
		BdW = operation.IsIgnoredForTranslation;
		od5 = operation.StartOffset;
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		Gd6 = operation.StartPosition;
	}

	public override string ToString()
	{
		if (HasInsertion)
		{
			if (!HasDeletion)
			{
				return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8960) + od5 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(10046) + InsertionLength + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
			}
			return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8828) + od5 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8888) + DeletionLength + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(10046) + InsertionLength + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
		}
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9018) + od5 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8888) + DeletionLength + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	internal static bool a2Q()
	{
		return h2h == null;
	}

	internal static VersionedTextChangeOperation R2x()
	{
		return h2h;
	}
}
