using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassShootScore.Heirarchy
{
    class Player : WorldObject
    {
        public enum PlayerAttribute
        {
            Passing,
            Shooting,
            Technique,
        }

        public bool Male { get; private set; }

        public Team Team { get; set; }

        public Dictionary<PlayerAttribute, int> Attributes; 

        public Player()
        {
            Male = true;
            Name = TextGenSystem.ActiveTextGenSystem.GenerateNewPlayerName(Male);

            Attributes = new Dictionary<PlayerAttribute, int>();
            GenerateInitialAttributes();

            Debug.WriteLine(string.Format("New Player {0} created with ID {1}", Name, ID), "Player");
        }

        private void GenerateInitialAttributes()
        {
            // Note: random for now, but should be intelligent in the future
            var enums = (PlayerAttribute[]) Enum.GetValues(typeof (PlayerAttribute));
            foreach (var playerAttribute in enums)
            {
                Attributes[playerAttribute] = WorldDatabase.ActiveWorldDatabase.Rand.Next(0, 100);
            }
        }
    }
}
