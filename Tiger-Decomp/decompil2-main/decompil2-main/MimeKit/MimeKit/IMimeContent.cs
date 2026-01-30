using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MimeKit;

public interface IMimeContent
{
	ContentEncoding Encoding { get; }

	NewLineFormat? NewLineFormat { get; }

	Stream Stream { get; }

	Stream Open();

	void DecodeTo(Stream stream, CancellationToken cancellationToken = default(CancellationToken));

	Task DecodeToAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken));

	void WriteTo(Stream stream, CancellationToken cancellationToken = default(CancellationToken));

	Task WriteToAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken));
}
