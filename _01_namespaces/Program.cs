using System;

namespace CSharpNamespace
{
    class Foo
    {
        //...
    }
  
}
namespace CSharpNamespace1
{
    class Foo
    {
        //...
    }
   
}

namespace A
{
    class Incrementer
    {
        private int _count;
        public Incrementer(int count)
        {
            _count = count;
        }
        public int AnotherMultyIncrement()
        {
            for (int i = 0; i < 5; i++)
                _count++;
            return _count;
        }
    }

}
namespace B
{
    class Incrementer
    {
        private int _var;
        public Incrementer(int var)
        {
            _var = var;
        }
        public int MultyIncrement()
        {
            for (int i = 0; i < 5; i++)
                _var += 10;
            return _var;
        }
    }
    class Tester
    {
        public static void Main()
        {
            Incrementer obj1 = new Incrementer(10);
            
            Console.WriteLine(obj1.MultyIncrement());
           
            A.Incrementer incrementer = new A.Incrementer(10);
            ////A.Incrementer obj2 = new A.Incrementer(5);
            Console.WriteLine(incrementer.AnotherMultyIncrement());
        }
    }
}
