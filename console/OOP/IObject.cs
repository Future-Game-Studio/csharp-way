using System;

namespace MyApp 
{
    public partial class Program
    {
        #region Counters
        interface ICounter
        {
            int Count { get; set; }
        }

        interface ITitle
        {
            int FullName { get; set; }
        }

        class StringCounter : ICounter
        {
            public int Count { get; set; }
        }
        class Counter : ICounter, ITitle
        {
            private int _count;

            public int Count
            {
                get => _count;
                set => _count = value;
            }
            int ITitle.FullName { get; set; }
        }

#endregion

        public abstract class Fruits : IObject
        {
            public abstract string Shape { get; set; }

            public void Log()
            {
                Console.WriteLine("Type: " + GetType().Name + " Shape: " + Shape);
            }
        }

        class Apple : Fruits
        {
            public override string Shape { get; set; } = "Sphere";
        }
        class Grapes : Fruits
        {
            public override string Shape { get; set; } = "Multiple";

        }
        class Car : IObject
        {
            public int Wheels { get; set; }
            public string Dimentions { get; set; } = "";
        }

        class Logger<T> where T : IObject
        {
            public void Log(IObject obj)
            {
                Console.WriteLine("Logger => " + obj.GetType().Name);
            }
        }

        interface IObject
        {
        }
    }
}