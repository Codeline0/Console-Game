using System;
using System.Dynamic;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    public static new void UpdatePosition(string keyPressed, out int X, out int Y)
        {

            X = 0;
            Y = 0;

            switch (keyPressed) {
                case "LeftArrow":
                    X -= 1;
                    break;
                case "RightArrow":
                    X += 1;
                    break;
                case "UpArrow":
                    Y -= 1;
                    break;
                case "DownArrow":
                    Y += 1;
                    break;
                case "Spacebar":
                    break;
            }
        }

    public static new char UpdateCursor(string keyInput)
        {

            char theChar = 'c';

            switch (keyInput){
                case "LeftArrow":
                    theChar = '<';
                    break;
                case "RightArrow":
                    theChar = '>';
                    break;
                case "UpArrow":
                    theChar = '^';
                    break;
                case "DownArrow":
                    theChar = 'v';
                    break;
                case "Spacebar":
                    break;
            }

            return theChar;
        }
        public static new int KeepInBounds(int coord, int maxValue)
        {

            if (coord > maxValue)
            {
                return 0;
            }
            else if (coord < 0)
            {
                return maxValue;
            }
            else
            {
                return coord;
            }
            

        }
        public static new bool DidScore(int charX, int charY, int fruitX, int fruitY)
        {
            if (charX == fruitX && charY == fruitY)
            {
                return true;
            }   
            else
            {
                return false;
            }
        }


  }
}