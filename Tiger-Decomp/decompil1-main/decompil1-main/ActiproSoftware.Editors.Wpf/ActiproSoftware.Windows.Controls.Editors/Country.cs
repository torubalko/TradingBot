using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors;

public class Country
{
	private string Y6k;

	private string V6E;

	private string h67;

	private static DeferrableObservableCollection<Country> Y64;

	internal static Country tz;

	public string Alpha2Code => Y6k;

	public string Alpha3Code => V6E;

	[Obsolete("Use the Alpha2Code property instead.", false)]
	public string Code => Y6k;

	[SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
	public static DeferrableObservableCollection<Country> Countries
	{
		get
		{
			if (Y64 == null || Y64.Count == 0)
			{
				Y64 = new DeferrableObservableCollection<Country>();
				Y64.AddRange(new Country[249]
				{
					new Country(QdM.AR8(3602), QdM.AR8(3620), QdM.AR8(3628)),
					new Country(QdM.AR8(3638), QdM.AR8(3682), QdM.AR8(3690)),
					new Country(QdM.AR8(3700), QdM.AR8(3726), QdM.AR8(3734)),
					new Country(QdM.AR8(3744), QdM.AR8(3786), QdM.AR8(3794)),
					new Country(QdM.AR8(3804), QdM.AR8(3824), QdM.AR8(3832)),
					new Country(QdM.AR8(3842), QdM.AR8(3860), QdM.AR8(3868)),
					new Country(QdM.AR8(3878), QdM.AR8(3896), QdM.AR8(3904)),
					new Country(QdM.AR8(3914), QdM.AR8(3930), QdM.AR8(3938)),
					new Country(QdM.AR8(3948), QdM.AR8(3972), QdM.AR8(3980)),
					new Country(QdM.AR8(3990), QdM.AR8(4012), QdM.AR8(4020)),
					new Country(QdM.AR8(4030), QdM.AR8(4062), QdM.AR8(4070)),
					new Country(QdM.AR8(4080), QdM.AR8(4098), QdM.AR8(4106)),
					new Country(QdM.AR8(4116), QdM.AR8(4138), QdM.AR8(4146)),
					new Country(QdM.AR8(4156), QdM.AR8(4170), QdM.AR8(4178)),
					new Country(QdM.AR8(4188), QdM.AR8(4218), QdM.AR8(4226)),
					new Country(QdM.AR8(4236), QdM.AR8(4260), QdM.AR8(4268)),
					new Country(QdM.AR8(4278), QdM.AR8(4326), QdM.AR8(4334)),
					new Country(QdM.AR8(4344), QdM.AR8(4364), QdM.AR8(4372)),
					new Country(QdM.AR8(4382), QdM.AR8(4406), QdM.AR8(4414)),
					new Country(QdM.AR8(4424), QdM.AR8(4442), QdM.AR8(4450)),
					new Country(QdM.AR8(4460), QdM.AR8(4488), QdM.AR8(4496)),
					new Country(QdM.AR8(4506), QdM.AR8(4526), QdM.AR8(4534)),
					new Country(QdM.AR8(4544), QdM.AR8(4562), QdM.AR8(4570)),
					new Country(QdM.AR8(4580), QdM.AR8(4598), QdM.AR8(4606)),
					new Country(QdM.AR8(4616), QdM.AR8(4630), QdM.AR8(4638)),
					new Country(QdM.AR8(4648), QdM.AR8(4684), QdM.AR8(4692)),
					new Country(QdM.AR8(4702), QdM.AR8(4720), QdM.AR8(4728)),
					new Country(QdM.AR8(4738), QdM.AR8(4776), QdM.AR8(4784)),
					new Country(QdM.AR8(4794), QdM.AR8(4860), QdM.AR8(4868)),
					new Country(QdM.AR8(4878), QdM.AR8(4946), QdM.AR8(4954)),
					new Country(QdM.AR8(4964), QdM.AR8(4980), QdM.AR8(4988)),
					new Country(QdM.AR8(4998), QdM.AR8(5016), QdM.AR8(5024)),
					new Country(QdM.AR8(5034), QdM.AR8(5050), QdM.AR8(5058)),
					new Country(QdM.AR8(5068), QdM.AR8(5098), QdM.AR8(5106)),
					new Country(QdM.AR8(5116), QdM.AR8(5136), QdM.AR8(5144)),
					new Country(QdM.AR8(5154), QdM.AR8(5172), QdM.AR8(5180)),
					new Country(QdM.AR8(5190), QdM.AR8(5206), QdM.AR8(5214)),
					new Country(QdM.AR8(5224), QdM.AR8(5240), QdM.AR8(5248)),
					new Country(QdM.AR8(5258), QdM.AR8(5308), QdM.AR8(5316)),
					new Country(QdM.AR8(5326), QdM.AR8(5404), QdM.AR8(5412)),
					new Country(QdM.AR8(5422), QdM.AR8(5474), QdM.AR8(5482)),
					new Country(QdM.AR8(5492), QdM.AR8(5506), QdM.AR8(5514)),
					new Country(QdM.AR8(5524), QdM.AR8(5550), QdM.AR8(5558)),
					new Country(QdM.AR8(5568), QdM.AR8(5626), QdM.AR8(5634)),
					new Country(QdM.AR8(5644), QdM.AR8(5672), QdM.AR8(5680)),
					new Country(QdM.AR8(5690), QdM.AR8(5704), QdM.AR8(5712)),
					new Country(QdM.AR8(5722), QdM.AR8(5742), QdM.AR8(5750)),
					new Country(QdM.AR8(5760), QdM.AR8(5774), QdM.AR8(5782)),
					new Country(QdM.AR8(5792), QdM.AR8(5812), QdM.AR8(5820)),
					new Country(QdM.AR8(5830), QdM.AR8(5854), QdM.AR8(5862)),
					new Country(QdM.AR8(5872), QdM.AR8(5884), QdM.AR8(5892)),
					new Country(QdM.AR8(5902), QdM.AR8(5926), QdM.AR8(5934)),
					new Country(QdM.AR8(5944), QdM.AR8(5962), QdM.AR8(5970)),
					new Country(QdM.AR8(5980), QdM.AR8(6016), QdM.AR8(6024)),
					new Country(QdM.AR8(6034), QdM.AR8(6050), QdM.AR8(6058)),
					new Country(QdM.AR8(6068), QdM.AR8(6100), QdM.AR8(6108)),
					new Country(QdM.AR8(6118), QdM.AR8(6136), QdM.AR8(6144)),
					new Country(QdM.AR8(6154), QdM.AR8(6174), QdM.AR8(6182)),
					new Country(QdM.AR8(6192), QdM.AR8(6210), QdM.AR8(6218)),
					new Country(QdM.AR8(6228), QdM.AR8(6248), QdM.AR8(6256)),
					new Country(QdM.AR8(6266), QdM.AR8(6306), QdM.AR8(6314)),
					new Country(QdM.AR8(6324), QdM.AR8(6342), QdM.AR8(6350)),
					new Country(QdM.AR8(6360), QdM.AR8(6378), QdM.AR8(6386)),
					new Country(QdM.AR8(6396), QdM.AR8(6414), QdM.AR8(6422)),
					new Country(QdM.AR8(6432), QdM.AR8(6446), QdM.AR8(6454)),
					new Country(QdM.AR8(6464), QdM.AR8(6496), QdM.AR8(6504)),
					new Country(QdM.AR8(6514), QdM.AR8(6532), QdM.AR8(6540)),
					new Country(QdM.AR8(6550), QdM.AR8(6564), QdM.AR8(6572)),
					new Country(QdM.AR8(6582), QdM.AR8(6602), QdM.AR8(6610)),
					new Country(QdM.AR8(6620), QdM.AR8(6638), QdM.AR8(6646)),
					new Country(QdM.AR8(6656), QdM.AR8(6668), QdM.AR8(6676)),
					new Country(QdM.AR8(6686), QdM.AR8(6744), QdM.AR8(6752)),
					new Country(QdM.AR8(6762), QdM.AR8(6828), QdM.AR8(6836)),
					new Country(QdM.AR8(6846), QdM.AR8(6876), QdM.AR8(6884)),
					new Country(QdM.AR8(6894), QdM.AR8(6910), QdM.AR8(6918)),
					new Country(QdM.AR8(6928), QdM.AR8(6942), QdM.AR8(6950)),
					new Country(QdM.AR8(6960), QdM.AR8(6992), QdM.AR8(7000)),
					new Country(QdM.AR8(7010), QdM.AR8(7028), QdM.AR8(7036)),
					new Country(QdM.AR8(7046), QdM.AR8(7064), QdM.AR8(7072)),
					new Country(QdM.AR8(7082), QdM.AR8(7112), QdM.AR8(7120)),
					new Country(QdM.AR8(7130), QdM.AR8(7150), QdM.AR8(7158)),
					new Country(QdM.AR8(7168), QdM.AR8(7182), QdM.AR8(7190)),
					new Country(QdM.AR8(7200), QdM.AR8(7222), QdM.AR8(7230)),
					new Country(QdM.AR8(7240), QdM.AR8(7262), QdM.AR8(7270)),
					new Country(QdM.AR8(7280), QdM.AR8(7296), QdM.AR8(7304)),
					new Country(QdM.AR8(7314), QdM.AR8(7330), QdM.AR8(7338)),
					new Country(QdM.AR8(7348), QdM.AR8(7372), QdM.AR8(7380)),
					new Country(QdM.AR8(7390), QdM.AR8(7428), QdM.AR8(7436)),
					new Country(QdM.AR8(7446), QdM.AR8(7462), QdM.AR8(7470)),
					new Country(QdM.AR8(7480), QdM.AR8(7552), QdM.AR8(7560)),
					new Country(QdM.AR8(7570), QdM.AR8(7592), QdM.AR8(7600)),
					new Country(QdM.AR8(7610), QdM.AR8(7622), QdM.AR8(7630)),
					new Country(QdM.AR8(7640), QdM.AR8(7670), QdM.AR8(7678)),
					new Country(QdM.AR8(7688), QdM.AR8(7704), QdM.AR8(7712)),
					new Country(QdM.AR8(7722), QdM.AR8(7744), QdM.AR8(7752)),
					new Country(QdM.AR8(7762), QdM.AR8(7832), QdM.AR8(7840)),
					new Country(QdM.AR8(7850), QdM.AR8(7870), QdM.AR8(7878)),
					new Country(QdM.AR8(7888), QdM.AR8(7906), QdM.AR8(7914)),
					new Country(QdM.AR8(7924), QdM.AR8(7938), QdM.AR8(7946)),
					new Country(QdM.AR8(7956), QdM.AR8(7974), QdM.AR8(7982)),
					new Country(QdM.AR8(7992), QdM.AR8(8014), QdM.AR8(8022)),
					new Country(QdM.AR8(8032), QdM.AR8(8050), QdM.AR8(8058)),
					new Country(QdM.AR8(8068), QdM.AR8(8084), QdM.AR8(8092)),
					new Country(QdM.AR8(8102), QdM.AR8(8128), QdM.AR8(8136)),
					new Country(QdM.AR8(8146), QdM.AR8(8160), QdM.AR8(8168)),
					new Country(QdM.AR8(8178), QdM.AR8(8242), QdM.AR8(8250)),
					new Country(QdM.AR8(8260), QdM.AR8(8272), QdM.AR8(8280)),
					new Country(QdM.AR8(8290), QdM.AR8(8344), QdM.AR8(8352)),
					new Country(QdM.AR8(8362), QdM.AR8(8380), QdM.AR8(8388)),
					new Country(QdM.AR8(8398), QdM.AR8(8412), QdM.AR8(8420)),
					new Country(QdM.AR8(8430), QdM.AR8(8446), QdM.AR8(8454)),
					new Country(QdM.AR8(8464), QdM.AR8(8482), QdM.AR8(8490)),
					new Country(QdM.AR8(8500), QdM.AR8(8516), QdM.AR8(8524)),
					new Country(QdM.AR8(8534), QdM.AR8(8548), QdM.AR8(8556)),
					new Country(QdM.AR8(8566), QdM.AR8(8580), QdM.AR8(8588)),
					new Country(QdM.AR8(8598), QdM.AR8(8622), QdM.AR8(8630)),
					new Country(QdM.AR8(8640), QdM.AR8(8660), QdM.AR8(8668)),
					new Country(QdM.AR8(8678), QdM.AR8(8698), QdM.AR8(8706)),
					new Country(QdM.AR8(8716), QdM.AR8(8734), QdM.AR8(8742)),
					new Country(QdM.AR8(8752), QdM.AR8(8798), QdM.AR8(8806)),
					new Country(QdM.AR8(8816), QdM.AR8(8896), QdM.AR8(8904)),
					new Country(QdM.AR8(8914), QdM.AR8(8954), QdM.AR8(8962)),
					new Country(QdM.AR8(8972), QdM.AR8(8988), QdM.AR8(8996)),
					new Country(QdM.AR8(9006), QdM.AR8(9038), QdM.AR8(9046)),
					new Country(QdM.AR8(9056), QdM.AR8(9080), QdM.AR8(9088)),
					new Country(QdM.AR8(9098), QdM.AR8(9166), QdM.AR8(9174)),
					new Country(QdM.AR8(9184), QdM.AR8(9202), QdM.AR8(9210)),
					new Country(QdM.AR8(9220), QdM.AR8(9246), QdM.AR8(9254)),
					new Country(QdM.AR8(9264), QdM.AR8(9294), QdM.AR8(9302)),
					new Country(QdM.AR8(9312), QdM.AR8(9334), QdM.AR8(9342)),
					new Country(QdM.AR8(9352), QdM.AR8(9370), QdM.AR8(9378)),
					new Country(QdM.AR8(9388), QdM.AR8(9406), QdM.AR8(9414)),
					new Country(QdM.AR8(9424), QdM.AR8(9446), QdM.AR8(9454)),
					new Country(QdM.AR8(9464), QdM.AR8(9488), QdM.AR8(9496)),
					new Country(QdM.AR8(9506), QdM.AR8(9522), QdM.AR8(9530)),
					new Country(QdM.AR8(9540), QdM.AR8(9554), QdM.AR8(9562)),
					new Country(QdM.AR8(9572), QdM.AR8(9590), QdM.AR8(9598)),
					new Country(QdM.AR8(9608), QdM.AR8(9624), QdM.AR8(9632)),
					new Country(QdM.AR8(9642), QdM.AR8(9686), QdM.AR8(9694)),
					new Country(QdM.AR8(9704), QdM.AR8(9728), QdM.AR8(9736)),
					new Country(QdM.AR8(9746), QdM.AR8(9802), QdM.AR8(9810)),
					new Country(QdM.AR8(9820), QdM.AR8(9844), QdM.AR8(9852)),
					new Country(QdM.AR8(9862), QdM.AR8(9898), QdM.AR8(9906)),
					new Country(QdM.AR8(9916), QdM.AR8(10004), QdM.AR8(10012)),
					new Country(QdM.AR8(10022), QdM.AR8(10034), QdM.AR8(10042)),
					new Country(QdM.AR8(10052), QdM.AR8(10070), QdM.AR8(10078)),
					new Country(QdM.AR8(10088), QdM.AR8(10108), QdM.AR8(10116)),
					new Country(QdM.AR8(10126), QdM.AR8(10140), QdM.AR8(10148)),
					new Country(QdM.AR8(10158), QdM.AR8(10210), QdM.AR8(10218)),
					new Country(QdM.AR8(10228), QdM.AR8(10252), QdM.AR8(10260)),
					new Country(QdM.AR8(10270), QdM.AR8(10294), QdM.AR8(10302)),
					new Country(QdM.AR8(10312), QdM.AR8(10336), QdM.AR8(10344)),
					new Country(QdM.AR8(10354), QdM.AR8(10368), QdM.AR8(10376)),
					new Country(QdM.AR8(10386), QdM.AR8(10408), QdM.AR8(10416)),
					new Country(QdM.AR8(10426), QdM.AR8(10446), QdM.AR8(10454)),
					new Country(QdM.AR8(10464), QdM.AR8(10480), QdM.AR8(10488)),
					new Country(QdM.AR8(10498), QdM.AR8(10514), QdM.AR8(10522)),
					new Country(QdM.AR8(10532), QdM.AR8(10552), QdM.AR8(10560)),
					new Country(QdM.AR8(10570), QdM.AR8(10594), QdM.AR8(10602)),
					new Country(QdM.AR8(10612), QdM.AR8(10630), QdM.AR8(10638)),
					new Country(QdM.AR8(10648), QdM.AR8(10678), QdM.AR8(10686)),
					new Country(QdM.AR8(10696), QdM.AR8(10710), QdM.AR8(10718)),
					new Country(QdM.AR8(10728), QdM.AR8(10760), QdM.AR8(10768)),
					new Country(QdM.AR8(10778), QdM.AR8(10796), QdM.AR8(10804)),
					new Country(QdM.AR8(10814), QdM.AR8(10836), QdM.AR8(10844)),
					new Country(QdM.AR8(10854), QdM.AR8(10880), QdM.AR8(10888)),
					new Country(QdM.AR8(10898), QdM.AR8(10914), QdM.AR8(10922)),
					new Country(QdM.AR8(10932), QdM.AR8(10946), QdM.AR8(10954)),
					new Country(QdM.AR8(10964), QdM.AR8(10978), QdM.AR8(10986)),
					new Country(QdM.AR8(10996), QdM.AR8(11008), QdM.AR8(11016)),
					new Country(QdM.AR8(11026), QdM.AR8(11052), QdM.AR8(11060)),
					new Country(QdM.AR8(11070), QdM.AR8(11082), QdM.AR8(11090)),
					new Country(QdM.AR8(11100), QdM.AR8(11116), QdM.AR8(11124)),
					new Country(QdM.AR8(11134), QdM.AR8(11146), QdM.AR8(11154)),
					new Country(QdM.AR8(11164), QdM.AR8(11200), QdM.AR8(11208)),
					new Country(QdM.AR8(11218), QdM.AR8(11254), QdM.AR8(11262)),
					new Country(QdM.AR8(11272), QdM.AR8(11298), QdM.AR8(11306)),
					new Country(QdM.AR8(11316), QdM.AR8(11336), QdM.AR8(11344)),
					new Country(QdM.AR8(11354), QdM.AR8(11370), QdM.AR8(11378)),
					new Country(QdM.AR8(11388), QdM.AR8(11442), QdM.AR8(11450)),
					new Country(QdM.AR8(11460), QdM.AR8(11480), QdM.AR8(11488)),
					new Country(QdM.AR8(11498), QdM.AR8(11524), QdM.AR8(11532)),
					new Country(QdM.AR8(11542), QdM.AR8(11584), QdM.AR8(11592)),
					new Country(QdM.AR8(11602), QdM.AR8(11622), QdM.AR8(11630)),
					new Country(QdM.AR8(11640), QdM.AR8(11654), QdM.AR8(11662)),
					new Country(QdM.AR8(11672), QdM.AR8(11692), QdM.AR8(11700)),
					new Country(QdM.AR8(11710), QdM.AR8(11724), QdM.AR8(11732)),
					new Country(QdM.AR8(11742), QdM.AR8(11760), QdM.AR8(11768)),
					new Country(QdM.AR8(11778), QdM.AR8(11796), QdM.AR8(11804)),
					new Country(QdM.AR8(11814), QdM.AR8(11830), QdM.AR8(11838)),
					new Country(QdM.AR8(11848), QdM.AR8(11888), QdM.AR8(11896)),
					new Country(QdM.AR8(11906), QdM.AR8(11922), QdM.AR8(11930)),
					new Country(QdM.AR8(11940), QdM.AR8(11968), QdM.AR8(11976)),
					new Country(QdM.AR8(11986), QdM.AR8(12020), QdM.AR8(12028)),
					new Country(QdM.AR8(12038), QdM.AR8(12062), QdM.AR8(12070)),
					new Country(QdM.AR8(12080), QdM.AR8(12094), QdM.AR8(12102)),
					new Country(QdM.AR8(12112), QdM.AR8(12128), QdM.AR8(12136)),
					new Country(QdM.AR8(12146), QdM.AR8(12168), QdM.AR8(12176)),
					new Country(QdM.AR8(12186), QdM.AR8(12278), QdM.AR8(12286)),
					new Country(QdM.AR8(12296), QdM.AR8(12316), QdM.AR8(12324)),
					new Country(QdM.AR8(12334), QdM.AR8(12382), QdM.AR8(12390)),
					new Country(QdM.AR8(12400), QdM.AR8(12420), QdM.AR8(12428)),
					new Country(QdM.AR8(12438), QdM.AR8(12466), QdM.AR8(12474)),
					new Country(QdM.AR8(12484), QdM.AR8(12508), QdM.AR8(12516)),
					new Country(QdM.AR8(12526), QdM.AR8(12544), QdM.AR8(12552)),
					new Country(QdM.AR8(12562), QdM.AR8(12580), QdM.AR8(12588)),
					new Country(QdM.AR8(12598), QdM.AR8(12618), QdM.AR8(12626)),
					new Country(QdM.AR8(12636), QdM.AR8(12662), QdM.AR8(12670)),
					new Country(QdM.AR8(12680), QdM.AR8(12726), QdM.AR8(12734)),
					new Country(QdM.AR8(12744), QdM.AR8(12770), QdM.AR8(12778)),
					new Country(QdM.AR8(12788), QdM.AR8(12842), QdM.AR8(12850)),
					new Country(QdM.AR8(12860), QdM.AR8(12904), QdM.AR8(12912)),
					new Country(QdM.AR8(12922), QdM.AR8(12944), QdM.AR8(12952)),
					new Country(QdM.AR8(12962), QdM.AR8(13014), QdM.AR8(13022)),
					new Country(QdM.AR8(13032), QdM.AR8(13044), QdM.AR8(13052)),
					new Country(QdM.AR8(13062), QdM.AR8(13120), QdM.AR8(13128)),
					new Country(QdM.AR8(13138), QdM.AR8(13150), QdM.AR8(13158)),
					new Country(QdM.AR8(13168), QdM.AR8(13188), QdM.AR8(13196)),
					new Country(QdM.AR8(13206), QdM.AR8(13230), QdM.AR8(13238)),
					new Country(QdM.AR8(13248), QdM.AR8(13266), QdM.AR8(13274)),
					new Country(QdM.AR8(13284), QdM.AR8(13310), QdM.AR8(13318)),
					new Country(QdM.AR8(13328), QdM.AR8(13356), QdM.AR8(13364)),
					new Country(QdM.AR8(13374), QdM.AR8(13392), QdM.AR8(13400)),
					new Country(QdM.AR8(13410), QdM.AR8(13424), QdM.AR8(13432)),
					new Country(QdM.AR8(13442), QdM.AR8(13458), QdM.AR8(13466)),
					new Country(QdM.AR8(13476), QdM.AR8(13518), QdM.AR8(13526)),
					new Country(QdM.AR8(13536), QdM.AR8(13552), QdM.AR8(13560)),
					new Country(QdM.AR8(13570), QdM.AR8(13586), QdM.AR8(13594)),
					new Country(QdM.AR8(13604), QdM.AR8(13664), QdM.AR8(13672)),
					new Country(QdM.AR8(13682), QdM.AR8(13700), QdM.AR8(13708)),
					new Country(QdM.AR8(13718), QdM.AR8(13734), QdM.AR8(13742)),
					new Country(QdM.AR8(13752), QdM.AR8(13828), QdM.AR8(13836)),
					new Country(QdM.AR8(13846), QdM.AR8(13876), QdM.AR8(13884)),
					new Country(QdM.AR8(13894), QdM.AR8(13912), QdM.AR8(13920)),
					new Country(QdM.AR8(13930), QdM.AR8(13954), QdM.AR8(13962)),
					new Country(QdM.AR8(13972), QdM.AR8(14034), QdM.AR8(14042)),
					new Country(QdM.AR8(14052), QdM.AR8(14120), QdM.AR8(14128)),
					new Country(QdM.AR8(14138), QdM.AR8(14208), QdM.AR8(14216)),
					new Country(QdM.AR8(14226), QdM.AR8(14276), QdM.AR8(14284)),
					new Country(QdM.AR8(14294), QdM.AR8(14338), QdM.AR8(14346)),
					new Country(QdM.AR8(14356), QdM.AR8(14376), QdM.AR8(14384)),
					new Country(QdM.AR8(14394), QdM.AR8(14412), QdM.AR8(14420)),
					new Country(QdM.AR8(14430), QdM.AR8(14468), QdM.AR8(14476)),
					new Country(QdM.AR8(14486), QdM.AR8(14500), QdM.AR8(14508)),
					new Country(QdM.AR8(14518), QdM.AR8(14532), QdM.AR8(14540)),
					new Country(QdM.AR8(14550), QdM.AR8(14568), QdM.AR8(14576)),
					new Country(QdM.AR8(14586), QdM.AR8(14614), QdM.AR8(14622)),
					new Country(QdM.AR8(14632), QdM.AR8(14648), QdM.AR8(14656)),
					new Country(QdM.AR8(14666), QdM.AR8(14686), QdM.AR8(14694))
				}.OrderBy((Country x) => x.h67));
			}
			return Y64;
		}
	}

	public string Name
	{
		get
		{
			return h67;
		}
		set
		{
			h67 = value;
		}
	}

	public Country(string name, string alpha2Code)
	{
		awj.QuEwGz();
		this._002Ector(name, alpha2Code, null);
	}

	public Country(string name, string alpha2Code, string alpha3Code)
	{
		awj.QuEwGz();
		base._002Ector();
		h67 = name;
		Y6k = alpha2Code;
		V6E = alpha3Code;
	}

	internal static bool PBF()
	{
		return tz == null;
	}

	internal static Country KBB()
	{
		return tz;
	}
}
