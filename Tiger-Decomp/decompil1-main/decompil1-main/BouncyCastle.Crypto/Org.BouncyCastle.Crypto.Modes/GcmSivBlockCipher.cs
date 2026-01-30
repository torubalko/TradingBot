using System;
using System.IO;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes.Gcm;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Modes;

public class GcmSivBlockCipher : IAeadBlockCipher, IAeadCipher
{
	private class GcmSivCache : MemoryStream
	{
		internal GcmSivCache()
		{
		}
	}

	private class GcmSivHasher
	{
		private readonly byte[] theBuffer = new byte[BUFLEN];

		private readonly byte[] theByte = new byte[1];

		private int numActive;

		private ulong numHashed;

		private readonly GcmSivBlockCipher parent;

		internal GcmSivHasher(GcmSivBlockCipher parent)
		{
			this.parent = parent;
		}

		internal ulong getBytesProcessed()
		{
			return numHashed;
		}

		internal void Reset()
		{
			numActive = 0;
			numHashed = 0uL;
		}

		internal void updateHash(byte pByte)
		{
			theByte[0] = pByte;
			updateHash(theByte, 0, 1);
		}

		internal void updateHash(byte[] pBuffer, int pOffset, int pLen)
		{
			int mySpace = BUFLEN - numActive;
			int numProcessed = 0;
			int myRemaining = pLen;
			if (numActive > 0 && pLen >= mySpace)
			{
				Array.Copy(pBuffer, pOffset, theBuffer, numActive, mySpace);
				fillReverse(theBuffer, 0, BUFLEN, parent.theReverse);
				parent.gHASH(parent.theReverse);
				numProcessed += mySpace;
				myRemaining -= mySpace;
				numActive = 0;
			}
			while (myRemaining >= BUFLEN)
			{
				fillReverse(pBuffer, pOffset + numProcessed, BUFLEN, parent.theReverse);
				parent.gHASH(parent.theReverse);
				numProcessed += mySpace;
				myRemaining -= mySpace;
			}
			if (myRemaining > 0)
			{
				Array.Copy(pBuffer, pOffset + numProcessed, theBuffer, numActive, myRemaining);
				numActive += myRemaining;
			}
			numHashed += (ulong)pLen;
		}

		internal void completeHash()
		{
			if (numActive > 0)
			{
				Arrays.Fill(parent.theReverse, 0);
				fillReverse(theBuffer, 0, numActive, parent.theReverse);
				parent.gHASH(parent.theReverse);
			}
		}
	}

	private static readonly int BUFLEN = 16;

	private static readonly int HALFBUFLEN = BUFLEN >> 1;

	private static readonly int NONCELEN = 12;

	private static readonly int MAX_DATALEN = 2147483639 - BUFLEN;

	private static readonly byte MASK = 128;

	private static readonly byte ADD = 225;

	private static readonly int INIT = 1;

	private static readonly int AEAD_COMPLETE = 2;

	private readonly IBlockCipher theCipher;

	private readonly IGcmMultiplier theMultiplier;

	internal readonly byte[] theGHash = new byte[BUFLEN];

	internal readonly byte[] theReverse = new byte[BUFLEN];

	private readonly GcmSivHasher theAEADHasher;

	private readonly GcmSivHasher theDataHasher;

	private GcmSivCache thePlain;

	private GcmSivCache theEncData;

	private bool forEncryption;

	private byte[] theInitialAEAD;

	private byte[] theNonce;

	private int theFlags;

	public virtual string AlgorithmName => theCipher.AlgorithmName + "-GCM-SIV";

	public GcmSivBlockCipher()
		: this(new AesEngine())
	{
	}

	public GcmSivBlockCipher(IBlockCipher pCipher)
		: this(pCipher, new Tables4kGcmMultiplier())
	{
	}

	public GcmSivBlockCipher(IBlockCipher pCipher, IGcmMultiplier pMultiplier)
	{
		if (pCipher.GetBlockSize() != BUFLEN)
		{
			throw new ArgumentException("Cipher required with a block size of " + BUFLEN + ".");
		}
		theCipher = pCipher;
		theMultiplier = pMultiplier;
		theAEADHasher = new GcmSivHasher(this);
		theDataHasher = new GcmSivHasher(this);
	}

	public virtual IBlockCipher GetUnderlyingCipher()
	{
		return theCipher;
	}

	public virtual int GetBlockSize()
	{
		return theCipher.GetBlockSize();
	}

