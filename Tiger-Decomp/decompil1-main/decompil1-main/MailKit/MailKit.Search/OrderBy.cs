using System;

namespace MailKit.Search;

public class OrderBy
{
	public static readonly OrderBy Arrival = new OrderBy(OrderByType.Arrival, SortOrder.Ascending);

	public static readonly OrderBy ReverseArrival = new OrderBy(OrderByType.Arrival, SortOrder.Descending);

	public static readonly OrderBy Cc = new OrderBy(OrderByType.Cc, SortOrder.Ascending);

	public static readonly OrderBy ReverseCc = new OrderBy(OrderByType.Cc, SortOrder.Descending);

	public static readonly OrderBy Date = new OrderBy(OrderByType.Date, SortOrder.Ascending);

	public static readonly OrderBy ReverseDate = new OrderBy(OrderByType.Date, SortOrder.Descending);

	public static readonly OrderBy From = new OrderBy(OrderByType.From, SortOrder.Ascending);

	public static readonly OrderBy ReverseFrom = new OrderBy(OrderByType.From, SortOrder.Descending);

	public static readonly OrderBy DisplayFrom = new OrderBy(OrderByType.DisplayFrom, SortOrder.Ascending);

	public static readonly OrderBy ReverseDisplayFrom = new OrderBy(OrderByType.DisplayFrom, SortOrder.Descending);

	public static readonly OrderBy Size = new OrderBy(OrderByType.Size, SortOrder.Ascending);

	public static readonly OrderBy ReverseSize = new OrderBy(OrderByType.Size, SortOrder.Descending);

	public static readonly OrderBy Subject = new OrderBy(OrderByType.Subject, SortOrder.Ascending);

	public static readonly OrderBy ReverseSubject = new OrderBy(OrderByType.Subject, SortOrder.Descending);

	public static readonly OrderBy To = new OrderBy(OrderByType.To, SortOrder.Ascending);

	public static readonly OrderBy ReverseTo = new OrderBy(OrderByType.To, SortOrder.Descending);

	public static readonly OrderBy DisplayTo = new OrderBy(OrderByType.DisplayTo, SortOrder.Ascending);

	public static readonly OrderBy ReverseDisplayTo = new OrderBy(OrderByType.DisplayTo, SortOrder.Descending);

	public OrderByType Type { get; private set; }

	public SortOrder Order { get; private set; }

	public OrderBy(OrderByType type, SortOrder order)
	{
		if (order == SortOrder.None)
		{
			throw new ArgumentOutOfRangeException("order");
		}
		Order = order;
		Type = type;
	}
}
