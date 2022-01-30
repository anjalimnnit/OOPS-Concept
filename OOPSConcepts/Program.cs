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
            CourseInterface abs = new CourseInterface(); 
            abs.EndCourse();
            ICourse1 course1 = new CourseInterface();  // For explicit interface declaration we require instance of interface itself;
            course1.StartCourse();
            ICourse2 course2 = new CourseInterface();
            course2.StartCourse();
            Dog myDog = new Dog();
            myDog.AnimalSound(); 
            myDog.Sleep();
            Car car = new Car();
            Console.WriteLine(car.brand);
            car.honk();
            Console.WriteLine(car.modelName);
        }
    }
}
