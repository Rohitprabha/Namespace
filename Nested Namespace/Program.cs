using System;
using nested1.ProjectC;

namespace nested1
{
    namespace ProjectC
    {
        class ClassA
        {
            public void print()
            {
                Console.WriteLine("Nested Namespace");
            }
        }
    }
}

namespace Nested_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA c = new ClassA();
            c.print();
        }
    }
}


