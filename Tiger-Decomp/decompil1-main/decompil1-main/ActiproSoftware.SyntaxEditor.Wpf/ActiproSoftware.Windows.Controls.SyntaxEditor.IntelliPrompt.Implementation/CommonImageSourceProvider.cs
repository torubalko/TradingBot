using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class CommonImageSourceProvider : IImageSourceProvider
{
	private CommonImageSet? vuJ;

	private ImageSource qut;

	private CommonImageKind kuZ;

	private static CommonImageSet Ouh;

	internal static CommonImageSourceProvider Xac;

	public static CommonImageSet DefaultImageSet
	{
		get
		{
			return Ouh;
		}
		set
		{
			Ouh = value;
		}
	}

	public CommonImageKind ImageKind
	{
		get
		{
			return kuZ;
		}
		set
		{
			if (kuZ != value)
			{
				kuZ = value;
				qut = null;
			}
		}
	}

	public CommonImageSourceProvider(CommonImageKind imageKind)
	{
		grA.DaB7cz();
		kuZ = CommonImageKind.Keyword;
		base._002Ector();
		ImageKind = imageKind;
	}

	public ImageSource GetImageSource()
	{
		return GetImageSource(Ouh);
	}

	public ImageSource GetImageSource(Color? backgroundColorHint)
	{
		CommonImageSet ouh = Ouh;
		CommonImageSet commonImageSet = ouh;
		if ((uint)(commonImageSet - 1) <= 1u && backgroundColorHint.HasValue && backgroundColorHint.Value.A > 0)
		{
			if (UIColor.FromColor(backgroundColorHint.Value).IsLight)
			{
				return GetImageSource(CommonImageSet.MetroLight);
			}
			return GetImageSource(CommonImageSet.MetroDark);
		}
		return GetImageSource(Ouh);
	}

	public virtual ImageSource GetImageSource(CommonImageSet imageSet)
	{
		if (qut == null || vuJ != imageSet)
		{
			int num = 1;
			if (xaT() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			Uri uriSource = default(Uri);
			while (true)
			{
				switch (num)
				{
				default:
					qut = new BitmapImage(uriSource);
					ImageProvider.SetCanAdapt(qut, value: false);
					break;
				case 1:
					vuJ = imageSet;
					if (imageSet == CommonImageSet.Classic)
					{
						uriSource = new Uri(ResourceHelper.GetLocationUriString(Assembly.GetExecutingAssembly(), string.Format(CultureInfo.InvariantCulture, Q7Z.tqM(14158), new object[2]
						{
							imageSet.ToString(),
							ImageKind.ToString()
						})));
						num = 0;
						if (!nad())
						{
							num = 0;
						}
						continue;
					}
					qut = BuO(imageSet, ImageKind);
					break;
				}
				break;
			}
			ImageProvider.SetCanAdapt(qut, value: false);
			if (qut.CanFreeze)
			{
				qut.Freeze();
			}
		}
		return qut;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static string HuM(CommonImageKind P_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Q7Z.tqM(14246));
		switch (P_0)
		{
		case CommonImageKind.Assembly:
			stringBuilder.Append(Q7Z.tqM(14676));
			break;
		case CommonImageKind.ClassPrivate:
			stringBuilder.Append(Q7Z.tqM(15764));
			break;
		case CommonImageKind.ClassInternal:
			stringBuilder.Append(Q7Z.tqM(17502));
			break;
		case CommonImageKind.ClassProtected:
			stringBuilder.Append(Q7Z.tqM(19312));
			break;
		case CommonImageKind.ClassPublic:
			stringBuilder.Append(Q7Z.tqM(20616));
			break;
		case CommonImageKind.CodeSnippet:
			stringBuilder.Append(Q7Z.tqM(21344));
			break;
		case CommonImageKind.ConstantPrivate:
			stringBuilder.Append(Q7Z.tqM(23050));
			break;
		case CommonImageKind.ConstantInternal:
			stringBuilder.Append(Q7Z.tqM(24906));
			break;
		case CommonImageKind.ConstantProtected:
			stringBuilder.Append(Q7Z.tqM(26834));
			break;
		case CommonImageKind.ConstantPublic:
			stringBuilder.Append(Q7Z.tqM(28256));
			break;
		case CommonImageKind.DelegatePrivate:
			stringBuilder.Append(Q7Z.tqM(29138));
			break;
		case CommonImageKind.DelegateInternal:
			stringBuilder.Append(Q7Z.tqM(30906));
			break;
		case CommonImageKind.DelegateProtected:
			stringBuilder.Append(Q7Z.tqM(32746));
			break;
		case CommonImageKind.DelegatePublic:
			stringBuilder.Append(Q7Z.tqM(34080));
			break;
		case CommonImageKind.EnumerationItem:
			stringBuilder.Append(Q7Z.tqM(34890));
			break;
		case CommonImageKind.EnumerationPrivate:
			stringBuilder.Append(Q7Z.tqM(35932));
			break;
		case CommonImageKind.EnumerationInternal:
			stringBuilder.Append(Q7Z.tqM(38182));
			break;
		case CommonImageKind.EnumerationProtected:
			stringBuilder.Append(Q7Z.tqM(40504));
			break;
		case CommonImageKind.EnumerationPublic:
			stringBuilder.Append(Q7Z.tqM(42320));
			break;
		case CommonImageKind.EventPrivate:
			stringBuilder.Append(Q7Z.tqM(43612));
			break;
		case CommonImageKind.EventInternal:
			stringBuilder.Append(Q7Z.tqM(45088));
			break;
		case CommonImageKind.EventProtected:
			stringBuilder.Append(Q7Z.tqM(46636));
			break;
		case CommonImageKind.EventPublic:
			stringBuilder.Append(Q7Z.tqM(47678));
			break;
		case CommonImageKind.ExtensionMethodPrivate:
			stringBuilder.Append(Q7Z.tqM(48184));
			break;
		case CommonImageKind.ExtensionMethodInternal:
			stringBuilder.Append(Q7Z.tqM(48184));
			break;
		case CommonImageKind.ExtensionMethodProtected:
			stringBuilder.Append(Q7Z.tqM(48184));
			break;
		case CommonImageKind.ExtensionMethodPublic:
			stringBuilder.Append(Q7Z.tqM(48184));
			break;
		case CommonImageKind.FieldPrivate:
			stringBuilder.Append(Q7Z.tqM(50120));
			break;
		case CommonImageKind.FieldInternal:
			stringBuilder.Append(Q7Z.tqM(51700));
			break;
		case CommonImageKind.FieldProtected:
			stringBuilder.Append(Q7Z.tqM(53352));
			break;
		case CommonImageKind.FieldPublic:
			stringBuilder.Append(Q7Z.tqM(54498));
			break;
		case CommonImageKind.FolderClosed:
			stringBuilder.Append(Q7Z.tqM(55058));
			break;
		case CommonImageKind.GenericArgument:
			stringBuilder.Append(Q7Z.tqM(55534));
			break;
		case CommonImageKind.InterfacePrivate:
			stringBuilder.Append(Q7Z.tqM(56464));
			break;
		case CommonImageKind.InterfaceInternal:
			stringBuilder.Append(Q7Z.tqM(59218));
			break;
		case CommonImageKind.InterfaceProtected:
			stringBuilder.Append(Q7Z.tqM(62044));
			break;
		case CommonImageKind.InterfacePublic:
			stringBuilder.Append(Q7Z.tqM(64364));
			break;
		case CommonImageKind.Keyword:
			stringBuilder.Append(Q7Z.tqM(66164));
			break;
		case CommonImageKind.MethodPrivate:
			stringBuilder.Append(Q7Z.tqM(67432));
			break;
		case CommonImageKind.MethodInternal:
			stringBuilder.Append(Q7Z.tqM(69542));
			break;
		case CommonImageKind.MethodProtected:
			stringBuilder.Append(Q7Z.tqM(71724));
			break;
		case CommonImageKind.MethodPublic:
			stringBuilder.Append(Q7Z.tqM(73400));
			break;
		case CommonImageKind.Namespace:
			stringBuilder.Append(Q7Z.tqM(74544));
			break;
		case CommonImageKind.Operator:
			stringBuilder.Append(Q7Z.tqM(77286));
			break;
		case CommonImageKind.Parameter:
			stringBuilder.Append(Q7Z.tqM(78292));
			break;
		case CommonImageKind.PropertyPrivate:
			stringBuilder.Append(Q7Z.tqM(79564));
			break;
		case CommonImageKind.PropertyInternal:
			stringBuilder.Append(Q7Z.tqM(81968));
			break;
		case CommonImageKind.PropertyProtected:
			stringBuilder.Append(Q7Z.tqM(84444));
			break;
		case CommonImageKind.PropertyPublic:
			stringBuilder.Append(Q7Z.tqM(86414));
			break;
		case CommonImageKind.StandardModuleInternal:
			stringBuilder.Append(Q7Z.tqM(87870));
			break;
		case CommonImageKind.StandardModulePublic:
			stringBuilder.Append(Q7Z.tqM(89444));
			break;
		case CommonImageKind.StructurePrivate:
			stringBuilder.Append(Q7Z.tqM(89972));
			break;
		case CommonImageKind.StructureInternal:
			stringBuilder.Append(Q7Z.tqM(91410));
			break;
		case CommonImageKind.StructureProtected:
			stringBuilder.Append(Q7Z.tqM(92920));
			break;
		case CommonImageKind.StructurePublic:
			stringBuilder.Append(Q7Z.tqM(93924));
			break;
		case CommonImageKind.XmlAttribute:
			stringBuilder.Append(Q7Z.tqM(54498));
			break;
		case CommonImageKind.XmlCDataSection:
			stringBuilder.Append(Q7Z.tqM(94388));
			break;
		case CommonImageKind.XmlComment:
			stringBuilder.Append(Q7Z.tqM(95738));
			break;
		case CommonImageKind.XmlDeclaration:
			stringBuilder.Append(Q7Z.tqM(97298));
			break;
		case CommonImageKind.XmlProcessingInstruction:
			stringBuilder.Append(Q7Z.tqM(98590));
			break;
		case CommonImageKind.XmlTag:
			stringBuilder.Append(Q7Z.tqM(100384));
			break;
		case CommonImageKind.Warning:
			stringBuilder.Append(Q7Z.tqM(101708));
			break;
		default:
			throw new ArgumentOutOfRangeException(Q7Z.tqM(103066));
		}
		stringBuilder.Append(Q7Z.tqM(103080));
		return stringBuilder.ToString();
	}

	private static DrawingImage BuO(CommonImageSet P_0, CommonImageKind P_1)
	{
		string xamlText = ((P_0 == CommonImageSet.MetroDark) ? HuM(P_1) : huU(P_1));
		return XamlReader.Parse(xamlText) as DrawingImage;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static string huU(CommonImageKind P_0)
	{
		StringBuilder stringBuilder = new StringBuilder(Q7Z.tqM(14246));
		switch (P_0)
		{
		case CommonImageKind.Assembly:
			stringBuilder.Append(Q7Z.tqM(103190));
			break;
		case CommonImageKind.ClassPrivate:
			stringBuilder.Append(Q7Z.tqM(104278));
			break;
		case CommonImageKind.ClassInternal:
			stringBuilder.Append(Q7Z.tqM(106016));
			break;
		case CommonImageKind.ClassProtected:
			stringBuilder.Append(Q7Z.tqM(107826));
			break;
		case CommonImageKind.ClassPublic:
			stringBuilder.Append(Q7Z.tqM(109130));
			break;
		case CommonImageKind.CodeSnippet:
			stringBuilder.Append(Q7Z.tqM(109858));
			break;
		case CommonImageKind.ConstantPrivate:
			stringBuilder.Append(Q7Z.tqM(111564));
			break;
		case CommonImageKind.ConstantInternal:
			stringBuilder.Append(Q7Z.tqM(113420));
			break;
		case CommonImageKind.ConstantProtected:
			stringBuilder.Append(Q7Z.tqM(115348));
			break;
		case CommonImageKind.ConstantPublic:
			stringBuilder.Append(Q7Z.tqM(116770));
			break;
		case CommonImageKind.DelegatePrivate:
			stringBuilder.Append(Q7Z.tqM(117652));
			break;
		case CommonImageKind.DelegateInternal:
			stringBuilder.Append(Q7Z.tqM(119420));
			break;
		case CommonImageKind.DelegateProtected:
			stringBuilder.Append(Q7Z.tqM(121260));
			break;
		case CommonImageKind.DelegatePublic:
			stringBuilder.Append(Q7Z.tqM(122594));
			break;
		case CommonImageKind.EnumerationItem:
			stringBuilder.Append(Q7Z.tqM(123404));
			break;
		case CommonImageKind.EnumerationPrivate:
			stringBuilder.Append(Q7Z.tqM(124446));
			break;
		case CommonImageKind.EnumerationInternal:
			stringBuilder.Append(Q7Z.tqM(126696));
			break;
		case CommonImageKind.EnumerationProtected:
			stringBuilder.Append(Q7Z.tqM(129018));
			break;
		case CommonImageKind.EnumerationPublic:
			stringBuilder.Append(Q7Z.tqM(130834));
			break;
		case CommonImageKind.EventPrivate:
			stringBuilder.Append(Q7Z.tqM(132126));
			break;
		case CommonImageKind.EventInternal:
			stringBuilder.Append(Q7Z.tqM(133602));
			break;
		case CommonImageKind.EventProtected:
			stringBuilder.Append(Q7Z.tqM(135150));
			break;
		case CommonImageKind.EventPublic:
			stringBuilder.Append(Q7Z.tqM(136192));
			break;
		case CommonImageKind.ExtensionMethodPrivate:
			stringBuilder.Append(Q7Z.tqM(136698));
			break;
		case CommonImageKind.ExtensionMethodInternal:
			stringBuilder.Append(Q7Z.tqM(136698));
			break;
		case CommonImageKind.ExtensionMethodProtected:
			stringBuilder.Append(Q7Z.tqM(136698));
			break;
		case CommonImageKind.ExtensionMethodPublic:
			stringBuilder.Append(Q7Z.tqM(136698));
			break;
		case CommonImageKind.FieldPrivate:
			stringBuilder.Append(Q7Z.tqM(138634));
			break;
		case CommonImageKind.FieldInternal:
			stringBuilder.Append(Q7Z.tqM(140214));
			break;
		case CommonImageKind.FieldProtected:
			stringBuilder.Append(Q7Z.tqM(141866));
			break;
		case CommonImageKind.FieldPublic:
			stringBuilder.Append(Q7Z.tqM(143012));
			break;
		case CommonImageKind.FolderClosed:
			stringBuilder.Append(Q7Z.tqM(143572));
			break;
		case CommonImageKind.GenericArgument:
			stringBuilder.Append(Q7Z.tqM(144048));
			break;
		case CommonImageKind.InterfacePrivate:
			stringBuilder.Append(Q7Z.tqM(144978));
			break;
		case CommonImageKind.InterfaceInternal:
			stringBuilder.Append(Q7Z.tqM(147732));
			break;
		case CommonImageKind.InterfaceProtected:
			stringBuilder.Append(Q7Z.tqM(150558));
			break;
		case CommonImageKind.InterfacePublic:
			stringBuilder.Append(Q7Z.tqM(152878));
			break;
		case CommonImageKind.Keyword:
			stringBuilder.Append(Q7Z.tqM(154678));
			break;
		case CommonImageKind.MethodPrivate:
			stringBuilder.Append(Q7Z.tqM(155946));
			break;
		case CommonImageKind.MethodInternal:
			stringBuilder.Append(Q7Z.tqM(158056));
			break;
		case CommonImageKind.MethodProtected:
			stringBuilder.Append(Q7Z.tqM(160238));
			break;
		case CommonImageKind.MethodPublic:
			stringBuilder.Append(Q7Z.tqM(161914));
			break;
		case CommonImageKind.Namespace:
			stringBuilder.Append(Q7Z.tqM(163058));
			break;
		case CommonImageKind.Operator:
			stringBuilder.Append(Q7Z.tqM(165800));
			break;
		case CommonImageKind.Parameter:
			stringBuilder.Append(Q7Z.tqM(166806));
			break;
		case CommonImageKind.PropertyPrivate:
			stringBuilder.Append(Q7Z.tqM(168078));
			break;
		case CommonImageKind.PropertyInternal:
			stringBuilder.Append(Q7Z.tqM(170482));
			break;
		case CommonImageKind.PropertyProtected:
			stringBuilder.Append(Q7Z.tqM(172958));
			break;
		case CommonImageKind.PropertyPublic:
			stringBuilder.Append(Q7Z.tqM(174928));
			break;
		case CommonImageKind.StandardModuleInternal:
			stringBuilder.Append(Q7Z.tqM(176384));
			break;
		case CommonImageKind.StandardModulePublic:
			stringBuilder.Append(Q7Z.tqM(177958));
			break;
		case CommonImageKind.StructurePrivate:
			stringBuilder.Append(Q7Z.tqM(178486));
			break;
		case CommonImageKind.StructureInternal:
			stringBuilder.Append(Q7Z.tqM(179924));
			break;
		case CommonImageKind.StructureProtected:
			stringBuilder.Append(Q7Z.tqM(181434));
			break;
		case CommonImageKind.StructurePublic:
			stringBuilder.Append(Q7Z.tqM(182438));
			break;
		case CommonImageKind.XmlAttribute:
			stringBuilder.Append(Q7Z.tqM(143012));
			break;
		case CommonImageKind.XmlCDataSection:
			stringBuilder.Append(Q7Z.tqM(182902));
			break;
		case CommonImageKind.XmlComment:
			stringBuilder.Append(Q7Z.tqM(184252));
			break;
		case CommonImageKind.XmlDeclaration:
			stringBuilder.Append(Q7Z.tqM(185812));
			break;
		case CommonImageKind.XmlProcessingInstruction:
			stringBuilder.Append(Q7Z.tqM(187104));
			break;
		case CommonImageKind.XmlTag:
			stringBuilder.Append(Q7Z.tqM(188898));
			break;
		case CommonImageKind.Warning:
			stringBuilder.Append(Q7Z.tqM(190222));
			break;
		default:
			throw new ArgumentOutOfRangeException(Q7Z.tqM(103066));
		}
		stringBuilder.Append(Q7Z.tqM(103080));
		return stringBuilder.ToString();
	}

	static CommonImageSourceProvider()
	{
		grA.DaB7cz();
		Ouh = CommonImageSet.MetroLight;
	}

	internal static bool nad()
	{
		return Xac == null;
	}

	internal static CommonImageSourceProvider xaT()
	{
		return Xac;
	}
}
