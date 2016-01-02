using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crawler.Core.Common.Queue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Crawler.UnitTesting.Core.Common.Queue
{
	[TestClass]
	public class ManagedQueueTest
	{
		[TestMethod]
		public void ManagedQueue_InstanceInitialized_FirstItemIsDequeued()
		{
			IEnumerable<int> queuedList = Enumerable.Range(0, 100);

			ManagedQueue<int> queue = new ManagedQueue<int>(queuedList);

			Assert.AreEqual(queuedList.ElementAt(0), queue.Front);
		}

		[TestMethod]
		public void ManagedQueue_Dequeue_FrontEqualsExceptParameter_CollectionDequeued()
		{
			IEnumerable<int> queuedList = Enumerable.Range(0, 100);

			ManagedQueue<int> queue = new ManagedQueue<int>(queuedList);

			queue.Dequeue(queuedList.ElementAt(0));

			Assert.AreEqual(queuedList.ElementAt(1), queue.Front);
		}

		[TestMethod]
		public void ManagedQueue_Dequeue_FrontDoesNotEqualExceptParameter_CollectionNotDequeued()
		{
			IEnumerable<int> queuedList = Enumerable.Range(0, 100);

			ManagedQueue<int> queue = new ManagedQueue<int>(queuedList);

			queue.Dequeue(queuedList.ElementAt(2));

			Assert.AreEqual(queuedList.ElementAt(0), queue.Front);
		}

		[TestMethod]
		public void ManagedQueue_MultipleThreadsModifyEachOhersResources_ThrowsExeption()
		{
			ThreadDangerException exception = null;

			Action action = () =>
			{
				IEnumerable<int> iterations = Enumerable.Range(0, 10000000);

				ThreadDangerous threadDangerous = new ThreadDangerous();

				try
				{
					Parallel.ForEach(iterations, x => threadDangerous.DoSomething());
				}
				catch (AggregateException aex)
				{
					foreach (var ex in aex.Flatten().InnerExceptions)
					{
						if (!(ex is ThreadDangerException))
							throw;

						exception = (ThreadDangerException)ex;
					}
				}
			};

			do
			{
				action();
			} while (exception == null);

			Assert.IsNotNull(exception);
			Assert.AreEqual("Not thread safe", exception.Message);
		}

		[TestMethod]
		public void ManagedQueue_MultipleThreadsModifyEachOhersResources_DoesNotThrowExeption()
		{
			IEnumerable<int> iterations = Enumerable.Range(0, 10000000);

			ThreadDangerException exception = null;

			ThreadSafe threadSafe = new ThreadSafe();

			try
			{
				Parallel.ForEach(iterations, x => threadSafe.DoSomething());
			}
			catch (AggregateException aex)
			{
				foreach (var ex in aex.Flatten().InnerExceptions)
				{
					if (!(ex is ThreadDangerException))
						throw;

					exception = (ThreadDangerException)ex;
				}
			}

			Assert.IsNull(exception);
		}
	}

	public class ThreadDangerException : Exception
	{
		public ThreadDangerException() : base("Not thread safe") { }
	}

	public class ThreadDangerous
	{
		private Guid test;
		private readonly Guid ctrl;

		public void DoSomething()
		{
			test = Guid.NewGuid();
			test = ctrl;

			if (test != ctrl)
				throw new ThreadDangerException();
		}
	}

	public class ThreadSafe
	{
		private Guid test;
		private readonly Guid ctrl;
		private readonly object _lock = new Object();

		public void DoSomething()
		{
			lock (_lock)
			{
				test = Guid.NewGuid();
				test = ctrl;

				if (test != ctrl)
					throw new ThreadDangerException();
			}
		}
	}
}