using static System.Console;

namespace Draw_Shapes.Models
{
    class SmileyFace : Shape
    {
        public SmileyFace(ConsoleColor color, int positionLeftOffset, int positionTopOffset)
            : base(color, positionLeftOffset, positionTopOffset)
        {

        }

        public override void Draw()
        {
            Write(@"
                 #####
                ## # ##
                #######
                #     #
                 #####
             ");
        }
    }
}
