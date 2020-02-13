using System;

namespace ConsoleGame
{
    class Game : SuperGame
    {
        public new static void UpdatePosition(string key, out int xChange, out int yChange)
        {
            switch (key)
            {
                case "LeftArrow":
                    xChange = -1;
                    yChange = 0;
                    break;
                case "RightArrow":
                    xChange = 1;
                    yChange = 0;
                    break;
                case "UpArrow":
                    yChange = -1;
                    xChange = 0;
                    break;
                case "DownArrow":
                    yChange = 1;
                    xChange = 0;
                    break;
                default:
                    xChange = 0;
                    yChange = 0;
                    break;
            }
        }
        public new static char UpdateCursor(string input)
        {
            switch (input)
            {
                case "LeftArrow":
                    return '<';
                case "UpArrow":
                    return '^';
                case "RightArrow":
                    return '>';
                case "DownArrow":
                    return 'v';
                default:
                    return '<';
            }
        }
        public new static int KeepInBounds(int cood, int max)
        {
            if (cood < 0)
            {
                return 0;
            }
            else if (cood >= max)
            {
                return max - 1;
            }
            else
            {
                return cood;
            }
        }
        public new static bool DidScore(int xChar, int yChar, int xFruit, int yFruit)
        {
            if (xChar == xFruit && yChar == yFruit)
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