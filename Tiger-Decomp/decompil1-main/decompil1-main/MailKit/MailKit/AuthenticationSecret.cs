namespace MailKit;

public struct AuthenticationSecret
{
	public int StartIndex { get; private set; }

	public int Length { get; private set; }

	public AuthenticationSecret(int startIndex, int length)
	{
		StartIndex = startIndex;
		Length = length;
	}
}
