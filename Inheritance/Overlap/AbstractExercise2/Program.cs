using AbstractExercise2.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace AbstractExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new CompanyPerson(name, annualIncome, employees));
                }
                else
                {
                    Console.Write("Health expenditures: ");
                    double healthSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new IndividualPerson(name, annualIncome, healthSpending));
                }
            }
            double total = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (Person person in list)
            {
                Console.WriteLine($"{person.Name}: $ {person.TaxCalc().ToString("F2", CultureInfo.InvariantCulture)}");
                total += person.TaxCalc();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}