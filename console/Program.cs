using Playground.OOP;
using System;
using System.Collections.Generic;

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
    }
}