using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.Editors;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
public class Resources
{
	private static ResourceManager TuT;

	private static CultureInfo fuI;

	private static Resources HAU;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static ResourceManager ResourceManager
	{
		get
		{
			if (TuT == null)
			{
				ResourceManager tuT = new ResourceManager("ActiproSoftware.Products.Editors.Resources", typeof(Resources).Assembly);
				TuT = tuT;
			}
			return TuT;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public static CultureInfo Culture
	{
		get
		{
			return fuI;
		}
		set
		{
			fuI = value;
		}
	}

	public static string ExIntervalsDoNotIntersect => ResourceManager.GetString(QdM.AR8(30424), fuI);

	public static string ExInvalidEncodedCharacter => ResourceManager.GetString(QdM.AR8(30478), fuI);

	public static string ExInvalidRegexNodeType => ResourceManager.GetString(QdM.AR8(30532), fuI);

	public static string ExInvalidRegexOpCode => ResourceManager.GetString(QdM.AR8(30580), fuI);

	public static string ExInvalidUnicodeCategoryName => ResourceManager.GetString(QdM.AR8(30624), fuI);

	public static string ExRegexParserEmptyQuotedString => ResourceManager.GetString(QdM.AR8(30684), fuI);

	public static string ExRegexParserInvalidRangeCharacter => ResourceManager.GetString(QdM.AR8(30748), fuI);

	public static string ExRegexParserInvalidSubstitutionGroupNumber => ResourceManager.GetString(QdM.AR8(30820), fuI);

	public static string ExRegexParserNoLeftExpressionForBarOperand => ResourceManager.GetString(QdM.AR8(30910), fuI);

	public static string ExRegexParserNoRangeMinimum => ResourceManager.GetString(QdM.AR8(30998), fuI);

	public static string ExRegexParserNoRegularExpression => ResourceManager.GetString(QdM.AR8(31056), fuI);

	public static string ExRegexParserOpenCurlyBraceExpected => ResourceManager.GetString(QdM.AR8(31124), fuI);

	public static string ExRegexParserUnexpectedCharClassEnd => ResourceManager.GetString(QdM.AR8(31198), fuI);

	public static string ExRegexParserUnexpectedGroupingConstructEnd => ResourceManager.GetString(QdM.AR8(31272), fuI);

	public static string ExRegexParserUnexpectedLookBehindConstructEnd => ResourceManager.GetString(QdM.AR8(31362), fuI);

	public static string ExRegexParserUnexpectedMacroReferenceEnd => ResourceManager.GetString(QdM.AR8(31456), fuI);

	public static string ExRegexParserUnexpectedQuotedStringEnd => ResourceManager.GetString(QdM.AR8(31540), fuI);

	public static string ExRegexParserUnknownGroupingConstruct => ResourceManager.GetString(QdM.AR8(31620), fuI);

	public static string UIBrushPickerAddGradientStopButtonToolTip => ResourceManager.GetString(QdM.AR8(31698), fuI);

	public static string UIBrushPickerRemoveGradientStopButtonToolTip => ResourceManager.GetString(QdM.AR8(31784), fuI);

	public static string UIBrushPickerReverseGradientStopsButtonToolTip => ResourceManager.GetString(QdM.AR8(31876), fuI);

	public static string UICalculatorButtonAddText => ResourceManager.GetString(QdM.AR8(31972), fuI);

	public static string UICalculatorButtonAddToMemoryText => ResourceManager.GetString(QdM.AR8(32026), fuI);

	public static string UICalculatorButtonBackspaceText => ResourceManager.GetString(QdM.AR8(32096), fuI);

	public static string UICalculatorButtonCalculateText => ResourceManager.GetString(QdM.AR8(32162), fuI);

	public static string UICalculatorButtonClearEntryText => ResourceManager.GetString(QdM.AR8(32228), fuI);

	public static string UICalculatorButtonClearMemoryText => ResourceManager.GetString(QdM.AR8(32296), fuI);

	public static string UICalculatorButtonClearText => ResourceManager.GetString(QdM.AR8(32366), fuI);

	public static string UICalculatorButtonDecimalSeparatorText => ResourceManager.GetString(QdM.AR8(32424), fuI);

	public static string UICalculatorButtonDigit0Text => ResourceManager.GetString(QdM.AR8(32504), fuI);

	public static string UICalculatorButtonDigit1Text => ResourceManager.GetString(QdM.AR8(32564), fuI);

	public static string UICalculatorButtonDigit2Text => ResourceManager.GetString(QdM.AR8(32624), fuI);

	public static string UICalculatorButtonDigit3Text => ResourceManager.GetString(QdM.AR8(32684), fuI);

	public static string UICalculatorButtonDigit4Text => ResourceManager.GetString(QdM.AR8(32744), fuI);

	public static string UICalculatorButtonDigit5Text => ResourceManager.GetString(QdM.AR8(32804), fuI);

	public static string UICalculatorButtonDigit6Text => ResourceManager.GetString(QdM.AR8(32864), fuI);

	public static string UICalculatorButtonDigit7Text => ResourceManager.GetString(QdM.AR8(32924), fuI);

	public static string UICalculatorButtonDigit8Text => ResourceManager.GetString(QdM.AR8(32984), fuI);

	public static string UICalculatorButtonDigit9Text => ResourceManager.GetString(QdM.AR8(33044), fuI);

	public static string UICalculatorButtonDivideText => ResourceManager.GetString(QdM.AR8(33104), fuI);

	public static string UICalculatorButtonMultiplyText => ResourceManager.GetString(QdM.AR8(33164), fuI);

	public static string UICalculatorButtonPercentText => ResourceManager.GetString(QdM.AR8(33228), fuI);

	public static string UICalculatorButtonRecallMemoryText => ResourceManager.GetString(QdM.AR8(33290), fuI);

	public static string UICalculatorButtonReciprocalText => ResourceManager.GetString(QdM.AR8(33362), fuI);

	public static string UICalculatorButtonSetMemoryText => ResourceManager.GetString(QdM.AR8(33430), fuI);

	public static string UICalculatorButtonSquareRootText => ResourceManager.GetString(QdM.AR8(33496), fuI);

	public static string UICalculatorButtonSubtractFromMemoryText => ResourceManager.GetString(QdM.AR8(33564), fuI);

	public static string UICalculatorButtonSubtractText => ResourceManager.GetString(QdM.AR8(33648), fuI);

	public static string UICalculatorButtonToggleSignText => ResourceManager.GetString(QdM.AR8(33712), fuI);

	public static string UICalendarClearButtonText => ResourceManager.GetString(QdM.AR8(33780), fuI);

	public static string UICalendarTodayButtonText => ResourceManager.GetString(QdM.AR8(33834), fuI);

	public static string UIGradientBrushText => ResourceManager.GetString(QdM.AR8(33888), fuI);

	public static string UINewGuidButtonToolTip => ResourceManager.GetString(QdM.AR8(33930), fuI);

	public static string UIPartEditBoxPlaceholderText => ResourceManager.GetString(QdM.AR8(33978), fuI);

	public static string UISpinnerDecrementButtonToolTip => ResourceManager.GetString(QdM.AR8(34038), fuI);

	public static string UISpinnerIncrementButtonToolTip => ResourceManager.GetString(QdM.AR8(34104), fuI);

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	internal Resources()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool GA9()
	{
		return HAU == null;
	}

	internal static Resources vAM()
	{
		return HAU;
	}
}
