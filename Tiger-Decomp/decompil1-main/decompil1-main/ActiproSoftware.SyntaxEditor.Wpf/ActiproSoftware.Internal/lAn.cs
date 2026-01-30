using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor;

namespace ActiproSoftware.Internal;

internal class lAn : ReadOnlyObservableCollection<ITextViewLine>, ITextViewLineCollection, IList<ITextViewLine>, ICollection<ITextViewLine>, IEnumerable<ITextViewLine>, IEnumerable
{
	private double DTc;

	private int? mTa;

	private double? FTx;

	private Size ETG;

	private static lAn IW5;

	public TextPosition FirstVisiblePosition => (base.Count > 0) ? base.Items[0].VisibleStartPosition : new TextPosition(0, 0);

	public int FullyVisibleCount
	{
		get
		{
			if (!mTa.HasValue)
			{
				mTa = this.Count((ITextViewLine l) => l.Visibility == TextViewLineVisibility.FullyVisible);
				if (DTc > 0.0 && mTa.Value > 0)
				{
					ITextViewLine textViewLine = this.Last();
					if (textViewLine.Visibility == TextViewLineVisibility.FullyVisible)
					{
						double num = ETG.Height - textViewLine.Bounds.Bottom;
						if (num > 0.0)
						{
							mTa += (int)(num / DTc);
						}
					}
				}
			}
			return mTa.Value;
		}
	}

	public double MaxWidth
	{
		get
		{
			if (!FTx.HasValue)
			{
				FTx = ((base.Count > 0) ? this.Max((ITextViewLine l) => l.Size.Width) : 0.0);
			}
			return FTx.Value;
		}
	}

	public TextSnapshotRange SnapshotRange
	{
		get
		{
			if (base.Count > 0)
			{
				return new TextSnapshotRange(base.Items[0].View.CurrentSnapshot, base.Items[0].StartOffset, base.Items[base.Count - 1].EndOffset);
			}
			return TextSnapshotRange.Deleted;
		}
	}

	public lAn()
	{
		grA.DaB7cz();
		this._002Ector(new ObservableCollection<ITextViewLine>(), default(Size), 0.0);
	}

	public lAn(ObservableCollection<ITextViewLine> P_0, Size P_1, double P_2)
	{
		grA.DaB7cz();
		base._002Ector(P_0);
		ETG = P_1;
		DTc = P_2;
	}

	internal static bool JWG()
	{
		return IW5 == null;
	}

	internal static lAn XWN()
	{
		return IW5;
	}
}
