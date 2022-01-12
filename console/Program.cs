using Playground.OOP;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Playground // Note: actual namespace depends on the project name.
{
    public partial class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var fruits = new List<Fruits>
            {
                new Apple(),
                new Grapes()
            };

            var box = new Box(fruits);

            var found = box.SearchShape("Sphere");

            var logger = new Logger<Fruits>();




            foreach (var shape in Where(box, item => item.Shape == "Sphere"))
            {

            }

            foreach (var shape in box.Select(StringFormatter))
            {
                Console.Write(shape);
            }

            var numbers = Enumerable.Range(0, 10).ToArray();

            var max = numbers.Max();
            var min = numbers.Min();
            var average = numbers.Average();

            if (numbers.Any())
            {

            }

            numbers.Sum();
            numbers.Reverse();

            var product = numbers.Aggregate(1, (acc, x) => acc * x);
            numbers.Reverse().Skip(2).Reverse();


            foreach (var item in box)
            {
                logger.Log(item);
            }


            if (found != null)
            {
                found.Log();
            }
            else
            {
                // did not found anything(
            }

            if (box.TrySearchShape("Sphere", out _))
            {
                // do something with object
            }
            else
            {
                // did not found anything(
            }

        }

        private static string StringFormatter(Fruits arg1)
        {
            return string.Format(arg1.Shape, $" -> {0}");
        }

        static IEnumerable<int> Range(int itemsMax)
        {
            for (int i = 0; i < itemsMax; i++)
            {
                yield return i;
            }
        }
        static IEnumerable<T> Where<T>(IEnumerable<T> items, Func<T, bool> predicate)
        {
            foreach (var item in items)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        static IEnumerable<R> Select<T, R>(IEnumerable<T> items, Func<T, R> predicate)
        {
            foreach (var item in items)
            {
                yield return predicate(item);
            }
        }
    }
}