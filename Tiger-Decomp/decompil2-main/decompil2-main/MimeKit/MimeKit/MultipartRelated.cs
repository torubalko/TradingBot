using System;
using System.IO;
using System.Linq;
using MimeKit.Utils;

namespace MimeKit;

public class MultipartRelated : Multipart
{
	public MimeEntity Root
	{
		get
		{
			int rootIndex = GetRootIndex();
			if (rootIndex < 0 && base.Count == 0)
			{
				return null;
			}
			return base[Math.Max(rootIndex, 0)];
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			int num;
			if (base.Count > 0)
			{
				if ((num = GetRootIndex()) != -1)
				{
					base[num] = value;
				}
				else
				{
					Insert(0, value);
					num = 0;
				}
			}
			else
			{
				Add(value);
				num = 0;
			}
			base.ContentType.Parameters["type"] = value.ContentType.MediaType + "/" + value.ContentType.MediaSubtype;
			if (num > 0)
			{
				if (string.IsNullOrEmpty(value.ContentId))
				{
					value.ContentId = MimeUtils.GenerateMessageId();
				}
				base.ContentType.Parameters["start"] = "<" + value.ContentId + ">";
			}
			else
			{
				base.ContentType.Parameters.Remove("start");
			}
		}
	}

	public MultipartRelated(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public MultipartRelated(params object[] args)
		: base("related", args)
	{
	}

	public MultipartRelated()
		: base("related")
	{
	}

	private int GetRootIndex()
	{
		string text = base.ContentType.Parameters["start"];
		if (text != null)
		{
			string arg;
			if ((arg = MimeUtils.EnumerateReferences(text).FirstOrDefault()) == null)
			{
				arg = text;
			}
			Uri uri = new Uri($"cid:{arg}");
			return IndexOf(uri);
		}
		string text2 = base.ContentType.Parameters["type"];
		if (text2 == null)
		{
			return -1;
		}
		for (int i = 0; i < base.Count; i++)
		{
			string mimeType = base[i].ContentType.MimeType;
			if (mimeType.Equals(text2, StringComparison.OrdinalIgnoreCase))
			{
				return i;
			}
		}
		return -1;
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitMultipartRelated(this);
	}

	public bool Contains(Uri uri)
	{
		return IndexOf(uri) != -1;
	}

	public int IndexOf(Uri uri)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		bool flag = uri.IsAbsoluteUri && uri.Scheme.ToLowerInvariant() == "cid";
		for (int i = 0; i < base.Count; i++)
		{
			MimeEntity mimeEntity = base[i];
			if (uri.IsAbsoluteUri)
			{
				if (flag)
				{
					if (mimeEntity.ContentId == uri.AbsolutePath)
					{
						return i;
					}
				}
				else
				{
					if (!(mimeEntity.ContentLocation != null))
					{
						continue;
					}
					Uri uri2;
					if (!mimeEntity.ContentLocation.IsAbsoluteUri)
					{
						if (mimeEntity.ContentBase != null)
						{
							uri2 = new Uri(mimeEntity.ContentBase, mimeEntity.ContentLocation);
						}
						else
						{
							if (!(base.ContentBase != null))
							{
								continue;
							}
							uri2 = new Uri(base.ContentBase, mimeEntity.ContentLocation);
						}
					}
					else
					{
						uri2 = mimeEntity.ContentLocation;
					}
					if (uri2 == uri)
					{
						return i;
					}
				}
			}
			else if (mimeEntity.ContentLocation == uri)
			{
				return i;
			}
		}
		return -1;
	}

	public Stream Open(Uri uri, out string mimeType, out string charset)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		int num = IndexOf(uri);
		if (num == -1)
		{
			throw new FileNotFoundException();
		}
		if (!(base[num] is MimePart { Content: not null } mimePart))
		{
			throw new FileNotFoundException();
		}
		mimeType = mimePart.ContentType.MimeType;
		charset = mimePart.ContentType.Charset;
		return mimePart.Content.Open();
	}

	public Stream Open(Uri uri)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		int num = IndexOf(uri);
		if (num == -1)
		{
			throw new FileNotFoundException();
		}
		if (!(base[num] is MimePart { Content: not null } mimePart))
		{
			throw new FileNotFoundException();
		}
		return mimePart.Content.Open();
	}
}
