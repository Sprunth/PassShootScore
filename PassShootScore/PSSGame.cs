﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassShootScore.Heirarchy;
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

        public override void PostInitialize()
        {
            textGenSystem = new TextGenSystem();

            // test
            var league1 = new League(true);
        }
    }
}