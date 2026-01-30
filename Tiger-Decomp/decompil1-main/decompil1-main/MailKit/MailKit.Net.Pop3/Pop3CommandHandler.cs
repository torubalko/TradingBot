using System.Threading.Tasks;

namespace MailKit.Net.Pop3;

internal delegate Task Pop3CommandHandler(Pop3Engine engine, Pop3Command pc, string text, bool doAsync);
