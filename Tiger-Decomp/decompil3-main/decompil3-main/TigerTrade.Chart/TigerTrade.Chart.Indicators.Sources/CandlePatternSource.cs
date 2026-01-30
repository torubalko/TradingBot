using System.Collections.Generic;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TicTacTec.TA.Library;
using TigerTrade.Chart.Indicators.Common;

namespace TigerTrade.Chart.Indicators.Sources;

[IndicatorSource("CandlePattern", Type = typeof(CandlePatternSource))]
[DataContract(Name = "CandlePatternSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class CandlePatternSource : IndicatorSourceBase
{
	private CandlePatternSourcePatternType _patternType;

	private double _penetration;

	private static CandlePatternSource xsi1dRevljW4vLVPqCFf;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPatternType")]
	[DataMember(Name = "PatternType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public CandlePatternSourcePatternType PatternType
	{
		get
		{
			return _patternType;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (value != _patternType)
					{
						_patternType = value;
						OnPropertyChanged((string)P27Wd5evbnWF8byZZ1nv(0x404ED0BE ^ 0x404E5842));
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1309555870 ^ -1309586828));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPenetration")]
	[DataMember(Name = "Penetration")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public double Penetration
	{
		get
		{
			return _penetration;
		}
		set
		{
			if (!value.Equals(_penetration))
			{
				_penetration = value;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1736566656 ^ -1736535658));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	public CandlePatternSource()
	{
		rEZ6QxevNUZiNBb2urrA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Penetration = 1.0;
				return;
			}
			base.SelectedSeries = (string)P27Wd5evbnWF8byZZ1nv(0x3E0426F0 ^ 0x3E04AFC0);
			PatternType = CandlePatternSourcePatternType.Doji;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 != 0)
			{
				num = 1;
			}
		}
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string> { yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5CD4F15 ^ 0x5CDC625) };
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		return SearchPattern(helper, PatternType);
	}

	public double[] SearchPattern(IndicatorsHelper helper, CandlePatternSourcePatternType type)
	{
		int num = v1ECAnevkCPmWmtQQppJ(helper);
		double[] array = new double[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = double.NaN;
		}
		int num2 = 45;
		TicTacTec.TA.Library.Core.RetCode retCode = default(TicTacTec.TA.Library.Core.RetCode);
		int outBegIdx = default(int);
		int[] array2 = default(int[]);
		CandlePatternSourcePatternType patternType = default(CandlePatternSourcePatternType);
		int num3 = default(int);
		while (true)
		{
			int outNBElement;
			int num4;
			switch (num2)
			{
			case 18:
				retCode = TicTacTec.TA.Library.Core.CdlStalledPattern(0, num - 1, helper.Open, helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
			case 39:
				goto IL_0146;
			case 59:
				switch (patternType)
				{
				case CandlePatternSourcePatternType.StalledPattern:
					break;
				case CandlePatternSourcePatternType.UpsideGapTwoCrows:
					goto IL_0146;
				case CandlePatternSourcePatternType.MorningDojiStar:
					retCode = TicTacTec.TA.Library.Core.CdlMorningDojiStar(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), (double[])YUfxmDevxtxvSpxctf2Q(helper), helper.Close, Penetration, out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.ConcealingBabySwallow:
					retCode = TicTacTec.TA.Library.Core.CdlConcealBabysWall(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), helper.High, helper.Low, (double[])jYrZ2sevSYJ1OaOQOOhs(helper), out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.TwoCrows:
					goto IL_0316;
				case CandlePatternSourcePatternType.TasukiGap:
					retCode = TicTacTec.TA.Library.Core.CdlTasukiGap(0, num - 1, helper.Open, helper.High, helper.Low, (double[])jYrZ2sevSYJ1OaOQOOhs(helper), out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.AdvanceBlock:
					retCode = TicTacTec.TA.Library.Core.CdlAdvanceBlock(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.RickshawMan:
					retCode = TicTacTec.TA.Library.Core.CdlRickshawMan(0, num - 1, helper.Open, helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.ThreeOutsideUpDown:
					retCode = TicTacTec.TA.Library.Core.Cdl3Outside(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.SpinningTop:
					retCode = TicTacTec.TA.Library.Core.CdlSpinningTop(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), helper.High, (double[])YUfxmDevxtxvSpxctf2Q(helper), (double[])jYrZ2sevSYJ1OaOQOOhs(helper), out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.UpDownGap:
					goto IL_04af;
				default:
					goto IL_04f3;
				case CandlePatternSourcePatternType.IdenticalThreeCrows:
					goto IL_0509;
				case CandlePatternSourcePatternType.ThrustingPattern:
					goto IL_0547;
				case CandlePatternSourcePatternType.HighWaveCandle:
					retCode = TicTacTec.TA.Library.Core.CdlHignWave(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), helper.High, (double[])YUfxmDevxtxvSpxctf2Q(helper), helper.Close, out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.EveningDojiStar:
					goto IL_05f7;
				case CandlePatternSourcePatternType.HikkakePattern:
					goto IL_0645;
				case CandlePatternSourcePatternType.HangingMan:
					goto IL_06cf;
				case CandlePatternSourcePatternType.ShootingStar:
					retCode = TicTacTec.TA.Library.Core.CdlShootingStar(0, num - 1, helper.Open, helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.OnNeckPattern:
					goto IL_075b;
				case CandlePatternSourcePatternType.HaramiCrossPattern:
					goto IL_079f;
				case CandlePatternSourcePatternType.EngulfingPattern:
					retCode = TicTacTec.TA.Library.Core.CdlEngulfing(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, (double[])jYrZ2sevSYJ1OaOQOOhs(helper), out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.Belthold:
					goto IL_082c;
				case CandlePatternSourcePatternType.ShortLineCandle:
					goto IL_086a;
				case CandlePatternSourcePatternType.DarkCloudCover:
					goto IL_08ae;
				case CandlePatternSourcePatternType.DojiStar:
					goto IL_08f6;
				case CandlePatternSourcePatternType.SeparatingLines:
					goto IL_0925;
				case CandlePatternSourcePatternType.Marubozu:
					goto IL_0963;
				case CandlePatternSourcePatternType.MorningStar:
					goto IL_09b6;
				case CandlePatternSourcePatternType.ThreeStarsInTheSouth:
					goto IL_09eb;
				case CandlePatternSourcePatternType.HomingPigeon:
					goto IL_0a31;
				case CandlePatternSourcePatternType.Counterattack:
					goto IL_0ac1;
				case CandlePatternSourcePatternType.StickSandwich:
					goto IL_0af0;
				case CandlePatternSourcePatternType.LadderBottom:
					goto IL_0b31;
				case CandlePatternSourcePatternType.RisingFallingThreeMethods:
					goto IL_0bad;
				case CandlePatternSourcePatternType.DragonflyDoji:
					goto IL_0bff;
				case CandlePatternSourcePatternType.Hammer:
					goto IL_0c67;
				case CandlePatternSourcePatternType.Kicking:
					goto IL_0cab;
				case CandlePatternSourcePatternType.TristarPattern:
					retCode = TicTacTec.TA.Library.Core.CdlTristar(0, num - 1, helper.Open, helper.High, helper.Low, (double[])jYrZ2sevSYJ1OaOQOOhs(helper), out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.GravestoneDoji:
					retCode = TicTacTec.TA.Library.Core.CdlGravestoneDoji(0, num - 1, helper.Open, helper.High, helper.Low, (double[])jYrZ2sevSYJ1OaOQOOhs(helper), out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.MatHold:
					goto IL_0d61;
				case CandlePatternSourcePatternType.LongLeggedDoji:
					goto IL_0d96;
				case CandlePatternSourcePatternType.MatchingLow:
					retCode = TicTacTec.TA.Library.Core.CdlMatchingLow(0, num - 1, helper.Open, helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.ThreeInsideUpDown:
					retCode = TicTacTec.TA.Library.Core.Cdl3Inside(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), helper.High, helper.Low, (double[])jYrZ2sevSYJ1OaOQOOhs(helper), out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.LongLineCandle:
					goto IL_0e79;
				case CandlePatternSourcePatternType.UpsideDownsideGapThreeMethods:
					goto IL_0ec7;
				case CandlePatternSourcePatternType.ThreeBlackCrows:
					goto IL_0efb;
				case CandlePatternSourcePatternType.Takuri:
					goto IL_0f33;
				case CandlePatternSourcePatternType.KickingBullBear:
					retCode = TicTacTec.TA.Library.Core.CdlKickingByLength(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), helper.High, (double[])YUfxmDevxtxvSpxctf2Q(helper), helper.Close, out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.Doji:
					goto IL_0fd4;
				case CandlePatternSourcePatternType.ModifiedHikkakePattern:
					retCode = TicTacTec.TA.Library.Core.CdlHikkakeMod(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, (double[])jYrZ2sevSYJ1OaOQOOhs(helper), out outBegIdx, out outNBElement, array2);
					goto IL_04f3;
				case CandlePatternSourcePatternType.InNeckPattern:
					goto IL_1079;
				case CandlePatternSourcePatternType.Breakaway:
					goto IL_10ad;
				case CandlePatternSourcePatternType.PiercingPattern:
					goto IL_10fa;
				case CandlePatternSourcePatternType.ThreeLineStrike:
					goto IL_1150;
				case CandlePatternSourcePatternType.HaramiPattern:
					goto IL_11b3;
				case CandlePatternSourcePatternType.AbandonedBaby:
					goto IL_11f5;
				case CandlePatternSourcePatternType.InvertedHammer:
					goto IL_126d;
				case CandlePatternSourcePatternType.ClosingMarubozu:
					goto IL_12c0;
				case CandlePatternSourcePatternType.EveningStar:
					goto IL_12ef;
				case CandlePatternSourcePatternType.Unique3River:
					goto IL_1338;
				case CandlePatternSourcePatternType.ThreeAdvancingWhiteSoldiers:
					goto IL_1380;
				}
				goto case 18;
			default:
				goto IL_04f3;
			case 55:
				goto IL_0509;
			case 8:
				goto IL_0547;
			case 11:
				goto IL_05f7;
			case 44:
				goto IL_0645;
			case 45:
				array2 = new int[num];
				retCode = TicTacTec.TA.Library.Core.RetCode.UnknownErr;
				outBegIdx = 0;
				num2 = 53;
				break;
			case 27:
				goto IL_06cf;
			case 57:
				goto IL_075b;
			case 61:
				goto IL_079f;
			case 23:
			case 24:
				if (num3 >= num)
				{
					return array;
				}
				goto case 54;
			case 53:
				patternType = PatternType;
				num2 = 59;
				break;
			case 51:
				goto IL_082c;
			case 7:
				goto IL_08ae;
			case 19:
				goto IL_08f6;
			case 28:
				goto IL_0925;
			case 3:
				goto IL_0963;
			case 48:
				goto IL_09b6;
			case 4:
				goto IL_09eb;
			case 30:
				goto IL_0a31;
			case 33:
				goto IL_0ac1;
			case 54:
				if (num3 >= outBegIdx)
				{
					array[num3] = array2[num3 - outBegIdx];
				}
				num3++;
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
				{
					num2 = 24;
				}
				break;
			case 38:
				goto IL_0bff;
			case 16:
				goto IL_0cab;
			case 26:
				goto IL_0d61;
			case 60:
				goto IL_0d96;
			case 9:
				goto IL_0e79;
			case 13:
				goto IL_0efb;
			case 25:
				goto IL_0fd4;
			case 52:
				goto IL_1079;
			case 46:
				goto IL_10ad;
			case 49:
				goto IL_11b3;
			case 32:
				goto IL_11f5;
			case 47:
				goto IL_126d;
			case 10:
				goto IL_12c0;
			case 5:
				goto IL_1338;
				IL_079f:
				retCode = TicTacTec.TA.Library.Core.CdlHaramiCross(0, num - 1, helper.Open, helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 14;
				break;
				IL_075b:
				retCode = TicTacTec.TA.Library.Core.CdlOnNeck(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 11;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
				{
					num2 = 40;
				}
				break;
				IL_06cf:
				retCode = TicTacTec.TA.Library.Core.CdlHangingMan(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, (double[])jYrZ2sevSYJ1OaOQOOhs(helper), out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_1380:
				retCode = TicTacTec.TA.Library.Core.Cdl3WhiteSoldiers(0, num - 1, helper.Open, helper.High, (double[])YUfxmDevxtxvSpxctf2Q(helper), helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 34;
				break;
				IL_1338:
				retCode = TicTacTec.TA.Library.Core.CdlUnique3River(0, num - 1, helper.Open, helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_12ef:
				retCode = TicTacTec.TA.Library.Core.CdlEveningStar(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), (double[])UPbSRqev1qZgDBhSKy5M(helper), (double[])YUfxmDevxtxvSpxctf2Q(helper), (double[])jYrZ2sevSYJ1OaOQOOhs(helper), Penetration, out outBegIdx, out outNBElement, array2);
				num2 = 37;
				break;
				IL_12c0:
				retCode = TicTacTec.TA.Library.Core.CdlClosingMarubozu(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), helper.High, (double[])YUfxmDevxtxvSpxctf2Q(helper), helper.Close, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_126d:
				retCode = TicTacTec.TA.Library.Core.CdlInvertedHammer(0, num - 1, helper.Open, helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 35;
				break;
				IL_11f5:
				retCode = TicTacTec.TA.Library.Core.CdlAbandonedBaby(0, num - 1, helper.Open, helper.High, helper.Low, helper.Close, Penetration, out outBegIdx, out outNBElement, array2);
				num2 = 56;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b == 0)
				{
					num2 = 3;
				}
				break;
				IL_0316:
				retCode = TicTacTec.TA.Library.Core.Cdl2Crows(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 22;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c != 0)
				{
					num2 = 8;
				}
				break;
				IL_11b3:
				retCode = TicTacTec.TA.Library.Core.CdlHarami(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				num4 = 42;
				goto IL_0005;
				IL_1150:
				retCode = TicTacTec.TA.Library.Core.Cdl3LineStrike(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), helper.High, (double[])YUfxmDevxtxvSpxctf2Q(helper), (double[])jYrZ2sevSYJ1OaOQOOhs(helper), out outBegIdx, out outNBElement, array2);
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
				{
					num2 = 43;
				}
				break;
				IL_0645:
				retCode = TicTacTec.TA.Library.Core.CdlHikkake(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_10fa:
				retCode = TicTacTec.TA.Library.Core.CdlPiercing(0, num - 1, helper.Open, helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 58;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 == 0)
				{
					num2 = 32;
				}
				break;
				IL_05f7:
				retCode = TicTacTec.TA.Library.Core.CdlEveningDojiStar(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), helper.High, helper.Low, helper.Close, Penetration, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_10ad:
				retCode = TicTacTec.TA.Library.Core.CdlBreakaway(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, (double[])jYrZ2sevSYJ1OaOQOOhs(helper), out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_1079:
				retCode = TicTacTec.TA.Library.Core.CdlInNeck(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 17;
				break;
				IL_0fd4:
				retCode = TicTacTec.TA.Library.Core.CdlDoji(0, num - 1, helper.Open, helper.High, (double[])YUfxmDevxtxvSpxctf2Q(helper), helper.Close, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_0f33:
				retCode = TicTacTec.TA.Library.Core.CdlTakuri(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, (double[])jYrZ2sevSYJ1OaOQOOhs(helper), out outBegIdx, out outNBElement, array2);
				num2 = 2;
				break;
				IL_0efb:
				retCode = TicTacTec.TA.Library.Core.Cdl3BlackCrows(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				num4 = 6;
				goto IL_0005;
				IL_0005:
				num2 = num4;
				break;
				IL_0ec7:
				retCode = TicTacTec.TA.Library.Core.CdlXSideGap3Methods(0, num - 1, helper.Open, helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 21;
				break;
				IL_0e79:
				retCode = TicTacTec.TA.Library.Core.CdlLongLine(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_0d96:
				retCode = TicTacTec.TA.Library.Core.CdlLongLeggedDoji(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 31;
				break;
				IL_0d61:
				retCode = TicTacTec.TA.Library.Core.CdlMatHold(0, num - 1, helper.Open, helper.High, helper.Low, (double[])jYrZ2sevSYJ1OaOQOOhs(helper), Penetration, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_0cab:
				retCode = TicTacTec.TA.Library.Core.CdlKicking(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), helper.High, helper.Low, (double[])jYrZ2sevSYJ1OaOQOOhs(helper), out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_0c67:
				retCode = TicTacTec.TA.Library.Core.CdlHammer(0, num - 1, helper.Open, helper.High, (double[])YUfxmDevxtxvSpxctf2Q(helper), helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 50;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
				{
					num2 = 11;
				}
				break;
				IL_0547:
				retCode = TicTacTec.TA.Library.Core.CdlThrusting(0, num - 1, helper.Open, helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d != 0)
				{
					num2 = 1;
				}
				break;
				IL_0bff:
				retCode = TicTacTec.TA.Library.Core.CdlDragonflyDoji(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_0bad:
				retCode = TicTacTec.TA.Library.Core.CdlRiseFall3Methods(0, num - 1, helper.Open, helper.High, (double[])YUfxmDevxtxvSpxctf2Q(helper), (double[])jYrZ2sevSYJ1OaOQOOhs(helper), out outBegIdx, out outNBElement, array2);
				num2 = 15;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 != 0)
				{
					num2 = 29;
				}
				break;
				IL_04f3:
				if (retCode != TicTacTec.TA.Library.Core.RetCode.Success)
				{
					return array;
				}
				num3 = 0;
				num2 = 21;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 == 0)
				{
					num2 = 23;
				}
				break;
				IL_0b31:
				retCode = TicTacTec.TA.Library.Core.CdlLadderBottom(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), (double[])YUfxmDevxtxvSpxctf2Q(helper), helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
				{
					num2 = 0;
				}
				break;
				IL_0509:
				retCode = TicTacTec.TA.Library.Core.CdlIdentical3Crows(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_0af0:
				retCode = TicTacTec.TA.Library.Core.CdlStickSandwhich(0, num - 1, helper.Open, helper.High, (double[])YUfxmDevxtxvSpxctf2Q(helper), helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 15;
				break;
				IL_0ac1:
				retCode = TicTacTec.TA.Library.Core.CdlCounterAttack(0, num - 1, helper.Open, helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_0a31:
				retCode = TicTacTec.TA.Library.Core.CdlHomingPigeon(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_09eb:
				retCode = TicTacTec.TA.Library.Core.Cdl3StarsInSouth(0, num - 1, helper.Open, (double[])UPbSRqev1qZgDBhSKy5M(helper), (double[])YUfxmDevxtxvSpxctf2Q(helper), helper.Close, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_09b6:
				retCode = TicTacTec.TA.Library.Core.CdlMorningStar(0, num - 1, helper.Open, helper.High, helper.Low, (double[])jYrZ2sevSYJ1OaOQOOhs(helper), Penetration, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_0963:
				retCode = TicTacTec.TA.Library.Core.CdlMarubozu(0, num - 1, helper.Open, helper.High, (double[])YUfxmDevxtxvSpxctf2Q(helper), helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 20;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
				{
					num2 = 10;
				}
				break;
				IL_0146:
				retCode = TicTacTec.TA.Library.Core.CdlUpsideGap2Crows(0, num - 1, helper.Open, helper.High, (double[])YUfxmDevxtxvSpxctf2Q(helper), helper.Close, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_0925:
				retCode = TicTacTec.TA.Library.Core.CdlSeperatingLines(0, num - 1, helper.Open, helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_08f6:
				retCode = TicTacTec.TA.Library.Core.CdlDojiStar(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), (double[])UPbSRqev1qZgDBhSKy5M(helper), helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_08ae:
				retCode = TicTacTec.TA.Library.Core.CdlDarkCloudCover(0, num - 1, helper.Open, helper.High, helper.Low, (double[])jYrZ2sevSYJ1OaOQOOhs(helper), Penetration, out outBegIdx, out outNBElement, array2);
				goto IL_04f3;
				IL_086a:
				retCode = TicTacTec.TA.Library.Core.CdlShortLine(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 36;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 == 0)
				{
					num2 = 18;
				}
				break;
				IL_04af:
				retCode = TicTacTec.TA.Library.Core.CdlGapSideSideWhite(0, num - 1, (double[])lHNdTcev5DwnIsWbgvXg(helper), helper.High, helper.Low, helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 6;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
				{
					num2 = 12;
				}
				break;
				IL_082c:
				retCode = TicTacTec.TA.Library.Core.CdlBeltHold(0, num - 1, helper.Open, helper.High, (double[])YUfxmDevxtxvSpxctf2Q(helper), helper.Close, out outBegIdx, out outNBElement, array2);
				num2 = 41;
				break;
			}
		}
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		int num = 2;
		int num2 = num;
		CandlePatternSource candlePatternSource = default(CandlePatternSource);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (candlePatternSource != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				candlePatternSource = source as CandlePatternSource;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				base.SelectedSeries = candlePatternSource.SelectedSeries;
				PatternType = trNyy8evL2u4Ip5PrMni(candlePatternSource);
				Penetration = T1ikT2evek5vBro9IXjw(candlePatternSource);
				return;
			}
		}
	}

	public override string ToString()
	{
		if (string.IsNullOrEmpty(base.SelectedSeries))
		{
			return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7394D272 ^ 0x73945596);
		}
		return string.Format((string)P27Wd5evbnWF8byZZ1nv(-1763895751 ^ -1763864119), base.SelectedSeries, PatternType);
	}

	static CandlePatternSource()
	{
		Rtldn0evsA3DsPyLkRxm();
		k5hOsxevXZ770RnBgwb2();
	}

	internal static object P27Wd5evbnWF8byZZ1nv(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool hmhKViev45ilOBOFeZBI()
	{
		return xsi1dRevljW4vLVPqCFf == null;
	}

	internal static CandlePatternSource AD7eNmevDuYAdxpEyYle()
	{
		return xsi1dRevljW4vLVPqCFf;
	}

	internal static void rEZ6QxevNUZiNBb2urrA()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static int v1ECAnevkCPmWmtQQppJ(object P_0)
	{
		return ((IndicatorsHelper)P_0).Count;
	}

	internal static object UPbSRqev1qZgDBhSKy5M(object P_0)
	{
		return ((IndicatorsHelper)P_0).High;
	}

	internal static object lHNdTcev5DwnIsWbgvXg(object P_0)
	{
		return ((IndicatorsHelper)P_0).Open;
	}

	internal static object jYrZ2sevSYJ1OaOQOOhs(object P_0)
	{
		return ((IndicatorsHelper)P_0).Close;
	}

	internal static object YUfxmDevxtxvSpxctf2Q(object P_0)
	{
		return ((IndicatorsHelper)P_0).Low;
	}

	internal static CandlePatternSourcePatternType trNyy8evL2u4Ip5PrMni(object P_0)
	{
		return ((CandlePatternSource)P_0).PatternType;
	}

	internal static double T1ikT2evek5vBro9IXjw(object P_0)
	{
		return ((CandlePatternSource)P_0).Penetration;
	}

	internal static void Rtldn0evsA3DsPyLkRxm()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void k5hOsxevXZ770RnBgwb2()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
