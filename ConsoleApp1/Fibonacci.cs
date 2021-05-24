using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Fibonacci
    {
        public static List<int> GetFibonacciSequence(int fibIndex)
        {
            List<int> sequence = new List<int>();       
            sequence.Add(1);
            sequence.Add(1);
            if (fibIndex > 2 )
            {
                sequence = recurse(fibIndex - 2, sequence);
            }
            return sequence;
        }
        private static List<int> recurse(int count, List<int> sequence)
        {
            if(fibsub.Class1.EmptyProcessor() == false)
            {
                return sequence;
            }
            if(count > 0)
            {
                sequence.Add(sequence[sequence.Count - 1] + sequence[sequence.Count - 2]);
                count--;
                return recurse(count, sequence);
            }
            return sequence;
        }
    }
}
