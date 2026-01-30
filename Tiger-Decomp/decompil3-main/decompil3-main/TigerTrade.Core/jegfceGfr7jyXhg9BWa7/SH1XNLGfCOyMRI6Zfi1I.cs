using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EDugZvNwF6e5LYsQZ3C5;
using nff6NvN8pYC4xeKDOd05;
using OrDDjnN8w7riQsQI5MiI;

namespace jegfceGfr7jyXhg9BWa7;

public class SH1XNLGfCOyMRI6Zfi1I<TVOfASNwc3YBCc7cklGi>
{
	private DateTime lXSGf7sNlUO;

	private readonly int WtOGf8AfnEF;

	private Func<Task<TVOfASNwc3YBCc7cklGi>> TiVGfAB9vxs;

	private object iTHGfPb3MKa;

	private bool yBrGfJZkQx7;

	private Task<TVOfASNwc3YBCc7cklGi> N0wGfFskOTf;

	private CancellationTokenSource moiGf3Oxt5K;

	internal static object gfMcfekfwqN8t9P96wth;

	public SH1XNLGfCOyMRI6Zfi1I(int P_0)
	{
		PtePeuN8hTquEuspcXYX.w8xk43ZFh0t();
		iTHGfPb3MKa = new object();
		moiGf3Oxt5K = new CancellationTokenSource();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_602f961efba14121b5babc65d1c5b5fc == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			WtOGf8AfnEF = P_0;
			num = 1;
			if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_69c5a0be35f641e2a0aee7e7539714fa == 0)
			{
				num = 1;
			}
		}
	}

	public Task<TVOfASNwc3YBCc7cklGi> RslGfKJwbUF(Func<Task<TVOfASNwc3YBCc7cklGi>> P_0)
	{
		lock (iTHGfPb3MKa)
		{
			TiVGfAB9vxs = P_0;
			lXSGf7sNlUO = DateTime.UtcNow;
			if (yBrGfJZkQx7 && !moiGf3Oxt5K.IsCancellationRequested)
			{
				return N0wGfFskOTf;
			}
			yBrGfJZkQx7 = true;
			N0wGfFskOTf = Task.Run(delegate
			{
				moiGf3Oxt5K.Token.Register(delegate
				{
					yBrGfJZkQx7 = false;
					moiGf3Oxt5K = new CancellationTokenSource();
				});
				do
				{
					Thread.Sleep(Math.Max((int)((double)WtOGf8AfnEF - (DateTime.UtcNow - lXSGf7sNlUO).TotalMilliseconds), 1));
				}
				while ((DateTime.UtcNow - lXSGf7sNlUO).TotalMilliseconds < (double)WtOGf8AfnEF);
				TVOfASNwc3YBCc7cklGi result = default(TVOfASNwc3YBCc7cklGi);
				try
				{
					if (!moiGf3Oxt5K.IsCancellationRequested)
					{
						result = TiVGfAB9vxs().Result;
					}
					moiGf3Oxt5K = new CancellationTokenSource();
					return result;
				}
				finally
				{
					lock (iTHGfPb3MKa)
					{
						yBrGfJZkQx7 = false;
					}
				}
			}, moiGf3Oxt5K.Token);
			return N0wGfFskOTf;
		}
	}

	public void HIcGfm181G4()
	{
		object obj = iTHGfPb3MKa;
		bool lockTaken = false;
		int num = 0;
		if (_003CModule_003E_007B968a7cfd_002D7850_002D4b40_002Dba2d_002D39fdc6ac4090_007D.m_a883f9217a0145f6ad83c958cbe5302c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			moiGf3Oxt5K.Cancel(throwOnFirstException: true);
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(obj);
			}
		}
	}

	[CompilerGenerated]
	private TVOfASNwc3YBCc7cklGi n4jGfhD03ju()
	{
		moiGf3Oxt5K.Token.Register(delegate
		{
			yBrGfJZkQx7 = false;
			moiGf3Oxt5K = new CancellationTokenSource();
		});
		do
		{
			Thread.Sleep(Math.Max((int)((double)WtOGf8AfnEF - (DateTime.UtcNow - lXSGf7sNlUO).TotalMilliseconds), 1));
		}
		while ((DateTime.UtcNow - lXSGf7sNlUO).TotalMilliseconds < (double)WtOGf8AfnEF);
		TVOfASNwc3YBCc7cklGi result = default(TVOfASNwc3YBCc7cklGi);
		try
		{
			if (!moiGf3Oxt5K.IsCancellationRequested)
			{
				result = TiVGfAB9vxs().Result;
			}
			moiGf3Oxt5K = new CancellationTokenSource();
			return result;
		}
		finally
		{
			lock (iTHGfPb3MKa)
			{
				yBrGfJZkQx7 = false;
			}
		}
	}

	[CompilerGenerated]
	private void C5kGfwTc2YS()
	{
		yBrGfJZkQx7 = false;
		moiGf3Oxt5K = new CancellationTokenSource();
	}

	static SH1XNLGfCOyMRI6Zfi1I()
	{
		RUVZnUNwJg2VA9xTOL2q.hFyN7BZEP4e();
		a3PXAGN83gwBrevdAXnH.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool BVAycckf7L2tLIfG5b0V()
	{
		return gfMcfekfwqN8t9P96wth == null;
	}

	internal static object vKBSKakf8qLFFMVKFD5I()
	{
		return gfMcfekfwqN8t9P96wth;
	}
}
