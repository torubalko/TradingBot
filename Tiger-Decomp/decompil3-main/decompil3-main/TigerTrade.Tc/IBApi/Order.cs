using System.Collections.Generic;
using BfZtb759KlUg4482QKym;
using eluDsTGmJhPFeMTB649b;
using eqloJpGyCVXNb0FSvR2i;
using JZ8sb1GrXwPFkVDPEGJ4;
using K1GcsD5GTtMSlaiJI0Xh;
using VyMlitGrDpIVMlMYRmFX;
using x97CE55GhEYKgt7TSVZT;
using ytyCxwGyW7ewXtL3i5px;

namespace IBApi;

internal class Order
{
	public static int CUSTOMER;

	public static int FIRM;

	public static char OPT_UNKNOWN;

	public static char OPT_BROKER_DEALER;

	public static char OPT_CUSTOMER;

	public static char OPT_FIRM;

	public static char OPT_ISEMM;

	public static char OPT_FARMM;

	public static char OPT_SPECIALIST;

	public static int AUCTION_MATCH;

	public static int AUCTION_IMPROVEMENT;

	public static int AUCTION_TRANSPARENT;

	public static string EMPTY_STR;

	private int orderId;

	private int clientId;

	private int permId;

	private string action;

	private double totalQuantity;

	private string orderType;

	private double lmtPrice;

	private double auxPrice;

	private string tif;

	private string activeStartTime;

	private string activeStopTime;

	private string ocaGroup;

	private int ocaType;

	private string orderRef;

	private bool transmit;

	private int parentId;

	private bool blockOrder;

	private bool sweepToFill;

	private int displaySize;

	private int triggerMethod;

	private bool outsideRth;

	private bool hidden;

	private string goodAfterTime;

	private string goodTillDate;

	private bool overridePercentageConstraints;

	private string rule80A;

	private bool allOrNone;

	private int minQty;

	private double percentOffset;

	private double trailStopPrice;

	private double trailingPercent;

	private string faGroup;

	private string faProfile;

	private string faMethod;

	private string faPercentage;

	private string openClose;

	private int origin;

	private int shortSaleSlot;

	private string designatedLocation;

	private int exemptCode;

	private double discretionaryAmt;

	private bool eTradeOnly;

	private bool firmQuoteOnly;

	private double nbboPriceCap;

	private bool optOutSmartRouting;

	private int auctionStrategy;

	private double startingPrice;

	private double stockRefPrice;

	private double delta;

	private double stockRangeLower;

	private double stockRangeUpper;

	private double volatility;

	private int volatilityType;

	private int continuousUpdate;

	private int referencePriceType;

	private string deltaNeutralOrderType;

	private double deltaNeutralAuxPrice;

	private int deltaNeutralConId;

	private string deltaNeutralSettlingFirm;

	private string deltaNeutralClearingAccount;

	private string deltaNeutralClearingIntent;

	private string deltaNeutralOpenClose;

	private bool deltaNeutralShortSale;

	private int deltaNeutralShortSaleSlot;

	private string deltaNeutralDesignatedLocation;

	private double basisPoints;

	private int basisPointsType;

	private int scaleInitLevelSize;

	private int scaleSubsLevelSize;

	private double scalePriceIncrement;

	private double scalePriceAdjustValue;

	private int scalePriceAdjustInterval;

	private double scaleProfitOffset;

	private bool scaleAutoReset;

	private int scaleInitPosition;

	private int scaleInitFillQty;

	private bool scaleRandomPercent;

	private string scaleTable;

	private string hedgeType;

	private string hedgeParam;

	private string account;

	private string clearingAccount;

	private string clearingIntent;

	private string algoStrategy;

	private List<YTRgdjGrspdQ4JAkykFO> algoParams;

	private bool whatIf;

	private string algoId;

	private bool notHeld;

	private string settlingFirm;

	private List<YTRgdjGrspdQ4JAkykFO> smartComboRoutingParams;

	private List<h3wMSrGyIGHqIiIVkxdf> orderComboLegs;

	private List<YTRgdjGrspdQ4JAkykFO> orderMiscOptions;

	private bool solicited;

	private string modelCode;

	private string extOperator;

	private double cashQty;

	private bool dontUseAutoPriceForHedge;

	private string autoCancelDate;

	private double filledQuantity;

	private int refFuturesConId;

	private bool autoCancelParent;

	private string shareholder;

	private bool imbalanceOnly;

	private bool routeMarketableToBbo;

	private long parentPermId;

	internal static Order R4cIaL5qHawqIF87BbgD;

	public int OrderId
	{
		get
		{
			return orderId;
		}
		set
		{
			orderId = value;
		}
	}

	public bool Solicited
	{
		get
		{
			return solicited;
		}
		set
		{
			solicited = value;
		}
	}

	public int ClientId
	{
		get
		{
			return clientId;
		}
		set
		{
			clientId = value;
		}
	}

	public int PermId
	{
		get
		{
			return permId;
		}
		set
		{
			permId = value;
		}
	}

	public string Action
	{
		get
		{
			return action;
		}
		set
		{
			action = value;
		}
	}

	public double TotalQuantity
	{
		get
		{
			return totalQuantity;
		}
		set
		{
			totalQuantity = value;
		}
	}

	public string OrderType
	{
		get
		{
			return orderType;
		}
		set
		{
			orderType = value;
		}
	}

	public double LmtPrice
	{
		get
		{
			return lmtPrice;
		}
		set
		{
			lmtPrice = value;
		}
	}

	public double AuxPrice
	{
		get
		{
			return auxPrice;
		}
		set
		{
			auxPrice = value;
		}
	}

	public string Tif
	{
		get
		{
			return tif;
		}
		set
		{
			tif = value;
		}
	}

	public string OcaGroup
	{
		get
		{
			return ocaGroup;
		}
		set
		{
			ocaGroup = value;
		}
	}

