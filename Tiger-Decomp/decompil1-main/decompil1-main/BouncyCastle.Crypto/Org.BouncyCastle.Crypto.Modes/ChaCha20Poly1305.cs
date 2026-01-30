using System;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes;

public class ChaCha20Poly1305 : IAeadCipher
{
	private enum State
	{
		Uninitialized,
		EncInit,
		EncAad,
		EncData,
		EncFinal,
		DecInit,
		DecAad,
		DecData,
		DecFinal
	}

	private const int BufSize = 64;

	private const int KeySize = 32;

	private const int NonceSize = 12;

	private const int MacSize = 16;

	private static readonly byte[] Zeroes = new byte[15];

	private const ulong AadLimit = ulong.MaxValue;

	private const ulong DataLimit = 274877906880uL;

	private readonly ChaCha7539Engine mChacha20;

	private readonly IMac mPoly1305;

	private readonly byte[] mKey = new byte[32];

	private readonly byte[] mNonce = new byte[12];

	private readonly byte[] mBuf = new byte[80];

	private readonly byte[] mMac = new byte[16];

	private byte[] mInitialAad;

	private ulong mAadCount;

	private ulong mDataCount;

	private State mState;

	private int mBufPos;

	public virtual string AlgorithmName => "ChaCha20Poly1305";

	public ChaCha20Poly1305()
		: this(new Poly1305())
	{
	}

	public ChaCha20Poly1305(IMac poly1305)
	{
		if (poly1305 == null)
		{
			throw new ArgumentNullException("poly1305");
		}
		if (16 != poly1305.GetMacSize())
		{
			throw new ArgumentException("must be a 128-bit MAC", "poly1305");
		}
		mChacha20 = new ChaCha7539Engine();
		mPoly1305 = poly1305;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		KeyParameter initKeyParam;
		byte[] initNonce;
		ICipherParameters chacha20Params;
		if (parameters is AeadParameters)
		{
			AeadParameters aeadParams = (AeadParameters)parameters;
			int macSizeBits = aeadParams.MacSize;
			if (128 != macSizeBits)
			{
				throw new ArgumentException("Invalid value for MAC size: " + macSizeBits);
			}
			initKeyParam = aeadParams.Key;
			initNonce = aeadParams.GetNonce();
			chacha20Params = new ParametersWithIV(initKeyParam, initNonce);
			mInitialAad = aeadParams.GetAssociatedText();
		}
		else
		{
			if (!(parameters is ParametersWithIV))
			{
				throw new ArgumentException("invalid parameters passed to ChaCha20Poly1305", "parameters");
			}
			ParametersWithIV obj = (ParametersWithIV)parameters;
			initKeyParam = (KeyParameter)obj.Parameters;
			initNonce = obj.GetIV();
			chacha20Params = obj;
			mInitialAad = null;
		}
		if (initKeyParam == null)
		{
			if (mState == State.Uninitialized)
			{
				throw new ArgumentException("Key must be specified in initial init");
			}
		}
		else if (32 != initKeyParam.GetKey().Length)
		{
			throw new ArgumentException("Key must be 256 bits");
		}
		if (initNonce == null || 12 != initNonce.Length)
		{
			throw new ArgumentException("Nonce must be 96 bits");
		}
		if (mState != State.Uninitialized && forEncryption && Arrays.AreEqual(mNonce, initNonce) && (initKeyParam == null || Arrays.AreEqual(mKey, initKeyParam.GetKey())))
		{
			throw new ArgumentException("cannot reuse nonce for ChaCha20Poly1305 encryption");
		}
		if (initKeyParam != null)
		{
			Array.Copy(initKeyParam.GetKey(), 0, mKey, 0, 32);
		}
		Array.Copy(initNonce, 0, mNonce, 0, 12);
		mChacha20.Init(forEncryption: true, chacha20Params);
		mState = (forEncryption ? State.EncInit : State.DecInit);
		Reset(clearMac: true, resetCipher: false);
	}

	public virtual int GetOutputSize(int len)
	{
		int total = System.Math.Max(0, len) + mBufPos;
		switch (mState)
		{
		case State.DecInit:
		case State.DecAad:
		case State.DecData:
			return System.Math.Max(0, total - 16);
		case State.EncInit:
		case State.EncAad:
		case State.EncData:
			return total + 16;
		default:
			throw new InvalidOperationException();
		}
	}

	public virtual int GetUpdateOutputSize(int len)
	{
		int total = System.Math.Max(0, len) + mBufPos;
		switch (mState)
		{
		case State.DecInit:
		case State.DecAad:
		case State.DecData:
			total = System.Math.Max(0, total - 16);
			break;
		default:
			throw new InvalidOperationException();
		case State.EncInit:
		case State.EncAad:
		case State.EncData:
			break;
		}
		return total - total % 64;
	}

