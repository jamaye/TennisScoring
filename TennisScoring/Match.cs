using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScoring
{
    internal class Match
    {
        public List<Set> allSets;
        public List<Player> setWinners;

        public Match()
        {
            allSets = new List<Set>();
            setWinners = new List<Player>();
        }
    }
}
