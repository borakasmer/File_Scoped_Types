using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Scoped_Types
{
    file class Games
    {
        public (int, int) MoveRight(int x, int y)
        {
            return (x + 2, y);
        }
        public (int, int) MoveDown(int x, int y)
        {
            return (x, y + 2);
        }
        public (int, int) MoveLeftt(int x, int y)
        {
            return (x - 2 < 0 ? x : x - 2, y);
        }
        public (int, int) MoveUp(int x, int y)
        {
            return (x, y - 2 < 0 ? y : y - 2);
        }
    }

    class Command2
    {
        public (int x, int y) MoveCommand(int x, int y, CommandType type)
        {
            Games games = new();
            return type switch
            {
                CommandType.MoveRight => games.MoveRight(x, y),
                CommandType.MoveDown => games.MoveDown(x, y),
                CommandType.MoveLeft => games.MoveLeftt(x, y),
                CommandType.MoveUp => games.MoveUp(x, y),
                _ => (x, y)
            };
        }
    }
}
