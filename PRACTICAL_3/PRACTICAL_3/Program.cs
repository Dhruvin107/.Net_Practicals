using System;
using System.Collections.Generic;

namespace PRACTICAL_3
{
    class Trip
    {
        public string TripName;
        public string Destination;
        public int NumberOfDays;

        public void GetTripDetails()
        {
            Console.Write("Enter Trip Name: ");
            TripName = Console.ReadLine();

            Console.Write("Enter Destination: ");
            Destination = Console.ReadLine();

            Console.Write("Enter Number of Days: ");
            NumberOfDays = Convert.ToInt32(Console.ReadLine());
        }

        public void DisplayTripDetails()
        {
            Console.WriteLine("\n------ Trip Details ------");
            Console.WriteLine("Trip Name      : " + TripName);
            Console.WriteLine("Destination    : " + Destination);
            Console.WriteLine("Number of Days : " + NumberOfDays);
        }
    }

    class ExpenseTracker : Trip
    {
        List<string> expenseNames = new List<string>();
        List<double> expenseCosts = new List<double>();

        public void AddExpenses()
        {
            Console.Write("\nEnter Number of Expenses: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nExpense " + (i + 1));

                Console.Write("Enter Expense Name: ");
                string name = Console.ReadLine();

                try
                {
                    Console.Write("Enter Expense Cost: ");
                    double cost = Convert.ToDouble(Console.ReadLine());

                    if (cost < 0)
                    {
                        throw new Exception("Expense cost cannot be negative.");
                    }

                    expenseNames.Add(name);
                    expenseCosts.Add(cost);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input! Please enter numeric value.");
                    i--;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    i--;
                }
            }
        }

        public void DisplayExpenses()
        {
            Console.WriteLine("\n------ Expense List ------");

            double total = 0;

            for (int i = 0; i < expenseNames.Count; i++)
            {
                Console.WriteLine(expenseNames[i] + " : ₹" + expenseCosts[i]);
                total += expenseCosts[i];
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine("Total Expense : ₹" + total);

            if (NumberOfDays > 0)
            {
                Console.WriteLine("Average Expense Per Day : ₹" + (total / NumberOfDays));
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ExpenseTracker tracker = new ExpenseTracker();

            try
            {
                tracker.GetTripDetails();
                tracker.AddExpenses();

                tracker.DisplayTripDetails();
                tracker.DisplayExpenses();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}