	public int OcaType
	{
		get
		{
			return ocaType;
		}
		set
		{
			ocaType = value;
		}
	}

	public string OrderRef
	{
		get
		{
			return orderRef;
		}
		set
		{
			orderRef = value;
		}
	}

	public bool Transmit
	{
		get
		{
			return transmit;
		}
		set
		{
			transmit = value;
		}
	}

	public int ParentId
	{
		get
		{
			return parentId;
		}
		set
		{
			parentId = value;
		}
	}

	public bool BlockOrder
	{
		get
		{
			return blockOrder;
		}
		set
		{
			blockOrder = value;
		}
	}

	public bool SweepToFill
	{
		get
		{
			return sweepToFill;
		}
		set
		{
			sweepToFill = value;
		}
	}

	public int DisplaySize
	{
		get
		{
			return displaySize;
		}
		set
		{
			displaySize = value;
		}
	}

	public int TriggerMethod
	{
		get
		{
			return triggerMethod;
		}
		set
		{
			triggerMethod = value;
		}
	}

	public bool OutsideRth
	{
		get
		{
			return outsideRth;
		}
		set
		{
			outsideRth = value;
		}
	}

	public bool Hidden
	{
		get
		{
			return hidden;
		}
		set
		{
			hidden = value;
		}
	}

	public string GoodAfterTime
	{
		get
		{
			return goodAfterTime;
		}
		set
		{
			goodAfterTime = value;
		}
	}

	public string GoodTillDate
	{
		get
		{
			return goodTillDate;
		}
		set
		{
			goodTillDate = value;
		}
	}

	public bool OverridePercentageConstraints
	{
		get
		{
			return overridePercentageConstraints;
		}
		set
		{
			overridePercentageConstraints = value;
		}
	}

	public string Rule80A
	{
		get
		{
			return rule80A;
		}
		set
		{
			rule80A = value;
		}
	}

	public bool AllOrNone
	{
		get
		{
			return allOrNone;
		}
		set
		{
			allOrNone = value;
		}
	}

	public int MinQty
	{
		get
		{
			return minQty;
		}
		set
		{
			minQty = value;
		}
	}

	public double PercentOffset
	{
		get
		{
			return percentOffset;
		}
		set
		{
			percentOffset = value;
		}
	}

	public double TrailStopPrice
	{
		get
		{
			return trailStopPrice;
		}
		set
		{
			trailStopPrice = value;
		}
	}

	public double TrailingPercent
	{
		get
		{
			return trailingPercent;
		}
		set
		{
			trailingPercent = value;
		}
	}

	public string FaGroup
	{
		get
		{
			return faGroup;
		}
		set
		{
			faGroup = value;
		}
	}

	public string FaProfile
	{
		get
		{
			return faProfile;
		}
		set
		{
			faProfile = value;
		}
	}

	public string FaMethod
	{
		get
		{
			return faMethod;
		}
		set
		{
			faMethod = value;
		}
	}

	public string FaPercentage
	{
		get
		{
			return faPercentage;
		}
		set
		{
			faPercentage = value;
		}
	}

	public string OpenClose
	{
		get
		{
			return openClose;
		}
		set
		{
			openClose = value;
		}
	}

	public int Origin
	{
		get
		{
			return origin;
		}
		set
		{
			origin = value;
		}
	}

	public int ShortSaleSlot
	{
		get
		{
			return shortSaleSlot;
		}
		set
		{
			shortSaleSlot = value;
		}
	}

	public string DesignatedLocation
	{
		get
		{
			return designatedLocation;
		}
		set
		{
			designatedLocation = value;
		}
	}

	public int ExemptCode
	{
		get
		{
			return exemptCode;
		}
		set
		{
			exemptCode = value;
		}
	}

	public double DiscretionaryAmt
	{
		get
		{
			return discretionaryAmt;
		}
		set
		{
			discretionaryAmt = value;
		}
	}

	public bool ETradeOnly
	{
		get
		{
			return eTradeOnly;
		}
		set
		{
			eTradeOnly = value;
		}
	}

	public bool FirmQuoteOnly
	{
		get
		{
			return firmQuoteOnly;
		}
		set
		{
			firmQuoteOnly = value;
		}
	}

	public double NbboPriceCap
	{
		get
		{
			return nbboPriceCap;
		}
		set
		{
			nbboPriceCap = value;
		}
	}

	public bool OptOutSmartRouting
	{
		get
		{
			return optOutSmartRouting;
		}
		set
		{
			optOutSmartRouting = value;
		}
	}

	public int AuctionStrategy
	{
		get
		{
			return auctionStrategy;
		}
		set
		{
			auctionStrategy = value;
		}
	}

	public double StartingPrice
	{
		get
		{
			return startingPrice;
		}
		set
		{
			startingPrice = value;
		}
	}

	public double StockRefPrice
	{
		get
		{
			return stockRefPrice;
		}
		set
		{
			stockRefPrice = value;
		}
	}

	public double Delta
	{
		get
		{
			return delta;
		}
		set
		{
			delta = value;
		}
	}

	public double StockRangeLower
	{
		get
		{
			return stockRangeLower;
		}
		set
		{
			stockRangeLower = value;
		}
	}

	public double StockRangeUpper
	{
		get
		{
			return stockRangeUpper;
		}
		set
		{
			stockRangeUpper = value;
		}
	}

	public double Volatility
	{
		get
		{
			return volatility;
		}
		set
		{
			volatility = value;
		}
	}

	public int VolatilityType
	{
		get
		{
			return volatilityType;
		}
		set
		{
			volatilityType = value;
		}
	}

	public int ContinuousUpdate
	{
		get
		{
			return continuousUpdate;
		}
		set
		{
			continuousUpdate = value;
		}
	}

	public int ReferencePriceType
	{
		get
		{
			return referencePriceType;
		}
		set
		{
			referencePriceType = value;
		}
	}

