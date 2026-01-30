using System;
using System.Collections.Generic;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Tagging.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Indicators;

namespace ActiproSoftware.Internal;

internal class xL : IIndicatorManager
{
	private IBookmarkIndicatorManager lRg;

	private IBreakpointIndicatorManager nRQ;

	private ICurrentStatementIndicatorManager LRe;

	private IEditorDocument qRl;

	internal static xL Egz;

	public IBookmarkIndicatorManager Bookmarks
	{
		get
		{
			if (lRg == null)
			{
				lRg = new Ka(this);
			}
			return lRg;
		}
	}

	public IBreakpointIndicatorManager Breakpoints
	{
		get
		{
			if (nRQ == null)
			{
				nRQ = new cH(this);
			}
			return nRQ;
		}
	}

	public ICurrentStatementIndicatorManager CurrentStatement
	{
		get
		{
			if (LRe == null)
			{
				LRe = new Ht(this);
			}
			return LRe;
		}
	}

	public IEditorDocument Document => qRl;

	public xL(IEditorDocument P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11024));
		}
		qRl = P_0;
	}

	private WP BRD<WP, ub>(bool P_0) where WP : class, ICollectionTagger<ub> where ub : IIndicatorTag
	{
		WP value = null;
		if (!qRl.Properties.TryGetValue<WP>(typeof(WP), out value) && P_0 && qRl.Language != null)
		{
			CodeDocumentTaggerProvider<WP> codeDocumentTaggerProvider = new CodeDocumentTaggerProvider<WP>(typeof(WP));
			qRl.Language.RegisterService(codeDocumentTaggerProvider);
			return codeDocumentTaggerProvider.GetTagger<ub>(qRl) as WP;
		}
		return value;
	}

	public TagVersionRange<tV> Add<wg, tV>(ITextSnapshotLine P_0, tV Wd) where wg : class, ICollectionTagger<tV> where tV : IIndicatorTag
	{
		return BRD<wg, tV>(_0020: true)?.Add(P_0, Wd);
	}

	public TagVersionRange<zD> Add<L3, zD>(TextSnapshotRange P_0, zD zk) where L3 : class, ICollectionTagger<zD> where zD : IIndicatorTag
	{
		return BRD<L3, zD>(_0020: true)?.Add(P_0, zk);
	}

	public void Clear<uh, jU>() where uh : class, ICollectionTagger<jU> where jU : IIndicatorTag
	{
		BRD<uh, jU>(_0020: false)?.Clear();
	}

	public TagVersionRange<qZ> FindNext<nG, qZ>(ITextSnapshotLine P_0, ITagSearchOptions<qZ> P_1) where nG : class, ICollectionTagger<qZ> where qZ : IIndicatorTag
	{
		return BRD<nG, qZ>(_0020: false)?.FindNext(P_0, P_1);
	}

	public TagVersionRange<eX> FindNext<sE, eX>(TextSnapshotOffset P_0, ITagSearchOptions<eX> P_1) where sE : class, ICollectionTagger<eX> where eX : IIndicatorTag
	{
		return BRD<sE, eX>(_0020: false)?.FindNext(P_0, P_1);
	}

	public int GetCount<Q1, c9>() where Q1 : class, ICollectionTagger<c9> where c9 : IIndicatorTag
	{
		return BRD<Q1, c9>(_0020: false)?.Count ?? 0;
	}

	public TagVersionRange<Cf> GetInstance<m2, Cf>(Cf a6) where m2 : class, ICollectionTagger<Cf> where Cf : IIndicatorTag
	{
		return BRD<m2, Cf>(_0020: false)?[a6];
	}

	public IEnumerable<TagVersionRange<pJ>> GetInstances<Ne, pJ>() where Ne : class, ICollectionTagger<pJ> where pJ : IIndicatorTag
	{
		Ne tagger = BRD<Ne, pJ>(_0020: false);
		if (tagger == null)
		{
			yield break;
		}
		foreach (TagVersionRange<pJ> item in tagger)
		{
			yield return item;
		}
	}

	public IEnumerable<TagVersionRange<k8>> GetInstances<zW, k8>(ITextSnapshotLine P_0) where zW : class, ICollectionTagger<k8> where k8 : IIndicatorTag
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192840));
		}
		return GetInstances<zW, k8>(P_0.SnapshotRange);
	}

	public IEnumerable<TagVersionRange<eq>> GetInstances<yj, eq>(TextSnapshotRange P_0) where yj : class, ICollectionTagger<eq> where eq : IIndicatorTag
	{
		if (P_0.IsDeleted)
		{
			throw new ArgumentNullException(Q7Z.tqM(219564));
		}
		foreach (TagVersionRange<eq> tagRange in GetInstances<yj, eq>())
		{
			TextSnapshotRange tagSnapshotRange = tagRange.VersionRange.Translate(P_0.Snapshot);
			if ((P_0.IsZeroLength && tagSnapshotRange.Contains(P_0)) || (tagSnapshotRange.IsZeroLength && P_0.Contains(tagSnapshotRange)) || P_0.OverlapsWith(tagSnapshotRange))
			{
				yield return tagRange;
			}
		}
	}

	public bool Remove<kz, HTS>(HTS HTT) where kz : class, ICollectionTagger<HTS> where HTS : IIndicatorTag
	{
		return BRD<kz, HTS>(_0020: false)?.Remove(HTT) ?? false;
	}

	public int RemoveAll<oTA, TT7>(Predicate<TagVersionRange<TT7>> P_0) where oTA : class, ICollectionTagger<TT7> where TT7 : IIndicatorTag
	{
		return BRD<oTA, TT7>(_0020: false)?.RemoveAll(P_0) ?? 0;
	}

	public TagVersionRange<eTu> Toggle<yTr, eTu>(ITextSnapshotLine P_0, eTu vT0) where yTr : class, ICollectionTagger<eTu> where eTu : IIndicatorTag
	{
		return BRD<yTr, eTu>(_0020: true)?.Toggle(P_0, vT0);
	}

	public TagVersionRange<dTR> Toggle<hTQ, dTR>(TextSnapshotRange P_0, dTR dTM) where hTQ : class, ICollectionTagger<dTR> where dTR : IIndicatorTag
	{
		return BRD<hTQ, dTR>(_0020: true)?.Toggle(P_0, dTM);
	}

	internal static bool lAm()
	{
		return Egz == null;
	}

	internal static xL VAp()
	{
		return Egz;
	}
}
