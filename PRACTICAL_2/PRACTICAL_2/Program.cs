using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAL_2
{
    internal class Program
    {
        class Employee
        {
            public int Empid;
            public string Name;
            public string Designation;
            public int Salary;
            public bool FullTime;
            public int Leaves;
        }

        interface IPayroll
        {
            void CalculateSalary();
        }

        class GetDetails : Employee
        {
            public void GetEmployeeDetails()
            {
                Console.WriteLine("---------------Enter Employee Details---------------");
                Console.WriteLine("Enter Employee ID: ");
                Empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name: ");
                Name = Console.ReadLine();
                Console.WriteLine("Enter Employee Designation: ");
                Designation = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary: ");
                Salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Is Employee Full Time? (true/false): ");
                FullTime = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Enter Employee Leaves: ");
                Leaves = Convert.ToInt32(Console.ReadLine());
            }
        }

        class DisplayDetails : GetDetails, IPayroll
        {

            public void CalculateSalary()
            {
                double DA = 0, HRA = 0, MA = 0, PF = 0;
                double TotalSalary = 0;
                int salaryCut = 0;

                if (Salary >= 500000)
                {
                    DA = Salary * 0.05;   
                    HRA = Salary * 0.02;  
                    MA = Salary * 0.03;   
                    PF = 20000;
                }
                else
                {
                    DA = Salary * 0.03;   
                    HRA = Salary * 0.01;  
                    MA = Salary * 0.02;   
                    PF = 10000;
                }

                TotalSalary = (Salary + DA + HRA + MA) - PF;

                if (Leaves > 10)
                {
                    salaryCut = (Leaves - 10) * 1000;
                }

                TotalSalary -= salaryCut;

                Console.WriteLine("\n--------- Salary Details ---------");
                Console.WriteLine("Basic Salary : " + Salary);
                Console.WriteLine("DA           : " + DA);
                Console.WriteLine("HRA          : " + HRA);
                Console.WriteLine("MA           : " + MA);
                Console.WriteLine("PF           : " + PF);
                Console.WriteLine("Total Leaves: " + Leaves);
                Console.WriteLine("Salary Cut: ₹" + salaryCut);
                Console.WriteLine("Net Salary   : " + TotalSalary);
            }
            public void DisplayEmployeeDetails()
            {
                Console.WriteLine("---------------Employee Details---------------");
                Console.WriteLine("Employee ID: " + Empid);
                Console.WriteLine("Employee Name: " + Name);
                Console.WriteLine("Employee Designation: " + Designation);
                Console.WriteLine("Employee Salary: " + Salary);

                if (FullTime)
                    Console.WriteLine("Employee is Full Time");
                else
                    Console.WriteLine("Employee is Part Time");

            }
        }
        static void Main(string[] args)
        {
            DisplayDetails employee = new DisplayDetails();

            employee.GetEmployeeDetails();
            employee.DisplayEmployeeDetails();
            IPayroll payroll = employee;
            payroll.CalculateSalary();
        }
    }
}
