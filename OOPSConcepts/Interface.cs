using System;

namespace OOPSConcepts
{
    public interface ICourse1
    {
        public void StartCourse();
        public void EndCourse();

        public int GetCourseNumber()  // Default interface implementation
        {
            return 1;
        }
    }
    public interface ICourse2
    {
        public void StartCourse();
        public void EndCourse();
        public int GetCourseNumber()
        {
            return 2;
        }

    }
    class CourseInterface : ICourse1, ICourse2
    {
        public void EndCourse()        // Implicit interface implementation
        {
            Console.WriteLine("Endcourse");
        }

        void ICourse1.StartCourse()   // Explicit interface implementation (does not require public access specifier)
        {
            Console.WriteLine("Startcourse for Icourse 1");
        }
        void ICourse2.StartCourse()
        {
            Console.WriteLine("Startcourse for Icourse 2");
        }
    }
}