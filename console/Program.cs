using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            var exp = new ExceptionsShowcase();

            var fruits = new List<Fruits>(); 

            fruits.Add(new Apple());
            fruits.Add(new Grapes());
            //  fruits.Add(new Car());

            var box = new Box(fruits);
            //  box.Add(new Car());

            var found = box.SearchShape("Sphere");

            var logger = new Logger<Fruits>();

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

            if (box.TrySearchShape("Sphere", out var fruit2))
            {
                // do something with object
            }
            else
            {
                // did not found anything(
            }

        }

        static T[] ParseParams<T>(string[] args, T[] counters) where T : ICounter
        {
            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    int number;
                    if (int.TryParse(args[i], out number))
                    {
                        counters[i].Count = number;
                    }
                }
            }

            return counters;
        }
    }
}