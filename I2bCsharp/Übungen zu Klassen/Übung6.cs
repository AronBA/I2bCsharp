/*
class Program
{
    static void Main(string[] args)
    {
        int pay = Convert.ToInt32(Console.ReadLine());
        Payment pay1 = new Payment();
        pay1.PaymentValue = pay;
    }
}

class Payment
{
    private int paymentValue;
    //Vervollständige die Eigenschaft
    public int PaymentValue
    {
        get
        {
            return paymentValue;
        }
        set
        {
            if (value <= 5000)
            {
                paymentValue = value;
                Console.WriteLine("Accept");
            }
            else
            {
                Console.WriteLine("Fehler");
            }
        }
    }
}
*/