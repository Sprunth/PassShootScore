using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassShootScore.Heirarchy;

namespace PassShootScore.Managers
{
    class TeamManager : Manager
    {
        private readonly PlayerManager playerMgr;

        public TeamManager()
        {
            playerMgr = ActivePlayerManager;
        }

        public Team CreateTeam(bool shouldGeneratePlayers = false)
        {
            var t = new Team();
            if (shouldGeneratePlayers)
            for (var i = 0; i < 5; i++)
            {
                t.AddPlayer(playerMgr.CreatePlayer());
            }
            WorldDB.AddTeam(t);
            return t;
        }
    }
}
