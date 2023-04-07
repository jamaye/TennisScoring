namespace TennisScoring;
class Program
{
    static void Main(string[] args)
    {
        //Singles Game
        Player player1 = new Player("Daniil Meldev", "Russia");
        Player player2 = new Player("Stefan Kozlov", "USA");
        
        //Determine who's serving first game
        player1.Service = true;         //Setting that they're serving
        Console.WriteLine("------------------------------");
        Console.Write ("Player 1: "); 
        player1.printInfo();
        Console.Write("Player 2: ");
        player2.printInfo();
        Console.WriteLine("------------------------------");

        Singles usOpen = new Singles(player1, player2);
        //Simulation of the a game; Player1 aced the whole game


        bool serverPoint = true;        //is the argument inside the addServerPoints call; will change
        string answer = "";
        
            while (!usOpen.gameEnd)
            {
                Console.Write("Did server earn the point: ");
                answer = Console.ReadLine();
                if (answer.ToUpper() == "YES")
                {
                    serverPoint = true;
                }
                else if (answer.ToUpper() == "NO")
                {
                    serverPoint = false;
                }
                usOpen.addServerPoints(serverPoint);       //Winner!; exit loop
                //Checks if the game ended, if so, reset the whole game
                //We have to add more info abt the set stuff; for now it will run infinitely
                if (usOpen.gameEnd == true)
                {
                    usOpen.resetGame();
                }
            }
            usOpen.resetGame();
            //Checks if the server won the game
            if (serverPoint)
            {
                //Means this is the server
                if (player1.Service)
                {
                    usOpen.addWinner(player1);
                }
                //Means that this is the server
                else if (player2.Service)
                {
                    usOpen.addWinner(player2);
                }
            }
            //Means that the receiver won the game
            else
            {
                //Means this is the server
                if (player1.Service)
                {
                    usOpen.addWinner(player2);
                }
                //Means that this is the server
                else if (player2.Service)
                {
                    usOpen.addWinner(player1);

                }
            }
        


        //

        //usOpen.printAllPoints();











    }
}
