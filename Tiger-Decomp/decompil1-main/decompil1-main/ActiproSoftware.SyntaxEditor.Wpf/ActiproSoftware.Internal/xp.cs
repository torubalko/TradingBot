using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

namespace ActiproSoftware.Internal;

internal class xp
{
	private struct F7u
	{
		public int QrE;

		public Jc lrc;

		internal static object BHr;

		public F7u(Jc P_0, int P_1)
		{
			grA.DaB7cz();
			lrc = P_0;
			QrE = P_1;
		}

		internal static bool HHX()
		{
			return BHr == null;
		}

		internal static object nHE()
		{
			return BHr;
		}
	}

	private int fmr;

	private Jc cms;

	private CM rmk;

	private int EmS;

	private List<F7u> sm9;

	internal static xp W7S;

	public xp(CM P_0, Jc P_1)
	{
		grA.DaB7cz();
		base._002Ector();
		rmk = P_0;
		cms = P_1;
	}

	private xp(xp P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		fmr = P_0.fmr;
		cms = P_0.cms;
		rmk = P_0.rmk;
		if (P_0.sm9 != null && P_0.sm9.Count > 0)
		{
			sm9 = new List<F7u>(P_0.sm9);
		}
		EmS = P_0.EmS;
	}

	private bool Lma(int P_0, int P_1)
	{
		if (P_0 >= 0 && cms.iv9() && P_0 < cms.Wvk().Count)
		{
			int num = P_1 - fmr - cms.kvh();
			return cms.Wvk()[P_0].kvh() <= num && EmX(P_0) > num;
		}
		return false;
	}

	private void tmx(Jc P_0, int P_1, int P_2, int P_3)
	{
		if (!cms.iv9())
		{
			return;
		}
		while (EmS < cms.Wvk().Count)
		{
			int num = cms.Wvk()[EmS].kvh();
			if (P_2 + num >= P_3)
			{
				while (EmS < cms.Wvk().Count)
				{
					Jc jc = cms.Wvk()[EmS];
					jc.EvN(jc.kvh() + P_2);
					if (!jc.Hvi())
					{
						jc.fvt(jc.RvJ() + P_2);
					}
					P_0.Wvk().Insert(P_1++, jc);
					cms.Wvk().RemoveAt(EmS);
				}
				break;
			}
			if (P_2 + num == P_3 - 1)
			{
				HmF(EmS);
				Cm4(_0020: true);
				continue;
			}
			int num2 = EmX(EmS);
			if (P_2 + num2 >= P_3)
			{
				HmF(EmS);
				tmx(P_0, P_1, P_2 + cms.kvh(), P_3);
				SmD();
				if (EmS < cms.Wvk().Count)
				{
					cms.Wvk()[EmS++].fvt(-1);
				}
			}
			else
			{
				EmS++;
			}
		}
	}

	private bool smG(int P_0)
	{
		if (!cms.CvM())
		{
			int num = P_0 - fmr;
			int result;
			if (cms.kvh() <= num)
			{
				int num2 = 0;
				if (!U7k())
				{
					int num3 = default(int);
					num2 = num3;
				}
				switch (num2)
				{
				}
				result = ((YmK() > num) ? 1 : 0);
			}
			else
			{
				result = 0;
			}
			return (byte)result != 0;
		}
		return true;
	}

	private int EmX(int P_0)
	{
		Jc jc = cms.Wvk()[P_0];
		if (!jc.Hvi())
		{
			return jc.RvJ();
		}
		return YmK() - cms.kvh();
	}

	private int YmK()
	{
		if (!cms.Hvi())
		{
			return cms.RvJ();
		}
		int num = 0;
		if (sm9 != null)
		{
			foreach (F7u item in sm9)
			{
				num -= item.lrc.kvh();
				if (!item.lrc.Hvi())
				{
					return item.lrc.RvJ() + num;
				}
			}
		}
		return rmk.lve() + num;
	}

	private void Hmf(Jc P_0)
	{
		if (sm9 == null)
		{
			sm9 = new List<F7u>(2);
		}
		sm9.Insert(0, new F7u(cms, EmS));
		fmr += cms.kvh();
		cms = P_0;
		EmS = 0;
	}

	private void SmD()
	{
		if (sm9 != null && sm9.Count != 0)
		{
			F7u f7u = sm9[0];
			sm9.RemoveAt(0);
			fmr -= f7u.lrc.kvh();
			cms = f7u.lrc;
			EmS = f7u.QrE;
		}
	}

