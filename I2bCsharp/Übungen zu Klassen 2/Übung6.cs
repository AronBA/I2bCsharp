/*
class Program
{
    static void Main(string[] args)
    {
        Score tm1 = new Score(2, 3);
        Score tm2 = new Score(4, 2);
        Score finalScores = tm1 + tm2;

        Console.WriteLine("Round 1: " + finalScores.round1Score);
        Console.WriteLine("Round 2: " + finalScores.round2Score);
    }
}
class Score
{
    public int round1Score { get; set; }
    public int round2Score { get; set; }
    public Score(int r1, int r2)
    {
        round1Score = r1;
        round2Score = r2;
    }
    
    public static Score operator+(Score tm1, Score tm2)
    {
       
        int round1Score = tm1.round1Score + tm2.round1Score;
        int round2Score = tm1.round2Score + tm2.round2Score;
        Score finalScores = new Score(round1Score,round2Score);
        return finalScores;
    }
}
*/