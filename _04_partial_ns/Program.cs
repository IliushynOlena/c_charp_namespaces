// Program.cs

using A;
//using A;
using System;
//using A;

namespace B
{
    public class Class
    {
        public static void Main()
        {
            ClassA a = new ClassA();
            a.Print();
            ClassB b = new ClassB();
            b.Print();
            ClassC c = new ClassC();
            c.Print();
            c.PrintNew();

           
        }
    }
}