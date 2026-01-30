using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class CodeSnippetProvider : ICodeSnippetProvider, IOrderable, IKeyedObject, IEditorViewKeyInputEventSink, ITextViewLifecycleEventSink, ITextViewTaggerProvider
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0<T> where T : ITag
	{
		public ITextView view;

		internal static object kjD;

		public _003C_003Ec__DisplayClass7_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal ITagger<T> GrQ()
		{
			return new SF(view.SyntaxEditor.Document) as ITagger<T>;
		}

		internal static bool XjB()
		{
			return kjD == null;
		}

		internal static object Yj0()
		{
			return kjD;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public CodeSnippetTypes Lrl;

		internal static _003C_003Ec__DisplayClass11_0 aj7;

		public _003C_003Ec__DisplayClass11_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal bool pre(ICodeSnippetMetadata m)
		{
			return (m.SnippetTypes & Lrl) == Lrl;
		}

		internal static bool bjn()
		{
			return aj7 == null;
		}

		internal static _003C_003Ec__DisplayClass11_0 Mjq()
		{
			return aj7;
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool NuP;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string muE;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IEnumerable<Ordering> auc;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ICodeSnippetFolder Eua;

	internal static CodeSnippetProvider Lal;

	IEnumerable<Type> ITextViewTaggerProvider.TagTypes => new Type[2]
	{
		typeof(IClassificationTag),
		typeof(Xx)
	};

	public bool IsCaseSensitive
	{
		[CompilerGenerated]
		get
		{
			return NuP;
		}
		[CompilerGenerated]
		set
		{
			NuP = value;
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return muE;
		}
		[CompilerGenerated]
		private set
		{
			muE = value;
		}
	}

	public IEnumerable<Ordering> Orderings
	{
		[CompilerGenerated]
		get
		{
			return auc;
		}
		[CompilerGenerated]
		private set
		{
			auc = value;
		}
	}

	public ICodeSnippetFolder RootFolder
	{
		[CompilerGenerated]
		get
		{
			return Eua;
		}
		[CompilerGenerated]
		set
		{
			Eua = value;
		}
	}

	public CodeSnippetProvider()
	{
		grA.DaB7cz();
		this._002Ector(Guid.NewGuid().ToString(), (Ordering[])null);
	}

	public CodeSnippetProvider(string key)
	{
		grA.DaB7cz();
		this._002Ector(key, (Ordering[])null);
	}

	public CodeSnippetProvider(string key, params Ordering[] orderings)
	{
		grA.DaB7cz();
		base._002Ector();
		if (string.IsNullOrEmpty(key))
		{
			throw new ArgumentNullException(Q7Z.tqM(11646));
		}
		Key = key;
		Orderings = orderings;
		IsCaseSensitive = true;
	}

	void IEditorViewKeyInputEventSink.NotifyKeyDown(IEditorView view, KeyEventArgs e)
	{
		OnViewKeyDown(view, e);
	}

	void IEditorViewKeyInputEventSink.NotifyKeyUp(IEditorView view, KeyEventArgs e)
	{
		OnViewKeyUp(view, e);
	}

	void ITextViewLifecycleEventSink.NotifyViewAttached(ITextView view)
	{
	}

	void ITextViewLifecycleEventSink.NotifyViewDetached(ITextView view)
	{
		SF value = null;
		if (view != null && view.Properties.TryGetValue<SF>(typeof(SF), out value))
		{
			value.Close();
			view.Properties.Remove(typeof(SF));
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
	ITagger<T> ITextViewTaggerProvider.GetTagger<T>(ITextView view)
	{
		_003C_003Ec__DisplayClass7_0<T> CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass7_0<T>();
		CS_0024_003C_003E8__locals4.view = view;
		if ((typeof(T) == typeof(IClassificationTag) || typeof(T) == typeof(Xx)) && CS_0024_003C_003E8__locals4.view is IEditorView)
		{
			return CS_0024_003C_003E8__locals4.view.Properties.GetOrCreateSingleton(typeof(SF), () => new SF(CS_0024_003C_003E8__locals4.view.SyntaxEditor.Document) as ITagger<T>);
		}
		return null;
	}

	private static ICodeSnippetFolder tCN(ICodeSnippetFolder P_0, CodeSnippetTypes P_1)
	{
		ICodeSnippetFolder codeSnippetFolder = JCd(P_0, P_1);
		if (codeSnippetFolder != null)
		{
			while (codeSnippetFolder != null && codeSnippetFolder.Items.Count == 0 && codeSnippetFolder.Folders.Count == 1)
			{
				codeSnippetFolder = codeSnippetFolder.Folders[0];
			}
		}
		return codeSnippetFolder;
	}

	private static ICodeSnippetFolder JCd(ICodeSnippetFolder P_0, CodeSnippetTypes P_1)
	{
		_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass11_0();
		CS_0024_003C_003E8__locals4.Lrl = P_1;
		if (P_0 != null)
		{
			CodeSnippetFolder codeSnippetFolder = new CodeSnippetFolder(P_0.Name)
			{
				Tag = P_0.Tag
			};
			if (P_0.Items != null)
			{
				IEnumerable<ICodeSnippetMetadata> enumerable = P_0.Items.Where((ICodeSnippetMetadata m) => (m.SnippetTypes & CS_0024_003C_003E8__locals4.Lrl) == CS_0024_003C_003E8__locals4.Lrl);
				if (enumerable.Any())
				{
					foreach (ICodeSnippetMetadata item in enumerable)
					{
						codeSnippetFolder.Items.Add(item);
					}
				}
			}
			if (P_0.Folders != null)
			{
				foreach (ICodeSnippetFolder folder in P_0.Folders)
				{
					ICodeSnippetFolder codeSnippetFolder2 = JCd(folder, CS_0024_003C_003E8__locals4.Lrl);
					if (codeSnippetFolder2 != null)
					{
						codeSnippetFolder.Folders.Add(codeSnippetFolder2);
					}
				}
			}
			if (codeSnippetFolder.Folders.Count + codeSnippetFolder.Items.Count > 0)
			{
				return codeSnippetFolder;
			}
		}
		return null;
	}

	protected bool CheckForShortcut(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (RootFolder != null)
		{
			int num = 2;
			ICodeSnippetMetadata codeSnippetMetadata = default(ICodeSnippetMetadata);
			TextSnapshotRange possibleShortcutSnapshotRange = default(TextSnapshotRange);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
				{
					ICodeSnippet codeSnippet = codeSnippetMetadata.GetCodeSnippet();
					if (codeSnippet != null)
					{
						CodeSnippetTemplateSession codeSnippetTemplateSession = new CodeSnippetTemplateSession();
						codeSnippetTemplateSession.XuB(value: true);
						codeSnippetTemplateSession.CodeSnippet = codeSnippet;
						codeSnippetTemplateSession.Open(view, possibleShortcutSnapshotRange.TextRange);
						return true;
					}
					break;
				}
				case 2:
				{
					if (view.Selection.EndOffset <= 0 || !view.Selection.IsZeroLength)
					{
						break;
					}
					possibleShortcutSnapshotRange = GetPossibleShortcutSnapshotRange(view.Selection.EndSnapshotOffset);
					if (possibleShortcutSnapshotRange.IsZeroLength || possibleShortcutSnapshotRange.EndOffset != view.Selection.EndOffset)
					{
						break;
					}
					string text = possibleShortcutSnapshotRange.Text.Trim();
					if (string.IsNullOrEmpty(text))
					{
						break;
					}
					codeSnippetMetadata = RootFolder.FindItemByShortcut(text, IsCaseSensitive);
					num = 1;
					if (qaW())
					{
						continue;
					}
					goto IL_0005;
				}
				case 1:
					{
						if (codeSnippetMetadata == null)
						{
							break;
						}
						num = 0;
						if (qaW())
						{
							continue;
						}
						goto IL_0005;
					}
					IL_0005:
					num = num2;
					continue;
				}
				break;
			}
		}
		return false;
	}

	protected virtual ICodeSnippetSelectionSession CreateSelectionSession(ICodeSnippetFolder rootFolder, CodeSnippetTypes snippetType)
	{
		CodeSnippetSelectionSession codeSnippetSelectionSession = new CodeSnippetSelectionSession();
		codeSnippetSelectionSession.Label = SR.GetString((snippetType == CodeSnippetTypes.SurroundsWith) ? SRName.UIIntelliPromptCodeSnippetSelectorSurroundWithText : SRName.UIIntelliPromptCodeSnippetSelectorInsertSnippetText);
		codeSnippetSelectionSession.RootFolder = rootFolder;
		return codeSnippetSelectionSession;
	}

	protected virtual TextSnapshotRange GetPossibleShortcutSnapshotRange(TextSnapshotOffset snapshotOffset)
	{
		TextRange wordTextRange = snapshotOffset.Snapshot.GetWordTextRange(snapshotOffset.Offset - 1);
		TextSnapshotRange result;
		if (!wordTextRange.IsZeroLength && wordTextRange.EndOffset == snapshotOffset.Offset)
		{
			result = new TextSnapshotRange(snapshotOffset.Snapshot, wordTextRange);
			int num = 0;
			if (!qaW())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			result = TextSnapshotRange.Deleted;
		}
		return result;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected virtual void OnViewKeyDown(IEditorView view, KeyEventArgs e)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		bool flag = e == null;
		int num = 0;
		if (kaS() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		Key key = e.Key;
		Key key2 = key;
		if (key2 == System.Windows.Input.Key.Tab && vAE.A0o() == ModifierKeys.None)
		{
			e.Handled = CheckForShortcut(view);
		}
	}

	protected virtual void OnViewKeyUp(IEditorView view, KeyEventArgs e)
	{
	}

	public bool RequestSelectionSession(IEditorView view, CodeSnippetTypes snippetType)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		ICodeSnippetFolder codeSnippetFolder = tCN(RootFolder, snippetType);
		if (codeSnippetFolder != null && codeSnippetFolder.Folders.Count + codeSnippetFolder.Items.Count > 0)
		{
			ICodeSnippetSelectionSession codeSnippetSelectionSession = CreateSelectionSession(codeSnippetFolder, snippetType);
			if (codeSnippetSelectionSession != null)
			{
				view.Scroller.ScrollToCaret();
				codeSnippetSelectionSession.Open(view);
				return true;
			}
		}
		return false;
	}

	public bool RequestTemplateSession(IEditorView view, ICodeSnippet codeSnippet)
	{
		if (view != null)
		{
			if (codeSnippet != null)
			{
				view.Scroller.ScrollToCaret();
				CodeSnippetTemplateSession codeSnippetTemplateSession = new CodeSnippetTemplateSession();
				codeSnippetTemplateSession.CodeSnippet = codeSnippet;
				codeSnippetTemplateSession.Open(view);
				int num = 0;
				if (!qaW())
				{
					int num2 = default(int);
					num = num2;
				}
				return num switch
				{
					_ => true, 
				};
			}
			throw new ArgumentNullException(Q7Z.tqM(12064));
		}
		throw new ArgumentNullException(Q7Z.tqM(952));
	}

	internal static bool qaW()
	{
		return Lal == null;
	}

	internal static CodeSnippetProvider kaS()
	{
		return Lal;
	}
}
