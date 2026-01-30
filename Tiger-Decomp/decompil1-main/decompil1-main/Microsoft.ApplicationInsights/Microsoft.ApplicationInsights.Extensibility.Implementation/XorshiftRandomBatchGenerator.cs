using System.Diagnostics.CodeAnalysis;

namespace Microsoft.ApplicationInsights.Extensibility.Implementation;

[SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Xorshift is a well-known algorithm name")]
internal class XorshiftRandomBatchGenerator : IRandomNumberBatchGenerator
{
	private const ulong Y = 4477743899113974427uL;

	private const ulong Z = 2994213561913849757uL;

	private const ulong W = 9123831478480964153uL;

	private ulong lastX;

	private ulong lastY;

	private ulong lastZ;

	private ulong lastW;

	public XorshiftRandomBatchGenerator(ulong seed)
	{
		lastX = seed * 5073061188973594169L + seed * 8760132611124384359L + seed * 8900702462021224483L + seed * 6807056130438027397L;
		lastY = 4477743899113974427uL;
		lastZ = 2994213561913849757uL;
		lastW = 9123831478480964153uL;
	}

	public void NextBatch(ulong[] buffer, int index, int count)
	{
		ulong num = lastX;
		ulong num2 = lastY;
		ulong num3 = lastZ;
		ulong num4 = lastW;
		for (int i = 0; i < count; i++)
		{
			ulong num5 = num ^ (num << 11);
			num = num2;
			num2 = num3;
			num3 = num4;
			num4 = (buffer[index + i] = num4 ^ (num4 >> 19) ^ (num5 ^ (num5 >> 8)));
		}
		lastX = num;
		lastY = num2;
		lastZ = num3;
		lastW = num4;
	}
}
