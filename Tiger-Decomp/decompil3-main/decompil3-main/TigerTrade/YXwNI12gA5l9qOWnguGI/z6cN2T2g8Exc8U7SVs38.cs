using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using cGFTGT9OgrCCY0OLJKa5;
using ciQ7MQHkM693awgKHy3A;
using EBnLmi9qWlLIutDAM7P4;
using ECOEgqlSad8NUJZ2Dr9n;
using gFW24n96BPbYOueh6TcD;
using iqasfE9M1MYMbvIsWwBJ;
using jS3Y2j9pTQRy0FnOknFG;
using Mjla299M344ZWOF3ROHJ;
using tDAqfc96gQunxvidsGQE;
using TigerTrade.Chart.Objects.Abstract;
using TigerTrade.Chart.Objects.Common;
using TigerTrade.Chart.Objects.Enums;
using TigerTrade.Chart.Objects.List;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;
using VNNS7k9MJWTB0F2UfSVa;
using WBx5p4iBSWxMoitgY88w;

namespace YXwNI12gA5l9qOWnguGI;

internal class z6cN2T2g8Exc8U7SVs38 : aUQvKjHk6H77hbYGG0GM, poLM8x9MPUgdGZpBmXt9, IComponentConnector
{
	private double V2c2RZME83J;

	private double xD42RVi4KBs;

	private ObjectBase h4X2RCsVqy4;

	private jjKtVJ9pUSOpdg38tqnP OGp2RrcWtwt;

	[CompilerGenerated]
	private Action<rl9GXq9MFNRC5VT7hPqj> m_Command;

	private ICommand BuC2RKuL2NB;

	private ICommand S9T2RmW5F8j;

	internal Thumb Thumb;

	private bool tsg2RhOcvhx;

	private static z6cN2T2g8Exc8U7SVs38 kDLr154PbtRWslLJSRMj;

