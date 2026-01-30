using System;
using System.IO;
using b1blkEHqcM0qO0TqYSj5;
using ECOEgqlSad8NUJZ2Dr9n;
using iHHYTdHq8PBW2LiWis4u;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Utilities;
using TuAMtrl1Nd3XoZQQUXf0;

namespace GJKxjiHqE75NHHhTO9AC;

internal class Yk3Od1Hqjai5LUixcs3l
{
	private readonly IBasicAgreement cpkHqWmCxE0;

	private readonly IDerivationFunction fTWHqtjcwB7;

	private readonly IMac WKtHqUNjPDP;

	private readonly BufferedBlockCipher yHYHqT2ZwJq;

	private readonly byte[] LJOHqyMWNW8;

	private bool OIYHqZA2ojL;

	private ICipherParameters NaNHqVSdWDY;

	private ICipherParameters JgeHqCMrDyk;

	private IesParameters NoVHqr6mnik;

	private byte[] ze3HqKpGXOg;

	private ECKeyPairGenerator O01Hqm387GS;

	private Hr4mPhHqX29rnbPnS5kr hNiHqhCAkUg;

	private byte[] fKsHqwhs0ib;

	internal static Yk3Od1Hqjai5LUixcs3l GsYtvpDMoyUgOfH0hqv8;

