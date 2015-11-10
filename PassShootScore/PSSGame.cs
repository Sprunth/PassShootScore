using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassShootScore.Displays;
using PassShootScore.Heirarchy;
using PassShootScore.Managers;
using SFML.System;
using SprunthFramework;

namespace PassShootScore
{
    class PSSGame : SprunthGame
    {
        private WorldDatabase worldDB;
        private TextGenSystem textGenSystem;

        public PSSGame(Vector2u screenSize) : base(screenSize)
        {
            worldDB = new WorldDatabase();
        }

        protected override void PostInitialize()
        {
            textGenSystem = new TextGenSystem();

            Manager.Initialize();
            
            // test
            Manager.ActiveLeagueManager.CreateLeague(true);


            InitializeAllDisplays();
        }

        /// <summary>
        /// Create an instance of all displays so they are ready to be used
        /// </summary>
        private void InitializeAllDisplays()
        {
            var playerView = new PlayerView(ScreenSize);
            playerView.LoadPlayer(worldDB.AllLeagues.First().Teams[0].Players[0]);

            GM.ActiveDisplay = playerView;
        }
    }
}
