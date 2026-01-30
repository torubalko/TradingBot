using System;
using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Searching.Implementation;

internal class SearchCaptureCollection : KeyedObservableCollection<ISearchCapture>, ISearchCaptureCollection, IKeyedObservableCollection<ISearchCapture>, IObservableCollection<ISearchCapture>, IList<ISearchCapture>, ICollection<ISearchCapture>, IEnumerable<ISearchCapture>, IEnumerable
{
	private bool dAk;

	internal static SearchCaptureCollection SVo;

	public override bool IsReadOnly => dAk;

	internal SearchCaptureCollection(IEnumerable<ISearchCapture> captures)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (captures == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6284));
		}
		foreach (ISearchCapture capture in captures)
		{
			Add(capture);
		}
		dAk = true;
	}

	internal static bool CVI()
	{
		return SVo == null;
	}

	internal static SearchCaptureCollection gVH()
	{
		return SVo;
	}
}
