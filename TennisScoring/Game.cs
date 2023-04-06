using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScoring
{
    internal class Game : Set
    {
        public List<string> server;
        public List<string> nonServer;
        public bool deuce;
        public bool gameEnd;

        public Game()
        {
            server = new List<string>() {"0"};
            nonServer = new List<string>() {"0"};
            deuce = false;
            gameEnd = false;
        }

        //Method that adds points to each player
        public void addServerPoints(bool win)
        {
            //If the server got the point
            if (win && !gameEnd)
            {
                switch (server.Last())
                {
                    case "0":
                        server.Add("15");
                        nonServer.Add(nonServer.Last());
                        break;
                    case "15":
                        server.Add("30");
                        nonServer.Add(nonServer.Last());
                        break;
                    case "30":
                        server.Add("40");
                        nonServer.Add(nonServer.Last());
                        isItDeuce();      //Checks it it's deuce
                        break;
                    case "40":
                        pointsAbove40(server, nonServer);
                        //Check if endGame is true
                        isGameEnd();
                        break;
                    case "AD":
                        pointsAbove40(server, nonServer);
                        //Check if endGame is true
                        isGameEnd();
                        break;
                    default:
                        break;
                }
            }
            else if (!win && !gameEnd)
            {
                switch (nonServer.Last())
                {
                    case "0":
                        nonServer.Add("15");
                        server.Add(server.Last());
                        break;
                    case "15":
                        nonServer.Add("30");
                        server.Add(server.Last());
                        break;
                    case "30":
                        nonServer.Add("40");
                        server.Add(server.Last());
                        isItDeuce();      //Checks it it's deuce
                        break;
                    case "40":
                        pointsAbove40(nonServer, server);
                        //Check if gameEnd is true
                        isGameEnd();
                        break;
                    case "AD":
                        pointsAbove40(nonServer, server);
                        //Check if gameEnd is true
                        isGameEnd();
                        break;
                    default:
                        break;
                }
            }
            else if (gameEnd)
            {
                Console.WriteLine("WE ALREADY HAVE A WINNER.");
            }
        }
        //Method that checks for deuce
        public bool isItDeuce() 
        {
            if (server.Last() == "40" && server.Last() == nonServer.Last())
            {
                deuce = true;
                Console.WriteLine("!!! DEUCE !!!");             //
            }
            else 
            {   
                deuce = false;
            }
            return deuce;
        }
        
        //Method that deals with scores after 40
        public void pointsAbove40(List<string> winPoint, List<string> lostPoint)
        {
            if (deuce)
            {
                //Winning player is ad
                winPoint.Add("AD");
                lostPoint.Add(lostPoint.Last());
                isItDeuce();

            }
            else if (winPoint.Last() == "AD")
            {
                //This means the list of winPoint won
                Console.WriteLine("!!!!We have a winner(1)!!!!");              //
                gameEnd = true;
            }
            else if (winPoint.Last() == "40" && lostPoint.Last() != "AD")
            {
                //This means the list of winPoint won
                Console.WriteLine("!!!!We have a winner(2)!!!!");              //
                gameEnd = true;
            }
            else if (winPoint.Last() == "40" && lostPoint.Last() == "AD")
            {
                winPoint.Add("40");
                lostPoint.Add("40");
                isItDeuce();
            }
        }
        //Method that adds the ended game to the set
        public bool isGameEnd()
        {
            if (gameEnd)
            {
                base.addGameToSet(server, nonServer, gameEnd);
                //resets the whole game class again for the next game
                
                return true;
            }
            else return false;
        }

        public void resetGame() 
        {
            server.Clear();
            nonServer.Clear();
            server.Add("0");
            nonServer.Add("0");
            deuce = gameEnd = false;
        }

        public void printAllPoints() 
        {
            Console.Write("Server Points: ");
            foreach (string s in server)
            {
                Console.Write(s + " | ");
            }
            Console.WriteLine("\nNumber of games played: " + server.Count);
            Console.Write("\nNon Server Points: ");
            foreach (string s in nonServer)
            {
                Console.Write(s + " | ");
            }
            Console.WriteLine("\nNumber of games played: " + nonServer.Count);
            Console.WriteLine("Is thegame over: " + gameEnd);


        }
    }
}
