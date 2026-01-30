using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Indicators;

namespace ActiproSoftware.Internal;

internal class iTv<kT4, rTw> : ITextRangeIndicatorManager<kT4, rTw> where kT4 : class, ICollectionTagger<rTw> where rTw : IIndicatorTag, new()
{
	private IIndicatorManager uRR;

	internal static object GAq;

	public int Count => uRR.GetCount<kT4, rTw>();

	public TagVersionRange<rTw> this[rTw TTs] => uRR.GetInstance<kT4, rTw>(TTs);

	public iTv(IIndicatorManager P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192868));
		}
		uRR = P_0;
	}

	[SpecialName]
	internal IIndicatorManager gRF()
	{
		return uRR;
	}

	public TagVersionRange<rTw> Add(TextSnapshotRange P_0)
	{
		return Add(P_0, new rTw());
	}

	public TagVersionRange<rTw> Add(TextSnapshotRange P_0, rTw tTK)
	{
		return uRR.Add<kT4, rTw>(P_0, tTK);
	}

	public void Clear()
	{
		uRR.Clear<kT4, rTw>();
	}

	public TagVersionRange<rTw> FindNext(TextSnapshotOffset P_0, ITagSearchOptions<rTw> P_1)
	{
		return uRR.FindNext<kT4, rTw>(P_0, P_1);
	}

	public IEnumerable<TagVersionRange<rTw>> GetInstances()
	{
		return uRR.GetInstances<kT4, rTw>();
	}

	public IEnumerable<TagVersionRange<rTw>> GetInstances(TextSnapshotRange P_0)
	{
		return uRR.GetInstances<kT4, rTw>(P_0);
	}

	public bool Remove(rTw rTN)
	{
		return uRR.Remove<kT4, rTw>(rTN);
	}

	public int RemoveAll(Predicate<TagVersionRange<rTw>> P_0)
	{
		return uRR.RemoveAll<kT4, rTw>(P_0);
	}

	public TagVersionRange<rTw> Toggle(TextSnapshotRange P_0)
	{
		return Toggle(P_0, new rTw());
	}

	public TagVersionRange<rTw> Toggle(TextSnapshotRange P_0, rTw nTC)
	{
		return uRR.Toggle<kT4, rTw>(P_0, nTC);
	}

	internal static bool bAx()
	{
		return GAq == null;
	}

	internal static object cAa()
	{
		return GAq;
	}
}
