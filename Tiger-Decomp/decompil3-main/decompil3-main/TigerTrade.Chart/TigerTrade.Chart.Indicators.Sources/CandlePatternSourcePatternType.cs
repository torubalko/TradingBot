using System.ComponentModel;
using System.Runtime.Serialization;
using lenU8Xi4GH9qbKatfZNL;
using TigerTrade.Core.UI.Converters;

namespace TigerTrade.Chart.Indicators.Sources;

[TypeConverter(typeof(EnumDescriptionTypeConverter))]
[DataContract(Name = "CandlePatternSourcePatternType", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public enum CandlePatternSourcePatternType
{
	[mQYh4Ti4nGsawZaMqRVA("Two Crows")]
	[EnumMember(Value = "TwoCrows")]
	TwoCrows,
	[mQYh4Ti4nGsawZaMqRVA("Three Black Crows")]
	[EnumMember(Value = "ThreeBlackCrows")]
	ThreeBlackCrows,
	[mQYh4Ti4nGsawZaMqRVA("Three Inside Up/Down")]
	[EnumMember(Value = "ThreeInsideUpDown")]
	ThreeInsideUpDown,
	[mQYh4Ti4nGsawZaMqRVA("Three-Line Strike")]
	[EnumMember(Value = "ThreeLineStrike")]
	ThreeLineStrike,
	[mQYh4Ti4nGsawZaMqRVA("Three Outside Up/Down")]
	[EnumMember(Value = "ThreeOutsideUpDown")]
	ThreeOutsideUpDown,
	[mQYh4Ti4nGsawZaMqRVA("Three Stars In The South")]
	[EnumMember(Value = "ThreeStarsInTheSouth")]
	ThreeStarsInTheSouth,
	[mQYh4Ti4nGsawZaMqRVA("Three Advancing White Soldiers")]
	[EnumMember(Value = "ThreeAdvancingWhiteSoldiers")]
	ThreeAdvancingWhiteSoldiers,
	[mQYh4Ti4nGsawZaMqRVA("Abandoned Baby")]
	[EnumMember(Value = "AbandonedBaby")]
	AbandonedBaby,
	[mQYh4Ti4nGsawZaMqRVA("Advance Block")]
	[EnumMember(Value = "AdvanceBlock")]
	AdvanceBlock,
	[mQYh4Ti4nGsawZaMqRVA("Belt-hold")]
	[EnumMember(Value = "Belthold")]
	Belthold,
	[EnumMember(Value = "Breakaway")]
	[mQYh4Ti4nGsawZaMqRVA("Breakaway")]
	Breakaway,
	[mQYh4Ti4nGsawZaMqRVA("Closing Marubozu")]
	[EnumMember(Value = "ClosingMarubozu")]
	ClosingMarubozu,
	[mQYh4Ti4nGsawZaMqRVA("Concealing Baby Swallow")]
	[EnumMember(Value = "ConcealingBabySwallow")]
	ConcealingBabySwallow,
	[mQYh4Ti4nGsawZaMqRVA("Counterattack")]
	[EnumMember(Value = "Counterattack")]
	Counterattack,
	[mQYh4Ti4nGsawZaMqRVA("Dark Cloud Cover")]
	[EnumMember(Value = "DarkCloudCover")]
	DarkCloudCover,
	[mQYh4Ti4nGsawZaMqRVA("Doji")]
	[EnumMember(Value = "Doji")]
	Doji,
	[EnumMember(Value = "DojiStar")]
	[mQYh4Ti4nGsawZaMqRVA("Doji Star")]
	DojiStar,
	[mQYh4Ti4nGsawZaMqRVA("Dragonfly Doji")]
	[EnumMember(Value = "DragonflyDoji")]
	DragonflyDoji,
	[EnumMember(Value = "EngulfingPattern")]
	[mQYh4Ti4nGsawZaMqRVA("Engulfing Pattern")]
	EngulfingPattern,
	[EnumMember(Value = "EveningDojiStar")]
	[mQYh4Ti4nGsawZaMqRVA("Evening Doji Star")]
	EveningDojiStar,
	[mQYh4Ti4nGsawZaMqRVA("Evening Star")]
	[EnumMember(Value = "EveningStar")]
	EveningStar,
	[mQYh4Ti4nGsawZaMqRVA("Up/Down-gap side-by-side white lines")]
	[EnumMember(Value = "UpDownGap")]
	UpDownGap,
	[EnumMember(Value = "GravestoneDoji")]
	[mQYh4Ti4nGsawZaMqRVA("Gravestone Doji")]
	GravestoneDoji,
	[EnumMember(Value = "Hammer")]
	[mQYh4Ti4nGsawZaMqRVA("Hammer")]
	Hammer,
	[mQYh4Ti4nGsawZaMqRVA("Hanging Man")]
	[EnumMember(Value = "HangingMan")]
	HangingMan,
	[mQYh4Ti4nGsawZaMqRVA("Harami Pattern")]
	[EnumMember(Value = "HaramiPattern")]
	HaramiPattern,
	[EnumMember(Value = "HaramiCrossPattern")]
	[mQYh4Ti4nGsawZaMqRVA("Harami Cross Pattern")]
	HaramiCrossPattern,
	[EnumMember(Value = "HighWaveCandle")]
	[mQYh4Ti4nGsawZaMqRVA("High-Wave Candle")]
	HighWaveCandle,
	[EnumMember(Value = "HikkakePattern")]
	[mQYh4Ti4nGsawZaMqRVA("Hikkake Pattern")]
	HikkakePattern,
	[mQYh4Ti4nGsawZaMqRVA("Modified Hikkake Pattern")]
	[EnumMember(Value = "ModifiedHikkakePattern")]
	ModifiedHikkakePattern,
	[mQYh4Ti4nGsawZaMqRVA("Homing Pigeon")]
	[EnumMember(Value = "HomingPigeon")]
	HomingPigeon,
	[EnumMember(Value = "IdenticalThreeCrows")]
	[mQYh4Ti4nGsawZaMqRVA("Identical Three Crows")]
	IdenticalThreeCrows,
	[EnumMember(Value = "InNeckPattern")]
	[mQYh4Ti4nGsawZaMqRVA("In-Neck Pattern")]
	InNeckPattern,
	[EnumMember(Value = "InvertedHammer")]
	[mQYh4Ti4nGsawZaMqRVA("Inverted Hammer")]
	InvertedHammer,
	[mQYh4Ti4nGsawZaMqRVA("Kicking")]
	[EnumMember(Value = "Kicking")]
	Kicking,
	[EnumMember(Value = "KickingBullBear")]
	[mQYh4Ti4nGsawZaMqRVA("Kicking - bull/bear determined by the longer marubozu")]
	KickingBullBear,
	[EnumMember(Value = "LadderBottom")]
	[mQYh4Ti4nGsawZaMqRVA("Ladder Bottom")]
	LadderBottom,
	[EnumMember(Value = "LongLeggedDoji")]
	[mQYh4Ti4nGsawZaMqRVA("Long Legged Doji")]
	LongLeggedDoji,
	[EnumMember(Value = "LongLineCandle")]
	[mQYh4Ti4nGsawZaMqRVA("Long Line Candle")]
	LongLineCandle,
	[mQYh4Ti4nGsawZaMqRVA("Marubozu")]
	[EnumMember(Value = "Marubozu")]
	Marubozu,
	[mQYh4Ti4nGsawZaMqRVA("Matching Low")]
	[EnumMember(Value = "MatchingLow")]
	MatchingLow,
	[EnumMember(Value = "MatHold")]
	[mQYh4Ti4nGsawZaMqRVA("Mat Hold")]
	MatHold,
	[mQYh4Ti4nGsawZaMqRVA("Morning Doji Star")]
	[EnumMember(Value = "MorningDojiStar")]
	MorningDojiStar,
	[EnumMember(Value = "MorningStar")]
	[mQYh4Ti4nGsawZaMqRVA("Morning Star")]
	MorningStar,
	[mQYh4Ti4nGsawZaMqRVA("On-Neck Pattern")]
	[EnumMember(Value = "OnNeckPattern")]
	OnNeckPattern,
	[EnumMember(Value = "PiercingPattern")]
	[mQYh4Ti4nGsawZaMqRVA("Piercing Pattern")]
	PiercingPattern,
	[mQYh4Ti4nGsawZaMqRVA("Rickshaw Man")]
	[EnumMember(Value = "RickshawMan")]
	RickshawMan,
	[mQYh4Ti4nGsawZaMqRVA("Rising/Falling Three Methods")]
	[EnumMember(Value = "RisingFallingThreeMethods")]
	RisingFallingThreeMethods,
	[EnumMember(Value = "SeparatingLines")]
	[mQYh4Ti4nGsawZaMqRVA("Separating Lines")]
	SeparatingLines,
	[EnumMember(Value = "ShootingStar")]
	[mQYh4Ti4nGsawZaMqRVA("Shooting Star")]
	ShootingStar,
	[EnumMember(Value = "ShortLineCandle")]
	[mQYh4Ti4nGsawZaMqRVA("Short Line Candle")]
	ShortLineCandle,
	[mQYh4Ti4nGsawZaMqRVA("Spinning Top")]
	[EnumMember(Value = "SpinningTop")]
	SpinningTop,
	[mQYh4Ti4nGsawZaMqRVA("Stalled Pattern")]
	[EnumMember(Value = "StalledPattern")]
	StalledPattern,
	[mQYh4Ti4nGsawZaMqRVA("Stick Sandwich")]
	[EnumMember(Value = "StickSandwich")]
	StickSandwich,
	[mQYh4Ti4nGsawZaMqRVA("Takuri (Dragonfly Doji with very long lower shadow)")]
	[EnumMember(Value = "Takuri")]
	Takuri,
	[EnumMember(Value = "TasukiGap")]
	[mQYh4Ti4nGsawZaMqRVA("Tasuki Gap")]
	TasukiGap,
	[mQYh4Ti4nGsawZaMqRVA("Thrusting Pattern")]
	[EnumMember(Value = "ThrustingPattern")]
	ThrustingPattern,
	[EnumMember(Value = "TristarPattern")]
	[mQYh4Ti4nGsawZaMqRVA("Tristar Pattern")]
	TristarPattern,
	[mQYh4Ti4nGsawZaMqRVA("Unique 3 River")]
	[EnumMember(Value = "Unique3River")]
	Unique3River,
	[EnumMember(Value = "UpsideGapTwoCrows")]
	[mQYh4Ti4nGsawZaMqRVA("Upside Gap Two Crows")]
	UpsideGapTwoCrows,
	[mQYh4Ti4nGsawZaMqRVA("Upside/Downside Gap Three Methods")]
	[EnumMember(Value = "UpsideDownsideGapThreeMethods")]
	UpsideDownsideGapThreeMethods
}
