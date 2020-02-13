using System;

namespace ConsoleGame
{
    class Game : SuperGame
    {
        public new static void UpdatePosition(string key1, out int x, out int y)
        {
            switch (key1)
            {
                case "LeftArrow":
                    x--;
                    break;
                case "RightArrow":
                    x++;
                    break;
                case "UpArrow":
                    y--;
                    break;
                case "DownArrow":
                    y++;
                    break;
                default:
                    break;
            }
        }
        public new static char UpdateCursor(string input)
        {
            switch (input)
            {
                case "LeftArrow":
                    '<';
                    break;
                case "UpArrow":
                    '^';
                    break;
                case "RightArrow":
                    '>';
                    break;
                case "DownArrow":
                    'v';
                    break;
                default:
                    break;

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
            if (xChar && xFruit == yChar && yFruit)
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