	public virtual void Init(bool pEncrypt, ICipherParameters cipherParameters)
	{
		byte[] myInitialAEAD = null;
		byte[] myNonce = null;
		KeyParameter myKey = null;
		if (cipherParameters is AeadParameters)
		{
			AeadParameters obj = (AeadParameters)cipherParameters;
			myInitialAEAD = obj.GetAssociatedText();
			myNonce = obj.GetNonce();
			myKey = obj.Key;
		}
		else
		{
			if (!(cipherParameters is ParametersWithIV))
			{
				throw new ArgumentException("invalid parameters passed to GCM_SIV");
			}
			ParametersWithIV obj2 = (ParametersWithIV)cipherParameters;
			myNonce = obj2.GetIV();
			myKey = (KeyParameter)obj2.Parameters;
		}
		if (myNonce == null || myNonce.Length != NONCELEN)
		{
			throw new ArgumentException("Invalid nonce");
		}
		if (myKey == null)
		{
			throw new ArgumentException("Invalid key");
		}
		byte[] k = myKey.GetKey();
		if (k.Length != BUFLEN && k.Length != BUFLEN << 1)
		{
			throw new ArgumentException("Invalid key");
		}
		forEncryption = pEncrypt;
		theInitialAEAD = myInitialAEAD;
		theNonce = myNonce;
		deriveKeys(myKey);
		ResetStreams();
	}

	private void CheckAeadStatus(int pLen)
	{
		if ((theFlags & INIT) == 0)
		{
			throw new InvalidOperationException("Cipher is not initialised");
		}
		if ((theFlags & AEAD_COMPLETE) != 0)
		{
			throw new InvalidOperationException("AEAD data cannot be processed after ordinary data");
		}
		if ((long)theAEADHasher.getBytesProcessed() + long.MinValue > MAX_DATALEN - pLen + long.MinValue)
		{
			throw new InvalidOperationException("AEAD byte count exceeded");
		}
	}

	private void CheckStatus(int pLen)
	{
		if ((theFlags & INIT) == 0)
		{
			throw new InvalidOperationException("Cipher is not initialised");
		}
		if ((theFlags & AEAD_COMPLETE) == 0)
		{
			theAEADHasher.completeHash();
			theFlags |= AEAD_COMPLETE;
		}
		long dataLimit = MAX_DATALEN;
		long currBytes = thePlain.Length;
		if (!forEncryption)
		{
			dataLimit += BUFLEN;
			currBytes = theEncData.Length;
		}
		if (currBytes + long.MinValue > dataLimit - pLen + long.MinValue)
		{
			throw new InvalidOperationException("byte count exceeded");
		}
	}

	public virtual void ProcessAadByte(byte pByte)
	{
		CheckAeadStatus(1);
		theAEADHasher.updateHash(pByte);
	}

	public virtual void ProcessAadBytes(byte[] pData, int pOffset, int pLen)
	{
		CheckAeadStatus(pLen);
		CheckBuffer(pData, pOffset, pLen, pOutput: false);
		theAEADHasher.updateHash(pData, pOffset, pLen);
	}

	public virtual int ProcessByte(byte pByte, byte[] pOutput, int pOutOffset)
	{
		CheckStatus(1);
		if (forEncryption)
		{
			thePlain.WriteByte(pByte);
			theDataHasher.updateHash(pByte);
		}
		else
		{
			theEncData.WriteByte(pByte);
		}
		return 0;
	}

	public virtual int ProcessBytes(byte[] pData, int pOffset, int pLen, byte[] pOutput, int pOutOffset)
	{
		CheckStatus(pLen);
		CheckBuffer(pData, pOffset, pLen, pOutput: false);
		if (forEncryption)
		{
			thePlain.Write(pData, pOffset, pLen);
			theDataHasher.updateHash(pData, pOffset, pLen);
		}
		else
		{
			theEncData.Write(pData, pOffset, pLen);
		}
		return 0;
	}

	public virtual int DoFinal(byte[] pOutput, int pOffset)
	{
		CheckStatus(0);
		CheckBuffer(pOutput, pOffset, GetOutputSize(0), pOutput: true);
		if (forEncryption)
		{
			byte[] myTag = calculateTag();
			int result = BUFLEN + encryptPlain(myTag, pOutput, pOffset);
			Array.Copy(myTag, 0, pOutput, pOffset + (int)thePlain.Length, BUFLEN);
			ResetStreams();
			return result;
		}
		decryptPlain();
		int result2 = Streams.WriteBufTo(thePlain, pOutput, pOffset);
		ResetStreams();
		return result2;
	}

