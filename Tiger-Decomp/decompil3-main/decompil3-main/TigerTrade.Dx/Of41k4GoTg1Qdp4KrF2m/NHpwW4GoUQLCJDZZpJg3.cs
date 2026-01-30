using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using f2JVnFGom8EMhUtDPoRs;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;
using SharpDX;
using SharpDX.Multimedia;
using SharpDX.XAudio2;
using TigerTrade.Core.Utils.Logging;

namespace Of41k4GoTg1Qdp4KrF2m;

public class NHpwW4GoUQLCJDZZpJg3 : vCn3XRGoKVvafsvAHLC0
{
	private class lSpNoFGB50ZAYTugpqbI
	{
		public readonly SourceVoice gJlGBSF4gJb;

		public readonly AudioBuffer MQUGBxNXQDi;

		internal static lSpNoFGB50ZAYTugpqbI KYaWk0kdkOCMZ5JFon8y;

		public lSpNoFGB50ZAYTugpqbI(SourceVoice P_0, AudioBuffer P_1)
		{
			qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
			base._002Ector();
			gJlGBSF4gJb = P_0;
			MQUGBxNXQDi = P_1;
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_744051fff5ee4fd88eb37a2c62f67f62 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static lSpNoFGB50ZAYTugpqbI()
		{
			vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
			P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool fIxo0ukd1xdX7U7au3S1()
		{
			return KYaWk0kdkOCMZ5JFon8y == null;
		}

		internal static lSpNoFGB50ZAYTugpqbI sK5e5Ckd58uJIr4XKqjU()
		{
			return KYaWk0kdkOCMZ5JFon8y;
		}
	}

	private readonly Dictionary<string, lSpNoFGB50ZAYTugpqbI> GR1Goy3t2Xs;

	private readonly XAudio2 rdUGoZ91JmZ;

	private readonly MasteringVoice xQaGoVpPpOF;

	private SourceVoice lsWGoCBtXia;

	private readonly object xJxGorbJ9Ok;

	private static NHpwW4GoUQLCJDZZpJg3 MbC2SSkjEScY2HWrcAMT;

	public double Dsol9eLTWeh
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (lsWGoCBtXia != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_a88909e12c974739b0a37dd0a505569a == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_0024;
				default:
					{
						if (rdUGoZ91JmZ != null)
						{
							lsWGoCBtXia.GetVolume(out var volumeRef);
							return volumeRef;
						}
						goto IL_0024;
					}
					IL_0024:
					return -1.0;
				}
			}
		}
		set
		{
			aADXf9kjOjiwrSnjmlwk(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-602153869 ^ -602154583));
			if (lsWGoCBtXia == null)
			{
				return;
			}
			while (rdUGoZ91JmZ != null)
			{
				int num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_37442e8fbe0a4d0b81152928e1eb527c == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 2:
					return;
				case 1:
					continue;
				}
				try
				{
					Xg80wTkjq60JYYhHtHZF(lsWGoCBtXia, (float)num2, 0);
					return;
				}
				catch (Exception e)
				{
					LogManager.WriteError(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(--855742383 ^ 0x330191BF), e);
					return;
				}
			}
		}
	}

	public NHpwW4GoUQLCJDZZpJg3()
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		GR1Goy3t2Xs = new Dictionary<string, lSpNoFGB50ZAYTugpqbI>();
		xJxGorbJ9Ok = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_2e105f252f2d4c3197f1ac87f7d5a037 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 1:
			return;
		}
		try
		{
			LogManager.WriteInfo(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x385FFAB ^ 0x385FB11));
			rdUGoZ91JmZ = new XAudio2();
			xQaGoVpPpOF = new MasteringVoice(rdUGoZ91JmZ);
			int num2 = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_ff0a4d8796cd433cb37c0cf2a1b8489a == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			case 0:
				break;
			}
		}
		catch (SharpDXException e)
		{
			LogManager.WriteError(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-1774602229 ^ -1774600979), e);
			rdUGoZ91JmZ = null;
			int num3 = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_56b8b1a6026c4b1e82172f38beccbc71 != 0)
			{
				num3 = 0;
			}
			switch (num3)
			{
			}
			xQaGoVpPpOF = null;
		}
		catch (Exception e2)
		{
			int num4 = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_05692657bf2742bd873f9ce176ecb3de != 0)
			{
				num4 = 0;
			}
			switch (num4)
			{
			}
			LogManager.WriteError((string)aYHvSckjgb8miQi1IvZM(-2017337494 ^ -2017338848), e2);
			rdUGoZ91JmZ = null;
			xQaGoVpPpOF = null;
		}
	}

	public void Open(string P_0)
	{
		try
		{
			LogManager.WriteInfo(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x24085900 ^ 0x24085C7C));
			int num = 1;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_4244154882d84aceb472cc9692dc853e != 0)
			{
				num = 0;
			}
			object obj = default(object);
			lSpNoFGB50ZAYTugpqbI value = default(lSpNoFGB50ZAYTugpqbI);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (string.IsNullOrEmpty(P_0) || rdUGoZ91JmZ == null)
					{
						return;
					}
					break;
				case 2:
				{
					bool lockTaken = false;
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num2 = 0;
						if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_625649b49e194040b4ce727cb6f9ee27 != 0)
						{
							num2 = 0;
						}
						while (true)
						{
							switch (num2)
							{
							case 1:
								GR1Goy3t2Xs.Add(P_0, value);
								goto IL_00a4;
							case 5:
							{
								SoundStream soundStream = new SoundStream(File.OpenRead(P_0));
								WaveFormat format = soundStream.Format;
								AudioBuffer audioBuffer = new AudioBuffer
								{
									Stream = soundStream.ToDataStream(),
									AudioBytes = (int)IKPNGIkjRgNbrYCkmWdW(soundStream),
									Flags = BufferFlags.EndOfStream
								};
								soundStream.Close();
								SourceVoice sourceVoice = new SourceVoice(rdUGoZ91JmZ, format, enableCallbackEvents: false);
								sourceVoice.SubmitSourceBuffer(audioBuffer, soundStream.DecodedPacketsInfo);
								value = new lSpNoFGB50ZAYTugpqbI(sourceVoice, audioBuffer);
								num2 = 1;
								if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_b9fb19cfd21f4fc4a96e87e964085d04 != 0)
								{
									num2 = 1;
								}
								continue;
							}
							default:
								if (GR1Goy3t2Xs.TryGetValue(P_0, out value))
								{
									break;
								}
								goto case 5;
							case 2:
								break;
							case 3:
								value.gJlGBSF4gJb.SubmitSourceBuffer(value.MQUGBxNXQDi, null);
								goto IL_00a4;
							case 4:
								return;
								IL_00a4:
								lsWGoCBtXia = value.gJlGBSF4gJb;
								num2 = 4;
								continue;
							}
							B1KbAPkj62EK9pfbLhk0(value.gJlGBSF4gJb);
							hT2CBlkjMNb3JPds63A2(value.gJlGBSF4gJb);
							num2 = 3;
						}
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(obj);
						}
					}
				}
				}
				obj = xJxGorbJ9Ok;
				num = 2;
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x735715F1 ^ 0x73571059), e);
		}
	}

	public void Stop()
	{
		try
		{
			LogManager.WriteInfo(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-1009517961 ^ -1009517509));
			if (rdUGoZ91JmZ == null)
			{
				return;
			}
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_9e61d8add8d44babb7ee69056242227b == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					lsWGoCBtXia?.FlushSourceBuffers();
					return;
				case 2:
					return;
				default:
				{
					SourceVoice sourceVoice = lsWGoCBtXia;
					if (sourceVoice == null)
					{
						goto case 1;
					}
					sourceVoice.Stop();
					num = 1;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_f5528508a13a45b09f609c79ae9fcac4 != 0)
					{
						num = 1;
					}
					break;
				}
				}
			}
		}
		catch (Exception e)
		{
			LogManager.WriteError(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0x28BBDCA ^ 0x28BBBB2), e);
		}
	}

	public void Fy1l9cyZWeh()
	{
		try
		{
			aADXf9kjOjiwrSnjmlwk(aYHvSckjgb8miQi1IvZM(0x4662F6AF ^ 0x4662F005));
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_56b8b1a6026c4b1e82172f38beccbc71 != 0)
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
				if (rdUGoZ91JmZ == null)
				{
					num = 1;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_9e61d8add8d44babb7ee69056242227b == 0)
					{
						num = 1;
					}
					continue;
				}
				SourceVoice sourceVoice = lsWGoCBtXia;
				if (sourceVoice != null)
				{
					ALDqMLkjIbZpTjGaZZcS(sourceVoice);
				}
				return;
			}
		}
		catch (Exception ex)
		{
			GBFx0tkjWHn5vjSS67yx(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-617064403 ^ -617062661), ex);
		}
	}

	static NHpwW4GoUQLCJDZZpJg3()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object aYHvSckjgb8miQi1IvZM(int P_0)
	{
		return vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(P_0);
	}

	internal static bool zlmuHwkjQprBwHX35L5f()
	{
		return MbC2SSkjEScY2HWrcAMT == null;
	}

	internal static NHpwW4GoUQLCJDZZpJg3 Ny7F3dkjdQ3AqfjUo1R9()
	{
		return MbC2SSkjEScY2HWrcAMT;
	}

	internal static long IKPNGIkjRgNbrYCkmWdW(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static void B1KbAPkj62EK9pfbLhk0(object P_0)
	{
		((SourceVoice)P_0).Stop();
	}

	internal static void hT2CBlkjMNb3JPds63A2(object P_0)
	{
		((SourceVoice)P_0).FlushSourceBuffers();
	}

	internal static void aADXf9kjOjiwrSnjmlwk(object P_0)
	{
		LogManager.WriteInfo((string)P_0);
	}

	internal static void Xg80wTkjq60JYYhHtHZF(object P_0, float P_1, int P_2)
	{
		((Voice)P_0).SetVolume(P_1, P_2);
	}

	internal static void ALDqMLkjIbZpTjGaZZcS(object P_0)
	{
		((SourceVoice)P_0).Start();
	}

	internal static void GBFx0tkjWHn5vjSS67yx(object P_0, object P_1)
	{
		LogManager.WriteError((string)P_0, (Exception)P_1);
	}
}
