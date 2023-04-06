using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScoring
{
    internal class Singles : Game
    {
        public Player Player1
        { get; set; }
        public Player Player2
        { get; set; }
        //Constructor
        public Singles(Player player1, Player player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

    
    }
}
