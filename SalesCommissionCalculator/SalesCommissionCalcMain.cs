using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesCommissionCalculator
{
    class SalesCommissionCalcMain
    {
        static void Main(string[] args)
        {            
            double grossSales = 0;

            SalesCommissionCalculator mySales = new SalesCommissionCalculator(
                grossSales);

            Console.Write("Please input sales for the week or -1 to quit: ");
            grossSales = double.Parse(Console.ReadLine());

            mySales.Calculations(grossSales);            
        }
    }
}
