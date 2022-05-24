/*
class Program
{
    static void Main(string[] args)
    {
        int numOfDeps = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (count < numOfDeps)
        {
            string depName = Console.ReadLine();
            Department dep = new Department(depName);
            count++;
        }

        Console.WriteLine("Nummer des Departementes: " + Department.depCount);
    }
}
class Department
{
    public static int depCount = 2;
    public string depName;
   

    public Department(string name)
    {
        Console.WriteLine("Department geöffnet: " + name);
        this.depName = name;
        depCount++;
    }
}
*/