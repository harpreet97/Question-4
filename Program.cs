using System;

namespace Question_4
{
    class Person
    {
        public string FirstName { get; set
        public String LastName { get; set; }
        public Int16 YearOfBirth { get; set; }

        public Person(string firstName, string lastName)
        {

            FirstName = firstName;
            LastName = lastName;
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

        public int StudentID { get; set; }
        public string Campus { get; set; }
        public Student(string firstName, string lastName,string campus) : base(firstName, lastName)
        {

            StudentID = EnrollStudent();
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
            System.Console.Write("Enter first name: ");
            string firstname = Console.ReadLine();
            
            Console.WriteLine("");
            System.Console.Write("Enter last name:");
            string lastname = Console.ReadLine();
            Console.WriteLine("");

            System.Console.Write("Enter your campus:");
            string campus = Console.ReadLine();
            Console.WriteLine("");
            
            Console.WriteLine("Creating new person record...");
            Console.WriteLine("");
            Console.WriteLine("Adding new student record to Mokoia campus...");
            Console.WriteLine("");
            Student newStudent = new Student(firstname, lastname, campus);
            System.Console.WriteLine(string.Format("{0} {1} of {2} campus has a student ID of {3}.", newStudent.FirstName, newStudent.LastName, newStudent.Campus, newStudent.StudentID));
            Console.ReadLine();
        }
    }
}
