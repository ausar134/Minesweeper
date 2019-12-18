using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleHelper.Common;

namespace Minesweeper
{
    class Program
    {
        private const int maxWidth = 119;
        private const int maxHeight = 40;
        private const int borderSize = 4;
        private const int borderWidth = maxWidth - borderSize;
        private const int borderHeight = maxHeight - borderSize;
        private const int cursorStartingPosX = 6;
        private const int cursorStartingPosY = 6;
        private const char playableAreaHorizontalSymbol = '─';
        private const char playableIntersectionSymbol = '┼';
        private const char playableLeftCross = '├';
        private const char playableRightCross = '┤';
        private const char playableTopCross = '┬';
        private const char playableBottomCross = '┴';
		private const char playableAreaVerticalSymbol = '│';
        private const char cursorSymbol = 'O';
        private const char bombSymbol = 'X';

        private const int MaxBombs = 50;

        static void Main(string[] args)
        {
            OnInit();
            CursorMovement();
            Thread.Sleep(10000);
        }

        public static void OnInit()
        {
            ConsoleHelpers.DrawBorder(borderSize);
            DrawPlayableArea();
            GenerateBombs(MaxBombs);
            Console.SetCursorPosition(cursorStartingPosX, cursorStartingPosY);
        }

        public static void DrawPlayableArea()
        {
	        for (var i = borderSize + 1; i < borderHeight; i++)
	        {
		        for (var j = borderSize + 1; j < borderWidth; j++)
		        {
			        Console.SetCursorPosition(j, i);
			        Console.ForegroundColor = ConsoleColor.Red;

					if (i % 2 == 0 && j % 2 == 0)
			        {
				        continue;
			        }

			        if (i % 2 != 0)
			        {
				        Console.Write(playableAreaHorizontalSymbol);
					}

			        if (j % 2 != 0)
			        {
				       Console.Write(playableAreaVerticalSymbol);
					}
		        }
	        }
        }

        public static void CursorMovement()
        {
            ConsoleKeyInfo key;

            int cursorPosX = cursorStartingPosX;
            int cursorPosY = cursorStartingPosY;

            int movementX = 0;
            int movementY = 0;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    Console.CursorVisible = false;

                    //Has to be true to stop printing
                    key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow when (cursorPosX > borderSize + 1):
                            Console.SetCursorPosition(cursorPosX, cursorPosY);
                            Console.Write(" "); 
                            movementX = -2;
                            cursorPosX += movementX;
                            break;
                        case ConsoleKey.RightArrow when (cursorPosX < borderWidth - 2):
                            Console.SetCursorPosition(cursorPosX, cursorPosY);
                            Console.Write(" ");
                            movementX = +2;
                            cursorPosX += movementX;
                            break;
                        case ConsoleKey.UpArrow when (cursorPosY > borderSize + 1):
                            Console.SetCursorPosition(cursorPosX, cursorPosY);
                            Console.Write(" ");
                            movementY = -2;
                            cursorPosY += movementY;
                            break;
                        case ConsoleKey.DownArrow when (cursorPosY < borderHeight - 1):
                            Console.SetCursorPosition(cursorPosX, cursorPosY);
                            Console.Write(" ");
                            movementY = +2;
                            cursorPosY += movementY;
                            break;
                        case ConsoleKey.Spacebar:
                            Console.SetCursorPosition(cursorPosX, cursorPosY);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(cursorSymbol);
                            break;
                        default:
                            break;
                    }
                        Console.SetCursorPosition(cursorPosX, cursorPosY);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(cursorSymbol);
                }
            }
        }

        public static void GenerateBombs(int bombCount)
        {
            var bombGenerator = new Random();
            const int currentBombs = 0;

            for (var i = currentBombs; i < bombCount; i++) 
            {
                    var bombX= bombGenerator.Next(borderSize, borderWidth-1);
                    var bombY = bombGenerator.Next(borderSize, borderHeight-1);

                var isOnVerticalBorder = bombX % 2 == 1;
                var isOnHorizontalBorder = bombY % 2 == 1;

                if (!isOnVerticalBorder && !isOnHorizontalBorder)
                {
                    Console.SetCursorPosition(bombX, bombY);
                    Console.Write(bombSymbol);
                }
            }
        }
    }
}
