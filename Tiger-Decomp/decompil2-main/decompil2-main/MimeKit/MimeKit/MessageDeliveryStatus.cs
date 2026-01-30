using System;
using System.IO;
using MimeKit.IO;

namespace MimeKit;

public class MessageDeliveryStatus : MimePart
{
	private HeaderListCollection groups;

	public HeaderListCollection StatusGroups
	{
		get
		{
			if (groups == null)
			{
				if (base.Content == null)
				{
					base.Content = new MimeContent(new MemoryBlockStream());
					groups = new HeaderListCollection();
				}
				else
				{
					groups = new HeaderListCollection();
					using Stream stream = base.Content.Open();
					MimeParser mimeParser = new MimeParser(stream, MimeFormat.Entity);
					while (!mimeParser.IsEndOfStream)
					{
						HeaderList headerList = mimeParser.ParseHeaders();
						groups.Add(headerList);
					}
				}
				groups.Changed += OnGroupsChanged;
			}
			return groups;
		}
	}

	public MessageDeliveryStatus(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public MessageDeliveryStatus()
		: base("message", "delivery-status")
	{
	}

	private void OnGroupsChanged(object sender, EventArgs e)
	{
		MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		FormatOptions options = FormatOptions.Default;
		for (int i = 0; i < groups.Count; i++)
		{
			groups[i].WriteTo(options, memoryBlockStream);
		}
		memoryBlockStream.Position = 0L;
		base.Content = new MimeContent(memoryBlockStream);
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitMessageDeliveryStatus(this);
	}
}
