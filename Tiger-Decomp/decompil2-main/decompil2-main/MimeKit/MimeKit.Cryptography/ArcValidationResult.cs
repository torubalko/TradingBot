namespace MimeKit.Cryptography;

public class ArcValidationResult
{
	public ArcHeaderValidationResult MessageSignature { get; internal set; }

	public ArcHeaderValidationResult[] Seals { get; internal set; }

	public ArcSignatureValidationResult Chain { get; internal set; }

	public ArcValidationErrors ChainErrors { get; internal set; }

	internal ArcValidationResult()
	{
		Chain = ArcSignatureValidationResult.None;
	}

	public ArcValidationResult(ArcSignatureValidationResult chain, ArcHeaderValidationResult messageSignature, ArcHeaderValidationResult[] seals)
	{
		MessageSignature = messageSignature;
		Seals = seals;
		Chain = chain;
	}
}
