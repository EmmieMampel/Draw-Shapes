using static System.Console;

namespace Draw_Shapes.Models
{
    class Circle : Shape
    {
        public Circle(CircleSize size, ConsoleColor color, int positionLeftOffset, int positionTopOffset)
            : base(color, positionLeftOffset, positionTopOffset)
        {
            Size = size;
        }

        public CircleSize Size { get; private set; }

        public override void Draw()
        {
            ForegroundColor = Color;

            SetCursorPosition(PositionLeftOffset, PositionTopOffset);

            switch (Size)
            {
                case CircleSize.Small:

                    Write(@"
                            ##
                           ####
                           ####
                            ##
                        ");

                    break;

                case CircleSize.Large:

                    Write(@"
                            #####
                           #######
                           #######
                           #######
                            #####
                        ");

                    break;
            }
        }
    }
}
