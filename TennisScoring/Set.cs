using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScoring
{
    internal class Set : Match
    {
        public List<Game> allGames;
        public List<Player> gameWinner;

        //Constructor
        public Set() 
        {
            allGames = new List<Game>();
            gameWinner = new List<Player>();
        }
    }
}
