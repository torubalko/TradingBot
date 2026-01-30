using MimeKit.IO.Filters;
using MimeKit.Utils;

namespace MimeKit.Cryptography;

public class OpenPgpDetectionFilter : MimeFilterBase
{
	private enum OpenPgpState
	{
		None = 0,
		BeginPgpMessage = 1,
		EndPgpMessage = 3,
		BeginPgpSignedMessage = 4,
		BeginPgpSignature = 12,
		EndPgpSignature = 28,
		BeginPgpPublicKeyBlock = 32,
		EndPgpPublicKeyBlock = 96,
		BeginPgpPrivateKeyBlock = 128,
		EndPgpPrivateKeyBlock = 384
	}

	private struct OpenPgpMarker
	{
		public byte[] Marker;

		public OpenPgpState InitialState;

		public OpenPgpState DetectedState;

		public bool IsEnd;

		public OpenPgpMarker(string marker, OpenPgpState initial, OpenPgpState detected, bool isEnd)
		{
			Marker = CharsetUtils.UTF8.GetBytes(marker);
			InitialState = initial;
			DetectedState = detected;
			IsEnd = isEnd;
		}
	}

	private static readonly OpenPgpMarker[] OpenPgpMarkers = new OpenPgpMarker[9]
	{
		new OpenPgpMarker("-----BEGIN PGP MESSAGE-----", OpenPgpState.None, OpenPgpState.BeginPgpMessage, isEnd: false),
		new OpenPgpMarker("-----END PGP MESSAGE-----", OpenPgpState.BeginPgpMessage, OpenPgpState.EndPgpMessage, isEnd: true),
		new OpenPgpMarker("-----BEGIN PGP SIGNED MESSAGE-----", OpenPgpState.None, OpenPgpState.BeginPgpSignedMessage, isEnd: false),
		new OpenPgpMarker("-----BEGIN PGP SIGNATURE-----", OpenPgpState.BeginPgpSignedMessage, OpenPgpState.BeginPgpSignature, isEnd: false),
		new OpenPgpMarker("-----END PGP SIGNATURE-----", OpenPgpState.BeginPgpSignature, OpenPgpState.EndPgpSignature, isEnd: true),
		new OpenPgpMarker("-----BEGIN PGP PUBLIC KEY BLOCK-----", OpenPgpState.None, OpenPgpState.BeginPgpPublicKeyBlock, isEnd: false),
		new OpenPgpMarker("-----END PGP PUBLIC KEY BLOCK-----", OpenPgpState.BeginPgpPublicKeyBlock, OpenPgpState.EndPgpPublicKeyBlock, isEnd: true),
		new OpenPgpMarker("-----BEGIN PGP PRIVATE KEY BLOCK-----", OpenPgpState.None, OpenPgpState.BeginPgpPrivateKeyBlock, isEnd: false),
		new OpenPgpMarker("-----END PGP PRIVATE KEY BLOCK-----", OpenPgpState.BeginPgpPrivateKeyBlock, OpenPgpState.EndPgpPrivateKeyBlock, isEnd: false)
	};

	private OpenPgpState state;

	private int position;

	private int next;

	private bool seenEndMarker;

	private bool midline;

	public int? BeginOffset { get; private set; }

	public int? EndOffset { get; private set; }

	public OpenPgpDataType DataType => state switch
	{
		OpenPgpState.EndPgpPrivateKeyBlock => OpenPgpDataType.PrivateKey, 
		OpenPgpState.EndPgpPublicKeyBlock => OpenPgpDataType.PublicKey, 
		OpenPgpState.EndPgpSignature => OpenPgpDataType.SignedMessage, 
		OpenPgpState.EndPgpMessage => OpenPgpDataType.EncryptedMessage, 
		_ => OpenPgpDataType.None, 
	};

	private static bool IsMarker(byte[] input, int startIndex, int endIndex, byte[] marker, out bool cr)
	{
		int num = startIndex;
		int num2 = 0;
		cr = false;
		while (num2 < marker.Length && num < endIndex)
		{
			if (input[num++] != marker[num2++])
			{
				return false;
			}
		}
		if (num2 < marker.Length)
		{
			return false;
		}
		if (num < endIndex && input[num] == 13)
		{
			cr = true;
			num++;
		}
		if (num < endIndex)
		{
			return input[num] == 10;
		}
		return false;
	}

