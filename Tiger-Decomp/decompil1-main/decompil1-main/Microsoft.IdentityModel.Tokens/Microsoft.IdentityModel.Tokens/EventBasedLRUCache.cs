using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

internal class EventBasedLRUCache<TKey, TValue>
{
	internal delegate void ItemRemoved(TValue Value);

	private readonly int _capacity;

	private readonly double _compactionPercentage = 0.2;

	private LinkedList<LRUCacheItem<TKey, TValue>> _doubleLinkedList = new LinkedList<LRUCacheItem<TKey, TValue>>();

	private ConcurrentQueue<Action> _eventQueue = new ConcurrentQueue<Action>();

	private ConcurrentDictionary<TKey, LRUCacheItem<TKey, TValue>> _map;

	private readonly double _maxCapacityPercentage = 0.95;

	private readonly bool _removeExpiredValues;

	private readonly int _removeExpiredValuesIntervalInSeconds;

	private readonly TaskCreationOptions _options;

	private Timer _timer;

	private int _taskCount;

	private int _eventQueuePollingInterval = 50;

	private long _eventQueueTaskIdleTimeoutInSeconds = 120L;

	private Task _eventQueueTask;

	private DateTime _eventQueueTaskStopTime;

	private const int EventQueueTaskStopped = 0;

	private const int EventQueueTaskRunning = 1;

	private const int EventQueueTaskDoNotStop = 2;

	private int _eventQueueTaskState;

	internal ItemRemoved OnItemRemoved { get; set; }

