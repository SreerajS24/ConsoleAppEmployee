using ConsoleEmpl.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee("Sreeraj", "Sreekumaran", 1000, 313);
            Console.WriteLine(employee1.FullName());
            Console.WriteLine($"Salary: {employee1.Salary}");
            Console.WriteLine($"Pin Code: {employee1.PinCode}");

            Console.WriteLine(Environment.NewLine);

            var employee2 = new Employee("Renjith", "S", 2000, 314);
            Console.WriteLine(employee2.FullName());
            Console.WriteLine($"Salary: {employee2.Salary}");
            Console.WriteLine($"Pin Code: {employee2.PinCode}");
            Console.WriteLine(Environment.NewLine);

            //Struct Example
            SalaryStruct salarystruct = new SalaryStruct(1000);
            Console.WriteLine(salarystruct.ToString());
            Console.WriteLine(Environment.NewLine);

            //with no return value
            UpdateSalarySlip(salarystruct, DateTime.UtcNow);
            Console.WriteLine($"UpdateSalarySlip with no return \n{salarystruct.ToString()}");
            Console.WriteLine(Environment.NewLine);

            //with ref keyword
            UpdateSalarySlipWithRef(ref salarystruct, DateTime.UtcNow);
            Console.WriteLine($"UpdateSalarySlip with no return \n{salarystruct.ToString()}");
            Console.WriteLine(Environment.NewLine);

            //with 'out' return value
            UpdateSalarySlipOut(out salarystruct, DateTime.UtcNow);
            Console.WriteLine($"UpdateSalarySlip with out return \n{salarystruct.ToString()}");
            Console.WriteLine(Environment.NewLine);

            //with return value
            salarystruct = UpdateSalarySlipReturn(salarystruct, DateTime.UtcNow);
            Console.WriteLine($"UpdateSalarySlip with return \n{salarystruct.ToString()}");
            Console.WriteLine(Environment.NewLine);

            employee1.AddCompletedTasks("Task1");
            employee1.AddCompletedTasks("Task2");
            employee1.Describe(employee1.FullName());

            employee2.AddCompletedTasks("Task3");
            employee2.AddCompletedTasks("Task4");
            employee2.Describe(employee2.FullName());

            Console.ReadLine();
        }

        private static void UpdateSalarySlip(SalaryStruct salarySlip, DateTime reportingDate)
        {
            salarySlip.ReportingDate = reportingDate;
        }

        private static void UpdateSalarySlipWithRef(ref SalaryStruct salarySlip, DateTime reportingDate)
        {
            salarySlip.ReportingDate = reportingDate;
        }

        private static SalaryStruct UpdateSalarySlipReturn(SalaryStruct salarySlip, DateTime reportingDate)
        {
            salarySlip.ReportingDate = reportingDate;
            return salarySlip;
        }

        private static void UpdateSalarySlipOut(out SalaryStruct salarySlip, DateTime reportingDate)
        {
            SalaryStruct salary1 = new SalaryStruct(2000);
            salary1.ReportingDate = reportingDate;
            salarySlip = salary1;
        }

    }
}
