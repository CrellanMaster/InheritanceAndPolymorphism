using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercise2.Entities
{
    internal class CompanyPerson : Person
    {
        public int EmployeesNumber { get; protected set; }

        public CompanyPerson()
        {
        }
        public CompanyPerson(string name, double annualIncome, int employeesNumber) : base(name, annualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public sealed override double TaxCalc()
        {
            double tax = EmployeesNumber > 10 ? AnnualIncome * 0.14 : AnnualIncome * 0.16;
            return tax;

        }
    }
}
