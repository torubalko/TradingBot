using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ActiproSoftware.Products.Text;
using ActiproSoftware.Text.Searching;
using ActiproSoftware.Text.Searching.Implementation;
using ActiproSoftware.Text.StringTrees;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Undo;
using ActiproSoftware.Text.Undo.Implementation;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

public abstract class TextDocumentBase : ITextDocument, INotifyPropertyChanged
{
	private TextVersion bhm;

	private object qhc;

	private IStringTreeNode fhh;

	private EventHandler<TextSnapshotChangedEventArgs> Vhd;

	private EventHandler<TextSnapshotChangedEventArgs> qhL;

	private EventHandler<TextSnapshotChangedEventArgs> Yhq;

	private EventHandler<TextSnapshotChangedEventArgs> Chs;

	private EventHandler<TextSnapshotChangingEventArgs> KhI;

	private EventHandler<TextSnapshotChangingEventArgs> bh7;

	private EventHandler<TextSnapshotChangingEventArgs> KhM;

	private EventHandler<TextSnapshotChangingEventArgs> Whw;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ITextSnapshot FhH;

	private CharacterCasing ahP;

	private bool rhp;

	private bool chb;

	private int GhC;

	private UndoHistory uhU;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler uha;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler xhj;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PropertyChangedEventHandler ehF;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler whx;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool Uhg;

	private string zhO;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<StringPropertyChangedEventArgs> yhl;

	private static TextDocumentBase N2b;

	public ITextSnapshot CurrentSnapshot
	{
		[CompilerGenerated]
		get
		{
			return FhH;
		}
		[CompilerGenerated]
		private set
		{
			FhH = value;
		}
	}

	public CharacterCasing AutoCharacterCasing
	{
		get
		{
			return ahP;
		}
		set
		{
			ahP = value;
		}
	}

	public bool AutoConvertTabsToSpaces
	{
		[CompilerGenerated]
		get
		{
			return Uhg;
		}
		[CompilerGenerated]
		set
		{
			Uhg = value;
		}
	}

