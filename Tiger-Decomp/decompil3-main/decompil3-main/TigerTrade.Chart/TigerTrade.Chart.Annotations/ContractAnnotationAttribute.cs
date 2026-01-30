using System;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;

namespace TigerTrade.Chart.Annotations;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class ContractAnnotationAttribute : Attribute
{
	private static ContractAnnotationAttribute fSNDSJLJvAUMFcOImBAq;

	[NotNull]
	public string Contract { get; private set; }

	public bool ForceFullStates { get; private set; }

	public ContractAnnotationAttribute([NotNull] string contract)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		this._002Ector(contract, forceFullStates: false);
	}

	public ContractAnnotationAttribute([NotNull] string contract, bool forceFullStates)
	{
		hp6PdRLJiknwioficnkJ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Contract = contract;
		ForceFullStates = forceFullStates;
	}

	static ContractAnnotationAttribute()
	{
		CWtZQ1LJl3RFmtNNYVF1();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool IKYWEcLJBB3Kg49nArX8()
	{
		return fSNDSJLJvAUMFcOImBAq == null;
	}

	internal static ContractAnnotationAttribute EHdbXnLJagKZb3nq0xB2()
	{
		return fSNDSJLJvAUMFcOImBAq;
	}

	internal static void hp6PdRLJiknwioficnkJ()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static void CWtZQ1LJl3RFmtNNYVF1()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
