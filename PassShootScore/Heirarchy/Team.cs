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
        public List<Player> Players { get; private set; }

        public Team()
        {
            Name = TextGenSystem.ActiveTextGenSystem.GenerateNewTeamName();
            Debug.WriteLine(string.Format("Creating new team: {0} with ID {1}", Name, ID), "Team");

            Players = new List<Player>();
        }

        public void AddPlayer(Player p)
        {
            Players.Add(p);
        }

    }
}
