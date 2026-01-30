using System;
using System.IO;
using MimeKit.IO;

namespace MimeKit;

public class MessageDispositionNotification : MimePart
{
	private HeaderList fields;

	public HeaderList Fields
	{
		get
		{
			if (fields == null)
			{
				if (base.Content == null)
				{
					base.Content = new MimeContent(new MemoryBlockStream());
					fields = new HeaderList();
				}
				else
				{
					using Stream stream = base.Content.Open();
					fields = HeaderList.Load(stream);
				}
				fields.Changed += OnFieldsChanged;
			}
			return fields;
		}
	}

	public MessageDispositionNotification(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public MessageDispositionNotification()
		: base("message", "disposition-notification")
	{
	}

	private void OnFieldsChanged(object sender, HeaderListChangedEventArgs e)
	{
		MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		FormatOptions options = FormatOptions.Default;
		fields.WriteTo(options, memoryBlockStream);
		memoryBlockStream.Position = 0L;
		base.Content = new MimeContent(memoryBlockStream);
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitMessageDispositionNotification(this);
	}
}
