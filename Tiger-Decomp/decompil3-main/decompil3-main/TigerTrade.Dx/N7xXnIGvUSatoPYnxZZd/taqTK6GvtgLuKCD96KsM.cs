using System;
using System.IO;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;
using SharpDX;
using SharpDX.DirectWrite;

namespace N7xXnIGvUSatoPYnxZZd;

internal class taqTK6GvtgLuKCD96KsM : CallbackBase, FontFileEnumerator, IUnknown, ICallbackable, IDisposable
{
	private readonly Factory AbLGvTLTIUA;

	private readonly FontFileLoader heAGvykYx60;

	private readonly DataStream z8FGvZnceP6;

	private FontFile E1hGvV5oIeV;

	internal static taqTK6GvtgLuKCD96KsM qjs45QkQeuSvVPCrVa4h;

	FontFile FontFileEnumerator.CurrentFontFile
	{
		get
		{
			jDhm5KkQE1ArATrev7Vc(E1hGvV5oIeV);
			return E1hGvV5oIeV;
		}
	}

	public taqTK6GvtgLuKCD96KsM(Factory P_0, FontFileLoader P_1, DataStream P_2)
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_9c97202d436d4fdeb9d5766e35301e16 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				z8FGvZnceP6 = P_2;
				return;
			case 1:
				AbLGvTLTIUA = P_0;
				heAGvykYx60 = P_1;
				num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_23c0df2b361f4cd8810a5300adca24b7 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	bool FontFileEnumerator.MoveNext()
	{
		bool num = q0s3DdkQcxPVIv1haNWR(z8FGvZnceP6) != 0;
		if (num)
		{
			E1hGvV5oIeV?.Dispose();
			E1hGvV5oIeV = new FontFile(AbLGvTLTIUA, z8FGvZnceP6.PositionPointer, 4, heAGvykYx60);
			DataStream dataStream = z8FGvZnceP6;
			dataStream.Position = b8yq3ekQje3cIhgPkE37(dataStream) + 4;
		}
		return num;
	}

	static taqTK6GvtgLuKCD96KsM()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool WaM8tokQsHEs2qCpYhKb()
	{
		return qjs45QkQeuSvVPCrVa4h == null;
	}

	internal static taqTK6GvtgLuKCD96KsM iHW47RkQX4jC39mTBNkM()
	{
		return qjs45QkQeuSvVPCrVa4h;
	}

	internal static long q0s3DdkQcxPVIv1haNWR(object P_0)
	{
		return ((DataStream)P_0).RemainingLength;
	}

	internal static long b8yq3ekQje3cIhgPkE37(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	internal static int jDhm5KkQE1ArATrev7Vc(object P_0)
	{
		return ((IUnknown)P_0).AddReference();
	}
}
