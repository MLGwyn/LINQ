using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> MultiplyBy2 = value => value * 2;
            // int MultiplyBy2(int value)
            // {
            //     return value * 2;
            // }
            var scores = new List<int> { 42, 100, 98, 15 };
            var newScores = new List<int>();
            foreach (var score in scores)
            {
                var doubled = MultiplyBy2(score);
                newScores.Add(doubled);
            }

            Console.ReadLine();

        }
    }
}
