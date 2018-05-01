using System;

namespace Question_4
{
    class Person
    {
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public Int16 YearOfBirth { get; set; }

        public Person(string fn, string ln)
        {

            FirstName = fn;
            LastName = ln;
        }
        public int GetAge()
        {
            var age = DateTime.Now.Year - YearOfBirth;
            return age;
        }
        public string GetFullName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

    }
    class Student : Person
    {

        public int StudentId { get; set; }
        public string Campus { get; set; }
        public Student(string fn, string ln,string campus) : base(fn, ln)
        {

            StudentId = EnrollStudent();
            Campus = campus;

        }

        public int EnrollStudent()
        {
            Random _rdm = new Random();
            return _rdm.Next(1000, 9999);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the details of student below");
            Console.WriteLine("********************************");
            System.Console.WriteLine("Enter your first name?");
            string firstname = Console.ReadLine();
            Console.WriteLine("Firstname:" + firstname);
            Console.WriteLine("");
            System.Console.WriteLine("Enter your last name?");
            string lastname = Console.ReadLine();
            Console.WriteLine("Lastname" + lastname);
            Console.WriteLine("");
            System.Console.WriteLine("Enter your campus?");
            string campus = Console.ReadLine();
            Console.WriteLine("Campus:" + campus);
            Console.WriteLine("");
            Console.WriteLine("Creating new person record...");
            Console.WriteLine("");
            Student newStudent = new Student(firstname, lastname, campus);
            System.Console.WriteLine(string.Format("{0} {1} of {2} campus has a student ID of {3}", newStudent.FirstName, newStudent.LastName, newStudent.Campus, newStudent.StudentId));
            Console.ReadLine();
        }
    }
}
