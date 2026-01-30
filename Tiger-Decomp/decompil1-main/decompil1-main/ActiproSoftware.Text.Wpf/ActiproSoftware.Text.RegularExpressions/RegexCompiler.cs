using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using ActiproSoftware.Products.Text;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.RegularExpressions;

internal class RegexCompiler
{
	private int y87;

	private int G8M;

	private List<int> K8w;

	private Stack<int> D8H;

	private bool Y8P;

	private Dictionary<string, int> k8p;

	private List<string> e8b;

	internal static RegexCompiler Abc;

	internal RegexCode Compile(RegexNode rootNode, bool isRightToLeft)
	{
		Y8P = isRightToLeft;
		B8I(0);
		T8d(16, 0);
		D8m(rootNode);
		K8w[G8s() + 1] = G8M;
		D8h(29);
		int[] array = new int[K8w.Count];
		string[] array2 = new string[e8b.Count];
		K8w.CopyTo(array);
		e8b.CopyTo(array2);
		RegexCode result = new RegexCode(array, array2, Y8P, y87);
		if (K8w.Count > 0)
		{
			K8w.Clear();
		}
		if (D8H.Count > 0)
		{
			D8H.Clear();
		}
		if (k8p.Count > 0)
		{
			k8p.Clear();
		}
		if (e8b.Count > 0)
		{
			e8b.Clear();
		}
		y87 = 0;
		return result;
	}

	private void D8m(RegexNode P_0)
	{
		if (P_0.HasChildren)
		{
			int num3 = default(int);
			if (!Y8P || P_0.NodeType == 16)
			{
				while (true)
				{
					int num = 0;
					while (true)
					{
						bool flag = num < P_0.Children.Count;
						int num2 = 0;
						if (!bbf())
						{
							num2 = num3;
						}
						switch (num2)
						{
						default:
							if (flag)
							{
								goto IL_00ec;
							}
							return;
						case 1:
							break;
						}
						break;
						IL_00ec:
						t8c(P_0.NodeType | 0x40, P_0, num);
						D8m(P_0.Children[num]);
						t8c(P_0.NodeType | 0x80, P_0, num);
						num++;
					}
				}
			}
			for (int num4 = P_0.Children.Count - 1; num4 >= 0; num4--)
			{
				t8c(P_0.NodeType | 0x40, P_0, num4);
				D8m(P_0.Children[num4]);
				t8c(P_0.NodeType | 0x80, P_0, num4);
			}
		}
		else
		{
			t8c(P_0.NodeType, P_0, 0);
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void t8c(int P_0, RegexNode P_1, int P_2)
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
			switch (P_1.CaseSensitivity)
			{
			case CaseSensitivity.AutoCorrect:
				T8d(P_1.NodeType | 0x200, E8q(P_1.StringData));
				break;
			case CaseSensitivity.Insensitive:
				T8d(P_1.NodeType | 0x100, E8q(P_1.StringData));
				break;
			default:
				T8d(P_1.NodeType, E8q(P_1.StringData));
				break;
			}
			break;
		case 1:
		case 2:
			switch (P_1.CaseSensitivity)
			{
			case CaseSensitivity.AutoCorrect:
				T8d(P_1.NodeType | 0x200, P_1.StringData[0]);
				break;
			case CaseSensitivity.Insensitive:
				T8d(P_1.NodeType | 0x100, P_1.StringData[0]);
				break;
			default:
				T8d(P_1.NodeType, P_1.StringData[0]);
				break;
			}
			break;
		case 3:
			T8d(P_1.NodeType, E8q(P_1.StringData));
			break;
		case 91:
			if (P_1.Maximum < int.MaxValue || P_1.Minimum > 1)
			{
				if (P_1.Minimum == 0)
				{
					T8d(18, 0);
				}
				else
				{
					T8d(19, 1 - P_1.Minimum);
				}
			}
			else
			{
				D8h((P_1.Minimum == 0) ? 21 : 22);
			}
			if (P_1.Minimum == 0)
			{
				B8I(G8M);
				T8d(28, 0);
			}
			B8I(G8M);
			break;
		case 155:
		{
			int g8M = G8M;
			if (P_1.Maximum < int.MaxValue || P_1.Minimum > 1)
			{
				N8L(20, G8s(), (P_1.Maximum == int.MaxValue) ? int.MaxValue : (P_1.Maximum - P_1.Minimum));
			}
			else
			{
				T8d(17, G8s());
			}
			if (P_1.Minimum == 0)
			{
				K8w[G8s() + 1] = g8M;
			}
			break;
		}
		case 80:
			if (P_2 < P_1.Children.Count - 1)
			{
				B8I(G8M);
				T8d(16, 0);
			}
			break;
		case 144:
			if (P_2 < P_1.Children.Count - 1)
			{
				int num = G8s();
				B8I(G8M);
				T8d(28, 0);
				K8w[num + 1] = G8M;
			}
			else
			{
				for (int i = 0; i < P_2; i++)
				{
					K8w[G8s() + 1] = G8M;
				}
			}
			break;
		case 82:
			D8h(22);
			P_1.Minimum = y87++;
			break;
		case 146:
			T8d(23, P_1.Minimum);
			break;
		case 85:
			D8h(25);
			D8h(22);
			break;
		case 149:
			D8h(24);
			D8h(27);
			break;
		case 87:
			D8h(25);
			D8h(31);
			D8h(22);
			Y8P = true;
			break;
		case 151:
			D8h(24);
			D8h(30);
			D8h(27);
			Y8P = false;
			break;
		case 86:
			D8h(25);
			B8I(G8M);
			T8d(16, 0);
			break;
		case 150:
			D8h(26);
			K8w[G8s() + 1] = G8M;
			D8h(27);
			break;
		case 88:
			D8h(25);
			B8I(G8M);
			D8h(31);
			T8d(16, 0);
			Y8P = true;
			break;
		case 152:
			D8h(26);
			K8w[G8s() + 2] = G8M;
			D8h(30);
			D8h(27);
			Y8P = false;
			break;
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
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
			D8h(P_1.NodeType);
			break;
		default:
			throw new InvalidRegexPatternException(string.Format(CultureInfo.CurrentCulture, SR.GetString(SRName.ExInvalidRegexNodeType), new object[1] { P_0 }));
		}
	}

	private void D8h(int P_0)
	{
		K8w.Add(P_0);
		G8M = K8w.Count;
	}

	private void T8d(int P_0, int P_1)
	{
		K8w.Add(P_0);
		K8w.Add(P_1);
		G8M = K8w.Count;
	}

	private void N8L(int P_0, int P_1, int P_2)
	{
		K8w.Add(P_0);
		K8w.Add(P_1);
		K8w.Add(P_2);
		G8M = K8w.Count;
	}

	private int E8q(string P_0)
	{
		if (P_0 == null)
		{
			P_0 = string.Empty;
		}
		int result;
		if (k8p.ContainsKey(P_0))
		{
			result = k8p[P_0];
		}
		else
		{
			int count = e8b.Count;
			e8b.Add(P_0);
			k8p[P_0] = count;
			result = count;
			int num = 0;
			if (fbM() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		return result;
	}

	private int G8s()
	{
		return D8H.Pop();
	}

	private void B8I(int P_0)
	{
		D8H.Push(P_0);
	}

	public RegexCompiler()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		K8w = new List<int>();
		D8H = new Stack<int>();
		k8p = new Dictionary<string, int>();
		e8b = new List<string>();
		base._002Ector();
	}

	internal static bool bbf()
	{
		return Abc == null;
	}

	internal static RegexCompiler fbM()
	{
		return Abc;
	}
}
