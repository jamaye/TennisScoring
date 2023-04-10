using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TennisScoring
{
    class Player
    {
        //Properties
        public string Name
        { get; set; }
        public string Location
        { get; set; }
        public bool Service    
        { get; set; }
        //Constructor
        public Player(string name, string location)
        {
            Name = name;
            Location = location;
            Service = false;
        }

        public void printInfo() 
        {
            Console.WriteLine(Name /*+ " | " +Location + " | Service: " + Service*/);
        }
    }
}
