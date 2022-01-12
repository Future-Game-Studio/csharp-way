using System;

namespace Playground.OOP
{
    #region Counters
    internal interface ICounter
    {
        int Count { get; set; }
    }

    internal interface ITitle
    {
        int FullName { get; set; }
    }

    internal class StringCounter : ICounter
    {
        public int Count { get; set; }
    }

    internal class Counter : ICounter, ITitle
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

    internal class Apple : Fruits
    {
        public override string Shape { get; set; } = "Sphere";
    }

    internal class Grapes : Fruits
    {
        public override string Shape { get; set; } = "Multiple";

    }

    internal class Car : IObject
    {
        public int Wheels { get; set; }
        public string Dimentions { get; set; } = "";
    }

    internal class Logger<T> where T : IObject
    {
        public void Log(IObject obj)
        {
            Console.WriteLine("Logger => " + obj.GetType().Name);
        }
    }

    /// <summary>
    /// Base object marker
    /// </summary>
    internal interface IObject
    {
    }
}