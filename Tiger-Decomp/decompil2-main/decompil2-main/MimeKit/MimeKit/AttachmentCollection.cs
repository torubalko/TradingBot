using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;
using MimeKit.IO.Filters;

namespace MimeKit;

public class AttachmentCollection : IList<MimeEntity>, ICollection<MimeEntity>, IEnumerable<MimeEntity>, IEnumerable
{
	private const int BufferLength = 4096;

	private readonly List<MimeEntity> attachments;

	private readonly bool linked;

	public int Count => attachments.Count;

	public bool IsReadOnly => false;

	public MimeEntity this[int index]
	{
		get
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return attachments[index];
		}
		set
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			attachments[index] = value;
		}
	}

	public AttachmentCollection(bool linkedResources)
	{
		attachments = new List<MimeEntity>();
		linked = linkedResources;
	}

	public AttachmentCollection()
		: this(linkedResources: false)
	{
	}

	private static void LoadContent(MimePart attachment, Stream stream)
	{
		MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		if (attachment.ContentType.IsMimeType("text", "*"))
		{
			byte[] array = ArrayPool<byte>.Shared.Rent(4096);
			BestEncodingFilter bestEncodingFilter = new BestEncodingFilter();
			try
			{
				int num;
				int outputIndex;
				int outputLength;
				while ((num = stream.Read(array, 0, 4096)) > 0)
				{
					bestEncodingFilter.Filter(array, 0, num, out outputIndex, out outputLength);
					memoryBlockStream.Write(array, 0, num);
				}
				bestEncodingFilter.Flush(array, 0, 0, out outputIndex, out outputLength);
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(array);
			}
			attachment.ContentTransferEncoding = bestEncodingFilter.GetBestEncoding(EncodingConstraint.SevenBit);
		}
		else
		{
			attachment.ContentTransferEncoding = ContentEncoding.Base64;
			stream.CopyTo(memoryBlockStream, 4096);
		}
		memoryBlockStream.Position = 0L;
		attachment.Content = new MimeContent(memoryBlockStream);
	}

	private static async Task LoadContentAsync(MimePart attachment, Stream stream, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		MemoryBlockStream content = new MemoryBlockStream();
		if (attachment.ContentType.IsMimeType("text", "*"))
		{
			byte[] buf = ArrayPool<byte>.Shared.Rent(4096);
			BestEncodingFilter filter = new BestEncodingFilter();
			try
			{
				int num;
				int outputIndex;
				int outputLength;
				while ((num = await stream.ReadAsync(buf, 0, 4096, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)) > 0)
				{
					cancellationToken.ThrowIfCancellationRequested();
					filter.Filter(buf, 0, num, out outputIndex, out outputLength);
					content.Write(buf, 0, num);
				}
				filter.Flush(buf, 0, 0, out outputIndex, out outputLength);
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(buf);
			}
			attachment.ContentTransferEncoding = filter.GetBestEncoding(EncodingConstraint.SevenBit);
		}
		else
		{
			attachment.ContentTransferEncoding = ContentEncoding.Base64;
			await stream.CopyToAsync(content, 4096, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		content.Position = 0L;
		attachment.Content = new MimeContent(content);
	}

	private static ContentType GetMimeType(string fileName)
	{
		string mimeType = MimeTypes.GetMimeType(fileName);
		return ContentType.Parse(mimeType);
	}

	private static string GetFileName(string path)
	{
		int num = path.LastIndexOf(Path.DirectorySeparatorChar);
		if (num <= 0)
		{
			return path;
		}
		return path.Substring(num + 1);
	}

	private MimeEntity CreateAttachment(ContentType contentType, string path, Stream stream)
	{
		string fileName = GetFileName(path);
		MimeEntity mimeEntity;
		if (contentType.IsMimeType("message", "rfc822"))
		{
			MimeMessage message = MimeMessage.Load(stream);
			mimeEntity = new MessagePart
			{
				Message = message
			};
		}
		else
		{
			MimePart mimePart = ((!contentType.IsMimeType("text", "*")) ? new MimePart(contentType) : new TextPart(contentType));
			LoadContent(mimePart, stream);
			mimeEntity = mimePart;
		}
		mimeEntity.ContentDisposition = new ContentDisposition(linked ? "inline" : "attachment");
		mimeEntity.ContentDisposition.FileName = fileName;
		mimeEntity.ContentType.Name = fileName;
		if (linked)
		{
			mimeEntity.ContentLocation = new Uri(fileName, UriKind.Relative);
		}
		return mimeEntity;
	}

	private async Task<MimeEntity> CreateAttachmentAsync(ContentType contentType, string path, Stream stream, CancellationToken cancellationToken)
	{
		string fileName = GetFileName(path);
		MimeEntity mimeEntity;
		if (contentType.IsMimeType("message", "rfc822"))
		{
			MimeMessage message = await MimeMessage.LoadAsync(stream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			mimeEntity = new MessagePart
			{
				Message = message
			};
		}
		else
		{
			MimePart part = ((!contentType.IsMimeType("text", "*")) ? new MimePart(contentType) : new TextPart(contentType));
			await LoadContentAsync(part, stream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			mimeEntity = part;
		}
		mimeEntity.ContentDisposition = new ContentDisposition(linked ? "inline" : "attachment");
		mimeEntity.ContentDisposition.FileName = fileName;
		mimeEntity.ContentType.Name = fileName;
		if (linked)
		{
			mimeEntity.ContentLocation = new Uri(fileName, UriKind.Relative);
		}
		return mimeEntity;
	}

	public MimeEntity Add(string fileName, byte[] data, ContentType contentType)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException("The specified file path is empty.", "fileName");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		using MemoryStream stream = new MemoryStream(data, writable: false);
		MimeEntity mimeEntity = CreateAttachment(contentType, fileName, stream);
		attachments.Add(mimeEntity);
		return mimeEntity;
	}

	public MimeEntity Add(string fileName, Stream stream, ContentType contentType)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException("The specified file path is empty.", "fileName");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!stream.CanRead)
		{
			throw new ArgumentException("The stream cannot be read.", "stream");
		}
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		MimeEntity mimeEntity = CreateAttachment(contentType, fileName, stream);
		attachments.Add(mimeEntity);
		return mimeEntity;
	}

	public async Task<MimeEntity> AddAsync(string fileName, Stream stream, ContentType contentType, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException("The specified file path is empty.", "fileName");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!stream.CanRead)
		{
			throw new ArgumentException("The stream cannot be read.", "stream");
		}
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		MimeEntity mimeEntity = await CreateAttachmentAsync(contentType, fileName, stream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		attachments.Add(mimeEntity);
		return mimeEntity;
	}

	public MimeEntity Add(string fileName, byte[] data)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException("The specified file path is empty.", "fileName");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		using MemoryStream stream = new MemoryStream(data, writable: false);
		MimeEntity mimeEntity = CreateAttachment(GetMimeType(fileName), fileName, stream);
		attachments.Add(mimeEntity);
		return mimeEntity;
	}

	public MimeEntity Add(string fileName, Stream stream)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException("The specified file path is empty.", "fileName");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!stream.CanRead)
		{
			throw new ArgumentException("The stream cannot be read.", "stream");
		}
		MimeEntity mimeEntity = CreateAttachment(GetMimeType(fileName), fileName, stream);
		attachments.Add(mimeEntity);
		return mimeEntity;
	}

	public async Task<MimeEntity> AddAsync(string fileName, Stream stream, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException("The specified file path is empty.", "fileName");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (!stream.CanRead)
		{
			throw new ArgumentException("The stream cannot be read.", "stream");
		}
		MimeEntity mimeEntity = await CreateAttachmentAsync(GetMimeType(fileName), fileName, stream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		attachments.Add(mimeEntity);
		return mimeEntity;
	}

	public MimeEntity Add(string fileName, ContentType contentType)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException("The specified file path is empty.", "fileName");
		}
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		using FileStream stream = File.OpenRead(fileName);
		MimeEntity mimeEntity = CreateAttachment(contentType, fileName, stream);
		attachments.Add(mimeEntity);
		return mimeEntity;
	}

	public async Task<MimeEntity> AddAsync(string fileName, ContentType contentType, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException("The specified file path is empty.", "fileName");
		}
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		using FileStream stream = File.OpenRead(fileName);
		MimeEntity mimeEntity = await CreateAttachmentAsync(contentType, fileName, stream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		attachments.Add(mimeEntity);
		return mimeEntity;
	}

	public MimeEntity Add(string fileName)
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException("The specified file path is empty.", "fileName");
		}
		using FileStream stream = File.OpenRead(fileName);
		MimeEntity mimeEntity = CreateAttachment(GetMimeType(fileName), fileName, stream);
		attachments.Add(mimeEntity);
		return mimeEntity;
	}

	public async Task<MimeEntity> AddAsync(string fileName, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (fileName.Length == 0)
		{
			throw new ArgumentException("The specified file path is empty.", "fileName");
		}
		using FileStream stream = File.OpenRead(fileName);
		MimeEntity mimeEntity = await CreateAttachmentAsync(GetMimeType(fileName), fileName, stream, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		attachments.Add(mimeEntity);
		return mimeEntity;
	}

	public void Add(MimeEntity attachment)
	{
		if (attachment == null)
		{
			throw new ArgumentNullException("attachment");
		}
		attachments.Add(attachment);
	}

	public void Clear()
	{
		attachments.Clear();
	}

	public bool Contains(MimeEntity attachment)
	{
		if (attachment == null)
		{
			throw new ArgumentNullException("attachment");
		}
		return attachments.Contains(attachment);
	}

	public void CopyTo(MimeEntity[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (arrayIndex < 0 || arrayIndex >= array.Length)
		{
			throw new ArgumentOutOfRangeException("arrayIndex");
		}
		attachments.CopyTo(array, arrayIndex);
	}

	public int IndexOf(MimeEntity attachment)
	{
		if (attachment == null)
		{
			throw new ArgumentNullException("attachment");
		}
		return attachments.IndexOf(attachment);
	}

	public void Insert(int index, MimeEntity attachment)
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (attachment == null)
		{
			throw new ArgumentNullException("attachment");
		}
		attachments.Insert(index, attachment);
	}

	public bool Remove(MimeEntity attachment)
	{
		if (attachment == null)
		{
			throw new ArgumentNullException("attachment");
		}
		return attachments.Remove(attachment);
	}

	public void RemoveAt(int index)
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		attachments.RemoveAt(index);
	}

	public IEnumerator<MimeEntity> GetEnumerator()
	{
		return attachments.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
