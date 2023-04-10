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
        public List<Object> gameWinners; //we might not need this
        public bool setEnd;
        public int Player1gameCount
        { get; set; }
        public int Player2gameCount
        { get; set; }
        //Constructor
        public Set()
        {
            allGames = new List<Game>();
            gameWinners = new List<Object>();
            setEnd = false;
        }

        //Method that adds a game to allGames list
        public void addGameToSet(List<string> s, List<string> ns, bool e)
        {
            //Checks if there's a winner now
            Game game = new Game();
            game.server = s;
            game.nonServer = ns;
            game.gameEnd = e;
            allGames.Add(game);

        }

        //Method that adds the winner to the game winner list
        //Convert player/team to object
        public void addWinner(Object winner)
        {
            gameWinners.Add(winner);
        }

        //Method that counts the game scores for current
        public int countGamePoints(Player p)
        {
            Object temp = p;
            int i = 0;
            foreach (Object o in gameWinners)
            {
                if (o == p)
                {
                    i++;
                }
            }
            return i;
        }

        //Method that checks if there is a set winner
        public void checkSetWinner()
        {
            //If there is, add the set to the match class
            //reset the set and start over
            int totalGames = allGames.Count;
            if (totalGames >= 6)
            {
                if (Player1gameCount >= 6 && Player2gameCount <= (Player1gameCount - 2))
                {
                    Console.WriteLine("Set winner: " + allGames[allGames.Count-1].gameWinner.Name);
                    //Do more stuff
                }else if (Player2gameCount >= 6 && Player1gameCount <= (Player2gameCount - 2))
                {
                    Console.WriteLine("Set winner: " + allGames[allGames.Count - 1].gameWinner.Name);
                    //Do more stuff

                }
            }

        }

       


    }
}
