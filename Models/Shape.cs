
namespace Draw_Shapes.Models
{
    abstract class Shape
    {
        public Shape(ConsoleColor color, int positionLeftOffset, int positionTopOffset)
        {
            Color = color;
            PositionLeftOffset = positionLeftOffset;
            PositionTopOffset = positionTopOffset;
        }

        public ConsoleColor Color { get; private set; }
        public int PositionLeftOffset { get; private set; }
        public int PositionTopOffset { get; private set; }

        public abstract void Draw();
    }
}
