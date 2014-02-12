using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesCommissionCalculator
{
    class SalesCommissionCalculator
    {
        public double GrossSales { get; set; }

        public SalesCommissionCalculator(double sales)
        {
            GrossSales = sales;
        }

        public void Calculations(double sales)
        {            
            double totalSales = 0;
            double earnings = 0;
            const int SALARY = 200;
            const double PERCENTAGE = 0.09;               
            
            while (sales != -1)
            {
                totalSales += sales;
                earnings = SALARY + (totalSales * PERCENTAGE);
                Console.WriteLine("Weekly earnings: {0:F}", earnings);
                Console.WriteLine();

                Console.Write("Please input sales for the week or -1 to quit: ");
                sales = double.Parse(Console.ReadLine());
            }            
        }
    }
}
