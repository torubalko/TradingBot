#define DEBUG
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Windows.Controls.Primitives;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes.Generation;

public class ThemeDefinition : ObservableObjectBase
{
	private ColorFamilyName C7h;

	private ColorFamilyName w7m;

	private ColorFamilyName K7w;

	private ColorFamilyName C74;

	private ColorFamilyName P7u;

	private int U72;

	private int S7e;

	private ColorPaletteKind F77;

	private int S7F;

	private double G7o;

	private int m7Q;

	private Color m7O;

	private Color b70;

	private Color F7k;

	private Color G7l;

	private Color m7A;

	private Color S7C;

	private Color b7Y;

	private Color r7I;

	private Color P7x;

	private ThemeIntent e7r;

	private ArrowKind E7Z;

	private GradientKind m7n;

	private BackgroundStateKind h7a;

	private BorderContrastKind Q7q;

	private double s7W;

	private BulletGlyphKind D7U;

	private BulletChromeRelativeSize l7H;

	private GradientKind x76;

	private BorderContrastKind K7V;

	private double B75;

	private Thickness G7R;

	private double M7E;

	private BorderContrastKind a7s;

	private ThemeIntent f7L;

	private GradientKind V7d;

	private BackgroundStateKind E7N;

	private BorderContrastKind s7M;

	private double L7K;

	private double y7g;

	private Thickness O78;

	private double t7D;

	private double O7P;

	private string name;

	private BorderContrastKind X7G;

	private double y71;

	private int j7z;

	private bool HFc;

	private bool oFj;

	private double EFv;

	private double vFX;

	private StatusBarBackgroundKind YFT;

	private double vFB;

	private double SFp;

	private double YFb;

	private WindowBorderKind mFy;

	private WindowTitleBarBackgroundKind fFf;

	private static readonly Thickness CFi;

	private static readonly Thickness HFS;

	private double? tF3;

	private FontFamily eFt;

	private FontSizeKind RFJ;

	private FontSizeKind fF9;

	private static readonly double? BFh;

	private static FontFamily iFm;

	internal static ThemeDefinition Bfg;

