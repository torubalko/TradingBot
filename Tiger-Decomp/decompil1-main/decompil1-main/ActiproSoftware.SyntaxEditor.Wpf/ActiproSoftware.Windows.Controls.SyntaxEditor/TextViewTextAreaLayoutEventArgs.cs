using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public class TextViewTextAreaLayoutEventArgs : TextViewEventArgs
{
	private ITextViewLine[] cX9;

	private ITextViewLine[] eXy;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool FXq;

	private static TextViewTextAreaLayoutEventArgs nDi;

	public IEnumerable<ITextViewLine> AddedOrUpdatedViewLines => eXy.Where((ITextViewLine l) => l.Change == TextViewLineChange.AddedOrUpdated);

	public bool HadSnapshotChange
	{
		[CompilerGenerated]
		get
		{
			return FXq;
		}
		[CompilerGenerated]
		private set
		{
			FXq = value;
		}
	}

	public IEnumerable<ITextViewLine> RemovedViewLines => cX9;

	public IEnumerable<ITextViewLine> TranslatedViewLines => eXy.Where((ITextViewLine l) => l.Change == TextViewLineChange.Translated);

	public TextViewTextAreaLayoutEventArgs(ITextView view)
	{
		grA.DaB7cz();
		this._002Ector(view, null, hadSnapshotChange: false);
		if (eXy == null)
		{
			return;
		}
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		ITextViewLine[] array = eXy;
		for (int i = 0; i < array.Length; i++)
		{
			DAp dAp = (DAp)array[i];
			dAp.Change = TextViewLineChange.None;
		}
	}

	internal TextViewTextAreaLayoutEventArgs(ITextView view, IEnumerable<ITextViewLine> removedViewLines, bool hadSnapshotChange)
	{
		grA.DaB7cz();
		base._002Ector(view);
		eXy = view.VisibleViewLines.ToArray();
		if (removedViewLines != null)
		{
			cX9 = removedViewLines.ToArray();
		}
		else
		{
			cX9 = new ITextViewLine[0];
		}
		HadSnapshotChange = hadSnapshotChange;
	}

	internal static bool RD2()
	{
		return nDi == null;
	}

	internal static TextViewTextAreaLayoutEventArgs oDV()
	{
		return nDi;
	}
}
