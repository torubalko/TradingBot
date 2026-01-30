using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining.Implementation;

namespace ActiproSoftware.Internal;

internal class CM : INotifyPropertyChanged, IOutliningManager, ITagger<ICollapsedRegionTag>, IOrderable, IKeyedObject, ITagger<IIntraTextSpacerTag>, ITextViewTaggerProvider
{
	private class V7T : DisposableObject
	{
		private CM yV8;

		internal static V7T tHO;

		public V7T(CM P_0)
		{
			grA.DaB7cz();
			base._002Ector();
			yV8 = P_0;
			P_0.uAd();
		}

		protected override void Dispose(bool P_0)
		{
			if (yV8 != null)
			{
				yV8.iAh();
				yV8 = null;
			}
			base.Dispose(P_0);
		}

		internal static bool BH1()
		{
			return tHO == null;
		}

		internal static V7T DH5()
		{
			return tHO;
		}
	}

	internal class w7A : ICollapsedRegionTag, ITag, IIntraTextSpacerTag
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private double FVs;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object LVk;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Size HVS;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string UV9;

		private static w7A JHG;

		public double Baseline
		{
			[CompilerGenerated]
			get
			{
				return FVs;
			}
			[CompilerGenerated]
			set
			{
				FVs = fVs;
			}
		}

		public object Key
		{
			[CompilerGenerated]
			get
			{
				return LVk;
			}
			[CompilerGenerated]
			set
			{
				LVk = lVk;
			}
		}

		public Size Size
		{
			[CompilerGenerated]
			get
			{
				return HVS;
			}
			[CompilerGenerated]
			set
			{
				HVS = hVS;
			}
		}

		public string Text
		{
			[CompilerGenerated]
			get
			{
				return UV9;
			}
			[CompilerGenerated]
			set
			{
				UV9 = uV;
			}
		}

		public w7A()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		public TagSnapshotRange<IIntraTextSpacerTag> vVI(TextSnapshotRange P_0)
		{
			return new TagSnapshotRange<IIntraTextSpacerTag>(P_0, this);
		}

		internal static bool JHN()
		{
			return JHG == null;
		}

		internal static w7A PHH()
		{
			return JHG;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public IEditorDocument RV7;

		internal static _003C_003Ec__DisplayClass28_0 wHj;

		public _003C_003Ec__DisplayClass28_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void XVy(WeakEventListener<CM, SyntaxLanguageChangedEventArgs> weakEventListener)
		{
			RV7.RemoveLanguageChangedEventHandler(weakEventListener.OnEvent, EventHandlerPriority.Low);
		}

		internal void qVq(WeakEventListener<CM, EventArgs> weakEventListener)
		{
			RV7.ParseDataChanged -= weakEventListener.OnEvent;
		}

		internal void tV2(WeakEventListener<CM, TextSnapshotChangedEventArgs> weakEventListener)
		{
			RV7.TextChanged -= weakEventListener.OnEvent;
		}

		internal static bool iHM()
		{
			return wHj == null;
		}

		internal static _003C_003Ec__DisplayClass28_0 LH3()
		{
			return wHj;
		}
	}

	[CompilerGenerated]
	private sealed class _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIntraTextSpacerTag_003E_002DGetTags_003Ed__72 : IEnumerable<TagSnapshotRange<IIntraTextSpacerTag>>, IEnumerable, IEnumerator<TagSnapshotRange<IIntraTextSpacerTag>>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private TagSnapshotRange<IIntraTextSpacerTag> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private NormalizedTextSnapshotRangeCollection snapshotRanges;

		public NormalizedTextSnapshotRangeCollection _003C_003E3__snapshotRanges;

		private object parameter;

		public object _003C_003E3__parameter;

		public CM _003C_003E4__this;

		private ITagger<ICollapsedRegionTag> _003Ctagger_003E5__1;

		private IEnumerator<TagSnapshotRange<ICollapsedRegionTag>> _003C_003Es__2;

		private TagSnapshotRange<ICollapsedRegionTag> _003CtagRange_003E5__3;

		private w7A _003Ctag_003E5__4;

		internal static _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIntraTextSpacerTag_003E_002DGetTags_003Ed__72 LHc;

