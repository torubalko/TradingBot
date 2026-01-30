using System;
using System.Runtime.Serialization;
using dW9IjE2Usa1dyh9vvZp;

namespace TigerTrade.Chart.Base.Enums;

[Flags]
[DataContract(Name = "ChartRouletteFlags", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Base")]
public enum ChartRouletteFlags
{
	[Xdm5MC2tN0JMGo5PMYU("ChartRouletteFlagsNone")]
	[EnumMember(Value = "None")]
	None = 0,
	[EnumMember(Value = "Bars")]
	[Xdm5MC2tN0JMGo5PMYU("ChartRouletteFlagsBars")]
	Bars = 1,
	[EnumMember(Value = "Time")]
	[Xdm5MC2tN0JMGo5PMYU("ChartRouletteFlagsTime")]
	Time = 2,
	[EnumMember(Value = "Price")]
	[Xdm5MC2tN0JMGo5PMYU("ChartRouletteFlagsPrice")]
	Price = 4,
	[EnumMember(Value = "Ticks")]
	[Xdm5MC2tN0JMGo5PMYU("ChartRouletteFlagsTicks")]
	Ticks = 8,
	[EnumMember(Value = "Money")]
	[Xdm5MC2tN0JMGo5PMYU("ChartRouletteFlagsMoney")]
	Money = 0x10,
	[Xdm5MC2tN0JMGo5PMYU("ChartRouletteFlagsRange")]
	[EnumMember(Value = "Range")]
	Range = 0x20,
	[EnumMember(Value = "Change")]
	[Xdm5MC2tN0JMGo5PMYU("ChartRouletteFlagsChange")]
	Change = 0x40,
	[EnumMember(Value = "Volume")]
	[Xdm5MC2tN0JMGo5PMYU("ChartRouletteFlagsVolume")]
	Volume = 0x80,
	[EnumMember(Value = "Trades")]
	[Xdm5MC2tN0JMGo5PMYU("ChartRouletteFlagsTrades")]
	Trades = 0x100,
	[EnumMember(Value = "Delta")]
	[Xdm5MC2tN0JMGo5PMYU("ChartRouletteFlagsDelta")]
	Delta = 0x200,
	[Xdm5MC2tN0JMGo5PMYU("ChartRouletteFlagsBid")]
	[EnumMember(Value = "Bid")]
	Bid = 0x400,
	[Xdm5MC2tN0JMGo5PMYU("ChartRouletteFlagsAsk")]
	[EnumMember(Value = "Ask")]
	Ask = 0x800
}
