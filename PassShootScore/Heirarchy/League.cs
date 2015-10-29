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

        public League(bool generateTeams = false)
        {
            Name = TextGenSystem.ActiveTextGenSystem.GenerateNewLeagueName();
            teams = new List<Team>();

            Debug.WriteLine(string.Format("New League created: {0}", Name), "League");

            if (generateTeams)
                GenerateTeams(6);
        }

        private void GenerateTeams(int count)
        {
            for (var i = 0; i < count; i++)
                teams.Add(new Team(true));
        }
    }
}
