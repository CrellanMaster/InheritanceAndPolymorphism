using AbstractExercise1.Entities.Enums;

namespace AbstractExercise1.Entities
{
    abstract class Shape
    {

        public Color Color { get; set; }
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
