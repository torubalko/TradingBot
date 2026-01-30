using ActiproSoftware.Products.Text;
using ActiproSoftware.Text.Implementation;
using dg3ypDAonQcOidMs0w;

namespace ActiproSoftware.Text;

public static class ClassificationTypes
{
	private static IClassificationType iV;

	private static IClassificationType CB;

	private static IClassificationType I9;

	private static IClassificationType KA;

	private static IClassificationType zu;

	private static IClassificationType E8;

	private static IClassificationType DT;

	private static IClassificationType q2;

	private static IClassificationType rm;

	private static IClassificationType Ic;

	private static IClassificationType Ch;

	internal static ClassificationTypes LP;

	public static IClassificationType Comment
	{
		get
		{
			if (iV == null)
			{
				iV = new ClassificationType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(0), SR.GetString(SRName.UIClassificationTypeComment));
			}
			return iV;
		}
	}

	public static IClassificationType CompilerError
	{
		get
		{
			if (CB == null)
			{
				CB = new ClassificationType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(18), SR.GetString(SRName.UIClassificationTypeCompilerError));
			}
			return CB;
		}
	}

	public static IClassificationType Identifier
	{
		get
		{
			if (I9 == null)
			{
				I9 = new ClassificationType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(48), SR.GetString(SRName.UIClassificationTypeIdentifier));
			}
			return I9;
		}
	}

	public static IClassificationType Keyword
	{
		get
		{
			if (KA == null)
			{
				KA = new ClassificationType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(72), SR.GetString(SRName.UIClassificationTypeKeyword));
			}
			return KA;
		}
	}

	public static IClassificationType Number
	{
		get
		{
			if (zu == null)
			{
				zu = new ClassificationType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(90), SR.GetString(SRName.UIClassificationTypeNumber));
			}
			return zu;
		}
	}

	public static IClassificationType OtherError
	{
		get
		{
			if (E8 == null)
			{
				E8 = new ClassificationType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106), SR.GetString(SRName.UIClassificationTypeOtherError));
			}
			return E8;
		}
	}

	public static IClassificationType PreprocessorKeyword
	{
		get
		{
			if (DT == null)
			{
				DT = new ClassificationType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(130), SR.GetString(SRName.UIClassificationTypePreprocessorKeyword));
			}
			return DT;
		}
	}

	public static IClassificationType ReadOnlyRegion
	{
		get
		{
			if (q2 == null)
			{
				q2 = new ClassificationType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(172), SR.GetString(SRName.UIClassificationTypeReadOnlyRegion));
			}
			return q2;
		}
	}

	public static IClassificationType String
	{
		get
		{
			if (rm == null)
			{
				rm = new ClassificationType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(204), SR.GetString(SRName.UIClassificationTypeString));
			}
			return rm;
		}
	}

	public static IClassificationType SyntaxError
	{
		get
		{
			if (Ic == null)
			{
				Ic = new ClassificationType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(220), SR.GetString(SRName.UIClassificationTypeSyntaxError));
			}
			return Ic;
		}
	}

	public static IClassificationType Warning
	{
		get
		{
			if (Ch == null)
			{
				Ch = new ClassificationType(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(246), SR.GetString(SRName.UIClassificationTypeWarning));
			}
			return Ch;
		}
	}

	internal static bool eU()
	{
		return LP == null;
	}

	internal static ClassificationTypes c2()
	{
		return LP;
	}
}