	public bool wmg(IOutliningNodeDefinition P_0, TextRange P_1)
	{
		lm3(P_1.StartOffset);
		while (!cms.CvM() && (OmL() == P_1.StartOffset || Qm6() - 1 == P_1.StartOffset || Qm6() <= P_1.EndOffset))
		{
			Cm4(_0020: true);
		}
		lm3(P_1.EndOffset - 1);
		while (!cms.CvM() && (OmL() == P_1.EndOffset || Qm6() - 1 == P_1.EndOffset || OmL() >= P_1.StartOffset))
		{
			Cm4(_0020: true);
		}
		lm3(P_1.StartOffset);
		Jc jc = new Jc(P_0);
		jc.EvN(P_1.StartOffset - fmr - cms.kvh());
		jc.fvt(P_1.EndOffset - fmr - cms.kvh());
		Jc jc2 = jc;
		cms.Wvk().Insert(EmS++, jc2);
		while (EmS < cms.Wvk().Count)
		{
			Jc jc3 = cms.Wvk()[EmS];
			if (jc3.kvh() >= jc2.RvJ())
			{
				break;
			}
			cms.Wvk().RemoveAt(EmS);
			jc3.EvN(jc3.kvh() - jc2.kvh());
			if (!jc3.Hvi())
			{
				jc3.fvt(jc3.RvJ() - jc2.kvh());
			}
			jc2.Wvk().Add(jc3);
		}
		lm3(P_1.StartOffset);
		rmk.lAN(new TextSnapshotRange(rmk.Document.CurrentSnapshot, P_1));
		return true;
	}

	public void GmQ(IOutliningNodeDefinition P_0, int P_1)
	{
		Jc jc = new Jc(P_0);
		jc.EvN(P_1 - fmr - cms.kvh());
		Jc jc2 = jc;
		jc2.fvt(jc2.kvh());
		cms.Wvk().Insert(EmS, jc2);
		rmk.lAN(new TextSnapshotRange(rmk.Document.CurrentSnapshot, P_1, P_1));
		HmF(EmS);
		smY();
	}

	public int Dme(int P_0)
	{
		if (P_0 < rmk.lve())
		{
			if (!smG(P_0))
			{
				while (!cms.CvM())
				{
					SmD();
					EmS++;
					if (smG(P_0))
					{
						break;
					}
				}
				if (cms.iv9() && EmS < cms.Wvk().Count && Lma(EmS, P_0))
				{
					Hmf(cms.Wvk()[EmS]);
				}
			}
			else if (cms.iv9() && EmS < cms.Wvk().Count && Lma(EmS, P_0))
			{
				Hmf(cms.Wvk()[EmS]);
			}
		}
		if (cms.iv9() && EmS < cms.Wvk().Count)
		{
			return fmr + cms.kvh() + cms.Wvk()[EmS].kvh();
		}
		return fmr + YmK() - 1;
	}

	public bool vml(bool P_0)
	{
		if ((!P_0 || !cms.Gvq()) && cms.iv9() && EmS < cms.Wvk().Count)
		{
			HmF(EmS);
			return true;
		}
		if (!cms.CvM())
		{
			SmD();
			EmS++;
			return vml(P_0);
		}
		return false;
	}

	public xp EmA(int P_0)
	{
		if (P_0 >= 0 && P_0 < cms.Wvk().Count)
		{
			xp xp2 = new xp(this);
			xp2.EmS = P_0;
			xp2.Hmf(cms.Wvk()[P_0]);
			return xp2;
		}
		return null;
	}

	public xp Umv()
	{
		return new xp(this);
	}

	public xp ymm()
	{
		if (cms.CvM())
		{
			return null;
		}
		xp xp2 = new xp(this);
		xp2.SmD();
		return xp2;
	}

	public void ymC(int P_0)
	{
		if (!cms.CvM())
		{
			int num = P_0 - fmr;
			if (cms.kvh() >= num)
			{
				throw new ArgumentOutOfRangeException(Q7Z.tqM(11796), Q7Z.tqM(11812));
			}
			bool flag = cms.iv9() && EmS < cms.Wvk().Count && (cms.Wvk()[cms.Wvk().Count - 1].RvJ() == -1 || cms.Wvk()[cms.Wvk().Count - 1].RvJ() + cms.kvh() >= num);
			cms.fvt(num);
			if (flag)
			{
				xp xp2 = Umv();
				xp2.tmx(sm9[0].lrc, sm9[0].QrE + 1, cms.kvh(), num);
			}
			rmk.lAN(new TextSnapshotRange(rmk.Document.CurrentSnapshot, P_0, P_0));
			SmD();
			EmS++;
		}
	}

