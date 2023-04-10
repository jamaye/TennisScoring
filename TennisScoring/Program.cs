namespace TennisScoring;
class Program
{
    static void Main(string[] args)
    {
        //Singles Game
        Player player1 = new Player("Daniil Meldev", "Russia");
        Player player2 = new Player("Stefan Kozlov", "USA");

        //Determine who's serving first game
        Console.WriteLine("A. Daniil Meldev, B. Stefan Kozlov");
        Console.Write("Who is serving (A/B): ");
        string input = Console.ReadLine();
        if (input == "A")
        {
            player1.Service = true;
        }
        else
        {
            player2.Service = true;

        }
        Singles usOpen = new Singles(player1, player2);
        printSinglePlayers(usOpen, player1,player2);

       
        bool serverPoint = false;        //is the argument inside the addServerPoints call; will change
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
                //Checks if the game ended
                if (usOpen.gameEnd == true)
                {
                    //This if statement will add the game class to the set class

                    //Checks who last earned the point
                    if (serverPoint)
                    {   
                        //Means the server for this game earned the game point
                        //We don't know who the server is; Verify who it is
                        if (player1.Service)
                        {
                            usOpen.addWinner(player1);
                            usOpen.gameWinner = player1;
                            usOpen.allGames[usOpen.allGames.Count - 1].gameWinner = player1;    //Set the gameWinner for the game
                        }
                        else if (player2.Service)
                        {
                            usOpen.addWinner(player2);
                            usOpen.gameWinner = player2;
                        usOpen.allGames[usOpen.allGames.Count - 1].gameWinner = player2;    //Set the gameWinner for the game


                    }
                }
                    //Means that the receiver for the game earned the game point
                    else
                    {
                        //Means player1 did not serve; so player1 got the point
                        if (!player1.Service)
                        {
                            usOpen.addWinner(player1);
                            usOpen.gameWinner = player1;
                        usOpen.allGames[usOpen.allGames.Count - 1].gameWinner = player1;    //Set the gameWinner for the game


                    }
                    //Means player2 did not serve; so player2 got the point
                    else if (!player2.Service)
                        {
                            usOpen.addWinner(player2);
                            usOpen.gameWinner = player2;
                            usOpen.allGames[usOpen.allGames.Count - 1].gameWinner = player2;    //Set the gameWinner for the game



                    }
                }
                usOpen.calculatePlayerGameCount();      //Calculates the game tally for each player
                usOpen.checkSetWinner();
                usOpen.resetGame();
                usOpen.changeServer();
                printSinglePlayers(usOpen, player1, player2);
               
                
            }
        }
            //Checks if the server won the game
            


        //

        //usOpen.printAllPoints();

    }

    static void printSinglePlayers(Singles s, Player p1, Player p2) 
    {
        Console.WriteLine("\n------------Single Players-------------");
        if (p1.Service == true)
        {
            Console.Write("Server Info: ");
            p1.printInfo();
            Console.WriteLine("          -----------------");

            Console.Write("Receiver Info: ");
            p2.printInfo();
        }
        else 
        {
            Console.Write("Server Info: ");
            p2.printInfo();
            Console.WriteLine("          -----------------");

            Console.Write("Receiver Info: ");
            p1.printInfo();
        }

       
        Console.WriteLine($"{s.Player1.Name}: {s.Player1gameCount}");
        Console.WriteLine($"{s.Player2.Name}: {s.Player2gameCount}");
        Console.WriteLine("------------END Players-------------");

    }
}
