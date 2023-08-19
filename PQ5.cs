using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_questions
{
    internal class PQ5
    {
        static void Main(string[] args)
        {
           int a=10; int b=12;
            int c;
            c = a;
            a = b;
            b=c;
            Console.WriteLine($"value of a is {a} and value of b is {b}");
        }
    }
}
