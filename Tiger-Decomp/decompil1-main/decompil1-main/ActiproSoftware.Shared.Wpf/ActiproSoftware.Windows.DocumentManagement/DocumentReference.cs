using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.DocumentManagement;

public class DocumentReference : DependencyObject, IDocumentReference
{
	public static readonly DependencyProperty DescriptionProperty;

	public static readonly DependencyProperty ImageSourceLargeProperty;

	public static readonly DependencyProperty ImageSourceSmallProperty;

	public static readonly DependencyProperty IsPinnedRecentDocumentProperty;

	public static readonly DependencyProperty LastOpenedDateTimeProperty;

	public static readonly DependencyProperty LocationProperty;

	public static readonly DependencyProperty NameProperty;

	public static readonly DependencyProperty TagProperty;

	internal static DocumentReference QNM;

	public string Description
	{
		get
		{
			return (string)GetValue(DescriptionProperty);
		}
		set
		{
			SetValue(DescriptionProperty, value);
		}
	}

	public ImageSource ImageSourceLarge
	{
		get
		{
			return (ImageSource)GetValue(ImageSourceLargeProperty);
		}
		set
		{
			SetValue(ImageSourceLargeProperty, value);
		}
	}

	public ImageSource ImageSourceSmall
	{
		get
		{
			return (ImageSource)GetValue(ImageSourceSmallProperty);
		}
		set
		{
			SetValue(ImageSourceSmallProperty, value);
		}
	}

	public bool IsPinnedRecentDocument
	{
		get
		{
			return (bool)GetValue(IsPinnedRecentDocumentProperty);
		}
		set
		{
			SetValue(IsPinnedRecentDocumentProperty, value);
		}
	}

	public DateTime LastOpenedDateTime
	{
		get
		{
			return (DateTime)GetValue(LastOpenedDateTimeProperty);
		}
		set
		{
			SetValue(LastOpenedDateTimeProperty, value);
		}
	}

	public Uri Location
	{
		get
		{
			return (Uri)GetValue(LocationProperty);
		}
		set
		{
			SetValue(LocationProperty, value);
		}
	}

	public string Name
	{
		get
		{
			return (string)GetValue(NameProperty);
		}
		set
		{
			SetValue(NameProperty, value);
		}
	}

	public object Tag
	{
		get
		{
			return GetValue(TagProperty);
		}
		set
		{
			SetValue(TagProperty, value);
		}
	}

	public DocumentReference()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		LastOpenedDateTime = DateTime.Now;
	}

	public DocumentReference(Uri location)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector();
		Location = location;
	}

	private static void uko(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DocumentReference documentReference = (DocumentReference)P_0;
		try
		{
			if (documentReference.Name == null && P_1.NewValue != null)
			{
				Uri uri = (Uri)P_1.NewValue;
				if (uri.IsAbsoluteUri)
				{
					documentReference.Name = Path.GetFileName(uri.LocalPath);
				}
			}
		}
		catch (ArgumentException)
		{
		}
		catch (InvalidOperationException)
		{
		}
	}

	static DocumentReference()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		DescriptionProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111154), typeof(string), typeof(DocumentReference), new FrameworkPropertyMetadata(null));
		ImageSourceLargeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111180), typeof(ImageSource), typeof(DocumentReference), new FrameworkPropertyMetadata(null));
		ImageSourceSmallProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111216), typeof(ImageSource), typeof(DocumentReference), new FrameworkPropertyMetadata(null));
		IsPinnedRecentDocumentProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111252), typeof(bool), typeof(DocumentReference), new FrameworkPropertyMetadata(false));
		LastOpenedDateTimeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111300), typeof(DateTime), typeof(DocumentReference), new FrameworkPropertyMetadata(DateTime.Now));
		LocationProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111340), typeof(Uri), typeof(DocumentReference), new FrameworkPropertyMetadata(null, uko));
		NameProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(105006), typeof(string), typeof(DocumentReference), new FrameworkPropertyMetadata(null));
		TagProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111360), typeof(object), typeof(DocumentReference), new FrameworkPropertyMetadata(null));
	}

	internal static bool lNY()
	{
		return QNM == null;
	}

	internal static DocumentReference eNt()
	{
		return QNM;
	}
}
