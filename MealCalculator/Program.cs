using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealCost = 12.00;
            int tip = 20;
            int tax = 8;
            double tipPercent = (double)tip / 100;
            double taxPercent = (double)tax / 100;
            double totalMealCost;

            totalMealCost = (tipPercent * mealCost) + (taxPercent * mealCost) + mealCost;
            Console.WriteLine($"The total meal cost is {totalMealCost:0}");
            Console.ReadLine();
        }
    }
}
