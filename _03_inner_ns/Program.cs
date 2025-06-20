using System;

// System.Collections.Generic.List<object>
// System.IO.StreamWriter
// System.Xml.Serialization.XmlSerializationReader

namespace ITAcademy
{
    namespace ProgrammingDepartment
    {
        namespace CSharp
        {
            namespace Basics
            {
                class MyClass
                {
                    //...
                }
            }
        }
        namespace CPlusPlus
        {
            namespace Basics
            {
                class MyClass
                {
                    //...
                }
            }
        }
    }
}
//namespace ITAcademy.ProgrammingDepartment.CSharp.Basics.MyClass{ }

namespace CompanyName
{
    namespace BankingSerices
    {
        class Client
        {
            //...
        }
    }
}
// CompanyName.BankingSerices.Client

namespace NS
{
    namespace A
    {
        class Foo
        {
            public void Method()
            {
                Console.WriteLine("Hello from A.Foo");
            }
            static void Main()
            {
                Foo obj = new Foo();
                obj.Method();

                NS.Foo f = new NS.Foo();
                f.Method();

                global::Foo obj2 = new global::Foo();
                obj2.Method();
            }
        }
    }
    class Foo
    {
        public void Method()
        {
            Console.WriteLine("Hello from NS.Foo");
        }
    }
}
class Foo
{
    public void Method()
    {
        Console.WriteLine("Hello from .Foo");
    }
}