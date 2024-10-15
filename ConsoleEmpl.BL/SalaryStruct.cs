using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmpl.BL
{
    public struct SalaryStruct
    {
        private double Salary;
        public DateTime ReportingDate { get; set; }

        public SalaryStruct(double salary)
        {
            Salary = salary;
            ReportingDate = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Salary Slip: \nSalary: {Salary} \nReportingDate: {ReportingDate}";
        }
    }
}
