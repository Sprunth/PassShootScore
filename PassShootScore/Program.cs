using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFML.System;

namespace PassShootScore
{
    class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
#endif

            var game = new PSSGame(new Vector2u(1024, 600));
            game.Initialize("Pass, Shoot, Score!");
            game.Run();
        }
    }
}