	public double Left
	{
		get
		{
			return V2c2RZME83J;
		}
		set
		{
			if (!v2c2RZME83J.Equals(V2c2RZME83J))
			{
				V2c2RZME83J = v2c2RZME83J;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(-1416986301 ^ -1417001363));
			}
		}
	}

	public double Top
	{
		get
		{
			return xD42RVi4KBs;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (!num3.Equals(xD42RVi4KBs))
					{
						xD42RVi4KBs = num3;
						cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(0x2D3134C9 ^ 0x2D31F3F3));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ICommand PanelCommand => BuC2RKuL2NB ?? (BuC2RKuL2NB = new RelayCommand(delegate(object P_0)
	{
		kml2g3VFWG9(P_0 as string);
	}));

	public Brush LineColor1Brush => new SolidColorBrush(LineColor1);

	public Color LineColor1
	{
		get
		{
			int num = 1;
			int num2 = num;
			LineObjectBase lineObjectBase = default(LineObjectBase);
			PolygonObjectBase polygonObjectBase = default(PolygonObjectBase);
			while (true)
			{
				switch (num2)
				{
				default:
					if (lineObjectBase != null)
					{
						return LFDueT4PjEZqdYppOHTw(lineObjectBase.LineColor);
					}
					polygonObjectBase = h4X2RCsVqy4 as PolygonObjectBase;
					if (polygonObjectBase == null)
					{
						return CfwFfF4PEkObAHwjLeZm();
					}
					goto case 2;
				case 1:
					lineObjectBase = h4X2RCsVqy4 as LineObjectBase;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return LFDueT4PjEZqdYppOHTw(polygonObjectBase.LineColor);
				}
			}
		}
		set
		{
			int num = 1;
			LineObjectBase lineObjectBase = default(LineObjectBase);
			PolygonObjectBase polygonObjectBase = default(PolygonObjectBase);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						lineObjectBase = h4X2RCsVqy4 as LineObjectBase;
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
						{
							num2 = 0;
						}
						continue;
					case 3:
						cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x34407BB ^ 0x344C0FF));
						cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(-894902996 ^ -894952796));
						num2 = 5;
						continue;
					case 7:
						if (FF8klW4PgIMDgoShEtQ8(LFDueT4PjEZqdYppOHTw(tZRNgL4Pdd3r7xbPxQMA(polygonObjectBase)), color))
						{
							polygonObjectBase.LineColor = color;
							num = 3;
							break;
						}
						return;
					case 5:
					{
						Action<rl9GXq9MFNRC5VT7hPqj> action2 = this.Command;
						if (action2 == null)
						{
							return;
						}
						action2((rl9GXq9MFNRC5VT7hPqj)4);
						num = 6;
						break;
					}
					default:
						if (lineObjectBase != null)
						{
							if ((Color)CqoTIf4PQS1oC09A9fCU(lineObjectBase) != color)
							{
								lineObjectBase.LineColor = color;
								cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(0x34407BB ^ 0x344C0FF));
								num2 = 3;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
								{
									num2 = 4;
								}
								continue;
							}
							return;
						}
						polygonObjectBase = h4X2RCsVqy4 as PolygonObjectBase;
						if (polygonObjectBase == null)
						{
							return;
						}
						goto case 7;
					case 4:
					{
						cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-198991962 ^ -199010258));
						Action<rl9GXq9MFNRC5VT7hPqj> action = this.Command;
						if (action == null)
						{
							num2 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
							{
								num2 = 2;
							}
							continue;
						}
						action((rl9GXq9MFNRC5VT7hPqj)4);
						return;
					}
					case 6:
						return;
					case 2:
						return;
					}
					break;
				}
			}
		}
	}

	public Visibility LineColor1Visibility
	{
		get
		{
			if (!(h4X2RCsVqy4 is LineObjectBase))
			{
				if (!(h4X2RCsVqy4 is PolygonObjectBase))
				{
					goto IL_0043;
				}
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
			}
			if (!(h4X2RCsVqy4 is StFuPkiB5NwB49ql7Kjg))
			{
				return Visibility.Visible;
			}
			goto IL_0043;
			IL_0043:
			return Visibility.Collapsed;
		}
	}

	public Brush LineColor2Brush => new SolidColorBrush(LineColor2);

	public Color LineColor2
	{
		get
		{
			if (h4X2RCsVqy4 is HorizontalLineObject horizontalLineObject)
			{
				return LFDueT4PjEZqdYppOHTw(horizontalLineObject.ActiveAlertLineColor);
			}
			return CfwFfF4PEkObAHwjLeZm();
		}
		set
		{
			int num = 1;
			int num2 = num;
			HorizontalLineObject horizontalLineObject = default(HorizontalLineObject);
			while (true)
			{
				switch (num2)
				{
				case 3:
				{
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-690510723 ^ -690527341));
					Action<rl9GXq9MFNRC5VT7hPqj> action = this.Command;
					if (action == null)
					{
						return;
					}
					action((rl9GXq9MFNRC5VT7hPqj)4);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
					{
						num2 = 2;
					}
					break;
				}
				case 1:
					horizontalLineObject = h4X2RCsVqy4 as HorizontalLineObject;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				default:
					if (horizontalLineObject == null)
					{
						return;
					}
					wdjCvK4PRo8lTfOMrUT3(horizontalLineObject, color);
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1962651919 ^ -1962636965));
					num2 = 3;
					break;
				}
			}
		}
	}

	public Visibility LineColor2Visibility
	{
		get
		{
			if (h4X2RCsVqy4 is HorizontalLineObject)
			{
				return Visibility.Visible;
			}
			return Visibility.Collapsed;
		}
	}

	public int LineWidth1
	{
		get
		{
			int num = 2;
			int num2 = num;
			LineObjectBase lineObjectBase = default(LineObjectBase);
			PolygonObjectBase polygonObjectBase = default(PolygonObjectBase);
			while (true)
			{
				switch (num2)
				{
				case 2:
					lineObjectBase = h4X2RCsVqy4 as LineObjectBase;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (lineObjectBase != null)
					{
						return ekTJmy4P6w6cNcRuxxMs(lineObjectBase) - 1;
					}
					polygonObjectBase = h4X2RCsVqy4 as PolygonObjectBase;
					if (polygonObjectBase != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return 0;
				default:
					return polygonObjectBase.LineWidth - 1;
				}
			}
		}
		set
		{
			LineObjectBase lineObjectBase = h4X2RCsVqy4 as LineObjectBase;
			int num;
			PolygonObjectBase polygonObjectBase = default(PolygonObjectBase);
			if (lineObjectBase != null)
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
				{
					num = 0;
				}
			}
			else
			{
				polygonObjectBase = h4X2RCsVqy4 as PolygonObjectBase;
				num = 3;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					if (lineObjectBase.LineWidth != num2 + 1)
					{
						lineObjectBase.LineWidth = num2 + 1;
						cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(0x6D18F862 ^ 0x6D183072));
						int num3 = 4;
						num = num3;
						break;
					}
					return;
				case 4:
					this.Command?.Invoke((rl9GXq9MFNRC5VT7hPqj)4);
					return;
				case 5:
					OCvqrI4PMIhLTNZFfOSj(polygonObjectBase, num2 + 1);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
					{
						num = 0;
					}
					break;
				default:
				{
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7D553BE0 ^ 0x7D55F3F0));
					Action<rl9GXq9MFNRC5VT7hPqj> action = this.Command;
					if (action == null)
					{
						num = 2;
						break;
					}
					action((rl9GXq9MFNRC5VT7hPqj)4);
					return;
				}
				case 3:
					if (polygonObjectBase != null && polygonObjectBase.LineWidth != num2 + 1)
					{
						num = 5;
						break;
					}
					return;
				case 2:
					return;
				}
			}
		}
	}

	public Visibility LineWidth1Visibility
	{
		get
		{
			if (!(h4X2RCsVqy4 is LineObjectBase))
			{
				if (!(h4X2RCsVqy4 is PolygonObjectBase) || h4X2RCsVqy4 is StFuPkiB5NwB49ql7Kjg)
				{
					return Visibility.Collapsed;
				}
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
			}
			return Visibility.Visible;
		}
	}

	public int LineStyle1
	{
		get
		{
			if (!(h4X2RCsVqy4 is LineObjectBase lineObjectBase))
			{
				if (h4X2RCsVqy4 is PolygonObjectBase polygonObjectBase)
				{
					int num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
					{
						num = 0;
					}
					return num switch
					{
						_ => (int)polygonObjectBase.LineStyle, 
					};
				}
				return 0;
			}
			return (int)lineObjectBase.LineStyle;
		}
		set
		{
			int num = 3;
			int num2 = num;
			LineObjectBase lineObjectBase = default(LineObjectBase);
			PolygonObjectBase polygonObjectBase = default(PolygonObjectBase);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1306877528 ^ -1306891780));
					num2 = 5;
					break;
				case 5:
				{
					Action<rl9GXq9MFNRC5VT7hPqj> action = this.Command;
					if (action == null)
					{
						return;
					}
					action((rl9GXq9MFNRC5VT7hPqj)4);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 2:
					if (lineObjectBase != null)
					{
						if (GJLfJM4PODU9H4dfulou(lineObjectBase) != (XDashStyle)num3)
						{
							rrNqnJ4PqQObdsuuTRIM(lineObjectBase, (XDashStyle)num3);
							cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2074141628 ^ -2074094576));
							this.Command?.Invoke((rl9GXq9MFNRC5VT7hPqj)4);
						}
						return;
					}
					polygonObjectBase = h4X2RCsVqy4 as PolygonObjectBase;
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					lineObjectBase = h4X2RCsVqy4 as LineObjectBase;
					num2 = 2;
					break;
				case 6:
					if (uiUGCo4PI9xK5n6eiDIB(polygonObjectBase) != (XDashStyle)num3)
					{
						polygonObjectBase.LineStyle = (XDashStyle)num3;
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
						{
							num2 = 1;
						}
						break;
					}
					return;
				case 0:
					return;
				case 4:
					if (polygonObjectBase == null)
					{
						return;
					}
					num2 = 6;
					break;
				}
			}
		}
	}

	public Visibility LineStyle1Visibility
	{
		get
		{
			if ((h4X2RCsVqy4 is LineObjectBase || h4X2RCsVqy4 is PolygonObjectBase) && !(h4X2RCsVqy4 is StFuPkiB5NwB49ql7Kjg))
			{
				return Visibility.Visible;
			}
			return Visibility.Collapsed;
		}
	}

	public Color BackColor1
	{
		get
		{
			if (h4X2RCsVqy4 is PolygonObjectBase polygonObjectBase)
			{
				return HPj23n4PWxjnio6c6Oxf(polygonObjectBase);
			}
			if (h4X2RCsVqy4 is IconObject iconObject)
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
				{
					num = 0;
				}
				return num switch
				{
					_ => iconObject.Color, 
				};
			}
			return Colors.Transparent;
		}
		set
		{
			PolygonObjectBase polygonObjectBase = h4X2RCsVqy4 as PolygonObjectBase;
			IconObject iconObject = default(IconObject);
			int num;
			if (polygonObjectBase == null)
			{
				iconObject = h4X2RCsVqy4 as IconObject;
				if (iconObject == null)
				{
					return;
				}
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
				{
					num = 3;
				}
			}
			else
			{
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 != 0)
				{
					num = 5;
				}
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 4:
					return;
				case 3:
				{
					if (!(LFDueT4PjEZqdYppOHTw(iconObject.Color) != color))
					{
						return;
					}
					iconObject.Color = color;
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1346994499 ^ -1346980315));
					Action<rl9GXq9MFNRC5VT7hPqj> action2 = this.Command;
					if (action2 == null)
					{
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
						{
							num = 0;
						}
						break;
					}
					action2((rl9GXq9MFNRC5VT7hPqj)4);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
					{
						num = 0;
					}
					break;
				}
				case 0:
					return;
				case 5:
				{
					if (!((Color)polygonObjectBase.BackColor != color))
					{
						return;
					}
					polygonObjectBase.BackColor = color;
					cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(-1461292091 ^ -1461273763));
					Action<rl9GXq9MFNRC5VT7hPqj> action = this.Command;
					if (action == null)
					{
						num = 2;
						break;
					}
					action((rl9GXq9MFNRC5VT7hPqj)4);
					num = 4;
					break;
				}
				case 2:
					return;
				case 1:
					return;
				}
			}
		}
	}

	public Visibility BackColor1Visibility
	{
		get
		{
			if ((h4X2RCsVqy4 is PolygonObjectBase || h4X2RCsVqy4 is IconObject) && !(h4X2RCsVqy4 is StFuPkiB5NwB49ql7Kjg))
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
				{
					num = 0;
				}
				return num switch
				{
					_ => Visibility.Visible, 
				};
			}
			return Visibility.Collapsed;
		}
	}

	public int Size
	{
		get
		{
			LabelObject labelObject = h4X2RCsVqy4 as LabelObject;
			if (labelObject == null)
			{
				IconObject iconObject = h4X2RCsVqy4 as IconObject;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
				{
					num = 1;
				}
				switch (num)
				{
				case 1:
					if (iconObject != null)
					{
						return kj1VTp4Ptuj4p6K2MLFM(iconObject);
					}
					return 0;
				}
			}
			return labelObject.FontSize;
		}
		set
		{
			int num = 6;
			int num2 = num;
			IconObject iconObject = default(IconObject);
			LabelObject labelObject = default(LabelObject);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
				{
					iconObject.Size = num3;
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x9F0F634 ^ 0x9F09632));
					Action<rl9GXq9MFNRC5VT7hPqj> action = this.Command;
					if (action == null)
					{
						num2 = 4;
						break;
					}
					action((rl9GXq9MFNRC5VT7hPqj)4);
					return;
				}
				case 6:
					labelObject = h4X2RCsVqy4 as LabelObject;
					num2 = 5;
					break;
				case 3:
				{
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x3301F7A9));
					Action<rl9GXq9MFNRC5VT7hPqj> action2 = this.Command;
					if (action2 == null)
					{
						return;
					}
					action2((rl9GXq9MFNRC5VT7hPqj)4);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 1:
					if (kj1VTp4Ptuj4p6K2MLFM(iconObject) == num3)
					{
						return;
					}
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
					{
						num2 = 1;
					}
					break;
				case 5:
					if (labelObject == null)
					{
						iconObject = h4X2RCsVqy4 as IconObject;
						if (iconObject == null)
						{
							return;
						}
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						if (labelObject.FontSize == num3)
						{
							return;
						}
						labelObject.FontSize = num3;
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
						{
							num2 = 3;
						}
					}
					break;
				case 4:
					return;
				}
			}
		}
	}

	public Visibility SizeVisibility
	{
		get
		{
			if (h4X2RCsVqy4 is LabelObject || h4X2RCsVqy4 is IconObject)
			{
				return Visibility.Visible;
			}
			return Visibility.Collapsed;
		}
	}

	public bool ObjectPosition
	{
		get
		{
			if (h4X2RCsVqy4 != null)
			{
				return h4X2RCsVqy4.Position == TigerTrade.Chart.Objects.Enums.ObjectPosition.Back;
			}
			return false;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					if (h4X2RCsVqy4 != null)
					{
						if (flag == (h4X2RCsVqy4.Position == TigerTrade.Chart.Objects.Enums.ObjectPosition.Back))
						{
							num2 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
							{
								num2 = 3;
							}
							break;
						}
						h4X2RCsVqy4.Position = (flag ? TigerTrade.Chart.Objects.Enums.ObjectPosition.Back : TigerTrade.Chart.Objects.Enums.ObjectPosition.Front);
						cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(-1841489831 ^ -1841442287));
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
						{
							num2 = 0;
						}
					}
					break;
				case 2:
					this.Command?.Invoke((rl9GXq9MFNRC5VT7hPqj)4);
					return;
				case 3:
					return;
				}
			}
		}
	}

	public bool ObjectLock
	{
		get
		{
			if (h4X2RCsVqy4 != null)
			{
				return h4X2RCsVqy4.Lock;
			}
			return false;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					if (h4X2RCsVqy4 == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (flag == gB995h4PUvjCmHjxrJlL(h4X2RCsVqy4))
				{
					return;
				}
				h4X2RCsVqy4.Lock = flag;
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-602153869 ^ -602204645));
				Action<rl9GXq9MFNRC5VT7hPqj> action = this.Command;
				if (action == null)
				{
					return;
				}
				action((rl9GXq9MFNRC5VT7hPqj)4);
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	public bool ObjectBorder
	{
		get
		{
			if (h4X2RCsVqy4 is PolygonObjectBase polygonObjectBase)
			{
				return v5nXK84PT62gcEUFKeUg(polygonObjectBase);
			}
			return false;
		}
		set
		{
			int num = 3;
			int num2 = num;
			PolygonObjectBase polygonObjectBase = default(PolygonObjectBase);
			while (true)
			{
				switch (num2)
				{
				default:
					this.Command?.Invoke((rl9GXq9MFNRC5VT7hPqj)4);
					return;
				case 1:
					polygonObjectBase.DrawBorder = flag;
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x42970ACB));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					if (polygonObjectBase == null || polygonObjectBase.DrawBorder == flag)
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					polygonObjectBase = h4X2RCsVqy4 as PolygonObjectBase;
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}
	}

	public Visibility ObjectBorderVisibility
	{
		get
		{
			if (!(h4X2RCsVqy4 is PolygonObjectBase) || h4X2RCsVqy4 is StFuPkiB5NwB49ql7Kjg)
			{
				return Visibility.Collapsed;
			}
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => Visibility.Visible, 
			};
		}
	}

	public bool ObjectBack
	{
		get
		{
			if (h4X2RCsVqy4 is PolygonObjectBase polygonObjectBase)
			{
				return qY3Bgi4PyIXulcOJj1fr(polygonObjectBase);
			}
			return false;
		}
		set
		{
			int num = 2;
			int num2 = num;
			PolygonObjectBase polygonObjectBase = default(PolygonObjectBase);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (polygonObjectBase != null && polygonObjectBase.DrawBack != flag)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 2:
					polygonObjectBase = h4X2RCsVqy4 as PolygonObjectBase;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 != 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					return;
				}
				URQcWR4PZfURvQ6rxS2L(polygonObjectBase, flag);
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x385FFAB ^ 0x3853777));
				Action<rl9GXq9MFNRC5VT7hPqj> action = this.Command;
				if (action == null)
				{
					num2 = 3;
					continue;
				}
				action((rl9GXq9MFNRC5VT7hPqj)4);
				return;
			}
		}
	}

	public Visibility ObjectBackVisibility
	{
		get
		{
			if (h4X2RCsVqy4 is PolygonObjectBase && !(h4X2RCsVqy4 is StFuPkiB5NwB49ql7Kjg))
			{
				return Visibility.Visible;
			}
			return Visibility.Collapsed;
		}
	}

	public bool ObjectExtendLeft
	{
		get
		{
			int num = 2;
			int num2 = num;
			LinearRegressionObject linearRegressionObject = default(LinearRegressionObject);
			LineObject lineObject = default(LineObject);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return YYcSh64PCBq0e3k8r6D0(linearRegressionObject);
				case 1:
					if (lineObject != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
						{
							num2 = 0;
						}
						break;
					}
					if (!(h4X2RCsVqy4 is ChannelObject channelObject))
					{
						if (h4X2RCsVqy4 is FibonacciRetracementObject fibonacciRetracementObject)
						{
							return fibonacciRetracementObject.OpenStart;
						}
						linearRegressionObject = h4X2RCsVqy4 as LinearRegressionObject;
						if (linearRegressionObject == null)
						{
							return false;
						}
						num2 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
						{
							num2 = 3;
						}
						break;
					}
					return YYcSh64PCBq0e3k8r6D0(channelObject);
				default:
					return n0wEem4PVD2jm70UAyi3(lineObject);
				case 2:
					lineObject = h4X2RCsVqy4 as LineObject;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
		set
		{
			ChannelObject channelObject = default(ChannelObject);
			FibonacciRetracementObject fibonacciRetracementObject = default(FibonacciRetracementObject);
			int num;
			LinearRegressionObject linearRegressionObject = default(LinearRegressionObject);
			if (!(h4X2RCsVqy4 is LineObject lineObject))
			{
				channelObject = h4X2RCsVqy4 as ChannelObject;
				if (channelObject == null)
				{
					fibonacciRetracementObject = h4X2RCsVqy4 as FibonacciRetracementObject;
					if (fibonacciRetracementObject != null)
					{
						num = 8;
					}
					else
					{
						linearRegressionObject = h4X2RCsVqy4 as LinearRegressionObject;
						if (linearRegressionObject == null)
						{
							return;
						}
						num = 10;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b != 0)
						{
							num = 4;
						}
					}
				}
				else
				{
					num = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
					{
						num = 4;
					}
				}
			}
			else
			{
				if (n0wEem4PVD2jm70UAyi3(lineObject) == flag)
				{
					return;
				}
				Ls5JBo4PrblcpON2FOTr(lineObject, flag);
				num = 11;
			}
			while (true)
			{
				int num2;
				switch (num)
				{
				default:
					return;
				case 10:
					if (YYcSh64PCBq0e3k8r6D0(linearRegressionObject) != flag)
					{
						qLI98p4Pme0uqxSvRRx5(linearRegressionObject, flag);
						num2 = 7;
						goto IL_0005;
					}
					return;
				case 3:
				{
					Action<rl9GXq9MFNRC5VT7hPqj> action2 = this.Command;
					if (action2 == null)
					{
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
						{
							num = 1;
						}
						break;
					}
					action2((rl9GXq9MFNRC5VT7hPqj)4);
					return;
				}
				case 5:
					return;
				case 9:
				{
					Action<rl9GXq9MFNRC5VT7hPqj> action3 = this.Command;
					if (action3 == null)
					{
						return;
					}
					action3((rl9GXq9MFNRC5VT7hPqj)4);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
					{
						num = 0;
					}
					break;
				}
				case 4:
				{
					cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(-1192989954 ^ -1192975502));
					Action<rl9GXq9MFNRC5VT7hPqj> action4 = this.Command;
					if (action4 == null)
					{
						num = 2;
						break;
					}
					action4((rl9GXq9MFNRC5VT7hPqj)4);
					return;
				}
				case 7:
					cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(-1878953018 ^ -1878934966));
					num2 = 3;
					goto IL_0005;
				case 8:
					if (fibonacciRetracementObject.OpenStart == flag)
					{
						return;
					}
					NJ3XLY4PKqBCl31QA4ug(fibonacciRetracementObject, flag);
					num = 4;
					break;
				case 6:
				{
					if (channelObject.OpenStart == flag)
					{
						return;
					}
					channelObject.OpenStart = flag;
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x86EFEF6 ^ 0x86E377A));
					Action<rl9GXq9MFNRC5VT7hPqj> action = this.Command;
					if (action == null)
					{
						return;
					}
					action((rl9GXq9MFNRC5VT7hPqj)4);
					num = 5;
					break;
				}
				case 0:
					return;
				case 11:
					cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x33015E23));
					num = 9;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
					{
						num = 5;
					}
					break;
				case 2:
					return;
				case 1:
					return;
					IL_0005:
					num = num2;
					break;
				}
			}
		}
	}

	public Visibility ObjectExtebdLeftVisibility
	{
		get
		{
			if (!(h4X2RCsVqy4 is LineObject) && !(h4X2RCsVqy4 is ChannelObject))
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return Visibility.Collapsed;
					}
					if (h4X2RCsVqy4 is FibonacciRetracementObject || h4X2RCsVqy4 is LinearRegressionObject)
					{
						break;
					}
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
					{
						num = 1;
					}
				}
			}
			return Visibility.Visible;
		}
	}

	public bool ObjectExtendRight
	{
		get
		{
			if (!(h4X2RCsVqy4 is LineObject lineObject))
			{
				int num = 3;
				ChannelObject channelObject = default(ChannelObject);
				LinearRegressionObject linearRegressionObject = default(LinearRegressionObject);
				while (true)
				{
					switch (num)
					{
					case 3:
						channelObject = h4X2RCsVqy4 as ChannelObject;
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 == 0)
						{
							num = 0;
						}
						continue;
					case 2:
						return channelObject.OpenEnd;
					case 1:
						return linearRegressionObject?.OpenEnd ?? false;
					}
					if (channelObject == null)
					{
						if (h4X2RCsVqy4 is FibonacciRetracementObject fibonacciRetracementObject)
						{
							return g8504N4Ph1IxTrXwgplZ(fibonacciRetracementObject);
						}
						linearRegressionObject = h4X2RCsVqy4 as LinearRegressionObject;
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
						{
							num = 0;
						}
					}
					else
					{
						num = 2;
					}
				}
			}
			return lineObject.OpenEnd;
		}
		set
		{
			int num = 10;
			LineObject lineObject = default(LineObject);
			FibonacciRetracementObject fibonacciRetracementObject = default(FibonacciRetracementObject);
			LinearRegressionObject linearRegressionObject = default(LinearRegressionObject);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 10:
						lineObject = h4X2RCsVqy4 as LineObject;
						num2 = 9;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 != 0)
						{
							num2 = 1;
						}
						continue;
					case 2:
						if (fibonacciRetracementObject.OpenEnd != flag)
						{
							num2 = 4;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
							{
								num2 = 2;
							}
							continue;
						}
						return;
					case 9:
						if (lineObject == null)
						{
							if (h4X2RCsVqy4 is ChannelObject channelObject)
							{
								if (channelObject.OpenEnd != flag)
								{
									channelObject.OpenEnd = flag;
									num2 = 7;
									continue;
								}
								return;
							}
							fibonacciRetracementObject = h4X2RCsVqy4 as FibonacciRetracementObject;
							if (fibonacciRetracementObject != null)
							{
								num2 = 2;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
								{
									num2 = 1;
								}
								continue;
							}
							linearRegressionObject = h4X2RCsVqy4 as LinearRegressionObject;
							if (linearRegressionObject != null)
							{
								num2 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 != 0)
								{
									num2 = 0;
								}
								continue;
							}
							return;
						}
						goto case 8;
					case 12:
						return;
					case 3:
					{
						cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(-530053095 ^ -530005519));
						Action<rl9GXq9MFNRC5VT7hPqj> action2 = this.Command;
						if (action2 == null)
						{
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						action2((rl9GXq9MFNRC5VT7hPqj)4);
						return;
					}
					default:
						if (linearRegressionObject.OpenEnd != flag)
						{
							num2 = 11;
							continue;
						}
						return;
					case 8:
					{
						if (lineObject.OpenEnd == flag)
						{
							return;
						}
						lineObject.OpenEnd = flag;
						cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(-123775059 ^ -123756987));
						Action<rl9GXq9MFNRC5VT7hPqj> action3 = this.Command;
						if (action3 == null)
						{
							return;
						}
						action3((rl9GXq9MFNRC5VT7hPqj)4);
						num2 = 12;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
						{
							num2 = 5;
						}
						continue;
					}
					case 4:
						fibonacciRetracementObject.OpenEnd = flag;
						cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1736566656 ^ -1736519320));
						num2 = 6;
						continue;
					case 11:
						linearRegressionObject.OpenEnd = flag;
						num2 = 3;
						continue;
					case 7:
					{
						cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x86EFEF6 ^ 0x86E371E));
						Action<rl9GXq9MFNRC5VT7hPqj> action = this.Command;
						if (action != null)
						{
							action((rl9GXq9MFNRC5VT7hPqj)4);
							return;
						}
						break;
					}
					case 5:
						return;
					case 6:
						this.Command?.Invoke((rl9GXq9MFNRC5VT7hPqj)4);
						return;
					case 1:
						return;
					}
					break;
				}
				num = 5;
			}
		}
	}

	public Visibility ObjectExtebdRightVisibility
	{
		get
		{
			if (!(h4X2RCsVqy4 is LineObject) && !(h4X2RCsVqy4 is ChannelObject) && !(h4X2RCsVqy4 is FibonacciRetracementObject))
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						break;
					default:
						if (!(h4X2RCsVqy4 is LinearRegressionObject))
						{
							return Visibility.Collapsed;
						}
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
						{
							num = 1;
						}
						continue;
					}
					break;
				}
			}
			return Visibility.Visible;
		}
	}

	public Visibility CommonButtonsVisibility
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (h4X2RCsVqy4.InSetup)
					{
						break;
					}
					return Visibility.Visible;
				case 1:
					if (h4X2RCsVqy4 != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				break;
			}
			return Visibility.Collapsed;
		}
	}

	public ObservableCollection<MenuItem> ObjectTemplates
	{
		get
		{
			ObservableCollection<MenuItem> observableCollection = new ObservableCollection<MenuItem>();
			if (h4X2RCsVqy4 == null)
			{
				return observableCollection;
			}
			List<MYCFlf96vCUwGFaDBEec> list = cZtq3296dk9rWrmmjNdh.GUt96OJ1sH6(h4X2RCsVqy4.ID);
			ObjectBase objectBase = DdW8419qIO2Mfk0ZN1xd.uy89qtWDjwk(h4X2RCsVqy4.ID);
			objectBase.ApplyTheme(OGp2RrcWtwt.Chart.Theme);
			MenuItem item = new MenuItem
			{
				Header = TigerTrade.Properties.Resources.CommonTemplateDefault,
				Command = c4Z2RTloiTR(),
				CommandParameter = objectBase
			};
			observableCollection.Add(item);
			foreach (MYCFlf96vCUwGFaDBEec item3 in list)
			{
				MenuItem item2 = new MenuItem
				{
					Header = item3.TemplateName,
					Command = c4Z2RTloiTR(),
					CommandParameter = item3.H1x96S1oL1V
				};
				observableCollection.Add(item2);
			}
			return observableCollection;
		}
	}

	public event Action<rl9GXq9MFNRC5VT7hPqj> Command
	{
		[CompilerGenerated]
		add
		{
			Action<rl9GXq9MFNRC5VT7hPqj> action = this.m_Command;
			Action<rl9GXq9MFNRC5VT7hPqj> action2;
			do
			{
				action2 = action;
				Action<rl9GXq9MFNRC5VT7hPqj> value2 = (Action<rl9GXq9MFNRC5VT7hPqj>)Delegate.Combine(action2, b);
				action = Interlocked.CompareExchange(ref this.m_Command, value2, action2);
			}
			while ((object)action != action2);
		}
		[CompilerGenerated]
		remove
		{
			Action<rl9GXq9MFNRC5VT7hPqj> action = this.m_Command;
			Action<rl9GXq9MFNRC5VT7hPqj> action2;
			do
			{
				action2 = action;
				Action<rl9GXq9MFNRC5VT7hPqj> value2 = (Action<rl9GXq9MFNRC5VT7hPqj>)Delegate.Remove(action2, value3);
				action = Interlocked.CompareExchange(ref this.m_Command, value2, action2);
			}
			while ((object)action != action2);
		}
	}

	public z6cN2T2g8Exc8U7SVs38()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		Left = 75.0;
		Top = 50.0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			base.Visibility = Visibility.Collapsed;
			InitializeComponent();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
			{
				num = 1;
			}
		}
	}

	private void xsu2gPnVcW4(object P_0, DragDeltaEventArgs P_1)
	{
		if (!(LLY5vU4P5cHoU8qZcoyL(this) is Popup popup))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			popup.HorizontalOffset = Math.Min(Math.Max(0.0, popup.HorizontalOffset + P_1.HorizontalChange), OGp2RrcWtwt.ActualWidth - IxAso24PSKphO2tHpoEW(this));
			popup.VerticalOffset = Math.Min(cL3bi94PxgG7LOAuuy5G(0.0, popup.VerticalOffset + P_1.VerticalChange), yB5jyo4PLJxVV2oWsBPy(OGp2RrcWtwt) - base.ActualHeight);
		}
	}

	public void Open(ObjectBase P_0, jjKtVJ9pUSOpdg38tqnP P_1)
	{
		int num;
		if (((MhMDPU9v8rkigy1ao0Th)sIQMqM4Pev43IeK018Q6()).FEe9BFx3pWr)
		{
			h4X2RCsVqy4 = P_0;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
			{
				num = 0;
			}
		}
		else
		{
			e4yq7V4PsVtwITYncsj4(this, Visibility.Collapsed);
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
			{
				num = 0;
			}
		}
		while (true)
		{
			switch (num)
			{
			default:
				OGp2RrcWtwt = P_1;
				base.Visibility = Visibility.Visible;
				num = 3;
				break;
			case 2:
				return;
			case 1:
				return;
			case 3:
				if (base.Parent is Popup popup)
				{
					popup.IsOpen = true;
				}
				qck2gJoa3kY();
				h4X2RCsVqy4.PropertyChanged += mO62gFZjrFq;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	private void qck2gJoa3kY()
	{
		cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2002318893 ^ -2002268521));
		cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x37B74BDF ^ 0x37B78C83));
		int num = 9;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b == 0)
		{
			num = 4;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(0x50C1C840 ^ 0x50C10FAE));
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 != 0)
				{
					num = 6;
				}
				break;
			default:
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -530005591));
				num = 7;
				break;
			case 4:
				cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(-1583344314 ^ -1583292962));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
				{
					num = 2;
				}
				break;
			case 8:
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -530005939));
				cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(-1461292091 ^ -1461273687));
				num = 4;
				break;
			case 7:
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x37B74BDF ^ 0x37B78237));
				cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(-490987856 ^ -490941250));
				num = 10;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
				{
					num = 3;
				}
				break;
			case 3:
				cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(--146713930 ^ 0x8BE65BE));
				cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(0x4297C3EB ^ 0x42970ACB));
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-448941864 ^ -448955932));
				cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(--737722733 ^ 0x2BF8A16B));
				cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(-1522697859 ^ -1522683887));
				cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(-176525661 ^ -176511185));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b != 0)
				{
					num = 0;
				}
				break;
			case 9:
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28C965BE ^ 0x28C9A236));
				cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(-1192989954 ^ -1192972972));
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xC1DDB3B ^ 0xC1D1CF9));
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
				{
					num = 5;
				}
				break;
			case 10:
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-602153869 ^ -602204613));
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4220DA8 ^ 0x422C7C0));
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1A5F1B9E ^ 0x1A5FD11E));
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-57768881 ^ -57782531));
				return;
			case 1:
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x22BF43FC ^ 0x22BF8BD4));
				num = 8;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
				{
					num = 8;
				}
				break;
			case 6:
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009569177));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				cY7HkOvo1nf(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2002318893 ^ -2002271901));
				cY7HkOvo1nf((string)wiyJR54P1OhnAZVbv4mW(0x37B74BDF ^ 0x37B78303));
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void mO62gFZjrFq(object P_0, PropertyChangedEventArgs P_1)
	{
		if (h4X2RCsVqy4 == null)
		{
			return;
		}
		aOH96s9MkelyvlptjAcV.v5i9MxteN4G(h4X2RCsVqy4);
		zypNwZ9OdGPv4hGl7jn5.Dy39OROAMYK(h4X2RCsVqy4, OGp2RrcWtwt);
		aOH96s9MkelyvlptjAcV.m609MSZpGwW();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			qck2gJoa3kY();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 != 0)
			{
				num = 1;
			}
		}
	}

	public void Close()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				h4X2RCsVqy4 = null;
				OGp2RrcWtwt = null;
				return;
			default:
				if (h4X2RCsVqy4 != null)
				{
					h4X2RCsVqy4.PropertyChanged -= mO62gFZjrFq;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 2;
			case 1:
				base.Visibility = Visibility.Collapsed;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void kml2g3VFWG9(string P_0)
	{
		if (dTYWQq4PXkSgMSV2EAnO(P_0))
		{
			return;
		}
		if (!SoUEWK4PcRydWqDiRjah(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1311293279 ^ -1311274379)))
		{
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
				{
					if (!(P_0 == (string)wiyJR54P1OhnAZVbv4mW(0x24085900 ^ 0x240893E0)))
					{
						return;
					}
					Action<rl9GXq9MFNRC5VT7hPqj> action = this.Command;
					if (action == null)
					{
						num = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
						{
							num = 0;
						}
						break;
					}
					action(rl9GXq9MFNRC5VT7hPqj.Delete);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
					{
						num = 0;
					}
					break;
				}
				case 2:
					return;
				}
			}
		}
		this.Command?.Invoke(rl9GXq9MFNRC5VT7hPqj.Edit);
	}

	[SpecialName]
	public ICommand c4Z2RTloiTR()
	{
		return S9T2RmW5F8j ?? (S9T2RmW5F8j = new RelayCommand(delegate(object P_0)
		{
			if (P_0 is ObjectBase objectBase)
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						h4X2RCsVqy4.CopyTemplate(objectBase, style: false);
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
						{
							num = 1;
						}
						break;
					case 1:
						this.Command?.Invoke((rl9GXq9MFNRC5VT7hPqj)4);
						return;
					}
				}
			}
		}));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (!tsg2RhOcvhx)
				{
					tsg2RhOcvhx = true;
					Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-624753169 ^ -624701665), UriKind.Relative);
					Application.LoadComponent(this, resourceLocator);
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)LxE0rU4Pwh65EFpG0d8o(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		if (P_0 != 1)
		{
			tsg2RhOcvhx = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			Thumb = (Thumb)P_1;
			Thumb.DragDelta += xsu2gPnVcW4;
		}
	}

	[SpecialName]
	DependencyObject poLM8x9MPUgdGZpBmXt9.get_Parent()
	{
		return base.Parent;
	}

	[CompilerGenerated]
	private void UOa2gpmqqqQ(object P_0)
	{
		kml2g3VFWG9(P_0 as string);
	}

	[CompilerGenerated]
	private void cLq2guadFp8(object P_0)
	{
		if (!(P_0 is ObjectBase objectBase))
		{
			return;
		}
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.Command?.Invoke((rl9GXq9MFNRC5VT7hPqj)4);
				return;
			}
			h4X2RCsVqy4.CopyTemplate(objectBase, style: false);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
			{
				num = 1;
			}
		}
	}

	static z6cN2T2g8Exc8U7SVs38()
	{
		W5HqIe4P7TS72XmyNYVH();
	}

	internal static object wiyJR54P1OhnAZVbv4mW(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool ARmmTE4PN5I6iuaUsYwy()
	{
		return kDLr154PbtRWslLJSRMj == null;
	}

	internal static z6cN2T2g8Exc8U7SVs38 KCOoJt4PkiyiLMed8cTh()
	{
		return kDLr154PbtRWslLJSRMj;
	}

	internal static object LLY5vU4P5cHoU8qZcoyL(object P_0)
	{
		return ((FrameworkElement)P_0).Parent;
	}

	internal static double IxAso24PSKphO2tHpoEW(object P_0)
	{
		return ((FrameworkElement)P_0).ActualWidth;
	}

	internal static double cL3bi94PxgG7LOAuuy5G(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static double yB5jyo4PLJxVV2oWsBPy(object P_0)
	{
		return ((FrameworkElement)P_0).ActualHeight;
	}

	internal static object sIQMqM4Pev43IeK018Q6()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static void e4yq7V4PsVtwITYncsj4(object P_0, Visibility P_1)
	{
		((UIElement)P_0).Visibility = P_1;
	}

	internal static bool dTYWQq4PXkSgMSV2EAnO(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool SoUEWK4PcRydWqDiRjah(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Color LFDueT4PjEZqdYppOHTw(XColor P_0)
	{
		return P_0;
	}

	internal static Color CfwFfF4PEkObAHwjLeZm()
	{
		return Colors.Transparent;
	}

	internal static XColor CqoTIf4PQS1oC09A9fCU(object P_0)
	{
		return ((LineObjectBase)P_0).LineColor;
	}

	internal static XColor tZRNgL4Pdd3r7xbPxQMA(object P_0)
	{
		return ((PolygonObjectBase)P_0).LineColor;
	}

	internal static bool FF8klW4PgIMDgoShEtQ8(Color P_0, Color P_1)
	{
		return P_0 != P_1;
	}

	internal static void wdjCvK4PRo8lTfOMrUT3(object P_0, XColor P_1)
	{
		((HorizontalLineObject)P_0).ActiveAlertLineColor = P_1;
	}

	internal static int ekTJmy4P6w6cNcRuxxMs(object P_0)
	{
		return ((LineObjectBase)P_0).LineWidth;
	}

	internal static void OCvqrI4PMIhLTNZFfOSj(object P_0, int P_1)
	{
		((PolygonObjectBase)P_0).LineWidth = P_1;
	}

	internal static XDashStyle GJLfJM4PODU9H4dfulou(object P_0)
	{
		return ((LineObjectBase)P_0).LineStyle;
	}

	internal static void rrNqnJ4PqQObdsuuTRIM(object P_0, XDashStyle P_1)
	{
		((LineObjectBase)P_0).LineStyle = P_1;
	}

	internal static XDashStyle uiUGCo4PI9xK5n6eiDIB(object P_0)
	{
		return ((PolygonObjectBase)P_0).LineStyle;
	}

	internal static XColor HPj23n4PWxjnio6c6Oxf(object P_0)
	{
		return ((PolygonObjectBase)P_0).BackColor;
	}

	internal static int kj1VTp4Ptuj4p6K2MLFM(object P_0)
	{
		return ((IconObject)P_0).Size;
	}

	internal static bool gB995h4PUvjCmHjxrJlL(object P_0)
	{
		return ((ObjectBase)P_0).Lock;
	}

	internal static bool v5nXK84PT62gcEUFKeUg(object P_0)
	{
		return ((PolygonObjectBase)P_0).DrawBorder;
	}

	internal static bool qY3Bgi4PyIXulcOJj1fr(object P_0)
	{
		return ((PolygonObjectBase)P_0).DrawBack;
	}

	internal static void URQcWR4PZfURvQ6rxS2L(object P_0, bool P_1)
	{
		((PolygonObjectBase)P_0).DrawBack = P_1;
	}

	internal static bool n0wEem4PVD2jm70UAyi3(object P_0)
	{
		return ((LineObject)P_0).OpenStart;
	}

	internal static bool YYcSh64PCBq0e3k8r6D0(object P_0)
	{
		return ((LineGroupObjectBaseEx)P_0).OpenStart;
	}

	internal static void Ls5JBo4PrblcpON2FOTr(object P_0, bool P_1)
	{
		((LineObject)P_0).OpenStart = P_1;
	}

	internal static void NJ3XLY4PKqBCl31QA4ug(object P_0, bool P_1)
	{
		((FibonacciRetracementObject)P_0).OpenStart = P_1;
	}

	internal static void qLI98p4Pme0uqxSvRRx5(object P_0, bool P_1)
	{
		((LineGroupObjectBaseEx)P_0).OpenStart = P_1;
	}

	internal static bool g8504N4Ph1IxTrXwgplZ(object P_0)
	{
		return ((FibonacciRetracementObject)P_0).OpenEnd;
	}

	internal static object LxE0rU4Pwh65EFpG0d8o(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void W5HqIe4P7TS72XmyNYVH()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
