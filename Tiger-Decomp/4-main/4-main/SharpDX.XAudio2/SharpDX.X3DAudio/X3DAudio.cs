using System;
using SharpDX.Multimedia;

namespace SharpDX.X3DAudio;

public class X3DAudio
{
	private delegate void X3DAudioCalculateDelegate(ref X3DAudioHandle instance, Listener listenerRef, Emitter emitterRef, CalculateFlags flags, IntPtr dSPSettingsRef);

	private X3DAudioHandle handle;

	private readonly X3DAudioVersion version;

	private readonly X3DAudioCalculateDelegate calculateDelegate;

	public const float SpeedOfSound = 343.5f;

	public X3DAudioVersion Version => version;

	public X3DAudio(Speakers speakers)
		: this(speakers, X3DAudioVersion.Default)
	{
	}

	public X3DAudio(Speakers speakers, X3DAudioVersion requestVersion)
		: this(speakers, 343.5f, requestVersion)
	{
	}

	public X3DAudio(Speakers speakers, float speedOfSound, X3DAudioVersion requestVersion = X3DAudioVersion.Default)
	{
		X3DAudioVersion[] array = ((requestVersion != X3DAudioVersion.Default) ? new X3DAudioVersion[1] { requestVersion } : new X3DAudioVersion[3]
		{
			X3DAudioVersion.Version29,
			X3DAudioVersion.Version28,
			X3DAudioVersion.Version17
		});
		X3DAudioVersion[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			switch (array2[i])
			{
			case X3DAudioVersion.Version17:
				try
				{
					X3DAudio17.X3DAudioInitialize(speakers, speedOfSound, out handle);
					version = X3DAudioVersion.Version17;
					calculateDelegate = X3DAudio17.X3DAudioCalculate;
				}
				catch (DllNotFoundException)
				{
				}
				break;
			case X3DAudioVersion.Version28:
				try
				{
					X3DAudio28.X3DAudioInitialize(speakers, speedOfSound, out handle);
					version = X3DAudioVersion.Version28;
					calculateDelegate = X3DAudio28.X3DAudioCalculate;
				}
				catch (DllNotFoundException)
				{
				}
				break;
			}
			if (version != X3DAudioVersion.Default)
			{
				break;
			}
		}
		if (version == X3DAudioVersion.Default)
		{
			throw new DllNotFoundException(string.Format("Unable to find X3DAudio dlls for the following requested version [{0}]", string.Join(",", array)));
		}
	}

	public DspSettings Calculate(Listener listener, Emitter emitter, CalculateFlags flags, int sourceChannelCount, int destinationChannelCount)
	{
		DspSettings dspSettings = new DspSettings(sourceChannelCount, destinationChannelCount);
		Calculate(listener, emitter, flags, dspSettings);
		return dspSettings;
	}

	public unsafe void Calculate(Listener listener, Emitter emitter, CalculateFlags flags, DspSettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		DspSettings.__Native @ref = default(DspSettings.__Native);
		@ref.SrcChannelCount = settings.SourceChannelCount;
		@ref.DstChannelCount = settings.DestinationChannelCount;
		fixed (float* matrixCoefficients = settings.MatrixCoefficients)
		{
			void* ptr = matrixCoefficients;
			fixed (float* delayTimes = settings.DelayTimes)
			{
				void* ptr2 = delayTimes;
				@ref.MatrixCoefficientsPointer = (IntPtr)ptr;
				@ref.DelayTimesPointer = (IntPtr)ptr2;
				calculateDelegate(ref handle, listener, emitter, flags, new IntPtr(&@ref));
			}
		}
		settings.__MarshalFrom(ref @ref);
	}
}
