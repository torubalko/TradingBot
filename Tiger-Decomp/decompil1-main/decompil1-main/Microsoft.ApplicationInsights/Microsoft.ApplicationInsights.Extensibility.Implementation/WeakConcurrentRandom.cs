using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

internal class WeakConcurrentRandom
{
	private static WeakConcurrentRandom random;

	private int index;

	private int segmentCount;

	private int segmentSize;

	private int bitsToStoreRandomIndexWithinSegment;

	private int segmentIndexMask;

	private int randomIndexWithinSegmentMask;

	private int randomArrayIndexMask;

	private IRandomNumberBatchGenerator[] randomGemerators;

	private ulong[] randomNumbers;

	public static WeakConcurrentRandom Instance
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		get
		{
			if (random != null)
			{
				return random;
			}
			Interlocked.CompareExchange(ref random, new WeakConcurrentRandom(), null);
			return random;
		}
	}

	public WeakConcurrentRandom()
	{
		Initialize();
	}

	public void Initialize()
	{
		Initialize((ulong seed) => new XorshiftRandomBatchGenerator(seed), 3, 10);
	}

	public void Initialize(Func<ulong, IRandomNumberBatchGenerator> randomGeneratorFactory, int segmentIndexBits, int segmentBits)
	{
		int num = segmentIndexBits;
		if (segmentIndexBits < 1 || segmentIndexBits > 4)
		{
			num = 3;
		}
		int num2 = segmentBits;
		if (segmentBits < 7 || segmentBits > 15)
		{
			num2 = 9;
		}
		bitsToStoreRandomIndexWithinSegment = num2;
		segmentCount = 1 << num;
		segmentSize = 1 << num2;
		segmentIndexMask = segmentCount - 1 << bitsToStoreRandomIndexWithinSegment;
		randomIndexWithinSegmentMask = segmentSize - 1;
		randomArrayIndexMask = segmentIndexMask | randomIndexWithinSegmentMask;
		int num3 = segmentCount * segmentSize;
		randomGemerators = new IRandomNumberBatchGenerator[segmentCount];
		XorshiftRandomBatchGenerator xorshiftRandomBatchGenerator = new XorshiftRandomBatchGenerator((ulong)Environment.TickCount);
		ulong[] array = new ulong[segmentCount];
		xorshiftRandomBatchGenerator.NextBatch(array, 0, segmentCount);
		for (int i = 0; i < segmentCount; i++)
		{
			Func<ulong, IRandomNumberBatchGenerator> func = (ulong seed) => new XorshiftRandomBatchGenerator(seed);
			IRandomNumberBatchGenerator randomNumberBatchGenerator = ((randomGeneratorFactory == null) ? func(array[i]) : (randomGeneratorFactory(array[i]) ?? func(array[i])));
			randomGemerators[i] = randomNumberBatchGenerator;
		}
		randomNumbers = new ulong[num3];
		xorshiftRandomBatchGenerator.NextBatch(randomNumbers, 0, num3);
	}

	public ulong Next()
	{
		int num = Interlocked.Increment(ref index);
		if ((num & randomIndexWithinSegmentMask) == 0)
		{
			RegenerateSegment(num);
		}
		return randomNumbers[num & randomArrayIndexMask];
	}

	private void RegenerateSegment(int newIndex)
	{
		int num = (((newIndex & segmentIndexMask) != 0) ? (((newIndex & segmentIndexMask) >> bitsToStoreRandomIndexWithinSegment) - 1) : (segmentCount - 1));
		randomGemerators[num].NextBatch(randomNumbers, num * segmentSize, segmentSize);
	}
}
