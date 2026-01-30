using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Internal;

internal class yo : DeferrableObservableCollection<ICompletionItem>, ICompletionItemCollection, IList<ICompletionItem>, ICollection<ICompletionItem>, IEnumerable<ICompletionItem>, IEnumerable, INotifyCollectionChanged
{
	private class R75 : DisposableObject
	{
		private yo xrY;

		private static R75 UjJ;

		public R75(yo P_0)
		{
			grA.DaB7cz();
			base._002Ector();
			xrY = P_0;
			P_0.BeginUpdate();
		}

		protected override void Dispose(bool P_0)
		{
			if (xrY != null)
			{
				xrY.EndUpdate();
				xrY = null;
			}
			base.Dispose(P_0);
		}

		internal static bool SjR()
		{
			return UjJ == null;
		}

		internal static R75 RjO()
		{
			return UjJ;
		}
	}

	internal static yo Tar;

	public IDisposable CreateBatch()
	{
		return new R75(this);
	}

	public yo()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	void ICompletionItemCollection.AddRange(IEnumerable<ICompletionItem> P_0)
	{
		AddRange(P_0);
	}

	internal static bool taX()
	{
		return Tar == null;
	}

	internal static yo AaE()
	{
		return Tar;
	}
}
