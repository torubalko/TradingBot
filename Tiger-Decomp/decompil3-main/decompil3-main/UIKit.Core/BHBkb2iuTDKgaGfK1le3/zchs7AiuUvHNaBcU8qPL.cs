using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using bengxqsFHOBf5kWpcG0Y;
using EZmIFqiz5oDVq7Kw7dIG;
using gSJfigsFY1OGJ9yWyJhK;
using KvJdCOsJzwmqgaKKHKlv;
using lAZo0WsPn6tyQVhIALKn;
using qRDaGsizlSqIqJoUyrXr;

namespace BHBkb2iuTDKgaGfK1le3;

[TemplatePart(Name = "PART_ItemsPanel", Type = typeof(Panel))]
[TemplatePart(Name = "PART_SelectionIndicator", Type = typeof(FrameworkElement))]
public class zchs7AiuUvHNaBcU8qPL : Control
{
	public delegate void w86K7Kl2NOKA1mPHkNjr(object sender, qqKe4SizijYwT9xMuoBP e);

	private double EkYizfm5tqB;

	private double ygSiz9AocwA;

	private Panel FoNizn2mh6G;

	private Dictionary<object, CahRbBiz1UGRx7tbhujj> JMUizGod2rm;

	public static readonly DependencyProperty LyUizYBjkv8;

	public static readonly DependencyProperty p5cizoWKrqb;

	public static readonly DependencyProperty MFkizvAhA3X;

	public static readonly DependencyProperty vV5izB7P3VT;

	public static readonly RoutedEvent uc2iza4uO60;

	private static zchs7AiuUvHNaBcU8qPL n4sapbXvKWlUVHthMcv9;

	public DataTemplate ItemTemplate
	{
		get
		{
			return (DataTemplate)uUJ6BWXvwcoKXWdsVJV5(this, LyUizYBjkv8);
		}
		set
		{
			SetValue(LyUizYBjkv8, value2);
		}
	}

	public object SelectedItem
	{
		get
		{
			return GetValue(p5cizoWKrqb);
		}
		set
		{
			ab5MVjXv7fGxRR6mZxLg(this, p5cizoWKrqb, obj);
		}
	}

	public double ItemSpacing
	{
		get
		{
			return (double)uUJ6BWXvwcoKXWdsVJV5(this, MFkizvAhA3X);
		}
		set
		{
			ab5MVjXv7fGxRR6mZxLg(this, MFkizvAhA3X, num);
		}
	}

	public ObservableCollection<object> ItemsSource
	{
		get
		{
			return (ObservableCollection<object>)GetValue(vV5izB7P3VT);
		}
		set
		{
			SetValue(vV5izB7P3VT, value2);
		}
	}

	public event w86K7Kl2NOKA1mPHkNjr SelectedItemChanged
	{
		add
		{
			AddHandler(uc2iza4uO60, handler);
		}
		remove
		{
			xe4K0dXv8v57qniCtTty(this, uc2iza4uO60, w86K7Kl2NOKA1mPHkNjr);
		}
	}

