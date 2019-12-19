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
		private const char playableAreaVerticalSymbol = '│';
		private const char cursorSymbol = 'O';
		private const char bombSymbol = 'X';

		private static Point[] bombPos = new Point[MaxBombs];
        private static int[,] gameCells = new int[borderHeight, borderWidth]; 
		private const int MaxBombs = 50;

		static void Main(string[] args)
		{
            Console.CursorVisible = false;
            OnInit();
			CursorMovement();
		}

		public static void OnInit()
		{
			ConsoleHelpers.DrawBorder(borderSize);
			DrawPlayableArea();
			GenerateBombs(bombPos, MaxBombs);
            CheckCellElement(gameCells);
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
						case ConsoleKey.LeftArrow when (cursorPosX > borderSize + 2):
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
						case ConsoleKey.UpArrow when (cursorPosY > borderSize + 2):
							Console.SetCursorPosition(cursorPosX, cursorPosY);
							Console.Write(" ");
							movementY = -2;
							cursorPosY += movementY;
							break;
						case ConsoleKey.DownArrow when (cursorPosY < borderHeight - 2):
							Console.SetCursorPosition(cursorPosX, cursorPosY);
							Console.Write(" ");
							movementY = +2;
							cursorPosY += movementY;
							break;
						case ConsoleKey.Spacebar:
                            CheckCellElement(gameCells);
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

		public static void GenerateBombs(Point[] bombPos, int bombCount)
		{
			var bombGenerator = new Random();
            int bombMin = 0;

            while (bombMin < bombCount)
            {
                for (var i = bombMin; i < bombCount; i++)
                {
                    var bombX = bombGenerator.Next(borderSize + 1, borderWidth - 1);
                    var bombY = bombGenerator.Next(borderSize + 1, borderHeight - 1);

                    var isOnVerticalBorder = bombX % 2 == 1;
                    var isOnHorizontalBorder = bombY % 2 == 1;

                    if (!isOnVerticalBorder && !isOnHorizontalBorder)
                    {
                        Console.SetCursorPosition(bombX, bombY);
                        bombPos[i].X = bombX;
                        bombPos[i].Y = bombY;
                        bombMin += 1;
                    }
                }
            }
        }

        public static void CheckCellElement(int[,] gameCells)
        {
            for (int i = 0; i < borderHeight; i++)
            {
                for (int j = 0; j < borderWidth; j++)
                {
                    if (gameCells[i, j] == bombSymbol)
                    {
                        
                    }
                }
            }
        }
	}
}