	public virtual void ProcessAadByte(byte input)
	{
		CheckAad();
		mAadCount = IncrementCount(mAadCount, 1u, ulong.MaxValue);
		mPoly1305.Update(input);
	}

	public virtual void ProcessAadBytes(byte[] inBytes, int inOff, int len)
	{
		if (inBytes == null)
		{
			throw new ArgumentNullException("inBytes");
		}
		if (inOff < 0)
		{
			throw new ArgumentException("cannot be negative", "inOff");
		}
		if (len < 0)
		{
			throw new ArgumentException("cannot be negative", "len");
		}
		Check.DataLength(inBytes, inOff, len, "input buffer too short");
		CheckAad();
		if (len > 0)
		{
			mAadCount = IncrementCount(mAadCount, (uint)len, ulong.MaxValue);
			mPoly1305.BlockUpdate(inBytes, inOff, len);
		}
	}

	public virtual int ProcessByte(byte input, byte[] outBytes, int outOff)
	{
		CheckData();
		switch (mState)
		{
		case State.DecData:
			mBuf[mBufPos] = input;
			if (++mBufPos == mBuf.Length)
			{
				mPoly1305.BlockUpdate(mBuf, 0, 64);
				ProcessData(mBuf, 0, 64, outBytes, outOff);
				Array.Copy(mBuf, 64, mBuf, 0, 16);
				mBufPos = 16;
				return 64;
			}
			return 0;
		case State.EncData:
			mBuf[mBufPos] = input;
			if (++mBufPos == 64)
			{
				ProcessData(mBuf, 0, 64, outBytes, outOff);
				mPoly1305.BlockUpdate(outBytes, outOff, 64);
				mBufPos = 0;
				return 64;
			}
			return 0;
		default:
			throw new InvalidOperationException();
		}
	}

