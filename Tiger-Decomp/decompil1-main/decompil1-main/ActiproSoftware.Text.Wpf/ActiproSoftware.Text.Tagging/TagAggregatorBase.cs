using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Tagging;

public abstract class TagAggregatorBase<T> : DisposableObject, ITagAggregator<T>, IDisposable where T : ITag
{
	private class CH
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private WeakEventListener<TagAggregatorBase<T>, EventArgs> jqL;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int Yqq;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ITagger<T> Hqs;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private WeakEventListener<TagAggregatorBase<T>, TagsChangedEventArgs> rqI;

		private static object Kcs;

		[SpecialName]
		[CompilerGenerated]
		public WeakEventListener<TagAggregatorBase<T>, EventArgs> bqV()
		{
			return jqL;
		}

		[SpecialName]
		[CompilerGenerated]
		public void JqB(WeakEventListener<TagAggregatorBase<T>, EventArgs> P_0)
		{
			jqL = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int LqA()
		{
			return Yqq;
		}

		[SpecialName]
		[CompilerGenerated]
		public void bqu(int P_0)
		{
			Yqq = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public ITagger<T> qqT()
		{
			return Hqs;
		}

		[SpecialName]
		[CompilerGenerated]
		public void gq2(ITagger<T> P_0)
		{
			Hqs = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public WeakEventListener<TagAggregatorBase<T>, TagsChangedEventArgs> Dqc()
		{
			return rqI;
		}

		[SpecialName]
		[CompilerGenerated]
		public void aqh(WeakEventListener<TagAggregatorBase<T>, TagsChangedEventArgs> P_0)
		{
			rqI = P_0;
		}

		public CH()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal static bool rc4()
		{
			return Kcs == null;
		}

		internal static object gcu()
		{
			return Kcs;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public ISyntaxLanguage newLanguage;

		internal static object zcR;

		public _003C_003Ec__DisplayClass14_0()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal void zq7(WeakEventListener<TagAggregatorBase<T>, CollectionChangeEventArgs<object>> weakEventListener)
		{
			newLanguage.ServiceAdded -= weakEventListener.OnEvent;
		}

		internal void xqM(WeakEventListener<TagAggregatorBase<T>, CollectionChangeEventArgs<object>> weakEventListener)
		{
			newLanguage.ServiceRemoved -= weakEventListener.OnEvent;
		}

		internal static bool Rc0()
		{
			return zcR == null;
		}

		internal static object zcN()
		{
			return zcR;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public ITagger<T> tagger;

		internal static object gcl;

		public _003C_003Ec__DisplayClass15_0()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal void bqC(WeakEventListener<TagAggregatorBase<T>, EventArgs> weakEventListener)
		{
			tagger.Closed -= weakEventListener.OnEvent;
		}

		internal void cqU(WeakEventListener<TagAggregatorBase<T>, TagsChangedEventArgs> weakEventListener)
		{
			tagger.TagsChanged -= weakEventListener.OnEvent;
		}

		internal static bool lco()
		{
			return gcl == null;
		}

		internal static object qcI()
		{
			return gcl;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public ICodeDocument newDocument;

		internal static object hcH;

		public _003C_003Ec__DisplayClass23_0()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal void kqa(WeakEventListener<TagAggregatorBase<T>, SyntaxLanguageChangedEventArgs> weakEventListener)
		{
			newDocument.LanguageChanged -= weakEventListener.OnEvent;
		}

		internal static bool Xc6()
		{
			return hcH == null;
		}

		internal static object dcE()
		{
			return hcH;
		}
	}

	private bool N9q;

	private ICodeDocument u9s;

	private bool o9I;

	private ISyntaxLanguage X97;

	private List<CH> h9M;

	private WeakEventListener<TagAggregatorBase<T>, SyntaxLanguageChangedEventArgs> f9w;

	private WeakEventListener<TagAggregatorBase<T>, CollectionChangeEventArgs<object>> E9H;

	private WeakEventListener<TagAggregatorBase<T>, CollectionChangeEventArgs<object>> F9P;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<TagsChangedEventArgs> g9p;

	private static object XnK;

	protected bool CanAttachToEvents => N9q;

	protected bool IsDisposed => o9I;

	public event EventHandler<TagsChangedEventArgs> TagsChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<TagsChangedEventArgs> eventHandler = g9p;
			EventHandler<TagsChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TagsChangedEventArgs> value2 = (EventHandler<TagsChangedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref g9p, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<TagsChangedEventArgs> eventHandler = g9p;
			EventHandler<TagsChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TagsChangedEventArgs> value2 = (EventHandler<TagsChangedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref g9p, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	protected TagAggregatorBase()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(canAttachToEvents: true);
	}

	protected TagAggregatorBase(bool canAttachToEvents)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		h9M = new List<CH>();
		base._002Ector();
		N9q = canAttachToEvents;
	}

	private void O9u(ISyntaxLanguage P_0)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals6 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals6.newLanguage = P_0;
		S92();
		X97 = CS_0024_003C_003E8__locals6.newLanguage;
		int num = 0;
		if (Kno() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (X97 != null)
		{
			E9H = new WeakEventListener<TagAggregatorBase<T>, CollectionChangeEventArgs<object>>(this, delegate(TagAggregatorBase<T> instance, object source, CollectionChangeEventArgs<object> eventArgs)
			{
				instance.n9h(source, eventArgs);
			}, delegate(WeakEventListener<TagAggregatorBase<T>, CollectionChangeEventArgs<object>> weakEventListener)
			{
				CS_0024_003C_003E8__locals6.newLanguage.ServiceAdded -= weakEventListener.OnEvent;
			});
			CS_0024_003C_003E8__locals6.newLanguage.ServiceAdded += E9H.OnEvent;
			F9P = new WeakEventListener<TagAggregatorBase<T>, CollectionChangeEventArgs<object>>(this, delegate(TagAggregatorBase<T> instance, object source, CollectionChangeEventArgs<object> eventArgs)
			{
				instance.n9h(source, eventArgs);
			}, delegate(WeakEventListener<TagAggregatorBase<T>, CollectionChangeEventArgs<object>> weakEventListener)
			{
				CS_0024_003C_003E8__locals6.newLanguage.ServiceRemoved -= weakEventListener.OnEvent;
			});
			CS_0024_003C_003E8__locals6.newLanguage.ServiceRemoved += F9P.OnEvent;
		}
	}

	private void G98(ITagger<T> P_0)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals7 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals7.tagger = P_0;
		foreach (CH item in h9M)
		{
			if (item.qqT() == CS_0024_003C_003E8__locals7.tagger)
			{
				int num = item.LqA();
				item.bqu(num + 1);
				return;
			}
		}
		CH cH = new CH();
		cH.gq2(CS_0024_003C_003E8__locals7.tagger);
		cH.bqu(1);
		CH cH2 = cH;
		h9M.Add(cH2);
		if (N9q)
		{
			cH2.JqB(new WeakEventListener<TagAggregatorBase<T>, EventArgs>(this, delegate(TagAggregatorBase<T> instance, object source, EventArgs eventArgs)
			{
				instance.b9d(source, eventArgs);
			}, delegate(WeakEventListener<TagAggregatorBase<T>, EventArgs> weakEventListener)
			{
				CS_0024_003C_003E8__locals7.tagger.Closed -= weakEventListener.OnEvent;
			}));
			CS_0024_003C_003E8__locals7.tagger.Closed += cH2.bqV().OnEvent;
			cH2.aqh(new WeakEventListener<TagAggregatorBase<T>, TagsChangedEventArgs>(this, delegate(TagAggregatorBase<T> instance, object source, TagsChangedEventArgs eventArgs)
			{
				instance.S9L(source, eventArgs);
			}, delegate(WeakEventListener<TagAggregatorBase<T>, TagsChangedEventArgs> weakEventListener)
			{
				CS_0024_003C_003E8__locals7.tagger.TagsChanged -= weakEventListener.OnEvent;
			}));
			CS_0024_003C_003E8__locals7.tagger.TagsChanged += cH2.Dqc().OnEvent;
		}
	}

	private void t9T()
	{
		if (h9M.Count == 0)
		{
			return;
		}
		foreach (CH item in h9M)
		{
			if (N9q)
			{
				if (item.bqV() != null)
				{
					item.bqV().Detach();
					item.JqB(null);
				}
				if (item.Dqc() != null)
				{
					item.Dqc().Detach();
					item.aqh(null);
				}
			}
			if (item.qqT() is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
		h9M.Clear();
	}

	private void S92()
	{
		if (X97 != null)
		{
			if (E9H != null)
			{
				E9H.Detach();
				E9H = null;
			}
			if (F9P != null)
			{
				F9P.Detach();
				F9P = null;
			}
			X97 = null;
			int num = 0;
			if (Kno() != null)
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
	}

	private void W9m()
	{
		if (o9I)
		{
			return;
		}
		int count = h9M.Count;
		t9T();
		IList<ITagger<T>> taggers = GetTaggers();
		if (taggers != null)
		{
			ITagger<T>[] array = OrderableHelper.Sort(taggers);
			Array.Reverse(array);
			ITagger<T>[] array2 = array;
			int num = 0;
			int num2 = 1;
			if (Kno() != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			case 1:
				if (num >= array2.Length)
				{
					break;
				}
				goto default;
			default:
			{
				ITagger<T> tagger = array2[num];
				G98(tagger);
				num++;
				goto case 1;
			}
			}
		}
		if (u9s != null && h9M.Count + count > 0)
		{
			OnTagsChanged(new TagsChangedEventArgs(new TextSnapshotRange(u9s.CurrentSnapshot, 0, u9s.CurrentSnapshot.Length)));
		}
	}

	private void x9c(object P_0, SyntaxLanguageChangedEventArgs P_1)
	{
		O9u(P_1.NewLanguage);
		Refresh();
	}

	private void n9h(object P_0, CollectionChangeEventArgs<object> P_1)
	{
		if (IsRefreshRequired(P_1.Item))
		{
			Refresh();
		}
	}

	private void b9d(object P_0, EventArgs P_1)
	{
		ITagger<T> tagger = (ITagger<T>)P_0;
		int num = h9M.Count - 1;
		int num4 = default(int);
		while (num >= 0)
		{
			CH cH = h9M[num];
			bool n9q;
			int num3;
			if (cH.qqT() == tagger)
			{
				int num2 = cH.LqA();
				cH.bqu(num2 - 1);
				if (cH.LqA() != 0)
				{
					break;
				}
				n9q = N9q;
				num3 = 0;
				if (!mnl())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			num--;
			continue;
			IL_0005:
			num3 = num4;
			goto IL_0009;
			IL_0009:
			do
			{
				switch (num3)
				{
				case 1:
					cH.Dqc().Detach();
					cH.aqh(null);
					break;
				default:
					if (!n9q)
					{
						break;
					}
					if (cH.bqV() != null)
					{
						cH.bqV().Detach();
						cH.JqB(null);
					}
					if (cH.Dqc() == null)
					{
						break;
					}
					goto IL_0090;
				}
				h9M.RemoveAt(num);
				return;
				IL_0090:
				num3 = 1;
			}
			while (mnl());
			goto IL_0005;
		}
	}

	private void S9L(object P_0, TagsChangedEventArgs P_1)
	{
		if (!o9I)
		{
			OnTagsChanged(P_1);
		}
	}

	protected void AttachDocument(ICodeDocument newDocument)
	{
		_003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals4 = new _003C_003Ec__DisplayClass23_0();
		CS_0024_003C_003E8__locals4.newDocument = newDocument;
		if (CS_0024_003C_003E8__locals4.newDocument == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5536));
		}
		if (o9I)
		{
			return;
		}
		DetachDocument();
		u9s = CS_0024_003C_003E8__locals4.newDocument;
		O9u(u9s.Language);
		if (N9q)
		{
			f9w = new WeakEventListener<TagAggregatorBase<T>, SyntaxLanguageChangedEventArgs>(this, delegate(TagAggregatorBase<T> instance, object source, SyntaxLanguageChangedEventArgs eventArgs)
			{
				instance.x9c(source, eventArgs);
			}, delegate(WeakEventListener<TagAggregatorBase<T>, SyntaxLanguageChangedEventArgs> weakEventListener)
			{
				CS_0024_003C_003E8__locals4.newDocument.LanguageChanged -= weakEventListener.OnEvent;
			});
			u9s.LanguageChanged += f9w.OnEvent;
		}
	}

	protected void DetachDocument()
	{
		if (u9s != null)
		{
			S92();
			if (N9q && f9w != null)
			{
				f9w.Detach();
				f9w = null;
			}
			u9s = null;
			int num = 0;
			if (!mnl())
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
	}

	protected override void Dispose(bool disposing)
	{
		if (!o9I)
		{
			o9I = true;
			t9T();
			DetachDocument();
		}
		base.Dispose(disposing);
	}

	public IEnumerable<TagSnapshotRange<T>> GetTags(params TextSnapshotRange[] snapshotRanges)
	{
		return GetTags(new NormalizedTextSnapshotRangeCollection(snapshotRanges), null);
	}

	public IEnumerable<TagSnapshotRange<T>> GetTags(NormalizedTextSnapshotRangeCollection snapshotRanges, object parameter)
	{
		if (u9s != null && snapshotRanges != null && snapshotRanges.Count > 0 && snapshotRanges[0].Snapshot != null && snapshotRanges[0].Snapshot.Document != u9s)
		{
			yield break;
		}
		foreach (CH taggerData in h9M)
		{
			IEnumerable<TagSnapshotRange<T>> taggerResults = taggerData.qqT().GetTags(snapshotRanges, parameter);
			if (taggerResults == null)
			{
				continue;
			}
			foreach (TagSnapshotRange<T> item in taggerResults)
			{
				yield return item;
			}
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Taggers")]
	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	[SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
	protected virtual IList<ITagger<T>> GetTaggers()
	{
		List<ITagger<T>> list = new List<ITagger<T>>();
		if (u9s != null)
		{
			IList<ICodeDocumentTaggerProvider> services = u9s.GetServices<ICodeDocumentTaggerProvider>();
			if (services != null)
			{
				foreach (ICodeDocumentTaggerProvider item in services)
				{
					IEnumerable<Type> tagTypes = item.TagTypes;
					if (tagTypes == null)
					{
						continue;
					}
					foreach (Type item2 in tagTypes)
					{
						if (item2 == typeof(T))
						{
							ITagger<T> tagger = item.GetTagger<T>(u9s);
							if (tagger != null)
							{
								list.Add(tagger);
							}
							break;
						}
					}
				}
			}
		}
		return list;
	}

	protected virtual bool IsRefreshRequired(object service)
	{
		bool result;
		if (service is ICodeDocumentTaggerProvider { TagTypes: var tagTypes })
		{
			if (tagTypes != null)
			{
				bool flag = false;
				foreach (Type item in tagTypes)
				{
					if (item == typeof(T))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					goto IL_0156;
				}
				result = false;
				int num = 0;
				if (!mnl())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 1:
					goto IL_0156;
				}
			}
			else
			{
				result = false;
			}
		}
		else
		{
			result = false;
		}
		goto IL_0088;
		IL_0088:
		return result;
		IL_0156:
		result = true;
		goto IL_0088;
	}

	protected virtual void OnTagsChanged(TagsChangedEventArgs e)
	{
		g9p?.Invoke(this, e);
	}

	protected void Refresh()
	{
		W9m();
	}

	internal static bool mnl()
	{
		return XnK == null;
	}

	internal static object Kno()
	{
		return XnK;
	}
}
