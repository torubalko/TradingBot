namespace Org.BouncyCastle.Crypto.Engines;

public class VmpcKsa3Engine : VmpcEngine
{
	public override string AlgorithmName => "VMPC-KSA3";

	protected override void InitKey(byte[] keyBytes, byte[] ivBytes)
	{
		s = 0;
		P = new byte[256];
		for (int i = 0; i < 256; i++)
		{
			P[i] = (byte)i;
		}
		for (int m = 0; m < 768; m++)
		{
			s = P[(s + P[m & 0xFF] + keyBytes[m % keyBytes.Length]) & 0xFF];
			byte temp = P[m & 0xFF];
			P[m & 0xFF] = P[s & 0xFF];
			P[s & 0xFF] = temp;
		}
		for (int j = 0; j < 768; j++)
		{
			s = P[(s + P[j & 0xFF] + ivBytes[j % ivBytes.Length]) & 0xFF];
			byte temp2 = P[j & 0xFF];
			P[j & 0xFF] = P[s & 0xFF];
			P[s & 0xFF] = temp2;
		}
		for (int k = 0; k < 768; k++)
		{
			s = P[(s + P[k & 0xFF] + keyBytes[k % keyBytes.Length]) & 0xFF];
			byte temp3 = P[k & 0xFF];
			P[k & 0xFF] = P[s & 0xFF];
			P[s & 0xFF] = temp3;
		}
		n = 0;
	}
}