	public virtual int ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff)
	{
		if (inBytes == null)
		{
			throw new ArgumentNullException("inBytes");
		}
		if (inOff < 0)
		{
			throw new ArgumentException("cannot be negative", "inOff");
		}
		if (len < 0)
		{
			throw new ArgumentException("cannot be negative", "len");
		}
		Check.DataLength(inBytes, inOff, len, "input buffer too short");
		if (outOff < 0)
		{
			throw new ArgumentException("cannot be negative", "outOff");
		}
		CheckData();
		int resultLen = 0;
		switch (mState)
		{
		case State.DecData:
		{
			for (int i = 0; i < len; i++)
			{
				mBuf[mBufPos] = inBytes[inOff + i];
				if (++mBufPos == mBuf.Length)
				{
					mPoly1305.BlockUpdate(mBuf, 0, 64);
					ProcessData(mBuf, 0, 64, outBytes, outOff + resultLen);
					Array.Copy(mBuf, 64, mBuf, 0, 16);
					mBufPos = 16;
					resultLen += 64;
				}
			}
			break;
		}
		case State.EncData:
			if (mBufPos != 0)
			{
				while (len > 0)
				{
					len--;
					mBuf[mBufPos] = inBytes[inOff++];
					if (++mBufPos == 64)
					{
						ProcessData(mBuf, 0, 64, outBytes, outOff);
						mPoly1305.BlockUpdate(outBytes, outOff, 64);
						mBufPos = 0;
						resultLen = 64;
						break;
					}
				}
			}
			while (len >= 64)
			{
				ProcessData(inBytes, inOff, 64, outBytes, outOff + resultLen);
				mPoly1305.BlockUpdate(outBytes, outOff + resultLen, 64);
				inOff += 64;
				len -= 64;
				resultLen += 64;
			}
			if (len > 0)
			{
				Array.Copy(inBytes, inOff, mBuf, 0, len);
				mBufPos = len;
			}
			break;
		default:
			throw new InvalidOperationException();
		}
		return resultLen;
	}

	public virtual int DoFinal(byte[] outBytes, int outOff)
	{
		if (outBytes == null)
		{
			throw new ArgumentNullException("outBytes");
		}
		if (outOff < 0)
		{
			throw new ArgumentException("cannot be negative", "outOff");
		}
		CheckData();
		Array.Clear(mMac, 0, 16);
		int resultLen = 0;
		switch (mState)
		{
		case State.DecData:
			if (mBufPos < 16)
			{
				throw new InvalidCipherTextException("data too short");
			}
			resultLen = mBufPos - 16;
			Check.OutputLength(outBytes, outOff, resultLen, "output buffer too short");
			if (resultLen > 0)
			{
				mPoly1305.BlockUpdate(mBuf, 0, resultLen);
				ProcessData(mBuf, 0, resultLen, outBytes, outOff);
			}
			FinishData(State.DecFinal);
			if (!Arrays.ConstantTimeAreEqual(16, mMac, 0, mBuf, resultLen))
			{
				throw new InvalidCipherTextException("mac check in ChaCha20Poly1305 failed");
			}
			break;
		case State.EncData:
			resultLen = mBufPos + 16;
			Check.OutputLength(outBytes, outOff, resultLen, "output buffer too short");
			if (mBufPos > 0)
			{
				ProcessData(mBuf, 0, mBufPos, outBytes, outOff);
				mPoly1305.BlockUpdate(outBytes, outOff, mBufPos);
			}
			FinishData(State.EncFinal);
			Array.Copy(mMac, 0, outBytes, outOff + mBufPos, 16);
			break;
		default:
			throw new InvalidOperationException();
		}
		Reset(clearMac: false, resetCipher: true);
		return resultLen;
	}

	public virtual byte[] GetMac()
	{
		return Arrays.Clone(mMac);
	}

	public virtual void Reset()
	{
		Reset(clearMac: true, resetCipher: true);
	}

	private void CheckAad()
	{
		switch (mState)
		{
		case State.DecInit:
			mState = State.DecAad;
			break;
		case State.EncInit:
			mState = State.EncAad;
			break;
		case State.EncFinal:
			throw new InvalidOperationException("ChaCha20Poly1305 cannot be reused for encryption");
		default:
			throw new InvalidOperationException();
		case State.EncAad:
		case State.DecAad:
			break;
		}
	}

	private void CheckData()
	{
		switch (mState)
		{
		case State.DecInit:
		case State.DecAad:
			FinishAad(State.DecData);
			break;
		case State.EncInit:
		case State.EncAad:
			FinishAad(State.EncData);
			break;
		case State.EncFinal:
			throw new InvalidOperationException("ChaCha20Poly1305 cannot be reused for encryption");
		default:
			throw new InvalidOperationException();
		case State.EncData:
		case State.DecData:
			break;
		}
	}

	private void FinishAad(State nextState)
	{
		PadMac(mAadCount);
		mState = nextState;
	}

	private void FinishData(State nextState)
	{
		PadMac(mDataCount);
		byte[] lengths = new byte[16];
		Pack.UInt64_To_LE(mAadCount, lengths, 0);
		Pack.UInt64_To_LE(mDataCount, lengths, 8);
		mPoly1305.BlockUpdate(lengths, 0, 16);
		mPoly1305.DoFinal(mMac, 0);
		mState = nextState;
	}

	private ulong IncrementCount(ulong count, uint increment, ulong limit)
	{
		if (count > limit - increment)
		{
			throw new InvalidOperationException("Limit exceeded");
		}
		return count + increment;
	}

	private void InitMac()
	{
		byte[] firstBlock = new byte[64];
		try
		{
			mChacha20.ProcessBytes(firstBlock, 0, 64, firstBlock, 0);
			mPoly1305.Init(new KeyParameter(firstBlock, 0, 32));
		}
		finally
		{
			Array.Clear(firstBlock, 0, 64);
		}
	}

	private void PadMac(ulong count)
	{
		int partial = (int)count & 0xF;
		if (partial != 0)
		{
			mPoly1305.BlockUpdate(Zeroes, 0, 16 - partial);
		}
	}

	private void ProcessData(byte[] inBytes, int inOff, int inLen, byte[] outBytes, int outOff)
	{
		Check.OutputLength(outBytes, outOff, inLen, "output buffer too short");
		mChacha20.ProcessBytes(inBytes, inOff, inLen, outBytes, outOff);
		mDataCount = IncrementCount(mDataCount, (uint)inLen, 274877906880uL);
	}

	private void Reset(bool clearMac, bool resetCipher)
	{
		Array.Clear(mBuf, 0, mBuf.Length);
		if (clearMac)
		{
			Array.Clear(mMac, 0, mMac.Length);
		}
		mAadCount = 0uL;
		mDataCount = 0uL;
		mBufPos = 0;
		switch (mState)
		{
		case State.DecAad:
		case State.DecData:
		case State.DecFinal:
			mState = State.DecInit;
			break;
		case State.EncAad:
		case State.EncData:
		case State.EncFinal:
			mState = State.EncFinal;
			return;
		default:
			throw new InvalidOperationException();
		case State.EncInit:
		case State.DecInit:
			break;
		}
		if (resetCipher)
		{
			mChacha20.Reset();
		}
		InitMac();
		if (mInitialAad != null)
		{
			ProcessAadBytes(mInitialAad, 0, mInitialAad.Length);
		}
	}
}
