/*
namespace I2bCsharp.Übungen_zu_Klassen;

class Übung2
{
    static void Main(string[] args)
    {
        int games = Convert.ToInt32(Console.ReadLine()); 
        int wins = Convert.ToInt32(Console.ReadLine()); 

        //Kreiere das player Objekt
        Player player1 = new Player();
        player1.games = games;
        player1.wins = wins;

        //output
        Console.WriteLine(player1.GetWinRate());
        
    }
}

class Player
{
    public int games;
    public int wins;
    //winrate ist privat
    private int winrate;

    //vervollständige die Methode
    public int GetWinRate()
    {
        return wins * 100/games ;
    }
}
*/