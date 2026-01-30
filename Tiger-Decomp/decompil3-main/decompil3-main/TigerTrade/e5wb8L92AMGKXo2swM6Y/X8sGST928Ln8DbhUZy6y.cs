using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Windows.Media;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Annotations;
using TigerTrade.Dx;
using TuAMtrl1Nd3XoZQQUXf0;

namespace e5wb8L92AMGKXo2swM6Y;

[DataContract(Name = "AppTelegramSettings", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Config")]
public class X8sGST928Ln8DbhUZy6y : INotifyPropertyChanged
{
	private bool MtL9H8UEPF6;

	private string DVo9HAR2CGL;

	private string axG9HPA8WtQ;

	private int Xcy9HJqKuTg;

	private string QdT9HFw1db8;

	private FontFamily Qug9H3piExJ;

	private XColor ksJ9Hpr8qxf;

	private SolidColorBrush Q2T9HuGviNG;

	private double Vvu9HzNvSOB;

	private bool eG69f0Lx5IW;

	private XColor jLC9f2TXB9N;

	private SolidColorBrush snD9fHPFwPc;

	[CompilerGenerated]
	private PropertyChangedEventHandler m_PropertyChanged;

	internal static X8sGST928Ln8DbhUZy6y UU0hVVbDKJBeYLkuwdCB;

	[DefaultValue(false)]
	[DataMember(Name = "IsLocked")]
	public bool IsLocked
	{
		get
		{
			return MtL9H8UEPF6;
		}
		set
		{
			if (flag != MtL9H8UEPF6)
			{
				MtL9H8UEPF6 = flag;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				YN392PbDH7a(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1380525184 ^ -1380785668));
			}
		}
	}

	public int SecBefore
	{
		get
		{
			return yRufQmbD7oghSmv0DuPl(ClSnSLbDwP4LC8K95pZI());
		}
		set
		{
			j18iDj9nukSCmEyZs5lH.Settings.SecBefore = num;
		}
	}

	[DefaultValue(false)]
	[DataMember(Name = "VoiceSound")]
	public string VoiceSound
	{
		get
		{
			return DVo9HAR2CGL;
		}
		set
		{
			if (!(text == DVo9HAR2CGL))
			{
				DVo9HAR2CGL = text;
				YN392PbDH7a(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-165474503 ^ -165202519));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	[DefaultValue(false)]
	[DataMember(Name = "TickSound")]
	public string TickSound
	{
		get
		{
			return axG9HPA8WtQ;
		}
		set
		{
			if (!keCIoqbD8SQPQHg3Q4tt(text, axG9HPA8WtQ))
			{
				axG9HPA8WtQ = text;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				YN392PbDH7a(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1009517961 ^ -1009270561));
			}
		}
	}

	[DefaultValue(0)]
	[DataMember(Name = "TimeZone1")]
	public int TimeZone
	{
		get
		{
			return Xcy9HJqKuTg;
		}
		set
		{
			if (num != Xcy9HJqKuTg)
			{
				Xcy9HJqKuTg = num;
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				YN392PbDH7a(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--737722733 ^ 0x2BFCFBD3));
			}
		}
	}

	[DefaultValue("Exo 2")]
	[DataMember(Name = "FontName")]
	public string FontName
	{
		get
		{
			return QdT9HFw1db8;
		}
		set
		{
			if (text == QdT9HFw1db8)
			{
				return;
			}
			QdT9HFw1db8 = text;
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
			{
				num = 1;
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
					FontFamily = (FontFamily)NSZ44rbDA7oP2rrplGQJ(text);
					YN392PbDH7a(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x4297D03D));
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	public FontFamily FontFamily
	{
		get
		{
			return Qug9H3piExJ;
		}
		set
		{
			Qug9H3piExJ = qug9H3piExJ;
			YN392PbDH7a(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-991861155 ^ -991935099));
		}
	}

	[DefaultValue("SteelBlue")]
	[DataMember(Name = "XFontColor")]
	public XColor XFontColor
	{
		get
		{
			return ksJ9Hpr8qxf;
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
				case 1:
					if (xColor == ksJ9Hpr8qxf)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
						{
							num2 = 0;
						}
						break;
					}
					ksJ9Hpr8qxf = xColor;
					FontColor = new SolidColorBrush(RAstFybDPLpXEQRrBVIE(XFontColor));
					YN392PbDH7a((string)vE9k2hbDJMski5hEwQcR(0xAD5B8B3 ^ 0xAD18261));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public SolidColorBrush FontColor
	{
		get
		{
			return Q2T9HuGviNG;
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
				case 1:
					if (solidColorBrush == Q2T9HuGviNG)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
						{
							num2 = 0;
						}
						break;
					}
					Q2T9HuGviNG = solidColorBrush;
					YN392PbDH7a(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x16AD7E76 ^ 0x16A9449C));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "FontSize")]
	public double FontSize
	{
		get
		{
			return Vvu9HzNvSOB;
		}
		set
		{
			if (!(Math.Abs(num - Vvu9HzNvSOB) < 0.1))
			{
				Vvu9HzNvSOB = num;
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				}
				YN392PbDH7a(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1522697859 ^ -1522701673));
			}
		}
	}

	[DefaultValue(false)]
	[DataMember(Name = "BackgroundEnabled")]
	public bool BackgroundEnabled
	{
		get
		{
			return eG69f0Lx5IW;
		}
		set
		{
			if (eG69f0Lx5IW != flag)
			{
				eG69f0Lx5IW = flag;
				YN392PbDH7a(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x68DEE0F ^ 0x689D50F));
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	[DataMember(Name = "XBackgroundColor")]
	[DefaultValue("SteelBlue")]
	public XColor XBackgroundColor
	{
		get
		{
			return jLC9f2TXB9N;
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
				case 1:
					if (xColor == jLC9f2TXB9N)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
						{
							num2 = 0;
						}
						break;
					}
					jLC9f2TXB9N = xColor;
					BackgroundColor = new SolidColorBrush(RAstFybDPLpXEQRrBVIE(xColor));
					YN392PbDH7a((string)vE9k2hbDJMski5hEwQcR(--18459671 ^ 0x11D9731));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public SolidColorBrush BackgroundColor
	{
		get
		{
			return snD9fHPFwPc;
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
				case 1:
					if (solidColorBrush == snD9fHPFwPc)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
						{
							num2 = 0;
						}
						break;
					}
					snD9fHPFwPc = solidColorBrush;
					YN392PbDH7a(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xC1DDB3B ^ 0xC19E071));
					return;
				case 0:
					return;
				}
			}
		}
	}

	public bool Voice1Minute
	{
		get
		{
			return ((MhMDPU9v8rkigy1ao0Th)ClSnSLbDwP4LC8K95pZI()).Voice1Minute;
		}
		set
		{
			j18iDj9nukSCmEyZs5lH.Settings.Voice1Minute = flag;
		}
	}

	public bool Tick1Minute
	{
		get
		{
			return j18iDj9nukSCmEyZs5lH.Settings.Tick1Minute;
		}
		set
		{
			Kn0eZpbDFPnwAln9fnVb(j18iDj9nukSCmEyZs5lH.Settings, flag);
		}
	}

	public bool Voice5Minute
	{
		get
		{
			return ((MhMDPU9v8rkigy1ao0Th)ClSnSLbDwP4LC8K95pZI()).Voice5Minute;
		}
		set
		{
			o1JUkUbD3C15U8jApt9L(ClSnSLbDwP4LC8K95pZI(), flag);
		}
	}

	public bool Tick5Minute
	{
		get
		{
			return Om5xGLbDpcWt04S2wxDP(j18iDj9nukSCmEyZs5lH.Settings);
		}
		set
		{
			Ai0seNbDuV80sfci2R2k(j18iDj9nukSCmEyZs5lH.Settings, flag);
		}
	}

	public bool Voice15Minute
	{
		get
		{
			return JouUM8bDzJ5C3MxcqkYX(j18iDj9nukSCmEyZs5lH.Settings);
		}
		set
		{
			j18iDj9nukSCmEyZs5lH.Settings.Voice15Minute = flag;
		}
	}

	public bool Tick15Minute
	{
		get
		{
			return z7NrpQbb0gekD11ZFC2J(j18iDj9nukSCmEyZs5lH.Settings);
		}
		set
		{
			nCro68bb2vF1CJMwsidC(ClSnSLbDwP4LC8K95pZI(), flag);
		}
	}

	public bool Voice30Minute
	{
		get
		{
			return j18iDj9nukSCmEyZs5lH.Settings.Voice30Minute;
		}
		set
		{
			IMFawrbbHPdfxdhodgQQ(j18iDj9nukSCmEyZs5lH.Settings, flag);
		}
	}

	public bool Tick30Minute
	{
		get
		{
			return j18iDj9nukSCmEyZs5lH.Settings.Tick30Minute;
		}
		set
		{
			j18iDj9nukSCmEyZs5lH.Settings.Tick30Minute = flag;
		}
	}

	public bool Voice1Hour
	{
		get
		{
			return j18iDj9nukSCmEyZs5lH.Settings.Voice1Hour;
		}
		set
		{
			j18iDj9nukSCmEyZs5lH.Settings.Voice1Hour = flag;
		}
	}

	public bool Tick1Hour
	{
		get
		{
			return j18iDj9nukSCmEyZs5lH.Settings.Tick1Hour;
		}
		set
		{
			j18iDj9nukSCmEyZs5lH.Settings.Tick1Hour = flag;
		}
	}

	public bool Voice4Hour
	{
		get
		{
			return ((MhMDPU9v8rkigy1ao0Th)ClSnSLbDwP4LC8K95pZI()).Voice4Hour;
		}
		set
		{
			j18iDj9nukSCmEyZs5lH.Settings.Voice4Hour = flag;
		}
	}

	public bool Tick4Hour
	{
		get
		{
			return ((MhMDPU9v8rkigy1ao0Th)ClSnSLbDwP4LC8K95pZI()).Tick4Hour;
		}
		set
		{
			j18iDj9nukSCmEyZs5lH.Settings.Tick4Hour = flag;
		}
	}

	public bool Voice1Day
	{
		get
		{
			return j18iDj9nukSCmEyZs5lH.Settings.Voice1Day;
		}
		set
		{
			i3YInBbbflOtOyOLYXc2(j18iDj9nukSCmEyZs5lH.Settings, flag);
		}
	}

	public bool Tick1Day
	{
		get
		{
			return j18iDj9nukSCmEyZs5lH.Settings.Tick1Day;
		}
		set
		{
			tOCp6Vbb9CR0bdE3GR8I(ClSnSLbDwP4LC8K95pZI(), flag);
		}
	}

	public bool VoiceFunding
	{
		get
		{
			return ((MhMDPU9v8rkigy1ao0Th)ClSnSLbDwP4LC8K95pZI()).VoiceFunding;
		}
		set
		{
			qTnBGZbbnE5CEg4beQ1a(j18iDj9nukSCmEyZs5lH.Settings, flag);
		}
	}

	public bool TickFunding
	{
		get
		{
			return Ax6mmGbbGFMolYiV8Q1O(j18iDj9nukSCmEyZs5lH.Settings);
		}
		set
		{
			j18iDj9nukSCmEyZs5lH.Settings.TickFunding = flag;
		}
	}

	public IEnumerable<string> Fonts => XFont.SortedFonts;

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			int num = 1;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 1:
					propertyChangedEventHandler2 = this.m_PropertyChanged;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
				{
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler, b);
					propertyChangedEventHandler2 = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler);
					if ((object)propertyChangedEventHandler2 == propertyChangedEventHandler)
					{
						return;
					}
					break;
				}
				}
				propertyChangedEventHandler = propertyChangedEventHandler2;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
				{
					num2 = 0;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 2;
			int num2 = num;
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					propertyChangedEventHandler = this.m_PropertyChanged;
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 != 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 1:
					break;
				}
				PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value3);
					propertyChangedEventHandler = Interlocked.CompareExchange(ref this.m_PropertyChanged, value2, propertyChangedEventHandler2);
				}
				while ((object)propertyChangedEventHandler != propertyChangedEventHandler2);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	public X8sGST928Ln8DbhUZy6y()
	{
		KuD6nqbbY49tbs7njdrn();
		base._002Ector();
		TimeZone = 0;
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				FontSize = 35.0;
				return;
			case 1:
				XFontColor = X3yNiFbbvkOrSx38u9T3(hIJ4jWbboPx9oWn9vyHX());
				XBackgroundColor = jItRMFbbBNVSh7ao6hsD();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				FontName = (string)vE9k2hbDJMski5hEwQcR(0x5CD4F15 ^ 0x5CD1947);
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[NotifyPropertyChangedInvocator]
	private void YN392PbDH7a([CallerMemberName] string propertyName = null)
	{
		this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	static X8sGST928Ln8DbhUZy6y()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool xnmdS5bDmSqWocWGMaSH()
	{
		return UU0hVVbDKJBeYLkuwdCB == null;
	}

	internal static X8sGST928Ln8DbhUZy6y r4KiIJbDhroxsoOm5Qye()
	{
		return UU0hVVbDKJBeYLkuwdCB;
	}

	internal static object ClSnSLbDwP4LC8K95pZI()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static int yRufQmbD7oghSmv0DuPl(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).SecBefore;
	}

	internal static bool keCIoqbD8SQPQHg3Q4tt(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object NSZ44rbDA7oP2rrplGQJ(object P_0)
	{
		return XFont.GetFont((string)P_0);
	}

	internal static Color RAstFybDPLpXEQRrBVIE(XColor P_0)
	{
		return P_0;
	}

	internal static object vE9k2hbDJMski5hEwQcR(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void Kn0eZpbDFPnwAln9fnVb(object P_0, bool P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).Tick1Minute = P_1;
	}

	internal static void o1JUkUbD3C15U8jApt9L(object P_0, bool P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).Voice5Minute = P_1;
	}

	internal static bool Om5xGLbDpcWt04S2wxDP(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).Tick5Minute;
	}

	internal static void Ai0seNbDuV80sfci2R2k(object P_0, bool P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).Tick5Minute = P_1;
	}

	internal static bool JouUM8bDzJ5C3MxcqkYX(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).Voice15Minute;
	}

	internal static bool z7NrpQbb0gekD11ZFC2J(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).Tick15Minute;
	}

	internal static void nCro68bb2vF1CJMwsidC(object P_0, bool P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).Tick15Minute = P_1;
	}

	internal static void IMFawrbbHPdfxdhodgQQ(object P_0, bool P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).Voice30Minute = P_1;
	}

	internal static void i3YInBbbflOtOyOLYXc2(object P_0, bool P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).Voice1Day = P_1;
	}

	internal static void tOCp6Vbb9CR0bdE3GR8I(object P_0, bool P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).Tick1Day = P_1;
	}

	internal static void qTnBGZbbnE5CEg4beQ1a(object P_0, bool P_1)
	{
		((MhMDPU9v8rkigy1ao0Th)P_0).VoiceFunding = P_1;
	}

	internal static bool Ax6mmGbbGFMolYiV8Q1O(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).TickFunding;
	}

	internal static void KuD6nqbbY49tbs7njdrn()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static Color hIJ4jWbboPx9oWn9vyHX()
	{
		return Colors.SteelBlue;
	}

	internal static XColor X3yNiFbbvkOrSx38u9T3(Color P_0)
	{
		return P_0;
	}

	internal static Color jItRMFbbBNVSh7ao6hsD()
	{
		return Colors.Gray;
	}
}
