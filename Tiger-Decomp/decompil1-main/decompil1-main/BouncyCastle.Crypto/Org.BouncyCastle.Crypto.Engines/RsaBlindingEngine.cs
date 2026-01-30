using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class RsaBlindingEngine : IAsymmetricBlockCipher
{
	private readonly IRsa core;

	private RsaKeyParameters key;

	private BigInteger blindingFactor;

	private bool forEncryption;

	public virtual string AlgorithmName => "RSA";

	public RsaBlindingEngine()
		: this(new RsaCoreEngine())
	{
	}

	public RsaBlindingEngine(IRsa rsa)
	{
		core = rsa;
	}

	public virtual void Init(bool forEncryption, ICipherParameters param)
	{
		RsaBlindingParameters p = ((!(param is ParametersWithRandom)) ? ((RsaBlindingParameters)param) : ((RsaBlindingParameters)((ParametersWithRandom)param).Parameters));
		core.Init(forEncryption, p.PublicKey);
		this.forEncryption = forEncryption;
		key = p.PublicKey;
		blindingFactor = p.BlindingFactor;
	}

	public virtual int GetInputBlockSize()
	{
		return core.GetInputBlockSize();
	}

	public virtual int GetOutputBlockSize()
	{
		return core.GetOutputBlockSize();
	}

	public virtual byte[] ProcessBlock(byte[] inBuf, int inOff, int inLen)
	{
		BigInteger msg = core.ConvertInput(inBuf, inOff, inLen);
		msg = ((!forEncryption) ? UnblindMessage(msg) : BlindMessage(msg));
		return core.ConvertOutput(msg);
	}

	private BigInteger BlindMessage(BigInteger msg)
	{
		BigInteger blindMsg = blindingFactor;
		blindMsg = msg.Multiply(blindMsg.ModPow(key.Exponent, key.Modulus));
		return blindMsg.Mod(key.Modulus);
	}

	private BigInteger UnblindMessage(BigInteger blindedMsg)
	{
		BigInteger m = key.Modulus;
		BigInteger blindFactorInverse = BigIntegers.ModOddInverse(m, blindingFactor);
		return blindedMsg.Multiply(blindFactorInverse).Mod(m);
	}
}
