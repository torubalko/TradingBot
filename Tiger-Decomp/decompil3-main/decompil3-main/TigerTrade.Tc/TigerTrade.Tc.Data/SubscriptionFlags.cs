using System;

namespace TigerTrade.Tc.Data;

[Flags]
public enum SubscriptionFlags
{
	None = 0,
	Level1 = 1,
	Level2 = 2,
	Ticks = 4,
	OpenInterest = 8
}
