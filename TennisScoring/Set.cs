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
        public List<Object> gameWinner;
        public bool setEnd;
        //Constructor
        public Set() 
        {
            allGames = new List<Game>();
            gameWinner = new List<Object>();
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
            Console.WriteLine("---- This recent game added ----");  //
            game.printAllPoints();      //
            Console.WriteLine("[Size of allGames list: " + allGames.Count +"]");  //

            Console.WriteLine("---- END ----");  //

        }

        //Method that adds the winner to the game winner list
        //Convert player/team to object
        public void addWinner(Object winner) 
        {
            gameWinner.Add(winner);
            Console.WriteLine("Winner of the Game: " + ((Player)winner).Name);      //
            Console.WriteLine("[Size of gameWinner list: " + gameWinner.Count +"]");  //


        }
    }
}
