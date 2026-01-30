using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Implementation;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
public class CodeSnippetTemplateSession : IntelliPromptSessionBase, ICodeSnippetTemplateSession, IIntelliPromptSession, IServiceLocator, IEditorDocumentTextChangeEventSink, IEditorViewKeyInputEventSink, IEditorViewSelectionChangeEventSink, INotifyPropertyChanged
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public TagSnapshotRange<Xx> ir1;

		internal static _003C_003Ec__DisplayClass16_0 ajg;

		public _003C_003Ec__DisplayClass16_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal bool irv(TagVersionRange<Xx> t)
		{
			return t.Tag != null && !t.Tag.nC8() && t.Tag.xCH() != null && t.VersionRange.Translate(ir1.SnapshotRange.Snapshot).StartOffset > ir1.SnapshotRange.StartOffset;
		}

		internal bool srm(TagVersionRange<Xx> t)
		{
			return t.Tag != null && !t.Tag.nC8() && t.Tag.xCH() != null && t.VersionRange.Translate(ir1.SnapshotRange.Snapshot).StartOffset < ir1.SnapshotRange.StartOffset;
		}

		internal bool OrC(TagVersionRange<Xx> t)
		{
			return t.Tag != null && !t.Tag.nC8() && t.Tag.xCH() != null && t.VersionRange.Translate(ir1.SnapshotRange.Snapshot).StartOffset < ir1.SnapshotRange.StartOffset;
		}

		internal bool Qru(TagVersionRange<Xx> t)
		{
			return t.Tag != null && !t.Tag.nC8() && t.Tag.xCH() != null && t.VersionRange.Translate(ir1.SnapshotRange.Snapshot).StartOffset > ir1.SnapshotRange.StartOffset;
		}

		internal static bool xjA()
		{
			return ajg == null;
		}

		internal static _003C_003Ec__DisplayClass16_0 Kjl()
		{
			return ajg;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public string Rr3;

		internal static _003C_003Ec__DisplayClass32_0 VjW;

		public _003C_003Ec__DisplayClass32_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal bool QrF(TagVersionRange<Xx> t)
		{
			return t.Tag != null && t.Tag.xCH() != null && t.Tag.xCH().Id == Rr3;
		}

		internal static bool wjS()
		{
			return VjW == null;
		}

		internal static _003C_003Ec__DisplayClass32_0 zjk()
		{
			return VjW;
		}
	}

	private TagVersionRange<Xx> pur;

	private string Nus;

	private ICodeSnippet Kuk;

	private TextSnapshotOffset? cuS;

	private bool Su9;

	private TextSnapshotRange? guy;

	private bool kuq;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool iu2;

	private static CodeSnippetTemplateSession faO;

	public ICodeSnippetDeclaration ActiveDeclaration => (pur != null && pur.Tag != null) ? pur.Tag.xCH() : null;

	public override Rect? Bounds => null;

	protected override bool CanOpenForReadOnlyTextRanges => false;

	public override bool ClosesOnLostFocus => false;

	public ICodeSnippet CodeSnippet
	{
		get
		{
			return Kuk;
		}
		set
		{
			if (Kuk != value)
			{
				Kuk = value;
				NotifyPropertyChanged(Q7Z.tqM(12686));
			}
		}
	}

	public bool IsAutoIndentEnabled
	{
		get
		{
			return Su9;
		}
		set
		{
			if (Su9 != value)
			{
				Su9 = value;
				NotifyPropertyChanged(Q7Z.tqM(13898));
			}
		}
	}

	public override IIntelliPromptSessionType SessionType => IntelliPromptSessionTypes.CodeSnippetTemplate;

	public event PropertyChangedEventHandler PropertyChanged;

	public CodeSnippetTemplateSession()
	{
		grA.DaB7cz();
		Su9 = true;
		base._002Ector();
		RegisterService((IEditorDocumentTextChangeEventSink)this);
		RegisterService((IEditorViewKeyInputEventSink)this);
		RegisterService((IEditorViewSelectionChangeEventSink)this);
		RegisterService(new CodeSnippetFieldQuickInfoProvider());
	}

	void IEditorDocumentTextChangeEventSink.NotifyDocumentTextChanged(SyntaxEditor editor, EditorSnapshotChangedEventArgs e)
	{
		OnDocumentTextChanged(editor, e);
	}

	void IEditorDocumentTextChangeEventSink.NotifyDocumentTextChanging(SyntaxEditor editor, EditorSnapshotChangingEventArgs e)
	{
		OnDocumentTextChanging(editor, e);
	}

	void IEditorViewKeyInputEventSink.NotifyKeyDown(IEditorView view, KeyEventArgs e)
	{
		OnViewKeyDown(view, e);
	}

	void IEditorViewKeyInputEventSink.NotifyKeyUp(IEditorView view, KeyEventArgs e)
	{
		OnViewKeyUp(view, e);
	}

	void IEditorViewSelectionChangeEventSink.NotifySelectionChanged(IEditorView view, EditorViewSelectionEventArgs e)
	{
		OnViewSelectionChanged(view, e);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void Ku4(TagSnapshotRange<Xx> P_0, bool P_1)
	{
		_003C_003Ec__DisplayClass16_0 CS_0024_003C_003E8__locals9 = new _003C_003Ec__DisplayClass16_0();
		CS_0024_003C_003E8__locals9.ir1 = P_0;
		SF value = null;
		if (base.View == null || !base.View.Properties.TryGetValue<SF>(typeof(SF), out value) || value == null)
		{
			return;
		}
		TagVersionRange<Xx> tagVersionRange;
		if (P_1)
		{
			tagVersionRange = value.FirstOrDefault((TagVersionRange<Xx> t) => t.Tag != null && !t.Tag.nC8() && t.Tag.xCH() != null && t.VersionRange.Translate(CS_0024_003C_003E8__locals9.ir1.SnapshotRange.Snapshot).StartOffset > CS_0024_003C_003E8__locals9.ir1.SnapshotRange.StartOffset);
			if (tagVersionRange == null)
			{
				tagVersionRange = value.FirstOrDefault((TagVersionRange<Xx> t) => t.Tag != null && !t.Tag.nC8() && t.Tag.xCH() != null && t.VersionRange.Translate(CS_0024_003C_003E8__locals9.ir1.SnapshotRange.Snapshot).StartOffset < CS_0024_003C_003E8__locals9.ir1.SnapshotRange.StartOffset);
			}
		}
		else
		{
			tagVersionRange = value.LastOrDefault((TagVersionRange<Xx> t) => t.Tag != null && !t.Tag.nC8() && t.Tag.xCH() != null && t.VersionRange.Translate(CS_0024_003C_003E8__locals9.ir1.SnapshotRange.Snapshot).StartOffset < CS_0024_003C_003E8__locals9.ir1.SnapshotRange.StartOffset);
			if (tagVersionRange == null)
			{
				tagVersionRange = value.LastOrDefault((TagVersionRange<Xx> t) => t.Tag != null && !t.Tag.nC8() && t.Tag.xCH() != null && t.VersionRange.Translate(CS_0024_003C_003E8__locals9.ir1.SnapshotRange.Snapshot).StartOffset > CS_0024_003C_003E8__locals9.ir1.SnapshotRange.StartOffset);
			}
		}
		if (tagVersionRange != null)
		{
			gu8(tagVersionRange.Tag.xCH().Id, _0020: true);
		}
	}

	private string kuo(string P_0, string P_1)
	{
		if (!Su9 || string.IsNullOrEmpty(P_0) || string.IsNullOrEmpty(P_1))
		{
			return P_0;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in P_0)
		{
			stringBuilder.Append(c);
			if (c == '\n')
			{
				stringBuilder.Append(P_1);
			}
		}
		return stringBuilder.ToString();
	}

	private void Euj()
	{
		SF value = null;
		if (base.View != null && base.View.Properties.TryGetValue<SF>(typeof(SF), out value))
		{
			value?.Clear();
		}
	}

	private ICodeSnippetDeclaration suw(string P_0)
	{
		if (Kuk != null && Kuk.Declarations != null)
		{
			foreach (ICodeSnippetDeclaration declaration in Kuk.Declarations)
			{
				if (declaration.Id == P_0)
				{
					return declaration;
				}
			}
		}
		return null;
	}

	private string Fu6()
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		if (Kuk != null && Kuk.Declarations.Count > 0)
		{
			string text = Regex.Escape(Kuk.CodeDelimiter ?? Q7Z.tqM(12090));
			stringBuilder.Append(Q7Z.tqM(13832) + text + Q7Z.tqM(13852));
			for (int i = 0; i < Kuk.Declarations.Count; i++)
			{
				ICodeSnippetDeclaration codeSnippetDeclaration = Kuk.Declarations[i];
				if (codeSnippetDeclaration != null && !string.IsNullOrEmpty(codeSnippetDeclaration.Id))
				{
					if (flag)
					{
						stringBuilder.Append(Q7Z.tqM(13870));
					}
					stringBuilder.AppendFormat(CultureInfo.InvariantCulture, Q7Z.tqM(13876), new object[1] { Regex.Escape(codeSnippetDeclaration.Id) });
					flag = true;
				}
			}
			stringBuilder.Append(Q7Z.tqM(13890) + text + Q7Z.tqM(13890));
		}
		return flag ? stringBuilder.ToString() : null;
	}

	private TagSnapshotRange<Xx> TuH(TextSnapshotOffset P_0)
	{
		SF value = null;
		if (base.View != null && base.View.Properties.TryGetValue<SF>(typeof(SF), out value) && value != null)
		{
			IEnumerable<TagSnapshotRange<Xx>> tags = value.GetTags(new NormalizedTextSnapshotRangeCollection(new TextSnapshotRange(P_0)), null);
			if (tags != null)
			{
				TagSnapshotRange<Xx> result = null;
				foreach (TagSnapshotRange<Xx> item in tags)
				{
					if (item != null && item.Tag != null)
					{
						if (!item.Tag.nC8())
						{
							result = item;
							break;
						}
						result = item;
					}
				}
				return result;
			}
		}
		return null;
	}

	private static string aub(string P_0, int P_1)
	{
		int num = 1;
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			do
			{
				IL_0012:
				switch (num2)
				{
				case 2:
					while (num3 >= 0)
					{
						switch (P_0[num3])
						{
						default:
							return string.Empty;
						case '\t':
						case ' ':
							break;
						case '\n':
						case '\r':
							return text;
						}
						text = P_0[num3] + text;
						num3--;
					}
					return text;
				default:
					num3 = P_1 - 1;
					num2 = 2;
					if (!Ua1())
					{
						num2 = 2;
					}
					goto IL_0012;
				case 1:
					break;
				}
				text = string.Empty;
				num2 = 0;
			}
			while (va5() == null);
		}
	}

	private IEnumerable<ICodeSnippetTemplateSessionEventSink> WuT()
	{
		return base.View.SyntaxEditor.jGF().g6Q<ICodeSnippetTemplateSessionEventSink>(_0020: true, base.View);
	}

	private bool TuL(List<Tuple<TextRange, Xx>> P_0)
	{
		SF value = null;
		if (base.View != null && base.View.Properties.TryGetValue<SF>(typeof(SF), out value) && value != null)
		{
			value.Clear();
			if (P_0 != null)
			{
				string text = null;
				foreach (Tuple<TextRange, Xx> item2 in P_0)
				{
					Xx item = item2.Item2;
					ITextVersionRange versionRange = new TextSnapshotRange(base.View.CurrentSnapshot, base.SnapshotRange.StartOffset + item2.Item1.StartOffset, base.SnapshotRange.StartOffset + item2.Item1.EndOffset).ToVersionRange(TextRangeTrackingModes.ExpandBothEdges | TextRangeTrackingModes.DeleteWhenSurrounded);
					value.Add(new TagVersionRange<Xx>(versionRange, item));
					if (string.IsNullOrEmpty(text) && item.xCH() != null && item.xCH().IsEditable)
					{
						text = item.xCH().Id;
					}
				}
				if (!string.IsNullOrEmpty(text))
				{
					gu8(text, _0020: true);
				}
				return value.Count > 0;
			}
		}
		return false;
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool fu0()
	{
		return iu2;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void XuB(bool value)
	{
		iu2 = value;
	}

	private string Fun(string P_0, out string P_1)
	{
		if (P_0 == null)
		{
			P_0 = string.Empty;
		}
		else if (P_0.IndexOf('\r') != -1)
		{
			P_0 = P_0.Replace(Q7Z.tqM(7886), Q7Z.tqM(7894)).Replace('\r', '\n');
		}
		IEditorDocument editorDocument = ((base.View != null) ? base.View.SyntaxEditor.Document : null);
		if (editorDocument.AutoConvertTabsToSpaces)
		{
			P_0 = P_0.Replace(Q7Z.tqM(7824), new string(' ', editorDocument.TabSize));
		}
		P_1 = null;
		if (Su9 && editorDocument != null && !base.SnapshotRange.IsDeleted)
		{
			int indentAmount = base.SnapshotRange.StartLine.IndentAmount;
			if (indentAmount > 0)
			{
				P_1 = StringHelper.GetIndentText(editorDocument.AutoConvertTabsToSpaces, editorDocument.TabSize, indentAmount);
				P_0 = kuo(P_0, P_1);
			}
		}
		return P_0;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void gu8(string P_0, bool P_1)
	{
		AuI();
		string text = ((pur != null) ? pur.Tag.xCH().Id : null);
		if (text != P_0 && !string.IsNullOrEmpty(text) && base.View != null)
		{
			IEnumerable<ICodeSnippetTemplateSessionEventSink> enumerable = WuT();
			foreach (ICodeSnippetTemplateSessionEventSink item in enumerable)
			{
				item.NotifyDeclarationDeactivated(this);
			}
		}
		pur = null;
		Nus = null;
		if (base.View == null)
		{
			return;
		}
		SF value = null;
		TextRange? textRange = null;
		TextRange? textRange2 = null;
		if (base.View.Properties.TryGetValue<SF>(typeof(SF), out value) && value != null)
		{
			foreach (TagVersionRange<Xx> item2 in value)
			{
				if (item2 != null && item2.Tag != null && item2.Tag.xCH() != null)
				{
					item2.Tag.IsActive = item2.Tag.xCH().Id == P_0;
					if (item2.Tag.IsActive && !item2.Tag.nC8())
					{
						pur = item2;
						textRange2 = item2.VersionRange.Translate(base.View.CurrentSnapshot).TextRange;
						Nus = base.View.CurrentSnapshot.GetSubstring(textRange2.Value);
					}
					textRange = ((!textRange.HasValue) ? new TextRange?(item2.VersionRange.Translate(base.View.CurrentSnapshot).TextRange) : new TextRange?(TextRange.Union(textRange.Value, item2.VersionRange.Translate(base.View.CurrentSnapshot).TextRange)));
				}
			}
		}
		if (text != P_0 && textRange.HasValue)
		{
			value.lC9(new TagsChangedEventArgs(new TextSnapshotRange(base.View.CurrentSnapshot, textRange.Value)));
		}
		if (P_1 && textRange2.HasValue && (text != P_0 || !textRange2.Value.IntersectsWith(base.View.Selection.EndOffset)))
		{
			base.View.Selection.SelectRange(textRange2.Value);
		}
		if (!(text != P_0) || string.IsNullOrEmpty(P_0))
		{
			return;
		}
		IEnumerable<ICodeSnippetTemplateSessionEventSink> enumerable2 = WuT();
		foreach (ICodeSnippetTemplateSessionEventSink item3 in enumerable2)
		{
			item3.NotifyDeclarationActivated(this);
		}
	}

	private void AuI()
	{
		if (pur == null || Nus == null || base.View == null)
		{
			return;
		}
		string text = pur.VersionRange.Translate(base.View.CurrentSnapshot).GetText(LineTerminator.Newline);
		if (!(text != Nus))
		{
			return;
		}
		Ju5(pur.Tag.xCH().Id, text);
		int num = 0;
		if (!Ua1())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		Nus = text;
		IEnumerable<ICodeSnippetTemplateSessionEventSink> enumerable = WuT();
		foreach (ICodeSnippetTemplateSessionEventSink item in enumerable)
		{
			item.NotifyDeclarationTextChanged(this);
		}
	}

	private void Ju5(string P_0, string P_1)
	{
		_003C_003Ec__DisplayClass32_0 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass32_0();
		CS_0024_003C_003E8__locals2.Rr3 = P_0;
		SF value = null;
		if (base.View == null || !base.View.Properties.TryGetValue<SF>(typeof(SF), out value) || value == null)
		{
			return;
		}
		IEnumerable<TagVersionRange<Xx>> enumerable = value.Where((TagVersionRange<Xx> t) => t.Tag != null && t.Tag.xCH() != null && t.Tag.xCH().Id == CS_0024_003C_003E8__locals2.Rr3);
		if (enumerable == null)
		{
			return;
		}
		ITextChange textChange = base.View.CurrentSnapshot.CreateTextChange(TextChangeTypes.UpdateCodeSnippetTemplateFields, new TextChangeOptions
		{
			OffsetDelta = TextChangeOffsetDelta.SequentialOnly,
			RetainSelection = true
		});
		foreach (TagVersionRange<Xx> item in enumerable)
		{
			if (item != null && item.Tag != null)
			{
				item.Tag.pCB(_0020: true);
				TextSnapshotRange textSnapshotRange = item.VersionRange.Translate(base.View.CurrentSnapshot);
				if (textSnapshotRange.GetText(LineTerminator.Newline) != P_1)
				{
					textChange.ReplaceText(textSnapshotRange.TextRange, P_1);
				}
			}
		}
		textChange.Apply();
		foreach (TagVersionRange<Xx> item2 in enumerable)
		{
			if (item2 != null && item2.Tag != null)
			{
				item2.Tag.pCB(_0020: false);
			}
		}
	}

	protected void NotifyPropertyChanged(string name)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}

	protected override void OnClosed(CancelEventArgs e)
	{
		Euj();
		gu8(null, _0020: false);
		int num = 0;
		if (!Ua1())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		cuS = null;
		guy = null;
		kuq = false;
		IEnumerable<ICodeSnippetTemplateSessionEventSink> enumerable = WuT();
		foreach (ICodeSnippetTemplateSessionEventSink item in enumerable)
		{
			item.NotifySessionClosed(this);
		}
		base.OnClosed(e);
	}

	protected virtual void OnDocumentTextChanged(SyntaxEditor editor, EditorSnapshotChangedEventArgs e)
	{
		if (editor == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(13940));
		}
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		if (e.TextChange == null || e.TextChange.Type == TextChangeTypes.InsertCodeSnippetTemplate || e.TextChange.Type == TextChangeTypes.AutoCorrect)
		{
			return;
		}
		SF value = null;
		if (base.View != null && base.View.Properties.TryGetValue<SF>(typeof(SF), out value) && value != null && value.Count == 0)
		{
			Close(cancelled: false);
		}
		else
		{
			if (!guy.HasValue || base.View == null || editor.ActiveView != base.View || !base.View.HasFocus)
			{
				return;
			}
			if (e.TextChange.Operations.Count == 1)
			{
				ITextChangeOperation textChangeOperation = e.TextChange.Operations.FirstOrDefault();
				if (textChangeOperation != null && (textChangeOperation.DeletionEndOffset < guy.Value.StartOffset || textChangeOperation.DeletionEndOffset > guy.Value.EndOffset))
				{
					Close(cancelled: false);
					return;
				}
			}
			guy = guy.Value.TranslateTo(base.View.CurrentSnapshot, TextRangeTrackingModes.ExpandBothEdges);
		}
	}

	protected virtual void OnDocumentTextChanging(SyntaxEditor editor, EditorSnapshotChangingEventArgs e)
	{
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1506:AvoidExcessiveClassCoupling")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected override void OnOpened(EventArgs e)
	{
		IEditorView view = base.View;
		if (view == null || base.SnapshotRange.IsDeleted || Kuk == null || string.IsNullOrEmpty(Kuk.CodeText))
		{
			Close(cancelled: true);
			return;
		}
		string text2;
		string text = Fun(Kuk.CodeText, out text2);
		string text3 = Kuk.BmU();
		int num = text.IndexOf(text3, StringComparison.Ordinal);
		if (num != -1)
		{
			text = text.Substring(0, num) + text.Substring(num + text3.Length);
		}
		string text4 = Fu6();
		List<Tuple<TextRange, Xx>> list = null;
		if (text4 != null)
		{
			MatchCollection matchCollection = Regex.Matches(text, text4);
			if (matchCollection != null && matchCollection.Count > 0)
			{
				int num2 = 0;
				HashSet<string> hashSet = new HashSet<string>();
				foreach (Match item2 in matchCollection)
				{
					string value = item2.Groups[Q7Z.tqM(13956)].Value;
					ICodeSnippetDeclaration codeSnippetDeclaration = suw(value);
					if (codeSnippetDeclaration == null)
					{
						continue;
					}
					string value2 = item2.Groups[Q7Z.tqM(13964)].Value;
					if (string.IsNullOrEmpty(value2))
					{
						continue;
					}
					int num3 = item2.Index + num2;
					if (!string.IsNullOrEmpty(codeSnippetDeclaration.DefaultText))
					{
						text = text.Substring(0, num3) + codeSnippetDeclaration.DefaultText + text.Substring(num3 + value2.Length);
						if (num3 < num)
						{
							num += codeSnippetDeclaration.DefaultText.Length - value2.Length;
						}
					}
					if (list == null)
					{
						list = new List<Tuple<TextRange, Xx>>();
					}
					bool flag = hashSet.Contains(value);
					if (!flag)
					{
						hashSet.Add(value);
					}
					List<Tuple<TextRange, Xx>> list2 = list;
					TextRange item = TextRange.FromSpan(num3, (codeSnippetDeclaration.DefaultText ?? value2).Length);
					Xx xx = new Xx();
					xx.jCb(codeSnippetDeclaration);
					xx.FCI(flag);
					list2.Add(new Tuple<TextRange, Xx>(item, xx));
					if (!string.IsNullOrEmpty(codeSnippetDeclaration.DefaultText))
					{
						num2 += codeSnippetDeclaration.DefaultText.Length - value2.Length;
					}
				}
			}
		}
		string text5 = Kuk.ImJ();
		int num4 = text.IndexOf(text5, StringComparison.Ordinal);
		while (num4 != -1)
		{
			string text6 = Kuk.UmZ();
			text = text.Substring(0, num4) + text6 + text.Substring(num4 + text5.Length);
			int num5 = text6.Length - text5.Length;
			if (num4 < num)
			{
				num += num5;
			}
			if (list != null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					Tuple<TextRange, Xx> tuple = list[i];
					if (num4 < tuple.Item1.StartOffset)
					{
						list[i] = new Tuple<TextRange, Xx>(new TextRange(tuple.Item1.StartOffset + num5, tuple.Item1.EndOffset + num5), tuple.Item2);
					}
				}
			}
			num4 = text.IndexOf(text5, num4 + text6.Length, StringComparison.Ordinal);
		}
		string text7 = Kuk.Mmt();
		int num6 = text.IndexOf(text7, StringComparison.Ordinal);
		while (num6 != -1)
		{
			string text8 = (fu0() ? string.Empty : base.SnapshotRange.GetText(LineTerminator.Newline));
			string text9 = aub(text, num6);
			if (!string.IsNullOrEmpty(text9))
			{
				if (!string.IsNullOrEmpty(text2) && text9.StartsWith(text2, StringComparison.Ordinal))
				{
					text9 = text9.Substring(text2.Length);
				}
				text8 = kuo(text8, text9);
			}
			text = text.Substring(0, num6) + text8 + text.Substring(num6 + text7.Length);
			int num7 = text8.Length - text7.Length;
			if (num6 < num)
			{
				num += num7;
			}
			if (list != null)
			{
				for (int j = 0; j < list.Count; j++)
				{
					Tuple<TextRange, Xx> tuple2 = list[j];
					if (num6 < tuple2.Item1.StartOffset)
					{
						list[j] = new Tuple<TextRange, Xx>(new TextRange(tuple2.Item1.StartOffset + num7, tuple2.Item1.EndOffset + num7), tuple2.Item2);
					}
				}
			}
			num6 = text.IndexOf(text7, num6 + text8.Length, StringComparison.Ordinal);
		}
		using (view.Selection.CreateBatch(EditorViewSelectionBatchOptions.None))
		{
			ITextChange textChange = view.CurrentSnapshot.CreateTextChange(TextChangeTypes.InsertCodeSnippetTemplate, new EditorViewTextChangeOptions(this)
			{
				CheckReadOnly = true
			});
			textChange.ReplaceText(base.SnapshotRange.TextRange, text);
			if (!textChange.Apply())
			{
				Close(cancelled: true);
				return;
			}
			guy = new TextSnapshotRange(view.CurrentSnapshot, TextRange.FromSpan(base.SnapshotRange.StartOffset, text.Length));
			if (num != -1)
			{
				cuS = new TextSnapshotOffset(view.CurrentSnapshot, base.SnapshotRange.StartOffset + num);
				view.Selection.StartOffset = cuS.Value.Offset;
			}
		}
		if (TuL(list))
		{
			base.OnOpened(e);
			IEnumerable<ICodeSnippetTemplateSessionEventSink> enumerable = WuT();
			{
				foreach (ICodeSnippetTemplateSessionEventSink item3 in enumerable)
				{
					item3.NotifySessionOpened(this);
				}
				return;
			}
		}
		Close(cancelled: false);
	}

	protected virtual void OnViewKeyDown(IEditorView view, KeyEventArgs e)
	{
		if (e == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(1014));
		}
		if (base.View != view)
		{
			return;
		}
		switch (e.Key)
		{
		case Key.Return:
			if (base.View != null)
			{
				TagSnapshotRange<Xx> tagSnapshotRange2 = TuH(base.View.Selection.EndSnapshotOffset);
				if (tagSnapshotRange2 != null && tagSnapshotRange2.Tag != null && !tagSnapshotRange2.Tag.nC8())
				{
					AuI();
					if (cuS.HasValue)
					{
						base.View.Selection.StartOffset = cuS.Value.TranslateTo(base.View.CurrentSnapshot, TextOffsetTrackingMode.Negative).Offset;
					}
					else
					{
						base.View.Selection.StartOffset = base.SnapshotRange.TranslateTo(base.View.CurrentSnapshot, TextRangeTrackingModes.Default).EndOffset;
					}
					e.Handled = true;
				}
			}
			Close(cancelled: false);
			break;
		case Key.Escape:
			if (vAE.A0o() == ModifierKeys.None)
			{
				e.Handled = true;
				Close(cancelled: false);
			}
			break;
		case Key.Tab:
			if (base.View != null)
			{
				TagSnapshotRange<Xx> tagSnapshotRange = TuH(base.View.Selection.EndSnapshotOffset);
				if (tagSnapshotRange != null && tagSnapshotRange.Tag != null && !tagSnapshotRange.Tag.nC8())
				{
					ModifierKeys modifierKeys = vAE.A0o();
					ModifierKeys modifierKeys2 = modifierKeys;
					if (modifierKeys2 == ModifierKeys.None || modifierKeys2 == ModifierKeys.Shift)
					{
						e.Handled = true;
						Ku4(tagSnapshotRange, (vAE.A0o() & ModifierKeys.Shift) != ModifierKeys.Shift);
					}
					break;
				}
			}
			Close(cancelled: false);
			break;
		}
	}

	protected virtual void OnViewKeyUp(IEditorView view, KeyEventArgs e)
	{
	}

	protected virtual void OnViewSelectionChanged(IEditorView view, EditorViewSelectionEventArgs e)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		if (view != base.View)
		{
			return;
		}
		TagSnapshotRange<Xx> tagSnapshotRange = TuH(view.Selection.EndSnapshotOffset);
		if (tagSnapshotRange != null && tagSnapshotRange.Tag != null && !tagSnapshotRange.Tag.nC8())
		{
			kuq = true;
			if (!tagSnapshotRange.Tag.IsActive && tagSnapshotRange.Tag.xCH() != null)
			{
				gu8(tagSnapshotRange.Tag.xCH().Id, _0020: false);
			}
		}
		else if (kuq)
		{
			kuq = false;
			AuI();
		}
	}

	public void Open(IEditorView view)
	{
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		TextSnapshotRange textSnapshotRange = view.Selection.SnapshotRange;
		ITextSnapshotLine startLine = textSnapshotRange.StartLine;
		if (textSnapshotRange.StartOffset == startLine.StartOffset)
		{
			int firstNonWhitespaceCharacterOffset = startLine.FirstNonWhitespaceCharacterOffset;
			if (firstNonWhitespaceCharacterOffset <= textSnapshotRange.EndOffset)
			{
				textSnapshotRange = new TextSnapshotRange(textSnapshotRange.Snapshot, firstNonWhitespaceCharacterOffset, textSnapshotRange.EndOffset);
			}
		}
		Open(view, textSnapshotRange);
	}

	public override void Reposition()
	{
	}

	internal static bool Ua1()
	{
		return faO == null;
	}

	internal static CodeSnippetTemplateSession va5()
	{
		return faO;
	}
}
