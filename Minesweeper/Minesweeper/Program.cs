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
        private const int cursorStartingPosX = 5;
        private const int cursorStartingPosY = 5;
        private const char playableAreaHorizontalSymbol = '-';
        private const char playableAreaVerticalSymbol = '|';
        private const char cursorSymbol = 'O';
        private const char bombSymbol = 'X';

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
            GenerateBombs();
            Console.SetCursorPosition(cursorStartingPosX, cursorStartingPosY);
        }

        public static void DrawPlayableArea()
        {
            for (int j = borderSize + 1; j < borderWidth; j++)
            {
                Console.SetCursorPosition(j, borderSize * 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);

                Console.SetCursorPosition(j, borderSize * 2 - 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);

                Console.SetCursorPosition(j, borderSize * 3);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);

                Console.SetCursorPosition(j, borderSize * 3 - 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);

                Console.SetCursorPosition(j, borderSize * 4);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);

                Console.SetCursorPosition(j, borderSize * 4 - 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);

                Console.SetCursorPosition(j, borderSize * 5);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);

                Console.SetCursorPosition(j, borderSize * 5 - 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);

                Console.SetCursorPosition(j, borderSize * 6);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);

                Console.SetCursorPosition(j, borderSize * 6 - 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);

                Console.SetCursorPosition(j, borderSize * 7);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);

                Console.SetCursorPosition(j, borderSize * 7 - 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);

                Console.SetCursorPosition(j, borderSize * 8);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);

                Console.SetCursorPosition(j, borderSize * 8 - 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);

                Console.SetCursorPosition(j, borderSize * 9 - 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaHorizontalSymbol);
            }


            for (int i = borderSize + 1; i < borderHeight; i++)
            {
                Console.SetCursorPosition(borderSize * 2, i );
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 2 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 3, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 3 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 4, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 4 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 5, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 5 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 6, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 6 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 7, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 7 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 8, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 8 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 9, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 9 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 10, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 10 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 11, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 11 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 12, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 12 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 13, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 13 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 14, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 14 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 15, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 15 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 16, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 16 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 17, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 17 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 18, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 18 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 19, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 19 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 20, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 20 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 21, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 21 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 22, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 22 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 23, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 23 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 24 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 24, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 25 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 25, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 26 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 26, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 27 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 27, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 28 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 28, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);

                Console.SetCursorPosition(borderSize * 29 - 2, i);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(playableAreaVerticalSymbol);
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

        public static void GenerateBombs()
        {
            Random bombGenerator = new Random();
            int bombCount = 0;
            int bombAmountMin = 10;
            int bombAmountMax = 50;

            for (int i = bombCount; i < bombAmountMax; i++) 
            {
                    var bombX= bombGenerator.Next(borderSize, borderWidth-1);
                    var bombY = bombGenerator.Next(borderSize, borderHeight-1);

                var isOnVerticalBorder = bombX % borderSize == 0;
                var isOnHorizontalBorder = bombY % borderSize == 0;

                if (!isOnVerticalBorder && !isOnHorizontalBorder)
                {
                    Console.SetCursorPosition(bombX, bombY);
                    Console.Write(bombSymbol);
                }
            }
        }
    }
}
