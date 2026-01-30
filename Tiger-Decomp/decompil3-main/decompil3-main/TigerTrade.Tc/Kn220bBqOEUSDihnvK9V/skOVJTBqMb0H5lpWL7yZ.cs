using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Web;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using Newtonsoft.Json;
using x97CE55GhEYKgt7TSVZT;

namespace Kn220bBqOEUSDihnvK9V;

internal abstract class skOVJTBqMb0H5lpWL7yZ
{
	[Serializable]
	[CompilerGenerated]
	private sealed class Sr38PnifywAbN9GmlDRu
	{
		public static readonly Sr38PnifywAbN9GmlDRu Py0ifKIWeCw;

		public static Func<KeyValuePair<string, string>, string> zahifmpQoZu;

		public static Func<KeyValuePair<string, string>, string> lG9ifhxwg5F;

		public static Func<KeyValuePair<string, object>, string> JR6ifwdkJ6f;

		public static Func<KeyValuePair<string, object>, string> gGVif7VObbD;

		internal static Sr38PnifywAbN9GmlDRu HuFGwNLQGmfu58Arf6L7;

		static Sr38PnifywAbN9GmlDRu()
		{
			F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
			pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
			Yd4ZGLLQvvexOGkfcgHO();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Py0ifKIWeCw = new Sr38PnifywAbN9GmlDRu();
		}

		public Sr38PnifywAbN9GmlDRu()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
			base._002Ector();
		}

		internal string znSifZoRl2g(KeyValuePair<string, string> p)
		{
			return p.Key;
		}

		internal string Ux7ifVgJABc(KeyValuePair<string, string> x)
		{
			return x.Key + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--871424829 ^ 0x33F04261) + x.Value;
		}

		internal string HUqifCbJGCK(KeyValuePair<string, object> p)
		{
			return p.Key;
		}

		internal string bgmifri5yFq(KeyValuePair<string, object> x)
		{
			return x.Key + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6EC99CAF ^ 0x6EC93DF3) + HttpUtility.UrlEncode(x.Value.ToString(), Encoding.UTF8);
		}

		internal static void Yd4ZGLLQvvexOGkfcgHO()
		{
			itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		}

		internal static bool Y6XP8eLQYNEaMAvNPQMa()
		{
			return HuFGwNLQGmfu58Arf6L7 == null;
		}

		internal static Sr38PnifywAbN9GmlDRu VCFy64LQo0X8ca9a7rFe()
		{
			return HuFGwNLQGmfu58Arf6L7;
		}
	}

	[CompilerGenerated]
	private CancellationToken etcBqt7hEU3;

	internal static skOVJTBqMb0H5lpWL7yZ kYBrvYxMFjVqDmuJBWOM;

	[JsonIgnore]
	public CancellationToken id0BqWG7y0S
	{
		[CompilerGenerated]
		get
		{
			return etcBqt7hEU3;
		}
		[CompilerGenerated]
		protected set
		{
			etcBqt7hEU3 = cancellationToken;
		}
	}

	public virtual string MlPl9kI3Tww()
	{
		IEnumerable<string> values = from x in JsonConvert.DeserializeObject<IDictionary<string, string>>((string)vfvjDDxMuxdDavA8ElC4(this))
			orderby x.Key
			select x.Key + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--871424829 ^ 0x33F04261) + x.Value;
		return string.Join(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1346994499 ^ -1346952399), values);
	}

	public virtual string yRHlvkHQHMS()
	{
		IEnumerable<string> values = from x in JsonConvert.DeserializeObject<IDictionary<string, object>>(JsonConvert.SerializeObject((object)this).Trim())
			orderby x.Key
			select x.Key + F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6EC99CAF ^ 0x6EC93DF3) + HttpUtility.UrlEncode(x.Value.ToString(), Encoding.UTF8);
		return string.Join(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1774602229 ^ -1774656121), values);
	}

	protected skOVJTBqMb0H5lpWL7yZ()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static skOVJTBqMb0H5lpWL7yZ()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool tw8qGPxM3gRygLaXH0vu()
	{
		return kYBrvYxMFjVqDmuJBWOM == null;
	}

	internal static skOVJTBqMb0H5lpWL7yZ EyXc12xMpXy8A1jFWfnf()
	{
		return kYBrvYxMFjVqDmuJBWOM;
	}

	internal static object vfvjDDxMuxdDavA8ElC4(object P_0)
	{
		return JsonConvert.SerializeObject(P_0);
	}
}
