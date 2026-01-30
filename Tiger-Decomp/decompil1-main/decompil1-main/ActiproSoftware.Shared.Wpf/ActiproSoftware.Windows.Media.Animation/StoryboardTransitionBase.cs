using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media.Animation;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media.Animation;

public abstract class StoryboardTransitionBase : Transition
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public StoryboardTransitionBase qU9;

		public TransitionPresenter presenter;

		public FrameworkElement wUh;

		public Storyboard YUm;

		public FrameworkElement RUw;

		public Storyboard LU4;

		internal static _003C_003Ec__DisplayClass7_0 Qjv;

		public _003C_003Ec__DisplayClass7_0()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal static bool qja()
		{
			return Qjv == null;
		}

		internal static _003C_003Ec__DisplayClass7_0 ujy()
		{
			return Qjv;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_1
	{
		public bool rUu;

		public _003C_003Ec__DisplayClass7_0 LU2;

		internal static _003C_003Ec__DisplayClass7_1 yjQ;

		public _003C_003Ec__DisplayClass7_1()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal static bool yjC()
		{
			return yjQ == null;
		}

		internal static _003C_003Ec__DisplayClass7_1 yjR()
		{
			return yjQ;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_2
	{
		public EventHandler BU7;

		public _003C_003Ec__DisplayClass7_1 vUF;

		internal static _003C_003Ec__DisplayClass7_2 bj9;

		public _003C_003Ec__DisplayClass7_2()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal void EUe(object _003Cp0_003E, EventArgs _003Cp1_003E)
		{
			if (vUF.rUu)
			{
				vUF.LU2.qU9.EndTransition(vUF.LU2.presenter, vUF.LU2.wUh, vUF.LU2.YUm, vUF.LU2.RUw, vUF.LU2.LU4);
			}
			vUF.rUu = true;
			vUF.LU2.YUm.Completed -= BU7;
		}

		internal static bool Mjc()
		{
			return bj9 == null;
		}

		internal static _003C_003Ec__DisplayClass7_2 zju()
		{
			return bj9;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_3
	{
		public EventHandler HUQ;

		public _003C_003Ec__DisplayClass7_1 RUO;

		internal static _003C_003Ec__DisplayClass7_3 Ojo;

		public _003C_003Ec__DisplayClass7_3()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal void MUo(object _003Cp0_003E, EventArgs _003Cp1_003E)
		{
			if (RUO.rUu)
			{
				RUO.LU2.qU9.EndTransition(RUO.LU2.presenter, RUO.LU2.wUh, RUO.LU2.YUm, RUO.LU2.RUw, RUO.LU2.LU4);
			}
			RUO.rUu = true;
			RUO.LU2.LU4.Completed -= HUQ;
		}

		internal static bool hj5()
		{
			return Ojo == null;
		}

		internal static _003C_003Ec__DisplayClass7_3 Ejm()
		{
			return Ojo;
		}
	}

	internal static StoryboardTransitionBase RHj;

	protected virtual Storyboard GetFromContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return null;
	}

	protected virtual Style GetFromContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return null;
	}

	protected virtual Style GetFromContentStyle(TransitionPresenter presenter, FrameworkElement fromContent, FrameworkElement toContent)
	{
		return GetFromContentStyle(presenter, fromContent);
	}

	protected virtual Storyboard GetToContentStoryboard(TransitionPresenter presenter, FrameworkElement content)
	{
		return null;
	}

	protected virtual Style GetToContentStyle(TransitionPresenter presenter, FrameworkElement content)
	{
		return null;
	}

	protected virtual Style GetToContentStyle(TransitionPresenter presenter, FrameworkElement toContent, FrameworkElement fromContent)
	{
		return GetToContentStyle(presenter, toContent);
	}

	protected override void OnCompleted(TransitionPresenter presenter, FrameworkElement fromContent, object fromContentData, FrameworkElement toContent, object toContentData)
	{
		if (fromContentData is Storyboard storyboard)
		{
			int num = 0;
			if (VH6() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			storyboard.Stop(fromContent);
		}
		if (toContentData is Storyboard storyboard2)
		{
			storyboard2.Stop(toContent);
		}
		fromContent?.ClearValue(FrameworkElement.StyleProperty);
		toContent?.ClearValue(FrameworkElement.StyleProperty);
	}

	protected override void OnStarted(TransitionPresenter presenter, FrameworkElement fromContent, FrameworkElement toContent)
	{
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
		_003C_003Ec__DisplayClass7_.qU9 = this;
		_003C_003Ec__DisplayClass7_.presenter = presenter;
		_003C_003Ec__DisplayClass7_.wUh = fromContent;
		_003C_003Ec__DisplayClass7_.RUw = toContent;
		_003C_003Ec__DisplayClass7_.YUm = GetFromContentStoryboard(_003C_003Ec__DisplayClass7_.presenter, _003C_003Ec__DisplayClass7_.wUh);
		_003C_003Ec__DisplayClass7_.LU4 = GetToContentStoryboard(_003C_003Ec__DisplayClass7_.presenter, _003C_003Ec__DisplayClass7_.RUw);
		if (_003C_003Ec__DisplayClass7_.YUm != null || _003C_003Ec__DisplayClass7_.LU4 != null)
		{
			_003C_003Ec__DisplayClass7_1 _003C_003Ec__DisplayClass7_2 = new _003C_003Ec__DisplayClass7_1();
			_003C_003Ec__DisplayClass7_2.LU2 = _003C_003Ec__DisplayClass7_;
			_003C_003Ec__DisplayClass7_2.LU2.wUh.Style = GetFromContentStyle(_003C_003Ec__DisplayClass7_2.LU2.presenter, _003C_003Ec__DisplayClass7_2.LU2.wUh, _003C_003Ec__DisplayClass7_2.LU2.RUw);
			_003C_003Ec__DisplayClass7_2.LU2.RUw.Style = GetToContentStyle(_003C_003Ec__DisplayClass7_2.LU2.presenter, _003C_003Ec__DisplayClass7_2.LU2.RUw, _003C_003Ec__DisplayClass7_2.LU2.wUh);
			_003C_003Ec__DisplayClass7_2.rUu = _003C_003Ec__DisplayClass7_2.LU2.YUm == null || _003C_003Ec__DisplayClass7_2.LU2.LU4 == null;
			if (_003C_003Ec__DisplayClass7_2.LU2.YUm != null)
			{
				_003C_003Ec__DisplayClass7_2 CS_0024_003C_003E8__locals29 = new _003C_003Ec__DisplayClass7_2();
				CS_0024_003C_003E8__locals29.vUF = _003C_003Ec__DisplayClass7_2;
				CS_0024_003C_003E8__locals29.vUF.LU2.YUm = CS_0024_003C_003E8__locals29.vUF.LU2.YUm.Clone();
				CS_0024_003C_003E8__locals29.BU7 = null;
				CS_0024_003C_003E8__locals29.BU7 = delegate
				{
					if (CS_0024_003C_003E8__locals29.vUF.rUu)
					{
						CS_0024_003C_003E8__locals29.vUF.LU2.qU9.EndTransition(CS_0024_003C_003E8__locals29.vUF.LU2.presenter, CS_0024_003C_003E8__locals29.vUF.LU2.wUh, CS_0024_003C_003E8__locals29.vUF.LU2.YUm, CS_0024_003C_003E8__locals29.vUF.LU2.RUw, CS_0024_003C_003E8__locals29.vUF.LU2.LU4);
					}
					CS_0024_003C_003E8__locals29.vUF.rUu = true;
					CS_0024_003C_003E8__locals29.vUF.LU2.YUm.Completed -= CS_0024_003C_003E8__locals29.BU7;
				};
				CS_0024_003C_003E8__locals29.vUF.LU2.YUm.Completed += CS_0024_003C_003E8__locals29.BU7;
				CS_0024_003C_003E8__locals29.vUF.LU2.YUm.Begin(CS_0024_003C_003E8__locals29.vUF.LU2.wUh, isControllable: true);
			}
			if (_003C_003Ec__DisplayClass7_2.LU2.LU4 == null)
			{
				return;
			}
			_003C_003Ec__DisplayClass7_3 CS_0024_003C_003E8__locals39 = new _003C_003Ec__DisplayClass7_3();
			CS_0024_003C_003E8__locals39.RUO = _003C_003Ec__DisplayClass7_2;
			CS_0024_003C_003E8__locals39.RUO.LU2.LU4 = CS_0024_003C_003E8__locals39.RUO.LU2.LU4.Clone();
			CS_0024_003C_003E8__locals39.HUQ = null;
			CS_0024_003C_003E8__locals39.HUQ = delegate
			{
				if (CS_0024_003C_003E8__locals39.RUO.rUu)
				{
					CS_0024_003C_003E8__locals39.RUO.LU2.qU9.EndTransition(CS_0024_003C_003E8__locals39.RUO.LU2.presenter, CS_0024_003C_003E8__locals39.RUO.LU2.wUh, CS_0024_003C_003E8__locals39.RUO.LU2.YUm, CS_0024_003C_003E8__locals39.RUO.LU2.RUw, CS_0024_003C_003E8__locals39.RUO.LU2.LU4);
				}
				CS_0024_003C_003E8__locals39.RUO.rUu = true;
				CS_0024_003C_003E8__locals39.RUO.LU2.LU4.Completed -= CS_0024_003C_003E8__locals39.HUQ;
			};
			CS_0024_003C_003E8__locals39.RUO.LU2.LU4.Completed += CS_0024_003C_003E8__locals39.HUQ;
			CS_0024_003C_003E8__locals39.RUO.LU2.LU4.Begin(CS_0024_003C_003E8__locals39.RUO.LU2.RUw, isControllable: true);
		}
		else
		{
			base.OnStarted(_003C_003Ec__DisplayClass7_.presenter, _003C_003Ec__DisplayClass7_.wUh, _003C_003Ec__DisplayClass7_.RUw);
		}
	}

	protected StoryboardTransitionBase()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool fHe()
	{
		return RHj == null;
	}

	internal static StoryboardTransitionBase VH6()
	{
		return RHj;
	}
}
