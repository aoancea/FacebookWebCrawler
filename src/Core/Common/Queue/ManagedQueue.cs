using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crawler.Core.Common.Queue
{
	public class ManagedQueue<T> where T : IComparable
	{
		private object locker = new object();

		private readonly Queue<T> internalQueue;

		public T DequeuedItem { get; private set; }

		public ManagedQueue(IEnumerable<T> collection)
		{
			this.internalQueue = new Queue<T>(collection);
			DequeuedItem = this.internalQueue.Dequeue();
		}

		public void Dequeue(T previouslyDequeued)
		{
			lock (locker)
			{
				if (DequeuedItem.CompareTo(previouslyDequeued) == 0)
				{
					DequeuedItem = this.internalQueue.Dequeue();
				}
			}
		}
	}
}