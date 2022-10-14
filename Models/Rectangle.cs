

namespace Draw_Shapes.Models
{
    class Rectangle : Shape
    {
        public Rectangle(ConsoleColor color, int width, int length, int positionLeftOffset, int positionTopOffset)
            : base(color, positionLeftOffset, positionTopOffset)
        {
            Width = width;
            Length = length;
        }

        public int Width { get; private set; }
        public int Length { get; private set; }

        public override void Draw()
        {

        }
    }
}
