using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmpl.BL
{
    public class Employee
    {
        private string FirstName;
        private string LastName;
        private StringBuilder _completedTasks;
        public double Salary { get; }
        public int PinCode { get; }
        

        public Employee(string firstName, string lastName, double salary, int pinCode)
            {
                FirstName= firstName;
                LastName = lastName;
                Salary = salary;
                PinCode = pinCode; 
                _completedTasks = new StringBuilder();
            }

        public string FullName()
        {
            var fullname = FirstName + " " + LastName;
            return fullname;
        }

        public void AddCompletedTasks(string taskName)
        {
            _completedTasks.AppendLine(taskName);
        }

        public void Describe(string FullName)
        {
            Console.WriteLine($"{FullName} Completed tasks:");
            Console.WriteLine(_completedTasks.ToString());
        }


    }
}
