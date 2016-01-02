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

		private readonly Queue<T> queue;

		public T Front { get; private set; }

		public ManagedQueue(IEnumerable<T> collection)
		{
			queue = new Queue<T>(collection);
			Front = queue.Dequeue();
		}

		public void Dequeue(T except)
		{
			lock (locker)
			{
				if (Front.CompareTo(except) == 0)
				{
					Front = queue.Dequeue();
				}
			}
		}
	}
}