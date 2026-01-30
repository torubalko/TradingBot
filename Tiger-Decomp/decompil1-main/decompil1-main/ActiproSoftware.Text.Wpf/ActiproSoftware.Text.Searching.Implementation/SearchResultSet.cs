using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Searching.Implementation;

public class SearchResultSet : ISearchResultSet
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ISearchOptions BAn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private SearchOperationType mAG;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ISearchResultCollection PAe;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool gAy;

	internal static SearchResultSet XVa;

	public ISearchOptions Options
	{
		[CompilerGenerated]
		get
		{
			return BAn;
		}
		[CompilerGenerated]
		set
		{
			BAn = value;
		}
	}

	public SearchOperationType OperationType
	{
		[CompilerGenerated]
		get
		{
			return mAG;
		}
		[CompilerGenerated]
		set
		{
			mAG = value;
		}
	}

	public ISearchResultCollection Results
	{
		[CompilerGenerated]
		get
		{
			return PAe;
		}
		[CompilerGenerated]
		private set
		{
			PAe = value;
		}
	}

	public bool Wrapped
	{
		[CompilerGenerated]
		get
		{
			return gAy;
		}
		[CompilerGenerated]
		set
		{
			gAy = value;
		}
	}

	public SearchResultSet(SearchOperationType operationType, ISearchOptions options, bool wrapped)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(operationType, options, null, wrapped);
	}

	internal SearchResultSet(SearchOperationType operationType, ISearchOptions options, ISearchResultCollection results, bool wrapped)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		OperationType = operationType;
		Options = options;
		Results = results ?? new SearchResultCollection();
		Wrapped = wrapped;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		switch (OperationType)
		{
		case SearchOperationType.FindAll:
			stringBuilder.Append(SR.GetString(SRName.UISearchOperationTypeFindAll));
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1920));
			break;
		case SearchOperationType.FindNext:
			stringBuilder.Append(SR.GetString(SRName.UISearchOperationTypeFindNext));
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1920));
			break;
		case SearchOperationType.ReplaceAll:
			stringBuilder.Append(SR.GetString(SRName.UISearchOperationTypeReplaceAll));
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1920));
			break;
		case SearchOperationType.ReplaceNext:
			stringBuilder.Append(SR.GetString(SRName.UISearchOperationTypeReplaceNext));
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1920));
			break;
		}
		stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5496));
		stringBuilder.Append(Options.FindText.Split('\r', '\n')[0]);
		SearchOperationType operationType = OperationType;
		SearchOperationType searchOperationType = operationType;
		if (searchOperationType == SearchOperationType.ReplaceNext || searchOperationType == SearchOperationType.ReplaceAll)
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6368));
			stringBuilder.Append(Options.ReplaceText.Split('\r', '\n')[0]);
		}
		stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5496));
		if (Wrapped)
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1920));
			stringBuilder.Append(SR.GetString(SRName.UISearchResultWrapped));
		}
		stringBuilder.AppendLine(string.Empty);
		foreach (ISearchResult result in Results)
		{
			if (result.ReplaceSnapshotRange.IsDeleted)
			{
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6380), new object[3]
				{
					result.FindSnapshotRange.StartPosition.Line + 1,
					result.FindSnapshotRange.StartPosition.Character + 1,
					result.FindSnapshotRange.StartLine.Text
				});
			}
			else
			{
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6380), new object[3]
				{
					result.ReplaceSnapshotRange.StartPosition.Line + 1,
					result.ReplaceSnapshotRange.StartPosition.Character + 1,
					result.ReplaceSnapshotRange.StartLine.Text
				});
			}
		}
		return stringBuilder.ToString();
	}

	internal static bool pV7()
	{
		return XVa == null;
	}

	internal static SearchResultSet DVJ()
	{
		return XVa;
	}
}
