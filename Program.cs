using Draw_Shapes.Models;
using System.Drawing;
using static System.Console;

namespace Draw_Shapes
{
    class Program
    {
        static List<Shape> shapeList = new List<Shape>();

        static void Main(string[] args)
        {
            bool applicationRunning = true;

            CursorVisible = false;

            do
            {
                WriteLine("(1) Ny kvadrat");
                WriteLine("(2) Ny cirkel");
                WriteLine("(3) Ny smiley");
                WriteLine("(4) Rita på skärm");
                WriteLine("(5) Avsluta");

                ConsoleKeyInfo userInput;

                bool invalidSelection = true;

                do
                {
                    userInput = ReadKey(true);

                    invalidSelection = !(
                        userInput.Key == ConsoleKey.D1 ||
                        userInput.Key == ConsoleKey.NumPad1 ||
                        userInput.Key == ConsoleKey.D2 ||
                        userInput.Key == ConsoleKey.NumPad2 ||
                        userInput.Key == ConsoleKey.D3 ||
                        userInput.Key == ConsoleKey.NumPad3 ||
                        userInput.Key == ConsoleKey.D4 ||
                        userInput.Key == ConsoleKey.NumPad4 ||
                        userInput.Key == ConsoleKey.D5 ||
                        userInput.Key == ConsoleKey.NumPad5
                        );

                } while (invalidSelection);

                Clear();
                CursorVisible = true;

                switch (userInput.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        NewSquare();

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        NewCircle();

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        NewSmiley();

                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        Draw();

                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:

                        applicationRunning = false;

                        break;
                }

                Clear();

            } while (applicationRunning);
        }

        private static void NewSmiley()
        {
            Write("Färg: ");

            ConsoleColor color = Enum.Parse<ConsoleColor>(ReadLine(), true);

            Write("Position från vänster: ");

            int postionLeftOffset = int.Parse(ReadLine());

            Write("Position från toppen: ");

            int positionTopOffset = int.Parse(ReadLine());

            var smiley = new SmileyFace(color, postionLeftOffset, positionTopOffset);

            shapeList.Add(smiley);

            Clear();

            WriteLine("Smiley skapad");

            Thread.Sleep(2000);
        }

        private static void NewCircle()
        {
            // Ny cirkel
            Write("Storlek (Small, Large): ");

            CircleSize size = Enum.Parse<CircleSize>(ReadLine(), true);

            Write("Färg: ");

            ConsoleColor color = Enum.Parse<ConsoleColor>(ReadLine(), true);

            Write("Position från vänster: ");

            int postionLeftOffset = int.Parse(ReadLine());

            Write("Position från toppen: ");

            int positionTopOffset = int.Parse(ReadLine());

            var circle = new Circle(size, color, postionLeftOffset, positionTopOffset);

            shapeList.Add(circle);

            Clear();

            WriteLine("Cirkel skapad");

            Thread.Sleep(2000);
        }

        private static void NewSquare()
        {
            Write("Sidlängd: ");

            int sideLength = int.Parse(ReadLine());

            Write("Färg: ");

            ConsoleColor color = Enum.Parse<ConsoleColor>(ReadLine(), true);

            Write("Position från vänster: ");

            int leftPostionOffset = int.Parse(ReadLine());

            Write("Position från toppen: ");

            int topPositionOffset = int.Parse(ReadLine());

            var square = new Square(
                sideLength,
                color,
                leftPostionOffset,
                topPositionOffset
                );

            shapeList.Add(square);

            Clear();

            WriteLine("Kvadrat skapad");

            Thread.Sleep(2000);
        }

        static void Draw()
        {
            shapeList.ForEach(shape => shape.Draw());

            ForegroundColor = ConsoleColor.White;

            ReadKey(true);
        }
    }
}