using AbstractExercise1.Entities.Enums;

namespace AbstractExercise1.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; protected set; }
        public double Height { get; protected set; }
        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
