using System;

namespace CSharpPractice
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*In C#, constructor is a special method which is invoked automatically
            at the time of object creation. It is used to initialize the data members
            of new object generally. The constructor in C# has the same name as class or struct.

            There can be two types of constructors in C#.

            1. Default constructor
            2. Parameterized constructor*/

            //Default constructor
            /*A constructor which has no argument is known as default constructor.It is invoked
            at the time of creating object.*/
            Employee Default = new Employee();

            //Parameterized constructor
            Employee Parameterized = new Employee("Hello", "World");
            Parameterized.EmployeeInfo();

            Default.EmployeeInfo();

            // if we don't create any constructor it will automatically create a default constructor for us

            /*
             * The main purpose of constructor is to initialize class fields.
             * constructor is not mandatory. a default constructor is automatically provided.
             * constructor do not have return values and always have the same name of class
             */
        }
    }

    public class Employee
    {
        private string _firstName;
        private string _lastName;

        //Default constructor
        //public Employee()
        //{
        //    Console.WriteLine("Default Constructor Invoked");
        //}

        public Employee() : this("No First Name", "No Last Name")
        {
        }

        public Employee(string FirstName, String LastName)
        {
            _firstName = FirstName;
            _lastName = LastName;
        }

        public void EmployeeInfo()
        {
            Console.WriteLine("Full Name : {0} {1}", _firstName, _lastName);
        }
    }
}