	[SpecialName]
	public int Qm6()
	{
		return fmr + YmK();
	}

	[SpecialName]
	public TextSnapshotRange tmb()
	{
		return new TextSnapshotRange(rmk.Document.CurrentSnapshot, OmL(), Qm6());
	}

	[SpecialName]
	public int OmL()
	{
		return fmr + cms.kvh();
	}

	[SpecialName]
	public Jc tm8()
	{
		return cms;
	}

	public int Umu(int P_0)
	{
		if (!cms.iv9())
		{
			return -1;
		}
		int num = P_0 - fmr - cms.kvh();
		int num2 = 0;
		int num3 = cms.Wvk().Count - 1;
		while (num2 <= num3)
		{
			int num4 = (num2 + num3) / 2;
			if (num >= cms.Wvk()[num4].kvh() && num < EmX(num4))
			{
				return num4;
			}
			if (num < cms.Wvk()[num4].kvh())
			{
				num3 = num4 - 1;
			}
			else
			{
				num2 = num4 + 1;
			}
		}
		if (num3 >= 0)
		{
			if (num < cms.Wvk()[num3].kvh())
			{
				return ~num3;
			}
			return ~(num3 + 1);
		}
		return -1;
	}

	[SpecialName]
	public CM xm5()
	{
		return rmk;
	}

	public void Dm1()
	{
		if (sm9 == null)
		{
			return;
		}
		int num3 = default(int);
		for (int num = sm9.Count - 1; num >= 0; num--)
		{
			Jc lrc = sm9[num].lrc;
			if (lrc != null && lrc.Gvq() && !lrc.CvM())
			{
				int num2 = 1;
				if (I7Z() != null)
				{
					num2 = num3;
				}
				switch (num2)
				{
				default:
					AmR();
					num = Math.Min(num, sm9.Count);
					goto case 1;
				case 1:
					if (tm8() == lrc)
					{
						break;
					}
					goto default;
				}
			}
		}
	}

	public void HmF(int P_0)
	{
		if (P_0 >= 0 && cms.iv9() && P_0 < cms.Wvk().Count)
		{
			EmS = P_0;
			Hmf(cms.Wvk()[P_0]);
		}
	}

