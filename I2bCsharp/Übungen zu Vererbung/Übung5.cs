/*
class Programm
{
    static void Main(string[] args)
    {
        Figur Rechteck = new Rechteck(5, 6);
        Figur Dreieck = new Dreieck(4, 8, 3);

        Console.WriteLine(Rechteck.Perimiert());
        Console.WriteLine(Dreieck.Perimiert());
    }
}
abstract class Figur
{
    public abstract int Perimiert();

}
class Rechteck : Figur
{
    public int Breite;
    public int Höhe;
    public Rechteck(int Breite, int Höhe)
    {
        this.Breite = Breite;
        this.Höhe = Höhe;
    }

    public override int Perimiert()
    {
        return 2*(Höhe + Breite);
    }
}
class Dreieck : Figur
{
    public int side1;
    public int side2;
    public int side3;
    public Dreieck(int s1, int s2, int s3)
    {
        this.side1 = s1;
        this.side2 = s2;
        this.side3 = s3;
    }

    public override int Perimiert()
    {
        return side1 + side2 + side3;
    }
}
*/