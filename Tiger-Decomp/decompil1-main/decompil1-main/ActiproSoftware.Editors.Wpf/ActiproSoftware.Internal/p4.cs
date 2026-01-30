using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using ActiproSoftware.Products.Editors;

namespace ActiproSoftware.Internal;

internal class p4
{
	private int uo0;

	private int hoY;

	private List<int> Wog;

	private Stack<int> Aoo;

	private bool zoO;

	private Dictionary<string, int> moT;

	private List<string> AoI;

	private static p4 rav;

	internal C1 ios(XA P_0, char P_1, bool P_2)
	{
		zoO = P_2;
		Tox(0);
		Coa(16, 0);
		int num = 1;
		if (Ta4() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				eoj(P_0);
				Wog[HoX() + 1] = hoY;
				num = 0;
				if (!Sap())
				{
					num = 0;
				}
				continue;
			}
			Fo2(29);
			int[] array = new int[Wog.Count];
			string[] array2 = new string[AoI.Count];
			Wog.CopyTo(array);
			AoI.CopyTo(array2);
			C1 result = new C1(array, array2, zoO, P_1);
			if (Wog.Count > 0)
			{
				Wog.Clear();
			}
			if (Aoo.Count > 0)
			{
				Aoo.Clear();
			}
			if (moT.Count > 0)
			{
				moT.Clear();
			}
			if (AoI.Count > 0)
			{
				AoI.Clear();
			}
			uo0 = 0;
			return result;
		}
	}

	private void eoj(XA P_0)
	{
		if (!P_0.poE())
		{
			woP(P_0.poh, P_0, 0);
		}
		else if (zoO && P_0.poh != 16)
		{
			for (int num = P_0.Poe().Count - 1; num >= 0; num--)
			{
				woP(P_0.poh | 0x40, P_0, num);
				eoj(P_0.Poe()[num]);
				woP(P_0.poh | 0x80, P_0, num);
			}
		}
		else
		{
			for (int i = 0; i < P_0.Poe().Count; i++)
			{
				woP(P_0.poh | 0x40, P_0, i);
				eoj(P_0.Poe()[i]);
				woP(P_0.poh | 0x80, P_0, i);
			}
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void woP(int P_0, XA P_1, int P_2)
	{
		switch (P_0)
		{
		case 20:
		case 81:
		case 83:
		case 145:
		case 147:
			break;
		case 4:
			switch (P_1.Ho4)
			{
			case fw.a05:
				Coa(P_1.poh | 0x200, Xol(P_1.qoN));
				break;
			case (fw)1:
				Coa(P_1.poh | 0x100, Xol(P_1.qoN));
				break;
			default:
				Coa(P_1.poh, Xol(P_1.qoN));
				break;
			}
			break;
		case 1:
		case 2:
			switch (P_1.Ho4)
			{
			case fw.a05:
				Coa(P_1.poh | 0x200, P_1.qoN[0]);
				break;
			case (fw)1:
				Coa(P_1.poh | 0x100, P_1.qoN[0]);
				break;
			default:
				Coa(P_1.poh, P_1.qoN[0]);
				break;
			}
			break;
		case 3:
			switch (P_1.Ho4)
			{
			case fw.a05:
				Sof(P_1.poh | 0x200, Xol(P_1.qoN), Xol(P_1.Qow));
				break;
			case (fw)1:
				Sof(P_1.poh | 0x100, Xol(P_1.qoN), Xol(P_1.Qow));
				break;
			default:
				Sof(P_1.poh, Xol(P_1.qoN), Xol(P_1.Qow));
				break;
			}
			break;
		case 91:
			if (P_1.Maximum < int.MaxValue || P_1.Minimum > 1)
			{
				if (P_1.Minimum == 0)
				{
					Coa(18, 0);
				}
				else
				{
					Coa(19, 1 - P_1.Minimum);
				}
			}
			else
			{
				Fo2((P_1.Minimum == 0) ? 21 : 22);
			}
			if (P_1.Minimum == 0)
			{
				Tox(hoY);
				Coa(28, 0);
			}
			Tox(hoY);
			break;
		case 155:
		{
			int value = hoY;
			if (P_1.Maximum < int.MaxValue || P_1.Minimum > 1)
			{
				Sof(20, HoX(), (P_1.Maximum == int.MaxValue) ? int.MaxValue : (P_1.Maximum - P_1.Minimum));
			}
			else
			{
				Coa(17, HoX());
			}
			if (P_1.Minimum == 0)
			{
				Wog[HoX() + 1] = value;
			}
			break;
		}
		case 80:
			if (P_2 < P_1.Poe().Count - 1)
			{
				Tox(hoY);
				Coa(16, 0);
			}
			Fo2(48);
			break;
		case 144:
			Fo2(49);
			if (P_2 < P_1.Poe().Count - 1)
			{
				int num = HoX();
				Tox(hoY);
				Coa(28, 0);
				Wog[num + 1] = hoY;
			}
			else
			{
				for (int i = 0; i < P_2; i++)
				{
					Wog[HoX() + 1] = hoY;
				}
			}
			break;
		case 82:
			Fo2(22);
			P_1.Minimum = uo0++;
			break;
		case 146:
			Coa(23, P_1.Minimum);
			break;
		case 32:
		case 33:
		case 34:
		case 35:
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
			Fo2(P_1.poh);
			break;
		default:
			throw new oG(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExInvalidRegexNodeType), new object[1] { P_0 }));
		}
	}

	private void Fo2(int P_0)
	{
		Wog.Add(P_0);
		hoY = Wog.Count;
	}

	private void Coa(int P_0, int P_1)
	{
		Wog.Add(P_0);
		Wog.Add(P_1);
		hoY = Wog.Count;
	}

	private void Sof(int P_0, int P_1, int P_2)
	{
		Wog.Add(P_0);
		Wog.Add(P_1);
		Wog.Add(P_2);
		hoY = Wog.Count;
	}

	private int Xol(string P_0)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					break;
				default:
				{
					if (flag)
					{
						P_0 = string.Empty;
					}
					if (moT.ContainsKey(P_0))
					{
						return moT[P_0];
					}
					int count = AoI.Count;
					AoI.Add(P_0);
					moT[P_0] = count;
					return count;
				}
				}
				flag = P_0 == null;
				num2 = 0;
			}
			while (Sap());
		}
	}

	private int HoX()
	{
		return Aoo.Pop();
	}

	private void Tox(int P_0)
	{
		Aoo.Push(P_0);
	}

	public p4()
	{
		awj.QuEwGz();
		Wog = new List<int>();
		Aoo = new Stack<int>();
		moT = new Dictionary<string, int>();
		AoI = new List<string>();
		base._002Ector();
	}

	internal static bool Sap()
	{
		return rav == null;
	}

	internal static p4 Ta4()
	{
		return rav;
	}
}
