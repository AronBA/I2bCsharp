/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I2bCsharp.Übungen_zu_Methoden
{
    internal class Übung5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aktuelles Budget: ");
            double budget = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Erhöhung in Prozent: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Neues Budget: " + calculate(budget, p));
        }
        static double calculate(double budget, double prozent)
        {
            budget = budget + (budget * prozent / 100);


            return budget;
        }
    }

}

*/