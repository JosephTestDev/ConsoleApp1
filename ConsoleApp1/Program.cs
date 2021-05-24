using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {     

            List<int> fib = Fibonacci.GetFibonacciSequence(54);

            for(int index = 0; index < fib.Count; index++)
                Console.WriteLine(fib[index]);
        }
    }
}
