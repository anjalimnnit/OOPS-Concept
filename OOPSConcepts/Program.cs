using System;

namespace OOPSConcepts
{
    class Program
    {
        static void Main()
        {
            RunTimePolymorphism poly = new(0);
            poly.Print();
            RunTimePolymorphism child1 = new ChildClass(1);
            child1.Print();
            RunTimePolymorphism child2 = new DerivedClass(2);
            child2.Print();
        }
    }
}
