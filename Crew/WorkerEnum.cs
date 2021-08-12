using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crew
{
    class WorkerEnum : IEnumerator<Worker>
    {
        private Worker[] _workers;
        private int position = -1;

        public WorkerEnum(Worker[] list)
        {
            _workers = list;
        }

        public Worker Current
        {
            get
            {
                try
                {
                    return _workers[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (++position >= _workers.Length)
            {
                return false;
            }
            else
            {
                return (position < _workers.Length);
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
