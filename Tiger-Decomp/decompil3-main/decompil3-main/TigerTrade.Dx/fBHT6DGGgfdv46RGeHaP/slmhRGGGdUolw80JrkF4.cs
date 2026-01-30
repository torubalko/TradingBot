using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using fZl77HkDbCF2hZri4dVV;
using H59IbFkNkUTQB7uIfts0;
using kvtsvxkNBA3S7tECx5XS;
using SharpDX;
using SharpDX.IO;
using SharpDX.Multimedia;
using SharpDX.XAudio2;
using TigerTrade.Core.Utils.Logging;

namespace fBHT6DGGgfdv46RGeHaP;

public class slmhRGGGdUolw80JrkF4
{
	private class Ec0qtrGBlC0SEnrKD2HL
	{
		public readonly SourceVoice ba8GB4EALNr;

		public readonly AudioBuffer i3EGBDZr8jy;

		internal static Ec0qtrGBlC0SEnrKD2HL tQRL1gkdBXQo8tOujFwL;

		public Ec0qtrGBlC0SEnrKD2HL(SourceVoice P_0, AudioBuffer P_1)
		{
			qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_9ea6ac1b9978445f984c9b1d9e0008bf != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			ba8GB4EALNr = P_0;
			i3EGBDZr8jy = P_1;
		}

		static Ec0qtrGBlC0SEnrKD2HL()
		{
			NcoFMRkdlce3wo8X7UC8();
			P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool xxDtUkkdalef5HYMr1FU()
		{
			return tQRL1gkdBXQo8tOujFwL == null;
		}

		internal static Ec0qtrGBlC0SEnrKD2HL u6liSMkdiFws8gXZitKq()
		{
			return tQRL1gkdBXQo8tOujFwL;
		}

		internal static void NcoFMRkdlce3wo8X7UC8()
		{
			vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
		}
	}

	[CompilerGenerated]
	private sealed class BCaZd8GBbxyP6ysgDbFD
	{
		public slmhRGGGdUolw80JrkF4 CKuGBkxv3vn;

		public AudioBuffer sukGB15DHUA;

		internal static BCaZd8GBbxyP6ysgDbFD BtCVqGkd4BiVxLcOIRVC;

		public BCaZd8GBbxyP6ysgDbFD()
		{
			qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
			base._002Ector();
		}

		internal void oBZGBNwS8Va(IntPtr context)
		{
			kvL5WOkdNBeJebwLv6cI(CKuGBkxv3vn.AFSGGT3xDD1, sukGB15DHUA, CKuGBkxv3vn.mJ9GGVwtLT5.DecodedPacketsInfo);
		}

		static BCaZd8GBbxyP6ysgDbFD()
		{
			vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
			P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool jmCrbfkdDvQcTkTwbX59()
		{
			return BtCVqGkd4BiVxLcOIRVC == null;
		}

		internal static BCaZd8GBbxyP6ysgDbFD il0ixSkdbHnV0LaG3Zg7()
		{
			return BtCVqGkd4BiVxLcOIRVC;
		}

		internal static void kvL5WOkdNBeJebwLv6cI(object P_0, object P_1, object P_2)
		{
			((SourceVoice)P_0).SubmitSourceBuffer((AudioBuffer)P_1, (uint[])P_2);
		}
	}

	private readonly Dictionary<string, Ec0qtrGBlC0SEnrKD2HL> tFrGGI07qNZ;

	private readonly XAudio2 WSfGGWrLZAR;

	private readonly MasteringVoice WPZGGtXEf0I;

	private SourceVoice FQTGGUm41DI;

	private SourceVoice AFSGGT3xDD1;

	private readonly object LTXGGyTDQWf;

	private NativeFileStream bxhGGZRC0mR;

	private SoundStream mJ9GGVwtLT5;

	private DataStream aKlGGC9PCbn;

	internal static slmhRGGGdUolw80JrkF4 LxqAPokXmk8q2qDeB8qr;

