using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.RegularExpressions;
using ActiproSoftware.Text.Searching;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Text.Tagging.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public class SearchResultHighlightTagger : CollectionTagger<IClassificationTag>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public INotifyPropertyChanged UyT;

		private static _003C_003Ec__DisplayClass8_0 efT;

		public _003C_003Ec__DisplayClass8_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void pyb(WeakEventListener<SearchResultHighlightTagger, PropertyChangedEventArgs> weakEventListener)
		{
			UyT.PropertyChanged -= weakEventListener.OnEvent;
		}

		internal static bool Ift()
		{
			return efT == null;
		}

		internal static _003C_003Ec__DisplayClass8_0 NfY()
		{
			return efT;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public SearchResultHighlightTagger HyI;

		public IEditorView Py5;

		internal static _003C_003Ec__DisplayClass18_0 Xfo;

		public _003C_003Ec__DisplayClass18_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool tfQ()
		{
			return Xfo == null;
		}

		internal static _003C_003Ec__DisplayClass18_0 lfy()
		{
			return Xfo;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_1
	{
		public int Yy0;

		public _003C_003Ec__DisplayClass18_0 EyB;

		private static _003C_003Ec__DisplayClass18_1 Ifh;

		public _003C_003Ec__DisplayClass18_1()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool Vf6()
		{
			return Ifh == null;
		}

		internal static _003C_003Ec__DisplayClass18_1 xfK()
		{
			return Ifh;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_2
	{
		public ISearchOptions ayr;

		public _003C_003Ec__DisplayClass18_1 lys;

		internal static _003C_003Ec__DisplayClass18_2 SfC;

		public _003C_003Ec__DisplayClass18_2()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void NyV()
		{
			_003C_003Ec__DisplayClass18_3 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_3
			{
				zy9 = this
			};
			if (lys.EyB.HyI.rIH == lys.Yy0)
			{
				ayr.MaximumResultCount = 3000;
				_003C_003Ec__DisplayClass18_.KyS = null;
				try
				{
					TextSnapshotRange textSnapshotRange = NIe(lys.EyB.Py5, ayr);
					_003C_003Ec__DisplayClass18_.KyS = lys.EyB.Py5.CurrentSnapshot.FindAll(ayr, textSnapshotRange);
				}
				catch (InvalidRegexPatternException)
				{
				}
				vAE.l0x<object>(lys.EyB.Py5.SyntaxEditor, _003C_003Ec__DisplayClass18_.Syk, null);
			}
		}

		internal static bool zfr()
		{
			return SfC == null;
		}

		internal static _003C_003Ec__DisplayClass18_2 EfX()
		{
			return SfC;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass18_3
	{
		public ISearchResultSet KyS;

		public _003C_003Ec__DisplayClass18_2 zy9;

		private static _003C_003Ec__DisplayClass18_3 LfE;

		public _003C_003Ec__DisplayClass18_3()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void Syk(object o)
		{
			if (zy9.lys.EyB.HyI.rIH == zy9.lys.Yy0)
			{
				if (KyS != null && KyS.Results != null)
				{
					zy9.lys.EyB.HyI.DIR(KyS.Results.ToArray());
				}
				else
				{
					zy9.lys.EyB.HyI.DIR(null);
				}
			}
		}

		internal static bool ffw()
		{
			return LfE == null;
		}

		internal static _003C_003Ec__DisplayClass18_3 mfu()
		{
			return LfE;
		}
	}

	private ISearchOptions cIj;

	private IEnumerable<ISearchResult> iIw;

	private BTZ hI6;

	private int rIH;

	private IEditorView JIb;

	private WeakEventListener<SearchResultHighlightTagger, PropertyChangedEventArgs> AIT;

	internal static SearchResultHighlightTagger U5Q;

	public SearchResultHighlightTagger(IEditorView view)
	{
		grA.DaB7cz();
		base._002Ector(Q7Z.tqM(420), (IEnumerable<Ordering>)new Ordering[2]
		{
			new Ordering(Q7Z.tqM(198006), OrderPlacement.Before),
			new Ordering(Q7Z.tqM(197968), OrderPlacement.Before)
		}, (ICodeDocument)(view?.SyntaxEditor.Document), isForLanguage: false);
		if (view == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(952));
		}
		JIb = view;
		view.Closed += cI1;
		view.HighlightedResultSearchOptionsChanged += yIF;
		view.SyntaxEditor.DocumentChanged += KIA;
		view.SyntaxEditor.DocumentTextChanged += mIv;
		view.SyntaxEditor.ViewIsIncrementalSearchActiveChanged += yIm;
		view.SyntaxEditor.ViewSearch += gIC;
		hI6 = view.SyntaxEditor.FGR().PLW(Q7Z.tqM(198232) + (int)view.Placement, WIu);
	}

	private void zIQ(bool P_0)
	{
		if (AIT != null)
		{
			AIT.Detach();
			AIT = null;
		}
		if (!P_0)
		{
			return;
		}
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals4.UyT = cIj as INotifyPropertyChanged;
		if (CS_0024_003C_003E8__locals4.UyT != null)
		{
			AIT = new WeakEventListener<SearchResultHighlightTagger, PropertyChangedEventArgs>(this, delegate(SearchResultHighlightTagger instance, object source, PropertyChangedEventArgs eventArgs)
			{
				instance.LIl(source, eventArgs);
			}, delegate(WeakEventListener<SearchResultHighlightTagger, PropertyChangedEventArgs> weakEventListener)
			{
				CS_0024_003C_003E8__locals4.UyT.PropertyChanged -= weakEventListener.OnEvent;
			});
			CS_0024_003C_003E8__locals4.UyT.PropertyChanged += AIT.OnEvent;
		}
	}

	private static TextSnapshotRange NIe(IEditorView P_0, ISearchOptions P_1)
	{
		if (P_0 is EditorView editorView)
		{
			IEditorSearchOptions editorSearchOptions = P_1 as IEditorSearchOptions;
			bool flag = editorSearchOptions != null;
			int num = 0;
			if (k5h() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (flag)
			{
				return editorView.Xfo(editorSearchOptions.Scope);
			}
		}
		return P_0.CurrentSnapshot.SnapshotRange;
	}

	private void LIl(object P_0, PropertyChangedEventArgs P_1)
	{
		string propertyName = P_1.PropertyName;
		string text = propertyName;
		if (!(text == Q7Z.tqM(193304)) && !(text == Q7Z.tqM(193344)) && !(text == Q7Z.tqM(193370)))
		{
			jI3();
		}
	}

	private void KIA(object P_0, EditorDocumentChangedEventArgs P_1)
	{
		ChangeDocument(P_1.NewValue);
		jI3();
	}

	private void mIv(object P_0, EditorSnapshotChangedEventArgs P_1)
	{
		jI3();
	}

	private void yIm(object P_0, TextViewEventArgs P_1)
	{
		if (JIb != null && P_1.View == JIb && !JIb.IsIncrementalSearchActive && JIb.SyntaxEditor.IsSearchResultHighlightingEnabled)
		{
			JIb.HighlightedResultSearchOptions = null;
		}
	}

	private void gIC(object P_0, EditorViewSearchEventArgs P_1)
	{
		if (JIb == null || P_1.View != JIb || P_1.ResultSet == null || P_1.ResultSet.OperationType != SearchOperationType.FindNextIncremental || !JIb.SyntaxEditor.IsSearchResultHighlightingEnabled)
		{
			return;
		}
		IEditorSearchOptions editorSearchOptions = JIb.SyntaxEditor.eGu().SearchOptions;
		if (editorSearchOptions != null && JIb.IsIncrementalSearchActive)
		{
			if (JIb.HighlightedResultSearchOptions != editorSearchOptions)
			{
				JIb.HighlightedResultSearchOptions = editorSearchOptions;
			}
		}
		else
		{
			JIb.HighlightedResultSearchOptions = null;
		}
	}

	private void WIu()
	{
		IEnumerable<ISearchResult> enumerable = iIw;
		iIw = null;
		SIo(enumerable);
	}

	private void cI1(object P_0, EventArgs P_1)
	{
		Close();
	}

	private void yIF(object P_0, EventArgs P_1)
	{
		jI3();
	}

	private void jI3()
	{
		_003C_003Ec__DisplayClass18_0 _003C_003Ec__DisplayClass18_ = new _003C_003Ec__DisplayClass18_0();
		_003C_003Ec__DisplayClass18_.HyI = this;
		_003C_003Ec__DisplayClass18_.Py5 = JIb;
		if (_003C_003Ec__DisplayClass18_.Py5 != null)
		{
			ISearchOptions highlightedResultSearchOptions = _003C_003Ec__DisplayClass18_.Py5.HighlightedResultSearchOptions;
			if (highlightedResultSearchOptions != null)
			{
				_003C_003Ec__DisplayClass18_1 _003C_003Ec__DisplayClass18_2 = new _003C_003Ec__DisplayClass18_1();
				_003C_003Ec__DisplayClass18_2.EyB = _003C_003Ec__DisplayClass18_;
				_003C_003Ec__DisplayClass18_2.Yy0 = qI4(highlightedResultSearchOptions);
				if (!string.IsNullOrEmpty(highlightedResultSearchOptions.FindText))
				{
					_003C_003Ec__DisplayClass18_2 CS_0024_003C_003E8__locals11 = new _003C_003Ec__DisplayClass18_2();
					CS_0024_003C_003E8__locals11.lys = _003C_003Ec__DisplayClass18_2;
					CS_0024_003C_003E8__locals11.ayr = highlightedResultSearchOptions.Clone() as ISearchOptions;
					Task.Factory.StartNew(delegate
					{
						_003C_003Ec__DisplayClass18_3 _003C_003Ec__DisplayClass18_3 = new _003C_003Ec__DisplayClass18_3();
						_003C_003Ec__DisplayClass18_3.zy9 = CS_0024_003C_003E8__locals11;
						if (CS_0024_003C_003E8__locals11.lys.EyB.HyI.rIH == CS_0024_003C_003E8__locals11.lys.Yy0)
						{
							CS_0024_003C_003E8__locals11.ayr.MaximumResultCount = 3000;
							_003C_003Ec__DisplayClass18_3.KyS = null;
							try
							{
								TextSnapshotRange textSnapshotRange = NIe(CS_0024_003C_003E8__locals11.lys.EyB.Py5, CS_0024_003C_003E8__locals11.ayr);
								_003C_003Ec__DisplayClass18_3.KyS = CS_0024_003C_003E8__locals11.lys.EyB.Py5.CurrentSnapshot.FindAll(CS_0024_003C_003E8__locals11.ayr, textSnapshotRange);
							}
							catch (InvalidRegexPatternException)
							{
							}
							vAE.l0x<object>(CS_0024_003C_003E8__locals11.lys.EyB.Py5.SyntaxEditor, _003C_003Ec__DisplayClass18_3.Syk, null);
						}
					});
				}
				else
				{
					DIR(null);
				}
				return;
			}
		}
		qI4(null);
		DIR(null);
	}

	private void DIR(IEnumerable<ISearchResult> P_0)
	{
		if (hI6 != null)
		{
			hI6.Stop();
		}
		int num = 0;
		if (JIb != null)
		{
			ITextViewLine textViewLine = JIb.VisibleViewLines.FirstOrDefault();
			if (textViewLine != null)
			{
				ITextViewLine textViewLine2 = JIb.VisibleViewLines.LastOrDefault();
				if (textViewLine2 != null)
				{
					int num2 = textViewLine2.EndOffset - textViewLine.StartOffset;
					if (num2 > 50000)
					{
						num = 1000;
					}
					else if (num2 > 10000)
					{
						num = 500;
					}
				}
			}
		}
		if (num > 0 && hI6 != null)
		{
			iIw = P_0;
			hI6.Start(num);
		}
		else
		{
			iIw = null;
			SIo(P_0);
		}
	}

	private void PIY(PropertyDictionary P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		foreach (object key in P_0.Keys)
		{
			if (P_0.TryGetValue<object>(key, out var value) && value == this)
			{
				P_0.Remove(key);
			}
		}
	}

	private int qI4(ISearchOptions P_0)
	{
		if (cIj != P_0)
		{
			cIj = P_0;
			zIQ(_0020: true);
		}
		bool flag = P_0 != null && !string.IsNullOrEmpty(P_0.FindText);
		rIH = (flag ? ((rIH + 1) % 100000) : 0);
		return rIH;
	}

	private void SIo(IEnumerable<ISearchResult> P_0)
	{
		using (CreateBatch())
		{
			Clear();
			if (JIb != null)
			{
				IOverlayPane overlayPane = JIb.OverlayPanes[Q7Z.tqM(9576)];
				if (overlayPane != null)
				{
					TextSnapshotRange selectionScopeSnapshotRange = JIb.Searcher.SelectionScopeSnapshotRange;
					if (selectionScopeSnapshotRange.StartOffset > 0 || selectionScopeSnapshotRange.EndOffset < JIb.CurrentSnapshot.Length)
					{
						Add(selectionScopeSnapshotRange, new ClassificationTag(cT.FindScopeHighlight));
					}
				}
			}
			if (P_0 == null)
			{
				return;
			}
			foreach (ISearchResult item in P_0)
			{
				if (item != null && !item.FindSnapshotRange.IsDeleted && item.FindSnapshotRange.Snapshot == JIb.CurrentSnapshot)
				{
					TextSnapshotRange snapshotRange = item.FindSnapshotRange.TranslateTo(JIb.CurrentSnapshot, TextRangeTrackingModes.DeleteWhenZeroLength);
					if (!snapshotRange.IsZeroLength)
					{
						Add(snapshotRange, new ClassificationTag(cT.FindMatchHighlight));
					}
				}
			}
		}
	}

	protected override void OnClosed()
	{
		if (JIb != null)
		{
			PIY(JIb.Properties);
			JIb.HighlightedResultSearchOptionsChanged -= yIF;
			if (JIb.SyntaxEditor != null)
			{
				JIb.SyntaxEditor.DocumentChanged -= KIA;
				JIb.SyntaxEditor.DocumentTextChanged -= mIv;
				JIb.SyntaxEditor.ViewIsIncrementalSearchActiveChanged -= yIm;
				JIb.SyntaxEditor.ViewSearch -= gIC;
			}
			JIb = null;
		}
		if (hI6 != null)
		{
			int num = 0;
			if (!L5y())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			hI6.Destroy();
			hI6 = null;
		}
		base.OnClosed();
	}

	internal static bool L5y()
	{
		return U5Q == null;
	}

	internal static SearchResultHighlightTagger k5h()
	{
		return U5Q;
	}
}
