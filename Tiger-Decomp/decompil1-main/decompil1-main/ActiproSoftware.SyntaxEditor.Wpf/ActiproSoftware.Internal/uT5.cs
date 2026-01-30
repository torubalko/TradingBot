using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Indicators;

namespace ActiproSoftware.Internal;

internal class uT5<bTi, LTc> : ILineIndicatorManager<bTi, LTc> where bTi : class, ICollectionTagger<LTc> where LTc : IIndicatorTag, new()
{
	private IIndicatorManager lRm;

	internal static object GA4;

	public int Count => lRm.GetCount<bTi, LTc>();

	public TagVersionRange<LTc> this[LTc pTx] => lRm.GetInstance<bTi, LTc>(pTx);

	public uT5(IIndicatorManager P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192868));
		}
		lRm = P_0;
	}

	[SpecialName]
	internal IIndicatorManager GRA()
	{
		return lRm;
	}

	public TagVersionRange<LTc> Add(ITextSnapshotLine P_0)
	{
		return Add(P_0, new LTc());
	}

	public TagVersionRange<LTc> Add(ITextSnapshotLine P_0, LTc fTp)
	{
		return lRm.Add<bTi, LTc>(P_0, fTp);
	}

	public void Clear()
	{
		lRm.Clear<bTi, LTc>();
	}

	public TagVersionRange<LTc> FindNext(ITextSnapshotLine P_0, ITagSearchOptions<LTc> P_1)
	{
		return lRm.FindNext<bTi, LTc>(P_0, P_1);
	}

	public IEnumerable<TagVersionRange<LTc>> GetInstances()
	{
		return lRm.GetInstances<bTi, LTc>();
	}

	public IEnumerable<TagVersionRange<LTc>> GetInstances(ITextSnapshotLine P_0)
	{
		return lRm.GetInstances<bTi, LTc>(P_0);
	}

	public bool Remove(LTc LTI)
	{
		return lRm.Remove<bTi, LTc>(LTI);
	}

	public int RemoveAll(Predicate<TagVersionRange<LTc>> P_0)
	{
		return lRm.RemoveAll<bTi, LTc>(P_0);
	}

	public TagVersionRange<LTc> Toggle(ITextSnapshotLine P_0)
	{
		return Toggle(P_0, new LTc());
	}

	public TagVersionRange<LTc> Toggle(ITextSnapshotLine P_0, LTc NTF)
	{
		return lRm.Toggle<bTi, LTc>(P_0, NTF);
	}

	internal static bool dAD()
	{
		return GA4 == null;
	}

	internal static object YAB()
	{
		return GA4;
	}
}