	public slmhRGGGdUolw80JrkF4()
	{
		qenpj1kNvArYd94Dp3W2.xFYkW4O7C9a();
		tFrGGI07qNZ = new Dictionary<string, Ec0qtrGBlC0SEnrKD2HL>();
		LTXGGyTDQWf = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_626ac6dc76ed4045a1c38eaf4d1f1e5d == 0)
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
			WSfGGWrLZAR = new XAudio2();
			WPZGGtXEf0I = new MasteringVoice(WSfGGWrLZAR);
		}
		catch (SharpDXException e)
		{
			LogManager.WriteError(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-448941864 ^ -448941940), e);
			int num2 = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_625649b49e194040b4ce727cb6f9ee27 == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			}
			WSfGGWrLZAR = null;
			WPZGGtXEf0I = null;
		}
		catch (Exception ex)
		{
			WShkvSkX7TOfKJFlZKHG(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-165474503 ^ -165474431), ex);
			WSfGGWrLZAR = null;
			int num3 = 0;
			if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_432f46d1d7314c65a511e6124fe643b3 == 0)
			{
				num3 = 0;
			}
			switch (num3)
			{
			}
			WPZGGtXEf0I = null;
		}
	}

	public void gNEGGRWuTCe(string P_0)
	{
		try
		{
			GoILWGkX8tgtIOem44Fr(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-1522697859 ^ -1522697833));
			if (string.IsNullOrEmpty(P_0) || WSfGGWrLZAR == null)
			{
				return;
			}
			lock (LTXGGyTDQWf)
			{
				SoundStream soundStream = default(SoundStream);
				int num;
				if (!tFrGGI07qNZ.TryGetValue(P_0, out var value))
				{
					soundStream = new SoundStream(File.OpenRead(P_0));
					num = 4;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_ad54b84e60ad4cb5b706bdc362a3d52b != 0)
					{
						num = 3;
					}
					goto IL_00bb;
				}
				goto IL_0119;
				IL_00bb:
				while (true)
				{
					switch (num)
					{
					case 1:
					case 3:
						FQTGGUm41DI = value.ba8GB4EALNr;
						return;
					case 4:
					{
						WaveFormat format = soundStream.Format;
						AudioBuffer audioBuffer = new AudioBuffer
						{
							Stream = (DataStream)GidpBWkXABJ5dkMTq5Ht(soundStream),
							AudioBytes = (int)yMsrXfkXPHPdLtXFhHBi(soundStream),
							Flags = BufferFlags.EndOfStream
						};
						soundStream.Close();
						SourceVoice sourceVoice = new SourceVoice(WSfGGWrLZAR, format, enableCallbackEvents: false);
						ATp6vnkXJcDhApvDdrxT(sourceVoice, audioBuffer, soundStream.DecodedPacketsInfo);
						value = new Ec0qtrGBlC0SEnrKD2HL(sourceVoice, audioBuffer);
						num = 2;
						if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_05692657bf2742bd873f9ce176ecb3de != 0)
						{
							num = 2;
						}
						continue;
					}
					case 2:
						tFrGGI07qNZ.Add(P_0, value);
						num = 3;
						if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_17f56675ec65443a9b27990370f77848 != 0)
						{
							num = 3;
						}
						continue;
					}
					break;
				}
				goto IL_0119;
				IL_0119:
				value.ba8GB4EALNr.Stop();
				value.ba8GB4EALNr.FlushSourceBuffers();
				value.ba8GB4EALNr.SubmitSourceBuffer(value.i3EGBDZr8jy, null);
				num = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_f86e5f1f94bb473ea99521e551650092 != 0)
				{
					num = 0;
				}
				goto IL_00bb;
			}
		}
		catch (Exception ex)
		{
			WShkvSkX7TOfKJFlZKHG(NjIxJDkXFf7DwsGhcAO5(-5977659 ^ -5977901), ex);
		}
	}

	public void UsQGG6BuPR7()
	{
		try
		{
			if (WSfGGWrLZAR == null)
			{
				return;
			}
			SourceVoice fQTGGUm41DI2;
			while (true)
			{
				SourceVoice fQTGGUm41DI = FQTGGUm41DI;
				if (fQTGGUm41DI != null)
				{
					a71QbtkX3mcmm8lYiWyF(fQTGGUm41DI);
				}
				fQTGGUm41DI2 = FQTGGUm41DI;
				if (fQTGGUm41DI2 != null)
				{
					break;
				}
				int num = 1;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_7e2cedcef3cc4cf38b7bccbb81c290d2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					return;
				}
			}
			Flb58ckXpIUGffJLZ6W4(fQTGGUm41DI2);
		}
		catch (Exception e)
		{
			LogManager.WriteError((string)NjIxJDkXFf7DwsGhcAO5(-842040449 ^ -842040777), e);
		}
	}

	public void Q2mGGMJKxto()
	{
		try
		{
			if (WSfGGWrLZAR == null)
			{
				int num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_7cdcc7f22c1c45758ad6a22691ad1f90 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
			else
			{
				SourceVoice fQTGGUm41DI = FQTGGUm41DI;
				if (fQTGGUm41DI != null)
				{
					h72nEUkXubiQU3rB4wjf(fQTGGUm41DI);
				}
			}
		}
		catch (Exception ex)
		{
			WShkvSkX7TOfKJFlZKHG(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(--871424829 ^ 0x33F0E247), ex);
		}
	}

	public void abIGGOm0IKj(string P_0)
	{
		int num = 1;
		int num2 = num;
		BCaZd8GBbxyP6ysgDbFD bCaZd8GBbxyP6ysgDbFD = default(BCaZd8GBbxyP6ysgDbFD);
		while (true)
		{
			switch (num2)
			{
			case 1:
				bCaZd8GBbxyP6ysgDbFD = new BCaZd8GBbxyP6ysgDbFD();
				num2 = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_2389a6f9140241a4a585b48e518be2dd != 0)
				{
					num2 = 0;
				}
				continue;
			}
			bCaZd8GBbxyP6ysgDbFD.CKuGBkxv3vn = this;
			try
			{
				if (string.IsNullOrEmpty(P_0) || WSfGGWrLZAR == null)
				{
					return;
				}
				while (true)
				{
					bxhGGZRC0mR = new NativeFileStream(P_0, NativeFileMode.Open, NativeFileAccess.Read);
					mJ9GGVwtLT5 = new SoundStream(bxhGGZRC0mR);
					int num3 = 1;
					if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_fea930b6f02c4324b62fc155550453ca != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 4:
							if (AFSGGT3xDD1 == null)
							{
								AFSGGT3xDD1 = new SourceVoice(WSfGGWrLZAR, mJ9GGVwtLT5.Format);
								bCaZd8GBbxyP6ysgDbFD.sukGB15DHUA = new AudioBuffer
								{
									Stream = aKlGGC9PCbn,
									AudioBytes = (int)aKlGGC9PCbn.Length,
									Flags = BufferFlags.None
								};
								AFSGGT3xDD1.BufferEnd += bCaZd8GBbxyP6ysgDbFD.oBZGBNwS8Va;
								num3 = 3;
								if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_1f10bc03091f4bd381d7108e341d458d == 0)
								{
									num3 = 3;
								}
								continue;
							}
							goto case 2;
						case 1:
							aKlGGC9PCbn = mJ9GGVwtLT5.ToDataStream();
							num3 = 2;
							if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_074b09844c3c44949f01ad6af7266f45 == 0)
							{
								num3 = 4;
							}
							continue;
						case 2:
							AFSGGT3xDD1.Start();
							return;
						case 3:
							ATp6vnkXJcDhApvDdrxT(AFSGGT3xDD1, bCaZd8GBbxyP6ysgDbFD.sukGB15DHUA, nsqJt1kXzMKXmvA3r1XG(mJ9GGVwtLT5));
							num3 = 2;
							if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_10b7977984684a30b2d10583321d7520 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					}
				}
			}
			catch (Exception e)
			{
				LogManager.WriteError(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(0xC1DDB3B ^ 0xC1DDA97), e);
				return;
			}
		}
	}

	public void bIZGGq4jlH8()
	{
		try
		{
			if (WSfGGWrLZAR == null)
			{
				return;
			}
			SourceVoice aFSGGT3xDD = AFSGGT3xDD1;
			if (aFSGGT3xDD != null)
			{
				a71QbtkX3mcmm8lYiWyF(aFSGGT3xDD);
				int num = 0;
				if (_003CModule_003E_007Bb15b547b_002D0c8d_002D403b_002Dab59_002D8d46c3561607_007D.m_625649b49e194040b4ce727cb6f9ee27 != 0)
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
		catch (Exception e)
		{
			LogManager.WriteError(vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(-1435596783 ^ -1435596297), e);
		}
	}

	static slmhRGGGdUolw80JrkF4()
	{
		vpHjm6kDDRWPs2gcoFH7.YVLkDdJnH9g();
		RSATR5kc0EjxNFmSFmoe();
	}

	internal static void WShkvSkX7TOfKJFlZKHG(object P_0, object P_1)
	{
		LogManager.WriteError((string)P_0, (Exception)P_1);
	}

	internal static bool LThBxDkXhBU1qhBucIH3()
	{
		return LxqAPokXmk8q2qDeB8qr == null;
	}

	internal static slmhRGGGdUolw80JrkF4 xH0sLIkXwaNwXaJ4cVkZ()
	{
		return LxqAPokXmk8q2qDeB8qr;
	}

	internal static void GoILWGkX8tgtIOem44Fr(object P_0)
	{
		LogManager.WriteInfo((string)P_0);
	}

	internal static object GidpBWkXABJ5dkMTq5Ht(object P_0)
	{
		return ((SoundStream)P_0).ToDataStream();
	}

	internal static long yMsrXfkXPHPdLtXFhHBi(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static void ATp6vnkXJcDhApvDdrxT(object P_0, object P_1, object P_2)
	{
		((SourceVoice)P_0).SubmitSourceBuffer((AudioBuffer)P_1, (uint[])P_2);
	}

	internal static object NjIxJDkXFf7DwsGhcAO5(int P_0)
	{
		return vpHjm6kDDRWPs2gcoFH7.bKykDIaot93(P_0);
	}

	internal static void a71QbtkX3mcmm8lYiWyF(object P_0)
	{
		((SourceVoice)P_0).Stop();
	}

	internal static void Flb58ckXpIUGffJLZ6W4(object P_0)
	{
		((SourceVoice)P_0).FlushSourceBuffers();
	}

	internal static void h72nEUkXubiQU3rB4wjf(object P_0)
	{
		((SourceVoice)P_0).Start();
	}

	internal static object nsqJt1kXzMKXmvA3r1XG(object P_0)
	{
		return ((SoundStream)P_0).DecodedPacketsInfo;
	}

	internal static void RSATR5kc0EjxNFmSFmoe()
	{
		P6syMqkNNLI24Cmarav7.kLjw4iIsCLsZtxc4lksN0j();
	}
}
