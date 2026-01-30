using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;

namespace UIKit.Core;

public class ColorsPallet : Control
{
	public static readonly DependencyProperty BiXiJq7ef6q;

	public static readonly DependencyProperty BmCiJIkFWdG;

	public static readonly DependencyProperty WhgiJWnaIs0;

	public static readonly DependencyProperty NwxiJtLwG2C;

	public static readonly DependencyProperty MsXiJUHaaey;

	public static readonly DependencyProperty jDViJTQ3UEr;

	public static readonly DependencyProperty jlqiJys8ocU;

	private static ColorsPallet DuC6gWXYFp8jACIfI1So;

	public IEnumerable ItemsSource
	{
		get
		{
			return (IEnumerable)GetValue(BiXiJq7ef6q);
		}
		set
		{
			SetValue(BiXiJq7ef6q, value2);
		}
	}

	public DataTemplate ItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(BmCiJIkFWdG);
		}
		set
		{
			SetValue(BmCiJIkFWdG, value2);
		}
	}

	public DataTemplateSelector ItemTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(WhgiJWnaIs0);
		}
		set
		{
			SetValue(WhgiJWnaIs0, value2);
		}
	}

	public bool IsItemActiveView
	{
		get
		{
			return (bool)GetValue(NwxiJtLwG2C);
		}
		set
		{
			SetValue(NwxiJtLwG2C, flag);
		}
	}

	public string HintPropertyName
	{
		get
		{
			return (string)GetValue(MsXiJUHaaey);
		}
		set
		{
			SetValue(MsXiJUHaaey, value2);
		}
	}

	public Thickness ItemMargin
	{
		get
		{
			return (Thickness)xPDx2sXYuCqIhPY6N0D4(this, jDViJTQ3UEr);
		}
		set
		{
			SetValue(jDViJTQ3UEr, thickness);
		}
	}

	public ICommand ItemClickCommand
	{
		get
		{
			return (ICommand)xPDx2sXYuCqIhPY6N0D4(this, jlqiJys8ocU);
		}
		set
		{
			SetValue(jlqiJys8ocU, value2);
		}
	}

	public ColorsPallet()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_045d0f7a0142410b9c67d902cef040ca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.DefaultStyleKey = Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554465));
	}

	static ColorsPallet()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				WhgiJWnaIs0 = (DependencyProperty)VKa6LSXoHD55M4hxYcgO(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x5CD4F15 ^ 0x5CD49BB), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777322)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554465)));
				NwxiJtLwG2C = DependencyProperty.Register((string)gtLHEQXofyXTOHG3Jnru(-1736566656 ^ -1736565158), Type.GetTypeFromHandle(iKKVfJXo0w4iy2UPSjQb(16777220)), hpAFjqXo23VEo7agDyNY(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554465)), new PropertyMetadata(false));
				MsXiJUHaaey = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(--500511424 ^ 0x1DD5343E), hpAFjqXo23VEo7agDyNY(iKKVfJXo0w4iy2UPSjQb(16777225)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554465)));
				jDViJTQ3UEr = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x385FFAB ^ 0x385F889), hpAFjqXo23VEo7agDyNY(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777299)), Type.GetTypeFromHandle(iKKVfJXo0w4iy2UPSjQb(33554465)));
				num = 2;
				continue;
			case 2:
				jlqiJys8ocU = (DependencyProperty)VKa6LSXoHD55M4hxYcgO(gtLHEQXofyXTOHG3Jnru(0x12620268 ^ 0x12620552), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777255)), hpAFjqXo23VEo7agDyNY(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554465)));
				return;
			case 3:
				TVYPCdXYzW0WAHvYawi7();
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e45e5ac62513442e89d79a2fa6de9ea2 == 0)
				{
					num = 0;
				}
				continue;
			}
			BiXiJq7ef6q = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-165474503 ^ -165476031), Type.GetTypeFromHandle(iKKVfJXo0w4iy2UPSjQb(16777321)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554465)));
			BmCiJIkFWdG = (DependencyProperty)VKa6LSXoHD55M4hxYcgO(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x22BF43FC ^ 0x22BF456E), Type.GetTypeFromHandle(iKKVfJXo0w4iy2UPSjQb(16777294)), hpAFjqXo23VEo7agDyNY(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554465)));
			num = 0;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_22f1d8a6a91b4fb198e1e1bbe4572bc0 != 0)
			{
				num = 1;
			}
		}
	}

	internal static bool tRVIHmXY3FN03txLTpc0()
	{
		return DuC6gWXYFp8jACIfI1So == null;
	}

	internal static ColorsPallet ndojS3XYp4scC8XwuHjx()
	{
		return DuC6gWXYFp8jACIfI1So;
	}

	internal static object xPDx2sXYuCqIhPY6N0D4(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void TVYPCdXYzW0WAHvYawi7()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
	}

	internal static RuntimeTypeHandle iKKVfJXo0w4iy2UPSjQb(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static Type hpAFjqXo23VEo7agDyNY(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object VKa6LSXoHD55M4hxYcgO(object P_0, Type P_1, Type P_2)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2);
	}

	internal static object gtLHEQXofyXTOHG3Jnru(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}
}
