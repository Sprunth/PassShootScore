using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassShootScore.Heirarchy
{
    class League : WorldObject
    {
        private List<Team> teams; 

        public League()
        {
            Name = TextGenSystem.ActiveTextGenSystem.GenerateNewLeagueName();
            teams = new List<Team>();

            Debug.WriteLine(string.Format("New League created: {0}", Name), "League");
        }

        public void AddTeam(Team t)
        {
            teams.Add(t);
        }
    }
}