	public bool IsModified
	{
		get
		{
			return rhp;
		}
		set
		{
			if (rhp != value)
			{
				rhp = value;
				OnIsModifiedChanged(EventArgs.Empty);
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9076));
			}
		}
	}

	public bool IsReadOnly
	{
		get
		{
			return chb;
		}
		set
		{
			if (chb != value)
			{
				chb = value;
				OnIsReadOnlyChanged(EventArgs.Empty);
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9100));
			}
		}
	}

	public int TabSize
	{
		get
		{
			return GhC;
		}
		set
		{
			if (value < 1)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6008), SR.GetString(SRName.ExTabSizeMinimum));
			}
			if (GhC != value)
			{
				GhC = value;
				OnTabSizeChanged(EventArgs.Empty);
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9124));
			}
		}
	}

	public IUndoHistory UndoHistory => uhU;

	public string FileName
	{
		get
		{
			return zhO;
		}
		set
		{
			if (!(zhO == value))
			{
				string oldValue = zhO;
				zhO = value;
				OnFileNameChanged(new StringPropertyChangedEventArgs(oldValue, zhO));
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9142));
			}
		}
	}

	public event EventHandler<TextSnapshotChangedEventArgs> TextChanged
	{
		add
		{
			AddTextChangedEventHandler(value, EventHandlerPriority.Medium);
		}
		remove
		{
			RemoveTextChangedEventHandler(value, EventHandlerPriority.Medium);
		}
	}

	public event EventHandler<TextSnapshotChangingEventArgs> TextChanging
	{
		add
		{
			AddTextChangingEventHandler(value, EventHandlerPriority.Medium);
		}
		remove
		{
			RemoveTextChangingEventHandler(value, EventHandlerPriority.Medium);
		}
	}

	public event EventHandler IsModifiedChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = uha;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref uha, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = uha;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref uha, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler IsReadOnlyChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = xhj;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref xhj, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = xhj;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref xhj, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = ehF;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref ehF, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = ehF;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref ehF, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public event EventHandler TabSizeChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = whx;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref whx, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = whx;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref whx, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<StringPropertyChangedEventArgs> FileNameChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<StringPropertyChangedEventArgs> eventHandler = yhl;
			EventHandler<StringPropertyChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<StringPropertyChangedEventArgs> value2 = (EventHandler<StringPropertyChangedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref yhl, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<StringPropertyChangedEventArgs> eventHandler = yhl;
			EventHandler<StringPropertyChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<StringPropertyChangedEventArgs> value2 = (EventHandler<StringPropertyChangedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref yhl, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	private void XhA()
	{
		fhh = LeafStringTreeNode.Create(string.Empty);
		bhm = new TextVersion(this, 0, fhh.Length);
		CurrentSnapshot = new TextSnapshot(bhm, fhh, null, null);
	}

	internal bool ApplyTextChange(TextChange textChange, Action<ITextSnapshot> snapshotCreatedAction = null)
	{
		bool result = false;
		lock (qhc)
		{
			if (textChange.Operations != null && textChange.Operations.Count > 0)
			{
				if (!(CurrentSnapshot is TextSnapshot textSnapshot))
				{
					return false;
				}
				if (textChange.CheckReadOnly)
				{
					if (chb)
					{
						return false;
					}
					int startOffset = Math.Max(0, textChange.Operations.Min((ITextChangeOperation o) => o.StartOffset) - 1);
					if (Thu(GetReadOnlyRegions(new TextRange(startOffset, textSnapshot.Length)), textChange))
					{
						return false;
					}
				}
				IStringTreeNode stringTreeNode = textSnapshot.TextData;
				for (int num = 0; num < textChange.Operations.Count; num++)
				{
					if (!(textChange.Operations[num] is TextChangeOperation textChangeOperation))
					{
						throw new ArgumentException(SR.GetString(SRName.ExTextChangeOperationRequired), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5454));
					}
					TextRange textRange = ((!textChangeOperation.IsTextReplacement) ? TextRange.FromSpan(textChangeOperation.StartOffset, textChangeOperation.DeletionLength).Translate(textChange.Snapshot.Version, textSnapshot.Version, TextRangeTrackingModes.Default, boundsCheck: false) : new TextRange(0, stringTreeNode.Length));
					string deletedText = (textRange.IsZeroLength ? string.Empty : stringTreeNode.ToString(textRange.StartOffset, textRange.EndOffset));
					string text = textChangeOperation.InsertedText ?? string.Empty;
					if (textChangeOperation.IsTextReplacement)
					{
						string textReplacementInsertText = GetTextReplacementInsertText(textChangeOperation);
						if (!string.IsNullOrEmpty(textReplacementInsertText))
						{
							text = textReplacementInsertText;
						}
					}
					TextChangeOperation textChangeOperation2 = new TextChangeOperation(stringTreeNode, textRange.StartOffset, deletedText, text, textChangeOperation.IsTextReplacement, textChangeOperation.IsProgrammaticTextReplacement, textChangeOperation.IsIgnoredForTranslation);
					textChange.ReplaceOperation(num, textChangeOperation2);
					stringTreeNode = stringTreeNode.Replace(textChangeOperation2.StartOffset, textChangeOperation2.DeletionEndOffset, text);
				}
				TextVersion textVersion = bhm.CreateNext(textChange);
				ITextSnapshot textSnapshot2 = new TextSnapshot(textVersion, stringTreeNode, textSnapshot.HeaderText, textSnapshot.FooterText);
				snapshotCreatedAction?.Invoke(textSnapshot2);
				TextSnapshotChangingEventArgs e = new TextSnapshotChangingEventArgs(textSnapshot, textSnapshot2, textChange);
				OnTextChanging(e);
				if (e.Cancel)
				{
					if (bhm.Next == textVersion)
					{
						bhm.ClearNext();
					}
				}
				else
				{
					fhh = stringTreeNode;
					bhm = textVersion;
					CurrentSnapshot = textSnapshot2;
					OnTextChanged(new TextSnapshotChangedEventArgs(textSnapshot, CurrentSnapshot, textChange));
					phT(textChange);
					result = true;
				}
			}
		}
		return result;
	}

	private static bool Thu(IEnumerable<TagSnapshotRange<IReadOnlyRegionTag>> P_0, ITextChange P_1)
	{
		if (P_0 != null && P_0.Any() && P_1 != null && P_1.Operations != null && P_1.Operations.Count > 0)
		{
			TagSnapshotRange<IReadOnlyRegionTag>[] array = P_0.ToArray();
			List<TextRange> list = array.Select((TagSnapshotRange<IReadOnlyRegionTag> r) => r.SnapshotRange.TextRange).ToList();
			foreach (ITextChangeOperation operation in P_1.Operations)
			{
				if (operation == null)
				{
					continue;
				}
				for (int num = 0; num < list.Count; num++)
				{
					IReadOnlyRegionTag tag = array[num].Tag;
					TextRangeTrackingModes trackingModes = (TextRangeTrackingModes)((tag.IncludeFirstEdge ? 1 : 0) | (tag.IncludeLastEdge ? 2 : 0));
					TextRange value = list[num];
					if (value.AdjustForTextChangeOperation(operation, trackingModes))
					{
						return true;
					}
					list[num] = value;
				}
			}
		}
		return false;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void AddTextChangedEventHandler(EventHandler<TextSnapshotChangedEventArgs> handler, EventHandlerPriority priority)
	{
		if (handler == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8644));
		}
		if (handler.Target is ITextDocument)
		{
			Vhd = (EventHandler<TextSnapshotChangedEventArgs>)Delegate.Combine(Vhd, handler);
			return;
		}
		switch (priority)
		{
		case EventHandlerPriority.High:
			qhL = (EventHandler<TextSnapshotChangedEventArgs>)Delegate.Combine(qhL, handler);
			break;
		case EventHandlerPriority.Low:
			Chs = (EventHandler<TextSnapshotChangedEventArgs>)Delegate.Combine(Chs, handler);
			break;
		default:
			Yhq = (EventHandler<TextSnapshotChangedEventArgs>)Delegate.Combine(Yhq, handler);
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void AddTextChangingEventHandler(EventHandler<TextSnapshotChangingEventArgs> handler, EventHandlerPriority priority)
	{
		if (handler == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8644));
		}
		if (handler.Target is ITextDocument)
		{
			KhI = (EventHandler<TextSnapshotChangingEventArgs>)Delegate.Combine(KhI, handler);
			return;
		}
		switch (priority)
		{
		case EventHandlerPriority.High:
			KhM = (EventHandler<TextSnapshotChangingEventArgs>)Delegate.Combine(KhM, handler);
			break;
		case EventHandlerPriority.Low:
			Whw = (EventHandler<TextSnapshotChangingEventArgs>)Delegate.Combine(Whw, handler);
			break;
		default:
			bh7 = (EventHandler<TextSnapshotChangingEventArgs>)Delegate.Combine(bh7, handler);
			break;
		}
	}

	public bool AppendText(ITextChangeType type, string text)
	{
		return AppendText(type, text, null);
	}

	public bool AppendText(ITextChangeType type, string text, ITextChangeOptions options)
	{
		return InsertText(type, CurrentSnapshot.Length, text, options);
	}

	public ITextChange CreateTextChange(ITextChangeType type)
	{
		return CurrentSnapshot.CreateTextChange(type);
	}

	public ITextChange CreateTextChange(ITextChangeType type, ITextChangeOptions options)
	{
		return CurrentSnapshot.CreateTextChange(type, options);
	}

	public bool DeleteText(ITextChangeType type, TextRange textRange)
	{
		return DeleteText(type, textRange.FirstOffset, textRange.AbsoluteLength);
	}

	public bool DeleteText(ITextChangeType type, TextRange textRange, ITextChangeOptions options)
	{
		return DeleteText(type, textRange.FirstOffset, textRange.AbsoluteLength, options);
	}

	public bool DeleteText(ITextChangeType type, int offset, int length)
	{
		return DeleteText(type, offset, length, null);
	}

	public bool DeleteText(ITextChangeType type, int offset, int length, ITextChangeOptions options)
	{
		return ReplaceText(type, offset, length, string.Empty, options);
	}

	protected virtual string GetTextReplacementInsertText(ITextChangeOperation operation)
	{
		return null;
	}

	public bool InsertText(ITextChangeType type, int offset, string text)
	{
		return InsertText(type, offset, text, null);
	}

	public bool InsertText(ITextChangeType type, int offset, string text, ITextChangeOptions options)
	{
		return ReplaceText(type, offset, 0, text, options);
	}

	protected virtual void OnTextChanged(TextSnapshotChangedEventArgs e)
	{
		Vhd?.Invoke(this, e);
		qhL?.Invoke(this, e);
		Yhq?.Invoke(this, e);
		Chs?.Invoke(this, e);
	}

	protected virtual void OnTextChanging(TextSnapshotChangingEventArgs e)
	{
		Whw?.Invoke(this, e);
		bh7?.Invoke(this, e);
		KhM?.Invoke(this, e);
		KhI?.Invoke(this, e);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void RemoveTextChangedEventHandler(EventHandler<TextSnapshotChangedEventArgs> handler, EventHandlerPriority priority)
	{
		if (handler == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8644));
		}
		if (handler.Target is ITextDocument)
		{
			Vhd = (EventHandler<TextSnapshotChangedEventArgs>)Delegate.Remove(Vhd, handler);
			return;
		}
		switch (priority)
		{
		case EventHandlerPriority.High:
			qhL = (EventHandler<TextSnapshotChangedEventArgs>)Delegate.Remove(qhL, handler);
			break;
		case EventHandlerPriority.Low:
			Chs = (EventHandler<TextSnapshotChangedEventArgs>)Delegate.Remove(Chs, handler);
			break;
		default:
			Yhq = (EventHandler<TextSnapshotChangedEventArgs>)Delegate.Remove(Yhq, handler);
			break;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public void RemoveTextChangingEventHandler(EventHandler<TextSnapshotChangingEventArgs> handler, EventHandlerPriority priority)
	{
		if (handler == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(8644));
		}
		if (handler.Target is ITextDocument)
		{
			KhI = (EventHandler<TextSnapshotChangingEventArgs>)Delegate.Remove(KhI, handler);
			return;
		}
		switch (priority)
		{
		case EventHandlerPriority.High:
			KhM = (EventHandler<TextSnapshotChangingEventArgs>)Delegate.Remove(KhM, handler);
			break;
		case EventHandlerPriority.Low:
			Whw = (EventHandler<TextSnapshotChangingEventArgs>)Delegate.Remove(Whw, handler);
			break;
		default:
			bh7 = (EventHandler<TextSnapshotChangingEventArgs>)Delegate.Remove(bh7, handler);
			break;
		}
	}

	public bool ReplaceText(ITextChangeType type, TextRange textRange, string text)
	{
		return ReplaceText(type, textRange.FirstOffset, textRange.AbsoluteLength, text);
	}

	public bool ReplaceText(ITextChangeType type, TextRange textRange, string text, ITextChangeOptions options)
	{
		return ReplaceText(type, textRange.FirstOffset, textRange.AbsoluteLength, text, options);
	}

	public bool ReplaceText(ITextChangeType type, int offset, int length, string text)
	{
		return ReplaceText(type, offset, length, text, null);
	}

	public bool ReplaceText(ITextChangeType type, int offset, int length, string text, ITextChangeOptions options)
	{
		ITextChange textChange = CreateTextChange(type, options);
		textChange.ReplaceText(offset, length, text);
		return textChange.Apply();
	}

	public bool SetHeaderAndFooterText(string headerText, string footerText)
	{
		headerText = TextChangeOperation.ScrubInsertedText(headerText ?? string.Empty);
		footerText = TextChangeOperation.ScrubInsertedText(footerText ?? string.Empty);
		ITextSnapshot currentSnapshot = CurrentSnapshot;
		TextVersion textVersion = bhm.CreateNext();
		ITextSnapshot textSnapshot = new TextSnapshot(textVersion, fhh, headerText ?? currentSnapshot.HeaderText, footerText ?? currentSnapshot.FooterText);
		ITextChange textChange = new TextChange(currentSnapshot, TextChangeTypes.HeaderAndFooterChange, new TextChangeOptions());
		TextSnapshotChangingEventArgs e = new TextSnapshotChangingEventArgs(currentSnapshot, textSnapshot, textChange);
		OnTextChanging(e);
		if (e.Cancel)
		{
			if (bhm.Next == textVersion)
			{
				bhm.ClearNext();
			}
			return false;
		}
		bhm = textVersion;
		CurrentSnapshot = textSnapshot;
		OnTextChanged(new TextSnapshotChangedEventArgs(currentSnapshot, CurrentSnapshot, textChange));
		return true;
	}

	public bool SetText(string text)
	{
		ITextChange textChange = CreateTextChange(TextChangeTypes.TextReplacement);
		textChange.SetText(text);
		return textChange.Apply();
	}

	public bool SetText(ITextChangeType type, string text)
	{
		return SetText(type, text, null);
	}

	public bool SetText(ITextChangeType type, string text, ITextChangeOptions options)
	{
		ITextChange textChange = CreateTextChange(type, options);
		textChange.SetText(text, isProgrammatic: false);
		return textChange.Apply();
	}

	protected TextDocumentBase()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		qhc = new object();
		ahP = CharacterCasing.Normal;
		GhC = 4;
		base._002Ector();
		XhA();
		uhU = new UndoHistory(this);
		uhU.UndoRedoRequested += uh8;
	}

	private void uh8(object P_0, UndoRedoRequestEventArgs P_1)
	{
		ITextChangeOperation[] array = new ITextChangeOperation[P_1.TextChange.Operations.Count];
		P_1.TextChange.Operations.CopyTo(array, 0);
		if (P_1.IsUndo)
		{
			Array.Reverse(array);
		}
		ITextChangeOptions options = new TextChangeOptions
		{
			CustomData = P_1.TextChange.CustomData,
			RetainSelection = P_1.TextChange.RetainSelection
		};
		ITextChange textChange = new TextChange(CurrentSnapshot, P_1.TextChange.Type, options, P_1.IsUndo, !P_1.IsUndo, P_1.TextChange.IsMerged);
		try
		{
			textChange.PreSelectionPositionRanges = P_1.TextChange.PreSelectionPositionRanges;
			textChange.PostSelectionPositionRanges = P_1.TextChange.PostSelectionPositionRanges;
			int num = 0;
			int num3 = default(int);
			while (true)
			{
				bool flag = num < array.Length;
				int num2 = 0;
				if (!F21())
				{
					num2 = num3;
				}
				switch (num2)
				{
				}
				if (!flag)
				{
					return;
				}
				ITextChangeOperation textChangeOperation = array[num];
				if (!P_1.IsUndo)
				{
					textChange.ReplaceText(textChangeOperation.StartOffset, textChangeOperation.DeletionLength, textChangeOperation.InsertedText);
				}
				else
				{
					textChange.ReplaceText(textChangeOperation.StartOffset, textChangeOperation.InsertionLength, textChangeOperation.DeletedText);
				}
				num++;
			}
		}
		finally
		{
			P_1.Cancel = !textChange.Apply();
		}
	}

	private void phT(ITextChange P_0)
	{
		if (P_0.Operations.Count > 0 && P_0.Operations[P_0.Operations.Count - 1].IsProgrammaticTextReplacement)
		{
			IsModified = false;
		}
		else
		{
			if (P_0.IsRedo)
			{
				return;
			}
			if (P_0.IsUndo)
			{
				if (uhU.SavePointAvailable == SavePointType.Original && uhU.UndoStack.Count == 0)
				{
					IsModified = false;
				}
				else
				{
					IsModified = uhU.SavePointAvailable != SavePointType.UndoTextChange || !uhU.UndoStack.IsAtSavePoint;
				}
			}
			else
			{
				IsModified = true;
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	protected virtual IEnumerable<TagSnapshotRange<IReadOnlyRegionTag>> GetReadOnlyRegions(TextRange textRange)
	{
		return null;
	}

	public bool IsTextRangeReadOnly(TextRange textRange)
	{
		if (chb)
		{
			return true;
		}
		IEnumerable<TagSnapshotRange<IReadOnlyRegionTag>> readOnlyRegions = GetReadOnlyRegions(textRange);
		if (readOnlyRegions != null && readOnlyRegions.Any())
		{
			TextSnapshotRange range = new TextSnapshotRange(CurrentSnapshot, textRange.NormalizedTextRange);
			foreach (TagSnapshotRange<IReadOnlyRegionTag> item in readOnlyRegions)
			{
				if (item.SnapshotRange.IntersectsWith(range, item.Tag.IncludeFirstEdge, item.Tag.IncludeLastEdge))
				{
					return true;
				}
			}
		}
		return false;
	}

	protected void NotifyPropertyChanged(string name)
	{
		ehF?.Invoke(this, new PropertyChangedEventArgs(name));
	}

	protected virtual void OnIsModifiedChanged(EventArgs e)
	{
		uha?.Invoke(this, e);
	}

	protected virtual void OnIsReadOnlyChanged(EventArgs e)
	{
		xhj?.Invoke(this, e);
	}

	protected virtual void OnTabSizeChanged(EventArgs e)
	{
		whx?.Invoke(this, e);
	}

	public ISearchResultSet ReplaceAll(ISearchOptions options)
	{
		return ReplaceAll(options, CurrentSnapshot.TextRange);
	}

	public ISearchResultSet ReplaceAll(ISearchOptions options, params TextRange[] searchTextRanges)
	{
		return TextSearcher.ReplaceAll(this, null, options, searchTextRanges);
	}

	public ISearchResultSet ReplaceNext(ISearchOptions options, int startOffset, bool canWrap)
	{
		return ReplaceNext(options, startOffset, canWrap, CurrentSnapshot.TextRange);
	}

	public ISearchResultSet ReplaceNext(ISearchOptions options, int startOffset, bool canWrap, TextRange searchTextRange)
	{
		return TextSearcher.ReplaceNext(this, null, options, startOffset, canWrap, searchTextRange);
	}

	public LineTerminator LoadFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9162));
		}
		FileName = path;
		string text;
		using (StreamReader streamReader = File.OpenText(path))
		{
			text = streamReader.ReadToEnd();
		}
		SetText(text);
		return StringHelper.GetLineTerminator(text);
	}

	public LineTerminator LoadFile(string path, Encoding encoding)
	{
		if (path == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9162));
		}
		FileName = path;
		using FileStream stream = File.OpenRead(path);
		return LoadFile(stream, encoding);
	}

	public LineTerminator LoadFile(Stream stream, Encoding encoding)
	{
		if (stream == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9174));
		}
		StreamReader streamReader = new StreamReader(stream, encoding);
		string text = streamReader.ReadToEnd();
		SetText(text);
		return StringHelper.GetLineTerminator(text);
	}

	protected virtual void OnFileNameChanged(StringPropertyChangedEventArgs e)
	{
		yhl?.Invoke(this, e);
	}

	public void SaveFile(string path, LineTerminator lineTerminator)
	{
		if (path == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9162));
		}
		string text = CurrentSnapshot.GetText(lineTerminator);
		using (StreamWriter streamWriter = File.CreateText(path))
		{
			streamWriter.Write(text);
			streamWriter.Flush();
		}
		if (path == zhO)
		{
			IsModified = false;
		}
	}

	public void SaveFile(string path, Encoding encoding, LineTerminator lineTerminator)
	{
		if (path == null)
		{
			int num = 0;
			if (!F21())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9162));
			}
		}
		string text = CurrentSnapshot.GetText(lineTerminator);
		using (FileStream stream = File.Create(path))
		{
			StreamWriter streamWriter = new StreamWriter(stream, encoding);
			streamWriter.Write(text);
			streamWriter.Flush();
		}
		if (path == zhO)
		{
			IsModified = false;
		}
	}

	public void SaveFile(Stream stream, Encoding encoding, LineTerminator lineTerminator)
	{
		if (stream == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9174));
		}
		string text = CurrentSnapshot.GetText(lineTerminator);
		StreamWriter streamWriter = new StreamWriter(stream, encoding);
		streamWriter.Write(text);
		streamWriter.Flush();
	}

	internal static bool F21()
	{
		return N2b == null;
	}

	internal static TextDocumentBase O25()
	{
		return N2b;
	}
}
