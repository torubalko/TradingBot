using System;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Core.Utils.Binary;
using TuAMtrl1Nd3XoZQQUXf0;
using y0NVxPIMRsnabaLT4l5;

namespace qQ3pRxIhHRYpJkP6xvw;

internal sealed class ssKP3QImggmMrEx7NgL : BinReader<pHt7cGI6aYE4MplEqcN>
{
	private long pIUIwL6J1l;

	private long WD8I78qsrU;

	internal static ssKP3QImggmMrEx7NgL JlMsdf4l5euFxB4yY0Jd;

	public ssKP3QImggmMrEx7NgL(byte[] P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(P_0);
	}

	protected override pHt7cGI6aYE4MplEqcN ReadItem()
	{
		pIUIwL6J1l += ReadLeb128();
		WD8I78qsrU += ReadLeb128();
		return new pHt7cGI6aYE4MplEqcN
		{
			Time = new DateTime(pIUIwL6J1l),
			ywaIOm9J7t = WD8I78qsrU,
			qdbIqpOt94 = ReadLeb128(),
			GLTIIeIy3D = B9yaUl4lLFk1DuEsLFPd(this),
			wGTIW4anXs = ReadLeb128(),
			K7dItOxv6u = B9yaUl4lLFk1DuEsLFPd(this),
			glQIUXvYP3 = B9yaUl4lLFk1DuEsLFPd(this),
			rPmITCd11T = B9yaUl4lLFk1DuEsLFPd(this),
			qDAIye9tGJ = ReadLeb128(),
			TgsIZPsOUt = ReadLeb128(),
			k74IV7v2R1 = ReadLeb128(),
			hhmICxkHpu = ReadLeb128(),
			rUaIrgGJUl = B9yaUl4lLFk1DuEsLFPd(this),
			qsuIKTCTxM = ReadLeb128()
		};
	}

	static ssKP3QImggmMrEx7NgL()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool IqIHP04lSE41xRSWmXr1()
	{
		return JlMsdf4l5euFxB4yY0Jd == null;
	}

	internal static ssKP3QImggmMrEx7NgL YkNAJB4lxAroCWPgpl4q()
	{
		return JlMsdf4l5euFxB4yY0Jd;
	}

	internal static long B9yaUl4lLFk1DuEsLFPd(object P_0)
	{
		return ((BinReader<pHt7cGI6aYE4MplEqcN>)P_0).ReadLeb128();
	}
}
