using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq; 

namespace MyApp 
{
    public partial class Program
    {
        public class Box : IEnumerable<Fruits>, IList
        {
            private List<Fruits> _items = new List<Fruits>();

            public bool IsFixedSize => ((IList)_items).IsFixedSize;

            public bool IsReadOnly => ((IList)_items).IsReadOnly;

            public int Count => ((ICollection)_items).Count;

            public bool IsSynchronized => ((ICollection)_items).IsSynchronized;

            public object SyncRoot => ((ICollection)_items).SyncRoot;

            public object? this[int index] { get => ((IList)_items)[index]; set => ((IList)_items)[index] = value; }

            public Box(IEnumerable<Fruits> items)
            {
                _items = items.ToList();
            }

            public void Add(Fruits obj)
            {
                _items.Add(obj);
            }

            public bool TrySearchShape(string shapeName, out Fruits? fruit)
            {
                foreach (var item in _items)
                {
                    if (item.Shape == shapeName)
                    {
                        fruit = item;
                        return true;
                    }
                }
                fruit = null;
                return false;
            }
            public Fruits? SearchShape(string shapeName)
            {
                foreach (var item in _items)
                {
                    if (item.Shape == shapeName)
                    {
                        return item;
                    }
                }
                return null;
            }

            public IEnumerator<Fruits> GetEnumerator()
            {
                return ((IEnumerable<Fruits>)_items).GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable)_items).GetEnumerator();
            }

            public int Add(object? value)
            {
                return ((IList)_items).Add(value);
            }

            public void Clear()
            {
                ((IList)_items).Clear();
            }

            public bool Contains(object? value)
            {
                return ((IList)_items).Contains(value);
            }

            public int IndexOf(object? value)
            {
                return ((IList)_items).IndexOf(value);
            }

            public void Insert(int index, object? value)
            {
                ((IList)_items).Insert(index, value);
            }

            public void Remove(object? value)
            {
                ((IList)_items).Remove(value);
            }

            public void RemoveAt(int index)
            {
                ((IList)_items).RemoveAt(index);
            }

            public void CopyTo(Array array, int index)
            {
                ((ICollection)_items).CopyTo(array, index);
            }
        }
    }
}