	public void lm3(int P_0)
	{
		Wmo();
		if (P_0 != rmk.lve())
		{
			goto IL_0116;
		}
		while (cms.iv9() && cms.Wvk()[cms.Wvk().Count - 1].Hvi())
		{
			HmF(cms.Wvk().Count - 1);
		}
		EmS = (cms.iv9() ? cms.Wvk().Count : 0);
		int num = 0;
		if (!U7k())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		default:
			return;
		case 0:
			return;
		case 1:
			break;
		}
		goto IL_0116;
		IL_0116:
		int num3 = Umu(P_0);
		if (num3 >= 0)
		{
			EmS = num3;
			Hmf(cms.Wvk()[EmS]);
			num = 0;
			if (I7Z() == null)
			{
				num = 1;
			}
			goto IL_0009;
		}
		EmS = ~num3;
	}

	public void AmR()
	{
		if (!cms.CvM())
		{
			SmD();
		}
	}

	[SpecialName]
	public int NmB()
	{
		return (sm9 != null) ? sm9.Count : 0;
	}

	public void smY()
	{
		if (cms.CvM() || cms.Hvi())
		{
			return;
		}
		int startOffset = Qm6();
		cms.fvt(-1);
		Jc lrc = sm9[0].lrc;
		int num = sm9[0].QrE + 1;
		if (lrc.iv9() && num < lrc.Wvk().Count)
		{
			Jc jc = cms;
			int num2 = -jc.kvh();
			while (jc.iv9() && jc.Wvk()[jc.Wvk().Count - 1].Hvi())
			{
				jc = jc.Wvk()[jc.Wvk().Count - 1];
				num2 -= jc.kvh();
			}
			while (num < lrc.Wvk().Count)
			{
				Jc jc2 = lrc.Wvk()[num];
				lrc.Wvk().RemoveAt(num);
				jc2.EvN(jc2.kvh() + num2);
				if (jc2.kvh() > 0)
				{
					if (!jc2.Hvi())
					{
						jc2.fvt(jc2.RvJ() + num2);
					}
					jc.Wvk().Add(jc2);
				}
			}
		}
		rmk.lAN(new TextSnapshotRange(rmk.Document.CurrentSnapshot, startOffset, Qm6()));
	}

	public void Cm4(bool P_0)
	{
		if (cms.CvM())
		{
			return;
		}
		Jc jc = cms;
		rmk.lAN(tmb());
		int num = 0;
		if (I7Z() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		SmD();
		if (!cms.iv9() || EmS >= cms.Wvk().Count)
		{
			return;
		}
		int emS = EmS;
		cms.Wvk().RemoveAt(emS);
		if (!P_0)
		{
			return;
		}
		foreach (Jc item in jc.Wvk())
		{
			item.EvN(item.kvh() + jc.kvh());
			if (!item.Hvi())
			{
				item.fvt(item.RvJ() + jc.kvh());
			}
			cms.Wvk().Insert(emS++, item);
		}
	}

	public void Wmo()
	{
		fmr = 0;
		EmS = 0;
		if (sm9 != null && sm9.Count > 0)
		{
			cms = sm9[sm9.Count - 1].lrc;
			sm9.Clear();
		}
	}

	public int vmj(int P_0, int P_1)
	{
		int num = P_0;
		lm3(P_0);
		if (!cms.CvM() && cms.Gvq())
		{
			rmk.AAz(this, false);
		}
		if (!cms.CvM() && P_0 == OmL())
		{
			num = Math.Max(num, Qm6());
			Cm4(_0020: true);
		}
		if (cms.iv9() && EmS < cms.Wvk().Count)
		{
			HmF(EmS);
		}
		int num2 = P_0 + P_1;
		while (!cms.CvM())
		{
			bool flag = false;
			bool flag2 = false;
			if (P_0 <= OmL())
			{
				if (num2 > OmL())
				{
					num = Math.Max(num, Qm6());
					if (num2 < Qm6())
					{
						Cm4(_0020: true);
						flag2 = true;
					}
					else
					{
						Cm4(_0020: false);
						flag2 = true;
					}
					flag = true;
				}
				else
				{
					Jc jc = cms;
					jc.EvN(jc.kvh() - P_1);
					if (!cms.Hvi())
					{
						Jc jc2 = cms;
						jc2.fvt(jc2.RvJ() - P_1);
					}
				}
			}
			else if (num2 < Qm6())
			{
				if (!cms.Hvi())
				{
					Jc jc3 = cms;
					jc3.fvt(jc3.RvJ() - P_1);
				}
				flag = true;
			}
			else if (rmk.ActiveMode == OutliningMode.Automatic)
			{
				smY();
				flag = true;
			}
			else
			{
				num = Math.Max(num, Qm6());
				Cm4(_0020: true);
				flag2 = true;
			}
			if (flag && cms.iv9() && EmS < cms.Wvk().Count)
			{
				HmF(EmS);
				continue;
			}
			if (!(flag2 && flag))
			{
				SmD();
			}
			if (!flag2)
			{
				EmS++;
			}
			if (cms.iv9() && EmS < cms.Wvk().Count)
			{
				HmF(EmS);
			}
		}
		return num;
	}

	public void Amw(int P_0, int P_1)
	{
		lm3(P_0);
		if (!cms.CvM() && cms.Gvq() && P_0 > OmL())
		{
			rmk.AAz(this, false);
		}
		if (P_0 >= OmL() && cms.iv9() && EmS < cms.Wvk().Count)
		{
			HmF(EmS);
		}
		while (!cms.CvM())
		{
			if (P_0 <= OmL())
			{
				Jc jc = cms;
				jc.EvN(jc.kvh() + P_1);
				if (!cms.Hvi())
				{
					Jc jc2 = cms;
					jc2.fvt(jc2.RvJ() + P_1);
				}
			}
			else if (!cms.Hvi())
			{
				Jc jc3 = cms;
				jc3.fvt(jc3.RvJ() + P_1);
			}
			SmD();
			EmS++;
			if (cms.iv9() && EmS < cms.Wvk().Count)
			{
				HmF(EmS);
			}
		}
	}

	internal static bool U7k()
	{
		return W7S == null;
	}

	internal static xp I7Z()
	{
		return W7S;
	}
}
