using System;
using System.Collections.Generic;
using System.Linq;
using bQeLQJ9JVIVGlOu9BJva;
using ECOEgqlSad8NUJZ2Dr9n;
using ROhuQx9FcGTLTqPCaJ0j;
using TuAMtrl1Nd3XoZQQUXf0;

namespace nBH5g8fwnykfadCTGsNh;

internal sealed class B6hQCpfw9A1xbI4rO3mY
{
	private long RhefwvAHYoy;

	private long XftfwBZfhIN;

	private long i8VfwaYjXOs;

	private long wMxfwiLWDXq;

	private long a11fwlmoLdq;

	private long IPofw43AtRH;

	private readonly HashSet<long> LP1fwDXeRWn;

	private readonly HashSet<long> Dubfwbt4ybC;

	internal static B6hQCpfw9A1xbI4rO3mY LnMPTYbBZ8JI4L3YfvrK;

	public void FGsfwGXALHv(KHxL9R9JZMZ1sv2HFY9P P_0, long P_1, int P_2)
	{
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (P_0.Price == RhefwvAHYoy)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
					{
						num2 = 5;
					}
					break;
				}
				if (LFHJghbBrmjhRjTBIy39(P_0) == i8VfwaYjXOs)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				LP1fwDXeRWn.Add(RhefwvAHYoy);
				goto IL_014c;
			default:
				IPofw43AtRH += P_0.Size;
				num2 = 4;
				break;
			case 2:
				return;
			case 1:
			case 4:
				if (XftfwBZfhIN >= P_1 && a11fwlmoLdq >= XftfwBZfhIN * P_2 && !LP1fwDXeRWn.Contains(RhefwvAHYoy))
				{
					num2 = 3;
					break;
				}
				goto IL_014c;
			case 5:
				{
					a11fwlmoLdq += P_0.Size;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
					{
						num2 = 1;
					}
					break;
				}
				IL_014c:
				if (wMxfwiLWDXq < P_1)
				{
					return;
				}
				if (IPofw43AtRH < wMxfwiLWDXq * P_2)
				{
					num2 = 2;
					break;
				}
				if (!Dubfwbt4ybC.Contains(i8VfwaYjXOs))
				{
					Dubfwbt4ybC.Add(i8VfwaYjXOs);
				}
				return;
			}
		}
	}

	public void xtEfwYfBNNZ(daEwNq9FXerRxid1xGMa P_0)
	{
		int num = 7;
		List<long>.Enumerator enumerator = default(List<long>.Enumerator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					XftfwBZfhIN = P_0.BidSize;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					try
					{
						while (enumerator.MoveNext())
						{
							while (true)
							{
								IL_0165:
								long current2 = enumerator.Current;
								if (current2 > P_0.BidPrice)
								{
									int num4 = 1;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
									{
										num4 = 1;
									}
									while (true)
									{
										switch (num4)
										{
										case 1:
											LP1fwDXeRWn.Remove(current2);
											num4 = 0;
											if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
											{
												num4 = 0;
											}
											continue;
										case 2:
											goto IL_0165;
										}
										break;
									}
								}
								else if (!P_0.BidQuotes.ContainsKey(current2))
								{
									LP1fwDXeRWn.Remove(current2);
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					goto IL_0040;
				case 5:
					if (SX0hbqbBhyr8W1h7ECPx(LP1fwDXeRWn) > 0)
					{
						num2 = 8;
						continue;
					}
					goto IL_0040;
				case 3:
					if (P_0.AskPrice != i8VfwaYjXOs)
					{
						i8VfwaYjXOs = P_0.AskPrice;
						wMxfwiLWDXq = G1kUt0bBmRFcmjBxZ08e(P_0);
						IPofw43AtRH = 0L;
						goto case 5;
					}
					wMxfwiLWDXq = Math.Max(wMxfwiLWDXq, P_0.AskSize);
					num2 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					enumerator = LP1fwDXeRWn.ToList().GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					if (VX43P8bBKZ08y1VCj3FF(P_0) == RhefwvAHYoy)
					{
						XftfwBZfhIN = Math.Max(XftfwBZfhIN, P_0.BidSize);
						goto case 3;
					}
					num2 = 6;
					continue;
				case 6:
					RhefwvAHYoy = P_0.BidPrice;
					num2 = 4;
					continue;
				case 2:
					{
						try
						{
							while (enumerator.MoveNext())
							{
								while (true)
								{
									IL_0394:
									long current = enumerator.Current;
									if (current < s5n4J4bBwLh08hP2rT6C(P_0))
									{
										Dubfwbt4ybC.Remove(current);
									}
									else
									{
										if (P_0.AskQuotes.ContainsKey(current))
										{
											break;
										}
										int num3 = 0;
										if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
										{
											num3 = 0;
										}
										while (true)
										{
											switch (num3)
											{
											case 1:
												break;
											default:
												Dubfwbt4ybC.Remove(current);
												num3 = 1;
												if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
												{
													num3 = 1;
												}
												continue;
											case 2:
												goto IL_0394;
											}
											break;
										}
									}
									break;
								}
							}
							return;
						}
						finally
						{
							((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
					}
					IL_0040:
					if (Dubfwbt4ybC.Count > 0)
					{
						enumerator = Dubfwbt4ybC.ToList().GetEnumerator();
						num2 = 2;
						continue;
					}
					return;
				}
				break;
			}
			a11fwlmoLdq = 0L;
			num = 3;
		}
	}

	public void Clear()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Dubfwbt4ybC.Clear();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 2:
				XftfwBZfhIN = 0L;
				i8VfwaYjXOs = 0L;
				wMxfwiLWDXq = 0L;
				a11fwlmoLdq = 0L;
				IPofw43AtRH = 0L;
				LP1fwDXeRWn.Clear();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				RhefwvAHYoy = 0L;
				num2 = 2;
				break;
			}
		}
	}

	public bool wydfwovWOMu(long P_0)
	{
		if (!LP1fwDXeRWn.Contains(P_0))
		{
			return Dubfwbt4ybC.Contains(P_0);
		}
		return true;
	}

	public B6hQCpfw9A1xbI4rO3mY()
	{
		xcX6rdbB7CYvHCnBZ4UK();
		LP1fwDXeRWn = new HashSet<long>();
		Dubfwbt4ybC = new HashSet<long>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static B6hQCpfw9A1xbI4rO3mY()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static long LFHJghbBrmjhRjTBIy39(object P_0)
	{
		return ((KHxL9R9JZMZ1sv2HFY9P)P_0).Price;
	}

	internal static bool PJnWA2bBVwxhZufCrXUp()
	{
		return LnMPTYbBZ8JI4L3YfvrK == null;
	}

	internal static B6hQCpfw9A1xbI4rO3mY sACd9lbBCC43Z0g8diQq()
	{
		return LnMPTYbBZ8JI4L3YfvrK;
	}

	internal static long VX43P8bBKZ08y1VCj3FF(object P_0)
	{
		return ((daEwNq9FXerRxid1xGMa)P_0).BidPrice;
	}

	internal static long G1kUt0bBmRFcmjBxZ08e(object P_0)
	{
		return ((daEwNq9FXerRxid1xGMa)P_0).AskSize;
	}

	internal static int SX0hbqbBhyr8W1h7ECPx(object P_0)
	{
		return ((HashSet<long>)P_0).Count;
	}

	internal static long s5n4J4bBwLh08hP2rT6C(object P_0)
	{
		return ((daEwNq9FXerRxid1xGMa)P_0).AskPrice;
	}

	internal static void xcX6rdbB7CYvHCnBZ4UK()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
