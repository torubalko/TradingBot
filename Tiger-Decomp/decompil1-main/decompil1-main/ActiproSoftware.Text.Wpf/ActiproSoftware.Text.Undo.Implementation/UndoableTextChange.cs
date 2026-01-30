using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Products.Text;
using ActiproSoftware.Text.Implementation;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Undo.Implementation;

internal class UndoableTextChange : IUndoableTextChange
{
	private List<ITextChangeOperation> dBF;

	internal const int TypingPreviewTextMaxLength = 20;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private UndoHistory.LineUndoVersionSet cBx;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object nBg;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool nBO;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ITextPositionRangeCollection zBl;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ITextPositionRangeCollection QBi;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool iBW;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextChangeType iB5;

	internal static UndoableTextChange Jn1;

	internal UndoHistory.LineUndoVersionSet VersionSet
	{
		[CompilerGenerated]
		get
		{
			return cBx;
		}
		[CompilerGenerated]
		set
		{
			cBx = value;
		}
	}

	public object CustomData
	{
		[CompilerGenerated]
		get
		{
			return nBg;
		}
		[CompilerGenerated]
		private set
		{
			nBg = value;
		}
	}

	public string Description
	{
		get
		{
			if (Type == TextChangeTypes.Typing && dBF.Count > 0)
			{
				int num = 0;
				if (!fn5())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				ITextChangeOperation textChangeOperation = dBF[dBF.Count - 1];
				if (textChangeOperation.InsertionLength > 0)
				{
					return string.Concat(str2: ((textChangeOperation.InsertionLength <= 20) ? textChangeOperation.InsertedText : (textChangeOperation.InsertedText.Substring(0, 20) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5478))).Replace('\n', ' '), str0: Type.Description, str1: WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5488), str3: WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5496));
				}
			}
			return Type.Description;
		}
	}

	public bool IsMerged
	{
		[CompilerGenerated]
		get
		{
			return nBO;
		}
		[CompilerGenerated]
		private set
		{
			nBO = value;
		}
	}

	public IList<ITextChangeOperation> Operations => new ReadOnlyCollection<ITextChangeOperation>(dBF);

	public ITextPositionRangeCollection PostSelectionPositionRanges
	{
		[CompilerGenerated]
		get
		{
			return zBl;
		}
		[CompilerGenerated]
		set
		{
			zBl = value;
		}
	}

	public ITextPositionRangeCollection PreSelectionPositionRanges
	{
		[CompilerGenerated]
		get
		{
			return QBi;
		}
		[CompilerGenerated]
		set
		{
			QBi = value;
		}
	}

	public bool RetainSelection
	{
		[CompilerGenerated]
		get
		{
			return iBW;
		}
		[CompilerGenerated]
		private set
		{
			iBW = value;
		}
	}

	public ITextChangeType Type
	{
		[CompilerGenerated]
		get
		{
			return iB5;
		}
		[CompilerGenerated]
		private set
		{
			iB5 = value;
		}
	}

	internal UndoableTextChange(ITextChange textChange, UndoHistory.LineUndoVersionSet versionSet)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		dBF = new List<ITextChangeOperation>();
		base._002Ector();
		if (textChange == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5454));
		}
		if (textChange.Operations == null || textChange.Operations.Count == 0)
		{
			throw new ArgumentException(SR.GetString(SRName.ExTextChangeRequiresOneOperation), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5454));
		}
		CustomData = textChange.CustomData;
		IsMerged = textChange.IsMerged;
		PostSelectionPositionRanges = textChange.PostSelectionPositionRanges;
		PreSelectionPositionRanges = textChange.PreSelectionPositionRanges;
		RetainSelection = textChange.RetainSelection;
		Type = textChange.Type;
		VersionSet = versionSet;
		IList<ITextChangeOperation> operations = textChange.Operations;
		int num = operations.Count - 1;
		while (num >= 0 && !operations[num].IsProgrammaticTextReplacement)
		{
			num--;
		}
		for (num++; num < operations.Count; num++)
		{
			dBF.Add(operations[num]);
		}
	}

	internal bool Merge(ITextChange textChange, UndoHistory.LineUndoVersionSet versionSet, bool force)
	{
		if (Type == TextChangeTypes.Typing && textChange.Type == TextChangeTypes.Typing && textChange.Operations.Count == 1 && textChange.CustomData == null)
		{
			TextChangeOperation textChangeOperation = dBF[dBF.Count - 1] as TextChangeOperation;
			TextChangeOperation textChangeOperation2 = textChange.Operations[0] as TextChangeOperation;
			if (textChangeOperation != null && textChangeOperation2 != null && textChangeOperation.Merge(textChangeOperation2))
			{
				VersionSet.AddRange(versionSet);
				PostSelectionPositionRanges = textChange.PostSelectionPositionRanges;
				return true;
			}
		}
		if (force && textChange.Operations.Count > 0)
		{
			IsMerged = true;
			IList<ITextChangeOperation> operations = textChange.Operations;
			int num;
			for (num = operations.Count - 1; num >= 0; num--)
			{
				if (operations[num].IsProgrammaticTextReplacement)
				{
					dBF.Clear();
					break;
				}
			}
			for (num++; num < operations.Count; num++)
			{
				dBF.Add(operations[num]);
			}
			VersionSet.AddRange(versionSet);
			return true;
		}
		return false;
	}

	internal static bool fn5()
	{
		return Jn1 == null;
	}

	internal static UndoableTextChange xnP()
	{
		return Jn1;
	}
}
