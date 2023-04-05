using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScoring
{
    internal class Team
    {
        public Player Server
        { get; set; }
       public Player NotServer
        { get; set; }

        //Constructor
        public Team(Player server, Player notServer)
        {
            Server = server;
            NotServer = notServer;
        }  
    }
}
