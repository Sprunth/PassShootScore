using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassShootScore.Heirarchy
{
    class Team : WorldObject
    {
        private List<Player> players; 

        public Team(bool shouldGeneratePlayers = false)
        {
            Name = TextGenSystem.ActiveTextGenSystem.GenerateNewTeamName();
            Debug.WriteLine(string.Format("Creating new team: {0} with ID {1}", Name, ID), "Team");

            players = new List<Player>();

            if (shouldGeneratePlayers)
                GenerateTeamPlayers(5);
        }

        public void GenerateTeamPlayers(int count)
        {
            for (var i=0; i<count; i++)
                AddPlayer(new Player());
        }

        public void AddPlayer(Player p)
        {
            players.Add(p);
        }
    }
}