	public virtual byte[] GetMac()
	{
		throw new InvalidOperationException();
	}

	public virtual int GetUpdateOutputSize(int pLen)
	{
		return 0;
	}

	public virtual int GetOutputSize(int pLen)
	{
		if (forEncryption)
		{
			return (int)(pLen + thePlain.Length + BUFLEN);
		}
		int myCurr = (int)(pLen + theEncData.Length);
		if (myCurr <= BUFLEN)
		{
			return 0;
		}
		return myCurr - BUFLEN;
	}

	public virtual void Reset()
	{
		ResetStreams();
	}

	private void ResetStreams()
	{
		if (thePlain != null)
		{
			thePlain.Position = 0L;
			Streams.WriteZeroes(thePlain, thePlain.Capacity);
		}
		theAEADHasher.Reset();
		theDataHasher.Reset();
		thePlain = new GcmSivCache();
		theEncData = (forEncryption ? null : new GcmSivCache());
		theFlags &= ~AEAD_COMPLETE;
		Arrays.Fill(theGHash, 0);
		if (theInitialAEAD != null)
		{
			theAEADHasher.updateHash(theInitialAEAD, 0, theInitialAEAD.Length);
		}
	}

	private static int bufLength(byte[] pBuffer)
	{
		if (pBuffer != null)
		{
			return pBuffer.Length;
		}
		return 0;
	}

	private static void CheckBuffer(byte[] pBuffer, int pOffset, int pLen, bool pOutput)
	{
		int myBufLen = bufLength(pBuffer);
		int myLast = pOffset + pLen;
		if (pLen < 0 || pOffset < 0 || myLast < 0 || myLast > myBufLen)
		{
			throw pOutput ? new OutputLengthException("Output buffer too short.") : new DataLengthException("Input buffer too short.");
		}
	}

	private int encryptPlain(byte[] pCounter, byte[] pTarget, int pOffset)
	{
		byte[] buffer = thePlain.GetBuffer();
		int thePlainLen = (int)thePlain.Length;
		byte[] mySrc = buffer;
		byte[] myCounter = Arrays.Clone(pCounter);
		myCounter[BUFLEN - 1] |= MASK;
		byte[] myMask = new byte[BUFLEN];
		long myRemaining = thePlainLen;
		int myOff = 0;
		while (myRemaining > 0)
		{
			theCipher.ProcessBlock(myCounter, 0, myMask, 0);
			int myLen = (int)System.Math.Min(BUFLEN, myRemaining);
			xorBlock(myMask, mySrc, myOff, myLen);
			Array.Copy(myMask, 0, pTarget, pOffset + myOff, myLen);
			myRemaining -= myLen;
			myOff += myLen;
			incrementCounter(myCounter);
		}
		return thePlainLen;
	}

	private void decryptPlain()
	{
		byte[] theEncDataBuf = theEncData.GetBuffer();
		int num = (int)theEncData.Length;
		byte[] mySrc = theEncDataBuf;
		int myRemaining = num - BUFLEN;
		if (myRemaining < 0)
		{
			throw new InvalidCipherTextException("Data too short");
		}
		byte[] myExpected = Arrays.CopyOfRange(mySrc, myRemaining, myRemaining + BUFLEN);
		byte[] myCounter = Arrays.Clone(myExpected);
		myCounter[BUFLEN - 1] |= MASK;
		byte[] myMask = new byte[BUFLEN];
		int myOff = 0;
		while (myRemaining > 0)
		{
			theCipher.ProcessBlock(myCounter, 0, myMask, 0);
			int myLen = System.Math.Min(BUFLEN, myRemaining);
			xorBlock(myMask, mySrc, myOff, myLen);
			thePlain.Write(myMask, 0, myLen);
			theDataHasher.updateHash(myMask, 0, myLen);
			myRemaining -= myLen;
			myOff += myLen;
			incrementCounter(myCounter);
		}
		if (!Arrays.ConstantTimeAreEqual(calculateTag(), myExpected))
		{
			Reset();
			throw new InvalidCipherTextException("mac check failed");
		}
	}

