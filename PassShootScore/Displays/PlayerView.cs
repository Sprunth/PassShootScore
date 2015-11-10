using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gwen.Control;
using PassShootScore.Heirarchy;
using SFML.Graphics;
using SFML.System;
using SprunthFramework;

namespace PassShootScore.Displays
{
    class PlayerView : Display
    {
        private Player currentlyLoadedPlayer;

        private GroupBox playerBox;
        private Label playerNameLabel;

        public PlayerView(Vector2u displaySize) : base(displaySize)
        {
            BackgroundColor = new Color(40,40,40);

            playerBox = new GroupBox(GuiCanvas);
            playerBox.SetBounds(20, 20, displaySize.X - 40, displaySize.Y - 40);

            playerNameLabel = new GroupBox(playerBox);
            playerNameLabel.SetBounds(20, 20, 256, 32);
        }

        public void LoadPlayer(Player p)
        {
            currentlyLoadedPlayer = p;

            playerNameLabel.Text = p.Name;
        }
    }
}
