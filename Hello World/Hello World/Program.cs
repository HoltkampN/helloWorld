using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            var myString = "Hello World";

            var myOtherString = myString;

            Console.WriteLine(myString);
            Console.WriteLine(myOtherString);

            var myInputString = Console.ReadLine();

            Console.WriteLine("my input: " + myInputString);
            Console.ReadLine();

            var myDecimal = 100.1m;

            myDecimal += 1.34m;

           


                
            

        }
    }
}
