using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Method Hiding allows a derived type to define the same method present in base class with a different implementation and hide it from base class */
namespace OOPSConcepts
{
    public class RunTimePolymorphism
    {
        int number;
        // Default constructors are created only when any other constructor is not defined
        public RunTimePolymorphism(int x)
        {
            number = x;
            Console.WriteLine("Base class constructor");
        }
        public virtual void Print()
        {
            Console.WriteLine($"Hello from parent {number}");
        }
    }
        public class ChildClass : RunTimePolymorphism
        {
        int number;
            public ChildClass(int x): base(x)  // Base class constructor gets called first
           {
            number = x;
            Console.WriteLine($"Derived class {number} constructor");
        }
            public override void Print()
            {
                Console.WriteLine($"Hello from child class {number}");   // Method overriding using override keyword 
            }
        }
        public class DerivedClass : RunTimePolymorphism
        {
        int number;
       public  DerivedClass(int x) : base(x)
        {
            number = x;
            Console.WriteLine($"Derived class {number} constructor");
        }
            public new void Print()
            {
                Console.WriteLine($"Hello from child class {number}");  // Method hiding using new keyword 
        }
        }
    }

