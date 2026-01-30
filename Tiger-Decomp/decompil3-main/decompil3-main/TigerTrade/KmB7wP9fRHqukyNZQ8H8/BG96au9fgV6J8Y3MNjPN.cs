using System.Configuration;
using System.Reflection;
using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using zkHtNg9fImUaeO7bxwVW;

namespace KmB7wP9fRHqukyNZQ8H8;

[DefaultMember("Item")]
[ConfigurationCollection(typeof(n8Wl8O9fqNNZCRNuFMKd))]
public class BG96au9fgV6J8Y3MNjPN : ConfigurationElementCollection
{
	internal static BG96au9fgV6J8Y3MNjPN Xh3lBmbbXuTdBaTLCY3Z;

	[SpecialName]
	public n8Wl8O9fqNNZCRNuFMKd X8K9f6ItNut(string P_0)
	{
		return (n8Wl8O9fqNNZCRNuFMKd)BaseGet(P_0);
	}

	[SpecialName]
	public void daA9fMKBdLQ(string P_0, n8Wl8O9fqNNZCRNuFMKd P_1)
	{
		if (MbgkWYbbEiYR8c5M7JI3(this, P_0) != null)
		{
			BaseRemoveAt(X1IStIbbQe5nJE1JVRr8(this, BaseGet(P_0)));
		}
		bjfGaUbbdZe4RKAwnLKg(this, P_1);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override ConfigurationElement CreateNewElement()
	{
		return new n8Wl8O9fqNNZCRNuFMKd();
	}

	protected override object GetElementKey(ConfigurationElement P_0)
	{
		return ((n8Wl8O9fqNNZCRNuFMKd)P_0).Key;
	}

	public BG96au9fgV6J8Y3MNjPN()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static BG96au9fgV6J8Y3MNjPN()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool vjsdTebbcuodalLbEP8i()
	{
		return Xh3lBmbbXuTdBaTLCY3Z == null;
	}

	internal static BG96au9fgV6J8Y3MNjPN blQNHpbbj4T3qaQJUP1j()
	{
		return Xh3lBmbbXuTdBaTLCY3Z;
	}

	internal static object MbgkWYbbEiYR8c5M7JI3(object P_0, object P_1)
	{
		return ((ConfigurationElementCollection)P_0).BaseGet(P_1);
	}

	internal static int X1IStIbbQe5nJE1JVRr8(object P_0, object P_1)
	{
		return ((ConfigurationElementCollection)P_0).BaseIndexOf((ConfigurationElement)P_1);
	}

	internal static void bjfGaUbbdZe4RKAwnLKg(object P_0, object P_1)
	{
		((ConfigurationElementCollection)P_0).BaseAdd((ConfigurationElement)P_1);
	}
}
