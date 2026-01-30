using ECOEgqlSad8NUJZ2Dr9n;
using fMNuDsUssnYTM24aSd4;
using TigerTrade.Core.Utils.Binary;
using TuAMtrl1Nd3XoZQQUXf0;

namespace z47ZjKUQdvGIKntvmej;

internal sealed class sQti28UEsv9bhEJqmb4 : BinReader<sAWOZVUeI69hxuuyBsn>
{
	private long roUUdu7LUi;

	private static sQti28UEsv9bhEJqmb4 uBAlXF44UBcKGSKH0smb;

	public sQti28UEsv9bhEJqmb4(byte[] P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(P_0);
	}

	protected override sAWOZVUeI69hxuuyBsn ReadItem()
	{
		roUUdu7LUi += ReadLeb128();
		long num = ReadLeb128();
		long num2 = bSWxyC44ZrVdqlGoDS2E(this);
		int num3 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
		{
			num3 = 0;
		}
		switch (num3)
		{
		default:
		{
			long num4 = ReadLeb128();
			return new sAWOZVUeI69hxuuyBsn(roUUdu7LUi, num, num2, num4);
		}
		}
	}

	static sQti28UEsv9bhEJqmb4()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool iqxNVF44TUok5DWAVyLU()
	{
		return uBAlXF44UBcKGSKH0smb == null;
	}

	internal static sQti28UEsv9bhEJqmb4 baEC5b44ysP7ynOWq1G5()
	{
		return uBAlXF44UBcKGSKH0smb;
	}

	internal static long bSWxyC44ZrVdqlGoDS2E(object P_0)
	{
		return ((BinReader<sAWOZVUeI69hxuuyBsn>)P_0).ReadLeb128();
	}
}
