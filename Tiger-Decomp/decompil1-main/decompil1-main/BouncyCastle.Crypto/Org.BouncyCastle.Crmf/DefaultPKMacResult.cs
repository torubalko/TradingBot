using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crmf;

internal class DefaultPKMacResult : IBlockResult
{
	private readonly IMac mac;

	public DefaultPKMacResult(IMac mac)
	{
		this.mac = mac;
	}

	public byte[] Collect()
	{
		byte[] res = new byte[mac.GetMacSize()];
		mac.DoFinal(res, 0);
		return res;
	}

	public int Collect(byte[] sig, int sigOff)
	{
		byte[] array = Collect();
		array.CopyTo(sig, sigOff);
		return array.Length;
	}
}
