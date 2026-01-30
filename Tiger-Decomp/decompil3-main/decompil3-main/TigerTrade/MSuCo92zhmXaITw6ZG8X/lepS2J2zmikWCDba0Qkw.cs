using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Dx;
using TuAMtrl1Nd3XoZQQUXf0;

namespace MSuCo92zhmXaITw6ZG8X;

[DataContract(Name = "ColorPickerSwatchItem", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config")]
internal class lepS2J2zmikWCDba0Qkw
{
	[CompilerGenerated]
	private XColor v2S2zPAGRjX;

	internal static lepS2J2zmikWCDba0Qkw omblrEDa97IOV5QMqtaR;

	[DataMember(Name = "PaletteColors")]
	public XColor Color
	{
		[CompilerGenerated]
		get
		{
			return v2S2zPAGRjX;
		}
		[CompilerGenerated]
		set
		{
			v2S2zPAGRjX = xColor;
		}
	}

	public string HexString => (string)UfEGvpDaYqtbvbx06XoI(Color);

	public static string H1t2zw8YeMu(Color P_0)
	{
		return (string)KZjYl8DaoGMswARTYAin(-1878953018 ^ -1878946360) + P_0.A.ToString((string)KZjYl8DaoGMswARTYAin(0x741B85CB ^ 0x741B7BDF)) + P_0.R.ToString((string)KZjYl8DaoGMswARTYAin(0x1A5F1B9E ^ 0x1A5FE58A)) + P_0.G.ToString((string)KZjYl8DaoGMswARTYAin(0x2BD86B18 ^ 0x2BD8950C)) + P_0.B.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x684F243E ^ 0x684FDA2A));
	}

	public lepS2J2zmikWCDba0Qkw()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static lepS2J2zmikWCDba0Qkw()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool QcYbc7DanMgQIywKLnW7()
	{
		return omblrEDa97IOV5QMqtaR == null;
	}

	internal static lepS2J2zmikWCDba0Qkw DWjNpJDaGvac5uPdtQuj()
	{
		return omblrEDa97IOV5QMqtaR;
	}

	internal static object UfEGvpDaYqtbvbx06XoI(Color P_0)
	{
		return H1t2zw8YeMu(P_0);
	}

	internal static object KZjYl8DaoGMswARTYAin(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}
}
