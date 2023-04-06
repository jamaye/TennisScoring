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
        bool deuce;

        public Game()
        {
            server = new List<string>() {"0"};
            nonServer = new List<string>() {"0"};
            deuce = false;
        }

        //Method that adds points to each player
        public void addServerPoints(bool win)
        {
            //If the server got the point
            if (win)
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
                        break;
                    case "AD":
                        pointsAbove40(server, nonServer);
                        break;
                    default:
                        break;
                }
            }
            else 
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
                        break;
                    case "AD":
                        pointsAbove40(nonServer, server);
                        break;
                    default:
                        break;
                }
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
            }
            else if (winPoint.Last() == "40" && lostPoint.Last() != "AD")
            {
                //This means the list of winPoint won
                Console.WriteLine("!!!!We have a winner(2)!!!!");              //
                    
            }
            else if (winPoint.Last() == "40" && lostPoint.Last() == "AD")
            {
                winPoint.Add("40");
                lostPoint.Add("40");
                isItDeuce();
            }
        }
        public void printAllPoints() 
        {
            Console.Write("Server Points: ");
            foreach (string s in server)
            {
                Console.Write(s + " | ");
            }
            Console.Write("\nNon Server Points: ");
            foreach (string s in nonServer)
            {
                Console.Write(s + " | ");
            }

        }
    }
}
