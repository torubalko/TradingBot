using System;

namespace Org.BouncyCastle.Tls;

public class TlsFatalAlert : TlsException
{
	protected readonly short m_alertDescription;

	public virtual short AlertDescription => m_alertDescription;

	private static string GetMessage(short alertDescription, string detailMessage)
	{
		string msg = Org.BouncyCastle.Tls.AlertDescription.GetText(alertDescription);
		if (detailMessage != null)
		{
			msg = msg + "; " + detailMessage;
		}
		return msg;
	}

	public TlsFatalAlert(short alertDescription)
		: this(alertDescription, (string)null)
	{
	}

	public TlsFatalAlert(short alertDescription, string detailMessage)
		: this(alertDescription, detailMessage, null)
	{
	}

	public TlsFatalAlert(short alertDescription, Exception alertCause)
		: this(alertDescription, null, alertCause)
	{
	}

	public TlsFatalAlert(short alertDescription, string detailMessage, Exception alertCause)
		: base(GetMessage(alertDescription, detailMessage), alertCause)
	{
		m_alertDescription = alertDescription;
	}
}
