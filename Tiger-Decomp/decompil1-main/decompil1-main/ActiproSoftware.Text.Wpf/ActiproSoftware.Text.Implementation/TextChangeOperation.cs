using System;
using ActiproSoftware.Text.StringTrees;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

internal class TextChangeOperation : ITextChangeOperation, ITextChangeRangedOperation
{
	[Flags]
	private enum MD
	{

	}

	private class x1
	{
		private MD tsn;

		internal static x1 AM7;

		internal bool fst(MD P_0)
		{
			return (tsn & P_0) == P_0;
		}

		internal void nsQ(MD P_0, bool P_1)
		{
			if (P_1)
			{
				tsn |= P_0;
			}
			else
			{
				tsn &= ~P_0;
			}
		}

		public x1()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal static bool CMJ()
		{
			return AM7 == null;
		}

		internal static x1 zMy()
		{
			return AM7;
		}
	}

	private string Wcr;

	private TextPosition oc3;

	private int scJ;

	private string LcX;

	private TextPosition HcN;

	private x1 lcR;

	private int Jcf;

	private TextPosition pct;

	private static TextChangeOperation wUB;

	public string DeletedText => Wcr;

	public int DeletionEndOffset => Jcf + scJ;

	public TextPosition DeletionEndPosition => oc3;

	public int DeletionLength => scJ;

	public bool HasDeletion => scJ > 0;

	public bool HasInsertion => LcX.Length > 0;

	public string InsertedText => LcX;

	public int InsertionEndOffset => Jcf + LcX.Length;

	public TextPosition InsertionEndPosition => HcN;

	public int InsertionLength => LcX.Length;

	public bool IsIgnoredForTranslation => lcR.fst((MD)4);

	public bool IsProgrammaticTextReplacement => lcR.fst((MD)2);

	public bool IsTextReplacement => lcR.fst((MD)1);

	public int LengthDelta => LcX.Length - scJ;

	public int LinesDeleted => oc3.Line - pct.Line;

	public int LinesDelta => LinesInserted - LinesDeleted;

	public int LinesInserted => HcN.Line - pct.Line;

	public int StartOffset => Jcf;

	public TextPosition StartPosition => pct;

	internal TextChangeOperation(int startOffset, int deletionLength, string insertedText, bool isTextReplacement, bool isProgrammaticTextReplacement, bool isIgnoredForTranslation)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		lcR = new x1();
		base._002Ector();
		if (insertedText == null)
		{
			insertedText = string.Empty;
		}
		Jcf = startOffset;
		scJ = deletionLength;
		int num = 1;
		if (false)
		{
			int num2;
			num = num2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Wcr = string.Empty;
				LcX = insertedText;
				if (isTextReplacement)
				{
					lcR.nsQ((MD)1, _0020: true);
				}
				if (isProgrammaticTextReplacement)
				{
					num = 0;
					if (1 == 0)
					{
						num = 0;
					}
					break;
				}
				goto IL_0081;
			default:
				{
					lcR.nsQ((MD)2, _0020: true);
					goto IL_0081;
				}
				IL_0081:
				if (isIgnoredForTranslation)
				{
					lcR.nsQ((MD)4, _0020: true);
				}
				return;
			}
		}
	}

	internal TextChangeOperation(IStringTreeNode textData, int startOffset, string deletedText, string insertedText, bool isTextReplacement, bool isProgrammaticTextReplacement, bool isIgnoredForTranslation)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		lcR = new x1();
		base._002Ector();
		if (deletedText == null)
		{
			deletedText = string.Empty;
		}
		if (insertedText == null)
		{
			insertedText = string.Empty;
		}
		Jcf = startOffset;
		scJ = deletedText.Length;
		Wcr = deletedText;
		LcX = insertedText;
		if (isTextReplacement)
		{
			lcR.nsQ((MD)1, _0020: true);
		}
		if (isProgrammaticTextReplacement)
		{
			lcR.nsQ((MD)2, _0020: true);
		}
		if (isIgnoredForTranslation)
		{
			lcR.nsQ((MD)4, _0020: true);
		}
		int num = deletedText.IndexOf('\n');
		int num2 = 0;
		while (num != -1)
		{
			num2++;
			num = deletedText.IndexOf('\n', num + 1);
		}
		int length = deletedText.Length;
		int num3 = length;
		num = deletedText.LastIndexOf('\n');
		if (num != -1)
		{
			num3 -= num + 1;
		}
		num = insertedText.IndexOf('\n');
		int num4 = 0;
		while (num != -1)
		{
			num4++;
			num = insertedText.IndexOf('\n', num + 1);
		}
		int length2 = insertedText.Length;
		int num5 = length2;
		num = insertedText.LastIndexOf('\n');
		if (num != -1)
		{
			num5 -= num + 1;
		}
		int lineIndex = textData.GetLineIndex(startOffset);
		pct = new TextPosition(lineIndex, startOffset - textData.GetLineTextRange(lineIndex).StartOffset);
		oc3 = new TextPosition(lineIndex + num2, ((num2 <= 0) ? pct.Character : 0) + num3);
		HcN = new TextPosition(lineIndex + num4, ((num4 <= 0) ? pct.Character : 0) + num5);
		if (startOffset == 0 && (textData.Length == 0 || (length > 0 && length == textData.Length)))
		{
			lcR.nsQ((MD)1, _0020: true);
		}
	}

	internal bool Merge(ITextChangeOperation nextOperation)
	{
		if (nextOperation.DeletionLength == 0 && nextOperation.LinesInserted == 0 && InsertionEndOffset == nextOperation.StartOffset)
		{
			LcX += nextOperation.InsertedText;
			HcN = new TextPosition(HcN.Line, HcN.Character + nextOperation.InsertionLength);
			return true;
		}
		return false;
	}

	internal static string ScrubInsertedText(string insertedText)
	{
		if (insertedText != null && insertedText.IndexOf('\r') != -1)
		{
			return insertedText.Replace(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5358), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5366)).Replace('\r', '\n');
		}
		return insertedText;
	}

	public override string ToString()
	{
		if (HasInsertion)
		{
			string text = LcX.Split('\n')[0];
			if (HasDeletion)
			{
				return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8828) + Jcf + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8888) + DeletionLength + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8926) + text + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
			}
			return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8960) + Jcf + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8926) + text + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
		}
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9018) + Jcf + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8888) + DeletionLength + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	internal static bool zUz()
	{
		return wUB == null;
	}

	internal static TextChangeOperation u2d()
	{
		return wUB;
	}
}