	private static void nijiuy6lZ6Q(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is zchs7AiuUvHNaBcU8qPL zchs7AiuUvHNaBcU8qPL2))
		{
			return;
		}
		bool flag = default(bool);
		ObservableCollection<object> observableCollection2 = default(ObservableCollection<object>);
		while (true)
		{
			ObservableCollection<object> observableCollection = P_1.OldValue as ObservableCollection<object>;
			int num = 3;
			while (true)
			{
				switch (num)
				{
				case 3:
					flag = observableCollection != null;
					num = 4;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_faab0d03eb4e4bb7bc79fb35300cacbb == 0)
					{
						num = 1;
					}
					continue;
				default:
					observableCollection.CollectionChanged -= zchs7AiuUvHNaBcU8qPL2.qYuiuVp8Kf1;
					goto IL_0101;
				case 5:
					return;
				case 2:
					break;
				case 4:
					if (flag)
					{
						num = 0;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_883f478e115e47949c2e3479fe99223e != 0)
						{
							num = 0;
						}
						continue;
					}
					goto IL_0101;
				case 1:
					{
						if (observableCollection2 != null)
						{
							UyDC7vXvAfY3NSifFRBZ(observableCollection2, new NotifyCollectionChangedEventHandler(zchs7AiuUvHNaBcU8qPL2.qYuiuVp8Kf1));
							zchs7AiuUvHNaBcU8qPL2.ErLiuZuHVop(observableCollection2);
							num = 5;
							if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5cd8e53bfc054438a37c94de95b33088 == 0)
							{
								num = 4;
							}
							continue;
						}
						return;
					}
					IL_0101:
					observableCollection2 = P_1.NewValue as ObservableCollection<object>;
					num = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_df0a40d144cf4cfbb9b3ae4d9199b671 == 0)
					{
						num = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	private void ErLiuZuHVop(IList P_0)
	{
		int num = 3;
		int num2 = num;
		bool flag = default(bool);
		KeyValuePair<object, CahRbBiz1UGRx7tbhujj> keyValuePair = default(KeyValuePair<object, CahRbBiz1UGRx7tbhujj>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				flag = FoNizn2mh6G != null;
				num2 = 2;
				break;
			default:
				UBjiurdf2ba(P_0);
				if (JMUizGod2rm.Count <= 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f97c2b59553f423fb8445ca09317c97d == 0)
					{
						num2 = 1;
					}
					break;
				}
				keyValuePair = JMUizGod2rm.FirstOrDefault((KeyValuePair<object, CahRbBiz1UGRx7tbhujj> keyValuePair2) => SelectedItem?.Equals(keyValuePair2.Key) ?? false);
				if (keyValuePair.Key != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a0279c4ba1c84315962e441eb713cbcc == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 1;
			case 1:
				nwoiuhTOaOx();
				num2 = 4;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f81ebbf7757141e48ba3cbd647965ea5 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			case 2:
				if (!flag)
				{
					return;
				}
				rjyywhXvPi4mRHRFmITC(JMUizGod2rm);
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_045d0f7a0142410b9c67d902cef040ca == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				keyValuePair.Value.IsSelected = true;
				goto case 1;
			}
		}
	}

	private void qYuiuVp8Kf1(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		bool flag = default(bool);
		NotifyCollectionChangedAction notifyCollectionChangedAction = default(NotifyCollectionChangedAction);
		IEnumerator enumerator = default(IEnumerator);
		CahRbBiz1UGRx7tbhujj cahRbBiz1UGRx7tbhujj = default(CahRbBiz1UGRx7tbhujj);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				flag = FoNizn2mh6G == null;
				num2 = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_df0a40d144cf4cfbb9b3ae4d9199b671 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
			{
				NotifyCollectionChangedAction notifyCollectionChangedAction2 = YCYlhYXvJJdYLf1vUHMC(P_1);
				notifyCollectionChangedAction = notifyCollectionChangedAction2;
				if (notifyCollectionChangedAction == NotifyCollectionChangedAction.Add)
				{
					UBjiurdf2ba((IList)RnFHgXXvFXRRKbUgNIlI(P_1));
					return;
				}
				num2 = 3;
				break;
			}
			case 6:
				return;
			case 7:
				try
				{
					while (true)
					{
						int num3;
						if (!IUH3H0Xvz9iGm16XAgyE(enumerator))
						{
							num3 = 2;
							if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_80afc7eb1a6e4a8ea5ca9a872ecf5362 == 0)
							{
								num3 = 2;
							}
						}
						else
						{
							object key = JZl9Q9XvpVSmRZdP28q9(enumerator);
							if (!JMUizGod2rm.ContainsKey(key))
							{
								continue;
							}
							cahRbBiz1UGRx7tbhujj = JMUizGod2rm[key];
							num3 = 0;
							if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_f803e8ef04c14ef097ea51825f131558 == 0)
							{
								num3 = 0;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								return;
							default:
								cahRbBiz1UGRx7tbhujj.MouseLeftButtonUp -= iJeiuKL6jmF;
								num3 = 3;
								if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5a3bf026df2e4752aeee32ca0b5dd9a8 != 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								break;
							case 3:
								LH0JZ5XvuQuLiMQgMGES(FoNizn2mh6G.Children, cahRbBiz1UGRx7tbhujj);
								break;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable disposable)
					{
						stmAqeXB0LHG5M5sddDH(disposable);
						int num4 = 0;
						if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_d0223d742fec4f149986da581d0284c4 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				}
			case 1:
				if (flag)
				{
					return;
				}
				num2 = 4;
				break;
			case 0:
				return;
			case 5:
				return;
			case 3:
				if (notifyCollectionChangedAction == NotifyCollectionChangedAction.Remove)
				{
					enumerator = (IEnumerator)liSWXCXv3ItriLu0ZOYO(P_1.OldItems);
					num2 = 1;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_6d9219368a864c2d9c7ba55f24c4b4c6 != 0)
					{
						num2 = 7;
					}
					break;
				}
				return;
			}
		}
	}

	private static void hLwiuCfksjC(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		zchs7AiuUvHNaBcU8qPL zchs7AiuUvHNaBcU8qPL2 = P_0 as zchs7AiuUvHNaBcU8qPL;
		int num;
		if (zchs7AiuUvHNaBcU8qPL2 == null)
		{
			num = 2;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_1c958f34803646f7bd8283df13e97b54 != 0)
			{
				num = 2;
			}
		}
		else
		{
			zchs7AiuUvHNaBcU8qPL2.AhRiuwWrstV();
			if (!zchs7AiuUvHNaBcU8qPL2.JMUizGod2rm.ContainsKey(P_1.NewValue))
			{
				return;
			}
			num = 3;
		}
		CahRbBiz1UGRx7tbhujj cahRbBiz1UGRx7tbhujj = default(CahRbBiz1UGRx7tbhujj);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				cahRbBiz1UGRx7tbhujj.IsSelected = true;
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_676a22a67a2e42df98963bf8d98eb889 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				cahRbBiz1UGRx7tbhujj = zchs7AiuUvHNaBcU8qPL2.JMUizGod2rm[P_1.NewValue];
				num = 1;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_b722cf66163942b8bd102d3477674df0 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				return;
			case 0:
				return;
			}
		}
	}

	private void UBjiurdf2ba(IList P_0)
	{
		int num = 3;
		int num2 = num;
		object current = default(object);
		CahRbBiz1UGRx7tbhujj cahRbBiz1UGRx7tbhujj = default(CahRbBiz1UGRx7tbhujj);
		while (true)
		{
			switch (num2)
			{
			case 3:
				FoNizn2mh6G.Children.Clear();
				num2 = 2;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_b27b24728ab74165bf1db9dac9d36fc6 != 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
			{
				if (P_0 == null)
				{
					return;
				}
				IEnumerator enumerator = P_0.GetEnumerator();
				try
				{
					while (true)
					{
						IL_00c6:
						int num3;
						if (enumerator.MoveNext())
						{
							current = enumerator.Current;
							CahRbBiz1UGRx7tbhujj obj = new CahRbBiz1UGRx7tbhujj
							{
								Content = current
							};
							bfOjysXB2l6hW6NqcJe9(obj, ItemTemplate);
							obj.Margin = new Thickness(ItemSpacing, 0.0, 0.0, 0.0);
							cahRbBiz1UGRx7tbhujj = obj;
							num3 = 1;
							if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_b27b24728ab74165bf1db9dac9d36fc6 == 0)
							{
								num3 = 2;
							}
						}
						else
						{
							num3 = 0;
							if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e1a6c635ab4940dbb3ffcd364da08562 != 0)
							{
								num3 = 1;
							}
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								bb2NASXBHbcEUSbR787X(cahRbBiz1UGRx7tbhujj, new MouseButtonEventHandler(iJeiuKL6jmF));
								num3 = 0;
								if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_6cac8bca385d4f06aa9f854441c8d5db != 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								goto end_IL_0046;
							}
							JMUizGod2rm.Add(current, cahRbBiz1UGRx7tbhujj);
							((UIElementCollection)W6Oe9SXBfM8nQ8ZENkyU(FoNizn2mh6G)).Add((UIElement)cahRbBiz1UGRx7tbhujj);
							goto IL_00c6;
							continue;
							end_IL_0046:
							break;
						}
						break;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num4 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5a3bf026df2e4752aeee32ca0b5dd9a8 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						disposable?.Dispose();
						break;
					}
				}
				break;
			}
			case 1:
				return;
			}
			y82R8iXBnrIDbctBmrGB(FoNizn2mh6G, new Thickness(FoNizn2mh6G.Margin.Left - ItemSpacing, FoNizn2mh6G.Margin.Top, FoNizn2mh6G.Margin.Right, bA1UxfXB99MfH2WxDRNW(FoNizn2mh6G).Bottom));
			num2 = 1;
			if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_d226d78a4e104f1db903a0d012416f7b == 0)
			{
				num2 = 1;
			}
		}
	}

	private void iJeiuKL6jmF(object P_0, MouseButtonEventArgs P_1)
	{
		int num = 2;
		CahRbBiz1UGRx7tbhujj cahRbBiz1UGRx7tbhujj = default(CahRbBiz1UGRx7tbhujj);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (cahRbBiz1UGRx7tbhujj == null)
					{
						return;
					}
					goto end_IL_0012;
				case 3:
					cahRbBiz1UGRx7tbhujj.IsSelected = true;
					num2 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_b722cf66163942b8bd102d3477674df0 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					cahRbBiz1UGRx7tbhujj = P_0 as CahRbBiz1UGRx7tbhujj;
					num2 = 1;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_e0422e3937cf4958b4c4343ee25d0b9a == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			AhRiuwWrstV();
			SelectedItem = cahRbBiz1UGRx7tbhujj.Content;
			num = 3;
		}
	}

	public zchs7AiuUvHNaBcU8qPL()
	{
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		EkYizfm5tqB = 0.0;
		ygSiz9AocwA = 0.0;
		JMUizGod2rm = new Dictionary<object, CahRbBiz1UGRx7tbhujj>();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_6cac8bca385d4f06aa9f854441c8d5db == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				Nb3BqsXBGldGjCfD62ij(this, new SizeChangedEventHandler(MYtium5F59j));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5181c84710c64ff897e0d62573bc5717 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 1:
				ItemsSource = new ObservableCollection<object>();
				num = 2;
				break;
			}
		}
	}

	private void MYtium5F59j(object P_0, SizeChangedEventArgs P_1)
	{
		nwoiuhTOaOx();
	}

	private void nwoiuhTOaOx()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				EkYizfm5tqB = (base.ActualWidth - base.Padding.Left - base.Padding.Right - (double)(IV5tRDXBYF1trBwKoq4I(JMUizGod2rm) - 1) * ItemSpacing) / (double)JMUizGod2rm.Count;
				num2 = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_a4dd3ba864e24f44bf9ef3932a4f38e3 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ygSiz9AocwA = Tkd9mhXBoSCvs1PybNDN(this) - base.Padding.Top - base.Padding.Bottom;
			using Dictionary<object, CahRbBiz1UGRx7tbhujj>.Enumerator enumerator = JMUizGod2rm.GetEnumerator();
			while (true)
			{
				int num3;
				if (!enumerator.MoveNext())
				{
					num3 = 0;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_540f760caa314ecc92f28221e7d6062f == 0)
					{
						num3 = 0;
					}
				}
				else
				{
					KeyValuePair<object, CahRbBiz1UGRx7tbhujj> current = enumerator.Current;
					current.Value.Width = Math.Max(0.0, EkYizfm5tqB);
					current.Value.Height = MkYnZ3XBv3Wudli5VBCg(0.0, ygSiz9AocwA);
					num3 = 1;
					if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_72636cc658db410dbd2030e9fe5ca30c != 0)
					{
						num3 = 1;
					}
				}
				switch (num3)
				{
				default:
					return;
				case 1:
					break;
				case 0:
					return;
				}
			}
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		FoNizn2mh6G = GetTemplateChild(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x706541F3 ^ 0x706548AD)) as Panel;
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_13019221e20c438386b6c8d9a8967f7c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		ErLiuZuHVop(ItemsSource);
	}

	private void AhRiuwWrstV()
	{
		using Dictionary<object, CahRbBiz1UGRx7tbhujj>.Enumerator enumerator = JMUizGod2rm.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.IsSelected = false;
		}
		int num = 0;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_5cd8e53bfc054438a37c94de95b33088 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static zchs7AiuUvHNaBcU8qPL()
	{
		YqHEhkXBBSi5Odmt5bmv();
		HandHqsFGhqpm8Ixav52.kLjw4iIsCLsZtxc4lksN0j();
		RwEN8CsJudtSqX6iB0vv.D4wX52wcDDu();
		LyUizYBjkv8 = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(-1306877528 ^ -1306876102), fGdaxZXBasFravx183Qe(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(16777294)), fGdaxZXBasFravx183Qe(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554473)));
		p5cizoWKrqb = DependencyProperty.Register(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x7DB10E6E ^ 0x7DB107EE), fGdaxZXBasFravx183Qe(uZ9GbyXBiXBeYU2rsTye(16777236)), Type.GetTypeFromHandle(uZ9GbyXBiXBeYU2rsTye(33554473)), new PropertyMetadata(null, hLwiuCfksjC));
		int num = 1;
		if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_148384daf661411383613097e5a99904 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				uc2iza4uO60 = EventManager.RegisterRoutedEvent((string)IMnblhXBlUocPSnC3ltf(-673683647 ^ -673681673), RoutingStrategy.Bubble, fGdaxZXBasFravx183Qe(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554474)), Type.GetTypeFromHandle(uZ9GbyXBiXBeYU2rsTye(33554473)));
				return;
			case 1:
				MFkizvAhA3X = (DependencyProperty)J5gjLyXB404jGqMhkIsK(IMnblhXBlUocPSnC3ltf(0x7F55E538 ^ 0x7F55ECA4), Type.GetTypeFromHandle(uZ9GbyXBiXBeYU2rsTye(16777298)), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554473)), new FrameworkPropertyMetadata(5.0));
				num = 2;
				break;
			case 2:
				vV5izB7P3VT = (DependencyProperty)J5gjLyXB404jGqMhkIsK(OQNZEtsP93U56NxbHlup.BeJsPcmdLda(0x130FEA25 ^ 0x130FEC5D), typeof(ObservableCollection<object>), Type.GetTypeFromHandle(H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(33554473)), new PropertyMetadata(nijiuy6lZ6Q));
				num = 0;
				if (_003CModule_003E_007Bac03c99d_002D3996_002D4c8b_002D8609_002D241770b9ef1d_007D.m_4c8ecf325a364ca59e2eb4ef96febad8 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private bool WV0iu73SIqR(KeyValuePair<object, CahRbBiz1UGRx7tbhujj> P_0)
	{
		return SelectedItem?.Equals(P_0.Key) ?? false;
	}

	internal static object uUJ6BWXvwcoKXWdsVJV5(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static bool it4OUnXvmnZfoKPBLHVw()
	{
		return n4sapbXvKWlUVHthMcv9 == null;
	}

	internal static zchs7AiuUvHNaBcU8qPL dtqVLnXvhhLbBROlXYdD()
	{
		return n4sapbXvKWlUVHthMcv9;
	}

	internal static void ab5MVjXv7fGxRR6mZxLg(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void xe4K0dXv8v57qniCtTty(object P_0, object P_1, object P_2)
	{
		((UIElement)P_0).RemoveHandler((RoutedEvent)P_1, (Delegate)P_2);
	}

	internal static void UyDC7vXvAfY3NSifFRBZ(object P_0, object P_1)
	{
		((ObservableCollection<object>)P_0).CollectionChanged += (NotifyCollectionChangedEventHandler)P_1;
	}

	internal static void rjyywhXvPi4mRHRFmITC(object P_0)
	{
		((Dictionary<object, CahRbBiz1UGRx7tbhujj>)P_0).Clear();
	}

	internal static NotifyCollectionChangedAction YCYlhYXvJJdYLf1vUHMC(object P_0)
	{
		return ((NotifyCollectionChangedEventArgs)P_0).Action;
	}

	internal static object RnFHgXXvFXRRKbUgNIlI(object P_0)
	{
		return ((NotifyCollectionChangedEventArgs)P_0).NewItems;
	}

	internal static object liSWXCXv3ItriLu0ZOYO(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object JZl9Q9XvpVSmRZdP28q9(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static void LH0JZ5XvuQuLiMQgMGES(object P_0, object P_1)
	{
		((UIElementCollection)P_0).Remove((UIElement)P_1);
	}

	internal static bool IUH3H0Xvz9iGm16XAgyE(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void stmAqeXB0LHG5M5sddDH(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void bfOjysXB2l6hW6NqcJe9(object P_0, object P_1)
	{
		((CahRbBiz1UGRx7tbhujj)P_0).ContentTemplate = (DataTemplate)P_1;
	}

	internal static void bb2NASXBHbcEUSbR787X(object P_0, object P_1)
	{
		((UIElement)P_0).MouseLeftButtonUp += (MouseButtonEventHandler)P_1;
	}

	internal static object W6Oe9SXBfM8nQ8ZENkyU(object P_0)
	{
		return ((Panel)P_0).Children;
	}

	internal static Thickness bA1UxfXB99MfH2WxDRNW(object P_0)
	{
		return ((FrameworkElement)P_0).Margin;
	}

	internal static void y82R8iXBnrIDbctBmrGB(object P_0, Thickness P_1)
	{
		((FrameworkElement)P_0).Margin = P_1;
	}

	internal static void Nb3BqsXBGldGjCfD62ij(object P_0, object P_1)
	{
		((FrameworkElement)P_0).SizeChanged += (SizeChangedEventHandler)P_1;
	}

	internal static int IV5tRDXBYF1trBwKoq4I(object P_0)
	{
		return ((Dictionary<object, CahRbBiz1UGRx7tbhujj>)P_0).Count;
	}

	internal static double Tkd9mhXBoSCvs1PybNDN(object P_0)
	{
		return ((FrameworkElement)P_0).ActualHeight;
	}

	internal static double MkYnZ3XBv3Wudli5VBCg(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void YqHEhkXBBSi5Odmt5bmv()
	{
		OQNZEtsP93U56NxbHlup.tMIsP5FCtWb();
	}

	internal static Type fGdaxZXBasFravx183Qe(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static RuntimeTypeHandle uZ9GbyXBiXBeYU2rsTye(int token)
	{
		return H3LhbasF2i0Iy16mjsXM.Od6X5H5fBxU(token);
	}

	internal static object IMnblhXBlUocPSnC3ltf(int P_0)
	{
		return OQNZEtsP93U56NxbHlup.BeJsPcmdLda(P_0);
	}

	internal static object J5gjLyXB404jGqMhkIsK(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
