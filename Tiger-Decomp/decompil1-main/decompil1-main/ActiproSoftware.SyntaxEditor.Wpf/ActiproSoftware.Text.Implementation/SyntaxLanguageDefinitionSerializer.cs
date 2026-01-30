using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using System.Xml.Linq;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text.Analysis.Implementation;
using ActiproSoftware.Text.Lexing;
using ActiproSoftware.Text.Lexing.Implementation;
using ActiproSoftware.Text.Tagging.Implementation;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting.Implementation;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Text.Implementation;

public class SyntaxLanguageDefinitionSerializer
{
	private class M7L
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private Assembly Oqa;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private bool cqx;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private IHighlightingStyleRegistry pqG;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private ISyntaxLanguage uqX;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private string EqK;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private XElement wqf;

		internal static M7L Ni0;

		public IHighlightingStyleRegistry HighlightingStyleRegistry
		{
			[CompilerGenerated]
			get
			{
				return pqG;
			}
			[CompilerGenerated]
			set
			{
				pqG = highlightingStyleRegistry;
			}
		}

		public ISyntaxLanguage Language
		{
			[CompilerGenerated]
			get
			{
				return uqX;
			}
			[CompilerGenerated]
			set
			{
				uqX = syntaxLanguage;
			}
		}

		[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		public string Wqc => Q7Z.tqM(219668);

		[SpecialName]
		[CompilerGenerated]
		public Assembly Xy2()
		{
			return Oqa;
		}

		[SpecialName]
		[CompilerGenerated]
		public void Ey7(Assembly P_0)
		{
			Oqa = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public bool Iyp()
		{
			return cqx;
		}

		[SpecialName]
		[CompilerGenerated]
		public void MyM(bool P_0)
		{
			cqx = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public string yyh()
		{
			return EqK;
		}

		[SpecialName]
		[CompilerGenerated]
		public void gyN(string P_0)
		{
			EqK = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public XElement dyz()
		{
			return wqf;
		}

		[SpecialName]
		[CompilerGenerated]
		public void GqW(XElement P_0)
		{
			wqf = P_0;
		}

		public M7L()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool ci7()
		{
			return Ni0 == null;
		}

		internal static M7L ain()
		{
			return Ni0;
		}
	}

	private class P7P
	{
		private static P7P Jiq;

		[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
		public HighlightingStyle CqD(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return null;
			}
			string[] array = P_0.Split(',');
			if (array == null || array.Length == 0)
			{
				return null;
			}
			HighlightingStyle highlightingStyle = new HighlightingStyle();
			for (int i = 0; i < array.Length; i++)
			{
				switch (i)
				{
				case 0:
					if (!string.IsNullOrEmpty(array[i]))
					{
						highlightingStyle.Foreground = UIColor.FromWebColor(array[i]).ToColor();
					}
					break;
				case 1:
				{
					if (!string.IsNullOrEmpty(array[i]) && bool.TryParse(array[i], out var result3))
					{
						highlightingStyle.Bold = result3;
					}
					break;
				}
				case 2:
				{
					if (!string.IsNullOrEmpty(array[i]) && bool.TryParse(array[i], out var result2))
					{
						highlightingStyle.Italic = result2;
					}
					break;
				}
				case 3:
					if (!string.IsNullOrEmpty(array[i]))
					{
						highlightingStyle.Background = UIColor.FromWebColor(array[i]).ToColor();
					}
					break;
				case 4:
				{
					if (!string.IsNullOrEmpty(array[i]) && bool.TryParse(array[i], out var result))
					{
						highlightingStyle.BackgroundSpansVirtualSpace = result;
					}
					break;
				}
				}
			}
			return highlightingStyle;
		}

		public P7P()
		{
			grA.DaB7cz();
			base._002Ector();
		}

		internal static bool Qix()
		{
			return Jiq == null;
		}

		internal static P7P Cia()
		{
			return Jiq;
		}
	}

	private class a7b : DynamicLexicalScope
	{
		internal static a7b giL;

		public a7b(ILexicalState P_0)
		{
			grA.DaB7cz();
			base._002Ector();
			base.LexicalStateCore = P_0;
		}

		internal static bool Uig()
		{
			return giL == null;
		}

		internal static a7b riA()
		{
			return giL;
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IHighlightingStyleRegistry W5g;

	internal static SyntaxLanguageDefinitionSerializer LG7;

	public IHighlightingStyleRegistry HighlightingStyleRegistry
	{
		[CompilerGenerated]
		get
		{
			return W5g;
		}
		[CompilerGenerated]
		set
		{
			W5g = value;
		}
	}

	private static Assembly mIq(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			throw new ArgumentNullException(Q7Z.tqM(198378));
		}
		Assembly[] array = vAE.P0f();
		if (array != null)
		{
			Assembly[] array2 = array;
			int num2 = default(int);
			foreach (Assembly assembly in array2)
			{
				if (assembly.FullName.StartsWith(P_0 + Q7Z.tqM(196626), StringComparison.OrdinalIgnoreCase))
				{
					int num = 0;
					if (YGq() != null)
					{
						num = num2;
					}
					return num switch
					{
						_ => assembly, 
					};
				}
			}
		}
		return null;
	}

	private ISyntaxLanguage LI2(Assembly P_0, Stream P_1, ISyntaxLanguage P_2, string P_3)
	{
		if (P_1 == null)
		{
			int num = 0;
			if (YGq() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				throw new ArgumentNullException(Q7Z.tqM(12670));
			}
		}
		M7L m7L = new M7L();
		m7L.Language = P_2;
		m7L.Ey7(P_0);
		m7L.HighlightingStyleRegistry = HighlightingStyleRegistry;
		m7L.gyN(P_3);
		XDocument xDocument = XDocument.Load(P_1);
		m7L.GqW(xDocument.Root);
		if (m7L.dyz() != null)
		{
			try
			{
				if (m7L.dyz().Name == XName.Get(Q7Z.tqM(198406), m7L.Wqc))
				{
					XIO(m7L);
				}
			}
			catch (Exception innerException)
			{
				throw new ArgumentException(SR.GetString(SRName.ExInvalidLanguageDefinitionStream), innerException);
			}
		}
		if (m7L.Language == null)
		{
			throw new ArgumentException(SR.GetString(SRName.ExInvalidLanguageDefinitionStream));
		}
		return m7L.Language;
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	private void cI7(M7L P_0)
	{
		XElement[] array = q5W(P_0.dyz(), Q7Z.tqM(198446), Q7Z.tqM(198488), P_0.Wqc);
		if (array == null)
		{
			return;
		}
		XElement[] array2 = array;
		foreach (XElement xElement in array2)
		{
			string text = M5D(xElement, Q7Z.tqM(198528));
			if (string.IsNullOrEmpty(text))
			{
				continue;
			}
			IClassificationType classificationType = ((P_0.HighlightingStyleRegistry != null) ? P_0.HighlightingStyleRegistry.GetClassificationType(text) : null);
			if (classificationType == null)
			{
				classificationType = AmbientHighlightingStyleRegistry.Instance.GetClassificationType(text);
			}
			if (classificationType != null)
			{
				continue;
			}
			string description = M5D(xElement, Q7Z.tqM(12864)) ?? StringHelper.CreateDescription(text);
			HighlightingStyle highlightingStyle = null;
			string text2 = M5D(xElement, Q7Z.tqM(198538));
			if (!string.IsNullOrEmpty(text2))
			{
				highlightingStyle = new P7P().CqD(text2);
			}
			if (highlightingStyle == null)
			{
				XElement xElement2 = S5E(xElement, Q7Z.tqM(198538), Q7Z.tqM(7544), P_0.Wqc);
				if (xElement2 != null)
				{
					HighlightingStyle highlightingStyle2 = new HighlightingStyle();
					highlightingStyle2.Foreground = l5G(xElement2, Q7Z.tqM(194680));
					highlightingStyle2.Background = l5G(xElement2, Q7Z.tqM(194448));
					highlightingStyle2.BackgroundSpansVirtualSpace = true.Equals(L5K(xElement2, Q7Z.tqM(194472)));
					highlightingStyle2.Bold = L5K(xElement2, Q7Z.tqM(194530));
					highlightingStyle2.Italic = L5K(xElement2, Q7Z.tqM(194896));
					if (!highlightingStyle2.HasDefaultFormatting)
					{
						highlightingStyle = highlightingStyle2;
					}
				}
			}
			classificationType = new ClassificationType(text, description);
			if (P_0.HighlightingStyleRegistry != null)
			{
				P_0.HighlightingStyleRegistry.Register(classificationType, highlightingStyle ?? new HighlightingStyle());
			}
			else
			{
				AmbientHighlightingStyleRegistry.Instance.Register(classificationType, highlightingStyle ?? new HighlightingStyle());
			}
		}
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private void nIi(M7L P_0, XElement P_1)
	{
		DynamicLexer dynamicLexer = new DynamicLexer();
		if (!string.IsNullOrEmpty(P_0.Language.Key))
		{
			dynamicLexer.Key = P_0.Language.Key;
		}
		P_0.Language.RegisterService((ILexer)dynamicLexer);
		P_0.Language.RegisterService(new TokenTaggerProvider<TokenTagger>());
		XElement[] array = q5W(P_1, Q7Z.tqM(198566), Q7Z.tqM(198582), P_0.Wqc);
		if (array != null)
		{
			XElement[] array2 = array;
			foreach (XElement xElement in array2)
			{
				string text = M5D(xElement, Q7Z.tqM(198528));
				string text2 = M5D(xElement, Q7Z.tqM(198596));
				if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(text2))
				{
					DynamicLexicalMacro item = new DynamicLexicalMacro(text, text2);
					dynamicLexer.LexicalMacros.Add(item);
				}
			}
		}
		XElement[] array3 = j5a(P_1, Q7Z.tqM(198614), Q7Z.tqM(198630), P_0.Wqc);
		if (array3 == null)
		{
			return;
		}
		XElement[] array4 = array3;
		foreach (XElement xElement2 in array4)
		{
			string text3 = M5D(xElement2, Q7Z.tqM(198528));
			if (string.IsNullOrEmpty(text3))
			{
				continue;
			}
			DynamicLexicalState dynamicLexicalState = dynamicLexer.LexicalStates[text3];
			if (dynamicLexicalState == null)
			{
				dynamicLexicalState = new DynamicLexicalState(text3);
				dynamicLexer.LexicalStates.Add(dynamicLexicalState);
			}
			int? num = K5f(xElement2, Q7Z.tqM(13956));
			if (num.HasValue)
			{
				dynamicLexicalState.Id = num.Value;
			}
			int? num2 = K5f(xElement2, Q7Z.tqM(198644));
			if (num2.HasValue)
			{
				dynamicLexicalState.DefaultTokenId = num2.Value;
			}
			dynamicLexicalState.DefaultTokenKey = M5D(xElement2, Q7Z.tqM(198676));
			string text4 = M5D(xElement2, Q7Z.tqM(198710));
			if (!string.IsNullOrEmpty(text4))
			{
				dynamicLexicalState.DefaultClassificationType = ((P_0.HighlightingStyleRegistry != null) ? P_0.HighlightingStyleRegistry.GetClassificationType(text4) : null);
				if (dynamicLexicalState.DefaultClassificationType == null)
				{
					dynamicLexicalState.DefaultClassificationType = AmbientHighlightingStyleRegistry.Instance.GetClassificationType(text4);
				}
			}
			dynamicLexicalState.DefaultCaseSensitivity = U5X(xElement2, Q7Z.tqM(198770), CaseSensitivity.Insensitive);
			if (dynamicLexicalState.DefaultCaseSensitivity == CaseSensitivity.AutoCorrect)
			{
				P_0.MyM(_0020: true);
			}
			XElement[] array5 = q5W(xElement2, Q7Z.tqM(198818), Q7Z.tqM(9638), P_0.Wqc);
			if (array5 != null)
			{
				XElement[] array6 = array5;
				foreach (XElement xElement3 in array6)
				{
					DynamicLexicalScope dynamicLexicalScope = new DynamicLexicalScope();
					bool? flag = L5K(xElement3, Q7Z.tqM(198834));
					if (flag.HasValue)
					{
						dynamicLexicalScope.IsAncestorEndScopeCheckEnabled = flag.Value;
					}
					XElement xElement4 = JIz(xElement3, Q7Z.tqM(198898), new string[2]
					{
						Q7Z.tqM(198936),
						Q7Z.tqM(198980)
					}, P_0.Wqc);
					if (xElement4 != null)
					{
						dynamicLexicalScope.StartLexicalPatternGroup = uIp(P_0, xElement4);
					}
					XElement xElement5 = JIz(xElement3, Q7Z.tqM(199018), new string[2]
					{
						Q7Z.tqM(198936),
						Q7Z.tqM(198980)
					}, P_0.Wqc);
					if (xElement5 != null)
					{
						dynamicLexicalScope.EndLexicalPatternGroup = uIp(P_0, xElement5);
					}
					XElement xElement6 = dId(xElement3, Q7Z.tqM(199052), Q7Z.tqM(199076), P_0.Wqc);
					if (xElement6 != null)
					{
						dynamicLexicalScope.Transition = AIJ(P_0, xElement6, dynamicLexicalState);
					}
					dynamicLexicalState.LexicalScopes.Add(dynamicLexicalScope);
				}
			}
			XElement[] array7 = H5x(xElement2, Q7Z.tqM(199110), new string[2]
			{
				Q7Z.tqM(198936),
				Q7Z.tqM(198980)
			}, P_0.Wqc);
			if (array7 != null)
			{
				XElement[] array8 = array7;
				foreach (XElement xElement7 in array8)
				{
					DynamicLexicalPatternGroup dynamicLexicalPatternGroup = uIp(P_0, xElement7);
					if (dynamicLexicalPatternGroup != null)
					{
						dynamicLexicalState.LexicalPatternGroups.Add(dynamicLexicalPatternGroup);
					}
				}
			}
			XElement xElement8 = S5E(xElement2, Q7Z.tqM(199052), Q7Z.tqM(199076), P_0.Wqc);
			if (xElement8 != null)
			{
				dynamicLexicalState.Transition = AIJ(P_0, xElement8, dynamicLexicalState);
			}
		}
		XElement[] array9 = array3;
		foreach (XElement xElement9 in array9)
		{
			string text5 = M5D(xElement9, Q7Z.tqM(198528));
			if (string.IsNullOrEmpty(text5))
			{
				continue;
			}
			DynamicLexicalState dynamicLexicalState2 = dynamicLexer.LexicalStates[text5];
			if (dynamicLexicalState2 == null)
			{
				continue;
			}
			XElement[] array10 = q5W(xElement9, Q7Z.tqM(199140), Q7Z.tqM(199166), P_0.Wqc);
			if (array10 == null)
			{
				continue;
			}
			XElement[] array11 = array10;
			foreach (XElement xElement10 in array11)
			{
				string text6 = M5D(xElement10, Q7Z.tqM(198528));
				if (!string.IsNullOrEmpty(text6))
				{
					DynamicLexicalState dynamicLexicalState3 = dynamicLexer.LexicalStates[text6];
					if (dynamicLexicalState3 != null)
					{
						dynamicLexicalState2.ChildLexicalStates.Add(dynamicLexicalState3);
					}
				}
			}
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	private DynamicLexicalPatternGroup uIp(M7L P_0, XElement P_1)
	{
		DynamicLexicalPatternType dynamicLexicalPatternType = DynamicLexicalPatternType.Explicit;
		string localName = P_1.Name.LocalName;
		string text = localName;
		if (!(text == Q7Z.tqM(198936)))
		{
			if (!(text == Q7Z.tqM(198980)))
			{
				return null;
			}
			dynamicLexicalPatternType = DynamicLexicalPatternType.Regex;
		}
		else
		{
			dynamicLexicalPatternType = DynamicLexicalPatternType.Explicit;
		}
		string tokenKey = M5D(P_1, Q7Z.tqM(199186));
		string text2 = M5D(P_1, Q7Z.tqM(199206));
		IClassificationType classificationType = null;
		if (!string.IsNullOrEmpty(text2))
		{
			classificationType = ((P_0.HighlightingStyleRegistry != null) ? P_0.HighlightingStyleRegistry.GetClassificationType(text2) : null);
			if (classificationType == null)
			{
				classificationType = AmbientHighlightingStyleRegistry.Instance.GetClassificationType(text2);
			}
		}
		DynamicLexicalPatternGroup dynamicLexicalPatternGroup = new DynamicLexicalPatternGroup(dynamicLexicalPatternType, tokenKey, classificationType);
		dynamicLexicalPatternGroup.Key = M5D(P_1, Q7Z.tqM(198528));
		int? num = K5f(P_1, Q7Z.tqM(199252));
		if (num.HasValue)
		{
			dynamicLexicalPatternGroup.TokenId = num.Value;
		}
		dynamicLexicalPatternGroup.LookBehindPattern = M5D(P_1, Q7Z.tqM(199270));
		dynamicLexicalPatternGroup.LookAheadPattern = M5D(P_1, Q7Z.tqM(199308));
		dynamicLexicalPatternGroup.CaseSensitivity = U5X<CaseSensitivity?>(P_1, Q7Z.tqM(199344), null);
		if (dynamicLexicalPatternGroup.CaseSensitivity == CaseSensitivity.AutoCorrect)
		{
			P_0.MyM(_0020: true);
		}
		string text3 = M5D(P_1, Q7Z.tqM(198596));
		if (!string.IsNullOrEmpty(text3))
		{
			dynamicLexicalPatternGroup.Patterns.Add(new DynamicLexicalPattern(text3));
		}
		foreach (XElement item2 in P_1.Elements())
		{
			XElement xElement = item2;
			if (xElement == null)
			{
				continue;
			}
			string localName2 = xElement.Name.LocalName;
			string text4 = localName2;
			if (!(text4 == Q7Z.tqM(199378)))
			{
				if (!(text4 == Q7Z.tqM(199412)))
				{
					if (text4 == Q7Z.tqM(199448))
					{
						text3 = M5D(xElement, Q7Z.tqM(199476));
						if (!string.IsNullOrEmpty(text3))
						{
							dynamicLexicalPatternGroup.Patterns.Add(new DynamicLexicalPattern(text3));
						}
					}
					continue;
				}
				DynamicLexicalPattern[] array = NIt(xElement.Value);
				if (array != null && array.Length != 0)
				{
					DynamicLexicalPattern[] array2 = array;
					foreach (DynamicLexicalPattern item in array2)
					{
						dynamicLexicalPatternGroup.Patterns.Add(item);
					}
				}
			}
			else
			{
				text3 = M5D(xElement, Q7Z.tqM(199476));
				if (!string.IsNullOrEmpty(text3))
				{
					dynamicLexicalPatternGroup.Patterns.Add(new DynamicLexicalPattern(text3));
				}
			}
		}
		return dynamicLexicalPatternGroup;
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	private void lIM(M7L P_0)
	{
		XElement xElement = P_0.dyz().Element(XName.Get(Q7Z.tqM(199490), P_0.Wqc));
		if (xElement != null)
		{
			P_0.Language.RegisterService((IExampleTextProvider)new ExampleTextProvider(xElement.Value));
		}
	}

	private void XIO(M7L P_0)
	{
		string text = M5D(P_0.dyz(), Q7Z.tqM(199554));
		if (!string.IsNullOrEmpty(text))
		{
			if (P_0.Language == null)
			{
				P_0.Language = new SyntaxLanguage(text);
			}
			cI7(P_0);
			GIU(P_0);
			lIM(P_0);
			if (P_0.Iyp())
			{
				P_0.Language.RegisterAutoCorrector(new AutoCaseCorrector());
			}
		}
	}

	private void GIU(M7L P_0)
	{
		XElement xElement = dId(P_0.dyz(), Q7Z.tqM(199580), Q7Z.tqM(199594), P_0.Wqc);
		if (xElement != null)
		{
			nIi(P_0, xElement);
		}
	}

	private LexicalStateTransition AIJ(M7L P_0, XElement P_1, ILexicalState P_2)
	{
		ISyntaxLanguage syntaxLanguage = null;
		XElement xElement = S5E(P_1, Q7Z.tqM(199622), Q7Z.tqM(199652), P_0.Wqc);
		if (xElement == null)
		{
			goto IL_0039;
		}
		syntaxLanguage = null;
		using (Stream stream = GIZ(P_0, xElement))
		{
			if (stream != null)
			{
				ISyntaxLanguage syntaxLanguage2 = LI2(P_0.Xy2(), stream, null, P_0.yyh());
				if (syntaxLanguage2 != null)
				{
					syntaxLanguage = syntaxLanguage2;
				}
			}
		}
		goto IL_014d;
		IL_0039:
		syntaxLanguage = P_0.Language;
		goto IL_014d;
		IL_014d:
		if (syntaxLanguage != null)
		{
			DynamicLexicalScope dynamicLexicalScope = null;
			XElement xElement2 = S5E(P_1, Q7Z.tqM(199678), Q7Z.tqM(9638), P_0.Wqc);
			bool flag = xElement2 != null;
			int num = 2;
			while (true)
			{
				IL_0005:
				int num2 = num;
				while (true)
				{
					bool? flag2;
					switch (num2)
					{
					case 1:
					{
						XElement xElement3 = JIz(xElement2, Q7Z.tqM(199018), new string[2]
						{
							Q7Z.tqM(198936),
							Q7Z.tqM(198980)
						}, P_0.Wqc);
						if (xElement3 != null)
						{
							dynamicLexicalScope.EndLexicalPatternGroup = uIp(P_0, xElement3);
						}
						goto IL_0299;
					}
					case 2:
						{
							if (flag)
							{
								dynamicLexicalScope = new a7b(P_2);
								flag2 = L5K(xElement2, Q7Z.tqM(198834));
								if (!flag2.HasValue)
								{
									goto case 1;
								}
								goto IL_0274;
							}
							goto IL_0299;
						}
						IL_0299:
						if (!(syntaxLanguage.GetService<ILexer>() is IMergableLexer mergableLexer))
						{
							return null;
						}
						return new LexicalStateTransition(syntaxLanguage, mergableLexer.DefaultLexicalState, dynamicLexicalScope);
					}
					break;
					IL_0274:
					dynamicLexicalScope.IsAncestorEndScopeCheckEnabled = flag2.Value;
					num2 = 1;
					if (!wGn())
					{
						goto IL_0005;
					}
				}
				break;
			}
			goto IL_0039;
		}
		return null;
	}

	internal static DynamicLexicalPattern[] NIt(string P_0)
	{
		string text = string.Empty;
		List<DynamicLexicalPattern> list = new List<DynamicLexicalPattern>();
		int num2 = default(int);
		for (int i = 0; i < P_0.Length; i++)
		{
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					break;
				default:
					goto IL_0071;
				}
				char c = P_0[i];
				switch (c)
				{
				case '\t':
				case '\n':
				case '\r':
				case ' ':
					if (text.Length > 0)
					{
						list.Add(new DynamicLexicalPattern(text));
						num = 1;
						if (wGn())
						{
							continue;
						}
					}
					else
					{
						num = 0;
						if (wGn())
						{
							continue;
						}
					}
					num = num2;
					continue;
				}
				text += c;
				break;
				IL_0071:
				text = string.Empty;
				break;
			}
		}
		if (text.Length > 0)
		{
			list.Add(new DynamicLexicalPattern(text));
		}
		return list.ToArray();
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	private static Stream GIZ(M7L P_0, XElement P_1)
	{
		Stream stream = null;
		if (P_1 != null)
		{
			string text = M5D(P_1, Q7Z.tqM(199702));
			if (!string.IsNullOrEmpty(text))
			{
				string text2 = M5D(P_1, Q7Z.tqM(196010));
				if (!string.IsNullOrEmpty(text2))
				{
					Assembly assembly = mIq(text2);
					if (assembly != null)
					{
						stream = assembly.GetManifestResourceStream(text);
					}
				}
				if (stream == null && P_0.Xy2() != null)
				{
					while (stream == null && !string.IsNullOrEmpty(text))
					{
						stream = P_0.Xy2().GetManifestResourceStream(text);
						int num = text.IndexOf('.');
						text = ((num == -1) ? null : text.Substring(num + 1));
					}
				}
			}
			if (stream == null)
			{
				string text3 = M5D(P_1, Q7Z.tqM(199758));
				if (!string.IsNullOrEmpty(text3))
				{
					if (!string.IsNullOrEmpty(P_0.yyh()))
					{
						string path = Path.Combine(P_0.yyh(), text3);
						if (File.Exists(path))
						{
							try
							{
								stream = File.OpenRead(path);
							}
							catch (ArgumentException)
							{
							}
							catch (DirectoryNotFoundException)
							{
							}
							catch (FileNotFoundException)
							{
							}
							catch (NotSupportedException)
							{
							}
							catch (PathTooLongException)
							{
							}
							catch (UnauthorizedAccessException)
							{
							}
						}
					}
					if (stream == null)
					{
						string path = Path.Combine(Directory.GetCurrentDirectory(), text3);
						if (File.Exists(path))
						{
							try
							{
								stream = File.OpenRead(path);
							}
							catch (ArgumentException)
							{
							}
							catch (DirectoryNotFoundException)
							{
							}
							catch (FileNotFoundException)
							{
							}
							catch (NotSupportedException)
							{
							}
							catch (PathTooLongException)
							{
							}
							catch (UnauthorizedAccessException)
							{
							}
						}
					}
				}
			}
		}
		return stream;
	}

	public void InitializeFromFile(ISyntaxLanguage language, string path)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		if (path == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12470));
		}
		using FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
		if (fileStream != null)
		{
			LI2(Assembly.GetCallingAssembly(), fileStream, language, Path.GetDirectoryName(path));
		}
	}

	public void InitializeFromStream(ISyntaxLanguage language, Stream stream)
	{
		if (language == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(197912));
		}
		if (stream == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12670));
		}
		LI2(Assembly.GetCallingAssembly(), stream, language, null);
	}

	public ISyntaxLanguage LoadFromFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12470));
		}
		ISyntaxLanguage result = null;
		using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
		{
			if (fileStream != null)
			{
				result = LI2(Assembly.GetCallingAssembly(), fileStream, null, Path.GetDirectoryName(path));
			}
		}
		return result;
	}

	public ISyntaxLanguage LoadFromStream(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12670));
		}
		return LI2(Assembly.GetCallingAssembly(), stream, null, null);
	}

	private static XElement DIh(XElement P_0, string[] P_1, string P_2)
	{
		IEnumerable<XElement> enumerable = P_0.Elements();
		if (enumerable != null)
		{
			foreach (XElement item in enumerable)
			{
				foreach (string localName in P_1)
				{
					if (item.Name == XName.Get(localName, P_2))
					{
						return item;
					}
				}
			}
		}
		return null;
	}

	private static XElement[] LIN(XElement P_0, string[] P_1, string P_2)
	{
		List<XElement> list = new List<XElement>();
		IEnumerable<XElement> enumerable = P_0.Elements();
		if (enumerable != null)
		{
			foreach (XElement item in enumerable)
			{
				foreach (string localName in P_1)
				{
					if (item.Name == XName.Get(localName, P_2))
					{
						list.Add(item);
					}
				}
			}
		}
		return (list.Count > 0) ? list.ToArray() : null;
	}

	private static XElement dId(XElement P_0, string P_1, string P_2, string P_3)
	{
		return JIz(P_0, P_1, new string[1] { P_2 }, P_3);
	}

	private static XElement JIz(XElement P_0, string P_1, string[] P_2, string P_3)
	{
		if (P_2 != null)
		{
			XElement xElement = DIh(P_0, new string[1] { P_0.Name.LocalName + Q7Z.tqM(199778) + P_1 }, P_3);
			if (xElement != null)
			{
				return DIh(xElement, P_2, P_3);
			}
		}
		return null;
	}

	private static XElement[] q5W(XElement P_0, string P_1, string P_2, string P_3)
	{
		return X5P(P_0, P_1, new string[1] { P_2 }, P_3);
	}

	private static XElement[] X5P(XElement P_0, string P_1, string[] P_2, string P_3)
	{
		if (P_2 != null)
		{
			XElement xElement = DIh(P_0, new string[1] { P_0.Name.LocalName + Q7Z.tqM(199778) + P_1 }, P_3);
			if (xElement != null)
			{
				return LIN(xElement, P_2, P_3);
			}
		}
		return null;
	}

	private static XElement S5E(XElement P_0, string P_1, string P_2, string P_3)
	{
		return Q5c(P_0, P_1, new string[1] { P_2 }, P_3);
	}

	private static XElement Q5c(XElement P_0, string P_1, string[] P_2, string P_3)
	{
		return JIz(P_0, P_1, P_2, P_3) ?? DIh(P_0, P_2, P_3);
	}

	private static XElement[] j5a(XElement P_0, string P_1, string P_2, string P_3)
	{
		return H5x(P_0, P_1, new string[1] { P_2 }, P_3);
	}

	private static XElement[] H5x(XElement P_0, string P_1, string[] P_2, string P_3)
	{
		return X5P(P_0, P_1, P_2, P_3) ?? LIN(P_0, P_2, P_3);
	}

	private static Color? l5G(XElement P_0, string P_1)
	{
		string text = M5D(P_0, P_1);
		return (text != null) ? new Color?(UIColor.FromWebColor(text).ToColor()) : ((Color?)null);
	}

	private static UAV U5X<UAV>(XElement P_0, string P_1, UAV uAd)
	{
		string text = M5D(P_0, P_1);
		if (text != null)
		{
			Type type = typeof(UAV);
			if (!type.IsSubclassOf(typeof(Enum)) && type.IsGenericType)
			{
				Type[] genericArguments = type.GetGenericArguments();
				if (genericArguments != null && genericArguments.Length == 1 && genericArguments[0].IsEnum)
				{
					type = genericArguments[0];
				}
			}
			return (UAV)Enum.Parse(type, text, ignoreCase: true);
		}
		return uAd;
	}

	private static bool? L5K(XElement P_0, string P_1)
	{
		string text = M5D(P_0, P_1);
		return (text != null) ? new bool?(Convert.ToBoolean(text, CultureInfo.InvariantCulture)) : ((bool?)null);
	}

	private static int? K5f(XElement P_0, string P_1)
	{
		string text = M5D(P_0, P_1);
		return (text != null) ? new int?(Convert.ToInt32(text, CultureInfo.InvariantCulture)) : ((int?)null);
	}

	private static string M5D(XElement P_0, string P_1)
	{
		return P_0.Attribute(P_1)?.Value;
	}

	public SyntaxLanguageDefinitionSerializer()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool wGn()
	{
		return LG7 == null;
	}

	internal static SyntaxLanguageDefinitionSerializer YGq()
	{
		return LG7;
	}
}
