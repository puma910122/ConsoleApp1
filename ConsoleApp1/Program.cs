using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double meal_cost = 100;
            int tip_parcent = 15;
            int tax_parcent = 8;
            int meal_costint = (int)meal_cost;
            int sum = meal_costint + tip_parcent + tax_parcent;
            Console.WriteLine("totalcost:"+sum);

        }
    }
}
