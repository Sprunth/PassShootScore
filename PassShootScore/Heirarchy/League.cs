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
        public List<Team> Teams { get; private set; }

        public League()
        {
            Name = TextGenSystem.ActiveTextGenSystem.GenerateNewLeagueName();
            Teams = new List<Team>();

            Debug.WriteLine(string.Format("New League created: {0}", Name), "League");
        }

        public void AddTeam(Team t)
        {
            Teams.Add(t);
        }
    }
}
