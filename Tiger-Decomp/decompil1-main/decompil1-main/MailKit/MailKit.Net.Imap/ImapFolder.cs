using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MailKit.Search;
using MimeKit;
using MimeKit.IO;
using MimeKit.Text;
using MimeKit.Utils;

namespace MailKit.Net.Imap;

public class ImapFolder : MailFolder, IImapFolder, IMailFolder, IEnumerable<MimeMessage>, IEnumerable
{
	private class Quota
	{
		public uint? MessageLimit;

		public uint? StorageLimit;

		public uint? CurrentMessageCount;

		public uint? CurrentStorageSize;
	}

	private class QuotaContext
	{
		public IList<string> QuotaRoots { get; private set; }

		public IDictionary<string, Quota> Quotas { get; private set; }

		public QuotaContext()
		{
			Quotas = new Dictionary<string, Quota>();
			QuotaRoots = new List<string>();
		}
	}

	private class FetchSummaryContext
	{
		public readonly List<IMessageSummary> Messages;

		public FetchSummaryContext()
		{
			Messages = new List<IMessageSummary>();
		}

		private int BinarySearch(int index, bool insert)
		{
			int num = 0;
			int num2 = Messages.Count;
			if (num2 == 0)
			{
				if (!insert)
				{
					return -1;
				}
				return 0;
			}
			do
			{
				int num3 = num + (num2 - num) / 2;
				if (index == Messages[num3].Index)
				{
					return num3;
				}
				if (index > Messages[num3].Index)
				{
					num = num3 + 1;
				}
				else
				{
					num2 = num3;
				}
			}
			while (num < num2);
			if (!insert)
			{
				return -1;
			}
			return num;
		}

		public void Add(int index, MessageSummary message)
		{
			int num = BinarySearch(index, insert: true);
			if (num < Messages.Count)
			{
				Messages.Insert(num, message);
			}
			else
			{
				Messages.Add(message);
			}
		}

		public bool TryGetValue(int index, out MessageSummary message)
		{
			int index2;
			if ((index2 = BinarySearch(index, insert: false)) == -1)
			{
				message = null;
				return false;
			}
			message = (MessageSummary)Messages[index2];
			return true;
		}

		public void OnMessageExpunged(object sender, MessageEventArgs args)
		{
			int num = BinarySearch(args.Index, insert: true);
			if (num < Messages.Count)
			{
				if (Messages[num].Index == args.Index)
				{
					Messages.RemoveAt(num);
				}
				for (int i = num; i < Messages.Count; i++)
				{
					((MessageSummary)Messages[i]).Index--;
				}
			}
		}
	}

	private class FetchPreviewTextContext : FetchStreamContextBase
	{
		private static readonly PlainTextPreviewer textPreviewer = new PlainTextPreviewer();

		private static readonly HtmlTextPreviewer htmlPreviewer = new HtmlTextPreviewer();

		private readonly FetchSummaryContext ctx;

		private readonly ImapFolder folder;

		public FetchPreviewTextContext(ImapFolder folder, FetchSummaryContext ctx)
			: base(null)
		{
			this.folder = folder;
			this.ctx = ctx;
		}

		public override Task AddAsync(Section section, bool doAsync, CancellationToken cancellationToken)
		{
			if (!ctx.TryGetValue(section.Index, out var message))
			{
				return FetchStreamContextBase.Complete;
			}
			BodyPartText bodyPartText = message.TextBody;
			TextPreviewer textPreviewer;
			if (bodyPartText == null)
			{
				textPreviewer = htmlPreviewer;
				bodyPartText = message.HtmlBody;
			}
			else
			{
				textPreviewer = FetchPreviewTextContext.textPreviewer;
			}
			if (bodyPartText == null)
			{
				return FetchStreamContextBase.Complete;
			}
			string charset = bodyPartText.ContentType.Charset ?? "utf-8";
			ContentEncoding encoding;
			if (!string.IsNullOrEmpty(bodyPartText.ContentTransferEncoding))
			{
				MimeUtils.TryParse(bodyPartText.ContentTransferEncoding, out encoding);
			}
			else
			{
				encoding = ContentEncoding.Default;
			}
			using (MemoryStream memoryStream = new MemoryStream())
			{
				MimeContent mimeContent = new MimeContent(section.Stream, encoding);
				mimeContent.DecodeTo(memoryStream);
				memoryStream.Position = 0L;
				try
				{
					message.PreviewText = textPreviewer.GetPreviewText(memoryStream, charset);
				}
				catch (DecoderFallbackException)
				{
					memoryStream.Position = 0L;
					message.PreviewText = textPreviewer.GetPreviewText(memoryStream, ImapEngine.Latin1);
				}
				message.Fields |= MessageSummaryItems.PreviewText;
				folder.OnMessageSummaryFetched(message);
			}
			return FetchStreamContextBase.Complete;
		}

		public override Task SetUniqueIdAsync(int index, UniqueId uid, bool doAsync, CancellationToken cancellationToken)
		{
			return FetchStreamContextBase.Complete;
		}
	}

	private class Section
	{
		public int Index;

		public UniqueId? UniqueId;

		public Stream Stream;

		public string Name;

		public int Offset;

		public int Length;

		public Section(Stream stream, int index, UniqueId? uid, string name, int offset, int length)
		{
			Stream = stream;
			Offset = offset;
			Length = length;
			UniqueId = uid;
			Index = index;
			Name = name;
		}
	}

	private abstract class FetchStreamContextBase : IDisposable
	{
		protected static readonly Task Complete = Task.FromResult(result: true);

		public readonly List<Section> Sections = new List<Section>();

		private readonly ITransferProgress progress;

		public FetchStreamContextBase(ITransferProgress progress)
		{
			this.progress = progress;
		}

		public abstract Task AddAsync(Section section, bool doAsync, CancellationToken cancellationToken);

		public virtual bool Contains(int index, string specifier, out Section section)
		{
			section = null;
			return false;
		}

		public abstract Task SetUniqueIdAsync(int index, UniqueId uid, bool doAsync, CancellationToken cancellationToken);

		public void Report(long nread, long total)
		{
			if (progress != null)
			{
				progress.Report(nread, total);
			}
		}

		public void Dispose()
		{
			for (int i = 0; i < Sections.Count; i++)
			{
				Section section = Sections[i];
				try
				{
					section.Stream.Dispose();
				}
				catch (IOException)
				{
				}
			}
		}
	}

	private class FetchStreamContext : FetchStreamContextBase
	{
		public FetchStreamContext(ITransferProgress progress)
			: base(progress)
		{
		}

		public override Task AddAsync(Section section, bool doAsync, CancellationToken cancellationToken)
		{
			Sections.Add(section);
			return FetchStreamContextBase.Complete;
		}

		public bool TryGetSection(UniqueId uid, string specifier, out Section section, bool remove = false)
		{
			for (int i = 0; i < Sections.Count; i++)
			{
				Section section2 = Sections[i];
				if (section2.UniqueId.HasValue && !(section2.UniqueId.Value != uid) && section2.Name.Equals(specifier, StringComparison.OrdinalIgnoreCase))
				{
					if (remove)
					{
						Sections.RemoveAt(i);
					}
					section = section2;
					return true;
				}
			}
			section = null;
			return false;
		}

		public bool TryGetSection(int index, string specifier, out Section section, bool remove = false)
		{
			for (int i = 0; i < Sections.Count; i++)
			{
				Section section2 = Sections[i];
				if (section2.Index == index && section2.Name.Equals(specifier, StringComparison.OrdinalIgnoreCase))
				{
					if (remove)
					{
						Sections.RemoveAt(i);
					}
					section = section2;
					return true;
				}
			}
			section = null;
			return false;
		}

		public override Task SetUniqueIdAsync(int index, UniqueId uid, bool doAsync, CancellationToken cancellationToken)
		{
			for (int i = 0; i < Sections.Count; i++)
			{
				if (Sections[i].Index == index)
				{
					Sections[i].UniqueId = uid;
				}
			}
			return FetchStreamContextBase.Complete;
		}
	}

	private class FetchStreamCallbackContext : FetchStreamContextBase
	{
		private readonly ImapFolder folder;

		private readonly object callback;

		public FetchStreamCallbackContext(ImapFolder folder, object callback, ITransferProgress progress)
			: base(progress)
		{
			this.folder = folder;
			this.callback = callback;
		}

		private Task InvokeCallbackAsync(ImapFolder folder, int index, UniqueId uid, Stream stream, bool doAsync, CancellationToken cancellationToken)
		{
			if (doAsync)
			{
				return ((ImapFetchStreamAsyncCallback)callback)(folder, index, uid, stream, cancellationToken);
			}
			((ImapFetchStreamCallback)callback)(folder, index, uid, stream);
			return FetchStreamContextBase.Complete;
		}

		public override async Task AddAsync(Section section, bool doAsync, CancellationToken cancellationToken)
		{
			if (section.UniqueId.HasValue)
			{
				await InvokeCallbackAsync(folder, section.Index, section.UniqueId.Value, section.Stream, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				section.Stream.Dispose();
			}
			else
			{
				Sections.Add(section);
			}
		}

		public override async Task SetUniqueIdAsync(int index, UniqueId uid, bool doAsync, CancellationToken cancellationToken)
		{
			for (int i = 0; i < Sections.Count; i++)
			{
				if (Sections[i].Index == index)
				{
					await InvokeCallbackAsync(folder, index, uid, Sections[i].Stream, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					Sections[i].Stream.Dispose();
					Sections.RemoveAt(i);
					break;
				}
			}
		}
	}

	private bool supportsModSeq;

	internal static readonly HashSet<string> EmptyHeaderFields = new HashSet<string>();

	private const int PreviewHtmlLength = 16384;

	private const int PreviewTextLength = 512;

	private const int BufferSize = 4096;

	internal ImapEngine Engine { get; private set; }

	internal string EncodedName { get; set; }

	public override object SyncRoot => Engine;

	public override HashSet<ThreadingAlgorithm> ThreadingAlgorithms => Engine.ThreadingAlgorithms;

	public override bool IsOpen => Engine.Selected == this;

	public ImapFolder(ImapFolderConstructorArgs args)
	{
		if (args == null)
		{
			throw new ArgumentNullException("args");
		}
		InitializeProperties(args);
	}

	private void InitializeProperties(ImapFolderConstructorArgs args)
	{
		base.DirectorySeparator = args.DirectorySeparator;
		EncodedName = args.EncodedName;
		base.Attributes = args.Attributes;
		base.FullName = args.FullName;
		Engine = args.Engine;
		base.Name = args.Name;
	}

	public override bool Supports(FolderFeature feature)
	{
		return feature switch
		{
			FolderFeature.AccessRights => (Engine.Capabilities & ImapCapabilities.Acl) != 0, 
			FolderFeature.Annotations => base.AnnotationAccess != AnnotationAccess.None, 
			FolderFeature.Metadata => (Engine.Capabilities & ImapCapabilities.Metadata) != 0, 
			FolderFeature.ModSequences => supportsModSeq, 
			FolderFeature.QuickResync => Engine.QResyncEnabled, 
			FolderFeature.Quotas => (Engine.Capabilities & ImapCapabilities.Quota) != 0, 
			FolderFeature.Sorting => (Engine.Capabilities & ImapCapabilities.Sort) != 0, 
			FolderFeature.Threading => (Engine.Capabilities & ImapCapabilities.Thread) != 0, 
			FolderFeature.UTF8 => Engine.UTF8Enabled, 
			_ => false, 
		};
	}

	private void CheckState(bool open, bool rw)
	{
		if (Engine.IsDisposed)
		{
			throw new ObjectDisposedException("ImapClient");
		}
		if (!Engine.IsConnected)
		{
			throw new ServiceNotConnectedException("The ImapClient is not connected.");
		}
		if (Engine.State < ImapEngineState.Authenticated)
		{
			throw new ServiceNotAuthenticatedException("The ImapClient is not authenticated.");
		}
		if (open)
		{
			FolderAccess folderAccess = ((!rw) ? FolderAccess.ReadOnly : FolderAccess.ReadWrite);
			if (!IsOpen || base.Access < folderAccess)
			{
				throw new FolderNotOpenException(base.FullName, folderAccess);
			}
		}
	}

	private void CheckAllowIndexes()
	{
		if (Engine.NotifySelectedNewExpunge)
		{
			throw new InvalidOperationException("Indexes and '*' cannot be used while MessageNew/MessageExpunge is registered with NOTIFY for SELECTED.");
		}
	}

	internal void Reset()
	{
		base.PermanentFlags = MessageFlags.None;
		base.AcceptedFlags = MessageFlags.None;
		base.Access = FolderAccess.None;
		base.AnnotationAccess = AnnotationAccess.None;
		base.AnnotationScopes = AnnotationScope.None;
		base.MaxAnnotationSize = 0u;
		supportsModSeq = false;
		base.HighestModSeq = 0uL;
	}

	protected override void OnParentFolderRenamed()
	{
		string encodedName = EncodedName;
		base.FullName = base.ParentFolder.FullName + base.DirectorySeparator + base.Name;
		EncodedName = Engine.EncodeMailboxName(base.FullName);
		Engine.FolderCache.Remove(encodedName);
		Engine.FolderCache[EncodedName] = this;
		Reset();
		if (Engine.Selected == this)
		{
			Engine.State = ImapEngineState.Authenticated;
			Engine.Selected = null;
			OnClosed();
		}
	}

	private void ProcessResponseCodes(ImapCommand ic, IMailFolder folder, bool throwNotFound = true)
	{
		bool flag = false;
		foreach (ImapResponseCode respCode in ic.RespCodes)
		{
			switch (respCode.Type)
			{
			case ImapResponseCodeType.PermanentFlags:
				base.PermanentFlags = ((PermanentFlagsResponseCode)respCode).Flags;
				break;
			case ImapResponseCodeType.ReadOnly:
				if (respCode.IsTagged)
				{
					base.Access = FolderAccess.ReadOnly;
				}
				break;
			case ImapResponseCodeType.ReadWrite:
				if (respCode.IsTagged)
				{
					base.Access = FolderAccess.ReadWrite;
				}
				break;
			case ImapResponseCodeType.TryCreate:
				flag = true;
				break;
			case ImapResponseCodeType.UidNext:
				base.UidNext = ((UidNextResponseCode)respCode).Uid;
				break;
			case ImapResponseCodeType.UidValidity:
			{
				uint uidValidity = ((UidValidityResponseCode)respCode).UidValidity;
				if (IsOpen)
				{
					UpdateUidValidity(uidValidity);
				}
				else
				{
					base.UidValidity = uidValidity;
				}
				break;
			}
			case ImapResponseCodeType.Unseen:
				base.FirstUnread = ((UnseenResponseCode)respCode).Index;
				break;
			case ImapResponseCodeType.HighestModSeq:
			{
				ulong highestModSeq = ((HighestModSeqResponseCode)respCode).HighestModSeq;
				supportsModSeq = true;
				if (IsOpen)
				{
					UpdateHighestModSeq(highestModSeq);
				}
				else
				{
					base.HighestModSeq = highestModSeq;
				}
				break;
			}
			case ImapResponseCodeType.NoModSeq:
				supportsModSeq = false;
				base.HighestModSeq = 0uL;
				break;
			case ImapResponseCodeType.MailboxId:
				if (!respCode.IsTagged)
				{
					base.Id = ((MailboxIdResponseCode)respCode).MailboxId;
				}
				break;
			case ImapResponseCodeType.Annotations:
			{
				AnnotationsResponseCode annotationsResponseCode = (AnnotationsResponseCode)respCode;
				base.AnnotationAccess = annotationsResponseCode.Access;
				base.AnnotationScopes = annotationsResponseCode.Scopes;
				base.MaxAnnotationSize = annotationsResponseCode.MaxSize;
				break;
			}
			}
		}
		if (flag && throwNotFound && folder != null)
		{
			throw new FolderNotFoundException(folder.FullName);
		}
	}

	private static string SelectOrExamine(FolderAccess access)
	{
		if (access != FolderAccess.ReadOnly)
		{
			return "SELECT";
		}
		return "EXAMINE";
	}

	private static Task QResyncFetchAsync(ImapEngine engine, ImapCommand ic, int index, bool doAsync)
	{
		return ic.Folder.OnFetchAsync(engine, index, doAsync, ic.CancellationToken);
	}

	private async Task<FolderAccess> OpenAsync(ImapCommand ic, FolderAccess access, bool doAsync, CancellationToken cancellationToken)
	{
		Reset();
		if (access == FolderAccess.ReadWrite)
		{
			base.PermanentFlags = MailFolder.SettableFlags | MessageFlags.UserDefined;
		}
		else
		{
			base.PermanentFlags = MessageFlags.None;
		}
		try
		{
			Engine.QueueCommand(ic);
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, this);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create((access == FolderAccess.ReadOnly) ? "EXAMINE" : "SELECT", ic);
			}
		}
		catch
		{
			base.PermanentFlags = MessageFlags.None;
			throw;
		}
		if (Engine.Selected != null && Engine.Selected != this)
		{
			ImapFolder selected = Engine.Selected;
			selected.Reset();
			selected.OnClosed();
		}
		Engine.State = ImapEngineState.Selected;
		Engine.Selected = this;
		OnOpened();
		return base.Access;
	}

	private Task<FolderAccess> OpenAsync(FolderAccess access, uint uidValidity, ulong highestModSeq, IList<UniqueId> uids, bool doAsync, CancellationToken cancellationToken)
	{
		if (access != FolderAccess.ReadOnly && access != FolderAccess.ReadWrite)
		{
			throw new ArgumentOutOfRangeException("access");
		}
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		CheckState(open: false, rw: false);
		if ((Engine.Capabilities & ImapCapabilities.QuickResync) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the QRESYNC extension.");
		}
		if (!Supports(FolderFeature.QuickResync))
		{
			throw new InvalidOperationException("The QRESYNC extension has not been enabled.");
		}
		string text = (((Engine.Capabilities & ImapCapabilities.Annotate) == ImapCapabilities.None || Engine.QuirksMode == ImapQuirksMode.SunMicrosystems) ? string.Format(CultureInfo.InvariantCulture, "(QRESYNC ({0} {1}", uidValidity, highestModSeq) : string.Format(CultureInfo.InvariantCulture, "(ANNOTATE QRESYNC ({0} {1}", uidValidity, highestModSeq));
		if (uids.Count > 0)
		{
			string text2 = UniqueIdSet.ToString(uids);
			text = text + " " + text2;
		}
		text += "))";
		string format = $"{SelectOrExamine(access)} %F {text}\r\n";
		ImapCommand imapCommand = new ImapCommand(Engine, cancellationToken, this, format, this);
		imapCommand.RegisterUntaggedHandler("FETCH", QResyncFetchAsync);
		return OpenAsync(imapCommand, access, doAsync, cancellationToken);
	}

	public override FolderAccess Open(FolderAccess access, uint uidValidity, ulong highestModSeq, IList<UniqueId> uids, CancellationToken cancellationToken = default(CancellationToken))
	{
		return OpenAsync(access, uidValidity, highestModSeq, uids, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<FolderAccess> OpenAsync(FolderAccess access, uint uidValidity, ulong highestModSeq, IList<UniqueId> uids, CancellationToken cancellationToken = default(CancellationToken))
	{
		return OpenAsync(access, uidValidity, highestModSeq, uids, doAsync: true, cancellationToken);
	}

	private Task<FolderAccess> OpenAsync(FolderAccess access, bool doAsync, CancellationToken cancellationToken)
	{
		if (access != FolderAccess.ReadOnly && access != FolderAccess.ReadWrite)
		{
			throw new ArgumentOutOfRangeException("access");
		}
		CheckState(open: false, rw: false);
		string text = string.Empty;
		if ((Engine.Capabilities & ImapCapabilities.CondStore) != ImapCapabilities.None)
		{
			text += "CONDSTORE";
		}
		if ((Engine.Capabilities & ImapCapabilities.Annotate) != ImapCapabilities.None && Engine.QuirksMode != ImapQuirksMode.SunMicrosystems)
		{
			text += " ANNOTATE";
		}
		if (text.Length > 0)
		{
			text = " (" + text.TrimStart() + ")";
		}
		string format = $"{SelectOrExamine(access)} %F{text}\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format, this);
		return OpenAsync(ic, access, doAsync, cancellationToken);
	}

	public override FolderAccess Open(FolderAccess access, CancellationToken cancellationToken = default(CancellationToken))
	{
		return OpenAsync(access, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<FolderAccess> OpenAsync(FolderAccess access, CancellationToken cancellationToken = default(CancellationToken))
	{
		return OpenAsync(access, doAsync: true, cancellationToken);
	}

	private async Task CloseAsync(bool expunge, bool doAsync, CancellationToken cancellationToken)
	{
		CheckState(open: true, expunge);
		ImapCommand ic = (expunge ? Engine.QueueCommand(cancellationToken, this, "CLOSE\r\n") : (((Engine.Capabilities & ImapCapabilities.Unselect) == ImapCapabilities.None) ? null : Engine.QueueCommand(cancellationToken, this, "UNSELECT\r\n")));
		if (ic != null)
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create(expunge ? "CLOSE" : "UNSELECT", ic);
			}
		}
		Reset();
		if (Engine.Selected == this)
		{
			Engine.State = ImapEngineState.Authenticated;
			Engine.Selected = null;
			OnClosed();
		}
	}

	public override void Close(bool expunge = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		CloseAsync(expunge, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task CloseAsync(bool expunge = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		return CloseAsync(expunge, doAsync: true, cancellationToken);
	}

	private async Task<IMailFolder> GetCreatedFolderAsync(string encodedName, string id, bool specialUse, bool doAsync, CancellationToken cancellationToken)
	{
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, null, "LIST \"\" %S\r\n", encodedName);
		List<ImapFolder> list = new List<ImapFolder>();
		ic.RegisterUntaggedHandler("LIST", ImapUtils.ParseFolderListAsync);
		ic.UserData = list;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("LIST", ic);
		}
		ImapFolder folder;
		if ((folder = ImapEngine.GetFolder(list, encodedName)) != null)
		{
			folder.ParentFolder = this;
			folder.Id = id;
			if (specialUse)
			{
				Engine.AssignSpecialFolder(folder);
			}
		}
		return folder;
	}

	private async Task<IMailFolder> CreateAsync(string name, bool isMessageFolder, bool doAsync, CancellationToken cancellationToken)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (!Engine.IsValidMailboxName(name, base.DirectorySeparator))
		{
			throw new ArgumentException("The name is not a legal folder name.", "name");
		}
		CheckState(open: false, rw: false);
		if (!string.IsNullOrEmpty(base.FullName) && base.DirectorySeparator == '\0')
		{
			throw new InvalidOperationException("Cannot create child folders.");
		}
		string mailboxName = ((!string.IsNullOrEmpty(base.FullName)) ? (base.FullName + base.DirectorySeparator + name) : name);
		string encodedName = Engine.EncodeMailboxName(mailboxName);
		string text = encodedName;
		if (!isMessageFolder && Engine.QuirksMode != ImapQuirksMode.GMail)
		{
			text += base.DirectorySeparator;
		}
		ImapCommand ic = Engine.QueueCommand(cancellationToken, null, "CREATE %S\r\n", text);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok && ic.GetResponseCode(ImapResponseCodeType.AlreadyExists) == null)
		{
			throw ImapCommandException.Create("CREATE", ic);
		}
		string id = ((MailboxIdResponseCode)ic.GetResponseCode(ImapResponseCodeType.MailboxId))?.MailboxId;
		IMailFolder mailFolder = await GetCreatedFolderAsync(encodedName, id, specialUse: false, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		Engine.OnFolderCreated(mailFolder);
		return mailFolder;
	}

	public override IMailFolder Create(string name, bool isMessageFolder, CancellationToken cancellationToken = default(CancellationToken))
	{
		return CreateAsync(name, isMessageFolder, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IMailFolder> CreateAsync(string name, bool isMessageFolder, CancellationToken cancellationToken = default(CancellationToken))
	{
		return CreateAsync(name, isMessageFolder, doAsync: true, cancellationToken);
	}

	private async Task<IMailFolder> CreateAsync(string name, IEnumerable<SpecialFolder> specialUses, bool doAsync, CancellationToken cancellationToken)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (!Engine.IsValidMailboxName(name, base.DirectorySeparator))
		{
			throw new ArgumentException("The name is not a legal folder name.", "name");
		}
		if (specialUses == null)
		{
			throw new ArgumentNullException("specialUses");
		}
		CheckState(open: false, rw: false);
		if (!string.IsNullOrEmpty(base.FullName) && base.DirectorySeparator == '\0')
		{
			throw new InvalidOperationException("Cannot create child folders.");
		}
		if ((Engine.Capabilities & ImapCapabilities.CreateSpecialUse) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the CREATE-SPECIAL-USE extension.");
		}
		StringBuilder stringBuilder = new StringBuilder();
		uint num = 0u;
		foreach (SpecialFolder specialUse in specialUses)
		{
			uint num2 = (uint)(1 << (int)specialUse);
			if ((num & num2) != 0)
			{
				continue;
			}
			num |= num2;
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Append(' ');
			}
			switch (specialUse)
			{
			case SpecialFolder.All:
				stringBuilder.Append("\\All");
				continue;
			case SpecialFolder.Archive:
				stringBuilder.Append("\\Archive");
				continue;
			case SpecialFolder.Drafts:
				stringBuilder.Append("\\Drafts");
				continue;
			case SpecialFolder.Flagged:
				stringBuilder.Append("\\Flagged");
				continue;
			case SpecialFolder.Important:
				stringBuilder.Append("\\Important");
				continue;
			case SpecialFolder.Junk:
				stringBuilder.Append("\\Junk");
				continue;
			case SpecialFolder.Sent:
				stringBuilder.Append("\\Sent");
				continue;
			case SpecialFolder.Trash:
				stringBuilder.Append("\\Trash");
				continue;
			}
			if (stringBuilder.Length > 0)
			{
				stringBuilder.Length--;
			}
		}
		string mailboxName = ((!string.IsNullOrEmpty(base.FullName)) ? (base.FullName + base.DirectorySeparator + name) : name);
		string encodedName = Engine.EncodeMailboxName(mailboxName);
		string format = ((stringBuilder.Length <= 0) ? "CREATE %S\r\n" : $"CREATE %S (USE ({stringBuilder}))\r\n");
		ImapCommand ic = Engine.QueueCommand(cancellationToken, null, format, encodedName);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("CREATE", ic);
		}
		string id = ((MailboxIdResponseCode)ic.GetResponseCode(ImapResponseCodeType.MailboxId))?.MailboxId;
		IMailFolder mailFolder = await GetCreatedFolderAsync(encodedName, id, specialUse: true, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		Engine.OnFolderCreated(mailFolder);
		return mailFolder;
	}

	public override IMailFolder Create(string name, IEnumerable<SpecialFolder> specialUses, CancellationToken cancellationToken = default(CancellationToken))
	{
		return CreateAsync(name, specialUses, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IMailFolder> CreateAsync(string name, IEnumerable<SpecialFolder> specialUses, CancellationToken cancellationToken = default(CancellationToken))
	{
		return CreateAsync(name, specialUses, doAsync: true, cancellationToken);
	}

	private async Task RenameAsync(IMailFolder parent, string name, bool doAsync, CancellationToken cancellationToken)
	{
		if (parent == null)
		{
			throw new ArgumentNullException("parent");
		}
		if (!(parent is ImapFolder) || ((ImapFolder)parent).Engine != Engine)
		{
			throw new ArgumentException("The parent folder does not belong to this ImapClient.", "parent");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (!Engine.IsValidMailboxName(name, base.DirectorySeparator))
		{
			throw new ArgumentException("The name is not a legal folder name.", "name");
		}
		if (base.IsNamespace || (base.Attributes & FolderAttributes.Inbox) != FolderAttributes.None)
		{
			throw new InvalidOperationException("Cannot rename this folder.");
		}
		CheckState(open: false, rw: false);
		string mailboxName = (string.IsNullOrEmpty(parent.FullName) ? name : (parent.FullName + parent.DirectorySeparator + name));
		string encodedName = Engine.EncodeMailboxName(mailboxName);
		ImapCommand ic = Engine.QueueCommand(cancellationToken, null, "RENAME %F %S\r\n", this, encodedName);
		string oldFullName = base.FullName;
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, this);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("RENAME", ic);
		}
		Engine.FolderCache.Remove(EncodedName);
		Engine.FolderCache[encodedName] = this;
		base.ParentFolder = parent;
		base.FullName = Engine.DecodeMailboxName(encodedName);
		EncodedName = encodedName;
		base.Name = name;
		Reset();
		if (Engine.Selected == this)
		{
			Engine.State = ImapEngineState.Authenticated;
			Engine.Selected = null;
			OnClosed();
		}
		OnRenamed(oldFullName, base.FullName);
	}

	public override void Rename(IMailFolder parent, string name, CancellationToken cancellationToken = default(CancellationToken))
	{
		RenameAsync(parent, name, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task RenameAsync(IMailFolder parent, string name, CancellationToken cancellationToken = default(CancellationToken))
	{
		return RenameAsync(parent, name, doAsync: true, cancellationToken);
	}

	private async Task DeleteAsync(bool doAsync, CancellationToken cancellationToken)
	{
		if (base.IsNamespace || (base.Attributes & FolderAttributes.Inbox) != FolderAttributes.None)
		{
			throw new InvalidOperationException("Cannot delete this folder.");
		}
		CheckState(open: false, rw: false);
		ImapCommand ic = Engine.QueueCommand(cancellationToken, null, "DELETE %F\r\n", this);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, this);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("DELETE", ic);
		}
		Reset();
		if (Engine.Selected == this)
		{
			Engine.State = ImapEngineState.Authenticated;
			Engine.Selected = null;
			OnClosed();
		}
		base.Attributes |= FolderAttributes.NonExistent;
		OnDeleted();
	}

	public override void Delete(CancellationToken cancellationToken = default(CancellationToken))
	{
		DeleteAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return DeleteAsync(doAsync: true, cancellationToken);
	}

	private async Task SubscribeAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckState(open: false, rw: false);
		ImapCommand ic = Engine.QueueCommand(cancellationToken, null, "SUBSCRIBE %F\r\n", this);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("SUBSCRIBE", ic);
		}
		if ((base.Attributes & FolderAttributes.Subscribed) == 0)
		{
			base.Attributes |= FolderAttributes.Subscribed;
			OnSubscribed();
		}
	}

