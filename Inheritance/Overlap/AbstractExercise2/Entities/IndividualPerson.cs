using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercise2.Entities
{
    internal class IndividualPerson : Person
    {
        public double HealthSpending { get; protected set; }

        public IndividualPerson()
        {
        }

        public IndividualPerson(string name, double annualIncome, double healthSpending) : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public sealed override double TaxCalc()
        {
            double tax = AnnualIncome < 20000.0 ? AnnualIncome * 0.15 : AnnualIncome * 0.25;
            tax -= HealthSpending > 0.0 ? HealthSpending * 0.5 : 0;
            return tax;
        }
    }
}

