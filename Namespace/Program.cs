using System;
using Project_A;
using Project_B;

namespace Namespaces_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Project_A.ClassA.print();
            Project_B.ClassA.print();

        }
    }
}
