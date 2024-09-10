using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Scoped_Types
{
    class Rules: IGameRules
    {
        public int Top { get; set; }
        public int Left { get; set; }

        public (int, int) Move()
        {
            return (Top, Left);
        }

}

    file interface IGameRules
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public (int, int) Move();
    }
}
