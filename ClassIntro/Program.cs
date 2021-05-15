using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Engin Demiroğ";
            int age = 36;

            //Kodlamaio 

            Course course1 = new Course();
            course1.CourseName = "C# : ";
            course1.Teacher = "Engin Demiroğ";
            course1.ViewRate = 68;

            Course course2 = new Course();
            course2.CourseName = "Java : ";
            course2.Teacher = "Kerem Varış";
            course2.ViewRate = 70;

            Course course3 = new Course();
            course3.CourseName = "Python : ";
            course3.Teacher = "Ercan Kırbıyık";
            course3.ViewRate = 30;

            Course course4 = new Course();
            course4.CourseName = "C++ : ";
            course4.Teacher = "Ali Veli";
            course4.ViewRate = 50;

            /*
             * Console.WriteLine(course1.CourseName + " " + course1.Teacher);
             Console.WriteLine(course2.CourseName + " " + course2.Teacher);
             Console.WriteLine(course3.CourseName + " " + course3.Teacher);
            */

            

            Course[] courses = new Course[] {course1, course2, course3, course4 };

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + course.Teacher);
            }

        }
    }

    class Course
    {
        public string CourseName { get; set; }

        public string Teacher { get; set; }

        public int ViewRate { get; set; }
    }
   


    
}
