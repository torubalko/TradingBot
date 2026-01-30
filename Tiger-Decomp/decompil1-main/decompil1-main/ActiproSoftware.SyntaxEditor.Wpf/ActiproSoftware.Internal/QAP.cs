using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Internal;

internal class QAP<mAb> : TagAggregatorBase<mAb> where mAb : ITag
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public QAP<mAb> _003C_003E4__this;

		public TagsChangedEventArgs e;

		internal static object Mf8;

		public _003C_003Ec__DisplayClass7_0()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal void xyy(object o)
		{
			_003C_003E4__this.wII(e);
		}

		internal static bool afU()
		{
			return Mf8 == null;
		}

		internal static object Lfe()
		{
			return Mf8;
		}
	}

	private ITextView RI0;

	internal static object g5w;

	public QAP(ITextView P_0, bool P_1)
	{
		grA.DaB7cz();
		base._002Ector(P_1);
		if (P_0 == null)
		{
			int num = 0;
			if (1 == 0)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			default:
				throw new ArgumentNullException(Q7Z.tqM(952));
			}
		}
		RI0 = P_0;
		if (P_1)
		{
			P_0.SyntaxEditor.DocumentChanged += SI5;
		}
		if (P_0.SyntaxEditor.Document != null)
		{
			AttachDocument(P_0.SyntaxEditor.Document);
		}
		Refresh();
	}

	private void wII(TagsChangedEventArgs P_0)
	{
		base.OnTagsChanged(P_0);
	}

	private void SI5(object P_0, EditorDocumentChangedEventArgs P_1)
	{
		DetachDocument();
		if (P_1.NewValue != null)
		{
			AttachDocument(P_1.NewValue);
		}
		Refresh();
	}

	protected override void Dispose(bool P_0)
	{
		base.Dispose(P_0);
		if (!P_0 || base.IsDisposed)
		{
			return;
		}
		bool flag = RI0 != null;
		int num = 0;
		if (X58() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (flag)
		{
			if (base.CanAttachToEvents && RI0.SyntaxEditor != null)
			{
				RI0.SyntaxEditor.DocumentChanged -= SI5;
			}
			RI0 = null;
		}
	}

	protected override IList<ITagger<mAb>> GetTaggers()
	{
		IList<ITagger<mAb>> taggers = base.GetTaggers();
		if (RI0 != null && RI0.SyntaxEditor != null)
		{
			IEnumerable<ITextViewTaggerProvider> enumerable = RI0.SyntaxEditor.jGF().g6Q<ITextViewTaggerProvider>(_0020: false, RI0);
			if (enumerable != null)
			{
				foreach (ITextViewTaggerProvider item in enumerable)
				{
					IEnumerable<Type> tagTypes = item.TagTypes;
					if (tagTypes == null)
					{
						continue;
					}
					foreach (Type item2 in tagTypes)
					{
						if (item2 == typeof(mAb))
						{
							ITagger<mAb> tagger = item.GetTagger<mAb>(RI0);
							if (tagger != null)
							{
								taggers.Add(tagger);
							}
							break;
						}
					}
				}
			}
		}
		return taggers;
	}

	protected override bool IsRefreshRequired(object P_0)
	{
		if (base.IsRefreshRequired(P_0))
		{
			return true;
		}
		if (!(P_0 is ITextViewTaggerProvider { TagTypes: var tagTypes }))
		{
			return false;
		}
		if (tagTypes == null)
		{
			return false;
		}
		bool flag = false;
		foreach (Type item in tagTypes)
		{
			if (item == typeof(mAb))
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			return false;
		}
		return true;
	}

	protected override void OnTagsChanged(TagsChangedEventArgs P_0)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals5 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals5._003C_003E4__this = this;
		CS_0024_003C_003E8__locals5.e = P_0;
		if (RI0 != null)
		{
			vAE.l0x<object>(RI0.SyntaxEditor, delegate
			{
				CS_0024_003C_003E8__locals5._003C_003E4__this.wII(CS_0024_003C_003E8__locals5.e);
			}, null);
		}
		else
		{
			base.OnTagsChanged(CS_0024_003C_003E8__locals5.e);
		}
	}

	internal static bool V5u()
	{
		return g5w == null;
	}

	internal static object X58()
	{
		return g5w;
	}
}
