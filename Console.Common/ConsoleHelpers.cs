namespace ConsoleHelper.Common
{
 using System;

    public static class ConsoleHelpers
    {
        public static void DrawBorder(int borderSize, char horizontal = '═',
            char vertical = '║', char topLeftCorner = '╔', char topRightCorner = '╗',
            char bottomLeftCorner = '╚', char bottomRightCorner = '╝')

        {
            var height = 40;
            var width = 119;

            Console.SetWindowSize(width, height);

            int borderWidth = width - borderSize;
            int borderHeight = height - borderSize;

            for (int i = borderSize; i <= borderHeight; i++)
            {
                Console.SetCursorPosition(borderSize, i);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(vertical);

                Console.SetCursorPosition(borderWidth, i);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(vertical);
            }

            for (int j = borderSize; j <= borderWidth; j++)
            {
                Console.SetCursorPosition(j, borderSize);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(horizontal);

                Console.SetCursorPosition(j, borderHeight);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(horizontal);
            }

            Console.SetCursorPosition(borderSize, borderSize);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(topLeftCorner);

            Console.SetCursorPosition(borderWidth, borderSize);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(topRightCorner);

            Console.SetCursorPosition(borderSize, borderHeight);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(bottomLeftCorner);

            Console.SetCursorPosition(borderWidth, borderHeight);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(bottomRightCorner);
        }
    }
}
