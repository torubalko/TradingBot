using System.Windows.Media;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;

namespace TigerTrade.Dx;

public sealed class XBrush
{
	internal bool IsValid;

	private static XBrush M5QNPjkEngtlj6KOecEO;

	public static XBrush White { get; }

	public static XBrush Black { get; }

	public XColor Color { get; }

	static XBrush()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_864675f4630f4f79a61c0e443925db5c != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				White = new XBrush(p1l0fIkEvRqkJjlusPWX(XUfOEgkEoWxp6v6NAIvv()));
				Black = new XBrush(p1l0fIkEvRqkJjlusPWX(LmLOx8kEBXsorJuIVPEs()));
				return;
			}
			qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
			num = 1;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_de21cd78737049749dce66b024a96c1f == 0)
			{
				num = 1;
			}
		}
	}

	public XBrush(XColor color)
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_883e1ff4b87e4e34a59abd4a690f92d5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Color = color;
		IsValid = Color.IsValid && !Color.IsTransparent;
	}

	public XBrush(XColor color, int alpha)
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_a157e6a3d94947ada3590d3d2dc40b26 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Color = new XColor((byte)alpha, color);
		IsValid = Color.IsValid && !Color.IsTransparent;
	}

	internal static Color XUfOEgkEoWxp6v6NAIvv()
	{
		return Colors.White;
	}

	internal static XColor p1l0fIkEvRqkJjlusPWX(Color color)
	{
		return color;
	}

	internal static Color LmLOx8kEBXsorJuIVPEs()
	{
		return Colors.Black;
	}

	internal static bool gZUdHHkEGDqoLCucgEIZ()
	{
		return M5QNPjkEngtlj6KOecEO == null;
	}

	internal static XBrush DZGqcpkEYdhMqPMhDYOP()
	{
		return M5QNPjkEngtlj6KOecEO;
	}
}