	public override void Subscribe(CancellationToken cancellationToken = default(CancellationToken))
	{
		SubscribeAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task SubscribeAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return SubscribeAsync(doAsync: true, cancellationToken);
	}

	private async Task UnsubscribeAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckState(open: false, rw: false);
		ImapCommand ic = Engine.QueueCommand(cancellationToken, null, "UNSUBSCRIBE %F\r\n", this);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("UNSUBSCRIBE", ic);
		}
		if ((base.Attributes & FolderAttributes.Subscribed) != FolderAttributes.None)
		{
			base.Attributes &= ~FolderAttributes.Subscribed;
			OnUnsubscribed();
		}
	}

	public override void Unsubscribe(CancellationToken cancellationToken = default(CancellationToken))
	{
		UnsubscribeAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task UnsubscribeAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return UnsubscribeAsync(doAsync: true, cancellationToken);
	}

	private async Task<IList<IMailFolder>> GetSubfoldersAsync(StatusItems items, bool subscribedOnly, bool doAsync, CancellationToken cancellationToken)
	{
		CheckState(open: false, rw: false);
		StringBuilder stringBuilder = new StringBuilder(EncodedName.Length + 2);
		stringBuilder.Append(EncodedName);
		for (int i = 0; i < EncodedName.Length; i++)
		{
			if (stringBuilder[i] == '*')
			{
				stringBuilder[i] = '%';
			}
		}
		if (stringBuilder.Length > 0)
		{
			stringBuilder.Append(base.DirectorySeparator);
		}
		stringBuilder.Append('%');
		List<IMailFolder> children = new List<IMailFolder>();
		bool status = items != StatusItems.None;
		List<ImapFolder> list = new List<ImapFolder>();
		StringBuilder stringBuilder2 = new StringBuilder();
		bool listReturnsSubscribed = false;
		bool lsub = subscribedOnly;
		if (subscribedOnly)
		{
			if ((Engine.Capabilities & ImapCapabilities.ListExtended) != ImapCapabilities.None)
			{
				stringBuilder2.Append("LIST (SUBSCRIBED)");
				listReturnsSubscribed = true;
				lsub = false;
			}
			else
			{
				stringBuilder2.Append("LSUB");
			}
		}
		else
		{
			stringBuilder2.Append("LIST");
		}
		stringBuilder2.Append(" \"\" %S");
		if (!lsub)
		{
			if (items != StatusItems.None && (Engine.Capabilities & ImapCapabilities.ListStatus) != ImapCapabilities.None)
			{
				stringBuilder2.Append(" RETURN (");
				if ((Engine.Capabilities & ImapCapabilities.ListExtended) != ImapCapabilities.None)
				{
					if (!subscribedOnly)
					{
						stringBuilder2.Append("SUBSCRIBED ");
						listReturnsSubscribed = true;
					}
					stringBuilder2.Append("CHILDREN ");
				}
				stringBuilder2.AppendFormat("STATUS ({0})", Engine.GetStatusQuery(items));
				stringBuilder2.Append(')');
				status = false;
			}
			else if ((Engine.Capabilities & ImapCapabilities.ListExtended) != ImapCapabilities.None)
			{
				stringBuilder2.Append(" RETURN (");
				if (!subscribedOnly)
				{
					stringBuilder2.Append("SUBSCRIBED ");
					listReturnsSubscribed = true;
				}
				stringBuilder2.Append("CHILDREN");
				stringBuilder2.Append(')');
			}
		}
		stringBuilder2.Append("\r\n");
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, null, stringBuilder2.ToString(), stringBuilder.ToString());
		ic.RegisterUntaggedHandler(lsub ? "LSUB" : "LIST", ImapUtils.ParseFolderListAsync);
		ic.ListReturnsSubscribed = listReturnsSubscribed;
		ic.UserData = list;
		ic.Lsub = lsub;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		string mailboxName = ((base.FullName.Length > 0) ? (base.FullName + base.DirectorySeparator) : string.Empty);
		mailboxName = ImapUtils.CanonicalizeMailboxName(mailboxName, base.DirectorySeparator);
		bool flag = false;
		foreach (ImapFolder item in list)
		{
			string text = ImapUtils.CanonicalizeMailboxName(item.FullName, item.DirectorySeparator);
			string text2 = (ImapUtils.IsInbox(item.FullName) ? "INBOX" : item.Name);
			if (!text.StartsWith(mailboxName, StringComparison.Ordinal))
			{
				flag |= item.ParentFolder == null;
				continue;
			}
			if (string.Compare(text, mailboxName.Length, text2, 0, text2.Length, StringComparison.Ordinal) != 0)
			{
				flag |= item.ParentFolder == null;
				continue;
			}
			item.ParentFolder = this;
			children.Add(item);
		}
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create(lsub ? "LSUB" : "LIST", ic);
		}
		if (flag)
		{
			await Engine.LookupParentFoldersAsync(list, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		if (status)
		{
			for (int j = 0; j < children.Count; j++)
			{
				if (children[j].Exists)
				{
					await ((ImapFolder)children[j]).StatusAsync(items, doAsync, throwNotFound: false, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
			}
		}
		return children;
	}

	public override IList<IMailFolder> GetSubfolders(StatusItems items, bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetSubfoldersAsync(items, subscribedOnly, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<IMailFolder>> GetSubfoldersAsync(StatusItems items, bool subscribedOnly = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetSubfoldersAsync(items, subscribedOnly, doAsync: true, cancellationToken);
	}

	private async Task<IMailFolder> GetSubfolderAsync(string name, bool doAsync, CancellationToken cancellationToken)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (!Engine.IsValidMailboxName(name, base.DirectorySeparator))
		{
			throw new ArgumentException("The name of the subfolder is invalid.", "name");
		}
		CheckState(open: false, rw: false);
		string fullName = ((base.FullName.Length > 0) ? (base.FullName + base.DirectorySeparator + name) : name);
		string encodedName = Engine.EncodeMailboxName(fullName);
		if (Engine.GetCachedFolder(encodedName, out var folder))
		{
			return folder;
		}
		string text = encodedName.Replace('*', '%');
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, null, "LIST \"\" %S\r\n", text);
		ic.RegisterUntaggedHandler("LIST", ImapUtils.ParseFolderListAsync);
		List<ImapFolder> userData;
		List<ImapFolder> list = (userData = new List<ImapFolder>());
		ic.UserData = userData;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("LIST", ic);
		}
		ImapFolder folder2;
		folder = (folder2 = ImapEngine.GetFolder(list, encodedName));
		if (folder2 != null)
		{
			folder.ParentFolder = this;
		}
		if (list.Count > 1 || folder == null)
		{
			await Engine.LookupParentFoldersAsync(list, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		if (folder == null)
		{
			throw new FolderNotFoundException(fullName);
		}
		return folder;
	}

	public override IMailFolder GetSubfolder(string name, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetSubfolderAsync(name, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IMailFolder> GetSubfolderAsync(string name, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetSubfolderAsync(name, doAsync: true, cancellationToken);
	}

	private async Task CheckAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckState(open: true, rw: false);
		ImapCommand ic = Engine.QueueCommand(cancellationToken, this, "CHECK\r\n");
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("CHECK", ic);
		}
	}

	public override void Check(CancellationToken cancellationToken = default(CancellationToken))
	{
		CheckAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task CheckAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return CheckAsync(doAsync: true, cancellationToken);
	}

	internal async Task StatusAsync(StatusItems items, bool doAsync, bool throwNotFound, CancellationToken cancellationToken)
	{
		if ((Engine.Capabilities & ImapCapabilities.Status) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the STATUS command.");
		}
		CheckState(open: false, rw: false);
		if (items != StatusItems.None)
		{
			string format = $"STATUS %F ({Engine.GetStatusQuery(items)})\r\n";
			ImapCommand ic = Engine.QueueCommand(cancellationToken, null, format, this);
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, this, throwNotFound);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("STATUS", ic);
			}
		}
	}

	public override void Status(StatusItems items, CancellationToken cancellationToken = default(CancellationToken))
	{
		StatusAsync(items, doAsync: false, throwNotFound: true, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task StatusAsync(StatusItems items, CancellationToken cancellationToken = default(CancellationToken))
	{
		return StatusAsync(items, doAsync: true, throwNotFound: true, cancellationToken);
	}

	private static async Task<string> ReadStringTokenAsync(ImapEngine engine, string format, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync("(){%*\\\"\n", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		return imapToken.Type switch
		{
			ImapTokenType.Literal => await engine.ReadLiteralAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false), 
			ImapTokenType.QString => (string)imapToken.Value, 
			ImapTokenType.Atom => (string)imapToken.Value, 
			_ => throw ImapEngine.UnexpectedToken(format, imapToken), 
		};
	}

	private static async Task UntaggedAclAsync(ImapEngine engine, ImapCommand ic, int index, bool doAsync)
	{
		string format = string.Format("Syntax error in untagged {0} response. {1}", "ACL", "{0}");
		AccessControlList acl = (AccessControlList)ic.UserData;
		await ReadStringTokenAsync(engine, format, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		do
		{
			acl.Add(new AccessControl(await ReadStringTokenAsync(engine, format, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false), await ReadStringTokenAsync(engine, format, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
		}
		while ((await engine.PeekTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type != ImapTokenType.Eoln);
	}

	private async Task<AccessControlList> GetAccessControlListAsync(bool doAsync, CancellationToken cancellationToken)
	{
		if ((Engine.Capabilities & ImapCapabilities.Acl) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the ACL extension.");
		}
		CheckState(open: false, rw: false);
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, null, "GETACL %F\r\n", this);
		ic.RegisterUntaggedHandler("ACL", UntaggedAclAsync);
		ic.UserData = new AccessControlList();
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("GETACL", ic);
		}
		return (AccessControlList)ic.UserData;
	}

	public override AccessControlList GetAccessControlList(CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetAccessControlListAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<AccessControlList> GetAccessControlListAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetAccessControlListAsync(doAsync: true, cancellationToken);
	}

	private static async Task UntaggedListRightsAsync(ImapEngine engine, ImapCommand ic, int index, bool doAsync)
	{
		string format = string.Format("Syntax error in untagged {0} response. {1}", "LISTRIGHTS", "{0}");
		AccessRights access = (AccessRights)ic.UserData;
		await ReadStringTokenAsync(engine, format, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		await ReadStringTokenAsync(engine, format, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		do
		{
			access.AddRange(await ReadStringTokenAsync(engine, format, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false));
		}
		while ((await engine.PeekTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type != ImapTokenType.Eoln);
	}

	private async Task<AccessRights> GetAccessRightsAsync(string name, bool doAsync, CancellationToken cancellationToken)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if ((Engine.Capabilities & ImapCapabilities.Acl) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the ACL extension.");
		}
		CheckState(open: false, rw: false);
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, null, "LISTRIGHTS %F %S\r\n", this, name);
		ic.RegisterUntaggedHandler("LISTRIGHTS", UntaggedListRightsAsync);
		ic.UserData = new AccessRights();
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("LISTRIGHTS", ic);
		}
		return (AccessRights)ic.UserData;
	}

	public override AccessRights GetAccessRights(string name, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetAccessRightsAsync(name, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<AccessRights> GetAccessRightsAsync(string name, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetAccessRightsAsync(name, doAsync: true, cancellationToken);
	}

	private static async Task UntaggedMyRightsAsync(ImapEngine engine, ImapCommand ic, int index, bool doAsync)
	{
		string format = string.Format("Syntax error in untagged {0} response. {1}", "MYRIGHTS", "{0}");
		AccessRights access = (AccessRights)ic.UserData;
		await ReadStringTokenAsync(engine, format, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		AccessRights accessRights = access;
		accessRights.AddRange(await ReadStringTokenAsync(engine, format, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false));
	}

	private async Task<AccessRights> GetMyAccessRightsAsync(bool doAsync, CancellationToken cancellationToken)
	{
		if ((Engine.Capabilities & ImapCapabilities.Acl) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the ACL extension.");
		}
		CheckState(open: false, rw: false);
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, null, "MYRIGHTS %F\r\n", this);
		ic.RegisterUntaggedHandler("MYRIGHTS", UntaggedMyRightsAsync);
		ic.UserData = new AccessRights();
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("MYRIGHTS", ic);
		}
		return (AccessRights)ic.UserData;
	}

	public override AccessRights GetMyAccessRights(CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMyAccessRightsAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<AccessRights> GetMyAccessRightsAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMyAccessRightsAsync(doAsync: true, cancellationToken);
	}

	private async Task ModifyAccessRightsAsync(string name, AccessRights rights, string action, bool doAsync, CancellationToken cancellationToken)
	{
		if ((Engine.Capabilities & ImapCapabilities.Acl) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the ACL extension.");
		}
		CheckState(open: false, rw: false);
		ImapCommand ic = Engine.QueueCommand(cancellationToken, null, "SETACL %F %S %S\r\n", this, name, action + rights);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("SETACL", ic);
		}
	}

	public override void AddAccessRights(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (rights == null)
		{
			throw new ArgumentNullException("rights");
		}
		if (rights.Count == 0)
		{
			throw new ArgumentException("No rights were specified.", "rights");
		}
		ModifyAccessRightsAsync(name, rights, "+", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task AddAccessRightsAsync(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (rights == null)
		{
			throw new ArgumentNullException("rights");
		}
		if (rights.Count == 0)
		{
			throw new ArgumentException("No rights were specified.", "rights");
		}
		return ModifyAccessRightsAsync(name, rights, "+", doAsync: true, cancellationToken);
	}

	public override void RemoveAccessRights(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (rights == null)
		{
			throw new ArgumentNullException("rights");
		}
		if (rights.Count == 0)
		{
			throw new ArgumentException("No rights were specified.", "rights");
		}
		ModifyAccessRightsAsync(name, rights, "-", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task RemoveAccessRightsAsync(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (rights == null)
		{
			throw new ArgumentNullException("rights");
		}
		if (rights.Count == 0)
		{
			throw new ArgumentException("No rights were specified.", "rights");
		}
		return ModifyAccessRightsAsync(name, rights, "-", doAsync: true, cancellationToken);
	}

	public override void SetAccessRights(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (rights == null)
		{
			throw new ArgumentNullException("rights");
		}
		ModifyAccessRightsAsync(name, rights, string.Empty, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task SetAccessRightsAsync(string name, AccessRights rights, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (rights == null)
		{
			throw new ArgumentNullException("rights");
		}
		return ModifyAccessRightsAsync(name, rights, string.Empty, doAsync: true, cancellationToken);
	}

	private async Task RemoveAccessAsync(string name, bool doAsync, CancellationToken cancellationToken)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if ((Engine.Capabilities & ImapCapabilities.Acl) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the ACL extension.");
		}
		CheckState(open: false, rw: false);
		ImapCommand ic = Engine.QueueCommand(cancellationToken, null, "DELETEACL %F %S\r\n", this, name);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("DELETEACL", ic);
		}
	}

	public override void RemoveAccess(string name, CancellationToken cancellationToken = default(CancellationToken))
	{
		RemoveAccessAsync(name, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task RemoveAccessAsync(string name, CancellationToken cancellationToken = default(CancellationToken))
	{
		return RemoveAccessAsync(name, doAsync: true, cancellationToken);
	}

	private async Task<string> GetMetadataAsync(MetadataTag tag, bool doAsync, CancellationToken cancellationToken)
	{
		CheckState(open: false, rw: false);
		if ((Engine.Capabilities & ImapCapabilities.Metadata) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the METADATA extension.");
		}
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, null, "GETMETADATA %F %S\r\n", this, tag.Id);
		ic.RegisterUntaggedHandler("METADATA", ImapUtils.ParseMetadataAsync);
		MetadataCollection metadata = (MetadataCollection)(ic.UserData = new MetadataCollection());
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("GETMETADATA", ic);
		}
		string result = null;
		for (int i = 0; i < metadata.Count; i++)
		{
			if (metadata[i].EncodedName == EncodedName && metadata[i].Tag.Id == tag.Id)
			{
				result = metadata[i].Value;
				metadata.RemoveAt(i);
				break;
			}
		}
		Engine.ProcessMetadataChanges(metadata);
		return result;
	}

	public override string GetMetadata(MetadataTag tag, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMetadataAsync(tag, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<string> GetMetadataAsync(MetadataTag tag, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMetadataAsync(tag, doAsync: true, cancellationToken);
	}

	private async Task<MetadataCollection> GetMetadataAsync(MetadataOptions options, IEnumerable<MetadataTag> tags, bool doAsync, CancellationToken cancellationToken)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (tags == null)
		{
			throw new ArgumentNullException("tags");
		}
		CheckState(open: false, rw: false);
		if ((Engine.Capabilities & ImapCapabilities.Metadata) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the METADATA extension.");
		}
		StringBuilder stringBuilder = new StringBuilder("GETMETADATA %F");
		List<object> list = new List<object>();
		bool flag = false;
		if (options.MaxSize.HasValue || options.Depth != 0)
		{
			stringBuilder.Append(" (");
			if (options.MaxSize.HasValue)
			{
				stringBuilder.AppendFormat("MAXSIZE {0} ", options.MaxSize.Value);
			}
			if (options.Depth > 0)
			{
				stringBuilder.AppendFormat("DEPTH {0} ", (options.Depth == int.MaxValue) ? "infinity" : "1");
			}
			stringBuilder[stringBuilder.Length - 1] = ')';
			stringBuilder.Append(' ');
			flag = true;
		}
		list.Add(this);
		int length = stringBuilder.Length;
		foreach (MetadataTag tag in tags)
		{
			stringBuilder.Append(" %S");
			list.Add(tag.Id);
		}
		if (flag)
		{
			stringBuilder[length] = '(';
			stringBuilder.Append(')');
		}
		stringBuilder.Append("\r\n");
		if (list.Count == 1)
		{
			return new MetadataCollection();
		}
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, null, stringBuilder.ToString(), list.ToArray());
		ic.RegisterUntaggedHandler("METADATA", ImapUtils.ParseMetadataAsync);
		ic.UserData = new MetadataCollection();
		options.LongEntries = 0u;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("GETMETADATA", ic);
		}
		MetadataResponseCode metadataResponseCode = (MetadataResponseCode)ic.GetResponseCode(ImapResponseCodeType.Metadata);
		if (metadataResponseCode != null && metadataResponseCode.SubType == MetadataResponseCodeSubType.LongEntries)
		{
			options.LongEntries = metadataResponseCode.Value;
		}
		return Engine.FilterMetadata((MetadataCollection)ic.UserData, EncodedName);
	}

	public override MetadataCollection GetMetadata(MetadataOptions options, IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMetadataAsync(options, tags, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<MetadataCollection> GetMetadataAsync(MetadataOptions options, IEnumerable<MetadataTag> tags, CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetMetadataAsync(options, tags, doAsync: true, cancellationToken);
	}

	private async Task SetMetadataAsync(MetadataCollection metadata, bool doAsync, CancellationToken cancellationToken)
	{
		if (metadata == null)
		{
			throw new ArgumentNullException("metadata");
		}
		CheckState(open: false, rw: false);
		if ((Engine.Capabilities & ImapCapabilities.Metadata) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the METADATA extension.");
		}
		if (metadata.Count == 0)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder("SETMETADATA %F (");
		List<object> list = new List<object>();
		list.Add(this);
		for (int i = 0; i < metadata.Count; i++)
		{
			if (i > 0)
			{
				stringBuilder.Append(' ');
			}
			if (metadata[i].Value != null)
			{
				stringBuilder.Append("%S %S");
				list.Add(metadata[i].Tag.Id);
				list.Add(metadata[i].Value);
			}
			else
			{
				stringBuilder.Append("%S NIL");
				list.Add(metadata[i].Tag.Id);
			}
		}
		stringBuilder.Append(")\r\n");
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, null, stringBuilder.ToString(), list.ToArray());
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response == ImapCommandResponse.Ok)
		{
			return;
		}
		throw ImapCommandException.Create("SETMETADATA", ic);
	}

	public override void SetMetadata(MetadataCollection metadata, CancellationToken cancellationToken = default(CancellationToken))
	{
		SetMetadataAsync(metadata, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task SetMetadataAsync(MetadataCollection metadata, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetMetadataAsync(metadata, doAsync: true, cancellationToken);
	}

	private static async Task UntaggedQuotaRootAsync(ImapEngine engine, ImapCommand ic, int index, bool doAsync)
	{
		string format = string.Format("Syntax error in untagged {0} response. {1}", "QUOTAROOT", "{0}");
		QuotaContext ctx = (QuotaContext)ic.UserData;
		await ReadStringTokenAsync(engine, format, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		ImapToken imapToken = await engine.PeekTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		while (imapToken.Type != ImapTokenType.Eoln)
		{
			string item = await ReadStringTokenAsync(engine, format, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			ctx.QuotaRoots.Add(item);
			imapToken = await engine.PeekTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
	}

	private static async Task UntaggedQuotaAsync(ImapEngine engine, ImapCommand ic, int index, bool doAsync)
	{
		string format = string.Format("Syntax error in untagged {0} response. {1}", "QUOTA", "{0}");
		string quotaRoot = await ReadStringTokenAsync(engine, format, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		QuotaContext ctx = (QuotaContext)ic.UserData;
		Quota quota = new Quota();
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, format, imapToken);
		while (imapToken.Type != ImapTokenType.CloseParen)
		{
			imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, format, imapToken);
			string resource = (string)imapToken.Value;
			imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			uint used = ImapEngine.ParseNumber(imapToken, false, format, imapToken);
			imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			uint value = ImapEngine.ParseNumber(imapToken, false, format, imapToken);
			string text = resource.ToUpperInvariant();
			if (!(text == "MESSAGE"))
			{
				if (text == "STORAGE")
				{
					quota.CurrentStorageSize = used;
					quota.StorageLimit = value;
				}
			}
			else
			{
				quota.CurrentMessageCount = used;
				quota.MessageLimit = value;
			}
			imapToken = await engine.PeekTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		ctx.Quotas[quotaRoot] = quota;
	}

	private async Task<FolderQuota> GetQuotaAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckState(open: false, rw: false);
		if ((Engine.Capabilities & ImapCapabilities.Quota) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the QUOTA extension.");
		}
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, null, "GETQUOTAROOT %F\r\n", this);
		QuotaContext ctx = new QuotaContext();
		ic.RegisterUntaggedHandler("QUOTAROOT", UntaggedQuotaRootAsync);
		ic.RegisterUntaggedHandler("QUOTA", UntaggedQuotaAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("GETQUOTAROOT", ic);
		}
		for (int i = 0; i < ctx.QuotaRoots.Count; i++)
		{
			string text = ctx.QuotaRoots[i];
			if (ctx.Quotas.TryGetValue(text, out var quota))
			{
				return new FolderQuota(await Engine.GetQuotaRootFolderAsync(text, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false))
				{
					CurrentMessageCount = quota.CurrentMessageCount,
					CurrentStorageSize = quota.CurrentStorageSize,
					MessageLimit = quota.MessageLimit,
					StorageLimit = quota.StorageLimit
				};
			}
		}
		return new FolderQuota(null);
	}

	public override FolderQuota GetQuota(CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetQuotaAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<FolderQuota> GetQuotaAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return GetQuotaAsync(doAsync: true, cancellationToken);
	}

	private async Task<FolderQuota> SetQuotaAsync(uint? messageLimit, uint? storageLimit, bool doAsync, CancellationToken cancellationToken)
	{
		CheckState(open: false, rw: false);
		if ((Engine.Capabilities & ImapCapabilities.Quota) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the QUOTA extension.");
		}
		StringBuilder stringBuilder = new StringBuilder("SETQUOTA %F (");
		if (messageLimit.HasValue)
		{
			stringBuilder.AppendFormat("MESSAGE {0} ", messageLimit.Value);
		}
		if (storageLimit.HasValue)
		{
			stringBuilder.AppendFormat("STORAGE {0} ", storageLimit.Value);
		}
		stringBuilder[stringBuilder.Length - 1] = ')';
		stringBuilder.Append("\r\n");
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, null, stringBuilder.ToString(), this);
		QuotaContext ctx = new QuotaContext();
		ic.RegisterUntaggedHandler("QUOTA", UntaggedQuotaAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("SETQUOTA", ic);
		}
		if (ctx.Quotas.TryGetValue(EncodedName, out var value))
		{
			return new FolderQuota(this)
			{
				CurrentMessageCount = value.CurrentMessageCount,
				CurrentStorageSize = value.CurrentStorageSize,
				MessageLimit = value.MessageLimit,
				StorageLimit = value.StorageLimit
			};
		}
		return new FolderQuota(null);
	}

	public override FolderQuota SetQuota(uint? messageLimit, uint? storageLimit, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetQuotaAsync(messageLimit, storageLimit, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<FolderQuota> SetQuotaAsync(uint? messageLimit, uint? storageLimit, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SetQuotaAsync(messageLimit, storageLimit, doAsync: true, cancellationToken);
	}

	private async Task ExpungeAsync(bool doAsync, CancellationToken cancellationToken)
	{
		CheckState(open: true, rw: true);
		ImapCommand ic = Engine.QueueCommand(cancellationToken, this, "EXPUNGE\r\n");
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("EXPUNGE", ic);
		}
	}

	public override void Expunge(CancellationToken cancellationToken = default(CancellationToken))
	{
		ExpungeAsync(doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task ExpungeAsync(CancellationToken cancellationToken = default(CancellationToken))
	{
		return ExpungeAsync(doAsync: true, cancellationToken);
	}

	private async Task ExpungeAsync(IList<UniqueId> uids, bool doAsync, CancellationToken cancellationToken)
	{
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		CheckState(open: true, rw: true);
		if (uids.Count == 0)
		{
			return;
		}
		if ((Engine.Capabilities & ImapCapabilities.UidPlus) == ImapCapabilities.None)
		{
			BinarySearchQuery query = SearchQuery.Deleted.And(SearchQuery.Not(SearchQuery.Uids(uids)));
			IList<UniqueId> unmark = await SearchAsync(query, doAsync, retry: false, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (unmark.Count > 0)
			{
				await ModifyFlagsAsync(unmark, null, MessageFlags.Deleted, null, "-FLAGS.SILENT", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			await ExpungeAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (unmark.Count > 0)
			{
				await ModifyFlagsAsync(unmark, null, MessageFlags.Deleted, null, "+FLAGS.SILENT", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			return;
		}
		foreach (ImapCommand ic in Engine.QueueCommands(cancellationToken, this, "UID EXPUNGE %s\r\n", uids))
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("EXPUNGE", ic);
			}
		}
	}

	public override void Expunge(IList<UniqueId> uids, CancellationToken cancellationToken = default(CancellationToken))
	{
		ExpungeAsync(uids, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task ExpungeAsync(IList<UniqueId> uids, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ExpungeAsync(uids, doAsync: true, cancellationToken);
	}

	private ImapCommand QueueAppend(FormatOptions options, MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, CancellationToken cancellationToken, ITransferProgress progress)
	{
		StringBuilder stringBuilder = new StringBuilder("APPEND %F ");
		List<object> list = new List<object>();
		list.Add(this);
		if ((flags & MailFolder.SettableFlags) != MessageFlags.None)
		{
			stringBuilder.AppendFormat("{0} ", ImapUtils.FormatFlagsList(flags, 0));
		}
		if (date.HasValue)
		{
			stringBuilder.AppendFormat("\"{0}\" ", ImapUtils.FormatInternalDate(date.Value));
		}
		if (annotations != null && annotations.Count > 0)
		{
			ImapUtils.FormatAnnotations(stringBuilder, annotations, list, throwOnError: false);
			if (stringBuilder[stringBuilder.Length - 1] != ' ')
			{
				stringBuilder.Append(' ');
			}
		}
		stringBuilder.Append("%L\r\n");
		list.Add(message);
		string format = stringBuilder.ToString();
		object[] args = list.ToArray();
		ImapCommand imapCommand = new ImapCommand(Engine, cancellationToken, null, options, format, args);
		imapCommand.Progress = progress;
		Engine.QueueCommand(imapCommand);
		return imapCommand;
	}

	private async Task<UniqueId?> AppendAsync(FormatOptions options, MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		CheckState(open: false, rw: false);
		if (options.International && (Engine.Capabilities & ImapCapabilities.UTF8Accept) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the UTF8 extension.");
		}
		FormatOptions formatOptions = options.Clone();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		formatOptions.EnsureNewLine = true;
		if ((Engine.Capabilities & ImapCapabilities.UTF8Only) == ImapCapabilities.UTF8Only)
		{
			formatOptions.International = true;
		}
		if (formatOptions.International && !Engine.UTF8Enabled)
		{
			throw new InvalidOperationException("The UTF8 extension has not been enabled.");
		}
		ImapCommand ic = QueueAppend(formatOptions, message, flags, date, annotations, cancellationToken, progress);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, this);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("APPEND", ic);
		}
		return ((AppendUidResponseCode)ic.GetResponseCode(ImapResponseCodeType.AppendUid))?.UidSet[0];
	}

	public override UniqueId? Append(FormatOptions options, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(options, message, flags, null, null, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<UniqueId?> AppendAsync(FormatOptions options, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(options, message, flags, null, null, doAsync: true, cancellationToken, progress);
	}

	public override UniqueId? Append(FormatOptions options, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(options, message, flags, date, null, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<UniqueId?> AppendAsync(FormatOptions options, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(options, message, flags, date, null, doAsync: true, cancellationToken, progress);
	}

	public override UniqueId? Append(FormatOptions options, MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(options, message, flags, date, annotations, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<UniqueId?> AppendAsync(FormatOptions options, MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(options, message, flags, date, annotations, doAsync: true, cancellationToken, progress);
	}

	private ImapCommand QueueMultiAppend(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, IList<DateTimeOffset> dates, IList<IList<Annotation>> annotations, CancellationToken cancellationToken, ITransferProgress progress)
	{
		StringBuilder stringBuilder = new StringBuilder("APPEND %F");
		List<object> list = new List<object>();
		list.Add(this);
		for (int i = 0; i < messages.Count; i++)
		{
			stringBuilder.Append(' ');
			if ((flags[i] & MailFolder.SettableFlags) != MessageFlags.None)
			{
				stringBuilder.AppendFormat("{0} ", ImapUtils.FormatFlagsList(flags[i], 0));
			}
			if (dates != null)
			{
				stringBuilder.AppendFormat("\"{0}\" ", ImapUtils.FormatInternalDate(dates[i]));
			}
			stringBuilder.Append("%L");
			list.Add(messages[i]);
		}
		stringBuilder.Append("\r\n");
		string format = stringBuilder.ToString();
		object[] args = list.ToArray();
		ImapCommand imapCommand = new ImapCommand(Engine, cancellationToken, null, options, format, args);
		imapCommand.Progress = progress;
		Engine.QueueCommand(imapCommand);
		return imapCommand;
	}

	private async Task<IList<UniqueId>> AppendAsync(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (messages == null)
		{
			throw new ArgumentNullException("messages");
		}
		for (int i = 0; i < messages.Count; i++)
		{
			if (messages[i] == null)
			{
				throw new ArgumentException("One or more of the messages is null.");
			}
		}
		if (flags == null)
		{
			throw new ArgumentNullException("flags");
		}
		if (messages.Count != flags.Count)
		{
			throw new ArgumentException("The number of messages and the number of flags must be equal.");
		}
		CheckState(open: false, rw: false);
		if (options.International && (Engine.Capabilities & ImapCapabilities.UTF8Accept) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the UTF8 extension.");
		}
		FormatOptions format = options.Clone();
		format.NewLineFormat = NewLineFormat.Dos;
		format.EnsureNewLine = true;
		if ((Engine.Capabilities & ImapCapabilities.UTF8Only) == ImapCapabilities.UTF8Only)
		{
			format.International = true;
		}
		if (format.International && !Engine.UTF8Enabled)
		{
			throw new InvalidOperationException("The UTF8 extension has not been enabled.");
		}
		if (messages.Count == 0)
		{
			return new UniqueId[0];
		}
		if ((Engine.Capabilities & ImapCapabilities.MultiAppend) != ImapCapabilities.None)
		{
			ImapCommand ic = QueueMultiAppend(format, messages, flags, null, null, cancellationToken, progress);
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, this);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("APPEND", ic);
			}
			AppendUidResponseCode appendUidResponseCode = (AppendUidResponseCode)ic.GetResponseCode(ImapResponseCodeType.AppendUid);
			if (appendUidResponseCode != null)
			{
				return appendUidResponseCode.UidSet;
			}
			return new UniqueId[0];
		}
		List<UniqueId> uids = new List<UniqueId>();
		for (int j = 0; j < messages.Count; j++)
		{
			UniqueId? uniqueId = await AppendAsync(format, messages[j], flags[j], null, null, doAsync, cancellationToken, progress).ConfigureAwait(continueOnCapturedContext: false);
			if (uids != null && uniqueId.HasValue)
			{
				uids.Add(uniqueId.Value);
			}
			else
			{
				uids = null;
			}
		}
		if (uids == null)
		{
			return new UniqueId[0];
		}
		return uids;
	}

	public override IList<UniqueId> Append(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(options, messages, flags, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<IList<UniqueId>> AppendAsync(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(options, messages, flags, doAsync: true, cancellationToken, progress);
	}

	private async Task<IList<UniqueId>> AppendAsync(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, IList<DateTimeOffset> dates, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (messages == null)
		{
			throw new ArgumentNullException("messages");
		}
		for (int i = 0; i < messages.Count; i++)
		{
			if (messages[i] == null)
			{
				throw new ArgumentException("One or more of the messages is null.");
			}
		}
		if (flags == null)
		{
			throw new ArgumentNullException("flags");
		}
		if (dates == null)
		{
			throw new ArgumentNullException("dates");
		}
		if (messages.Count != flags.Count || messages.Count != dates.Count)
		{
			throw new ArgumentException("The number of messages, the number of flags, and the number of dates must be equal.");
		}
		CheckState(open: false, rw: false);
		if (options.International && (Engine.Capabilities & ImapCapabilities.UTF8Accept) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the UTF8 extension.");
		}
		FormatOptions format = options.Clone();
		format.NewLineFormat = NewLineFormat.Dos;
		format.EnsureNewLine = true;
		if ((Engine.Capabilities & ImapCapabilities.UTF8Only) == ImapCapabilities.UTF8Only)
		{
			format.International = true;
		}
		if (format.International && !Engine.UTF8Enabled)
		{
			throw new InvalidOperationException("The UTF8 extension has not been enabled.");
		}
		if (messages.Count == 0)
		{
			return new UniqueId[0];
		}
		if ((Engine.Capabilities & ImapCapabilities.MultiAppend) != ImapCapabilities.None)
		{
			ImapCommand ic = QueueMultiAppend(format, messages, flags, dates, null, cancellationToken, progress);
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("APPEND", ic);
			}
			AppendUidResponseCode appendUidResponseCode = (AppendUidResponseCode)ic.GetResponseCode(ImapResponseCodeType.AppendUid);
			if (appendUidResponseCode != null)
			{
				return appendUidResponseCode.UidSet;
			}
			return new UniqueId[0];
		}
		List<UniqueId> uids = new List<UniqueId>();
		for (int j = 0; j < messages.Count; j++)
		{
			UniqueId? uniqueId = await AppendAsync(format, messages[j], flags[j], dates[j], null, doAsync, cancellationToken, progress).ConfigureAwait(continueOnCapturedContext: false);
			if (uids != null && uniqueId.HasValue)
			{
				uids.Add(uniqueId.Value);
			}
			else
			{
				uids = null;
			}
		}
		if (uids == null)
		{
			return new UniqueId[0];
		}
		return uids;
	}

	public override IList<UniqueId> Append(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, IList<DateTimeOffset> dates, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(options, messages, flags, dates, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<IList<UniqueId>> AppendAsync(FormatOptions options, IList<MimeMessage> messages, IList<MessageFlags> flags, IList<DateTimeOffset> dates, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return AppendAsync(options, messages, flags, dates, doAsync: true, cancellationToken, progress);
	}

	private ImapCommand QueueReplace(FormatOptions options, UniqueId uid, MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, CancellationToken cancellationToken, ITransferProgress progress)
	{
		StringBuilder stringBuilder = new StringBuilder($"UID REPLACE {uid} %F ");
		List<object> list = new List<object>();
		list.Add(this);
		if ((flags & MailFolder.SettableFlags) != MessageFlags.None)
		{
			stringBuilder.AppendFormat("{0} ", ImapUtils.FormatFlagsList(flags, 0));
		}
		if (date.HasValue)
		{
			stringBuilder.AppendFormat("\"{0}\" ", ImapUtils.FormatInternalDate(date.Value));
		}
		stringBuilder.Append("%L\r\n");
		list.Add(message);
		string format = stringBuilder.ToString();
		object[] args = list.ToArray();
		ImapCommand imapCommand = new ImapCommand(Engine, cancellationToken, null, options, format, args);
		imapCommand.Progress = progress;
		Engine.QueueCommand(imapCommand);
		return imapCommand;
	}

	private async Task<UniqueId?> ReplaceAsync(FormatOptions options, UniqueId uid, MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (!uid.IsValid)
		{
			throw new ArgumentException("The uid is invalid.", "uid");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		CheckState(open: true, rw: true);
		if ((Engine.Capabilities & ImapCapabilities.Replace) == ImapCapabilities.None)
		{
			UniqueId? appended = await AppendAsync(options, message, flags, date, annotations, doAsync, cancellationToken, progress).ConfigureAwait(continueOnCapturedContext: false);
			await ModifyFlagsAsync(new UniqueId[1] { uid }, null, MessageFlags.Deleted, null, "+FLAGS.SILENT", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if ((Engine.Capabilities & ImapCapabilities.UidPlus) != ImapCapabilities.None)
			{
				await ExpungeAsync(new UniqueId[1] { uid }, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			return appended;
		}
		if (options.International && (Engine.Capabilities & ImapCapabilities.UTF8Accept) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the UTF8 extension.");
		}
		FormatOptions formatOptions = options.Clone();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		formatOptions.EnsureNewLine = true;
		if ((Engine.Capabilities & ImapCapabilities.UTF8Only) == ImapCapabilities.UTF8Only)
		{
			formatOptions.International = true;
		}
		if (formatOptions.International && !Engine.UTF8Enabled)
		{
			throw new InvalidOperationException("The UTF8 extension has not been enabled.");
		}
		ImapCommand ic = QueueReplace(formatOptions, uid, message, flags, date, annotations, cancellationToken, progress);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, this);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("REPLACE", ic);
		}
		return ((AppendUidResponseCode)ic.GetResponseCode(ImapResponseCodeType.AppendUid))?.UidSet[0];
	}

	public override UniqueId? Replace(FormatOptions options, UniqueId uid, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return ReplaceAsync(options, uid, message, flags, null, null, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<UniqueId?> ReplaceAsync(FormatOptions options, UniqueId uid, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return ReplaceAsync(options, uid, message, flags, null, null, doAsync: true, cancellationToken, progress);
	}

	public override UniqueId? Replace(FormatOptions options, UniqueId uid, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return ReplaceAsync(options, uid, message, flags, date, null, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<UniqueId?> ReplaceAsync(FormatOptions options, UniqueId uid, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return ReplaceAsync(options, uid, message, flags, date, null, doAsync: true, cancellationToken, progress);
	}

	private ImapCommand QueueReplace(FormatOptions options, int index, MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, CancellationToken cancellationToken, ITransferProgress progress)
	{
		StringBuilder stringBuilder = new StringBuilder("REPLACE %d %F ");
		List<object> list = new List<object>();
		list.Add(index + 1);
		list.Add(this);
		if ((flags & MailFolder.SettableFlags) != MessageFlags.None)
		{
			stringBuilder.AppendFormat("{0} ", ImapUtils.FormatFlagsList(flags, 0));
		}
		if (date.HasValue)
		{
			stringBuilder.AppendFormat("\"{0}\" ", ImapUtils.FormatInternalDate(date.Value));
		}
		stringBuilder.Append("%L\r\n");
		list.Add(message);
		string format = stringBuilder.ToString();
		object[] args = list.ToArray();
		ImapCommand imapCommand = new ImapCommand(Engine, cancellationToken, null, options, format, args);
		imapCommand.Progress = progress;
		Engine.QueueCommand(imapCommand);
		return imapCommand;
	}

	private async Task<UniqueId?> ReplaceAsync(FormatOptions options, int index, MimeMessage message, MessageFlags flags, DateTimeOffset? date, IList<Annotation> annotations, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (index < 0 || index >= base.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		CheckState(open: true, rw: true);
		if ((Engine.Capabilities & ImapCapabilities.Replace) == ImapCapabilities.None)
		{
			UniqueId? uid = await AppendAsync(options, message, flags, date, annotations, doAsync, cancellationToken, progress).ConfigureAwait(continueOnCapturedContext: false);
			await ModifyFlagsAsync(new int[1] { index }, null, MessageFlags.Deleted, null, "+FLAGS.SILENT", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			return uid;
		}
		if (options.International && (Engine.Capabilities & ImapCapabilities.UTF8Accept) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the UTF8 extension.");
		}
		FormatOptions formatOptions = options.Clone();
		formatOptions.NewLineFormat = NewLineFormat.Dos;
		formatOptions.EnsureNewLine = true;
		if ((Engine.Capabilities & ImapCapabilities.UTF8Only) == ImapCapabilities.UTF8Only)
		{
			formatOptions.International = true;
		}
		if (formatOptions.International && !Engine.UTF8Enabled)
		{
			throw new InvalidOperationException("The UTF8 extension has not been enabled.");
		}
		ImapCommand ic = QueueReplace(formatOptions, index, message, flags, date, annotations, cancellationToken, progress);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, this);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("REPLACE", ic);
		}
		return ((AppendUidResponseCode)ic.GetResponseCode(ImapResponseCodeType.AppendUid))?.UidSet[0];
	}

	public override UniqueId? Replace(FormatOptions options, int index, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return ReplaceAsync(options, index, message, flags, null, null, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<UniqueId?> ReplaceAsync(FormatOptions options, int index, MimeMessage message, MessageFlags flags = MessageFlags.None, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return ReplaceAsync(options, index, message, flags, null, null, doAsync: true, cancellationToken, progress);
	}

	public override UniqueId? Replace(FormatOptions options, int index, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return ReplaceAsync(options, index, message, flags, date, null, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<UniqueId?> ReplaceAsync(FormatOptions options, int index, MimeMessage message, MessageFlags flags, DateTimeOffset date, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return ReplaceAsync(options, index, message, flags, date, null, doAsync: true, cancellationToken, progress);
	}

	private async Task<IList<int>> GetIndexesAsync(IList<UniqueId> uids, bool doAsync, CancellationToken cancellationToken)
	{
		string format = $"SEARCH UID {UniqueIdSet.ToString(uids)}\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		SearchResults results = new SearchResults(SortOrder.Ascending);
		if ((Engine.Capabilities & ImapCapabilities.ESearch) != ImapCapabilities.None)
		{
			ic.RegisterUntaggedHandler("ESEARCH", ESearchMatchesAsync);
		}
		ic.RegisterUntaggedHandler("SEARCH", SearchMatchesAsync);
		ic.UserData = results;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("SEARCH", ic);
		}
		int[] array = new int[results.UniqueIds.Count];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (int)(results.UniqueIds[i].Id - 1);
		}
		return array;
	}

	private async Task<UniqueIdMap> CopyToAsync(IList<UniqueId> uids, IMailFolder destination, bool doAsync, CancellationToken cancellationToken)
	{
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (!(destination is ImapFolder) || ((ImapFolder)destination).Engine != Engine)
		{
			throw new ArgumentException("The destination folder does not belong to this ImapClient.", "destination");
		}
		CheckState(open: true, rw: false);
		if (uids.Count == 0)
		{
			return UniqueIdMap.Empty;
		}
		if ((Engine.Capabilities & ImapCapabilities.UidPlus) == ImapCapabilities.None)
		{
			await CopyToAsync(await GetIndexesAsync(uids, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false), destination, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			return UniqueIdMap.Empty;
		}
		UniqueIdSet dest = null;
		UniqueIdSet src = null;
		foreach (ImapCommand ic in Engine.QueueCommands(cancellationToken, this, "UID COPY %s %F\r\n", uids, destination))
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, destination);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("COPY", ic);
			}
			CopyUidResponseCode copyUidResponseCode = (CopyUidResponseCode)ic.GetResponseCode(ImapResponseCodeType.CopyUid);
			if (copyUidResponseCode != null)
			{
				if (dest == null)
				{
					dest = copyUidResponseCode.DestUidSet;
					src = copyUidResponseCode.SrcUidSet;
				}
				else
				{
					dest.AddRange(copyUidResponseCode.DestUidSet);
					src.AddRange(copyUidResponseCode.SrcUidSet);
				}
			}
		}
		if (dest == null)
		{
			return UniqueIdMap.Empty;
		}
		return new UniqueIdMap(src, dest);
	}

	public override UniqueIdMap CopyTo(IList<UniqueId> uids, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		return CopyToAsync(uids, destination, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<UniqueIdMap> CopyToAsync(IList<UniqueId> uids, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		return CopyToAsync(uids, destination, doAsync: true, cancellationToken);
	}

	private async Task<UniqueIdMap> MoveToAsync(IList<UniqueId> uids, IMailFolder destination, bool doAsync, CancellationToken cancellationToken)
	{
		if ((Engine.Capabilities & ImapCapabilities.Move) == ImapCapabilities.None)
		{
			UniqueIdMap copied = await CopyToAsync(uids, destination, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			await ModifyFlagsAsync(uids, null, MessageFlags.Deleted, null, "+FLAGS.SILENT", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			await ExpungeAsync(uids, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			return copied;
		}
		if ((Engine.Capabilities & ImapCapabilities.UidPlus) == ImapCapabilities.None)
		{
			await MoveToAsync(await GetIndexesAsync(uids, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false), destination, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			return UniqueIdMap.Empty;
		}
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (!(destination is ImapFolder) || ((ImapFolder)destination).Engine != Engine)
		{
			throw new ArgumentException("The destination folder does not belong to this ImapClient.", "destination");
		}
		CheckState(open: true, rw: true);
		if (uids.Count == 0)
		{
			return UniqueIdMap.Empty;
		}
		UniqueIdSet dest = null;
		UniqueIdSet src = null;
		foreach (ImapCommand ic in Engine.QueueCommands(cancellationToken, this, "UID MOVE %s %F\r\n", uids, destination))
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, destination);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("MOVE", ic);
			}
			CopyUidResponseCode copyUidResponseCode = (CopyUidResponseCode)ic.GetResponseCode(ImapResponseCodeType.CopyUid);
			if (copyUidResponseCode != null)
			{
				if (dest == null)
				{
					dest = copyUidResponseCode.DestUidSet;
					src = copyUidResponseCode.SrcUidSet;
				}
				else
				{
					dest.AddRange(copyUidResponseCode.DestUidSet);
					src.AddRange(copyUidResponseCode.SrcUidSet);
				}
			}
		}
		if (dest == null)
		{
			return UniqueIdMap.Empty;
		}
		return new UniqueIdMap(src, dest);
	}

	public override UniqueIdMap MoveTo(IList<UniqueId> uids, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		return MoveToAsync(uids, destination, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<UniqueIdMap> MoveToAsync(IList<UniqueId> uids, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		return MoveToAsync(uids, destination, doAsync: true, cancellationToken);
	}

	private async Task CopyToAsync(IList<int> indexes, IMailFolder destination, bool doAsync, CancellationToken cancellationToken)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (!(destination is ImapFolder) || ((ImapFolder)destination).Engine != Engine)
		{
			throw new ArgumentException("The destination folder does not belong to this ImapClient.", "destination");
		}
		CheckState(open: true, rw: false);
		CheckAllowIndexes();
		if (indexes.Count != 0)
		{
			string arg = ImapUtils.FormatIndexSet(Engine, indexes);
			string format = $"COPY {arg} %F\r\n";
			ImapCommand ic = Engine.QueueCommand(cancellationToken, this, format, destination);
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, destination);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("COPY", ic);
			}
		}
	}

	public override void CopyTo(IList<int> indexes, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		CopyToAsync(indexes, destination, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task CopyToAsync(IList<int> indexes, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		return CopyToAsync(indexes, destination, doAsync: true, cancellationToken);
	}

	private async Task MoveToAsync(IList<int> indexes, IMailFolder destination, bool doAsync, CancellationToken cancellationToken)
	{
		if ((Engine.Capabilities & ImapCapabilities.Move) == ImapCapabilities.None)
		{
			await CopyToAsync(indexes, destination, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			await ModifyFlagsAsync(indexes, null, MessageFlags.Deleted, null, "+FLAGS.SILENT", doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			return;
		}
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (!(destination is ImapFolder) || ((ImapFolder)destination).Engine != Engine)
		{
			throw new ArgumentException("The destination folder does not belong to this ImapClient.", "destination");
		}
		CheckState(open: true, rw: true);
		CheckAllowIndexes();
		if (indexes.Count != 0)
		{
			string arg = ImapUtils.FormatIndexSet(Engine, indexes);
			string format = $"MOVE {arg} %F\r\n";
			ImapCommand ic = Engine.QueueCommand(cancellationToken, this, format, destination);
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, destination);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("MOVE", ic);
			}
		}
	}

	public override void MoveTo(IList<int> indexes, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		MoveToAsync(indexes, destination, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task MoveToAsync(IList<int> indexes, IMailFolder destination, CancellationToken cancellationToken = default(CancellationToken))
	{
		return MoveToAsync(indexes, destination, doAsync: true, cancellationToken);
	}

	public override IEnumerator<MimeMessage> GetEnumerator()
	{
		CheckState(open: true, rw: false);
		for (int i = 0; i < base.Count; i++)
		{
			yield return GetMessage(i, CancellationToken.None);
		}
	}

	internal void OnExists(int count)
	{
		if (base.Count != count)
		{
			base.Count = count;
			OnCountChanged();
		}
	}

	internal void OnExpunge(int index)
	{
		base.Count--;
		OnMessageExpunged(new MessageEventArgs(index));
		OnCountChanged();
	}

	internal async Task OnFetchAsync(ImapEngine engine, int index, bool doAsync, CancellationToken cancellationToken)
	{
		MessageSummary message = new MessageSummary(this, index);
		UniqueId? uid = null;
		await FetchSummaryItemsAsync(engine, message, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if ((message.Fields & MessageSummaryItems.UniqueId) != MessageSummaryItems.None)
		{
			uid = message.UniqueId;
		}
		if ((message.Fields & MessageSummaryItems.Flags) != MessageSummaryItems.None)
		{
			MessageFlagsChangedEventArgs e = new MessageFlagsChangedEventArgs(index, message.Flags.Value, message.Keywords);
			e.ModSeq = message.ModSeq;
			e.UniqueId = uid;
			OnMessageFlagsChanged(e);
		}
		if ((message.Fields & MessageSummaryItems.GMailLabels) != MessageSummaryItems.None)
		{
			MessageLabelsChangedEventArgs e2 = new MessageLabelsChangedEventArgs(index, message.GMailLabels);
			e2.ModSeq = message.ModSeq;
			e2.UniqueId = uid;
			OnMessageLabelsChanged(e2);
		}
		if ((message.Fields & MessageSummaryItems.Annotations) != MessageSummaryItems.None)
		{
			AnnotationsChangedEventArgs e3 = new AnnotationsChangedEventArgs(index, message.Annotations);
			e3.ModSeq = message.ModSeq;
			e3.UniqueId = uid;
			OnAnnotationsChanged(e3);
		}
		if ((message.Fields & MessageSummaryItems.ModSeq) != MessageSummaryItems.None)
		{
			ModSeqChangedEventArgs e4 = new ModSeqChangedEventArgs(index, message.ModSeq.Value);
			e4.UniqueId = uid;
			OnModSeqChanged(e4);
		}
		if (message.Fields != MessageSummaryItems.None)
		{
			OnMessageSummaryFetched(message);
		}
	}

	internal void OnRecent(int count)
	{
		if (base.Recent != count)
		{
			base.Recent = count;
			OnRecentChanged();
		}
	}

	internal async Task OnVanishedAsync(ImapEngine engine, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		bool earlier = false;
		if (imapToken.Type == ImapTokenType.OpenParen)
		{
			while (true)
			{
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (imapToken.Type == ImapTokenType.CloseParen)
				{
					break;
				}
				ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "VANISHED", imapToken);
				string text = (string)imapToken.Value;
				if (text == "EARLIER")
				{
					earlier = true;
				}
			}
			imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		UniqueIdSet uniqueIdSet = ImapEngine.ParseUidSet(imapToken, base.UidValidity, "Syntax error in untagged {0} response. {1}", "VANISHED", imapToken);
		OnMessagesVanished(new MessagesVanishedEventArgs(uniqueIdSet, earlier));
		if (!earlier)
		{
			base.Count -= uniqueIdSet.Count;
			OnCountChanged();
		}
	}

	internal void UpdateAttributes(FolderAttributes attrs)
	{
		bool flag = false;
		bool flag2 = false;
		if ((attrs & FolderAttributes.Subscribed) == 0)
		{
			flag = (base.Attributes & FolderAttributes.Subscribed) != 0;
		}
		else
		{
			flag2 = (base.Attributes & FolderAttributes.Subscribed) == 0;
		}
		bool flag3 = (attrs & FolderAttributes.NonExistent) != FolderAttributes.None && (base.Attributes & FolderAttributes.NonExistent) == 0;
		base.Attributes = attrs;
		if (flag)
		{
			OnUnsubscribed();
		}
		if (flag2)
		{
			OnSubscribed();
		}
		if (flag3)
		{
			OnDeleted();
		}
	}

	internal void UpdateAcceptedFlags(MessageFlags flags)
	{
		base.AcceptedFlags = flags;
	}

	internal void UpdatePermanentFlags(MessageFlags flags)
	{
		base.PermanentFlags = flags;
	}

	internal void UpdateIsNamespace(bool value)
	{
		base.IsNamespace = value;
	}

	internal void UpdateUnread(int count)
	{
		if (base.Unread != count)
		{
			base.Unread = count;
			OnUnreadChanged();
		}
	}

	internal void UpdateUidNext(UniqueId uid)
	{
		if (!base.UidNext.HasValue || !(base.UidNext.Value == uid))
		{
			base.UidNext = uid;
			OnUidNextChanged();
		}
	}

	internal void UpdateAppendLimit(uint? limit)
	{
		base.AppendLimit = limit;
	}

	internal void UpdateSize(ulong? size)
	{
		if (base.Size != size)
		{
			base.Size = size;
			OnSizeChanged();
		}
	}

	internal void UpdateId(string id)
	{
		if (!(base.Id == id))
		{
			base.Id = id;
			OnIdChanged();
		}
	}

	internal void UpdateHighestModSeq(ulong modseq)
	{
		if (base.HighestModSeq != modseq)
		{
			base.HighestModSeq = modseq;
			OnHighestModSeqChanged();
		}
	}

	internal void UpdateUidValidity(uint validity)
	{
		if (base.UidValidity != validity)
		{
			base.UidValidity = validity;
			OnUidValidityChanged();
		}
	}

	internal void OnRenamed(ImapFolderConstructorArgs args)
	{
		string fullName = base.FullName;
		InitializeProperties(args);
		OnRenamed(fullName, base.FullName);
	}

	private async Task<IList<UniqueId>> StoreAsync(IList<UniqueId> uids, ulong? modseq, IList<Annotation> annotations, bool doAsync, CancellationToken cancellationToken)
	{
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		if (modseq.HasValue && !supportsModSeq)
		{
			throw new NotSupportedException("The ImapFolder does not support mod-sequences.");
		}
		if (annotations == null)
		{
			throw new ArgumentNullException("annotations");
		}
		CheckState(open: true, rw: true);
		if (base.AnnotationAccess == AnnotationAccess.None)
		{
			throw new NotSupportedException("The ImapFolder does not support annotations.");
		}
		if (uids.Count == 0 || annotations.Count == 0)
		{
			return new UniqueId[0];
		}
		StringBuilder stringBuilder = new StringBuilder("UID STORE %s ");
		List<object> list = new List<object>();
		UniqueIdSet unmodified = null;
		if (modseq.HasValue)
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "(UNCHANGEDSINCE {0}) ", modseq.Value);
		}
		ImapUtils.FormatAnnotations(stringBuilder, annotations, list, throwOnError: true);
		stringBuilder.Append("\r\n");
		string format = stringBuilder.ToString();
		object[] args = list.ToArray();
		foreach (ImapCommand ic in Engine.QueueCommands(cancellationToken, this, format, uids, args))
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("STORE", ic);
			}
			ProcessUnmodified(ic, ref unmodified, modseq);
		}
		if (unmodified == null)
		{
			return new UniqueId[0];
		}
		return unmodified;
	}

	public override void Store(IList<UniqueId> uids, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken))
	{
		StoreAsync(uids, null, annotations, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task StoreAsync(IList<UniqueId> uids, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken))
	{
		return StoreAsync(uids, null, annotations, doAsync: true, cancellationToken);
	}

	public override IList<UniqueId> Store(IList<UniqueId> uids, ulong modseq, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken))
	{
		return StoreAsync(uids, modseq, annotations, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<UniqueId>> StoreAsync(IList<UniqueId> uids, ulong modseq, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken))
	{
		return StoreAsync(uids, modseq, annotations, doAsync: true, cancellationToken);
	}

	private async Task<IList<int>> StoreAsync(IList<int> indexes, ulong? modseq, IList<Annotation> annotations, bool doAsync, CancellationToken cancellationToken)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (modseq.HasValue && !supportsModSeq)
		{
			throw new NotSupportedException("The ImapFolder does not support mod-sequences.");
		}
		if (annotations == null)
		{
			throw new ArgumentNullException("annotations");
		}
		CheckState(open: true, rw: true);
		if (base.AnnotationAccess == AnnotationAccess.None)
		{
			throw new NotSupportedException("The ImapFolder does not support annotations.");
		}
		if (indexes.Count == 0 || annotations.Count == 0)
		{
			return new int[0];
		}
		string arg = ImapUtils.FormatIndexSet(Engine, indexes);
		StringBuilder stringBuilder = new StringBuilder("STORE ");
		List<object> list = new List<object>();
		stringBuilder.AppendFormat("{0} ", arg);
		if (modseq.HasValue)
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "(UNCHANGEDSINCE {0}) ", modseq.Value);
		}
		ImapUtils.FormatAnnotations(stringBuilder, annotations, list, throwOnError: true);
		stringBuilder.Append("\r\n");
		string format = stringBuilder.ToString();
		object[] args = list.ToArray();
		ImapCommand ic = Engine.QueueCommand(cancellationToken, this, format, args);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("STORE", ic);
		}
		return GetUnmodified(ic, modseq);
	}

	public override void Store(IList<int> indexes, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken))
	{
		StoreAsync(indexes, null, annotations, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task StoreAsync(IList<int> indexes, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken))
	{
		return StoreAsync(indexes, null, annotations, doAsync: true, cancellationToken);
	}

	public override IList<int> Store(IList<int> indexes, ulong modseq, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken))
	{
		return StoreAsync(indexes, modseq, annotations, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<int>> StoreAsync(IList<int> indexes, ulong modseq, IList<Annotation> annotations, CancellationToken cancellationToken = default(CancellationToken))
	{
		return StoreAsync(indexes, modseq, annotations, doAsync: true, cancellationToken);
	}

	private static async Task ReadLiteralDataAsync(ImapEngine engine, bool doAsync, CancellationToken cancellationToken)
	{
		byte[] buf = ArrayPool<byte>.Shared.Rent(4096);
		try
		{
			int num;
			do
			{
				num = ((!doAsync) ? engine.Stream.Read(buf, 0, 4096, cancellationToken) : (await engine.Stream.ReadAsync(buf, 0, 4096, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
			}
			while (num > 0);
		}
		finally
		{
			ArrayPool<byte>.Shared.Return(buf);
		}
	}

	private static async Task SkipParenthesizedList(ImapEngine engine, bool doAsync, CancellationToken cancellationToken)
	{
		while (true)
		{
			ImapToken token = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (token.Type == ImapTokenType.Eoln)
			{
				break;
			}
			await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (token.Type != ImapTokenType.CloseParen)
			{
				if (token.Type == ImapTokenType.OpenParen)
				{
					await SkipParenthesizedList(engine, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				continue;
			}
			break;
		}
	}

	private async Task<DateTimeOffset?> ReadDateTimeOffsetTokenAsync(ImapEngine engine, string atom, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		switch (imapToken.Type)
		{
		case ImapTokenType.Atom:
		case ImapTokenType.QString:
			return ImapUtils.ParseInternalDate((string)imapToken.Value);
		case ImapTokenType.Nil:
			return null;
		default:
			throw ImapEngine.UnexpectedToken("Syntax error in {0}. {1}", atom, imapToken);
		}
	}

	private async Task FetchSummaryItemsAsync(ImapEngine engine, MessageSummary message, bool doAsync, CancellationToken cancellationToken)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, "Syntax error in untagged {0} response. {1}", "FETCH", imapToken);
		while (true)
		{
			imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (imapToken.Type == ImapTokenType.CloseParen || imapToken.Type == ImapTokenType.Eoln)
			{
				break;
			}
			bool parenthesized = false;
			if (engine.QuirksMode == ImapQuirksMode.Domino && imapToken.Type == ImapTokenType.OpenParen)
			{
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				parenthesized = true;
			}
			ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "FETCH", imapToken);
			string atom = (string)imapToken.Value;
			switch (atom.ToUpperInvariant())
			{
			case "INTERNALDATE":
			{
				MessageSummary messageSummary = message;
				messageSummary.InternalDate = await ReadDateTimeOffsetTokenAsync(engine, atom, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				message.Fields |= MessageSummaryItems.InternalDate;
				break;
			}
			case "SAVEDATE":
			{
				MessageSummary messageSummary = message;
				messageSummary.SaveDate = await ReadDateTimeOffsetTokenAsync(engine, atom, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				message.Fields |= MessageSummaryItems.SaveDate;
				break;
			}
			case "RFC822.SIZE":
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				message.Size = ImapEngine.ParseNumber(imapToken, false, "Syntax error in {0}. {1}", atom, imapToken);
				message.Fields |= MessageSummaryItems.Size;
				break;
			case "BODYSTRUCTURE":
			{
				string format = string.Format("Syntax error in {0}. {1}", "BODYSTRUCTURE", "{0}");
				MessageSummary messageSummary = message;
				messageSummary.Body = await ImapUtils.ParseBodyAsync(engine, format, string.Empty, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				message.Fields |= MessageSummaryItems.BodyStructure;
				break;
			}
			case "BODY":
			{
				imapToken = await engine.PeekTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				string format = "Syntax error in BODY. {0}";
				if (imapToken.Type == ImapTokenType.OpenBracket)
				{
					bool referencesField = false;
					bool headerFields = false;
					imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					ImapEngine.AssertToken(imapToken, ImapTokenType.OpenBracket, format, imapToken);
					while (true)
					{
						imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
						if (imapToken.Type == ImapTokenType.CloseBracket)
						{
							break;
						}
						if (imapToken.Type == ImapTokenType.OpenParen)
						{
							while (true)
							{
								imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
								if (imapToken.Type == ImapTokenType.CloseParen)
								{
									break;
								}
								engine.Stream.UngetToken(imapToken);
								string text = await ImapUtils.ReadStringTokenAsync(engine, format, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
								if (headerFields && !referencesField && text.Equals("REFERENCES", StringComparison.OrdinalIgnoreCase))
								{
									referencesField = true;
								}
							}
						}
						else
						{
							ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, format, imapToken);
							atom = (string)imapToken.Value;
							headerFields = atom.Equals("HEADER.FIELDS", StringComparison.OrdinalIgnoreCase);
							if (!headerFields && atom.Equals("HEADER", StringComparison.OrdinalIgnoreCase))
							{
								referencesField = true;
							}
						}
					}
					ImapEngine.AssertToken(imapToken, ImapTokenType.CloseBracket, format, imapToken);
					imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					ImapEngine.AssertToken(imapToken, ImapTokenType.Literal, format, imapToken);
					try
					{
						MessageSummary messageSummary = message;
						messageSummary.Headers = await engine.ParseHeadersAsync(engine.Stream, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					}
					catch (FormatException)
					{
						message.Headers = new HeaderList();
					}
					await ReadLiteralDataAsync(engine, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					message.References = new MessageIdList();
					int index;
					if ((index = message.Headers.IndexOf(HeaderId.References)) != -1)
					{
						Header header = message.Headers[index];
						byte[] rawValue = header.RawValue;
						foreach (string item in MimeUtils.EnumerateReferences(rawValue, 0, rawValue.Length))
						{
							message.References.Add(item);
						}
					}
					message.Fields |= MessageSummaryItems.Headers;
					if (referencesField)
					{
						message.Fields |= MessageSummaryItems.References;
					}
				}
				else
				{
					MessageSummary messageSummary = message;
					messageSummary.Body = await ImapUtils.ParseBodyAsync(engine, format, string.Empty, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					message.Fields |= MessageSummaryItems.Body;
				}
				break;
			}
			case "ENVELOPE":
			{
				MessageSummary messageSummary = message;
				messageSummary.Envelope = await ImapUtils.ParseEnvelopeAsync(engine, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				message.Fields |= MessageSummaryItems.Envelope;
				break;
			}
			case "FLAGS":
			{
				MessageSummary messageSummary = message;
				messageSummary.Flags = await ImapUtils.ParseFlagsListAsync(engine, atom, message.Keywords, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				message.Fields |= MessageSummaryItems.Flags;
				break;
			}
			case "MODSEQ":
			{
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, "Syntax error in {0}. {1}", atom, imapToken);
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ulong value64 = ImapEngine.ParseNumber64(imapToken, false, "Syntax error in {0}. {1}", atom, imapToken);
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ImapEngine.AssertToken(imapToken, ImapTokenType.CloseParen, "Syntax error in {0}. {1}", atom, imapToken);
				message.Fields |= MessageSummaryItems.ModSeq;
				message.ModSeq = value64;
				if (value64 > base.HighestModSeq)
				{
					UpdateHighestModSeq(value64);
				}
				break;
			}
			case "UID":
			{
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				uint id = ImapEngine.ParseNumber(imapToken, true, "Syntax error in {0}. {1}", atom, imapToken);
				message.UniqueId = new UniqueId(base.UidValidity, id);
				message.Fields |= MessageSummaryItems.UniqueId;
				break;
			}
			case "EMAILID":
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, "Syntax error in {0}. {1}", atom, imapToken);
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in {0}. {1}", atom, imapToken);
				message.Fields |= MessageSummaryItems.EmailId;
				message.EmailId = (string)imapToken.Value;
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ImapEngine.AssertToken(imapToken, ImapTokenType.CloseParen, "Syntax error in {0}. {1}", atom, imapToken);
				break;
			case "THREADID":
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (imapToken.Type == ImapTokenType.OpenParen)
				{
					imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in {0}. {1}", atom, imapToken);
					message.Fields |= MessageSummaryItems.ThreadId;
					message.ThreadId = (string)imapToken.Value;
					imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					ImapEngine.AssertToken(imapToken, ImapTokenType.CloseParen, "Syntax error in {0}. {1}", atom, imapToken);
				}
				else
				{
					ImapEngine.AssertToken(imapToken, ImapTokenType.Nil, "Syntax error in {0}. {1}", atom, imapToken);
					message.Fields |= MessageSummaryItems.ThreadId;
					message.ThreadId = null;
				}
				break;
			case "X-GM-MSGID":
			{
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ulong value64 = ImapEngine.ParseNumber64(imapToken, true, "Syntax error in {0}. {1}", atom, imapToken);
				message.Fields |= MessageSummaryItems.GMailMessageId;
				message.GMailMessageId = value64;
				break;
			}
			case "X-GM-THRID":
			{
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ulong value64 = ImapEngine.ParseNumber64(imapToken, true, "Syntax error in {0}. {1}", atom, imapToken);
				message.Fields |= MessageSummaryItems.GMailThreadId;
				message.GMailThreadId = value64;
				break;
			}
			case "X-GM-LABELS":
			{
				MessageSummary messageSummary = message;
				messageSummary.GMailLabels = await ImapUtils.ParseLabelsListAsync(engine, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				message.Fields |= MessageSummaryItems.GMailLabels;
				break;
			}
			case "ANNOTATION":
			{
				MessageSummary messageSummary = message;
				messageSummary.Annotations = await ImapUtils.ParseAnnotationsAsync(engine, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				message.Fields |= MessageSummaryItems.Annotations;
				break;
			}
			default:
				if ((await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type == ImapTokenType.OpenParen)
				{
					await SkipParenthesizedList(engine, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				break;
			}
			if (parenthesized)
			{
				imapToken = await engine.ReadTokenAsync(doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ImapEngine.AssertToken(imapToken, ImapTokenType.CloseParen, "Syntax error in untagged {0} response. {1}", "FETCH", imapToken);
			}
		}
		ImapEngine.AssertToken(imapToken, ImapTokenType.CloseParen, "Syntax error in untagged {0} response. {1}", "FETCH", imapToken);
	}

	private async Task FetchSummaryItemsAsync(ImapEngine engine, ImapCommand ic, int index, bool doAsync)
	{
		FetchSummaryContext fetchSummaryContext = (FetchSummaryContext)ic.UserData;
		if (!fetchSummaryContext.TryGetValue(index, out var message))
		{
			message = new MessageSummary(this, index);
			fetchSummaryContext.Add(index, message);
		}
		await FetchSummaryItemsAsync(engine, message, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		OnMessageSummaryFetched(message);
	}

	internal static string FormatSummaryItems(ImapEngine engine, ref MessageSummaryItems items, HashSet<string> headers, out bool previewText, bool isNotify = false)
	{
		if ((items & MessageSummaryItems.PreviewText) != MessageSummaryItems.None)
		{
			items |= MessageSummaryItems.BodyStructure | MessageSummaryItems.UniqueId;
			previewText = true;
		}
		else
		{
			previewText = false;
		}
		if ((items & MessageSummaryItems.BodyStructure) != MessageSummaryItems.None && (items & MessageSummaryItems.Body) != MessageSummaryItems.None)
		{
			items &= ~MessageSummaryItems.Body;
		}
		if (engine.QuirksMode != ImapQuirksMode.GMail && !isNotify)
		{
			switch (items & ~MessageSummaryItems.PreviewText)
			{
			case MessageSummaryItems.All:
				return "ALL";
			case MessageSummaryItems.Full:
				return "FULL";
			case MessageSummaryItems.Fast:
				return "FAST";
			}
		}
		List<string> list = new List<string>();
		if ((items & MessageSummaryItems.UniqueId) != MessageSummaryItems.None)
		{
			list.Add("UID");
		}
		if ((items & MessageSummaryItems.Flags) != MessageSummaryItems.None)
		{
			list.Add("FLAGS");
		}
		if ((items & MessageSummaryItems.InternalDate) != MessageSummaryItems.None)
		{
			list.Add("INTERNALDATE");
		}
		if ((items & MessageSummaryItems.Size) != MessageSummaryItems.None)
		{
			list.Add("RFC822.SIZE");
		}
		if ((items & MessageSummaryItems.Envelope) != MessageSummaryItems.None)
		{
			list.Add("ENVELOPE");
		}
		if ((items & MessageSummaryItems.BodyStructure) != MessageSummaryItems.None)
		{
			list.Add("BODYSTRUCTURE");
		}
		if ((items & MessageSummaryItems.Body) != MessageSummaryItems.None)
		{
			list.Add("BODY");
		}
		if ((engine.Capabilities & ImapCapabilities.CondStore) != ImapCapabilities.None && (items & MessageSummaryItems.ModSeq) != MessageSummaryItems.None)
		{
			list.Add("MODSEQ");
		}
		if ((engine.Capabilities & ImapCapabilities.Annotate) != ImapCapabilities.None && (items & MessageSummaryItems.Annotations) != MessageSummaryItems.None)
		{
			list.Add("ANNOTATION (/* (value size))");
		}
		if ((engine.Capabilities & ImapCapabilities.ObjectID) != ImapCapabilities.None)
		{
			if ((items & MessageSummaryItems.EmailId) != MessageSummaryItems.None)
			{
				list.Add("EMAILID");
			}
			if ((items & MessageSummaryItems.ThreadId) != MessageSummaryItems.None)
			{
				list.Add("THREADID");
			}
		}
		if ((engine.Capabilities & ImapCapabilities.SaveDate) != ImapCapabilities.None && (items & MessageSummaryItems.SaveDate) != MessageSummaryItems.None)
		{
			list.Add("SAVEDATE");
		}
		if ((engine.Capabilities & ImapCapabilities.GMailExt1) != ImapCapabilities.None)
		{
			if ((items & MessageSummaryItems.GMailMessageId) != MessageSummaryItems.None)
			{
				list.Add("X-GM-MSGID");
			}
			if ((items & MessageSummaryItems.GMailThreadId) != MessageSummaryItems.None)
			{
				list.Add("X-GM-THRID");
			}
			if ((items & MessageSummaryItems.GMailLabels) != MessageSummaryItems.None)
			{
				list.Add("X-GM-LABELS");
			}
		}
		if ((items & MessageSummaryItems.Headers) != MessageSummaryItems.None)
		{
			list.Add("BODY.PEEK[HEADER]");
		}
		else if ((items & MessageSummaryItems.References) != MessageSummaryItems.None || headers.Count > 0)
		{
			StringBuilder stringBuilder = new StringBuilder("BODY.PEEK[HEADER.FIELDS (");
			bool flag = false;
			foreach (string header in headers)
			{
				if (header.Equals("REFERENCES", StringComparison.OrdinalIgnoreCase))
				{
					flag = true;
				}
				stringBuilder.Append(header);
				stringBuilder.Append(' ');
			}
			if ((items & MessageSummaryItems.References) != MessageSummaryItems.None && !flag)
			{
				stringBuilder.Append("REFERENCES ");
			}
			stringBuilder[stringBuilder.Length - 1] = ')';
			stringBuilder.Append(']');
			list.Add(stringBuilder.ToString());
		}
		if (list.Count == 1 && !isNotify)
		{
			return list[0];
		}
		return string.Format("({0})", string.Join(" ", list));
	}

	private string FormatSummaryItems(ref MessageSummaryItems items, HashSet<string> headers, out bool previewText)
	{
		return FormatSummaryItems(Engine, ref items, headers, out previewText);
	}

	private static IList<IMessageSummary> AsReadOnly(ICollection<IMessageSummary> collection)
	{
		IMessageSummary[] array = new IMessageSummary[collection.Count];
		collection.CopyTo(array, 0);
		return new ReadOnlyCollection<IMessageSummary>(array);
	}

	private async Task FetchPreviewTextAsync(FetchSummaryContext sctx, Dictionary<string, UniqueIdSet> bodies, int octets, bool doAsync, CancellationToken cancellationToken)
	{
		foreach (KeyValuePair<string, UniqueIdSet> body in bodies)
		{
			UniqueIdSet value = body.Value;
			string format = string.Format(arg1: string.IsNullOrEmpty(body.Key) ? "TEXT" : body.Key, provider: CultureInfo.InvariantCulture, format: "UID FETCH {0} (BODY.PEEK[{1}]<0.{2}>)\r\n", arg0: value, arg2: octets);
			ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
			FetchPreviewTextContext ctx = new FetchPreviewTextContext(this, sctx);
			ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
			ic.UserData = ctx;
			Engine.QueueCommand(ic);
			try
			{
				await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
				ProcessResponseCodes(ic, null);
				if (ic.Response != ImapCommandResponse.Ok)
				{
					throw ImapCommandException.Create("FETCH", ic);
				}
			}
			finally
			{
				ctx.Dispose();
			}
		}
	}

	private async Task GetPreviewTextAsync(FetchSummaryContext sctx, bool doAsync, CancellationToken cancellationToken)
	{
		Dictionary<string, UniqueIdSet> dictionary = new Dictionary<string, UniqueIdSet>();
		Dictionary<string, UniqueIdSet> htmlBodies = new Dictionary<string, UniqueIdSet>();
		foreach (IMessageSummary message in sctx.Messages)
		{
			MessageSummary messageSummary = (MessageSummary)message;
			BodyPartText bodyPartText = messageSummary.TextBody;
			Dictionary<string, UniqueIdSet> dictionary2;
			if (bodyPartText == null)
			{
				bodyPartText = messageSummary.HtmlBody;
				dictionary2 = htmlBodies;
			}
			else
			{
				dictionary2 = dictionary;
			}
			if (bodyPartText == null)
			{
				messageSummary.Fields |= MessageSummaryItems.PreviewText;
				messageSummary.PreviewText = string.Empty;
				OnMessageSummaryFetched(messageSummary);
				continue;
			}
			if (!dictionary2.TryGetValue(bodyPartText.PartSpecifier, out var value))
			{
				value = new UniqueIdSet(SortOrder.Ascending);
				dictionary2.Add(bodyPartText.PartSpecifier, value);
			}
			value.Add(messageSummary.UniqueId);
		}
		base.MessageExpunged += sctx.OnMessageExpunged;
		try
		{
			await FetchPreviewTextAsync(sctx, dictionary, 512, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			await FetchPreviewTextAsync(sctx, htmlBodies, 16384, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		finally
		{
			base.MessageExpunged -= sctx.OnMessageExpunged;
		}
	}

	private async Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, MessageSummaryItems items, bool doAsync, CancellationToken cancellationToken)
	{
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		if (items == MessageSummaryItems.None)
		{
			throw new ArgumentOutOfRangeException("items");
		}
		CheckState(open: true, rw: false);
		if (uids.Count == 0)
		{
			return new IMessageSummary[0];
		}
		bool previewText;
		string arg = FormatSummaryItems(ref items, EmptyHeaderFields, out previewText);
		string format = $"UID FETCH %s {arg}\r\n";
		FetchSummaryContext ctx = new FetchSummaryContext();
		base.MessageExpunged += ctx.OnMessageExpunged;
		try
		{
			foreach (ImapCommand ic in Engine.CreateCommands(cancellationToken, this, format, uids))
			{
				ic.RegisterUntaggedHandler("FETCH", FetchSummaryItemsAsync);
				ic.UserData = ctx;
				Engine.QueueCommand(ic);
				await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
				ProcessResponseCodes(ic, null);
				if (ic.Response != ImapCommandResponse.Ok)
				{
					throw ImapCommandException.Create("FETCH", ic);
				}
			}
		}
		finally
		{
			base.MessageExpunged -= ctx.OnMessageExpunged;
		}
		if (previewText)
		{
			await GetPreviewTextAsync(ctx, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return AsReadOnly(ctx.Messages);
	}

	private async Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, MessageSummaryItems items, IEnumerable<string> headers, bool doAsync, CancellationToken cancellationToken)
	{
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		HashSet<string> uniqueHeaders = ImapUtils.GetUniqueHeaders(headers);
		CheckState(open: true, rw: false);
		if (uids.Count == 0)
		{
			return new IMessageSummary[0];
		}
		bool previewText;
		string arg = FormatSummaryItems(ref items, uniqueHeaders, out previewText);
		string format = $"UID FETCH %s {arg}\r\n";
		FetchSummaryContext ctx = new FetchSummaryContext();
		base.MessageExpunged += ctx.OnMessageExpunged;
		try
		{
			foreach (ImapCommand ic in Engine.CreateCommands(cancellationToken, this, format, uids))
			{
				ic.RegisterUntaggedHandler("FETCH", FetchSummaryItemsAsync);
				ic.UserData = ctx;
				Engine.QueueCommand(ic);
				await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
				ProcessResponseCodes(ic, null);
				if (ic.Response != ImapCommandResponse.Ok)
				{
					throw ImapCommandException.Create("FETCH", ic);
				}
			}
		}
		finally
		{
			base.MessageExpunged -= ctx.OnMessageExpunged;
		}
		if (previewText)
		{
			await GetPreviewTextAsync(ctx, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return AsReadOnly(ctx.Messages);
	}

	private async Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, bool doAsync, CancellationToken cancellationToken)
	{
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		if (items == MessageSummaryItems.None)
		{
			throw new ArgumentOutOfRangeException("items");
		}
		if (!supportsModSeq)
		{
			throw new NotSupportedException("The ImapFolder does not support mod-sequences.");
		}
		CheckState(open: true, rw: false);
		if (uids.Count == 0)
		{
			return new IMessageSummary[0];
		}
		bool previewText;
		string arg = FormatSummaryItems(ref items, EmptyHeaderFields, out previewText);
		string arg2 = (Engine.QResyncEnabled ? " VANISHED" : string.Empty);
		string arg3 = modseq.ToString(CultureInfo.InvariantCulture);
		string format = $"UID FETCH %s {arg} (CHANGEDSINCE {arg3}{arg2})\r\n";
		FetchSummaryContext ctx = new FetchSummaryContext();
		base.MessageExpunged += ctx.OnMessageExpunged;
		try
		{
			foreach (ImapCommand ic in Engine.CreateCommands(cancellationToken, this, format, uids))
			{
				ic.RegisterUntaggedHandler("FETCH", FetchSummaryItemsAsync);
				ic.UserData = ctx;
				Engine.QueueCommand(ic);
				await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
				ProcessResponseCodes(ic, null);
				if (ic.Response != ImapCommandResponse.Ok)
				{
					throw ImapCommandException.Create("FETCH", ic);
				}
			}
		}
		finally
		{
			base.MessageExpunged -= ctx.OnMessageExpunged;
		}
		if (previewText)
		{
			await GetPreviewTextAsync(ctx, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return AsReadOnly(ctx.Messages);
	}

	private async Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, bool doAsync, CancellationToken cancellationToken)
	{
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		HashSet<string> uniqueHeaders = ImapUtils.GetUniqueHeaders(headers);
		if (!supportsModSeq)
		{
			throw new NotSupportedException("The ImapFolder does not support mod-sequences.");
		}
		CheckState(open: true, rw: false);
		if (uids.Count == 0)
		{
			return new IMessageSummary[0];
		}
		bool previewText;
		string arg = FormatSummaryItems(ref items, uniqueHeaders, out previewText);
		string arg2 = (Engine.QResyncEnabled ? " VANISHED" : string.Empty);
		string arg3 = modseq.ToString(CultureInfo.InvariantCulture);
		string format = $"UID FETCH %s {arg} (CHANGEDSINCE {arg3}{arg2})\r\n";
		FetchSummaryContext ctx = new FetchSummaryContext();
		base.MessageExpunged += ctx.OnMessageExpunged;
		try
		{
			foreach (ImapCommand ic in Engine.CreateCommands(cancellationToken, this, format, uids))
			{
				ic.RegisterUntaggedHandler("FETCH", FetchSummaryItemsAsync);
				ic.UserData = ctx;
				Engine.QueueCommand(ic);
				await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
				ProcessResponseCodes(ic, null);
				if (ic.Response != ImapCommandResponse.Ok)
				{
					throw ImapCommandException.Create("FETCH", ic);
				}
			}
		}
		finally
		{
			base.MessageExpunged -= ctx.OnMessageExpunged;
		}
		if (previewText)
		{
			await GetPreviewTextAsync(ctx, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return AsReadOnly(ctx.Messages);
	}

	public override IList<IMessageSummary> Fetch(IList<UniqueId> uids, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(uids, items, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(uids, items, doAsync: true, cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(IList<UniqueId> uids, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Fetch(uids, items, ImapUtils.GetUniqueHeaders(headers), cancellationToken);
	}

	public override Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(uids, items, ImapUtils.GetUniqueHeaders(headers), cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(IList<UniqueId> uids, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(uids, items, headers, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(uids, items, headers, doAsync: true, cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(uids, modseq, items, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(uids, modseq, items, doAsync: true, cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Fetch(uids, modseq, items, ImapUtils.GetUniqueHeaders(headers), cancellationToken);
	}

	public override Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(uids, modseq, items, ImapUtils.GetUniqueHeaders(headers), cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(uids, modseq, items, headers, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<IMessageSummary>> FetchAsync(IList<UniqueId> uids, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(uids, modseq, items, headers, doAsync: true, cancellationToken);
	}

	private async Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, MessageSummaryItems items, bool doAsync, CancellationToken cancellationToken)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (items == MessageSummaryItems.None)
		{
			throw new ArgumentOutOfRangeException("items");
		}
		CheckState(open: true, rw: false);
		CheckAllowIndexes();
		if (indexes.Count == 0)
		{
			return new IMessageSummary[0];
		}
		string arg = ImapUtils.FormatIndexSet(Engine, indexes);
		bool previewText;
		string arg2 = FormatSummaryItems(ref items, EmptyHeaderFields, out previewText);
		string format = $"FETCH {arg} {arg2}\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchSummaryContext ctx = new FetchSummaryContext();
		ic.RegisterUntaggedHandler("FETCH", FetchSummaryItemsAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("FETCH", ic);
		}
		if (previewText)
		{
			await GetPreviewTextAsync(ctx, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return AsReadOnly(ctx.Messages);
	}

	private async Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, MessageSummaryItems items, IEnumerable<string> headers, bool doAsync, CancellationToken cancellationToken)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		HashSet<string> uniqueHeaders = ImapUtils.GetUniqueHeaders(headers);
		CheckState(open: true, rw: false);
		CheckAllowIndexes();
		if (indexes.Count == 0)
		{
			return new IMessageSummary[0];
		}
		string arg = ImapUtils.FormatIndexSet(Engine, indexes);
		bool previewText;
		string arg2 = FormatSummaryItems(ref items, uniqueHeaders, out previewText);
		string format = $"FETCH {arg} {arg2}\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchSummaryContext ctx = new FetchSummaryContext();
		ic.RegisterUntaggedHandler("FETCH", FetchSummaryItemsAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("FETCH", ic);
		}
		if (previewText)
		{
			await GetPreviewTextAsync(ctx, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return AsReadOnly(ctx.Messages);
	}

	private async Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, ulong modseq, MessageSummaryItems items, bool doAsync, CancellationToken cancellationToken)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (items == MessageSummaryItems.None)
		{
			throw new ArgumentOutOfRangeException("items");
		}
		if (!supportsModSeq)
		{
			throw new NotSupportedException("The ImapFolder does not support mod-sequences.");
		}
		CheckState(open: true, rw: false);
		CheckAllowIndexes();
		if (indexes.Count == 0)
		{
			return new IMessageSummary[0];
		}
		string arg = ImapUtils.FormatIndexSet(Engine, indexes);
		bool previewText;
		string arg2 = FormatSummaryItems(ref items, EmptyHeaderFields, out previewText);
		string arg3 = modseq.ToString(CultureInfo.InvariantCulture);
		string format = $"FETCH {arg} {arg2} (CHANGEDSINCE {arg3})\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchSummaryContext ctx = new FetchSummaryContext();
		ic.RegisterUntaggedHandler("FETCH", FetchSummaryItemsAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("FETCH", ic);
		}
		if (previewText)
		{
			await GetPreviewTextAsync(ctx, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return AsReadOnly(ctx.Messages);
	}

	private async Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, bool doAsync, CancellationToken cancellationToken)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		HashSet<string> uniqueHeaders = ImapUtils.GetUniqueHeaders(headers);
		if (!supportsModSeq)
		{
			throw new NotSupportedException("The ImapFolder does not support mod-sequences.");
		}
		CheckState(open: true, rw: false);
		CheckAllowIndexes();
		if (indexes.Count == 0)
		{
			return new IMessageSummary[0];
		}
		string arg = ImapUtils.FormatIndexSet(Engine, indexes);
		bool previewText;
		string arg2 = FormatSummaryItems(ref items, uniqueHeaders, out previewText);
		string arg3 = modseq.ToString(CultureInfo.InvariantCulture);
		string format = $"FETCH {arg} {arg2} (CHANGEDSINCE {arg3})\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchSummaryContext ctx = new FetchSummaryContext();
		ic.RegisterUntaggedHandler("FETCH", FetchSummaryItemsAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("FETCH", ic);
		}
		if (previewText)
		{
			await GetPreviewTextAsync(ctx, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return AsReadOnly(ctx.Messages);
	}

	public override IList<IMessageSummary> Fetch(IList<int> indexes, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(indexes, items, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(indexes, items, doAsync: true, cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(IList<int> indexes, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Fetch(indexes, items, ImapUtils.GetUniqueHeaders(headers), cancellationToken);
	}

	public override Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(indexes, items, ImapUtils.GetUniqueHeaders(headers), cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(IList<int> indexes, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(indexes, items, headers, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(indexes, items, headers, doAsync: true, cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(IList<int> indexes, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(indexes, modseq, items, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(indexes, modseq, items, doAsync: true, cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(IList<int> indexes, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Fetch(indexes, modseq, items, ImapUtils.GetUniqueHeaders(headers), cancellationToken);
	}

	public override Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(indexes, modseq, items, ImapUtils.GetUniqueHeaders(headers), cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(IList<int> indexes, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(indexes, modseq, items, headers, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<IMessageSummary>> FetchAsync(IList<int> indexes, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(indexes, modseq, items, headers, doAsync: true, cancellationToken);
	}

	private static string GetFetchRange(int min, int max)
	{
		string text = (min + 1).ToString(CultureInfo.InvariantCulture);
		if (min == max)
		{
			return text;
		}
		string arg = ((max != -1) ? (max + 1).ToString(CultureInfo.InvariantCulture) : "*");
		return string.Format(CultureInfo.InvariantCulture, "{0}:{1}", text, arg);
	}

	private async Task<IList<IMessageSummary>> FetchAsync(int min, int max, MessageSummaryItems items, bool doAsync, CancellationToken cancellationToken)
	{
		if (min < 0)
		{
			throw new ArgumentOutOfRangeException("min");
		}
		if (max != -1 && max < min)
		{
			throw new ArgumentOutOfRangeException("max");
		}
		if (items == MessageSummaryItems.None)
		{
			throw new ArgumentOutOfRangeException("items");
		}
		CheckState(open: true, rw: false);
		CheckAllowIndexes();
		if (min == base.Count)
		{
			return new IMessageSummary[0];
		}
		bool previewText;
		string arg = FormatSummaryItems(ref items, EmptyHeaderFields, out previewText);
		string format = $"FETCH {GetFetchRange(min, max)} {arg}\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchSummaryContext ctx = new FetchSummaryContext();
		ic.RegisterUntaggedHandler("FETCH", FetchSummaryItemsAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("FETCH", ic);
		}
		if (previewText)
		{
			await GetPreviewTextAsync(ctx, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return AsReadOnly(ctx.Messages);
	}

	private async Task<IList<IMessageSummary>> FetchAsync(int min, int max, MessageSummaryItems items, IEnumerable<string> headers, bool doAsync, CancellationToken cancellationToken)
	{
		if (min < 0)
		{
			throw new ArgumentOutOfRangeException("min");
		}
		if (max != -1 && max < min)
		{
			throw new ArgumentOutOfRangeException("max");
		}
		HashSet<string> uniqueHeaders = ImapUtils.GetUniqueHeaders(headers);
		CheckState(open: true, rw: false);
		CheckAllowIndexes();
		if (min == base.Count)
		{
			return new IMessageSummary[0];
		}
		bool previewText;
		string arg = FormatSummaryItems(ref items, uniqueHeaders, out previewText);
		string format = $"FETCH {GetFetchRange(min, max)} {arg}\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchSummaryContext ctx = new FetchSummaryContext();
		ic.RegisterUntaggedHandler("FETCH", FetchSummaryItemsAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("FETCH", ic);
		}
		if (previewText)
		{
			await GetPreviewTextAsync(ctx, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return AsReadOnly(ctx.Messages);
	}

	private async Task<IList<IMessageSummary>> FetchAsync(int min, int max, ulong modseq, MessageSummaryItems items, bool doAsync, CancellationToken cancellationToken)
	{
		if (min < 0)
		{
			throw new ArgumentOutOfRangeException("min");
		}
		if (max != -1 && max < min)
		{
			throw new ArgumentOutOfRangeException("max");
		}
		if (items == MessageSummaryItems.None)
		{
			throw new ArgumentOutOfRangeException("items");
		}
		if (!supportsModSeq)
		{
			throw new NotSupportedException("The ImapFolder does not support mod-sequences.");
		}
		CheckState(open: true, rw: false);
		CheckAllowIndexes();
		bool previewText;
		string arg = FormatSummaryItems(ref items, EmptyHeaderFields, out previewText);
		string arg2 = modseq.ToString(CultureInfo.InvariantCulture);
		string format = $"FETCH {GetFetchRange(min, max)} {arg} (CHANGEDSINCE {arg2})\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchSummaryContext ctx = new FetchSummaryContext();
		ic.RegisterUntaggedHandler("FETCH", FetchSummaryItemsAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("FETCH", ic);
		}
		if (previewText)
		{
			await GetPreviewTextAsync(ctx, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return AsReadOnly(ctx.Messages);
	}

	private async Task<IList<IMessageSummary>> FetchAsync(int min, int max, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, bool doAsync, CancellationToken cancellationToken)
	{
		if (min < 0)
		{
			throw new ArgumentOutOfRangeException("min");
		}
		if (max != -1 && max < min)
		{
			throw new ArgumentOutOfRangeException("max");
		}
		HashSet<string> uniqueHeaders = ImapUtils.GetUniqueHeaders(headers);
		if (!supportsModSeq)
		{
			throw new NotSupportedException("The ImapFolder does not support mod-sequences.");
		}
		CheckState(open: true, rw: false);
		CheckAllowIndexes();
		bool previewText;
		string arg = FormatSummaryItems(ref items, uniqueHeaders, out previewText);
		string arg2 = modseq.ToString(CultureInfo.InvariantCulture);
		string format = $"FETCH {GetFetchRange(min, max)} {arg} (CHANGEDSINCE {arg2})\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchSummaryContext ctx = new FetchSummaryContext();
		ic.RegisterUntaggedHandler("FETCH", FetchSummaryItemsAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("FETCH", ic);
		}
		if (previewText)
		{
			await GetPreviewTextAsync(ctx, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return AsReadOnly(ctx.Messages);
	}

	public override IList<IMessageSummary> Fetch(int min, int max, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(min, max, items, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<IMessageSummary>> FetchAsync(int min, int max, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(min, max, items, doAsync: true, cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(int min, int max, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Fetch(min, max, items, ImapUtils.GetUniqueHeaders(headers), cancellationToken);
	}

	public override Task<IList<IMessageSummary>> FetchAsync(int min, int max, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(min, max, items, ImapUtils.GetUniqueHeaders(headers), cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(int min, int max, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(min, max, items, headers, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<IMessageSummary>> FetchAsync(int min, int max, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(min, max, items, headers, doAsync: true, cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(int min, int max, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(min, max, modseq, items, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<IMessageSummary>> FetchAsync(int min, int max, ulong modseq, MessageSummaryItems items, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(min, max, modseq, items, doAsync: true, cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(int min, int max, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return Fetch(min, max, modseq, items, ImapUtils.GetUniqueHeaders(headers), cancellationToken);
	}

	public override Task<IList<IMessageSummary>> FetchAsync(int min, int max, ulong modseq, MessageSummaryItems items, IEnumerable<HeaderId> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(min, max, modseq, items, ImapUtils.GetUniqueHeaders(headers), cancellationToken);
	}

	public override IList<IMessageSummary> Fetch(int min, int max, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(min, max, modseq, items, headers, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<IMessageSummary>> FetchAsync(int min, int max, ulong modseq, MessageSummaryItems items, IEnumerable<string> headers, CancellationToken cancellationToken = default(CancellationToken))
	{
		return FetchAsync(min, max, modseq, items, headers, doAsync: true, cancellationToken);
	}

	protected virtual Stream CreateStream(UniqueId? uid, string section, int offset, int length)
	{
		if (length > 4096)
		{
			return new MemoryBlockStream();
		}
		return new MemoryStream(length);
	}

	protected virtual Stream CommitStream(Stream stream, UniqueId uid, string section, int offset, int length)
	{
		return stream;
	}

	private async Task<HeaderList> ParseHeadersAsync(Stream stream, bool doAsync, CancellationToken cancellationToken)
	{
		try
		{
			return await Engine.ParseHeadersAsync(stream, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		finally
		{
			stream.Dispose();
		}
	}

	private async Task<MimeMessage> ParseMessageAsync(Stream stream, bool doAsync, CancellationToken cancellationToken)
	{
		bool dispose = !(stream is MemoryStream) && !(stream is MemoryBlockStream);
		try
		{
			return await Engine.ParseMessageAsync(stream, !dispose, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		finally
		{
			if (dispose)
			{
				stream.Dispose();
			}
		}
	}

	private async Task<MimeEntity> ParseEntityAsync(Stream stream, bool dispose, bool doAsync, CancellationToken cancellationToken)
	{
		try
		{
			return await Engine.ParseEntityAsync(stream, !dispose, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		finally
		{
			if (dispose)
			{
				stream.Dispose();
			}
		}
	}

	private async Task FetchStreamAsync(ImapEngine engine, ImapCommand ic, int index, bool doAsync)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		AnnotationsChangedEventArgs annotations = new AnnotationsChangedEventArgs(index);
		MessageLabelsChangedEventArgs labels = new MessageLabelsChangedEventArgs(index);
		MessageFlagsChangedEventArgs flags = new MessageFlagsChangedEventArgs(index);
		ModSeqChangedEventArgs modSeq = new ModSeqChangedEventArgs(index);
		FetchStreamContextBase ctx = (FetchStreamContextBase)ic.UserData;
		StringBuilder sectionBuilder = new StringBuilder();
		bool annotationsChanged = false;
		bool modSeqChanged = false;
		bool labelsChanged = false;
		bool flagsChanged = false;
		long nread = 0L;
		long size = 0L;
		UniqueId? uid = null;
		ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, "Syntax error in untagged {0} response. {1}", "FETCH", imapToken);
		while (true)
		{
			imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (imapToken.Type == ImapTokenType.Eoln)
			{
				imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			if (imapToken.Type == ImapTokenType.CloseParen)
			{
				break;
			}
			ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "FETCH", imapToken);
			string atom = (string)imapToken.Value;
			int offset = 0;
			switch (atom.ToUpperInvariant())
			{
			case "BODY":
			{
				imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ImapEngine.AssertToken(imapToken, ImapTokenType.OpenBracket, "Syntax error in {0}. {1}", atom, imapToken);
				sectionBuilder.Clear();
				while (true)
				{
					imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					if (imapToken.Type == ImapTokenType.CloseBracket)
					{
						break;
					}
					if (imapToken.Type == ImapTokenType.OpenParen)
					{
						sectionBuilder.Append(" (");
						while (true)
						{
							imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
							if (imapToken.Type == ImapTokenType.CloseParen)
							{
								break;
							}
							switch (imapToken.Type)
							{
							case ImapTokenType.Literal:
							{
								StringBuilder stringBuilder = sectionBuilder;
								stringBuilder.Append(await engine.ReadLiteralAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false));
								break;
							}
							case ImapTokenType.Atom:
							case ImapTokenType.QString:
								sectionBuilder.Append((string)imapToken.Value);
								break;
							default:
								throw ImapEngine.UnexpectedToken("Syntax error in {0}. {1}", atom, imapToken);
							}
							sectionBuilder.Append(' ');
						}
						if (sectionBuilder[sectionBuilder.Length - 1] == ' ')
						{
							sectionBuilder.Length--;
						}
						sectionBuilder.Append(')');
					}
					else
					{
						ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in {0}. {1}", atom, imapToken);
						sectionBuilder.Append((string)imapToken.Value);
					}
				}
				ImapEngine.AssertToken(imapToken, ImapTokenType.CloseBracket, "Syntax error in {0}. {1}", atom, imapToken);
				imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (imapToken.Type == ImapTokenType.Atom)
				{
					string text = (string)imapToken.Value;
					if (text.Length > 2 && text[0] == '<' && text[text.Length - 1] == '>')
					{
						string s = text.Substring(1, text.Length - 2);
						int.TryParse(s, NumberStyles.None, CultureInfo.InvariantCulture, out offset);
						imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					}
				}
				string name = sectionBuilder.ToString();
				int length;
				Stream stream;
				switch (imapToken.Type)
				{
				case ImapTokenType.Literal:
				{
					length = (int)imapToken.Value;
					size += length;
					stream = CreateStream(uid, name, offset, length);
					byte[] buf = ArrayPool<byte>.Shared.Rent(4096);
					try
					{
						while (true)
						{
							int num = ((!doAsync) ? engine.Stream.Read(buf, 0, 4096, ic.CancellationToken) : (await engine.Stream.ReadAsync(buf, 0, 4096, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false)));
							if (num <= 0)
							{
								break;
							}
							stream.Write(buf, 0, num);
							nread += num;
							ctx.Report(nread, size);
						}
						stream.Position = 0L;
					}
					catch
					{
						stream.Dispose();
						throw;
					}
					finally
					{
						ArrayPool<byte>.Shared.Return(buf);
					}
					break;
				}
				case ImapTokenType.Atom:
				case ImapTokenType.QString:
				{
					byte[] buf = Encoding.UTF8.GetBytes((string)imapToken.Value);
					length = buf.Length;
					nread += length;
					size += length;
					stream = CreateStream(uid, name, offset, length);
					try
					{
						stream.Write(buf, 0, length);
						ctx.Report(nread, size);
						stream.Position = 0L;
					}
					catch
					{
						stream.Dispose();
						throw;
					}
					break;
				}
				case ImapTokenType.Nil:
					stream = CreateStream(uid, name, offset, 0);
					length = 0;
					break;
				default:
					throw ImapEngine.UnexpectedToken("Syntax error in {0}. {1}", atom, imapToken);
				}
				if (uid.HasValue)
				{
					stream = CommitStream(stream, uid.Value, name, offset, length);
				}
				if (ctx.Contains(index, name, out var section))
				{
					section.Stream.Dispose();
				}
				section = new Section(stream, index, uid, name, offset, length);
				await ctx.AddAsync(section, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				break;
			}
			case "UID":
			{
				imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				uint id = ImapEngine.ParseNumber(imapToken, true, "Syntax error in {0}. {1}", atom, imapToken);
				uid = new UniqueId(base.UidValidity, id);
				await ctx.SetUniqueIdAsync(index, uid.Value, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				annotations.UniqueId = uid.Value;
				modSeq.UniqueId = uid.Value;
				labels.UniqueId = uid.Value;
				flags.UniqueId = uid.Value;
				break;
			}
			case "MODSEQ":
			{
				imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, "Syntax error in {0}. {1}", atom, imapToken);
				imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ulong modseq = ImapEngine.ParseNumber64(imapToken, false, "Syntax error in {0}. {1}", atom, imapToken);
				imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				ImapEngine.AssertToken(imapToken, ImapTokenType.CloseParen, "Syntax error in {0}. {1}", atom, imapToken);
				if (modseq > base.HighestModSeq)
				{
					UpdateHighestModSeq(modseq);
				}
				annotations.ModSeq = modseq;
				modSeq.ModSeq = modseq;
				labels.ModSeq = modseq;
				flags.ModSeq = modseq;
				modSeqChanged = true;
				break;
			}
			case "FLAGS":
			{
				MessageFlagsChangedEventArgs e3 = flags;
				e3.Flags = await ImapUtils.ParseFlagsListAsync(engine, atom, flags.Keywords, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				flagsChanged = true;
				break;
			}
			case "X-GM-LABELS":
			{
				MessageLabelsChangedEventArgs e2 = labels;
				e2.Labels = await ImapUtils.ParseLabelsListAsync(engine, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				labelsChanged = true;
				break;
			}
			case "ANNOTATION":
			{
				AnnotationsChangedEventArgs e = annotations;
				e.Annotations = await ImapUtils.ParseAnnotationsAsync(engine, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				annotationsChanged = true;
				break;
			}
			default:
				if ((await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type == ImapTokenType.OpenParen)
				{
					await SkipParenthesizedList(engine, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				}
				break;
			}
		}
		ImapEngine.AssertToken(imapToken, ImapTokenType.CloseParen, "Syntax error in untagged {0} response. {1}", "FETCH", imapToken);
		if (flagsChanged)
		{
			OnMessageFlagsChanged(flags);
		}
		if (labelsChanged)
		{
			OnMessageLabelsChanged(labels);
		}
		if (annotationsChanged)
		{
			OnAnnotationsChanged(annotations);
		}
		if (modSeqChanged)
		{
			OnModSeqChanged(modSeq);
		}
	}

	private static string GetBodyPartQuery(string partSpec, bool headersOnly, out string[] tags)
	{
		string result;
		if (headersOnly)
		{
			tags = new string[1];
			if (partSpec.Length > 0)
			{
				result = $"BODY.PEEK[{partSpec}.MIME]";
				tags[0] = partSpec + ".MIME";
			}
			else
			{
				result = "BODY.PEEK[HEADER]";
				tags[0] = "HEADER";
			}
		}
		else
		{
			tags = new string[2];
			if (partSpec.Length > 0)
			{
				tags[0] = partSpec + ".MIME";
				tags[1] = partSpec;
			}
			else
			{
				tags[0] = "HEADER";
				tags[1] = "TEXT";
			}
			result = $"BODY.PEEK[{tags[0]}] BODY.PEEK[{tags[1]}]";
		}
		return result;
	}

	private async Task<HeaderList> GetHeadersAsync(UniqueId uid, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (!uid.IsValid)
		{
			throw new ArgumentException("The uid is invalid.", "uid");
		}
		CheckState(open: true, rw: false);
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, "UID FETCH %u (BODY.PEEK[HEADER])\r\n", uid.Id);
		FetchStreamContext ctx = new FetchStreamContext(progress);
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		Section section;
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
			if (!ctx.TryGetSection(uid, "HEADER", out section, remove: true))
			{
				throw new MessageNotFoundException("The IMAP server did not return the requested message headers.");
			}
		}
		finally
		{
			ctx.Dispose();
		}
		return await ParseHeadersAsync(section.Stream, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	private async Task<HeaderList> GetHeadersAsync(UniqueId uid, string partSpecifier, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (!uid.IsValid)
		{
			throw new ArgumentException("The uid is invalid.", "uid");
		}
		if (partSpecifier == null)
		{
			throw new ArgumentNullException("partSpecifier");
		}
		CheckState(open: true, rw: false);
		string[] tags;
		string format = $"UID FETCH {uid} ({GetBodyPartQuery(partSpecifier, headersOnly: true, out tags)})\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchStreamContext ctx = new FetchStreamContext(progress);
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		Section section;
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
			if (!ctx.TryGetSection(uid, tags[0], out section, remove: true))
			{
				throw new MessageNotFoundException("The IMAP server did not return the requested body part headers.");
			}
		}
		finally
		{
			ctx.Dispose();
		}
		return await ParseHeadersAsync(section.Stream, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public override HeaderList GetHeaders(UniqueId uid, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetHeadersAsync(uid, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<HeaderList> GetHeadersAsync(UniqueId uid, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetHeadersAsync(uid, doAsync: true, cancellationToken, progress);
	}

	public virtual HeaderList GetHeaders(UniqueId uid, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetHeadersAsync(uid, partSpecifier, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public virtual Task<HeaderList> GetHeadersAsync(UniqueId uid, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetHeadersAsync(uid, partSpecifier, doAsync: true, cancellationToken, progress);
	}

	public override HeaderList GetHeaders(UniqueId uid, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (!uid.IsValid)
		{
			throw new ArgumentException("The uid is invalid.", "uid");
		}
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		return GetHeaders(uid, part.PartSpecifier, cancellationToken, progress);
	}

	public override Task<HeaderList> GetHeadersAsync(UniqueId uid, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (!uid.IsValid)
		{
			throw new ArgumentException("The uid is invalid.", "uid");
		}
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		return GetHeadersAsync(uid, part.PartSpecifier, cancellationToken, progress);
	}

	private async Task<HeaderList> GetHeadersAsync(int index, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (index < 0 || index >= base.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		CheckState(open: true, rw: false);
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, "FETCH %d (BODY.PEEK[HEADER])\r\n", index + 1);
		FetchStreamContext ctx = new FetchStreamContext(progress);
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		Section section;
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
			if (!ctx.TryGetSection(index, "HEADER", out section, remove: true))
			{
				throw new MessageNotFoundException("The IMAP server did not return the requested message.");
			}
		}
		finally
		{
			ctx.Dispose();
		}
		return await ParseHeadersAsync(section.Stream, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	private async Task<HeaderList> GetHeadersAsync(int index, string partSpecifier, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (index < 0 || index >= base.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (partSpecifier == null)
		{
			throw new ArgumentNullException("partSpecifier");
		}
		CheckState(open: true, rw: false);
		string arg = (index + 1).ToString(CultureInfo.InvariantCulture);
		string[] tags;
		string format = $"FETCH {arg} ({GetBodyPartQuery(partSpecifier, headersOnly: true, out tags)})\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchStreamContext ctx = new FetchStreamContext(progress);
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		Section section;
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
			if (!ctx.TryGetSection(index, tags[0], out section, remove: true))
			{
				throw new MessageNotFoundException("The IMAP server did not return the requested body part headers.");
			}
		}
		finally
		{
			ctx.Dispose();
		}
		return await ParseHeadersAsync(section.Stream, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public override HeaderList GetHeaders(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetHeadersAsync(index, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<HeaderList> GetHeadersAsync(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetHeadersAsync(index, doAsync: true, cancellationToken, progress);
	}

	public virtual HeaderList GetHeaders(int index, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetHeadersAsync(index, partSpecifier, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public virtual Task<HeaderList> GetHeadersAsync(int index, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetHeadersAsync(index, partSpecifier, doAsync: true, cancellationToken, progress);
	}

	public override HeaderList GetHeaders(int index, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (index < 0 || index >= base.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		return GetHeaders(index, part.PartSpecifier, cancellationToken, progress);
	}

	public override Task<HeaderList> GetHeadersAsync(int index, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (index < 0 || index >= base.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		return GetHeadersAsync(index, part.PartSpecifier, cancellationToken, progress);
	}

	private async Task<MimeMessage> GetMessageAsync(UniqueId uid, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (!uid.IsValid)
		{
			throw new ArgumentException("The uid is invalid.", "uid");
		}
		CheckState(open: true, rw: false);
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, "UID FETCH %u (BODY.PEEK[])\r\n", uid.Id);
		FetchStreamContext ctx = new FetchStreamContext(progress);
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		Section section;
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
			if (!ctx.TryGetSection(uid, string.Empty, out section, remove: true))
			{
				throw new MessageNotFoundException("The IMAP server did not return the requested message.");
			}
		}
		finally
		{
			ctx.Dispose();
		}
		return await ParseMessageAsync(section.Stream, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public override MimeMessage GetMessage(UniqueId uid, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetMessageAsync(uid, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<MimeMessage> GetMessageAsync(UniqueId uid, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetMessageAsync(uid, doAsync: true, cancellationToken, progress);
	}

	private async Task<MimeMessage> GetMessageAsync(int index, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (index < 0 || index >= base.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		CheckState(open: true, rw: false);
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, "FETCH %d (BODY.PEEK[])\r\n", index + 1);
		FetchStreamContext ctx = new FetchStreamContext(progress);
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		Section section;
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
			if (!ctx.TryGetSection(index, string.Empty, out section, remove: true))
			{
				throw new MessageNotFoundException("The IMAP server did not return the requested message.");
			}
		}
		finally
		{
			ctx.Dispose();
		}
		return await ParseMessageAsync(section.Stream, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	public override MimeMessage GetMessage(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetMessageAsync(index, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<MimeMessage> GetMessageAsync(int index, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetMessageAsync(index, doAsync: true, cancellationToken, progress);
	}

	private async Task<MimeEntity> GetBodyPartAsync(UniqueId uid, string partSpecifier, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (!uid.IsValid)
		{
			throw new ArgumentException("The uid is invalid.", "uid");
		}
		if (partSpecifier == null)
		{
			throw new ArgumentNullException("partSpecifier");
		}
		CheckState(open: true, rw: false);
		string[] tags;
		string format = $"UID FETCH {uid} ({GetBodyPartQuery(partSpecifier, headersOnly: false, out tags)})\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchStreamContext ctx = new FetchStreamContext(progress);
		ChainedStream chained = null;
		bool dispose = false;
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
			chained = new ChainedStream();
			string[] array = tags;
			foreach (string specifier in array)
			{
				if (!ctx.TryGetSection(uid, specifier, out var section, remove: true))
				{
					throw new MessageNotFoundException("The IMAP server did not return the requested body part.");
				}
				if (!(section.Stream is MemoryStream) && !(section.Stream is MemoryBlockStream))
				{
					dispose = true;
				}
				chained.Add(section.Stream);
			}
		}
		catch
		{
			chained?.Dispose();
			throw;
		}
		finally
		{
			ctx.Dispose();
		}
		MimeEntity mimeEntity = await ParseEntityAsync(chained, dispose, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (partSpecifier.Length == 0)
		{
			for (int num = mimeEntity.Headers.Count; num > 0; num--)
			{
				Header header = mimeEntity.Headers[num - 1];
				if (!header.Field.StartsWith("Content-", StringComparison.OrdinalIgnoreCase))
				{
					mimeEntity.Headers.RemoveAt(num - 1);
				}
			}
		}
		return mimeEntity;
	}

	public virtual MimeEntity GetBodyPart(UniqueId uid, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetBodyPartAsync(uid, partSpecifier, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public virtual Task<MimeEntity> GetBodyPartAsync(UniqueId uid, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetBodyPartAsync(uid, partSpecifier, doAsync: true, cancellationToken, progress);
	}

	public override MimeEntity GetBodyPart(UniqueId uid, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (!uid.IsValid)
		{
			throw new ArgumentException("The uid is invalid.", "uid");
		}
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		return GetBodyPart(uid, part.PartSpecifier, cancellationToken, progress);
	}

	public override Task<MimeEntity> GetBodyPartAsync(UniqueId uid, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (!uid.IsValid)
		{
			throw new ArgumentException("The uid is invalid.", "uid");
		}
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		return GetBodyPartAsync(uid, part.PartSpecifier, cancellationToken, progress);
	}

	private async Task<MimeEntity> GetBodyPartAsync(int index, string partSpecifier, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (index < 0 || index >= base.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (partSpecifier == null)
		{
			throw new ArgumentNullException("partSpecifier");
		}
		CheckState(open: true, rw: false);
		string arg = (index + 1).ToString(CultureInfo.InvariantCulture);
		string[] tags;
		string format = $"FETCH {arg} ({GetBodyPartQuery(partSpecifier, headersOnly: false, out tags)})\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchStreamContext ctx = new FetchStreamContext(progress);
		ChainedStream chained = null;
		bool dispose = false;
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
			chained = new ChainedStream();
			string[] array = tags;
			foreach (string specifier in array)
			{
				if (!ctx.TryGetSection(index, specifier, out var section, remove: true))
				{
					throw new MessageNotFoundException("The IMAP server did not return the requested body part.");
				}
				if (!(section.Stream is MemoryStream) && !(section.Stream is MemoryBlockStream))
				{
					dispose = true;
				}
				chained.Add(section.Stream);
			}
		}
		catch
		{
			chained?.Dispose();
			throw;
		}
		finally
		{
			ctx.Dispose();
		}
		MimeEntity mimeEntity = await ParseEntityAsync(chained, dispose, doAsync, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		if (partSpecifier.Length == 0)
		{
			for (int num = mimeEntity.Headers.Count; num > 0; num--)
			{
				Header header = mimeEntity.Headers[num - 1];
				if (!header.Field.StartsWith("Content-", StringComparison.OrdinalIgnoreCase))
				{
					mimeEntity.Headers.RemoveAt(num - 1);
				}
			}
		}
		return mimeEntity;
	}

	public virtual MimeEntity GetBodyPart(int index, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetBodyPartAsync(index, partSpecifier, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public virtual Task<MimeEntity> GetBodyPartAsync(int index, string partSpecifier, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetBodyPartAsync(index, partSpecifier, doAsync: true, cancellationToken, progress);
	}

	public override MimeEntity GetBodyPart(int index, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (index < 0 || index >= base.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		return GetBodyPart(index, part.PartSpecifier, cancellationToken, progress);
	}

	public override Task<MimeEntity> GetBodyPartAsync(int index, BodyPart part, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		if (index < 0 || index >= base.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (part == null)
		{
			throw new ArgumentNullException("part");
		}
		return GetBodyPartAsync(index, part.PartSpecifier, cancellationToken, progress);
	}

	private async Task<Stream> GetStreamAsync(UniqueId uid, int offset, int count, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (!uid.IsValid)
		{
			throw new ArgumentException("The uid is invalid.", "uid");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		CheckState(open: true, rw: false);
		if (count == 0)
		{
			return new MemoryStream();
		}
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, "UID FETCH %u (BODY.PEEK[]<%d.%d>)\r\n", uid.Id, offset, count);
		FetchStreamContext ctx = new FetchStreamContext(progress);
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		Section section;
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
			if (!ctx.TryGetSection(uid, string.Empty, out section, remove: true))
			{
				throw new MessageNotFoundException("The IMAP server did not return the requested stream.");
			}
		}
		finally
		{
			ctx.Dispose();
		}
		return section.Stream;
	}

	private async Task<Stream> GetStreamAsync(int index, int offset, int count, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (index < 0 || index >= base.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		CheckState(open: true, rw: false);
		if (count == 0)
		{
			return new MemoryStream();
		}
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, "FETCH %d (BODY.PEEK[]<%d.%d>)\r\n", index + 1, offset, count);
		FetchStreamContext ctx = new FetchStreamContext(progress);
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		Section section;
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
			if (!ctx.TryGetSection(index, string.Empty, out section, remove: true))
			{
				throw new MessageNotFoundException("The IMAP server did not return the requested stream.");
			}
		}
		finally
		{
			ctx.Dispose();
		}
		return section.Stream;
	}

	public override Stream GetStream(UniqueId uid, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamAsync(uid, offset, count, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<Stream> GetStreamAsync(UniqueId uid, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamAsync(uid, offset, count, doAsync: true, cancellationToken, progress);
	}

	public override Stream GetStream(int index, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamAsync(index, offset, count, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<Stream> GetStreamAsync(int index, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamAsync(index, offset, count, doAsync: true, cancellationToken, progress);
	}

	private async Task<Stream> GetStreamAsync(UniqueId uid, string section, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (!uid.IsValid)
		{
			throw new ArgumentException("The uid is invalid.", "uid");
		}
		if (section == null)
		{
			throw new ArgumentNullException("section");
		}
		CheckState(open: true, rw: false);
		string format = $"UID FETCH {uid} (BODY.PEEK[{section}])\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchStreamContext ctx = new FetchStreamContext(progress);
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		Section section2;
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
			if (!ctx.TryGetSection(uid, section, out section2, remove: true))
			{
				throw new MessageNotFoundException("The IMAP server did not return the requested stream.");
			}
		}
		finally
		{
			ctx.Dispose();
		}
		return section2.Stream;
	}

	public override Stream GetStream(UniqueId uid, string section, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamAsync(uid, section, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<Stream> GetStreamAsync(UniqueId uid, string section, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamAsync(uid, section, doAsync: true, cancellationToken, progress);
	}

	private async Task<Stream> GetStreamAsync(UniqueId uid, string section, int offset, int count, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (!uid.IsValid)
		{
			throw new ArgumentException("The uid is invalid.", "uid");
		}
		if (section == null)
		{
			throw new ArgumentNullException("section");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		CheckState(open: true, rw: false);
		if (count == 0)
		{
			return new MemoryStream();
		}
		string arg = string.Format(CultureInfo.InvariantCulture, "{0}.{1}", offset, count);
		string format = $"UID FETCH {uid} (BODY.PEEK[{section}]<{arg}>)\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchStreamContext ctx = new FetchStreamContext(progress);
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		Section section2;
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
			if (!ctx.TryGetSection(uid, section, out section2, remove: true))
			{
				throw new MessageNotFoundException("The IMAP server did not return the requested stream.");
			}
		}
		finally
		{
			ctx.Dispose();
		}
		return section2.Stream;
	}

	public override Stream GetStream(UniqueId uid, string section, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamAsync(uid, section, offset, count, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<Stream> GetStreamAsync(UniqueId uid, string section, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamAsync(uid, section, offset, count, doAsync: true, cancellationToken, progress);
	}

	private async Task<Stream> GetStreamAsync(int index, string section, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (index < 0 || index >= base.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (section == null)
		{
			throw new ArgumentNullException("section");
		}
		CheckState(open: true, rw: false);
		string arg = (index + 1).ToString(CultureInfo.InvariantCulture);
		string format = $"FETCH {arg} (BODY.PEEK[{section}])\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchStreamContext ctx = new FetchStreamContext(progress);
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		Section section2;
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
			if (!ctx.TryGetSection(index, section, out section2, remove: true))
			{
				throw new MessageNotFoundException("The IMAP server did not return the requested stream.");
			}
		}
		finally
		{
			ctx.Dispose();
		}
		return section2.Stream;
	}

	public override Stream GetStream(int index, string section, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamAsync(index, section, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<Stream> GetStreamAsync(int index, string section, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamAsync(index, section, doAsync: true, cancellationToken, progress);
	}

	private async Task<Stream> GetStreamAsync(int index, string section, int offset, int count, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (index < 0 || index >= base.Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (section == null)
		{
			throw new ArgumentNullException("section");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		CheckState(open: true, rw: false);
		if (count == 0)
		{
			return new MemoryStream();
		}
		string arg = (index + 1).ToString(CultureInfo.InvariantCulture);
		string arg2 = string.Format(CultureInfo.InvariantCulture, "{0}.{1}", offset, count);
		string format = $"FETCH {arg} (BODY.PEEK[{section}]<{arg2}>)\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchStreamContext ctx = new FetchStreamContext(progress);
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		Section section2;
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
			if (!ctx.TryGetSection(index, section, out section2, remove: true))
			{
				throw new MessageNotFoundException("The IMAP server did not return the requested stream.");
			}
		}
		finally
		{
			ctx.Dispose();
		}
		return section2.Stream;
	}

	public override Stream GetStream(int index, string section, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamAsync(index, section, offset, count, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public override Task<Stream> GetStreamAsync(int index, string section, int offset, int count, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamAsync(index, section, offset, count, doAsync: true, cancellationToken, progress);
	}

	private async Task GetStreamsAsync(IList<UniqueId> uids, object callback, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		CheckState(open: true, rw: false);
		if (uids.Count == 0)
		{
			return;
		}
		FetchStreamCallbackContext ctx = new FetchStreamCallbackContext(this, callback, progress);
		string format = "UID FETCH %s (BODY.PEEK[])\r\n";
		try
		{
			foreach (ImapCommand ic in Engine.CreateCommands(cancellationToken, this, format, uids))
			{
				ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
				ic.UserData = ctx;
				Engine.QueueCommand(ic);
				await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
				ProcessResponseCodes(ic, null);
				if (ic.Response != ImapCommandResponse.Ok)
				{
					throw ImapCommandException.Create("FETCH", ic);
				}
			}
		}
		finally
		{
			ctx.Dispose();
		}
	}

	private async Task GetStreamsAsync(IList<int> indexes, object callback, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		CheckState(open: true, rw: false);
		CheckAllowIndexes();
		if (indexes.Count == 0)
		{
			return;
		}
		string arg = ImapUtils.FormatIndexSet(Engine, indexes);
		string format = $"FETCH {arg} (UID BODY.PEEK[])\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchStreamCallbackContext ctx = new FetchStreamCallbackContext(this, callback, progress);
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
		}
		finally
		{
			ctx.Dispose();
		}
	}

	private async Task GetStreamsAsync(int min, int max, object callback, bool doAsync, CancellationToken cancellationToken, ITransferProgress progress)
	{
		if (min < 0)
		{
			throw new ArgumentOutOfRangeException("min");
		}
		if (max != -1 && max < min)
		{
			throw new ArgumentOutOfRangeException("max");
		}
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		CheckState(open: true, rw: false);
		CheckAllowIndexes();
		if (min == base.Count)
		{
			return;
		}
		string format = $"FETCH {GetFetchRange(min, max)} (UID BODY.PEEK[])\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		FetchStreamCallbackContext ctx = new FetchStreamCallbackContext(this, callback, progress);
		ic.RegisterUntaggedHandler("FETCH", FetchStreamAsync);
		ic.UserData = ctx;
		Engine.QueueCommand(ic);
		try
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("FETCH", ic);
			}
		}
		finally
		{
			ctx.Dispose();
		}
	}

	public virtual void GetStreams(IList<UniqueId> uids, ImapFetchStreamCallback callback, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		GetStreamsAsync(uids, callback, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public virtual Task GetStreamsAsync(IList<UniqueId> uids, ImapFetchStreamAsyncCallback callback, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamsAsync(uids, callback, doAsync: true, cancellationToken, progress);
	}

	public virtual void GetStreams(IList<int> indexes, ImapFetchStreamCallback callback, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		GetStreamsAsync(indexes, callback, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public virtual Task GetStreamsAsync(IList<int> indexes, ImapFetchStreamAsyncCallback callback, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamsAsync(indexes, callback, doAsync: true, cancellationToken, progress);
	}

	public virtual void GetStreams(int min, int max, ImapFetchStreamCallback callback, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		GetStreamsAsync(min, max, callback, doAsync: false, cancellationToken, progress).GetAwaiter().GetResult();
	}

	public virtual Task GetStreamsAsync(int min, int max, ImapFetchStreamAsyncCallback callback, CancellationToken cancellationToken = default(CancellationToken), ITransferProgress progress = null)
	{
		return GetStreamsAsync(min, max, callback, doAsync: true, cancellationToken, progress);
	}

	private void ProcessUnmodified(ImapCommand ic, ref UniqueIdSet uids, ulong? modseq)
	{
		if (!modseq.HasValue)
		{
			return;
		}
		foreach (ModifiedResponseCode item in ic.RespCodes.OfType<ModifiedResponseCode>())
		{
			if (uids != null)
			{
				uids.AddRange(item.UidSet);
			}
			else
			{
				uids = item.UidSet;
			}
		}
	}

	private IList<int> GetUnmodified(ImapCommand ic, ulong? modseq)
	{
		if (modseq.HasValue)
		{
			ModifiedResponseCode modifiedResponseCode = ic.RespCodes.OfType<ModifiedResponseCode>().FirstOrDefault();
			if (modifiedResponseCode != null)
			{
				int[] array = new int[modifiedResponseCode.UidSet.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = (int)(modifiedResponseCode.UidSet[i].Id - 1);
				}
				return array;
			}
		}
		return new int[0];
	}

	private async Task<IList<UniqueId>> ModifyFlagsAsync(IList<UniqueId> uids, ulong? modseq, MessageFlags flags, HashSet<string> keywords, string action, bool doAsync, CancellationToken cancellationToken)
	{
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		if (modseq.HasValue && !supportsModSeq)
		{
			throw new NotSupportedException("The ImapFolder does not support mod-sequences.");
		}
		CheckState(open: true, rw: true);
		if (uids.Count == 0)
		{
			return new UniqueId[0];
		}
		string arg = ImapUtils.FormatFlagsList(flags & base.PermanentFlags, keywords?.Count ?? 0);
		object[] array;
		if (keywords == null)
		{
			array = new object[0];
		}
		else
		{
			object[] array2 = keywords.ToArray();
			array = array2;
		}
		object[] args = array;
		UniqueIdSet unmodified = null;
		string arg2 = string.Empty;
		if (modseq.HasValue)
		{
			arg2 = string.Format(CultureInfo.InvariantCulture, " (UNCHANGEDSINCE {0})", modseq.Value);
		}
		string format = $"UID STORE %s{arg2} {action} {arg}\r\n";
		foreach (ImapCommand ic in Engine.QueueCommands(cancellationToken, this, format, uids, args))
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("STORE", ic);
			}
			ProcessUnmodified(ic, ref unmodified, modseq);
		}
		if (unmodified == null)
		{
			return new UniqueId[0];
		}
		return unmodified;
	}

	public override void AddFlags(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		bool flag = keywords == null || keywords.Count == 0;
		if ((flags & MailFolder.SettableFlags) == 0 && flag)
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		ModifyFlagsAsync(uids, null, flags, keywords, silent ? "+FLAGS.SILENT" : "+FLAGS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task AddFlagsAsync(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		bool flag = keywords == null || keywords.Count == 0;
		if ((flags & MailFolder.SettableFlags) == 0 && flag)
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		return ModifyFlagsAsync(uids, null, flags, keywords, silent ? "+FLAGS.SILENT" : "+FLAGS", doAsync: true, cancellationToken);
	}

	public override void RemoveFlags(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if ((flags & MailFolder.SettableFlags) == 0 && (keywords == null || keywords.Count == 0))
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		ModifyFlagsAsync(uids, null, flags, keywords, silent ? "-FLAGS.SILENT" : "-FLAGS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task RemoveFlagsAsync(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if ((flags & MailFolder.SettableFlags) == 0 && (keywords == null || keywords.Count == 0))
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		return ModifyFlagsAsync(uids, null, flags, keywords, silent ? "-FLAGS.SILENT" : "-FLAGS", doAsync: true, cancellationToken);
	}

	public override void SetFlags(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		ModifyFlagsAsync(uids, null, flags, keywords, silent ? "FLAGS.SILENT" : "FLAGS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task SetFlagsAsync(IList<UniqueId> uids, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ModifyFlagsAsync(uids, null, flags, keywords, silent ? "FLAGS.SILENT" : "FLAGS", doAsync: true, cancellationToken);
	}

	public override IList<UniqueId> AddFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if ((flags & MailFolder.SettableFlags) == 0 && (keywords == null || keywords.Count == 0))
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		return ModifyFlagsAsync(uids, modseq, flags, keywords, silent ? "+FLAGS.SILENT" : "+FLAGS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<UniqueId>> AddFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if ((flags & MailFolder.SettableFlags) == 0 && (keywords == null || keywords.Count == 0))
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		return ModifyFlagsAsync(uids, modseq, flags, keywords, silent ? "+FLAGS.SILENT" : "+FLAGS", doAsync: true, cancellationToken);
	}

	public override IList<UniqueId> RemoveFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if ((flags & MailFolder.SettableFlags) == 0 && (keywords == null || keywords.Count == 0))
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		return ModifyFlagsAsync(uids, modseq, flags, keywords, silent ? "-FLAGS.SILENT" : "-FLAGS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<UniqueId>> RemoveFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if ((flags & MailFolder.SettableFlags) == 0 && (keywords == null || keywords.Count == 0))
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		return ModifyFlagsAsync(uids, modseq, flags, keywords, silent ? "-FLAGS.SILENT" : "-FLAGS", doAsync: true, cancellationToken);
	}

	public override IList<UniqueId> SetFlags(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ModifyFlagsAsync(uids, modseq, flags, keywords, silent ? "FLAGS.SILENT" : "FLAGS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<UniqueId>> SetFlagsAsync(IList<UniqueId> uids, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ModifyFlagsAsync(uids, modseq, flags, keywords, silent ? "FLAGS.SILENT" : "FLAGS", doAsync: true, cancellationToken);
	}

	private async Task<IList<int>> ModifyFlagsAsync(IList<int> indexes, ulong? modseq, MessageFlags flags, HashSet<string> keywords, string action, bool doAsync, CancellationToken cancellationToken)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if (modseq.HasValue && !supportsModSeq)
		{
			throw new NotSupportedException("The ImapFolder does not support mod-sequences.");
		}
		CheckState(open: true, rw: true);
		if (indexes.Count == 0)
		{
			return new int[0];
		}
		string text = ImapUtils.FormatFlagsList(flags & base.PermanentFlags, keywords?.Count ?? 0);
		object[] array;
		if (keywords == null)
		{
			array = new object[0];
		}
		else
		{
			object[] array2 = keywords.ToArray();
			array = array2;
		}
		object[] args = array;
		string text2 = ImapUtils.FormatIndexSet(Engine, indexes);
		string text3 = string.Empty;
		if (modseq.HasValue)
		{
			text3 = string.Format(CultureInfo.InvariantCulture, " (UNCHANGEDSINCE {0})", modseq.Value);
		}
		string format = $"STORE {text2}{text3} {action} {text}\r\n";
		ImapCommand ic = Engine.QueueCommand(cancellationToken, this, format, args);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("STORE", ic);
		}
		return GetUnmodified(ic, modseq);
	}

	public override void AddFlags(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if ((flags & MailFolder.SettableFlags) == 0 && (keywords == null || keywords.Count == 0))
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		ModifyFlagsAsync(indexes, null, flags, keywords, silent ? "+FLAGS.SILENT" : "+FLAGS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task AddFlagsAsync(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if ((flags & MailFolder.SettableFlags) == 0 && (keywords == null || keywords.Count == 0))
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		return ModifyFlagsAsync(indexes, null, flags, keywords, silent ? "+FLAGS.SILENT" : "+FLAGS", doAsync: true, cancellationToken);
	}

	public override void RemoveFlags(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if ((flags & MailFolder.SettableFlags) == 0 && (keywords == null || keywords.Count == 0))
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		ModifyFlagsAsync(indexes, null, flags, keywords, silent ? "-FLAGS.SILENT" : "-FLAGS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task RemoveFlagsAsync(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if ((flags & MailFolder.SettableFlags) == 0 && (keywords == null || keywords.Count == 0))
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		return ModifyFlagsAsync(indexes, null, flags, keywords, silent ? "-FLAGS.SILENT" : "-FLAGS", doAsync: true, cancellationToken);
	}

	public override void SetFlags(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		ModifyFlagsAsync(indexes, null, flags, keywords, silent ? "FLAGS.SILENT" : "FLAGS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task SetFlagsAsync(IList<int> indexes, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ModifyFlagsAsync(indexes, null, flags, keywords, silent ? "FLAGS.SILENT" : "FLAGS", doAsync: true, cancellationToken);
	}

	public override IList<int> AddFlags(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if ((flags & MailFolder.SettableFlags) == 0 && (keywords == null || keywords.Count == 0))
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		return ModifyFlagsAsync(indexes, modseq, flags, keywords, silent ? "+FLAGS.SILENT" : "+FLAGS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<int>> AddFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if ((flags & MailFolder.SettableFlags) == 0 && (keywords == null || keywords.Count == 0))
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		return ModifyFlagsAsync(indexes, modseq, flags, keywords, silent ? "+FLAGS.SILENT" : "+FLAGS", doAsync: true, cancellationToken);
	}

	public override IList<int> RemoveFlags(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if ((flags & MailFolder.SettableFlags) == 0 && (keywords == null || keywords.Count == 0))
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		return ModifyFlagsAsync(indexes, modseq, flags, keywords, silent ? "-FLAGS.SILENT" : "-FLAGS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<int>> RemoveFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if ((flags & MailFolder.SettableFlags) == 0 && (keywords == null || keywords.Count == 0))
		{
			throw new ArgumentException("No flags were specified.", "flags");
		}
		return ModifyFlagsAsync(indexes, modseq, flags, keywords, silent ? "-FLAGS.SILENT" : "-FLAGS", doAsync: true, cancellationToken);
	}

	public override IList<int> SetFlags(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ModifyFlagsAsync(indexes, modseq, flags, keywords, silent ? "FLAGS.SILENT" : "FLAGS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<int>> SetFlagsAsync(IList<int> indexes, ulong modseq, MessageFlags flags, HashSet<string> keywords, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ModifyFlagsAsync(indexes, modseq, flags, keywords, silent ? "FLAGS.SILENT" : "FLAGS", doAsync: true, cancellationToken);
	}

	private string LabelListToString(IList<string> labels, ICollection<object> args)
	{
		StringBuilder stringBuilder = new StringBuilder("(");
		for (int i = 0; i < labels.Count; i++)
		{
			if (i > 0)
			{
				stringBuilder.Append(' ');
			}
			if (labels[i] == null)
			{
				stringBuilder.Append("NIL");
				continue;
			}
			switch (labels[i])
			{
			case "\\AllMail":
			case "\\Drafts":
			case "\\Important":
			case "\\Inbox":
			case "\\Spam":
			case "\\Sent":
			case "\\Starred":
			case "\\Trash":
				stringBuilder.Append(labels[i]);
				break;
			default:
				stringBuilder.Append("%S");
				args.Add(Engine.EncodeMailboxName(labels[i]));
				break;
			}
		}
		stringBuilder.Append(')');
		return stringBuilder.ToString();
	}

	private async Task<IList<UniqueId>> ModifyLabelsAsync(IList<UniqueId> uids, ulong? modseq, IList<string> labels, string action, bool doAsync, CancellationToken cancellationToken)
	{
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		if ((Engine.Capabilities & ImapCapabilities.GMailExt1) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the Google Mail extensions.");
		}
		CheckState(open: true, rw: true);
		if (uids.Count == 0)
		{
			return new UniqueId[0];
		}
		string arg = string.Empty;
		if (modseq.HasValue)
		{
			arg = string.Format(CultureInfo.InvariantCulture, " (UNCHANGEDSINCE {0})", modseq.Value);
		}
		List<object> list = new List<object>();
		string arg2 = LabelListToString(labels, list);
		string format = $"UID STORE %s{arg} {action} {arg2}\r\n";
		UniqueIdSet unmodified = null;
		foreach (ImapCommand ic in Engine.QueueCommands(cancellationToken, this, format, uids, list.ToArray()))
		{
			await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
			ProcessResponseCodes(ic, null);
			if (ic.Response != ImapCommandResponse.Ok)
			{
				throw ImapCommandException.Create("STORE", ic);
			}
			ProcessUnmodified(ic, ref unmodified, modseq);
		}
		if (unmodified == null)
		{
			return new UniqueId[0];
		}
		return unmodified;
	}

	public override void AddLabels(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		ModifyLabelsAsync(uids, null, labels, silent ? "+X-GM-LABELS.SILENT" : "+X-GM-LABELS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task AddLabelsAsync(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		return ModifyLabelsAsync(uids, null, labels, silent ? "+X-GM-LABELS.SILENT" : "+X-GM-LABELS", doAsync: true, cancellationToken);
	}

	public override void RemoveLabels(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		ModifyLabelsAsync(uids, null, labels, silent ? "-X-GM-LABELS.SILENT" : "-X-GM-LABELS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task RemoveLabelsAsync(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		return ModifyLabelsAsync(uids, null, labels, silent ? "-X-GM-LABELS.SILENT" : "-X-GM-LABELS", doAsync: true, cancellationToken);
	}

	public override void SetLabels(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		ModifyLabelsAsync(uids, null, labels, silent ? "X-GM-LABELS.SILENT" : "X-GM-LABELS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task SetLabelsAsync(IList<UniqueId> uids, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		return ModifyLabelsAsync(uids, null, labels, silent ? "X-GM-LABELS.SILENT" : "X-GM-LABELS", doAsync: true, cancellationToken);
	}

	public override IList<UniqueId> AddLabels(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		return ModifyLabelsAsync(uids, modseq, labels, silent ? "+X-GM-LABELS.SILENT" : "+X-GM-LABELS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<UniqueId>> AddLabelsAsync(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		return ModifyLabelsAsync(uids, modseq, labels, silent ? "+X-GM-LABELS.SILENT" : "+X-GM-LABELS", doAsync: true, cancellationToken);
	}

	public override IList<UniqueId> RemoveLabels(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		return ModifyLabelsAsync(uids, modseq, labels, silent ? "-X-GM-LABELS.SILENT" : "-X-GM-LABELS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<UniqueId>> RemoveLabelsAsync(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		return ModifyLabelsAsync(uids, modseq, labels, silent ? "-X-GM-LABELS.SILENT" : "-X-GM-LABELS", doAsync: true, cancellationToken);
	}

	public override IList<UniqueId> SetLabels(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		return ModifyLabelsAsync(uids, modseq, labels, silent ? "X-GM-LABELS.SILENT" : "X-GM-LABELS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<UniqueId>> SetLabelsAsync(IList<UniqueId> uids, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		return ModifyLabelsAsync(uids, modseq, labels, silent ? "X-GM-LABELS.SILENT" : "X-GM-LABELS", doAsync: true, cancellationToken);
	}

	private async Task<IList<int>> ModifyLabelsAsync(IList<int> indexes, ulong? modseq, IList<string> labels, string action, bool doAsync, CancellationToken cancellationToken)
	{
		if (indexes == null)
		{
			throw new ArgumentNullException("indexes");
		}
		if ((Engine.Capabilities & ImapCapabilities.GMailExt1) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the Google Mail extensions.");
		}
		CheckState(open: true, rw: true);
		if (indexes.Count == 0)
		{
			return new int[0];
		}
		string text = ImapUtils.FormatIndexSet(Engine, indexes);
		string text2 = string.Empty;
		if (modseq.HasValue)
		{
			text2 = string.Format(CultureInfo.InvariantCulture, " (UNCHANGEDSINCE {0})", modseq.Value);
		}
		List<object> list = new List<object>();
		string text3 = LabelListToString(labels, list);
		string format = $"STORE {text}{text2} {action} {text3}\r\n";
		ImapCommand ic = Engine.QueueCommand(cancellationToken, this, format, list.ToArray());
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("STORE", ic);
		}
		return GetUnmodified(ic, modseq);
	}

	public override void AddLabels(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		ModifyLabelsAsync(indexes, null, labels, silent ? "+X-GM-LABELS.SILENT" : "+X-GM-LABELS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task AddLabelsAsync(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		return ModifyLabelsAsync(indexes, null, labels, silent ? "+X-GM-LABELS.SILENT" : "+X-GM-LABELS", doAsync: true, cancellationToken);
	}

	public override void RemoveLabels(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		ModifyLabelsAsync(indexes, null, labels, silent ? "-X-GM-LABELS.SILENT" : "-X-GM-LABELS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task RemoveLabelsAsync(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		return ModifyLabelsAsync(indexes, null, labels, silent ? "-X-GM-LABELS.SILENT" : "-X-GM-LABELS", doAsync: true, cancellationToken);
	}

	public override void SetLabels(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		ModifyLabelsAsync(indexes, null, labels, silent ? "X-GM-LABELS.SILENT" : "X-GM-LABELS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task SetLabelsAsync(IList<int> indexes, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		return ModifyLabelsAsync(indexes, null, labels, silent ? "X-GM-LABELS.SILENT" : "X-GM-LABELS", doAsync: true, cancellationToken);
	}

	public override IList<int> AddLabels(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		return ModifyLabelsAsync(indexes, modseq, labels, silent ? "+X-GM-LABELS.SILENT" : "+X-GM-LABELS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<int>> AddLabelsAsync(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		return ModifyLabelsAsync(indexes, modseq, labels, silent ? "+X-GM-LABELS.SILENT" : "+X-GM-LABELS", doAsync: true, cancellationToken);
	}

	public override IList<int> RemoveLabels(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		return ModifyLabelsAsync(indexes, modseq, labels, silent ? "-X-GM-LABELS.SILENT" : "-X-GM-LABELS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<int>> RemoveLabelsAsync(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		if (labels.Count == 0)
		{
			throw new ArgumentException("No labels were specified.", "labels");
		}
		return ModifyLabelsAsync(indexes, modseq, labels, silent ? "-X-GM-LABELS.SILENT" : "-X-GM-LABELS", doAsync: true, cancellationToken);
	}

	public override IList<int> SetLabels(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		return ModifyLabelsAsync(indexes, modseq, labels, silent ? "X-GM-LABELS.SILENT" : "X-GM-LABELS", doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<int>> SetLabelsAsync(IList<int> indexes, ulong modseq, IList<string> labels, bool silent, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (labels == null)
		{
			throw new ArgumentNullException("labels");
		}
		return ModifyLabelsAsync(indexes, modseq, labels, silent ? "X-GM-LABELS.SILENT" : "X-GM-LABELS", doAsync: true, cancellationToken);
	}

	private static bool IsAscii(string text)
	{
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] > '\u007f')
			{
				return false;
			}
		}
		return true;
	}

	private static string FormatDateTime(DateTime date)
	{
		return date.ToString("d-MMM-yyyy", CultureInfo.InvariantCulture);
	}

	private bool IsBadCharset(ImapCommand ic, string charset)
	{
		if (ic.Response == ImapCommandResponse.No && ic.RespCodes.Any((ImapResponseCode rc) => rc.Type == ImapResponseCodeType.BadCharset) && charset != null)
		{
			return !Engine.SupportedCharsets.Contains(charset);
		}
		return false;
	}

	private void AddTextArgument(StringBuilder builder, List<object> args, string text, ref string charset)
	{
		if (IsAscii(text))
		{
			builder.Append("%S");
			args.Add(text);
			return;
		}
		if (Engine.SupportedCharsets.Contains("UTF-8"))
		{
			builder.Append("%S");
			charset = "UTF-8";
			args.Add(text);
			return;
		}
		byte[] array = new byte[text.Length];
		for (int i = 0; i < text.Length; i++)
		{
			array[i] = (byte)text[i];
		}
		builder.Append("%L");
		args.Add(array);
	}

	private void BuildQuery(StringBuilder builder, SearchQuery query, List<object> args, bool parens, ref string charset)
	{
		switch (query.Term)
		{
		case SearchTerm.All:
			builder.Append("ALL");
			break;
		case SearchTerm.And:
		{
			BinarySearchQuery binarySearchQuery = (BinarySearchQuery)query;
			if (parens)
			{
				builder.Append('(');
			}
			BuildQuery(builder, binarySearchQuery.Left, args, parens: false, ref charset);
			builder.Append(' ');
			BuildQuery(builder, binarySearchQuery.Right, args, parens: false, ref charset);
			if (parens)
			{
				builder.Append(')');
			}
			break;
		}
		case SearchTerm.Annotation:
		{
			if ((Engine.Capabilities & ImapCapabilities.Annotate) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The ANNOTATION search term is not supported by the IMAP server.");
			}
			AnnotationSearchQuery annotationSearchQuery = (AnnotationSearchQuery)query;
			builder.AppendFormat("ANNOTATION {0} {1} %S", annotationSearchQuery.Entry, annotationSearchQuery.Attribute);
			args.Add(annotationSearchQuery.Value);
			break;
		}
		case SearchTerm.Answered:
			builder.Append("ANSWERED");
			break;
		case SearchTerm.BccContains:
		{
			TextSearchQuery textSearchQuery = (TextSearchQuery)query;
			builder.Append("BCC ");
			AddTextArgument(builder, args, textSearchQuery.Text, ref charset);
			break;
		}
		case SearchTerm.BodyContains:
		{
			TextSearchQuery textSearchQuery = (TextSearchQuery)query;
			builder.Append("BODY ");
			AddTextArgument(builder, args, textSearchQuery.Text, ref charset);
			break;
		}
		case SearchTerm.CcContains:
		{
			TextSearchQuery textSearchQuery = (TextSearchQuery)query;
			builder.Append("CC ");
			AddTextArgument(builder, args, textSearchQuery.Text, ref charset);
			break;
		}
		case SearchTerm.Deleted:
			builder.Append("DELETED");
			break;
		case SearchTerm.DeliveredAfter:
		{
			DateSearchQuery dateSearchQuery = (DateSearchQuery)query;
			builder.AppendFormat("SINCE {0}", FormatDateTime(dateSearchQuery.Date));
			break;
		}
		case SearchTerm.DeliveredBefore:
		{
			DateSearchQuery dateSearchQuery = (DateSearchQuery)query;
			builder.AppendFormat("BEFORE {0}", FormatDateTime(dateSearchQuery.Date));
			break;
		}
		case SearchTerm.DeliveredOn:
		{
			DateSearchQuery dateSearchQuery = (DateSearchQuery)query;
			builder.AppendFormat("ON {0}", FormatDateTime(dateSearchQuery.Date));
			break;
		}
		case SearchTerm.Draft:
			builder.Append("DRAFT");
			break;
		case SearchTerm.Filter:
		{
			if ((Engine.Capabilities & ImapCapabilities.Filters) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The FILTER search term is not supported by the IMAP server.");
			}
			FilterSearchQuery filterSearchQuery = (FilterSearchQuery)query;
			builder.Append("FILTER %S");
			args.Add(filterSearchQuery.Name);
			break;
		}
		case SearchTerm.Flagged:
			builder.Append("FLAGGED");
			break;
		case SearchTerm.FromContains:
		{
			TextSearchQuery textSearchQuery = (TextSearchQuery)query;
			builder.Append("FROM ");
			AddTextArgument(builder, args, textSearchQuery.Text, ref charset);
			break;
		}
		case SearchTerm.Fuzzy:
		{
			if ((Engine.Capabilities & ImapCapabilities.FuzzySearch) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The FUZZY search term is not supported by the IMAP server.");
			}
			builder.Append("FUZZY ");
			UnarySearchQuery unarySearchQuery = (UnarySearchQuery)query;
			BuildQuery(builder, unarySearchQuery.Operand, args, parens: true, ref charset);
			break;
		}
		case SearchTerm.HeaderContains:
		{
			HeaderSearchQuery headerSearchQuery = (HeaderSearchQuery)query;
			builder.AppendFormat("HEADER {0} ", headerSearchQuery.Field);
			AddTextArgument(builder, args, headerSearchQuery.Value, ref charset);
			break;
		}
		case SearchTerm.Keyword:
		{
			TextSearchQuery textSearchQuery = (TextSearchQuery)query;
			builder.Append("KEYWORD ");
			AddTextArgument(builder, args, textSearchQuery.Text, ref charset);
			break;
		}
		case SearchTerm.LargerThan:
		{
			NumericSearchQuery numericSearchQuery = (NumericSearchQuery)query;
			builder.AppendFormat(CultureInfo.InvariantCulture, "LARGER {0}", numericSearchQuery.Value);
			break;
		}
		case SearchTerm.MessageContains:
		{
			TextSearchQuery textSearchQuery = (TextSearchQuery)query;
			builder.Append("TEXT ");
			AddTextArgument(builder, args, textSearchQuery.Text, ref charset);
			break;
		}
		case SearchTerm.ModSeq:
		{
			NumericSearchQuery numericSearchQuery = (NumericSearchQuery)query;
			builder.AppendFormat(CultureInfo.InvariantCulture, "MODSEQ {0}", numericSearchQuery.Value);
			break;
		}
		case SearchTerm.New:
			builder.Append("NEW");
			break;
		case SearchTerm.Not:
		{
			builder.Append("NOT ");
			UnarySearchQuery unarySearchQuery = (UnarySearchQuery)query;
			BuildQuery(builder, unarySearchQuery.Operand, args, parens: true, ref charset);
			break;
		}
		case SearchTerm.NotAnswered:
			builder.Append("UNANSWERED");
			break;
		case SearchTerm.NotDeleted:
			builder.Append("UNDELETED");
			break;
		case SearchTerm.NotDraft:
			builder.Append("UNDRAFT");
			break;
		case SearchTerm.NotFlagged:
			builder.Append("UNFLAGGED");
			break;
		case SearchTerm.NotKeyword:
		{
			TextSearchQuery textSearchQuery = (TextSearchQuery)query;
			builder.Append("UNKEYWORD ");
			AddTextArgument(builder, args, textSearchQuery.Text, ref charset);
			break;
		}
		case SearchTerm.NotRecent:
			builder.Append("OLD");
			break;
		case SearchTerm.NotSeen:
			builder.Append("UNSEEN");
			break;
		case SearchTerm.Older:
		{
			if ((Engine.Capabilities & ImapCapabilities.Within) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The OLDER search term is not supported by the IMAP server.");
			}
			NumericSearchQuery numericSearchQuery = (NumericSearchQuery)query;
			builder.AppendFormat(CultureInfo.InvariantCulture, "OLDER {0}", numericSearchQuery.Value);
			break;
		}
		case SearchTerm.Or:
		{
			builder.Append("OR ");
			BinarySearchQuery binarySearchQuery = (BinarySearchQuery)query;
			BuildQuery(builder, binarySearchQuery.Left, args, parens: true, ref charset);
			builder.Append(' ');
			BuildQuery(builder, binarySearchQuery.Right, args, parens: true, ref charset);
			break;
		}
		case SearchTerm.Recent:
			builder.Append("RECENT");
			break;
		case SearchTerm.SaveDateSupported:
			if ((Engine.Capabilities & ImapCapabilities.SaveDate) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The SAVEDATESUPPORTED search term is not supported by the IMAP server.");
			}
			builder.Append("SAVEDATESUPPORTED");
			break;
		case SearchTerm.SavedBefore:
		{
			if ((Engine.Capabilities & ImapCapabilities.SaveDate) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The SAVEDBEFORE search term is not supported by the IMAP server.");
			}
			DateSearchQuery dateSearchQuery = (DateSearchQuery)query;
			builder.AppendFormat("SAVEDBEFORE {0}", FormatDateTime(dateSearchQuery.Date));
			break;
		}
		case SearchTerm.SavedOn:
		{
			if ((Engine.Capabilities & ImapCapabilities.SaveDate) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The SAVEDON search term is not supported by the IMAP server.");
			}
			DateSearchQuery dateSearchQuery = (DateSearchQuery)query;
			builder.AppendFormat("SAVEDON {0}", FormatDateTime(dateSearchQuery.Date));
			break;
		}
		case SearchTerm.SavedSince:
		{
			if ((Engine.Capabilities & ImapCapabilities.SaveDate) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The SAVEDSINCE search term is not supported by the IMAP server.");
			}
			DateSearchQuery dateSearchQuery = (DateSearchQuery)query;
			builder.AppendFormat("SAVEDSINCE {0}", FormatDateTime(dateSearchQuery.Date));
			break;
		}
		case SearchTerm.Seen:
			builder.Append("SEEN");
			break;
		case SearchTerm.SentBefore:
		{
			DateSearchQuery dateSearchQuery = (DateSearchQuery)query;
			builder.AppendFormat("SENTBEFORE {0}", FormatDateTime(dateSearchQuery.Date));
			break;
		}
		case SearchTerm.SentOn:
		{
			DateSearchQuery dateSearchQuery = (DateSearchQuery)query;
			builder.AppendFormat("SENTON {0}", FormatDateTime(dateSearchQuery.Date));
			break;
		}
		case SearchTerm.SentSince:
		{
			DateSearchQuery dateSearchQuery = (DateSearchQuery)query;
			builder.AppendFormat("SENTSINCE {0}", FormatDateTime(dateSearchQuery.Date));
			break;
		}
		case SearchTerm.SmallerThan:
		{
			NumericSearchQuery numericSearchQuery = (NumericSearchQuery)query;
			builder.AppendFormat(CultureInfo.InvariantCulture, "SMALLER {0}", numericSearchQuery.Value);
			break;
		}
		case SearchTerm.SubjectContains:
		{
			TextSearchQuery textSearchQuery = (TextSearchQuery)query;
			builder.Append("SUBJECT ");
			AddTextArgument(builder, args, textSearchQuery.Text, ref charset);
			break;
		}
		case SearchTerm.ToContains:
		{
			TextSearchQuery textSearchQuery = (TextSearchQuery)query;
			builder.Append("TO ");
			AddTextArgument(builder, args, textSearchQuery.Text, ref charset);
			break;
		}
		case SearchTerm.Uid:
		{
			UidSearchQuery uidSearchQuery = (UidSearchQuery)query;
			builder.AppendFormat("UID {0}", UniqueIdSet.ToString(uidSearchQuery.Uids));
			break;
		}
		case SearchTerm.Younger:
		{
			if ((Engine.Capabilities & ImapCapabilities.Within) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The YOUNGER search term is not supported by the IMAP server.");
			}
			NumericSearchQuery numericSearchQuery = (NumericSearchQuery)query;
			builder.AppendFormat(CultureInfo.InvariantCulture, "YOUNGER {0}", numericSearchQuery.Value);
			break;
		}
		case SearchTerm.GMailMessageId:
		{
			if ((Engine.Capabilities & ImapCapabilities.GMailExt1) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The X-GM-MSGID search term is not supported by the IMAP server.");
			}
			NumericSearchQuery numericSearchQuery = (NumericSearchQuery)query;
			builder.AppendFormat(CultureInfo.InvariantCulture, "X-GM-MSGID {0}", numericSearchQuery.Value);
			break;
		}
		case SearchTerm.GMailThreadId:
		{
			if ((Engine.Capabilities & ImapCapabilities.GMailExt1) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The X-GM-THRID search term is not supported by the IMAP server.");
			}
			NumericSearchQuery numericSearchQuery = (NumericSearchQuery)query;
			builder.AppendFormat(CultureInfo.InvariantCulture, "X-GM-THRID {0}", numericSearchQuery.Value);
			break;
		}
		case SearchTerm.GMailLabels:
		{
			if ((Engine.Capabilities & ImapCapabilities.GMailExt1) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The X-GM-LABELS search term is not supported by the IMAP server.");
			}
			TextSearchQuery textSearchQuery = (TextSearchQuery)query;
			builder.Append("X-GM-LABELS ");
			AddTextArgument(builder, args, textSearchQuery.Text, ref charset);
			break;
		}
		case SearchTerm.GMailRaw:
		{
			if ((Engine.Capabilities & ImapCapabilities.GMailExt1) == ImapCapabilities.None)
			{
				throw new NotSupportedException("The X-GM-RAW search term is not supported by the IMAP server.");
			}
			TextSearchQuery textSearchQuery = (TextSearchQuery)query;
			builder.Append("X-GM-RAW ");
			AddTextArgument(builder, args, textSearchQuery.Text, ref charset);
			break;
		}
		default:
			throw new ArgumentOutOfRangeException();
		}
	}

	private string BuildQueryExpression(SearchQuery query, List<object> args, out string charset)
	{
		StringBuilder stringBuilder = new StringBuilder();
		charset = null;
		BuildQuery(stringBuilder, query, args, parens: false, ref charset);
		return stringBuilder.ToString();
	}

	private string BuildSortOrder(IList<OrderBy> orderBy)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append('(');
		for (int i = 0; i < orderBy.Count; i++)
		{
			if (stringBuilder.Length > 1)
			{
				stringBuilder.Append(' ');
			}
			if (orderBy[i].Order == SortOrder.Descending)
			{
				stringBuilder.Append("REVERSE ");
			}
			switch (orderBy[i].Type)
			{
			case OrderByType.Annotation:
			{
				if ((Engine.Capabilities & ImapCapabilities.Annotate) == ImapCapabilities.None)
				{
					throw new NotSupportedException("The ANNOTATION search term is not supported by the IMAP server.");
				}
				OrderByAnnotation orderByAnnotation = (OrderByAnnotation)orderBy[i];
				stringBuilder.AppendFormat("ANNOTATION {0} {1}", orderByAnnotation.Entry, orderByAnnotation.Attribute);
				break;
			}
			case OrderByType.Arrival:
				stringBuilder.Append("ARRIVAL");
				break;
			case OrderByType.Cc:
				stringBuilder.Append("CC");
				break;
			case OrderByType.Date:
				stringBuilder.Append("DATE");
				break;
			case OrderByType.DisplayFrom:
				if ((Engine.Capabilities & ImapCapabilities.SortDisplay) == ImapCapabilities.None)
				{
					throw new NotSupportedException("The IMAP server does not support the SORT=DISPLAY extension.");
				}
				stringBuilder.Append("DISPLAYFROM");
				break;
			case OrderByType.DisplayTo:
				if ((Engine.Capabilities & ImapCapabilities.SortDisplay) == ImapCapabilities.None)
				{
					throw new NotSupportedException("The IMAP server does not support the SORT=DISPLAY extension.");
				}
				stringBuilder.Append("DISPLAYTO");
				break;
			case OrderByType.From:
				stringBuilder.Append("FROM");
				break;
			case OrderByType.Size:
				stringBuilder.Append("SIZE");
				break;
			case OrderByType.Subject:
				stringBuilder.Append("SUBJECT");
				break;
			case OrderByType.To:
				stringBuilder.Append("TO");
				break;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}
		stringBuilder.Append(')');
		return stringBuilder.ToString();
	}

	private static async Task SearchMatchesAsync(ImapEngine engine, ImapCommand ic, int index, bool doAsync)
	{
		SearchResults results = (SearchResults)ic.UserData;
		IList<UniqueId> uids = results.UniqueIds;
		ImapToken imapToken;
		while (true)
		{
			imapToken = await engine.PeekTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			if (imapToken.Type == ImapTokenType.Eoln || imapToken.Type == ImapTokenType.OpenParen)
			{
				break;
			}
			imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			uint id = ImapEngine.ParseNumber(imapToken, true, "Syntax error in untagged {0} response. {1}", "SEARCH", imapToken);
			uids.Add(new UniqueId(ic.Folder.UidValidity, id));
		}
		if (imapToken.Type == ImapTokenType.OpenParen)
		{
			await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			do
			{
				imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (imapToken.Type == ImapTokenType.CloseParen)
				{
					break;
				}
				ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "SEARCH", imapToken);
				string atom = (string)imapToken.Value;
				string text = atom.ToUpperInvariant();
				if (text == "MODSEQ")
				{
					imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					results.ModSeq = ImapEngine.ParseNumber64(imapToken, false, "Syntax error in {0}. {1}", atom, imapToken);
				}
			}
			while ((await engine.PeekTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false)).Type != ImapTokenType.Eoln);
		}
		results.UniqueIds = uids;
	}

	private static async Task ESearchMatchesAsync(ImapEngine engine, ImapCommand ic, int index, bool doAsync)
	{
		ImapToken imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		SearchResults results = (SearchResults)ic.UserData;
		int parenDepth = 0;
		if (imapToken.Type == ImapTokenType.OpenParen)
		{
			while (true)
			{
				imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				if (imapToken.Type == ImapTokenType.CloseParen)
				{
					break;
				}
				ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "ESEARCH", imapToken);
				string atom = (string)imapToken.Value;
				if (atom == "TAG")
				{
					imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, ImapTokenType.QString, "Syntax error in untagged {0} response. {1}", "ESEARCH", imapToken);
					string text = (string)imapToken.Value;
					if (text != ic.Tag)
					{
						throw new ImapProtocolException("Unexpected TAG value in untagged ESEARCH response: " + text);
					}
				}
			}
			imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		if (imapToken.Type == ImapTokenType.Atom && (string)imapToken.Value == "UID")
		{
			imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		while (true)
		{
			if (imapToken.Type == ImapTokenType.CloseParen)
			{
				if (parenDepth == 0)
				{
					throw ImapEngine.UnexpectedToken("Syntax error in untagged {0} response. {1}", "ESEARCH", imapToken);
				}
				imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				parenDepth--;
			}
			if (imapToken.Type == ImapTokenType.Eoln)
			{
				break;
			}
			if (imapToken.Type == ImapTokenType.OpenParen)
			{
				imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
				parenDepth++;
			}
			ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "ESEARCH", imapToken);
			string atom = (string)imapToken.Value;
			imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			switch (atom.ToUpperInvariant())
			{
			case "RELEVANCY":
				ImapEngine.AssertToken(imapToken, ImapTokenType.OpenParen, "Syntax error in untagged {0} response. {1}", "ESEARCH", imapToken);
				results.Relevancy = new List<byte>();
				while (true)
				{
					imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
					if (imapToken.Type == ImapTokenType.CloseParen)
					{
						break;
					}
					uint num = ImapEngine.ParseNumber(imapToken, true, "Syntax error in untagged {0} response. {1}", "ESEARCH", imapToken);
					if (num > 100)
					{
						throw ImapEngine.UnexpectedToken("Syntax error in untagged {0} response. {1}", "ESEARCH", imapToken);
					}
					results.Relevancy.Add((byte)num);
				}
				break;
			case "MODSEQ":
				ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "ESEARCH", imapToken);
				results.ModSeq = ImapEngine.ParseNumber64(imapToken, false, "Syntax error in {0}. {1}", atom, imapToken);
				break;
			case "COUNT":
			{
				ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "ESEARCH", imapToken);
				uint count = ImapEngine.ParseNumber(imapToken, false, "Syntax error in {0}. {1}", atom, imapToken);
				results.Count = (int)count;
				break;
			}
			case "MIN":
			{
				ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "ESEARCH", imapToken);
				uint id2 = ImapEngine.ParseNumber(imapToken, true, "Syntax error in {0}. {1}", atom, imapToken);
				results.Min = new UniqueId(ic.Folder.UidValidity, id2);
				break;
			}
			case "MAX":
			{
				ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "ESEARCH", imapToken);
				uint id = ImapEngine.ParseNumber(imapToken, true, "Syntax error in {0}. {1}", atom, imapToken);
				results.Max = new UniqueId(ic.Folder.UidValidity, id);
				break;
			}
			case "ALL":
			{
				ImapEngine.AssertToken(imapToken, ImapTokenType.Atom, "Syntax error in untagged {0} response. {1}", "ESEARCH", imapToken);
				UniqueIdSet uniqueIdSet = ImapEngine.ParseUidSet(imapToken, ic.Folder.UidValidity, "Syntax error in {0}. {1}", atom, imapToken);
				results.Count = uniqueIdSet.Count;
				results.UniqueIds = uniqueIdSet;
				break;
			}
			default:
				throw ImapEngine.UnexpectedToken("Syntax error in untagged {0} response. {1}", "ESEARCH", imapToken);
			}
			imapToken = await engine.ReadTokenAsync(doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		engine.Stream.UngetToken(imapToken);
	}

	private async Task<SearchResults> SearchAsync(string query, bool doAsync, CancellationToken cancellationToken)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		query = query.Trim();
		if (query.Length == 0)
		{
			throw new ArgumentException("Cannot search using an empty query.", "query");
		}
		CheckState(open: true, rw: false);
		string format = "UID SEARCH " + query + "\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		if ((Engine.Capabilities & ImapCapabilities.ESearch) != ImapCapabilities.None)
		{
			ic.RegisterUntaggedHandler("ESEARCH", ESearchMatchesAsync);
		}
		ic.RegisterUntaggedHandler("SEARCH", SearchMatchesAsync);
		ic.UserData = new SearchResults(base.UidValidity, SortOrder.Ascending);
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("SEARCH", ic);
		}
		return (SearchResults)ic.UserData;
	}

	public virtual SearchResults Search(string query, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SearchAsync(query, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public virtual Task<SearchResults> SearchAsync(string query, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SearchAsync(query, doAsync: true, cancellationToken);
	}

	private async Task<IList<UniqueId>> SearchAsync(SearchQuery query, bool doAsync, bool retry, CancellationToken cancellationToken)
	{
		List<object> list = new List<object>();
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		CheckState(open: true, rw: false);
		SearchQuery query2 = query.Optimize(new ImapSearchQueryOptimizer());
		string charset;
		string text = BuildQueryExpression(query2, list, out charset);
		string text2 = "UID SEARCH ";
		if ((Engine.Capabilities & ImapCapabilities.ESearch) != ImapCapabilities.None)
		{
			text2 += "RETURN (ALL) ";
		}
		if (charset != null && list.Count > 0 && !Engine.UTF8Enabled)
		{
			text2 = text2 + "CHARSET " + charset + " ";
		}
		text2 = text2 + text + "\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, text2, list.ToArray());
		if ((Engine.Capabilities & ImapCapabilities.ESearch) != ImapCapabilities.None)
		{
			ic.RegisterUntaggedHandler("ESEARCH", ESearchMatchesAsync);
		}
		ic.RegisterUntaggedHandler("SEARCH", SearchMatchesAsync);
		ic.UserData = new SearchResults(base.UidValidity, SortOrder.Ascending);
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			if (retry && IsBadCharset(ic, charset))
			{
				return await SearchAsync(query, doAsync, retry: false, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			throw ImapCommandException.Create("SEARCH", ic);
		}
		return ((SearchResults)ic.UserData).UniqueIds;
	}

	public override IList<UniqueId> Search(SearchQuery query, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SearchAsync(query, doAsync: false, retry: true, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<UniqueId>> SearchAsync(SearchQuery query, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SearchAsync(query, doAsync: true, retry: true, cancellationToken);
	}

	private async Task<SearchResults> SearchAsync(SearchOptions options, SearchQuery query, bool doAsync, bool retry, CancellationToken cancellationToken)
	{
		List<object> list = new List<object>();
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		CheckState(open: true, rw: false);
		if ((Engine.Capabilities & ImapCapabilities.ESearch) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the ESEARCH extension.");
		}
		SearchQuery query2 = query.Optimize(new ImapSearchQueryOptimizer());
		string charset;
		string text = BuildQueryExpression(query2, list, out charset);
		string text2 = "UID SEARCH RETURN (";
		if (options != SearchOptions.All && options != SearchOptions.None)
		{
			if ((options & SearchOptions.All) != SearchOptions.None)
			{
				text2 += "ALL ";
			}
			if ((options & SearchOptions.Relevancy) != SearchOptions.None)
			{
				text2 += "RELEVANCY ";
			}
			if ((options & SearchOptions.Count) != SearchOptions.None)
			{
				text2 += "COUNT ";
			}
			if ((options & SearchOptions.Min) != SearchOptions.None)
			{
				text2 += "MIN ";
			}
			if ((options & SearchOptions.Max) != SearchOptions.None)
			{
				text2 += "MAX ";
			}
			text2 = text2.TrimEnd();
		}
		text2 += ") ";
		if (charset != null && list.Count > 0 && !Engine.UTF8Enabled)
		{
			text2 = text2 + "CHARSET " + charset + " ";
		}
		text2 = text2 + text + "\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, text2, list.ToArray());
		ic.RegisterUntaggedHandler("ESEARCH", ESearchMatchesAsync);
		ic.RegisterUntaggedHandler("SEARCH", SearchMatchesAsync);
		ic.UserData = new SearchResults(base.UidValidity);
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			if (retry && IsBadCharset(ic, charset))
			{
				return await SearchAsync(options, query, doAsync, retry: false, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			throw ImapCommandException.Create("SEARCH", ic);
		}
		return (SearchResults)ic.UserData;
	}

	public override SearchResults Search(SearchOptions options, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SearchAsync(options, query, doAsync: false, retry: true, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<SearchResults> SearchAsync(SearchOptions options, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SearchAsync(options, query, doAsync: true, retry: true, cancellationToken);
	}

	private async Task<SearchResults> SortAsync(string query, bool doAsync, CancellationToken cancellationToken)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		query = query.Trim();
		if (query.Length == 0)
		{
			throw new ArgumentException("Cannot sort using an empty query.", "query");
		}
		if ((Engine.Capabilities & ImapCapabilities.Sort) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the SORT extension.");
		}
		CheckState(open: true, rw: false);
		string format = "UID SORT " + query + "\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, format);
		if ((Engine.Capabilities & ImapCapabilities.ESort) != ImapCapabilities.None)
		{
			ic.RegisterUntaggedHandler("ESEARCH", ESearchMatchesAsync);
		}
		ic.RegisterUntaggedHandler("SORT", SearchMatchesAsync);
		ic.UserData = new SearchResults(base.UidValidity);
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			throw ImapCommandException.Create("SORT", ic);
		}
		return (SearchResults)ic.UserData;
	}

	public virtual SearchResults Sort(string query, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SortAsync(query, doAsync: false, cancellationToken).GetAwaiter().GetResult();
	}

	public virtual Task<SearchResults> SortAsync(string query, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SortAsync(query, doAsync: true, cancellationToken);
	}

	private async Task<IList<UniqueId>> SortAsync(SearchQuery query, IList<OrderBy> orderBy, bool doAsync, bool retry, CancellationToken cancellationToken)
	{
		List<object> list = new List<object>();
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		if (orderBy == null)
		{
			throw new ArgumentNullException("orderBy");
		}
		if (orderBy.Count == 0)
		{
			throw new ArgumentException("No sort order provided.", "orderBy");
		}
		CheckState(open: true, rw: false);
		if ((Engine.Capabilities & ImapCapabilities.Sort) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the SORT extension.");
		}
		SearchQuery query2 = query.Optimize(new ImapSearchQueryOptimizer());
		string charset;
		string text = BuildQueryExpression(query2, list, out charset);
		string text2 = BuildSortOrder(orderBy);
		string text3 = "UID SORT ";
		if ((Engine.Capabilities & ImapCapabilities.ESort) != ImapCapabilities.None)
		{
			text3 += "RETURN (ALL) ";
		}
		text3 = text3 + text2 + " " + (charset ?? "US-ASCII") + " " + text + "\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, text3, list.ToArray());
		if ((Engine.Capabilities & ImapCapabilities.ESort) != ImapCapabilities.None)
		{
			ic.RegisterUntaggedHandler("ESEARCH", ESearchMatchesAsync);
		}
		else
		{
			ic.RegisterUntaggedHandler("SORT", SearchMatchesAsync);
		}
		ic.UserData = new SearchResults(base.UidValidity);
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			if (retry && IsBadCharset(ic, charset))
			{
				return await SortAsync(query, orderBy, doAsync, retry: false, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			throw ImapCommandException.Create("SORT", ic);
		}
		return ((SearchResults)ic.UserData).UniqueIds;
	}

	public override IList<UniqueId> Sort(SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SortAsync(query, orderBy, doAsync: false, retry: true, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<UniqueId>> SortAsync(SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SortAsync(query, orderBy, doAsync: true, retry: true, cancellationToken);
	}

	private async Task<SearchResults> SortAsync(SearchOptions options, SearchQuery query, IList<OrderBy> orderBy, bool doAsync, bool retry, CancellationToken cancellationToken)
	{
		List<object> list = new List<object>();
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		if (orderBy == null)
		{
			throw new ArgumentNullException("orderBy");
		}
		if (orderBy.Count == 0)
		{
			throw new ArgumentException("No sort order provided.", "orderBy");
		}
		CheckState(open: true, rw: false);
		if ((Engine.Capabilities & ImapCapabilities.ESort) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the ESORT extension.");
		}
		SearchQuery query2 = query.Optimize(new ImapSearchQueryOptimizer());
		string charset;
		string text = BuildQueryExpression(query2, list, out charset);
		string text2 = BuildSortOrder(orderBy);
		string text3 = "UID SORT RETURN (";
		if (options != SearchOptions.All && options != SearchOptions.None)
		{
			if ((options & SearchOptions.All) != SearchOptions.None)
			{
				text3 += "ALL ";
			}
			if ((options & SearchOptions.Relevancy) != SearchOptions.None)
			{
				text3 += "RELEVANCY ";
			}
			if ((options & SearchOptions.Count) != SearchOptions.None)
			{
				text3 += "COUNT ";
			}
			if ((options & SearchOptions.Min) != SearchOptions.None)
			{
				text3 += "MIN ";
			}
			if ((options & SearchOptions.Max) != SearchOptions.None)
			{
				text3 += "MAX ";
			}
			text3 = text3.TrimEnd();
		}
		text3 += ") ";
		text3 = text3 + text2 + " " + (charset ?? "US-ASCII") + " " + text + "\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, text3, list.ToArray());
		ic.RegisterUntaggedHandler("ESEARCH", ESearchMatchesAsync);
		ic.UserData = new SearchResults(base.UidValidity);
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			if (retry && IsBadCharset(ic, charset))
			{
				return await SortAsync(options, query, orderBy, doAsync, retry: false, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			throw ImapCommandException.Create("SORT", ic);
		}
		return (SearchResults)ic.UserData;
	}

	public override SearchResults Sort(SearchOptions options, SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SortAsync(options, query, orderBy, doAsync: false, retry: true, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<SearchResults> SortAsync(SearchOptions options, SearchQuery query, IList<OrderBy> orderBy, CancellationToken cancellationToken = default(CancellationToken))
	{
		return SortAsync(options, query, orderBy, doAsync: true, retry: true, cancellationToken);
	}

	private static async Task ThreadMatchesAsync(ImapEngine engine, ImapCommand ic, int index, bool doAsync)
	{
		ic.UserData = await ImapUtils.ParseThreadsAsync(engine, ic.Folder.UidValidity, doAsync, ic.CancellationToken).ConfigureAwait(continueOnCapturedContext: false);
	}

	private async Task<IList<MessageThread>> ThreadAsync(ThreadingAlgorithm algorithm, SearchQuery query, bool doAsync, bool retry, CancellationToken cancellationToken)
	{
		string text = algorithm.ToString().ToUpperInvariant();
		List<object> list = new List<object>();
		if ((Engine.Capabilities & ImapCapabilities.Thread) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the THREAD extension.");
		}
		if (!Engine.ThreadingAlgorithms.Contains(algorithm))
		{
			throw new ArgumentOutOfRangeException("algorithm", "The specified threading algorithm is not supported.");
		}
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		CheckState(open: true, rw: false);
		SearchQuery query2 = query.Optimize(new ImapSearchQueryOptimizer());
		string charset;
		string text2 = BuildQueryExpression(query2, list, out charset);
		string text3 = "UID THREAD " + text + " " + (charset ?? "US-ASCII") + " ";
		text3 = text3 + text2 + "\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, text3, list.ToArray());
		ic.RegisterUntaggedHandler("THREAD", ThreadMatchesAsync);
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			if (retry && IsBadCharset(ic, charset))
			{
				return await ThreadAsync(algorithm, query, doAsync, retry: false, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			throw ImapCommandException.Create("THREAD", ic);
		}
		IList<MessageThread> list2 = (IList<MessageThread>)ic.UserData;
		if (list2 == null)
		{
			return new MessageThread[0];
		}
		return list2;
	}

	public override IList<MessageThread> Thread(ThreadingAlgorithm algorithm, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ThreadAsync(algorithm, query, doAsync: false, retry: true, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<MessageThread>> ThreadAsync(ThreadingAlgorithm algorithm, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ThreadAsync(algorithm, query, doAsync: true, retry: true, cancellationToken);
	}

	private async Task<IList<MessageThread>> ThreadAsync(IList<UniqueId> uids, ThreadingAlgorithm algorithm, SearchQuery query, bool doAsync, bool retry, CancellationToken cancellationToken)
	{
		if (uids == null)
		{
			throw new ArgumentNullException("uids");
		}
		if ((Engine.Capabilities & ImapCapabilities.Thread) == ImapCapabilities.None)
		{
			throw new NotSupportedException("The IMAP server does not support the THREAD extension.");
		}
		if (!Engine.ThreadingAlgorithms.Contains(algorithm))
		{
			throw new ArgumentOutOfRangeException("algorithm", "The specified threading algorithm is not supported.");
		}
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		CheckState(open: true, rw: false);
		if (uids.Count == 0)
		{
			return new MessageThread[0];
		}
		string text = algorithm.ToString().ToUpperInvariant();
		string text2 = UniqueIdSet.ToString(uids);
		List<object> list = new List<object>();
		SearchQuery query2 = query.Optimize(new ImapSearchQueryOptimizer());
		string charset;
		string text3 = BuildQueryExpression(query2, list, out charset);
		string text4 = "UID THREAD " + text + " " + (charset ?? "US-ASCII") + " ";
		text4 = text4 + "UID " + text2 + " " + text3 + "\r\n";
		ImapCommand ic = new ImapCommand(Engine, cancellationToken, this, text4, list.ToArray());
		ic.RegisterUntaggedHandler("THREAD", ThreadMatchesAsync);
		Engine.QueueCommand(ic);
		await Engine.RunAsync(ic, doAsync).ConfigureAwait(continueOnCapturedContext: false);
		ProcessResponseCodes(ic, null);
		if (ic.Response != ImapCommandResponse.Ok)
		{
			if (retry && IsBadCharset(ic, charset))
			{
				return await ThreadAsync(uids, algorithm, query, doAsync, retry: false, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
			}
			throw ImapCommandException.Create("THREAD", ic);
		}
		IList<MessageThread> list2 = (IList<MessageThread>)ic.UserData;
		if (list2 == null)
		{
			return new MessageThread[0];
		}
		return list2;
	}

	public override IList<MessageThread> Thread(IList<UniqueId> uids, ThreadingAlgorithm algorithm, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ThreadAsync(uids, algorithm, query, doAsync: false, retry: true, cancellationToken).GetAwaiter().GetResult();
	}

	public override Task<IList<MessageThread>> ThreadAsync(IList<UniqueId> uids, ThreadingAlgorithm algorithm, SearchQuery query, CancellationToken cancellationToken = default(CancellationToken))
	{
		return ThreadAsync(uids, algorithm, query, doAsync: true, retry: true, cancellationToken);
	}
}