	public string DeltaNeutralOrderType
	{
		get
		{
			return deltaNeutralOrderType;
		}
		set
		{
			deltaNeutralOrderType = value;
		}
	}

	public double DeltaNeutralAuxPrice
	{
		get
		{
			return deltaNeutralAuxPrice;
		}
		set
		{
			deltaNeutralAuxPrice = value;
		}
	}

	public int DeltaNeutralConId
	{
		get
		{
			return deltaNeutralConId;
		}
		set
		{
			deltaNeutralConId = value;
		}
	}

	public string DeltaNeutralSettlingFirm
	{
		get
		{
			return deltaNeutralSettlingFirm;
		}
		set
		{
			deltaNeutralSettlingFirm = value;
		}
	}

	public string DeltaNeutralClearingAccount
	{
		get
		{
			return deltaNeutralClearingAccount;
		}
		set
		{
			deltaNeutralClearingAccount = value;
		}
	}

	public string DeltaNeutralClearingIntent
	{
		get
		{
			return deltaNeutralClearingIntent;
		}
		set
		{
			deltaNeutralClearingIntent = value;
		}
	}

	public string DeltaNeutralOpenClose
	{
		get
		{
			return deltaNeutralOpenClose;
		}
		set
		{
			deltaNeutralOpenClose = value;
		}
	}

	public bool DeltaNeutralShortSale
	{
		get
		{
			return deltaNeutralShortSale;
		}
		set
		{
			deltaNeutralShortSale = value;
		}
	}

	public int DeltaNeutralShortSaleSlot
	{
		get
		{
			return deltaNeutralShortSaleSlot;
		}
		set
		{
			deltaNeutralShortSaleSlot = value;
		}
	}

	public string DeltaNeutralDesignatedLocation
	{
		get
		{
			return deltaNeutralDesignatedLocation;
		}
		set
		{
			deltaNeutralDesignatedLocation = value;
		}
	}

	public double BasisPoints
	{
		get
		{
			return basisPoints;
		}
		set
		{
			basisPoints = value;
		}
	}

	public int BasisPointsType
	{
		get
		{
			return basisPointsType;
		}
		set
		{
			basisPointsType = value;
		}
	}

	public int ScaleInitLevelSize
	{
		get
		{
			return scaleInitLevelSize;
		}
		set
		{
			scaleInitLevelSize = value;
		}
	}

	public int ScaleSubsLevelSize
	{
		get
		{
			return scaleSubsLevelSize;
		}
		set
		{
			scaleSubsLevelSize = value;
		}
	}

	public double ScalePriceIncrement
	{
		get
		{
			return scalePriceIncrement;
		}
		set
		{
			scalePriceIncrement = value;
		}
	}

	public double ScalePriceAdjustValue
	{
		get
		{
			return scalePriceAdjustValue;
		}
		set
		{
			scalePriceAdjustValue = value;
		}
	}

	public int ScalePriceAdjustInterval
	{
		get
		{
			return scalePriceAdjustInterval;
		}
		set
		{
			scalePriceAdjustInterval = value;
		}
	}

	public double ScaleProfitOffset
	{
		get
		{
			return scaleProfitOffset;
		}
		set
		{
			scaleProfitOffset = value;
		}
	}

	public bool ScaleAutoReset
	{
		get
		{
			return scaleAutoReset;
		}
		set
		{
			scaleAutoReset = value;
		}
	}

	public int ScaleInitPosition
	{
		get
		{
			return scaleInitPosition;
		}
		set
		{
			scaleInitPosition = value;
		}
	}

	public int ScaleInitFillQty
	{
		get
		{
			return scaleInitFillQty;
		}
		set
		{
			scaleInitFillQty = value;
		}
	}

	public bool ScaleRandomPercent
	{
		get
		{
			return scaleRandomPercent;
		}
		set
		{
			scaleRandomPercent = value;
		}
	}

	public string HedgeType
	{
		get
		{
			return hedgeType;
		}
		set
		{
			hedgeType = value;
		}
	}

	public string HedgeParam
	{
		get
		{
			return hedgeParam;
		}
		set
		{
			hedgeParam = value;
		}
	}

	public string Account
	{
		get
		{
			return account;
		}
		set
		{
			account = value;
		}
	}

	public string SettlingFirm
	{
		get
		{
			return settlingFirm;
		}
		set
		{
			settlingFirm = value;
		}
	}

	public string ClearingAccount
	{
		get
		{
			return clearingAccount;
		}
		set
		{
			clearingAccount = value;
		}
	}

	public string ClearingIntent
	{
		get
		{
			return clearingIntent;
		}
		set
		{
			clearingIntent = value;
		}
	}

	public string AlgoStrategy
	{
		get
		{
			return algoStrategy;
		}
		set
		{
			algoStrategy = value;
		}
	}

	public List<YTRgdjGrspdQ4JAkykFO> AlgoParams
	{
		get
		{
			return algoParams;
		}
		set
		{
			algoParams = value;
		}
	}

	public bool WhatIf
	{
		get
		{
			return whatIf;
		}
		set
		{
			whatIf = value;
		}
	}

	public string AlgoId
	{
		get
		{
			return algoId;
		}
		set
		{
			algoId = value;
		}
	}

	public bool NotHeld
	{
		get
		{
			return notHeld;
		}
		set
		{
			notHeld = value;
		}
	}

	public List<YTRgdjGrspdQ4JAkykFO> SmartComboRoutingParams
	{
		get
		{
			return smartComboRoutingParams;
		}
		set
		{
			smartComboRoutingParams = value;
		}
	}

	public List<h3wMSrGyIGHqIiIVkxdf> OrderComboLegs
	{
		get
		{
			return orderComboLegs;
		}
		set
		{
			orderComboLegs = value;
		}
	}

	public List<YTRgdjGrspdQ4JAkykFO> OrderMiscOptions
	{
		get
		{
			return orderMiscOptions;
		}
		set
		{
			orderMiscOptions = value;
		}
	}

