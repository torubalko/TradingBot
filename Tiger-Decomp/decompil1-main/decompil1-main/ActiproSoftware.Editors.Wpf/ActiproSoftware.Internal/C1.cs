using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using ActiproSoftware.Products.Editors;

namespace ActiproSoftware.Internal;

internal class C1
{
	private class fd5
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int mKE;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int RK7;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int jK4;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string yKB;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int[] qKh;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int HKw;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool bKN;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int[] dKU;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private int EKz;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string ORQ;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool aRV;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int aRC;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int[] xR6;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private int MRM;

		internal static fd5 Wtg;

		public int Offset
		{
			[CompilerGenerated]
			get
			{
				return EKz;
			}
			[CompilerGenerated]
			private set
			{
				EKz = eKz;
			}
		}

		public fd5(C1 P_0, int P_1)
		{
			awj.QuEwGz();
			base._002Ector();
			hKx(P_0.EgZ);
			iKT(P_0.ign);
			WKD(P_0.Uge.ToString());
			CKu(P_0.bgE.ToArray());
			UKd(P_0.pg7);
			int num = 0;
			if (false)
			{
				int num2;
				num = num2;
			}
			switch (num)
			{
			}
			wKF(P_0.Fg4.ToArray());
			Offset = P_0.igz.Offset;
			TKr(P_0.IoQ);
			VKW(P_1);
			wKt(P_0.eoC.ToArray());
			gKe(P_0.uo6);
		}

		[SpecialName]
		[CompilerGenerated]
		public int LKX()
		{
			return mKE;
		}

