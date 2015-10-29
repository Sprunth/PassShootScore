using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rant;
using Rant.Vocabulary;

namespace PassShootScore
{
    /// <summary>
    /// A singleton class to handle all the text generation
    /// Powered using RANT
    /// </summary>
    public class TextGenSystem
    {
        public static TextGenSystem ActiveTextGenSystem { get; private set; }

        private readonly RantEngine rant;

        private RantPattern nameGenMale, nameGenFemale;
        private RantPattern teamName, leagueName;

        public TextGenSystem()
        {
            Debug.WriteLine("Initializing Text Generation Engine");

            rant = new RantEngine();
            rant.LoadPackage("Rantionary");
            
            SetupRantPatterns();

            ActiveTextGenSystem = this;

            Debug.WriteLine("Done Initializing Text Generation Engine");
        }

        private void SetupRantPatterns()
        {
            nameGenMale = RantPattern.FromString("<name-male> <surname>");
            nameGenFemale = RantPattern.FromString("<name-female> <surname>");

            teamName = RantPattern.FromString("[case:title]<noun> {(0.3)FC|(0.3)United|}");
            leagueName = RantPattern.FromString("[case:title]{The <noun> League}");
        }


        public string GenerateNewPlayerName(bool male)
        {
            return male ? rant.Do(nameGenMale).ToString() : rant.Do(nameGenFemale).ToString();
        }

        public string GenerateNewTeamName()
        {
            return rant.Do(teamName).ToString().Trim();
        }

        public string GenerateNewLeagueName()
        {
            return rant.Do(leagueName).ToString();
        }
    }
}
