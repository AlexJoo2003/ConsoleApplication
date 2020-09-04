using System;

namespace ConsoleApplication1
{
    
    class Student
    {
        // Class Variables
        public string _firstName;
        protected string _lastName;
        protected string _schoolClass;
        public string school = "NTI";
        protected string[] AvailableJobs = { };

        public Student(string firstName, string lastName, string schoolClass)
        {
            _firstName = firstName;
            _lastName = lastName;
            _schoolClass = schoolClass;
            
            PrintInfo();
        }

        private void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("First Name: " + _firstName);
            Console.WriteLine("Last Name: " + _lastName);
            Console.WriteLine("Class Name: " + _schoolClass); 
            Console.WriteLine("School: " + school);
        }
        
        public void ListJobs()
        {
            Console.WriteLine();
            Console.WriteLine("Available Jobs:");
            foreach (string job in AvailableJobs)
            {
                Console.WriteLine(job);
            }
        }

        public void Talk()
        {
            Console.WriteLine();
            Console.WriteLine("Hello! I study in " + school + "!");
        }
        
    }

    class Engineering : Student
    {
        public Engineering(string firstName, string lastName, string schoolClass) : base(firstName, lastName, schoolClass)
        {
            _firstName = firstName;
            _lastName = lastName;
            _schoolClass = schoolClass;
            
            string[] availableJobs = {"WebbDeveloper", "ScienceEngineer", "SpaceEngineer", "etc"};
            AvailableJobs = availableJobs;
        }

        public void Talk()
        {
            Console.WriteLine();
            Console.WriteLine("Hello! I'm an Engineering Student at " + school + ".");
            Console.WriteLine();
        }
    }

    class Design : Student
    {
        
        public Design(string firstName, string lastName, string schoolClass) : base(firstName, lastName, schoolClass)
        {
            string[] availableJobs = {"McDonalds"};
            AvailableJobs = availableJobs;
        }
        public void Talk()
        {
            Console.WriteLine();
            Console.WriteLine("Hello! I'm a Design Student and I can ... nvm.");
        }
    }
    
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Engineering student1 = new Engineering("Alexander", "Alnoumeh", "19Te");
            Console.WriteLine(student1._firstName);
            // student1.PrintInfo(); Wont work cuase it is private
            student1.ListJobs();
            student1.Talk();
            Console.WriteLine();
            
            Design student2 = new Design("Saga", "Lundberg", "19Te");
            student2.ListJobs();
            student2.Talk();
            Console.WriteLine();
            
            Student student3 = new Student("TestName", "testName", "123asd");
            student3.school = "LBS";
            student3.Talk();
            
            Console.ReadKey();
        }
    }
}