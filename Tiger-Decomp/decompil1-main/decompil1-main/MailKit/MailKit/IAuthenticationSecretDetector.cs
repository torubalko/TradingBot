using System.Collections.Generic;

namespace MailKit;

public interface IAuthenticationSecretDetector
{
	IList<AuthenticationSecret> DetectSecrets(byte[] buffer, int offset, int count);
}
