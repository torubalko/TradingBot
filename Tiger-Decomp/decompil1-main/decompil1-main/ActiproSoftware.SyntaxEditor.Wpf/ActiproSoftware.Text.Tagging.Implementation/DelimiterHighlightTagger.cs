using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Analysis;
using ActiproSoftware.Text.Parsing;
using ActiproSoftware.Text.Parsing.Implementation;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Text.Tagging.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public class DelimiterHighlightTagger : CollectionTagger<IDelimiterHighlightTag>, IParser, IKeyedObject, IParseTarget
{
	private class p7t : IParseData
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private IStructureMatchResultSet uy4;

		internal static p7t Yf5;

		[SpecialName]
		[CompilerGenerated]
		public IStructureMatchResultSet Qy3()
		{
			return uy4;
		}

		[SpecialName]
		[CompilerGenerated]
		public void xyR(IStructureMatchResultSet P_0)
		{
			uy4 = P_0;
		}

		public p7t()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool NfG()
		{
			return Yf5 == null;
		}

		internal static p7t AfN()
		{
			return Yf5;
		}
	}

	private BTZ DIE;

	private Guid gIc;

	private IEditorView CIa;

	private int VIx;

	internal static DelimiterHighlightTagger T5j;

	Guid IParseTarget.UniqueId => gIc;

	public DelimiterHighlightTagger(IEditorView view)
	{
		grA.DaB7cz();
		gIc = Guid.NewGuid();
		VIx = 100;
		base._002Ector(Q7Z.tqM(198116), (IEnumerable<Ordering>)null, (ICodeDocument)(view?.SyntaxEditor.Document), isForLanguage: false);
		int num = 0;
		if (false)
		{
			num = 0;
		}
		switch (num)
		{
		}
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		CIa = view;
		CIa.HasFocusChanged += l8h;
		CIa.SelectionChanged += w8N;
		CIa.SyntaxEditor.DocumentChanged += I8J;
		CIa.SyntaxEditor.DocumentTextChanged += f8t;
	}

	IParseData IParser.Parse(IParseRequest request)
	{
		if (request != null && request.Tag is IStructureMatcher structureMatcher && request.Snapshot != null)
		{
			IStructureMatchResultSet structureMatchResultSet = structureMatcher.Match(new TextSnapshotOffset(request.Snapshot, request.TextBufferReader.Offset), null);
			p7t p7t = new p7t();
			p7t.xyR(structureMatchResultSet);
			return p7t;
		}
		return null;
	}

	void IParseTarget.NotifyParseComplete(IParseRequest request, IParseData result)
	{
		if (CIa != null && result is p7t p7t)
		{
			vAE.d0c(CIa.SyntaxEditor, eIP, p7t.Qy3());
		}
	}

	private void I8J(object P_0, EditorDocumentChangedEventArgs P_1)
	{
		if (CIa != null && CIa.SyntaxEditor.IsDelimiterHighlightingEnabled)
		{
			ChangeDocument(P_1.NewValue);
			A8d(CIa.HasFocus);
		}
	}

	private void f8t(object P_0, EditorSnapshotChangedEventArgs P_1)
	{
		if (CIa != null && CIa.SyntaxEditor.IsDelimiterHighlightingEnabled)
		{
			A8d(CIa.HasFocus);
		}
	}

	private void t8Z()
	{
		if (CIa == null)
		{
			return;
		}
		ITextSnapshotReader reader = CIa.CurrentSnapshot.GetReader(CIa.Selection.EndOffset);
		ParseRequest parseRequest = new ParseRequest(gIc.ToString(), reader.BufferReader, this, this);
		parseRequest.Priority = 300;
		parseRequest.RepeatedRequestPause = 0;
		parseRequest.Snapshot = CIa.CurrentSnapshot;
		parseRequest.Tag = CIa.SyntaxEditor.Document.Language.GetStructureMatcher();
		IParseRequestDispatcher dispatcher = AmbientParseRequestDispatcherProvider.Dispatcher;
		if (dispatcher != null)
		{
			dispatcher.QueueRequest(parseRequest);
			return;
		}
		IParseData result = parseRequest.Parser.Parse(parseRequest);
		if (parseRequest.Target != null)
		{
			parseRequest.Target.NotifyParseComplete(parseRequest, result);
		}
	}

	private void l8h(object P_0, EventArgs P_1)
	{
		if (CIa == null)
		{
			return;
		}
		bool hasFocus = CIa.HasFocus;
		int num = 0;
		if (!O5M())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (!hasFocus)
		{
			if (DIE != null)
			{
				DIE.Destroy();
				DIE = null;
			}
			A8d(_0020: false);
		}
		else
		{
			if (DIE == null)
			{
				DIE = CIa.SyntaxEditor.FGR().PLW(Q7Z.tqM(198156), t8Z);
			}
			i8z();
		}
	}

	private void w8N(object P_0, EditorViewSelectionEventArgs P_1)
	{
		if (CIa == null || !CIa.SyntaxEditor.IsDelimiterHighlightingEnabled)
		{
			return;
		}
		if (CIa.HasFocus && base.Count > 0)
		{
			int endOffset = CIa.Selection.EndOffset;
			using IEnumerator<TagVersionRange<IDelimiterHighlightTag>> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				TagVersionRange<IDelimiterHighlightTag> current = enumerator.Current;
				if (current.Tag == null || current.VersionRange.Document != CIa.CurrentSnapshot.Document)
				{
					continue;
				}
				TextSnapshotRange textSnapshotRange = current.VersionRange.Translate(CIa.CurrentSnapshot);
				if (textSnapshotRange.StartOffset == endOffset)
				{
					StructureMatchEdges matchEdges = current.Tag.MatchEdges;
					StructureMatchEdges structureMatchEdges = matchEdges;
					if (structureMatchEdges == StructureMatchEdges.Start || structureMatchEdges == StructureMatchEdges.Both)
					{
						return;
					}
				}
				else if (textSnapshotRange.EndOffset == endOffset)
				{
					StructureMatchEdges matchEdges2 = current.Tag.MatchEdges;
					StructureMatchEdges structureMatchEdges2 = matchEdges2;
					if ((uint)(structureMatchEdges2 - 2) <= 1u)
					{
						return;
					}
				}
				else if (textSnapshotRange.Contains(endOffset))
				{
					return;
				}
			}
		}
		A8d(CIa.HasFocus);
	}

	internal void A8d(bool P_0)
	{
		SIW();
		Clear();
		if (P_0)
		{
			i8z();
		}
	}

	private void i8z()
	{
		if (CIa != null && CIa.SyntaxEditor.IsDelimiterHighlightingEnabled && DIE != null)
		{
			DIE.Start(VIx);
		}
	}

	private void SIW()
	{
		if (DIE != null)
		{
			DIE.Stop();
		}
	}

	private void eIP(IStructureMatchResultSet P_0)
	{
		if (CIa == null || !CIa.HasFocus || !CIa.SyntaxEditor.IsDelimiterHighlightingEnabled || P_0 == null || P_0.Results == null || P_0.Results.Count < 2 || P_0.Results.First().SnapshotRange.Snapshot.Version != CIa.CurrentSnapshot.Version)
		{
			Clear();
			return;
		}
		using (CreateBatch())
		{
			Clear();
			foreach (IStructureMatchResult result in P_0.Results)
			{
				if (result == null || result.SnapshotRange.Snapshot.Document != CIa.CurrentSnapshot.Document)
				{
					continue;
				}
				TextSnapshotRange textSnapshotRange = result.SnapshotRange.TranslateTo(CIa.CurrentSnapshot, TextRangeTrackingModes.Default);
				if (textSnapshotRange.IsDeleted || CIa.CollapsedRegionManager == null)
				{
					continue;
				}
				NormalizedTextSnapshotRangeCollection collapsedRanges = CIa.CollapsedRegionManager.GetCollapsedRanges(textSnapshotRange);
				if (collapsedRanges != null)
				{
					foreach (TextSnapshotRange item in collapsedRanges)
					{
						if (item.Contains(textSnapshotRange))
						{
							return;
						}
					}
				}
				ITextVersionRange versionRange = textSnapshotRange.ToVersionRange(TextRangeTrackingModes.DeleteWhenZeroLength);
				bAL tag = new bAL(result.MatchEdges);
				Add(new TagVersionRange<IDelimiterHighlightTag>(versionRange, tag));
			}
		}
	}

	protected override void OnClosed()
	{
		if (CIa != null)
		{
			CIa.HasFocusChanged -= l8h;
			CIa.SelectionChanged -= w8N;
			if (CIa.SyntaxEditor != null)
			{
				CIa.SyntaxEditor.DocumentChanged -= I8J;
				CIa.SyntaxEditor.DocumentTextChanged -= f8t;
			}
			CIa = null;
		}
		base.OnClosed();
		int num = 0;
		if (w53() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool O5M()
	{
		return T5j == null;
	}

	internal static DelimiterHighlightTagger w53()
	{
		return T5j;
	}
}
