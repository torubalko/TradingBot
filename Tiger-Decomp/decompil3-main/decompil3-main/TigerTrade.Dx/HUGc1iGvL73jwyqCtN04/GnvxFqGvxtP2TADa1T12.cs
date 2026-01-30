using System.Runtime.CompilerServices;
using System.Windows.Media;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;
using LckAIVGv1q9tlWqHdC7b;

namespace HUGc1iGvL73jwyqCtN04;

internal class GnvxFqGvxtP2TADa1T12
{
	private readonly GlyphTypeface fD2GvEX7IGn;

	private readonly rfemodGvkIb7bHow3Pkn[] FpgGvQrLTpj;

	[CompilerGenerated]
	private readonly double uuhGvdJPJoR;

	internal static GnvxFqGvxtP2TADa1T12 pl8SlSkE3fdJXBccRBmZ;

	public GnvxFqGvxtP2TADa1T12(GlyphTypeface P_0)
	{
		NuVmEokEzTrreSDaVlXX();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_56b8b1a6026c4b1e82172f38beccbc71 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				FpgGvQrLTpj = new rfemodGvkIb7bHow3Pkn[65536];
				uuhGvdJPJoR = ROJi4CkQ0prZa2J3Ml9r(fD2GvEX7IGn);
				return;
			}
			fD2GvEX7IGn = P_0;
			num = 1;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_bd63eb643aa34f16bc5bf5aec8c37779 != 0)
			{
				num = 0;
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public double wJRGvcBt7jF()
	{
		return uuhGvdJPJoR;
	}

	public rfemodGvkIb7bHow3Pkn mUyGveoQMjN(char P_0)
	{
		rfemodGvkIb7bHow3Pkn rfemodGvkIb7bHow3Pkn = FpgGvQrLTpj[(uint)P_0];
		if (rfemodGvkIb7bHow3Pkn != null)
		{
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_71862513ffe24172acf3377a71840acf == 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => rfemodGvkIb7bHow3Pkn, 
			};
		}
		rfemodGvkIb7bHow3Pkn = new rfemodGvkIb7bHow3Pkn
		{
			GuRGv5Dp1By = UoEGvXUB664(P_0, out var qo4GvSHe7Et),
			Qo4GvSHe7Et = qo4GvSHe7Et
		};
		FpgGvQrLTpj[(uint)P_0] = rfemodGvkIb7bHow3Pkn;
		return rfemodGvkIb7bHow3Pkn;
	}

	public double zqTGvsga18W(char P_0)
	{
		return mUyGveoQMjN(P_0).GuRGv5Dp1By;
	}

	private double UoEGvXUB664(ushort P_0, out short P_1)
	{
		fD2GvEX7IGn.CharacterToGlyphMap.TryGetValue(P_0, out var value);
		P_1 = (short)value;
		return fD2GvEX7IGn.AdvanceWidths[value];
	}

	static GnvxFqGvxtP2TADa1T12()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void NuVmEokEzTrreSDaVlXX()
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
	}

	internal static double ROJi4CkQ0prZa2J3Ml9r(object P_0)
	{
		return ((GlyphTypeface)P_0).CapsHeight;
	}

	internal static bool cdbuRUkEpMAWuHty6d34()
	{
		return pl8SlSkE3fdJXBccRBmZ == null;
	}

	internal static GnvxFqGvxtP2TADa1T12 J0qYDVkEu4UMLQjoaFZZ()
	{
		return pl8SlSkE3fdJXBccRBmZ;
	}
}
