// Program.cs

//using NS;

//using NS1;
using System;
//using NS;
using NS1;


namespace M
{
    public class Program
    {
        public static void Main()
        {
            Class objA = new Class();
            
            NS1.Class c1 = new NS1.Class();
            //Class objA = new Class();
            //Class objA = new Class();
            NS.Class @class = new NS.Class();
            //NS.Class objA = new NS.Class();
          
            Console.WriteLine("objA = " + objA.a);
            objA.Print();


            NS1.Class objB = new NS1.Class();
            Console.WriteLine("objB = " + objB.b);
            objB.Print();
        }
    }
}