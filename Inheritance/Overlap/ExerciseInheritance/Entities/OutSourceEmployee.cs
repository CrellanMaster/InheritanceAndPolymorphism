using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseInheritance.Entities
{
    internal class OutSourceEmployee : Employee
    {
        public double AdditionalCharge { get; protected set; }

        public OutSourceEmployee()
        {
        }

        public OutSourceEmployee(string name, int hours, double valuePerHours, double additionalCharge) : base(name, hours, valuePerHours)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {
            return base.Payment() + (AdditionalCharge * 1.10);
        }
    }
}