		[SpecialName]
		[CompilerGenerated]
		private void hKx(int P_0)
		{
			mKE = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int QKY()
		{
			return RK7;
		}

		[SpecialName]
		[CompilerGenerated]
		public void kKg(int P_0)
		{
			RK7 = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int zKO()
		{
			return jK4;
		}

		[SpecialName]
		[CompilerGenerated]
		private void iKT(int P_0)
		{
			jK4 = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public string gKb()
		{
			return yKB;
		}

		[SpecialName]
		[CompilerGenerated]
		private void WKD(string P_0)
		{
			yKB = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int[] zKq()
		{
			return qKh;
		}

		[SpecialName]
		[CompilerGenerated]
		private void CKu(int[] P_0)
		{
			qKh = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int HKR()
		{
			return HKw;
		}

		[SpecialName]
		[CompilerGenerated]
		private void UKd(int P_0)
		{
			HKw = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public bool xK5()
		{
			return bKN;
		}

		[SpecialName]
		[CompilerGenerated]
		public void kKc(bool P_0)
		{
			bKN = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int[] OKL()
		{
			return dKU;
		}

		[SpecialName]
		[CompilerGenerated]
		private void wKF(int[] P_0)
		{
			dKU = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public string bKm()
		{
			return ORQ;
		}

		[SpecialName]
		[CompilerGenerated]
		public void dKS(string P_0)
		{
			ORQ = P_0;
		}

		public void mKl(C1 P_0)
		{
			P_0.EgZ = LKX();
			P_0.bgE = zKq().ToArray();
			P_0.pg7 = HKR();
			P_0.Fg4 = new List<int>(OKL());
			P_0.pgN = sKp();
			P_0.igz.Offset = Offset;
			int num = 0;
			if (ptY() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			P_0.IoQ = mK8();
			P_0.eoC = HKZ().ToArray();
			P_0.uo6 = oKJ();
			P_0.Lg0(zKO());
		}

		[SpecialName]
		[CompilerGenerated]
		public bool mK8()
		{
			return aRV;
		}

		[SpecialName]
		[CompilerGenerated]
		private void TKr(bool P_0)
		{
			aRV = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int sKp()
		{
			return aRC;
		}

		[SpecialName]
		[CompilerGenerated]
		private void VKW(int P_0)
		{
			aRC = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int[] HKZ()
		{
			return xR6;
		}

		[SpecialName]
		[CompilerGenerated]
		private void wKt(int[] P_0)
		{
			xR6 = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int oKJ()
		{
			return MRM;
		}

		[SpecialName]
		[CompilerGenerated]
		private void gKe(int P_0)
		{
			MRM = P_0;
		}

		internal static bool yts()
		{
			return Wtg == null;
		}

		internal static fd5 ptY()
		{
			return Wtg;
		}
	}

	private int EgZ;

	private List<int> rgt;

	private int ign;

	private int[] ygJ;

	private StringBuilder Uge;

	private Dictionary<int, char> cgk;

	private int[] bgE;

	private int pg7;

	private List<int> Fg4;

	private List<fd5> zgB;

	private int Ygh;

	private bool Ugw;

	private int pgN;

	private char XgU;

	private gf igz;

	private bool IoQ;

	private string[] OoV;

	private int[] eoC;

	private int uo6;

	private u2 VoM;

	internal static C1 la3;

	internal C1(int[] P_0, string[] P_1, bool P_2, char P_3)
	{
		awj.QuEwGz();
		rgt = new List<int>();
		Uge = new StringBuilder();
		cgk = new Dictionary<int, char>();
		Fg4 = new List<int>();
		zgB = new List<fd5>();
		VoM = u2.qYo();
		base._002Ector();
		ygJ = P_0;
		OoV = P_1;
		Ugw = P_2;
		XgU = P_3;
		bgE = new int[20];
		eoC = new int[40];
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	[SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
	private string WgX(int P_0, ref int P_1)
	{
		string text = null;
		StringBuilder stringBuilder = new StringBuilder();
		List<int> list = new List<int>();
		int num = 0;
		while (true)
		{
			int num2;
			switch (Ygh)
			{
			case 29:
				if (stringBuilder.Length > 0 && (text == null || stringBuilder.Length < text.Length))
				{
					text = stringBuilder.ToString();
				}
				if (num-- > 0)
				{
					break;
				}
				return text ?? string.Empty;
			case 16:
				num++;
				HgH(igz.Offset);
				qgS(2);
				continue;
			case 80:
				igz.Offset = Ngd();
				Lg0(Xgx(1));
				continue;
			case 48:
				list.Add(stringBuilder.Length);
				EgZ++;
				Ugc();
				qgS(1);
				continue;
			case 112:
			{
				EgZ = Math.Max(0, EgZ - 1);
				int num5 = list[list.Count - 1];
				if (num5 < stringBuilder.Length)
				{
					stringBuilder.Remove(num5, stringBuilder.Length - num5);
				}
				list.RemoveAt(list.Count - 1);
				break;
			}
			case 49:
				EgZ = Math.Max(0, EgZ - 1);
				Ugc();
				qgS(1);
				continue;
			case 113:
				EgZ++;
				break;
			case 3:
			case 259:
			case 515:
				stringBuilder.Append(XgU);
				Ugc();
				qgS(3);
				continue;
			case 67:
			case 323:
			case 579:
				stringBuilder.Remove(stringBuilder.Length - 1, 1);
				break;
			case 4:
			case 260:
			case 516:
			{
				string text3 = OoV[Xgx(1)];
				if (pgN < text3.Length)
				{
					if (P_1 == stringBuilder.Length && EgZ == P_0)
					{
						P_1 += text3.Length - pgN;
					}
					stringBuilder.Append((EgZ > P_0) ? new string(XgU, text3.Length - pgN) : text3.Substring(pgN));
				}
				pgN = 0;
				Ugc();
				qgS(2);
				continue;
			}
			case 68:
			case 324:
			case 580:
			{
				string text2 = OoV[Xgx(1)];
				stringBuilder.Remove(stringBuilder.Length - text2.Length, text2.Length);
				break;
			}
			case 1:
			case 257:
			case 513:
			{
				char value = ((EgZ > P_0) ? XgU : ((char)Xgx(1)));
				if (P_1 == stringBuilder.Length && EgZ == P_0)
				{
					P_1++;
				}
				stringBuilder.Append(value);
				Ugc();
				qgS(2);
				continue;
			}
			case 65:
			case 321:
			case 577:
				stringBuilder.Remove(stringBuilder.Length - 1, 1);
				break;
			case 2:
			case 258:
			case 514:
				stringBuilder.Append(XgU);
				Ugc();
				qgS(2);
				continue;
			case 66:
			case 322:
			case 578:
				stringBuilder.Remove(stringBuilder.Length - 1, 1);
				break;
			case 22:
				Ng9(igz.Offset);
				Ugc();
				qgS(1);
				continue;
			case 21:
				Ng9(-1);
				Ugc();
				qgS(1);
				Lg0(Xgx(1));
				continue;
			case 85:
			case 86:
				TgR();
				break;
			case 17:
				num2 = TgR();
				RgF(num2);
				qgS(2);
				continue;
			case 81:
			{
				int num4 = list[list.Count - 1];
				if (num4 < stringBuilder.Length)
				{
					stringBuilder.Remove(num4, stringBuilder.Length - num4);
				}
				list.RemoveAt(list.Count - 1);
				num2 = Ngd();
				int num3 = Ngd();
				TgR();
				igz.Offset = num2;
				RgF(num3);
				qgS(2);
				continue;
			}
			case 145:
				Ng9(Ngd());
				break;
			case 24:
				igz.Offset = TgR();
				HgH(igz.Offset);
				qgS(1);
				continue;
			case 88:
				Ng9(Ngd());
				break;
			case 23:
				num2 = TgR();
				HgH(num2);
				qgS(2);
				continue;
			case 87:
				Ng9(Ngd());
				break;
			case 19:
				kg5(igz.Offset, Xgx(1));
				Ugc();
				qgS(2);
				continue;
			case 18:
				qgS(2);
				Lg0(Xgx(1) + 3);
				continue;
			case 82:
			case 83:
				TgR();
				TgR();
				break;
			case 20:
			{
				num2 = TgR();
				int num3 = TgR();
				if (num2 < Math.Min(0, Xgx(2)) && (igz.Offset - num3 != 0 || num2 < 0))
				{
					HgH(num3);
					kg5(igz.Offset, num2 + 1);
					Lg0(Xgx(1));
				}
				else
				{
					rgA(num3, num2);
					qgS(3);
				}
				continue;
			}
			case 84:
			{
				num2 = Ngd();
				int num3 = TgR();
				if (num3 > 0)
				{
					igz.Offset = TgR();
					rgA(num2, num3 - 1);
					qgS(3);
					continue;
				}
				kg5(TgR(), num3 - 1);
				break;
			}
			case 148:
			{
				num2 = Ngd();
				int num3 = Ngd();
				kg5(num3, num2);
				break;
			}
			case 28:
				Lg0(Xgx(1));
				continue;
			case 32:
			case 33:
			case 34:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
			case 42:
			case 43:
			case 44:
			case 45:
			case 46:
			case 47:
				stringBuilder.Append(XgU);
				Ugc();
				qgS(1);
				continue;
			case 96:
			case 97:
			case 98:
			case 100:
			case 101:
			case 102:
			case 103:
			case 104:
			case 105:
			case 106:
			case 107:
			case 108:
			case 109:
			case 110:
			case 111:
				stringBuilder.Remove(stringBuilder.Length - 1, 1);
				break;
			case 31:
				IoQ = true;
				Ugc();
				qgS(1);
				continue;
			case 95:
				IoQ = false;
				break;
			case 30:
				IoQ = false;
				Ugc();
				qgS(1);
				continue;
			case 94:
				IoQ = true;
				break;
			default:
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExInvalidRegexOpCode), new object[1] { Ygh }));
			case 35:
				break;
			}
			num2 = Ngd();
			if (num2 < 0)
			{
				ign = -num2;
				Ygh = ygJ[ign] | 0x80;
			}
			else
			{
				ign = num2;
				Ygh = ygJ[ign] | 0x40;
			}
		}
	}

	private int Xgx(int P_0)
	{
		return ygJ[ign + P_0];
	}

	private void Lg0(int P_0)
	{
		ign = P_0;
		Ygh = ygJ[ign];
	}

	private void XgY(int P_0)
	{
		Pgp(P_0);
		rgt.Add(P_0);
	}

	private void tgg(int P_0, char P_1)
	{
		if (cgk.TryGetValue(P_0, out var value))
		{
			if (value == '\0' || value == P_1)
			{
				int num = 0;
				if (!pab())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
			else
			{
				cgk[P_0] = '\0';
			}
		}
		else
		{
			cgk[P_0] = P_1;
		}
	}

	private void Sgo(int P_0)
	{
		egW(P_0);
		if (!rgt.Contains(P_0))
		{
			Fg4.Add(P_0);
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private fd5 NgO()
	{
		int num = 0;
		KgK();
		while (true)
		{
			int num2;
			switch (Ygh)
			{
			case 29:
			{
				if (num-- > 0)
				{
					break;
				}
				fd5 fd2 = (from d in zgB
					orderby d.Offset descending
					orderby (!d.xK5()) ? 1 : 0
					select d).FirstOrDefault();
				fd2?.mKl(this);
				return fd2;
			}
			case 16:
				num++;
				HgH(igz.Offset);
				qgS(2);
				continue;
			case 80:
				num = Math.Max(0, num - 1);
				igz.Offset = Ngd();
				Lg0(Xgx(1));
				continue;
			case 48:
				EgZ++;
				Ugc();
				qgS(1);
				continue;
			case 112:
				EgZ = Math.Max(0, EgZ - 1);
				break;
			case 49:
				EgZ = Math.Max(0, EgZ - 1);
				Ugc();
				qgS(1);
				continue;
			case 113:
				EgZ++;
				break;
			case 3:
			case 259:
			case 515:
			{
				tgg(igz.Offset, '\0');
				bool flag = Ygh == 515;
				if (XgT(OoV[Xgx(1)], OoV[Xgx(2)], flag))
				{
					HgH(igz.Offset - 1);
					qgS(3);
					KgK();
					continue;
				}
				break;
			}
			case 67:
			case 323:
			case 579:
				igz.Offset = Ngd();
				rgv();
				break;
			case 1:
			{
				char c2 = (char)Xgx(1);
				tgg(igz.Offset, c2);
				if (bgb(c2))
				{
					Uge.Append(c2);
					Sgo(igz.Offset - 1);
					HgH(igz.Offset - 1);
					qgS(2);
					KgK();
					continue;
				}
				break;
			}
			case 257:
			case 513:
			{
				char c = (char)Xgx(1);
				tgg(igz.Offset, c);
				bool flag3 = Ygh == 516;
				if (DgI(c))
				{
					Uge.Append(flag3 ? c : igz.MkA());
					Sgo(igz.Offset - 1);
					HgH(igz.Offset - 1);
					qgS(2);
					KgK();
					continue;
				}
				break;
			}
			case 65:
			case 321:
			case 577:
				igz.Offset = Ngd();
				rgv();
				egW(igz.Offset);
				break;
			case 4:
			{
				string text2 = OoV[Xgx(1)];
				if (Agu(text2))
				{
					HgH(igz.Offset - text2.Length);
					qgS(2);
					continue;
				}
				break;
			}
			case 260:
			case 516:
			{
				string text = OoV[Xgx(1)];
				bool flag2 = Ygh == 516;
				if (Egq(text, flag2))
				{
					HgH(igz.Offset - text.Length);
					qgS(2);
					continue;
				}
				break;
			}
			case 68:
			case 324:
			case 580:
				igz.Offset = Ngd();
				rgv();
				egW(igz.Offset);
				break;
			case 2:
				tgg(igz.Offset, '\0');
				if (VgG((char)Xgx(1)))
				{
					Uge.Append(igz.MkA());
					HgH(igz.Offset - 1);
					qgS(2);
					KgK();
					continue;
				}
				break;
			case 258:
			case 514:
				tgg(igz.Offset, '\0');
				if (agD((char)Xgx(1)))
				{
					Uge.Append(igz.MkA());
					HgH(igz.Offset - 1);
					qgS(2);
					KgK();
					continue;
				}
				break;
			case 42:
				tgg(igz.Offset, '\0');
				if (dgr() > 0 && Xg8() != XgU && char.IsWhiteSpace(Xg8()))
				{
					switch (Xg8())
					{
					default:
						Uge.Append(Xg8());
						HgH(igz.Offset);
						qg1();
						qgS(1);
						KgK();
						continue;
					case '\n':
					case '\r':
					case '\u2028':
					case '\u2029':
						break;
					}
				}
				break;
			case 44:
				tgg(igz.Offset, '\0');
				if (dgr() > 0 && Xg8() != XgU)
				{
					switch (Xg8())
					{
					case '\n':
					case '\r':
					case '\u2028':
					case '\u2029':
						Uge.Append(Xg8());
						HgH(igz.Offset);
						qg1();
						qgS(1);
						KgK();
						continue;
					}
				}
				break;
			case 66:
			case 106:
			case 108:
			case 322:
			case 578:
				igz.Offset = Ngd();
				rgv();
				break;
			case 22:
				Ng9(igz.Offset);
				Ugc();
				qgS(1);
				continue;
			case 86:
				TgR();
				break;
			case 21:
				XgY(igz.Offset);
				Ng9(-1);
				Ugc();
				qgS(1);
				continue;
			case 85:
				Pgp(igz.Offset);
				TgR();
				break;
			case 17:
				XgY(igz.Offset);
				num2 = TgR();
				if (igz.Offset - num2 != 0)
				{
					qgL(num2, igz.Offset);
					Ng9(igz.Offset);
					Lg0(Xgx(1));
				}
				else
				{
					RgF(num2);
					qgS(2);
				}
				continue;
			case 81:
			{
				num2 = Ngd();
				int num3 = Ngd();
				TgR();
				igz.Offset = num2;
				RgF(num3);
				qgS(2);
				continue;
			}
			case 145:
				Ng9(Ngd());
				break;
			case 24:
				igz.Offset = TgR();
				HgH(igz.Offset);
				qgS(1);
				continue;
			case 88:
				Ng9(Ngd());
				break;
			case 23:
				num2 = TgR();
				if (Xgx(1) == 0 && zgB.Count > 0)
				{
					fd5 fd = zgB[zgB.Count - 1];
					if (fd.Offset == igz.Offset)
					{
						fd.kKc(_0020: true);
					}
				}
				HgH(num2);
				qgS(2);
				continue;
			case 87:
				Ng9(Ngd());
				break;
			case 19:
				kg5(igz.Offset, Xgx(1));
				Ugc();
				qgS(2);
				continue;
			case 83:
				TgR();
				TgR();
				break;
			case 18:
				XgY(igz.Offset);
				kg5(-1, Xgx(1));
				Ugc();
				qgS(2);
				continue;
			case 82:
				Pgp(igz.Offset);
				TgR();
				TgR();
				break;
			case 20:
			{
				num2 = TgR();
				int num3 = TgR();
				if (num2 < Xgx(2) && (igz.Offset - num3 != 0 || num2 < 0))
				{
					XgY(igz.Offset);
					HgH(num3);
					kg5(igz.Offset, num2 + 1);
					Lg0(Xgx(1));
				}
				else
				{
					rgA(num3, num2);
					qgS(3);
				}
				continue;
			}
			case 84:
			{
				num2 = Ngd();
				int num3 = TgR();
				if (num3 > 0)
				{
					igz.Offset = TgR();
					rgA(num2, num3 - 1);
					qgS(3);
					continue;
				}
				kg5(TgR(), num3 - 1);
				break;
			}
			case 148:
			{
				num2 = Ngd();
				int num3 = Ngd();
				kg5(num3, num2);
				break;
			}
			case 28:
				Lg0(Xgx(1));
				continue;
			case 34:
				tgg(igz.Offset, '\0');
				if (dgr() <= 0 || Xg8() == XgU)
				{
					break;
				}
				Uge.Append(Xg8());
				HgH(igz.Offset);
				qg1();
				qgS(1);
				KgK();
				continue;
			case 36:
				tgg(igz.Offset, '\0');
				if (dgr() <= 0 || Xg8() == XgU || !char.IsLetter(Xg8()))
				{
					break;
				}
				Uge.Append(Xg8());
				HgH(igz.Offset);
				qg1();
				qgS(1);
				KgK();
				continue;
			case 38:
				tgg(igz.Offset, '\0');
				if (dgr() <= 0 || Xg8() == XgU || !char.IsDigit(Xg8()))
				{
					break;
				}
				Uge.Append(Xg8());
				HgH(igz.Offset);
				qg1();
				qgS(1);
				KgK();
				continue;
			case 40:
				tgg(igz.Offset, '\0');
				if (dgr() <= 0 || Xg8() == XgU || QdM.AR8(23646).IndexOf(Xg8().ToString(), StringComparison.OrdinalIgnoreCase) == -1)
				{
					break;
				}
				Uge.Append(Xg8());
				HgH(igz.Offset);
				qg1();
				qgS(1);
				KgK();
				continue;
			case 46:
				tgg(igz.Offset, '\0');
				if (dgr() <= 0 || Xg8() == XgU || !char.IsWhiteSpace(Xg8()))
				{
					break;
				}
				Uge.Append(Xg8());
				HgH(igz.Offset);
				qg1();
				qgS(1);
				KgK();
				continue;
			case 37:
				tgg(igz.Offset, '\0');
				if (dgr() <= 0 || Xg8() == XgU || char.IsLetter(Xg8()))
				{
					break;
				}
				Uge.Append(Xg8());
				HgH(igz.Offset);
				qg1();
				qgS(1);
				KgK();
				continue;
			case 39:
				tgg(igz.Offset, '\0');
				if (dgr() <= 0 || Xg8() == XgU || char.IsDigit(Xg8()))
				{
					break;
				}
				Uge.Append(Xg8());
				HgH(igz.Offset);
				qg1();
				qgS(1);
				KgK();
				continue;
			case 41:
				tgg(igz.Offset, '\0');
				if (dgr() <= 0 || Xg8() == XgU || QdM.AR8(23646).IndexOf(Xg8().ToString(), StringComparison.OrdinalIgnoreCase) != -1)
				{
					break;
				}
				Uge.Append(Xg8());
				HgH(igz.Offset);
				qg1();
				qgS(1);
				KgK();
				continue;
			case 45:
				tgg(igz.Offset, '\0');
				if (dgr() > 0 && Xg8() != XgU)
				{
					switch (Xg8())
					{
					default:
						Uge.Append(Xg8());
						HgH(igz.Offset);
						qg1();
						qgS(1);
						KgK();
						continue;
					case '\n':
					case '\r':
					case '\u2028':
					case '\u2029':
						break;
					}
				}
				break;
			case 47:
				tgg(igz.Offset, '\0');
				if (dgr() > 0 && Xg8() != XgU && !char.IsWhiteSpace(Xg8()))
				{
					Uge.Append(Xg8());
					HgH(igz.Offset);
					qg1();
					qgS(1);
					KgK();
					continue;
				}
				break;
			case 43:
				tgg(igz.Offset, '\0');
				if (dgr() > 0 && Xg8() != XgU)
				{
					if (!char.IsWhiteSpace(Xg8()))
					{
						Uge.Append(Xg8());
						HgH(igz.Offset);
						qg1();
						qgS(1);
						KgK();
						continue;
					}
					switch (Xg8())
					{
					case '\n':
					case '\r':
					case '\u2028':
					case '\u2029':
						Uge.Append(Xg8());
						HgH(igz.Offset);
						qg1();
						qgS(1);
						KgK();
						continue;
					}
				}
				break;
			case 33:
				tgg(igz.Offset, '\0');
				if (dgr() <= 0 || Xg8() == XgU || VoM.q0v(Xg8()))
				{
					break;
				}
				Uge.Append(Xg8());
				HgH(igz.Offset);
				qg1();
				qgS(1);
				KgK();
				continue;
			case 32:
				tgg(igz.Offset, '\0');
				if (dgr() <= 0 || Xg8() == XgU || !VoM.q0v(Xg8()))
				{
					break;
				}
				Uge.Append(Xg8());
				HgH(igz.Offset);
				qg1();
				qgS(1);
				KgK();
				continue;
			case 96:
			case 97:
			case 98:
			case 100:
			case 101:
			case 102:
			case 103:
			case 104:
			case 105:
			case 107:
			case 109:
			case 110:
			case 111:
				igz.Offset = Ngd();
				rgv();
				break;
			case 31:
				IoQ = true;
				Ugc();
				qgS(1);
				continue;
			case 95:
				IoQ = false;
				break;
			case 30:
				IoQ = false;
				Ugc();
				qgS(1);
				continue;
			case 94:
				IoQ = true;
				break;
			default:
				throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExInvalidRegexOpCode), new object[1] { Ygh }));
			case 35:
				break;
			}
			num2 = Ngd();
			if (num2 < 0)
			{
				ign = -num2;
				Ygh = ygJ[ign] | 0x80;
			}
			else
			{
				ign = num2;
				Ygh = ygJ[ign] | 0x40;
			}
		}
	}

	[SuppressMessage("Microsoft.Globalization", "CA1304:SpecifyCultureInfo", MessageId = "System.Char.ToUpper(System.Char)")]
	[SuppressMessage("Microsoft.Globalization", "CA1304:SpecifyCultureInfo", MessageId = "System.Char.ToLower(System.Char)")]
	private bool XgT(string P_0, string P_1, bool P_2)
	{
		bool result = default(bool);
		int num;
		char c = default(char);
		bool flag = default(bool);
		if (dgr() <= 0)
		{
			result = false;
			num = 1;
			if (!pab())
			{
				goto IL_0005;
			}
		}
		else
		{
			c = Xg8();
			if (c == XgU)
			{
				result = false;
				goto IL_01c3;
			}
			flag = u2.e03(P_1, c);
			num = 2;
			if (kad() != null)
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_01c3:
		return result;
		IL_0009:
		switch (num)
		{
		default:
			if (char.IsLower(c))
			{
				Uge.Append(char.ToUpper(c));
			}
			else
			{
				Uge.Append(char.ToLower(c));
			}
			goto IL_0060;
		case 1:
			break;
		case 2:
			{
				if (flag)
				{
					Uge.Append(c);
					qg1();
					result = true;
					break;
				}
				if (u2.e03(P_0, c))
				{
					if (!P_2)
					{
						Uge.Append(c);
						goto IL_0060;
					}
					goto default;
				}
				result = false;
				break;
			}
			IL_0060:
			qg1();
			result = true;
			break;
		}
		goto IL_01c3;
	}

	private bool DgI(char P_0)
	{
		if (dgr() <= 0 || Xg8() == XgU)
		{
			return false;
		}
		if (char.ToUpperInvariant(Xg8()) == char.ToUpperInvariant(P_0))
		{
			qg1();
			return true;
		}
		return false;
	}

	private bool bgb(char P_0)
	{
		if (dgr() <= 0 || Xg8() == XgU)
		{
			return false;
		}
		if (Xg8() == P_0)
		{
			qg1();
			return true;
		}
		return false;
	}

	private bool agD(char P_0)
	{
		if (dgr() <= 0 || Xg8() == XgU)
		{
			int num = 0;
			if (kad() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			return num switch
			{
				_ => false, 
			};
		}
		if (char.ToUpperInvariant(Xg8()) == char.ToUpperInvariant(P_0))
		{
			return false;
		}
		qg1();
		return true;
	}

	private bool VgG(char P_0)
	{
		if (dgr() > 0 && Xg8() != XgU)
		{
			if (Xg8() != P_0)
			{
				qg1();
				return true;
			}
			return false;
		}
		return false;
	}

	private bool Egq(string P_0, bool P_1)
	{
		int length = P_0.Length;
		int length2 = Uge.Length;
		int num = igz.Offset;
		if (IoQ)
		{
			int num2 = length;
			while (num2 > 0)
			{
				char c = P_0[--num2];
				tgg(num + (length - num2 + 1), c);
				if (igz.OkW() || igz.MkA() == XgU || char.ToUpperInvariant(igz.Tk1()) != char.ToUpperInvariant(c))
				{
					Uge.Remove(length2, Uge.Length - length2);
					igz.Offset = num;
					egW(num);
					return false;
				}
				if (!P_1)
				{
					c = igz.gkB();
				}
				Sgo(igz.Offset);
				Uge.Append(c);
				KgK(num2);
			}
		}
		else
		{
			int num3 = 0;
			while (num3 < length)
			{
				char c2 = P_0[num3++];
				tgg(num + num3 - 1, c2);
				if (igz.CkP() || igz.gkB() == XgU || char.ToUpperInvariant(igz.hkk()) != char.ToUpperInvariant(c2))
				{
					Uge.Remove(length2, Uge.Length - length2);
					igz.Offset = num;
					egW(num);
					return false;
				}
				if (!P_1)
				{
					c2 = igz.MkA();
				}
				Sgo(igz.Offset - 1);
				Uge.Append(c2);
				KgK(num3);
			}
		}
		return true;
	}

	private bool Agu(string P_0)
	{
		int length = P_0.Length;
		int length2 = Uge.Length;
		int num = igz.Offset;
		if (IoQ)
		{
			int num2 = length;
			while (num2 > 0)
			{
				tgg(num + (length - num2), P_0[num2 - 1]);
				if (igz.OkW() || igz.MkA() == XgU || igz.Tk1() != P_0[--num2])
				{
					Uge.Remove(length2, Uge.Length - length2);
					igz.Offset = num;
					egW(num);
					return false;
				}
				Sgo(igz.Offset);
				Uge.Append(igz.gkB());
				KgK(num2);
			}
		}
		else
		{
			int num3 = 0;
			while (num3 < length)
			{
				tgg(num + num3, P_0[num3]);
				if (igz.CkP() || igz.gkB() == XgU || igz.hkk() != P_0[num3++])
				{
					Uge.Remove(length2, Uge.Length - length2);
					igz.Offset = num;
					egW(num);
					return false;
				}
				Sgo(igz.Offset - 1);
				Uge.Append(igz.MkA());
				KgK(num3);
			}
		}
		return true;
	}

	private void KgK(int P_0 = 0)
	{
		if (zgB.Count == 0 || (!IoQ && igz.Offset > zgB[0].Offset) || (IoQ && igz.Offset < zgB[0].Offset))
		{
			zgB.Clear();
			zgB.Add(new fd5(this, P_0));
		}
		else if (igz.Offset == zgB[0].Offset)
		{
			zgB.Add(new fd5(this, P_0));
		}
	}

	private int TgR()
	{
		return bgE[--pg7];
	}

	private int Ngd()
	{
		return eoC[--uo6];
	}

	private void Ng9(int P_0)
	{
		if (pg7 >= bgE.Length)
		{
			Rgy();
		}
		bgE[pg7++] = P_0;
	}

	private void kg5(int P_0, int P_1)
	{
		if (pg7 + 1 >= bgE.Length)
		{
			Rgy();
		}
		bgE[pg7++] = P_0;
		bgE[pg7++] = P_1;
	}

	private void Ugc()
	{
		if (uo6 >= eoC.Length)
		{
			lgm();
		}
		eoC[uo6++] = ign;
	}

	private void HgH(int P_0)
	{
		if (uo6 + 1 >= eoC.Length)
		{
			lgm();
		}
		eoC[uo6++] = P_0;
		eoC[uo6++] = ign;
	}

	private void qgL(int P_0, int P_1)
	{
		if (uo6 + 2 >= eoC.Length)
		{
			lgm();
		}
		eoC[uo6++] = P_0;
		eoC[uo6++] = P_1;
		eoC[uo6++] = ign;
	}

	private void RgF(int P_0)
	{
		if (uo6 + 1 >= eoC.Length)
		{
			lgm();
		}
		eoC[uo6++] = P_0;
		eoC[uo6++] = -ign;
	}

	private void rgA(int P_0, int P_1)
	{
		if (uo6 + 2 >= eoC.Length)
		{
			lgm();
		}
		eoC[uo6++] = P_0;
		eoC[uo6++] = P_1;
		eoC[uo6++] = -ign;
	}

	private void ag3()
	{
		igz = null;
		rgt.Clear();
		Uge.Clear();
		cgk.Clear();
		pg7 = 0;
		uo6 = 0;
		if (bgE.Length > 20)
		{
			bgE = new int[20];
		}
		if (eoC.Length > 40)
		{
			eoC = new int[40];
		}
		Fg4.Clear();
		zgB.Clear();
		int num = 0;
		if (kad() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void Rgy()
	{
		int[] destinationArray = new int[2 * bgE.Length];
		Array.Copy(bgE, 0, destinationArray, 0, pg7);
		bgE = destinationArray;
	}

	private void lgm()
	{
		int[] destinationArray = new int[2 * eoC.Length];
		Array.Copy(eoC, 0, destinationArray, 0, uo6);
		eoC = destinationArray;
	}

	private void qgS(int P_0)
	{
		Lg0(ign + P_0);
	}

	private void qg1()
	{
		if (IoQ)
		{
			igz.Tk1();
		}
		else
		{
			igz.hkk();
		}
	}

	private char Xg8()
	{
		return IoQ ? igz.MkA() : igz.gkB();
	}

	private int dgr()
	{
		return IoQ ? (igz.Offset + igz.qkg()) : (igz.Length - igz.Offset);
	}

	private void rgv()
	{
		if (Uge.Length > igz.Offset)
		{
			Uge.Remove(igz.Offset, Uge.Length - igz.Offset);
		}
	}

	private void Pgp(int P_0)
	{
		while (rgt.Count > 0 && rgt[rgt.Count - 1] >= P_0)
		{
			rgt.RemoveAt(rgt.Count - 1);
		}
	}

	private void egW(int P_0)
	{
		while (Fg4.Count > 0 && Fg4[Fg4.Count - 1] >= P_0)
		{
			Fg4.RemoveAt(Fg4.Count - 1);
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public tk pgi(string P_0, bool P_1)
	{
		tk tk2 = new tk();
		tk2.lYk(P_0);
		tk2.MatchedText = string.Empty;
		tk2.vgM(string.Empty);
		igz = new a3(P_0);
		IoQ = Ugw;
		Lg0(0);
		fd5 fd = NgO();
		if (fd != null)
		{
			tk2.MatchedText = fd.gKb();
			tk2.pY4(fd.xK5());
		}
		List<int> list = new List<int>();
		if (tk2.lY7())
		{
			foreach (int item in Fg4)
			{
				if (!cgk.TryGetValue(item, out var value) || value != 0)
				{
					list.Add(item);
				}
			}
		}
		else if (zgB.Count > 0)
		{
			int num = int.MaxValue;
			int num2 = int.MaxValue;
			for (int num3 = zgB.Count - 1; num3 >= 0; num3--)
			{
				int num4 = 0;
				fd5 fd2 = zgB[num3];
				fd2.mKl(this);
				fd2.dKS(WgX(fd2.LKX(), ref num4));
				fd2.kKg(num4);
				num = Math.Min(num, fd2.bKm().Length - fd2.QKY());
				num2 = Math.Min(num2, fd2.LKX());
			}
			for (int num5 = zgB.Count - 1; num5 >= 0; num5--)
			{
				if (zgB[num5].bKm().Length - zgB[num5].QKY() > num)
				{
					zgB.RemoveAt(num5);
				}
			}
			zgB.Sort((fd5 d1, fd5 d2) => d1.bKm().Length.CompareTo(d2.bKm().Length));
			fd5 fd3 = zgB[0];
			if (fd3.Offset > 0)
			{
				tk2.pY4(_0020: true);
				tk2.oYw(_0020: true);
				tk2.MatchedText = fd3.gKb();
			}
			int[] array = fd3.OKL();
			foreach (int num7 in array)
			{
				if (!cgk.TryGetValue(num7, out var value2) || value2 != 0)
				{
					list.Add(num7);
				}
			}
			if (P_1)
			{
				int num8 = ((zgB.Count > 1) ? Math.Max(0, num2 - 1) : fd3.LKX());
				int num9 = 0;
				fd3.mKl(this);
				tk2.vgM(WgX(num8, ref num9));
				int length = tk2.MatchedText.Length;
				for (int num10 = 0; num10 < tk2.Ng6().Length; num10++)
				{
					if (tk2.Ng6()[num10] != XgU && (!cgk.TryGetValue(length + num10, out var value3) || value3 != 0))
					{
						list.Add(length + num10);
					}
				}
				if (tk2.Ng6().Length > 0 && !tk2.Ng6().Contains(XgU))
				{
					ag3();
					igz = new a3(P_0 + tk2.Ng6());
					Lg0(0);
					fd = NgO();
					if (fd != null && fd.xK5())
					{
						tk2.pY4(_0020: true);
						tk2.oYw(_0020: false);
					}
				}
			}
		}
		tk2.oYz(list.ToArray());
		ag3();
		return tk2;
	}

	internal static bool pab()
	{
		return la3 == null;
	}

	internal static C1 kad()
	{
		return la3;
	}
}