	public string ActiveStartTime
	{
		get
		{
			return activeStartTime;
		}
		set
		{
			activeStartTime = value;
		}
	}

	public string ActiveStopTime
	{
		get
		{
			return activeStopTime;
		}
		set
		{
			activeStopTime = value;
		}
	}

	public string ScaleTable
	{
		get
		{
			return scaleTable;
		}
		set
		{
			scaleTable = value;
		}
	}

	public string ModelCode
	{
		get
		{
			return modelCode;
		}
		set
		{
			modelCode = value;
		}
	}

	public string ExtOperator
	{
		get
		{
			return extOperator;
		}
		set
		{
			extOperator = value;
		}
	}

	public double CashQty
	{
		get
		{
			return cashQty;
		}
		set
		{
			cashQty = value;
		}
	}

	public string Mifid2DecisionMaker { get; set; }

	public string Mifid2DecisionAlgo { get; set; }

	public string Mifid2ExecutionTrader { get; set; }

	public string Mifid2ExecutionAlgo { get; set; }

	public bool DontUseAutoPriceForHedge
	{
		get
		{
			return dontUseAutoPriceForHedge;
		}
		set
		{
			dontUseAutoPriceForHedge = value;
		}
	}

	public string AutoCancelDate
	{
		get
		{
			return autoCancelDate;
		}
		set
		{
			autoCancelDate = value;
		}
	}

	public double FilledQuantity
	{
		get
		{
			return filledQuantity;
		}
		set
		{
			filledQuantity = value;
		}
	}

	public int RefFuturesConId
	{
		get
		{
			return refFuturesConId;
		}
		set
		{
			refFuturesConId = value;
		}
	}

	public bool AutoCancelParent
	{
		get
		{
			return autoCancelParent;
		}
		set
		{
			autoCancelParent = value;
		}
	}

	public string Shareholder
	{
		get
		{
			return shareholder;
		}
		set
		{
			shareholder = value;
		}
	}

	public bool ImbalanceOnly
	{
		get
		{
			return imbalanceOnly;
		}
		set
		{
			imbalanceOnly = value;
		}
	}

	public bool RouteMarketableToBbo
	{
		get
		{
			return routeMarketableToBbo;
		}
		set
		{
			routeMarketableToBbo = value;
		}
	}

	public long ParentPermId
	{
		get
		{
			return parentPermId;
		}
		set
		{
			parentPermId = value;
		}
	}

	public bool RandomizeSize { get; set; }

	public bool RandomizePrice { get; set; }

	public int ReferenceContractId { get; set; }

	public bool IsPeggedChangeAmountDecrease { get; set; }

	public double PeggedChangeAmount { get; set; }

	public double ReferenceChangeAmount { get; set; }

	public string ReferenceExchange { get; set; }

	public string AdjustedOrderType { get; set; }

	public double TriggerPrice { get; set; }

	public double LmtPriceOffset { get; set; }

	public double AdjustedStopPrice { get; set; }

	public double AdjustedStopLimitPrice { get; set; }

	public double AdjustedTrailingAmount { get; set; }

	public int AdjustableTrailingUnit { get; set; }

	public List<QdiLj9GyViRcymtjAeXQ> Conditions { get; set; }

	public bool ConditionsIgnoreRth { get; set; }

	public bool ConditionsCancelOrder { get; set; }

	public coJdb1Gr4tHxGkGHsRSX Tier { get; set; }

	public bool IsOmsContainer { get; set; }

	public bool DiscretionaryUpToLimitPrice { get; set; }

	public bool? UsePriceMgmtAlgo { get; set; }