	private byte[] calculateTag()
	{
		theDataHasher.completeHash();
		byte[] myPolyVal = completePolyVal();
		byte[] myResult = new byte[BUFLEN];
		for (int i = 0; i < NONCELEN; i++)
		{
			myPolyVal[i] ^= theNonce[i];
		}
		myPolyVal[BUFLEN - 1] &= (byte)(MASK - 1);
		theCipher.ProcessBlock(myPolyVal, 0, myResult, 0);
		return myResult;
	}

	private byte[] completePolyVal()
	{
		byte[] myResult = new byte[BUFLEN];
		gHashLengths();
		fillReverse(theGHash, 0, BUFLEN, myResult);
		return myResult;
	}

	private void gHashLengths()
	{
		byte[] myIn = new byte[BUFLEN];
		Pack.UInt64_To_BE(8 * theDataHasher.getBytesProcessed(), myIn, 0);
		Pack.UInt64_To_BE(8 * theAEADHasher.getBytesProcessed(), myIn, 8);
		gHASH(myIn);
	}

	private void gHASH(byte[] pNext)
	{
		xorBlock(theGHash, pNext);
		theMultiplier.MultiplyH(theGHash);
	}

	private static void fillReverse(byte[] pInput, int pOffset, int pLength, byte[] pOutput)
	{
		int i = 0;
		int j = BUFLEN - 1;
		while (i < pLength)
		{
			pOutput[j] = pInput[pOffset + i];
			i++;
			j--;
		}
	}

	private static void xorBlock(byte[] pLeft, byte[] pRight)
	{
		for (int i = 0; i < BUFLEN; i++)
		{
			pLeft[i] ^= pRight[i];
		}
	}

	private static void xorBlock(byte[] pLeft, byte[] pRight, int pOffset, int pLength)
	{
		for (int i = 0; i < pLength; i++)
		{
			pLeft[i] ^= pRight[i + pOffset];
		}
	}

	private static void incrementCounter(byte[] pCounter)
	{
		for (int i = 0; i < 4; i++)
		{
			if (++pCounter[i] != 0)
			{
				break;
			}
		}
	}

	private static void mulX(byte[] pValue)
	{
		byte myMask = 0;
		for (int i = 0; i < BUFLEN; i++)
		{
			byte myValue = pValue[i];
			pValue[i] = (byte)(((myValue >> 1) & ~MASK) | myMask);
			myMask = (byte)(((myValue & 1) != 0) ? MASK : 0);
		}
		if (myMask != 0)
		{
			pValue[0] ^= ADD;
		}
	}

	private void deriveKeys(KeyParameter pKey)
	{
		byte[] myIn = new byte[BUFLEN];
		byte[] myOut = new byte[BUFLEN];
		byte[] myResult = new byte[BUFLEN];
		byte[] myEncKey = new byte[pKey.GetKey().Length];
		Array.Copy(theNonce, 0, myIn, BUFLEN - NONCELEN, NONCELEN);
		theCipher.Init(forEncryption: true, pKey);
		int myOff = 0;
		theCipher.ProcessBlock(myIn, 0, myOut, 0);
		Array.Copy(myOut, 0, myResult, myOff, HALFBUFLEN);
		myIn[0]++;
		myOff += HALFBUFLEN;
		theCipher.ProcessBlock(myIn, 0, myOut, 0);
		Array.Copy(myOut, 0, myResult, myOff, HALFBUFLEN);
		myIn[0]++;
		myOff = 0;
		theCipher.ProcessBlock(myIn, 0, myOut, 0);
		Array.Copy(myOut, 0, myEncKey, myOff, HALFBUFLEN);
		myIn[0]++;
		myOff += HALFBUFLEN;
		theCipher.ProcessBlock(myIn, 0, myOut, 0);
		Array.Copy(myOut, 0, myEncKey, myOff, HALFBUFLEN);
		if (myEncKey.Length == BUFLEN << 1)
		{
			myIn[0]++;
			myOff += HALFBUFLEN;
			theCipher.ProcessBlock(myIn, 0, myOut, 0);
			Array.Copy(myOut, 0, myEncKey, myOff, HALFBUFLEN);
			myIn[0]++;
			myOff += HALFBUFLEN;
			theCipher.ProcessBlock(myIn, 0, myOut, 0);
			Array.Copy(myOut, 0, myEncKey, myOff, HALFBUFLEN);
		}
		theCipher.Init(forEncryption: true, new KeyParameter(myEncKey));
		fillReverse(myResult, 0, BUFLEN, myOut);
		mulX(myOut);
		theMultiplier.Init(myOut);
		theFlags |= INIT;
	}
}
