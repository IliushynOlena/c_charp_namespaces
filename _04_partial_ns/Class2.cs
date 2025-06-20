// Class2.cs
using System;

namespace A
{
    class ClassB
    {
        public void Print()
        {
            Console.WriteLine("Printing from A.ClassB");
        }
    }
}

namespace A
{
    partial class ClassC
    {
        public void Print()
        {
            Console.WriteLine("Printing from A.ClassC");
        }
    }
}
namespace A
{
    partial class ClassC
    {
        public void PrintNew()
        {
            Console.WriteLine("Printing from A.ClassC");
        }
    }
}