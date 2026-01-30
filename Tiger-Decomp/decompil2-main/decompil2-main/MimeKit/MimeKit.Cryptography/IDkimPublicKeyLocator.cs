using System.Threading;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;

namespace MimeKit.Cryptography;

public interface IDkimPublicKeyLocator
{
	AsymmetricKeyParameter LocatePublicKey(string methods, string domain, string selector, CancellationToken cancellationToken = default(CancellationToken));

	Task<AsymmetricKeyParameter> LocatePublicKeyAsync(string methods, string domain, string selector, CancellationToken cancellationToken = default(CancellationToken));
}
