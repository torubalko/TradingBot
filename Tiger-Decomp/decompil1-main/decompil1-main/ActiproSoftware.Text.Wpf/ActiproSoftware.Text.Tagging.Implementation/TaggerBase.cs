using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Tagging.Implementation;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tagger")]
public abstract class TaggerBase<T> : ITagger<T>, IOrderable, IKeyedObject where T : ITag
{
	[Flags]
	private enum wC
	{

	}

	private class wa
	{
		private wC aql;

		internal static object Ocp;

		internal bool Yqg(wC P_0)
		{
			return (aql & P_0) == P_0;
		}

		internal void gqO(wC P_0, bool P_1)
		{
			if (P_1)
			{
				aql |= P_0;
			}
			else
			{
				aql &= ~P_0;
			}
		}

		public wa()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal static bool Qcm()
		{
			return Ocp == null;
		}

		internal static object zcS()
		{
			return Ocp;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public ICodeDocument newDocument;

		private static object gcB;

		public _003C_003Ec__DisplayClass14_0()
		{
			hHEYokUTtehNq5ji0d.BN1hJz();
			base._002Ector();
		}

		internal void wqi(WeakEventListener<TaggerBase<T>, SyntaxLanguageChangedEventArgs> weakEventListener)
		{
			newDocument.RemoveLanguageChangedEventHandler(weakEventListener.OnEvent, EventHandlerPriority.High);
		}

		internal static bool hcz()
		{
			return gcB == null;
		}

		internal static object afd()
		{
			return gcB;
		}
	}

	private wa h9R;

	private WeakEventListener<TaggerBase<T>, SyntaxLanguageChangedEventArgs> q9f;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler T9t;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler<TagsChangedEventArgs> M9Q;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ICodeDocument N9n;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string j9G;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IEnumerable<Ordering> T9e;

	internal static object gA2;

	public ICodeDocument Document
	{
		[CompilerGenerated]
		get
		{
			return N9n;
		}
		[CompilerGenerated]
		private set
		{
			N9n = value;
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return j9G;
		}
		[CompilerGenerated]
		private set
		{
			j9G = value;
		}
	}

	public IEnumerable<Ordering> Orderings
	{
		[CompilerGenerated]
		get
		{
			return T9e;
		}
		[CompilerGenerated]
		private set
		{
			T9e = value;
		}
	}

	public event EventHandler Closed
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = T9t;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref T9t, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = T9t;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref T9t, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler<TagsChangedEventArgs> TagsChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler<TagsChangedEventArgs> eventHandler = M9Q;
			EventHandler<TagsChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TagsChangedEventArgs> value2 = (EventHandler<TagsChangedEventArgs>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref M9Q, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<TagsChangedEventArgs> eventHandler = M9Q;
			EventHandler<TagsChangedEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<TagsChangedEventArgs> value2 = (EventHandler<TagsChangedEventArgs>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref M9Q, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	protected TaggerBase(string key, IEnumerable<Ordering> orderings, ICodeDocument document)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(key, orderings, document, isForLanguage: true);
	}

	protected TaggerBase(string key, IEnumerable<Ordering> orderings, ICodeDocument document, bool isForLanguage)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		h9R = new wa();
		base._002Ector();
		if (key == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5194));
		}
		if (document == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5516));
		}
		Key = key;
		Orderings = orderings;
		h9R.gqO((wC)4, isForLanguage);
		h9R.gqO((wC)1, _0020: true);
		ChangeDocument(document);
	}

	private void t9r(object P_0, SyntaxLanguageChangedEventArgs P_1)
	{
		Close();
	}

	private void B93(PropertyDictionary P_0)
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

	protected void ChangeDocument(ICodeDocument newDocument)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals5.newDocument = newDocument;
		bool flag = default(bool);
		int num;
		if (Document != null)
		{
			if (h9R.Yqg((wC)4))
			{
				flag = q9f != null;
				num = 1;
				if (tAq())
				{
					num = 1;
				}
				goto IL_0009;
			}
			goto IL_009b;
		}
		goto IL_014e;
		IL_0009:
		bool flag2 = default(bool);
		switch (num)
		{
		default:
			if (flag2)
			{
				q9f = new WeakEventListener<TaggerBase<T>, SyntaxLanguageChangedEventArgs>(this, delegate(TaggerBase<T> instance, object source, SyntaxLanguageChangedEventArgs eventArgs)
				{
					instance.t9r(source, eventArgs);
				}, delegate(WeakEventListener<TaggerBase<T>, SyntaxLanguageChangedEventArgs> weakEventListener)
				{
					CS_0024_003C_003E8__locals5.newDocument.RemoveLanguageChangedEventHandler(weakEventListener.OnEvent, EventHandlerPriority.High);
				});
				CS_0024_003C_003E8__locals5.newDocument.AddLanguageChangedEventHandler(q9f.OnEvent, EventHandlerPriority.High);
			}
			return;
		case 1:
			break;
		}
		if (flag)
		{
			q9f.Detach();
			q9f = null;
		}
		goto IL_009b;
		IL_009b:
		B93(Document.Properties);
		goto IL_014e;
		IL_014e:
		Document = CS_0024_003C_003E8__locals5.newDocument;
		if (CS_0024_003C_003E8__locals5.newDocument == null)
		{
			return;
		}
		flag2 = h9R.Yqg((wC)4);
		num = 0;
		if (!tAq())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0009;
	}

	public void Close()
	{
		if (h9R.Yqg((wC)1))
		{
			h9R.gqO((wC)1, _0020: false);
			OnClosed();
			T9t?.Invoke(this, EventArgs.Empty);
			ChangeDocument(null);
		}
	}

	public abstract IEnumerable<TagSnapshotRange<T>> GetTags(NormalizedTextSnapshotRangeCollection snapshotRanges, object parameter);

	protected virtual void OnClosed()
	{
	}

	protected virtual void OnTagsChanged(TagsChangedEventArgs e)
	{
		M9Q?.Invoke(this, e);
	}

	internal static bool tAq()
	{
		return gA2 == null;
	}

	internal static object dAc()
	{
		return gA2;
	}
}
