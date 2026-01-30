using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace MailKit.Net;

internal static class SocketUtils
{
	public static async Task<Socket> ConnectAsync(string host, int port, IPEndPoint localEndPoint, bool doAsync, CancellationToken cancellationToken)
	{
		cancellationToken.ThrowIfCancellationRequested();
		IPAddress[] ipAddresses = ((!doAsync) ? Dns.GetHostAddressesAsync(host).GetAwaiter().GetResult() : (await Dns.GetHostAddressesAsync(host).ConfigureAwait(continueOnCapturedContext: false)));
		for (int i = 0; i < ipAddresses.Length; i++)
		{
			cancellationToken.ThrowIfCancellationRequested();
			Socket socket = new Socket(ipAddresses[i].AddressFamily, SocketType.Stream, ProtocolType.Tcp);
			try
			{
				if (localEndPoint != null)
				{
					socket.Bind(localEndPoint);
				}
				if (doAsync || cancellationToken.CanBeCanceled)
				{
					TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
					using (cancellationToken.Register(delegate
					{
						tcs.TrySetCanceled();
					}, useSynchronizationContext: false))
					{
						IAsyncResult ar = socket.BeginConnect(ipAddresses[i], port, delegate
						{
							tcs.TrySetResult(result: true);
						}, null);
						if (doAsync)
						{
							await tcs.Task.ConfigureAwait(continueOnCapturedContext: false);
						}
						else
						{
							tcs.Task.GetAwaiter().GetResult();
						}
						socket.EndConnect(ar);
					}
				}
				else
				{
					socket.Connect(ipAddresses[i], port);
				}
				return socket;
			}
			catch (OperationCanceledException)
			{
				socket.Dispose();
				throw;
			}
			catch
			{
				socket.Dispose();
				if (i + 1 == ipAddresses.Length)
				{
					throw;
				}
			}
		}
		throw new IOException($"Failed to resolve host: {host}");
	}

	public static async Task<Socket> ConnectAsync(string host, int port, IPEndPoint localEndPoint, int timeout, bool doAsync, CancellationToken cancellationToken)
	{
		using CancellationTokenSource ts = new CancellationTokenSource(timeout);
		using CancellationTokenSource linked = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, ts.Token);
		try
		{
			return await ConnectAsync(host, port, localEndPoint, doAsync, linked.Token).ConfigureAwait(continueOnCapturedContext: false);
		}
		catch (OperationCanceledException)
		{
			if (!cancellationToken.IsCancellationRequested)
			{
				throw new TimeoutException();
			}
			throw;
		}
	}

	public static void Poll(Socket socket, SelectMode mode, CancellationToken cancellationToken)
	{
		do
		{
			cancellationToken.ThrowIfCancellationRequested();
		}
		while (!socket.Poll(250000, mode));
	}
}
