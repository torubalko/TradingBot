namespace Org.BouncyCastle.Bcpg.Sig;

public class PreferredAlgorithms : SignatureSubpacket
{
	private static byte[] IntToByteArray(int[] v)
	{
		byte[] data = new byte[v.Length];
		for (int i = 0; i != v.Length; i++)
		{
			data[i] = (byte)v[i];
		}
		return data;
	}

	public PreferredAlgorithms(SignatureSubpacketTag type, bool critical, bool isLongLength, byte[] data)
		: base(type, critical, isLongLength, data)
	{
	}

	public PreferredAlgorithms(SignatureSubpacketTag type, bool critical, int[] preferences)
		: base(type, critical, isLongLength: false, IntToByteArray(preferences))
	{
	}

	public int[] GetPreferences()
	{
		int[] v = new int[data.Length];
		for (int i = 0; i != v.Length; i++)
		{
			v[i] = data[i] & 0xFF;
		}
		return v;
	}
}
