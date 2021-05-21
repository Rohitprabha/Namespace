using System;
using PROA = Project_A.ClassA;                           //use alias for avoiding ambiguity
using PROB = Project_B.ClassA;
namespace Namespace_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            PROA.print();
            PROB.print();
        }
    }
}
