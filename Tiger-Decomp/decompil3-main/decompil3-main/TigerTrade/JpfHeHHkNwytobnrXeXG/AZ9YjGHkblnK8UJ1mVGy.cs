using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Markup;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace JpfHeHHkNwytobnrXeXG;

internal class AZ9YjGHkblnK8UJ1mVGy : MarkupExtension
{
	public class zXK07FnTFZJl5Ho0hMhV
	{
		[CompilerGenerated]
		private string EUHny0ymss9;

		[CompilerGenerated]
		private object KwZny2xRuYW;

		private static zXK07FnTFZJl5Ho0hMhV aRM0H4NLBFooevwwRxGu;

		public string Description
		{
			[CompilerGenerated]
			get
			{
				return EUHny0ymss9;
			}
			[CompilerGenerated]
			set
			{
				EUHny0ymss9 = eUHny0ymss;
			}
		}

		public object Value
		{
			[CompilerGenerated]
			get
			{
				return KwZny2xRuYW;
			}
			[CompilerGenerated]
			set
			{
				KwZny2xRuYW = kwZny2xRuYW;
			}
		}

		public zXK07FnTFZJl5Ho0hMhV()
		{
			oaBFKFNLlwUZgbnJiqKR();
			base._002Ector();
		}

		static zXK07FnTFZJl5Ho0hMhV()
		{
			cDDPEZNL4GD1EYx4Q1dd();
		}

		internal static bool clo4VxNLarXm7g4apGiL()
		{
			return aRM0H4NLBFooevwwRxGu == null;
		}

		internal static zXK07FnTFZJl5Ho0hMhV PeEduBNLiXbjqYocoNeX()
		{
			return aRM0H4NLBFooevwwRxGu;
		}

		internal static void oaBFKFNLlwUZgbnJiqKR()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static void cDDPEZNL4GD1EYx4Q1dd()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	private Type xatHkLPSCQa;

	internal static AZ9YjGHkblnK8UJ1mVGy msL74LDSAs2PnkFa1SZO;

	public AZ9YjGHkblnK8UJ1mVGy(Type P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		if ((object)P_0 != null)
		{
			pJDHkS3Tjcb(P_0);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
			return;
		}
		throw new ArgumentNullException(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1801468030 ^ -1801525528));
	}

	[SpecialName]
	public Type UlFHk5H36Z3()
	{
		return xatHkLPSCQa;
	}

	[SpecialName]
	private void pJDHkS3Tjcb(Type P_0)
	{
		if (xatHkLPSCQa == P_0)
		{
			return;
		}
		Type type = Nullable.GetUnderlyingType(P_0);
		if ((object)type == null)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			type = P_0;
		}
		if (!type.IsEnum)
		{
			throw new ArgumentException((string)Tw2f9hDSFgvVW4qQhgDK(0x1EFE0A28 ^ 0x1EFF2B56));
		}
		xatHkLPSCQa = P_0;
	}

	public override object ProvideValue(IServiceProvider P_0)
	{
		return (from object obj in Enum.GetValues(UlFHk5H36Z3())
			select new zXK07FnTFZJl5Ho0hMhV
			{
				Value = obj,
				Description = HorHkkEbOjR(obj)
			}).ToArray();
	}

	private string HorHkkEbOjR(object P_0)
	{
		if (!(((IEnumerable<object>)cKdaumDSphvWZH07JB1Z(UlFHk5H36Z3().GetField(P_0.ToString()), J2g8DtDS3SWUGuh7uC91(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777247)), false)).FirstOrDefault() is DescriptionAttribute descriptionAttribute))
		{
			return P_0.ToString();
		}
		return descriptionAttribute.Description;
	}

	[CompilerGenerated]
	private zXK07FnTFZJl5Ho0hMhV pFkHk1k76k3(object P_0)
	{
		return new zXK07FnTFZJl5Ho0hMhV
		{
			Value = P_0,
			Description = HorHkkEbOjR(P_0)
		};
	}

	static AZ9YjGHkblnK8UJ1mVGy()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool L3kH1NDSPX43BpKUxMGE()
	{
		return msL74LDSAs2PnkFa1SZO == null;
	}

	internal static AZ9YjGHkblnK8UJ1mVGy l7qvwSDSJMoR9AhRdiV6()
	{
		return msL74LDSAs2PnkFa1SZO;
	}

	internal static object Tw2f9hDSFgvVW4qQhgDK(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static Type J2g8DtDS3SWUGuh7uC91(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object cKdaumDSphvWZH07JB1Z(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}
}
