using System;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        interface ICounter
        {
            int Count { get; set; }
        }

        class StringCounter : ICounter
        {
            public int Count { get; set; }
        }

        class Counter : ICounter
        {
            private int _count;

            public int Count
            {
                get => _count;
                set => _count = value;
            }
        }
        public static void Main(string[] args)
        { 
            string[] args2 = Environment.GetCommandLineArgs();

            var count = args.Length;

            var counters = ParseParams<Counter>(args,
                    new Counter[count].Select(x => new Counter()).ToArray());

            int index = 0;
            foreach (var item in counters)
            {
                Console.WriteLine($"Item {index++} {item.Count}");
            }

            string valueStr = "Params";

            if (valueStr is not null)
            {
                
            }
        }

        static T[] ParseParams<T>(string[] args, T[] counters) where T : ICounter
        {
            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (int.TryParse(args[i], out var number))
                    {
                        counters[i].Count = number;
                    }
                }
            }

            return counters;
        }
    }
}