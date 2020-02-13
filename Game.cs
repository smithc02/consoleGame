using System;

namespace ConsoleGame
{
    class Game : SuperGame
    {
        public new static UpdatePosition(string key1, out int x, out int y)
        {
            switch (key1)
            {
                case "LeftArrow":
                    x--;
                case "RightArrow":
                    x++;
                case "UpArrow":
                    y--;
                case "DownArrow":
                    y++;
            }


        }
    }
}