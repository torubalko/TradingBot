using System.Collections.Generic;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Analysis;

namespace ActiproSoftware.Internal;

internal class iTm
{
	private Stack<TextSnapshotRange> SYG;

	internal static iTm CAk;

	private static TextSnapshotRange yYW(TextSnapshotRange P_0)
	{
		if (!P_0.IsDeleted && P_0.Snapshot.Document is ICodeDocument codeDocument)
		{
			int num = 0;
			if (!UAZ())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (codeDocument.Language != null)
			{
				ICodeBlockFinder codeBlockFinder = codeDocument.Language.GetCodeBlockFinder();
				if (codeBlockFinder != null)
				{
					return codeBlockFinder.FindContaining(P_0);
				}
			}
		}
		return TextSnapshotRange.Deleted;
	}

	private TextSnapshotRange XYP()
	{
		if (SYG != null)
		{
			TextSnapshotRange result = SYG.Pop();
			if (SYG.Count == 0)
			{
				IYc();
			}
			return result;
		}
		return TextSnapshotRange.Deleted;
	}

	private void RYE(TextSnapshotRange P_0)
	{
		if (SYG == null)
		{
			SYG = new Stack<TextSnapshotRange>();
		}
		SYG.Push(P_0);
	}

	public void IYc()
	{
		SYG = null;
	}

	public TextSnapshotRange xYa()
	{
		return XYP();
	}

	public TextSnapshotRange QYx(TextSnapshotRange P_0)
	{
		TextSnapshotRange result = yYW(P_0);
		if (!result.IsDeleted)
		{
			RYE(P_0);
			return result;
		}
		return result;
	}

	public iTm()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool UAZ()
	{
		return CAk == null;
	}

	internal static iTm RAF()
	{
		return CAk;
	}
}
