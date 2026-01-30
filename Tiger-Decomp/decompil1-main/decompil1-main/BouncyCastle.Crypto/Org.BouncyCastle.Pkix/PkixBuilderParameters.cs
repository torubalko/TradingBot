using System.Text;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Pkix;

public class PkixBuilderParameters : PkixParameters
{
	private int maxPathLength = 5;

	private ISet excludedCerts = new HashSet();

	public virtual int MaxPathLength
	{
		get
		{
			return maxPathLength;
		}
		set
		{
			if (value < -1)
			{
				throw new InvalidParameterException("The maximum path length parameter can not be less than -1.");
			}
			maxPathLength = value;
		}
	}

	public static PkixBuilderParameters GetInstance(PkixParameters pkixParams)
	{
		PkixBuilderParameters pkixBuilderParameters = new PkixBuilderParameters(pkixParams.GetTrustAnchors(), new X509CertStoreSelector(pkixParams.GetTargetCertConstraints()));
		pkixBuilderParameters.SetParams(pkixParams);
		return pkixBuilderParameters;
	}

	public PkixBuilderParameters(ISet trustAnchors, IX509Selector targetConstraints)
		: base(trustAnchors)
	{
		SetTargetCertConstraints(targetConstraints);
	}

	public virtual ISet GetExcludedCerts()
	{
		return new HashSet(excludedCerts);
	}

	public virtual void SetExcludedCerts(ISet excludedCerts)
	{
		if (excludedCerts == null)
		{
			this.excludedCerts = new HashSet();
		}
		else
		{
			this.excludedCerts = new HashSet(excludedCerts);
		}
	}

	protected override void SetParams(PkixParameters parameters)
	{
		base.SetParams(parameters);
		if (parameters is PkixBuilderParameters)
		{
			PkixBuilderParameters _params = (PkixBuilderParameters)parameters;
			maxPathLength = _params.maxPathLength;
			excludedCerts = new HashSet(_params.excludedCerts);
		}
	}

	public override object Clone()
	{
		PkixBuilderParameters pkixBuilderParameters = new PkixBuilderParameters(GetTrustAnchors(), GetTargetCertConstraints());
		pkixBuilderParameters.SetParams(this);
		return pkixBuilderParameters;
	}

	public override string ToString()
	{
		string nl = Platform.NewLine;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("PkixBuilderParameters [" + nl);
		stringBuilder.Append(base.ToString());
		stringBuilder.Append("  Maximum Path Length: ");
		stringBuilder.Append(MaxPathLength);
		stringBuilder.Append(nl + "]" + nl);
		return stringBuilder.ToString();
	}
}
