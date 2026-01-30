using System.Threading;

namespace MimeKit.IO;

public interface ICancellableStream
{
	int Read(byte[] buffer, int offset, int count, CancellationToken cancellationToken);

	void Write(byte[] buffer, int offset, int count, CancellationToken cancellationToken);

	void Flush(CancellationToken cancellationToken);
}
