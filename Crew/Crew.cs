using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crew
{
    class Crew : IList<Worker>, IComparer<Worker>
    {
        #region IList
        private Worker[] _workers = new Worker[1];
        private int _count;

        public Crew()
        {
            _count = 0;
        }
        public Worker this[int index] 
        {
            get
            {
                return _workers[index];
            } 
            set
            {
                _workers[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(Worker item)
        {
            if (_count < _workers.Length)
            {
                _workers[_count] = item;
                _count++;
            }
        }

        public void Clear()
        {
            _count = 0;
        }

        public bool Contains(Worker item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_workers[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        public void CopyTo(Worker[] array, int arrayIndex)
        {
            for (int i = 0; i < Count; i++)
            {
                array.SetValue(_workers[i], arrayIndex++);
            }
        }

        public IEnumerator<Worker> GetEnumerator()
        {
            return new WorkerEnum(_workers);
        }

        public int IndexOf(Worker item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_workers[i] == item)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, Worker item)
        {
            if ((_count + 1 <= _workers.Length) && (index < Count) && (index >= 0))
            {
                _count++;

                for (int i = Count - 1; i > index; i--)
                {
                    _workers[i] = _workers[i - 1];
                }
                _workers[index] = item;
            }
        }

        public bool Remove(Worker item)
        {
            RemoveAt(IndexOf(item));
            return true;
        }

        public void RemoveAt(int index)
        {
            if((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                {
                    _workers[i] = _workers[i + 1];
                }
                _count--;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        #endregion

        #region IComparer
        public int Compare(Worker x, Worker y)
        {
            if (x.Position > y.Position)
            {
                Console.WriteLine("Sort by ");
                Console.WriteLine($"Name: {x.Name} Surname: {x.Surname} - Position: {x.Position}");
                Console.WriteLine($"Name: {y.Name} Surname: {y.Surname} - Position: {y.Position}");
                Console.WriteLine("-------------------------------------------------------------");
                return 1;
            }
            else if (x.Position < y.Position)
            {
                Console.WriteLine("Sort by ");
                Console.WriteLine($"Name: {x.Name} Surname: {x.Surname} - Position: {x.Position}");
                Console.WriteLine($"Name: {y.Name} Surname: {y.Surname} - Position: {y.Position}");
                Console.WriteLine("-------------------------------------------------------------");
                return -1;
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
