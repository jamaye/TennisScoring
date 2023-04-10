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

        //Method that changes who the server is
        public void changeServer()
        {
            if (Player1.Service)
            {
                Player1.Service = false;
                Player2.Service = true;
            }
            else 
            {
                Player1.Service = true;
                Player2.Service = false;
            }

        }

        //Method that counts the players game points for current set
        public void calculatePlayerGameCount() 
        {
            Player1gameCount = countGamePoints(Player1);
            Player2gameCount = countGamePoints(Player2);
        }
        


    }
}