	public Yk3Od1Hqjai5LUixcs3l(IBasicAgreement P_0, IDerivationFunction P_1, IMac P_2)
	{
		S07JgDDMaOAhiTbkEC17();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				yHYHqT2ZwJq = null;
				return;
			case 1:
				LJOHqyMWNW8 = new byte[P_2.GetMacSize()];
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
				{
					num = 1;
				}
				continue;
			}
			cpkHqWmCxE0 = P_0;
			fTWHqtjcwB7 = P_1;
			WKtHqUNjPDP = P_2;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
			{
				num = 0;
			}
		}
	}

	public Yk3Od1Hqjai5LUixcs3l(IBasicAgreement P_0, IDerivationFunction P_1, IMac P_2, BufferedBlockCipher P_3)
	{
		S07JgDDMaOAhiTbkEC17();
		base._002Ector();
		cpkHqWmCxE0 = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				WKtHqUNjPDP = P_2;
				LJOHqyMWNW8 = new byte[P_2.GetMacSize()];
				int num2 = 2;
				num = num2;
				continue;
			}
			case 2:
				yHYHqT2ZwJq = P_3;
				return;
			}
			fTWHqtjcwB7 = P_1;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
			{
				num = 1;
			}
		}
	}

	public void jt5HqQHQQLh(bool P_0, ICipherParameters P_1, ICipherParameters P_2, ICipherParameters P_3)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				NaNHqVSdWDY = P_1;
				JgeHqCMrDyk = P_2;
				ze3HqKpGXOg = new byte[0];
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea != 0)
				{
					num2 = 0;
				}
				break;
			default:
				JZCHqRpiaTy(P_3);
				return;
			case 2:
				OIYHqZA2ojL = P_0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void js7Hqdd1Nle(AsymmetricKeyParameter P_0, IesParameters P_1, ECKeyPairGenerator P_2)
	{
		OIYHqZA2ojL = true;
		JgeHqCMrDyk = P_0;
		O01Hqm387GS = P_2;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		JZCHqRpiaTy(P_1);
	}

	public void lclHqgB3xRh(AsymmetricKeyParameter P_0, IesParameters P_1, Hr4mPhHqX29rnbPnS5kr P_2)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				OIYHqZA2ojL = false;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				NaNHqVSdWDY = P_0;
				hNiHqhCAkUg = P_2;
				JZCHqRpiaTy(P_1);
				return;
			}
		}
	}

	private void JZCHqRpiaTy(ICipherParameters P_0)
	{
		fKsHqwhs0ib = null;
		NoVHqr6mnik = (IesParameters)P_0;
	}

	public BufferedBlockCipher wDkHq60DE2W()
	{
		return yHYHqT2ZwJq;
	}

	private byte[] iULHqMKWkeE(byte[] P_0, int P_1, int P_2)
	{
		int num = 11;
		byte[] array3 = default(byte[]);
		int num4 = default(int);
		byte[] array4 = default(byte[]);
		byte[] array7 = default(byte[]);
		byte[] array8 = default(byte[]);
		byte[] array2 = default(byte[]);
		byte[] array5 = default(byte[]);
		byte[] array = default(byte[]);
		int num3 = default(int);
		byte[] array6 = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					array3 = new byte[NoVHqr6mnik.MacKeySize / 8];
					num2 = 13;
					continue;
				case 1:
					num4 += p2uwP1DMD7V6ts5WWxgE(yHYHqT2ZwJq, array4, num4);
					goto IL_00e4;
				case 16:
					aL0fiKDMkkVQ6s6yVP7D(WKtHqUNjPDP, array7, 0);
					array8 = new byte[ze3HqKpGXOg.Length + num4 + array7.Length];
					E2dJa7DMiMs6lMOO5GEi(ze3HqKpGXOg, 0, array8, 0, ze3HqKpGXOg.Length);
					num2 = 21;
					continue;
				case 17:
					PsEu29DMltNmnXRtFDyS(yHYHqT2ZwJq, true, new ParametersWithIV(new KeyParameter(array2), fKsHqwhs0ib));
					goto IL_0233;
				case 7:
					if (ze3HqKpGXOg.Length != 0)
					{
						WKtHqUNjPDP.BlockUpdate(array5, 0, array5.Length);
						num2 = 16;
						continue;
					}
					goto case 16;
				case 11:
					if (yHYHqT2ZwJq == null)
					{
						num2 = 10;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						array2 = new byte[((IesWithCipherParameters)NoVHqr6mnik).CipherKeySize / 8];
						array3 = new byte[NoVHqr6mnik.MacKeySize / 8];
						array = new byte[array2.Length + array3.Length];
						fTWHqtjcwB7.GenerateBytes(array, 0, array.Length);
						num2 = 19;
					}
					continue;
				case 18:
					Array.Copy(array7, 0, array8, ze3HqKpGXOg.Length + num4, array7.Length);
					num2 = 12;
					continue;
				case 13:
					array = new byte[array2.Length + array3.Length];
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
					{
						num2 = 8;
					}
					continue;
				case 15:
					if (num3 == P_2)
					{
						num4 = P_2;
						goto IL_00e4;
					}
					goto case 14;
				case 10:
					array2 = new byte[P_2];
					num2 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
					{
						num2 = 9;
					}
					continue;
				case 6:
					num3++;
					num2 = 15;
					continue;
				default:
					if (array6 != null)
					{
						wLmrA0DMNZf6LLqB3KSB(WKtHqUNjPDP, array6, 0, array6.Length);
						num2 = 7;
						continue;
					}
					goto case 7;
				case 14:
					array4[num3] = (byte)(P_0[P_1 + num3] ^ array2[num3]);
					num2 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a != 0)
					{
						num2 = 6;
					}
					continue;
				case 12:
					return array8;
				case 8:
					fTWHqtjcwB7.GenerateBytes(array, 0, array.Length);
					if (ze3HqKpGXOg.Length != 0)
					{
						num = 20;
						break;
					}
					Array.Copy(array, 0, array2, 0, array2.Length);
					num = 5;
					break;
				case 20:
					Array.Copy(array, 0, array3, 0, array3.Length);
					Array.Copy(array, array3.Length, array2, 0, array2.Length);
					goto IL_03a9;
				case 21:
					Array.Copy(array4, 0, array8, ze3HqKpGXOg.Length, num4);
					num2 = 18;
					continue;
				case 3:
					array5 = null;
					num2 = 2;
					continue;
				case 5:
					E2dJa7DMiMs6lMOO5GEi(array, P_2, array3, 0, array3.Length);
					goto IL_03a9;
				case 4:
					num4 = xdco13DM4KmZYbKVnuV6(yHYHqT2ZwJq, P_0, P_1, P_2, array4, 0);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					if (ze3HqKpGXOg.Length != 0)
					{
						array5 = zb9HqIFiZl6(array6);
					}
					array7 = new byte[WKtHqUNjPDP.GetMacSize()];
					WKtHqUNjPDP.Init(new KeyParameter(array3));
					WKtHqUNjPDP.BlockUpdate(array4, 0, array4.Length);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
					{
						Array.Copy(array, 0, array2, 0, array2.Length);
						Array.Copy(array, array2.Length, array3, 0, array3.Length);
						if (fKsHqwhs0ib == null)
						{
							PsEu29DMltNmnXRtFDyS(yHYHqT2ZwJq, true, new KeyParameter(array2));
							goto IL_0233;
						}
						num2 = 17;
						continue;
					}
					IL_0233:
					array4 = new byte[yHYHqT2ZwJq.GetOutputSize(P_2)];
					num = 4;
					break;
					IL_03a9:
					array4 = new byte[P_2];
					num3 = 0;
					goto case 15;
					IL_00e4:
					array6 = (byte[])oqZM5xDMbsmN0EqdSN1U(NoVHqr6mnik);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
		}
	}

	private byte[] D88HqOQ0NSQ(byte[] P_0, int P_1, int P_2)
	{
		int num = 0;
		if (P_2 < ze3HqKpGXOg.Length + CJwmJ4DM1ocuHLKihwVW(WKtHqUNjPDP))
		{
			throw new InvalidCipherTextException(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x31595CD1));
		}
		if (yHYHqT2ZwJq != null)
		{
			goto IL_0172;
		}
		byte[] array = new byte[P_2 - ze3HqKpGXOg.Length - WKtHqUNjPDP.GetMacSize()];
		int num2 = 7;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
		{
			num2 = 10;
		}
		goto IL_0009;
		IL_0172:
		array = new byte[MOn2bQDMSMBSeiQdCtG7((IesWithCipherParameters)NoVHqr6mnik) / 8];
		num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
		{
			num2 = 1;
		}
		goto IL_0009;
		IL_0009:
		byte[] array3 = default(byte[]);
		byte[] array2 = default(byte[]);
		ICipherParameters cipherParameters = default(ICipherParameters);
		byte[] encodingV = default(byte[]);
		byte[] array5 = default(byte[]);
		byte[] array4 = default(byte[]);
		int num4 = default(int);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 10:
				array3 = new byte[NoVHqr6mnik.MacKeySize / 8];
				array2 = new byte[array.Length + array3.Length];
				AI4TcoDM5Uc7Ag6CQMx7(fTWHqtjcwB7, array2, 0, array2.Length);
				if (ze3HqKpGXOg.Length == 0)
				{
					goto case 17;
				}
				E2dJa7DMiMs6lMOO5GEi(array2, 0, array3, 0, array3.Length);
				Array.Copy(array2, array3.Length, array, 0, array.Length);
				goto IL_037b;
			case 1:
				array3 = new byte[NoVHqr6mnik.MacKeySize / 8];
				array2 = new byte[array.Length + array3.Length];
				num3 = 15;
				goto IL_0005;
			case 2:
				PsEu29DMltNmnXRtFDyS(yHYHqT2ZwJq, false, cipherParameters);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
				{
					num2 = 0;
				}
				continue;
			case 8:
			case 18:
				encodingV = NoVHqr6mnik.GetEncodingV();
				num2 = 16;
				continue;
			case 3:
				break;
			case 15:
				AI4TcoDM5Uc7Ag6CQMx7(fTWHqtjcwB7, array2, 0, array2.Length);
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
				{
					num2 = 12;
				}
				continue;
			case 16:
				array5 = null;
				if (ze3HqKpGXOg.Length == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 5;
			case 17:
				Array.Copy(array2, 0, array, 0, array.Length);
				num2 = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
				{
					num2 = 7;
				}
				continue;
			case 6:
			case 9:
			{
				int num5 = P_1 + P_2;
				byte[] array6 = Arrays.CopyOfRange(P_0, num5 - WKtHqUNjPDP.GetMacSize(), num5);
				byte[] array7 = new byte[array6.Length];
				hjSk9cDMxiNnCGJ50gej(WKtHqUNjPDP, new KeyParameter(array3));
				WKtHqUNjPDP.BlockUpdate(P_0, P_1 + ze3HqKpGXOg.Length, P_2 - ze3HqKpGXOg.Length - array7.Length);
				if (encodingV != null)
				{
					WKtHqUNjPDP.BlockUpdate(encodingV, 0, encodingV.Length);
				}
				if (ze3HqKpGXOg.Length != 0)
				{
					WKtHqUNjPDP.BlockUpdate(array5, 0, array5.Length);
				}
				aL0fiKDMkkVQ6s6yVP7D(WKtHqUNjPDP, array7, 0);
				if (!Arrays.ConstantTimeAreEqual(array6, array7))
				{
					throw new InvalidCipherTextException(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28C965BE ^ 0x28CA8812));
				}
				num2 = 13;
				continue;
			}
			case 13:
				if (yHYHqT2ZwJq == null)
				{
					return array4;
				}
				num += yHYHqT2ZwJq.DoFinal(array4, num);
				num2 = 14;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
				{
					num2 = 6;
				}
				continue;
			case 14:
				return (byte[])z0uxQLDMLwtND2nEO0vk(array4, 0, num);
			case 5:
				array5 = zb9HqIFiZl6(encodingV);
				num2 = 9;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
				{
					num2 = 8;
				}
				continue;
			case 4:
				if (num4 != array.Length)
				{
					array4[num4] = (byte)(P_0[P_1 + ze3HqKpGXOg.Length + num4] ^ array[num4]);
					num4++;
					num3 = 4;
					goto IL_0005;
				}
				num2 = 8;
				continue;
			case 11:
				cipherParameters = new ParametersWithIV(cipherParameters, fKsHqwhs0ib);
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
				{
					num2 = 0;
				}
				continue;
			case 12:
				Array.Copy(array2, 0, array, 0, array.Length);
				Array.Copy(array2, array.Length, array3, 0, array3.Length);
				cipherParameters = new KeyParameter(array);
				if (fKsHqwhs0ib != null)
				{
					num2 = 11;
					continue;
				}
				goto case 2;
			default:
				array4 = new byte[yHYHqT2ZwJq.GetOutputSize(P_2 - ze3HqKpGXOg.Length - WKtHqUNjPDP.GetMacSize())];
				num = xdco13DM4KmZYbKVnuV6(yHYHqT2ZwJq, P_0, P_1 + ze3HqKpGXOg.Length, P_2 - ze3HqKpGXOg.Length - WKtHqUNjPDP.GetMacSize(), array4, 0);
				num2 = 18;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
				{
					num2 = 8;
				}
				continue;
			case 7:
				{
					E2dJa7DMiMs6lMOO5GEi(array2, array.Length, array3, 0, array3.Length);
					goto IL_037b;
				}
				IL_037b:
				array4 = new byte[array.Length];
				num4 = 0;
				goto case 4;
				IL_0005:
				num2 = num3;
				continue;
			}
			break;
		}
		goto IL_0172;
	}

	public byte[] XqnHqq8qY24(byte[] P_0, int P_1, int P_2)
	{
		int num;
		if (OIYHqZA2ojL)
		{
			if (O01Hqm387GS != null)
			{
				num = 4;
				goto IL_0009;
			}
			goto IL_0090;
		}
		goto IL_0128;
		IL_0090:
		tvH2CbDMX2i9DBxNnZnP(cpkHqWmCxE0, NaNHqVSdWDY);
		BigInteger n = cpkHqWmCxE0.CalculateAgreement(JgeHqCMrDyk);
		num = 6;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
		{
			num = 3;
		}
		goto IL_0009;
		IL_0128:
		ArraySegment<byte> arraySegment = default(ArraySegment<byte>);
		if (hNiHqhCAkUg != null)
		{
			arraySegment = new ArraySegment<byte>(P_0, P_1, P_2);
			num = 2;
			goto IL_0009;
		}
		goto IL_0090;
		IL_0009:
		byte[] array = default(byte[]);
		byte[] result = default(byte[]);
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				byte[] array2 = Arrays.Concatenate(ze3HqKpGXOg, array);
				FxDsZxDMca4C8U4Diaqm(array, 0);
				array = array2;
				goto IL_0235;
			}
			case 6:
				array = BigIntegers.AsUnsignedByteArray(cpkHqWmCxE0.GetFieldSize(), n);
				if (ze3HqKpGXOg.Length != 0)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
					{
						num = 1;
					}
					continue;
				}
				goto IL_0235;
			case 4:
			{
				AsymmetricCipherKeyPair asymmetricCipherKeyPair = (AsymmetricCipherKeyPair)rUQBEYDMebjPoxYLbuxr(O01Hqm387GS);
				NaNHqVSdWDY = asymmetricCipherKeyPair.Private;
				ze3HqKpGXOg = (byte[])GMGmviDMsAqWFo9962iQ(((ECPublicKeyParameters)asymmetricCipherKeyPair.Public).Q);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
				{
					num = 0;
				}
				continue;
			}
			case 3:
				goto IL_0128;
			case 5:
				try
				{
					KdfParameters parameters = new KdfParameters(array, NoVHqr6mnik.GetDerivationV());
					int num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							fTWHqtjcwB7.Init(parameters);
							result = (OIYHqZA2ojL ? iULHqMKWkeE(P_0, P_1, P_2) : D88HqOQ0NSQ(P_0, P_1, P_2));
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
							{
								num2 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					Arrays.Fill(array, 0);
				}
				return result;
			case 2:
				{
					try
					{
						JgeHqCMrDyk = hNiHqhCAkUg.Qhel9NaghP8(arraySegment, out ze3HqKpGXOg);
					}
					catch (IOException ex)
					{
						throw new InvalidCipherTextException(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24085900 ^ 0x240BB4C6) + ex.Message, ex);
					}
					catch (ArgumentException ex2)
					{
						throw new InvalidCipherTextException(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6E2DFBED ^ 0x6E2E162B) + ex2.Message, ex2);
					}
					break;
				}
				IL_0235:
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
				{
					num = 2;
				}
				continue;
			}
			break;
		}
		goto IL_0090;
	}

	protected byte[] zb9HqIFiZl6(byte[] P_0)
	{
		int num = 1;
		int num2 = num;
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			default:
				if (P_0 != null)
				{
					HfRsHRHq7vCGynYbLRfd.iZmHqJWdFVW((long)P_0.Length * 8L, array, 0);
				}
				return array;
			case 1:
				array = new byte[8];
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static Yk3Od1Hqjai5LUixcs3l()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void S07JgDDMaOAhiTbkEC17()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool WkrUX6DMvAGt6L5B2veT()
	{
		return GsYtvpDMoyUgOfH0hqv8 == null;
	}

	internal static Yk3Od1Hqjai5LUixcs3l vJigIgDMBF9RQ0AhuMJo()
	{
		return GsYtvpDMoyUgOfH0hqv8;
	}

	internal static void E2dJa7DMiMs6lMOO5GEi(object P_0, int P_1, object P_2, int P_3, int P_4)
	{
		Array.Copy((Array)P_0, P_1, (Array)P_2, P_3, P_4);
	}

	internal static void PsEu29DMltNmnXRtFDyS(object P_0, bool P_1, object P_2)
	{
		((BufferedCipherBase)P_0).Init(P_1, (ICipherParameters)P_2);
	}

	internal static int xdco13DM4KmZYbKVnuV6(object P_0, object P_1, int P_2, int P_3, object P_4, int P_5)
	{
		return ((BufferedCipherBase)P_0).ProcessBytes((byte[])P_1, P_2, P_3, (byte[])P_4, P_5);
	}

	internal static int p2uwP1DMD7V6ts5WWxgE(object P_0, object P_1, int P_2)
	{
		return ((BufferedCipherBase)P_0).DoFinal((byte[])P_1, P_2);
	}

	internal static object oqZM5xDMbsmN0EqdSN1U(object P_0)
	{
		return ((IesParameters)P_0).GetEncodingV();
	}

	internal static void wLmrA0DMNZf6LLqB3KSB(object P_0, object P_1, int P_2, int P_3)
	{
		((IMac)P_0).BlockUpdate((byte[])P_1, P_2, P_3);
	}

	internal static int aL0fiKDMkkVQ6s6yVP7D(object P_0, object P_1, int P_2)
	{
		return ((IMac)P_0).DoFinal((byte[])P_1, P_2);
	}

	internal static int CJwmJ4DM1ocuHLKihwVW(object P_0)
	{
		return ((IMac)P_0).GetMacSize();
	}

	internal static int AI4TcoDM5Uc7Ag6CQMx7(object P_0, object P_1, int P_2, int P_3)
	{
		return ((IDerivationFunction)P_0).GenerateBytes((byte[])P_1, P_2, P_3);
	}

	internal static int MOn2bQDMSMBSeiQdCtG7(object P_0)
	{
		return ((IesWithCipherParameters)P_0).CipherKeySize;
	}

	internal static void hjSk9cDMxiNnCGJ50gej(object P_0, object P_1)
	{
		((IMac)P_0).Init((ICipherParameters)P_1);
	}

	internal static object z0uxQLDMLwtND2nEO0vk(object P_0, int P_1, int P_2)
	{
		return Arrays.CopyOfRange((byte[])P_0, P_1, P_2);
	}

	internal static object rUQBEYDMebjPoxYLbuxr(object P_0)
	{
		return ((ECKeyPairGenerator)P_0).GenerateKeyPair();
	}

	internal static object GMGmviDMsAqWFo9962iQ(object P_0)
	{
		return ((ECPoint)P_0).GetEncoded();
	}

	internal static void tvH2CbDMX2i9DBxNnZnP(object P_0, object P_1)
	{
		((IBasicAgreement)P_0).Init((ICipherParameters)P_1);
	}

	internal static void FxDsZxDMca4C8U4Diaqm(object P_0, byte P_1)
	{
		Arrays.Fill((byte[])P_0, P_1);
	}
}