		TagSnapshotRange<IIntraTextSpacerTag> IEnumerator<TagSnapshotRange<IIntraTextSpacerTag>>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIntraTextSpacerTag_003E_002DGetTags_003Ed__72(int _003C_003E1__state)
		{
			grA.DaB7cz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num != -3 && num != 1)
			{
				return;
			}
			try
			{
			}
			finally
			{
				_003C_003Em__Finally1();
			}
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					_003C_003E1__state = -3;
					goto IL_0031;
				}
				goto IL_019b;
				IL_0016:
				int num3 = default(int);
				int num2 = num3;
				goto IL_001a;
				IL_001a:
				bool flag;
				while (true)
				{
					switch (num2)
					{
					case 1:
						goto IL_003e;
					case 2:
						goto IL_019b;
					}
					break;
					IL_003e:
					if (!flag)
					{
						num2 = 0;
						if (kHT() == null)
						{
							continue;
						}
						goto IL_0016;
					}
					_003C_003E2__current = _003Ctag_003E5__4.vVI(_003CtagRange_003E5__3.SnapshotRange);
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_0031;
				IL_0031:
				_003Ctag_003E5__4 = null;
				_003CtagRange_003E5__3 = null;
				goto IL_005a;
				IL_005a:
				if (!_003C_003Es__2.MoveNext())
				{
					_003C_003Em__Finally1();
					_003C_003Es__2 = null;
					return false;
				}
				_003CtagRange_003E5__3 = _003C_003Es__2.Current;
				_003Ctag_003E5__4 = _003CtagRange_003E5__3.Tag as w7A;
				flag = _003Ctag_003E5__4 != null;
				num2 = 1;
				if (!zHd())
				{
					goto IL_0016;
				}
				goto IL_001a;
				IL_019b:
				_003C_003E1__state = -1;
				_003Ctagger_003E5__1 = _003C_003E4__this;
				_003C_003Es__2 = _003Ctagger_003E5__1.GetTags(snapshotRanges, parameter).GetEnumerator();
				_003C_003E1__state = -3;
				goto IL_005a;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003Es__2 != null)
			{
				_003C_003Es__2.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<TagSnapshotRange<IIntraTextSpacerTag>> IEnumerable<TagSnapshotRange<IIntraTextSpacerTag>>.GetEnumerator()
		{
			_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIntraTextSpacerTag_003E_002DGetTags_003Ed__72 _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIntraTextSpacerTag_003E_002DGetTags_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIntraTextSpacerTag_003E_002DGetTags_003Ed__ = this;
			}
			else
			{
				_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIntraTextSpacerTag_003E_002DGetTags_003Ed__ = new _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIntraTextSpacerTag_003E_002DGetTags_003Ed__72(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIntraTextSpacerTag_003E_002DGetTags_003Ed__.snapshotRanges = _003C_003E3__snapshotRanges;
			_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIntraTextSpacerTag_003E_002DGetTags_003Ed__.parameter = _003C_003E3__parameter;
			return _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIntraTextSpacerTag_003E_002DGetTags_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<TagSnapshotRange<IIntraTextSpacerTag>>)this).GetEnumerator();
		}

		internal static bool zHd()
		{
			return LHc == null;
		}

		internal static _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIntraTextSpacerTag_003E_002DGetTags_003Ed__72 kHT()
		{
			return LHc;
		}
	}

	[CompilerGenerated]
	private sealed class _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DICollapsedRegionTag_003E_002DGetTags_003Ed__73 : IEnumerable<TagSnapshotRange<ICollapsedRegionTag>>, IEnumerable, IEnumerator<TagSnapshotRange<ICollapsedRegionTag>>, IDisposable, IEnumerator
	{
		private int _003C_003E1__state;

		private TagSnapshotRange<ICollapsedRegionTag> _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private NormalizedTextSnapshotRangeCollection snapshotRanges;

		public NormalizedTextSnapshotRangeCollection _003C_003E3__snapshotRanges;

		private object parameter;

		public object _003C_003E3__parameter;

		public CM _003C_003E4__this;

		private ITextView _003Cview_003E5__1;

		private IPrinterView _003CprinterView_003E5__2;

		private object _003C_003Es__3;

		private bool _003C_003Es__4;

		private xp _003Cwalker_003E5__5;

		private IEnumerator<TextSnapshotRange> _003C_003Es__6;

		private TextSnapshotRange _003CsnapshotRange_003E5__7;

		private bool _003CisFirst_003E5__8;

		private IOutliningNode _003Cnode_003E5__9;

		private string _003CcollapsedText_003E5__10;

		private Size _003CtextSize_003E5__11;

		private double _003Cbaseline_003E5__12;

		private Typeface _003Ctypeface_003E5__13;

		private FormattedText _003CformattedText_003E5__14;

		private static _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DICollapsedRegionTag_003E_002DGetTags_003Ed__73 CHt;

		TagSnapshotRange<ICollapsedRegionTag> IEnumerator<TagSnapshotRange<ICollapsedRegionTag>>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DICollapsedRegionTag_003E_002DGetTags_003Ed__73(int _003C_003E1__state)
		{
			grA.DaB7cz();
			base._002Ector();
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if ((uint)(num - -4) > 1u && num != 1)
			{
				return;
			}
			try
			{
				if (num != -4 && num != 1)
				{
					return;
				}
				try
				{
				}
				finally
				{
					_003C_003Em__Finally2();
				}
			}
			finally
			{
				_003C_003Em__Finally1();
			}
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				if (num != 0)
				{
					goto IL_031e;
				}
				_003C_003E1__state = -1;
				if (snapshotRanges == null)
				{
					goto IL_02c1;
				}
				_003Cview_003E5__1 = parameter as ITextView;
				_003CprinterView_003E5__2 = _003Cview_003E5__1 as IPrinterView;
				if (_003CprinterView_003E5__2 != null && !_003CprinterView_003E5__2.SyntaxEditor.PrintSettings.AreCollapsedOutliningNodesAllowed)
				{
					return false;
				}
				goto IL_047d;
				IL_032b:
				_003CsnapshotRange_003E5__7 = default(TextSnapshotRange);
				goto IL_01c4;
				IL_047d:
				_003C_003Es__3 = _003C_003E4__this.tvY;
				_003C_003Es__4 = false;
				_003C_003E1__state = -3;
				Monitor.Enter(_003C_003Es__3, ref _003C_003Es__4);
				_003Cwalker_003E5__5 = new xp(_003C_003E4__this, _003C_003E4__this.Hvj);
				_003C_003Es__6 = snapshotRanges.GetEnumerator();
				_003C_003E1__state = -4;
				goto IL_01c4;
				IL_03de:
				_003C_003Em__Finally2();
				_003C_003Es__6 = null;
				_003Cwalker_003E5__5 = null;
				_003C_003Em__Finally1();
				_003C_003Es__3 = null;
				_003Cview_003E5__1 = null;
				_003CprinterView_003E5__2 = null;
				goto IL_02c1;
				IL_01c4:
				int num3;
				if (!_003C_003Es__6.MoveNext())
				{
					int num2 = 3;
					num3 = num2;
				}
				else
				{
					_003CsnapshotRange_003E5__7 = _003C_003Es__6.Current;
					_003Cwalker_003E5__5.lm3(_003CsnapshotRange_003E5__7.StartOffset);
					_003Cwalker_003E5__5.Dm1();
					num3 = 2;
				}
				goto IL_0012;
				IL_031e:
				if (num == 1)
				{
					_003C_003E1__state = -4;
					_003Cnode_003E5__9 = null;
					num3 = 6;
					goto IL_0012;
				}
				goto IL_00dc;
				IL_02c1:
				return false;
				IL_0012:
				while (true)
				{
					switch (num3)
					{
					case 1:
						_003CtextSize_003E5__11 = new Size(21.0, 0.0);
						_003Cbaseline_003E5__12 = 0.0;
						if (_003Cview_003E5__1 != null)
						{
							_003Ctypeface_003E5__13 = new Typeface(_003Cview_003E5__1.DefaultFontFamilyName);
							_003CformattedText_003E5__14 = new FormattedText(_003CcollapsedText_003E5__10, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, _003Ctypeface_003E5__13, _003Cview_003E5__1.DefaultFontSize, Brushes.Black, null, TextOptions.GetTextFormattingMode(_003Cview_003E5__1.VisualElement));
							_003CtextSize_003E5__11 = new Size(_003CformattedText_003E5__14.WidthIncludingTrailingWhitespace, _003CformattedText_003E5__14.Height);
							_003Cbaseline_003E5__12 = _003CformattedText_003E5__14.Baseline;
							_003Ctypeface_003E5__13 = null;
							_003CformattedText_003E5__14 = null;
						}
						_003C_003E2__current = new TagSnapshotRange<ICollapsedRegionTag>(new TextSnapshotRange(_003CsnapshotRange_003E5__7.Snapshot, _003Cwalker_003E5__5.OmL(), _003Cwalker_003E5__5.Qm6()), new w7A
						{
							Key = _003Cwalker_003E5__5.tm8(),
							Text = _003CcollapsedText_003E5__10,
							Baseline = _003Cbaseline_003E5__12,
							Size = _003CtextSize_003E5__11
						});
						_003C_003E1__state = 1;
						return true;
					case 5:
						break;
					case 7:
						if (_003Cwalker_003E5__5.tm8().Gvq())
						{
							_003Cnode_003E5__9 = new oi(_003Cwalker_003E5__5.Umv());
							_003CcollapsedText_003E5__10 = (string)LvQ(_003Cnode_003E5__9);
							num3 = 1;
							if (DHb() == null)
							{
								num3 = 1;
							}
							continue;
						}
						goto IL_02e5;
					case 4:
						goto IL_031e;
					case 3:
						goto IL_03de;
					default:
						goto IL_047d;
					case 2:
						_003CisFirst_003E5__8 = true;
						goto IL_003d;
					case 6:
						{
							_003CcollapsedText_003E5__10 = null;
							_003CtextSize_003E5__11 = default(Size);
							goto IL_02e5;
						}
						IL_003d:
						if (_003CisFirst_003E5__8 || _003Cwalker_003E5__5.OmL() < _003CsnapshotRange_003E5__7.EndOffset)
						{
							_003CisFirst_003E5__8 = false;
							num3 = 7;
							continue;
						}
						goto IL_032b;
						IL_02e5:
						if (_003Cwalker_003E5__5.vml(_0020: true))
						{
							goto IL_003d;
						}
						goto IL_032b;
					}
					break;
				}
				goto IL_00dc;
				IL_00dc:
				return false;
			}
			catch
			{
				//try-fault
				((IDisposable)this).Dispose();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003Es__4)
			{
				Monitor.Exit(_003C_003Es__3);
			}
		}

		private void _003C_003Em__Finally2()
		{
			_003C_003E1__state = -3;
			if (_003C_003Es__6 != null)
			{
				_003C_003Es__6.Dispose();
			}
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		IEnumerator<TagSnapshotRange<ICollapsedRegionTag>> IEnumerable<TagSnapshotRange<ICollapsedRegionTag>>.GetEnumerator()
		{
			_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DICollapsedRegionTag_003E_002DGetTags_003Ed__73 _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DICollapsedRegionTag_003E_002DGetTags_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.CurrentManagedThreadId)
			{
				_003C_003E1__state = 0;
				_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DICollapsedRegionTag_003E_002DGetTags_003Ed__ = this;
			}
			else
			{
				_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DICollapsedRegionTag_003E_002DGetTags_003Ed__ = new _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DICollapsedRegionTag_003E_002DGetTags_003Ed__73(0)
				{
					_003C_003E4__this = _003C_003E4__this
				};
			}
			_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DICollapsedRegionTag_003E_002DGetTags_003Ed__.snapshotRanges = _003C_003E3__snapshotRanges;
			_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DICollapsedRegionTag_003E_002DGetTags_003Ed__.parameter = _003C_003E3__parameter;
			return _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DICollapsedRegionTag_003E_002DGetTags_003Ed__;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<TagSnapshotRange<ICollapsedRegionTag>>)this).GetEnumerator();
		}

		internal static bool YHY()
		{
			return CHt == null;
		}

		internal static _003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DICollapsedRegionTag_003E_002DGetTags_003Ed__73 DHb()
		{
			return CHt;
		}
	}

	private int cvm;

	private object RvC;

	private TextSnapshotRange Dvu;

	private OutliningMode tv1;

	private IEditorDocument AvF;

	private int iv3;

	private int WvR;

	private object tvY;

	private bool zv4;

	private bool uvo;

	private Jc Hvj;

	private WeakEventListener<CM, SyntaxLanguageChangedEventArgs> kvw;

	private WeakEventListener<CM, EventArgs> Lv6;

	private WeakEventListener<CM, TextSnapshotChangedEventArgs> HvH;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler Fvb;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private PropertyChangedEventHandler m_PropertyChanged;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<TagsChangedEventArgs> zvT;

	internal static CM I7B;

	public OutliningMode ActiveMode
	{
		get
		{
			return tv1;
		}
		set
		{
			if (tv1 != outliningMode)
			{
				vvD(outliningMode);
			}
		}
	}

	public IEditorDocument Document => AvF;

	public IOutliningNode RootNode
	{
		get
		{
			lock (tvY)
			{
				return new oi(new xp(this, Hvj));
			}
		}
	}

	string IKeyedObject.Key => Q7Z.tqM(11130);

	IEnumerable<Ordering> IOrderable.Orderings => null;

	IEnumerable<Type> ITextViewTaggerProvider.TagTypes => new Type[2]
	{
		typeof(ICollapsedRegionTag),
		typeof(IIntraTextSpacerTag)
	};

	public event EventHandler Closed
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = Fvb;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, b);
				eventHandler = Interlocked.CompareExchange(ref Fvb, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = Fvb;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value3);
				eventHandler = Interlocked.CompareExchange(ref Fvb, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, b);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.m_PropertyChanged;
			PropertyChangedEventHandler propertyChangedEventHandler2;
			do
			{
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
				propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
			}
			while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
		}
	}

	public event EventHandler<TagsChangedEventArgs> TagsChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<TagsChangedEventArgs> eventHandler = zvT;
			EventHandler<TagsChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TagsChangedEventArgs> value2 = (EventHandler<TagsChangedEventArgs>)Delegate.Combine(eventHandler2, b);
				eventHandler = Interlocked.CompareExchange(ref zvT, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<TagsChangedEventArgs> eventHandler = zvT;
			EventHandler<TagsChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TagsChangedEventArgs> value2 = (EventHandler<TagsChangedEventArgs>)Delegate.Remove(eventHandler2, value3);
				eventHandler = Interlocked.CompareExchange(ref zvT, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private int rAZ(IOutliningSource P_0, TextSnapshotRange P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11008));
		}
		int length = P_1.Snapshot.Length;
		int num = Math.Max(0, P_1.StartOffset - 10);
		int num2 = num;
		int num3 = Math.Min(length, P_1.EndOffset + 10);
		int num4 = num3;
		int num5 = int.MaxValue;
		Jc jc = null;
		int num6 = 50;
		xp xp2 = new xp(this, Hvj);
		xp2.lm3(num2);
		while (num2 < num4)
		{
			int val = xp2.Dme(num2);
			int offset = num2;
			IOutliningNodeDefinition definition;
			OutliningNodeAction outliningNodeAction = P_0.GetNodeAction(ref offset, out definition);
			OutliningNodeAction outliningNodeAction2 = outliningNodeAction;
			OutliningNodeAction outliningNodeAction3 = outliningNodeAction2;
			if ((uint)(outliningNodeAction3 - 1) <= 1u && definition == null)
			{
				throw new ArgumentException(SR.GetString(SRName.ExNoOutliningSourceDefinitionReturned));
			}
			if (outliningNodeAction == OutliningNodeAction.Start && xp2.NmB() > num6)
			{
				outliningNodeAction = OutliningNodeAction.None;
			}
			switch (outliningNodeAction)
			{
			case OutliningNodeAction.Start:
			{
				bool flag = true;
				if (!xp2.tm8().CvM() && xp2.OmL() == num2)
				{
					if (xp2.tm8().lvr().Key != definition.Key)
					{
						num3 = Math.Max(num3, xp2.Qm6() - 1);
						num4 = Math.Max(num4, num3);
						xp2.Cm4(_0020: true);
						if (num4 > num3 && xp2.NmB() < num5)
						{
							jc = null;
							num4 = num3;
							num5 = int.MaxValue;
						}
					}
					else
					{
						flag = false;
					}
				}
				else if (xp2.Qm6() - 1 == num2)
				{
					xp xp4 = xp2.Umv();
					while (!xp4.tm8().CvM() && xp4.Qm6() - 1 == num2)
					{
						if (!xp4.tm8().Hvi())
						{
							xp4.smY();
						}
						jc = xp4.tm8();
						num4 = Math.Max(num4, xp4.Qm6() - 1);
						num5 = Math.Min(num5, xp4.NmB());
						xp4.AmR();
					}
				}
				if (flag)
				{
					xp2.GmQ(definition, num2);
					jc = xp2.tm8();
					num4 = Math.Max(num4, xp2.Qm6() - 1);
					num5 = Math.Min(num5, xp2.NmB());
				}
				break;
			}
			case OutliningNodeAction.End:
			{
				if (!xp2.tm8().CvM() && xp2.OmL() == num2)
				{
					num3 = Math.Max(num3, xp2.Qm6() - 1);
					num4 = Math.Max(num4, num3);
					xp2.Cm4(_0020: true);
					if (num4 > num3 && xp2.NmB() < num5)
					{
						jc = null;
						num4 = num3;
						num5 = int.MaxValue;
					}
				}
				xp xp5 = xp2.Umv();
				while (!xp5.tm8().CvM() && xp5.tm8().lvr().Key != definition.Key)
				{
					xp5.AmR();
				}
				if (xp5.tm8().CvM() || !(xp5.tm8().lvr().Key == definition.Key) || (!xp5.tm8().Hvi() && xp5.Qm6() <= num2 + 1))
				{
					break;
				}
				xp2 = xp5;
				if (xp2.tm8() != jc)
				{
					num3 = Math.Max(num3, xp2.Qm6() - 1);
				}
				num4 = Math.Max(num4, num3);
				xp2.ymC(num2 + 1);
				if (!xp2.tm8().CvM() && xp2.Qm6() - 1 == num2)
				{
					xp xp6 = xp2.Umv();
					while (!xp6.tm8().CvM() && xp6.Qm6() - 1 == num2)
					{
						if (!xp6.tm8().Hvi())
						{
							xp6.smY();
						}
						jc = xp6.tm8();
						num4 = Math.Max(num4, xp6.Qm6() - 1);
						num5 = Math.Min(num5, xp6.NmB());
						xp6.AmR();
					}
				}
				if (num4 > num3 && xp2.NmB() < num5)
				{
					jc = null;
					num4 = num3;
					num5 = int.MaxValue;
				}
				break;
			}
			case OutliningNodeAction.None:
				if (!xp2.tm8().CvM() && xp2.OmL() == num2)
				{
					num3 = Math.Max(num3, xp2.Qm6() - 1);
					num4 = Math.Max(num4, num3);
					xp2.Cm4(_0020: true);
					if (num4 > num3 && xp2.NmB() < num5)
					{
						jc = null;
						num4 = num3;
						num5 = int.MaxValue;
					}
				}
				else
				{
					if (xp2.Qm6() - 1 != num2)
					{
						break;
					}
					xp xp3 = xp2.Umv();
					while (!xp3.tm8().CvM() && xp3.Qm6() - 1 == num2)
					{
						if (!xp3.tm8().Hvi())
						{
							xp3.smY();
						}
						jc = xp3.tm8();
						num4 = Math.Max(num4, xp3.Qm6() - 1);
						num5 = Math.Min(num5, xp3.NmB());
						xp3.AmR();
					}
				}
				break;
			}
			if (num2 >= length)
			{
				break;
			}
			num2 = Math.Max(num2 + 1, Math.Min(offset, val));
		}
		if (zv4)
		{
			WvP();
			zv4 = false;
		}
		return num2 - num;
	}

	private void iAh()
	{
		bool flag = false;
		TextSnapshotRange dvu;
		lock (RvC)
		{
			dvu = Dvu;
			if (cvm > 0)
			{
				cvm--;
			}
			flag = cvm == 0;
			if (flag)
			{
				Dvu = TextSnapshotRange.Deleted;
			}
		}
		if (flag && !dvu.IsDeleted)
		{
			OnTagsChanged(new TagsChangedEventArgs(dvu));
		}
	}

	internal void lAN(TextSnapshotRange P_0)
	{
		P_0 = P_0.TranslateTo(Document.CurrentSnapshot, TextRangeTrackingModes.ExpandBothEdges);
		if (!P_0.IsDeleted)
		{
			if (cvm <= 0)
			{
				OnTagsChanged(new TagsChangedEventArgs(P_0));
			}
			else if (!Dvu.IsDeleted)
			{
				Dvu = new TextSnapshotRange(P_0.Snapshot, TextRange.Union(Dvu.TextRange, P_0.TextRange));
			}
			else
			{
				Dvu = P_0;
			}
		}
	}

	private void uAd()
	{
		lock (RvC)
		{
			cvm++;
		}
	}

	internal void AAz(xp P_0, bool? P_1)
	{
		if (!P_0.tm8().CvM())
		{
			if (!P_1.HasValue)
			{
				P_1 = !P_0.tm8().Gvq();
			}
			if (P_0.tm8().Gvq() != P_1.Value)
			{
				P_0.tm8().ev2(P_1.Value);
				lAN(P_0.tmb());
			}
		}
	}

	public IDisposable kvW()
	{
		return new V7T(this);
	}

	[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
	public CM(IEditorDocument P_0)
	{
		grA.DaB7cz();
		RvC = new object();
		Dvu = TextSnapshotRange.Deleted;
		tv1 = OutliningMode.Automatic;
		tvY = new object();
		zv4 = true;
		_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals10 = new _003C_003Ec__DisplayClass28_0();
		CS_0024_003C_003E8__locals10.RV7 = P_0;
		base._002Ector();
		if (CS_0024_003C_003E8__locals10.RV7 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11024));
		}
		AvF = CS_0024_003C_003E8__locals10.RV7;
		iv3 = CS_0024_003C_003E8__locals10.RV7.CurrentSnapshot.Length;
		kvw = new WeakEventListener<CM, SyntaxLanguageChangedEventArgs>(this, delegate(CM instance, object source, SyntaxLanguageChangedEventArgs eventArgs)
		{
			instance.svx(source, eventArgs);
		}, delegate(WeakEventListener<CM, SyntaxLanguageChangedEventArgs> weakEventListener)
		{
			CS_0024_003C_003E8__locals10.RV7.RemoveLanguageChangedEventHandler(weakEventListener.OnEvent, EventHandlerPriority.Low);
		});
		int num = 0;
		if (0 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				CS_0024_003C_003E8__locals10.RV7.AddLanguageChangedEventHandler(kvw.OnEvent, EventHandlerPriority.Low);
				num = 1;
				if (false)
				{
					int num2;
					num = num2;
				}
				break;
			case 1:
				Lv6 = new WeakEventListener<CM, EventArgs>(this, delegate(CM instance, object source, EventArgs eventArgs)
				{
					instance.gvG(source, eventArgs);
				}, delegate(WeakEventListener<CM, EventArgs> weakEventListener)
				{
					CS_0024_003C_003E8__locals10.RV7.ParseDataChanged -= weakEventListener.OnEvent;
				});
				CS_0024_003C_003E8__locals10.RV7.ParseDataChanged += Lv6.OnEvent;
				HvH = new WeakEventListener<CM, TextSnapshotChangedEventArgs>(this, delegate(CM instance, object source, TextSnapshotChangedEventArgs eventArgs)
				{
					instance.HvX(source, eventArgs);
				}, delegate(WeakEventListener<CM, TextSnapshotChangedEventArgs> weakEventListener)
				{
					CS_0024_003C_003E8__locals10.RV7.TextChanged -= weakEventListener.OnEvent;
				});
				CS_0024_003C_003E8__locals10.RV7.TextChanged += HvH.OnEvent;
				wvf(_0020: true);
				return;
			}
		}
	}

	private void WvP()
	{
		dvE((Jc treeNode) => treeNode.lvr().IsDefaultCollapsed, _0020: false);
	}

	private void dvE(Predicate<Jc> P_0, bool P_1)
	{
		xp xp2 = new xp(this, Hvj);
		while (xp2.vml(P_1))
		{
			if (!xp2.tm8().CvM() && P_0(xp2.tm8()))
			{
				AAz(xp2, true);
			}
		}
	}

	private void Bvc(IOutliningNode P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		int num2 = default(int);
		foreach (IOutliningNode item in P_0)
		{
			if (item == null || item.IsCollapsed)
			{
				break;
			}
			TextPosition startPosition = item.SnapshotRange.StartPosition;
			int num = 0;
			if (e77() != null)
			{
				num = num2;
			}
			switch (num)
			{
			default:
				if (startPosition.Line == P_0.SnapshotRange.StartPosition.Line)
				{
					Bvc(item);
					continue;
				}
				break;
			}
			break;
		}
		P_0.IsCollapsed = true;
	}

	[SpecialName]
	internal int lve()
	{
		return iv3;
	}

	private IOutliningSource Uva(ref AutomaticOutliningUpdateTrigger? P_0)
	{
		AutomaticOutliningUpdateTrigger? automaticOutliningUpdateTrigger = P_0;
		P_0 = null;
		IOutliner outliner = ((AvF != null && AvF.Language != null) ? AvF.Language.GetService<IOutliner>() : null);
		int num = 0;
		if (e77() != null)
		{
			num = 0;
		}
		IOutliningSource result = default(IOutliningSource);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (outliner != null)
				{
					P_0 = outliner.UpdateTrigger;
					if (!automaticOutliningUpdateTrigger.HasValue || outliner.UpdateTrigger == automaticOutliningUpdateTrigger)
					{
						IOutliningSource outliningSource = outliner.GetOutliningSource(AvF.CurrentSnapshot);
						if (outliningSource != null)
						{
							result = outliningSource;
							break;
						}
					}
				}
				result = null;
				num = 1;
				if (e77() != null)
				{
					num = num2;
				}
				continue;
			case 1:
				break;
			}
			break;
		}
		return result;
	}

	[SpecialName]
	private bool mvA()
	{
		IOutliner outliner = ((AvF != null && AvF.Language != null) ? AvF.Language.GetService<IOutliner>() : null);
		return outliner != null;
	}

	private void svx(object P_0, SyntaxLanguageChangedEventArgs P_1)
	{
		using (kvW())
		{
			lock (tvY)
			{
				wvf(_0020: true);
				vvD(null);
				IvK(null, AvF.CurrentSnapshot.SnapshotRange, _0020: true);
			}
		}
	}

	private void gvG(object P_0, EventArgs P_1)
	{
		if (tv1 != OutliningMode.Automatic)
		{
			return;
		}
		using (kvW())
		{
			lock (tvY)
			{
				uvo = AvF.CurrentSnapshot.Version.Number > WvR;
				if (!uvo)
				{
					IvK(AutomaticOutliningUpdateTrigger.ParseDataChanged, AvF.CurrentSnapshot.SnapshotRange, _0020: false);
				}
			}
		}
	}

	private void HvX(object P_0, TextSnapshotChangedEventArgs P_1)
	{
		using (kvW())
		{
			lock (tvY)
			{
				WvR = P_1.NewSnapshot.Version.Number;
				int lastTextReplacementOperationIndex = P_1.TextChange.LastTextReplacementOperationIndex;
				TextSnapshotRange textSnapshotRange = P_1.ChangedSnapshotRange;
				int num4;
				if (lastTextReplacementOperationIndex == -1 && P_1.TextChange.Operations.Count <= 250)
				{
					xp xp2 = new xp(this, Hvj);
					int num3 = default(int);
					foreach (ITextChangeOperation operation in P_1.TextChange.Operations)
					{
						if (operation.HasDeletion)
						{
							int num = xp2.vmj(operation.StartOffset, operation.DeletionLength);
							if (num > textSnapshotRange.EndOffset)
							{
								textSnapshotRange = new TextSnapshotRange(textSnapshotRange.Snapshot, textSnapshotRange.StartOffset, num);
							}
						}
						if (operation.HasInsertion)
						{
							xp2.Amw(operation.StartOffset, operation.InsertionLength);
							int num2 = 0;
							if (e77() != null)
							{
								num2 = num3;
							}
							switch (num2)
							{
							}
						}
						iv3 = Math.Max(0, iv3 + operation.LengthDelta);
					}
					iv3 = P_1.NewSnapshot.Length;
				}
				else
				{
					wvf(_0020: false);
					if (lastTextReplacementOperationIndex != -1)
					{
						zv4 |= P_1.TextChange.Operations[lastTextReplacementOperationIndex].IsProgrammaticTextReplacement;
						num4 = 0;
						if (t70())
						{
							num4 = 0;
						}
						goto IL_0038;
					}
				}
				goto IL_012f;
				IL_012f:
				IvK(AutomaticOutliningUpdateTrigger.TextChanged, textSnapshotRange, _0020: false);
				bool flag = uvo;
				num4 = 1;
				if (e77() != null)
				{
					int num5 = default(int);
					num4 = num5;
				}
				goto IL_0038;
				IL_0038:
				switch (num4)
				{
				case 1:
					if (flag)
					{
						IvK(AutomaticOutliningUpdateTrigger.ParseDataChanged, AvF.CurrentSnapshot.SnapshotRange, _0020: false);
						uvo = false;
					}
					return;
				}
				goto IL_012f;
			}
		}
	}

	private void IvK(AutomaticOutliningUpdateTrigger? P_0, TextSnapshotRange P_1, bool P_2)
	{
		if (tv1 != OutliningMode.Automatic || !mvA() || AvF == null)
		{
			return;
		}
		IOutliningSource outliningSource = Uva(ref P_0);
		if (outliningSource != null)
		{
			if (P_2 && P_0 == AutomaticOutliningUpdateTrigger.TextChanged)
			{
				zv4 = true;
			}
			rAZ(outliningSource, P_1);
			if (P_2 && P_0 == AutomaticOutliningUpdateTrigger.ParseDataChanged)
			{
				zv4 = true;
			}
		}
	}

	private void wvf(bool P_0)
	{
		iv3 = ((AvF != null) ? AvF.CurrentSnapshot.Length : 0);
		if (P_0)
		{
			uvo = false;
		}
		bool flag = Hvj != null && Hvj.iv9();
		OutliningNodeDefinition outliningNodeDefinition = new OutliningNodeDefinition(Q7Z.tqM(11044))
		{
			IsCollapsible = false
		};
		Jc jc = new Jc(outliningNodeDefinition);
		jc.lvO(_0020: true);
		Hvj = jc;
		if (flag && AvF != null)
		{
			lAN(AvF.CurrentSnapshot.SnapshotRange);
		}
	}

	internal void vvD(OutliningMode? P_0)
	{
		using (kvW())
		{
			lock (tvY)
			{
				OutliningMode outliningMode = ((AvF != null) ? AvF.OutliningMode : OutliningMode.None);
				OutliningMode outliningMode2;
				if (!P_0.HasValue)
				{
					outliningMode2 = ((outliningMode != OutliningMode.Default) ? outliningMode : (mvA() ? OutliningMode.Automatic : OutliningMode.Manual));
				}
				else
				{
					outliningMode2 = P_0.Value;
					if (outliningMode2 == OutliningMode.Default)
					{
						outliningMode2 = (mvA() ? OutliningMode.Automatic : OutliningMode.Manual);
					}
					OutliningMode outliningMode3 = outliningMode2;
					OutliningMode outliningMode4 = outliningMode3;
					if ((uint)(outliningMode4 - 1) <= 1u && outliningMode != OutliningMode.Default && outliningMode2 != outliningMode)
					{
						outliningMode2 = outliningMode;
					}
				}
				if (tv1 == outliningMode2)
				{
					return;
				}
				tv1 = outliningMode2;
				wvf(_0020: true);
				if (tv1 == OutliningMode.Automatic)
				{
					AutomaticOutliningUpdateTrigger? automaticOutliningUpdateTrigger = null;
					IOutliningSource outliningSource = Uva(ref automaticOutliningUpdateTrigger);
					if (outliningSource != null)
					{
						rAZ(outliningSource, AvF.CurrentSnapshot.SnapshotRange);
					}
				}
				Yvg(Q7Z.tqM(11060));
			}
		}
	}

	public void AddManualNode(TextSnapshotRange P_0, IOutliningNodeDefinition P_1)
	{
		if (tv1 != OutliningMode.Manual)
		{
			return;
		}
		using (kvW())
		{
			lock (tvY)
			{
				if (P_0.Snapshot.Document != AvF)
				{
					return;
				}
				P_0 = P_0.TranslateTo(AvF.CurrentSnapshot, TextRangeTrackingModes.DeleteWhenZeroLength);
				if (!P_0.IsDeleted && !P_0.IsZeroLength)
				{
					if (P_1 == null)
					{
						P_1 = new OutliningNodeDefinition(Q7Z.tqM(11084))
						{
							IsDefaultCollapsed = true
						};
					}
					xp xp2 = new xp(this, Hvj);
					xp2.lm3(P_0.StartOffset);
					if (xp2.wmg(P_1, P_0.TextRange) && P_1.IsDefaultCollapsed)
					{
						AAz(xp2, true);
					}
				}
			}
		}
	}

	public void ApplyDefaultOutliningExpansion()
	{
		using (kvW())
		{
			lock (tvY)
			{
				xp xp2 = new xp(this, Hvj);
				while (xp2.vml(_0020: false))
				{
					Jc jc = xp2.tm8();
					bool flag = jc.lvr() != null && jc.lvr().IsDefaultCollapsed;
					if (jc.Gvq() != flag)
					{
						AAz(xp2, flag);
					}
				}
			}
		}
	}

	public void Close()
	{
		wvf(_0020: true);
		if (AvF != null)
		{
			if (kvw != null)
			{
				kvw.Detach();
				kvw = null;
			}
			if (Lv6 != null)
			{
				Lv6.Detach();
				Lv6 = null;
			}
			if (HvH != null)
			{
				HvH.Detach();
				HvH = null;
			}
			AvF = null;
		}
		Fvb?.Invoke(this, EventArgs.Empty);
	}

	public void CollapseToDefinitions()
	{
		using (kvW())
		{
			lock (tvY)
			{
				dvE((Jc treeNode) => treeNode.lvr().IsImplementation, _0020: true);
			}
		}
	}

	public void EnsureExpanded(TextSnapshotOffset P_0)
	{
		if (P_0.Snapshot.Document != AvF)
		{
			return;
		}
		P_0 = P_0.TranslateTo(AvF.CurrentSnapshot, TextOffsetTrackingMode.Negative);
		if (P_0.IsDeleted)
		{
			return;
		}
		using (kvW())
		{
			lock (tvY)
			{
				xp xp2 = new xp(this, Hvj);
				xp2.lm3(P_0.Offset);
				while (xp2.tm8() != null && !xp2.tm8().CvM())
				{
					AAz(xp2, false);
					xp2.AmR();
				}
			}
		}
	}

	public void ExpandAllOutlining()
	{
		using (kvW())
		{
			lock (tvY)
			{
				xp xp2 = new xp(this, Hvj);
				while (xp2.vml(_0020: false))
				{
					if (xp2.tm8().Gvq())
					{
						AAz(xp2, false);
					}
				}
			}
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public OutliningState GetOutliningState(TextSnapshotRange P_0)
	{
		OutliningState outliningState = OutliningState.None;
		lock (tvY)
		{
			if (P_0.Snapshot.Document != AvF)
			{
				return outliningState;
			}
			P_0 = P_0.TranslateTo(AvF.CurrentSnapshot, TextRangeTrackingModes.DeleteWhenZeroLength);
			if (P_0.IsDeleted)
			{
				return outliningState;
			}
			xp xp2 = new xp(this, Hvj);
			xp2.lm3(Math.Max(0, P_0.StartOffset - 1));
			if (!xp2.tm8().CvM())
			{
				bool flag = xp2.OmL() == P_0.StartOffset;
				xp xp3 = xp2.ymm();
				while (!xp3.tm8().CvM())
				{
					if (xp3.tm8().lvr().IsCollapsible)
					{
						flag = false;
						if (xp3.Qm6() > P_0.EndOffset)
						{
							outliningState |= OutliningState.IsOpen;
							break;
						}
					}
					xp3.AmR();
				}
				if (flag)
				{
					outliningState |= OutliningState.IsTopLevel;
				}
			}
			else
			{
				outliningState |= OutliningState.IsTopLevel;
			}
			while (xp2.OmL() <= P_0.EndOffset)
			{
				if (xp2.tm8().lvr().IsCollapsible)
				{
					if (P_0.Contains(xp2.OmL()))
					{
						outliningState = (OutliningState)((int)outliningState | (xp2.tm8().Gvq() ? 2 : 4));
					}
					if ((outliningState & (OutliningState.HasExpandedNodeEnd | OutliningState.IsOpen)) != (OutliningState.HasExpandedNodeEnd | OutliningState.IsOpen))
					{
						bool flag2 = true;
						if (xp2.Qm6() <= P_0.EndOffset)
						{
							if (!xp2.tm8().Hvi() || P_0.EndOffset < AvF.CurrentSnapshot.Length)
							{
								flag2 = false;
							}
							else if (xp2.tm8().lvr() != null && !xp2.tm8().lvr().HasEndDelimiter && P_0.EndOffset == AvF.CurrentSnapshot.Length)
							{
								xp xp4 = xp2.ymm();
								while (!xp4.tm8().CvM())
								{
									if (!xp4.tm8().Hvi())
									{
										flag2 = false;
										break;
									}
									if (xp4.tm8().lvr() != null && !xp4.tm8().lvr().HasEndDelimiter)
									{
										xp4.AmR();
										continue;
									}
									break;
								}
							}
						}
						if (!flag2)
						{
							if (!xp2.tm8().Gvq())
							{
								outliningState |= OutliningState.HasExpandedNodeEnd;
							}
						}
						else
						{
							outliningState |= OutliningState.IsOpen;
						}
					}
				}
				if (!xp2.vml(_0020: true))
				{
					break;
				}
			}
		}
		return outliningState;
	}

	public IEnumerable<IOutliningNode> GetStartingNodes(TextSnapshotRange P_0)
	{
		lock (tvY)
		{
			if (P_0.Snapshot.Document != AvF)
			{
				yield break;
			}
			P_0 = P_0.TranslateTo(AvF.CurrentSnapshot, TextRangeTrackingModes.DeleteWhenZeroLength);
			if (P_0.IsDeleted || P_0.IsZeroLength)
			{
				yield break;
			}
			xp walker = new xp(this, Hvj);
			walker.lm3(P_0.StartOffset);
			while (walker.OmL() < P_0.EndOffset)
			{
				if (walker.tm8().lvr().IsCollapsible && P_0.Contains(walker.OmL()))
				{
					yield return new oi(walker.Umv());
				}
				if (walker.vml(_0020: true))
				{
					continue;
				}
				break;
			}
		}
	}

	protected void Yvg(string P_0)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(P_0));
	}

	public void RemoveAllManualNodes()
	{
		if (tv1 == OutliningMode.Manual)
		{
			wvf(_0020: true);
		}
	}

	public void RemoveManualNode(TextSnapshotOffset P_0)
	{
		if (tv1 != OutliningMode.Manual)
		{
			return;
		}
		using (kvW())
		{
			lock (tvY)
			{
				if (P_0.Snapshot.Document != AvF)
				{
					return;
				}
				int num2 = default(int);
				while (true)
				{
					P_0 = P_0.TranslateTo(AvF.CurrentSnapshot, TextOffsetTrackingMode.Negative);
					if (P_0.IsDeleted)
					{
						break;
					}
					xp xp2 = new xp(this, Hvj);
					xp2.lm3(P_0.Offset);
					int num = 0;
					if (!t70())
					{
						num = num2;
					}
					switch (num)
					{
					case 1:
						continue;
					}
					if (P_0.Offset > 0)
					{
						xp xp3 = new xp(this, Hvj);
						xp3.lm3(P_0.Offset - 1);
						if (!xp3.tm8().CvM() && (xp2.tm8().CvM() || xp3.OmL() > xp2.OmL()))
						{
							xp2 = xp3;
						}
					}
					if (!xp2.tm8().CvM())
					{
						xp2.Cm4(_0020: true);
					}
					return;
				}
			}
		}
	}

	public void ToggleAllOutliningExpansion()
	{
		using (kvW())
		{
			lock (tvY)
			{
				xp xp2 = new xp(this, Hvj);
				bool flag = false;
				while (xp2.vml(_0020: false))
				{
					if (!xp2.tm8().CvM() && xp2.tm8().Gvq())
					{
						flag = true;
						AAz(xp2, false);
					}
				}
				if (!flag)
				{
					xp2.Wmo();
					while (xp2.vml(_0020: false))
					{
						AAz(xp2, true);
					}
				}
			}
		}
	}

	public void ToggleOutliningExpansion(TextSnapshotOffset P_0)
	{
		if (P_0.Snapshot.Document != AvF)
		{
			return;
		}
		P_0 = P_0.TranslateTo(AvF.CurrentSnapshot, TextOffsetTrackingMode.Negative);
		int num = 0;
		if (e77() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (P_0.IsDeleted)
		{
			return;
		}
		using (kvW())
		{
			lock (tvY)
			{
				xp xp2 = new xp(this, Hvj);
				xp2.lm3(P_0.Offset);
				if (P_0.Offset > 0)
				{
					xp xp3 = new xp(this, Hvj);
					xp3.lm3(P_0.Offset - 1);
					if (xp3.tm8().CvM())
					{
						int num3 = 0;
						if (!t70())
						{
							int num4 = default(int);
							num3 = num4;
						}
						switch (num3)
						{
						}
					}
					else if (xp2.tm8().CvM() || xp3.OmL() > xp2.OmL())
					{
						xp2 = xp3;
					}
				}
				AAz(xp2, null);
			}
		}
	}

	public void ToggleOutliningExpansion(ITextViewLine P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11110));
		}
		ITextView view = P_0.View;
		IOutliningManager outliningManager = view.SyntaxEditor.Document.OutliningManager;
		if (outliningManager == null)
		{
			return;
		}
		IEnumerable<IOutliningNode> startingNodes = outliningManager.GetStartingNodes(new TextSnapshotRange(view.CurrentSnapshot, P_0.StartOffset, P_0.EndOffsetIncludingLineTerminator));
		if (startingNodes != null)
		{
			bool flag = false;
			bool flag2 = true;
			TextRange deleted = TextRange.Deleted;
			foreach (IOutliningNode item in startingNodes)
			{
				if (item == null || !item.IsCollapsed)
				{
					continue;
				}
				TextRange textRange = item.SnapshotRange.TextRange;
				if (deleted.IsDeleted || !deleted.Contains(textRange))
				{
					deleted = textRange;
					item.IsCollapsed = false;
					flag2 = false;
					flag = true;
				}
				break;
			}
			if (flag2)
			{
				foreach (IOutliningNode item2 in startingNodes)
				{
					if (item2 != null && !item2.IsCollapsed)
					{
						Bvc(item2);
						flag = true;
					}
				}
			}
			if (flag)
			{
				return;
			}
		}
		ToggleOutliningExpansion(new TextSnapshotOffset(view.CurrentSnapshot, P_0.StartOffset));
	}

	IEnumerable<TagSnapshotRange<IIntraTextSpacerTag>> ITagger<IIntraTextSpacerTag>.GetTags(NormalizedTextSnapshotRangeCollection P_0, object P_1)
	{
		int num2 = default(int);
		while (true)
		{
			IL_00a2:
			ITagger<ICollapsedRegionTag> tagger = this;
			foreach (TagSnapshotRange<ICollapsedRegionTag> tagRange in tagger.GetTags(P_0, P_1))
			{
				w7A tag = tagRange.Tag as w7A;
				bool flag = tag != null;
				int num = 1;
				if (!_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIntraTextSpacerTag_003E_002DGetTags_003Ed__72.zHd())
				{
					goto IL_0016;
				}
				goto IL_001a;
				IL_0016:
				num = num2;
				goto IL_001a;
				IL_001a:
				while (true)
				{
					switch (num)
					{
					case 1:
						if (flag)
						{
							yield return tag.vVI(tagRange.SnapshotRange);
							break;
						}
						goto IL_0045;
					case 2:
						goto end_IL_001a;
					}
					goto IL_005a;
					IL_0045:
					num = 0;
					if (_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DIIntraTextSpacerTag_003E_002DGetTags_003Ed__72.kHT() == null)
					{
						continue;
					}
					goto IL_0016;
					continue;
					end_IL_001a:
					break;
				}
				goto IL_00a2;
				IL_005a:;
			}
			break;
		}
	}

	IEnumerable<TagSnapshotRange<ICollapsedRegionTag>> ITagger<ICollapsedRegionTag>.GetTags(NormalizedTextSnapshotRangeCollection P_0, object P_1)
	{
		if (P_0 == null)
		{
			yield break;
		}
		ITextView view = P_1 as ITextView;
		if (view is IPrinterView printerView && !printerView.SyntaxEditor.PrintSettings.AreCollapsedOutliningNodesAllowed)
		{
			yield break;
		}
		TextSnapshotRange snapshotRange = default(TextSnapshotRange);
		string collapsedText = default(string);
		bool isFirst = default(bool);
		while (true)
		{
			lock (tvY)
			{
				xp walker = new xp(this, Hvj);
				using IEnumerator<TextSnapshotRange> enumerator = P_0.GetEnumerator();
				while (true)
				{
					IL_01c4:
					int num2;
					if (!enumerator.MoveNext())
					{
						int num = 3;
						num2 = num;
					}
					else
					{
						snapshotRange = enumerator.Current;
						walker.lm3(snapshotRange.StartOffset);
						walker.Dm1();
						num2 = 2;
					}
					while (true)
					{
						switch (num2)
						{
						case 6:
							collapsedText = null;
							goto IL_00d2;
						case 1:
						{
							Size textSize = new Size(21.0, 0.0);
							double baseline = 0.0;
							if (view != null)
							{
								FormattedText formattedText = new FormattedText(typeface: new Typeface(view.DefaultFontFamilyName), textToFormat: collapsedText, culture: CultureInfo.CurrentCulture, flowDirection: FlowDirection.LeftToRight, emSize: view.DefaultFontSize, foreground: Brushes.Black, numberSubstitution: null, textFormattingMode: TextOptions.GetTextFormattingMode(view.VisualElement));
								textSize = new Size(formattedText.WidthIncludingTrailingWhitespace, formattedText.Height);
								baseline = formattedText.Baseline;
							}
							yield return new TagSnapshotRange<ICollapsedRegionTag>(new TextSnapshotRange(snapshotRange.Snapshot, walker.OmL(), walker.Qm6()), new w7A
							{
								Key = walker.tm8(),
								Text = collapsedText,
								Baseline = baseline,
								Size = textSize
							});
							goto IL_0098;
						}
						case 4:
						{
							int num3;
							if (num3 != 1)
							{
								yield break;
							}
							goto IL_0098;
						}
						case 7:
							if (walker.tm8().Gvq())
							{
								IOutliningNode node = new oi(walker.Umv());
								collapsedText = (string)LvQ(node);
								num2 = 1;
								if (_003CActiproSoftware_002DText_002DTagging_002DITagger_003CActiproSoftware_002DText_002DTagging_002DICollapsedRegionTag_003E_002DGetTags_003Ed__73.DHb() == null)
								{
									num2 = 1;
								}
								continue;
							}
							goto IL_00d2;
						case 3:
							yield break;
						case 2:
							isFirst = true;
							goto IL_003d;
						case 5:
							yield break;
							IL_0098:
							num2 = 6;
							continue;
							IL_003d:
							if (isFirst || walker.OmL() < snapshotRange.EndOffset)
							{
								isFirst = false;
								num2 = 7;
								continue;
							}
							goto IL_032b;
							IL_00d2:
							if (walker.vml(_0020: true))
							{
								goto IL_003d;
							}
							goto IL_032b;
						}
						break;
						IL_032b:
						snapshotRange = default(TextSnapshotRange);
						goto IL_01c4;
					}
					break;
				}
			}
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1004:GenericMethodsShouldProvideTypeParameter")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
	ITagger<p5> ITextViewTaggerProvider.GetTagger<p5>(ITextView P_0)
	{
		if (typeof(p5) == typeof(ICollapsedRegionTag) || typeof(p5) == typeof(IIntraTextSpacerTag))
		{
			return this as ITagger<p5>;
		}
		return null;
	}

	private static object LvQ(IOutliningNode P_0)
	{
		object result;
		if (P_0 != null)
		{
			if (P_0.Definition == null)
			{
				throw new ArgumentException(SR.GetString(SRName.ExNoOutliningNodeDefinition), Q7Z.tqM(11166));
			}
			object collapsedContent = P_0.Definition.GetCollapsedContent(P_0);
			if (collapsedContent != null)
			{
				if (!(collapsedContent is string text))
				{
					throw new ArgumentException(Q7Z.tqM(11178));
				}
				if (!string.IsNullOrEmpty(text))
				{
					result = text;
					goto IL_005d;
				}
			}
			result = Q7Z.tqM(11524);
			int num = 0;
			if (!t70())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			goto IL_005d;
		}
		throw new ArgumentNullException(Q7Z.tqM(11166));
		IL_005d:
		return result;
	}

	protected virtual void OnTagsChanged(TagsChangedEventArgs P_0)
	{
		zvT?.Invoke(this, P_0);
	}

	internal static bool t70()
	{
		return I7B == null;
	}

	internal static CM e77()
	{
		return I7B;
	}
}
