using System;
using System.Collections.Generic;

namespace MarkViiInClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = new List<int>();
            Stack<int> numbersStack = new Stack<int>();
            Queue<int> numbersQueue = new Queue<int>();
            Bag<int> numbersBag = new Bag<int>();
        }
    }

    class Bag<T>
    {
        private List<T> items = new List<T>();

        public void PutInBag(T item)
        {
            items.Add(item);
        }

        public T GetFromBag()
        {
            int randomIndex = new Random().Next(0, items.Count);

            T item = items[randomIndex];
            items.RemoveAt(randomIndex);

            return item;
        }
    }
}