	private static bool IsPartialMatch(byte[] input, int startIndex, int endIndex, byte[] marker)
	{
		int num = startIndex;
		int num2 = 0;
		while (num2 < marker.Length && num < endIndex)
		{
			if (input[num++] != marker[num2++])
			{
				return false;
			}
		}
		if (num < endIndex && input[num] == 13)
		{
			num++;
		}
		return num == endIndex;
	}

	private void SetPosition(int offset, int marker, bool cr)
	{
		int num = OpenPgpMarkers[marker].Marker.Length + ((!cr) ? 1 : 2);
		switch (state)
		{
		case OpenPgpState.BeginPgpPrivateKeyBlock:
			BeginOffset = position + offset;
			break;
		case OpenPgpState.EndPgpPrivateKeyBlock:
			EndOffset = position + offset + num;
			break;
		case OpenPgpState.BeginPgpPublicKeyBlock:
			BeginOffset = position + offset;
			break;
		case OpenPgpState.EndPgpPublicKeyBlock:
			EndOffset = position + offset + num;
			break;
		case OpenPgpState.BeginPgpSignedMessage:
			BeginOffset = position + offset;
			break;
		case OpenPgpState.EndPgpSignature:
			EndOffset = position + offset + num;
			break;
		case OpenPgpState.BeginPgpMessage:
			BeginOffset = position + offset;
			break;
		case OpenPgpState.EndPgpMessage:
			EndOffset = position + offset + num;
			break;
		}
	}

	protected override byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength, bool flush)
	{
		int num = startIndex + length;
		int i = startIndex;
		outputIndex = startIndex;
		outputLength = 0;
		if (seenEndMarker || length == 0)
		{
			return input;
		}
		if (midline)
		{
			for (; i < num && input[i] != 10; i++)
			{
			}
			if (i == num)
			{
				if (state != OpenPgpState.None)
				{
					outputLength = i - startIndex;
				}
				position += i - startIndex;
				return input;
			}
			midline = false;
		}
		bool cr;
		if (state == OpenPgpState.None)
		{
			do
			{
				int num2 = i;
				for (; i < num && input[i] != 10; i++)
				{
				}
				if (i == num)
				{
					bool flag = false;
					for (int j = 0; j < OpenPgpMarkers.Length; j++)
					{
						if (OpenPgpMarkers[j].InitialState == state && IsPartialMatch(input, num2, i, OpenPgpMarkers[j].Marker))
						{
							flag = true;
							break;
						}
					}
					if (flag)
					{
						SaveRemainingInput(input, num2, i - num2);
						position += num2 - startIndex;
					}
					else
					{
						position += i - num2;
						midline = true;
					}
					return input;
				}
				i++;
				for (int k = 0; k < OpenPgpMarkers.Length; k++)
				{
					if (OpenPgpMarkers[k].InitialState == state && IsMarker(input, num2, num, OpenPgpMarkers[k].Marker, out cr))
					{
						state = OpenPgpMarkers[k].DetectedState;
						SetPosition(num2 - startIndex, k, cr);
						outputLength = i - num2;
						outputIndex = num2;
						next = k + 1;
						break;
					}
				}
			}
			while (i < num && state == OpenPgpState.None);
			if (i == num)
			{
				position += i - startIndex;
				return input;
			}
		}
		do
		{
			int num3 = i;
			for (; i < num && input[i] != 10; i++)
			{
			}
			if (i == num)
			{
				if (flush)
				{
					break;
				}
				if (IsPartialMatch(input, num3, i, OpenPgpMarkers[next].Marker))
				{
					SaveRemainingInput(input, num3, i - num3);
					outputLength = num3 - outputIndex;
					position += num3 - startIndex;
				}
				else
				{
					outputLength = i - outputIndex;
					position += i - startIndex;
					midline = true;
				}
				return input;
			}
			i++;
			if (IsMarker(input, num3, num, OpenPgpMarkers[next].Marker, out cr))
			{
				seenEndMarker = OpenPgpMarkers[next].IsEnd;
				state = OpenPgpMarkers[next].DetectedState;
				SetPosition(num3 - startIndex, next, cr);
				next++;
				if (seenEndMarker)
				{
					break;
				}
			}
		}
		while (i < num);
		outputLength = i - outputIndex;
		position += i - startIndex;
		return input;
	}

	public override void Reset()
	{
		state = OpenPgpState.None;
		seenEndMarker = false;
		BeginOffset = null;
		EndOffset = null;
		midline = false;
		position = 0;
		next = 0;
		base.Reset();
	}
}
