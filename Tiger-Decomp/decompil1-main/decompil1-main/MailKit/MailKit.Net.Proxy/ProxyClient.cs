using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace MailKit.Net.Proxy;

public abstract class ProxyClient : IProxyClient
{
	public NetworkCredential ProxyCredentials { get; private set; }

	public string ProxyHost { get; private set; }

	public int ProxyPort { get; private set; }

	public IPEndPoint LocalEndPoint { get; set; }

	protected ProxyClient(string host, int port)
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (host.Length == 0 || host.Length > 255)
		{
			throw new ArgumentException("The length of the host name must be between 0 and 256 characters.", "host");
		}
		if (port < 0 || port > 65535)
		{
			throw new ArgumentOutOfRangeException("port");
		}
		ProxyHost = host;
		ProxyPort = ((port == 0) ? 1080 : port);
	}

	protected ProxyClient(string host, int port, NetworkCredential credentials)
		: this(host, port)
	{
		if (credentials == null)
		{
			throw new ArgumentNullException("credentials");
		}
		ProxyCredentials = credentials;
	}

	internal static void ValidateArguments(string host, int port)
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		if (host.Length == 0 || host.Length > 255)
		{
			throw new ArgumentException("The length of the host name must be between 0 and 256 characters.", "host");
		}
		if (port <= 0 || port > 65535)
		{
			throw new ArgumentOutOfRangeException("port");
		}
	}

	private static void ValidateArguments(string host, int port, int timeout)
	{
		ValidateArguments(host, port);
		if (timeout < -1)
		{
			throw new ArgumentOutOfRangeException("timeout");
		}
	}

	private static void AsyncOperationCompleted(object sender, SocketAsyncEventArgs args)
	{
		TaskCompletionSource<bool> taskCompletionSource = (TaskCompletionSource<bool>)args.UserToken;
		if (args.SocketError == SocketError.Success)
		{
			taskCompletionSource.TrySetResult(result: true);
		}
		else
		{
			taskCompletionSource.TrySetException(new SocketException((int)args.SocketError));
		}
	}

	internal static async Task SendAsync(Socket socket, byte[] buffer, int offset, int length, bool doAsync, CancellationToken cancellationToken)
	{
		if (doAsync || cancellationToken.CanBeCanceled)
		{
			TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
			using (cancellationToken.Register(delegate
			{
				tcs.TrySetCanceled();
			}, useSynchronizationContext: false))
			{
				using SocketAsyncEventArgs args = new SocketAsyncEventArgs();
				args.Completed += AsyncOperationCompleted;
				args.SetBuffer(buffer, offset, length);
				args.AcceptSocket = socket;
				args.UserToken = tcs;
				if (!socket.SendAsync(args))
				{
					AsyncOperationCompleted(null, args);
				}
				if (doAsync)
				{
					await tcs.Task.ConfigureAwait(continueOnCapturedContext: false);
				}
				else
				{
					tcs.Task.GetAwaiter().GetResult();
				}
				return;
			}
		}
		SocketUtils.Poll(socket, SelectMode.SelectWrite, cancellationToken);
		socket.Send(buffer, offset, length, SocketFlags.None);
	}

	internal static async Task<int> ReceiveAsync(Socket socket, byte[] buffer, int offset, int length, bool doAsync, CancellationToken cancellationToken)
	{
		if (doAsync || cancellationToken.CanBeCanceled)
		{
			TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
			using (cancellationToken.Register(delegate
			{
				tcs.TrySetCanceled();
			}, useSynchronizationContext: false))
			{
				using SocketAsyncEventArgs args = new SocketAsyncEventArgs();
				args.Completed += AsyncOperationCompleted;
				args.SetBuffer(buffer, offset, length);
				args.AcceptSocket = socket;
				args.UserToken = tcs;
				if (!socket.ReceiveAsync(args))
				{
					AsyncOperationCompleted(null, args);
				}
				if (doAsync)
				{
					await tcs.Task.ConfigureAwait(continueOnCapturedContext: false);
				}
				else
				{
					tcs.Task.GetAwaiter().GetResult();
				}
				return args.BytesTransferred;
			}
		}
		SocketUtils.Poll(socket, SelectMode.SelectRead, cancellationToken);
		return socket.Receive(buffer, offset, length, SocketFlags.None);
	}

	public abstract Socket Connect(string host, int port, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<Socket> ConnectAsync(string host, int port, CancellationToken cancellationToken = default(CancellationToken));

	public virtual Socket Connect(string host, int port, int timeout, CancellationToken cancellationToken = default(CancellationToken))
	{
		ValidateArguments(host, port, timeout);
		using CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(timeout);
		using CancellationTokenSource cancellationTokenSource2 = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, cancellationTokenSource.Token);
		try
		{
			return Connect(host, port, cancellationTokenSource2.Token);
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

	public virtual async Task<Socket> ConnectAsync(string host, int port, int timeout, CancellationToken cancellationToken = default(CancellationToken))
	{
		ValidateArguments(host, port, timeout);
		using CancellationTokenSource ts = new CancellationTokenSource(timeout);
		using CancellationTokenSource linked = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, ts.Token);
		try
		{
			return await ConnectAsync(host, port, linked.Token).ConfigureAwait(continueOnCapturedContext: false);
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
}