	internal long EventQueueTaskIdleTimeoutInSeconds
	{
		get
		{
			return _eventQueueTaskIdleTimeoutInSeconds;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("value", "EventQueueTaskExecutionTimeInSeconds must be positive.");
			}
			_eventQueueTaskIdleTimeoutInSeconds = value;
		}
	}

	private int EventQueuePollingInterval
	{
		get
		{
			return _eventQueuePollingInterval;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("value", "EventQueuePollingInterval must be positive.");
			}
			_eventQueuePollingInterval = value;
		}
	}

	internal LinkedList<LRUCacheItem<TKey, TValue>> LinkedList => _doubleLinkedList;

	internal long LinkedListCount => _doubleLinkedList.Count;

	internal long MapCount => _map.Count;

	internal ICollection<LRUCacheItem<TKey, TValue>> MapValues => _map.Values;

	internal long EventQueueCount => _eventQueue.Count;

	internal int TaskCount => _taskCount;

	internal EventBasedLRUCache(int capacity, TaskCreationOptions options = TaskCreationOptions.None, IEqualityComparer<TKey> comparer = null, bool removeExpiredValues = false, int removeExpiredValuesIntervalInSeconds = 300)
	{
		if (capacity <= 0)
		{
			throw LogHelper.LogExceptionMessage(new ArgumentOutOfRangeException("capacity"));
		}
		_capacity = capacity;
		_options = options;
		_map = new ConcurrentDictionary<TKey, LRUCacheItem<TKey, TValue>>(comparer ?? EqualityComparer<TKey>.Default);
		_removeExpiredValuesIntervalInSeconds = 1000 * removeExpiredValuesIntervalInSeconds;
		_removeExpiredValues = removeExpiredValues;
		_eventQueueTaskStopTime = DateTime.UtcNow;
		if (_removeExpiredValues)
		{
			_timer = new Timer(RemoveExpiredValuesPeriodically, null, _removeExpiredValuesIntervalInSeconds, _removeExpiredValuesIntervalInSeconds);
		}
	}

	private void AddActionToEventQueue(Action action)
	{
		_eventQueue.Enqueue(action);
		StartEventQueueTaskIfNotRunning();
	}

	public bool Contains(TKey key)
	{
		if (key == null)
		{
			throw LogHelper.LogArgumentNullException("key");
		}
		return _map.ContainsKey(key);
	}

	private void EventQueueTaskAction()
	{
		Interlocked.Increment(ref _taskCount);
		while (true)
		{
			_eventQueueTaskState = 1;
			try
			{
				if (_eventQueue.TryDequeue(out var result))
				{
					result?.Invoke();
				}
				else if (DateTime.UtcNow > _eventQueueTaskStopTime)
				{
					if (Interlocked.CompareExchange(ref _eventQueueTaskState, 0, 1) == 1)
					{
						break;
					}
				}
				else
				{
					Thread.Sleep(_eventQueuePollingInterval);
				}
			}
			catch (Exception ex)
			{
				LogHelper.LogWarning(LogHelper.FormatInvariant("IDX10900: EventBasedLRUCache._eventQueue encountered an error while processing a cache operation. Exception '{0}'.", ex));
			}
		}
		Interlocked.Decrement(ref _taskCount);
	}

	internal int RemoveExpiredValues()
	{
		int num = 0;
		try
		{
			LinkedListNode<LRUCacheItem<TKey, TValue>> linkedListNode = _doubleLinkedList.First;
			while (linkedListNode != null)
			{
				LinkedListNode<LRUCacheItem<TKey, TValue>> next = linkedListNode.Next;
				if (linkedListNode.Value.ExpirationTime < DateTime.UtcNow)
				{
					_doubleLinkedList.Remove(linkedListNode);
					if (_map.TryRemove(linkedListNode.Value.Key, out var value))
					{
						OnItemRemoved?.Invoke(value.Value);
					}
					num++;
				}
				linkedListNode = next;
			}
		}
		catch (ObjectDisposedException ex)
		{
			LogHelper.LogWarning(LogHelper.FormatInvariant("IDX10902: Object disposed exception in '{0}': '{1}'", LogHelper.MarkAsNonPII("RemoveExpiredValues"), ex));
		}
		return num;
	}

	protected void RemoveExpiredValuesPeriodically(object state)
	{
		if (_map.Count > 0)
		{
			AddActionToEventQueue(delegate
			{
				RemoveExpiredValues();
			});
		}
	}

	private void RemoveLRUs()
	{
		int num = ((_map.Count <= _capacity) ? _capacity : _map.Count);
		int num2 = num - (int)((double)num * _compactionPercentage);
		while (_map.Count > num2 && _doubleLinkedList.Count > 0)
		{
			LinkedListNode<LRUCacheItem<TKey, TValue>> last = _doubleLinkedList.Last;
			if (_map.TryRemove(last.Value.Key, out var value))
			{
				OnItemRemoved?.Invoke(value.Value);
			}
			_doubleLinkedList.Remove(last);
		}
	}

	private DateTime SetTaskEndTime()
	{
		return DateTime.UtcNow.AddSeconds(EventQueueTaskIdleTimeoutInSeconds);
	}

	public void SetValue(TKey key, TValue value)
	{
		SetValue(key, value, DateTime.MaxValue);
	}

	public bool SetValue(TKey key, TValue value, DateTime expirationTime)
	{
		if (key == null)
		{
			throw LogHelper.LogArgumentNullException("key");
		}
		if (value == null)
		{
			throw LogHelper.LogArgumentNullException("value");
		}
		if (_removeExpiredValues && expirationTime < DateTime.UtcNow)
		{
			return false;
		}
		if (_map.TryGetValue(key, out var cacheItem))
		{
			cacheItem.Value = value;
			cacheItem.ExpirationTime = expirationTime;
			AddActionToEventQueue(delegate
			{
				_doubleLinkedList.Remove(cacheItem);
				_doubleLinkedList.AddFirst(cacheItem);
			});
		}
		else
		{
			if ((double)_map.Count / (double)_capacity >= _maxCapacityPercentage)
			{
				_eventQueue.Enqueue(delegate
				{
					RemoveLRUs();
				});
			}
			LRUCacheItem<TKey, TValue> existingCacheItem = new LRUCacheItem<TKey, TValue>(key, value, expirationTime);
			AddActionToEventQueue(delegate
			{
				_doubleLinkedList.Remove(existingCacheItem);
				_doubleLinkedList.AddFirst(existingCacheItem);
			});
			_map[key] = existingCacheItem;
		}
		return true;
	}

	private void StartEventQueueTaskIfNotRunning()
	{
		_eventQueueTaskStopTime = SetTaskEndTime();
		if (Interlocked.CompareExchange(ref _eventQueueTaskState, 2, 1) != 1 && Interlocked.CompareExchange(ref _eventQueueTaskState, 1, 0) == 0)
		{
			_eventQueueTask = Task.Run((Action)EventQueueTaskAction);
		}
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		if (key == null)
		{
			throw LogHelper.LogArgumentNullException("key");
		}
		if (!_map.ContainsKey(key))
		{
			value = default(TValue);
			return false;
		}
		if (_map.TryGetValue(key, out var cacheItem))
		{
			AddActionToEventQueue(delegate
			{
				_doubleLinkedList.Remove(cacheItem);
				_doubleLinkedList.AddFirst(cacheItem);
			});
		}
		value = ((cacheItem != null) ? cacheItem.Value : default(TValue));
		return cacheItem != null;
	}

	public bool TryRemove(TKey key, out TValue value)
	{
		if (key == null)
		{
			throw LogHelper.LogArgumentNullException("key");
		}
		if (!_map.TryGetValue(key, out var cacheItem))
		{
			value = default(TValue);
			return false;
		}
		value = cacheItem.Value;
		AddActionToEventQueue(delegate
		{
			_doubleLinkedList.Remove(cacheItem);
		});
		if (_map.TryRemove(key, out cacheItem))
		{
			OnItemRemoved?.Invoke(cacheItem.Value);
			return true;
		}
		return false;
	}

	internal void WaitForProcessing()
	{
		while (_eventQueue.Count != 0)
		{
		}
	}
}