	[Display(GroupName = "Color Family Usage", ShortName = "Dock Guides", Description = "The color family to use for dock guide accents.")]
	public ColorFamilyName DockGuideColorFamilyName
	{
		get
		{
			return C7h;
		}
		set
		{
			if (C7h != value)
			{
				C7h = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102118));
			}
		}
	}

	[Display(GroupName = "Color Family Usage", ShortName = "Preview Tabs", Description = "The color family to use for tabbed MDI preview tabs.")]
	public ColorFamilyName PreviewTabColorFamilyName
	{
		get
		{
			return w7m;
		}
		set
		{
			if (w7m != value)
			{
				w7m = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102170));
			}
		}
	}

	[Display(GroupName = "Color Family Usage", ShortName = "Primary Accent", Description = "The color family to use for primary accents.")]
	public ColorFamilyName PrimaryAccentColorFamilyName
	{
		get
		{
			return K7w;
		}
		set
		{
			if (K7w != value)
			{
				K7w = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102224));
			}
		}
	}

	[Display(GroupName = "Color Family Usage", ShortName = "Progress", Description = "The color family to use for progress bars.")]
	public ColorFamilyName ProgressColorFamilyName
	{
		get
		{
			return C74;
		}
		set
		{
			if (C74 != value)
			{
				C74 = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102284));
			}
		}
	}

	[Display(GroupName = "Color Family Usage", ShortName = "Window", Description = "The color family to use for windows, such as for title bar button hover backgrounds, tool window title bars, etc.")]
	public ColorFamilyName WindowColorFamilyName
	{
		get
		{
			return P7u;
		}
		set
		{
			if (P7u != value)
			{
				P7u = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102334));
			}
		}
	}

	[Display(GroupName = "Color Palette", ShortName = "Blue Base", Description = "The base color used for the blue color family.")]
	public Color BaseColorBlue
	{
		get
		{
			return m7O;
		}
		set
		{
			if (m7O != value)
			{
				m7O = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103306));
			}
		}
	}

	[Display(GroupName = "Color Palette", ShortName = "Green Base", Description = "The base color used for the green color family.")]
	public Color BaseColorGreen
	{
		get
		{
			return b70;
		}
		set
		{
			if (b70 != value)
			{
				b70 = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103336));
			}
		}
	}

	[Display(GroupName = "Color Palette", ShortName = "Indigo Base", Description = "The base color used for the indigo color family.")]
	public Color BaseColorIndigo
	{
		get
		{
			return F7k;
		}
		set
		{
			if (F7k != value)
			{
				F7k = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103368));
			}
		}
	}

	[Display(GroupName = "Color Palette", ShortName = "Orange Base", Description = "The base color used for the orange color family.")]
	public Color BaseColorOrange
	{
		get
		{
			return G7l;
		}
		set
		{
			if (G7l != value)
			{
				G7l = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103402));
			}
		}
	}

	[Display(GroupName = "Color Palette", ShortName = "Pink Base", Description = "The base color used for the pink color family.")]
	public Color BaseColorPink
	{
		get
		{
			return m7A;
		}
		set
		{
			if (m7A != value)
			{
				m7A = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103436));
			}
		}
	}

	[Display(GroupName = "Color Palette", ShortName = "Purple Base", Description = "The base color used for the purple color family.")]
	public Color BaseColorPurple
	{
		get
		{
			return S7C;
		}
		set
		{
			if (S7C != value)
			{
				S7C = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103466));
			}
		}
	}

	[Display(GroupName = "Color Palette", ShortName = "Red Base", Description = "The base color used for the red color family.")]
	public Color BaseColorRed
	{
		get
		{
			return b7Y;
		}
		set
		{
			if (b7Y != value)
			{
				b7Y = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103500));
			}
		}
	}

	[Display(GroupName = "Color Palette", ShortName = "Teal Base", Description = "The base color used for the teal color family.")]
	public Color BaseColorTeal
	{
		get
		{
			return r7I;
		}
		set
		{
			if (r7I != value)
			{
				r7I = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103528));
			}
		}
	}

	[Display(GroupName = "Color Palette", ShortName = "Yellow Base", Description = "The base color used for the yellow color family.")]
	public Color BaseColorYellow
	{
		get
		{
			return P7x;
		}
		set
		{
			if (P7x != value)
			{
				P7x = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103558));
			}
		}
	}

	[Display(GroupName = "Grayscale Palette", ShortName = "Hue Base", Description = "The base color hue (0..359) used for tinting the gray and silver colors.", Order = 1)]
	public int BaseGrayscaleHue
	{
		get
		{
			return U72;
		}
		set
		{
			if (value < 0 || value > 359)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0, 359));
			}
			if (U72 != value)
			{
				U72 = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103682));
			}
		}
	}

	[Display(GroupName = "Grayscale Palette", ShortName = "Saturation Percentage", Description = "The percentage of base color hue to tint gray and silver colors.  A zero value means pure gray/silver.", Order = 2)]
	public int BaseGrayscaleSaturation
	{
		get
		{
			return S7e;
		}
		set
		{
			if (value < 0 || value > 100)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0, 100));
			}
			if (S7e != value)
			{
				S7e = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103718));
			}
		}
	}

	[Display(GroupName = "Color Palette", ShortName = "Palette Kind", Description = "The base color palette kind.", Order = -1)]
	public ColorPaletteKind ColorPaletteKind
	{
		get
		{
			return F77;
		}
		set
		{
			if (F77 != value)
			{
				F77 = value;
				h7J();
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103768));
			}
		}
	}

	[Display(GroupName = "Grayscale Palette", ShortName = "Gray Min", Description = "The minimum color component of the gray color range.  A smaller value means closer to black.", Order = 3)]
	public int GrayMin
	{
		get
		{
			return S7F;
		}
		set
		{
			if (value < 0 || value > 50)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0, 50));
			}
			if (S7F != value)
			{
				S7F = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103804));
			}
		}
	}

	[Display(GroupName = "Grayscale Palette", ShortName = "Gray/Silver Ratio", Description = "The percentage ratio comparing how the Gray vs. Silver color ramps cover the grayscale spectrum.", Order = 4)]
	public double GraySilverRatio
	{
		get
		{
			return G7o;
		}
		set
		{
			if (value < 0.25 || value > 0.75)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0.25, 0.75));
			}
			if (G7o != value)
			{
				G7o = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103822));
			}
		}
	}

	[Display(GroupName = "Grayscale Palette", ShortName = "Silver Max", Description = "The max color component of the silver color range.  A larger value means closer to white.", Order = 6)]
	public int SilverMax
	{
		get
		{
			return m7Q;
		}
		set
		{
			if (value < 200 || value > 255)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 200, 255));
			}
			if (m7Q != value)
			{
				m7Q = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103856));
			}
		}
	}

	internal BackgroundStateKind BarItemBackgroundStateKindResolved => F79(BarItemBackgroundStateKind);

	internal BackgroundStateKind ListItemBackgroundStateKindResolved => F79(ListItemBackgroundStateKind);

	[Display(GroupName = "Theme Options", ShortName = "Arrow Kind", Description = "The appearance of arrows.")]
	public ArrowKind ArrowKind
	{
		get
		{
			return E7Z;
		}
		set
		{
			if (E7Z != value)
			{
				E7Z = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103878));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Bar Item Background Gradient", Description = "The gradient for toolbar/menu item backgrounds.")]
	public GradientKind BarItemBackgroundGradientKind
	{
		get
		{
			return m7n;
		}
		set
		{
			if (m7n != value)
			{
				m7n = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103900));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Bar Item Background State Accents", Description = "The background state accents to use for toolbar/menu items.")]
	public BackgroundStateKind BarItemBackgroundStateKind
	{
		get
		{
			return h7a;
		}
		set
		{
			if (h7a != value)
			{
				h7a = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103962));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Bar Item Border Contrast", Description = "The amount of contrast between toolbar/menu item borders and their backgrounds.")]
	public BorderContrastKind BarItemBorderContrastKind
	{
		get
		{
			return Q7q;
		}
		set
		{
			if (Q7q != value)
			{
				Q7q = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104018));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Bullet Border Width", Description = "The border width for checkbox and radio button controls.")]
	public double BulletBorderWidth
	{
		get
		{
			return s7W;
		}
		set
		{
			if (value < 0.0 || value > 2.0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0.0, 2.0));
			}
			if (s7W != value)
			{
				s7W = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104072));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Bullet Glyph", Description = "The appearance of bullet (checkbox / radio button) glyphs.")]
	public BulletGlyphKind BulletGlyphKind
	{
		get
		{
			return D7U;
		}
		set
		{
			if (D7U != value)
			{
				D7U = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104110));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Bullet Relative Size", Description = "The size of bullet (checkbox / radio button) glyphs, relative to the font size.")]
	public BulletChromeRelativeSize BulletRelativeSize
	{
		get
		{
			return l7H;
		}
		set
		{
			if (l7H != value)
			{
				l7H = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104144));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Button Background Gradient", Description = "The gradient for button backgrounds.")]
	public GradientKind ButtonBackgroundGradientKind
	{
		get
		{
			return x76;
		}
		set
		{
			if (x76 != value)
			{
				x76 = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104184));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Button Border Contrast", Description = "The amount of contrast between button borders and their backgrounds.")]
	public BorderContrastKind ButtonBorderContrastKind
	{
		get
		{
			return K7V;
		}
		set
		{
			if (K7V != value)
			{
				K7V = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104244));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Button Corner Radius", Description = "The corner radius for buttons.")]
	public double ButtonCornerRadius
	{
		get
		{
			return B75;
		}
		set
		{
			if (value < 0.0 || value > 7.0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0.0, 7.0));
			}
			if (B75 != value)
			{
				B75 = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104296));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Button Padding", Description = "The padding around button content.")]
	public Thickness ButtonPadding
	{
		get
		{
			return G7R;
		}
		set
		{
			if (G7R != value)
			{
				G7R = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104336));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "CheckBox Corner Radius", Description = "The corner radius for checkboxes.")]
	public double CheckBoxCornerRadius
	{
		get
		{
			return M7E;
		}
		set
		{
			if (value < 0.0 || value > 7.0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0.0, 7.0));
			}
			if (M7E != value)
			{
				M7E = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104366));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Container Border Contrast", Description = "The amount of contrast between container borders and their backgrounds.")]
	public BorderContrastKind ContainerBorderContrastKind
	{
		get
		{
			return a7s;
		}
		set
		{
			if (a7s != value)
			{
				a7s = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104410));
			}
		}
	}

	[Display(GroupName = "General", Description = "Whether the theme is meant to be light, dark, high-contrast, etc.  Only use high-contrast when Windows itself is using a high-contrast theme.")]
	public ThemeIntent Intent
	{
		get
		{
			return f7L;
		}
		set
		{
			if (f7L != value)
			{
				f7L = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104468));
			}
		}
	}

	[Browsable(false)]
	public bool IsDarkTheme => Intent.IsDarkTheme();

	[Display(GroupName = "Theme Options", ShortName = "List Item Background Gradient", Description = "The gradient for list item backgrounds.")]
	public GradientKind ListItemBackgroundGradientKind
	{
		get
		{
			return V7d;
		}
		set
		{
			if (V7d != value)
			{
				V7d = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104484));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "List Item Background State Accents", Description = "The background state accents to use for list items.")]
	public BackgroundStateKind ListItemBackgroundStateKind
	{
		get
		{
			return E7N;
		}
		set
		{
			if (E7N != value)
			{
				E7N = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104548));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "List Item Border Contrast", Description = "The amount of contrast between list item borders and their backgrounds.")]
	public BorderContrastKind ListItemBorderContrastKind
	{
		get
		{
			return s7M;
		}
		set
		{
			if (s7M != value)
			{
				s7M = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104606));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Menu Item Icon Column Width", Description = "The width for menu item icon columns.")]
	public double MenuItemIconColumnWidth
	{
		get
		{
			return L7K;
		}
		set
		{
			if (value < 20.0 || value > 60.0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 20.0, 60.0));
			}
			if (L7K != value)
			{
				L7K = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104662));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Large Menu Item Icon Column Width", Description = "The width for large menu item icon columns.")]
	public double MenuItemLargeIconColumnWidth
	{
		get
		{
			return y7g;
		}
		set
		{
			if (value < 20.0 || value > 60.0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 20.0, 60.0));
			}
			if (y7g != value)
			{
				y7g = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104712));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Menu Item Padding", Description = "The padding around menu item text.")]
	public Thickness MenuItemPadding
	{
		get
		{
			return O78;
		}
		set
		{
			if (O78 != value)
			{
				O78 = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104772));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Menu Item Popup Column Width", Description = "The width for menu item popup columns.")]
	public double MenuItemPopupColumnWidth
	{
		get
		{
			return t7D;
		}
		set
		{
			if (value < 20.0 || value > 60.0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 20.0, 60.0));
			}
			if (t7D != value)
			{
				t7D = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104806));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Menu Popup Corner Radius", Description = "The corner radius for menu popups.")]
	public double MenuPopupCornerRadius
	{
		get
		{
			return O7P;
		}
		set
		{
			if (value < 0.0 || value > 7.0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0.0, 7.0));
			}
			if (O7P != value)
			{
				O7P = value;
				int num = 0;
				if (cfj() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104858));
			}
		}
	}

	[Display(GroupName = "General", Description = "The theme's name.  When this definition is registered on ThemeManager, the definition will generate asset resources if ThemeManager.CurrentTheme is set to to the same theme name.")]
	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(104904));
			}
			if (name != value)
			{
				name = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105006));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Popup Border Contrast", Description = "The amount of contrast between popup borders and their backgrounds.")]
	public BorderContrastKind PopupBorderContrastKind
	{
		get
		{
			return X7G;
		}
		set
		{
			if (X7G != value)
			{
				X7G = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105018));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Popup Corner Radius", Description = "The corner radius for popups.")]
	public double PopupCornerRadius
	{
		get
		{
			return y71;
		}
		set
		{
			if (!(value < 0.0) && !(value > 7.0))
			{
				if (y71 != value)
				{
					y71 = value;
					NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105068));
					int num = 0;
					if (!mf8())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					case 0:
						break;
					}
				}
				return;
			}
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0.0, 7.0));
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Popup Shadow Direction", Description = "The direction of the shadow, in degrees, where 270 is down, 315 is lower-right, etc.")]
	public int PopupShadowDirection
	{
		get
		{
			return j7z;
		}
		set
		{
			if ((double)value < 0.0 || (double)value > 360.0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0.0, 360.0));
			}
			if (j7z != value)
			{
				j7z = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105106));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Require Darker Borders", Description = "Whether to require darker borders in dark-oriented themes.")]
	public bool RequireDarkerBorders
	{
		get
		{
			return HFc;
		}
		set
		{
			if (HFc != value)
			{
				HFc = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105150));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Scroll Bar Has Buttons", Description = "Whether scroll bars have buttons, or only a track and thumb.")]
	public bool ScrollBarHasButtons
	{
		get
		{
			return oFj;
		}
		set
		{
			if (oFj != value)
			{
				oFj = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105194));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Scroll Bar Thumb Corner Radius", Description = "The corner radius for scroll bar thumbs.")]
	public double ScrollBarThumbCornerRadius
	{
		get
		{
			return EFv;
		}
		set
		{
			if (!(value < 0.0) && !(value > 7.0))
			{
				if (EFv != value)
				{
					EFv = value;
					NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105236));
				}
				return;
			}
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0.0, 7.0));
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Scroll Bar Thumb Margin", Description = "The margin for scroll bar thumbs.")]
	public double ScrollBarThumbMargin
	{
		get
		{
			return vFX;
		}
		set
		{
			if (value < 0.0 || value > 7.0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0.0, 7.0));
			}
			if (vFX != value)
			{
				vFX = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105292));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Status Bar Background", Description = "The appearance of status bar backgrounds.")]
	public StatusBarBackgroundKind StatusBarBackgroundKind
	{
		get
		{
			return YFT;
		}
		set
		{
			if (YFT != value)
			{
				YFT = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105336));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Tab Corner Radius", Description = "The corner radius for tabs.")]
	public double TabCornerRadius
	{
		get
		{
			return vFB;
		}
		set
		{
			if (value < 0.0 || value > 7.0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0.0, 7.0));
			}
			if (vFB != value)
			{
				vFB = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105386));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Title Bar Corner Radius", Description = "The corner radius for tool window title bars.")]
	public double TitleBarCornerRadius
	{
		get
		{
			return SFp;
		}
		set
		{
			if (value < 0.0 || value > 7.0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0.0, 7.0));
			}
			if (SFp != value)
			{
				SFp = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105420));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Tool Bar Button Corner Radius", Description = "The corner radius for tool bar buttons.")]
	public double ToolBarButtonCornerRadius
	{
		get
		{
			return YFb;
		}
		set
		{
			if (value < 0.0 || value > 7.0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 0.0, 7.0));
			}
			if (YFb != value)
			{
				YFb = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105464));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Window Border", Description = "The appearance of the active window border.")]
	public WindowBorderKind WindowBorderKind
	{
		get
		{
			return mFy;
		}
		set
		{
			if (mFy != value)
			{
				mFy = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105518));
			}
		}
	}

	[Display(GroupName = "Theme Options", ShortName = "Window Title Bar Background", Description = "The appearance of the window title bar background.")]
	public WindowTitleBarBackgroundKind WindowTitleBarBackgroundKind
	{
		get
		{
			return fFf;
		}
		set
		{
			if (fFf != value)
			{
				fFf = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105554));
			}
		}
	}

	[Display(GroupName = "Fonts", ShortName = "Base Font Size", Description = "The default font size used in UI.  Reset this property to null to use the system's default font size (SystemFonts.MessageFontSize).")]
	public double? BaseFontSize
	{
		get
		{
			return tF3;
		}
		set
		{
			if (value < 10.0 || value > 20.0)
			{
				throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103592), string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103606), 10.0, 20.0));
			}
			if (tF3 != value)
			{
				tF3 = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105614));
			}
		}
	}

	[Display(GroupName = "Fonts", ShortName = "Default Font Family", Description = "The default font family applied to windows, menus, and tool tips.  Reset this property to null to use the system's default font family (SystemFonts.MessageFontFamily).", Order = -1)]
	public FontFamily DefaultFontFamily
	{
		get
		{
			return eFt;
		}
		set
		{
			if (eFt != value)
			{
				eFt = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105642));
			}
		}
	}

	[Display(GroupName = "Fonts", ShortName = "Tool Title Font Size", Description = "The font size used in tool window container titles.")]
	public FontSizeKind ToolWindowContainerTitleFontSizeKind
	{
		get
		{
			return RFJ;
		}
		set
		{
			if (RFJ != value)
			{
				RFJ = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105680));
			}
		}
	}

	[Display(GroupName = "Fonts", ShortName = "Title Font Size", Description = "The font size used in window titles.")]
	public FontSizeKind WindowTitleFontSizeKind
	{
		get
		{
			return fF9;
		}
		set
		{
			if (fF9 != value)
			{
				fF9 = value;
				NotifyPropertyChanged(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105756));
			}
		}
	}

	public virtual void ResetDockGuideColorFamilyName()
	{
		DockGuideColorFamilyName = ColorFamilyName.Orange;
	}

	public virtual bool ShouldSerializeDockGuideColorFamilyName()
	{
		return DockGuideColorFamilyName != ColorFamilyName.Orange;
	}

	public virtual void ResetPreviewTabColorFamilyName()
	{
		PreviewTabColorFamilyName = ColorFamilyName.Purple;
	}

	public virtual bool ShouldSerializePreviewTabColorFamilyName()
	{
		return PreviewTabColorFamilyName != ColorFamilyName.Purple;
	}

	public virtual void ResetPrimaryAccentColorFamilyName()
	{
		PrimaryAccentColorFamilyName = ColorFamilyName.Blue;
	}

	public virtual bool ShouldSerializePrimaryAccentColorFamilyName()
	{
		return PrimaryAccentColorFamilyName != ColorFamilyName.Blue;
	}

	public virtual void ResetProgressColorFamilyName()
	{
		ProgressColorFamilyName = ColorFamilyName.Green;
	}

	public virtual bool ShouldSerializeProgressColorFamilyName()
	{
		return ProgressColorFamilyName != ColorFamilyName.Green;
	}

	public virtual void ResetWindowColorFamilyName()
	{
		WindowColorFamilyName = ColorFamilyName.Blue;
	}

	public virtual bool ShouldSerializeWindowColorFamilyName()
	{
		return WindowColorFamilyName != ColorFamilyName.Blue;
	}

	private static void s73()
	{
		Color baseColorForBrandColor = ColorPalette.GetBaseColorForBrandColor(Color.FromRgb(164, 55, 58));
		Color baseColorForBrandColor2 = ColorPalette.GetBaseColorForBrandColor(Color.FromRgb(183, 71, 42));
		Color baseColorForBrandColor3 = ColorPalette.GetBaseColorForBrandColor(Color.FromRgb(33, 115, 70));
		Color baseColorForBrandColor4 = ColorPalette.GetBaseColorForBrandColor(Color.FromRgb(7, 117, 104));
		Color baseColorForBrandColor5 = ColorPalette.GetBaseColorForBrandColor(Color.FromRgb(16, 110, 190));
		Color baseColorForBrandColor6 = ColorPalette.GetBaseColorForBrandColor(Color.FromRgb(43, 87, 154));
		Color baseColorForBrandColor7 = ColorPalette.GetBaseColorForBrandColor(Color.FromRgb(128, 57, 123));
		Color baseColorForBrandColor8 = ColorPalette.GetBaseColorForBrandColor(Color.FromRgb(119, 25, 170));
		Color baseColorForBrandColor9 = ColorPalette.GetBaseColorForBrandColor(Color.FromRgb(0, 122, 204));
		Debug.WriteLine(new string('-', 40));
		Debug.WriteLine(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102380));
		Debug.WriteLine(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102418) + baseColorForBrandColor.R.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor.G.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor.B.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102520));
		int num = 0;
		if (mf8())
		{
			num = 1;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				Debug.WriteLine(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102528) + baseColorForBrandColor2.R.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor2.G.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor2.B.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102520));
				Debug.WriteLine(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102610) + baseColorForBrandColor3.R.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor3.G.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor3.B.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102520));
				Debug.WriteLine(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102692) + baseColorForBrandColor4.R.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor4.G.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor4.B.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102520));
				Debug.WriteLine(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102774) + baseColorForBrandColor5.R.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor5.G.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor5.B.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102520));
				Debug.WriteLine(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102856) + baseColorForBrandColor6.R.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor6.G.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor6.B.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102520));
				Debug.WriteLine(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102938) + baseColorForBrandColor7.R.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor7.G.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor7.B.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102520));
				Debug.WriteLine(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103020) + baseColorForBrandColor8.R.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor8.G.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor8.B.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102520));
				Debug.WriteLine(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103102) + baseColorForBrandColor9.R.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor9.G.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102508) + baseColorForBrandColor9.B.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102500)) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(102520));
				num = 0;
				if (cfj() != null)
				{
					num = num2;
				}
				break;
			default:
				Debug.WriteLine(new string('-', 40));
				return;
			}
		}
	}

	private static Color X7t(ColorPaletteKind P_0, ColorFamilyName P_1)
	{
		if (P_0 != ColorPaletteKind.Office)
		{
			goto IL_00d0;
		}
		ColorFamilyName colorFamilyName = P_1;
		int num = 4;
		goto IL_0009;
		IL_0009:
		Color result = default(Color);
		ColorFamilyName colorFamilyName2 = default(ColorFamilyName);
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 4:
				goto IL_017c;
			default:
				goto IL_01f4;
			case 1:
				goto IL_0363;
			}
			break;
			IL_0363:
			result = colorFamilyName2 switch
			{
				ColorFamilyName.Green => Color.FromRgb(59, 171, 106), 
				ColorFamilyName.Purple => Color.FromRgb(159, 122, 233), 
				ColorFamilyName.Pink => Color.FromRgb(245, 109, 154), 
				ColorFamilyName.Orange => Color.FromRgb(246, 152, 62), 
				ColorFamilyName.Blue => Color.FromRgb(10, 159, 235), 
				ColorFamilyName.Red => Color.FromRgb(226, 52, 46), 
				ColorFamilyName.Teal => Color.FromRgb(56, 177, 171), 
				ColorFamilyName.Yellow => Color.FromRgb(byte.MaxValue, 236, 75), 
				ColorFamilyName.Indigo => Color.FromRgb(102, 117, 206), 
				_ => throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103184), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(103218)), 
			};
			goto IL_01f4;
			IL_017c:
			switch (colorFamilyName)
			{
			case ColorFamilyName.Green:
				break;
			case ColorFamilyName.Pink:
				goto IL_0073;
			default:
				goto end_IL_0009;
			case ColorFamilyName.Blue:
				goto IL_0124;
			case ColorFamilyName.Orange:
				goto IL_01b2;
			case ColorFamilyName.Red:
				goto IL_0237;
			case ColorFamilyName.Purple:
				goto IL_028c;
			case ColorFamilyName.Indigo:
				goto IL_02c9;
			case ColorFamilyName.Teal:
				goto IL_02de;
			case ColorFamilyName.Yellow:
				goto IL_034b;
			}
			result = Color.FromRgb(47, 132, 90);
			goto IL_01f4;
			IL_034b:
			result = Color.FromRgb(byte.MaxValue, 214, 51);
			goto IL_01f4;
			IL_02de:
			result = Color.FromRgb(21, 136, 130);
			num = 0;
			if (cfj() == null)
			{
				continue;
			}
			goto IL_0005;
			IL_02c9:
			result = Color.FromRgb(61, 113, 177);
			goto IL_01f4;
			IL_028c:
			result = Color.FromRgb(149, 73, 148);
			num = 2;
			if (mf8())
			{
				continue;
			}
			goto IL_0005;
			IL_0237:
			result = Color.FromRgb(187, 75, 79);
			goto IL_01f4;
			IL_01b2:
			result = Color.FromRgb(210, 98, 63);
			goto IL_01f4;
			IL_0124:
			result = Color.FromRgb(37, 146, 218);
			goto IL_01f4;
			IL_0073:
			result = Color.FromRgb(153, 45, 197);
			goto IL_01f4;
			IL_01f4:
			return result;
			continue;
			end_IL_0009:
			break;
		}
		goto IL_00d0;
		IL_00d0:
		colorFamilyName2 = P_1;
		num = 1;
		if (cfj() != null)
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	private void h7J()
	{
		BaseColorRed = X7t(ColorPaletteKind, ColorFamilyName.Red);
		BaseColorOrange = X7t(ColorPaletteKind, ColorFamilyName.Orange);
		BaseColorYellow = X7t(ColorPaletteKind, ColorFamilyName.Yellow);
		BaseColorGreen = X7t(ColorPaletteKind, ColorFamilyName.Green);
		BaseColorTeal = X7t(ColorPaletteKind, ColorFamilyName.Teal);
		BaseColorBlue = X7t(ColorPaletteKind, ColorFamilyName.Blue);
		BaseColorIndigo = X7t(ColorPaletteKind, ColorFamilyName.Indigo);
		BaseColorPurple = X7t(ColorPaletteKind, ColorFamilyName.Purple);
		BaseColorPink = X7t(ColorPaletteKind, ColorFamilyName.Pink);
		int num = 0;
		if (!mf8())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public virtual void ResetBaseColorBlue()
	{
		BaseColorBlue = X7t(ColorPaletteKind, ColorFamilyName.Blue);
	}

	public virtual bool ShouldSerializeBaseColorBlue()
	{
		return BaseColorBlue != X7t(ColorPaletteKind, ColorFamilyName.Blue);
	}

	public virtual void ResetBaseColorGreen()
	{
		BaseColorGreen = X7t(ColorPaletteKind, ColorFamilyName.Green);
	}

	public virtual bool ShouldSerializeBaseColorGreen()
	{
		return BaseColorGreen != X7t(ColorPaletteKind, ColorFamilyName.Green);
	}

	public virtual void ResetBaseColorIndigo()
	{
		BaseColorIndigo = X7t(ColorPaletteKind, ColorFamilyName.Indigo);
	}

	public virtual bool ShouldSerializeBaseColorIndigo()
	{
		return BaseColorIndigo != X7t(ColorPaletteKind, ColorFamilyName.Indigo);
	}

	public virtual void ResetBaseColorOrange()
	{
		BaseColorOrange = X7t(ColorPaletteKind, ColorFamilyName.Orange);
	}

	public virtual bool ShouldSerializeBaseColorOrange()
	{
		return BaseColorOrange != X7t(ColorPaletteKind, ColorFamilyName.Orange);
	}

	public virtual void ResetBaseColorPink()
	{
		BaseColorPink = X7t(ColorPaletteKind, ColorFamilyName.Pink);
	}

	public virtual bool ShouldSerializeBaseColorPink()
	{
		return BaseColorPink != X7t(ColorPaletteKind, ColorFamilyName.Pink);
	}

	public virtual void ResetBaseColorPurple()
	{
		BaseColorPurple = X7t(ColorPaletteKind, ColorFamilyName.Purple);
	}

	public virtual bool ShouldSerializeBaseColorPurple()
	{
		return BaseColorPurple != X7t(ColorPaletteKind, ColorFamilyName.Purple);
	}

	public virtual void ResetBaseColorRed()
	{
		BaseColorRed = X7t(ColorPaletteKind, ColorFamilyName.Red);
	}

	public virtual bool ShouldSerializeBaseColorRed()
	{
		return BaseColorRed != X7t(ColorPaletteKind, ColorFamilyName.Red);
	}

	public virtual void ResetBaseColorTeal()
	{
		BaseColorTeal = X7t(ColorPaletteKind, ColorFamilyName.Teal);
	}

	public virtual bool ShouldSerializeBaseColorTeal()
	{
		return BaseColorTeal != X7t(ColorPaletteKind, ColorFamilyName.Teal);
	}

	public virtual void ResetBaseColorYellow()
	{
		BaseColorYellow = X7t(ColorPaletteKind, ColorFamilyName.Yellow);
	}

	public virtual bool ShouldSerializeBaseColorYellow()
	{
		return BaseColorYellow != X7t(ColorPaletteKind, ColorFamilyName.Yellow);
	}

	public virtual void ResetBaseGrayscaleHue()
	{
		BaseGrayscaleHue = 220;
	}

	public virtual bool ShouldSerializeBaseGrayscaleHue()
	{
		return BaseGrayscaleHue != 220;
	}

	public virtual void ResetBaseGrayscaleSaturation()
	{
		BaseGrayscaleSaturation = 7;
	}

	public virtual bool ShouldSerializeBaseGrayscaleSaturation()
	{
		return BaseGrayscaleSaturation != 7;
	}

	public virtual void ResetColorPaletteKind()
	{
		ColorPaletteKind = ColorPaletteKind.Vibrant;
	}

	public virtual bool ShouldSerializeColorPaletteKind()
	{
		return ColorPaletteKind != ColorPaletteKind.Vibrant;
	}

	public virtual void ResetGrayMin()
	{
		GrayMin = 35;
	}

	public virtual bool ShouldSerializeGrayMin()
	{
		return GrayMin != 35;
	}

	public virtual void ResetGraySilverRatio()
	{
		GraySilverRatio = 0.6;
	}

	public virtual bool ShouldSerializeGraySilverRatio()
	{
		return GraySilverRatio != 0.6;
	}

	public virtual void ResetSilverMax()
	{
		SilverMax = 255;
	}

	public virtual bool ShouldSerializeSilverMax()
	{
		return SilverMax != 255;
	}

	public ThemeDefinition(string themeName)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(themeName, ThemeIntent.Light);
	}

	public ThemeDefinition(string themeName, ThemeIntent intent)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		C7h = ColorFamilyName.Orange;
		w7m = ColorFamilyName.Purple;
		K7w = ColorFamilyName.Blue;
		C74 = ColorFamilyName.Green;
		P7u = ColorFamilyName.Blue;
		U72 = 220;
		S7e = 7;
		F77 = ColorPaletteKind.Vibrant;
		S7F = 35;
		G7o = 0.6;
		m7Q = 255;
		m7O = X7t(ColorPaletteKind.Vibrant, ColorFamilyName.Blue);
		b70 = X7t(ColorPaletteKind.Vibrant, ColorFamilyName.Green);
		F7k = X7t(ColorPaletteKind.Vibrant, ColorFamilyName.Indigo);
		G7l = X7t(ColorPaletteKind.Vibrant, ColorFamilyName.Orange);
		m7A = X7t(ColorPaletteKind.Vibrant, ColorFamilyName.Pink);
		S7C = X7t(ColorPaletteKind.Vibrant, ColorFamilyName.Purple);
		b7Y = X7t(ColorPaletteKind.Vibrant, ColorFamilyName.Red);
		r7I = X7t(ColorPaletteKind.Vibrant, ColorFamilyName.Teal);
		P7x = X7t(ColorPaletteKind.Vibrant, ColorFamilyName.Yellow);
		E7Z = ArrowKind.Chevron;
		m7n = GradientKind.None;
		h7a = BackgroundStateKind.Normal;
		Q7q = BorderContrastKind.Lowest;
		s7W = 1.0;
		D7U = BulletGlyphKind.Normal;
		l7H = BulletChromeRelativeSize.Small;
		x76 = GradientKind.Low;
		K7V = BorderContrastKind.Mid;
		B75 = 3.0;
		G7R = CFi;
		M7E = 2.0;
		a7s = BorderContrastKind.Mid;
		f7L = ThemeIntent.Light;
		V7d = GradientKind.None;
		E7N = BackgroundStateKind.Normal;
		s7M = BorderContrastKind.Lowest;
		L7K = 30.0;
		y7g = 50.0;
		O78 = HFS;
		t7D = 30.0;
		O7P = 0.0;
		name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96520);
		X7G = BorderContrastKind.Mid;
		y71 = 0.0;
		j7z = 270;
		HFc = true;
		oFj = true;
		EFv = 2.5;
		vFX = 6.0;
		YFT = StatusBarBackgroundKind.Normal;
		vFB = 3.0;
		SFp = 0.0;
		YFb = 2.0;
		mFy = WindowBorderKind.MidContrast;
		fFf = WindowTitleBarBackgroundKind.Window;
		tF3 = BFh;
		eFt = iFm;
		RFJ = FontSizeKind.Medium;
		fF9 = FontSizeKind.Medium;
		base._002Ector();
		Name = themeName;
		Intent = intent;
		e7r = intent;
	}

	private BackgroundStateKind F79(BackgroundStateKind P_0)
	{
		if (P_0 == BackgroundStateKind.Normal)
		{
			return IsDarkTheme ? BackgroundStateKind.MidContrast : BackgroundStateKind.Accent;
		}
		return P_0;
	}

	public virtual void ResetArrowKind()
	{
		ArrowKind = ArrowKind.Chevron;
	}

	public virtual bool ShouldSerializeArrowKind()
	{
		return ArrowKind != ArrowKind.Chevron;
	}

	public virtual void ResetBarItemBackgroundGradientKind()
	{
		BarItemBackgroundGradientKind = GradientKind.None;
	}

	public virtual bool ShouldSerializeBarItemBackgroundGradientKind()
	{
		return BarItemBackgroundGradientKind != GradientKind.None;
	}

	public virtual void ResetBarItemBackgroundStateKind()
	{
		BarItemBackgroundStateKind = BackgroundStateKind.Normal;
	}

	public virtual bool ShouldSerializeBarItemBackgroundStateKind()
	{
		return BarItemBackgroundStateKind != BackgroundStateKind.Normal;
	}

	public virtual void ResetBarItemBorderContrastKind()
	{
		BarItemBorderContrastKind = BorderContrastKind.Lowest;
	}

	public virtual bool ShouldSerializeBarItemBorderContrastKind()
	{
		return BarItemBorderContrastKind != BorderContrastKind.Lowest;
	}

	public virtual void ResetBulletBorderWidth()
	{
		BulletBorderWidth = 1.0;
	}

	public virtual bool ShouldSerializeBulletBorderWidth()
	{
		return BulletBorderWidth != 1.0;
	}

	public virtual void ResetBulletGlyphKind()
	{
		BulletGlyphKind = BulletGlyphKind.Normal;
	}

	public virtual bool ShouldSerializeBulletGlyphKind()
	{
		return BulletGlyphKind != BulletGlyphKind.Normal;
	}

	public virtual void ResetBulletRelativeSize()
	{
		BulletRelativeSize = BulletChromeRelativeSize.Small;
	}

	public virtual bool ShouldSerializeBulletRelativeSize()
	{
		return BulletRelativeSize != BulletChromeRelativeSize.Small;
	}

	public virtual void ResetButtonBackgroundGradientKind()
	{
		ButtonBackgroundGradientKind = GradientKind.Low;
	}

	public virtual bool ShouldSerializeButtonBackgroundGradientKind()
	{
		return ButtonBackgroundGradientKind != GradientKind.Low;
	}

	public virtual void ResetButtonBorderContrastKind()
	{
		ButtonBorderContrastKind = BorderContrastKind.Mid;
	}

	public virtual bool ShouldSerializeButtonBorderContrastKind()
	{
		return ButtonBorderContrastKind != BorderContrastKind.Mid;
	}

	public virtual void ResetButtonCornerRadius()
	{
		ButtonCornerRadius = 3.0;
	}

	public virtual bool ShouldSerializeButtonCornerRadius()
	{
		return ButtonCornerRadius != 3.0;
	}

	public virtual void ResetButtonPadding()
	{
		ButtonPadding = CFi;
	}

	public virtual bool ShouldSerializeButtonPadding()
	{
		return ButtonPadding != CFi;
	}

	public virtual void ResetCheckBoxCornerRadius()
	{
		CheckBoxCornerRadius = 2.0;
	}

	public virtual bool ShouldSerializeCheckBoxCornerRadius()
	{
		return CheckBoxCornerRadius != 2.0;
	}

	public virtual ThemeDefinition Clone(string themeName, ThemeIntent intent)
	{
		ThemeDefinition themeDefinition = MemberwiseClone() as ThemeDefinition;
		if (themeDefinition != null)
		{
			themeDefinition.Name = themeName;
			themeDefinition.e7r = intent;
			themeDefinition.Intent = intent;
		}
		return themeDefinition;
	}

	public virtual void ResetContainerBorderContrastKind()
	{
		ContainerBorderContrastKind = BorderContrastKind.Mid;
	}

	public virtual bool ShouldSerializeContainerBorderContrastKind()
	{
		return ContainerBorderContrastKind != BorderContrastKind.Mid;
	}

	public virtual void ResetIntent()
	{
		Intent = e7r;
	}

	public virtual bool ShouldSerializeIntent()
	{
		return Intent != e7r;
	}

	public virtual void ResetListItemBackgroundGradientKind()
	{
		ListItemBackgroundGradientKind = GradientKind.None;
	}

	public virtual bool ShouldSerializeListItemBackgroundGradientKind()
	{
		return ListItemBackgroundGradientKind != GradientKind.None;
	}

	public virtual void ResetListItemBackgroundStateKind()
	{
		ListItemBackgroundStateKind = BackgroundStateKind.Normal;
	}

	public virtual bool ShouldSerializeListItemBackgroundStateKind()
	{
		return ListItemBackgroundStateKind != BackgroundStateKind.Normal;
	}

	public virtual void ResetListItemBorderContrastKind()
	{
		ListItemBorderContrastKind = BorderContrastKind.Lowest;
	}

	public virtual bool ShouldSerializeListItemBorderContrastKind()
	{
		return ListItemBorderContrastKind != BorderContrastKind.Lowest;
	}

	public virtual void ResetMenuItemIconColumnWidth()
	{
		MenuItemIconColumnWidth = 30.0;
	}

	public virtual bool ShouldSerializeMenuItemIconColumnWidth()
	{
		return MenuItemIconColumnWidth != 30.0;
	}

	public virtual void ResetMenuItemLargeIconColumnWidth()
	{
		MenuItemLargeIconColumnWidth = 50.0;
	}

	public virtual bool ShouldSerializeMenuItemLargeIconColumnWidth()
	{
		return MenuItemLargeIconColumnWidth != 50.0;
	}

	public virtual void ResetMenuItemPadding()
	{
		MenuItemPadding = HFS;
	}

	public virtual bool ShouldSerializeMenuItemPadding()
	{
		return MenuItemPadding != HFS;
	}

	public virtual void ResetMenuItemPopupColumnWidth()
	{
		MenuItemPopupColumnWidth = 30.0;
	}

	public virtual bool ShouldSerializeMenuItemPopupColumnWidth()
	{
		return MenuItemPopupColumnWidth != 30.0;
	}

	public virtual void ResetMenuPopupCornerRadius()
	{
		MenuPopupCornerRadius = 0.0;
	}

	public virtual bool ShouldSerializeMenuPopupCornerRadius()
	{
		return MenuPopupCornerRadius != 0.0;
	}

	public virtual void ResetName()
	{
		Name = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96520);
	}

	public virtual bool ShouldSerializeName()
	{
		return Name != WP6RZJql8gZrNhVA9v.L3hoFlcqP6(96520);
	}

	public virtual void ResetPopupBorderContrastKind()
	{
		PopupBorderContrastKind = BorderContrastKind.Mid;
	}

	public virtual bool ShouldSerializePopupBorderContrastKind()
	{
		return PopupBorderContrastKind != BorderContrastKind.Mid;
	}

	public virtual void ResetPopupCornerRadius()
	{
		PopupCornerRadius = 0.0;
	}

	public virtual bool ShouldSerializePopupCornerRadius()
	{
		return PopupCornerRadius != 0.0;
	}

	public virtual void ResetPopupShadowDirection()
	{
		PopupShadowDirection = 270;
	}

	public virtual bool ShouldSerializePopupShadowDirection()
	{
		return PopupShadowDirection != 270;
	}

	public virtual void ResetRequireDarkerBorders()
	{
		RequireDarkerBorders = true;
	}

	public virtual bool ShouldSerializeRequireDarkerBorders()
	{
		return !RequireDarkerBorders;
	}

	public virtual void ResetScrollBarHasButtons()
	{
		ScrollBarHasButtons = true;
	}

	public virtual bool ShouldSerializeScrollBarHasButtons()
	{
		return !ScrollBarHasButtons;
	}

	public virtual void ResetScrollBarThumbCornerRadius()
	{
		ScrollBarThumbCornerRadius = 2.5;
	}

	public virtual bool ShouldSerializeScrollBarThumbCornerRadius()
	{
		return ScrollBarThumbCornerRadius != 2.5;
	}

	public virtual void ResetScrollBarThumbMargin()
	{
		ScrollBarThumbMargin = 6.0;
	}

	public virtual bool ShouldSerializeScrollBarThumbMargin()
	{
		return ScrollBarThumbMargin != 6.0;
	}

	public virtual void ResetStatusBarBackgroundKind()
	{
		StatusBarBackgroundKind = StatusBarBackgroundKind.Normal;
	}

	public virtual bool ShouldSerializeStatusBarBackgroundKind()
	{
		return StatusBarBackgroundKind != StatusBarBackgroundKind.Normal;
	}

	public virtual void ResetTabCornerRadius()
	{
		TabCornerRadius = 3.0;
	}

	public virtual bool ShouldSerializeTabCornerRadius()
	{
		return TabCornerRadius != 3.0;
	}

	public virtual void ResetTitleBarCornerRadius()
	{
		TitleBarCornerRadius = 0.0;
	}

	public virtual bool ShouldSerializeTitleBarCornerRadius()
	{
		return TitleBarCornerRadius != 0.0;
	}

	public virtual void ResetToolBarButtonCornerRadius()
	{
		ToolBarButtonCornerRadius = 2.0;
	}

	public virtual bool ShouldSerializeToolBarButtonCornerRadius()
	{
		return ToolBarButtonCornerRadius != 2.0;
	}

	public virtual void ResetWindowBorderKind()
	{
		WindowBorderKind = WindowBorderKind.MidContrast;
	}

	public virtual bool ShouldSerializeWindowBorderKind()
	{
		return WindowBorderKind != WindowBorderKind.MidContrast;
	}

	public virtual void ResetWindowTitleBarBackgroundKind()
	{
		WindowTitleBarBackgroundKind = WindowTitleBarBackgroundKind.Window;
	}

	public virtual bool ShouldSerializeWindowTitleBarBackgroundKind()
	{
		return WindowTitleBarBackgroundKind != WindowTitleBarBackgroundKind.Window;
	}

	public virtual void ResetBaseFontSize()
	{
		BaseFontSize = BFh;
	}

	public virtual bool ShouldSerializeBaseFontSize()
	{
		return BaseFontSize != BFh;
	}

	public virtual void ResetDefaultFontFamily()
	{
		DefaultFontFamily = iFm;
	}

	public virtual bool ShouldSerializeDefaultFontFamily()
	{
		return (iFm == null && DefaultFontFamily != null) || (iFm != null && !iFm.Equals(DefaultFontFamily));
	}

	public virtual void ResetToolWindowContainerTitleFontSizeKind()
	{
		ToolWindowContainerTitleFontSizeKind = FontSizeKind.Medium;
	}

	public virtual bool ShouldSerializeToolWindowContainerTitleFontSizeKind()
	{
		return ToolWindowContainerTitleFontSizeKind != FontSizeKind.Medium;
	}

	public virtual void ResetWindowTitleFontSizeKind()
	{
		WindowTitleFontSizeKind = FontSizeKind.Medium;
	}

	public virtual bool ShouldSerializeWindowTitleFontSizeKind()
	{
		return WindowTitleFontSizeKind != FontSizeKind.Medium;
	}

	static ThemeDefinition()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		CFi = new Thickness(7.0, 2.0, 7.0, 2.0);
		HFS = new Thickness(2.0, 5.0, 2.0, 5.0);
		BFh = null;
		iFm = null;
	}

	internal static bool mf8()
	{
		return Bfg == null;
	}

	internal static ThemeDefinition cfj()
	{
		return Bfg;
	}
}
