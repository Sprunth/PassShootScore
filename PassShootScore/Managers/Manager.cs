using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassShootScore.Managers
{
    class Manager
    {
        public static PlayerManager ActivePlayerManager { get; private set; }
        public static TeamManager ActiveTeamManager { get; private set; }
        public static LeagueManager ActiveLeagueManager { get; private set; }

        public static void Initialize()
        {
            ActivePlayerManager = new PlayerManager();
            ActiveTeamManager = new TeamManager();
            ActiveLeagueManager = new LeagueManager();
        }

        protected readonly WorldDatabase WorldDB;

        protected Manager()
        {
            WorldDB = WorldDatabase.ActiveWorldDatabase;
        }
    }
}
