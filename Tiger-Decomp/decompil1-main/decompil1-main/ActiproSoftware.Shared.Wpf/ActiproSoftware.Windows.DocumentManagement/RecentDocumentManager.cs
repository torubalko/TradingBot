using System;
using System.Collections;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Markup;
using ActiproSoftware.Windows.Serialization;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.DocumentManagement;

[ContentProperty("Documents")]
public class RecentDocumentManager : DependencyObject
{
	internal class DocumentLastOpenedComparer : IComparer
	{
		private static DocumentLastOpenedComparer mea;

		public int Compare(object x, object y)
		{
			IDocumentReference documentReference = (IDocumentReference)x;
			IDocumentReference documentReference2 = (IDocumentReference)y;
			if (documentReference.IsPinnedRecentDocument != documentReference2.IsPinnedRecentDocument)
			{
				return (!documentReference.IsPinnedRecentDocument) ? 1 : (-1);
			}
			return -1 * documentReference.LastOpenedDateTime.CompareTo(documentReference2.LastOpenedDateTime);
		}

		public DocumentLastOpenedComparer()
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
		}

		internal static bool Ley()
		{
			return mea == null;
		}

		internal static DocumentLastOpenedComparer oeQ()
		{
			return mea;
		}
	}

	private DocumentReferenceCollection xkl;

	private DocumentReferenceCollection mkA;

	private ReadOnlyDocumentReferenceCollection hkC;

	public static readonly DependencyProperty IndexProperty;

	public static readonly DependencyProperty MaxDocumentCountProperty;

	public static readonly DependencyProperty MaxFilteredDocumentCountProperty;

	private static RecentDocumentManager MN1;

	public DocumentReferenceCollection Documents => xkl;

	public ReadOnlyDocumentReferenceCollection FilteredDocuments => hkC;

	public int MaxDocumentCount
	{
		get
		{
			return (int)GetValue(MaxDocumentCountProperty);
		}
		set
		{
			SetValue(MaxDocumentCountProperty, value);
		}
	}

	public int MaxFilteredDocumentCount
	{
		get
		{
			return (int)GetValue(MaxFilteredDocumentCountProperty);
		}
		set
		{
			SetValue(MaxFilteredDocumentCountProperty, value);
		}
	}

	public RecentDocumentManager()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		xkl = new DocumentReferenceCollection();
		mkA = new DocumentReferenceCollection();
		hkC = new ReadOnlyDocumentReferenceCollection(mkA);
		xkl.CollectionChanged += vkQ;
	}

	private void vkQ(object P_0, NotifyCollectionChangedEventArgs P_1)
	{
		mkk();
		RebindFilteredDocuments();
	}

	private static void ckO(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RecentDocumentManager recentDocumentManager = (RecentDocumentManager)P_0;
		if ((int)P_1.NewValue < recentDocumentManager.Documents.Count)
		{
			recentDocumentManager.mkk();
			recentDocumentManager.RebindFilteredDocuments();
		}
	}

	private static void tk0(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RecentDocumentManager recentDocumentManager = (RecentDocumentManager)P_0;
		recentDocumentManager.RebindFilteredDocuments();
	}

	private void mkk()
	{
		int num = xkl.Count - MaxDocumentCount;
		if (num <= 0)
		{
			return;
		}
		IDocumentReference[] array = new IDocumentReference[xkl.Count];
		xkl.CopyTo(array, 0);
		Array.Sort(array, new DocumentLastOpenedComparer());
		xkl.BeginUpdate();
		try
		{
			int num2 = array.Length - 1;
			while (num2 >= 0 && num > 0)
			{
				if (!array[num2].IsPinnedRecentDocument)
				{
					xkl.Remove(array[num2]);
					num--;
				}
				num2--;
			}
			int num3 = array.Length - 1;
			while (num3 >= 0 && num > 0)
			{
				xkl.Remove(array[num3]);
				num--;
				num3--;
			}
		}
		catch (InvalidOperationException)
		{
		}
		finally
		{
			xkl.EndUpdate();
		}
	}

	public void Deserialize(string xml)
	{
		xkl.BeginUpdate();
		try
		{
			xkl.Clear();
			if (!(new XamlSerializer().LoadFromString(xml) is DocumentReferenceCollection documentReferenceCollection))
			{
				return;
			}
			foreach (IDocumentReference item in documentReferenceCollection)
			{
				xkl.Add(item);
			}
		}
		finally
		{
			xkl.EndUpdate();
		}
	}

	public IDocumentReference GetDocumentReference(Uri location)
	{
		if (location != null)
		{
			foreach (IDocumentReference item in xkl)
			{
				if (location.Equals(item.Location))
				{
					return item;
				}
			}
		}
		return null;
	}

	public static int GetIndex(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (int)obj.GetValue(IndexProperty);
	}

	public static void SetIndex(DependencyObject obj, int value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(IndexProperty, value);
	}

	public IDocumentReference NotifyDocumentOpened(Uri location)
	{
		return NotifyDocumentOpened(location, null, null);
	}

	public IDocumentReference NotifyDocumentOpened(Uri location, string name)
	{
		return NotifyDocumentOpened(location, name, null);
	}

	public IDocumentReference NotifyDocumentOpened(Uri location, string name, object tag)
	{
		IDocumentReference documentReference = GetDocumentReference(location);
		if (documentReference == null)
		{
			documentReference = new DocumentReference(location);
			if (name != null)
			{
				documentReference.Name = name;
			}
			if (tag != null)
			{
				documentReference.Tag = tag;
			}
			xkl.Add(documentReference);
		}
		else
		{
			documentReference.LastOpenedDateTime = DateTime.Now;
			RebindFilteredDocuments();
		}
		IDocumentReference documentReference2 = documentReference;
		int num = 0;
		if (IN8() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => documentReference2, 
		};
	}

	public void RebindFilteredDocuments()
	{
		foreach (IDocumentReference item in hkC)
		{
			if (item is DependencyObject dependencyObject)
			{
				dependencyObject.ClearValue(IndexProperty);
			}
		}
		IDocumentReference[] array = new IDocumentReference[xkl.Count];
		xkl.CopyTo(array, 0);
		Array.Sort(array, new DocumentLastOpenedComparer());
		int num = 0;
		IDocumentReference[] array2 = array;
		foreach (IDocumentReference documentReference in array2)
		{
			if (documentReference.IsPinnedRecentDocument)
			{
				num++;
			}
		}
		int num2 = Math.Max(0, MaxFilteredDocumentCount);
		mkA.BeginUpdate();
		try
		{
			mkA.Clear();
			for (int j = 0; j < array.Length; j++)
			{
				if (num2 <= 0)
				{
					break;
				}
				IDocumentReference documentReference2 = array[j];
				bool flag = false;
				if (documentReference2.IsPinnedRecentDocument)
				{
					flag = true;
					num--;
				}
				else if (num2 > num)
				{
					flag = true;
				}
				if (flag)
				{
					mkA.Add(documentReference2);
					num2--;
					if (documentReference2 is DependencyObject dependencyObject2)
					{
						dependencyObject2.SetValue(IndexProperty, mkA.Count);
					}
				}
			}
		}
		finally
		{
			mkA.EndUpdate();
		}
	}

	public string Serialize()
	{
		return new XamlSerializer().SaveToString(xkl);
	}

	static RecentDocumentManager()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		IndexProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111370), typeof(int), typeof(RecentDocumentManager), new FrameworkPropertyMetadata(0));
		MaxDocumentCountProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111384), typeof(int), typeof(RecentDocumentManager), new FrameworkPropertyMetadata(30, ckO));
		MaxFilteredDocumentCountProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111420), typeof(int), typeof(RecentDocumentManager), new FrameworkPropertyMetadata(16, tk0));
	}

	internal static bool GNg()
	{
		return MN1 == null;
	}

	internal static RecentDocumentManager IN8()
	{
		return MN1;
	}
}
