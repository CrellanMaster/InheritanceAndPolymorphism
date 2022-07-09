using AbstractExercise1.Entities.Enums;

namespace AbstractExercise1.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; protected set; }
        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
