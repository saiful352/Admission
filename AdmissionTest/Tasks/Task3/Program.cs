using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var lines = GetLines();
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public static string[] GetLines()
        {
            // Remove NotImplementedException and write code here
            // You have to read all lines the text file in this project
            // and return all the text in that file as string array
            throw new NotImplementedException();
        }
    }
}
