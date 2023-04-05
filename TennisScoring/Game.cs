using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScoring
{
    internal class Game : Set
    {
        public List<int> server;
        public List<int> nonServer;

        public Game()
        {
            server = new List<int>() {0};
            nonServer = new List<int>() {0};
        }

        public void addServerPoints(bool win)
        {
            int temp = server.Last();
            //If the server got the point and it's not the first point of the game
            if (win)
            {
                switch (server.Last())
                {
                    case 0:
                        server.Add(15);
                        break;
                    case 15:
                        server.Add(30);
                        break;
                    case 30:
                        server.Add(40);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
