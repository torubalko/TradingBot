namespace MailKit.Net.Smtp;

public class SmtpResponse
{
	public SmtpStatusCode StatusCode { get; private set; }

	public string Response { get; private set; }

	public SmtpResponse(SmtpStatusCode code, string response)
	{
		StatusCode = code;
		Response = response;
	}
}
