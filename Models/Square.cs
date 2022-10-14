using static System.Console;

namespace Draw_Shapes.Models
{
    class Square : Shape
    {
        public Square(int sideLength, ConsoleColor color, int positionLeftOffset, int positionTopOffset)
            : base(color, positionLeftOffset, positionTopOffset)
        {
            SideLength = sideLength;
        }

        public int SideLength { get; private set; }

        public override void Draw()
        {
            ForegroundColor = Color;

            for (int row = 0; row < SideLength; row++)
            {
                for (int column = 0; column < SideLength; column++)
                {
                    SetCursorPosition(PositionLeftOffset + column, PositionTopOffset + row);

                    Write("X");
                }
            }
        }
    }
}
