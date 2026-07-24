using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAL_1
{
    internal class Program
    {
        //Adminssion Management System
        class Student
        {
            public int AdmissionNumber;
            public string StudentName;
            public string CourseName;
            public int Semester;

            private double Fees;
            private bool IsScholarshipEligible;

            private const double ScholarshipRate = 0.10;

            public bool CheckResult()
            {
                Console.Write("Enter Your 12th Percentage: ");
                int percentage = Convert.ToInt32(Console.ReadLine());

                if (percentage <= 55)
                {
                    Console.WriteLine("You are not eligible for admission.");
                    return false;
                }

                return true;
            }

            public bool StudentFields()
            {
                Console.WriteLine("1. Commerce");
                Console.WriteLine("2. Science");
                Console.WriteLine("3. Arts");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 2)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Only Science students are eligible for admission.");
                    return false;
                }
            }

            public void AcceptDetails()
            {
                Console.Write("Enter Admission Number: ");
                AdmissionNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Student Name: ");
                StudentName = Console.ReadLine();
                Console.Write("Enter Course Name: ");
                CourseName = Console.ReadLine();
                Console.Write("Enter Semester: ");
                Semester = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Fees: ");
                Fees = Convert.ToDouble(Console.ReadLine());
            }
            public void CheckScholarshipEligibility()
            {
                if (Fees >= 50000)
                {
                    IsScholarshipEligible = true;
                }
                else
                {
                    IsScholarshipEligible = false;
                }
            }

            public void DisplayDetails()
            {

                double FinalFees = Fees;
                if(IsScholarshipEligible)
                {
                    FinalFees = Fees - (Fees * ScholarshipRate);
                }

                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Student Details:");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine($"Admission Number: {AdmissionNumber}");
                Console.WriteLine($"Student Name: {StudentName}");
                Console.WriteLine($"Course Name: {CourseName}");
                Console.WriteLine($"Semester: {Semester}");
                Console.WriteLine($"Fees: {FinalFees}");
                Console.WriteLine($"Scholarship Eligible: {IsScholarshipEligible}");
            }
        }
        static void Main(string[] args)
        {
            Student S1 = new Student();

            if (S1.CheckResult() == false)
            {
                Console.ReadKey();
                return;   
            }

            if (S1.StudentFields() == false)
            {
                Console.ReadKey();
                return;  
            }

            S1.AcceptDetails();
            S1.CheckScholarshipEligibility();
            S1.DisplayDetails();

            Console.ReadKey();
        }
    }
}
