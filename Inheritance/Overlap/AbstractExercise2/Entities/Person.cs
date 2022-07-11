using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExercise2.Entities
{
    abstract class Person
    {
        public string Name { get; protected set; }
        public double AnnualIncome { get; protected set; }

        public Person()
        {

        }
        protected Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double TaxCalc();
    }
}
