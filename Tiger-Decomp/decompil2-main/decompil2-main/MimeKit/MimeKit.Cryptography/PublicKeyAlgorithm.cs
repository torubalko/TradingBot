namespace MimeKit.Cryptography;

public enum PublicKeyAlgorithm
{
	None = 0,
	RsaGeneral = 1,
	RsaEncrypt = 2,
	RsaSign = 3,
	ElGamalEncrypt = 16,
	Dsa = 17,
	EllipticCurve = 18,
	EllipticCurveDsa = 19,
	ElGamalGeneral = 20,
	DiffieHellman = 21,
	EdwardsCurveDsa = 22
}
