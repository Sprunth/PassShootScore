using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassShootScore.Heirarchy;

namespace PassShootScore.Managers
{
    class LeagueManager : Manager
    {
        private readonly TeamManager teamMgr;

        public LeagueManager()
        {
            teamMgr = ActiveTeamManager;
        }

        public League CreateLeague(bool shouldGenerateTeams = false)
        {
            var l = new League();
            if (shouldGenerateTeams)
            {
                for (var i = 0; i < 5; i++)
                {
                    l.AddTeam(teamMgr.CreateTeam(true));
                }
            }
            WorldDB.AddLeague(l);
            return l;
        }
    }
}
