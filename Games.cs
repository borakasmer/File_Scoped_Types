namespace File_Scoped_Types
{
    class Games
    {
        public (int, int) MoveRight(int x, int y)
        {
            return (x + 1, y);
        }
        public (int, int) MoveDown(int x, int y)
        {
            return (x, y + 1);
        }
        public (int, int) MoveLeftt(int x, int y)
        {
            return (x - 1 < 0 ? x : x - 1, y);
        }
        public (int, int) MoveUp(int x, int y)
        {
            return (x, y - 1 < 0 ? y : y - 1);
        }
    }

    class Command
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
