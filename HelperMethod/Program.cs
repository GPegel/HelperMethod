using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string myValue = superSecretFormula("world");
            Console.WriteLine(myValue);
            Console.ReadLine();

        }

        private static string superSecretFormula()
        {
            //some cool stuf here
            return " Hello World";
        }

        private static string superSecretFormula(string name)
        {
            return String.Format("Hello, {0}", name);
        }
    }
}
