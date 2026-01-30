using ActiproSoftware.Internal;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public struct TextViewScrollState
{
	private bool nXB;

	private double LXV;

	private double tXr;

	private TextViewVerticalAnchorPlacement DXs;

	private TextPosition MXk;

	internal static object eD3;

	public bool CanScrollPastDocumentEnd
	{
		get
		{
			return nXB;
		}
		set
		{
			nXB = value;
		}
	}

	public double HorizontalAmount
	{
		get
		{
			return LXV;
		}
		set
		{
			LXV = value;
		}
	}

	public double VerticalAmountOffset
	{
		get
		{
			return tXr;
		}
		set
		{
			tXr = value;
		}
	}

	public TextViewVerticalAnchorPlacement VerticalAnchorPlacement
	{
		get
		{
			return DXs;
		}
		set
		{
			DXs = value;
		}
	}

	public TextPosition VerticalAnchorTextPosition
	{
		get
		{
			return MXk;
		}
		set
		{
			MXk = value;
		}
	}

	public TextViewScrollState(TextPosition verticalAnchorTextPosition)
	{
		grA.DaB7cz();
		this = new TextViewScrollState(verticalAnchorTextPosition, TextViewVerticalAnchorPlacement.Top, 0.0, 0.0);
	}

	public TextViewScrollState(TextPosition verticalAnchorTextPosition, double horizontalAmount)
	{
		grA.DaB7cz();
		this = new TextViewScrollState(verticalAnchorTextPosition, TextViewVerticalAnchorPlacement.Top, 0.0, horizontalAmount);
	}

	public TextViewScrollState(TextPosition verticalAnchorTextPosition, TextViewVerticalAnchorPlacement verticalAnchorPlacement, double verticalAmountOffset, double horizontalAmount)
	{
		grA.DaB7cz();
		MXk = verticalAnchorTextPosition;
		DXs = verticalAnchorPlacement;
		tXr = verticalAmountOffset;
		LXV = horizontalAmount;
		nXB = false;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is TextViewScrollState textViewScrollState))
		{
			return false;
		}
		return MXk == textViewScrollState.MXk && tXr == textViewScrollState.tXr && LXV == textViewScrollState.LXV && DXs == textViewScrollState.DXs && nXB == textViewScrollState.nXB;
	}

	public override int GetHashCode()
	{
		return MXk.GetHashCode() ^ (int)tXr ^ (int)LXV ^ (int)DXs;
	}

	public static bool operator ==(TextViewScrollState left, TextViewScrollState right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(TextViewScrollState left, TextViewScrollState right)
	{
		return !(left == right);
	}

	internal static bool sDv()
	{
		return eD3 == null;
	}

	internal static object hDf()
	{
		return eD3;
	}
}
