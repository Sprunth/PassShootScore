using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassShootScore.Heirarchy;

namespace PassShootScore
{
    class WorldDatabase
    {
        public static WorldDatabase ActiveWorldDatabase { get; private set; }

        public readonly Random Rand;

        private Dictionary<Guid, Player> allPlayers;
        private Dictionary<Guid, Team> allTeams;
        private Dictionary<Guid, League> allLeagues;
        public IEnumerable<League> AllLeagues { get { return allLeagues.Values; } }  

        public WorldDatabase()
        {
            Rand = new Random();

            allPlayers = new Dictionary<Guid, Player>();
            allTeams = new Dictionary<Guid, Team>();
            allLeagues = new Dictionary<Guid, League>();

            ActiveWorldDatabase = this;
        }

        public void AddPlayer(Player p)
        {
            allPlayers.Add(p.ID, p);
        }

        public void AddTeam(Team t)
        {
            allTeams.Add(t.ID, t);
        }

        public void AddLeague(League l)
        {
            allLeagues.Add(l.ID, l);
        }

        public Player GetPlayerByID(Guid id)
        {
            return allPlayers[id];
        }

        public Team GetTeamByID(Guid id)
        {
            return allTeams[id];
        }

        public League GetLeagueByID(Guid id)
        {
            return allLeagues[id];
        }
    }
}
