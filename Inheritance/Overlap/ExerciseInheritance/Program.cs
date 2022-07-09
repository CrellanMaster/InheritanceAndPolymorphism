using ExerciseInheritance.Entities;
using System.Globalization;

namespace ExerciseInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= numEmployees; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/h)? ");
                char test = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hours: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (test == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    employees.Add(new OutSourceEmployee(name, hours, valuePerHours, additional));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHours));
                }
            }

            Console.WriteLine("PAYMENTS: ");

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} - ${employee.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}