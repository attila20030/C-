using Nyeroesvesztojatekos.Models;

class Program
{
    static void Main()
    {
        Jatekosok player1;

        try
        {
            player1 = new Jatekosok("Játékos Jani", "jatekos.jani@nyertes.hu", -10);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        player1 = new Jatekosok("Játékos Jani", "jatekos.jani@nyertes.hu", 50);
        Console.WriteLine(player1);

        player1.GetVictory(20);
        player1.GetVictory(30);
        Console.WriteLine($"Játékos Jani győzelmei: {player1.Gyozelmek}");
        player1.GetLose(40);
        Console.WriteLine(player1);
        Console.WriteLine($"Nyerő játékos-e? {player1.NyeresreAll()}");

        Jatekosok player2 = new Jatekosok("Játékos Béla", "jatekos.bela@vesztes.hu", 60);
        player2.GetVictory(10);
        player2.GetLose(20);
        player2.GetLose(30);
        Console.WriteLine(player2);
        Console.WriteLine($"Nyerő játékos-e? {player2.NyeresreAll()}");

        Jatekosok gyoztes = player1.Pontszam > player2.Pontszam ? player1 : player2;
        Console.WriteLine($"A győztes: {gyoztes.Nev}, pontszám: {gyoztes.Pontszam}");

        try
        {
            player1.GetLose(100);
            player1.GetVictory(10);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
