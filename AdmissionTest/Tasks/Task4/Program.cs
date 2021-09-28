using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var point1 = new Point { X = 5, Y = 9 };
            var point2 = point1;

            point2.X = 3;

            Console.WriteLine($"Point1 X: {point1.X}");
            Console.WriteLine($"Point2 X: {point2.X}");

        }
    }
}
