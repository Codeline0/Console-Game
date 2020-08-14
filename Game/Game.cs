using System;
using System.Dynamic;
using System.Threading;

namespace ConsoleGame
{
  class Game : SuperGame
  {
    //method used to update the player's position dependant on the key pressed.
    public static new void UpdatePosition(string keyPressed, out int X, out int Y)
        {

            X = 0;
            Y = 0;

            //changes the coordinates of the player based on the key pressed.
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

    //updates the way the player is facing. 
    public static new char UpdateCursor(string keyInput)
        {

            char theChar = 'c';

            //cardinal points. 
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

            //returns the char that shows the way the player moved.
            return theChar;
        }

        //keeps the player inside the assigned space for the game.
        public static new int KeepInBounds(int coord, int maxValue)
        {
            //if the x or y values exceeds the boundaries value, it sets the position to the origin.
            if (coord > maxValue)
            {
                return 0;
            }
            //if the x or y values are less than zero, it sets the position to the boundary limit.
            else if (coord < 0)
            {
                return maxValue;
            }
            //the player isn't affected whatsoever.
            else
            {
                return coord;
            }
            

        }

        //sets the number of '@' collected by the player.
        public static new bool DidScore(int charX, int charY, int fruitX, int fruitY)
        {
            //if the position of the character and the fruit are the same for (x, y), returns true.
            if (charX == fruitX && charY == fruitY)
            {
                return true;
            }   
            //returns false if the conditions are not met.
            else
            {
                return false;
            }
        }


  }
}