// Program.cs

// using alias_name = full.name.of.namespace;
using System.Collections.Generic;
using Gen = System.Collections.Generic;
using X = NS;
using Y = NS1;

namespace M
{
    public class ClassM
    {
        public int m = 3;
        public static void Main()
        {        
            X.Class obj = new X.Class(); // Error
           

            NS.Class obj2 = new NS.Class();
            NS1.Class @class = new NS1.Class();


            X::Class @class1 = new X::Class();
            X.Class @class2 = new X.Class();    

            X::Class objA = new X::Class();
            objA.Print();
           
            Y.Class class3 = new Y.Class();
            Y::Class class4 = new Y::Class();

            Y::Class objB = new Y::Class();
            objB.Print();

            Y.Class c = new Y.Class();

         
          
        }
    }
    public class X
    {
        public class Class
        {
            //...
        }
    }
}