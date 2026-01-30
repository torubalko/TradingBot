using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors;

public class Currency
{
	private string M6N;

	private string v6U;

	private string T6z;

	private static DeferrableObservableCollection<Currency> SMQ;

	internal static Currency vBh;

	public string Code => M6N;

	[SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
	public static DeferrableObservableCollection<Currency> Currencies
	{
		get
		{
			if (SMQ == null || SMQ.Count == 0)
			{
				SMQ = new DeferrableObservableCollection<Currency>();
				SMQ.AddRange(new Currency[171]
				{
					new Currency(QdM.AR8(14740), QdM.AR8(16370), null),
					new Currency(QdM.AR8(14750), QdM.AR8(16386), QdM.AR8(16404)),
					new Currency(QdM.AR8(14760), QdM.AR8(16410), QdM.AR8(16410)),
					new Currency(QdM.AR8(14770), QdM.AR8(16420), null),
					new Currency(QdM.AR8(14780), QdM.AR8(16432), QdM.AR8(16450)),
					new Currency(QdM.AR8(14790), QdM.AR8(16456), null),
					new Currency(QdM.AR8(14800), QdM.AR8(16472), QdM.AR8(16484)),
					new Currency(QdM.AR8(14810), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(14820), QdM.AR8(16506), QdM.AR8(16450)),
					new Currency(QdM.AR8(14830), QdM.AR8(16522), QdM.AR8(16536)),
					new Currency(QdM.AR8(14840), QdM.AR8(16546), QdM.AR8(8734)),
					new Currency(QdM.AR8(14850), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(14860), QdM.AR8(16558), null),
					new Currency(QdM.AR8(14870), QdM.AR8(16570), QdM.AR8(16580)),
					new Currency(QdM.AR8(14880), QdM.AR8(16588), null),
					new Currency(QdM.AR8(14890), QdM.AR8(16602), null),
					new Currency(QdM.AR8(14900), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(14910), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(14920), QdM.AR8(16616), QdM.AR8(16638)),
					new Currency(QdM.AR8(14920), QdM.AR8(16646), QdM.AR8(16638)),
					new Currency(QdM.AR8(14940), QdM.AR8(16660), QdM.AR8(16672)),
					new Currency(QdM.AR8(14950), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(5058), QdM.AR8(16680), null),
					new Currency(QdM.AR8(14960), QdM.AR8(16700), QdM.AR8(16712)),
					new Currency(QdM.AR8(14970), QdM.AR8(16718), QdM.AR8(16732)),
					new Currency(QdM.AR8(14980), QdM.AR8(16490), QdM.AR8(16740)),
					new Currency(QdM.AR8(14990), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(15000), QdM.AR8(16602), null),
					new Currency(QdM.AR8(5558), QdM.AR8(16750), null),
					new Currency(QdM.AR8(15010), QdM.AR8(16602), QdM.AR8(15010)),
					new Currency(QdM.AR8(15020), QdM.AR8(16770), null),
					new Currency(QdM.AR8(15030), QdM.AR8(16792), null),
					new Currency(QdM.AR8(15040), QdM.AR8(16472), QdM.AR8(16484)),
					new Currency(QdM.AR8(15050), QdM.AR8(16830), QdM.AR8(16860)),
					new Currency(QdM.AR8(15060), QdM.AR8(16472), QdM.AR8(16484)),
					new Currency(QdM.AR8(15070), QdM.AR8(16866), null),
					new Currency(QdM.AR8(15080), QdM.AR8(16910), QdM.AR8(16924)),
					new Currency(QdM.AR8(15090), QdM.AR8(16930), QdM.AR8(16966)),
					new Currency(QdM.AR8(15100), QdM.AR8(16472), QdM.AR8(16966)),
					new Currency(QdM.AR8(15110), QdM.AR8(16972), null),
					new Currency(QdM.AR8(15120), QdM.AR8(16988), QdM.AR8(17004)),
					new Currency(QdM.AR8(15130), QdM.AR8(16602), null),
					new Currency(QdM.AR8(15140), QdM.AR8(17012), QdM.AR8(17026)),
					new Currency(QdM.AR8(15150), QdM.AR8(16472), QdM.AR8(17034)),
					new Currency(QdM.AR8(15160), QdM.AR8(16588), null),
					new Currency(QdM.AR8(15170), QdM.AR8(17044), QdM.AR8(17058)),
					new Currency(QdM.AR8(15180), QdM.AR8(17064), null),
					new Currency(QdM.AR8(15190), QdM.AR8(17078), null),
					new Currency(QdM.AR8(15200), QdM.AR8(17090), QdM.AR8(17102)),
					new Currency(QdM.AR8(15210), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(15220), QdM.AR8(17044), QdM.AR8(17058)),
					new Currency(QdM.AR8(15230), QdM.AR8(17044), QdM.AR8(17058)),
					new Currency(QdM.AR8(15240), QdM.AR8(17108), null),
					new Currency(QdM.AR8(15250), QdM.AR8(17120), null),
					new Currency(QdM.AR8(15260), QdM.AR8(17044), QdM.AR8(17058)),
					new Currency(QdM.AR8(15270), QdM.AR8(17132), null),
					new Currency(QdM.AR8(15280), QdM.AR8(16602), null),
					new Currency(QdM.AR8(15290), QdM.AR8(17148), QdM.AR8(17166)),
					new Currency(QdM.AR8(15300), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(15310), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(15320), QdM.AR8(17172), QdM.AR8(17190)),
					new Currency(QdM.AR8(15330), QdM.AR8(17196), QdM.AR8(17208)),
					new Currency(QdM.AR8(15340), QdM.AR8(17216), null),
					new Currency(QdM.AR8(15350), QdM.AR8(17232), QdM.AR8(17248)),
					new Currency(QdM.AR8(15360), QdM.AR8(17256), QdM.AR8(17272)),
					new Currency(QdM.AR8(15370), QdM.AR8(17280), QdM.AR8(17296)),
					new Currency(QdM.AR8(15380), QdM.AR8(17302), QdM.AR8(17316)),
					new Currency(QdM.AR8(15390), QdM.AR8(16588), null),
					new Currency(QdM.AR8(15400), QdM.AR8(17322), QdM.AR8(17334)),
					new Currency(QdM.AR8(15410), QdM.AR8(17340), QdM.AR8(17026)),
					new Currency(QdM.AR8(15420), QdM.AR8(16490), QdM.AR8(17354)),
					new Currency(QdM.AR8(15430), QdM.AR8(16588), null),
					new Currency(QdM.AR8(15440), QdM.AR8(17362), QdM.AR8(16860)),
					new Currency(QdM.AR8(15450), QdM.AR8(17372), null),
					new Currency(QdM.AR8(15460), QdM.AR8(17392), QdM.AR8(16580)),
					new Currency(QdM.AR8(15470), QdM.AR8(17402), QdM.AR8(17414)),
					new Currency(QdM.AR8(15480), QdM.AR8(16602), null),
					new Currency(QdM.AR8(15490), QdM.AR8(17420), QdM.AR8(17430)),
					new Currency(QdM.AR8(15500), QdM.AR8(17420), QdM.AR8(17430)),
					new Currency(QdM.AR8(15510), QdM.AR8(16588), null),
					new Currency(QdM.AR8(15520), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(15530), QdM.AR8(17436), QdM.AR8(16580)),
					new Currency(QdM.AR8(15540), QdM.AR8(17450), QdM.AR8(17460)),
					new Currency(QdM.AR8(15550), QdM.AR8(17044), QdM.AR8(17058)),
					new Currency(QdM.AR8(15560), QdM.AR8(17302), QdM.AR8(17316)),
					new Currency(QdM.AR8(15570), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(15580), QdM.AR8(17466), null),
					new Currency(QdM.AR8(15590), QdM.AR8(17478), QdM.AR8(17492)),
					new Currency(QdM.AR8(15600), QdM.AR8(16588), null),
					new Currency(QdM.AR8(15610), QdM.AR8(16370), null),
					new Currency(QdM.AR8(15620), QdM.AR8(17500), null),
					new Currency(QdM.AR8(15630), QdM.AR8(17510), null),
					new Currency(QdM.AR8(10012), QdM.AR8(17526), QdM.AR8(17540)),
					new Currency(QdM.AR8(15640), QdM.AR8(17550), null),
					new Currency(QdM.AR8(15650), QdM.AR8(17562), QdM.AR8(17578)),
					new Currency(QdM.AR8(15660), QdM.AR8(17584), null),
					new Currency(QdM.AR8(15670), QdM.AR8(17600), null),
					new Currency(QdM.AR8(15680), QdM.AR8(17302), QdM.AR8(17316)),
					new Currency(QdM.AR8(15690), QdM.AR8(17618), null),
					new Currency(QdM.AR8(15700), QdM.AR8(17636), null),
					new Currency(QdM.AR8(15710), QdM.AR8(16472), QdM.AR8(16484)),
					new Currency(QdM.AR8(15720), QdM.AR8(17652), QdM.AR8(16484)),
					new Currency(QdM.AR8(15730), QdM.AR8(17694), QdM.AR8(17712)),
					new Currency(QdM.AR8(15740), QdM.AR8(17720), QdM.AR8(10368)),
					new Currency(QdM.AR8(15750), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(15760), QdM.AR8(17738), QdM.AR8(17752)),
					new Currency(QdM.AR8(15770), QdM.AR8(17758), QdM.AR8(17784)),
					new Currency(QdM.AR8(15780), QdM.AR8(17012), QdM.AR8(17026)),
					new Currency(QdM.AR8(15790), QdM.AR8(17302), QdM.AR8(17316)),
					new Currency(QdM.AR8(15800), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(15810), QdM.AR8(17322), QdM.AR8(17334)),
					new Currency(QdM.AR8(15820), QdM.AR8(17792), QdM.AR8(17808)),
					new Currency(QdM.AR8(15830), QdM.AR8(17818), QdM.AR8(17828)),
					new Currency(QdM.AR8(15840), QdM.AR8(17838), null),
					new Currency(QdM.AR8(15850), QdM.AR8(16472), QdM.AR8(17850)),
					new Currency(QdM.AR8(15860), QdM.AR8(17302), QdM.AR8(17316)),
					new Currency(QdM.AR8(15870), QdM.AR8(17860), QdM.AR8(17874)),
					new Currency(QdM.AR8(15880), QdM.AR8(17882), QdM.AR8(17900)),
					new Currency(QdM.AR8(15890), QdM.AR8(17322), QdM.AR8(17334)),
					new Currency(QdM.AR8(15900), QdM.AR8(17500), QdM.AR8(17908)),
					new Currency(QdM.AR8(15910), QdM.AR8(16588), QdM.AR8(17918)),
					new Currency(QdM.AR8(15920), QdM.AR8(16718), QdM.AR8(17930)),
					new Currency(QdM.AR8(15930), QdM.AR8(16602), null),
					new Currency(QdM.AR8(15940), QdM.AR8(17940), QdM.AR8(17334)),
					new Currency(QdM.AR8(15950), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(15960), QdM.AR8(17302), QdM.AR8(17316)),
					new Currency(QdM.AR8(15970), QdM.AR8(17044), null),
					new Currency(QdM.AR8(15980), QdM.AR8(17340), QdM.AR8(17026)),
					new Currency(QdM.AR8(15990), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(16000), QdM.AR8(17044), QdM.AR8(17058)),
					new Currency(QdM.AR8(16010), QdM.AR8(17954), null),
					new Currency(QdM.AR8(16020), QdM.AR8(17372), QdM.AR8(17968)),
					new Currency(QdM.AR8(16030), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(16040), QdM.AR8(17044), null),
					new Currency(QdM.AR8(16050), QdM.AR8(17974), null),
					new Currency(QdM.AR8(16060), QdM.AR8(16910), QdM.AR8(16484)),
					new Currency(QdM.AR8(16070), QdM.AR8(17044), QdM.AR8(17058)),
					new Currency(QdM.AR8(16080), QdM.AR8(17988), null),
					new Currency(QdM.AR8(16090), QdM.AR8(18010), QdM.AR8(18022)),
					new Currency(QdM.AR8(16100), QdM.AR8(18028), null),
					new Currency(QdM.AR8(16110), QdM.AR8(18044), null),
					new Currency(QdM.AR8(16120), QdM.AR8(16588), null),
					new Currency(QdM.AR8(16130), QdM.AR8(18066), null),
					new Currency(QdM.AR8(16140), QdM.AR8(18084), QdM.AR8(13310)),
					new Currency(QdM.AR8(16150), QdM.AR8(16490), QdM.AR8(18096)),
					new Currency(QdM.AR8(16160), QdM.AR8(16490), QdM.AR8(18106)),
					new Currency(QdM.AR8(16170), QdM.AR8(17372), null),
					new Currency(QdM.AR8(16180), QdM.AR8(18116), QdM.AR8(18134)),
					new Currency(QdM.AR8(16190), QdM.AR8(17372), null),
					new Currency(QdM.AR8(16200), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(16210), QdM.AR8(18140), QdM.AR8(16484)),
					new Currency(QdM.AR8(16220), QdM.AR8(18178), null),
					new Currency(QdM.AR8(16230), QdM.AR8(16472), QdM.AR8(18214)),
					new Currency(QdM.AR8(16240), QdM.AR8(18222), QdM.AR8(16580)),
					new Currency(QdM.AR8(16250), QdM.AR8(18232), QdM.AR8(18250)),
					new Currency(QdM.AR8(16260), QdM.AR8(18258), QdM.AR8(18270)),
					new Currency(QdM.AR8(16270), QdM.AR8(18276), null),
					new Currency(QdM.AR8(16280), QdM.AR8(18288), null),
					new Currency(QdM.AR8(16290), QdM.AR8(18300), null),
					new Currency(QdM.AR8(18332), QdM.AR8(18342), null),
					new Currency(QdM.AR8(18370), QdM.AR8(18380), null),
					new Currency(QdM.AR8(16300), QdM.AR8(16490), QdM.AR8(16484)),
					new Currency(QdM.AR8(18404), QdM.AR8(18414), null),
					new Currency(QdM.AR8(16310), QdM.AR8(18468), null),
					new Currency(QdM.AR8(18502), QdM.AR8(18512), null),
					new Currency(QdM.AR8(16320), QdM.AR8(18546), null),
					new Currency(QdM.AR8(18562), QdM.AR8(18572), null),
					new Currency(QdM.AR8(16330), QdM.AR8(17322), QdM.AR8(17334)),
					new Currency(QdM.AR8(16340), QdM.AR8(18606), QdM.AR8(2618)),
					new Currency(QdM.AR8(16350), QdM.AR8(17636), null),
					new Currency(QdM.AR8(16360), QdM.AR8(16490), QdM.AR8(18618))
				}.OrderBy((Currency x) => x.M6N));
			}
			return SMQ;
		}
	}

	public string Description => string.Format(CultureInfo.InvariantCulture, QdM.AR8(18626), new object[3]
	{
		M6N,
		v6U,
		(!string.IsNullOrEmpty(T6z)) ? (QdM.AR8(18652) + T6z + QdM.AR8(18658)) : null
	}).Trim();

	public string Name
	{
		get
		{
			return v6U;
		}
		set
		{
			v6U = value;
		}
	}

	public string Symbol
	{
		get
		{
			return T6z;
		}
		set
		{
			T6z = value;
		}
	}

	public Currency(string code, string name, string symbol)
	{
		awj.QuEwGz();
		base._002Ector();
		M6N = code;
		v6U = name;
		T6z = symbol;
	}

	internal static bool pBS()
	{
		return vBh == null;
	}

	internal static Currency fBA()
	{
		return vBh;
	}
}
