using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassShootScore.Heirarchy;

namespace PassShootScore.Managers
{
    class PlayerManager : Manager
    {
        public PlayerManager()
        {

        }

        public Player CreatePlayer()
        {
            var p = new Player();
            WorldDB.AddPlayer(p);
            return p;
        }
    }
}
