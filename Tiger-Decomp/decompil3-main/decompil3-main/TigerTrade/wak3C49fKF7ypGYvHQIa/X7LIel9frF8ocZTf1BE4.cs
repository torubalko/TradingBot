using System.Configuration;
using System.Reflection;
using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using QTHhwX9f8Xdf60vpRbwm;
using TuAMtrl1Nd3XoZQQUXf0;

namespace wak3C49fKF7ypGYvHQIa;

[ConfigurationCollection(typeof(Rc9bRZ9f7uZ1kpq4j1X8))]
[DefaultMember("Item")]
public class X7LIel9frF8ocZTf1BE4 : ConfigurationElementCollection
{
	internal static X7LIel9frF8ocZTf1BE4 o6qSywbbZfyqbWN1N1jZ;

	[SpecialName]
	public Rc9bRZ9f7uZ1kpq4j1X8 qjb9fmbrAZk(string P_0)
	{
		return (Rc9bRZ9f7uZ1kpq4j1X8)SJHJm1bbrUCQRl4Pkqe9(this, P_0);
	}

	[SpecialName]
	public void LPS9fhCZsXT(string P_0, Rc9bRZ9f7uZ1kpq4j1X8 P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				WOR4PJbbK9tSBVG9YOb6(this, BaseIndexOf((ConfigurationElement)SJHJm1bbrUCQRl4Pkqe9(this, P_0)));
				goto IL_003d;
			case 1:
				{
					if (SJHJm1bbrUCQRl4Pkqe9(this, P_0) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_003d;
				}
				IL_003d:
				BaseAdd(P_1);
				return;
			}
		}
	}

	protected override ConfigurationElement CreateNewElement()
	{
		return new Rc9bRZ9f7uZ1kpq4j1X8();
	}

	protected override object GetElementKey(ConfigurationElement P_0)
	{
		return ((Rc9bRZ9f7uZ1kpq4j1X8)P_0).Key;
	}

	public X7LIel9frF8ocZTf1BE4()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static X7LIel9frF8ocZTf1BE4()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object SJHJm1bbrUCQRl4Pkqe9(object P_0, object P_1)
	{
		return ((ConfigurationElementCollection)P_0).BaseGet(P_1);
	}

	internal static bool f2rYg5bbVMwda9enPJ4n()
	{
		return o6qSywbbZfyqbWN1N1jZ == null;
	}

	internal static X7LIel9frF8ocZTf1BE4 OU0dPjbbC8h8kwxsANZb()
	{
		return o6qSywbbZfyqbWN1N1jZ;
	}

	internal static void WOR4PJbbK9tSBVG9YOb6(object P_0, int P_1)
	{
		((ConfigurationElementCollection)P_0).BaseRemoveAt(P_1);
	}
}
