using System.Threading.Tasks;

namespace MailKit.Net.Imap;

internal delegate Task ImapContinuationHandler(ImapEngine engine, ImapCommand ic, string text, bool doAsync);
