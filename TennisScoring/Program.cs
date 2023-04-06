namespace TennisScoring;
class Program
{
    static void Main(string[] args)
    {
        //Singles Game
        Player player1 = new Player("Daniil Meldev", "Russia");
        Player player2 = new Player("Stefan Kozlov", "USA");
        Console.Write ("Player 1: "); 
        player1.printInfo();
        Console.Write("Player 2: ");
        player2.printInfo();

        Singles usOpen = new Singles(player1, player2);
        //Simulation of the a game; Player1 aced the whole game
        usOpen.addServerPoints(true);
        usOpen.addServerPoints(true);
        usOpen.addServerPoints(false);
        usOpen.addServerPoints(false);
        usOpen.addServerPoints(true);
        usOpen.addServerPoints(false);      //deuce
        usOpen.addServerPoints(true);       //ad-in
        usOpen.addServerPoints(false);      //deuce
        usOpen.addServerPoints(false);
        usOpen.addServerPoints(false);       //Winner!




        usOpen.printAllPoints();











    }
}