	public Order()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		orderComboLegs = new List<h3wMSrGyIGHqIiIVkxdf>();
		orderMiscOptions = new List<YTRgdjGrspdQ4JAkykFO>();
		base._002Ector();
		lmtPrice = double.MaxValue;
		int num = 13;
		while (true)
		{
			int num2;
			switch (num)
			{
			case 15:
				deltaNeutralClearingAccount = EMPTY_STR;
				deltaNeutralClearingIntent = EMPTY_STR;
				num = 12;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 != 0)
				{
					num = 0;
				}
				break;
			case 3:
				exemptCode = -1;
				num = 9;
				break;
			case 11:
				stockRangeUpper = double.MaxValue;
				num = 27;
				break;
			case 21:
				activeStopTime = EMPTY_STR;
				num = 17;
				break;
			case 2:
				deltaNeutralShortSale = false;
				num = 16;
				break;
			case 31:
				scalePriceAdjustValue = double.MaxValue;
				scalePriceAdjustInterval = int.MaxValue;
				scaleProfitOffset = double.MaxValue;
				scaleAutoReset = false;
				num = 8;
				break;
			case 4:
				deltaNeutralOrderType = EMPTY_STR;
				deltaNeutralAuxPrice = double.MaxValue;
				num = 26;
				break;
			case 23:
				routeMarketableToBbo = false;
				parentPermId = long.MaxValue;
				UsePriceMgmtAlgo = null;
				num = 7;
				break;
			case 12:
				deltaNeutralOpenClose = EMPTY_STR;
				num = 2;
				break;
			case 18:
				Mifid2DecisionMaker = EMPTY_STR;
				Mifid2DecisionAlgo = EMPTY_STR;
				Mifid2ExecutionTrader = EMPTY_STR;
				Mifid2ExecutionAlgo = EMPTY_STR;
				dontUseAutoPriceForHedge = false;
				autoCancelDate = EMPTY_STR;
				num = 10;
				break;
			case 14:
				stockRefPrice = double.MaxValue;
				delta = double.MaxValue;
				stockRangeLower = double.MaxValue;
				num2 = 11;
				goto IL_003a;
			case 1:
				AdjustedTrailingAmount = double.MaxValue;
				ExtOperator = EMPTY_STR;
				num = 22;
				break;
			case 29:
				scaleRandomPercent = false;
				scaleTable = EMPTY_STR;
				whatIf = false;
				notHeld = false;
				Conditions = new List<QdiLj9GyViRcymtjAeXQ>();
				num = 32;
				break;
			case 28:
				refFuturesConId = int.MaxValue;
				autoCancelParent = false;
				num = 5;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d != 0)
				{
					num = 6;
				}
				break;
			case 5:
				designatedLocation = EMPTY_STR;
				num = 3;
				break;
			case 24:
				activeStartTime = EMPTY_STR;
				num = 21;
				break;
			case 9:
				minQty = int.MaxValue;
				num = 30;
				break;
			case 10:
				filledQuantity = double.MaxValue;
				num = 28;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 != 0)
				{
					num = 18;
				}
				break;
			case 7:
				return;
			case 20:
				startingPrice = double.MaxValue;
				num = 11;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_67356183f8464ca6962cfffbcb53813d != 0)
				{
					num = 14;
				}
				break;
			case 27:
				volatility = double.MaxValue;
				volatilityType = int.MaxValue;
				num = 4;
				break;
			case 30:
				percentOffset = double.MaxValue;
				nbboPriceCap = double.MaxValue;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
				{
					num = 0;
				}
				break;
			case 26:
				deltaNeutralConId = 0;
				deltaNeutralSettlingFirm = EMPTY_STR;
				num2 = 15;
				goto IL_003a;
			case 6:
				shareholder = EMPTY_STR;
				imbalanceOnly = false;
				num = 23;
				break;
			case 8:
				scaleInitPosition = int.MaxValue;
				scaleInitFillQty = int.MaxValue;
				num = 29;
				break;
			case 32:
				TriggerPrice = double.MaxValue;
				LmtPriceOffset = double.MaxValue;
				AdjustedStopPrice = double.MaxValue;
				num = 5;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 != 0)
				{
					num = 19;
				}
				break;
			case 19:
				AdjustedStopLimitPrice = double.MaxValue;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 != 0)
				{
					num = 1;
				}
				break;
			case 17:
				outsideRth = false;
				openClose = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1841489831 ^ -1841459623);
				origin = CUSTOMER;
				num = 25;
				break;
			case 13:
				auxPrice = double.MaxValue;
				num2 = 24;
				goto IL_003a;
			default:
				optOutSmartRouting = false;
				num = 20;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac != 0)
				{
					num = 12;
				}
				break;
			case 16:
				deltaNeutralShortSaleSlot = 0;
				deltaNeutralDesignatedLocation = EMPTY_STR;
				referencePriceType = int.MaxValue;
				trailStopPrice = double.MaxValue;
				trailingPercent = double.MaxValue;
				basisPoints = double.MaxValue;
				basisPointsType = int.MaxValue;
				scaleInitLevelSize = int.MaxValue;
				scaleSubsLevelSize = int.MaxValue;
				scalePriceIncrement = double.MaxValue;
				num = 14;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 != 0)
				{
					num = 31;
				}
				break;
			case 25:
				transmit = true;
				num = 5;
				break;
			case 22:
				{
					Tier = new coJdb1Gr4tHxGkGHsRSX(EMPTY_STR, EMPTY_STR, EMPTY_STR);
					cashQty = double.MaxValue;
					num = 18;
					break;
				}
				IL_003a:
				num = num2;
				break;
			}
		}
	}

	public override bool Equals(object p_other)
	{
		if (this == p_other)
		{
			return true;
		}
		int num;
		Order order = default(Order);
		if (p_other == null)
		{
			num = 39;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
			{
				num = 33;
			}
		}
		else
		{
			order = (Order)p_other;
			if (PermId == order.PermId)
			{
				return true;
			}
			if (OrderId != order.OrderId)
			{
				goto IL_0d16;
			}
			num = 25;
		}
		bool? usePriceMgmtAlgo2 = default(bool?);
		bool? usePriceMgmtAlgo = default(bool?);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 6:
				if (WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(DeltaNeutralSettlingFirm, order.DeltaNeutralSettlingFirm) == 0 && vnmJFn5qQtRBcOBBsTTn(DeltaNeutralClearingAccount, order.DeltaNeutralClearingAccount) == 0)
				{
					num = 10;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
					{
						num = 9;
					}
					continue;
				}
				goto case 9;
			case 38:
				if (ConditionsCancelOrder == PQtOm35qccexJeAwYUO1(order))
				{
					num = 54;
					continue;
				}
				break;
			case 41:
				if (ScaleSubsLevelSize == order.ScaleSubsLevelSize)
				{
					num = 34;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 == 0)
					{
						num = 7;
					}
					continue;
				}
				break;
			case 7:
				if (WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(AlgoStrategy, order.AlgoStrategy) == 0 && WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(AlgoId, order.AlgoId) == 0 && WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(ScaleTable, (string)cXUfDN5qI8SnBkYhAnXt(order)) == 0 && WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(ModelCode, order.ModelCode) == 0 && WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(ExtOperator, order.ExtOperator) == 0 && WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(AutoCancelDate, order.AutoCancelDate) == 0)
				{
					num2 = 40;
					goto IL_0005;
				}
				goto case 9;
			case 53:
				if (OverridePercentageConstraints != ej6U7n5qv0f7QGs0ZQT9(order) || AllOrNone != order.AllOrNone || MinQty != HyLFZC5qBqX6uN9KM6Jj(order) || PercentOffset != order.PercentOffset || TrailStopPrice != order.TrailStopPrice)
				{
					break;
				}
				num2 = 27;
				goto IL_0005;
			case 29:
				if (ScaleRandomPercent == order.ScaleRandomPercent && WhatIf == order.WhatIf)
				{
					num = 16;
					continue;
				}
				break;
			case 20:
				if (vnmJFn5qQtRBcOBBsTTn(DeltaNeutralDesignatedLocation, UjTh8B5qOqQa789EQL3r(order)) == 0 && WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(HedgeType, order.HedgeType) == 0 && WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(HedgeParam, order.HedgeParam) == 0)
				{
					num = 13;
					continue;
				}
				goto case 9;
			case 1:
				if (ScaleInitLevelSize == order.ScaleInitLevelSize)
				{
					num = 41;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 != 0)
					{
						num = 12;
					}
					continue;
				}
				break;
			case 15:
				if (RefFuturesConId != order.RefFuturesConId)
				{
					break;
				}
				num2 = 26;
				goto IL_0005;
			case 5:
				if (DisplaySize == order.DisplaySize)
				{
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 == 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			case 32:
				return false;
			case 54:
				if (Tier != order.Tier)
				{
					num = 12;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 == 0)
					{
						num = 50;
					}
					continue;
				}
				if (CashQty == order.CashQty)
				{
					num = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
					{
						num = 45;
					}
					continue;
				}
				break;
			case 31:
				if (DeltaNeutralShortSaleSlot == order.DeltaNeutralShortSaleSlot)
				{
					num = 11;
					continue;
				}
				break;
			case 27:
				if (TrailingPercent == order.TrailingPercent)
				{
					num = 21;
					continue;
				}
				break;
			case 46:
				if (ScalePriceAdjustValue == order.ScalePriceAdjustValue && ScalePriceAdjustInterval == order.ScalePriceAdjustInterval && ScaleProfitOffset == order.ScaleProfitOffset && ScaleAutoReset == order.ScaleAutoReset && ScaleInitPosition == UQQuAu5qeLa8e3M12rue(order) && ScaleInitFillQty == order.ScaleInitFillQty)
				{
					num = 29;
					continue;
				}
				break;
			case 2:
				if (ContinuousUpdate == SfoemA5qkKuxvdR4NMyU(order))
				{
					num = 51;
					continue;
				}
				break;
			case 44:
				if (WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(DeltaNeutralOrderType, (string)U5maMU5q6SKDOPedyqIh(order)) == 0)
				{
					num = 6;
					continue;
				}
				goto case 9;
			case 9:
			case 22:
			case 23:
			case 37:
			case 48:
				return false;
			case 16:
				if (NotHeld == order.NotHeld && ExemptCode == order.ExemptCode && RandomizePrice == order.RandomizePrice && RandomizeSize == Y6gKy25qsgbEUDeQNE81(order) && Solicited == order.Solicited && ConditionsIgnoreRth == wS6D9k5qX8bnef01Q4Bi(order))
				{
					num = 36;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2eeb07b76a6b47ee89babb98850d4c1d == 0)
					{
						num = 38;
					}
					continue;
				}
				break;
			case 4:
				if (WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(DesignatedLocation, order.DesignatedLocation) == 0)
				{
					goto case 44;
				}
				goto case 9;
			case 30:
				if (Transmit != order.Transmit || ParentId != order.ParentId || BlockOrder != order.BlockOrder || SweepToFill != rwx5Hq5qGGobHxgrKMak(order))
				{
					break;
				}
				num2 = 5;
				goto IL_0005;
			case 45:
				if (dontUseAutoPriceForHedge == order.dontUseAutoPriceForHedge)
				{
					num = 23;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c != 0)
					{
						num = 24;
					}
					continue;
				}
				break;
			case 12:
				if (WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(ActiveStopTime, (string)xy0xGW5qgxeE8ePiJVkP(order)) == 0)
				{
					if (vnmJFn5qQtRBcOBBsTTn(OcaGroup, order.OcaGroup) != 0)
					{
						num = 7;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f == 0)
						{
							num = 9;
						}
						continue;
					}
					if (WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(OrderRef, order.OrderRef) != 0)
					{
						num = 11;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
						{
							num = 37;
						}
						continue;
					}
					if (vnmJFn5qQtRBcOBBsTTn(GoodAfterTime, order.GoodAfterTime) == 0 && WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(GoodTillDate, (string)wMQSFA5qRZo7VDUKy3yi(order)) == 0)
					{
						num = 17;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e == 0)
						{
							num = 17;
						}
						continue;
					}
				}
				goto case 9;
			case 3:
				usePriceMgmtAlgo2 = order.UsePriceMgmtAlgo;
				num = 8;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
				{
					num = 43;
				}
				continue;
			case 10:
				if (WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(DeltaNeutralClearingIntent, order.DeltaNeutralClearingIntent) == 0 && WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(DeltaNeutralOpenClose, (string)oTU33H5qMCOpQFYK4TPE(order)) == 0)
				{
					num = 20;
					continue;
				}
				goto case 9;
			case 14:
				if (StockRangeUpper == Hv4dHD5qNQAmrH3aIc0R(order))
				{
					num = 8;
					continue;
				}
				break;
			case 8:
				if (Volatility == order.Volatility && VolatilityType == order.VolatilityType)
				{
					num = 2;
					continue;
				}
				break;
			case 13:
				if (WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(Account, order.Account) == 0 && WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(SettlingFirm, (string)MNFmcE5qqs82VHu6hOwi(order)) == 0)
				{
					if (WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(ClearingAccount, order.ClearingAccount) != 0)
					{
						num = 23;
						continue;
					}
					if (WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(ClearingIntent, order.ClearingIntent) == 0)
					{
						num = 7;
						continue;
					}
				}
				goto case 9;
			case 17:
				if (vnmJFn5qQtRBcOBBsTTn(Rule80A, order.Rule80A) != 0 || WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(FaGroup, order.FaGroup) != 0 || WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(FaProfile, order.FaProfile) != 0 || WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(FaMethod, order.FaMethod) != 0 || vnmJFn5qQtRBcOBBsTTn(FaPercentage, order.FaPercentage) != 0)
				{
					goto case 9;
				}
				if (vnmJFn5qQtRBcOBBsTTn(OpenClose, order.OpenClose) != 0)
				{
					num = 48;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d != 0)
					{
						num = 40;
					}
					continue;
				}
				goto case 4;
			case 52:
				if (DiscretionaryAmt == order.DiscretionaryAmt && ETradeOnly == kvkTLH5qiBiXWX6KukkS(order) && FirmQuoteOnly == syurRj5qlf1w1ru44n1h(order) && NbboPriceCap == order.NbboPriceCap && OptOutSmartRouting == y5ZLwo5q423PSjY5hGBT(order) && AuctionStrategy == order.AuctionStrategy)
				{
					num = 28;
					continue;
				}
				break;
			case 43:
				if (usePriceMgmtAlgo == usePriceMgmtAlgo2)
				{
					num = 29;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 == 0)
					{
						num = 49;
					}
					continue;
				}
				break;
			case 33:
				if (OcaType == order.OcaType)
				{
					num = 30;
					continue;
				}
				break;
			case 26:
				if (AutoCancelParent != order.AutoCancelParent)
				{
					break;
				}
				num2 = 35;
				goto IL_0005;
			case 40:
				if (vnmJFn5qQtRBcOBBsTTn(Shareholder, SSH02U5qW7Hm0FOq79JS(order)) == 0)
				{
					if (!WuQIpZGmPv6pcTlVZRTj.cOdGmziJtOt(AlgoParams, order.AlgoParams))
					{
						return false;
					}
					if (!WuQIpZGmPv6pcTlVZRTj.cOdGmziJtOt(SmartComboRoutingParams, order.SmartComboRoutingParams))
					{
						return false;
					}
					if (WuQIpZGmPv6pcTlVZRTj.cOdGmziJtOt(OrderComboLegs, order.OrderComboLegs))
					{
						return true;
					}
					num = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca == 0)
					{
						num = 32;
					}
					continue;
				}
				goto case 9;
			case 28:
				if (StartingPrice == order.StartingPrice && StockRefPrice == order.StockRefPrice && Delta == CD27d15qDt8D9UkIp20K(order) && StockRangeLower == hUVAmF5qbjtckKkUViho(order))
				{
					num = 14;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f == 0)
					{
						num = 14;
					}
					continue;
				}
				break;
			case 49:
				if (FilledQuantity == qNIhQj5qEVXSrpuOE7uy(order))
				{
					num = 15;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c != 0)
					{
						num = 2;
					}
					continue;
				}
				break;
			case 11:
				if (BasisPoints == VXGEvn5qxiJt7SxCBv60(order) && BasisPointsType == order.BasisPointsType)
				{
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee != 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			case 35:
				if (ImbalanceOnly == order.ImbalanceOnly)
				{
					num = 25;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e == 0)
					{
						num = 47;
					}
					continue;
				}
				break;
			case 24:
				if (IsOmsContainer == L1gn6b5qjk2Hd846Fcdm(order))
				{
					num = 19;
					continue;
				}
				break;
			case 51:
				if (ReferencePriceType == order.ReferencePriceType)
				{
					num = 42;
					continue;
				}
				break;
			default:
				if (TriggerMethod != TEofe75qY8wqkkDx3kNS(order) || OutsideRth != order.OutsideRth || Hidden != TF7RNF5qowG6sM2TKaLR(order))
				{
					break;
				}
				num2 = 53;
				goto IL_0005;
			case 39:
				return false;
			case 36:
				if (DeltaNeutralShortSale == lSBsou5qSHgPV6Z2X4UC(order))
				{
					num = 31;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
					{
						num = 12;
					}
					continue;
				}
				break;
			case 18:
			case 50:
				break;
			case 25:
				if (ClientId == xGgjEV5qnS77QOU7CCF3(order) && TotalQuantity == order.TotalQuantity && LmtPrice == order.LmtPrice && AuxPrice == order.AuxPrice)
				{
					num = 33;
					continue;
				}
				break;
			case 34:
				if (ScalePriceIncrement == gjPm3X5qL02SXR34UHjt(order))
				{
					num = 46;
					continue;
				}
				break;
			case 21:
				if (Origin == RKoiwu5qa4ist26erEdx(order) && ShortSaleSlot == order.ShortSaleSlot)
				{
					num = 52;
					continue;
				}
				break;
			case 19:
				usePriceMgmtAlgo = UsePriceMgmtAlgo;
				num = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 != 0)
				{
					num = 3;
				}
				continue;
			case 47:
				if (RouteMarketableToBbo != order.RouteMarketableToBbo)
				{
					break;
				}
				if (ParentPermId != order.ParentPermId)
				{
					num = 18;
					continue;
				}
				if (WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(Action, order.Action) == 0 && vnmJFn5qQtRBcOBBsTTn(OrderType, order.OrderType) == 0 && WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(Tif, (string)lptnSj5qdeNXTlngaT1t(order)) == 0 && WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP(ActiveStartTime, order.ActiveStartTime) == 0)
				{
					num = 12;
					continue;
				}
				goto case 9;
			case 42:
				{
					if (DeltaNeutralAuxPrice == i0l5DG5q1MEs3H5HBT2N(order) && DeltaNeutralConId == ghKq2n5q5YoeHawMqkgc(order))
					{
						num = 36;
						continue;
					}
					break;
				}
				IL_0005:
				num = num2;
				continue;
			}
			break;
		}
		goto IL_0d16;
		IL_0d16:
		return false;
	}

	static Order()
	{
		oYDaK25qtrrmc6g9AiUP();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 2:
				OPT_CUSTOMER = 'c';
				OPT_FIRM = 'f';
				OPT_ISEMM = 'm';
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 == 0)
				{
					num = 0;
				}
				break;
			default:
				OPT_FARMM = 'n';
				OPT_SPECIALIST = 'y';
				num = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 == 0)
				{
					num = 5;
				}
				break;
			case 1:
			{
				OPT_UNKNOWN = '?';
				int num2 = 6;
				num = num2;
				break;
			}
			case 5:
				AUCTION_MATCH = 1;
				AUCTION_IMPROVEMENT = 2;
				AUCTION_TRANSPARENT = 3;
				EMPTY_STR = "";
				return;
			case 6:
				OPT_BROKER_DEALER = 'b';
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
				{
					num = 1;
				}
				break;
			case 4:
				itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
				num = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 != 0)
				{
					num = 2;
				}
				break;
			case 3:
				CUSTOMER = 0;
				FIRM = 1;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static bool WgyY4b5qfso2DjHgl6RS()
	{
		return R4cIaL5qHawqIF87BbgD == null;
	}

	internal static Order jcjUFy5q9w6VCWbHhpX2()
	{
		return R4cIaL5qHawqIF87BbgD;
	}

	internal static int xGgjEV5qnS77QOU7CCF3(object P_0)
	{
		return ((Order)P_0).ClientId;
	}

	internal static bool rwx5Hq5qGGobHxgrKMak(object P_0)
	{
		return ((Order)P_0).SweepToFill;
	}

	internal static int TEofe75qY8wqkkDx3kNS(object P_0)
	{
		return ((Order)P_0).TriggerMethod;
	}

	internal static bool TF7RNF5qowG6sM2TKaLR(object P_0)
	{
		return ((Order)P_0).Hidden;
	}

	internal static bool ej6U7n5qv0f7QGs0ZQT9(object P_0)
	{
		return ((Order)P_0).OverridePercentageConstraints;
	}

	internal static int HyLFZC5qBqX6uN9KM6Jj(object P_0)
	{
		return ((Order)P_0).MinQty;
	}

	internal static int RKoiwu5qa4ist26erEdx(object P_0)
	{
		return ((Order)P_0).Origin;
	}

	internal static bool kvkTLH5qiBiXWX6KukkS(object P_0)
	{
		return ((Order)P_0).ETradeOnly;
	}

	internal static bool syurRj5qlf1w1ru44n1h(object P_0)
	{
		return ((Order)P_0).FirmQuoteOnly;
	}

	internal static bool y5ZLwo5q423PSjY5hGBT(object P_0)
	{
		return ((Order)P_0).OptOutSmartRouting;
	}

	internal static double CD27d15qDt8D9UkIp20K(object P_0)
	{
		return ((Order)P_0).Delta;
	}

	internal static double hUVAmF5qbjtckKkUViho(object P_0)
	{
		return ((Order)P_0).StockRangeLower;
	}

	internal static double Hv4dHD5qNQAmrH3aIc0R(object P_0)
	{
		return ((Order)P_0).StockRangeUpper;
	}

	internal static int SfoemA5qkKuxvdR4NMyU(object P_0)
	{
		return ((Order)P_0).ContinuousUpdate;
	}

	internal static double i0l5DG5q1MEs3H5HBT2N(object P_0)
	{
		return ((Order)P_0).DeltaNeutralAuxPrice;
	}

	internal static int ghKq2n5q5YoeHawMqkgc(object P_0)
	{
		return ((Order)P_0).DeltaNeutralConId;
	}

	internal static bool lSBsou5qSHgPV6Z2X4UC(object P_0)
	{
		return ((Order)P_0).DeltaNeutralShortSale;
	}

	internal static double VXGEvn5qxiJt7SxCBv60(object P_0)
	{
		return ((Order)P_0).BasisPoints;
	}

	internal static double gjPm3X5qL02SXR34UHjt(object P_0)
	{
		return ((Order)P_0).ScalePriceIncrement;
	}

	internal static int UQQuAu5qeLa8e3M12rue(object P_0)
	{
		return ((Order)P_0).ScaleInitPosition;
	}

	internal static bool Y6gKy25qsgbEUDeQNE81(object P_0)
	{
		return ((Order)P_0).RandomizeSize;
	}

	internal static bool wS6D9k5qX8bnef01Q4Bi(object P_0)
	{
		return ((Order)P_0).ConditionsIgnoreRth;
	}

	internal static bool PQtOm35qccexJeAwYUO1(object P_0)
	{
		return ((Order)P_0).ConditionsCancelOrder;
	}

	internal static bool L1gn6b5qjk2Hd846Fcdm(object P_0)
	{
		return ((Order)P_0).IsOmsContainer;
	}

	internal static double qNIhQj5qEVXSrpuOE7uy(object P_0)
	{
		return ((Order)P_0).FilledQuantity;
	}

	internal static int vnmJFn5qQtRBcOBBsTTn(object P_0, object P_1)
	{
		return WuQIpZGmPv6pcTlVZRTj.KYxGmpVu8dP((string)P_0, (string)P_1);
	}

	internal static object lptnSj5qdeNXTlngaT1t(object P_0)
	{
		return ((Order)P_0).Tif;
	}

	internal static object xy0xGW5qgxeE8ePiJVkP(object P_0)
	{
		return ((Order)P_0).ActiveStopTime;
	}

	internal static object wMQSFA5qRZo7VDUKy3yi(object P_0)
	{
		return ((Order)P_0).GoodTillDate;
	}

	internal static object U5maMU5q6SKDOPedyqIh(object P_0)
	{
		return ((Order)P_0).DeltaNeutralOrderType;
	}

	internal static object oTU33H5qMCOpQFYK4TPE(object P_0)
	{
		return ((Order)P_0).DeltaNeutralOpenClose;
	}

	internal static object UjTh8B5qOqQa789EQL3r(object P_0)
	{
		return ((Order)P_0).DeltaNeutralDesignatedLocation;
	}

	internal static object MNFmcE5qqs82VHu6hOwi(object P_0)
	{
		return ((Order)P_0).SettlingFirm;
	}

	internal static object cXUfDN5qI8SnBkYhAnXt(object P_0)
	{
		return ((Order)P_0).ScaleTable;
	}

	internal static object SSH02U5qW7Hm0FOq79JS(object P_0)
	{
		return ((Order)P_0).Shareholder;
	}

	internal static void oYDaK25qtrrmc6g9AiUP()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
