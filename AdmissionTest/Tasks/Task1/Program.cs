using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var name = GetName();
            Console.WriteLine(name);
        }

        public static string GetName()
        {
            // Remove NotImplementedException and add code here.
            // GetObject returns an object which has Name property
            // Get that value and return that.
            object nm = GetObject();
            
            return nm.Name;
        }

        public static object GetObject()
        {
            return new { Name = "Camera", Price = 200 };
        }
    }
}
