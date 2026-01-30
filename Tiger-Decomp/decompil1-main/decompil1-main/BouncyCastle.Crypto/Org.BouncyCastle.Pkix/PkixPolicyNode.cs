using System.Collections;
using System.Text;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Pkix;

public class PkixPolicyNode
{
	protected IList mChildren;

	protected int mDepth;

	protected ISet mExpectedPolicies;

	protected PkixPolicyNode mParent;

	protected ISet mPolicyQualifiers;

	protected string mValidPolicy;

	protected bool mCritical;

	public virtual int Depth => mDepth;

	public virtual IEnumerable Children => new EnumerableProxy(mChildren);

	public virtual bool IsCritical
	{
		get
		{
			return mCritical;
		}
		set
		{
			mCritical = value;
		}
	}

	public virtual ISet PolicyQualifiers => new HashSet(mPolicyQualifiers);

	public virtual string ValidPolicy => mValidPolicy;

	public virtual bool HasChildren => mChildren.Count != 0;

	public virtual ISet ExpectedPolicies
	{
		get
		{
			return new HashSet(mExpectedPolicies);
		}
		set
		{
			mExpectedPolicies = new HashSet(value);
		}
	}

	public virtual PkixPolicyNode Parent
	{
		get
		{
			return mParent;
		}
		set
		{
			mParent = value;
		}
	}

	public PkixPolicyNode(IList children, int depth, ISet expectedPolicies, PkixPolicyNode parent, ISet policyQualifiers, string validPolicy, bool critical)
	{
		if (children == null)
		{
			mChildren = Platform.CreateArrayList();
		}
		else
		{
			mChildren = Platform.CreateArrayList(children);
		}
		mDepth = depth;
		mExpectedPolicies = expectedPolicies;
		mParent = parent;
		mPolicyQualifiers = policyQualifiers;
		mValidPolicy = validPolicy;
		mCritical = critical;
	}

	public virtual void AddChild(PkixPolicyNode child)
	{
		child.Parent = this;
		mChildren.Add(child);
	}

	public virtual void RemoveChild(PkixPolicyNode child)
	{
		mChildren.Remove(child);
	}

	public override string ToString()
	{
		return ToString("");
	}

	public virtual string ToString(string indent)
	{
		StringBuilder buf = new StringBuilder();
		buf.Append(indent);
		buf.Append(mValidPolicy);
		buf.Append(" {");
		buf.Append(Platform.NewLine);
		foreach (PkixPolicyNode child in mChildren)
		{
			buf.Append(child.ToString(indent + "    "));
		}
		buf.Append(indent);
		buf.Append("}");
		buf.Append(Platform.NewLine);
		return buf.ToString();
	}

	public virtual object Clone()
	{
		return Copy();
	}

	public virtual PkixPolicyNode Copy()
	{
		PkixPolicyNode node = new PkixPolicyNode(Platform.CreateArrayList(), mDepth, new HashSet(mExpectedPolicies), null, new HashSet(mPolicyQualifiers), mValidPolicy, mCritical);
		foreach (PkixPolicyNode mChild in mChildren)
		{
			PkixPolicyNode copy = mChild.Copy();
			copy.Parent = node;
			node.AddChild(copy);
		}
		return node;
	}
}
